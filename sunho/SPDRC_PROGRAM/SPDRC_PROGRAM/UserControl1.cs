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
            this.lineRatioGraph.Series.Clear();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// DataTable에서 컬럼 이름 얻어오는 메서드
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
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

        /// <summary>
        /// CSV A파일 LOAD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    dtA = CSVconvertToDataTable(filePath, "dtA");   // 이 함수 쓰려면 csv 파일 맨 윗줄의 cell이 하나라도 비어있으면 안됨.
                else if (filePath.EndsWith(".xlsx") || filePath.EndsWith(".xls"))
                    dtA = Xlsx_xlsConvertToDataTable(filePath, "dtA");

            }

            CountLineNumOf_dtA_AndSet_cbB_aStartRowFinishRowWithNumbers();
            //SPDRC_PROGRAM.DatabaseLoadForm aDatabaseLoadForm = new SPDRC_PROGRAM.DatabaseLoadForm();
            //aDatabaseLoadForm.ShowDialog();\

            //컬럼명 추출
            List<string> colNameList = new List<string>();
            //중복된 List는 빼고 저장
            colNameList = GetColumnName(dtA).Distinct().ToList();
            foreach (var str in colNameList)
            {
                cbB_aTotalColumnName.Items.Add(str.ToString());
            }

        }



        /// <summary>
        /// CSV B파일 LOAD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_bFileLoad_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btn_bFileLoad_Clicked");
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = "";


                filePath = dialog.FileName;
                Console.WriteLine(String.Format("{0} was imported by btn_bFileLoad_Click", filePath));

                if (filePath.EndsWith(".csv"))
                    dtB = CSVconvertToDataTable(filePath, "dtB");   // 이 함수 쓰려면 csv 파일 맨 윗줄의 cell이 하나라도 비어있으면 안됨.
                else if (filePath.EndsWith(".xlsx") || filePath.EndsWith(".xls"))
                    dtB = Xlsx_xlsConvertToDataTable(filePath, "dtB");

            }

            CountLineNumOf_dtB_AndSet_cbB_bStartRowWithNumbers();

            //컬럼명 추출
            List<string> colNameList = new List<string>();
            //중복된 List는 빼고 저장
            colNameList = GetColumnName(dtB).Distinct().ToList();
            foreach (var str in colNameList)
            {
                cbB_bTotalColumnName.Items.Add(str.ToString());
            }
        }


        private DataTable Xlsx_xlsConvertToDataTable(string filePath, string dtType)
        {

            string dirName = Path.GetDirectoryName(filePath);
            string fileName = Path.GetFileName(filePath);
            string fileExtension = Path.GetExtension(filePath);
            string pathConn = string.Empty;
            string excelsql = string.Empty;
            try
            {
                switch (fileExtension)
                {
                    case ".xls":
                        pathConn = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={filePath};" + "Extended Properties=\"Excel 8.0; HDR=Yes; IMEX=1\"";
                        excelsql = "SELECT * FROM [WorkSheet$]";
                        break;

                    case ".xlsx":
                        pathConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 12.0;HDR=YES'";
                        excelsql = @"select * from[WorkSheet$]";
                        break;

                    case ".csv":
                        pathConn = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dirName};" + "Extended Properties=\"text; HDR=Yes; IMEX=1; FMT=Delimited\"";
                        excelsql = $"SELECT * FROM [{fileName}]";
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("오류의 건:" + e.Message);
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

        private DataTable CSVconvertToDataTable(string filePath, string dtType)
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

        // 사용자가 불러온 B파일의 row number들을 모두 comboBox B의 시작 행 선택 요소들로 집어 넣음
        private void CountLineNumOf_dtB_AndSet_cbB_bStartRowWithNumbers()
        {
            string[] data = new string[dtB.Rows.Count];

            for (int i = 0; i < dtB.Rows.Count; i++)
            {
                data[i] = (i + 1).ToString();
                //data[4] = i + 1;
            }
            cbB_bStartRow.Items.Clear();
            cbB_bStartRow.Items.AddRange(data);
        }

        // 사용자가 불러온 A파일의 row number들을 모두 comboBox A의 시작 행 , 끝 행 선택 요소들로 집어 넣음
        private void CountLineNumOf_dtA_AndSet_cbB_aStartRowFinishRowWithNumbers()
        {
            string[] data = new string[dtA.Rows.Count];

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


        private void sampleCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(string.Format("Selected cbB_bStartRowNum is {0}", cbB_bStartRow.SelectedItem));
            cbB_bStartRowNum = Int32.Parse(cbB_bStartRow.SelectedItem.ToString());
            cbB_bStartRowIsChecked = true;

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

            if (cbB_aStartRowIsChecked)
                lbl_aRowNum.Text = (cbB_aFinishRowNum - cbB_aStartRowNum + 1).ToString();
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            Minus_dtA_dtB();

            CalculateLineRatioAndTeThenAddToPreProcessedDt();
        }

        // dtA 에서 dtB의 내용들을 뺌 
        private void Minus_dtA_dtB()
        {
            if (cbB_aStartRowIsChecked && cbB_aFinishRowIsChecked && cbB_bStartRowIsChecked)
            {
                selectedRangeOf_dtA = dtA.Copy();
                selectedRangeOf_dtB = dtB.Copy();

                //-------------------------------------------selectedRangeOf_dtA에서 사용자가 선택한 행 이외의 행들은 모두 지워버림-----------------------------------
                selectedRangeOf_dtA.AcceptChanges();
                foreach (DataRow row in selectedRangeOf_dtA.Rows)
                {
                    if (cbB_aStartRowNum <= Int32.Parse(row["lineNum"].ToString()) && Int32.Parse(row["lineNum"].ToString()) <= cbB_aFinishRowNum)
                        ;
                    else
                        row.Delete();
                }
                selectedRangeOf_dtA.AcceptChanges();

                //------------------------------------------------------------------- selectedRangeOf_dtB에서 사용자가 선택한 행 이외의 행들은 모두 지워버림------------------------------------------------------------------
                selectedRangeOf_dtB.AcceptChanges();
                foreach (DataRow row in selectedRangeOf_dtB.Rows)
                {
                    if (cbB_bStartRowNum <= Int32.Parse(row["lineNum"].ToString()) && Int32.Parse(row["lineNum"].ToString()) <= cbB_bStartRowNum + cbB_aFinishRowNum - cbB_aStartRowNum)
                        ;
                    else
                        row.Delete();
                }
                selectedRangeOf_dtB.AcceptChanges();

                //--------------------------------------------------------------------selectedRangeOf_dtA의 내용에서 selectedRangeOf_dtB 내용들을 빼기 하는 부분-------------------------------------------------------------------------------------------
                preProcessedDt = selectedRangeOf_dtA.Copy(); //형식 복사

                for (int rowNum = 0; rowNum <= selectedRangeOf_dtA.Rows.Count - 1; rowNum++)
                {
                    for (int columnNum = 0; columnNum <= selectedRangeOf_dtA.Columns.Count - 1; columnNum++)
                    {
                        if (columnNum == 0)
                            preProcessedDt.Rows[rowNum][columnNum] = (rowNum + 1).ToString();
                        else
                            preProcessedDt.Rows[rowNum][columnNum] = (Int32.Parse(selectedRangeOf_dtA.Rows[rowNum][columnNum].ToString()) - Int32.Parse(selectedRangeOf_dtB.Rows[rowNum][columnNum].ToString())).ToString();
                    }
                }

                dgv_3.DataSource = preProcessedDt;  // preProcessedDt = selectedRangeOf_dtA - selectedRangeOf_dtB
            }
            else
                MessageBox.Show("'A파일의 시작 행과 끝 행' 그리고 'B파일의 시작 행'을 모두 선택해 주십시오.");
        }

        // 전처리 완료된 preProcessedDt의 맨 끝에   "lineratio" , "Te"  column을 추가하고  preProcessedDt의 내부 요소들로 lineratio와 전자온도를 구하는 함수
        private void CalculateLineRatioAndTeThenAddToPreProcessedDt()
        {
            preProcessedDt.Columns.Add("lineRatio");
            preProcessedDt.Columns.Add("Te");

            string[] waveLength1 = new string[preProcessedDt.Rows.Count];
            string[] waveLength2 = new string[preProcessedDt.Rows.Count];

            for (int rowNum = 0; rowNum <= preProcessedDt.Rows.Count - 1; rowNum++)
            {
                waveLength1[rowNum] = preProcessedDt.Rows[rowNum][1].ToString(); // preProcessedDt의 column number가 0부터 시작된다고 가정했을 때 column number가 1인 열의 데이터들을 모두 하나의 배열에 담음
                waveLength2[rowNum] = preProcessedDt.Rows[rowNum][2].ToString(); // preProcessedDt의 column number가 0부터 시작된다고 가정했을 때 column number가 2인 열의 데이터들을 모두 하나의 배열에 담음
                Console.WriteLine(waveLength1[rowNum]);
            }

            for (int rowNum = 0; rowNum <= preProcessedDt.Rows.Count - 1; rowNum++)
            {
                preProcessedDt.Rows[rowNum]["lineRatio"] = double.Parse(waveLength1[rowNum]) / double.Parse(waveLength2[rowNum]);  // line ratio를 구해서 preProcessedDt의 "lineRatio" column 부분에 차곡차곡 데이터를 입력 
                preProcessedDt.Rows[rowNum]["Te"] = -2 / Math.Log(double.Parse(waveLength1[rowNum]) / double.Parse(waveLength2[rowNum]));  //  electron temperature를 구해서 preProcessedDt의 "Te" column 부분에 차곡차곡 데이터를 입력
            }

            dgv_3.DataSource = preProcessedDt;

        }

        private void btn_graph_Click(object sender, EventArgs e)
        {
            Minus_dtA_dtB();

            CalculateLineRatioAndTeThenAddToPreProcessedDt();

            DrawGraph();
        }

        //preProcessedDt의 "lineRatio", "Te" column의 데이터들을 그래프에 띄우는 부분 
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

            for (int rowNum = 0; rowNum <= preProcessedDt.Rows.Count - 1; rowNum++)
            {
                lineRatio.Points.AddXY(preProcessedDt.Rows[rowNum]["lineNum"], preProcessedDt.Rows[rowNum]["lineRatio"]);
                Te.Points.AddXY(preProcessedDt.Rows[rowNum]["lineNum"], preProcessedDt.Rows[rowNum]["Te"]);
            }
        }

        // 그래프에 마우스를 갖다대었을때 그래프가 줌인, 줌 아웃되게 하는 기능을 추가하는 부분
        private void lineRatioGraph_Click(object sender, EventArgs e)
        {
            lineRatioGraph.ChartAreas[0].AxisX.ScaleView.Zoomable = true;   // graph zoom 
            lineRatioGraph.ChartAreas[0].CursorX.AutoScroll = true;
            lineRatioGraph.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
        }

        /// <summary>
        /// A파일 좌클릭으로 선택 시작 행 인덱스 추출.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow cbB_aStartRowNum_row = dgv_1.Rows[e.RowIndex];
                cbB_aStartRowNum = cbB_aStartRowNum_row.Index;
                Console.WriteLine("a시작 확인: " + cbB_aStartRowNum);
                cbB_aStartRow.SelectedIndex = cbB_aStartRowNum;
            }
            catch
            {
                Console.WriteLine("열머리");
            }
        }


        /// <summary>
        /// A파일 우클릭으로 선택 끝 행 인덱스 추출.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    DataGridViewRow cbB_aFinishRowNum_row = dgv_1.Rows[e.RowIndex];
                    cbB_aFinishRowNum = cbB_aFinishRowNum_row.Index;
                    Console.WriteLine("a끝 확인: " + cbB_aFinishRowNum);
                    cbB_aFinishRow.SelectedIndex = cbB_aFinishRowNum;
                }
            }
            catch
            {
                Console.WriteLine("열머리");
            }
        }

        /// <summary>
        /// B파일 좌클릭으로 선택 시작 행 인덱스 추출.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow cbB_bStartRowNum_row = dgv_1.Rows[e.RowIndex];
                cbB_bStartRowNum = cbB_bStartRowNum_row.Index;
                Console.WriteLine("b시작 확인: " + cbB_bStartRowNum);
                cbB_bStartRow.SelectedIndex = cbB_bStartRowNum;
            }
            catch
            {
                Console.WriteLine("열머리");
            }
        }

        /// <summary>
        /// A파일 컬럼명 추가하기 눌렀을 경우
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbB_aColumnNameAdd_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Add(cbB_aTotalColumnName.SelectedItem.ToString());

            foreach (string prime in list)
            {
                if (!cbB_aSelectedColumnName.Items.Contains(prime))
                {
                    cbB_aSelectedColumnName.Items.Add(prime);
                }
            }
            int numAcom = cbB_aSelectedColumnName.Items.Count;
            int numBcom = cbB_bSelectedColumnName.Items.Count;

            if (numAcom == numBcom)
                tb_selectedColumnNumber.Text = numAcom.ToString();

            else
                tb_selectedColumnNumber.Text = "A,B 열 갯수 불일치";
        }

        /// <summary>
        ///  B파일 컬럼명 추가하기 눌렀을 경우
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbB_bColumnNameAdd_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Add(cbB_bTotalColumnName.SelectedItem.ToString());

            foreach (string prime in list)
            {
                if (!cbB_bSelectedColumnName.Items.Contains(prime))
                {
                    cbB_bSelectedColumnName.Items.Add(prime);
                }
            }
            int numAcom = cbB_aSelectedColumnName.Items.Count;
            int numBcom = cbB_bSelectedColumnName.Items.Count;

            if (numAcom == numBcom)
                tb_selectedColumnNumber.Text = numBcom.ToString();

            else
                tb_selectedColumnNumber.Text = "A,B 열 갯수 불일치";
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            Minus_dtA_dtB_test();
            CalculateLineRatioAndTeThenAddToPreProcessedDt_test();

        }

        /// <summary>
        /// DataTable에서 컬럼 이름 얻어오는 메서드
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>


        private void Minus_dtA_dtB_test()
        {
            if (cbB_aStartRowIsChecked && cbB_aFinishRowIsChecked && cbB_bStartRowIsChecked)
            {
                selectedRangeOf_dtA = dtA.Copy();
                selectedRangeOf_dtB = dtB.Copy();

                //-------------------------------------------selectedRangeOf_dtA에서 사용자가 선택한 행 이외의 행들은 모두 지워버림-----------------------------------
                selectedRangeOf_dtA.AcceptChanges();
                foreach (DataRow row in selectedRangeOf_dtA.Rows)
                {
                    if (cbB_aStartRowNum <= selectedRangeOf_dtA.Rows.IndexOf(row)+1  && selectedRangeOf_dtA.Rows.IndexOf(row)+1 <= cbB_aFinishRowNum)
                        ;
                    else
                        row.Delete();
                }
                selectedRangeOf_dtA.AcceptChanges();

                //------------------------------------------------------------------- selectedRangeOf_dtB에서 사용자가 선택한 행 이외의 행들은 모두 지워버림------------------------------------------------------------------
                selectedRangeOf_dtB.AcceptChanges();
                foreach (DataRow row in selectedRangeOf_dtB.Rows)
                {
                    if (cbB_bStartRowNum <= selectedRangeOf_dtB.Rows.IndexOf(row) +1 && selectedRangeOf_dtB.Rows.IndexOf(row) +1 <= cbB_bStartRowNum + cbB_aFinishRowNum - cbB_aStartRowNum)
                        ;
                    else
                        row.Delete();
                }
                selectedRangeOf_dtB.AcceptChanges();

                //------------------------------------------------------------------- selectedRangeOf_dtA에서 사용자가 선택한 열 이외의 행들은 모두 지워버림------------------------------------------------------------------
                selectedRangeOf_dtA.AcceptChanges();


                List<string> listA = new List<string>();
                int numA = Convert.ToInt32(tb_selectedColumnNumber.Text);
                Console.WriteLine("A콤보박스 사이즈 확인: " + numA);
                for (int i = 0; i < numA; i++)
                {
                    listA.Add(cbB_aSelectedColumnName.Items[i].ToString());
                    Console.WriteLine("살릴 컬럼 이름 : {0}", cbB_aSelectedColumnName.Items[i].ToString());
                }

                List<string> colNameList = new List<string>();
                colNameList = GetColumnName(selectedRangeOf_dtA).Distinct().ToList();
                List<string> colNameListString = new List<string>();
                foreach (var str in colNameList)
                {
                    colNameListString.Add(str.ToString());
                    Console.WriteLine("전체 컬럼 이름 : {0}", str.ToString());
                }

                List<string> minuscolNameListString = new List<string>();
                minuscolNameListString = colNameListString.Except(listA).ToList();

                foreach (var str in minuscolNameListString)
                {
                    Console.WriteLine("차집합 컬럼 이름 : {0}", str.ToString());
                }

                var colTotalNum = minuscolNameListString.Count;
                for(int i =0; i < colTotalNum; i++)
                {
                    selectedRangeOf_dtA.Columns.Remove(minuscolNameListString[i].ToString());
                    Console.WriteLine(minuscolNameListString[i].ToString()+"삭제완료");

                }


                selectedRangeOf_dtA.AcceptChanges();
                //------------------------------------------------------------------- selectedRangeOf_dtB에서 사용자가 선택한 열 이외의 행들은 모두 지워버림------------------------------------------------------------------
                selectedRangeOf_dtB.AcceptChanges();

                List<string> listB = new List<string>();
                int numB = Convert.ToInt32(tb_selectedColumnNumber.Text);
                Console.WriteLine("A콤보박스 사이즈 확인: " + numB);
                for (int i = 0; i < numB; i++)
                {
                    listB.Add(cbB_bSelectedColumnName.Items[i].ToString());
                    Console.WriteLine("살릴 컬럼 이름 : {0}", cbB_bSelectedColumnName.Items[i].ToString());
                }

                List<string> colNameListB = new List<string>();
                colNameListB = GetColumnName(selectedRangeOf_dtB).Distinct().ToList();
                List<string> colNameListStringB = new List<string>();
                foreach (var str in colNameListB)
                {
                    colNameListStringB.Add(str.ToString());
                    Console.WriteLine("전체 컬럼 이름 : {0}", str.ToString());
                }

                List<string> minuscolNameListStringB = new List<string>();
                minuscolNameListStringB = colNameListStringB.Except(listB).ToList();

                foreach (var str in minuscolNameListStringB)
                {
                    Console.WriteLine("차집합 컬럼 이름 : {0}", str.ToString());
                }

                var colTotalNumB = minuscolNameListStringB.Count;
                for (int i = 0; i < colTotalNumB; i++)
                {
                    selectedRangeOf_dtB.Columns.Remove(minuscolNameListStringB[i].ToString());
                    Console.WriteLine(minuscolNameListStringB[i].ToString() + "삭제완료");

                }

                selectedRangeOf_dtB.AcceptChanges();
                //--------------------------------------------------------------------selectedRangeOf_dtA의 내용에서 selectedRangeOf_dtB 내용들을 빼기 하는 부분-------------------------------------------------------------------------------------------
                if (selectedRangeOf_dtA.Columns.Contains("lineNum"))
                    selectedRangeOf_dtA.Columns.Remove("lineNum");
                if (selectedRangeOf_dtB.Columns.Contains("lineNum"))
                    selectedRangeOf_dtB.Columns.Remove("lineNum");

                preProcessedDt = selectedRangeOf_dtA.Copy(); //형식 복사
                for (int num=0; num <= selectedRangeOf_dtA.Columns.Count-1; num++)
                {
                    preProcessedDt.Columns[num].ColumnName = (selectedRangeOf_dtA.Columns[num]+" - "+selectedRangeOf_dtB.Columns[num]);
                }
                //preProcessedDt.AcceptChanges();

                for (int rowNum = 0; rowNum <= selectedRangeOf_dtA.Rows.Count - 1; rowNum++)
                {
                    for (int columnNum = 0; columnNum <= selectedRangeOf_dtA.Columns.Count-1 ; columnNum++)
                    {
                        preProcessedDt.Rows[rowNum][columnNum] = (Int32.Parse(selectedRangeOf_dtA.Rows[rowNum][columnNum].ToString()) - Int32.Parse(selectedRangeOf_dtB.Rows[rowNum][columnNum].ToString())).ToString();
                    }
                }

                dgv_3.DataSource = preProcessedDt;  // preProcessedDt = selectedRangeOf_dtA - selectedRangeOf_dtB
            }
            else
                MessageBox.Show("'A파일의 시작 행과 끝 행' 그리고 'B파일의 시작 행'을 모두 선택해 주십시오.");
        }
        // 전처리 완료된 preProcessedDt의 맨 끝에   "lineratio" , "Te"  column을 추가하고  preProcessedDt의 내부 요소들로 lineratio와 전자온도를 구하는 함수
        private void CalculateLineRatioAndTeThenAddToPreProcessedDt_test()
        {
            preProcessedDt.Columns.Add("lineRatio");
            preProcessedDt.Columns.Add("Te");

            for (int rowNum = 0; rowNum <= preProcessedDt.Rows.Count - 1; rowNum++)
            {
                preProcessedDt.Rows[rowNum]["lineRatio"] = double.Parse(preProcessedDt.Rows[rowNum][0].ToString()) / double.Parse(preProcessedDt.Rows[rowNum][1].ToString());  // line ratio를 구해서 preProcessedDt의 "lineRatio" column 부분에 차곡차곡 데이터를 입력 
                preProcessedDt.Rows[rowNum]["Te"] = -2 / Math.Log(double.Parse(preProcessedDt.Rows[rowNum][0].ToString()) / double.Parse(preProcessedDt.Rows[rowNum][1].ToString()));  //  electron temperature를 구해서 preProcessedDt의 "Te" column 부분에 차곡차곡 데이터를 입력
            }

            dgv_3.DataSource = preProcessedDt;

        }

        private void dgv_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
