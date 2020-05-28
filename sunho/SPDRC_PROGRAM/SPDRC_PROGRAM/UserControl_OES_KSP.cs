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



namespace SPDRC_PROGRAM
{
    public partial class UserControl_OES_KSP : UserControl
    {
        DataTable dtA;

        public UserControl_OES_KSP()
        {
            InitializeComponent();
            chart1.Series.Clear();
          //  KSPwaveLengthChooseSetting();
        }

        private void UserControl_OES_KSP_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void KSPwaveLengthChooseSetting( )
        {
            string filePath = "kspOES_baseWaveLength.csv";
            string[] lines = System.IO.File.ReadAllLines(filePath);

            if (lines.Length > 0)
            {
                string firstLine = lines[0]; 

                string[] headerLabels = firstLine.Split(',');

                cbBox_waveLength1.Items.Clear();
                cbBox_waveLength2.Items.Clear();
                cbBox_waveLength1.Items.AddRange(headerLabels);
                cbBox_waveLength2.Items.AddRange(headerLabels);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Fileload_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btn_Fileload_Clicked");
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = "";

                filePath = dialog.FileName;
                Console.WriteLine(String.Format("{0} was imported bybtn_Fileload_Click", filePath));

                checkedListBox_OESdataCollect.Items.Add(filePath, true);

                if (filePath.EndsWith(".csv"))
                    dtA = CSVconvertToDataTable(filePath);   // 이 함수 쓰려면 csv 파일 맨 윗줄의 cell이 하나라도 비어있으면 안됨.
                else if (filePath.EndsWith(".xlsx") || filePath.EndsWith(".xls"))
                    dtA = Xlsx_xlsConvertToDataTable(filePath);

            }
        }

        private DataTable Xlsx_xlsConvertToDataTable(string filePath)
        {
            string dirName = Path.GetDirectoryName(filePath);
            string fileName = Path.GetFileName(filePath);
            string fileExtension = Path.GetExtension(filePath);
            string pathConn = string.Empty;
            string excelsql = string.Empty;

            switch (fileExtension)
            {
                case ".xls":
                    pathConn = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={filePath};" + "Extended Properties=\"Excel 8.0; HDR=Yes; IMEX=1\"";
                    excelsql = "SELECT * FROM [Sheet1$]";
                    break;

                case ".xlsx":
                    pathConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 12.0;HDR=YES'";
                    excelsql = @"select * from[Sheet1$]";
                    break;

                case ".csv":
                    pathConn = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dirName};" + "Extended Properties=\"text; HDR=Yes; IMEX=1; FMT=Delimited\"";
                    excelsql = $"SELECT * FROM [{fileName}]";
                    break;
            }

            OleDbConnection conn = new OleDbConnection(pathConn);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(excelsql, conn);
            DataSet excelDs = new DataSet();
            myDataAdapter.Fill(excelDs);
            DataTable excelTable = excelDs.Tables[0];

            dgv_1.DataSource = excelTable;

            return excelTable;
        }

        private DataTable CSVconvertToDataTable(string filePath)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filePath);

            if (lines.Length > 0)
            {
                string firstLine = lines[0]; // 2

                string[] headerLabels = firstLine.Split(',');

                short columnIndex = 0;
                foreach (string headerWord in headerLabels)   // create header of Datatale
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                    columnIndex++;
                }


                for (int lineNum = 1; lineNum < lines.Length; lineNum++) // fill data to Datatale // 3
                {
                    string[] dataWords = lines[lineNum].Split(',');
                    DataRow dr = dt.NewRow();
                    columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }

                if (dt.Rows.Count > 0)
                {
                    dgv_1.DataSource = dt;
                }
            }
            return dt;
        }

        private void checkedListBox_OESdataCollect_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("ddd");
        }
        private void checkedListBox_OESdataCollect_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox_OESdataCollect.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox_OESdataCollect.SetItemChecked(ix, false);
        }
    }
}
