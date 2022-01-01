namespace YearCalculator
{
    partial class Main
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
            this.monthSelect_cb = new System.Windows.Forms.ComboBox();
            this.dateSelect_cb = new System.Windows.Forms.ComboBox();
            this.description_lb = new System.Windows.Forms.Label();
            this.month_lb = new System.Windows.Forms.Label();
            this.minYear_tb = new System.Windows.Forms.TextBox();
            this.date_lb = new System.Windows.Forms.Label();
            this.minYear_lb = new System.Windows.Forms.Label();
            this.maxYear_lb = new System.Windows.Forms.Label();
            this.maxYear_tb = new System.Windows.Forms.TextBox();
            this.day_lb = new System.Windows.Forms.Label();
            this.daySelect_cb = new System.Windows.Forms.ComboBox();
            this.yearList_lb = new System.Windows.Forms.ListBox();
            this.reset_bt = new System.Windows.Forms.Button();
            this.calculate_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthSelect_cb
            // 
            this.monthSelect_cb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.monthSelect_cb.FormattingEnabled = true;
            this.monthSelect_cb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.monthSelect_cb.Location = new System.Drawing.Point(14, 30);
            this.monthSelect_cb.Name = "monthSelect_cb";
            this.monthSelect_cb.Size = new System.Drawing.Size(50, 22);
            this.monthSelect_cb.TabIndex = 0;
            this.monthSelect_cb.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxDrawItem);
            this.monthSelect_cb.Validating += new System.ComponentModel.CancelEventHandler(this.validateMonth);
            // 
            // dateSelect_cb
            // 
            this.dateSelect_cb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dateSelect_cb.FormattingEnabled = true;
            this.dateSelect_cb.IntegralHeight = false;
            this.dateSelect_cb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dateSelect_cb.Location = new System.Drawing.Point(93, 30);
            this.dateSelect_cb.MaxDropDownItems = 10;
            this.dateSelect_cb.Name = "dateSelect_cb";
            this.dateSelect_cb.Size = new System.Drawing.Size(50, 22);
            this.dateSelect_cb.TabIndex = 1;
            this.dateSelect_cb.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxDrawItem);
            this.dateSelect_cb.Validating += new System.ComponentModel.CancelEventHandler(this.validateDate);
            // 
            // description_lb
            // 
            this.description_lb.AutoSize = true;
            this.description_lb.Location = new System.Drawing.Point(12, 9);
            this.description_lb.Name = "description_lb";
            this.description_lb.Size = new System.Drawing.Size(329, 12);
            this.description_lb.TabIndex = 19;
            this.description_lb.Text = "주어진 월, 일과 요일을 기반으로 가능한 연도를 계산합니다.";
            // 
            // month_lb
            // 
            this.month_lb.AutoSize = true;
            this.month_lb.Location = new System.Drawing.Point(70, 33);
            this.month_lb.Name = "month_lb";
            this.month_lb.Size = new System.Drawing.Size(17, 12);
            this.month_lb.TabIndex = 18;
            this.month_lb.Text = "월";
            // 
            // minYear_tb
            // 
            this.minYear_tb.Location = new System.Drawing.Point(75, 56);
            this.minYear_tb.Name = "minYear_tb";
            this.minYear_tb.Size = new System.Drawing.Size(50, 21);
            this.minYear_tb.TabIndex = 3;
            this.minYear_tb.Text = "1582";
            this.minYear_tb.Validating += new System.ComponentModel.CancelEventHandler(this.validateMinYear);
            // 
            // date_lb
            // 
            this.date_lb.AutoSize = true;
            this.date_lb.Location = new System.Drawing.Point(149, 33);
            this.date_lb.Name = "date_lb";
            this.date_lb.Size = new System.Drawing.Size(17, 12);
            this.date_lb.TabIndex = 17;
            this.date_lb.Text = "일";
            // 
            // minYear_lb
            // 
            this.minYear_lb.AutoSize = true;
            this.minYear_lb.Location = new System.Drawing.Point(12, 59);
            this.minYear_lb.Name = "minYear_lb";
            this.minYear_lb.Size = new System.Drawing.Size(57, 12);
            this.minYear_lb.TabIndex = 16;
            this.minYear_lb.Text = "최소 연도";
            // 
            // maxYear_lb
            // 
            this.maxYear_lb.AutoSize = true;
            this.maxYear_lb.Location = new System.Drawing.Point(131, 59);
            this.maxYear_lb.Name = "maxYear_lb";
            this.maxYear_lb.Size = new System.Drawing.Size(57, 12);
            this.maxYear_lb.TabIndex = 15;
            this.maxYear_lb.Text = "최대 연도";
            // 
            // maxYear_tb
            // 
            this.maxYear_tb.Location = new System.Drawing.Point(194, 56);
            this.maxYear_tb.Name = "maxYear_tb";
            this.maxYear_tb.Size = new System.Drawing.Size(50, 21);
            this.maxYear_tb.TabIndex = 4;
            this.maxYear_tb.Text = "3000";
            this.maxYear_tb.Validating += new System.ComponentModel.CancelEventHandler(this.validateMaxYear);
            // 
            // day_lb
            // 
            this.day_lb.AutoSize = true;
            this.day_lb.Location = new System.Drawing.Point(218, 33);
            this.day_lb.Name = "day_lb";
            this.day_lb.Size = new System.Drawing.Size(29, 12);
            this.day_lb.TabIndex = 14;
            this.day_lb.Text = "요일";
            // 
            // daySelect_cb
            // 
            this.daySelect_cb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.daySelect_cb.FormattingEnabled = true;
            this.daySelect_cb.Items.AddRange(new object[] {
            "월",
            "화",
            "수",
            "목",
            "금",
            "토",
            "일"});
            this.daySelect_cb.Location = new System.Drawing.Point(172, 30);
            this.daySelect_cb.Name = "daySelect_cb";
            this.daySelect_cb.Size = new System.Drawing.Size(40, 22);
            this.daySelect_cb.TabIndex = 2;
            this.daySelect_cb.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxDrawItem);
            this.daySelect_cb.Validating += new System.ComponentModel.CancelEventHandler(this.validateDay);
            // 
            // yearList_lb
            // 
            this.yearList_lb.FormattingEnabled = true;
            this.yearList_lb.ItemHeight = 12;
            this.yearList_lb.Location = new System.Drawing.Point(12, 83);
            this.yearList_lb.Name = "yearList_lb";
            this.yearList_lb.Size = new System.Drawing.Size(329, 316);
            this.yearList_lb.TabIndex = 6;
            // 
            // reset_bt
            // 
            this.reset_bt.Location = new System.Drawing.Point(185, 415);
            this.reset_bt.Name = "reset_bt";
            this.reset_bt.Size = new System.Drawing.Size(75, 23);
            this.reset_bt.TabIndex = 7;
            this.reset_bt.Text = "초기화";
            this.reset_bt.UseVisualStyleBackColor = true;
            this.reset_bt.Click += new System.EventHandler(this.initialize);
            // 
            // calculate_bt
            // 
            this.calculate_bt.Location = new System.Drawing.Point(266, 415);
            this.calculate_bt.Name = "calculate_bt";
            this.calculate_bt.Size = new System.Drawing.Size(75, 23);
            this.calculate_bt.TabIndex = 5;
            this.calculate_bt.Text = "계산하기";
            this.calculate_bt.UseVisualStyleBackColor = true;
            this.calculate_bt.Click += new System.EventHandler(this.calculate);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 450);
            this.Controls.Add(this.calculate_bt);
            this.Controls.Add(this.reset_bt);
            this.Controls.Add(this.yearList_lb);
            this.Controls.Add(this.daySelect_cb);
            this.Controls.Add(this.day_lb);
            this.Controls.Add(this.maxYear_tb);
            this.Controls.Add(this.maxYear_lb);
            this.Controls.Add(this.minYear_lb);
            this.Controls.Add(this.date_lb);
            this.Controls.Add(this.minYear_tb);
            this.Controls.Add(this.month_lb);
            this.Controls.Add(this.description_lb);
            this.Controls.Add(this.dateSelect_cb);
            this.Controls.Add(this.monthSelect_cb);
            this.Icon = global::YearCalculator.Properties.Resources.calculator;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "연도 계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox monthSelect_cb;
        private System.Windows.Forms.ComboBox dateSelect_cb;
        private System.Windows.Forms.Label description_lb;
        private System.Windows.Forms.Label month_lb;
        private System.Windows.Forms.TextBox minYear_tb;
        private System.Windows.Forms.Label date_lb;
        private System.Windows.Forms.Label minYear_lb;
        private System.Windows.Forms.Label maxYear_lb;
        private System.Windows.Forms.TextBox maxYear_tb;
        private System.Windows.Forms.Label day_lb;
        private System.Windows.Forms.ComboBox daySelect_cb;
        private System.Windows.Forms.ListBox yearList_lb;
        private System.Windows.Forms.Button reset_bt;
        private System.Windows.Forms.Button calculate_bt;
    }
}

