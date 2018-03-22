using System;
using System.Collections.Generic;
using System.Xml;
using SAPbouiCOM.Framework;

namespace AdicionalesProyectos
{
    [FormAttribute("AdicionalesProyectos.AnalisisProyectosFinazas", "AnalisisProyectosFinazas.b1f")]
    public class AnalisisProyectosFinazas : UserFormBase
    {
        public AnalisisProyectosFinazas()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.Folder0 = ((SAPbouiCOM.Folder)(this.GetItem("Item_1").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }

        private SAPbouiCOM.Folder Folder0;

        private void OnCustomInitialize()
        {

        }
    }
}