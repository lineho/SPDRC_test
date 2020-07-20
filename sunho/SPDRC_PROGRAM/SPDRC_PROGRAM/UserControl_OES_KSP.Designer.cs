namespace SPDRC_PROGRAM
{
    partial class UserControl_OES_KSP
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.checkedListBox_OESdataCollect = new System.Windows.Forms.CheckedListBox();
            this.btn_Fileload = new System.Windows.Forms.Button();
            this.lineRatioGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbBox_waveLength1 = new System.Windows.Forms.ComboBox();
            this.cbBox_waveLength2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_drawGraph = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dgv_1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lineRatioGraph2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lineRatioGraph3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lineRatioGraph4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.lineRatioGraph)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineRatioGraph2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineRatioGraph3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineRatioGraph4)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox_OESdataCollect
            // 
            this.checkedListBox_OESdataCollect.CheckOnClick = true;
            this.checkedListBox_OESdataCollect.FormattingEnabled = true;
            this.checkedListBox_OESdataCollect.Location = new System.Drawing.Point(29, 188);
            this.checkedListBox_OESdataCollect.Name = "checkedListBox_OESdataCollect";
            this.checkedListBox_OESdataCollect.Size = new System.Drawing.Size(779, 132);
            this.checkedListBox_OESdataCollect.TabIndex = 0;
            this.checkedListBox_OESdataCollect.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_OESdataCollect_SelectedIndexChanged);
            // 
            // btn_Fileload
            // 
            this.btn_Fileload.Location = new System.Drawing.Point(836, 209);
            this.btn_Fileload.Name = "btn_Fileload";
            this.btn_Fileload.Size = new System.Drawing.Size(132, 43);
            this.btn_Fileload.TabIndex = 1;
            this.btn_Fileload.Text = "OES 파일 불러오기";
            this.btn_Fileload.UseVisualStyleBackColor = true;
            this.btn_Fileload.Click += new System.EventHandler(this.btn_Fileload_Click);
            // 
            // lineRatioGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.lineRatioGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.lineRatioGraph.Legends.Add(legend1);
            this.lineRatioGraph.Location = new System.Drawing.Point(27, 6);
            this.lineRatioGraph.Name = "lineRatioGraph";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.lineRatioGraph.Series.Add(series1);
            this.lineRatioGraph.Size = new System.Drawing.Size(746, 453);
            this.lineRatioGraph.TabIndex = 3;
            this.lineRatioGraph.Text = "chart1";
            this.lineRatioGraph.Click += new System.EventHandler(this.lineRatioGraph_Click);
            // 
            // cbBox_waveLength1
            // 
            this.cbBox_waveLength1.FormattingEnabled = true;
            this.cbBox_waveLength1.Location = new System.Drawing.Point(161, 124);
            this.cbBox_waveLength1.Name = "cbBox_waveLength1";
            this.cbBox_waveLength1.Size = new System.Drawing.Size(121, 20);
            this.cbBox_waveLength1.TabIndex = 4;
            this.cbBox_waveLength1.SelectedIndexChanged += new System.EventHandler(this.cbBox_waveLength1_SelectedIndexChanged);
            // 
            // cbBox_waveLength2
            // 
            this.cbBox_waveLength2.FormattingEnabled = true;
            this.cbBox_waveLength2.Location = new System.Drawing.Point(288, 124);
            this.cbBox_waveLength2.Name = "cbBox_waveLength2";
            this.cbBox_waveLength2.Size = new System.Drawing.Size(121, 20);
            this.cbBox_waveLength2.TabIndex = 5;
            this.cbBox_waveLength2.SelectedIndexChanged += new System.EventHandler(this.cbBox_waveLength2_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.cbBox_waveLength1);
            this.groupBox1.Controls.Add(this.cbBox_waveLength2);
            this.groupBox1.Location = new System.Drawing.Point(29, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 150);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "파장 선택";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "파장 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "파장 1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SPDRC_PROGRAM.Properties.Resources.전자온도_관련_식;
            this.pictureBox1.Location = new System.Drawing.Point(27, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 75);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_drawGraph
            // 
            this.btn_drawGraph.Location = new System.Drawing.Point(836, 260);
            this.btn_drawGraph.Name = "btn_drawGraph";
            this.btn_drawGraph.Size = new System.Drawing.Size(132, 40);
            this.btn_drawGraph.TabIndex = 7;
            this.btn_drawGraph.Text = "그래프로 나타내기\r\n";
            this.btn_drawGraph.UseVisualStyleBackColor = true;
            this.btn_drawGraph.Click += new System.EventHandler(this.btn_drawGraph_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 838);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // dgv_1
            // 
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_1.Location = new System.Drawing.Point(29, 344);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.RowTemplate.Height = 23;
            this.dgv_1.Size = new System.Drawing.Size(427, 473);
            this.dgv_1.TabIndex = 2;
            this.dgv_1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_1_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(462, 326);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 491);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lineRatioGraph);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lineRatioGraph2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lineRatioGraph2
            // 
            chartArea2.Name = "ChartArea1";
            this.lineRatioGraph2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.lineRatioGraph2.Legends.Add(legend2);
            this.lineRatioGraph2.Location = new System.Drawing.Point(18, 16);
            this.lineRatioGraph2.Name = "lineRatioGraph2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.lineRatioGraph2.Series.Add(series2);
            this.lineRatioGraph2.Size = new System.Drawing.Size(754, 434);
            this.lineRatioGraph2.TabIndex = 0;
            this.lineRatioGraph2.Text = "chart2";
            this.lineRatioGraph2.Click += new System.EventHandler(this.lineRatioGraph2_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lineRatioGraph3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(790, 465);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lineRatioGraph3
            // 
            chartArea3.Name = "ChartArea1";
            this.lineRatioGraph3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.lineRatioGraph3.Legends.Add(legend3);
            this.lineRatioGraph3.Location = new System.Drawing.Point(15, 15);
            this.lineRatioGraph3.Name = "lineRatioGraph3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.lineRatioGraph3.Series.Add(series3);
            this.lineRatioGraph3.Size = new System.Drawing.Size(755, 431);
            this.lineRatioGraph3.TabIndex = 0;
            this.lineRatioGraph3.Text = "chart3";
            this.lineRatioGraph3.Click += new System.EventHandler(this.lineRatioGraph3_Click_1);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lineRatioGraph4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(790, 465);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lineRatioGraph4
            // 
            chartArea4.Name = "ChartArea1";
            this.lineRatioGraph4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.lineRatioGraph4.Legends.Add(legend4);
            this.lineRatioGraph4.Location = new System.Drawing.Point(16, 15);
            this.lineRatioGraph4.Name = "lineRatioGraph4";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.lineRatioGraph4.Series.Add(series4);
            this.lineRatioGraph4.Size = new System.Drawing.Size(757, 433);
            this.lineRatioGraph4.TabIndex = 0;
            this.lineRatioGraph4.Text = "chart4";
            this.lineRatioGraph4.Click += new System.EventHandler(this.lineRatioGraph4_Click_1);
            // 
            // UserControl_OES_KSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btn_drawGraph);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_1);
            this.Controls.Add(this.btn_Fileload);
            this.Controls.Add(this.checkedListBox_OESdataCollect);
            this.Name = "UserControl_OES_KSP";
            this.Size = new System.Drawing.Size(1274, 838);
            this.Load += new System.EventHandler(this.UserControl_OES_KSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lineRatioGraph)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lineRatioGraph2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lineRatioGraph3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lineRatioGraph4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox_OESdataCollect;
        private System.Windows.Forms.Button btn_Fileload;
        private System.Windows.Forms.DataVisualization.Charting.Chart lineRatioGraph;
        private System.Windows.Forms.ComboBox cbBox_waveLength1;
        private System.Windows.Forms.ComboBox cbBox_waveLength2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_drawGraph;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dgv_1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart lineRatioGraph2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart lineRatioGraph3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart lineRatioGraph4;
    }
}
