using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDRC_PROGRAM
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void btn_aFileLoad_Click(object sender, EventArgs e)
        {
            SPDRC_PROGRAM.DatabaseLoadForm aDatabaseLoadForm = new SPDRC_PROGRAM.DatabaseLoadForm();
            aDatabaseLoadForm.ShowDialog();
        }

        private void btn_bFileLoad_Click(object sender, EventArgs e)
        {

        }
    }
}
