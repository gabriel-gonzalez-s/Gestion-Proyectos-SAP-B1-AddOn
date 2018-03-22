Imports SAPbouiCOM.Framework
Imports SAPbobsCOM
Imports System.Management
Imports System.Text.RegularExpressions
Imports System.Xml.Serialization
Imports System.Data.OleDb


Namespace SBOAddonProject1
    Module Module1

        '------------------------------------------------------------
        ' Declaracion de Variables Globales Publicas
        '------------------------------------------------------------

        'Nombres de las Bases de Datos a Consultar y Actualizar
        '------------------------------------------------------------
        Public sBDComercial As String = "SBO_COMERCIAL"
        Public sBDIndustrial As String = "SBO_INDUSTRIAL"
        Public sBDMontaje As String = "SBO_MONTAJE"

        'Ruta Donde Guardar Todos los Documentos a Anexar
        '------------------------------------------------------------
        Public sPathAnexos As String = "" '"\\Fssapbo\SAPB1\Anexos\"
        Public sPathBitmap As String = ""

        '------------------------------------------------------------

        Public sCodProyecto As String = "CODIGO PROYECTO"
        Public sPSql As String = ""
        Public sPSql2 As String = ""
        Public sPSql3 As String = ""
        Public sPSql4 As String = ""
        Public sPSql5 As String = ""
        Public sPSql6 As String = ""
        Public sFormID_Principal = ""

        Public bFirstTime As Boolean
        Public AbiertoDesdeForm As Boolean = False
        Public esPantallaModal As Boolean = False       ' Variable para Controlar el Estado Modal de un Form Activo
        Public IDPantallaModal As String = ""           ' Variable que Contiene el ID de la Pantalla Modal Activa
        Public IDFormPedidoFocus As String              ' Variable que guarda el FormID de la Pantalla de Pedido al darle Focus
        Public bLoadInputEvents As Boolean = False      ' Variables para Control de UserInput
        Public sValorInicialCampo As String = ""
        Public Habilitado As Boolean = False
        Public ConsultaUsuario As Boolean = False
        Public AbiertoDesdeEnlace As Boolean = False
        Public AbiertoDesdeMenu As Boolean = False
        Public DatosProyectoCargados As Int32 = 0

        'Variables de Definicion de Formularios e Items UI API
        '------------------------------------------------------------
        Public oCompany As New SAPbobsCOM.Company
        Public oApplication As SAPbouiCOM.Application
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
        'Public oUserInput As cUserInput
        '-------------------------------
        Public oGestionIngenieria As FrmGestion_Ingenieria
        Public oConectarAplicacion As New NConectarAplicacion
        Public oFunciones As New Funciones

        '------------------------------------------------------------

        <STAThread()>
        Sub Main(ByVal args() As String)

            Try

                Dim oApp As Application
                If (args.Length < 1) Then
                    oApp = New Application
                Else
                    oApp = New Application(args(0))
                End If

                sPathAnexos = oFunciones.GetAttachPath()
                sPathBitmap = oFunciones.GetBitmapPath()

                Dim MyMenu As Menu
                MyMenu = New Menu()
                MyMenu.AddMenuItems()
                AddHandler Application.SBO_Application.AppEvent, AddressOf SBO_Application_AppEvent
                AddHandler Application.SBO_Application.ItemEvent, AddressOf SBO_Application_ItemEvent
                AddHandler Application.SBO_Application.FormDataEvent, AddressOf SBO_Application_FormDataEvent
                AddHandler Application.SBO_Application.MenuEvent, AddressOf SBO_Application_MenuEvent
                AddHandler Application.SBO_Application.RightClickEvent, AddressOf SBO_Application_RightClickEvent
                AddHandler Application.SBO_Application.ProgressBarEvent, AddressOf SBO_Application_ProgressBarEvent

                oConectarAplicacion.Conectar_Aplicacion(oCompany)

                oApp.Run()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End Sub

        Sub SBO_Application_ProgressBarEvent(ByRef pVal As SAPbouiCOM.ProgressBarEvent, ByRef BubbleEvent As Boolean)

            If pVal.EventType = SAPbouiCOM.BoProgressBarEventTypes.pbet_ProgressBarStopped Then
                Try
                    Dim EventEnum As SAPbouiCOM.BoProgressBarEventTypes
                    EventEnum = pVal.EventType
                Catch ex As Exception
                End Try
            End If

        End Sub

        Sub SBO_Application_AppEvent(EventType As SAPbouiCOM.BoAppEventTypes)
            Select Case EventType
                Case SAPbouiCOM.BoAppEventTypes.aet_ShutDown
                    oFunciones.Desconectar_y_Cerrar_Aplicacion()
                Case SAPbouiCOM.BoAppEventTypes.aet_CompanyChanged
                    oFunciones.Desconectar_y_Cerrar_Aplicacion()
                Case SAPbouiCOM.BoAppEventTypes.aet_FontChanged
                Case SAPbouiCOM.BoAppEventTypes.aet_LanguageChanged
                Case SAPbouiCOM.BoAppEventTypes.aet_ServerTerminition
                    oFunciones.Desconectar_y_Cerrar_Aplicacion()
            End Select
        End Sub

        Private WithEvents SBO_Application As SAPbouiCOM.Application
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '  EVENTOS DE MENU
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        Private Sub SBO_Application_MenuEvent(ByRef pVal As SAPbouiCOM.MenuEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.MenuEvent

            oForm = Application.SBO_Application.Forms.ActiveForm

            If (oForm.TypeEx.Contains("SBOAddonProject1") Or oForm.TypeEx.Contains("139")) Then
                '------------------------------------------------------------------------------------------------------------------------------------------------
                '  ESTE EVENTO VERIFICA SI LA PANTALLA ACTIVA ES MODAL; SI ES ASI SE ANULA EL EVENTO MENU
                '------------------------------------------------------------------------------------------------------------------------------------------------
                If esPantallaModal Then

                    If pVal.MenuUID = "773" Then 'Menu Contextual "Pegar" Permitido
                        BubbleEvent = True
                    Else
                        BubbleEvent = False
                    End If

                End If

                '------------------------------------------------------------------------------------------------------------------------------------------------
                '  ESTE EVENTO INICIALIZA LOS CAMPOS AGREGADOS A UN FORM DEL SISTEMA AL PRESIONAR LA OPCION "NUEVO" (PEDIDO DE CLIENTES)
                '------------------------------------------------------------------------------------------------------------------------------------------------
                oForm = Application.SBO_Application.Forms.ActiveForm

                ' Boton CREAR -------------------------------------------------------------------------------------------------------------------------------------
                If pVal.MenuUID = "1282" Then

                    oForm = Application.SBO_Application.Forms.ActiveForm

                    If pVal.BeforeAction = True Then

                        Select Case oForm.TypeEx

                            Case "SBOAddonProject1.FrmGestionTV" ' Pantalla de Gastion TV

                                Try

                                    oForm.Freeze(True)

                                    oButton = oForm.Items.Item("Item_13").Specific
                                    oButton.Caption = "Crear"

                                    oButton = oForm.Items.Item("Item_17").Specific
                                    oButton.Item.Visible = True
                                    oButton.Item.Click()
                                    oButton.Item.Visible = False

                                    BubbleEvent = False

                                Catch ex As Exception
                                Finally
                                    oForm.Freeze(False)
                                End Try

                        End Select

                    End If

                End If

                'BOTON CREAR Y BUSCAR EN PEDIDO - INICIALIZA TODOS LOS TEXTBOX AGREGADOS
                If (pVal.MenuUID = "1281" Or pVal.MenuUID = "1282") And pVal.BeforeAction = False And oForm.TypeEx = "139" Then
                    Try
                        oForm = Application.SBO_Application.Forms.ActiveForm

                        oForm.Freeze(True)

                        Dim oedit2 As SAPbouiCOM.EditText
                        oedit2 = oForm.Items.Item("edCodPro").Specific
                        oedit2.Value = ""
                        oForm.Items.Item("16").Click()
                        oedit2.Item.Enabled = True
                        oedit2 = oForm.Items.Item("edNomPro").Specific
                        oedit2.Value = ""
                        oForm.Items.Item("16").Click()
                        oedit2.Item.Enabled = True
                        oedit2 = oForm.Items.Item("edFecPro").Specific
                        oedit2.Value = ""
                        oForm.Items.Item("16").Click()
                        oedit2.Item.Enabled = True

                        'Total Kilos Pedido
                        oedit2 = oForm.Items.Item("edKilosTot").Specific
                        oedit2.String = "0"
                        oForm.Items.Item("16").Click()
                        oedit2.Item.Enabled = False


                        'Pestaña Fechas del Proyecto
                        oedit2 = oForm.Items.Item("edFTD").Specific
                        oedit2.Value = ""
                        oedit2 = oForm.Items.Item("edFTP").Specific
                        oedit2.Value = ""
                        oedit2 = oForm.Items.Item("edFID").Specific
                        oedit2.Value = ""
                        oedit2 = oForm.Items.Item("edFIMo").Specific
                        oedit2.Value = ""
                        oedit2 = oForm.Items.Item("edFTMo").Specific
                        oedit2.Value = ""
                        oedit2 = oForm.Items.Item("edFPCl").Specific
                        oedit2.Value = ""


                        oedit2 = oForm.Items.Item("edMulta").Specific
                        oedit2.Value = ""
                        oedit2 = oForm.Items.Item("edMulD").Specific
                        oedit2.Value = ""
                        oedit2 = oForm.Items.Item("edMulMo").Specific
                        oedit2.Value = ""
                        oedit2 = oForm.Items.Item("edFrecMul").Specific
                        oedit2.Value = ""
                        oedit2 = oForm.Items.Item("edComMul").Specific
                        oedit2.Value = ""

                        If pVal.MenuUID = "1282" Then
                            oForm.Items.Item("4").Click()
                        Else
                            oForm.Items.Item("8").Click()
                        End If
                        'oedit2.Item.Enabled = True

                    Catch ex As Exception
                    Finally
                        oForm.Freeze(False)
                    End Try

                End If

                If pVal.MenuUID = "1281" Then ' BOTON BUSCAR EN ESTADO GLOBAL

                    If pVal.BeforeAction = True Then
                        Select Case oForm.TypeEx
                            Case "SBOAddonProject1.FrmEstado_Global" ' Pantalla Estado Global
                                oButton = oForm.Items.Item("Item_105").Specific
                                oButton.Item.Click()
                                BubbleEvent = False
                            Case "SBOAddonProject1.Form11"        ' Pantalla Gestion de Planos
                                oButton = oForm.Items.Item("Item_26").Specific
                                oButton.Item.Click()
                                BubbleEvent = False

                        End Select
                    End If

                End If


                'BOTON DERECHO (BORRAR REGISTRO) -------------------------------------------------------------------------------------------------------------------

                If (pVal.MenuUID = "Eliminar Mensaje de Marquesina" And pVal.BeforeAction = False) Then

                    oForm = Application.SBO_Application.Forms.ActiveForm
                    Try
                        oForm.Freeze(True)
                        oButton = oForm.Items.Item("Item_18").Specific
                        oButton.Item.Visible = True ' Boton en Form que ejecuta el evento de Eliminacion del Mensaje de Marquesina
                        oButton.Item.Click()
                        oButton.Item.Visible = False
                    Catch ex As Exception
                    Finally
                        oForm.Freeze(False)
                    End Try

                End If

                If (pVal.MenuUID = "Eliminar Documento" And pVal.BeforeAction = True) Then

                    oForm = Application.SBO_Application.Forms.ActiveForm
                    Try
                        oForm.Freeze(True)
                        oButton = oForm.Items.Item("Item_14").Specific
                        oButton.Item.Visible = True ' Boton en Form que ejecuta el evento de Eliminacion del Documento
                        oButton.Item.Click()
                        oButton.Item.Visible = False
                    Catch ex As Exception
                    Finally
                        oForm.Freeze(False)
                    End Try

                End If
            End If


        End Sub

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '  EVENTOS DE ITEMS
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        Private Sub SBO_Application_ItemEvent(ByVal FormUID As String, ByRef pVal As SAPbouiCOM.ItemEvent, ByRef BubbleEvent As Boolean)


            If (pVal.FormTypeEx.Contains("SBOAddonProject1") Or pVal.FormTypeEx.Contains("139")) Then

                '------------------------------------------------------------------------------------------------------------------------------------------------
                '  ESTOS EVENTO MANEJA LA CONDICION MODAL DE LAS PANTALLAS DONDE ReportType = "Modal"
                '------------------------------------------------------------------------------------------------------------------------------------------------
                If pVal.EventType = SAPbouiCOM.BoEventTypes.et_FORM_VISIBLE And pVal.BeforeAction = False Then

                    Try
                        oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)

                        If oForm.ReportType = "Modal" Then
                            esPantallaModal = True
                            IDPantallaModal = pVal.FormUID
                        End If
                    Catch ex As Exception
                    End Try

                End If

                If esPantallaModal And FormUID <> IDPantallaModal And IDPantallaModal.Trim.Length > 0 And
                    (pVal.EventType = SAPbouiCOM.BoEventTypes.et_FORM_ACTIVATE Or pVal.EventType = SAPbouiCOM.BoEventTypes.et_FORM_DEACTIVATE Or pVal.EventType = SAPbouiCOM.BoEventTypes.et_CLICK) Then
                    oForm = Application.SBO_Application.Forms.Item(IDPantallaModal)
                    oForm.Select() ' Selecciona la pantalla modal
                    BubbleEvent = False
                End If

                ' If the modal from is closed...
                If FormUID = IDPantallaModal And pVal.EventType = SAPbouiCOM.BoEventTypes.et_FORM_CLOSE And esPantallaModal Then
                    esPantallaModal = False
                    IDPantallaModal = ""
                End If
                '------------------------------------------------------------------------------------------------------------------------------------------------

                If pVal.FormTypeEx = "SBOAddonProject1.Form2" Then
                    Form2.SBO_Application_ItemEvent(FormUID, pVal, BubbleEvent)
                End If

                '------------------------------------------------------------------------------------------------------------------------------------------------
                '  ESTE EVENTO AGREGA ITEMS A UN FORM DEL SISTEMA (PEDIDO DE CLIENTES)
                '------------------------------------------------------------------------------------------------------------------------------------------------
                If pVal.FormTypeEx = "139" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_FORM_ACTIVATE And pVal.BeforeAction = False Then

                    IDFormPedidoFocus = FormUID

                End If

                If pVal.FormTypeEx = "139" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_FORM_LOAD And pVal.BeforeAction = False Then

                    oForm = Application.SBO_Application.Forms.Item(FormUID)
                    IDFormPedidoFocus = FormUID


                    If ConsultaUsuario = False Then
                        Try
                            oUDataTable = oForm.DataSources.DataTables.Item("DT_SQL")
                        Catch ex As Exception
                            oUDataTable = oForm.DataSources.DataTables.Add("DT_SQL")
                        End Try

                        oFunciones.IdentificarAccesoUsuario(oUDataTable)

                    End If

                End If

                '------------------------------------------------------------------------------------------------------------------------------------------------
                '  ESTE EVENTO ABRE LA PANTALLA DE CREACION DE PROYECTOS AL PRESIONAR EL NUEVO BOTON (PEDIDO DE CLIENTES)
                '------------------------------------------------------------------------------------------------------------------------------------------------
                If pVal.FormTypeEx = "139" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED And pVal.ItemUID = "btnNewProy" And pVal.BeforeAction Then
                    'Conectar_Aplicacion()

                    If NConectarAplicacion.sCurrentCompanyDBSH <> sBDComercial Then
                        Application.SBO_Application.StatusBar.SetText("Unicamente se Pueden Registrar Proyectos por la Comercial", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
                    Else
                        AbiertoDesdeForm = True

                        Dim Formp2 As FrmRegistrar_Proy
                        Formp2 = New FrmRegistrar_Proy

                        oForm = Application.SBO_Application.Forms.Item(Formp2.UIAPIRawForm.UniqueID)
                        If oFunciones.UserDataSourceExists(oForm, "UD_DESDEF") Then

                        End If
                        Dim oUDS As SAPbouiCOM.UserDataSource = Formp2.UIAPIRawForm.DataSources.UserDataSources.Item("UD_DESDEF")
                        oUDS.ValueEx = pVal.FormTypeEx

                        'Application.SBO_Application.ActivateMenuItem("SBOAddonProject1.FrmRegistrar_Proy")
                        Formp2.Show()
                    End If

                End If

                '------------------------------------------------------------------------------------------------------------------------------------------------
                '  ESTE EVENTO SELECCIONA Y VISUALIZA EL CONTENIDO DEL TAB DONDE ESTA LA MATRIX DE PLANOS (PEDIDO DE CLIENTES)
                '------------------------------------------------------------------------------------------------------------------------------------------------
                If pVal.FormTypeEx = "139" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED And pVal.ItemUID = "NewTab" And pVal.BeforeAction Then
                    oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
                    oForm.PaneLevel = 18
                End If

                '------------------------------------------------------------------------------------------------------------------------------------------------
                '  ESTE EVENTO SELECCIONA Y VISUALIZA EL CONTENIDO DEL TAB DONDE ESTA LA FECHAS Y MULTA DE PROYECTOS (PEDIDO DE CLIENTES)
                '------------------------------------------------------------------------------------------------------------------------------------------------
                If pVal.FormTypeEx = "139" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED And pVal.ItemUID = "NewTab2" And pVal.BeforeAction Then
                    oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
                    oForm.PaneLevel = 16
                End If

                '------------------------------------------------------------------------------------------------------------------------------------------------
                '  ESTE EVENTO SELECCIONA Y VISUALIZA EL CONTENIDO DEL TAB DONDE ESTA LOS DOCUMENTOS DEL PROYECTO (PEDIDO DE CLIENTES)
                '------------------------------------------------------------------------------------------------------------------------------------------------
                If pVal.FormTypeEx = "139" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED And pVal.ItemUID = "NewTab3" And pVal.BeforeAction Then
                    oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
                    oForm.PaneLevel = 17
                End If

                '------------------------------------------------------------------------------------------------------------------------------------------------
                '  ESTE EVENTO SELECCIONA TODA LA FILA DE LA MATRIX DE PLANOS O DOCUMENTOS AL HACER CLICK EN CUALQUIER COLUMNA (PEDIDO DE CLIENTES)
                '------------------------------------------------------------------------------------------------------------------------------------------------
                If pVal.FormTypeEx = "139" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_ITEM_PRESSED And (pVal.ItemUID = "MtxPlanos" Or pVal.ItemUID = "MtxDocPro") And pVal.BeforeAction Then
                    oMatrix = oForm.Items.Item(pVal.ItemUID).Specific
                    Dim rowNum As Integer = oMatrix.GetNextSelectedRow(0, SAPbouiCOM.BoOrderType.ot_RowOrder)
                    Try
                        oMatrix.SelectRow(pVal.Row, True, False)
                    Catch
                    End Try
                End If

                '------------------------------------------------------------------------------------------------------------------------------------------------
                '  ESTE EVENTO ABRE EL ARCHIVO DE LA MATRIX DE PLANO O DOCUMENTOS AL HACER DOBLE CLICK EN LA COLUMNA DEL ARCHIVO (PEDIDO DE CLIENTES)
                '------------------------------------------------------------------------------------------------------------------------------------------------
                If pVal.FormTypeEx = "139" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_DOUBLE_CLICK And (pVal.ItemUID = "MtxPlanos" Or pVal.ItemUID = "MtxDocPro") And pVal.BeforeAction Then

                    oMatrix = oForm.Items.Item(pVal.ItemUID).Specific

                    If pVal.ColUID = "Ruta_Doc" Then
                        oedit = oMatrix.Columns.Item(pVal.ColUID).Cells.Item(pVal.Row).Specific ' Selecciona el contenido de la celda
                        oFunciones.Open_File(oedit.Value.Trim)
                    End If
                End If


                '------------------------------------------------------------------------------------------------------------------------------------------------
                '  ESTE EVENTO TOMA EL VALOR DE UN CHOOSE FROM LIST Y LO COLOCA EN UN USER DATA SOURCE UD_CFL (GESTION PLANOS, ESTADO GLOBAL)
                '------------------------------------------------------------------------------------------------------------------------------------------------
                If (pVal.FormTypeEx = "SBOAddonProject1.FrmEstado_Global" And pVal.ItemUID = "Item_123") And
                    pVal.EventType = SAPbouiCOM.BoEventTypes.et_CHOOSE_FROM_LIST And pVal.BeforeAction = False Then


                    Dim sCod As String = ""
                    Dim sNom As String = ""
                    Dim oCFLEvento As SAPbouiCOM.IChooseFromListEvent
                    oCFLEvento = pVal
                    Dim sCFL_ID As String
                    sCFL_ID = oCFLEvento.ChooseFromListUID
                    oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
                    Dim oCFL As SAPbouiCOM.ChooseFromList
                    oCFL = oForm.ChooseFromLists.Item(sCFL_ID)

                    Dim oDataTable As SAPbouiCOM.DataTable
                    Dim oDT_SQL As SAPbouiCOM.DataTable
                    oDataTable = oCFLEvento.SelectedObjects
                    oDT_SQL = oForm.DataSources.DataTables.Item("DT_SQL1")

                    Try
                        sCod = oDataTable.GetValue(0, 0)
                        sNom = oDataTable.GetValue(1, 0)
                        'Application.SBO_Application.MessageBox(oDataTable.GetValue("CardCode", 0).ToString())
                        'Application.SBO_Application.MessageBox(oDataTable.GetValue("CardName", 0).ToString())
                        oForm.DataSources.UserDataSources.Item("UD_CFL").ValueEx = sCod

                    Catch ex As Exception

                    End Try

                    If pVal.FormTypeEx = "SBOAddonProject1.FrmEstado_Global" Then


                        Dim oedit2 As SAPbouiCOM.EditText
                        oedit2 = oForm.Items.Item("Item_123").Specific
                        oedit = oForm.Items.Item("Item_126").Specific
                        Dim sCancelado As Boolean = False

                        If oedit2.Value <> oedit.Value And sCod.Trim.Length() > 0 Then 'Verifica que los valores no sean iguales y que exista una seleccion

                            If Application.SBO_Application.MessageBox("¿Cambiar el Cliente Final del Proyecto?", 2, "Cambiar", "Cancelar") = 1 Then

                                oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)

                                oedit2 = oForm.Items.Item("Item_0").Specific
                                Dim sCodPro As String = oedit2.Value

                                Dim sql As String = "UPDATE " + sBDComercial.Trim() + ".[dbo].[@ZINFOP] SET U_CardCode = '" + sCod + "', U_CardName = '" + sNom + "' WHERE cast(U_PrjCode as nvarchar) = '" + sCodPro + "'"

                                Try

                                    Try
                                        oDT_SQL.ExecuteQuery(sql)
                                        Application.SBO_Application.MessageBox("Se Actualizó el Cliente Final")
                                    Catch ex As Exception
                                        'Conectar_Aplicacion()
                                        'oRsSUers.DoQuery(sql)
                                        'Application.SBO_Application.MessageBox("Se Actualizó el Cliente Final")
                                    End Try

                                Catch ex As Exception
                                    Application.SBO_Application.MessageBox(sql)
                                    Application.SBO_Application.MessageBox(ex.Message)
                                End Try
                            Else
                                sCancelado = True
                            End If
                        Else
                            oedit2.Value = oedit.Value
                        End If

                    End If

                End If

                '------------------------------------------------------------------------------------------------------------------------------------------------
                '  ESTE EVENTO TOMA EL VALOR DE UN CHOOSE FROM LIST DE PROYECTO Y LO COLOCA EN UN USER DATA SOURCE UDS_CFLPRO  (PEDIDO DE CLIENTES)
                '------------------------------------------------------------------------------------------------------------------------------------------------
                If pVal.FormTypeEx = "139" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_CHOOSE_FROM_LIST And pVal.BeforeAction = False Then

                    Dim oCFLEvento As SAPbouiCOM.IChooseFromListEvent
                    oCFLEvento = pVal
                    Dim sCFL_ID As String
                    sCFL_ID = oCFLEvento.ChooseFromListUID
                    Dim oForm As SAPbouiCOM.Form
                    oForm = Application.SBO_Application.Forms.Item(FormUID)
                    Dim oCFL As SAPbouiCOM.ChooseFromList
                    oCFL = oForm.ChooseFromLists.Item(sCFL_ID)

                    Dim oDataTable As SAPbouiCOM.DataTable
                    oDataTable = oCFLEvento.SelectedObjects
                    Dim val As String
                    Try
                        val = oDataTable.GetValue(0, 0)
                        oForm.DataSources.UserDataSources.Item("UDS_CFLPRO").ValueEx = val
                    Catch ex As Exception

                    End Try

                End If

                '-------------------------------------------------------------------------------------------------------------------------------------------------------------
                '  ESTE EVENTO TOMA EL VALOR DE UN CHOOSE FROM LIST DE PROYECTO Y LO COLOCA EN UN USER DATA SOURCE UDS_CFLSLP  (CREACION DE PROYECTOS, ESTADO GLOBAL)
                '-------------------------------------------------------------------------------------------------------------------------------------------------------------
                If ((pVal.FormTypeEx = "SBOAddonProject1.FrmRegistrar_Proy" And pVal.ItemUID = "Item_9") Or
                   (pVal.FormTypeEx = "SBOAddonProject1.FrmEstado_Global" And pVal.ItemUID = "Item_159")) And
                    pVal.EventType = SAPbouiCOM.BoEventTypes.et_CHOOSE_FROM_LIST And pVal.BeforeAction = False Then

                    Dim oCFLEvento As SAPbouiCOM.IChooseFromListEvent
                    oCFLEvento = pVal
                    Dim sCFL_ID As String
                    sCFL_ID = oCFLEvento.ChooseFromListUID
                    Dim oForm As SAPbouiCOM.Form
                    oForm = Application.SBO_Application.Forms.Item(FormUID)
                    Dim oCFL As SAPbouiCOM.ChooseFromList
                    oCFL = oForm.ChooseFromLists.Item(sCFL_ID)

                    Dim oDataTable As SAPbouiCOM.DataTable
                    oDataTable = oCFLEvento.SelectedObjects

                    Dim sCod As String = ""
                    Dim sNom As String = ""

                    Try
                        sCod = oDataTable.GetValue(0, 0)
                        sNom = oDataTable.GetValue(1, 0)
                        oForm.DataSources.UserDataSources.Item("UDS_CFLSLP").ValueEx = sCod

                        oedit = oForm.Items.Item(pVal.ItemUID).Specific
                        oedit.Value = sNom
                        'Application.SBO_Application.MessageBox(val)
                    Catch ex As Exception
                    End Try

                End If

                '---------------------------------------------------------------------------------------------------------------------------------------------------------------------
                '  ESTE EVENTO CARGA LOS CAMPOS ADICIONALES(LATERALES) DE UN PEDIDO EN MODO ADD AL SELECCIONAR UN PROYECTO 
                '---------------------------------------------------------------------------------------------------------------------------------------------------------------------
                If pVal.FormTypeEx = "-139" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_FORM_LOAD And
                   pVal.BeforeAction = False And pVal.FormMode = SAPbouiCOM.BoFormMode.fm_ADD_MODE Then

                    If AbiertoDesdeMenu = False Then
                        'oForm = Application.SBO_Application.Forms.GetForm("139", 0)
                        oForm = Application.SBO_Application.Forms.Item(IDFormPedidoFocus)
                        oedit = oForm.Items.Item("157").Specific
                        Dim sCad As String = oedit.Value

                        oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)

                        If sCad.Trim().Length > 0 Then

                            SystemForm2.Cargar_Datos_Adicionales_Proyecto(oForm, sCad, pVal.FormUID)

                        End If
                    Else
                        AbiertoDesdeMenu = False
                    End If

                End If

                '---------------------------------------------------------------------------------------------------------------------------------------------------------------------
                '  ESTE EVENTO CARGA LOS CAMPOS AL SELECCIONAR UN PEDIDO QUE SE CARGUE EN MODO ADD AL SELECCIONAR UN PROYECTO
                '---------------------------------------------------------------------------------------------------------------------------------------------------------------------
                If pVal.FormTypeEx = "139" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_FORM_LOAD And
                   pVal.BeforeAction = False And pVal.FormMode = SAPbouiCOM.BoFormMode.fm_ADD_MODE Then

                    'oForm = Application.SBO_Application.Forms.GetForm("139", 0)
                    oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
                    oedit = oForm.Items.Item("157").Specific
                    Dim sCad As String = oedit.Value

                    If sCad.Trim().Length > 0 Then

                        Try
                            oUDataTable = oForm.DataSources.DataTables.Item("DT_INFOPRO")
                            SystemForm2.Cargar_Datos_Proyecto(oForm, sCad, pVal.FormUID, "et_FORM_LOAD")
                        Catch ex As Exception
                            AbiertoDesdeEnlace = True
                        End Try


                    End If

                End If

                '---------------------------------------------------------------------------------------------------------------------------------------------------------------------
                '  ESTE EVENTO CARGA LOS CAMPOS AL SELECCIONAR UN PROYECTO Y ESTAR EN MODO ADD Y TODOS LOS CAMPOS EMPTY (USER DATA SOURCE UDS_CFLPRO y ZINFOP) (PEDIDO DE CLIENTES)
                '---------------------------------------------------------------------------------------------------------------------------------------------------------------------
                If pVal.FormTypeEx = "139" And pVal.ItemUID = "157" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_GOT_FOCUS And
                   pVal.BeforeAction = False And pVal.FormMode = SAPbouiCOM.BoFormMode.fm_ADD_MODE Then

                    oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
                    oedit = oForm.Items.Item("157").Specific
                    Dim sCad As String = oedit.Value
                    'sValorInicialCampo = sCad

                    Dim oUDS As SAPbouiCOM.UserDataSource = oForm.DataSources.UserDataSources.Item("UDS_CFLPRO") ' Este dato se Carga en el evento "If pVal.FormTypeEx = "SBOAddonProject1.Form11" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_CHOOSE_FROM_LIST And pVal.BeforeAction = False"
                    Dim sCodiP As String = oUDS.ValueEx

                    oedit = oForm.Items.Item("edCodPro").Specific

                    If oedit.Value.Trim <> sCodiP And sCad.Trim().Length > 0 And
               sCodiP.Trim().Length > 0 And DatosProyectoCargados = 0 And
               sCodiP.Trim() <> "PRESTAMO" Then

                        SystemForm2.Cargar_Datos_Al_Seleccionar_Proyecto(pVal.FormUID, sCodiP)

                    End If

                    DatosProyectoCargados = 0


                End If

                '------------------------------------------------------------------------------------------------------------------------------------------------
                '  ESTE EVENTO CAMBIA EL COLOR DE LA CELDA EN LA MATRIX AL SELECCIONAR UNA OPCION DEL COMBO BOX (GESTION DE PLANOS)
                '------------------------------------------------------------------------------------------------------------------------------------------------
                If pVal.FormTypeEx = "SBOAddonProject1.Form11" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_COMBO_SELECT And pVal.ItemUID = "Item_4" And pVal.BeforeAction = False Then

                    oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
                    oMatrix = oForm.Items.Item("Item_4").Specific

                    For index = 1 To oMatrix.RowCount()
                        If oMatrix.Columns.Item("Col_2").Cells.Item(index).Specific.Value = "Activo" Then
                            oMatrix.CommonSetting.SetCellBackColor(index, 2, oFunciones.Color_RGB_SAP(255, 255, 153))
                        Else
                            oMatrix.CommonSetting.SetCellBackColor(index, 2, oFunciones.Color_RGB_SAP(255, 51, 51))
                        End If
                    Next

                End If

                '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                '  ESTE EVENTO VERIFICA CUAL ES LA EMPRESA ACTUAL E INHABILITA LOS LINKED BUTTONS EN EL GRID QUE HACEN REFERENCIA A OTRA BD (ESTADO COMERIAL INGENIERIA, INDUSTRIAL Y MONTAJE)
                '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                If (pVal.FormTypeEx = "SBOAddonProject1.Form4" Or pVal.FormTypeEx = "SBOAddonProject1.Form5" Or pVal.FormTypeEx = "SBOAddonProject1.Form8" Or pVal.FormTypeEx = "SBOAddonProject1.FormMapaD") And
                   pVal.EventType = SAPbouiCOM.BoEventTypes.et_MATRIX_LINK_PRESSED And
                   (pVal.ItemUID = "Item_0" Or pVal.ItemUID = "Item_41" Or pVal.ItemUID = "Item_44" Or pVal.ItemUID = "Item_49" Or pVal.ItemUID = "Item_50" Or pVal.ItemUID = "Item_34" Or
                    pVal.ItemUID = "Item_5" Or pVal.ItemUID = "Item_6" Or pVal.ItemUID = "Item_7" Or pVal.ItemUID = "Item_8") And
                   pVal.BeforeAction = True Then

                    If esPantallaModal Then
                        BubbleEvent = False
                    End If

                    oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
                    oGrid = oForm.Items.Item(pVal.ItemUID).Specific

                    Dim iNoLeaf As Integer = 0
                    Dim sCodigo As String = ""

                    Dim sGrp() As String = {"Oportunidad_de_Ventas", "Oferta_de_Ventas", "Pedido_de_Ventas", "Guia_de_Entrega",
                                           "Oportunidad de Ventas", "Oferta de Ventas", "Pedido de Ventas", "Guia de Entrega",
                                           "Orden_Fabricacion", "Solicitud_Compra", "PCI_Montajes", "PCV Comercial",
                                           "Orden Fabricacion", "Solicitud Compra", "PCI Montajes", "Pedido Comercial",
                                           "Pedido de Ventas      Tipo Pedido       % Avance Proyecto     % Avance Pedido",
                                           "Pedido de Ventas  <*>",
                                           "Pedido Compras    Fecha Pedido   % Entrad Totales   % Ent. PC",
                                           "Pedido Compras  <*>",
                                           "Entrada de Mercaderia",
                                           "Pedido Industrial    Tipo Pedido   Fecha Emision",
                                           "Pedido Industrial <*>",
                                           "Numero de Documento",
                                           "Oferta Ventas Montaje    Fecha Oferta",
                                           "Pedido Ventas Montaje     Tipo_Pedido       Estado_PCV",
                                           "Pedido Ventas Montaje <*>",
                                           "Solicitud Compra     Fecha Solicitud",
                                           "PCI_Montajes"}

                    'Aca se cuentan las filas NO LEAF para restarse al pVal.Row ya que este trae el indice del DataTable no del Grid (GridRow = pVal.Row - iNoLeaf)
                    'NOTA: oGrid.GetDataTableRowIndex(pVal.Row) regresa la fila correspondiente al DataTable SOLO FUNCIONA si la fila es LEAF
                    'If oGrid.Rows.IsLeaf(pVal.Row) = False Then
                    Try

                        For k As Integer = 0 To (pVal.Row - 1)
                            If oGrid.Rows.IsLeaf(k) = False Then
                                iNoLeaf += 1
                            End If
                        Next

                        'End If

                        Dim num As Integer = oGrid.GetDataTableRowIndex(pVal.Row) ' SOLO FUNCIONA SI LA FILA ES LEAF

                        sCodigo = oGrid.DataTable.GetValue(pVal.ColUID, If(oGrid.Rows.IsLeaf(pVal.Row), num, pVal.Row - iNoLeaf))
                        sCodigo = sCodigo.Substring(0, 20)

                    Catch ex As Exception

                    End Try


                    If sGrp.Contains(pVal.ColUID) Then  ' ABRE LA PANTALLA DEL DOCUMENTO CORRESPONDIENTE DE OTRA SOCIEDAD EN BASE AL DocNum

                        If oConectarAplicacion.sCurrentCompanyDB = sBDComercial Then ' VALIDACION DE COMERCIAL

                            If (pVal.FormTypeEx = "SBOAddonProject1.Form4" And pVal.ItemUID = "Item_49") Or
                               (pVal.FormTypeEx = "SBOAddonProject1.FormMapaD" And pVal.ItemUID = "Item_7") Then 'GRID INDUSTRIAL EDO COM-ING

                                Select Case pVal.ColUID
                                    Case "Pedido Industrial <*>" '"Pedido Industrial    Tipo Pedido   Fecha Emision"
                                        BubbleEvent = False
                                        Cargar_Pedidos_Clientes_Externo(sBDIndustrial.Trim(), pVal.FormUID, sCodigo, "Pedidos Clientes MINDUGAR INDUSTRIAL")
                                    Case "Numero de Documento"
                                        BubbleEvent = False
                                        Cargar_Guia_Entrega_Externa(sBDIndustrial.Trim(), pVal.FormUID, sCodigo, "Guia Entrega MINDUGAR INDUSTRIAL")
                                End Select

                            End If

                            If (pVal.FormTypeEx = "SBOAddonProject1.Form4" And pVal.ItemUID = "Item_50") Or
                               (pVal.FormTypeEx = "SBOAddonProject1.FormMapaD" And pVal.ItemUID = "Item_8") Then 'GRID MONTAJES

                                Select Case pVal.ColUID
                                    Case "Pedido Ventas Montaje <*>" '"Pedido Ventas Montaje     Tipo_Pedido       Estado_PCV"
                                        BubbleEvent = False
                                        Cargar_Pedidos_Clientes_Externo(sBDMontaje.Trim(), pVal.FormUID, sCodigo, "Pedidos Clientes MINDUGAR MONTAJES")
                                    Case "Oferta Ventas Montaje    Fecha Oferta"
                                        BubbleEvent = False
                                        Cargar_Oferta_Venta_Externa(sBDMontaje.Trim(), pVal.FormUID, sCodigo, "Oferta de Ventas MINDUGAR MONTAJES")
                                    Case "PCI_Montajes"
                                        BubbleEvent = False
                                        Cargar_Pedidos_Compras_Externo(sBDMontaje.Trim(), pVal.FormUID, sCodigo, "Pedido de Compras MINDUGAR MONTAJES")
                                    Case "Solicitud Compra     Fecha Solicitud"
                                        BubbleEvent = False
                                        Cargar_Solicitud_Compras_Externo(sBDMontaje.Trim(), pVal.FormUID, sCodigo, "Solicitud de Compras MINDUGAR MONTAJES")
                                End Select

                            End If

                        End If
                        '----------------------------------------------------------------------------------------------------------------------------------------
                        If oConectarAplicacion.sCurrentCompanyDB = sBDIndustrial Then ' VALIDACION DE INDUSTRIAL

                            If (pVal.FormTypeEx = "SBOAddonProject1.Form4" And pVal.ItemUID = "Item_0") Or
                               (pVal.FormTypeEx = "SBOAddonProject1.FormMapaD" And pVal.ItemUID = "Item_5") Then 'GRID VENTAS COMERCIAL EDO COM ING

                                Select Case pVal.ColUID
                                    Case "Pedido de Ventas", "Pedido de Ventas  <*>" '"Pedido de Ventas      Tipo Pedido       % Avance Proyecto     % Avance Pedido"
                                        BubbleEvent = False
                                        Cargar_Pedidos_Clientes_Externo(sBDComercial.Trim(), pVal.FormUID, sCodigo, "Pedidos Clientes MINDUGAR COMERCIAL")
                                    Case "Guia de Entrega"
                                        BubbleEvent = False
                                        Cargar_Guia_Entrega_Externa(sBDComercial.Trim(), pVal.FormUID, sCodigo, "Guia Entrega MINDUGAR COMERCIAL")
                                    Case "Oferta de Ventas"
                                        BubbleEvent = False
                                        Cargar_Oferta_Venta_Externa(sBDComercial.Trim(), pVal.FormUID, sCodigo, "Oferta de Ventas MINDUGAR COMERCIAL")
                                    Case "Oportunidad de Ventas"
                                        BubbleEvent = False
                                        Application.SBO_Application.MessageBox("Para ver este Documento debe entrar a MINDUGAR COMERCIAL")
                                End Select

                            End If

                            If (pVal.FormTypeEx = "SBOAddonProject1.Form4" And pVal.ItemUID = "Item_44") Or
                                (pVal.FormTypeEx = "SBOAddonProject1.FormMapaD" And pVal.ItemUID = "Item_6") Then 'GRID COMPRAS COMERCIAL EDO COM ING

                                Select Case pVal.ColUID
                                    Case "Entrada de Mercaderia"
                                        BubbleEvent = False
                                        Cargar_Entrada_Mercaderia_Externo(sBDComercial.Trim(), pVal.FormUID, sCodigo, "Entradas de Mercaderia MINDUGAR COMERCIAL")
                                    Case "Pedido Compras  <*>" '"Pedido Compras    Fecha Pedido   % Entrad Totales   % Ent. PC"
                                        BubbleEvent = False
                                        Cargar_Pedidos_Compras_Externo(sBDComercial.Trim(), pVal.FormUID, sCodigo, "Pedido de Compras MINDUGAR COMERCIAL")
                                End Select

                            End If

                            If (pVal.FormTypeEx = "SBOAddonProject1.Form4" And pVal.ItemUID = "Item_49") Or
                                (pVal.FormTypeEx = "SBOAddonProject1.FormMapaD" And pVal.ItemUID = "Item_7") Then 'GRID INDUSTRIAL EDO COM ING

                                Select Case pVal.ColUID
                                    Case "PCV Comercial"
                                        BubbleEvent = False
                                        Cargar_Pedidos_Clientes_Externo(sBDComercial.Trim(), pVal.FormUID, sCodigo, "Pedidos Clientes MINDUGAR COMERCIAL")
                                End Select

                            End If

                            If (pVal.FormTypeEx = "SBOAddonProject1.Form4" And pVal.ItemUID = "Item_50") Or
                                (pVal.FormTypeEx = "SBOAddonProject1.FormMapaD" And pVal.ItemUID = "Item_8") Then 'GRID MONTAJES EDO COM ING

                                Select Case pVal.ColUID
                                    Case "Pedido Comercial"
                                        BubbleEvent = False
                                        Cargar_Pedidos_Clientes_Externo(sBDComercial.Trim(), pVal.FormUID, sCodigo, "Pedidos Clientes MINDUGAR COMERCIAL")
                                    Case "Pedido Ventas Montaje <*>" '"Pedido Ventas Montaje     Tipo_Pedido       Estado_PCV"
                                        BubbleEvent = False
                                        Cargar_Pedidos_Clientes_Externo(sBDMontaje.Trim(), pVal.FormUID, sCodigo, "Pedidos Clientes MINDUGAR MONTAJES")
                                    Case "Oferta Ventas Montaje    Fecha Oferta"
                                        BubbleEvent = False
                                        Cargar_Oferta_Venta_Externa(sBDMontaje.Trim(), pVal.FormUID, sCodigo, "Oferta de Ventas MINDUGAR MONTAJES")
                                    Case "PCI_Montajes"
                                        BubbleEvent = False
                                        Cargar_Pedidos_Compras_Externo(sBDMontaje.Trim(), pVal.FormUID, sCodigo, "Pedido de Compras MINDUGAR MONTAJES")
                                    Case "Solicitud Compra     Fecha Solicitud"
                                        BubbleEvent = False
                                        Cargar_Solicitud_Compras_Externo(sBDMontaje.Trim(), pVal.FormUID, sCodigo, "Solicitud de Compras MINDUGAR MONTAJES")
                                End Select

                            End If

                        End If
                        '---------------------------------------------------------------------
                        If oConectarAplicacion.sCurrentCompanyDB = sBDMontaje Then ' VALIDACION DE MONTAJES

                            If (pVal.FormTypeEx = "SBOAddonProject1.Form4" And pVal.ItemUID = "Item_0") Or
                                (pVal.FormTypeEx = "SBOAddonProject1.FormMapaD" And pVal.ItemUID = "Item_5") Then 'GRID VENTAS COMERCIAL EDO COM ING

                                Select Case pVal.ColUID
                                    Case "Pedido de Ventas", "Pedido Comercial", "Pedido de Ventas  <*>" '"Pedido de Ventas      Tipo Pedido       % Avance Proyecto     % Avance Pedido"
                                        BubbleEvent = False
                                        Cargar_Pedidos_Clientes_Externo(sBDComercial.Trim(), pVal.FormUID, sCodigo, "Pedidos Clientes MINDUGAR COMERCIAL")
                                    Case "Guia de Entrega"
                                        BubbleEvent = False
                                        Cargar_Guia_Entrega_Externa(sBDComercial.Trim(), pVal.FormUID, sCodigo, "Guia Entrega MINDUGAR COMERCIAL")
                                    Case "Oferta de Ventas"
                                        Cargar_Oferta_Venta_Externa(sBDComercial.Trim(), pVal.FormUID, sCodigo, "Oferta de Ventas MINDUGAR COMERCIAL")
                                    Case "Oportunidad de Ventas"
                                        BubbleEvent = False
                                        Application.SBO_Application.MessageBox("Para ver este Documento debe entrar a MINDUGAR COMERCIAL")
                                End Select

                            End If

                            If (pVal.FormTypeEx = "SBOAddonProject1.Form4" And pVal.ItemUID = "Item_44") Or
                                (pVal.FormTypeEx = "SBOAddonProject1.FormMapaD" And pVal.ItemUID = "Item_6") Then 'GRID COMPRAS COMERCIAL EDO COM ING

                                Select Case pVal.ColUID
                                    Case "Entrada de Mercaderia"
                                        BubbleEvent = False
                                        Cargar_Entrada_Mercaderia_Externo(sBDComercial.Trim(), pVal.FormUID, sCodigo, "Entradas de Mercaderia MINDUGAR COMERCIAL")
                                    Case "Pedido Compras  <*>" '"Pedido Compras    Fecha Pedido   % Entrad Totales   % Ent. PC"
                                        BubbleEvent = False
                                        Cargar_Pedidos_Compras_Externo(sBDComercial.Trim(), pVal.FormUID, sCodigo, "Pedido de Compras MINDUGAR COMERCIAL")
                                End Select

                            End If

                            If (pVal.FormTypeEx = "SBOAddonProject1.Form4" And pVal.ItemUID = "Item_49") Or
                               (pVal.FormTypeEx = "SBOAddonProject1.FormMapaD" And pVal.ItemUID = "Item_7") Then 'GRID INDUSTRIAL EDO COM ING

                                Select Case pVal.ColUID
                                    Case "PCV Comercial"
                                        BubbleEvent = False
                                        Cargar_Pedidos_Clientes_Externo(sBDComercial.Trim(), pVal.FormUID, sCodigo, "Pedidos Clientes MINDUGAR COMERCIAL")
                                    Case "Pedido Industrial <*>" '"Pedido Industrial    Tipo Pedido   Fecha Emision"
                                        BubbleEvent = False
                                        Cargar_Pedidos_Clientes_Externo(sBDIndustrial.Trim(), pVal.FormUID, sCodigo, "Pedidos Clientes MINDUGAR INDUSTRIAL")
                                    Case "Numero de Documento"
                                        BubbleEvent = False
                                        Cargar_Guia_Entrega_Externa(sBDIndustrial.Trim(), pVal.FormUID, sCodigo, "Guia Entrega MINDUGAR INDUSTRIAL")
                                End Select

                            End If

                            If (pVal.FormTypeEx = "SBOAddonProject1.Form4" And pVal.ItemUID = "Item_50") Or
                                   (pVal.FormTypeEx = "SBOAddonProject1.FormMapaD" And pVal.ItemUID = "Item_8") Then 'GRID MONTAJES EDO COM ING

                                Select Case pVal.ColUID
                                    Case "Pedido Comercial"
                                        BubbleEvent = False
                                        Cargar_Pedidos_Clientes_Externo(sBDComercial.Trim(), pVal.FormUID, sCodigo, "Pedidos Clientes MINDUGAR COMERCIAL")
                                End Select

                            End If

                        End If

                        If BubbleEvent Then ' Si el Link Button es Valido se llama la Pantalla

                            Select Case pVal.ColUID
                                Case "Oportunidad_de_Ventas", "Oportunidad de Ventas"
                                    oFunciones.LinkedObjectForm(pVal.FormUID, "2566", "74", sCodigo)
                                Case "Oferta_de_Ventas", "Oferta de Ventas", "Oferta Ventas Montaje    Fecha Oferta"
                                    oFunciones.LinkedObjectForm(pVal.FormUID, "2049", "8", sCodigo)
                                Case "Pedido_de_Ventas", "Pedido de Ventas", "PCV Comercial", "Pedido Comercial"
                                    oFunciones.LinkedObjectForm("139", "2050", "8", sCodigo)
                                Case "Pedido de Ventas  <*>" '"Pedido de Ventas      Tipo Pedido       % Avance Proyecto     % Avance Pedido"
                                    oFunciones.LinkedObjectForm("139", "2050", "8", sCodigo)
                                Case "Guia_de_Entrega", "Guia de Entrega"
                                    oFunciones.LinkedObjectForm("139", "2051", "8", sCodigo)
                                Case "Orden_Fabricacion", "Orden Fabricacion"
                                    oFunciones.LinkedObjectForm("139", "4369", "18", sCodigo)
                                Case "Solicitud_Compra", "Solicitud Compra", "Solicitud Compra     Fecha Solicitud"
                                    oFunciones.LinkedObjectForm(pVal.FormUID, "39724", "8", sCodigo)
                                Case "PCI_Montajes", "PCI Montajes"
                                    oFunciones.LinkedObjectForm(pVal.FormUID, "2305", "8", sCodigo)
                                Case "Pedido Ventas Montaje <*>" '"Pedido Ventas Montaje     Tipo_Pedido       Estado_PCV"
                                    oFunciones.LinkedObjectForm(pVal.FormUID, "2050", "8", sCodigo)
                                Case "Pedido_de_Compras", "Pedido de Compras", "Pedido Industrial <*>"
                                    oFunciones.LinkedObjectForm(pVal.FormUID, "2305", "8", sCodigo)
                                Case "Pedido Compras  <*>" '"Pedido Compras    Fecha Pedido   % Entrad Totales   % Ent. PC"
                                    oFunciones.LinkedObjectForm(pVal.FormUID, "2305", "8", sCodigo)
                                Case "Entrada_Mercaderia", "Entrada de Mercaderia"
                                    oFunciones.LinkedObjectForm(pVal.FormUID, "2306", "8", sCodigo)
                            End Select

                            BubbleEvent = False

                        End If

                    End If

                End If

                '------------------------------------------------------------------------------------------------------------------------------------------------
                '  ESTE EVENTO ABRE EN LA PANTALLA DE GESTION DE PROYECTOS, EL LISTADO DE PCVS,PCIS Y DOCUMENTOS DESDE LA GESTION DE MONTAJES(GESTION DE MONTAJE)
                '------------------------------------------------------------------------------------------------------------------------------------------------
                If pVal.FormTypeEx = "SBOAddonProject1.Form_PlanifMontajes" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_MATRIX_LINK_PRESSED And
                 pVal.ItemUID = "Item_0" And pVal.BeforeAction = True Then

                    Dim bProgBar As Boolean = True

                    If esPantallaModal Then
                        BubbleEvent = False
                        Exit Sub
                    End If

                    oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
                    oGrid = oForm.Items.Item("Item_0").Specific
                    oGrid.Rows.SelectedRows.Add(pVal.Row)

                    Select Case pVal.ColUID

                        Case "Projecto"

                            Try
                                bProgBar = Funciones.Create_ProgressBar(oProgBar, "Abriendo Estado de Proyectos", 2)
                            Catch ex As Exception
                            End Try

                            Dim EstadoGlobal As FrmEstado_Global
                            EstadoGlobal = New FrmEstado_Global

                            BubbleEvent = False

                            Try

                                Dim sCodigo = oGrid.DataTable.GetValue(pVal.ColUID, oGrid.GetDataTableRowIndex(pVal.Row)) ' Selecciona el contenido de la celda

                                Dim oFormP As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(EstadoGlobal.UIAPIRawForm.UniqueID)
                                oDTSQL = oFormP.DataSources.DataTables.Item("DT_SQL1")
                                oDTSQL2 = oFormP.DataSources.DataTables.Item("DT_SQL2")

                                FrmEstado_Global.Cargar_Campos_Estado_Global(oFormP.UniqueID, sCodigo, oDTSQL, oDTSQL2)
                                'Cargar_Campos_Form_Principal(pVal)
                                'Application.SBO_Application.Forms.Item(pVal.FormUID).Close()
                            Catch
                            End Try


                            Try
                                bProgBar = Funciones.Increment_ProgressBar(oProgBar, 1)
                                bProgBar = Funciones.Close_ProgressBar(oProgBar)
                            Catch ex As Exception
                            End Try

                            EstadoGlobal.Show()

                        Case "Multa"

                            Dim EstadosPCV As FrmPCVmonta
                            EstadosPCV = New FrmPCVmonta

                            BubbleEvent = False

                            Try

                                Dim sCodigo = oGrid.DataTable.GetValue("Projecto", oGrid.GetDataTableRowIndex(pVal.Row)) ' Selecciona el numero de Proyecto
                                Dim nPCVs = oGrid.DataTable.GetValue("Multa", oGrid.GetDataTableRowIndex(pVal.Row)).ToString.Trim().Substring(0, 3).Replace("-", "") ' Selecciona el numero de PCVs

                                Dim oFormP As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(EstadosPCV.UIAPIRawForm.UniqueID)
                                oUDataSource = oFormP.DataSources.UserDataSources.Item("UD_1") 'Pasar el Codigo del Proyecto
                                oUDataSource.ValueEx = sCodigo
                                oUDataSource = oFormP.DataSources.UserDataSources.Item("UD_2") 'Pasar la Descripcion del Proyecto
                                oUDataSource.ValueEx = oGrid.DataTable.GetValue("Prj.Nombre", oGrid.GetDataTableRowIndex(pVal.Row))
                                oUDataTable = oFormP.DataSources.DataTables.Item("DT_SQL")

                                Try
                                    If nPCVs > 0 Then
                                        EstadosPCV.Show()
                                    Else
                                        Application.SBO_Application.StatusBar.SetText("EL Proyecto No Posee PCV en Montajes", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
                                    End If
                                Catch ex As Exception

                                End Try

                            Catch
                            End Try

                        Case "% PCIs"

                            Dim PCI_Monta As FrmPCImonta
                            PCI_Monta = New FrmPCImonta

                            BubbleEvent = False

                            Try

                                Dim sCodigo = oGrid.DataTable.GetValue("Projecto", oGrid.GetDataTableRowIndex(pVal.Row)) ' Selecciona el numero de Proyecto

                                Dim oFormP As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(PCI_Monta.UIAPIRawForm.UniqueID)
                                oUDataSource = oFormP.DataSources.UserDataSources.Item("UD_1") 'Pasar el Codigo del Proyecto
                                oUDataSource.ValueEx = sCodigo
                                oUDataSource = oFormP.DataSources.UserDataSources.Item("UD_2") 'Pasar la Descripcion del Proyecto
                                oUDataSource.ValueEx = oGrid.DataTable.GetValue("Prj.Nombre", oGrid.GetDataTableRowIndex(pVal.Row))
                                oUDataTable = oFormP.DataSources.DataTables.Item("DT_SQL")

                                PCI_Monta.Show()

                            Catch
                            End Try

                        Case "Doc.Adj."

                            Dim Documentos As FrmDocumentos
                            Documentos = New FrmDocumentos

                            BubbleEvent = False

                            Try

                                Dim sCodigo = oGrid.DataTable.GetValue("Projecto", oGrid.GetDataTableRowIndex(pVal.Row)) ' Selecciona el numero de Proyecto

                                Dim oFormP As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(Documentos.UIAPIRawForm.UniqueID)
                                oUDataSource = oFormP.DataSources.UserDataSources.Item("UD_0") 'Pasar el FORMUID
                                oUDataSource.ValueEx = pVal.FormUID
                                oUDataSource = oFormP.DataSources.UserDataSources.Item("UD_1") 'Pasar el Codigo del Proyecto
                                oUDataSource.ValueEx = sCodigo
                                oUDataSource = oFormP.DataSources.UserDataSources.Item("UD_2") 'Pasar la Descripcion del Proyecto
                                oUDataSource.ValueEx = oGrid.DataTable.GetValue("Prj.Nombre", oGrid.GetDataTableRowIndex(pVal.Row))
                                oUDataSource = oFormP.DataSources.UserDataSources.Item("UD_ROW") 'Pasar el numero de Fila
                                oUDataSource.ValueEx = pVal.Row

                                Documentos.OnInitializeFormEvents()
                                Documentos.Show()

                            Catch
                            End Try

                    End Select

                End If

                '------------------------------------------------------------------------------------------------------------------------------------------------
                '  ESTE EVENTO ABRE LAS PCV EN LA PANTALLA DE LISTADOS DE PCV EN GESTION DE MONTAJES
                '------------------------------------------------------------------------------------------------------------------------------------------------

                If pVal.FormTypeEx = "SBOAddonProject1.FrmPCVmonta" And
                  pVal.EventType = SAPbouiCOM.BoEventTypes.et_MATRIX_LINK_PRESSED And
                  pVal.ItemUID = "Item_0" And pVal.BeforeAction = True Then


                    oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
                    oGrid = oForm.Items.Item(pVal.ItemUID).Specific
                    Dim sCodigo As String = oGrid.DataTable.GetValue(0, pVal.Row)

                    oUDataSource = oForm.DataSources.UserDataSources.Item("UD_2")
                    Dim sNombre As String = oUDataSource.ValueEx.Trim()

                    Select Case pVal.ColUID
                        Case "N° PCV"

                            Select Case oConectarAplicacion.sCurrentCompanyDB
                                Case sBDComercial
                                    BubbleEvent = False
                                    Cargar_Pedidos_Clientes_Externo(sBDComercial.Trim(), pVal.FormUID, sCodigo, "Pedidos Clientes MINDUGAR MONTAJE")
                                Case sBDMontaje
                                    oFunciones.LinkedObjectForm(pVal.FormUID, "2050", "8", sCodigo)
                                    BubbleEvent = False
                                Case sBDIndustrial
                                    BubbleEvent = False
                                    Cargar_Pedidos_Clientes_Externo(sBDComercial.Trim(), pVal.FormUID, sCodigo, "Pedidos Clientes MINDUGAR MONTAJE")
                            End Select

                        Case "Doc.Adj."

                            Dim Documentos As FrmDocumentos
                            Documentos = New FrmDocumentos

                            BubbleEvent = False

                            Try

                                sCodigo = oGrid.DataTable.GetValue("Proyecto", oGrid.GetDataTableRowIndex(pVal.Row)) ' Selecciona el numero de Proyecto

                                Dim oFormP As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(Documentos.UIAPIRawForm.UniqueID)
                                oUDataSource = oFormP.DataSources.UserDataSources.Item("UD_1") 'Pasar el Codigo del Proyecto
                                oUDataSource.ValueEx = sCodigo
                                oUDataSource = oFormP.DataSources.UserDataSources.Item("UD_2") 'Pasar la Descripcion del Proyecto
                                oUDataSource.ValueEx = sNombre

                                Documentos.OnInitializeFormEvents()
                                Documentos.Show()


                            Catch
                            End Try
                    End Select

                End If

                '------------------------------------------------------------------------------------------------------------------------------------------------
                '  ESTE EVENTO ABRE LAS PCI EN LA PANTALLA DE LISTADOS DE PCI EN GESTION DE MONTAJES
                '------------------------------------------------------------------------------------------------------------------------------------------------

                If pVal.FormTypeEx = "SBOAddonProject1.FrmPCImonta" And
                  pVal.EventType = SAPbouiCOM.BoEventTypes.et_MATRIX_LINK_PRESSED And
                  pVal.ItemUID = "Item_0" And pVal.BeforeAction = True Then


                    oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
                    oGrid = oForm.Items.Item(pVal.ItemUID).Specific
                    Dim sCodigo As String = oGrid.DataTable.GetValue(0, pVal.Row)

                    Select Case oConectarAplicacion.sCurrentCompanyDB
                        Case sBDComercial
                            BubbleEvent = False
                            Cargar_Pedidos_Compras_Externo(sBDComercial.Trim(), pVal.FormUID, sCodigo, "Pedido de Compras MINDUGAR MONTAJE")
                        Case sBDMontaje
                            oFunciones.LinkedObjectForm(pVal.FormUID, "2305", "8", sCodigo)
                            BubbleEvent = False
                        Case sBDIndustrial
                            BubbleEvent = False
                            Cargar_Pedidos_Compras_Externo(sBDComercial.Trim(), pVal.FormUID, sCodigo, "Pedido de Compras MINDUGAR MONTAJE")
                    End Select


                End If

                '------------------------------------------------------------------------------------------------------------------------------------------------
                '  ESTE EVENTO ABRE LAS PCR EN EN INFORME DE PCRs ACTIVAS
                '------------------------------------------------------------------------------------------------------------------------------------------------

                If pVal.FormTypeEx = "SBOAddonProject1.FrmPCRcomerci" And
                  pVal.EventType = SAPbouiCOM.BoEventTypes.et_MATRIX_LINK_PRESSED And
                  pVal.ItemUID = "Item_0" And pVal.BeforeAction = True Then

                    Try
                        oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
                        oGrid = oForm.Items.Item(pVal.ItemUID).Specific
                        Dim iNoLeaf As Integer = 0
                        Dim sCodigo As String = ""

                        Try

                            oEditCol = oGrid.Columns.Item(pVal.ColUID)
                            sCodigo = oEditCol.GetText(pVal.Row)
                            sCodigo = sCodigo.Substring(0, 10)

                        Catch ex As Exception
                        End Try

                        Select Case oConectarAplicacion.sCurrentCompanyDB
                            Case sBDMontaje
                                BubbleEvent = False
                                Cargar_Pedidos_Clientes_Externo(sBDComercial.Trim(), pVal.FormUID, sCodigo, "PCI MINDUGAR COMERCIAL")
                            Case sBDComercial
                                oFunciones.LinkedObjectForm("139", "2050", "8", sCodigo)
                                BubbleEvent = False
                            Case sBDIndustrial
                                BubbleEvent = False
                                Cargar_Pedidos_Clientes_Externo(sBDComercial.Trim(), pVal.FormUID, sCodigo, "PCI MINDUGAR COMERCIAL")
                        End Select
                    Catch ex As Exception
                    End Try

                End If

                '------------------------------------------------------------------------------------------------------------------------------------------------
                '  ESTE EVENTO COLOCA Y CONFIGURA LOS LINKED BUTTONS EN LA CELDA EN EL GRID 1 (ESTADO COMERIAL INGENIERIA, INDUSTRIAL Y MONTAJE)
                '------------------------------------------------------------------------------------------------------------------------------------------------

                If (pVal.FormTypeEx = "SBOAddonProject1.Form4" Or pVal.FormTypeEx = "SBOAddonProject1.Form5" Or pVal.FormTypeEx = "SBOAddonProject1.Form8" Or pVal.FormTypeEx = "SBOAddonProject1.FormMapaD") And
                    pVal.EventType = SAPbouiCOM.BoEventTypes.et_MATRIX_LINK_PRESSED And (pVal.ItemUID = "Item_0" Or pVal.ItemUID = "Item_41" Or pVal.ItemUID = "Item_49" Or pVal.ItemUID = "Item_34" Or pVal.ItemUID = "Item_50") And pVal.BeforeAction = False Then

                    'MOVIDO PARA EL EVENTO BeforeAction = True PARA EVITAR QUE SE CARGUE EL FORM VACIO
                    BubbleEvent = False


                End If

                If pVal.FormTypeEx = "SBOAddonProject1.Form_PlanifMontajes" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_MATRIX_LINK_PRESSED And
                 pVal.ItemUID = "Item_0" And pVal.BeforeAction = False Then

                    BubbleEvent = False

                End If

                If pVal.FormTypeEx = "SBOAddonProject1.FrmPCVmonta" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_MATRIX_LINK_PRESSED And
                 pVal.ItemUID = "Item_0" And pVal.BeforeAction = False Then

                    BubbleEvent = False

                End If

                '------------------------------------------------------------------------------------------------------------------------------------------------
                '  ESTE EVENTO CAMBIA EL COLOR DE LA CELDA EN LA MATRIX AL SELECCIONAR UNA OPCION DEL COMBO BOX (GESTION DE PLANOS)
                '------------------------------------------------------------------------------------------------------------------------------------------------
                If pVal.FormTypeEx = "SBOAddonProject1.Form11" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_COMBO_SELECT And pVal.ItemUID = "Item_4" And pVal.BeforeAction = False Then

                    oMatrix = oForm.Items.Item("Item_4").Specific

                    If oMatrix.Columns.Item("Col_2").Cells.Item(pVal.Row).Specific.Value = "Activo" Then
                        oMatrix.CommonSetting.SetCellBackColor(pVal.Row, 2, oFunciones.Color_RGB_SAP(255, 255, 153))
                    Else
                        oMatrix.CommonSetting.SetCellBackColor(pVal.Row, 2, oFunciones.Color_RGB_SAP(255, 51, 51))
                    End If
                End If


                '-------------------------------------------------------------------------------------------------------
                '    ACTUALIZA LA VARIABLE GLOBAL AbiertoDesdeForm = FALSE CADA VEZ QUE SE CIERRA LA PANTALLA
                '-------------------------------------------------------------------------------------------------------
                If (pVal.FormTypeEx = "139") And
                   (pVal.EventType = SAPbouiCOM.BoEventTypes.et_FORM_UNLOAD Or pVal.EventType = SAPbouiCOM.BoEventTypes.et_FORM_CLOSE) And
                   pVal.BeforeAction Then

                    AbiertoDesdeForm = False

                End If

                '-------------------------------------------------------------------------------------------------------
                '    CAPTURA EVENTOS DE ITEMS EN LA PANTALLA DE GESTION DE INGENIERIA
                '-------------------------------------------------------------------------------------------------------
                '------------------------------------------------------------------------------------------------------------------------------------------------
                '  ESTE EVENTO ABRE EN LA PANTALLA DE GESTION DE INGENIERIA, EL LISTADO DE PCVS Y DOCUMENTOS DESDE LA GESTION DE INGERIERIA(GESTION DE INGENIERIA)
                '------------------------------------------------------------------------------------------------------------------------------------------------
                If pVal.FormTypeEx = "SBOAddonProject1.FrmGestion_Ingenieria" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_MATRIX_LINK_PRESSED And
                (pVal.ItemUID = "Item_3" Or pVal.ItemUID = "Item_4") And pVal.BeforeAction = True Then

                    'If nCountEvent = 0 Then
                    '    nCountEvent += 1
                    'Else
                    '    nCountEvent = 0
                    '    BubbleEvent = False
                    'End If

                    Try

                        Select Case pVal.ColUID

                            Case "Projecto"

                                Try
                                    oProgBar = Application.SBO_Application.StatusBar.CreateProgressBar("Abriendo Estado de Proyectos", 2, False)

                                    Try
                                        oProgBar.Value += 1
                                    Catch ex As Exception
                                        System.Runtime.InteropServices.Marshal.ReleaseComObject(oProgBar)
                                        oProgBar = Nothing
                                        oProgBar = Application.SBO_Application.StatusBar.CreateProgressBar("Abriendo Estado de Proyectos", 2, False)
                                        oProgBar.Value += 1
                                    End Try
                                Catch ex As Exception

                                End Try

                                Dim EstadoGlobal As FrmEstado_Global
                                EstadoGlobal = New FrmEstado_Global

                                BubbleEvent = False

                                Try

                                    oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
                                    oGrid = oForm.Items.Item(pVal.ItemUID).Specific
                                    oGrid.Rows.SelectedRows.Add(pVal.Row)

                                    Dim sCodigo = oGrid.DataTable.GetValue(pVal.ColUID, oGrid.GetDataTableRowIndex(pVal.Row)) ' Selecciona el contenido de la celda


                                    Dim oFormP As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(EstadoGlobal.UIAPIRawForm.UniqueID)
                                    oDTSQL = oFormP.DataSources.DataTables.Item("DT_SQL1")
                                    oDTSQL2 = oFormP.DataSources.DataTables.Item("DT_SQL2")

                                    FrmEstado_Global.Cargar_Campos_Estado_Global(oFormP.UniqueID, sCodigo, oDTSQL, oDTSQL2)

                                Catch
                                End Try

                                Try
                                    oProgBar.Value += 1
                                Catch ex As Exception

                                End Try

                                Try
                                    oProgBar.Stop()
                                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oProgBar)
                                    oProgBar = Nothing
                                Catch ex As Exception
                                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oProgBar)
                                    oProgBar = Nothing
                                End Try

                                EstadoGlobal.Show()
                                BubbleEvent = False

                            Case "PCVs"

                                Try

                                    Dim ListadoPCV As FrmPCVing
                                    ListadoPCV = New FrmPCVing

                                    BubbleEvent = False

                                    oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
                                    oGrid = oForm.Items.Item(pVal.ItemUID).Specific
                                    oGrid.Rows.SelectedRows.Add(pVal.Row)
                                    'oGrid.Item.Click()

                                    Dim sCodigo = oGrid.DataTable.GetValue("Projecto", oGrid.GetDataTableRowIndex(pVal.Row)) ' Selecciona el numero de Proyecto
                                    Dim nPCVs As Integer = oGrid.DataTable.GetValue("PCVs", oGrid.GetDataTableRowIndex(pVal.Row)) ' Selecciona el numero de PCVs

                                    Dim oFormP As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(ListadoPCV.UIAPIRawForm.UniqueID)
                                    oUDataSource = oFormP.DataSources.UserDataSources.Item("UD_1") 'Pasar el Codigo del Proyecto
                                    oUDataSource.ValueEx = sCodigo
                                    oUDataSource = oFormP.DataSources.UserDataSources.Item("UD_2") 'Pasar la Descripcion del Proyecto
                                    oUDataSource.ValueEx = oGrid.DataTable.GetValue("Prj.Nombre", oGrid.GetDataTableRowIndex(pVal.Row))
                                    oUDataSource = oFormP.DataSources.UserDataSources.Item("UD_0") 'Pasar EL cliente final
                                    oUDataSource.ValueEx = oGrid.DataTable.GetValue("Cliente", oGrid.GetDataTableRowIndex(pVal.Row))
                                    oUDataTable = oFormP.DataSources.DataTables.Item("DT_SQL")

                                    Try
                                        If nPCVs > 0 Then
                                            ListadoPCV.Show()
                                            BubbleEvent = False
                                        Else
                                            Application.SBO_Application.StatusBar.SetText("EL Proyecto No Posee PCVs", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
                                        End If

                                    Catch ex As Exception

                                    End Try

                                Catch ex As Exception

                                End Try

                        End Select

                    Catch ex As Exception

                    End Try

                End If


                '-------------------------------------------------------------------------------------------------------
                '    CAPTURA EVENTO DE CLICK EN GRID DE PANTALLA DE MENSAJES O ALERTAS
                '-------------------------------------------------------------------------------------------------------
                'If pVal.FormTypeEx = "198" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_MATRIX_LINK_PRESSED And pVal.ItemUID = "6" And pVal.BeforeAction = True Then

                '    If 1 = 1 Then
                '        Select Case pVal.ColUID
                '            Case "V_0"
                '                Dim activeForm2 As Form14
                '                activeForm2 = New Form14

                '                activeForm2.Show()
                '                'oForm = Application.SBO_Application.Forms.GetForm("142", 1)
                '        End Select
                '    End If
                '    BubbleEvent = False

                'End If

                'If pVal.FormTypeEx = "0" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_FORM_LOAD And pVal.BeforeAction = False Then
                '    oForm = Application.SBO_Application.Forms.GetForm(0, 0)
                '    oForm.Items.Item("4").Specific.GetType()
                '    'If oStatic.Caption.Trim = "" Then

                '    'End If
                'End If

                'oCol = oGrid.Columns.Item("Oportunidad_de_Ventas")
                'oCol.LinkedObjectType = "97"
                'oCol = oGrid.Columns.Item("Oferta_de_Ventas")
                'oCol.LinkedObjectType = "23"
                'oCol = oGrid.Columns.Item("Pedido_de_Ventas")
                'oCol.LinkedObjectType = "17"
                'oCol = oGrid.Columns.Item("Guia_de_Entrega")
                'oCol.LinkedObjectType = "15"

                '--------------------------------------------------------------------------------------

                ''Prueba para captura de evento en pantalla de oferta de venta
                'If (pVal.FormTypeEx = "149" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_FORM_LOAD And pVal.BeforeAction) Then
                '    'Application.SBO_Application.MessageBox("EVENTO CAPTURADO")
                'End If

                ''Prueba para captura de evento en pantalla de busqueda de proyectos
                'If (pVal.FormTypeEx = "10062" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_FORM_LOAD And pVal.BeforeAction) Then
                '    'Application.SBO_Application.MessageBox("EVENTO CAPTURADO")
                'End If

                'If (pVal.FormTypeEx = "10062" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_CLICK And pVal.ItemUID = "7") Then
                '    'Application.SBO_Application.MessageBox("El item es el: " + pVal.ItemUID.ToString() + " , La Columna es: " + pVal.ColUID.ToString())
                '    'Application.SBO_Application.MessageBox("La Forma Activa es: " + Application.SBO_Application.Forms.Item(FormUID).ActiveItem)

                '    oForm = Application.SBO_Application.Forms.Item(FormUID)
                '    oMatrix = oForm.Items.Item("7").Specific 'matrix
                '    oedit = oMatrix.Columns.Item("PrjName").Cells.Item(pVal.Row).Specific
                '    'Application.SBO_Application.MessageBox(oedit.Value)
                '    sCodProyecto = oedit.Value

                'End If 'END et_ITEM_PRESSED 

                'If pVal.FormTypeEx = "10062" And ((pVal.EventType = SAPbouiCOM.BoEventTypes.et_CLICK And pVal.ItemUID = "1") Or
                '                                  (pVal.EventType = SAPbouiCOM.BoEventTypes.et_DOUBLE_CLICK And pVal.ItemUID = "7")) Then

                '    Dim oTextCodigo2 As SAPbouiCOM.EditText
                '    Dim activeForm As FrmEstado_Global
                '    activeForm = New FrmEstado_Global
                '    Application.SBO_Application.MessageBox(pVal.FormUID)
                '    Application.SBO_Application.MessageBox(sFormID_Principal)
                '    oForm = Application.SBO_Application.Forms.Item(sFormID_Principal)
                '    oTextCodigo2 = oForm.Items.Item("Item_2").Specific  'Application.SBO_Application.Forms.ActiveForm.Items.Item("Item_0").Specific 'oForm.Items.Item("Item_0").Specific 
                '    oTextCodigo2.Value = sCodProyecto

                'End If

                'If pVal.FormTypeEx = "139" And pVal.EventType = SAPbouiCOM.BoEventTypes. And pVal.ItemUID = "38" And pVal.BeforeAction Then
                '    Application.SBO_Application.MessageBox("Click Sobre el EditText")
                'End If

                'Dim FormpF As NewForm_3_b1f
                'FormpF = New NewForm_3_b1f

                'If pVal.FormTypeEx = FormpF.UIAPIRawForm.UniqueID And (pVal.EventType = SAPbouiCOM.BoEventTypes.et_CLICK And pVal.ItemUID = "Item_41") Then
                '    Application.SBO_Application.MessageBox("Click Sobre el EditText")
                'End If

                If pVal.FormTypeEx = "SBOAddonProject1.NewForm_3_b1f" And (pVal.EventType = SAPbouiCOM.BoEventTypes.et_VALIDATE And pVal.ItemUID = "Item_68") Then
                    'Application.SBO_Application.MessageBox("Click Sobre el EditText")
                End If

            End If

        End Sub


        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '  EVENTOS DE MANEJO DE DATOS
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        Private Sub SBO_Application_FormDataEvent(ByRef BOInfo As SAPbouiCOM.BusinessObjectInfo, ByRef BubbleEvent As Boolean)
            '---------------------------------------------------------------------------------------------------------------------------------------------------------
            '  ESTE EVENTO MODIFICA UN FORM DEL SISTEMA HAY EVENTOS QUE SE HACEN EN EL FORM_LOAD Y FORM_DATA_LOAD PORQUE ESTE ULTIMO, 
            '  SE EJECUTA PRIMERO AL LLAMAR EL FORM DESDE OTRA PANTALLA
            '---------------------------------------------------------------------------------------------------------------------------------------------------------

            If (BOInfo.FormTypeEx.Contains("SBOAddonProject1") Or BOInfo.FormTypeEx.Contains("139")) Then
                '------------------------------------------------------------------------------------------------------------------------------------------------------
                '    ACTUALIZA LOS EDITS DE CODIGO Y NOMBRE DE PROYECTO AL CARGAR DATOS
                '------------------------------------------------------------------------------------------------------------------------------------------------------
                If BOInfo.FormTypeEx = "139" And BOInfo.EventType = SAPbouiCOM.BoEventTypes.et_FORM_DATA_LOAD And Not BOInfo.BeforeAction Then

                    oForm = Application.SBO_Application.Forms.Item(BOInfo.FormUID)

                    Try
                        SystemForm2.Cargar_Datos_Proyecto_Pedido_Cliente_Existente(BOInfo.FormUID)
                    Catch ex As Exception
                        AbiertoDesdeEnlace = True
                    End Try

                End If

                '------------------------------------------------------------------------------------------------------------------------------------------------------
                '    ACTUALIZA EL TOTAL DE KILOS DE PEDIDOS CLIENTE AL ACTUALIZAR DATOS
                '------------------------------------------------------------------------------------------------------------------------------------------------------
                If BOInfo.FormTypeEx = "139" And
                    (BOInfo.EventType = SAPbouiCOM.BoEventTypes.et_FORM_DATA_UPDATE) And
                    Not BOInfo.BeforeAction Then

                    oForm = Application.SBO_Application.Forms.Item(BOInfo.FormUID)
                    oedit = oForm.Items.Item("157").Specific

                    Dim oDataTable As SAPbouiCOM.DataTable = oForm.DataSources.DataTables.Item("DT_INFOPRO")
                    'Application.SBO_Application.MessageBox(oedit.Value)

                    Dim oedit2 As SAPbouiCOM.EditText

                    If oedit.Value.Trim.Length() Then

                        Try
                            oForm.Freeze(True)
                            oedit = oForm.Items.Item("8").Specific
                            sPSql = " SELECT sum(ISNULL(T0.[Quantity],0) * ISNULL(T1.[U_MIN_PESO],0)) as Kilos " &
                                    " FROM ORDR T3 JOIN RDR1 T0  ON T3.DocEntry = T0.DocEntry " &
                                    " INNER JOIN OITM T1 ON T0.[ItemCode] = T1.[ItemCode] " &
                                    " WHERE T3.DocNum = " + oedit.Value.ToString

                            Try
                                oDataTable.ExecuteQuery(sPSql)
                            Catch ex As Exception

                            End Try

                            oedit2 = oForm.Items.Item("edKilosTot").Specific
                            oedit2.Item.Enabled = True
                            oedit2.String = oDataTable.GetValue("Kilos", 0)
                            oForm.Items.Item("16").Click()
                            oedit2.Item.Enabled = False
                        Catch ex As Exception
                        Finally
                            oForm.Freeze(False)
                        End Try

                    End If

                End If

            End If

        End Sub

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '  MENU CLICK DERECHO
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        Private Sub SBO_Application_RightClickEvent(ByRef eventInfo As SAPbouiCOM.ContextMenuInfo, ByRef BubbleEvent As Boolean)

            oForm = Application.SBO_Application.Forms.Item(eventInfo.FormUID)

            If (oForm.TypeEx.Contains("SBOAddonProject1")) Then
                Select Case oForm.TypeEx

                    Case "SBOAddonProject1.FrmGestionTV"       'PANTALLA GESTION TV
                        If eventInfo.ItemUID = "Item_0" Then  'GRID MENSAJES
                            If eventInfo.BeforeAction = True Then
                                Try

                                    Crear_MenuContextual("Eliminar Mensaje de Marquesina", "Eliminar Mensaje de Marquesina")

                                Catch ex As Exception
                                    Application.SBO_Application.MessageBox(ex.Message)
                                End Try

                            Else

                                Try
                                    Application.SBO_Application.Menus.RemoveEx("Eliminar Mensaje de Marquesina")

                                Catch ex As Exception
                                    Application.SBO_Application.MessageBox(ex.Message)
                                End Try
                            End If
                        End If

                    Case "SBOAddonProject1.FrmDocumentos"       'PANTALLA DOCUMENTOS GESTION MONTAJES
                        If eventInfo.ItemUID = "Item_5" Then  'GRID DOCUMENTOS
                            If eventInfo.BeforeAction = True Then
                                Try

                                    Crear_MenuContextual("Eliminar Documento", "Eliminar Documento")

                                Catch ex As Exception
                                    'Application.SBO_Application.MessageBox(ex.Message)
                                End Try

                            Else

                                Try
                                    Application.SBO_Application.Menus.RemoveEx("Eliminar Documento")

                                Catch ex As Exception
                                    Application.SBO_Application.MessageBox(ex.Message)
                                End Try
                            End If
                        End If

                End Select
            End If

        End Sub

        Private Sub Crear_MenuContextual(IDMenu As String, Descripcion As String)

            Dim oMenuItem As SAPbouiCOM.MenuItem
            Dim oMenus As SAPbouiCOM.Menus

            Dim oCreationPackage As SAPbouiCOM.MenuCreationParams
            oCreationPackage = (Application.SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams))

            oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING
            oCreationPackage.UniqueID = IDMenu
            oCreationPackage.String = Descripcion
            oCreationPackage.Enabled = True

            oMenuItem = Application.SBO_Application.Menus.Item("1280") 'Data'
            oMenus = oMenuItem.SubMenus
            oMenus.AddEx(oCreationPackage)

        End Sub

        Public Sub Cargar_Oportunidad_Venta_Externa(SociedadDB As String, FormUID As String, DocNum As String, NombrePantalla As String)


        End Sub

        Public Sub Cargar_Oferta_Venta_Externa(SociedadDB As String, FormUID As String, DocNum As String, NombrePantalla As String)


            sPSql = " SELECT  ISNULL(S.SeriesName,'') as Series ,P.DocNum, P.CardCode, P.CardName, P.DocDate,P.DocDueDate,P.TaxDate " &
                                            " FROM " + SociedadDB.Trim() + ".[dbo].OQUT P LEFT JOIN NNM1 S ON P.Series = S.Series  WHERE P.DocNum = " + DocNum

            sPSql2 = " SELECT R.ItemCode as 'Numero del Articulo', R.Dscription as 'Descripcion',R.Quantity as 'Cantidad',R.OpenCreQty  as 'Pendiente' " &
                     " FROM " + SociedadDB.Trim() + ".[dbo].OQUT P " &
                     " JOIN " + SociedadDB.Trim() + ".[dbo].QUT1 R On P.DocEntry = R.DocEntry AND P.DocNum = " + DocNum

            Cargar_Pantalla_Consulta_Documento(FormUID, sPSql, sPSql2, NombrePantalla)

        End Sub

        Public Sub Cargar_Pedidos_Clientes_Externo(SociedadDB As String, FormUID As String, DocNum As String, NombrePantalla As String)


            sPSql = " SELECT  ISNULL(S.SeriesName,'') as Series,P.DocNum, P.CardCode, P.CardName, P.DocDate,P.DocDueDate,P.TaxDate " &
                                            " FROM " + SociedadDB.Trim() + ".[dbo].ORDR P LEFT JOIN NNM1 S ON P.Series = S.Series WHERE P.DocNum = " + DocNum

            sPSql2 = " SELECT R.ItemCode as 'Numero del Articulo', R.Dscription as 'Descripcion',R.Quantity as 'Cantidad',R.OpenCreQty  as 'Pendiente' " &
                     " FROM " + SociedadDB.Trim() + ".[dbo].ORDR P " &
                     " JOIN " + SociedadDB.Trim() + ".[dbo].RDR1 R On P.DocEntry = R.DocEntry AND P.DocNum = " + DocNum

            Cargar_Pantalla_Consulta_Documento(FormUID, sPSql, sPSql2, NombrePantalla)

        End Sub

        Public Sub Cargar_Guia_Entrega_Externa(SociedadDB As String, FormUID As String, DocNum As String, NombrePantalla As String)


            sPSql = " SELECT  ISNULL(S.SeriesName,'') as Series,P.DocNum, P.CardCode, P.CardName, P.DocDate,P.DocDueDate,P.TaxDate " &
                                            " FROM " + SociedadDB.Trim() + ".[dbo].ODLN P LEFT JOIN NNM1 S ON P.Series = S.Series WHERE P.DocNum = " + DocNum

            sPSql2 = " SELECT R.ItemCode as 'Numero del Articulo', R.Dscription as 'Descripcion',R.Quantity as 'Cantidad',R.OpenCreQty  as 'Pendiente' " &
                     " FROM " + SociedadDB.Trim() + ".[dbo].ODLN P " &
                     " JOIN " + SociedadDB.Trim() + ".[dbo].DLN1 R On P.DocEntry = R.DocEntry AND P.DocNum = " + DocNum

            Cargar_Pantalla_Consulta_Documento(FormUID, sPSql, sPSql2, NombrePantalla)

        End Sub

        Public Sub Cargar_Solicitud_Compras_Externo(SociedadDB As String, FormUID As String, DocNum As String, NombrePantalla As String)


            sPSql = " SELECT  ISNULL(S.SeriesName,'') as Series,P.DocNum, P.CardCode, P.CardName, P.DocDate,P.DocDueDate,P.TaxDate " &
                                            " FROM " + SociedadDB.Trim() + ".[dbo].OPRQ P LEFT JOIN NNM1 S ON P.Series = S.Series WHERE P.DocNum = " + DocNum

            sPSql2 = " SELECT R.ItemCode as 'Numero del Articulo', R.Dscription as 'Descripcion',R.Quantity as 'Cantidad',R.OpenCreQty  as 'Pendiente' " &
                     " FROM " + SociedadDB.Trim() + ".[dbo].OPRQ P " &
                     " JOIN " + SociedadDB.Trim() + ".[dbo].PRQ1 R On P.DocEntry = R.DocEntry AND P.DocNum = " + DocNum

            Cargar_Pantalla_Consulta_Documento(FormUID, sPSql, sPSql2, NombrePantalla)

        End Sub

        Public Sub Cargar_Pedidos_Compras_Externo(SociedadDB As String, FormUID As String, DocNum As String, NombrePantalla As String)


            sPSql = " SELECT  ISNULL(S.SeriesName,'') as Series,P.DocNum, P.CardCode, P.CardName, P.DocDate,P.DocDueDate,P.TaxDate " &
                                            " FROM " + SociedadDB.Trim() + ".[dbo].OPOR P LEFT JOIN NNM1 S ON P.Series = S.Series WHERE P.DocNum = " + DocNum

            sPSql2 = " SELECT R.ItemCode as 'Numero del Articulo', R.Dscription as 'Descripcion',R.Quantity as 'Cantidad',R.OpenCreQty  as 'Pendiente' " &
                     " FROM " + SociedadDB.Trim() + ".[dbo].OPOR P " &
                     " JOIN " + SociedadDB.Trim() + ".[dbo].POR1 R On P.DocEntry = R.DocEntry AND P.DocNum = " + DocNum

            Cargar_Pantalla_Consulta_Documento(FormUID, sPSql, sPSql2, NombrePantalla)

        End Sub

        Public Sub Cargar_Entrada_Mercaderia_Externo(SociedadDB As String, FormUID As String, DocNum As String, NombrePantalla As String)


            sPSql = " SELECT  ISNULL(S.SeriesName,'') as Series,P.DocNum, P.CardCode, P.CardName, P.DocDate,P.DocDueDate,P.TaxDate " &
                                            " FROM " + SociedadDB.Trim() + ".[dbo].OPDN P LEFT JOIN NNM1 S ON P.Series = S.Series WHERE P.DocNum = " + DocNum

            sPSql2 = " SELECT R.ItemCode as 'Numero del Articulo', R.Dscription as 'Descripcion',R.Quantity as 'Cantidad',R.OpenCreQty  as 'Pendiente' " &
                     " FROM " + SociedadDB.Trim() + ".[dbo].OPDN P " &
                     " JOIN " + SociedadDB.Trim() + ".[dbo].PDN1 R On P.DocEntry = R.DocEntry AND P.DocNum = " + DocNum

            Cargar_Pantalla_Consulta_Documento(FormUID, sPSql, sPSql2, NombrePantalla)

        End Sub

        Public Sub Cargar_Pantalla_Consulta_Documento(FormUIDOrigen As String, SqlEncab As String, SqlDeta As String, NombrePantalla As String)

            Dim PantallaConsulta As New FrmConsultaDat()

            oForm = Application.SBO_Application.Forms.Item(PantallaConsulta.UIAPIRawForm.UniqueID)

            oUDataSource = oForm.DataSources.UserDataSources.Item("UD_0")
            oUDataSource.ValueEx = FormUIDOrigen

            Try

                'oForm.Show()
                'oForm.Freeze(True)
                oForm.Title = NombrePantalla

                Try

                    oUDataTable = oForm.DataSources.DataTables.Item("DT_ENCA")
                    oUDataTable.ExecuteQuery(SqlEncab)

                    Asignar_Valor_a_EditText(oForm, "Item_4", oUDataTable.GetValue(2, 0), "Value", False)
                    Asignar_Valor_a_EditText(oForm, "Item_6", oUDataTable.GetValue(3, 0), "Value", False)
                    Asignar_Valor_a_EditText(oForm, "Item_20", oUDataTable.GetValue(0, 0), "Value", False)
                    Asignar_Valor_a_EditText(oForm, "Item_8", oUDataTable.GetValue(1, 0), "Value", False)
                    Asignar_Valor_a_EditText(oForm, "Item_12", oUDataTable.GetValue(4, 0), "String", False)
                    Asignar_Valor_a_EditText(oForm, "Item_14", oUDataTable.GetValue(5, 0), "String", False)
                    Asignar_Valor_a_EditText(oForm, "Item_18", oUDataTable.GetValue(6, 0), "String", False)

                Catch ex As Exception
                End Try

                Try
                    oUDataTable = oForm.DataSources.DataTables.Item("DT_DET")
                    oUDataTable.ExecuteQuery(SqlDeta)
                Catch ex As Exception
                End Try

            Catch ex As Exception
            Finally
                oForm.Freeze(False)
                PantallaConsulta.Show()
            End Try


        End Sub

        Public Sub Asignar_Valor_a_EditText(oPForm As SAPbouiCOM.Form, ItemId As String, Valor As String, Value_Or_String As String, Enable As Boolean)

            Try
                oedit = oPForm.Items.Item(ItemId).Specific
                Select Case Value_Or_String
                    Case "Value"
                        oedit.Value = Valor
                    Case "String"
                        oedit.String = Valor
                End Select
                oedit.Active = False
                oedit.Item.Enabled = Enable
            Catch ex As Exception

            End Try

        End Sub

        Public Function ConvertirDataTableSAP(ByVal SAPDataTable As SAPbouiCOM.DataTable) As DataTable

            '\ This function will take an SAP DataTable from the SAPbouiCOM library and convert it to a more
            '\ easily used ADO.NET datatable which can be used for data binding much easier.

            Dim dtTable As New DataTable
            Dim NewCol As DataColumn
            Dim NewRow As DataRow
            Dim ColCount As Integer

            Try

                For ColCount = 0 To SAPDataTable.Columns.Count - 1
                    NewCol = New DataColumn(SAPDataTable.Columns.Item(ColCount).Name)
                    dtTable.Columns.Add(NewCol)
                Next

                For i = 0 To SAPDataTable.Rows.Count - 1

                    NewRow = dtTable.NewRow
                    'populate each column in the row we're creating
                    For ColCount = 0 To SAPDataTable.Columns.Count - 1
                        NewRow.Item(SAPDataTable.Columns.Item(ColCount).Name) = SAPDataTable.GetValue(ColCount, i)
                    Next

                    'Add the row to the datatable
                    dtTable.Rows.Add(NewRow)
                Next

                Return dtTable

            Catch ex As Exception
                MsgBox(ex.ToString & Chr(10) & "Error converting SAP DataTable to DataTable .Net", MsgBoxStyle.Exclamation)
                ConvertirDataTableSAP = Nothing
                Exit Function
            End Try

        End Function


