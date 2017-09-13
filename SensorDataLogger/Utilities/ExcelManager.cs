using Microsoft.Office.Interop.Excel;
using SensorDataLogger.Devices;
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

        private PG250ExcelRowModel[] pg250ExcelBuffer = new PG250ExcelRowModel[10];
        private PG300ExcelRowModel[] pg300ExcelBuffer = new PG300ExcelRowModel[10];
        private int pg250ExcelIndex = 0;
        private int pg300ExcelIndex = 0;
        private UInt64 pg250ExcelLastIndex = AppConstants.INITIAL_LOG_ROW;
        private UInt64 pg300ExcelLastIndex = AppConstants.INITIAL_LOG_ROW;

        /*Logging Variables*/
        private string fileName = "";
        private string filePath = "";
        private byte deviceType = 0;
        private UInt32 lastRowIndex = AppConstants.INITIAL_LOG_ROW;



        //Excel Variables//
        Microsoft.Office.Interop.Excel.Application oXL;
        Workbook oWB;
        public ExcelManager()
        {
            oWB = null;
            oXL = new Microsoft.Office.Interop.Excel.Application();
            oXL.DisplayAlerts = false;
            
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
            this.fileName = FilePath + "/" + FileNameStr;
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
                oWB = oXL.Workbooks.Add(Type.Missing);
                Worksheet sh;
                if (oWB.Sheets.Count > 1)
                {
                    sh = oWB.Sheets[0];
                }
                else
                {
                    sh = oWB.Sheets.Add();
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

                sh.Range[sh.Cells[2, 3], sh.Cells[2, 4]].Merge();
                sh.Range[sh.Cells[2, 5], sh.Cells[2, 6]].Merge();
                sh.Range[sh.Cells[3, 3], sh.Cells[3, 4]].Merge();
                sh.Range[sh.Cells[3, 5], sh.Cells[3, 6]].Merge();
                sh.Range[sh.Cells[4, 3], sh.Cells[4, 4]].Merge();
                sh.Range[sh.Cells[4, 5], sh.Cells[4, 6]].Merge();
                sh.Range[sh.Cells[5, 3], sh.Cells[5, 4]].Merge();
                sh.Range[sh.Cells[5, 5], sh.Cells[5, 6]].Merge();
                sh.Range[sh.Cells[6, 3], sh.Cells[6, 4]].Merge();
                sh.Range[sh.Cells[6, 5], sh.Cells[6, 6]].Merge();
                sh.Range[sh.Cells[7, 3], sh.Cells[7, 4]].Merge();
                sh.Range[sh.Cells[7, 5], sh.Cells[7, 6]].Merge();

                sh.Range[sh.Cells[2, 3], sh.Cells[7, 8]].Cells.HorizontalAlignment =
                 Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                sh.Range[sh.Cells[2, 3], sh.Cells[7, 8]].Cells.Font.Size = 14;

                sh.Cells[2, 3] = "Cihaz Türü ";
                sh.Cells[2, 5] = (DeviceType == AppConstants.PG250_TYPE)? "PG250":"PG300";

                sh.Cells[3, 3] = "Operatör İsmi ";
                sh.Cells[3, 5] = OperatorName;

                sh.Cells[4, 3] = "Şehir";
                sh.Cells[4, 5] = FabrikaIsmi.Split(',')[1].Split('-')[0];

                sh.Cells[5, 3] = "Tesis Ismi ";
                sh.Cells[5, 5] = FabrikaIsmi.Split(',')[0];

                sh.Cells[6, 3] = "Ölçüm Noktası  ";
                sh.Cells[6, 5] = BacaIsmi;

                sh.Cells[7, 3] = "Saat / Tarih";
                sh.Cells[7, 5] = DateTimeStr;
                //oSheet.Cells[row, col] = data;
                //

                //Cihaza has Parametre Headerlarının yazıldıgı bölüm
                if (DeviceType == AppConstants.PG250_TYPE)
                {
                    int k = 1;
                    Range oRange = sh.get_Range("A11", "M11");
                    oRange.Cells.Font.Size = 16;
                    oRange.Cells.Font.Bold = true;
                    oRange.Interior.Color = Color.LightSkyBlue;
                    oRange.WrapText = true;
                    oRange.HorizontalAlignment  = XlHAlign.xlHAlignCenter;
                    oRange.VerticalAlignment    = XlVAlign.xlVAlignCenter;
                    oRange.Borders.get_Item(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlContinuous;
                    oRange.Borders.get_Item(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlContinuous;
                    oRange.Borders.get_Item(XlBordersIndex.xlInsideHorizontal).LineStyle = XlLineStyle.xlContinuous;
                    oRange.Borders.get_Item(XlBordersIndex.xlInsideVertical).LineStyle = XlLineStyle.xlContinuous;
                    foreach (string header in AppConstants.PG250_HEADERS)
                    {
                        sh.Columns[k].ColumnWidth = 20;
                        sh.Cells[AppConstants.INITIAL_LOG_ROW, k] = header;
                        k++;
                    }
                }
                else if (DeviceType == AppConstants.PG300_TYPE)
                {
                    int k = 1;
                    Range oRange = sh.get_Range("A11", "AD11");
                    oRange.Cells.Font.Size = 16;
                    oRange.Cells.Font.Bold = true;
                    oRange.Interior.Color = Color.LightSkyBlue;
                    oRange.WrapText = true;
                    oRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    oRange.VerticalAlignment = XlVAlign.xlVAlignCenter;
                    oRange.Borders.get_Item(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlContinuous;
                    oRange.Borders.get_Item(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlContinuous;
                    oRange.Borders.get_Item(XlBordersIndex.xlInsideHorizontal).LineStyle = XlLineStyle.xlContinuous;
                    oRange.Borders.get_Item(XlBordersIndex.xlInsideVertical).LineStyle = XlLineStyle.xlContinuous;
                    foreach (string header in AppConstants.PG300_HEADERS)
                    {
                        sh.Columns[k].ColumnWidth = 20;
                        sh.Cells[AppConstants.INITIAL_LOG_ROW, k] = header;
                        k++;
                    }
                }

                oWB.SaveAs(fileName);
                oWB.Close();
                oXL.Quit();

                //MessageBox.Show("Done!");
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return -1;
            }
            finally
            {
              
            }
        }

        private void OpenWorkFile()
        {

        }

        public int ValidateWorkFile(string filename)
        {
            
            Worksheet xlWorksheet;
            Workbook xlWorkbook;
            try
            {
                xlWorkbook = oXL.Workbooks.Open(filename);
                xlWorksheet = xlWorkbook.ActiveSheet;
            }
            catch(Exception eee)
            {
                MessageBox.Show("Dosya açılamadı ! " + eee.Message);
                return 0;
            }
            UInt64 lastRow = GetLastRow(xlWorksheet);
            Console.WriteLine((string)xlWorksheet.Cells[2, 5].Value2);
            string deviceName = (string)xlWorksheet.Cells[2, 5].Value2;
            using (var form = new OldRecordInformationDialog((string)xlWorksheet.Cells[2, 5].Text.ToString(),
                                                                (string)xlWorksheet.Cells[3, 5].Text.ToString(),
                                                                (string)xlWorksheet.Cells[4, 5].Text.ToString(),
                                                                (string)xlWorksheet.Cells[5, 5].Text.ToString(),
                                                                (string)xlWorksheet.Cells[6, 5].Text.ToString(),
                                                                (string)xlWorksheet.Cells[7, 5].Text.ToString(),
                                                                (string)xlWorksheet.Cells[lastRow-1, 1].Text.ToString()+" "+(string)xlWorksheet.Cells[lastRow - 1, 2].Text.ToString()))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    fileName = filename;
                    //OperatorModel newOperator = form.operatorModel;            //values preserved after close
                    //userList.Items.Add(newOperator.Name + " " + newOperator.Surname + " - " + newOperator.ID);
                    //TODO: BURADA PG250 YADA PG300 EKRANI AÇILACAK
                    Console.WriteLine("The last Row Index : {0}", lastRow);
                    xlWorkbook.Close();
                    if(deviceName.Equals("PG250"))
                    {
                        return 10;
                    }
                    else if(deviceName.Equals("PG300"))
                    {
                        return 11;
                    }
                    else
                    {
                        return 0;
                    }
                    
                }
                else
                {
                    xlWorkbook.Close();
                    return 0;
                }
               
            }
            
        }

        public UInt64 GetLastRow(Worksheet ws)
        {
            UInt64 lastRowIndex = 11;
            if (ws == null)
            {
                MessageBox.Show("Lütfen geçerli bir excel dosyası seçin");
                return 0;
            }
            while (ws.Cells[lastRowIndex, 1].Value2!=null)
            {
                lastRowIndex++;
            }
            return lastRowIndex;
        }

        public void AppendLog(byte DeviceType,object DataObject)
        {
            if(AppConstants.PG250_TYPE  == DeviceType)
            {
                pg250ExcelBuffer[pg250ExcelIndex++] = (PG250ExcelRowModel)DataObject;
                if(pg250ExcelIndex == AppConstants.MAXIMUM_BUFFER_SIZE)
                {
                    SaveBufferOnWorkFile(DeviceType);
                    pg250ExcelIndex = 0;
                }
            }
            else if(AppConstants.PG300_TYPE == DeviceType)
            {
                pg300ExcelBuffer[pg300ExcelIndex++] = (PG300ExcelRowModel)DataObject;
                if (pg300ExcelIndex == AppConstants.MAXIMUM_BUFFER_SIZE)
                {
                    SaveBufferOnWorkFile(DeviceType);
                    pg300ExcelIndex = 0;
                }
            }
            else
            {
                Console.WriteLine("Kayıtlı olmayan bir cihaz türü seçilmiş");
                return;
            }
        }

        private void SaveBufferOnWorkFile(byte DeviceType)
        {
            Worksheet xs;
            Workbook xlWorkbook;
            try
            {
                xlWorkbook = oXL.Workbooks.Open(fileName);
                xs = xlWorkbook.ActiveSheet;
            }
            catch (Exception eee)
            {
                MessageBox.Show("Dosya açılamadı ! " + eee.Message);
                return;
            }
            UInt64 lastRow = GetLastRow(xs);
            Console.WriteLine("The last Row Index : {0}", lastRow); 
            // ONLY CODE HERE !!!
            if (DeviceType == AppConstants.PG250_TYPE)
            {
                
                for (ulong i = 0; i < 10; i++)
                {
                    xs.Cells[lastRow + i, 1] = pg250ExcelBuffer[i].date;
                    xs.Cells[lastRow + i, 2] = pg250ExcelBuffer[i].time;
                    xs.Cells[lastRow + i, 3] = pg250ExcelBuffer[i].pg250Channels[0].Value;
                    xs.Cells[lastRow + i, 4] = pg250ExcelBuffer[i].pg250Channels[1].Value;
                    xs.Cells[lastRow + i, 5] = pg250ExcelBuffer[i].pg250Channels[2].Value;
                    xs.Cells[lastRow + i, 6] = pg250ExcelBuffer[i].pg250Channels[3].Value;
                    xs.Cells[lastRow + i, 7] = pg250ExcelBuffer[i].pg250Channels[4].Value;
                    xs.Cells[lastRow + i, 8] = pg250ExcelBuffer[i].pg250Channels[5].Value;
                    xs.Cells[lastRow + i, 9] = pg250ExcelBuffer[i].pg250Channels[6].Value;
                    xs.Cells[lastRow + i, 10] = pg250ExcelBuffer[i].pg250Channels[7].Value;
                    xs.Cells[lastRow + i, 11] = pg250ExcelBuffer[i].pg250Channels[8].Value;
                    xs.Cells[lastRow + i, 12] = pg250ExcelBuffer[i].pg250Diag.FLOW;
                    xs.Cells[lastRow + i, 13] = pg250ExcelBuffer[i].pg250Diag.NDIR;
                }
                xlWorkbook.Save();
                xlWorkbook.Close();
            }
            else if(DeviceType == AppConstants.PG300_TYPE)
            {
                for (ulong i = 0; i < 10; i++)
                {
                    xs.Cells[lastRow + i, 1] = pg300ExcelBuffer[i].date;
                    xs.Cells[lastRow + i, 2] = pg300ExcelBuffer[i].time;
                    xs.Cells[lastRow + i, 3] = pg300ExcelBuffer[i].pg300Channels[0].Value;
                    xs.Cells[lastRow + i, 4] = pg300ExcelBuffer[i].pg300Channels[1].Value;
                    xs.Cells[lastRow + i, 5] = pg300ExcelBuffer[i].pg300Channels[2].Value;
                    xs.Cells[lastRow + i, 6] = pg300ExcelBuffer[i].pg300Channels[3].Value;
                    xs.Cells[lastRow + i, 7] = pg300ExcelBuffer[i].pg300Channels[4].Value;
                    xs.Cells[lastRow + i, 8] = pg300ExcelBuffer[i].pg300Channels[5].Value;
                    xs.Cells[lastRow + i, 9] = pg300ExcelBuffer[i].pg300Channels[6].Value;
                    xs.Cells[lastRow + i, 10] = pg300ExcelBuffer[i].pg300Channels[7].Value;
                    xs.Cells[lastRow + i, 11] = pg300ExcelBuffer[i].pg300Channels[8].Value;
                    xs.Cells[lastRow + i, 12] = pg300ExcelBuffer[i].pg300Channels[9].Value;
                    xs.Cells[lastRow + i, 13] = pg300ExcelBuffer[i].pg300Channels[10].Value;
                    xs.Cells[lastRow + i, 14] = pg300ExcelBuffer[i].pg300Channels[11].Value;
                    xs.Cells[lastRow + i, 15] = pg300ExcelBuffer[i].pg300Channels[12].Value;
                    xs.Cells[lastRow + i, 16] = pg300ExcelBuffer[i].pg300Channels[13].Value;
                    xs.Cells[lastRow + i, 17] = pg300ExcelBuffer[i].pg300Channels[14].Value;
                    xs.Cells[lastRow + i, 18] = pg300ExcelBuffer[i].pg300Channels[15].Value;
                    xs.Cells[lastRow + i, 19] = pg300ExcelBuffer[i].pg300Channels[16].Value;
                    xs.Cells[lastRow + i, 20] = pg300ExcelBuffer[i].pg300Channels[17].Value;
                    xs.Cells[lastRow + i, 21] = pg300ExcelBuffer[i].pg300Channels[18].Value;
                    xs.Cells[lastRow + i, 22] = pg300ExcelBuffer[i].pg300Channels[19].Value;
                    xs.Cells[lastRow + i, 23] = pg300ExcelBuffer[i].pg300Diag.NDIRControlTemperature;
                    xs.Cells[lastRow + i, 24] = pg300ExcelBuffer[i].pg300Diag.O2ControlTemperature;
                    xs.Cells[lastRow + i, 25] = pg300ExcelBuffer[i].pg300Diag.CLAControlTemperature;
                    xs.Cells[lastRow + i, 26] = pg300ExcelBuffer[i].pg300Diag.NDIRCorrectionTemperature;
                    xs.Cells[lastRow + i, 27] = pg300ExcelBuffer[i].pg300Diag.InternalTemperature;
                    xs.Cells[lastRow + i, 28] = pg300ExcelBuffer[i].pg300Diag.ElectronicCoolerTemperature;
                    xs.Cells[lastRow + i, 29] = pg300ExcelBuffer[i].pg300Diag.AtmosphericPressure;
                    xs.Cells[lastRow + i, 30] = pg300ExcelBuffer[i].pg300Diag.FlowRate;
                }
                xlWorkbook.Save();
                xlWorkbook.Close();
            }
            else
            {
                Console.WriteLine("SaveBufferOnWorkFile() function called with undefined DeviceType param!!");
                return;
            }
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
        public void CloseExcelApplication()
        {
            oXL.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oXL);
        }

    }
}
