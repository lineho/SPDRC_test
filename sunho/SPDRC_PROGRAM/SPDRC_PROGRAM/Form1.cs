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
            userControl11.Show();
        }

        private void btn_Rga_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl_TES_EPD1.Hide();
            userControl_OES_KSP1.Hide();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void Form_main_Load(object sender, EventArgs e)
        {

        }

        private void btn_OesKSP_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl_TES_EPD1.Hide();
            userControl_OES_KSP1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_TES_EPD_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl_OES_KSP1.Hide();
            userControl_TES_EPD1.Show();
        }
    }
}
