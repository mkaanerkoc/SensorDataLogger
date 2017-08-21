using Microsoft.Office.Interop.Excel;
using SensorDataLogger.Dialogs;
using SensorDataLogger.StructObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorDataLogger.Utilities
{
    public sealed class ExcelManager
    {
        private static ExcelManager instance = null;
        private static readonly object padlock = new object();
        private List<object> dataBuffer;
        private Thread thread;

        /*Logging Variables*/
        private string fileName = "";
        private string filePath = "";
        private byte deviceType = 0;
        private UInt32 lastRowIndex = AppConstants.INITIAL_LOG_ROW;

        public ExcelManager()
        {
            
        }

        public static ExcelManager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ExcelManager();
                    }
                    return instance;
                }
            }
        }

        public void StartNewFileThread(Int16 DeviceType,
                                        string OperatorName,
                                        string FabrikaIsmi,
                                        string BacaIsmi,
                                        string DateTimeStr,
                                        string FileNameStr,
                                        string FilePath)
        {
            thread = new Thread(()=>this.CreateWorkFile( DeviceType,OperatorName,FabrikaIsmi, BacaIsmi,DateTimeStr,FileNameStr, FilePath));
            thread.Start();
            return;
        }

        /*
         *  CreateWorkFile - Creates a new Excel file and writes given parameters to file header tab.
         *  
         *  @Params
         *   Int16 DeviceType       (input)   - 
         *   string OperatorName    (input)   -
         *   string Sehir           (input)   -
         *   string FabrikaIsmi     (input)   -
         *   string BacaIsmi        (input)   - 
         *   string DateTimeStr     (input)   -
         *      
         *  @Return - int
         * 
         */
        public int CreateWorkFile(  Int16 DeviceType,
                                    string OperatorName,
                                    string FabrikaIsmi,
                                    string BacaIsmi,
                                    string DateTimeStr,
                                    string FileNameStr,
                                    string FilePath)
        {

            Microsoft.Office.Interop.Excel.Application oXL = new
            Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook oWB = null;

            this.fileName = FileNameStr;
            this.filePath = FilePath;
            this.deviceType = (byte)(DeviceType + 1);

            if (oXL == null)
            {
                MessageBox.Show("Excel düzgün şekilde yüklenmemiş. Çıkılıyor !");
                return -1;
            }
            try
            {
                //oXL.Visible = true;

                Workbook wb = oXL.Workbooks.Add(Type.Missing);
                Worksheet sh;
                if (wb.Sheets.Count > 1)
                {
                    sh = wb.Sheets[0];
                }
                else
                {
                    sh = wb.Sheets.Add();
                    sh.Name = "DATA";
                }
                //Create frame
                for (int i = 1; i < 15; i++)
                {
                    sh.Cells[1, i].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                }
                for (int i = 1; i < 10; i++)
                {
                    sh.Cells[i, 14].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                }
                for (int i = 1; i < 15; i++)
                {
                    sh.Cells[9, i].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                }
                for (int i = 1; i < 10; i++)
                {
                    sh.Cells[i, 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                }

                //Set Widths
                //sh.Columns[5].ColumnWidth = 30;
                //sh.Columns[6].ColumnWidth = 30;

                sh.Range[sh.Cells[3, 5], sh.Cells[3, 6]].Merge();
                sh.Range[sh.Cells[3, 7], sh.Cells[3, 8]].Merge();
                sh.Range[sh.Cells[4, 5], sh.Cells[4, 6]].Merge();
                sh.Range[sh.Cells[4, 7], sh.Cells[4, 8]].Merge();
                sh.Range[sh.Cells[5, 5], sh.Cells[5, 6]].Merge();
                sh.Range[sh.Cells[5, 7], sh.Cells[5, 8]].Merge();
                sh.Range[sh.Cells[6, 5], sh.Cells[6, 6]].Merge();
                sh.Range[sh.Cells[6, 7], sh.Cells[6, 8]].Merge();
                sh.Range[sh.Cells[7, 5], sh.Cells[7, 6]].Merge();
                sh.Range[sh.Cells[7, 7], sh.Cells[7, 8]].Merge();

                sh.Range[sh.Cells[3, 5], sh.Cells[7, 8]].Cells.HorizontalAlignment =
                 Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sh.Range[sh.Cells[3, 5], sh.Cells[7, 8]].Cells.Font.Size = 14;

                sh.Cells[2, 5] = "Cihaz Türü ";
                sh.Cells[2, 7] = (DeviceType == AppConstants.PG250_TYPE)? "PG250":"PG300";

                sh.Cells[3, 5] = "Operatör İsmi ";
                sh.Cells[3, 7] = OperatorName;

                sh.Cells[4, 5] = "Şehir";
                sh.Cells[4, 7] = FabrikaIsmi.Split(',')[1];

                sh.Cells[5, 5] = "Fabrika ";
                sh.Cells[5, 7] = FabrikaIsmi.Split(',')[0];

                sh.Cells[6, 5] = "Baca İsmi ";
                sh.Cells[6, 7] = BacaIsmi;

                sh.Cells[7, 5] = "Saat / Tarih";
                sh.Cells[7, 7] = DateTimeStr;
                //oSheet.Cells[row, col] = data;
                //

                //Cihaza has Parametre Headerlarının yazıldıgı bölüm
                if (this.deviceType == AppConstants.PG250_TYPE)
                {
                    int k = 1;
                    
                    foreach (string header in AppConstants.PG250_HEADERS)
                    {
                        sh.Columns[k].ColumnWidth = 20;
                        sh.Cells[AppConstants.INITIAL_LOG_ROW, k] = header;
                        sh.Cells[AppConstants.INITIAL_LOG_ROW, k].Font.Size = 16;
                        sh.Cells[AppConstants.INITIAL_LOG_ROW, k].Font.Bold = true;
                        sh.Cells[AppConstants.INITIAL_LOG_ROW, k].Interior.Color = Color.LightSkyBlue;
                        sh.Cells[AppConstants.INITIAL_LOG_ROW, k].HorizontalAlignment =
                 Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        k++;
                    }
                }
                else if (this.deviceType == AppConstants.PG300_TYPE)
                {
                    int k = 1;
                    foreach (string header in AppConstants.PG300_HEADERS)
                    {
                        sh.Cells[AppConstants.INITIAL_LOG_ROW, k] = header;
                        k++;
                    }
                }

                wb.SaveAs(FilePath+"/"+FileNameStr);
                wb.Close();
                oXL.Quit();

                MessageBox.Show("Done!");
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return -1;
            }
            finally
            {
                if (oWB != null)
                    oWB.Close();
            }
           
        }

        private void OpenWorkFile()
        {

        }

        public void ValidateWorkFile(string filename)
        {
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet;
            try
            {
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filename);
                xlWorksheet = xlWorkbook.ActiveSheet;
                Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            }
            catch(Exception eee)
            {
                MessageBox.Show("Dosya açılamadı ! " + eee.Message);
                return;
            }

            Console.WriteLine((string)xlWorksheet.Cells[2, 7].Value2);
            using (var form = new OldRecordInformationDialog((string)xlWorksheet.Cells[2, 7].Value2,
                                                                (string)xlWorksheet.Cells[3, 7].Value2,
                                                                (string)xlWorksheet.Cells[4, 7].Value2,
                                                                (string)xlWorksheet.Cells[5, 7].Value2,
                                                                (string)xlWorksheet.Cells[6, 7].Value2,
                                                                (string)xlWorksheet.Cells[3, 7].Value2,
                                                                (string)xlWorksheet.Cells[3, 7].Value2))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //OperatorModel newOperator = form.operatorModel;            //values preserved after close
                    //userList.Items.Add(newOperator.Name + " " + newOperator.Surname + " - " + newOperator.ID);
                }
            }

        }
        
        public void AppendLog(byte DeviceType,object DataObject)
        {
            if(this.deviceType  == DeviceType)
            {
                dataBuffer.Add(DataObject);
                if(dataBuffer.Count>AppConstants.MAXIMUM_BUFFER_SIZE)
                {
                    SaveBufferOnWorkFile();
                }
            }
            else
            {
                Console.WriteLine("Kayıtlı olmayan bir cihaz türü seçilmiş");
                return;
            }
        }

        private void SaveBufferOnWorkFile()
        {
            if(this.deviceType == AppConstants.PG250_TYPE)
            {

            }
            else if(this.deviceType == AppConstants.PG300_TYPE)
            {

            }
        }


        private void GetLastRawIndex()
        {

        }
        private void StartLogging()
        {
            dataBuffer = new List<object>();

        }

        private void PauseLogging()
        {

        }

        /*
         * Loglama işlemini bitirir ve excelin son halini kaydeder.
         * 
         * 
         * 
         * 
         * 
        */    
        private void FinishLogging()
        {

        }

    }
}
