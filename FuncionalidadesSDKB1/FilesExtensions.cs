using SAPbouiCOM.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionalidadesSDKB1
{
    public static class FilesExtensions
    {
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        //  EJECUTA UN ARCHIVO CONTENIDO EN LA RUTA INGRESADA COMO PARAMETRO
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static void OpenFile(String Path)
        {

            ProcessStartInfo psi = new ProcessStartInfo();

            psi.UseShellExecute = true;

            psi.FileName = Path;

            try
            {
                Process.Start(psi);
            }
            catch (Exception)
            {
                Application.SBO_Application.MessageBox("Ruta de archivo Invalida");
            }
        }

        public static void CopyFiletoDirectoy(string FilePath, string DestinyPath)
        {

            try
            {
                if (Directory.Exists(System.IO.Path.GetDirectoryName(FilePath)))
                    if (Directory.Exists(System.IO.Path.GetDirectoryName(DestinyPath)))
                    {
                        string FileName = System.IO.Path.GetFileName(FilePath);
                        System.IO.File.Copy(FilePath, DestinyPath + @"\" + FileName, true);
                    }
                    else
                        Application.SBO_Application.MessageBox("No existe el directorio " + DestinyPath.Trim());
                else
                    Application.SBO_Application.MessageBox("No existe el directorio " + FilePath.Trim());
            }
            catch (Exception)
            {
                Application.SBO_Application.MessageBox("Error al Copiar el Anexo a " + DestinyPath.Trim());
            }

        }

        public static void DeleteFile(string FilePath)
        {
            // Delete a file by using File class static method...
            if (System.IO.File.Exists(FilePath))
            {
                // Use a try block to catch IOExceptions, to
                // handle the case of the file already being
                // opened by another process.
                try
                {
                    System.IO.File.Delete(FilePath);
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        public static void GenerateTXTFileFromDataTable(string sRutaArchivo, SAPbouiCOM.DataTable DT_INFO)
        {
            try
            {

                StreamWriter archivo = new StreamWriter(sRutaArchivo);

                for (int i = 0; i <= DT_INFO.Rows.Count - 1; i++)
                {
                    archivo.WriteLine(DT_INFO.GetValue(0, i).ToString().Replace("<*>", ""));
                }

                archivo.Close();

            }
            catch (Exception) { }
        }
    }
}
