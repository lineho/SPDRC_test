namespace SPDRC_PROGRAM
{
    partial class UserControl_TES_EPD
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.EPD_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv_1 = new System.Windows.Forms.DataGridView();
            this.o_label = new System.Windows.Forms.Label();
            this.co_label = new System.Windows.Forms.Label();
            this.checkedListBox_OESdataCollect = new System.Windows.Forms.CheckedListBox();
            this.btn_FileLoad = new System.Windows.Forms.Button();
            this.btn_FindEPD = new System.Windows.Forms.Button();
            this.groupBox_EPD = new System.Windows.Forms.GroupBox();
            this.groupBox_chooseWavelength = new System.Windows.Forms.GroupBox();
            this.cbBox_waveLength1 = new System.Windows.Forms.ComboBox();
            this.cbBox_waveLength2 = new System.Windows.Forms.ComboBox();
            this.listBox_EPD = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.EPD_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            this.groupBox_EPD.SuspendLayout();
            this.groupBox_chooseWavelength.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // EPD_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.EPD_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.EPD_chart.Legends.Add(legend1);
            this.EPD_chart.Location = new System.Drawing.Point(448, 308);
            this.EPD_chart.Name = "EPD_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.BorderWidth = 4;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            this.EPD_chart.Series.Add(series1);
            this.EPD_chart.Series.Add(series2);
            this.EPD_chart.Series.Add(series3);
            this.EPD_chart.Size = new System.Drawing.Size(714, 509);
            this.EPD_chart.TabIndex = 0;
            this.EPD_chart.Text = "chart1";
            this.EPD_chart.Click += new System.EventHandler(this.EPD_chart_Click_1);
            // 
            // dgv_1
            // 
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_1.Location = new System.Drawing.Point(22, 308);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.RowTemplate.Height = 23;
            this.dgv_1.Size = new System.Drawing.Size(420, 509);
            this.dgv_1.TabIndex = 1;
            // 
            // o_label
            // 
            this.o_label.AutoSize = true;
            this.o_label.Location = new System.Drawing.Point(39, 33);
            this.o_label.Name = "o_label";
            this.o_label.Size = new System.Drawing.Size(113, 12);
            this.o_label.TabIndex = 4;
            this.o_label.Text = "CO 560.041 , 560.11";
            this.o_label.Click += new System.EventHandler(this.o_label_Click);
            // 
            // co_label
            // 
            this.co_label.AutoSize = true;
            this.co_label.Location = new System.Drawing.Point(188, 32);
            this.co_label.Name = "co_label";
            this.co_label.Size = new System.Drawing.Size(110, 12);
            this.co_label.TabIndex = 5;
            this.co_label.Text = "O 777.042 , 777.013";
            // 
            // checkedListBox_OESdataCollect
            // 
            this.checkedListBox_OESdataCollect.FormattingEnabled = true;
            this.checkedListBox_OESdataCollect.Location = new System.Drawing.Point(22, 123);
            this.checkedListBox_OESdataCollect.Name = "checkedListBox_OESdataCollect";
            this.checkedListBox_OESdataCollect.Size = new System.Drawing.Size(925, 164);
            this.checkedListBox_OESdataCollect.TabIndex = 6;
            // 
            // btn_FileLoad
            // 
            this.btn_FileLoad.Location = new System.Drawing.Point(979, 124);
            this.btn_FileLoad.Name = "btn_FileLoad";
            this.btn_FileLoad.Size = new System.Drawing.Size(161, 31);
            this.btn_FileLoad.TabIndex = 7;
            this.btn_FileLoad.Text = "CSV 파일 불러오기";
            this.btn_FileLoad.UseVisualStyleBackColor = true;
            this.btn_FileLoad.Click += new System.EventHandler(this.btn_FileLoad_Click);
            // 
            // btn_FindEPD
            // 
            this.btn_FindEPD.Location = new System.Drawing.Point(23, 20);
            this.btn_FindEPD.Name = "btn_FindEPD";
            this.btn_FindEPD.Size = new System.Drawing.Size(155, 27);
            this.btn_FindEPD.TabIndex = 8;
            this.btn_FindEPD.Text = "EPD 찾기";
            this.btn_FindEPD.UseVisualStyleBackColor = true;
            this.btn_FindEPD.Click += new System.EventHandler(this.btn_FindEPD_Click);
            // 
            // groupBox_EPD
            // 
            this.groupBox_EPD.Controls.Add(this.listBox_EPD);
            this.groupBox_EPD.Controls.Add(this.btn_FindEPD);
            this.groupBox_EPD.Location = new System.Drawing.Point(962, 165);
            this.groupBox_EPD.Name = "groupBox_EPD";
            this.groupBox_EPD.Size = new System.Drawing.Size(200, 123);
            this.groupBox_EPD.TabIndex = 9;
            this.groupBox_EPD.TabStop = false;
            this.groupBox_EPD.Text = "EPD";
            // 
            // groupBox_chooseWavelength
            // 
            this.groupBox_chooseWavelength.Controls.Add(this.cbBox_waveLength1);
            this.groupBox_chooseWavelength.Controls.Add(this.cbBox_waveLength2);
            this.groupBox_chooseWavelength.Controls.Add(this.o_label);
            this.groupBox_chooseWavelength.Controls.Add(this.co_label);
            this.groupBox_chooseWavelength.Location = new System.Drawing.Point(22, 11);
            this.groupBox_chooseWavelength.Name = "groupBox_chooseWavelength";
            this.groupBox_chooseWavelength.Size = new System.Drawing.Size(332, 96);
            this.groupBox_chooseWavelength.TabIndex = 10;
            this.groupBox_chooseWavelength.TabStop = false;
            this.groupBox_chooseWavelength.Text = "파장 선택";
            // 
            // cbBox_waveLength1
            // 
            this.cbBox_waveLength1.FormattingEnabled = true;
            this.cbBox_waveLength1.Location = new System.Drawing.Point(31, 59);
            this.cbBox_waveLength1.Name = "cbBox_waveLength1";
            this.cbBox_waveLength1.Size = new System.Drawing.Size(121, 20);
            this.cbBox_waveLength1.TabIndex = 8;
            this.cbBox_waveLength1.SelectedIndexChanged += new System.EventHandler(this.cbBox_waveLength1_SelectedIndexChanged);
            // 
            // cbBox_waveLength2
            // 
            this.cbBox_waveLength2.FormattingEnabled = true;
            this.cbBox_waveLength2.Location = new System.Drawing.Point(185, 59);
            this.cbBox_waveLength2.Name = "cbBox_waveLength2";
            this.cbBox_waveLength2.Size = new System.Drawing.Size(121, 20);
            this.cbBox_waveLength2.TabIndex = 7;
            this.cbBox_waveLength2.SelectedIndexChanged += new System.EventHandler(this.cbBox_waveLength2_SelectedIndexChanged);
            // 
            // listBox_EPD
            // 
            this.listBox_EPD.FormattingEnabled = true;
            this.listBox_EPD.ItemHeight = 12;
            this.listBox_EPD.Location = new System.Drawing.Point(23, 53);
            this.listBox_EPD.Name = "listBox_EPD";
            this.listBox_EPD.Size = new System.Drawing.Size(155, 64);
            this.listBox_EPD.TabIndex = 11;
            this.listBox_EPD.SelectedIndexChanged += new System.EventHandler(this.listBox_EPD_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(962, 711);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(8, 8);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // UserControl_TES_EPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox_chooseWavelength);
            this.Controls.Add(this.groupBox_EPD);
            this.Controls.Add(this.btn_FileLoad);
            this.Controls.Add(this.checkedListBox_OESdataCollect);
            this.Controls.Add(this.dgv_1);
            this.Controls.Add(this.EPD_chart);
            this.Name = "UserControl_TES_EPD";
            this.Size = new System.Drawing.Size(1181, 835);
            ((System.ComponentModel.ISupportInitialize)(this.EPD_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            this.groupBox_EPD.ResumeLayout(false);
            this.groupBox_chooseWavelength.ResumeLayout(false);
            this.groupBox_chooseWavelength.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart EPD_chart;
        private System.Windows.Forms.DataGridView dgv_1;
        private System.Windows.Forms.Label o_label;
        private System.Windows.Forms.Label co_label;
        private System.Windows.Forms.CheckedListBox checkedListBox_OESdataCollect;
        private System.Windows.Forms.Button btn_FileLoad;
        private System.Windows.Forms.Button btn_FindEPD;
        private System.Windows.Forms.GroupBox groupBox_EPD;
        private System.Windows.Forms.GroupBox groupBox_chooseWavelength;
        private System.Windows.Forms.ComboBox cbBox_waveLength2;
        private System.Windows.Forms.ComboBox cbBox_waveLength1;
        private System.Windows.Forms.ListBox listBox_EPD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
