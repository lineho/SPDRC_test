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
            this.grp_Menu = new System.Windows.Forms.GroupBox();
            this.btn_TES_EPD = new System.Windows.Forms.Button();
            this.btn_OesKSP = new System.Windows.Forms.Button();
            this.btn_Rga = new System.Windows.Forms.Button();
            this.btn_OesLam = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.userControl_TES_EPD1 = new SPDRC_PROGRAM.UserControl_TES_EPD();
            this.userControl_OES_KSP1 = new SPDRC_PROGRAM.UserControl_OES_KSP();
            this.userControl11 = new SPDRC_PROGRAM.UserControl_LAM_KIYO();
            this.grp_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Menu
            // 
            this.grp_Menu.Controls.Add(this.btn_TES_EPD);
            this.grp_Menu.Controls.Add(this.btn_OesKSP);
            this.grp_Menu.Controls.Add(this.btn_Rga);
            this.grp_Menu.Controls.Add(this.btn_OesLam);
            this.grp_Menu.Location = new System.Drawing.Point(13, 26);
            this.grp_Menu.Name = "grp_Menu";
            this.grp_Menu.Size = new System.Drawing.Size(245, 523);
            this.grp_Menu.TabIndex = 1;
            this.grp_Menu.TabStop = false;
            this.grp_Menu.Text = "Menu";
            // 
            // btn_TES_EPD
            // 
            this.btn_TES_EPD.Location = new System.Drawing.Point(7, 168);
            this.btn_TES_EPD.Name = "btn_TES_EPD";
            this.btn_TES_EPD.Size = new System.Drawing.Size(232, 43);
            this.btn_TES_EPD.TabIndex = 3;
            this.btn_TES_EPD.Text = "TES_EPD";
            this.btn_TES_EPD.UseVisualStyleBackColor = true;
            this.btn_TES_EPD.Click += new System.EventHandler(this.btn_TES_EPD_Click);
            // 
            // btn_OesKSP
            // 
            this.btn_OesKSP.Location = new System.Drawing.Point(7, 70);
            this.btn_OesKSP.Name = "btn_OesKSP";
            this.btn_OesKSP.Size = new System.Drawing.Size(232, 43);
            this.btn_OesKSP.TabIndex = 2;
            this.btn_OesKSP.Text = "OES_KSP";
            this.btn_OesKSP.UseVisualStyleBackColor = true;
            this.btn_OesKSP.Click += new System.EventHandler(this.btn_OesKSP_Click);
            // 
            // btn_Rga
            // 
            this.btn_Rga.Location = new System.Drawing.Point(7, 119);
            this.btn_Rga.Name = "btn_Rga";
            this.btn_Rga.Size = new System.Drawing.Size(232, 43);
            this.btn_Rga.TabIndex = 1;
            this.btn_Rga.Text = "RGA";
            this.btn_Rga.UseVisualStyleBackColor = true;
            this.btn_Rga.Click += new System.EventHandler(this.btn_Rga_Click);
            // 
            // btn_OesLam
            // 
            this.btn_OesLam.Location = new System.Drawing.Point(7, 21);
            this.btn_OesLam.Name = "btn_OesLam";
            this.btn_OesLam.Size = new System.Drawing.Size(232, 43);
            this.btn_OesLam.TabIndex = 0;
            this.btn_OesLam.Text = "OES_Lam";
            this.btn_OesLam.UseVisualStyleBackColor = true;
            this.btn_OesLam.Click += new System.EventHandler(this.btn_Oes_Click);
            // 
            // userControl_TES_EPD1
            // 
            this.userControl_TES_EPD1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl_TES_EPD1.Location = new System.Drawing.Point(274, 26);
            this.userControl_TES_EPD1.Name = "userControl_TES_EPD1";
            this.userControl_TES_EPD1.Size = new System.Drawing.Size(1200, 881);
            this.userControl_TES_EPD1.TabIndex = 4;
            // 
            // userControl_OES_KSP1
            // 
            this.userControl_OES_KSP1.Location = new System.Drawing.Point(264, 12);
            this.userControl_OES_KSP1.Name = "userControl_OES_KSP1";
            this.userControl_OES_KSP1.Size = new System.Drawing.Size(1210, 908);
            this.userControl_OES_KSP1.TabIndex = 3;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(258, 12);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1216, 895);
            this.userControl11.TabIndex = 0;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1479, 874);
            this.Controls.Add(this.userControl_TES_EPD1);
            this.Controls.Add(this.userControl_OES_KSP1);
            this.Controls.Add(this.grp_Menu);
            this.Controls.Add(this.userControl11);
            this.Name = "Form_main";
            this.Text = "SPDRC";
            this.grp_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl_LAM_KIYO userControl11;
        private System.Windows.Forms.GroupBox grp_Menu;
        private System.Windows.Forms.Button btn_Rga;
        private System.Windows.Forms.Button btn_OesLam;
        private System.Windows.Forms.Button btn_OesKSP;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UserControl_OES_KSP userControl_OES_KSP1;
        private System.Windows.Forms.Button btn_TES_EPD;
        private UserControl_TES_EPD userControl_TES_EPD1;
    }
}

