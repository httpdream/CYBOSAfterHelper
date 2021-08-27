using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Threading;

namespace CYBOSAfterHour
{
    public partial class CYBOSAfterHour : Form
    {
        CPSYSDIBLib.StockUniWeek stockUniWeek;
        CPUTILLib.CpCybos Cybos;
        List<AfterHourData> afterHourDatas = new List<AfterHourData>();
        BindingSource bindingSource = new BindingSource();
        BindingList<AfterHourData> bindingList;
        bool collect = false;
        public CYBOSAfterHour()
        {
            InitializeComponent();
            this.stockUniWeek = new CPSYSDIBLib.StockUniWeek();
            this.Cybos = new CPUTILLib.CpCybos();
            if (this.Cybos.IsConnect == 0)
            {
                MessageBox.Show("연결실패");
                Application.Exit();
            }
        }

        private void Collect_Click(object sender, EventArgs e)
        {
            if (collect)
            {
                return;
            }

            collect = true;
            Collect.Enabled = false;
            if (!checkDataPush.Checked)
            {
                this.afterHourDatas.Clear();
            }

            string[] codes = stockId.Text.Split(';');
            for (int i = 0; i < codes.Length; i++)
            {
                string code = codes[i];
                this.stockUniWeek.SetInputValue(0, "A" + code);

                int from = int.Parse(dateFrom.Value.ToString("yyyyMMdd"));
                UInt32 current = 20210827;

                while (current >= from)
                {
                    stockUniWeek.BlockRequest();

                    short length = (short)this.stockUniWeek.GetHeaderValue(1);
                    current = (UInt32)stockUniWeek.GetDataValue(0, 0);
                    
                    for (int j = 0; j < length; j++)
                    {
                        UInt32 date = (UInt32)stockUniWeek.GetDataValue(0, j);
                        UInt32 open = (UInt32)stockUniWeek.GetDataValue(1, j);
                        UInt32 high = (UInt32)stockUniWeek.GetDataValue(2, j);
                        UInt32 low = (UInt32)stockUniWeek.GetDataValue(3, j);
                        UInt32 close = (UInt32)stockUniWeek.GetDataValue(4, j);
                        UInt32 uchanged = (UInt32)stockUniWeek.GetDataValue(5, j);
                        double changedP = (double)stockUniWeek.GetDataValue(6, j);
                        UInt32 volume = (UInt32)stockUniWeek.GetDataValue(8, j);

                        int changed = (int)uchanged;
                        if (changedP < 0)
                        {
                            changed *= -1;
                        }

                        if (date >= from)
                        {
                            afterHourDatas.Add(new AfterHourData(code, (int)date, (int)open, (int)high, (int)low, (int)close, changed, changedP, (int)volume));
                        }
                    }

                    if (length < 32)
                    {
                        break;
                    }
                }

                Thread.Sleep(200);
                collectStatus.Text = string.Format("데이터 수집중.. {0}/{1}", i + 1, codes.Length);
            }

            this.bindingList = new BindingList<AfterHourData>(afterHourDatas);
            bindingSource.DataSource = this.bindingList;
            this.afterHourGridView.DataSource = bindingSource;

            collect = false;
            Collect.Enabled = true;

            collectStatus.Text = "데이터 수집 완료!";
        }

        private void toJSON_Click(object sender, EventArgs e)
        {
            var codes = this.afterHourDatas.ConvertAll(data => data.code);
            foreach (string code in codes)
            {
                var data = this.afterHourDatas.FindAll(val => val.code == code);
                data.Reverse();
                StreamWriter conditionWriter = new StreamWriter(string.Format("{0}.json", code));
                conditionWriter.Write(JsonConvert.SerializeObject(data));
                conditionWriter.Close();
            }

            MessageBox.Show("저장완료!");
        }
    }

    class AfterHourData
    {
        public string code { get; set; }
        public int date { get; set; }
        public int open { get; set; }
        public int high { get; set; }
        public int low { get; set; }
        public int close { get; set; }
        public int changed { get; set; }
        public double changedP { get; set; }
        public int volume { get; set; }

        public AfterHourData(string code, int date, int open, int high, int low, int close, int changed, double changedP, int volume)
        {
            this.code = code;
            this.date = date;
            this.open = open;
            this.high = high;
            this.low = low;
            this.close = close;
            this.changed = changed;
            this.changedP = changedP;
            this.volume = volume;
        }
    }
}
