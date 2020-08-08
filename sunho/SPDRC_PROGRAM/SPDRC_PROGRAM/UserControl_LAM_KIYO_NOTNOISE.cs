using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms.DataVisualization.Charting;

namespace SPDRC_PROGRAM
{
    public partial class UserControl_LAM_KIYO_NOTNOISE : UserControl
    {
                DataTable dtA = new DataTable();

        public UserControl_LAM_KIYO_NOTNOISE()
        {
            InitializeComponent();
            this.lineRatioGraph.Series.Clear();
        }

        private void UserControl_LAM_KIYO_NOTNOISE_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            this.lineRatioGraph.Series.Clear();
        }

        private void btn_aFileLoad_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btn_aFileLoad_Clicked");
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = "";


                filePath = dialog.FileName;
                Console.WriteLine(String.Format("{0} was imported by btn_aFileLoad_Click", filePath));

                //if (filePath.EndsWith(".csv"))
                //    dtA = CSVconvertToDataTable(filePath, "dtA");   // 이 함수 쓰려면 csv 파일 맨 윗줄의 cell이 하나라도 비어있으면 안됨.
                //else if (filePath.EndsWith(".xlsx") || filePath.EndsWith(".xls"))
                //    dtA = Xlsx_xlsConvertToDataTable(filePath, "dtA");

            }

        }
    }
}
