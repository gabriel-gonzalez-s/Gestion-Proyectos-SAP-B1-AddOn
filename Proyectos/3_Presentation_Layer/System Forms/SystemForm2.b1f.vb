Option Strict Off
Option Explicit On

Imports SAPbouiCOM.Framework

Namespace SBOAddonProject1
    <FormAttribute("139", "3_Presentation_Layer/System Forms/SystemForm2.b1f")>
    Friend Class SystemForm2
        Inherits SystemFormBase

        Public Sub New()
        End Sub

        Public Overrides Sub OnInitializeComponent()
            Me.EditText0 = CType(Me.GetItem("edCodPro").Specific, SAPbouiCOM.EditText)
            Me.EditText1 = CType(Me.GetItem("edNomPro").Specific, SAPbouiCOM.EditText)
            Me.EditText2 = CType(Me.GetItem("edFecPro").Specific, SAPbouiCOM.EditText)
            Me.StaticText0 = CType(Me.GetItem("Item_3").Specific, SAPbouiCOM.StaticText)
            Me.StaticText1 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.StaticText)
            Me.StaticText2 = CType(Me.GetItem("Item_5").Specific, SAPbouiCOM.StaticText)
            Me.EditText3 = CType(Me.GetItem("edFTD").Specific, SAPbouiCOM.EditText)
            Me.EditText4 = CType(Me.GetItem("edFTP").Specific, SAPbouiCOM.EditText)
            Me.EditText5 = CType(Me.GetItem("edFID").Specific, SAPbouiCOM.EditText)
            Me.EditText6 = CType(Me.GetItem("edFIMo").Specific, SAPbouiCOM.EditText)
            Me.EditText7 = CType(Me.GetItem("edFTMo").Specific, SAPbouiCOM.EditText)
            Me.EditText8 = CType(Me.GetItem("edFPCl").Specific, SAPbouiCOM.EditText)
            Me.EditText9 = CType(Me.GetItem("edMulta").Specific, SAPbouiCOM.EditText)
            Me.EditText10 = CType(Me.GetItem("edMulD").Specific, SAPbouiCOM.EditText)
            Me.EditText11 = CType(Me.GetItem("edMulMo").Specific, SAPbouiCOM.EditText)
            Me.EditText12 = CType(Me.GetItem("edFrecMul").Specific, SAPbouiCOM.EditText)
            Me.EditText13 = CType(Me.GetItem("edComMul").Specific, SAPbouiCOM.EditText)
            Me.EditText14 = CType(Me.GetItem("edNumCont").Specific, SAPbouiCOM.EditText)
            Me.StaticText3 = CType(Me.GetItem("Item_18").Specific, SAPbouiCOM.StaticText)
            Me.StaticText4 = CType(Me.GetItem("Item_19").Specific, SAPbouiCOM.StaticText)
            Me.StaticText5 = CType(Me.GetItem("Item_20").Specific, SAPbouiCOM.StaticText)
            Me.StaticText6 = CType(Me.GetItem("Item_21").Specific, SAPbouiCOM.StaticText)
            Me.StaticText7 = CType(Me.GetItem("Item_22").Specific, SAPbouiCOM.StaticText)
            Me.StaticText8 = CType(Me.GetItem("Item_23").Specific, SAPbouiCOM.StaticText)
            Me.StaticText9 = CType(Me.GetItem("Item_24").Specific, SAPbouiCOM.StaticText)
            Me.StaticText10 = CType(Me.GetItem("Item_25").Specific, SAPbouiCOM.StaticText)
            Me.StaticText11 = CType(Me.GetItem("Item_26").Specific, SAPbouiCOM.StaticText)
            Me.StaticText12 = CType(Me.GetItem("Item_27").Specific, SAPbouiCOM.StaticText)
            Me.StaticText13 = CType(Me.GetItem("Item_28").Specific, SAPbouiCOM.StaticText)
            Me.StaticText14 = CType(Me.GetItem("Item_29").Specific, SAPbouiCOM.StaticText)
            Me.EditText15 = CType(Me.GetItem("edKilosTot").Specific, SAPbouiCOM.EditText)
            Me.StaticText15 = CType(Me.GetItem("Item_31").Specific, SAPbouiCOM.StaticText)
            Me.Button0 = CType(Me.GetItem("btnNewProy").Specific, SAPbouiCOM.Button)
            Me.Matrix0 = CType(Me.GetItem("MtxPlanos").Specific, SAPbouiCOM.Matrix)
            Me.Matrix1 = CType(Me.GetItem("MtxDocPro").Specific, SAPbouiCOM.Matrix)
            Me.PictureBox0 = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.PictureBox)
            Me.OnCustomInitialize()

        End Sub

        Public Overrides Sub OnInitializeFormEvents()
            AddHandler ResizeAfter, AddressOf Me.Form_ResizeAfter
            AddHandler DataLoadAfter, AddressOf Me.Form_DataLoadAfter

        End Sub

        Private Sub OnCustomInitialize()

            Try
                Dim formID As String = Me.UIAPIRawForm.UniqueID
                oForm = Application.SBO_Application.Forms.Item(Me.UIAPIRawForm.UniqueID)
                Me.PictureBox0.Picture = sPathAnexos + "images\reload.bmp"
                oForm.DataSources.UserDataSources.Add("UDS_CFLPRO", SAPbouiCOM.BoDataType.dt_LONG_TEXT)
                oForm.DataSources.DataTables.Add("DT_INFOPRO")
                oForm.DataSources.DataTables.Add("DT_Planos")
                oForm.DataSources.DataTables.Add("DT_DocuPro")
                oFunciones.AgregarUserDataSource(oForm, "UDS_Edit", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
                oFunciones.AgregarUserDataSource(oForm, "UDS_Edit2", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
                oFunciones.AgregarUserDataSource(oForm, "UDS_Edit3", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
                oFunciones.AgregarUserDataSource(oForm, "UDS_Proy1", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
                oFunciones.AgregarUserDataSource(oForm, "UDS_Proy2", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
                oFunciones.AgregarUserDataSource(oForm, "UDS_Proy3", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
                oFunciones.AgregarUserDataSource(oForm, "UDS_Proy4", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
                oFunciones.AgregarUserDataSource(oForm, "UDS_Proy5", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
                oFunciones.AgregarUserDataSource(oForm, "UDS_Proy5A", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
                oFunciones.AgregarUserDataSource(oForm, "UDS_Proy6", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
                oFunciones.AgregarUserDataSource(oForm, "UDS_Proy7", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
                oFunciones.AgregarUserDataSource(oForm, "UDS_Proy8", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
                oFunciones.AgregarUserDataSource(oForm, "UDS_Proy9", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
                oFunciones.AgregarUserDataSource(oForm, "UDS_Proy10", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
                oFunciones.AgregarUserDataSource(oForm, "UDS_Proy12", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
                oFunciones.AgregarUserDataSource(oForm, "UD_Kilos", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
                EditText0.DataBind.SetBound(True, "", "UDS_Edit")
                EditText1.DataBind.SetBound(True, "", "UDS_Edit2")
                EditText2.DataBind.SetBound(True, "", "UDS_Edit3")
                EditText3.DataBind.SetBound(True, "", "UDS_Proy1")
                EditText4.DataBind.SetBound(True, "", "UDS_Proy2")
                EditText5.DataBind.SetBound(True, "", "UDS_Proy3")
                EditText6.DataBind.SetBound(True, "", "UDS_Proy4")
                EditText7.DataBind.SetBound(True, "", "UDS_Proy5")
                EditText8.DataBind.SetBound(True, "", "UDS_Proy5A")
                EditText9.DataBind.SetBound(True, "", "UDS_Proy6")
                EditText10.DataBind.SetBound(True, "", "UDS_Proy7")
                EditText11.DataBind.SetBound(True, "", "UDS_Proy8")
                EditText12.DataBind.SetBound(True, "", "UDS_Proy9")
                EditText13.DataBind.SetBound(True, "", "UDS_Proy10")
                EditText14.DataBind.SetBound(True, "", "UDS_Proy12")
                EditText15.DataBind.SetBound(True, "", "UD_Kilos")
                EditText0.Item.AffectsFormMode = False
                EditText1.Item.AffectsFormMode = False
                EditText2.Item.AffectsFormMode = False
                EditText3.Item.AffectsFormMode = False
                EditText4.Item.AffectsFormMode = False
                EditText5.Item.AffectsFormMode = False
                EditText6.Item.AffectsFormMode = False
                EditText7.Item.AffectsFormMode = False
                EditText8.Item.AffectsFormMode = False
                EditText9.Item.AffectsFormMode = False
                EditText10.Item.AffectsFormMode = False
                EditText11.Item.AffectsFormMode = False
                EditText12.Item.AffectsFormMode = False
                EditText13.Item.AffectsFormMode = False
                EditText14.Item.AffectsFormMode = False
                EditText15.Item.AffectsFormMode = False
                PictureBox0.Item.AffectsFormMode = False
                Agregar_Tabs_Pedidos(oForm)


                If AbiertoDesdeEnlace Then

                    AbiertoDesdeEnlace = False
                    SystemForm2.Cargar_Datos_Proyecto_Pedido_Cliente_Existente(formID)

                End If

            Catch ex As Exception
                Application.SBO_Application.StatusBar.SetText(ex.Message, SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
            End Try

        End Sub


        Private Sub Form_DataLoadAfter(ByRef pVal As SAPbouiCOM.BusinessObjectInfo)

            Try
                If oForm.Mode = SAPbouiCOM.BoFormMode.fm_ADD_MODE Or oForm.Mode = SAPbouiCOM.BoFormMode.fm_UPDATE_MODE Then
                    PictureBox0.Item.Visible = True
                Else
                    PictureBox0.Item.Visible = False
                End If
            Catch ex As Exception

            End Try

        End Sub

        Private Sub Form_ResizeAfter(pVal As SAPbouiCOM.SBOItemEventArg)

            Try
                oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
                oItem = oForm.Items.Item("157")
                PictureBox0.Item.Top = oItem.Top
                oItem = oForm.Items.Item("134")
                Button0.Item.Top = oItem.Top + 30
            Catch ex As Exception
            End Try

        End Sub

        Private Sub PictureBox0_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles PictureBox0.ClickAfter

            If PictureBox0.Item.Visible = True Then

                Try
                    oForm = Application.SBO_Application.Forms.Item(Me.UIAPIRawForm.UniqueID)
                    oForm.Freeze(True)
                    oedit = oForm.Items.Item("157").Specific
                    Dim sCad As String = oedit.Value

                    If sCad.Trim().Length > 0 And sCad.Trim() <> "PRESTAMO" Then

                        SystemForm2.Cargar_Datos_Proyecto(oForm, sCad, pVal.FormUID, "")
                        SystemForm2.Cargar_Datos_Adicionales_Proyecto(oForm, sCad, pVal.FormUID)
                        SystemForm2.Cargar_Matrix_Planos_Proyecto(oForm)
                        SystemForm2.Cargar_Matrix_Documentos_Proyecto(oForm)

                        oForm = Application.SBO_Application.Forms.Item(Me.UIAPIRawForm.UniqueID)
                        oForm.Items.Item("14").Click()

                    End If
                Catch ex As Exception
                Finally
                    oForm.Freeze(False)
                End Try


            End If

        End Sub

        Public Shared Sub Cargar_Datos_Al_Seleccionar_Proyecto(sFormOrig As String, sCodPro As String)

            Try
                Try
                    oForm = Application.SBO_Application.Forms.GetForm(sFormOrig, 0)
                Catch ex As Exception
                    oForm = Application.SBO_Application.Forms.Item(sFormOrig)
                End Try
                oForm.Freeze(True)
                oForm.Select()
                oForm.Mode = SAPbouiCOM.BoFormMode.fm_ADD_MODE

                'oForm.PaneLevel = 7
                'oedit = oForm.Items.Item("157").Specific
                'oedit.Item.Click()
                'oedit.Value = sCodPro
                'Application.SBO_Application.SendKeys("{TAB}")

                SystemForm2.Cargar_Datos_Proyecto(oForm, sCodPro, oForm.UniqueID, "")
                SystemForm2.Cargar_Datos_Adicionales_Proyecto(oForm, sCodPro, oForm.UniqueID)
                SystemForm2.Cargar_Matrix_Planos_Proyecto(oForm)
                SystemForm2.Cargar_Matrix_Documentos_Proyecto(oForm)

                If DatosProyectoCargados = 0 Then
                    DatosProyectoCargados = 1
                    Dim oedit2 As SAPbouiCOM.EditText
                    oedit2 = oForm.Items.Item("157").Specific
                    oedit2.Value = sCodPro
                End If

                oForm.Items.Item("14").Click()

            Catch ex As Exception
                Application.SBO_Application.MessageBox(ex.Message)
            Finally
                oForm.Freeze(False)
            End Try

        End Sub

        Public Shared Sub Cargar_Datos_Proyecto(oForm As SAPbouiCOM.Form, sCodiP As String, FormUID As String, Evento As String)

            Dim oDataTable As SAPbouiCOM.DataTable = oForm.DataSources.DataTables.Item("DT_INFOPRO")

            Dim query As String = " EXEC [SBO_COMERCIAL].[dbo].[Min_GPR_Consultar_Datos_Proyecto] N'" + sCodiP + "'"

            Try

                Try
                    oDataTable.ExecuteQuery(query)
                Catch ex As Exception
                End Try

                If oDataTable.IsEmpty = False Then

                    oForm = Application.SBO_Application.Forms.Item(FormUID)
                    'oForm = Application.SBO_Application.Forms.GetForm("139", 0)
                    Dim oedit2 As SAPbouiCOM.EditText

                    If Evento <> "et_FORM_DATA_LOAD" Then 'Modifica los campos solo si el evento es distinto a et_FORM_DATA_LOAD
                        oedit2 = oForm.Items.Item("4").Specific
                        If oedit2.Item.Enabled = True And oConectarAplicacion.sCurrentCompanyDB = sBDComercial Then
                            oedit2.Item.Click()
                            oedit2.Value = oDataTable.GetValue("CardCode", 0)
                            'oedit2 = oForm.Items.Item("54").Specific
                            'oedit2.Value = oDataTable.GetValue("CardName", 0)
                            Application.SBO_Application.SendKeys("{TAB}")
                        End If

                        Try
                            If oDataTable.GetValue("Nombre_Vendedor", 0).ToString.Trim.Length() > 0 Then
                                oComboBox = oForm.Items.Item("20").Specific
                                oComboBox.Item.Description = oDataTable.GetValue("Nombre_Vendedor", 0)
                                oComboBox.Select(oDataTable.GetValue("Nombre_Vendedor", 0), SAPbouiCOM.BoSearchKey.psk_ByValue)
                            End If
                        Catch ex As Exception
                        End Try

                        oedit2 = oForm.Items.Item("10").Specific
                        Dim Contab As Date = oedit2.String
                        oedit2 = oForm.Items.Item("12").Specific
                        Dim Entreg As Date = oDataTable.GetValue("Fecha_Ini_Despa", 0)
                        Try
                            oedit2.String = oDataTable.GetValue("Fecha_Ini_Despa", 0)
                        Catch ex As Exception

                        End Try
                        If Contab <= Entreg Then
                            Try
                                oedit2.String = oDataTable.GetValue("Fecha_Ini_Despa", 0)
                            Catch ex As Exception

                            End Try
                        End If

                    End If

                    oForm.DataSources.UserDataSources.Item("UDS_Edit").ValueEx = sCodiP
                    oForm.DataSources.UserDataSources.Item("UDS_Edit2").ValueEx = oDataTable.GetValue("Nombre", 0)

                    oForm.DataSources.UserDataSources.Item("UDS_Proy1").ValueEx = oDataTable.GetValue("Fecha_Fin_Desarr", 0)
                    oForm.DataSources.UserDataSources.Item("UDS_Proy2").ValueEx = oDataTable.GetValue("Fecha_Fin_Produc", 0)
                    oForm.DataSources.UserDataSources.Item("UDS_Proy3").ValueEx = If(oDataTable.GetValue("U_Con_Despacho", 0) = "1", oDataTable.GetValue("Fecha_Ini_Despa", 0), "Sin Despacho")
                    oForm.DataSources.UserDataSources.Item("UDS_Proy4").ValueEx = If(oDataTable.GetValue("U_Con_Montaje", 0) = "1", oDataTable.GetValue("Fecha_Ini_Monta", 0), "Sin Montaje")
                    oForm.DataSources.UserDataSources.Item("UDS_Proy5").ValueEx = If(oDataTable.GetValue("U_Con_Montaje", 0) = "1", oDataTable.GetValue("Fecha_Fin_Monta", 0), "Sin Montaje")
                    oForm.DataSources.UserDataSources.Item("UDS_Proy5A").ValueEx = oDataTable.GetValue("Fecha_Prom_Cli", 0)
                    oForm.DataSources.UserDataSources.Item("UDS_Edit3").ValueEx = oDataTable.GetValue("Fecha_Prom_Cli", 0)

                    oForm.Items.Item("16").Click()
                    'oForm.Items.Item("edCodPro").Enabled = False
                    'oForm.Items.Item("edNomPro").Enabled = False
                    'oForm.Items.Item("edFTD").Enabled = False
                    'oForm.Items.Item("edFTP").Enabled = False
                    'oForm.Items.Item("edFID").Enabled = False
                    'oForm.Items.Item("edFIMo").Enabled = False
                    'oForm.Items.Item("edFTMo").Enabled = False
                    'oForm.Items.Item("edFPCl").Enabled = False
                    'oForm.Items.Item("edFecPro").Enabled = False

                    oForm.DataSources.UserDataSources.Item("UDS_Proy6").ValueEx = oDataTable.GetValue("Multa", 0)
                    oForm.DataSources.UserDataSources.Item("UDS_Proy7").ValueEx = If(oDataTable.GetValue("Multa_Despa", 0) = "Y", "Si", "No")
                    oForm.DataSources.UserDataSources.Item("UDS_Proy8").ValueEx = If(oDataTable.GetValue("Multa_Monta", 0) = "Y", "Si", "No")
                    Dim sFrecu As String = oDataTable.GetValue("Frecuencia_Multa", 0)
                    oForm.DataSources.UserDataSources.Item("UDS_Proy9").ValueEx = If(sFrecu = "D", "Diaria", If(sFrecu = "S", "Semanal", If(sFrecu = "M", "Mensual", "")))
                    oForm.DataSources.UserDataSources.Item("UDS_Proy10").ValueEx = oDataTable.GetValue("Comentario_Multa", 0)
                    oForm.DataSources.UserDataSources.Item("UDS_Proy12").ValueEx = oDataTable.GetValue("U_Contrato_Cli", 0)

                    oForm.Items.Item("16").Click()
                    'oForm.Items.Item("edMulta").Enabled = False
                    'oForm.Items.Item("edMulD").Enabled = False
                    'oForm.Items.Item("edMulMo").Enabled = False
                    'oForm.Items.Item("edFrecMul").Enabled = False
                    'oForm.Items.Item("edComMul").Enabled = False
                    'oForm.Items.Item("edNumCont").Enabled = False

                    'oedit2 = oForm.Items.Item("157").Specific
                    'If oedit2.Item.Enabled = True Then
                    '    oedit2.Value = sCodiP
                    'End If
                    oForm.Items.Item("14").Click()

                End If

            Catch ex As Exception

                Application.SBO_Application.MessageBox(query)
                Application.SBO_Application.MessageBox(ex.Message)

            End Try

        End Sub

        Public Shared Sub Cargar_Datos_Adicionales_Proyecto(oForm As SAPbouiCOM.Form, sCodiP As String, FormUID As String)
            oForm = Application.SBO_Application.Forms.Item(FormUID)
            'oForm = Application.SBO_Application.Forms.GetForm("139", 0)
            Dim oDataTable As SAPbouiCOM.DataTable

            If oFunciones.DataTableExists(oForm, "DT_INFOPRO") = False Then

                oDataTable = oForm.DataSources.DataTables.Add("DT_INFOPRO")
                Dim query As String = " EXEC [SBO_COMERCIAL].[dbo].[SP_Consultar_Datos_Proyecto] N'" + sCodiP + "'"
                oDataTable.ExecuteQuery(query)

            Else
                oDataTable = oForm.DataSources.DataTables.Item("DT_INFOPRO")
                If oDataTable.IsEmpty Then
                    Dim query As String = " EXEC [SBO_COMERCIAL].[dbo].[SP_Consultar_Datos_Proyecto] N'" + sCodiP + "'"
                    oDataTable.ExecuteQuery(query)
                End If
            End If

            Dim oedit2 As SAPbouiCOM.EditText

            If Not oDataTable.IsEmpty Then

                Try  'Carga los UDF en la ventana lateral de campos, si no esta abierta, se abre por menu

                    'Capturamos la ventana lateral que tiene un numero de FormID inmedito al Form Padre (F_258 -> F_259)
                    Try
                        Dim UDFFormID = oForm.UDFFormUID
                        Dim FormIdProx = (Convert.ToInt32(FormUID.Replace(Left(FormUID, 2), "")) + 1).ToString()
                        Dim PrefFormID = Left(FormUID, 2)
                        oForm = Application.SBO_Application.Forms.Item(UDFFormID)

                    Catch ex As Exception
                        AbiertoDesdeMenu = True
                        Application.SBO_Application.ActivateMenuItem("6913")
                        Dim UDFFormID = oForm.UDFFormUID
                        oForm = Application.SBO_Application.Forms.Item(UDFFormID)
                        'oForm = Application.SBO_Application.Forms.GetForm("-139", 0)
                    End Try

                    oForm.Freeze(True)
                    Dim CatAct As String = ""
                    oComboBox = oForm.Items.Item("9").Specific
                    CatAct = oComboBox.Selected.Description.Trim()
                    'oComboBox.Item.Description = "Tod.categorías"
                    oComboBox.Select("Tod.categorías", SAPbouiCOM.BoSearchKey.psk_ByDescription)

                    oComboBox = oForm.Items.Item("U_MIN_Multa").Specific
                    oComboBox.Item.Description = oDataTable.GetValue("Multa", 0)
                    oComboBox.Select(oDataTable.GetValue("Multa", 0), SAPbouiCOM.BoSearchKey.psk_ByDescription)

                    SystemForm2.CambiarEnableFechasProyectos(oForm, True)

                    oedit2 = oForm.Items.Item("U_MIN_FechaVenta").Specific
                    oedit2.String = oDataTable.GetValue("Fecha_Venta", 0)   'oRsSUers.Fields.Item("Fecha_Venta").Value
                    oedit2 = oForm.Items.Item("U_MIN_FinDesarr").Specific
                    oedit2.String = oDataTable.GetValue("Fecha_Fin_Desarr", 0)   'oRsSUers.Fields.Item("Fecha_Fin_Desarr").Value
                    oedit2 = oForm.Items.Item("U_MIN_FinProduccion").Specific
                    oedit2.String = oDataTable.GetValue("Fecha_Fin_Produc", 0)  'oRsSUers.Fields.Item("Fecha_Fin_Produc").Value
                    oedit2 = oForm.Items.Item("U_MIN_IniDespacho").Specific
                    oedit2.String = oDataTable.GetValue("Fecha_Ini_Despa", 0)  'oRsSUers.Fields.Item("Fecha_Ini_Despa").Value
                    oedit2 = oForm.Items.Item("U_MIN_IniMontaje").Specific
                    oedit2.String = oDataTable.GetValue("Fecha_Ini_Monta", 0)  'oRsSUers.Fields.Item("Fecha_Ini_Monta").Value
                    oedit2 = oForm.Items.Item("U_MIN_FinMontaje").Specific
                    oedit2.String = oDataTable.GetValue("Fecha_Fin_Monta", 0)  'oRsSUers.Fields.Item("Fecha_Fin_Monta").Value
                    oedit2 = oForm.Items.Item("U_MIN_FechaMulta").Specific
                    oedit2.String = oDataTable.GetValue("Fecha_Ini_Multa", 0)  'oRsSUers.Fields.Item("Fecha_Ini_Multa").Value
                    oedit2 = oForm.Items.Item("U_MIN_ObsMulta").Specific
                    oedit2.String = oDataTable.GetValue("Comentario_Multa", 0)  'oRsSUers.Fields.Item("Comentario_Multa").Value

                    SystemForm2.CambiarEnableFechasProyectos(oForm, False)

                    oComboBox = oForm.Items.Item("9").Specific
                    oComboBox.Select(CatAct, SAPbouiCOM.BoSearchKey.psk_ByDescription)

                    oForm.Items.Item("U_MIN_Vendedor").Click()

                Catch ex As Exception

                    'Application.SBO_Application.ActivateMenuItem("6913")
                    'Application.SBO_Application.SendKeys("^(+U)")
                    'Application.SBO_Application.Forms.Item("-139").Select()
                    'oForm = Application.SBO_Application.Forms.GetForm("-139", 0)

                Finally
                    oForm.Freeze(False)
                End Try

            End If

        End Sub

        Public Shared Sub Cargar_Matrix_Planos_Proyecto(oForm As SAPbouiCOM.Form)

            '-------------------------------------------------------------------------------------------------------
            '    ACTUALIZA LA MATRIX CON LOS PLANOS 
            '-------------------------------------------------------------------------------------------------------
            Dim sql As String

            oedit = oForm.Items.Item("edCodPro").Specific


            'Application.SBO_Application.MessageBox(oedit.Value)



            sql = " select [U_PtahServer] as Archivo,[U_Status] as Estado, [U_Tipo_Plano] as Destino,[U_Fec_Registro] as Fecha,[U_Hora_Registro] as Hora " & _
                  " ,[U_Comentario] as Comentario,[U_PathOrigen] as RutaInic,[U_Renglon] as Fila " & _
                  " from  " + sBDComercial.Trim() + ".[dbo].[@ZPLAP]   " & _
                  " where U_Tipo_Documento = 'PLANO' and U_PrjCode = '" + oedit.Value.Trim() + "' order by U_Renglon "

            '------------------ CARGAR MATRIX PLANOS
            Try

                oUDataTable = oForm.DataSources.DataTables.Item("DT_Planos")
                oUDataTable.ExecuteQuery(sql)

                'If oUDataTable.IsEmpty = False Then

                oMatrix = oForm.Items.Item("MtxPlanos").Specific

                    oMatrix.Columns.Item("#").DataBind.Bind("DT_Planos", "Fila")
                    oMatrix.Columns.Item("Ruta_Doc").DataBind.Bind("DT_Planos", "Archivo")
                    oMatrix.Columns.Item("Fec_Reg").DataBind.Bind("DT_Planos", "Fecha")
                    oMatrix.Columns.Item("Estado").DataBind.Bind("DT_Planos", "Estado")
                    oMatrix.Columns.Item("Destino").DataBind.Bind("DT_Planos", "Destino")

                'End If

                oMatrix.Clear()
                oMatrix.LoadFromDataSource()
                oMatrix.AutoResizeColumns()

            Catch ex As Exception

            End Try

        End Sub

        Public Shared Sub Cargar_Matrix_Documentos_Proyecto(oForm As SAPbouiCOM.Form)
            '-------------------------------------------------------------------------------------------------------
            '    ACTUALIZA LA MATRIX CON LOS DOCUMENTOS 
            '-------------------------------------------------------------------------------------------------------
            Dim sql As String

            oedit = oForm.Items.Item("edCodPro").Specific

            sql = " select [U_PtahServer] as Archivo,[U_Fec_Registro] as Fecha,[U_Hora_Registro] as Hora,[U_Comentario] as Comentario,[U_Renglon] as Fila,[U_PathOrigen] as RutaInic" & _
                    " from  " + sBDComercial.Trim() + ".[dbo].[@ZPLAP]   " & _
                    " where U_Tipo_Documento = 'DOCUMENTO' and U_PrjCode = '" + oedit.Value.Trim() + "' order by U_Renglon "

            '------------------ CARGAR MATRIX DOCUMENTOS
            Try

                oUDataTable = oForm.DataSources.DataTables.Item("DT_DocuPro")
                oUDataTable.ExecuteQuery(sql)

                If oUDataTable.IsEmpty = False Then

                    oMatrix = oForm.Items.Item("MtxDocPro").Specific

                    oMatrix.Columns.Item("#").DataBind.Bind("DT_DocuPro", "Fila")
                    oMatrix.Columns.Item("Ruta_Doc").DataBind.Bind("DT_DocuPro", "Archivo")
                    oMatrix.Columns.Item("Fec_Reg").DataBind.Bind("DT_DocuPro", "Fecha")
                    oMatrix.Columns.Item("Comentario").DataBind.Bind("DT_DocuPro", "Comentario")

                End If

                oMatrix.Clear()
                oMatrix.LoadFromDataSource()
                oMatrix.AutoResizeColumns()

            Catch ex As Exception

            End Try

        End Sub

        Private Sub Agregar_Tabs_Pedidos(oForm As SAPbouiCOM.Form)

            Dim oNewItem As SAPbouiCOM.Item

            oFunciones.AgregarUserDataSource(oForm, "FolderDS", SAPbouiCOM.BoDataType.dt_SHORT_TEXT, 80)

            '-------------------------------------------------------------------------------------------
            '   AGREGAR CARPETA/TAB Y MATRIX EN FORMULARIO DE PEDIDOS PARA CONSULTAR MATRIX CON PLANOS
            '-------------------------------------------------------------------------------------------
            If Not oFunciones.ItemExists(oForm, "NewTab") Then
                oNewItem = oForm.Items.Add("NewTab", SAPbouiCOM.BoFormItemTypes.it_FOLDER)
                oItem = oForm.Items.Item("1320002137")
                oNewItem.Height = oItem.Height 'same height
                oNewItem.Width = oItem.Width 'same width
                oNewItem.Top = oItem.Top 'same top
                oNewItem.Left = oItem.Left + oItem.Width 'add to the left so its positioned next to Cancel
                oNewItem.AffectsFormMode = False

                oFolder = oNewItem.Specific
                oFolder.Caption = "Planos P&royecto"
                oFolder.Pane = 18
                oFolder.DataBind.SetBound(True, "", "FolderDS")
                oFolder.GroupWith("1320002137")


                oForm.PaneLevel = 1  'Retorna el Focus a la primera TAB
            End If

            '--------------------------------------------------------------------------------------
            '   AGREGAR CARPETA/TAB EN FORMULARIO DE PEDIDOS PARA FECHAS DE PROYECTOS
            '--------------------------------------------------------------------------------------
            If Not oFunciones.ItemExists(oForm, "NewTab2") Then
                oNewItem = oForm.Items.Add("NewTab2", SAPbouiCOM.BoFormItemTypes.it_FOLDER)
                oItem = oForm.Items.Item("1320002137")
                oNewItem.Height = oItem.Height 'same height
                oNewItem.Width = oItem.Width 'same width
                oNewItem.Top = oItem.Top 'same top
                oNewItem.Left = oItem.Left + oItem.Width 'add to the left so its positioned next to Cancel
                oNewItem.AffectsFormMode = False

                oFolder = oNewItem.Specific
                oFolder.Caption = "Fechas Proy&ecto"
                oFolder.Pane = 16
                oFolder.DataBind.SetBound(True, "", "FolderDS")
                oFolder.GroupWith("1320002137")

                oForm.PaneLevel = 1  'Retorna el Focus a la primera TAB
            End If

            '--------------------------------------------------------------------------------------
            '   AGREGAR CARPETA/TAB EN FORMULARIO DE PEDIDOS PARA DOCUMENTOS DE PROYECTOS
            '--------------------------------------------------------------------------------------

            If Not oFunciones.ItemExists(oForm, "NewTab3") Then
                oNewItem = oForm.Items.Add("NewTab3", SAPbouiCOM.BoFormItemTypes.it_FOLDER)
                oItem = oForm.Items.Item("1320002137")
                oNewItem.Height = oItem.Height 'same height
                oNewItem.Width = oItem.Width 'same width
                oNewItem.Top = oItem.Top 'same top
                oNewItem.Left = oItem.Left + oItem.Width 'add to the left so its positioned next to Cancel
                oNewItem.AffectsFormMode = False

                oFolder = oNewItem.Specific
                oFolder.Caption = "&Documentos Proyecto"
                oFolder.Pane = 17
                oFolder.DataBind.SetBound(True, "", "FolderDS")
                oFolder.GroupWith("1320002137")
                If oConectarAplicacion.sCurrentCompanyDB = sBDComercial Then
                    oFolder.Item.Enabled = IIf(Habilitado, True, False)
                Else
                    oFolder.Item.Enabled = False
                End If

                oForm.PaneLevel = 1  'Retorna el Focus a la primera TAB
            End If

        End Sub

        Public Shared Sub CambiarEnableFechasProyectos(oForm As SAPbouiCOM.Form, Estado As Boolean)

            Try
                oForm.Items.Item("U_MIN_Vendedor").Click()
                oForm.Items.Item("U_MIN_FechaVenta").Enabled = Estado
                oForm.Items.Item("U_MIN_FinDesarr").Enabled = Estado
                oForm.Items.Item("U_MIN_FinProduccion").Enabled = Estado
                oForm.Items.Item("U_MIN_IniDespacho").Enabled = Estado
                oForm.Items.Item("U_MIN_IniMontaje").Enabled = Estado
                oForm.Items.Item("U_MIN_FinMontaje").Enabled = Estado
                oForm.Items.Item("U_MIN_FechaMulta").Enabled = Estado
                oForm.Items.Item("U_MIN_ObsMulta").Enabled = Estado
            Catch ex As Exception
            End Try

        End Sub

        Public Shared Sub Cargar_Datos_Proyecto_Pedido_Cliente_Existente(FormUID As String)

            oForm = Application.SBO_Application.Forms.Item(FormUID)
            oedit = oForm.Items.Item("157").Specific

            Dim oedit2 As SAPbouiCOM.EditText

            If oedit.Value.Trim.Length() Then

                SystemForm2.Cargar_Datos_Proyecto(oForm, oedit.Value, FormUID, "et_FORM_DATA_LOAD")
                SystemForm2.Cargar_Matrix_Planos_Proyecto(oForm)
                SystemForm2.Cargar_Matrix_Documentos_Proyecto(oForm)

                Try

                    Dim oDataTable As SAPbouiCOM.DataTable = oForm.DataSources.DataTables.Item("DT_INFOPRO")

                    oedit = oForm.Items.Item("8").Specific
                    sPSql = " SELECT sum(ISNULL(T0.[Quantity],0)* ISNULL(T1.[U_MIN_PESO],0)) as Kilos " & _
                            " FROM ORDR T3 JOIN RDR1 T0  ON T3.DocEntry = T0.DocEntry " & _
                            " INNER JOIN OITM T1 ON T0.[ItemCode] = T1.[ItemCode] " & _
                            " WHERE T3.DocNum = " + oedit.Value.ToString

                    Try
                        oDataTable.ExecuteQuery(sPSql)
                    Catch ex As Exception

                    End Try

                    oedit2 = oForm.Items.Item("edKilosTot").Specific
                    oedit2.Item.Enabled = True
                    oedit2.String = oDataTable.GetValue("Kilos", 0)
                    oForm.Items.Item("16").Click()
                    Try
                        oedit2.Item.Enabled = False
                    Catch ex As Exception

                    End Try

                Catch ex As Exception

                    Application.SBO_Application.MessageBox(sPSql)
                    Application.SBO_Application.MessageBox(ex.Message)
                Finally
                    oForm.Freeze(False)
                End Try
                
                ''-------------------------------------------------------------------------------------------------------
                ''    ACTUALIZA LA MATRIX CON LOS PLANOS AL CARGAR DATOS
                ''-------------------------------------------------------------------------------------------------------
                'Dim sql As String

                'oedit = oForm.Items.Item("157").Specific

                ''Application.SBO_Application.MessageBox(oedit.Value)



                'sql = " select [U_PtahServer] as Archivo,[U_Status] as Estado, [U_Tipo_Plano] as Destino,[U_Fec_Registro] as Fecha,[U_Hora_Registro] as Hora " & _
                '      " ,[U_Comentario] as Comentario,[U_PathOrigen] as RutaInic,[U_Renglon] as Fila " & _
                '      " from  " + sBDComercial.Trim() + ".[dbo].[@ZPLAP]   " & _
                '      " where U_Tipo_Documento = 'PLANO' and U_PrjCode = '" + oedit.Value.Trim() + "' order by U_Renglon "

                ''------------------ CARGAR MATRIX PLANOS
                'Try

                '    oUDataTable = oForm.DataSources.DataTables.Item("DT_Planos")
                '    oUDataTable.ExecuteQuery(sql)

                '    If oUDataTable.Rows.Count > 0 And oUDataTable.IsEmpty = False Then

                '        oMatrix = oForm.Items.Item("MtxPlanos").Specific

                '        oMatrix.Columns.Item("#").DataBind.Bind("DT_Planos", "Fila")
                '        oMatrix.Columns.Item("Ruta_Doc").DataBind.Bind("DT_Planos", "Archivo")
                '        oMatrix.Columns.Item("Fec_Reg").DataBind.Bind("DT_Planos", "Fecha")
                '        oMatrix.Columns.Item("Estado").DataBind.Bind("DT_Planos", "Estado")
                '        oMatrix.Columns.Item("Destino").DataBind.Bind("DT_Planos", "Destino")

                '        oMatrix.Clear()
                '        oMatrix.LoadFromDataSource()
                '        oMatrix.AutoResizeColumns()

                '    End If

                'Catch ex As Exception

                'End Try

                'sql = " select [U_PtahServer] as Archivo,[U_Fec_Registro] as Fecha,[U_Hora_Registro] as Hora,[U_Comentario] as Comentario,[U_Renglon] as Fila,[U_PathOrigen] as RutaInic" & _
                '    " from  " + sBDComercial.Trim() + ".[dbo].[@ZPLAP]   " & _
                '    " where U_Tipo_Documento = 'DOCUMENTO' and U_PrjCode = '" + oedit.Value.Trim() + "' order by U_Renglon "

                ''------------------ CARGAR MATRIX DOCUMENTOS
                'Try

                '    oUDataTable = oForm.DataSources.DataTables.Item("DT_DocuPro")
                '    oUDataTable.ExecuteQuery(sql)

                '    If oUDataTable.Rows.Count > 0 And oUDataTable.IsEmpty = False Then

                '        oMatrix = oForm.Items.Item("MtxDocPro").Specific

                '        oMatrix.Columns.Item("#").DataBind.Bind("DT_DocuPro", "Fila")
                '        oMatrix.Columns.Item("Ruta_Doc").DataBind.Bind("DT_DocuPro", "Archivo")
                '        oMatrix.Columns.Item("Fec_Reg").DataBind.Bind("DT_DocuPro", "Fecha")
                '        oMatrix.Columns.Item("Comentario").DataBind.Bind("DT_DocuPro", "Comentario")

                '        oMatrix.Clear()
                '        oMatrix.LoadFromDataSource()
                '        oMatrix.AutoResizeColumns()

                '    End If

                'Catch ex As Exception

                'End Try



            End If

        End Sub

        Private WithEvents EditText0 As SAPbouiCOM.EditText
        Private WithEvents EditText1 As SAPbouiCOM.EditText
        Private WithEvents EditText2 As SAPbouiCOM.EditText
        Private WithEvents StaticText0 As SAPbouiCOM.StaticText
        Private WithEvents StaticText1 As SAPbouiCOM.StaticText
        Private WithEvents StaticText2 As SAPbouiCOM.StaticText
        Private WithEvents EditText3 As SAPbouiCOM.EditText
        Private WithEvents EditText4 As SAPbouiCOM.EditText
        Private WithEvents EditText5 As SAPbouiCOM.EditText
        Private WithEvents EditText6 As SAPbouiCOM.EditText
        Private WithEvents EditText7 As SAPbouiCOM.EditText
        Private WithEvents EditText8 As SAPbouiCOM.EditText
        Private WithEvents EditText9 As SAPbouiCOM.EditText
        Private WithEvents EditText10 As SAPbouiCOM.EditText
        Private WithEvents EditText11 As SAPbouiCOM.EditText
        Private WithEvents EditText12 As SAPbouiCOM.EditText
        Private WithEvents EditText13 As SAPbouiCOM.EditText
        Private WithEvents EditText14 As SAPbouiCOM.EditText
        Private WithEvents StaticText3 As SAPbouiCOM.StaticText
        Private WithEvents StaticText4 As SAPbouiCOM.StaticText
        Private WithEvents StaticText5 As SAPbouiCOM.StaticText
        Private WithEvents StaticText6 As SAPbouiCOM.StaticText
        Private WithEvents StaticText7 As SAPbouiCOM.StaticText
        Private WithEvents StaticText8 As SAPbouiCOM.StaticText
        Private WithEvents StaticText9 As SAPbouiCOM.StaticText
        Private WithEvents StaticText10 As SAPbouiCOM.StaticText
        Private WithEvents StaticText11 As SAPbouiCOM.StaticText
        Private WithEvents StaticText12 As SAPbouiCOM.StaticText
        Private WithEvents StaticText13 As SAPbouiCOM.StaticText
        Private WithEvents StaticText14 As SAPbouiCOM.StaticText
        Private WithEvents EditText15 As SAPbouiCOM.EditText
        Private WithEvents StaticText15 As SAPbouiCOM.StaticText
        Private WithEvents Button0 As SAPbouiCOM.Button
        Private WithEvents Matrix0 As SAPbouiCOM.Matrix
        Private WithEvents Matrix1 As SAPbouiCOM.Matrix
        Private WithEvents PictureBox0 As SAPbouiCOM.PictureBox

#Region "Codigo Anterior"

        '"  select TOP 1 PC.U_PrjCode as Project ,PC.U_PrjName as PrjName,PC.U_CardCode as CardCode,PC.U_CardName as CardName,case when isnull(HM.U_Multa_Nvo,PC.U_Multa) = 'Y' then 'Si' else 'No' end as Multa,   " & _
        '                                  "  isnull(convert(char(10),isnull(HF.U_Fecha_Venta,PC.U_Fec_Vta) ,103),'') as Fecha_Venta, " & _
        '                                  "  isnull(convert(char(10),isnull(HF.U_Fecha_Promet_Nvo,PC.U_Fec_Prom) ,103),'') as Fecha_Prom_Cli,    " & _
        '                                  "  isnull(convert(char(10),isnull(HF.U_Ter_Desar_Nvo,PC.U_Fec_Ter_Desa) ,103),'') as Fecha_Fin_Desarr, " & _
        '                                  "  isnull(convert(char(10),isnull(HF.U_Ter_Prod_Nvo,PC.U_Fec_Ter_Prod) ,103),'') as Fecha_Fin_Produc,     " & _
        '                                  "  isnull(convert(char(10),isnull(HF.U_Ter_Desp_Nvo,PC.U_Fec_Ini_Desp) ,103),'') as Fecha_Ini_Despa, " & _
        '                                  "  isnull(convert(char(10),isnull(HF.U_Ini_Mont_Nvo,PC.U_Fec_Ini_Mont) ,103),'') as Fecha_Ini_Monta,    " & _
        '                                  "  isnull(convert(char(10),isnull(HF.U_Ter_Mont_Nvo,PC.U_Fec_Ter_Mont) ,103),'') as Fecha_Fin_Monta,  " & _
        '                                  "  isnull(PC.U_Comentario,'') as Comentario, isnull(U_SlpName,'') as Nombre_Vendedor, isnull(U_SlpCode,'') as Cod_Vend, " & _
        '                                  "  isnull(HM.U_Multa_Desp_Nvo ,isnull(PC.U_Multa_Desp,'')) as Multa_Despa,  " & _
        '                                  "  isnull(HM.U_Multa_Mont_Nvo ,isnull(PC.U_Multa_Mont,'')) as Multa_Monta, " & _
        '                                  "  isnull(convert(char(10),HM.U_Fec_Ini_Multa_Nvo,103) ,isnull(convert(char(10),PC.U_Fec_Ini_Multa,103),'')) as Fecha_Ini_Multa,  " & _
        '                                  "  isnull(HM.U_Porc_Multa_Nvo ,isnull(PC.u_poc_multa,0)) as Porc_Multa,  " & _
        '                                  "  isnull(HM.U_Tope_Multa_Nvo ,isnull(PC.U_Tope_Multa,0)) as Tope_Multa, " & _
        '                                  "  isnull(HM.U_Frec_Multa_Nvo ,isnull(PC.U_Frec_Multa,'')) as Frecuencia_Multa,  " & _
        '                                  "  isnull(HM.U_Coment_Multa_Nvo ,isnull(PC.U_Coment_Multa,'')) as Comentario_Multa,     " & _
        '                                  "  isnull(PC.U_Contrato_Cli,'') as U_Contrato_Cli " & _
        '                                  "  from  " + sBDComercial.Trim() + ".DBO.[@ZINFOP] as PC  LEFT JOIN	(select TOP 1 * from " + sBDComercial.Trim() + ".DBO.[@ZHFPM]   " & _
        '                                  "  		 where  cast(U_PrjCode as nvarchar) = '" + sCodiP + "'  " & _
        '                                  "  	 and U_Fecha_Registro = (select max(U_Fecha_Registro)  from " + sBDComercial.Trim() + ".DBO.[@ZHFPM] where cast(U_PrjCode as nvarchar) = '" + sCodiP + "')) HF  " & _
        '                                  "  	 ON cast(PC.U_PrjCode as nvarchar) = cast(HF.U_PrjCode as nvarchar) " & _
        '                                  "  LEFT JOIN	(select TOP 1 * from " + sBDComercial.Trim() + ".DBO.[@ZHCMP]   " & _
        '                                  "  				 where  cast(U_PrjCode as nvarchar) = '" + sCodiP + "'  " & _
        '                                  "  				 and U_Fecha_Registro = (select max(U_Fecha_Registro)  from " + sBDComercial.Trim() + ".DBO.[@ZHCMP] where cast(U_PrjCode as nvarchar) = '" + sCodiP + "')) HM " & _
        '                                  "  ON cast(PC.U_PrjCode as nvarchar) = cast(HM.U_PrjCode as nvarchar) " & _
        '                                  "  where cast(PC.U_PrjCode as nvarchar) = '" + sCodiP + "'"

#End Region

    End Class
End Namespace
