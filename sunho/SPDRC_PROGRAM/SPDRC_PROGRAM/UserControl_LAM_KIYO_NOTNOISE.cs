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
        DataTable dt_transpose = new DataTable();
        DataTable dt_Selected = new DataTable();
        DataTable dt_SelectedTrans = new DataTable();
        DataTable dt_preProcessed = new DataTable();
        DataTable dt_preProcessedTrans = new DataTable();

        Dictionary<string, long> dic300 = new Dictionary<string, long>();
        Dictionary<string, long> dic400 = new Dictionary<string, long>();
        Dictionary<string, long> dic700 = new Dictionary<string, long>();

        public UserControl_LAM_KIYO_NOTNOISE()
        {
            InitializeComponent();
            this.lineRatioGraph.Series.Clear();
        }

        /// <summary>
        /// aFileLoad 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_aFileLoad_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btn_aFileLoad_Clicked");
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                Console.WriteLine("w3");
                string filePath = "";

                filePath = dialog.FileName;
                Console.WriteLine(String.Format("{0} was imported by btn_aFileLoad_Click", filePath));

                if (filePath.EndsWith(".csv"))
                {
                    dtA = CSVconvertToDataTable(filePath);   // 이 함수 쓰려면 csv 파일 맨 윗줄의 cell이 하나라도 비어있으면 안됨.
                }
                else if (filePath.EndsWith(".xlsx") || filePath.EndsWith(".xls"))
                {
                    dtA = Xlsx_xlsConvertToDataTable(filePath);
                }
                else
                {
                    MessageBox.Show("Csv, Xlsx 파일만 허용됩니다.");
                    btn_aFileLoad_Click(sender, e);
                }
            }

        }

        /// <summary>
        /// CSV 파일을 읽으면 Datatable형태로 변경.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="dtType"></param>
        /// <returns></returns>
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
                    dgv_A.DataSource = dt;
                }
            }
            Console.WriteLine("Sueecss: CSV convert to datatable");
            //특정 행 삭제
            DeleteRow(dtA);
            return dt;
        }


        /// <summary>
        /// xlsx 파일을 읽으면 datatable형태로 변경.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="dtType"></param>
        /// <returns></returns>
        private DataTable Xlsx_xlsConvertToDataTable(string filePath)
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
                        excelsql = @"select * from[Sheet1$]";
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
            dgv_A.DataSource = excelTable;
            Console.WriteLine("Sueecss: xls || xlsx || csv convert to datatable");
            return excelTable;
        }

        /// <summary>
        /// 행렬변환버튼 클릭시 행렬변환 기능.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 행렬 변환 체크표시 체크 여부 확인
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            Console.WriteLine("Finish the RowColTranspose");
            return outputTable;
        }

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

        private void btn_DeleteRow_Click(object sender, EventArgs e)
        {
            DeleteRow(dtA);
        }

        /// <summary>
        /// 파장 폭 선택 콤보박스 채우기.
        /// </summary>
        /// <param name="inputTable"></param>
        /// <returns></returns>
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

            return outputTable;

        }

        /// <summary>
        /// 컬럼명 가져오기
        /// </summary>
        /// <param name="dt"></param>
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

        private void cbB_300Finish_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (double.Parse(cbB_300Finish.SelectedItem.ToString()) < double.Parse(cbB_300Start.SelectedItem.ToString()))
            {
                MessageBox.Show("앞 선택된 값보다는 큰 값을 선택하셔야 됩니다.");
                cbB_300Finish.SelectedIndex = cbB_300Start.SelectedIndex + 1;
            }
        }

        private void cbB_400Finish_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (double.Parse(cbB_400Finish.SelectedItem.ToString()) < double.Parse(cbB_400Start.SelectedItem.ToString()))
            {
                MessageBox.Show("앞 선택된 값보다는 큰 값을 선택하셔야 됩니다.");
                cbB_400Finish.SelectedIndex = cbB_400Start.SelectedIndex + 1;
            }
        }

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
                long maxLavel = 0 ;
                for (int i = 0; i <= inputTable.Rows.Count-1; i++)
                {
                    if( Int64.Parse(inputTable.Rows[i][index].ToString())>= maxLavel)
                    {
                        maxLavel = long.Parse(inputTable.Rows[i][index].ToString());
                    }
                }
                ++index;


                double strDouble;
                bool success = double.TryParse(str, out strDouble);
                if (double.Parse(strDouble.ToString()) >= 300 && (double.Parse(strDouble.ToString()) < 400))
                {
                    Console.WriteLine("300대: " + str + "열의 최대값은" + maxLavel);
                    dic300[str] = maxLavel;
                }

                if (double.Parse(strDouble.ToString()) >= 400 && double.Parse(strDouble.ToString()) <= 500)
                {
                    Console.WriteLine("400대: " + str + "열의 최대값은" + maxLavel);
                    dic400[str] = maxLavel;

                }
                if (double.Parse(strDouble.ToString()) >= 700 && double.Parse(strDouble.ToString()) <= 800)
                {
                    Console.WriteLine("700대: " + str + "열의 최대값은" + maxLavel);
                    dic700[str] = maxLavel;

                }
            }

            foreach (KeyValuePair<string, long> item in dic300)
            {
                Console.WriteLine("딕셔너리 300: [{0}:{1}]", item.Key, item.Value);
            }
            var maxValue3 = dic300.Values.Max();
            var keyOfMaxValue3 = dic300.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            Console.WriteLine("딕셔너리 300의 최대값은: [{0}:{1}]", keyOfMaxValue3, maxValue3);
            foreach (KeyValuePair<string, long> item in dic400)
            {
                Console.WriteLine("딕셔너리 400: [{0}:{1}]", item.Key, item.Value);
            }
            var maxValue4 = dic400.Values.Max();
            var keyOfMaxValue4 = dic400.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            Console.WriteLine("딕셔너리 400의 최대값은: [{0}:{1}]", keyOfMaxValue4, maxValue4);

            foreach (KeyValuePair<string, long> item in dic700)
            {
                Console.WriteLine("딕셔너리 700: [{0}:{1}]", item.Key, item.Value);
            }
            var maxValue7 = dic700.Values.Max();
            var keyOfMaxValue7 = dic700.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            Console.WriteLine("딕셔너리 700의 최대값은: [{0}:{1}]", keyOfMaxValue7, maxValue7);
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
            dt_preProcessedTrans.Columns.Add(lbl_300.Text +" / " + lbl_400.Text);
            dt_preProcessedTrans.Columns.Add(lbl_400.Text + " / " + lbl_700.Text);
            dt_preProcessedTrans.Columns.Add("Te");
            dt_preProcessedTrans.Columns.Add("ne");

            for (int rowNum = 0; rowNum <= dt_preProcessedTrans.Rows.Count - 1; rowNum++)
            {
                dt_preProcessedTrans.Rows[rowNum][lbl_300.Text + " / " + lbl_400.Text] = double.Parse(dt_preProcessedTrans.Rows[rowNum][2].ToString()) / double.Parse(dt_preProcessedTrans.Rows[rowNum][3].ToString());  
                dt_preProcessedTrans.Rows[rowNum][lbl_400.Text + " / " + lbl_700.Text] = double.Parse(dt_preProcessedTrans.Rows[rowNum][3].ToString()) / double.Parse(dt_preProcessedTrans.Rows[rowNum][4].ToString());
                dt_preProcessedTrans.Rows[rowNum]["Te"] = -1.2583 / Math.Log(double.Parse(dt_preProcessedTrans.Rows[rowNum][3].ToString()) / double.Parse(dt_preProcessedTrans.Rows[rowNum][4].ToString()));
                dt_preProcessedTrans.Rows[rowNum]["Ne"] = (Math.Exp(-0.56/ double.Parse(dt_preProcessedTrans.Rows[rowNum]["Te"].ToString())) - double.Parse(dt_preProcessedTrans.Rows[rowNum][lbl_300.Text + " / " + lbl_400.Text].ToString()) )/ ((1/(3*(10^11))* double.Parse(dt_preProcessedTrans.Rows[rowNum][lbl_300.Text + " / " + lbl_400.Text].ToString()))-((1/(2*10^10))*(Math.Exp(-0.56 / double.Parse(dt_preProcessedTrans.Rows[rowNum]["Te"].ToString()))))) ;
            }
        }
    }
}
