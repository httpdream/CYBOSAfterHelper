namespace CYBOSAfterHour
{
    partial class CYBOSAfterHour
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.afterHourGridView = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.open = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.high = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.low = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.close = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changedP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Collect = new System.Windows.Forms.Button();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.toJSON = new System.Windows.Forms.Button();
            this.checkDataPush = new System.Windows.Forms.CheckBox();
            this.collectStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.afterHourGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // afterHourGridView
            // 
            this.afterHourGridView.AllowUserToAddRows = false;
            this.afterHourGridView.AllowUserToDeleteRows = false;
            this.afterHourGridView.AllowUserToResizeColumns = false;
            this.afterHourGridView.AllowUserToResizeRows = false;
            this.afterHourGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.afterHourGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.afterHourGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.afterHourGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.date,
            this.open,
            this.high,
            this.low,
            this.close,
            this.changed,
            this.changedP,
            this.volume});
            this.afterHourGridView.Location = new System.Drawing.Point(59, 178);
            this.afterHourGridView.Name = "afterHourGridView";
            this.afterHourGridView.RowHeadersWidth = 62;
            this.afterHourGridView.RowTemplate.Height = 30;
            this.afterHourGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.afterHourGridView.Size = new System.Drawing.Size(1195, 490);
            this.afterHourGridView.TabIndex = 0;
            // 
            // code
            // 
            this.code.DataPropertyName = "code";
            this.code.FillWeight = 70F;
            this.code.HeaderText = "종목코드";
            this.code.MinimumWidth = 8;
            this.code.Name = "code";
            this.code.Width = 150;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.FillWeight = 70F;
            this.date.HeaderText = "날짜";
            this.date.MinimumWidth = 8;
            this.date.Name = "date";
            this.date.Width = 150;
            // 
            // open
            // 
            this.open.DataPropertyName = "open";
            this.open.HeaderText = "시가";
            this.open.MinimumWidth = 8;
            this.open.Name = "open";
            this.open.Width = 60;
            // 
            // high
            // 
            this.high.DataPropertyName = "high";
            this.high.HeaderText = "고가";
            this.high.MinimumWidth = 8;
            this.high.Name = "high";
            this.high.ReadOnly = true;
            this.high.Width = 60;
            // 
            // low
            // 
            this.low.DataPropertyName = "low";
            this.low.HeaderText = "저가";
            this.low.MinimumWidth = 8;
            this.low.Name = "low";
            this.low.ReadOnly = true;
            this.low.Width = 60;
            // 
            // close
            // 
            this.close.DataPropertyName = "close";
            this.close.HeaderText = "종가";
            this.close.MinimumWidth = 8;
            this.close.Name = "close";
            this.close.ReadOnly = true;
            this.close.Width = 60;
            // 
            // changed
            // 
            this.changed.DataPropertyName = "changed";
            this.changed.HeaderText = "변화량";
            this.changed.MinimumWidth = 8;
            this.changed.Name = "changed";
            this.changed.ReadOnly = true;
            this.changed.Width = 80;
            // 
            // changedP
            // 
            this.changedP.DataPropertyName = "changedP";
            this.changedP.HeaderText = "변화율";
            this.changedP.MinimumWidth = 8;
            this.changedP.Name = "changedP";
            this.changedP.ReadOnly = true;
            this.changedP.Width = 80;
            // 
            // volume
            // 
            this.volume.DataPropertyName = "volume";
            this.volume.HeaderText = "거래량";
            this.volume.MinimumWidth = 8;
            this.volume.Name = "volume";
            this.volume.ReadOnly = true;
            this.volume.Width = 150;
            // 
            // stockId
            // 
            this.stockId.Location = new System.Drawing.Point(386, 56);
            this.stockId.Name = "stockId";
            this.stockId.Size = new System.Drawing.Size(250, 28);
            this.stockId.TabIndex = 1;
            this.stockId.Text = "005930";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "종목코드";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "수집날짜";
            // 
            // Collect
            // 
            this.Collect.Location = new System.Drawing.Point(677, 57);
            this.Collect.Name = "Collect";
            this.Collect.Size = new System.Drawing.Size(151, 67);
            this.Collect.TabIndex = 4;
            this.Collect.Text = "수집하기";
            this.Collect.UseVisualStyleBackColor = true;
            this.Collect.Click += new System.EventHandler(this.Collect_Click);
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(386, 96);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(250, 28);
            this.dateFrom.TabIndex = 5;
            this.dateFrom.Value = new System.DateTime(2021, 6, 1, 0, 0, 0, 0);
            // 
            // toJSON
            // 
            this.toJSON.Location = new System.Drawing.Point(875, 58);
            this.toJSON.Name = "toJSON";
            this.toJSON.Size = new System.Drawing.Size(142, 65);
            this.toJSON.TabIndex = 6;
            this.toJSON.Text = "toJSON File";
            this.toJSON.UseVisualStyleBackColor = true;
            this.toJSON.Click += new System.EventHandler(this.toJSON_Click);
            // 
            // checkDataPush
            // 
            this.checkDataPush.AutoSize = true;
            this.checkDataPush.Location = new System.Drawing.Point(284, 141);
            this.checkDataPush.Name = "checkDataPush";
            this.checkDataPush.Size = new System.Drawing.Size(130, 22);
            this.checkDataPush.TabIndex = 7;
            this.checkDataPush.Text = "데이터 추가";
            this.checkDataPush.UseVisualStyleBackColor = true;
            // 
            // collectStatus
            // 
            this.collectStatus.AutoSize = true;
            this.collectStatus.Location = new System.Drawing.Point(674, 145);
            this.collectStatus.Name = "collectStatus";
            this.collectStatus.Size = new System.Drawing.Size(0, 18);
            this.collectStatus.TabIndex = 8;
            // 
            // CYBOSAfterHour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 735);
            this.Controls.Add(this.collectStatus);
            this.Controls.Add(this.checkDataPush);
            this.Controls.Add(this.toJSON);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.Collect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stockId);
            this.Controls.Add(this.afterHourGridView);
            this.Name = "CYBOSAfterHour";
            this.Text = "시간외 데이터 수집기 by httpdream";
            ((System.ComponentModel.ISupportInitialize)(this.afterHourGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView afterHourGridView;
        private System.Windows.Forms.TextBox stockId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Collect;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Button toJSON;
        private System.Windows.Forms.CheckBox checkDataPush;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn open;
        private System.Windows.Forms.DataGridViewTextBoxColumn high;
        private System.Windows.Forms.DataGridViewTextBoxColumn low;
        private System.Windows.Forms.DataGridViewTextBoxColumn close;
        private System.Windows.Forms.DataGridViewTextBoxColumn changed;
        private System.Windows.Forms.DataGridViewTextBoxColumn changedP;
        private System.Windows.Forms.DataGridViewTextBoxColumn volume;
        private System.Windows.Forms.Label collectStatus;
    }
}

