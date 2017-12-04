using SAPbouiCOM.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionalidadesSDKB1
{
    public static class ApplicationExtensions
    {
        public static string GetUserName(string sUserID, SAPbouiCOM.DataTable DataTable)
        {
            string sNombreUsu = "";
            string query = @"SELECT USERID,USER_CODE,U_NAME FROM OUSR WHERE USERID = '"+ sUserID + "'";
            
            try
            {
                DataTable.ExecuteQuery(query);
                sNombreUsu = DataTable.GetValue("U_NAME", 0).ToString();
            }
            catch (Exception) { }

            return sNombreUsu;

    }
        public static string CurrentUserName()
        {
            string sNombreUsu = "";
            SAPbouiCOM.Form oForm = Application.SBO_Application.Forms.GetForm("169", 0); //Toma la Descripcion del Usuario Actual del Menu Principal
            SAPbouiCOM.StaticText oStatic = (SAPbouiCOM.StaticText)oForm.Items.Item("8").Specific;
            sNombreUsu = oStatic.Caption;
            return (string)sNombreUsu;

        }

        public static string GetAttachPath(SAPbobsCOM.Company SBO_Company)
        {
            string AttachPath = "";
            try
            {
                SAPbobsCOM.Recordset oRecorset = (SAPbobsCOM.Recordset)SBO_Company.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
                string sql = "select AttachPath from OADP";
                oRecorset.DoQuery(sql);
                AttachPath = oRecorset.Fields.Item("AttachPath").Value.ToString();
            }
            catch (Exception) { }

            return AttachPath;
        }

        public static string GetBitmapPath(SAPbobsCOM.Company SBO_Company)
        {
            string BitmapPath = "";
            try
            {
                SAPbobsCOM.Recordset oRecorset = (SAPbobsCOM.Recordset)SBO_Company.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
                string sql = "select BitmapPath from OADP";
                oRecorset.DoQuery(sql);
                BitmapPath = oRecorset.Fields.Item("BitmapPath").Value.ToString();
            }
            catch (Exception) { }

            return BitmapPath;
        }
        public static void LinkedObjectForm(string FormUniqueID, string ActivateMenuItem, string FindItemUID, string FindItemUIDValue)
        {
            try
            {
                SAPbouiCOM.Form oForm = null;
                SAPbouiCOM.IEditText oEditText = null;
                bool Bool = false;

                //For frm As Integer = 0 To Application.SBO_Application.Forms.Count - 1
                // Dim sCad As String = Application.SBO_Application.Forms.Item(frm).UniqueID
                // If Application.SBO_Application.Forms.Item(frm). = FormUniqueID Then
                // 'Application.SBO_Application.Forms.Item(pVal.FormUID)
                // oForm = Application.SBO_Application.Forms.Item(FormUniqueID)
                // oForm.Close()

                // Exit For

                // End If

                //Next

                if (Bool == false)
                {
                    Application.SBO_Application.ActivateMenuItem(ActivateMenuItem);

                    Application.SBO_Application.Forms.ActiveForm.Freeze(true);

                    oForm = Application.SBO_Application.Forms.ActiveForm;
                    oForm.Select();
                    oForm.Mode = SAPbouiCOM.BoFormMode.fm_FIND_MODE;
                    oForm.Items.Item(FindItemUID).Enabled = true;

                    oEditText = (SAPbouiCOM.IEditText)oForm.Items.Item(FindItemUID).Specific;
                    oEditText.Value = FindItemUIDValue.Trim();

                    oForm.Items.Item("1").Click();
                    oForm.Freeze(false);

                }
            }
            catch (Exception ex)
            {
                Application.SBO_Application.MessageBox(ex.Message);
            }
            finally { }

        }
    }
}
