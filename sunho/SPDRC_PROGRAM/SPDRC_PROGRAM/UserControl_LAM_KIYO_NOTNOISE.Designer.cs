﻿namespace SPDRC_PROGRAM
{
    partial class UserControl_LAM_KIYO_NOTNOISE
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grpB_fileLoad = new System.Windows.Forms.GroupBox();
            this.btn_aFileLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_RowColChange = new System.Windows.Forms.CheckBox();
            this.btn_RowColChange = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_RangeSelectFinished = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbB_700Finish = new System.Windows.Forms.ComboBox();
            this.cbB_700Start = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbB_300Finish = new System.Windows.Forms.ComboBox();
            this.cbB_300Start = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbB_400Finish = new System.Windows.Forms.ComboBox();
            this.cbB_400Start = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_700 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_400 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_300 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lineRatioGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_cal = new System.Windows.Forms.Button();
            this.cbB_700Real = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbB_300Real = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cbB_400Real = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_transpose = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_A = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_selected = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgv_result = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn_DeleteRow = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ckB_Ne = new System.Windows.Forms.CheckBox();
            this.ckB_Te = new System.Windows.Forms.CheckBox();
            this.btn_GraphTimeSelect = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.cbB_timeFinish = new System.Windows.Forms.ComboBox();
            this.cbB_timeStart = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.노이즈제거파일선택 = new System.Windows.Forms.GroupBox();
            this.btn_noiseFileLoad = new System.Windows.Forms.Button();
            this.btn_DeleteNoise = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dgv_noise = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dgv_aMinusNoise = new System.Windows.Forms.DataGridView();
            this.grpB_fileLoad.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineRatioGraph)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transpose)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_A)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selected)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.노이즈제거파일선택.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_noise)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aMinusNoise)).BeginInit();
            this.SuspendLayout();
            // 
            // grpB_fileLoad
            // 
            this.grpB_fileLoad.Controls.Add(this.btn_aFileLoad);
            this.grpB_fileLoad.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grpB_fileLoad.Location = new System.Drawing.Point(985, 18);
            this.grpB_fileLoad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpB_fileLoad.Name = "grpB_fileLoad";
            this.grpB_fileLoad.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpB_fileLoad.Size = new System.Drawing.Size(208, 55);
            this.grpB_fileLoad.TabIndex = 18;
            this.grpB_fileLoad.TabStop = false;
            this.grpB_fileLoad.Text = "파일 불러오기(1)";
            // 
            // btn_aFileLoad
            // 
            this.btn_aFileLoad.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_aFileLoad.Location = new System.Drawing.Point(6, 20);
            this.btn_aFileLoad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_aFileLoad.Name = "btn_aFileLoad";
            this.btn_aFileLoad.Size = new System.Drawing.Size(196, 27);
            this.btn_aFileLoad.TabIndex = 3;
            this.btn_aFileLoad.Text = "Xlsx 파일 불러오기";
            this.btn_aFileLoad.UseVisualStyleBackColor = true;
            this.btn_aFileLoad.Click += new System.EventHandler(this.btn_aFileLoad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_RowColChange);
            this.groupBox1.Controls.Add(this.btn_RowColChange);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(982, 242);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(208, 77);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "행/열 변환(4)";
            // 
            // cb_RowColChange
            // 
            this.cb_RowColChange.AutoSize = true;
            this.cb_RowColChange.Location = new System.Drawing.Point(23, 21);
            this.cb_RowColChange.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cb_RowColChange.Name = "cb_RowColChange";
            this.cb_RowColChange.Size = new System.Drawing.Size(163, 16);
            this.cb_RowColChange.TabIndex = 5;
            this.cb_RowColChange.Text = "체크시 행/열 변환 가능";
            this.cb_RowColChange.UseVisualStyleBackColor = true;
            this.cb_RowColChange.CheckedChanged += new System.EventHandler(this.cb_RowColChange_CheckedChanged);
            // 
            // btn_RowColChange
            // 
            this.btn_RowColChange.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_RowColChange.Location = new System.Drawing.Point(7, 43);
            this.btn_RowColChange.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_RowColChange.Name = "btn_RowColChange";
            this.btn_RowColChange.Size = new System.Drawing.Size(196, 27);
            this.btn_RowColChange.TabIndex = 3;
            this.btn_RowColChange.Text = "A 파일 행/열 변환";
            this.btn_RowColChange.UseVisualStyleBackColor = true;
            this.btn_RowColChange.Click += new System.EventHandler(this.btn_RowColChange_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_RangeSelectFinished);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbB_700Finish);
            this.groupBox2.Controls.Add(this.cbB_700Start);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbB_300Finish);
            this.groupBox2.Controls.Add(this.cbB_300Start);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbB_400Finish);
            this.groupBox2.Controls.Add(this.cbB_400Start);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(985, 314);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(208, 199);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "파장 범위 선택(5)";
            // 
            // btn_RangeSelectFinished
            // 
            this.btn_RangeSelectFinished.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_RangeSelectFinished.Location = new System.Drawing.Point(6, 147);
            this.btn_RangeSelectFinished.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_RangeSelectFinished.Name = "btn_RangeSelectFinished";
            this.btn_RangeSelectFinished.Size = new System.Drawing.Size(196, 27);
            this.btn_RangeSelectFinished.TabIndex = 6;
            this.btn_RangeSelectFinished.Text = "파장범위 선택 완료";
            this.btn_RangeSelectFinished.UseVisualStyleBackColor = true;
            this.btn_RangeSelectFinished.Click += new System.EventHandler(this.btn_RangeSelectFinished_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(5, 181);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 11);
            this.label8.TabIndex = 17;
            this.label8.Text = "파장 범위 체크 후 완료 클릭 필수!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(96, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "~";
            // 
            // cbB_700Finish
            // 
            this.cbB_700Finish.FormattingEnabled = true;
            this.cbB_700Finish.Location = new System.Drawing.Point(114, 120);
            this.cbB_700Finish.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbB_700Finish.Name = "cbB_700Finish";
            this.cbB_700Finish.Size = new System.Drawing.Size(90, 20);
            this.cbB_700Finish.TabIndex = 15;
            this.cbB_700Finish.SelectedIndexChanged += new System.EventHandler(this.cbB_700Finish_SelectedIndexChanged);
            // 
            // cbB_700Start
            // 
            this.cbB_700Start.FormattingEnabled = true;
            this.cbB_700Start.Location = new System.Drawing.Point(5, 120);
            this.cbB_700Start.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbB_700Start.Name = "cbB_700Start";
            this.cbB_700Start.Size = new System.Drawing.Size(90, 20);
            this.cbB_700Start.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "3차 파장 범위(700대)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(96, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "~";
            // 
            // cbB_300Finish
            // 
            this.cbB_300Finish.FormattingEnabled = true;
            this.cbB_300Finish.Location = new System.Drawing.Point(114, 36);
            this.cbB_300Finish.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbB_300Finish.Name = "cbB_300Finish";
            this.cbB_300Finish.Size = new System.Drawing.Size(90, 20);
            this.cbB_300Finish.TabIndex = 11;
            this.cbB_300Finish.SelectedIndexChanged += new System.EventHandler(this.cbB_300Finish_SelectedIndexChanged);
            // 
            // cbB_300Start
            // 
            this.cbB_300Start.FormattingEnabled = true;
            this.cbB_300Start.Location = new System.Drawing.Point(5, 36);
            this.cbB_300Start.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbB_300Start.Name = "cbB_300Start";
            this.cbB_300Start.Size = new System.Drawing.Size(90, 20);
            this.cbB_300Start.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "1차 파장 범위(300대)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(96, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "~";
            // 
            // cbB_400Finish
            // 
            this.cbB_400Finish.FormattingEnabled = true;
            this.cbB_400Finish.Location = new System.Drawing.Point(114, 81);
            this.cbB_400Finish.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbB_400Finish.Name = "cbB_400Finish";
            this.cbB_400Finish.Size = new System.Drawing.Size(90, 20);
            this.cbB_400Finish.TabIndex = 7;
            this.cbB_400Finish.SelectedIndexChanged += new System.EventHandler(this.cbB_400Finish_SelectedIndexChanged);
            // 
            // cbB_400Start
            // 
            this.cbB_400Start.FormattingEnabled = true;
            this.cbB_400Start.Location = new System.Drawing.Point(5, 81);
            this.cbB_400Start.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbB_400Start.Name = "cbB_400Start";
            this.cbB_400Start.Size = new System.Drawing.Size(90, 20);
            this.cbB_400Start.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "2차 파장 범위(400대)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(983, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "번호 순서대로 진행하여 주십시오.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_700);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.lbl_400);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.lbl_300);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(985, 516);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(208, 127);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "가장 큰 Intensity 가진 열 확인";
            // 
            // lbl_700
            // 
            this.lbl_700.AutoSize = true;
            this.lbl_700.ForeColor = System.Drawing.Color.Blue;
            this.lbl_700.Location = new System.Drawing.Point(128, 104);
            this.lbl_700.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_700.Name = "lbl_700";
            this.lbl_700.Size = new System.Drawing.Size(49, 11);
            this.lbl_700.TabIndex = 29;
            this.lbl_700.Text = "lbl_700";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 105);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 11);
            this.label17.TabIndex = 28;
            this.label17.Text = "- 1차 파장 열 추천: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 89);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(125, 11);
            this.label18.TabIndex = 27;
            this.label18.Text = "3차 파장 범위(700대)";
            // 
            // lbl_400
            // 
            this.lbl_400.AutoSize = true;
            this.lbl_400.ForeColor = System.Drawing.Color.Blue;
            this.lbl_400.Location = new System.Drawing.Point(128, 70);
            this.lbl_400.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_400.Name = "lbl_400";
            this.lbl_400.Size = new System.Drawing.Size(49, 11);
            this.lbl_400.TabIndex = 26;
            this.lbl_400.Text = "lbl_400";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 71);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 11);
            this.label14.TabIndex = 25;
            this.label14.Text = "- 1차 파장 열 추천: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 55);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 11);
            this.label15.TabIndex = 24;
            this.label15.Text = "2차 파장 범위(400대)";
            // 
            // lbl_300
            // 
            this.lbl_300.AutoSize = true;
            this.lbl_300.ForeColor = System.Drawing.Color.Blue;
            this.lbl_300.Location = new System.Drawing.Point(128, 36);
            this.lbl_300.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_300.Name = "lbl_300";
            this.lbl_300.Size = new System.Drawing.Size(49, 11);
            this.lbl_300.TabIndex = 23;
            this.lbl_300.Text = "lbl_300";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 37);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 11);
            this.label13.TabIndex = 22;
            this.label13.Text = "- 1차 파장 열 추천: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(184, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 11);
            this.label12.TabIndex = 21;
            this.label12.Text = "(6)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 11);
            this.label10.TabIndex = 19;
            this.label10.Text = "1차 파장 범위(300대)";
            // 
            // lineRatioGraph
            // 
            this.lineRatioGraph.AccessibleDescription = "ph";
            chartArea2.Name = "ChartArea1";
            this.lineRatioGraph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.lineRatioGraph.Legends.Add(legend2);
            this.lineRatioGraph.Location = new System.Drawing.Point(5, 9);
            this.lineRatioGraph.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lineRatioGraph.Name = "lineRatioGraph";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.lineRatioGraph.Series.Add(series2);
            this.lineRatioGraph.Size = new System.Drawing.Size(956, 654);
            this.lineRatioGraph.TabIndex = 22;
            this.lineRatioGraph.Text = "chart1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.btn_cal);
            this.groupBox4.Controls.Add(this.cbB_700Real);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.cbB_300Real);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.cbB_400Real);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(985, 649);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Size = new System.Drawing.Size(208, 212);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "최종 파장 선택(7)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(7, 185);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(191, 22);
            this.label19.TabIndex = 18;
            this.label19.Text = "계산 후 \'A파일의 연산 결과\'에서 \r\n              확인가능";
            // 
            // btn_cal
            // 
            this.btn_cal.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cal.Location = new System.Drawing.Point(6, 155);
            this.btn_cal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(196, 27);
            this.btn_cal.TabIndex = 18;
            this.btn_cal.Text = "계산하기";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // cbB_700Real
            // 
            this.cbB_700Real.FormattingEnabled = true;
            this.cbB_700Real.Location = new System.Drawing.Point(42, 129);
            this.cbB_700Real.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbB_700Real.Name = "cbB_700Real";
            this.cbB_700Real.Size = new System.Drawing.Size(131, 20);
            this.cbB_700Real.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(40, 113);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(133, 12);
            this.label21.TabIndex = 13;
            this.label21.Text = "3차 파장 범위(700대)";
            // 
            // cbB_300Real
            // 
            this.cbB_300Real.FormattingEnabled = true;
            this.cbB_300Real.Location = new System.Drawing.Point(42, 41);
            this.cbB_300Real.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbB_300Real.Name = "cbB_300Real";
            this.cbB_300Real.Size = new System.Drawing.Size(131, 20);
            this.cbB_300Real.TabIndex = 10;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(40, 27);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(133, 12);
            this.label23.TabIndex = 9;
            this.label23.Text = "1차 파장 범위(300대)";
            // 
            // cbB_400Real
            // 
            this.cbB_400Real.FormattingEnabled = true;
            this.cbB_400Real.Location = new System.Drawing.Point(42, 84);
            this.cbB_400Real.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbB_400Real.Name = "cbB_400Real";
            this.cbB_400Real.Size = new System.Drawing.Size(131, 20);
            this.cbB_400Real.TabIndex = 6;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(40, 69);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(133, 12);
            this.label25.TabIndex = 1;
            this.label25.Text = "2차 파장 범위(400대)";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgv_transpose);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage3.Size = new System.Drawing.Size(966, 669);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "A 파일 행렬변환결과";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgv_transpose
            // 
            this.dgv_transpose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_transpose.Location = new System.Drawing.Point(6, 8);
            this.dgv_transpose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgv_transpose.Name = "dgv_transpose";
            this.dgv_transpose.RowTemplate.Height = 23;
            this.dgv_transpose.Size = new System.Drawing.Size(954, 655);
            this.dgv_transpose.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.tabPage1.Controls.Add(this.dgv_A);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Size = new System.Drawing.Size(966, 669);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "A 파일";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_A
            // 
            this.dgv_A.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_A.Location = new System.Drawing.Point(6, 8);
            this.dgv_A.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgv_A.Name = "dgv_A";
            this.dgv_A.RowTemplate.Height = 23;
            this.dgv_A.Size = new System.Drawing.Size(954, 655);
            this.dgv_A.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(7, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(974, 695);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_selected);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Size = new System.Drawing.Size(966, 669);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "A 파일 파장 추출 결과";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_selected
            // 
            this.dgv_selected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_selected.Location = new System.Drawing.Point(6, 7);
            this.dgv_selected.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgv_selected.Name = "dgv_selected";
            this.dgv_selected.RowTemplate.Height = 23;
            this.dgv_selected.Size = new System.Drawing.Size(954, 656);
            this.dgv_selected.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgv_result);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage4.Size = new System.Drawing.Size(966, 669);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "A 파일 연산 결과";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgv_result
            // 
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_result.Location = new System.Drawing.Point(5, 6);
            this.dgv_result.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.RowTemplate.Height = 23;
            this.dgv_result.Size = new System.Drawing.Size(944, 647);
            this.dgv_result.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.lineRatioGraph);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(966, 669);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "그래프";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteRow
            // 
            this.btn_DeleteRow.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_DeleteRow.Location = new System.Drawing.Point(9, 20);
            this.btn_DeleteRow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_DeleteRow.Name = "btn_DeleteRow";
            this.btn_DeleteRow.Size = new System.Drawing.Size(194, 28);
            this.btn_DeleteRow.TabIndex = 6;
            this.btn_DeleteRow.Text = "필요없는 파장 제거";
            this.btn_DeleteRow.UseVisualStyleBackColor = true;
            this.btn_DeleteRow.Click += new System.EventHandler(this.btn_DeleteRow_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.btn_DeleteRow);
            this.groupBox5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox5.Location = new System.Drawing.Point(985, 137);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox5.Size = new System.Drawing.Size(208, 103);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "행 제거(3)";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(65, 82);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(136, 12);
            this.label24.TabIndex = 25;
            this.label24.Text = "(열 최대 갯수: 250개)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(16, 67);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(189, 12);
            this.label22.TabIndex = 24;
            this.label22.Text = "제거를 해야만 행렬변환이 가능";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(12, 51);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(116, 12);
            this.label20.TabIndex = 23;
            this.label20.Text = "행 제거 하는 이유:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ckB_Ne);
            this.groupBox6.Controls.Add(this.ckB_Te);
            this.groupBox6.Controls.Add(this.btn_GraphTimeSelect);
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Controls.Add(this.cbB_timeFinish);
            this.groupBox6.Controls.Add(this.cbB_timeStart);
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox6.Location = new System.Drawing.Point(11, 704);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox6.Size = new System.Drawing.Size(208, 157);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "그래프 시간대 선택(8)";
            // 
            // ckB_Ne
            // 
            this.ckB_Ne.AutoSize = true;
            this.ckB_Ne.Checked = true;
            this.ckB_Ne.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckB_Ne.Location = new System.Drawing.Point(47, 125);
            this.ckB_Ne.Name = "ckB_Ne";
            this.ckB_Ne.Size = new System.Drawing.Size(117, 16);
            this.ckB_Ne.TabIndex = 24;
            this.ckB_Ne.Text = "Ne 그래프 보기";
            this.ckB_Ne.UseVisualStyleBackColor = true;
            // 
            // ckB_Te
            // 
            this.ckB_Te.AutoSize = true;
            this.ckB_Te.Checked = true;
            this.ckB_Te.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckB_Te.Location = new System.Drawing.Point(47, 103);
            this.ckB_Te.Name = "ckB_Te";
            this.ckB_Te.Size = new System.Drawing.Size(116, 16);
            this.ckB_Te.TabIndex = 23;
            this.ckB_Te.Text = "Te 그래프 보기";
            this.ckB_Te.UseVisualStyleBackColor = true;
            // 
            // btn_GraphTimeSelect
            // 
            this.btn_GraphTimeSelect.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GraphTimeSelect.Location = new System.Drawing.Point(5, 66);
            this.btn_GraphTimeSelect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_GraphTimeSelect.Name = "btn_GraphTimeSelect";
            this.btn_GraphTimeSelect.Size = new System.Drawing.Size(196, 27);
            this.btn_GraphTimeSelect.TabIndex = 6;
            this.btn_GraphTimeSelect.Text = "그래프 그리기";
            this.btn_GraphTimeSelect.UseVisualStyleBackColor = true;
            this.btn_GraphTimeSelect.Click += new System.EventHandler(this.btn_GraphTimeSelect_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label26.Location = new System.Drawing.Point(96, 39);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(19, 15);
            this.label26.TabIndex = 12;
            this.label26.Text = "~";
            // 
            // cbB_timeFinish
            // 
            this.cbB_timeFinish.FormattingEnabled = true;
            this.cbB_timeFinish.Location = new System.Drawing.Point(114, 36);
            this.cbB_timeFinish.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbB_timeFinish.Name = "cbB_timeFinish";
            this.cbB_timeFinish.Size = new System.Drawing.Size(90, 20);
            this.cbB_timeFinish.TabIndex = 11;
            // 
            // cbB_timeStart
            // 
            this.cbB_timeStart.FormattingEnabled = true;
            this.cbB_timeStart.Location = new System.Drawing.Point(5, 36);
            this.cbB_timeStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbB_timeStart.Name = "cbB_timeStart";
            this.cbB_timeStart.Size = new System.Drawing.Size(90, 20);
            this.cbB_timeStart.TabIndex = 10;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(83, 19);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(38, 12);
            this.label27.TabIndex = 9;
            this.label27.Text = "Time";
            // 
            // 노이즈제거파일선택
            // 
            this.노이즈제거파일선택.Controls.Add(this.btn_noiseFileLoad);
            this.노이즈제거파일선택.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.노이즈제거파일선택.Location = new System.Drawing.Point(985, 78);
            this.노이즈제거파일선택.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.노이즈제거파일선택.Name = "노이즈제거파일선택";
            this.노이즈제거파일선택.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.노이즈제거파일선택.Size = new System.Drawing.Size(208, 55);
            this.노이즈제거파일선택.TabIndex = 19;
            this.노이즈제거파일선택.TabStop = false;
            this.노이즈제거파일선택.Text = "노이즈제거파일선택(2)";
            // 
            // btn_noiseFileLoad
            // 
            this.btn_noiseFileLoad.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_noiseFileLoad.Location = new System.Drawing.Point(0, 20);
            this.btn_noiseFileLoad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_noiseFileLoad.Name = "btn_noiseFileLoad";
            this.btn_noiseFileLoad.Size = new System.Drawing.Size(122, 27);
            this.btn_noiseFileLoad.TabIndex = 3;
            this.btn_noiseFileLoad.Text = "Xlsx 파일 불러오기";
            this.btn_noiseFileLoad.UseVisualStyleBackColor = true;
            this.btn_noiseFileLoad.Click += new System.EventHandler(this.btn_noiseFileLoad_Click);
            // 
            // btn_DeleteNoise
            // 
            this.btn_DeleteNoise.Enabled = false;
            this.btn_DeleteNoise.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_DeleteNoise.Location = new System.Drawing.Point(1106, 98);
            this.btn_DeleteNoise.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_DeleteNoise.Name = "btn_DeleteNoise";
            this.btn_DeleteNoise.Size = new System.Drawing.Size(89, 27);
            this.btn_DeleteNoise.TabIndex = 4;
            this.btn_DeleteNoise.Text = "노이즈 제거";
            this.btn_DeleteNoise.UseVisualStyleBackColor = true;
            this.btn_DeleteNoise.Click += new System.EventHandler(this.btn_DeleteNoise_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dgv_noise);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(966, 669);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "Noise";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dgv_noise
            // 
            this.dgv_noise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_noise.Location = new System.Drawing.Point(6, 7);
            this.dgv_noise.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgv_noise.Name = "dgv_noise";
            this.dgv_noise.RowTemplate.Height = 23;
            this.dgv_noise.Size = new System.Drawing.Size(954, 655);
            this.dgv_noise.TabIndex = 1;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dgv_aMinusNoise);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(966, 669);
            this.tabPage7.TabIndex = 7;
            this.tabPage7.Text = "A-Noise";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dgv_aMinusNoise
            // 
            this.dgv_aMinusNoise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aMinusNoise.Location = new System.Drawing.Point(6, 7);
            this.dgv_aMinusNoise.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgv_aMinusNoise.Name = "dgv_aMinusNoise";
            this.dgv_aMinusNoise.RowTemplate.Height = 23;
            this.dgv_aMinusNoise.Size = new System.Drawing.Size(954, 655);
            this.dgv_aMinusNoise.TabIndex = 2;
            // 
            // UserControl_LAM_KIYO_NOTNOISE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_DeleteNoise);
            this.Controls.Add(this.노이즈제거파일선택);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpB_fileLoad);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "UserControl_LAM_KIYO_NOTNOISE";
            this.Size = new System.Drawing.Size(1224, 864);
            this.grpB_fileLoad.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineRatioGraph)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transpose)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_A)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selected)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.노이즈제거파일선택.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_noise)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aMinusNoise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpB_fileLoad;
        private System.Windows.Forms.Button btn_aFileLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_RowColChange;
        private System.Windows.Forms.Button btn_RowColChange;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbB_700Finish;
        private System.Windows.Forms.ComboBox cbB_700Start;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbB_300Finish;
        private System.Windows.Forms.ComboBox cbB_300Start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbB_400Finish;
        private System.Windows.Forms.ComboBox cbB_400Start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_RangeSelectFinished;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart lineRatioGraph;
        private System.Windows.Forms.Label lbl_700;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_400;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_300;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbB_700Real;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbB_300Real;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbB_400Real;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgv_transpose;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dgv_A;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_DeleteRow;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgv_selected;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgv_result;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox ckB_Ne;
        private System.Windows.Forms.CheckBox ckB_Te;
        private System.Windows.Forms.Button btn_GraphTimeSelect;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cbB_timeFinish;
        private System.Windows.Forms.ComboBox cbB_timeStart;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox 노이즈제거파일선택;
        private System.Windows.Forms.Button btn_noiseFileLoad;
        private System.Windows.Forms.Button btn_DeleteNoise;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dgv_noise;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dgv_aMinusNoise;
    }
}
