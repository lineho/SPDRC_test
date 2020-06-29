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
    public partial class UserControl_OES_KSP : UserControl
    {
        DataTable dtA;
        string waveLength1 = "";
        string waveLength2 = "";
        string timeRate = "0.1";
        Boolean cbBoxWavelength1Checked = false;
        Boolean cbBoxWavelength2Checked = false;
        Dictionary<string, object> waveLength_thresholdEnergy = new Dictionary<string, object>();


        public UserControl_OES_KSP()
        {
            InitializeComponent();
            lineRatioGraph.Series.Clear();
            KSPwaveLengthChooseSetting();
            dtA = Basic_CSVconvertToDataTable("wavelength_thresholdEnergy.csv");
            foreach (DataRow row in dtA.Rows)
            {
                waveLength_thresholdEnergy.Add(row["wavelength"].ToString() , row["thresholdEnergy"].ToString());
            }
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

        private void btn_Fileload_Click(object sender, EventArgs e)
        {
            if (cbBoxWavelength1Checked  && cbBoxWavelength2Checked )
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
            int iSelectedIndex = checkedListBox_OESdataCollect.SelectedIndex;
            if (iSelectedIndex == -1)
                return;
            for (int iIndex = 0; iIndex < checkedListBox_OESdataCollect.Items.Count; iIndex++)
                checkedListBox_OESdataCollect.SetItemCheckState(iIndex, CheckState.Unchecked);
            checkedListBox_OESdataCollect.SetItemCheckState(iSelectedIndex, CheckState.Checked);

            Console.WriteLine(checkedListBox_OESdataCollect.SelectedItem.ToString());

            dtA = CSVdataSortByWaveLengths(checkedListBox_OESdataCollect.SelectedItem.ToString());
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

        private DataTable Basic_CSVconvertToDataTable(string filePath)
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

        private void btn_drawGraph_Click(object sender, EventArgs e)
        {
            CalculateLineRatioAndTeThenAddToDtA();

            ApplyMovingAverageFilterToElectronTemperature();

            DrawGraph();
        }

        private void CalculateLineRatioAndTeThenAddToDtA()
        {
            if (!dtA.Columns.Contains("lineRatio"))
            { 
                dtA.Columns.Add("lineRatio");
                dtA.Columns.Add("Te");
                dtA.Columns.Add("movingAverageFiltered_Te");
            }

            string[] arrayWaveLength1 = new string[dtA.Rows.Count];
            string[] arrayWaveLength2 = new string[dtA.Rows.Count];

            for (int rowNum = 0; rowNum <= dtA.Rows.Count - 1; rowNum++)
            {
                arrayWaveLength1[rowNum] = dtA.Rows[rowNum][waveLength1].ToString(); // 
                arrayWaveLength2[rowNum] = dtA.Rows[rowNum][waveLength2].ToString(); //
                //Console.WriteLine(arrayWaveLength1[rowNum]);
            }

            double deltaE = (double.Parse(waveLength_thresholdEnergy[waveLength1].ToString()) - double.Parse(waveLength_thresholdEnergy[waveLength2].ToString()));  // 파장의 threshold Energy 차이 (전자온도를 구할 때 사용) , waveLength_thresholdEnergy는 dictionary 변수이다. 
            Console.WriteLine("{0}", deltaE.ToString());


            for (int rowNum = 0; rowNum <= dtA.Rows.Count - 1; rowNum++)
            {
                //if (double.Parse(arrayWaveLength1[rowNum]) / double.Parse(arrayWaveLength2[rowNum]) <= -1000 || 1000 <= double.Parse(arrayWaveLength1[rowNum]) / double.Parse(arrayWaveLength2[rowNum]))  //   계산 과정에서 무한대가 나오는 것 방지
                //    dtA.Rows[rowNum]["lineRatio"] =0;
                //else
                    dtA.Rows[rowNum]["lineRatio"] = double.Parse(arrayWaveLength1[rowNum]) / double.Parse(arrayWaveLength2[rowNum]);  // line ratio 구하는 부분


                //if (-deltaE / Math.Log(double.Parse(arrayWaveLength1[rowNum]) / double.Parse(arrayWaveLength2[rowNum])) <= -25 || 25 <= -deltaE / Math.Log(double.Parse(arrayWaveLength1[rowNum]) / double.Parse(arrayWaveLength2[rowNum]))) //   계산 과정에서 무한대가 나오는 것 방지 , 무한대 값이 나오면 그래프에 표현이 안됨ㅠㅠ
                //    dtA.Rows[rowNum]["Te"] = 0;
                //else
                //    dtA.Rows[rowNum]["Te"] = - deltaE / Math.Log(double.Parse(arrayWaveLength1[rowNum]) / double.Parse(arrayWaveLength2[rowNum]));  // electron temperature 구하는 부분
                if (-deltaE / Math.Log(double.Parse(arrayWaveLength1[rowNum]) / double.Parse(arrayWaveLength2[rowNum])) <= -13)
                    dtA.Rows[rowNum]["Te"] = -13;
                else if (13 <= -deltaE / Math.Log(double.Parse(arrayWaveLength1[rowNum]) / double.Parse(arrayWaveLength2[rowNum])))
                    dtA.Rows[rowNum]["Te"] = 13;
                else
                    dtA.Rows[rowNum]["Te"] = -deltaE / Math.Log(double.Parse(arrayWaveLength1[rowNum]) / double.Parse(arrayWaveLength2[rowNum]));  // electron temperature 구하는 부분
            }

        }

        private void ApplyMovingAverageFilterToElectronTemperature()
        {
            for (int rowNum = 0; rowNum <= dtA.Rows.Count - 1; rowNum++)
            {
                if (rowNum <= 8)
                    dtA.Rows[rowNum]["movingAverageFiltered_Te"] = 0;
                else
                {
                    switch (timeRate)
                    {
                        case "0.1":
                            double sum = 0;
                            dtA.Rows[rowNum]["movingAverageFiltered_Te"] = null;
                            for (int Num = 0; Num <= 9; Num++)
                            {
                                sum += double.Parse(dtA.Rows[rowNum - Num]["Te"].ToString());  // row[9] ~row[0] 까지 모두 합함
                            }
                            dtA.Rows[rowNum]["movingAverageFiltered_Te"] = (sum / 10).ToString(); // Sum의 평균을 냄
                            break;
                    }
                }
            }

            dgv_1.DataSource = dtA;
        }

        private void DrawGraph()
        {
            this.lineRatioGraph.Series.Clear(); // 그래프 초기화

            Series lineRatio = this.lineRatioGraph.Series.Add("Line Ratio");
            lineRatio.ChartType = SeriesChartType.Spline;
            lineRatio.Color = Color.Red;
            lineRatio.MarkerSize = 10; // 선 두께 설정

            Series Te = this.lineRatioGraph.Series.Add("Electron Temperature");
            Te.ChartType = SeriesChartType.Spline;
            Te.MarkerSize = 30; // 선 두께 설정
            Te.Color = Color.Blue;

            for (int rowNum = 0; rowNum <= dtA.Rows.Count - 1; rowNum++)
            {
                lineRatio.Points.AddXY(dtA.Rows[rowNum]["Time(sec)"], dtA.Rows[rowNum]["lineRatio"]); //  lineRatio.Points.AddXY(dtA.Rows[rowNum]["Time(sec)"], dtA.Rows[rowNum]["lineRatio"]);
                Te.Points.AddXY(dtA.Rows[rowNum]["Time(sec)"], dtA.Rows[rowNum]["movingAverageFiltered_Te"]); //  Te.Points.AddXY(dtA.Rows[rowNum]["Time(sec)"], dtA.Rows[rowNum]["Te"]);
            }
        }


        private void lineRatioGraph_Click(object sender, EventArgs e)
        {
            lineRatioGraph.ChartAreas[0].AxisX.ScaleView.Zoomable = true;   // graph zoom 
            lineRatioGraph.ChartAreas[0].AxisY.ScaleView.Zoomable = true; // graph zoom
            lineRatioGraph.ChartAreas[0].CursorX.AutoScroll = true;
            lineRatioGraph.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
        }
    }
}
