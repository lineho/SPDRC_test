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
        //데이터테이블 정의
        //(초기 dtA를 행렬변환하고 난뒤 사용하지 않는 이유: 행삭제가 열삭제보다 빠르기 때문에 행렬변환한 것은 눈으로 보기용으로만 좋다.)
        //dtA: Raw_data
        //dt_transpose: 행렬변환된 dtA
        //dt_Selected: 필요없는 파장을 날린 dtA
        //dt_SelectedTrans: 행렬변환된 dt_Selected
        //dt_preProcessed: Te, Ne 등이 포함되는 최종 datatable
        //dt_preProcessedTrans: 행렬변환된 dt_preProcessed
        DataTable dtA = new DataTable();
        DataTable dt_transpose = new DataTable();
        DataTable dt_Selected = new DataTable();
        DataTable dt_SelectedTrans = new DataTable();
        DataTable dt_preProcessed = new DataTable();
        DataTable dt_preProcessedTrans = new DataTable();
        DataTable dt_preProcessedTransGraph = new DataTable();
        DataTable dt_MinusAfterData = new DataTable();
        DataTable dt_MinusRawData = new DataTable();

        //300,400,700대 파장에서의 최대값을 추천하기 위해 각 파장별 intensity가 저장됨.
        //Key: 파장명(WaveLength), value: 값(intensity)
        Dictionary<string, double> dic300 = new Dictionary<string, double>();
        Dictionary<string, double> dic400 = new Dictionary<string, double>();
        Dictionary<string, double> dic700 = new Dictionary<string, double>();


        //UserControl_LAM_KIYO_NOTNOISE 초기화
        public UserControl_LAM_KIYO_NOTNOISE()
        {
            InitializeComponent(); 
            this.lineRatioGraph.Series.Clear();
        }

        //'A파일 불러오기' 버튼 클릭시.
        private void btn_aFileLoad_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btn_aFileLoad_Clicked");
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = "";

                filePath = dialog.FileName;
                Console.WriteLine(String.Format("{0} was imported by btn_aFileLoad_Click", filePath));

                if (filePath.EndsWith(".xlsx"))
                {
                    dtA = Xlsx_xlsConvertToDataTable(filePath, dgv_A);
                }
                else if (filePath.EndsWith(".csv")) //csv파일 받을 수있도록 연구 필요.
                {
                    MessageBox.Show("Xlsx 파일만 허용됩니다.");
                    btn_aFileLoad_Click(sender, e);
                }
                else //xlsx가 아닌 파일 선택하였을 경우.
                {
                    MessageBox.Show("Xlsx 파일만 허용됩니다.");
                    btn_aFileLoad_Click(sender, e);
                }
            }
        }
        
        //Noise파일 불러오기
        private void btn_noiseFileLoad_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btn_noiseFileLoad_Clicked");
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = "";

                filePath = dialog.FileName;
                Console.WriteLine(String.Format("{0} was imported by btn_noiseFileLoad_Clicked", filePath));

                if (filePath.EndsWith(".xlsx"))
                {
                    dt_MinusAfterData = Xlsx_xlsConvertToDataTable(filePath, dgv_noise);
                    btn_noiseFileLoad.Enabled = false;
                    btn_DeleteNoise.Enabled = true;

                    //test
                    //컬럼명 추출
                    List<string> colNameList = new List<string>();
                    //중복된 List는 빼고 저장
                    colNameList = GetColumnName(dt_MinusAfterData).Distinct().ToList();
                    List<string> colNameSelectedList = new List<string>();
                    double colNameNum;
                    colNameNum = Convert.ToDouble(colNameList[0].Replace("#", "."));
                    dt_MinusAfterData.Columns[0].ColumnName = "Noise";
                    DataRow row = dt_MinusAfterData.NewRow();
                    row["Noise"] = colNameNum;
                    dt_MinusAfterData.Rows.InsertAt(row, 0);

                }
                else if (filePath.EndsWith(".csv")) //csv파일 받을 수있도록 연구 필요.
                {
                    MessageBox.Show("Xlsx 파일만 허용됩니다.");
                    btn_aFileLoad_Click(sender, e);
                }
                else //xlsx가 아닌 파일 선택하였을 경우.
                {
                    MessageBox.Show("Xlsx 파일만 허용됩니다.");
                    btn_aFileLoad_Click(sender, e);
                }
            }
        }

        /// xlsx 파일을 읽으면 datatable형태로 변경.
        private DataTable Xlsx_xlsConvertToDataTable(string filePath, DataGridView dataGridView)
        {
            string dirName = Path.GetDirectoryName(filePath);
            string fileName = Path.GetFileName(filePath);
            string pathConn = string.Empty;
            string excelsql = string.Empty;

            pathConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 12.0;HDR=YES'";
            OleDbConnection conn = new OleDbConnection(pathConn);

            //worksheet명 불러오기.
            conn.Open();
            System.Data.DataTable workSeetName = null;
            workSeetName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            String[] excelSheets = new String[workSeetName.Rows.Count];
            int i = 0;
            // Add the sheet name to the string array.
            foreach (DataRow row in workSeetName.Rows)
            {
                excelSheets[i] = row["TABLE_NAME"].ToString();
                i++;
            }
            Console.WriteLine("WorksheetName: " + excelSheets[0]);
            excelsql = $"select * from[{excelSheets[0]}]";
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(excelsql, conn);
            DataSet excelDs = new DataSet();
            myDataAdapter.Fill(excelDs);
            DataTable excelTable = excelDs.Tables[0];
            Console.WriteLine("Loading File...");
            dataGridView.DataSource = excelTable;
            Console.WriteLine("Sueecss: Load File \nSueecss: xlsx convert to datatable");
            return excelTable;
        }

        private void btn_DeleteNoise_Click(object sender, EventArgs e)
        {
            dt_MinusRawData = dtA;
            List<string> colNameList = new List<string>();
            colNameList = GetColumnName(dt_MinusRawData).Distinct().ToList();
            int colNum= 1;
            foreach (var str in colNameList)
            {
                if (str == "date")
                {
                    continue;
                }

                for (int cCount = 1; cCount <= dt_MinusRawData.Rows.Count - 1; cCount++)
                {
                    dt_MinusRawData.Rows[cCount][colNum] = double.Parse(dt_MinusRawData.Rows[cCount][colNum].ToString()) - double.Parse(dt_MinusAfterData.Rows[cCount-1][0].ToString());
                }
                //for (int rCount = 1; rCount <= inputTable.Columns.Count - 1; rCount++)
                //{
                //    DataRow newRow = outputTable.NewRow();

                //    // First column is inputTable's Header row's second column
                //    newRow[0] = inputTable.Columns[rCount].ColumnName.ToString();

                //    outputTable.Rows.Add(newRow);
                //}
                //string colValue = inputTable.Rows[cCount][rCount].ToString();
                //newRow[cCount + 1] = colValue;

                ++colNum;
            }
            dgv_aMinusNoise.DataSource = dt_MinusRawData;
            Console.WriteLine("Success: A-Noise");
        }



        private void btn_RowColChange_Click(object sender, EventArgs e)
        {
            if (cb_RowColChange.Checked)
            {
                dt_transpose = GenerateTransposedTable(dtA).Copy();
                dgv_transpose.DataSource = dt_transpose;
                cbbItemAdd(dt_transpose);
                dgv_A.DataSource = dtA;
            }
            else
            {
                MessageBox.Show("행렬변환이 불가합니다. 체크하고 다시 버튼을 클릭해주세요.");
            }
        }

        /// 행렬 변환 체크표시 체크 여부 확인
        private void cb_RowColChange_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_RowColChange.Checked)
            {
                Console.WriteLine("Matrix transformation is possible.");
            }
            else
            {
                Console.WriteLine("Matrix transformation is not possible.");
            }
        }

        //행렬변환
        private DataTable GenerateTransposedTable(DataTable inputTable)
        {
            DataTable outputTable = new DataTable();

            // Add columns by looping rows

            // Header row's first column is same as in inputTable
            outputTable.Columns.Add(inputTable.Columns[0].ColumnName.ToString());

            // Header row's second column onwards, 'inputTable's first column taken
            foreach (DataRow inRow in inputTable.Rows)
            {
                string newColName = inRow[0].ToString();
                outputTable.Columns.Add(newColName);
            }

            // Add rows by looping columns        
            for (int rCount = 1; rCount <= inputTable.Columns.Count - 1; rCount++)
            {
                DataRow newRow = outputTable.NewRow();

                // First column is inputTable's Header row's second column
                newRow[0] = inputTable.Columns[rCount].ColumnName.ToString();
                for (int cCount = 0; cCount <= inputTable.Rows.Count - 1; cCount++)
                {
                    string colValue = inputTable.Rows[cCount][rCount].ToString();
                    newRow[cCount + 1] = colValue;
                }
                outputTable.Rows.Add(newRow);
            }
            outputTable.Columns[1].ColumnName = "time";

            Console.WriteLine("Success: Row&Column Transposed");
            return outputTable;
        }

        //300, 400, 700대의 파장을 가진 행 이외의 행 삭제
        private DataTable DeleteRow(DataTable inputTable)
        {
            foreach (DataRow dataRow in inputTable.Select())
            {
                if (dataRow[0] != System.DBNull.Value)
                {
                    if (double.Parse(dataRow[0].ToString()) < 330 || double.Parse(dataRow[0].ToString()) > 770)
                    {
                        inputTable.Rows.Remove(dataRow);
                    }
                    else if ((double.Parse(dataRow[0].ToString()) > 460) && (double.Parse(dataRow[0].ToString()) < 730))
                    {
                        inputTable.Rows.Remove(dataRow);
                    }
                }
            }
            inputTable.AcceptChanges();
            return inputTable;
        }

        //'필요없는 파장 제거'버튼 클릭시.
        private void btn_DeleteRow_Click(object sender, EventArgs e)
        {
            DeleteRow(dtA);
            Console.WriteLine("Success: Remove Row Completed");
        }

        /// 파장 폭 선택 콤보박스 채우기.
        private DataTable cbbItemAdd(DataTable inputTable)
        {
            DataTable outputTable = new DataTable();

            //컬럼명 추출
            List<string> colNameList = new List<string>();
            //중복된 List는 빼고 저장
            colNameList = GetColumnName(inputTable).Distinct().ToList();
            foreach (var str in colNameList)
            {
                double strDouble;
                bool success = double.TryParse(str, out strDouble);
                if (strDouble > 300 && strDouble < 400)
                {
                    cbB_300Start.Items.Add(str.ToString());
                    cbB_300Finish.Items.Add(str.ToString());
                }
                else if (strDouble > 400 && strDouble < 500)
                {
                    cbB_400Start.Items.Add(str.ToString());
                    cbB_400Finish.Items.Add(str.ToString());
                }
                else if (strDouble > 700 && strDouble < 800)
                {
                    cbB_700Start.Items.Add(str.ToString());
                    cbB_700Finish.Items.Add(str.ToString());
                }
            }
            cbB_300Start.SelectedIndex = 0;
            cbB_400Start.SelectedIndex = 0;
            cbB_700Start.SelectedIndex = 0;

            cbB_300Finish.SelectedIndex = cbB_300Finish.Items.Count - 1;
            cbB_400Finish.SelectedIndex = cbB_400Finish.Items.Count - 1;
            cbB_700Finish.SelectedIndex = cbB_700Finish.Items.Count - 1;

            return outputTable;
        }

        /// 컬럼명 가져오기
        private static List<string> GetColumnName(DataTable dt)
        {
            List<string> list = new List<string>();
            string ColumnName = string.Empty;
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    ColumnName = column.ColumnName;
                    list.Add(ColumnName);
                }
            }
            return list;
        }

        //300대 파장 선택에서 잘못 선택하였을 경우.
        private void cbB_300Finish_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (double.Parse(cbB_300Finish.SelectedItem.ToString()) < double.Parse(cbB_300Start.SelectedItem.ToString()))
            {
                MessageBox.Show("앞 선택된 값보다는 큰 값을 선택하셔야 됩니다.");
                cbB_300Finish.SelectedIndex = cbB_300Start.SelectedIndex + 1;
            }
        }

        //400대 파장 선택에서 잘못 선택하였을 경우.
        private void cbB_400Finish_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (double.Parse(cbB_400Finish.SelectedItem.ToString()) < double.Parse(cbB_400Start.SelectedItem.ToString()))
            {
                MessageBox.Show("앞 선택된 값보다는 큰 값을 선택하셔야 됩니다.");
                cbB_400Finish.SelectedIndex = cbB_400Start.SelectedIndex + 1;
            }
        }

        //700대 파장 선택에서 잘못 선택하였을 경우.
        private void cbB_700Finish_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (double.Parse(cbB_700Finish.SelectedItem.ToString()) < double.Parse(cbB_700Start.SelectedItem.ToString()))
            {
                MessageBox.Show("앞 선택된 값보다는 큰 값을 선택하셔야 됩니다.");
                cbB_700Finish.SelectedIndex = cbB_700Start.SelectedIndex + 1;
            }
        }


        private void btn_RangeSelectFinished_Click(object sender, EventArgs e)
        {
            DataTable outputTable = new DataTable();

            //컬럼명 추출
            List<string> colNameList = new List<string>();
            //중복된 List는 빼고 저장
            colNameList = GetColumnName(dt_transpose).Distinct().ToList();
            List<string> colNameSelectedList = new List<string>();

            foreach (var str in colNameList)
            {
                double strDouble;
                bool success = double.TryParse(str, out strDouble);
                if (strDouble >= double.Parse(cbB_300Start.SelectedItem.ToString()) && strDouble <= double.Parse(cbB_300Finish.SelectedItem.ToString()))
                {
                    colNameSelectedList.Add(str);
                }
                else if (strDouble >= double.Parse(cbB_400Start.SelectedItem.ToString()) && strDouble <= double.Parse(cbB_400Finish.SelectedItem.ToString()))
                {
                    colNameSelectedList.Add(str);

                }
                else if (strDouble >= double.Parse(cbB_700Start.SelectedItem.ToString()) && strDouble <= double.Parse(cbB_700Finish.SelectedItem.ToString()))
                {
                    colNameSelectedList.Add(str);
                }
            }

            //except가 살리는 열들.
            dt_Selected = dtA.Copy();

            var except = colNameList.Except(colNameSelectedList);

            foreach (DataRow dataRow in dt_Selected.Select())
            {
                if (dataRow[0] != System.DBNull.Value)
                {
                    if (except.Contains(dataRow[0].ToString()))
                    {
                        dt_Selected.Rows.Remove(dataRow);
                    }
                    else 
                    {
                    }
                }
            }
            dt_Selected.AcceptChanges();
            dt_SelectedTrans = GenerateTransposedTable(dt_Selected).Copy();
            dgv_selected.DataSource = dt_SelectedTrans;
            Console.WriteLine("RangeSelectFinished");
            dt_SelectedTrans.AcceptChanges();

            MaxdataTable(dt_SelectedTrans);
        }

        private DataTable MaxdataTable(DataTable inputTable)
        {
            //컬럼명 추출
            List<string> colNameList = new List<string>();
            //중복된 List는 빼고 저장
            colNameList = GetColumnName(inputTable).Distinct().ToList();

            int index = 0;

            foreach (var str in colNameList)
            {
                double maxLavel = 0 ;
                for (int i = 0; i <= inputTable.Rows.Count-1; i++)
                {
                    //Console.WriteLine("이상예측: "+ double.Parse(inputTable.Rows[i][index].ToString()));

                    if (double.Parse(inputTable.Rows[i][index].ToString())>= maxLavel)
                    {
                        maxLavel = double.Parse(inputTable.Rows[i][index].ToString());
                    }
                }
                ++index;

                double strDouble;
                bool success = double.TryParse(str, out strDouble);
                if (double.Parse(strDouble.ToString()) >= 300 && (double.Parse(strDouble.ToString()) < 400))
                {
                    dic300[str] = maxLavel;
                }

                if (double.Parse(strDouble.ToString()) >= 400 && double.Parse(strDouble.ToString()) <= 500)
                {
                    dic400[str] = maxLavel;

                }
                if (double.Parse(strDouble.ToString()) >= 700 && double.Parse(strDouble.ToString()) <= 800)
                {
                    dic700[str] = maxLavel;

                }
            }

            var maxValue3 = dic300.Values.Max();
            var keyOfMaxValue3 = dic300.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            Console.WriteLine("wavelength with maximum value of 300 wavelengths: [{0}:{1}]", keyOfMaxValue3, maxValue3);

            var maxValue4 = dic400.Values.Max();
            var keyOfMaxValue4 = dic400.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            Console.WriteLine("wavelength with maximum value of 400 wavelengths: [{0}:{1}]", keyOfMaxValue4, maxValue4);

            var maxValue7 = dic700.Values.Max();
            var keyOfMaxValue7 = dic700.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            Console.WriteLine("wavelength with maximum value of 700 wavelengths: [{0}:{1}]", keyOfMaxValue7, maxValue7);
            lbl_300.Text = keyOfMaxValue3;
            lbl_400.Text = keyOfMaxValue4;
            lbl_700.Text = keyOfMaxValue7;

            cbbItemAddReal(dt_transpose);

            cbB_300Real.SelectedItem = keyOfMaxValue3;
            cbB_400Real.SelectedItem = keyOfMaxValue4;
            cbB_700Real.SelectedItem = keyOfMaxValue7;

            return inputTable;
        }
        private DataTable cbbItemAddReal(DataTable inputTable)
        {
            DataTable outputTable = new DataTable();

            //컬럼명 추출
            List<string> colNameList = new List<string>();
            //중복된 List는 빼고 저장
            colNameList = GetColumnName(inputTable).Distinct().ToList();
            foreach (var str in colNameList)
            {
                double strDouble;
                bool success = double.TryParse(str, out strDouble);
                if (strDouble > 300 && strDouble < 400)
                {
                    cbB_300Real.Items.Add(str.ToString());
                }
                else if (strDouble > 400 && strDouble < 500)
                {
                    cbB_400Real.Items.Add(str.ToString());
                }
                else if (strDouble > 700 && strDouble < 800)
                {
                    cbB_700Real.Items.Add(str.ToString());
                }
            }

            return outputTable;

        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            dt_preProcessed = dtA.Copy();
            foreach (DataRow dataRow in dt_preProcessed.Select())
            {
                if (dataRow[0] != System.DBNull.Value)
                {
                    if ( lbl_300.Text.Contains(dataRow[0].ToString()) || lbl_400.Text.Contains(dataRow[0].ToString()) || lbl_700.Text.Contains(dataRow[0].ToString()))
                    {
                    }
                    else
                    {
                        dt_preProcessed.Rows.Remove(dataRow);
                    }
                }
            }
            dt_preProcessed.AcceptChanges();
            dt_preProcessedTrans = GenerateTransposedTable(dt_preProcessed).Copy();
            dgv_result.DataSource = dt_preProcessedTrans;
            dt_preProcessedTrans.Columns.Add(lbl_400.Text +" / " + lbl_300.Text);
            dt_preProcessedTrans.Columns.Add(lbl_400.Text + " / " + lbl_700.Text);
            dt_preProcessedTrans.Columns.Add("Te");
            dt_preProcessedTrans.Columns.Add("ne");

            for (int rowNum = 0; rowNum <= dt_preProcessedTrans.Rows.Count - 1; rowNum++)
            {
                dt_preProcessedTrans.Rows[rowNum][1] = rowNum;
                dt_preProcessedTrans.Rows[rowNum][lbl_400.Text + " / " + lbl_300.Text] = double.Parse(dt_preProcessedTrans.Rows[rowNum][3].ToString()) / double.Parse(dt_preProcessedTrans.Rows[rowNum][2].ToString());  
                dt_preProcessedTrans.Rows[rowNum][lbl_400.Text + " / " + lbl_700.Text] = double.Parse(dt_preProcessedTrans.Rows[rowNum][3].ToString()) / double.Parse(dt_preProcessedTrans.Rows[rowNum][4].ToString());
                if (double.IsInfinity(2 * (-1.2583 / Math.Log(double.Parse(dt_preProcessedTrans.Rows[rowNum][3].ToString()) / double.Parse(dt_preProcessedTrans.Rows[rowNum][4].ToString())))))
                {
                    dt_preProcessedTrans.Rows[rowNum]["Te"] = 0;
                }
                else
                {
                    dt_preProcessedTrans.Rows[rowNum]["Te"] = 2 * (-1.2583 / Math.Log(double.Parse(dt_preProcessedTrans.Rows[rowNum][3].ToString()) / double.Parse(dt_preProcessedTrans.Rows[rowNum][4].ToString())));
                }
                dt_preProcessedTrans.Rows[rowNum]["Ne"] = (Math.Exp(-0.56/ double.Parse(dt_preProcessedTrans.Rows[rowNum]["Te"].ToString())) - double.Parse(dt_preProcessedTrans.Rows[rowNum][lbl_400.Text + " / " + lbl_300.Text].ToString()) )/ ((1/(3*(Math.Pow(10, 11)))* double.Parse(dt_preProcessedTrans.Rows[rowNum][lbl_400.Text + " / " + lbl_300.Text].ToString()))-((1/(2*(Math.Pow(10, 10))))*(Math.Exp(-0.56 / double.Parse(dt_preProcessedTrans.Rows[rowNum]["Te"].ToString()))))) ;
            }

            DrawGraph();
        }
        private void DrawGraph()
        {
            this.lineRatioGraph.Series.Clear(); // 그래프 초기화

            Series Ne = this.lineRatioGraph.Series.Add("Ne");
            Ne.ChartType = SeriesChartType.Spline;
            Ne.Color = Color.Red;
            Ne.MarkerSize = 10; // 선 두께 설정

            Series Te = this.lineRatioGraph.Series.Add("Electron Temperature");
            Te.ChartType = SeriesChartType.Spline;
            Te.Color = Color.Blue;
            Te.MarkerSize = 30; // 선 두께 설정
            lineRatioGraph.Series[0].YAxisType = AxisType.Primary;
            lineRatioGraph.Series[1].YAxisType = AxisType.Secondary;
            for (int rowNum = 0; rowNum <= dt_preProcessedTrans.Rows.Count - 1; rowNum++)
            {
                Ne.Points.AddXY( dt_preProcessedTrans.Rows[rowNum][1], dt_preProcessedTrans.Rows[rowNum]["Ne"]);
                Te.Points.AddXY(dt_preProcessedTrans.Rows[rowNum][1], dt_preProcessedTrans.Rows[rowNum]["Te"]);
            }
            string[] data = new string[dt_preProcessedTrans.Rows.Count];

            //그래프의 조정가능한 시간 넣기.
            for (int i = 0; i < dt_preProcessedTrans.Rows.Count; i++)
            {
                data[i] = (i).ToString();
            }
            cbB_timeStart.Items.Clear();
            cbB_timeFinish.Items.Clear();

            cbB_timeStart.Items.AddRange(data);
            cbB_timeFinish.Items.AddRange(data);

            cbB_timeStart.SelectedIndex = 0;
            cbB_timeFinish.SelectedIndex = cbB_timeFinish.Items.Count - 1;
        }

        private void btn_GraphTimeSelect_Click(object sender, EventArgs e)
        {
            dt_preProcessedTransGraph = dt_preProcessedTrans.Copy();
            int cbB_timeStartValue = Int32.Parse(cbB_timeStart.SelectedItem.ToString());
            int cbB_timeFinishValue = Int32.Parse(cbB_timeFinish.SelectedItem.ToString());
            
            dt_preProcessedTransGraph.AcceptChanges();

            foreach (DataRow row in dt_preProcessedTransGraph.Rows)
            {
                Console.WriteLine("cbB_timeStartValue: "+ cbB_timeStartValue);
                Console.WriteLine("cbB_timeFinishValue: " + cbB_timeFinishValue);
                Console.WriteLine("dt_preProcessedTransGraph.Rows.IndexOf(row)" + (dt_preProcessedTransGraph.Rows.IndexOf(row)+1));
                
                if (cbB_timeStartValue <= dt_preProcessedTransGraph.Rows.IndexOf(row)+1 && dt_preProcessedTransGraph.Rows.IndexOf(row) + 1 <= cbB_timeFinishValue)
                {
                    Console.WriteLine("good");
                }
                else
                {
                    Console.WriteLine("not");

                    row.Delete();

                }
            }
            dt_preProcessedTransGraph.AcceptChanges();

            if(ckB_Te.Checked && ckB_Ne.Checked)
            {
                this.lineRatioGraph.Series.Clear(); // 그래프 초기화

                Series Ne = this.lineRatioGraph.Series.Add("Ne");
                Ne.ChartType = SeriesChartType.Spline;
                Ne.Color = Color.Red;
                Ne.MarkerSize = 10; // 선 두께 설정

                Series Te = this.lineRatioGraph.Series.Add("Electron Temperature");
                Te.ChartType = SeriesChartType.Spline;
                Te.Color = Color.Blue;
                Te.MarkerSize = 30; // 선 두께 설정
                lineRatioGraph.Series[0].YAxisType = AxisType.Primary;
                lineRatioGraph.Series[1].YAxisType = AxisType.Secondary;
                for (int rowNum = 0; rowNum <= dt_preProcessedTransGraph.Rows.Count - 1; rowNum++)
                {
                    Ne.Points.AddXY(dt_preProcessedTransGraph.Rows[rowNum][1], dt_preProcessedTransGraph.Rows[rowNum]["Ne"]);
                    Te.Points.AddXY(dt_preProcessedTransGraph.Rows[rowNum][1], dt_preProcessedTransGraph.Rows[rowNum]["Te"]);
                }
               
            }
            else if (ckB_Te.Checked || ckB_Ne.Checked == false)
            {
                this.lineRatioGraph.Series.Clear(); // 그래프 초기화

                Series Te = this.lineRatioGraph.Series.Add("Electron Temperature");
                Te.ChartType = SeriesChartType.Spline;
                Te.Color = Color.Blue;
                Te.MarkerSize = 30; // 선 두께 설정
                lineRatioGraph.Series[0].YAxisType = AxisType.Primary;

                //수정해야될 부분
                //double maxValue = 6;
                //double miniValue = 1;
                //double IntervalValue = 0.1;

                //lineRatioGraph.ChartAreas[0].AxisY.Maximum = maxValue;
                //lineRatioGraph.ChartAreas[0].AxisY.Minimum = miniValue;
                //lineRatioGraph.ChartAreas[0].AxisY.Interval = IntervalValue;


                for (int rowNum = 0; rowNum <= dt_preProcessedTransGraph.Rows.Count - 1; rowNum++)
                {
                    Te.Points.AddXY(dt_preProcessedTransGraph.Rows[rowNum][1], dt_preProcessedTransGraph.Rows[rowNum]["Te"]);
                }

            }
            else if (ckB_Ne.Checked && ckB_Te.Checked == false)
            {
                this.lineRatioGraph.Series.Clear(); // 그래프 초기화

                Series Ne = this.lineRatioGraph.Series.Add("Ne");
                Ne.ChartType = SeriesChartType.Spline;
                Ne.Color = Color.Red;
                Ne.MarkerSize = 10; // 선 두께 설정
                lineRatioGraph.Series[0].YAxisType = AxisType.Primary;

                for (int rowNum = 0; rowNum <= dt_preProcessedTransGraph.Rows.Count - 1; rowNum++)
                {
                    Ne.Points.AddXY(dt_preProcessedTransGraph.Rows[rowNum][1], dt_preProcessedTransGraph.Rows[rowNum]["Ne"]);
                }

            }



        }


    }
}
