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
            // -----------------------------'-------------'---------주석처리하고 commit해야 하는 부분-------------------------'---------------------------'---------------------------------------------
            InitializeComponent();
            int a = 1233 / 100;
            Console.WriteLine((a*100).ToString());
            Console.WriteLine(Math.Pow(10,-2));
            lineRatioGraph.Series.Clear();
            KSPwaveLengthChooseSetting();
            dtA = Basic_CSVconvertToDataTable("C:/Users/com/Documents/GitHub/SPDRC_test/sunho/SPDRC_PROGRAM/SPDRC_PROGRAM/dataset/OES_KSP/wavelength_thresholdEnergy_for_donghwan.csv"); //@"../SPDRC_PROGRAM/SPDRC_PROGRAM/dataset/OES_KSP/wavelength_thresholdEnergy.csv"
            //----------------------------------'----------------------------------------'----------------------------------------------------------'----------------------------------------------------------
            foreach (DataRow row in dtA.Rows)
            {
                waveLength_thresholdEnergy.Add(row["wavelength"].ToString(), row["thresholdEnergy"].ToString());
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
            string filePath = "C:/Users/com/Documents/GitHub/SPDRC_test/sunho/SPDRC_PROGRAM/SPDRC_PROGRAM/dataset/OES_KSP/kspOES_baseWaveLength.csv";
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
                        else if (columnIndex == headWordIndex_waveLength1) { dr[waveLength1] = (Int32.Parse(dataWord) - 0).ToString(); } // dataWord  // noise 제거를 위해 raw 데이터에서 2000을 뺌
                        else if (columnIndex == headWordIndex_waveLength2) { dr[waveLength2] = (Int32.Parse(dataWord) - 0).ToString(); } // dataWord

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

            //ApplyMovingAverageFilterToElectronTemperature();

            DrawGraph();
        }

        private void CalculateLineRatioAndTeThenAddToDtA()
        {
            if (!dtA.Columns.Contains("lineRatio"))
            { 
                dtA.Columns.Add("lineRatio");
                dtA.Columns.Add("Te");
                dtA.Columns.Add("A");
                //dtA.Columns.Add("Te_14.7381_13.4798");
                //dtA.Columns.Add("movingAverageFiltered_Te");
                dtA.Columns.Add("electronDensity");
                //dtA.Columns.Add("electronDensity_16.4_15.6_Up");
                //dtA.Columns.Add("electronDensity_16.4_15.6_Down");
                //dtA.Columns.Add("electronDensity_14.7381_13.4798");
                //dtA.Columns.Add("electronDensity_14.7381_13.4798_Up");
                //dtA.Columns.Add("electronDensity_14.7381_13.4798_Down");
                //dtA.Columns.Add("electronDensity_simpleA_16.4_15.6");
                //dtA.Columns.Add("electronDensity_simpleA_16.4_15.6_Up");
                //dtA.Columns.Add("electronDensity_simpleA_16.4_15.6_Down");
                //dtA.Columns.Add("electronDensity_simpleA_14.7381_13.4798");
                //dtA.Columns.Add("electronDensity_simpleA_14.7381_13.4798_Up");
                //dtA.Columns.Add("electronDensity_simpleA_14.7381_13.4798_Down");
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
            //double deltaE_14_7381_13_4798 = 14.7381 - 13.4798;
            Console.WriteLine("{0}", deltaE.ToString());

            double A=0;
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
                //-----------------------------------------'-----------------------------------------------'--------------------------------------------'---------------------------'-------------------------------------------------------------------------------------------
                //if (-deltaE / Math.Log(double.Parse(arrayWaveLength1[rowNum]) / double.Parse(arrayWaveLength2[rowNum])) <= -13)
                //{
                //    dtA.Rows[rowNum]["Te"] = -13;
                //    dtA.Rows[rowNum]["electronDensity"] = -13;
                //}
                //else if (13 <= -deltaE / Math.Log(double.Parse(arrayWaveLength1[rowNum]) / double.Parse(arrayWaveLength2[rowNum])))
                //{
                //    dtA.Rows[rowNum]["Te"] = 13;
                //    dtA.Rows[rowNum]["electronDensity"] = 13;
                //}
                //else
                //{
                //    dtA.Rows[rowNum]["Te"] = -deltaE / Math.Log(double.Parse(arrayWaveLength1[rowNum]) / double.Parse(arrayWaveLength2[rowNum]));  // electron temperature 구하는 부분
                //}
                //--------------------------------------------------'---------------------------------------------------------------------------'-----------------------------------------------'------------------------------------------------------------
                dtA.Rows[rowNum]["Te"] = - deltaE / Math.Log(double.Parse(arrayWaveLength1[rowNum]) / double.Parse(arrayWaveLength2[rowNum]));  // electron temperature 구하는 부분
                //dtA.Rows[rowNum]["Te_14.7381_13.4798"] = -deltaE_14_7381_13_4798 / Math.Log(double.Parse(arrayWaveLength1[rowNum]) / double.Parse(arrayWaveLength2[rowNum]));

                if ( waveLength1 == "425.876")
                { 
                    //A = Math.Exp(1/2) * Math.Exp(-1.2583 / double.Parse(dtA.Rows[rowNum]["Te"].ToString()));
                    A = Math.Sqrt(Math.Exp(1))*Math.Exp(-1.2583 / double.Parse(dtA.Rows[rowNum]["Te"].ToString()));
                    dtA.Rows[rowNum]["A"] = A;
                    Console.WriteLine("check");
                }
                else if( waveLength1 == "751.47")
                { 
                    A = 0.6* Math.Pow(double.Parse(dtA.Rows[rowNum]["Te"].ToString()) , -0.1)  * Math.Exp(0.205/ double.Parse(dtA.Rows[rowNum]["Te"].ToString()));
                    dtA.Rows[rowNum]["A"] = A;
                }
                //double A = (30.6 * 7.5 * Math.Exp(-10) * 1 * Math.Exp(-16.4 / double.Parse(dtA.Rows[rowNum]["Te"].ToString()))) / (99.5 * 2 * Math.Exp(-9) * Math.Pow(double.Parse(dtA.Rows[rowNum]["Te"].ToString()), 0.5) * Math.Exp(-15.6 / double.Parse(dtA.Rows[rowNum]["Te"].ToString())));

                //double A_14_7381_13_4798 = (30.6 * 7.5 * Math.Exp(-10) * 1 * Math.Exp(-16.4 / double.Parse(dtA.Rows[rowNum]["Te_14.7381_13.4798"].ToString()))) / (99.5 * 2 * Math.Exp(-9) * Math.Pow(double.Parse(dtA.Rows[rowNum]["Te_14.7381_13.4798"].ToString()), 0.5) * Math.Exp(-15.6 / double.Parse(dtA.Rows[rowNum]["Te_14.7381_13.4798"].ToString())));
                //double simple_A = (Math.Exp(-16.4 / double.Parse(dtA.Rows[rowNum]["Te"].ToString()))) / Math.Exp(-15.6 / double.Parse(dtA.Rows[rowNum]["Te"].ToString()));
                //double simple_A_14_7381_13_4798 = (Math.Exp(-14.7381 / double.Parse(dtA.Rows[rowNum]["Te_14.7381_13.4798"].ToString()))) / Math.Exp(-13.4798 / double.Parse(dtA.Rows[rowNum]["Te_14.7381_13.4798"].ToString()));

                dtA.Rows[rowNum]["electronDensity"] = (double.Parse(dtA.Rows[rowNum]["lineRatio"].ToString()) - A) / (A /10 - double.Parse(dtA.Rows[rowNum]["lineRatio"].ToString())/3.3)*Math.Pow(10,11);
                //dtA.Rows[rowNum]["electronDensity_16.4_15.6_Up"] = (double.Parse(dtA.Rows[rowNum]["lineRatio"].ToString()) - A) ;
                //dtA.Rows[rowNum]["electronDensity_16.4_15.6_Down"] =  (A / (3.3 * Math.Pow(10, 11)) - Math.Pow(10, -12) * double.Parse(dtA.Rows[rowNum]["lineRatio"].ToString()));

                //dtA.Rows[rowNum]["electronDensity_14.7381_13.4798"] = (double.Parse(dtA.Rows[rowNum]["lineRatio"].ToString()) - A_14_7381_13_4798) / (A_14_7381_13_4798 / (3.3 * Math.Pow(10, 11)) - Math.Pow(10, -12) * double.Parse(dtA.Rows[rowNum]["lineRatio"].ToString()));
                //dtA.Rows[rowNum]["electronDensity_14.7381_13.4798_Up"] = (double.Parse(dtA.Rows[rowNum]["lineRatio"].ToString()) - A_14_7381_13_4798) ;
                //dtA.Rows[rowNum]["electronDensity_14.7381_13.4798_Down"] =  (A_14_7381_13_4798 / (3.3 * Math.Pow(10, 11)) - Math.Pow(10, -12) * double.Parse(dtA.Rows[rowNum]["lineRatio"].ToString()));

                //dtA.Rows[rowNum]["electronDensity_simpleA_16.4_15.6"] = (double.Parse(dtA.Rows[rowNum]["lineRatio"].ToString()) - simple_A) / (simple_A / (3.3 * Math.Pow(10, 11)) - Math.Pow(10, -12) * double.Parse(dtA.Rows[rowNum]["lineRatio"].ToString()));
                //dtA.Rows[rowNum]["electronDensity_simpleA_16.4_15.6_Up"] = (double.Parse(dtA.Rows[rowNum]["lineRatio"].ToString()) - simple_A) ;
                //dtA.Rows[rowNum]["electronDensity_simpleA_16.4_15.6_Down"] =  (simple_A / (3.3 * Math.Pow(10, 11)) - Math.Pow(10, -12) * double.Parse(dtA.Rows[rowNum]["lineRatio"].ToString()));

                //dtA.Rows[rowNum]["electronDensity_simpleA_14.7381_13.4798"] = (double.Parse(dtA.Rows[rowNum]["lineRatio"].ToString()) - simple_A_14_7381_13_4798) / (simple_A_14_7381_13_4798 / (3.3 * Math.Pow(10, 11)) - Math.Pow(10, -12) * double.Parse(dtA.Rows[rowNum]["lineRatio"].ToString()));
                //dtA.Rows[rowNum]["electronDensity_simpleA_14.7381_13.4798_Up"] = (double.Parse(dtA.Rows[rowNum]["lineRatio"].ToString()) - simple_A_14_7381_13_4798) ;
                //dtA.Rows[rowNum]["electronDensity_simpleA_14.7381_13.4798_Down"] =  (simple_A_14_7381_13_4798 / (3.3 * Math.Pow(10, 11)) - Math.Pow(10, -12) * double.Parse(dtA.Rows[rowNum]["lineRatio"].ToString()));

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

            lineRatioGraph.ChartAreas[0].AxisY.Title = "전자밀도";
            //lineRatioGraph.ChartAreas[0].AxisY2.Title = "lineRatio";
            lineRatioGraph.ChartAreas[0].AxisX.Title = "전자온도 (eV)";

            //lineRatioGraph2.ChartAreas[0].AxisY.Title = "전자밀도";
            //lineRatioGraph2.ChartAreas[0].AxisX.Title = "전자온도 (eV)";

            //lineRatioGraph3.ChartAreas[0].AxisY.Title = "전자밀도";
            //lineRatioGraph3.ChartAreas[0].AxisX.Title = "전자온도 (eV)";

            //lineRatioGraph4.ChartAreas[0].AxisY.Title = "전자밀도";
            //lineRatioGraph4.ChartAreas[0].AxisX.Title = "전자온도 (eV)";
            //Series lineRatio = this.lineRatioGraph.Series.Add("Line Ratio");
            //lineRatio.ChartType = SeriesChartType.Spline;
            //lineRatio.Color = Color.Red;
            //lineRatio.MarkerSize = 10; // 선 두께 설정

            Series Te = this.lineRatioGraph.Series.Add("Electron Temperature");
            Te.ChartType = SeriesChartType.Spline;
            Te.MarkerSize = 30; // 선 두께 설정
            Te.Color = Color.Blue;

            //Series Te2 = this.lineRatioGraph2.Series.Add("Electron Temperature");
            //Te2.ChartType = SeriesChartType.Spline;
            //Te2.MarkerSize = 30; // 선 두께 설정
            //Te2.Color = Color.Blue;

            //Series Te3 = this.lineRatioGraph3.Series.Add("Electron Temperature");
            //Te3.ChartType = SeriesChartType.Spline;
            //Te3.MarkerSize = 30; // 선 두께 설정
            //Te3.Color = Color.Blue;

            //Series Te4 = this.lineRatioGraph4.Series.Add("Electron Temperature");
            //Te4.ChartType = SeriesChartType.Spline;
            //Te4.MarkerSize = 30; // 선 두께 설정
            //Te4.Color = Color.Blue;


            Series electronDensity = this.lineRatioGraph.Series.Add("Electron Density");
            electronDensity.ChartType = SeriesChartType.Spline;
            electronDensity.MarkerSize = 30;
            electronDensity.Color = Color.Red;

            //Series electronDensity2 = this.lineRatioGraph2.Series.Add("Electron Density_A_14.7381_13.4798");
            //electronDensity2.ChartType = SeriesChartType.Spline;
            //electronDensity2.MarkerSize = 30;
            //electronDensity2.Color = Color.Red;

            //Series electronDensity3 = this.lineRatioGraph3.Series.Add("Electron Density_simpleA_16.4_15.6");
            //electronDensity3.ChartType = SeriesChartType.Spline;
            //electronDensity3.MarkerSize = 30;
            //electronDensity3.Color = Color.Red;

            //Series electronDensity4 = this.lineRatioGraph4.Series.Add("Electron Density_simpleA_14.7381_13.4798");
            //electronDensity4.ChartType = SeriesChartType.Spline;
            //electronDensity4.MarkerSize = 30;
            //electronDensity4.Color = Color.Red;



            for (int rowNum = 19; rowNum <= 71; rowNum++)
            {
                //lineRatio.Points.AddXY(dtA.Rows[rowNum]["Time(sec)"], dtA.Rows[rowNum]["lineRatio"]); //  lineRatio.Points.AddXY(dtA.Rows[rowNum]["Time(sec)"], dtA.Rows[rowNum]["lineRatio"]);
                //Te.Points.AddXY(dtA.Rows[rowNum]["Time(sec)"], dtA.Rows[rowNum]["movingAverageFiltered_Te"]); //  Te.Points.AddXY(dtA.Rows[rowNum]["Time(sec)"], dtA.Rows[rowNum]["Te"]);
                electronDensity.Points.AddXY(dtA.Rows[rowNum]["Te"], dtA.Rows[rowNum]["electronDensity"]);
                //electronDensity3.Points.AddXY(dtA.Rows[rowNum]["Te"], dtA.Rows[rowNum]["electronDensity_simpleA_16.4_15.6"]);
            }

            //for (int rowNum = 19; rowNum <= 73; rowNum++)
            //{
            //    //lineRatio.Points.AddXY(dtA.Rows[rowNum]["Time(sec)"], dtA.Rows[rowNum]["lineRatio"]); //  lineRatio.Points.AddXY(dtA.Rows[rowNum]["Time(sec)"], dtA.Rows[rowNum]["lineRatio"]);
            //    //Te.Points.AddXY(dtA.Rows[rowNum]["Time(sec)"], dtA.Rows[rowNum]["movingAverageFiltered_Te"]); //  Te.Points.AddXY(dtA.Rows[rowNum]["Time(sec)"], dtA.Rows[rowNum]["Te"]);
            //    electronDensity2.Points.AddXY(dtA.Rows[rowNum]["Te_14.7381_13.4798"], dtA.Rows[rowNum]["electronDensity_14.7381_13.4798"]);
            //    electronDensity4.Points.AddXY(dtA.Rows[rowNum]["Te_14.7381_13.4798"], dtA.Rows[rowNum]["electronDensity_simpleA_14.7381_13.4798"]);
            //}
        }


        private void lineRatioGraph_Click(object sender, EventArgs e)
        {
            lineRatioGraph.ChartAreas[0].AxisX.ScaleView.Zoomable = true;   // graph zoom 
            lineRatioGraph.ChartAreas[0].AxisY.ScaleView.Zoomable = true; // graph zoom
            lineRatioGraph.ChartAreas[0].CursorX.AutoScroll = true;
            lineRatioGraph.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
        }   

        private void lineRatioGraph2_Click_1(object sender, EventArgs e)
        {
            lineRatioGraph2.ChartAreas[0].AxisX.ScaleView.Zoomable = true;   // graph zoom 
            lineRatioGraph2.ChartAreas[0].AxisY.ScaleView.Zoomable = true; // graph zoom
            lineRatioGraph2.ChartAreas[0].CursorX.AutoScroll = true;
            lineRatioGraph2.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
        }

        private void lineRatioGraph3_Click_1(object sender, EventArgs e)
        {
            lineRatioGraph3.ChartAreas[0].AxisX.ScaleView.Zoomable = true;   // graph zoom 
            lineRatioGraph3.ChartAreas[0].AxisY.ScaleView.Zoomable = true; // graph zoom
            lineRatioGraph3.ChartAreas[0].CursorX.AutoScroll = true;
            lineRatioGraph3.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
        }

        private void lineRatioGraph4_Click_1(object sender, EventArgs e)
        {
            lineRatioGraph4.ChartAreas[0].AxisX.ScaleView.Zoomable = true;   // graph zoom 
            lineRatioGraph4.ChartAreas[0].AxisY.ScaleView.Zoomable = true; // graph zoom
            lineRatioGraph4.ChartAreas[0].CursorX.AutoScroll = true;
            lineRatioGraph4.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;

        }

        private void dgv_1_CellContentClick(object sender, DataGridViewCellEventArgs e) // 
        {

        }

    }
}
