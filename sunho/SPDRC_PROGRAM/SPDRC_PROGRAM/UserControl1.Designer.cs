namespace SPDRC_PROGRAM
{
    partial class UserControl1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgv_1 = new System.Windows.Forms.DataGridView();
            this.dgv_2 = new System.Windows.Forms.DataGridView();
            this.dgv_3 = new System.Windows.Forms.DataGridView();
            this.btn_aFileLoad = new System.Windows.Forms.Button();
            this.btn_bFileLoad = new System.Windows.Forms.Button();
            this.grpB_fileLoad = new System.Windows.Forms.GroupBox();
            this.lbl_grid1 = new System.Windows.Forms.Label();
            this.lbl_grid2 = new System.Windows.Forms.Label();
            this.lbl_grid3 = new System.Windows.Forms.Label();
            this.grpB_aSetRow = new System.Windows.Forms.GroupBox();
            this.cbB_aFinishRow = new System.Windows.Forms.ComboBox();
            this.cbB_aStartRow = new System.Windows.Forms.ComboBox();
            this.lbl_aRowNum = new System.Windows.Forms.Label();
            this.lbl_aRow = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpB_bSetRow = new System.Windows.Forms.GroupBox();
            this.cbB_bStartRow = new System.Windows.Forms.ComboBox();
            this.lbl_bRowNum = new System.Windows.Forms.Label();
            this.lbl_bRow = new System.Windows.Forms.Label();
            this.cbB_bFinishRow = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_graph = new System.Windows.Forms.Button();
            this.btn_cSaveFile = new System.Windows.Forms.Button();
            this.lineRatioGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_selectedColumnNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbB_bColumnNameAdd = new System.Windows.Forms.Button();
            this.cbB_bTotalColumnName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbB_bSelectedColumnName = new System.Windows.Forms.ComboBox();
            this.cbB_aSelectedColumnName = new System.Windows.Forms.ComboBox();
            this.cbB_aColumnNameAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbB_aTotalColumnName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_calc = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_3)).BeginInit();
            this.grpB_fileLoad.SuspendLayout();
            this.grpB_aSetRow.SuspendLayout();
            this.grpB_bSetRow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineRatioGraph)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_1
            // 
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_1.Location = new System.Drawing.Point(16, 26);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.RowTemplate.Height = 23;
            this.dgv_1.Size = new System.Drawing.Size(944, 442);
            this.dgv_1.TabIndex = 0;
            this.dgv_1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_1_CellClick);
            this.dgv_1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_1_CellMouseUp);
            // 
            // dgv_2
            // 
            this.dgv_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgv_2.Location = new System.Drawing.Point(16, 26);
            this.dgv_2.MultiSelect = false;
            this.dgv_2.Name = "dgv_2";
            this.dgv_2.RowTemplate.Height = 23;
            this.dgv_2.RowTemplate.ReadOnly = true;
            this.dgv_2.Size = new System.Drawing.Size(944, 442);
            this.dgv_2.TabIndex = 1;
            this.dgv_2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_2_CellClick);
            // 
            // dgv_3
            // 
            this.dgv_3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_3.Location = new System.Drawing.Point(16, 26);
            this.dgv_3.Name = "dgv_3";
            this.dgv_3.RowTemplate.Height = 23;
            this.dgv_3.Size = new System.Drawing.Size(944, 442);
            this.dgv_3.TabIndex = 2;
            // 
            // btn_aFileLoad
            // 
            this.btn_aFileLoad.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_aFileLoad.Location = new System.Drawing.Point(6, 20);
            this.btn_aFileLoad.Name = "btn_aFileLoad";
            this.btn_aFileLoad.Size = new System.Drawing.Size(196, 27);
            this.btn_aFileLoad.TabIndex = 3;
            this.btn_aFileLoad.Text = "A 파일 불러오기";
            this.btn_aFileLoad.UseVisualStyleBackColor = true;
            this.btn_aFileLoad.Click += new System.EventHandler(this.btn_aFileLoad_Click);
            // 
            // btn_bFileLoad
            // 
            this.btn_bFileLoad.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_bFileLoad.Location = new System.Drawing.Point(6, 53);
            this.btn_bFileLoad.Name = "btn_bFileLoad";
            this.btn_bFileLoad.Size = new System.Drawing.Size(196, 27);
            this.btn_bFileLoad.TabIndex = 4;
            this.btn_bFileLoad.Text = "B 파일 불러오기";
            this.btn_bFileLoad.UseVisualStyleBackColor = true;
            this.btn_bFileLoad.Click += new System.EventHandler(this.btn_bFileLoad_Click);
            // 
            // grpB_fileLoad
            // 
            this.grpB_fileLoad.Controls.Add(this.btn_aFileLoad);
            this.grpB_fileLoad.Controls.Add(this.btn_bFileLoad);
            this.grpB_fileLoad.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grpB_fileLoad.Location = new System.Drawing.Point(1004, 23);
            this.grpB_fileLoad.Name = "grpB_fileLoad";
            this.grpB_fileLoad.Size = new System.Drawing.Size(208, 88);
            this.grpB_fileLoad.TabIndex = 5;
            this.grpB_fileLoad.TabStop = false;
            this.grpB_fileLoad.Text = "파일 불러오기";
            // 
            // lbl_grid1
            // 
            this.lbl_grid1.AutoSize = true;
            this.lbl_grid1.Location = new System.Drawing.Point(14, 11);
            this.lbl_grid1.Name = "lbl_grid1";
            this.lbl_grid1.Size = new System.Drawing.Size(41, 12);
            this.lbl_grid1.TabIndex = 6;
            this.lbl_grid1.Text = "A 파일";
            // 
            // lbl_grid2
            // 
            this.lbl_grid2.AutoSize = true;
            this.lbl_grid2.Location = new System.Drawing.Point(14, 11);
            this.lbl_grid2.Name = "lbl_grid2";
            this.lbl_grid2.Size = new System.Drawing.Size(41, 12);
            this.lbl_grid2.TabIndex = 7;
            this.lbl_grid2.Text = "B 파일";
            // 
            // lbl_grid3
            // 
            this.lbl_grid3.AutoSize = true;
            this.lbl_grid3.Location = new System.Drawing.Point(14, 11);
            this.lbl_grid3.Name = "lbl_grid3";
            this.lbl_grid3.Size = new System.Drawing.Size(42, 12);
            this.lbl_grid3.TabIndex = 8;
            this.lbl_grid3.Text = "C 파일";
            // 
            // grpB_aSetRow
            // 
            this.grpB_aSetRow.Controls.Add(this.cbB_aFinishRow);
            this.grpB_aSetRow.Controls.Add(this.cbB_aStartRow);
            this.grpB_aSetRow.Controls.Add(this.lbl_aRowNum);
            this.grpB_aSetRow.Controls.Add(this.lbl_aRow);
            this.grpB_aSetRow.Controls.Add(this.label5);
            this.grpB_aSetRow.Controls.Add(this.label4);
            this.grpB_aSetRow.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grpB_aSetRow.Location = new System.Drawing.Point(1005, 118);
            this.grpB_aSetRow.Name = "grpB_aSetRow";
            this.grpB_aSetRow.Size = new System.Drawing.Size(200, 144);
            this.grpB_aSetRow.TabIndex = 9;
            this.grpB_aSetRow.TabStop = false;
            this.grpB_aSetRow.Text = "A 파일 행 설정";
            // 
            // cbB_aFinishRow
            // 
            this.cbB_aFinishRow.FormattingEnabled = true;
            this.cbB_aFinishRow.Location = new System.Drawing.Point(7, 86);
            this.cbB_aFinishRow.Name = "cbB_aFinishRow";
            this.cbB_aFinishRow.Size = new System.Drawing.Size(187, 20);
            this.cbB_aFinishRow.TabIndex = 16;
            this.cbB_aFinishRow.SelectedIndexChanged += new System.EventHandler(this.cbB_aFinishRow_SelectedIndexChanged_1);
            // 
            // cbB_aStartRow
            // 
            this.cbB_aStartRow.FormattingEnabled = true;
            this.cbB_aStartRow.Location = new System.Drawing.Point(7, 35);
            this.cbB_aStartRow.Name = "cbB_aStartRow";
            this.cbB_aStartRow.Size = new System.Drawing.Size(187, 20);
            this.cbB_aStartRow.TabIndex = 15;
            this.cbB_aStartRow.SelectedIndexChanged += new System.EventHandler(this.cbB_aStartRow_SelectedIndexChanged_1);
            // 
            // lbl_aRowNum
            // 
            this.lbl_aRowNum.AutoSize = true;
            this.lbl_aRowNum.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_aRowNum.Location = new System.Drawing.Point(67, 119);
            this.lbl_aRowNum.Name = "lbl_aRowNum";
            this.lbl_aRowNum.Size = new System.Drawing.Size(29, 12);
            this.lbl_aRowNum.TabIndex = 5;
            this.lbl_aRowNum.Text = "숫자";
            // 
            // lbl_aRow
            // 
            this.lbl_aRow.AutoSize = true;
            this.lbl_aRow.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_aRow.Location = new System.Drawing.Point(7, 119);
            this.lbl_aRow.Name = "lbl_aRow";
            this.lbl_aRow.Size = new System.Drawing.Size(53, 12);
            this.lbl_aRow.TabIndex = 4;
            this.lbl_aRow.Text = "행 갯수 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(7, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "끝나는 행 값(우클릭)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "시작할 행 값(좌클릭)";
            // 
            // grpB_bSetRow
            // 
            this.grpB_bSetRow.Controls.Add(this.cbB_bStartRow);
            this.grpB_bSetRow.Controls.Add(this.lbl_bRowNum);
            this.grpB_bSetRow.Controls.Add(this.lbl_bRow);
            this.grpB_bSetRow.Controls.Add(this.cbB_bFinishRow);
            this.grpB_bSetRow.Controls.Add(this.label10);
            this.grpB_bSetRow.Controls.Add(this.label11);
            this.grpB_bSetRow.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grpB_bSetRow.Location = new System.Drawing.Point(1006, 268);
            this.grpB_bSetRow.Name = "grpB_bSetRow";
            this.grpB_bSetRow.Size = new System.Drawing.Size(200, 144);
            this.grpB_bSetRow.TabIndex = 10;
            this.grpB_bSetRow.TabStop = false;
            this.grpB_bSetRow.Text = "B 파일 행 설정(자동)";
            // 
            // cbB_bStartRow
            // 
            this.cbB_bStartRow.FormattingEnabled = true;
            this.cbB_bStartRow.Location = new System.Drawing.Point(6, 36);
            this.cbB_bStartRow.Name = "cbB_bStartRow";
            this.cbB_bStartRow.Size = new System.Drawing.Size(187, 20);
            this.cbB_bStartRow.TabIndex = 14;
            this.cbB_bStartRow.SelectedIndexChanged += new System.EventHandler(this.sampleCB_SelectedIndexChanged);
            // 
            // lbl_bRowNum
            // 
            this.lbl_bRowNum.AutoSize = true;
            this.lbl_bRowNum.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_bRowNum.Location = new System.Drawing.Point(67, 119);
            this.lbl_bRowNum.Name = "lbl_bRowNum";
            this.lbl_bRowNum.Size = new System.Drawing.Size(29, 12);
            this.lbl_bRowNum.TabIndex = 5;
            this.lbl_bRowNum.Text = "숫자";
            // 
            // lbl_bRow
            // 
            this.lbl_bRow.AutoSize = true;
            this.lbl_bRow.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_bRow.Location = new System.Drawing.Point(7, 119);
            this.lbl_bRow.Name = "lbl_bRow";
            this.lbl_bRow.Size = new System.Drawing.Size(53, 12);
            this.lbl_bRow.TabIndex = 4;
            this.lbl_bRow.Text = "행 갯수 :";
            // 
            // cbB_bFinishRow
            // 
            this.cbB_bFinishRow.Enabled = false;
            this.cbB_bFinishRow.FormattingEnabled = true;
            this.cbB_bFinishRow.Location = new System.Drawing.Point(6, 86);
            this.cbB_bFinishRow.Name = "cbB_bFinishRow";
            this.cbB_bFinishRow.Size = new System.Drawing.Size(187, 20);
            this.cbB_bFinishRow.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(7, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "끝나는 행 값";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(7, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "시작할 행 값(좌클릭)";
            // 
            // btn_graph
            // 
            this.btn_graph.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_graph.Location = new System.Drawing.Point(1008, 826);
            this.btn_graph.Name = "btn_graph";
            this.btn_graph.Size = new System.Drawing.Size(199, 23);
            this.btn_graph.TabIndex = 12;
            this.btn_graph.Text = "그래프 확인";
            this.btn_graph.UseVisualStyleBackColor = true;
            this.btn_graph.Click += new System.EventHandler(this.btn_graph_Click);
            // 
            // btn_cSaveFile
            // 
            this.btn_cSaveFile.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cSaveFile.Location = new System.Drawing.Point(1008, 855);
            this.btn_cSaveFile.Name = "btn_cSaveFile";
            this.btn_cSaveFile.Size = new System.Drawing.Size(199, 23);
            this.btn_cSaveFile.TabIndex = 13;
            this.btn_cSaveFile.Text = "C 파일 저장하기";
            this.btn_cSaveFile.UseVisualStyleBackColor = true;
            // 
            // lineRatioGraph
            // 
            this.lineRatioGraph.AccessibleDescription = "ph";
            chartArea1.Name = "ChartArea1";
            this.lineRatioGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.lineRatioGraph.Legends.Add(legend1);
            this.lineRatioGraph.Location = new System.Drawing.Point(11, 513);
            this.lineRatioGraph.Name = "lineRatioGraph";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.lineRatioGraph.Series.Add(series1);
            this.lineRatioGraph.Size = new System.Drawing.Size(974, 365);
            this.lineRatioGraph.TabIndex = 14;
            this.lineRatioGraph.Text = "chart1";
            this.lineRatioGraph.Click += new System.EventHandler(this.lineRatioGraph_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(14, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(974, 500);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_1);
            this.tabPage1.Controls.Add(this.lbl_grid1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(966, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_2);
            this.tabPage2.Controls.Add(this.lbl_grid2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(966, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgv_3);
            this.tabPage3.Controls.Add(this.lbl_grid3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(966, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_selectedColumnNumber);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbB_bColumnNameAdd);
            this.groupBox1.Controls.Add(this.cbB_bTotalColumnName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbB_bSelectedColumnName);
            this.groupBox1.Controls.Add(this.cbB_aSelectedColumnName);
            this.groupBox1.Controls.Add(this.cbB_aColumnNameAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbB_aTotalColumnName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(1004, 423);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 242);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "열 선택(계산 순서로 선택해야함)";
            // 
            // tb_selectedColumnNumber
            // 
            this.tb_selectedColumnNumber.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_selectedColumnNumber.Location = new System.Drawing.Point(91, 211);
            this.tb_selectedColumnNumber.Name = "tb_selectedColumnNumber";
            this.tb_selectedColumnNumber.ReadOnly = true;
            this.tb_selectedColumnNumber.Size = new System.Drawing.Size(113, 20);
            this.tb_selectedColumnNumber.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(3, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "선택된 열 갯수:";
            // 
            // cbB_bColumnNameAdd
            // 
            this.cbB_bColumnNameAdd.Location = new System.Drawing.Point(125, 76);
            this.cbB_bColumnNameAdd.Name = "cbB_bColumnNameAdd";
            this.cbB_bColumnNameAdd.Size = new System.Drawing.Size(75, 23);
            this.cbB_bColumnNameAdd.TabIndex = 21;
            this.cbB_bColumnNameAdd.Text = "추가하기";
            this.cbB_bColumnNameAdd.UseVisualStyleBackColor = true;
            this.cbB_bColumnNameAdd.Click += new System.EventHandler(this.cbB_bColumnNameAdd_Click);
            // 
            // cbB_bTotalColumnName
            // 
            this.cbB_bTotalColumnName.FormattingEnabled = true;
            this.cbB_bTotalColumnName.Location = new System.Drawing.Point(9, 78);
            this.cbB_bTotalColumnName.Name = "cbB_bTotalColumnName";
            this.cbB_bTotalColumnName.Size = new System.Drawing.Size(110, 19);
            this.cbB_bTotalColumnName.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(9, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "B파일 선택할 열의 이름";
            // 
            // cbB_bSelectedColumnName
            // 
            this.cbB_bSelectedColumnName.FormattingEnabled = true;
            this.cbB_bSelectedColumnName.Location = new System.Drawing.Point(8, 182);
            this.cbB_bSelectedColumnName.Name = "cbB_bSelectedColumnName";
            this.cbB_bSelectedColumnName.Size = new System.Drawing.Size(191, 19);
            this.cbB_bSelectedColumnName.TabIndex = 18;
            // 
            // cbB_aSelectedColumnName
            // 
            this.cbB_aSelectedColumnName.FormattingEnabled = true;
            this.cbB_aSelectedColumnName.Location = new System.Drawing.Point(8, 145);
            this.cbB_aSelectedColumnName.Name = "cbB_aSelectedColumnName";
            this.cbB_aSelectedColumnName.Size = new System.Drawing.Size(191, 19);
            this.cbB_aSelectedColumnName.TabIndex = 17;
            // 
            // cbB_aColumnNameAdd
            // 
            this.cbB_aColumnNameAdd.Location = new System.Drawing.Point(124, 33);
            this.cbB_aColumnNameAdd.Name = "cbB_aColumnNameAdd";
            this.cbB_aColumnNameAdd.Size = new System.Drawing.Size(75, 23);
            this.cbB_aColumnNameAdd.TabIndex = 16;
            this.cbB_aColumnNameAdd.Text = "추가하기";
            this.cbB_aColumnNameAdd.UseVisualStyleBackColor = true;
            this.cbB_aColumnNameAdd.Click += new System.EventHandler(this.cbB_aColumnNameAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "열을 선택하지 않을 경우 자동으로 \r\n전체 A파일 대 전체 B파일로 계산됨";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(37, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 12);
            this.label12.TabIndex = 8;
            this.label12.Text = "B파일의 선택된 열 이름";
            // 
            // cbB_aTotalColumnName
            // 
            this.cbB_aTotalColumnName.FormattingEnabled = true;
            this.cbB_aTotalColumnName.Location = new System.Drawing.Point(8, 35);
            this.cbB_aTotalColumnName.Name = "cbB_aTotalColumnName";
            this.cbB_aTotalColumnName.Size = new System.Drawing.Size(110, 19);
            this.cbB_aTotalColumnName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(37, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "A파일의 선택된 열 이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "A파일 선택할 열의 이름";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_calc
            // 
            this.btn_calc.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_calc.Location = new System.Drawing.Point(1008, 799);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(199, 23);
            this.btn_calc.TabIndex = 16;
            this.btn_calc.Text = "연산하기";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(966, 474);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lineRatioGraph);
            this.Controls.Add(this.btn_cSaveFile);
            this.Controls.Add(this.btn_graph);
            this.Controls.Add(this.grpB_bSetRow);
            this.Controls.Add(this.grpB_aSetRow);
            this.Controls.Add(this.grpB_fileLoad);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1224, 881);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_3)).EndInit();
            this.grpB_fileLoad.ResumeLayout(false);
            this.grpB_aSetRow.ResumeLayout(false);
            this.grpB_aSetRow.PerformLayout();
            this.grpB_bSetRow.ResumeLayout(false);
            this.grpB_bSetRow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineRatioGraph)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_1;
        private System.Windows.Forms.DataGridView dgv_2;
        private System.Windows.Forms.DataGridView dgv_3;
        private System.Windows.Forms.Button btn_aFileLoad;
        private System.Windows.Forms.Button btn_bFileLoad;
        private System.Windows.Forms.GroupBox grpB_fileLoad;
        private System.Windows.Forms.Label lbl_grid1;
        private System.Windows.Forms.Label lbl_grid2;
        private System.Windows.Forms.Label lbl_grid3;
        private System.Windows.Forms.GroupBox grpB_aSetRow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_aRowNum;
        private System.Windows.Forms.Label lbl_aRow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpB_bSetRow;
        private System.Windows.Forms.Label lbl_bRowNum;
        private System.Windows.Forms.Label lbl_bRow;
        private System.Windows.Forms.ComboBox cbB_bFinishRow;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_graph;
        private System.Windows.Forms.Button btn_cSaveFile;
        private System.Windows.Forms.ComboBox cbB_bStartRow;
        private System.Windows.Forms.ComboBox cbB_aFinishRow;
        private System.Windows.Forms.ComboBox cbB_aStartRow;
        private System.Windows.Forms.DataVisualization.Charting.Chart lineRatioGraph;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbB_aTotalColumnName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ComboBox cbB_bSelectedColumnName;
        private System.Windows.Forms.ComboBox cbB_aSelectedColumnName;
        private System.Windows.Forms.Button cbB_aColumnNameAdd;
        private System.Windows.Forms.TextBox tb_selectedColumnNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cbB_bColumnNameAdd;
        private System.Windows.Forms.ComboBox cbB_bTotalColumnName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.TabPage tabPage4;
    }
}