#Region "Codigo Antiguo"
        'Public Sub Agregar_Campos_Proyecto(oForm As SAPbouiCOM.Form)

        '    Try

        '        Dim oNewItem As SAPbouiCOM.Item

        '        '--------------------------------------------------------------------------------------
        '        '   AGREGAR DATATBLES Y UDS PARA MANEJO DE INFORMACION DEL PROYECTO
        '        '--------------------------------------------------------------------------------------

        '        If Not oFunciones.UserDataSourceExists(oForm, "UDS_CFLPRO") Then
        '            Try
        '                oUDataSource = oForm.DataSources.UserDataSources.Add("UDS_CFLPRO", SAPbouiCOM.BoDataType.dt_LONG_TEXT)
        '            Catch ex As Exception

        '            End Try
        '        End If

        '        If Not oFunciones.DataTableExists(oForm, "DT_INFOPRO") Then
        '            Try
        '                oUDataTable = oForm.DataSources.DataTables.Add("DT_INFOPRO")
        '                Dim query As String = " EXEC [SBO_COMERCIAL].[dbo].[SP_Consultar_Datos_Proyecto] N''"
        '                oUDataTable.ExecuteQuery(query)

        '            Catch ex As Exception

        '            End Try
        '        End If


        '        '--------------------------------------------------------------------------------------
        '        '   AGREGAR BOTON EN FORMULARIO DE PEDIDOS PARA REGISTRAR NUEVO PROYECTO
        '        '--------------------------------------------------------------------------------------
        '        If Not oFunciones.ItemExists(oForm, "btnNewProy") Then
        '            oNewItem = oForm.Items.Add("btnNewProy", SAPbouiCOM.BoFormItemTypes.it_BUTTON)
        '            oNewItem.Height = 19 'oItem.Height 'same height
        '            oNewItem.Width = 131 'oItem.Width 'same width
        '            oNewItem.Top = 303 'oItem.Top 'same top
        '            oNewItem.Left = 427 'oItem.Left + 70 'add to the left so its positioned next to Cancel
        '            oNewItem.FromPane = 7
        '            oNewItem.ToPane = 7
        '            oNewItem.AffectsFormMode = False
        '            oButton = oNewItem.Specific
        '            oButton.Caption = "Nuevo Proyecto"
        '        End If
        '        '-----------------------------------------------------------------------------------------------
        '        '    EDITS Y LABELS EN FORMULARIO PARA VISUALIZAR CODIGO Y NOMBRE DE PROYECTO Y FECHA PROMETIDA
        '        '-----------------------------------------------------------------------------------------------
        '        If Not oFunciones.ItemExists(oForm, "edCodPro") Then
        '            oNewItem = oForm.Items.Add("edCodPro", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 137
        '            oNewItem.Top = 95
        '            oNewItem.Left = 427
        '            oNewItem.FromPane = 0
        '            oNewItem.ToPane = 0
        '            oNewItem.AffectsFormMode = False
        '            oedit = oNewItem.Specific
        '            oedit.Value = ""
        '            oFunciones.AgregarUserDataSource(oForm, "UDS_Edit", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
        '            oedit.DataBind.SetBound(True, "", "UDS_Edit")
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "edNomPro") Then
        '            oNewItem = oForm.Items.Add("edNomPro", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 160
        '            oNewItem.Top = 110
        '            oNewItem.Left = 404
        '            oNewItem.FromPane = 0
        '            oNewItem.ToPane = 0
        '            oNewItem.AffectsFormMode = False
        '            oedit = oNewItem.Specific
        '            oedit.Value = ""
        '            oFunciones.AgregarUserDataSource(oForm, "UDS_Edit2", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
        '            oedit.DataBind.SetBound(True, "", "UDS_Edit2")
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "edFecPro") Then
        '            oNewItem = oForm.Items.Add("edFecPro", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 137
        '            oNewItem.Top = 80
        '            oNewItem.Left = 427
        '            oNewItem.FromPane = 0
        '            oNewItem.ToPane = 0
        '            oNewItem.AffectsFormMode = False
        '            oedit = oNewItem.Specific
        '            oedit.Value = ""
        '            oFunciones.AgregarUserDataSource(oForm, "UDS_Edit3", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
        '            oedit.DataBind.SetBound(True, "", "UDS_Edit3")
        '        End If


        '        '-------------------- LABELS
        '        If Not oFunciones.ItemExists(oForm, "NewStatic") Then
        '            oNewItem = oForm.Items.Add("NewStatic", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 118
        '            oNewItem.Top = 95
        '            oNewItem.Left = 307
        '            oNewItem.FromPane = 0
        '            oNewItem.ToPane = 0
        '            oNewItem.AffectsFormMode = False
        '            oStatic = oNewItem.Specific
        '            oStatic.Caption = "Codigo del Proyecto"
        '            oStatic.Item.LinkTo = "edCodPro"
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "NewStatic2") Then
        '            oNewItem = oForm.Items.Add("NewStatic2", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 95
        '            oNewItem.Top = 110
        '            oNewItem.Left = 307
        '            oNewItem.FromPane = 0
        '            oNewItem.ToPane = 0
        '            oNewItem.AffectsFormMode = False
        '            oStatic = oNewItem.Specific
        '            oStatic.Caption = "Nombre Proyecto"
        '            oStatic.Item.LinkTo = "edNomPro"
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "NewStatic3") Then
        '            oNewItem = oForm.Items.Add("NewStatic3", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 120
        '            oNewItem.Top = 80
        '            oNewItem.Left = 307
        '            oNewItem.FromPane = 0
        '            oNewItem.ToPane = 0
        '            oNewItem.AffectsFormMode = False
        '            oStatic = oNewItem.Specific
        '            oStatic.Caption = "Fecha Promesa Proyecto"
        '            oStatic.Item.LinkTo = "edFecPro"
        '        End If

        '        '-----------------------------------------------------------------------------------------------
        '        '    EDITS Y LABELS EN FORMULARIO PARA VISUALIZAR TOTAL KILOS DE PEDIDO
        '        '-----------------------------------------------------------------------------------------------
        '        If Not oFunciones.UserDataSourceExists(oForm, "UD_Kilos") Then
        '            oUDataSource = oForm.DataSources.UserDataSources.Add("UD_Kilos", SAPbouiCOM.BoDataType.dt_QUANTITY)
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "edKilosTot") Then
        '            oNewItem = oForm.Items.Add("edKilosTot", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 110
        '            oNewItem.Top = 350
        '            oNewItem.Left = 427
        '            oNewItem.FromPane = 1
        '            oNewItem.ToPane = 1
        '            oNewItem.AffectsFormMode = False
        '            oNewItem.Enabled = False
        '            oedit = oNewItem.Specific
        '            oedit.Value = ""
        '            oedit.Item.RightJustified = True
        '            oedit.DataBind.SetBound(True, "", "UD_Kilos")
        '        End If

        '        '-------------------- LABELS
        '        If Not oFunciones.ItemExists(oForm, "StaticP11") Then
        '            oNewItem = oForm.Items.Add("StaticP11", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 100
        '            oNewItem.Top = 350
        '            oNewItem.Left = 307
        '            oNewItem.FromPane = 1
        '            oNewItem.ToPane = 1
        '            oNewItem.AffectsFormMode = False
        '            oStatic = oNewItem.Specific
        '            oStatic.Caption = "Total Kilos Pedido:"
        '            oStatic.Item.LinkTo = "edKilosTot"
        '        End If


        '        'Agregar_Tabs_Pedidos()

        '        '--------------------------------------------------------------------------------------
        '        '    EDITS Y LABELS EN FORMULARIO PARA VISUALIZAR CAMPOS DE FECHA Y MULTA DEL PROYECTO
        '        '--------------------------------------------------------------------------------------

        '        If Not oFunciones.ItemExists(oForm, "edFTD") Then
        '            oNewItem = oForm.Items.Add("edFTD", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 140
        '            oNewItem.Top = 170
        '            oNewItem.Left = 280
        '            oNewItem.FromPane = 16
        '            oNewItem.ToPane = 16
        '            oNewItem.AffectsFormMode = False
        '            oNewItem.Enabled = False
        '            oedit = oNewItem.Specific
        '            oedit.Value = ""
        '            oFunciones.AgregarUserDataSource(oForm, "UDS_Proy1", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
        '            oedit.DataBind.SetBound(True, "", "UDS_Proy1")
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "edFTP") Then
        '            oNewItem = oForm.Items.Add("edFTP", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 140
        '            oNewItem.Top = 185
        '            oNewItem.Left = 280
        '            oNewItem.FromPane = 16
        '            oNewItem.ToPane = 16
        '            oNewItem.AffectsFormMode = False
        '            oNewItem.Enabled = False
        '            oedit = oNewItem.Specific
        '            oedit.Value = ""
        '            oFunciones.AgregarUserDataSource(oForm, "UDS_Proy2", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
        '            oedit.DataBind.SetBound(True, "", "UDS_Proy2")
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "edFID") Then
        '            oNewItem = oForm.Items.Add("edFID", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 140
        '            oNewItem.Top = 200
        '            oNewItem.Left = 280
        '            oNewItem.FromPane = 16
        '            oNewItem.ToPane = 16
        '            oNewItem.AffectsFormMode = False
        '            oNewItem.Enabled = False
        '            oedit = oNewItem.Specific
        '            oedit.Value = ""
        '            oFunciones.AgregarUserDataSource(oForm, "UDS_Proy3", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
        '            oedit.DataBind.SetBound(True, "", "UDS_Proy3")
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "edFIMo") Then
        '            oNewItem = oForm.Items.Add("edFIMo", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 140
        '            oNewItem.Top = 215
        '            oNewItem.Left = 280
        '            oNewItem.FromPane = 16
        '            oNewItem.ToPane = 16
        '            oNewItem.AffectsFormMode = False
        '            oNewItem.Enabled = False
        '            oedit = oNewItem.Specific
        '            oedit.Value = ""
        '            oFunciones.AgregarUserDataSource(oForm, "UDS_Proy4", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
        '            oedit.DataBind.SetBound(True, "", "UDS_Proy4")
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "edFTMo") Then
        '            oNewItem = oForm.Items.Add("edFTMo", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 140
        '            oNewItem.Top = 230
        '            oNewItem.Left = 280
        '            oNewItem.FromPane = 16
        '            oNewItem.ToPane = 16
        '            oNewItem.AffectsFormMode = False
        '            oNewItem.Enabled = False
        '            oedit = oNewItem.Specific
        '            oedit.Value = ""
        '            oFunciones.AgregarUserDataSource(oForm, "UDS_Proy5", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
        '            oedit.DataBind.SetBound(True, "", "UDS_Proy5")
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "edFPCl") Then
        '            oNewItem = oForm.Items.Add("edFPCl", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 140
        '            oNewItem.Top = 245
        '            oNewItem.Left = 280
        '            oNewItem.FromPane = 16
        '            oNewItem.ToPane = 16
        '            oNewItem.AffectsFormMode = False
        '            oNewItem.Enabled = False
        '            oedit = oNewItem.Specific
        '            oedit.Value = ""
        '            oFunciones.AgregarUserDataSource(oForm, "UDS_Proy5A", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
        '            oedit.DataBind.SetBound(True, "", "UDS_Proy5A")
        '        End If

        '        '-------------------------------------------------------------------------------

        '        If Not oFunciones.ItemExists(oForm, "edMulta") Then
        '            oNewItem = oForm.Items.Add("edMulta", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 50
        '            oNewItem.Top = 170
        '            oNewItem.Left = 400
        '            oNewItem.FromPane = 16
        '            oNewItem.ToPane = 16
        '            oNewItem.AffectsFormMode = False
        '            oNewItem.Enabled = False
        '            oedit = oNewItem.Specific
        '            oedit.Value = ""
        '            oFunciones.AgregarUserDataSource(oForm, "UDS_Proy6", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
        '            oedit.DataBind.SetBound(True, "", "UDS_Proy6")
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "edMulD") Then
        '            oNewItem = oForm.Items.Add("edMulD", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 50
        '            oNewItem.Top = 185
        '            oNewItem.Left = 400
        '            oNewItem.FromPane = 16
        '            oNewItem.ToPane = 16
        '            oNewItem.AffectsFormMode = False
        '            oNewItem.Enabled = False
        '            oedit = oNewItem.Specific
        '            oedit.Value = ""
        '            oFunciones.AgregarUserDataSource(oForm, "UDS_Proy7", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
        '            oedit.DataBind.SetBound(True, "", "UDS_Proy7")
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "edMulMo") Then
        '            oNewItem = oForm.Items.Add("edMulMo", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 50
        '            oNewItem.Top = 200
        '            oNewItem.Left = 400
        '            oNewItem.FromPane = 16
        '            oNewItem.ToPane = 16
        '            oNewItem.AffectsFormMode = False
        '            oNewItem.Enabled = False
        '            oedit = oNewItem.Specific
        '            oedit.Value = ""
        '            oFunciones.AgregarUserDataSource(oForm, "UDS_Proy8", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
        '            oedit.DataBind.SetBound(True, "", "UDS_Proy8")
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "edFrecMul") Then
        '            oNewItem = oForm.Items.Add("edFrecMul", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 160
        '            oNewItem.Top = 215
        '            oNewItem.Left = 400
        '            oNewItem.FromPane = 16
        '            oNewItem.ToPane = 16
        '            oNewItem.AffectsFormMode = False
        '            oNewItem.Enabled = False
        '            oedit = oNewItem.Specific
        '            oedit.Value = ""
        '            oFunciones.AgregarUserDataSource(oForm, "UDS_Proy9", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
        '            oedit.DataBind.SetBound(True, "", "UDS_Proy9")
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "edComMul") Then
        '            oNewItem = oForm.Items.Add("edComMul", SAPbouiCOM.BoFormItemTypes.it_EXTEDIT)
        '            oNewItem.Height = 42
        '            oNewItem.Width = 160
        '            oNewItem.Top = 230
        '            oNewItem.Left = 400
        '            oNewItem.FromPane = 16
        '            oNewItem.ToPane = 16
        '            oNewItem.AffectsFormMode = False
        '            oNewItem.Enabled = False
        '            oExtEdit = oNewItem.Specific
        '            oExtEdit.Value = ""
        '            oFunciones.AgregarUserDataSource(oForm, "UDS_Proy10", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
        '            oedit.DataBind.SetBound(True, "", "UDS_Proy10")
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "edNumCont") Then
        '            oNewItem = oForm.Items.Add("edNumCont", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 160
        '            oNewItem.Top = 273
        '            oNewItem.Left = 400
        '            oNewItem.FromPane = 16
        '            oNewItem.ToPane = 16
        '            oNewItem.AffectsFormMode = False
        '            oNewItem.Enabled = False
        '            oedit = oNewItem.Specific
        '            oedit.Value = ""
        '            oFunciones.AgregarUserDataSource(oForm, "UDS_Proy12", SAPbouiCOM.BoDataType.dt_LONG_TEXT, 256)
        '            oedit.DataBind.SetBound(True, "", "UDS_Proy12")
        '        End If

        '        '-------------------- LABELS
        '        If Not oFunciones.ItemExists(oForm, "StaticP1") Then
        '            oNewItem = oForm.Items.Add("StaticP1", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 170
        '            oNewItem.Top = 170
        '            oNewItem.Left = 60
        '            oNewItem.FromPane = 16
        '            oNewItem.ToPane = 16
        '            oNewItem.AffectsFormMode = False
        '            oStatic = oNewItem.Specific
        '            oStatic.Caption = "Fecha Termino Desarrollo Sugerida:"
        '            oStatic.Item.LinkTo = "edFTD"
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "StaticP2") Then
        '            oNewItem = oForm.Items.Add("StaticP2", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 170
        '            oNewItem.Top = 185
        '            oNewItem.Left = 60
        '            oNewItem.FromPane = 16
        '            oNewItem.ToPane = 16
        '            oNewItem.AffectsFormMode = False
        '            oStatic = oNewItem.Specific
        '            oStatic.Caption = "Fecha Termino Produccion Sugerida:"
        '            oStatic.Item.LinkTo = "edFTP"
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "StaticP3") Then
        '            oNewItem = oForm.Items.Add("StaticP3", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 170
        '            oNewItem.Top = 200
        '            oNewItem.Left = 60
        '            oNewItem.FromPane = 16
        '            oNewItem.ToPane = 16
        '            oNewItem.AffectsFormMode = False
        '            oStatic = oNewItem.Specific
        '            oStatic.Caption = "Fecha Inicio Despacho Sugerida:"
        '            oStatic.Item.LinkTo = "edFID"
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "StaticP4") Then
        '            oNewItem = oForm.Items.Add("StaticP4", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 170
        '            oNewItem.Top = 215
        '            oNewItem.Left = 60
        '            oNewItem.FromPane = 16
        '            oNewItem.ToPane = 16
        '            oNewItem.AffectsFormMode = False
        '            oStatic = oNewItem.Specific
        '            oStatic.Caption = "Fecha Inicio Montaje Sugerida:"
        '            oStatic.Item.LinkTo = "edFIMo"
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "StaticP5") Then
        '            oNewItem = oForm.Items.Add("StaticP5", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 170
        '            oNewItem.Top = 230
        '            oNewItem.Left = 60
        '            oNewItem.FromPane = 16
        '            oNewItem.ToPane = 16
        '            oNewItem.AffectsFormMode = False
        '            oStatic = oNewItem.Specific
        '            oStatic.Caption = "Fecha Termino Montaje Sugerida:"
        '            oStatic.Item.LinkTo = "edFTMo"
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "StaticP5A") Then
        '            oNewItem = oForm.Items.Add("StaticP5A", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 170
        '            oNewItem.Top = 245
        '            oNewItem.Left = 60
        '            oNewItem.FromPane = 16
        '            oNewItem.ToPane = 16
        '            oNewItem.AffectsFormMode = False
        '            oStatic = oNewItem.Specific
        '            oStatic.Caption = "Fecha Vigente Prometida al Cliente:"
        '            oStatic.Item.LinkTo = "edFPCl"
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "StaticP6") Then
        '            oNewItem = oForm.Items.Add("StaticP6", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 100
        '            oNewItem.Top = 170
        '            oNewItem.Left = 285
        '            oNewItem.FromPane = 16
        '            oNewItem.ToPane = 16
        '            oNewItem.AffectsFormMode = False
        '            oStatic = oNewItem.Specific
        '            oStatic.Caption = "Tiene Multa:"
        '            oStatic.Item.LinkTo = "edMulta"
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "StaticP7") Then
        '            oNewItem = oForm.Items.Add("StaticP7", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 100
        '            oNewItem.Top = 185
        '            oNewItem.Left = 285
        '            oNewItem.FromPane = 16
        '            oNewItem.ToPane = 16
        '            oNewItem.AffectsFormMode = False
        '            oStatic = oNewItem.Specific
        '            oStatic.Caption = "Multa por Despacho:"
        '            oStatic.Item.LinkTo = "edMulD"
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "StaticP8") Then
        '            oNewItem = oForm.Items.Add("StaticP8", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 100
        '            oNewItem.Top = 200
        '            oNewItem.Left = 285
        '            oNewItem.FromPane = 16
        '            oNewItem.ToPane = 16
        '            oNewItem.AffectsFormMode = False
        '            oStatic = oNewItem.Specific
        '            oStatic.Caption = "Multa por Montaje:"
        '            oStatic.Item.LinkTo = "edMulMo"
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "StaticP9") Then
        '            oNewItem = oForm.Items.Add("StaticP9", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 100
        '            oNewItem.Top = 215
        '            oNewItem.Left = 285
        '            oNewItem.FromPane = 16
        '            oNewItem.ToPane = 16
        '            oNewItem.AffectsFormMode = False
        '            oStatic = oNewItem.Specific
        '            oStatic.Caption = "Frecuencia:"
        '            oStatic.Item.LinkTo = "edFrecMul"
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "StaticP10") Then
        '            oNewItem = oForm.Items.Add("StaticP10", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 100
        '            oNewItem.Top = 230
        '            oNewItem.Left = 285
        '            oNewItem.FromPane = 16
        '            oNewItem.ToPane = 16
        '            oNewItem.AffectsFormMode = False
        '            oStatic = oNewItem.Specific
        '            oStatic.Caption = "Comentario Multa:"
        '            oStatic.Item.LinkTo = "edComMul"
        '        End If

        '        If Not oFunciones.ItemExists(oForm, "StaticP12") Then
        '            oNewItem = oForm.Items.Add("StaticP12", SAPbouiCOM.BoFormItemTypes.it_STATIC)
        '            oNewItem.Height = 14
        '            oNewItem.Width = 100
        '            oNewItem.Top = 273
        '            oNewItem.Left = 285
        '            oNewItem.FromPane = 16
        '            oNewItem.ToPane = 16
        '            oNewItem.AffectsFormMode = False
        '            oStatic = oNewItem.Specific
        '            oStatic.Caption = "N° Contrato Cliente:"
        '            oStatic.Item.LinkTo = "edNumCont"
        '        End If


        '        '--------------------------------------------------------------------------------------
        '        '    CREACION DE LA MATRIX PARA EL MANEJO DE PLANOS
        '        '--------------------------------------------------------------------------------------
        '        If Not oFunciones.ItemExists(oForm, "MtxPlanos") Then
        '            oNewItem = oForm.Items.Add("MtxPlanos", SAPbouiCOM.BoFormItemTypes.it_MATRIX)
        '            oNewItem.Height = 172
        '            oNewItem.Width = 200
        '            oNewItem.Top = 173
        '            oNewItem.Left = 16

        '            oNewItem.FromPane = 15
        '            oNewItem.ToPane = 15
        '            oNewItem.AffectsFormMode = False

        '            oMatrix = oNewItem.Specific
        '            oMatrix.Item.Enabled = True

        '            '//***********************************
        '            '// Agregar Columnas a Matrix
        '            '//***********************************
        '            oColumns = oMatrix.Columns

        '            oColumn = oColumns.Add("#", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        '            oColumn.TitleObject.Caption = "#"
        '            oColumn.Width = 30
        '            oColumn.Editable = False

        '            '// Add a column for Ruta
        '            oColumn = oColumns.Add("Ruta_Doc", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        '            oColumn.TitleObject.Caption = "Archivo de Plano"
        '            oColumn.Width = 500
        '            oColumn.Editable = False

        '            '// Add a column for BP Card Phone
        '            oColumn = oColumns.Add("Fec_Reg", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        '            oColumn.TitleObject.Caption = "Fecha Registro"
        '            oColumn.Width = 100
        '            oColumn.Editable = False

        '            '// Add a column for BP Card Phone
        '            oColumn = oColumns.Add("Estado", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        '            oColumn.TitleObject.Caption = "Condicion"
        '            oColumn.Width = 200
        '            oColumn.Editable = False

        '            '// Add a column for BP Card Phone
        '            oColumn = oColumns.Add("Destino", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        '            oColumn.TitleObject.Caption = "Destino"
        '            oColumn.Width = 200
        '            oColumn.Editable = False


        '            '// Agregar el Data Table para manejar la data sobre la Matrix
        '            oUDataTable = oForm.DataSources.DataTables.Add("DT_Planos")


        '            'oMatrix.Clear()
        '            'oMatrix.AutoResizeColumns()

        '            oForm.PaneLevel = 1  'Retorna el Focus a la primera TAB

        '        End If

        '        '--------------------------------------------------------------------------------------
        '        '    CREACION DE LA MATRIX PARA MOSTRAR DOCUMENTOS DEL PROYECTO
        '        '--------------------------------------------------------------------------------------
        '        If Not oFunciones.ItemExists(oForm, "MtxDocPro") Then
        '            oNewItem = oForm.Items.Add("MtxDocPro", SAPbouiCOM.BoFormItemTypes.it_MATRIX)
        '            oNewItem.Height = 172
        '            oNewItem.Width = 200
        '            oNewItem.Top = 173
        '            oNewItem.Left = 16

        '            oNewItem.FromPane = 17
        '            oNewItem.ToPane = 17
        '            oNewItem.AffectsFormMode = False

        '            oMatrix = oNewItem.Specific
        '            oMatrix.Item.Enabled = True

        '            '//***********************************
        '            '// Agregar Columnas a Matrix
        '            '//***********************************
        '            oColumns = oMatrix.Columns

        '            oColumn = oColumns.Add("#", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        '            oColumn.TitleObject.Caption = "#"
        '            oColumn.Width = 30
        '            oColumn.Editable = False

        '            '// Add a column for Ruta
        '            oColumn = oColumns.Add("Ruta_Doc", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        '            oColumn.TitleObject.Caption = "Archivo de Documento"
        '            oColumn.Width = 300
        '            oColumn.Editable = False

        '            '// Add a column for BP Card Phone
        '            oColumn = oColumns.Add("Fec_Reg", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        '            oColumn.TitleObject.Caption = "Fecha Registro"
        '            oColumn.Width = 100
        '            oColumn.Editable = False

        '            '// Add a column for BP Card Phone
        '            oColumn = oColumns.Add("Comentario", SAPbouiCOM.BoFormItemTypes.it_EDIT)
        '            oColumn.TitleObject.Caption = "Comentario"
        '            oColumn.Width = 500
        '            oColumn.Editable = False


        '            '// Agregar el Data Table para manejar la data sobre la Matrix
        '            oUDataTable = oForm.DataSources.DataTables.Add("DT_DocuPro")


        '            'oMatrix.Clear()
        '            'oMatrix.AutoResizeColumns()

        '            oForm.PaneLevel = 1  'Retorna el Focus a la primera TAB

        '        End If

        '    Catch ex As Exception

        '    End Try


        'End Sub
        'If pVal.FormTypeEx = "139" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_FORM_LOAD And pVal.BeforeAction = False Then

        '    Dim m_menus As SAPbouiCOM.Menus = Application.SBO_Application.Menus
        '    Dim m_menuItem As SAPbouiCOM.MenuItem = m_menus.Item("6913")
        '    If m_menuItem.Checked = False Then
        '        'Application.SBO_Application.ActivateMenuItem("6913")
        '        Application.SBO_Application.SendKeys("^(+U)")
        '    End If

        '    'Try  'Carga los UDF en la ventana lateral de campos, si no esta abierta, se abre por menu

        '    '    oForm = Application.SBO_Application.Forms.GetForm("-139", 0)

        '    'Catch ex As Exception

        '    '    'Application.SBO_Application.ActivateMenuItem("6913")
        '    '    Application.SBO_Application.SendKeys("^(+U)")
        '    '    'Application.SBO_Application.Forms.Item("-139").Select()
        '    '    'oForm = Application.SBO_Application.Forms.GetForm("-139", 0)

        '    'End Try
        'End If

#End Region

    End Module
End Namespace