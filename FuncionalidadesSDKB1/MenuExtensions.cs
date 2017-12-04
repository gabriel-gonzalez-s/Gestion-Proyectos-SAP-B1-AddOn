using SAPbouiCOM.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionalidadesSDKB1
{
    public static class MenuExtensions
    {

        public static void RemoveMenu(string IDMenu)
        {
            if (Application.SBO_Application.Menus.Exists(IDMenu))
                Application.SBO_Application.Menus.RemoveEx(IDMenu);
        }

        public static void CreateContextualMenu(String IDMenu, String Descripcion, int Position)
        {
            SAPbouiCOM.MenuItem oMenuItem;
            SAPbouiCOM.Menus oMenus;

            SAPbouiCOM.MenuCreationParams oCreationPackage = null;
            oCreationPackage = (SAPbouiCOM.MenuCreationParams)(Application.SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams));

            oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING;
            oCreationPackage.UniqueID = IDMenu;
            oCreationPackage.String = Descripcion;
            oCreationPackage.Enabled = true;
            oCreationPackage.Position = Position;

            oMenuItem = Application.SBO_Application.Menus.Item("1280"); //Data
            oMenus = oMenuItem.SubMenus;
            oMenus.AddEx(oCreationPackage);
        }
    }
}
