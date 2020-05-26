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
        DataTable dtA = new DataTable();
        DataTable dtB = new DataTable();
        DataTable selectedRangeOf_dtA = new DataTable();
        DataTable selectedRangeOf_dtB = new DataTable();
        DataTable preProcessedDt = new DataTable();
        int cbB_aStartRowNum = 0;
        int cbB_aFinishRowNum = 0;
        int cbB_bStartRowNum = 0;
        bool cbB_aStartRowIsChecked = false;
        bool cbB_aFinishRowIsChecked = false;
        bool cbB_bStartRowIsChecked = false;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

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

                if (filePath.EndsWith(".csv"))
                    dtA = CSVconvertToDataTable(filePath , "dtA");   // 이 함수 쓰려면 csv 파일 맨 윗줄의 cell이 하나라도 비어있으면 안됨.
                else if (filePath.EndsWith(".xlsx") || filePath.EndsWith(".xls"))
                    dtA = Xlsx_xlsConvertToDataTable(filePath , "dtA");

            }

            CountLineNumOf_dtA_AndSet_cbB_aStartRowFinishRowWithNumbers();
            //SPDRC_PROGRAM.DatabaseLoadForm aDatabaseLoadForm = new SPDRC_PROGRAM.DatabaseLoadForm();
            //aDatabaseLoadForm.ShowDialog();
        }

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
                    dtB = CSVconvertToDataTable(filePath, "dtB");   // 이 함수 쓰려면 csv 파일 맨 윗줄의 cell이 하나라도 비어있으면 안됨.
                else if (filePath.EndsWith(".xlsx") || filePath.EndsWith(".xls"))
                    dtB = Xlsx_xlsConvertToDataTable(filePath , "dtB");
                
            }

            CountLineNumOf_dtB_AndSet_cbB_bStartRowWithNumbers();
        }

        private DataTable Xlsx_xlsConvertToDataTable(string filePath, string dtType)
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
            if (dtType == "dtA")
                dgv_1.DataSource = excelTable;
            else if (dtType == "dtB")
                dgv_2.DataSource = excelTable;
            return excelTable;
        }

        private DataTable CSVconvertToDataTable(string filePath , string dtType)
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
                    if (dtType == "dtA")
                        dgv_1.DataSource = dt;
                    else if (dtType == "dtB")
                        dgv_2.DataSource = dt;
                }
            }
            return dt;
        }

        private void CountLineNumOf_dtB_AndSet_cbB_bStartRowWithNumbers( )
        {
            string[] data = new string[1];
            Array.Resize(ref data, dtB.Rows.Count);

            for (int i = 0; i < dtB.Rows.Count; i++)
            {
                data[i] = (i + 1).ToString();
                //data[4] = i + 1;
            }
            cbB_bStartRow.Items.Clear();
            cbB_bStartRow.Items.AddRange(data);
        }

        private void CountLineNumOf_dtA_AndSet_cbB_aStartRowFinishRowWithNumbers()
        {
            string[] data = new string[1];
            Array.Resize(ref data, dtA.Rows.Count);

            for (int i = 0; i < dtA.Rows.Count; i++)
            {
                data[i] = (i + 1).ToString();
                //data[4] = i + 1;
            }
            cbB_aStartRow.Items.Clear();
            cbB_aStartRow.Items.AddRange(data);
            cbB_aFinishRow.Items.Clear();
            cbB_aFinishRow.Items.AddRange(data);
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
            Console.WriteLine(string.Format("Selected cbB_bStartRowNum is {0}", cbB_bStartRow.SelectedItem));
            cbB_bStartRowNum = Int32.Parse(cbB_bStartRow.SelectedItem.ToString());
            cbB_bStartRowIsChecked = true;

        }

        private void dgv_3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbB_aStartRow_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Console.WriteLine(string.Format("Selected cbB_aStartRowNum is {0}", cbB_aStartRow.SelectedItem));
            cbB_aStartRowNum = Int32.Parse(cbB_aStartRow.SelectedItem.ToString());
            cbB_aStartRowIsChecked = true;
        }

        private void cbB_aFinishRow_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Console.WriteLine(string.Format("Selected cbB_aFinishRowNum is {0}", cbB_aFinishRow.SelectedItem));
            cbB_aFinishRowNum = Int32.Parse(cbB_aFinishRow.SelectedItem.ToString());
            cbB_aFinishRowIsChecked = true;
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            if (cbB_aStartRowIsChecked && cbB_aFinishRowIsChecked && cbB_bStartRowIsChecked)
            {
                selectedRangeOf_dtA = dtA.Copy();
                selectedRangeOf_dtB = dtB.Copy();

                selectedRangeOf_dtA.AcceptChanges();
                foreach (DataRow row in selectedRangeOf_dtA.Rows)
                {
                    if (     cbB_aStartRowNum <= Int32.Parse(row["lineNum"].ToString())         &&          Int32.Parse(row["lineNum"].ToString()) <= cbB_aFinishRowNum    )
                        ;
                    else
                        row.Delete();
                }
                selectedRangeOf_dtA.AcceptChanges();

                selectedRangeOf_dtB.AcceptChanges();
                foreach (DataRow row in selectedRangeOf_dtB.Rows)
                {
                    if (    cbB_bStartRowNum <= Int32.Parse(row["lineNum"].ToString())         &&          Int32.Parse(row["lineNum"].ToString()) <= cbB_bStartRowNum+cbB_aFinishRowNum-cbB_aStartRowNum    )
                        ;
                    else
                        row.Delete();
                }
                selectedRangeOf_dtB.AcceptChanges();

                preProcessedDt = selectedRangeOf_dtA.Copy(); //형식 복사

                for (int rowNum = 0; rowNum<=selectedRangeOf_dtA.Rows.Count-1 ;rowNum++)
                {
                    for (int columnNum=0; columnNum <= selectedRangeOf_dtA.Columns.Count-1 ;columnNum++)
                    {
                        if (columnNum == 0)
                            preProcessedDt.Rows[rowNum][columnNum]= (rowNum+1).ToString();
                        else
                            preProcessedDt.Rows[rowNum][columnNum] = (       Int32.Parse(selectedRangeOf_dtA.Rows[rowNum][columnNum].ToString())   -   Int32.Parse(selectedRangeOf_dtB.Rows[rowNum][columnNum].ToString())    ).ToString();
                    }
                }

                dgv_3.DataSource = preProcessedDt;
            }
            else
                MessageBox.Show("'A파일의 시작 행과 끝 행' 그리고 'B파일의 시작 행'을 모두 선택해 주십시오.");
        }
    }
}
