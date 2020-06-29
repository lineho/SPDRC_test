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
using System.Drawing.Text;

namespace SPDRC_PROGRAM
{
    public partial class UserControl_TES_EPD : UserControl
    {
        DataTable dtA;
        string waveLength1 = "";
        string waveLength2 = "";
        string timeRate = "0.1";
        Boolean cbBoxWavelength1Checked = false;
        Boolean cbBoxWavelength2Checked = false;
        Dictionary<string, object> waveLength_thresholdEnergy = new Dictionary<string, object>();

        public UserControl_TES_EPD()
        {
            InitializeComponent();

            EPD_chart.Series.Clear();
            KSPwaveLengthChooseSetting();

        }

        private void KSPwaveLengthChooseSetting()
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


        private void o_label_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_co_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbBox_waveLength1_SelectedIndexChanged(object sender, EventArgs e)
        {
            waveLength1 = cbBox_waveLength1.SelectedItem.ToString();
            cbBoxWavelength1Checked = true;
            Console.WriteLine(waveLength1);
        }

        private void cbBox_waveLength2_SelectedIndexChanged(object sender, EventArgs e)
        {
            waveLength2 = cbBox_waveLength2.SelectedItem.ToString();
            cbBoxWavelength2Checked = true;
            Console.WriteLine(waveLength2);
        }

        private void btn_FileLoad_Click(object sender, EventArgs e)
        {
            if (cbBoxWavelength1Checked && cbBoxWavelength2Checked)
            {
                Console.WriteLine("btn_Fileload_Clicked");
                OpenFileDialog dialog = new OpenFileDialog();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = "";

                    filePath = dialog.FileName;
                    Console.WriteLine(String.Format("{0} was imported bybtn_Fileload_Click", filePath));

                    checkedListBox_OESdataCollect.Items.Add(filePath, false);

                    if (filePath.EndsWith(".csv"))
                        dtA = CSVdataSortByWaveLengths(filePath);   // 이 함수 쓰려면 csv 파일 맨 윗줄의 cell이 하나라도 비어있으면 안됨.
                    else if (filePath.EndsWith(".xlsx") || filePath.EndsWith(".xls"))
                        dtA = Xlsx_xlsConvertToDataTable(filePath);
                }
            }
            else
                MessageBox.Show("'파장1' 그리고 '파장2'를 모두 선택해 주십시오.");

        }

        private DataTable CSVdataSortByWaveLengths(string filePath)
        {
            //Int16 headWordIndex_lineNum = 0;
            Int16 headWordIndex_time = 0;
            Int16 headWordIndex_waveLength1 = 0;
            Int16 headWordIndex_waveLength2 = 0;

            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filePath);

            if (lines.Length > 0)
            {
                string thirdLine = lines[2]; // 2

                string[] headerLabels = thirdLine.Split(',');

                short columnIndex = 0;
                foreach (string headerWord in headerLabels)   // create header of Datatale
                {
                    if (headerWord == "Time(sec)")
                    {
                        dt.Columns.Add(new DataColumn(headerWord));
                        headWordIndex_time = columnIndex;
                        Console.WriteLine(headWordIndex_time);
                    }
                    else if (headerWord == waveLength1)
                    {
                        dt.Columns.Add(new DataColumn(headerWord));
                        headWordIndex_waveLength1 = columnIndex;
                        Console.WriteLine(headWordIndex_waveLength1);
                    }
                    else if (headerWord == waveLength2)
                    {
                        dt.Columns.Add(new DataColumn(headerWord));
                        headWordIndex_waveLength2 = columnIndex;
                        Console.WriteLine(headWordIndex_waveLength2);
                    }

                    columnIndex++;
                }


                for (int lineNum = 3; lineNum < lines.Length; lineNum++) // fill data to Datatale // 3
                {
                    string[] dataWords = lines[lineNum].Split(',');  // CSV 파일을 row 기준으로 한 줄씩 읽어옴.
                    DataRow dr = dt.NewRow();
                    columnIndex = 0;
                    foreach (string dataWord in dataWords)
                    {
                        if (columnIndex == headWordIndex_time) { dr["Time(sec)"] = dataWord; }
                        else if (columnIndex == headWordIndex_waveLength1) { dr[waveLength1] = (Int32.Parse(dataWord) - 2000).ToString(); } // dataWord  // noise 제거를 위해 raw 데이터에서 2000을 뺌
                        else if (columnIndex == headWordIndex_waveLength2) { dr[waveLength2] = (Int32.Parse(dataWord) - 2000).ToString(); } // dataWord

                        columnIndex++;
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


    }
}
