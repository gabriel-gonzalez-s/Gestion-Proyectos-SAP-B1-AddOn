using SAPbouiCOM.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using excel = Microsoft.Office.Interop.Excel;

namespace FuncionalidadesSDKB1
{
    public static class DataTableExtensions
    {
        public static SAPbouiCOM.DataTable GetDataTableFromCLF(SAPbouiCOM.ItemEvent oEvent, SAPbouiCOM.Form oForm)
        {
            SAPbouiCOM.ChooseFromListEvent event2 = (SAPbouiCOM.ChooseFromListEvent)oEvent;
            string chooseFromListUID = event2.ChooseFromListUID;
            SAPbouiCOM.ChooseFromList list = oForm.ChooseFromLists.Item(chooseFromListUID);
            return event2.SelectedObjects;
        }

        public static void JoinDataTables(SAPbouiCOM.DataTable DT1, SAPbouiCOM.DataTable DT2)
        {
            try
            {
                for (int iRow = 0; iRow <= DT2.Rows.Count - 1; iRow++)
                {
                    DT1.Rows.Add();
                    int nRow = DT1.Rows.Count - 1;

                    for (int iCol = 0; iCol <= DT2.Columns.Count - 1; iCol++)
                    {
                        try
                        {
                            DT1.SetValue(iCol, nRow, DT2.GetValue(iCol, iRow));
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        public static void DatatableSAP_a_Excel(SAPbouiCOM.DataTable DataTable)
        {
            try
            {
                SAPbouiCOM.ProgressBar oProgBar = null;
                Microsoft.Office.Interop.Excel.Application _excel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook wBook;//= default(Microsoft.Office.Interop.Excel.Workbook);
                Microsoft.Office.Interop.Excel._Worksheet wSheet;//= default(Microsoft.Office.Interop.Excel.Worksheet);

                wBook = (excel.Workbook)(_excel.Workbooks.Add(""));
                wSheet = (excel.Worksheet)_excel.ActiveSheet;

                int colIndex = 0;
                int rowIndex = 0;

                // Crea Progress Bar
                ProgressBarExtensions.Create_ProgressBar(ref oProgBar, "Generando Columnas Excel", DataTable.Columns.Count);

                int ind = 0;

                for (int i = 1; i <= DataTable.Columns.Count; i++)
                {
                    colIndex = colIndex + 1;
                    _excel.Cells[1, colIndex] = DataTable.Columns.Item(i - 1).Name;
                    ind += 1;
                    // Actualiza Progress Bar
                    ProgressBarExtensions.Increment_ProgressBar(ref oProgBar, 1);
                }

                // Cierra Progress Bar
                ProgressBarExtensions.Close_ProgressBar(ref oProgBar);


                // Crea Progress Bar
                ProgressBarExtensions.Create_ProgressBar(ref oProgBar, "Generando Filas Excel", DataTable.Rows.Count);

                for (int i = 0; i <= DataTable.Rows.Count - 1; i++)
                {
                    rowIndex = rowIndex + 1;
                    colIndex = 0;

                    for (int c = 1; c <= DataTable.Columns.Count; c++)
                    {
                        colIndex = colIndex + 1;
                        var Value = DataTable.GetValue(c - 1, i).ToString();
                        double dValue = double.TryParse(Value.Replace(".", ""), out dValue) ? dValue : 0;
                        Value = dValue == 0 ? Value : dValue.ToString();
                        _excel.Cells[rowIndex + 1, colIndex] = Value ;
                    }

                    // Actualiza Progress Bar
                    ProgressBarExtensions.Increment_ProgressBar(ref oProgBar, 1);

                }

                // Cierra Progress Bar
                ProgressBarExtensions.Close_ProgressBar(ref oProgBar);

                wSheet.Columns.AutoFit();

                _excel.Visible = true;
                _excel.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized;

            }
            catch (Exception) { }


            //Dim strFileName As String = "C:\datatable.xlsx"
            //If System.IO.File.Exists(strFileName) Then
            // System.IO.File.Delete(strFileName)
            //End If

            //wBook.SaveAs(strFileName)
            //wBook.Close()
            //_excel.Quit()
        }
    }
}
