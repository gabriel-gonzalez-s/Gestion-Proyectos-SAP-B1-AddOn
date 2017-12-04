using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SAPbouiCOM.Framework;

namespace FuncionalidadesSDKB1
{
    public static class ProgressBarExtensions
    {
        public static bool Create_ProgressBar(ref SAPbouiCOM.ProgressBar oProgBarx, string sMessage, int iValue)
        {
            bool bSucess = false;

            //********************* PROGRESS BAR
            try
            {
                GC.Collect();
                oProgBarx = null;
                System.Runtime.InteropServices.Marshal.ReleaseComObject(oProgBarx);
                oProgBarx = null;
                GC.Collect();
                bSucess = true;
            }
            catch (Exception) { }

            try
            {
                oProgBarx = Application.SBO_Application.StatusBar.CreateProgressBar(sMessage, iValue, true);
                oProgBarx.Value = 0;
                oProgBarx.Value += 1;
                bSucess = true;
            }
            catch (Exception)
            { bSucess = false; }

            return bSucess;
        }

        public static bool ChangeText_ProgressBar(ref SAPbouiCOM.ProgressBar oProgBar, string sMessage)
        {
            bool bSucess = false;

            try
            {
                oProgBar.Text = sMessage;
                bSucess = true;
            }
            catch (Exception)
            { bSucess = false; }

            return bSucess;
        }

        public static bool Increment_ProgressBar(ref SAPbouiCOM.ProgressBar oProgBar, int iIncrement)
        {
            bool bSucess = false;

            try
            {
                oProgBar.Value += iIncrement;
                bSucess = true;
            }
            catch (Exception)
            { bSucess = false; }

            return bSucess;
        }

        public static bool Close_ProgressBar(ref SAPbouiCOM.ProgressBar oProgBar)
        {
            bool bSucess = false;

            try
            {
                oProgBar.Stop();
                bSucess = true;
            }
            catch (Exception)
            {
                try
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oProgBar);
                    oProgBar = null;
                    GC.Collect();
                    bSucess = true;
                }
                catch (Exception)
                { bSucess = false; }

            }

            return bSucess;
        }
    }
}
