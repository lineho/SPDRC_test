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
            this.btn_cal = new System.Windows.Forms.Button();
            this.btn_graph = new System.Windows.Forms.Button();
            this.btn_cSaveFile = new System.Windows.Forms.Button();
            this.cbB_aStartRow = new System.Windows.Forms.ComboBox();
            this.cbB_aFinishRow = new System.Windows.Forms.ComboBox();
            this.checkedListBox_dtAseletedFile = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_dtBselectedFile = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_3)).BeginInit();
            this.grpB_fileLoad.SuspendLayout();
            this.grpB_aSetRow.SuspendLayout();
            this.grpB_bSetRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_1
            // 
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_1.Location = new System.Drawing.Point(14, 135);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.RowTemplate.Height = 23;
            this.dgv_1.Size = new System.Drawing.Size(314, 475);
            this.dgv_1.TabIndex = 0;
            // 
            // dgv_2
            // 
            this.dgv_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_2.Location = new System.Drawing.Point(344, 135);
            this.dgv_2.Name = "dgv_2";
            this.dgv_2.RowTemplate.Height = 23;
            this.dgv_2.Size = new System.Drawing.Size(314, 475);
            this.dgv_2.TabIndex = 1;
            // 
            // dgv_3
            // 
            this.dgv_3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_3.Location = new System.Drawing.Point(674, 135);
            this.dgv_3.Name = "dgv_3";
            this.dgv_3.RowTemplate.Height = 23;
            this.dgv_3.Size = new System.Drawing.Size(314, 475);
            this.dgv_3.TabIndex = 2;
            this.dgv_3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_3_CellContentClick);
            // 
            // btn_aFileLoad
            // 
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
            this.grpB_fileLoad.Location = new System.Drawing.Point(1007, 135);
            this.grpB_fileLoad.Name = "grpB_fileLoad";
            this.grpB_fileLoad.Size = new System.Drawing.Size(208, 88);
            this.grpB_fileLoad.TabIndex = 5;
            this.grpB_fileLoad.TabStop = false;
            this.grpB_fileLoad.Text = "파일 불러오기";
            // 
            // lbl_grid1
            // 
            this.lbl_grid1.AutoSize = true;
            this.lbl_grid1.Location = new System.Drawing.Point(13, 117);
            this.lbl_grid1.Name = "lbl_grid1";
            this.lbl_grid1.Size = new System.Drawing.Size(41, 12);
            this.lbl_grid1.TabIndex = 6;
            this.lbl_grid1.Text = "A 파일";
            // 
            // lbl_grid2
            // 
            this.lbl_grid2.AutoSize = true;
            this.lbl_grid2.Location = new System.Drawing.Point(342, 117);
            this.lbl_grid2.Name = "lbl_grid2";
            this.lbl_grid2.Size = new System.Drawing.Size(41, 12);
            this.lbl_grid2.TabIndex = 7;
            this.lbl_grid2.Text = "B 파일";
            // 
            // lbl_grid3
            // 
            this.lbl_grid3.AutoSize = true;
            this.lbl_grid3.Location = new System.Drawing.Point(673, 117);
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
            this.grpB_aSetRow.Location = new System.Drawing.Point(1008, 230);
            this.grpB_aSetRow.Name = "grpB_aSetRow";
            this.grpB_aSetRow.Size = new System.Drawing.Size(200, 144);
            this.grpB_aSetRow.TabIndex = 9;
            this.grpB_aSetRow.TabStop = false;
            this.grpB_aSetRow.Text = "A 파일 행 설정";
            // 
            // lbl_aRowNum
            // 
            this.lbl_aRowNum.AutoSize = true;
            this.lbl_aRowNum.Location = new System.Drawing.Point(67, 119);
            this.lbl_aRowNum.Name = "lbl_aRowNum";
            this.lbl_aRowNum.Size = new System.Drawing.Size(29, 12);
            this.lbl_aRowNum.TabIndex = 5;
            this.lbl_aRowNum.Text = "숫자";
            // 
            // lbl_aRow
            // 
            this.lbl_aRow.AutoSize = true;
            this.lbl_aRow.Location = new System.Drawing.Point(7, 119);
            this.lbl_aRow.Name = "lbl_aRow";
            this.lbl_aRow.Size = new System.Drawing.Size(53, 12);
            this.lbl_aRow.TabIndex = 4;
            this.lbl_aRow.Text = "행 갯수 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "끝나는 행 값";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "시작할 행 값";
            // 
            // grpB_bSetRow
            // 
            this.grpB_bSetRow.Controls.Add(this.cbB_bStartRow);
            this.grpB_bSetRow.Controls.Add(this.lbl_bRowNum);
            this.grpB_bSetRow.Controls.Add(this.lbl_bRow);
            this.grpB_bSetRow.Controls.Add(this.cbB_bFinishRow);
            this.grpB_bSetRow.Controls.Add(this.label10);
            this.grpB_bSetRow.Controls.Add(this.label11);
            this.grpB_bSetRow.Location = new System.Drawing.Point(1009, 380);
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
            this.lbl_bRowNum.Location = new System.Drawing.Point(67, 119);
            this.lbl_bRowNum.Name = "lbl_bRowNum";
            this.lbl_bRowNum.Size = new System.Drawing.Size(29, 12);
            this.lbl_bRowNum.TabIndex = 5;
            this.lbl_bRowNum.Text = "숫자";
            // 
            // lbl_bRow
            // 
            this.lbl_bRow.AutoSize = true;
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
            this.cbB_bFinishRow.SelectedIndexChanged += new System.EventHandler(this.cbB_bFinishRow_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "끝나는 행 값";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "시작할 행 값";
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(1009, 531);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(199, 23);
            this.btn_cal.TabIndex = 11;
            this.btn_cal.Text = "연산하기";
            this.btn_cal.UseVisualStyleBackColor = true;
            // 
            // btn_graph
            // 
            this.btn_graph.Location = new System.Drawing.Point(1008, 560);
            this.btn_graph.Name = "btn_graph";
            this.btn_graph.Size = new System.Drawing.Size(199, 23);
            this.btn_graph.TabIndex = 12;
            this.btn_graph.Text = "그래프 확인";
            this.btn_graph.UseVisualStyleBackColor = true;
            // 
            // btn_cSaveFile
            // 
            this.btn_cSaveFile.Location = new System.Drawing.Point(1007, 587);
            this.btn_cSaveFile.Name = "btn_cSaveFile";
            this.btn_cSaveFile.Size = new System.Drawing.Size(199, 23);
            this.btn_cSaveFile.TabIndex = 13;
            this.btn_cSaveFile.Text = "C 파일 저장하기";
            this.btn_cSaveFile.UseVisualStyleBackColor = true;
            // 
            // cbB_aStartRow
            // 
            this.cbB_aStartRow.FormattingEnabled = true;
            this.cbB_aStartRow.Location = new System.Drawing.Point(7, 35);
            this.cbB_aStartRow.Name = "cbB_aStartRow";
            this.cbB_aStartRow.Size = new System.Drawing.Size(187, 20);
            this.cbB_aStartRow.TabIndex = 15;
            // 
            // cbB_aFinishRow
            // 
            this.cbB_aFinishRow.FormattingEnabled = true;
            this.cbB_aFinishRow.Location = new System.Drawing.Point(7, 86);
            this.cbB_aFinishRow.Name = "cbB_aFinishRow";
            this.cbB_aFinishRow.Size = new System.Drawing.Size(187, 20);
            this.cbB_aFinishRow.TabIndex = 16;
            // 
            // checkedListBox_dtAseletedFile
            // 
            this.checkedListBox_dtAseletedFile.FormattingEnabled = true;
            this.checkedListBox_dtAseletedFile.Location = new System.Drawing.Point(14, 3);
            this.checkedListBox_dtAseletedFile.Name = "checkedListBox_dtAseletedFile";
            this.checkedListBox_dtAseletedFile.Size = new System.Drawing.Size(314, 100);
            this.checkedListBox_dtAseletedFile.TabIndex = 14;
            // 
            // checkedListBox_dtBselectedFile
            // 
            this.checkedListBox_dtBselectedFile.FormattingEnabled = true;
            this.checkedListBox_dtBselectedFile.Location = new System.Drawing.Point(344, 3);
            this.checkedListBox_dtBselectedFile.Name = "checkedListBox_dtBselectedFile";
            this.checkedListBox_dtBselectedFile.Size = new System.Drawing.Size(314, 100);
            this.checkedListBox_dtBselectedFile.TabIndex = 15;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkedListBox_dtBselectedFile);
            this.Controls.Add(this.checkedListBox_dtAseletedFile);
            this.Controls.Add(this.btn_cSaveFile);
            this.Controls.Add(this.btn_graph);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.grpB_bSetRow);
            this.Controls.Add(this.grpB_aSetRow);
            this.Controls.Add(this.lbl_grid3);
            this.Controls.Add(this.lbl_grid2);
            this.Controls.Add(this.lbl_grid1);
            this.Controls.Add(this.grpB_fileLoad);
            this.Controls.Add(this.dgv_3);
            this.Controls.Add(this.dgv_2);
            this.Controls.Add(this.dgv_1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1218, 624);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_3)).EndInit();
            this.grpB_fileLoad.ResumeLayout(false);
            this.grpB_aSetRow.ResumeLayout(false);
            this.grpB_aSetRow.PerformLayout();
            this.grpB_bSetRow.ResumeLayout(false);
            this.grpB_bSetRow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_graph;
        private System.Windows.Forms.Button btn_cSaveFile;
        private System.Windows.Forms.ComboBox cbB_bStartRow;
        private System.Windows.Forms.ComboBox cbB_aFinishRow;
        private System.Windows.Forms.ComboBox cbB_aStartRow;
        private System.Windows.Forms.CheckedListBox checkedListBox_dtAseletedFile;
        private System.Windows.Forms.CheckedListBox checkedListBox_dtBselectedFile;
    }
}
