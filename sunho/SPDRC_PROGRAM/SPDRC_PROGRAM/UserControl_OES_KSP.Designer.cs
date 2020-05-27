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
            this.checkedListBox_OESdataCollect = new System.Windows.Forms.CheckedListBox();
            this.btn_Fileload = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox_OESdataCollect
            // 
            this.checkedListBox_OESdataCollect.FormattingEnabled = true;
            this.checkedListBox_OESdataCollect.Location = new System.Drawing.Point(29, 29);
            this.checkedListBox_OESdataCollect.Name = "checkedListBox_OESdataCollect";
            this.checkedListBox_OESdataCollect.Size = new System.Drawing.Size(365, 84);
            this.checkedListBox_OESdataCollect.TabIndex = 0;
            // 
            // btn_Fileload
            // 
            this.btn_Fileload.Location = new System.Drawing.Point(419, 49);
            this.btn_Fileload.Name = "btn_Fileload";
            this.btn_Fileload.Size = new System.Drawing.Size(132, 40);
            this.btn_Fileload.TabIndex = 1;
            this.btn_Fileload.Text = "OES 파일 불러오기";
            this.btn_Fileload.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(365, 475);
            this.dataGridView1.TabIndex = 2;
            // 
            // UserControl_OES_KSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Fileload);
            this.Controls.Add(this.checkedListBox_OESdataCollect);
            this.Name = "UserControl_OES_KSP";
            this.Size = new System.Drawing.Size(1071, 697);
            this.Load += new System.EventHandler(this.UserControl_OES_KSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox_OESdataCollect;
        private System.Windows.Forms.Button btn_Fileload;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
