using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionalidadesSDKB1
{
    public static class ComboBoxExtensions
    {
        public static SAPbouiCOM.ComboBox GetComboBoxMatrix(SAPbouiCOM.Matrix oMatrix,string Column, int nRow)
        {
            SAPbouiCOM.ComboBox oComboBox = null;
            try
            {
                oComboBox = (SAPbouiCOM.ComboBox)oMatrix.Columns.Item(Column).Cells.Item(nRow).Specific;
                //SAPbouiCOM.ComboBox oComboBox = (SAPbouiCOM.ComboBox)((SAPbouiCOM.Column)Matrix0.Columns.Item("C_0_3")).Cells.Item(pVal.Row).Specific;
            }
            catch (Exception) { }
            return oComboBox;
        }

        public static void LoadComboQueryRecordset(string _query, dynamic oComboBox, string fieldValue, string fieldDesc, SAPbobsCOM.Company oCompany)
        {
            SAPbobsCOM.Recordset businessObject = (SAPbobsCOM.Recordset)oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
            businessObject.DoQuery(_query);
            SAPbouiCOM.ValidValues validValues = oComboBox.ValidValues;

            CleanComboBox(oComboBox);

            if (!string.Equals(fieldDesc, string.Empty))
            {
                while (!businessObject.EoF)
                {
                    validValues.Add((dynamic)businessObject.Fields.Item(fieldValue).Value, (dynamic)businessObject.Fields.Item(fieldDesc).Value);
                    businessObject.MoveNext();
                }
            }
            else
            {
                while (!businessObject.EoF)
                {
                    validValues.Add((dynamic)businessObject.Fields.Item(fieldValue).Value, "");
                    businessObject.MoveNext();
                }
            }
        }

        public static void LoadComboQueryDataTable(dynamic oComboBox, SAPbouiCOM.DataTable oDataTable, string Query, int ValorValue, int ValorDescription, bool ValorVacio)
        {
            try
            {
                oDataTable.ExecuteQuery(Query);

                if (ValorVacio)  // Agrega primera linea de ComboBox Vacia
                    oComboBox.ValidValues.Add("", "");

                for (int i = 0; i <= oDataTable.Rows.Count - 1; i++)
                {
                    oComboBox.ValidValues.Add(Convert.ToString(oDataTable.GetValue(ValorValue, i)), Convert.ToString(oDataTable.GetValue(ValorDescription, i)));
                }

            }
            catch (Exception) { }

        }

        public static void CleanComboBox(dynamic oComboBox)
        {
            int i = 0;

            while (oComboBox.ValidValues.Count > 0)
            {
                try
                {
                    oComboBox.ValidValues.Remove(i, SAPbouiCOM.BoSearchKey.psk_Index);
                }
                catch (Exception) { }
            }
        }

    }
}
