using SAPbouiCOM.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FuncionalidadesSDKB1
{
    public class ProjectFormXML
    {
        private static string _sPrjXml;

        public static string sPrjXml
        {
            get
            {
                return _sPrjXml;
            }

            set
            {
                _sPrjXml = value;
            }
        }

        public ProjectFormXML()
        {
            _sPrjXml = LoadXMlFromB1s();
        }

        public static string LoadXMlFromB1s()
        {
            XmlDocument document = new XmlDocument();
            string sPath = System.Environment.CurrentDirectory + "\\"; //Directorio Actual
            string sXml = "";
            string sProName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name; //Nombre Proyecto
            //string projectName = System.IO.Path.GetFileName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString();
            try
            {
                document.Load(sPath + sProName + ".b1s"); // Cargar XML de Proyecto
                sXml = document.InnerXml; //Obtener InnerXml del Proyecto

            }
            catch (Exception) { }
            finally
            {
                document = null;
                GC.Collect();
            }
            return sXml;
        }

        private static string ReadXmlFormFromB1s(string sFileName)
        {
            XmlDocument document = new XmlDocument();
            string sXPath = @"//project[@name=""VSIcreated""]//file[contains(@name,""" + sFileName + @""")]//content//@desc "; ; //XPath de Form
            string sXml = "";

            try
            {
                document.LoadXml(_sPrjXml); // Cargar XML de Proyecto
                sXml = document.SelectSingleNode(sXPath).Value; // Seleccionar contenido XML de @desc
                document.LoadXml(sXml); //Cargar el XML del Form
                sXml = document.InnerXml; //Obtener InnerXml del Form
            }
            catch (Exception) { }
            finally
            {
                document = null;
                GC.Collect();
            }
            return sXml;
        }

        public static SAPbouiCOM.Form LoadFormToProjectB1s(string fileName, string formType, SAPbouiCOM.BoFormModality modal = SAPbouiCOM.BoFormModality.fm_None)
        {
            SAPbouiCOM.Form oForm = null;

            try
            {
                string XmlForm = ReadXmlFormFromB1s(fileName);
                string ticks = DateTime.Now.Ticks.ToString();
                ticks = ticks.Substring(ticks.Length - 8);
                string uniqueId = fileName.Replace(".B1f", "") + ticks; //GenerateUniqueIdFormType(contents, formType);

                var formDefinition = (SAPbouiCOM.FormCreationParams)Application.SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_FormCreationParams);
                formDefinition.XmlData = XmlForm;
                formDefinition.UniqueID = uniqueId;
                formDefinition.FormType = formType;
                formDefinition.Modality = modal;

                oForm = Application.SBO_Application.Forms.AddEx(formDefinition);
            }
            catch (Exception) { }

            return oForm;
        }

        public static void LoadFormToProjectB1sBACTH(string sFileName, string formType)
        {
            string sXPathIUD = "Application//forms//action//form//@uid";
            string sXPathType = "Application//forms//action//form//@FormType";
            string sXml = "";
            string sPath = System.Environment.CurrentDirectory + "\\";
            string sProName = System.Reflection.Assembly.GetCallingAssembly().GetName().Name; //Nombre Proyecto

            XmlDocument xDocu = new XmlDocument();

            try
            {
                sXml = ReadXmlFormFromB1s(sFileName);

                xDocu.LoadXml(sXml);
                XmlNode xNode = xDocu.SelectSingleNode(sXPathIUD);
                string ticks = DateTime.Now.Ticks.ToString();
                ticks = ticks.Substring(ticks.Length - 8);
                string FormUID = sFileName.Replace(".B1f", "") + ticks;
                xNode.InnerText = FormUID;
                xNode = xDocu.SelectSingleNode(sXPathType);
                xNode.InnerText = formType;

                string sXML = xDocu.InnerXml.ToString();

                Application.SBO_Application.LoadBatchActions(ref sXML);
                SAPbouiCOM.Form oForm = Application.SBO_Application.Forms.Item(FormUID);
                oForm.Visible = true;
            }
            catch (Exception ex)
            {
                Application.SBO_Application.SetStatusBarMessage(ex.Message, SAPbouiCOM.BoMessageTime.bmt_Short, true);
            }
            finally
            {
                xDocu = null;
                GC.Collect();
            }
        }
    }
}
