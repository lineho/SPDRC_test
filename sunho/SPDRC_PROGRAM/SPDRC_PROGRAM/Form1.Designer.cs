namespace SPDRC_PROGRAM
{
    partial class Form_main
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
            this.userControl11 = new SPDRC_PROGRAM.UserControl1();
            this.grp_Menu = new System.Windows.Forms.GroupBox();
            this.btn_Rga = new System.Windows.Forms.Button();
            this.btn_Oes = new System.Windows.Forms.Button();
            this.grp_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(264, 26);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1039, 523);
            this.userControl11.TabIndex = 0;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // grp_Menu
            // 
            this.grp_Menu.Controls.Add(this.btn_Rga);
            this.grp_Menu.Controls.Add(this.btn_Oes);
            this.grp_Menu.Location = new System.Drawing.Point(13, 26);
            this.grp_Menu.Name = "grp_Menu";
            this.grp_Menu.Size = new System.Drawing.Size(245, 523);
            this.grp_Menu.TabIndex = 1;
            this.grp_Menu.TabStop = false;
            this.grp_Menu.Text = "Menu";
            // 
            // btn_Rga
            // 
            this.btn_Rga.Location = new System.Drawing.Point(7, 70);
            this.btn_Rga.Name = "btn_Rga";
            this.btn_Rga.Size = new System.Drawing.Size(232, 43);
            this.btn_Rga.TabIndex = 1;
            this.btn_Rga.Text = "RGA";
            this.btn_Rga.UseVisualStyleBackColor = true;
            this.btn_Rga.Click += new System.EventHandler(this.btn_Rga_Click);
            // 
            // btn_Oes
            // 
            this.btn_Oes.Location = new System.Drawing.Point(7, 21);
            this.btn_Oes.Name = "btn_Oes";
            this.btn_Oes.Size = new System.Drawing.Size(232, 43);
            this.btn_Oes.TabIndex = 0;
            this.btn_Oes.Text = "OES";
            this.btn_Oes.UseVisualStyleBackColor = true;
            this.btn_Oes.Click += new System.EventHandler(this.btn_Oes_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1315, 561);
            this.Controls.Add(this.grp_Menu);
            this.Controls.Add(this.userControl11);
            this.Name = "Form_main";
            this.Text = "SPDRC";
            this.grp_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
        private System.Windows.Forms.GroupBox grp_Menu;
        private System.Windows.Forms.Button btn_Rga;
        private System.Windows.Forms.Button btn_Oes;
    }
}

