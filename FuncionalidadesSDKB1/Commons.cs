using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAPbouiCOM.Framework;
using System.Globalization;

namespace FuncionalidadesSDKB1
{
    public static class Commons
    {
        public static NumberFormatInfo oNumberFormatInfo = new NumberFormatInfo();
        public static string FormatMoneyToString(double _double, SAPbobsCOM.Company oCompany, SAPbobsCOM.BoMoneyPrecisionTypes _Precision)
        {
            SAPbobsCOM.SBObob businessObject = (SAPbobsCOM.SBObob)oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge);
            SAPbobsCOM.Recordset recordset = (SAPbobsCOM.Recordset)oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
            recordset = businessObject.Format_MoneyToString(_double, _Precision);
            return (string)recordset.Fields.Item(0).Value;
        }

        public static double GetDoubleFromString(string _doublestring)
        {
            _doublestring = _doublestring.Trim().Substring(0, 1) == "." ? "0" + _doublestring : _doublestring;
            if (oNumberFormatInfo.NumberDecimalSeparator == ",")
            {
                return double.Parse(_doublestring, CultureInfo.CurrentCulture);
            }
            return double.Parse(_doublestring, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
        }

        public static string GetStringFromDouble(double _double)
        {
            try
            {
                return _double.ToString().Replace(",", ".");
            }
            catch (Exception)
            {
                return "0.00";
            }
        }

        public static string GetStringFromDoubleDecimal(double _double, int _decimal)
        {
            string str3 = "";
            try
            {
                str3 = _double.ToString().Replace(",", ".");
                if (str3.IndexOf(".") == -1)
                {
                    return str3;
                }
                return str3.Substring(0, (str3.IndexOf(".") + _decimal) + 1);
            }
            catch (Exception)
            {
                return "0.00";
            }
        }

        public static long Random()
        {
            long num2 = 1L;
            long num3 = 0x3e8L;
            System.Random random = new System.Random();
            return (((num2 - num3) * random.Next()) + num3);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        //  DEFINE UN COLOR RGB
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static int Color_RGB_SAP(int R, int G, int B)
        {
            int DecCol = B * 65536 + G * 256 + R;
            return DecCol;
        }




    }
}
