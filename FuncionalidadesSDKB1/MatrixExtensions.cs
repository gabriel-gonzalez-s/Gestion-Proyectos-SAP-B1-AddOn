using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SAPbouiCOM.Framework;

namespace FuncionalidadesSDKB1
{
    public static class MatrixExtensions
    {
        private static SAPbouiCOM.EditText oEdit;

        public static void SetCellValue(SAPbouiCOM.Matrix oMatrix, string Column, int nRow, string Value)
        {
            try
            {
                ((SAPbouiCOM.EditText)oMatrix.Columns.Item(Column).Cells.Item(nRow).Specific).Value = Value;
            }
            catch (Exception ) { }
        }

        public static string GetCellValue(SAPbouiCOM.Matrix oMatrix, string Column, int nRow)
        {
            string value = "";
            try
            {
                value = ((SAPbouiCOM.EditText)oMatrix.Columns.Item(Column).Cells.Item(nRow).Specific).Value;
            }
            catch (Exception) { }
            return value;
        }
        public static void SelectMatrixRow(ref SAPbouiCOM.Matrix oMatrix, int RowNum)
        {
            try
            {
                oMatrix.SelectRow(RowNum, true, false);
            }
            catch (Exception ) { }
        }

        public static void SetFocusCell (SAPbouiCOM.Matrix oMatrix, dynamic Columnn ,int nRow)
        {
            try
            {
                oEdit = (SAPbouiCOM.EditText)oMatrix.Columns.Item(Columnn).Cells.Item(nRow).Specific;
                oEdit.Active = true;
                oEdit.Item.Enabled = true;
            }
            catch (Exception) { }
        }

        public static void SelectMatrixRowSetFocus(ref SAPbouiCOM.Matrix oMatrix, dynamic Columnn, int RowNum)
        {
            SelectMatrixRow(ref oMatrix, RowNum);
            SetFocusCell(oMatrix, Columnn, RowNum);
        }


        public static void AddLineMatrixDBDataSource(SAPbouiCOM.Matrix oMatrix, SAPbouiCOM.DBDataSource source, string ColumnaFocus = "")
        {
            try
            {
                oMatrix.FlushToDataSource();
                source.InsertRecord(source.Size);
                source.Offset = source.Size - 1;
                oMatrix.LoadFromDataSource();
                oMatrix.SelectRow(source.Size, true, false);
                if (ColumnaFocus.Trim().Length != 0)
                {
                    oEdit = (SAPbouiCOM.EditText)oMatrix.Columns.Item(ColumnaFocus).Cells.Item(source.Size).Specific;
                    oEdit.Active = true;
                    oEdit.Item.Enabled = true;
                }
            }
            catch (Exception) { }
        }

        public static void SetCellValueDBDataSource(SAPbouiCOM.Matrix oMatrix, string Column, int nRow, string Value,SAPbouiCOM.DBDataSource oDBDSource, string DBDataSourceField)
        {
            try
            {
                ((SAPbouiCOM.EditText)oMatrix.Columns.Item(Column).Cells.Item(nRow).Specific).Value = Value;
                oMatrix.FlushToDataSource();
                oDBDSource.SetValue(DBDataSourceField, nRow - 1, Value);
                oMatrix.LoadFromDataSource();
            }
            catch (Exception) { }
        }
    }
}
