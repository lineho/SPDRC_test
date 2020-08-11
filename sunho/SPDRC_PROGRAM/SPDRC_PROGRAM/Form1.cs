using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDRC_PROGRAM
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void btn_Oes_Click(object sender, EventArgs e)
        {
            userControl_OES_KSP1.Hide();
            userControl_TES_EPD1.Hide();
            userControl11.Hide();
            userControl_LAM_KIYO_TEST1.Show();
        }

        private void btn_Rga_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl_TES_EPD1.Hide();
            userControl_OES_KSP1.Hide();
            userControl_LAM_KIYO_TEST1.Hide();
        }

        private void btn_OesKSP_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl_TES_EPD1.Hide();
            userControl_OES_KSP1.Show();
            userControl_LAM_KIYO_TEST1.Hide();
        }

        private void btn_TES_EPD_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl_OES_KSP1.Hide();
            userControl_TES_EPD1.Show();
            userControl_LAM_KIYO_TEST1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl_OES_KSP1.Hide();
            userControl_TES_EPD1.Hide();
            userControl_LAM_KIYO_TEST1.Hide();
        }
    }
}
