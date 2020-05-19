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
            userControl11.Show();
        }

        private void btn_Rga_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
