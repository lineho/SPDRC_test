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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            cbB_bStartRow.Items.Add("1");

            cbB_bStartRow.SelectedIndex = 0;

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void btn_aFileLoad_Click(object sender, EventArgs e)
        {
            SPDRC_PROGRAM.DatabaseLoadForm aDatabaseLoadForm = new SPDRC_PROGRAM.DatabaseLoadForm();
            aDatabaseLoadForm.ShowDialog();
        }

        DataTable dtB = new DataTable();

        private void btn_bFileLoad_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btn_bFileLoad_Clicked");
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath="";


                filePath = dialog.FileName;
                Console.WriteLine(String.Format("{0} was imported by btn_bFileLoad_Click", filePath));

                if (filePath.EndsWith(".csv"))
                    dtB = CSVconvertToDataTable(filePath);   // 이 함수 쓰려면 csv 파일 맨 윗줄의 cell이 하나라도 비어있으면 안됨.
                if (filePath.EndsWith(".xlsx") || filePath.EndsWith(".xls"))
                    dtB = Xlsx_xlsConvertToDataTable(filePath);
                
            }

            CountLineNumOf_dtB();
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
            dgv_2.DataSource = excelTable;
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
                    dgv_2.DataSource = dt;
                }
            }
            return dt;
        }

        private void CountLineNumOf_dtB( )
        {
            string[] data = new string[1];
            Array.Resize(ref data, dtB.Rows.Count);

            for (int i = 0; i < dtB.Rows.Count; i++)
            {
                data[i] = (i + 1).ToString();
                //data[4] = i + 1;
            }
            sampleCB.Items.Clear();
            sampleCB.Items.AddRange(data);
        }

        private void cbB_bStartRow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbB_aStartRow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbB_aFinishRow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbB_bFinishRow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sampleCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
