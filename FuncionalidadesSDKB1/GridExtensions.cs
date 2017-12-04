using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionalidadesSDKB1
{
    public static class GridExtensions
    {
        public static void ColorBackColorRowGrid(SAPbouiCOM.Grid oGrid, int nRow, int Color)
        {
            oGrid.CommonSetting.SetRowBackColor(nRow, Color);
        }

        public static void ColorFontCellGrid(SAPbouiCOM.Grid oGrid, int nCol, int nRow, int ColorFont, int ColorBack)
        {
            oGrid.CommonSetting.SetCellBackColor(nRow, nCol, ColorBack);
            oGrid.CommonSetting.SetCellFontColor(nRow, nCol, ColorFont);
        }

        public static void RowNumberGrid(SAPbouiCOM.Grid oGrid)
        {
            SAPbouiCOM.RowHeaders oHeader = null;
            oHeader = oGrid.RowHeaders;

            for (int i = 0; i <= oGrid.Rows.Count - 1; i++)
            {
                oHeader.SetText(i, Convert.ToString(i + 1));
            }
        }
    }
}
