Imports SAPbouiCOM.Framework
Imports SAPbobsCOM
Imports System.Management
Imports System.Text.RegularExpressions
Imports System.Xml.Serialization
Imports System.Data.OleDb
Imports SBOAddonProject1
Imports ThreadState = System.Threading.ThreadState
Imports System.Threading
Imports System.Security.Permissions



Namespace SBOAddonProject1

    Public Class Funciones

        'Variables de Definicion de Formularios e Items UI API
        '------------------------------------------------------------
        Public oApplication As SAPbouiCOM.Application
        Public SBO_Application As SAPbouiCOM.Application
        Public oForm As SAPbouiCOM.Form
        Public oItem As SAPbouiCOM.Item
        Public oMatrix As SAPbouiCOM.Matrix
        Public oGrid As SAPbouiCOM.Grid
        Public oColumns As SAPbouiCOM.Columns
        Public oColumn As SAPbouiCOM.Column
        Public oEditCol As SAPbouiCOM.EditTextColumn
        Public oedit As SAPbouiCOM.EditText
        Public oExtEdit As SAPbouiCOM.EditText
        Public oStatic As SAPbouiCOM.StaticText
        Public oButton As SAPbouiCOM.Button
        Public oOptionBtn As SAPbouiCOM.OptionBtn
        Public oCheckBox As SAPbouiCOM.CheckBox
        Public oComboBox As SAPbouiCOM.ComboBox
        Public oFolder As SAPbouiCOM.Folder
        Public oPicture As SAPbouiCOM.PictureBox
        Public oDBDataSource As SAPbouiCOM.DBDataSource
        Public oUDataSource As SAPbouiCOM.UserDataSource
        Public oUDataTable As SAPbouiCOM.DataTable
        Public oUDataTable2 As SAPbouiCOM.DataTable
        Public oUDataTable3 As SAPbouiCOM.DataTable
        Public oDTSQL As SAPbouiCOM.DataTable
        Public oDTSQL2 As SAPbouiCOM.DataTable
        Public oDTSQL3 As SAPbouiCOM.DataTable
        Public oProgBar As SAPbouiCOM.ProgressBar ' This is the progress bar
        Public oComboCol As SAPbouiCOM.ComboBoxColumn
        Public oChkCol As SAPbouiCOM.CheckBoxColumn

        'Variables para el manejo de mensajes
        '------------------------------------------------------------
        Public oCmpSrv As SAPbobsCOM.CompanyService
        Public oMessageService As MessagesService

        Public oNConectarAplicacion As New NConectarAplicacion()
        Public oCompany As SAPbobsCOM.Company = oNConectarAplicacion.oCompany

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '  INICIA EL SERVICIO DE ENVIO DE MENSAJES DENTO DE SAP BO
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        Public Sub IniciarServicioMensajes()

            Try
                'get company service
                oCmpSrv = oCompany.GetCompanyService
            Catch ex As Exception
                'get company service
                oNConectarAplicacion.Conectar_Aplicacion(oCompany)
                oCmpSrv = oCompany.GetCompanyService
            End Try

            'get msg service
            oMessageService = oCmpSrv.GetBusinessService(ServiceTypes.MessagesService)

        End Sub


        Public Sub Desconectar_y_Cerrar_Aplicacion()

            'If oCompany.Connected Then
            '    oCompany.Disconnect()
            'End If

            Try
                System.Windows.Forms.Application.Exit()
                System.Windows.Forms.Application.ExitThread()
            Catch ex As Exception

            End Try


        End Sub

        Public Sub Remover_Menu(IDMenu As String)

            If SBO_Application.Menus.Exists(IDMenu) Then

                SBO_Application.Menus.RemoveEx(IDMenu)

            End If

        End Sub

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '  RETORNA EL NOMBRE DEL USUARIO ACTIVO EN LA SESION ACTUAL
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        Public Function Nombre_Usuario_Actual()

            Dim sNombreUsu As String
            oForm = Application.SBO_Application.Forms.GetForm(169, 0) 'Toma la Descripcion del Usuario Actual del Menu Principal
            oStatic = oForm.Items.Item("8").Specific
            sNombreUsu = oStatic.Caption
            Return sNombreUsu

        End Function

        Public Function Consulta_Nombre_Usuario(sUserID As String, DataTable As SAPbouiCOM.DataTable) As String

            Dim sNombreUsu As String = ""

            Dim query As String = "SELECT USERID,USER_CODE,U_NAME FROM OUSR WHERE USERID = '" + sUserID + "'"

            Try

                Try
                    DataTable.ExecuteQuery(query)
                    sNombreUsu = DataTable.GetValue("U_NAME", 0)
                Catch ex As Exception
                    oNConectarAplicacion.Conectar_Aplicacion(oCompany)
                    DataTable.ExecuteQuery(query)
                    sNombreUsu = DataTable.GetValue("U_NAME", 0)
                End Try


            Catch exc As Exception

                Application.SBO_Application.MessageBox(query)
                Application.SBO_Application.MessageBox(exc.Message)

            End Try

            Return sNombreUsu

        End Function

        Public Function GetAttachPath() As String
            Dim AttachPath As String = ""
            Dim SBO_Company As SAPbobsCOM.Company = oCompany

            Try
                If SBO_Company.Connected = False Then
                    oNConectarAplicacion.Conectar_Aplicacion(SBO_Company)
                End If

                Dim oRecorset As SAPbobsCOM.Recordset = SBO_Company.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                Dim sql As String = "select AttachPath from OADP"
                oRecorset.DoQuery(sql)
                AttachPath = oRecorset.Fields.Item("AttachPath").Value
            Catch ex As Exception

            End Try

            Return AttachPath
        End Function

        Public Function GetBitmapPath() As String
            Dim BitmapPath As String = ""
            Dim SBO_Company As SAPbobsCOM.Company = oCompany

            Try
                If SBO_Company.Connected = False Then
                    oNConectarAplicacion.Conectar_Aplicacion(SBO_Company)
                End If

                Dim oRecorset As SAPbobsCOM.Recordset = SBO_Company.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                Dim sql As String = "select BitmapPath from OADP"
                oRecorset.DoQuery(sql)
                BitmapPath = oRecorset.Fields.Item("BitmapPath").Value
            Catch ex As Exception

            End Try

            Return BitmapPath
        End Function


        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '  VERIFICA SU UN ITEM YA EXISTE EN UN FORM
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        Public Function ItemExists(oForm As SAPbouiCOM.Form, ItemUid As String) As Boolean

            Try
                oItem = oForm.Items.Item(ItemUid)
            Catch ex As Exception
                ' item does not exist  
                Return False
            End Try

            Return True

        End Function

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '  VERIFICA SU UN DATATABLE YA EXISTE EN UN FORM
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        Public Function DataTableExists(oForm As SAPbouiCOM.Form, ItemUid As String) As Boolean

            Try
                oUDataTable = oForm.DataSources.DataTables.Item(ItemUid)
            Catch ex As Exception
                ' item does not exist  
                Return False
            End Try

            Return True

        End Function

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '  VERIFICA SU UN USERDATASOURCE YA EXISTE EN UN FORM
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        Public Function UserDataSourceExists(oForm As SAPbouiCOM.Form, ItemUid As String) As Boolean

            Try
                oUDataSource = oForm.DataSources.UserDataSources.Item(ItemUid)
            Catch ex As Exception
                ' item does not exist  
                Return False
            End Try

            Return True

        End Function

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '  DEFINE UN COLOR RGB
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        Public Function Color_RGB_SAP(R As Integer, G As Integer, B As Integer) As Long

            'Dim R As Integer = Val(InputBox$("Red Value"))
            'Dim B As Integer = Val(InputBox$("Blue Value"))
            'Dim G As Integer = Val(InputBox$("Green Value"))
            Dim DecCol As Long = B * 65536 + G * 256 + R
            Return DecCol

        End Function

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '  EJECUTA UN ARCHIVO CONTENIDO EN LA RUTA INGRESADA COMO PARAMETRO
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        Public Sub Open_File(Path As String)

            Dim psi As New ProcessStartInfo()

            psi.UseShellExecute = True

            psi.FileName = Path

            Try
                Process.Start(psi)
            Catch ex As Exception
                Application.SBO_Application.MessageBox("Ruta de archivo Invalida")
            End Try

        End Sub

        Public Sub Delete_File(FilePath As String)
            If System.IO.File.Exists(FilePath) Then
                Try
                    System.IO.File.Delete(FilePath)
                Catch ex As Exception
                    Application.SBO_Application.MessageBox(ex.Message)
                End Try

            End If
        End Sub

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '  COPIA UN ARCHIVO DE RUTA CONTENIDA EN UN EDITTEXT A LA CARPETA DE DIRECTORIOS ANEXOS DE SAP
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        Public Sub Copiar_Documentos_Anexos_a_Servidor(EditValidar As SAPbouiCOM.EditText, Optional NuevoNombre As String = "<*>")

            Dim PathLocal As String
            Dim FileName As String

            If EditValidar.Value.Trim.Length() > 0 Then

                Try
                    PathLocal = EditValidar.Value
                    FileName = IO.Path.GetFileName(PathLocal)
                    My.Computer.FileSystem.CopyFile(PathLocal, sPathAnexos + FileName, True) ' Copia el archivo al directorio anexos de SAP
                    If NuevoNombre <> "<*>" Then
                        My.Computer.FileSystem.RenameFile(sPathAnexos + FileName, NuevoNombre)
                        EditValidar.Value = sPathAnexos + NuevoNombre
                    Else
                        EditValidar.Value = sPathAnexos + FileName
                    End If

                Catch ex As Exception
                    Application.SBO_Application.MessageBox("Error al Copiar el Anexo a " + sPathAnexos.Trim() + ". " + ex.Message)
                End Try

            End If

        End Sub

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '  VALIDA LAS FECHAS Y CALCULA LOS DIAS HABILES CONTENIDOS EN 2 EDITEXT Y EL RESULTADO LO RETORNA EN UN 3ER EDITTEXT
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        Public Sub Valida_Fecha_Calcula_Dias(EditValidar As SAPbouiCOM.EditText, EditFecha As SAPbouiCOM.EditText, EditDias As SAPbouiCOM.EditText)

            Dim dFecha1 As Date
            Dim dFecha2 As Date

            If EditValidar.Value.Trim().Length() > 0 Then

                Try
                    dFecha1 = DateTime.ParseExact(EditValidar.Value, "yyyyMMdd", Nothing).ToString("dd\/MM\/yyyy")
                Catch ex As Exception
                    EditValidar.ClickPicker()
                    EditValidar.Active = True
                End Try


                If Not IsDate(EditFecha.Value) Then ' Si se toma la fecha del date picker superior(yyyyMMdd), se debe transformar a dd/MM/yyyy
                    Try
                        dFecha2 = DateTime.ParseExact(EditFecha.Value, "yyyyMMdd", Nothing).ToString("dd\/MM\/yyyy")
                    Catch ex As Exception
                        Application.SBO_Application.MessageBox(ex.Message)
                    End Try
                Else
                    dFecha2 = EditFecha.Value
                End If


                If IsDate(dFecha1) And IsDate(dFecha2) Then
                    Try
                        'Application.SBO_Application.MessageBox(Dias_Habiles(dFecha2, dFecha1))
                        EditDias.Value = Dias_Habiles(dFecha2, dFecha1)
                    Catch ex As Exception
                        Application.SBO_Application.MessageBox(ex.Message)
                    End Try

                End If
            Else

                EditDias.Value = "0"

            End If
        End Sub

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '  CALCULA LOS DIAS HABILES ENTRE 2 FECHAS
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        Public Function Dias_Habiles(FInicial As Date, FFinal As Date)

            'Dim fecha_inicial As String = Me.Calendar1.SelectedDate '04/07/2012
            'Dim fecha_final As String = Me.Calendar1.SelectedDate '11/07/2012
            Try
                Dim DiasTotales As Integer = 0
                Dim rangodias As Integer = 0
                Dim finicial2 As Date
                Dim ffinal2 As Date
                Dim diaNOhabil As Integer = 0
                Dim contador As Integer = 0
                Dim contador2 As Integer = 0
                'Dim test As Integer = 0
                Dim dtDiasBD As New DataTable
                'dtDiasBD = TablaDiasFestivos()
                Dim tamanioDatos As Integer
                Dim nEsNegativo As Integer = 1
                tamanioDatos = dtDiasBD.Rows.Count
                tamanioDatos = tamanioDatos - 1
                If IsDate(FInicial) And IsDate(FFinal) Then

                    If FInicial <= FFinal Then 'Para que retorne el numero de fechas negativo si es el caso
                        finicial2 = CDate(FInicial)
                        ffinal2 = CDate(FFinal)
                        nEsNegativo = 1
                    Else
                        finicial2 = CDate(FFinal)
                        ffinal2 = CDate(FInicial)
                        nEsNegativo = -1
                    End If

                    If finicial2 < ffinal2 Then
                        'Se obtiene el rango de dias
                        rangodias = DateDiff(DateInterval.Day, finicial2, ffinal2)
                        'rangodias = rangodias + 1
                        'se recorre el rango
                        For contador = 0 To rangodias Step 1
                            If Weekday(finicial2) = 1 Or Weekday(finicial2) = 7 Then
                                diaNOhabil = diaNOhabil + 1
                            End If
                            For contador2 = 0 To tamanioDatos Step 1
                                If CDate(finicial2).ToString("dd-MM-yyyy") = CDate(dtDiasBD.Rows(contador2)("fecha")).ToString("dd-MM-yyyy") Then
                                    diaNOhabil = diaNOhabil + 1
                                End If
                            Next

                            finicial2 = DateAdd("d", 1, finicial2) ' se incrementa la fecha un dia mas
                        Next
                        DiasTotales = (rangodias + 1) - diaNOhabil
                    End If
                End If
                Return DiasTotales * nEsNegativo
            Catch
                Return 0
            End Try

        End Function

        Public Function FechaHoraEnEntero(ByVal fecha As Date) As Long

            Dim numero As Long

            numero = Year(fecha) Mod 100
            numero = numero * 12 + Month(fecha) - 1
            numero = numero * 30 + Day(fecha) - 1
            numero = numero * 24 + Hour(fecha)
            numero = numero * 60 + Minute(fecha)
            numero = numero * 60 + Second(fecha)

            FechaHoraEnEntero = numero

        End Function


        Public Function EnteroEnFechaHora(ByVal entero As Long) As Date

            Dim seg As Integer : seg = entero Mod 60 : entero = entero \ 60
            Dim min As Integer : min = entero Mod 60 : entero = entero \ 60
            Dim hor As Integer : hor = entero Mod 24 : entero = entero \ 24
            Dim dia As Integer : dia = entero Mod 30 + 1 : entero = entero \ 30
            Dim mes As Integer : mes = entero Mod 12 + 1 : entero = entero \ 12
            Dim año As Integer : año = entero + 2000

            EnteroEnFechaHora = DateSerial(año, mes, dia) + TimeSerial(hor, min, seg)

        End Function

        Public Function HoraEnEntero(ByVal fecha As DateTime) As Long

            Dim numero As Long

            numero = 24 + Hour(fecha)
            numero = numero * 60 + Minute(fecha)
            numero = numero * 60 + Second(fecha)

            HoraEnEntero = numero

        End Function

        Public Function EnteroEnHora(ByVal entero As Long) As String

            Dim seg As Integer : seg = entero Mod 60 : entero = entero \ 60
            Dim min As Integer : min = entero Mod 60 : entero = entero \ 60
            Dim hor As Integer : hor = entero Mod 24 : entero = entero \ 24


            EnteroEnHora = TimeSerial(hor, min, seg).ToLongDateString

        End Function

        Public Function Hora_a_HoraSAPBD(Hora As String) As String

            Return Replace(Hora, ":", "")

        End Function

        Public Function HoraSAPBD_a_Hora(HoraSAPBD As String) As String

            HoraSAPBD = Right("000000" + HoraSAPBD.Trim, 6)
            'HoraSAPBD = If(Left(HoraSAPBD, 1) = "0", Right(HoraSAPBD, 5), HoraSAPBD)
            Dim Horas As String = If(HoraSAPBD.Trim.Length = 6, Left(HoraSAPBD.Trim, 2), Left(HoraSAPBD.Trim, 1))
            Dim Minutos As String = If(HoraSAPBD.Trim.Length = 6, HoraSAPBD.Trim.Substring(2, 2), HoraSAPBD.Trim.Substring(1, 2))
            Dim Segundos As String = Right(HoraSAPBD.Trim, 2)
            Return Horas.Trim + ":" + Minutos.Trim + ":" + Segundos.Trim

        End Function

        Public Function ValidateEDateForError(ByVal checkInputValue As String) As Boolean
            Dim returnError As Boolean
            Dim dateVal As Date
            If Date.TryParseExact(checkInputValue, "DD/MM/YYYY",
                   System.Globalization.CultureInfo.CurrentCulture,
                   Globalization.DateTimeStyles.None, dateVal) Then
                returnError = True
            End If
            Return returnError
        End Function

        Public Function HoraValida(Valor As String) As Boolean
            Dim r As New Regex("([0-1][0-9]|2[0-3]):[0-5][0-9]")
            Dim sw As Boolean = True
            If Not (r.Match(Valor)).Success Then
                sw = False
                'Si el dato de entrada no es hora, mostrar un mensaje al usuario ("Debe ingresar la hora con formato válido [08:30].")
            End If
            Return sw
        End Function

        Public Function HoraValidaHHMMSS(Valor As String) As Boolean

            Dim r As New Regex("([0-1][0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]")
            Dim letra As String = Valor.Trim.Substring(2, 1)

            If Valor.Trim.Length = 7 Then

                If (Valor.Trim.Substring(1, 1) = ":" And Valor.Trim.Substring(4, 1) = ":") Then

                    r = New Regex("[0-9]:[0-5][0-9]:[0-5][0-9]")

                ElseIf (Valor.Trim.Substring(2, 1) = ":" And Valor.Trim.Substring(4, 1) = ":") Then

                    r = New Regex("([0-1][0-9]|2[0-3]):[0-9]:[0-5][0-9]")

                ElseIf Valor.Trim.Substring(5, 1) = ":" Or Valor.Trim.Substring(6, 1) = ":" Then

                    r = New Regex("([0-1][0-9]|2[0-3]):[0-5][0-9]:[0-9]")

                End If

            End If

            Dim sw As Boolean = True
            If Not (r.Match(Valor)).Success Then
                sw = False
                'Si el dato de entrada no es hora, mostrar un mensaje al usuario ("Debe ingresar la hora con formato válido [08:30:15].")
            End If
            Return sw
        End Function

        Public Function EsCadenaEntero(Valor As String) As Boolean

            Dim number As Integer = 0
            Dim canConvert As Boolean = Integer.TryParse(Valor, number)

            Return canConvert

        End Function


        Public Function Teclas_Control_Permitidas(ByVal pVal As SAPbouiCOM.SBOItemEventArg, ByRef cajasTexto As SAPbouiCOM.EditText)

            Dim ListaPermitidas = New List(Of Integer) From {8, 9, 13, 34, 35, 36, 37, 38, 39, 40, 127}
            Teclas_Control_Permitidas = False

            If ListaPermitidas.Contains(pVal.CharPressed) Then
                Teclas_Control_Permitidas = True
            Else
                Teclas_Control_Permitidas = False
            End If

        End Function

        Public Function KeyNumeroDecimal(ByVal pVal As SAPbouiCOM.SBOItemEventArg, ByRef cajasTexto As SAPbouiCOM.EditText) As Boolean

            KeyNumeroDecimal = False
            Dim cKey As String = Chr(pVal.CharPressed)

            If UCase(cKey) Like "[0-9-]" Then
                Return True
            End If

            Dim c As Short = 0
            If UCase(cKey) Like "[,.]" Then

                cajasTexto.Value = Replace(cajasTexto.Value, ".", ",")

                If Cantidad_Caracter(cajasTexto.Value, ",") = 1 Then

                    If cajasTexto.Value.Trim.Length = 1 Then
                        cajasTexto.Value = Replace(cajasTexto.Value, ",", "0,")
                    End If

                    Return True

                Else
                    Return False
                End If

            End If

        End Function


        Public Function KeyNumeroEntero(ByVal pVal As SAPbouiCOM.SBOItemEventArg, ByRef cajasTexto As SAPbouiCOM.EditText) As Boolean

            KeyNumeroEntero = False
            Dim cKey As String = Chr(pVal.CharPressed)

            If UCase(cKey) Like "[0-9]" Then
                Return True
            End If

        End Function

        Public Function KeyHoraLarga(ByVal pVal As SAPbouiCOM.SBOItemEventArg, ByRef cajasTexto As SAPbouiCOM.EditText) As Boolean

            KeyHoraLarga = False
            Dim cKey As String = Chr(pVal.CharPressed)

            If UCase(cKey) Like "[0-9]" Then
                Return True
            End If

            Dim c As Short = 0
            If UCase(cKey) Like "[:]" Then

                If Cantidad_Caracter(cajasTexto.Value, ":") <= 2 Then
                    Return True
                Else
                    Return False
                End If

            End If

        End Function

        Public Function Cantidad_Caracter(sTexto As String, sCar As String) As Integer

            Dim cont As Integer = 0

            For i = 1 To Len(sTexto)
                If sCar = Mid(sTexto, i, Len(sCar)) Then cont = cont + 1
            Next

            Cantidad_Caracter = cont

        End Function

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '  COPIA EL CONTENIDO DE UNA HOJA ESPECIFICA DESDE UN LIBRO DE EXCEL EN UN DATATABLE 
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        Public Sub Cargar_Desde_Excel(DataTable As SAPbouiCOM.DataTable, sLibro As String, sHoja As String)

            'HDR=YES : Con encabezado
            'Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
            '                   "Data Source=" & sLibro & ";" & _
            '                   "Extended Properties=""Excel 12.0;HDR=YES"""
            Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;" &
                               "Data Source=" & sLibro & ";" &
                               "Extended Properties=""Excel 12.0 Xml;HDR=YES"""

            Try
                ' cadena de conexión
                Dim cn As New OleDbConnection(cs)

                If Not System.IO.File.Exists(sLibro) Then
                    MsgBox("No se encontró el Libro: " &
                            sLibro, MsgBoxStyle.Critical,
                            "Ruta inválida")
                    Exit Sub
                End If

                ' se conecta con la hoja sheet 1
                Dim dAdapter As New OleDbDataAdapter("Select * From [" & sHoja & "$]", cs)

                Dim datos As New DataSet
                'agrega los datos
                dAdapter.Fill(datos, DataTable.UniqueID)

                Dim dt As New DataTable
                dAdapter.Fill(dt)
                dt.TableName = "CargaMasiva"

                'Dim writer As New System.IO.StringWriter()
                'dt.WriteXml(writer, XmlWriteMode.WriteSchema, False)
                'Dim sXMLdt As String = writer.ToString()

                'Dim xmlString As String = String.Empty
                'Dim writer2 As IO.TextWriter = New IO.StringWriter()

                'dt.WriteXml(writer)
                'Dim Xml As String = writer.ToString()

                'Dim oXmlDoc As New System.Xml.XmlDocument()
                'oXmlDoc.LoadXml(Xml)

                DataTable.Clear()
                'DataTable.LoadSerializedXML(SAPbouiCOM.BoDataTableXmlSelect.dxs_All, sXMLdt)

                'Llenar el DataTable SAP a partir de DT .Net
                'Agregamos las Columnas
                For i = 0 To dt.Columns.Count - 1
                    DataTable.Columns.Add(dt.Columns.Item(i).ToString, SAPbouiCOM.BoFieldsType.ft_Text, 100)
                    Dim s As String = DataTable.Columns.Item(i).Name
                    'DataTable.Columns.Add(dt.Columns(i).ColumnName.ToString(), SAPbouiCOM.BoFieldsType.ft_Text, 100)
                Next

                'Agregamos las Filas
                Dim sCoLumna As String = ""
                For j = 0 To dt.Rows.Count - 1

                    DataTable.Rows.Add()

                    For ColCount = 0 To dt.Columns.Count - 1

                        sCoLumna = dt.Columns.Item(ColCount).ToString
                        Dim s As String = dt.Rows(j).Item(sCoLumna).ToString
                        DataTable.SetValue(sCoLumna, j, dt.Rows(j).Item(sCoLumna).ToString)
                        'If Not IsDBNull(dt.Rows(j).Item(sCoLumna)) Then
                        '    DataTable.SetValue(sCoLumna, j, dt.Rows(j).Item(sCoLumna))
                        'Else

                        'End If

                    Next

                Next

                Dim nombre As String = "" 'dt.Columns(0).ColumnName.ToString()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End Sub

        Public Function ObtenerNombrePrimeraHojaLibroExcel(ByVal rutaLibro As String) As String

            Dim app As Microsoft.Office.Interop.Excel.Application = Nothing
            Try
                app = New Microsoft.Office.Interop.Excel.Application()
                Dim wb As Microsoft.Office.Interop.Excel.Workbook = app.Workbooks.Open(rutaLibro)
                Dim ws As Microsoft.Office.Interop.Excel.Worksheet = CType(wb.Worksheets.Item(1), Microsoft.Office.Interop.Excel.Worksheet)
                Dim name As String = ws.Name
                ws = Nothing
                wb.Close()
                wb = Nothing
                Return name
            Catch ex As Exception
                Throw

            Finally
                If (Not app Is Nothing) Then _
                    app.Quit()
                Runtime.InteropServices.Marshal.ReleaseComObject(app)
                app = Nothing
            End Try
        End Function

        Public Function ConvertirDataTableSAP(ByVal SAPDataTable As SAPbouiCOM.DataTable) As DataTable

            '\ This function will take an SAP recordset from the SAPbobsCOM library and convert it to a more
            '\ easily used ADO.NET datatable which can be used for data binding much easier.

            Dim dtTable As New DataTable
            Dim NewCol As DataColumn
            Dim NewRow As DataRow
            Dim ColCount As Integer

            Try
                Try
                    oProgBar = Application.SBO_Application.StatusBar.CreateProgressBar("Procesando Columnas", SAPDataTable.Columns.Count, False)
                Catch ex As Exception
                End Try

                For ColCount = 0 To SAPDataTable.Columns.Count - 1
                    NewCol = New DataColumn(SAPDataTable.Columns.Item(ColCount).Name)
                    dtTable.Columns.Add(NewCol)
                    Try
                        oProgBar.Value += 1
                    Catch ex As Exception
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(oProgBar)
                        oProgBar = Nothing
                        oProgBar = Application.SBO_Application.StatusBar.CreateProgressBar("Procesando Columnas", SAPDataTable.Columns.Count, False)
                        oProgBar.Value = ColCount + 1
                    End Try
                Next

                Try
                    oProgBar.Stop()
                Catch ex As Exception
                End Try


                Try
                    oProgBar = Application.SBO_Application.StatusBar.CreateProgressBar("Procesando Filas", SAPDataTable.Columns.Count, False)
                Catch ex As Exception
                End Try

                For i = 0 To SAPDataTable.Rows.Count - 1

                    NewRow = dtTable.NewRow
                    'populate each column in the row we're creating
                    For ColCount = 0 To SAPDataTable.Columns.Count - 1

                        NewRow.Item(SAPDataTable.Columns.Item(ColCount).Name) = SAPDataTable.GetValue(ColCount, i)

                    Next

                    'Add the row to the datatable
                    dtTable.Rows.Add(NewRow)

                    Try
                        oProgBar.Value += 1
                    Catch ex As Exception
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(oProgBar)
                        oProgBar = Nothing
                        oProgBar = Application.SBO_Application.StatusBar.CreateProgressBar("Procesando Filas", SAPDataTable.Columns.Count, False)
                        oProgBar.Value = ColCount + 1
                    End Try

                Next

                Try
                    oProgBar.Stop()
                Catch ex As Exception
                End Try

                Return dtTable

            Catch ex As Exception
                MsgBox(ex.ToString & Chr(10) & "Error converting SAP DataTable to DataTable .Net", MsgBoxStyle.Exclamation)
                ConvertirDataTableSAP = Nothing
                Exit Function
            End Try


        End Function

        Public Function ConvertirRecordsetSAP(ByVal SAPRecordset As SAPbobsCOM.Recordset) As DataTable

            '\ This function will take an SAP recordset from the SAPbobsCOM library and convert it to a more
            '\ easily used ADO.NET datatable which can be used for data binding much easier.

            Dim dtTable As New DataTable
            Dim NewCol As DataColumn
            Dim NewRow As DataRow
            Dim ColCount As Integer

            Try
                For ColCount = 0 To SAPRecordset.Fields.Count - 1
                    NewCol = New DataColumn(SAPRecordset.Fields.Item(ColCount).Name)
                    dtTable.Columns.Add(NewCol)
                Next

                Do Until SAPRecordset.EoF

                    NewRow = dtTable.NewRow
                    'populate each column in the row we're creating
                    For ColCount = 0 To SAPRecordset.Fields.Count - 1

                        NewRow.Item(SAPRecordset.Fields.Item(ColCount).Name) = SAPRecordset.Fields.Item(ColCount).Value

                    Next

                    'Add the row to the datatable
                    dtTable.Rows.Add(NewRow)


                    SAPRecordset.MoveNext()
                Loop

                Return dtTable

            Catch ex As Exception
                MsgBox(ex.ToString & Chr(10) & "Error converting SAP Recordset to DataTable", MsgBoxStyle.Exclamation)
                ConvertirRecordsetSAP = Nothing
                Exit Function
            End Try


        End Function

        Public Sub DatatableNET_a_Excel(ByVal dtTemp As DataTable)

            Dim _excel As New Microsoft.Office.Interop.Excel.Application
            Dim wBook As Microsoft.Office.Interop.Excel.Workbook
            Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet


            wBook = _excel.Workbooks.Add()
            wSheet = wBook.ActiveSheet()

            Dim dt As System.Data.DataTable = dtTemp
            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            ' Crea Progress Bar
            Try
                oProgBar = Application.SBO_Application.StatusBar.CreateProgressBar("Generando Columnas Excel", dt.Columns.Count, False)
            Catch ex As Exception
            End Try

            For Each dc In dt.Columns

                colIndex = colIndex + 1
                _excel.Cells(1, colIndex) = dc.ColumnName

                ' Actualiza Progress Bar
                Try
                    oProgBar.Value += 1
                Catch ex As Exception
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oProgBar)
                    oProgBar = Nothing
                    oProgBar = Application.SBO_Application.StatusBar.CreateProgressBar("Generando Columnas Excel", dt.Columns.Count, False)
                    oProgBar.Value = colIndex + 1
                End Try

            Next

            ' Cierra Progress Bar
            Try
                oProgBar.Stop()
            Catch ex As Exception
            End Try


            ' Crea Progress Bar
            Try
                oProgBar = Application.SBO_Application.StatusBar.CreateProgressBar("Generando Filas Excel", dt.Rows.Count, False)
            Catch ex As Exception
            End Try

            For Each dr In dt.Rows

                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    _excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next

                ' Actualiza Progress Bar
                Try
                    oProgBar.Value += 1
                Catch ex As Exception
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oProgBar)
                    oProgBar = Nothing
                    oProgBar = Application.SBO_Application.StatusBar.CreateProgressBar("Generando Filas Excel", dt.Rows.Count, False)
                    oProgBar.Value = rowIndex + 1
                End Try

            Next

            ' Cierra Progress Bar
            Try
                oProgBar.Stop()
            Catch ex As Exception
            End Try

            wSheet.Columns.AutoFit()

            _excel.Visible = True
            _excel.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized

            'Dim strFileName As String = "C:\datatable.xlsx"
            'If System.IO.File.Exists(strFileName) Then
            '    System.IO.File.Delete(strFileName)
            'End If

            'wBook.SaveAs(strFileName)
            'wBook.Close()
            '_excel.Quit()
        End Sub

        Public Sub DatatableSAP_a_Excel(ByVal DataTable As SAPbouiCOM.DataTable)

            Dim _excel As New Microsoft.Office.Interop.Excel.Application
            Dim wBook As Microsoft.Office.Interop.Excel.Workbook
            Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet


            wBook = _excel.Workbooks.Add()
            wSheet = wBook.ActiveSheet()

            Dim dc As SAPbouiCOM.DataColumn
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            ' Crea Progress Bar
            Try
                oProgBar = Application.SBO_Application.StatusBar.CreateProgressBar("Generando Columnas Excel", DataTable.Columns.Count, False)
            Catch ex As Exception
            End Try

            For Each dc In DataTable.Columns

                colIndex = colIndex + 1
                _excel.Cells(1, colIndex) = dc.Name

                ' Actualiza Progress Bar
                Try
                    oProgBar.Value += 1
                Catch ex As Exception
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oProgBar)
                    oProgBar = Nothing
                    oProgBar = Application.SBO_Application.StatusBar.CreateProgressBar("Generando Columnas Excel", DataTable.Columns.Count, False)
                    oProgBar.Value = colIndex + 1
                End Try

            Next

            ' Cierra Progress Bar
            Try
                oProgBar.Stop()
            Catch ex As Exception
            End Try


            ' Crea Progress Bar
            Try
                oProgBar = Application.SBO_Application.StatusBar.CreateProgressBar("Generando Filas Excel", DataTable.Rows.Count, False)
            Catch ex As Exception
            End Try

            For i = 0 To DataTable.Rows.Count - 1

                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In DataTable.Columns
                    colIndex = colIndex + 1
                    _excel.Cells(rowIndex + 1, colIndex) = DataTable.GetValue(dc.Name, i)
                Next

                ' Actualiza Progress Bar
                Try
                    oProgBar.Value += 1
                Catch ex As Exception
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oProgBar)
                    oProgBar = Nothing
                    oProgBar = Application.SBO_Application.StatusBar.CreateProgressBar("Generando Filas Excel", DataTable.Rows.Count, False)
                    oProgBar.Value = rowIndex + 1
                End Try

            Next

            ' Cierra Progress Bar
            Try
                oProgBar.Stop()
            Catch ex As Exception
            End Try

            wSheet.Columns.AutoFit()

            _excel.Visible = True
            _excel.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized


            'Dim strFileName As String = "C:\datatable.xlsx"
            'If System.IO.File.Exists(strFileName) Then
            '    System.IO.File.Delete(strFileName)
            'End If

            'wBook.SaveAs(strFileName)
            'wBook.Close()
            '_excel.Quit()
        End Sub

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '  FILTRAR LOS CFL DE ACUERDO A CONDICIONES (CLIENTES Y VENDEDORES)
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------

        Public Sub FiltrarChooseFromList(ByVal FormUID As String, ByVal CFL_ID As String)
            Try
                Dim oConditions As SAPbouiCOM.Conditions
                Dim oCondition As SAPbouiCOM.Condition
                Dim oChooseFromList As SAPbouiCOM.ChooseFromList
                Dim emptyCon As New SAPbouiCOM.Conditions
                oChooseFromList = Application.SBO_Application.Forms.Item(FormUID).ChooseFromLists.Item(CFL_ID)
                oChooseFromList.SetConditions(emptyCon)
                oConditions = oChooseFromList.GetConditions()
                oCondition = oConditions.Add
                oCondition.Alias = "CardType"
                oCondition.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL
                oCondition.CondVal = "C"
                oChooseFromList.SetConditions(oConditions)
            Catch ex As Exception
                Application.SBO_Application.StatusBar.SetText(ex.Message)
            End Try
        End Sub

        Public Sub FiltrarChooseFromListSLP(ByVal FormUID As String, ByVal CFL_ID As String)
            Try
                Dim oConditions As SAPbouiCOM.Conditions
                Dim oCondition As SAPbouiCOM.Condition
                Dim oChooseFromList As SAPbouiCOM.ChooseFromList
                Dim emptyCon As New SAPbouiCOM.Conditions
                oChooseFromList = Application.SBO_Application.Forms.Item(FormUID).ChooseFromLists.Item(CFL_ID)
                oChooseFromList.SetConditions(emptyCon)
                oConditions = oChooseFromList.GetConditions()
                oCondition = oConditions.Add
                oCondition.Alias = "Active"
                oCondition.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL
                oCondition.CondVal = "Y"
                oChooseFromList.SetConditions(oConditions)
            Catch ex As Exception
                Application.SBO_Application.StatusBar.SetText(ex.Message)
            End Try
        End Sub

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '  RETORNA EL PROXIMO CODIGO CORRELATIVO DE LA TABLA DE ENTRADA DE ACUERDO AL CAMPO ESPECIFICADO EN EL PARAMETRO 'CampoCorrelativo'
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        Public Function Proximo_Codigo_Correlativo(sTabla As String, CampoCorrelativo As String, DataTable As SAPbouiCOM.DataTable) As Integer

            Dim sql As String = "select isnull(max(CAST(" + CampoCorrelativo.Trim + " as int)),0)+1 as Proximo from [" + sBDComercial.Trim() + "].[dbo].[" + sTabla + "]"

            Try

                Try
                    DataTable.ExecuteQuery(sql)

                Catch ex As Exception

                End Try


            Catch ex As Exception

                Application.SBO_Application.MessageBox(sql)
                Application.SBO_Application.MessageBox(ex.Message)

            End Try

            Return DataTable.GetValue("Proximo", 0)

        End Function

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '  RETORNA EL PROXIMO CODIGO CORRELATIVO DE LA TABLA DE PROYECTOS (INCREMETO EN MAGNITUD 10)
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        Public Function Proximo_Codigo_OPRJ(DataTable As SAPbouiCOM.DataTable) As String

            Dim sql As String = " select isnull(max(cast(isnull(case when ISNUMERIC(prjcode) = 1 then prjcode else '0' end,'0') as nvarchar   )),0)+10 as Proximo from [" + sBDComercial.Trim() + "].[dbo].[oprj] " &
                                " where prjcode < '698661' and right(rtrim(prjcode),1) = '1'"

            Try

                Try
                    DataTable.ExecuteQuery(sql)

                Catch ex As Exception

                End Try


            Catch ex As Exception

                Application.SBO_Application.MessageBox(sql)
                Application.SBO_Application.MessageBox(ex.Message)

            End Try

            Return DataTable.GetValue("Proximo", 0)

        End Function

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '  ELIMINA TODOS LOS VALORES CARGADOS EN UN COMBOBOX
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        Public Sub Inicializar_ComboBox(FormId As String, ItemID As String)

            oForm = Application.SBO_Application.Forms.Item(FormId)

            oComboBox = oForm.Items.Item(ItemID).Specific

            Dim i As Integer = 0

            While oComboBox.ValidValues.Count > 0
                Try
                    oComboBox.ValidValues.Remove(i, SAPbouiCOM.BoSearchKey.psk_Index)
                Catch ex As Exception

                End Try
            End While

        End Sub


        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        '  CARGA UN COMBOBOX DE ACUERDO A LA CONSULTA PASADA EN EL PARAMETRO 'Query', HAY QUE INDICAR CUALES SON LOS CAMPOS A CARGAR (Value y Description) Y SI AGREGARA UNA LINEA VACIA AL COMIENZO
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Public Sub Cargar_ComboBox(FormId As String, ComboID As String, DataTableID As String, Query As String, ValorValue As Integer, ValorDescription As Integer, ValorVacio As Boolean)

            Try

                oForm = Application.SBO_Application.Forms.Item(FormId)
                oComboBox = oForm.Items.Item(ComboID).Specific
                oDTSQL = oForm.DataSources.DataTables.Item(DataTableID)

                oDTSQL.ExecuteQuery(Query)

                If ValorVacio Then ' Agrega primera linea de ComboBox Vacia
                    oComboBox.ValidValues.Add("", "")
                End If


                For i As Integer = 0 To oDTSQL.Rows.Count - 1
                    oComboBox.ValidValues.Add(oDTSQL.GetValue(ValorValue, i).ToString, oDTSQL.GetValue(ValorDescription, i).ToString)
                Next

            Catch ex As Exception

            End Try

        End Sub

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '  ELIMINA TODOS LOS VALORES CARGADOS EN UN COMBOBOX COLUNM
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        Public Sub Inicializar_ComboBoxColumn(FormId As String, GridID As String, ItemID As String)

            oForm = Application.SBO_Application.Forms.Item(FormId)
            oGrid = oForm.Items.Item(GridID).Specific
            oComboCol = oGrid.Columns.Item(ItemID)

            Dim i As Integer = 0

            While oComboCol.ValidValues.Count > 0
                Try
                    oComboCol.ValidValues.Remove(i, SAPbouiCOM.BoSearchKey.psk_Index)
                Catch ex As Exception

                End Try
            End While

        End Sub


        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        '  CARGA UN COMBOBOX COLUNM DE ACUERDO A LA CONSULTA PASADA EN EL PARAMETRO 'Query', HAY QUE INDICAR CUALES SON LOS CAMPOS A CARGAR (Value y Description) Y SI AGREGARA UNA LINEA VACIA AL COMIENZO
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Public Sub Cargar_ComboBoxColumn(FormId As String, GridID As String, ComboID As String, DataTableID As String, Query As String, ValorValue As Integer, ValorDescription As Integer, ValorVacio As Boolean)

            Try

                oForm = Application.SBO_Application.Forms.Item(FormId)
                oGrid = oForm.Items.Item(GridID).Specific
                oComboCol = oGrid.Columns.Item(ComboID)
                oDTSQL = oForm.DataSources.DataTables.Item(DataTableID)

                oDTSQL.ExecuteQuery(Query)

                If ValorVacio Then ' Agrega primera linea de ComboBox Vacia
                    oComboCol.ValidValues.Add("", "")
                End If


                For i As Integer = 0 To oDTSQL.Rows.Count - 1
                    oComboCol.ValidValues.Add(oDTSQL.GetValue(ValorValue, i).ToString, oDTSQL.GetValue(ValorDescription, i).ToString)
                Next

            Catch ex As Exception

            End Try

        End Sub

        Public Function Numero_Columna_Matrix(FormID As String, MatrixID As String, ColID As String) As Integer

            Numero_Columna_Matrix = 0

            oForm = Application.SBO_Application.Forms.Item(FormID)
            oMatrix = oForm.Items.Item(MatrixID).Specific

            Dim iColNo As Integer = 0
            For iCols As Integer = 0 To oMatrix.Columns.Count - 1
                If oMatrix.Columns.Item(iCols).UniqueID.ToString.Trim = ColID Then
                    iColNo = iCols
                    Exit For
                End If
            Next

            Numero_Columna_Matrix = iColNo

        End Function

        Public Function Numero_Columna_Grid(FormID As String, GridID As String, ColID As String) As Integer

            Numero_Columna_Grid = 0

            oForm = Application.SBO_Application.Forms.Item(FormID)
            oGrid = oForm.Items.Item(GridID).Specific

            Dim iColNo As Integer = 0
            For iCols As Integer = 0 To oGrid.Columns.Count - 1
                If oGrid.Columns.Item(iCols).UniqueID.ToString.Trim = ColID Then
                    iColNo = iCols
                    Exit For
                End If
            Next

            Numero_Columna_Grid = iColNo

        End Function

        Public Sub Numero_Fila_Grid(oGrid As SAPbouiCOM.Grid)

            Dim oHeader As SAPbouiCOM.RowHeaders = oGrid.RowHeaders

            For i = 0 To oGrid.Rows.Count - 1
                oHeader.SetText(i, Convert.ToString(i + 1))
            Next

        End Sub

        Public Sub BackColor_Percent_Edit(oEdit As SAPbouiCOM.EditText)

            'Asignar Color al Porcentaje de Industrial
            Dim dPorc As Decimal = CDbl(Replace(Replace(oEdit.Value.ToString.Trim(), "%", ""), ".", ","))
            If dPorc = 100 Then
                oEdit.BackColor = RGB(48, 204, 0)
            ElseIf dPorc >= 75 And dPorc <= 99.99 Then
                oEdit.BackColor = RGB(60, 254, 0)
            ElseIf dPorc >= 50 And dPorc <= 74.99 Then
                oEdit.BackColor = RGB(117, 255, 75)
            ElseIf dPorc >= 25 And dPorc <= 49.99 Then
                oEdit.BackColor = RGB(117, 255, 153)
            ElseIf dPorc >= 0.01 And dPorc <= 24.99 Then
                oEdit.BackColor = RGB(234, 255, 177)
            Else
                oEdit.BackColor = RGB(240, 128, 128)
            End If

        End Sub

        Public Shared Function Create_ProgressBar(ByRef oProgBarx As SAPbouiCOM.ProgressBar, ByVal sMessage As String, ByVal iValue As Integer) As Boolean
            Dim bSucess As Boolean = False
            '********************* PROGRESS BAR
            Try
                GC.Collect()
                oProgBarx = Nothing
                System.Runtime.InteropServices.Marshal.ReleaseComObject(oProgBarx)
                oProgBarx = Nothing
                GC.Collect()
                bSucess = True
            Catch ex As Exception

            End Try

            Try
                oProgBarx = Application.SBO_Application.StatusBar.CreateProgressBar(sMessage, iValue, True)
                oProgBarx.Value = 0
                oProgBarx.Value = (oProgBarx.Value + 1)
                bSucess = True
            Catch ex As Exception
                bSucess = False
            End Try

            Return bSucess
        End Function

        Public Shared Function ChangeText_ProgressBar(ByRef oProgBar As SAPbouiCOM.ProgressBar, ByVal sMessage As String) As Boolean
            Dim bSucess As Boolean = False
            Try
                oProgBar.Text = sMessage
                bSucess = True
            Catch ex As Exception
                bSucess = False
            End Try

            Return bSucess
        End Function

        Public Shared Function Increment_ProgressBar(ByRef oProgBar As SAPbouiCOM.ProgressBar, ByVal iIncrement As Integer) As Boolean
            Dim bSucess As Boolean = False
            Try
                oProgBar.Value = (oProgBar.Value + iIncrement)
                bSucess = True
            Catch ex As Exception
                bSucess = False
            End Try

            Return bSucess
        End Function

        Public Shared Function Close_ProgressBar(ByRef oProgBar As SAPbouiCOM.ProgressBar) As Boolean
            Dim bSucess As Boolean = False
            Try
                oProgBar.Stop()
                System.Runtime.InteropServices.Marshal.ReleaseComObject(oProgBar)
                oProgBar = Nothing
                GC.Collect()
                bSucess = True
            Catch ex As Exception
                Try
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oProgBar)
                    oProgBar = Nothing
                    GC.Collect()
                    bSucess = True
                Catch ex1 As Exception
                    bSucess = False
                End Try

            End Try

            Return bSucess

        End Function

        '---------------------------------------------------------------------------------------
        ' Funciones para Obtener las Rutas de un Archivo Seleccionado con un file dialog box 
        '---------------------------------------------------------------------------------------
        Private FileName As String
        <Runtime.InteropServices.DllImport("user32.dll")>
        Private Shared Function GetForegroundWindow() As IntPtr
        End Function

        Public Function showOpenFileDialog() As String

            'Dim ShowFolderBrowserThread As Threading.Thread
            Try
                Dim ShowFolderBrowserThread As New Threading.Thread(AddressOf ShowFolderBrowser)
                If ShowFolderBrowserThread.ThreadState = System.Threading.ThreadState.Unstarted Then
                    ShowFolderBrowserThread.SetApartmentState(Threading.ApartmentState.STA)
                    'ShowFolderBrowserThread.SetApartmentState(System.Threading.ApartmentState.STA)
                    ShowFolderBrowserThread.Start()
                    While Not ShowFolderBrowserThread.IsAlive
                    End While
                    Threading.Thread.Sleep(1000)
                    ShowFolderBrowserThread.Join()


                ElseIf ShowFolderBrowserThread.ThreadState = Threading.ThreadState.Stopped Then
                    ShowFolderBrowserThread.Start()
                    While Not ShowFolderBrowserThread.IsAlive
                    End While
                    Threading.Thread.Sleep(1000)
                    ShowFolderBrowserThread.Join()

                End If
                While ShowFolderBrowserThread.ThreadState = Threading.ThreadState.Running
                    Windows.Forms.Application.DoEvents()
                End While
                If FileName <> "" Then
                    Return FileName
                End If
            Catch ex As Exception
                'SBO_Application.MessageBox("FileFile" & ex.Message)
                Application.SBO_Application.MessageBox(ex.ToString())
            End Try

            Return ""

        End Function

        Public Sub ShowFolderBrowser()

            Dim f As New FileIOPermission(PermissionState.None)
            f.AllLocalFiles = FileIOPermissionAccess.AllAccess
            Dim MyProcs() As System.Diagnostics.Process
            Dim FileName = ""
            Dim OpenFile As New Windows.Forms.OpenFileDialog

            Try
                OpenFile.Multiselect = False
                OpenFile.Filter = "|*.*"
                Dim filterindex As Integer = 0
                Try
                    filterindex = 0
                Catch ex As Exception
                End Try

                OpenFile.FilterIndex = filterindex

                OpenFile.RestoreDirectory = True
                MyProcs = Process.GetProcessesByName("SAP Business One")

                If MyProcs.Length = 1 Then
                    For i As Integer = 0 To MyProcs.Length - 1

                        Dim MyWindow As New WindowWrapper(MyProcs(i).MainWindowHandle)
                        Dim ret As Windows.Forms.DialogResult = OpenFile.ShowDialog(MyWindow)

                        If ret = Windows.Forms.DialogResult.OK Then
                            FileName = OpenFile.FileName
                            OpenFile.Dispose()
                        Else
                            System.Windows.Forms.Application.ExitThread()
                        End If
                    Next
                Else
                    Dim cProcess As System.Diagnostics.Process = System.Diagnostics.Process.GetCurrentProcess()
                    Dim iSBOID As Integer = getProcessParentID(cProcess.ProcessName, cProcess.Id)
                    Dim kProcs As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(iSBOID, cProcess.MachineName)
                    Dim SAPWindow As New WindowWrapper(kProcs.MainWindowHandle)
                    Dim ret As Windows.Forms.DialogResult = OpenFile.ShowDialog(SAPWindow)

                    If ret = Windows.Forms.DialogResult.OK Then
                        FileName = OpenFile.FileName
                        OpenFile.Dispose()
                    Else
                        System.Windows.Forms.Application.ExitThread()
                    End If
                End If
            Catch ex As Exception
                Application.SBO_Application.StatusBar.SetText(ex.Message)
                FileName = ""
            Finally
                OpenFile.Dispose()
            End Try
            'Dim MyProcs() As System.Diagnostics.Process
            'FileName = ""
            'Dim OpenFile As New System.Windows.Forms.OpenFileDialog

            'Dim form As System.Windows.Forms.Form = New System.Windows.Forms.Form()
            'form.TopMost = True
            ''Dim objOpenFileDialog As New System.Windows.Forms.OpenFileDialog
            ''objOpenFileDialog.InitialDirectory = System.Windows.Forms.Application.StartupPath + "\"
            ''objOpenFileDialog.Filter = "Excel files (*.xls)|*.xls";

            ''if(objOpenFileDialog.ShowDialog(form)!= DialogResult.Cancel) then
            ''End If

            'Try
            '    OpenFile.Multiselect = False
            '    OpenFile.Filter = "All files (*.*)|*.*"   '"All files(*.CSV)|*.CSV"
            '    Dim filterindex As Integer = 0
            '    Try
            '        filterindex = 0
            '    Catch ex As Exception
            '    End Try

            '    OpenFile.FilterIndex = filterindex

            '    OpenFile.RestoreDirectory = True
            '    MyProcs = System.Diagnostics.Process.GetProcessesByName("SAP Business One")

            '    If MyProcs.Length = 1 Then
            '        For i As Integer = 0 To MyProcs.Length - 1

            '            Dim MyWindow As New WindowWrapper(MyProcs(i).MainWindowHandle)

            '            Dim ret As Windows.Forms.DialogResult = OpenFile.ShowDialog(MyWindow)
            '            If ret = Windows.Forms.DialogResult.OK Then
            '                FileName = OpenFile.FileName
            '                OpenFile.Dispose()
            '            Else
            '                System.Windows.Forms.Application.ExitThread()
            '            End If
            '        Next
            '    End If
            'Catch ex As Exception
            '    'SBO_Application.StatusBar.SetText(ex.Message)
            '    Application.SBO_Application.MessageBox(ex.ToString())
            '    FileName = ""
            'Finally
            '    OpenFile.Dispose()
            'End Try

        End Sub

        Public Class WindowWrapper
            Implements System.Windows.Forms.IWin32Window
            Private _hwnd As IntPtr

            Public Sub New(ByVal handle As IntPtr)
                _hwnd = handle
            End Sub

            Private ReadOnly Property Handle() As System.IntPtr Implements System.Windows.Forms.IWin32Window.Handle
                Get
                    Return _hwnd
                End Get
            End Property
        End Class


        Public Function getProcessParentID(ByVal cName As String, ByVal cID As Integer) As Integer
            Dim query As System.Management.SelectQuery = New SelectQuery("SELECT * FROM Win32_Process WHERE Name like '" & cName & ".exe' and ProcessId = " & cID)
            Dim mgmtSearcher As System.Management.ManagementObjectSearcher = New ManagementObjectSearcher(query)
            Dim iID As Integer = -1
            For Each p As System.Management.ManagementObject In mgmtSearcher.Get()
                Dim s(1) As String
                p.InvokeMethod("GetOwner", DirectCast(s, Object()))
                ' Source Code link : http://www.vbdotnetforums.com/windows-services/4022-kill-specific-process.html  
                ' More Object Reference at this link : http://msdn.microsoft.com/en-us/library/aa394372(VS.85).asp  
                iID = p("ParentProcessId")
            Next
            Return iID
        End Function

        Public Sub Abre_Dialogo_y_Asigna_Path(EditText As SAPbouiCOM.EditText)
            ' Abre una ventana de File Dialog y toma la ruta completa del archivo seleccionado
            'oForm = Application.SBO_Application.Forms.Item(FormID)
            'oedit = oForm.Items.Item(EditTextID).Specific
            Dim sRuta As String = NOpenDialog.OpenFileDialog() 'showOpenFileDialog()
            EditText.Value = sRuta.Trim()

        End Sub

        Public Sub Abre_Dialogo_y_Asigna_Path2(EditText As SAPbouiCOM.EditText)
            ' Abre una ventana de File Dialog y toma la ruta completa del archivo seleccionado
            'oForm = Application.SBO_Application.Forms.Item(FormID)
            'oedit = oForm.Items.Item(EditTextID).Specific
            Dim sRuta As String = NOpenFileDialog.ShowOpenFileDialog() 'showOpenFileDialog()
            EditText.Value = sRuta.Trim()

        End Sub

        Public Sub Abre_Dialogo_y_Asigna_Path3(EditText As SAPbouiCOM.EditText, TipoDialogo As DialogType)
            ' Abre una ventana de File Dialog y toma la ruta completa del archivo seleccionado

            Dim dialog As New NSelectFileDialog("", "", "All files (*.*)|*.*", TipoDialogo)
            dialog.Open()

            If Not String.IsNullOrEmpty(dialog.SelectedFile) Then
                EditText.Value = dialog.SelectedFile.Trim()
            End If

        End Sub


        '------------------------------------------------------------------------------------------------------------------------------------------------------

        Public Sub LinkedObjectForm(ByVal FormUniqueID As String, ByVal ActivateMenuItem As String, ByVal FindItemUID As String, ByVal FindItemUIDValue As String)

            Try

                Dim oForm As SAPbouiCOM.Form
                Dim Bool As Boolean = False

                'For frm As Integer = 0 To Application.SBO_Application.Forms.Count - 1
                '    Dim sCad As String = Application.SBO_Application.Forms.Item(frm).UniqueID
                '    If Application.SBO_Application.Forms.Item(frm). = FormUniqueID Then
                '        'Application.SBO_Application.Forms.Item(pVal.FormUID)
                '        oForm = Application.SBO_Application.Forms.Item(FormUniqueID)
                '        oForm.Close()

                '        Exit For

                '    End If

                'Next

                If Bool = False Then

                    Application.SBO_Application.ActivateMenuItem(ActivateMenuItem)

                    Application.SBO_Application.Forms.ActiveForm.Freeze(True)

                    oForm = Application.SBO_Application.Forms.ActiveForm

                    oForm.Select()

                    oForm.Mode = SAPbouiCOM.BoFormMode.fm_FIND_MODE

                    oForm.Items.Item(FindItemUID).Enabled = True

                    oForm.Items.Item(FindItemUID).Specific.Value = Trim(FindItemUIDValue)

                    oForm.Items.Item("1").Click()

                    oForm.Freeze(False)


                End If

            Catch ex As Exception

                Application.SBO_Application.MessageBox(oCompany.GetLastErrorDescription)

            Finally

            End Try

        End Sub

        Public Sub AgregarUserDataSource(oForm As SAPbouiCOM.Form, Nombre As String, Tipo As SAPbouiCOM.BoDataType, Longitud As Integer)

            If Not UserDataSourceExists(oForm, Nombre) Then
                Try
                    oUDataSource = oForm.DataSources.UserDataSources.Add(Nombre, Tipo, Longitud)
                Catch ex As Exception

                End Try
            End If

        End Sub

        Public Sub IdentificarAccesoUsuario(oDataTable As SAPbouiCOM.DataTable)

            Dim Acceso As String = ""

            sPSql = "SELECT * FROM [" + sBDComercial + "].dbo.[OUSR] where USER_Code ='" + oConectarAplicacion.sAliasUsuActual + "'"

            Try
                oDataTable.ExecuteQuery(sPSql)
                Acceso = Convert.ToString(oDataTable.GetValue("U_Acceso_DocuPro", 0))
                Habilitado = IIf(Acceso = "S", True, False)
                ConsultaUsuario = True
            Catch ex As Exception
                Habilitado = False
            End Try


        End Sub

        Public Shared Sub FreezeForm(oForm As SAPbouiCOM.Form, Status As Boolean)
            Try
                If Application.SBO_Application.ClientType = SAPbouiCOM.BoClientType.ct_Desktop Then

                    oForm.Freeze(Status)

                End If
            Catch ex As Exception
            End Try

        End Sub

    End Class

End Namespace



