Option Strict Off
Option Explicit On

'Imports System.Runtime.InteropServices.Marshal
Imports SAPbouiCOM.Framework

Namespace SBOAddonProject1
    <FormAttribute("SBOAddonProject1.Form_PlanifMontajes", "3_Presentation_Layer/Pantallas Principales/FrmGestion_Montajes.b1f")>
    Friend Class Form_PlanifMontajes
        Inherits UserFormBase

        Private oForm As SAPbouiCOM.Form
        Private Col_DatAnt As String
        Private TomadoPorCbx As Boolean = False
        Private oProgBar As SAPbouiCOM.ProgressBar

        Private ColProjecto As Integer
        Private ColPrjNombre As Integer
        Private ColMulta As Integer
        Private ColFecIniMont As Integer
        Private ColFecTerMont As Integer
        Private ColDiasDisp As Integer
        Private ColIdEstado As Integer
        Private ColVend As Integer
        Private ColIdSuperv As Integer
        Private ColPInd As Integer
        Private ColPDesp As Integer
        Private ColIdMont As Integer
        Private ColDesEst As Integer
        Private ColPPCI As Integer
        Private ColFecRecep As Integer

        Public Sub New()
        End Sub

        Public Overrides Sub OnInitializeComponent()
            Me.DT_Sql_Pro = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_Sql_Pro")
            Me.DTSqlProR = Me.UIAPIRawForm.DataSources.DataTables.Item("DTSqlProR")
            Me.DT_Estado = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_Estado")
            Me.DT_Superv = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_Superv")
            Me.DT_JProy = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_JProy")
            Me.DT_Produ = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_Produ")
            Me.DT_Monta = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_Monta")
            Me.DT_SQL1 = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_SQL1")
            Me.Button0 = CType(Me.GetItem("Item_1").Specific, SAPbouiCOM.Button)
            Me.Edt_Estado = CType(Me.GetItem("Item_2").Specific, SAPbouiCOM.EditText)
            Me.Folder0 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.Folder)
            Me.Button1 = CType(Me.GetItem("Item_5").Specific, SAPbouiCOM.Button)
            Me.Button2 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.Button)
            Me.Button3 = CType(Me.GetItem("Item_7").Specific, SAPbouiCOM.Button)
            Me.EditText0 = CType(Me.GetItem("Item_8").Specific, SAPbouiCOM.EditText)
            Me.Button4 = CType(Me.GetItem("Item_9").Specific, SAPbouiCOM.Button)
            Me.UD_Row = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_Row")
            Me.UD_Col = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_Col")
            Me.StaticText0 = CType(Me.GetItem("Item_10").Specific, SAPbouiCOM.StaticText)
            Me.Grd_PlanifMont = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.Grid)
            Me.Grd_PlanifMont.Item.FromPane = 1
            Me.Grd_PlanifMont.Item.ToPane = 1
            Me.Grd_PlanifMont.Item.Visible = True
            Me.OnCustomInitialize()


        End Sub

        Public Overrides Sub OnInitializeFormEvents()
            AddHandler ResizeAfter, AddressOf Me.Form_PlanifMontajes_ResizeAfter
            AddHandler ResizeAfter, AddressOf Me.Form_PlanifMontajes_ResizeAfter

        End Sub

        Private Sub OnCustomInitialize()

            oForm = Application.SBO_Application.Forms.Item(Me.UIAPIRawForm.UniqueID)
            Me.Edt_Estado.Item.Visible = True
            Me.Button4.Item.Visible = False
            Call Cargar_Grid_Gestion_Montajes(Button1.Caption, "")

        End Sub

        Private Sub Form_PlanifMontajes_ResizeAfter(pVal As SAPbouiCOM.SBOItemEventArg) Handles Me.ResizeAfter

            oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
            oItem = oForm.Items.Item("Item_3")
            oItem.Top = 15
            oItem.Left = 16
            oItem.Height = oForm.Height - 88
            oItem.Width = oForm.Width - 52
            Me.Grd_PlanifMont.AutoResizeColumns()
            Me.Grd_PlanifMont.Item.Width = oItem.Width - 36
            Me.Grd_PlanifMont.Item.Height = oItem.Height - 40

        End Sub

        Private Sub Grd_PlanifMont_ComboSelectBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles Grd_PlanifMont.ComboSelectBefore
            Dim dtRow As Integer = Grd_PlanifMont.GetDataTableRowIndex(pVal.Row)
            Col_DatAnt = Grd_PlanifMont.DataTable.GetValue(pVal.ColUID, dtRow).ToString()
            TomadoPorCbx = True
        End Sub

        Private Sub Grd_PlanifMont_GotFocusAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grd_PlanifMont.GotFocusAfter
            If TomadoPorCbx = False Then
                Dim dtRow As Integer = Grd_PlanifMont.GetDataTableRowIndex(pVal.Row)
                Col_DatAnt = Grd_PlanifMont.DataTable.GetValue(pVal.ColUID, dtRow)
            End If
            TomadoPorCbx = False
        End Sub

        Private Sub Grd_PlanifMont_ValidateBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles Grd_PlanifMont.ValidateBefore
            Funciones.FreezeForm(oForm, True)
            If Grd_PlanifMont.DataTable.GetValue(pVal.ColUID, pVal.Row) <> Col_DatAnt Then DT_Sql_Pro.SetValue("Modif", pVal.Row, "Y")
            ActualizaProyecto(pVal.Row, pVal.ColUID)
            Funciones.FreezeForm(oForm, False)
        End Sub

        Private Sub Grd_PlanifMont_PickerClickedBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles Grd_PlanifMont.PickerClickedBefore
            'Cuando la fecha es menor al Año 2015
            Funciones.FreezeForm(oForm, True)
            Try
                Dim dtRow As Integer = Grd_PlanifMont.GetDataTableRowIndex(pVal.Row)
                If cuantos(Grd_PlanifMont.DataTable.GetValue(pVal.ColUID, dtRow), "-") = 2 Then 'Campo fecha
                    Dim iDate As Integer = CDate(Grd_PlanifMont.DataTable.GetValue(pVal.ColUID, dtRow)).ToOADate
                    If CDate(Grd_PlanifMont.DataTable.GetValue(pVal.ColUID, dtRow)).ToOADate < 42000 Then '2015
                        DT_Sql_Pro.SetValue(pVal.ColUID, dtRow, DateTime.Now.ToString("yyyyMMdd"))
                        Col_DatAnt = Grd_PlanifMont.DataTable.GetValue(pVal.ColUID, dtRow)
                    End If
                End If
            Catch ex As Exception
                Application.SBO_Application.StatusBar.SetText(ex.Message)
            Finally
                Me.Edt_Estado.Item.Visible = False
                Funciones.FreezeForm(oForm, False)
            End Try
        End Sub

        Private Sub Grd_PlanifMont_ComboSelectAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grd_PlanifMont.ComboSelectAfter

            Dim nRow = Me.Grd_PlanifMont.GetDataTableRowIndex(pVal.Row)
            Dim bGuardar As Boolean = True

            Try
                Funciones.FreezeForm(oForm, True)

                'Cambia Color de Row si Esta "En Proceso"
                If pVal.ColUID = "Desc.Est." Then
                    Select Case oCmbx05.GetSelectedValue(pVal.Row).Description
                        Case "3"
                            Me.Grd_PlanifMont.CommonSetting.SetRowBackColor(pVal.Row + 1, RGB(250, 250, 210))
                            Call Porc_Industrial_BackColor(pVal.Row)
                            Call Dias_Disponibles_BackColor(pVal.Row)
                        Case "7"
                            bGuardar = False
                            Asignar_Documento(DT_Sql_Pro.GetValue(0, nRow).ToString(), "Recepcion")
                            'Me.Grd_PlanifMont.CommonSetting.SetRowBackColor(pVal.Row + 1, RGB(250, 250, 250))
                            'Grid_Row_BackColor(pVal.Row)
                            'Me.Grd_PlanifMont.CommonSetting.SetCellBackColor(pVal.Row + 1, 6, RGB(240, 128, 128))
                        Case "8"
                            Me.Grd_PlanifMont.CommonSetting.SetRowBackColor(pVal.Row + 1, RGB(250, 250, 250))
                            Grid_Row_BackColor(pVal.Row)
                            Me.Grd_PlanifMont.CommonSetting.SetCellBackColor(pVal.Row + 1, 6, RGB(240, 128, 128))
                        Case "9"
                            Me.Grd_PlanifMont.CommonSetting.SetRowBackColor(pVal.Row + 1, RGB(250, 250, 250))
                            Grid_Row_BackColor(pVal.Row)
                            Me.Grd_PlanifMont.CommonSetting.SetCellBackColor(pVal.Row + 1, 6, RGB(240, 128, 128))
                        Case "10"
                            Me.Grd_PlanifMont.CommonSetting.SetRowBackColor(pVal.Row + 1, RGB(250, 250, 250))
                            Grid_Row_BackColor(pVal.Row)
                            Me.Grd_PlanifMont.CommonSetting.SetCellBackColor(pVal.Row + 1, 6, RGB(240, 128, 128))
                        Case "11"
                            Me.Grd_PlanifMont.CommonSetting.SetRowBackColor(pVal.Row + 1, RGB(250, 250, 250))
                            Grid_Row_BackColor(pVal.Row)
                            Me.Grd_PlanifMont.CommonSetting.SetCellBackColor(pVal.Row + 1, 6, RGB(240, 128, 128))
                        Case "12"
                            Me.Grd_PlanifMont.CommonSetting.SetRowBackColor(pVal.Row + 1, RGB(250, 250, 250))
                            Grid_Row_BackColor(pVal.Row)
                            Me.Grd_PlanifMont.CommonSetting.SetCellBackColor(pVal.Row + 1, 6, RGB(240, 128, 128))
                        Case Else
                            Me.Grd_PlanifMont.CommonSetting.SetRowBackColor(pVal.Row + 1, RGB(250, 250, 250))
                            Grid_Row_BackColor(pVal.Row)
                    End Select

                End If
                'Dim x As String = oCmbxSuperv.GetSelectedValue(nRow).Description
                Dim Paso As String = Grd_PlanifMont.DataTable.GetValue(pVal.ColUID, nRow).ToString()
                If Grd_PlanifMont.DataTable.GetValue(pVal.ColUID, nRow).ToString() <> Col_DatAnt Then
                    If pVal.ColUID = "Desc.Est." Then
                        If oCmbx05.GetSelectedValue(pVal.Row).Description <> 7 Then
                            DT_Sql_Pro.SetValue("IdEstado", nRow, oCmbx05.GetSelectedValue(pVal.Row).Description)
                        Else
                            Grd_PlanifMont.DataTable.SetValue(pVal.ColUID, nRow, Col_DatAnt)
                        End If
                        'DT_Sql_Pro.SetValue("Fec.Estado", nRow, DateTime.Now)
                    End If
                    If pVal.ColUID = "Supervisor" Then
                        DT_Sql_Pro.SetValue("IdSuperv", nRow, oCmbxSuperv.GetSelectedValue(pVal.Row).Description)
                    End If
                    If pVal.ColUID = "Jefe.Proy." Then
                        DT_Sql_Pro.SetValue("IdJefe", nRow, oCmbxJefe.GetSelectedValue(pVal.Row).Description)
                    End If
                    If pVal.ColUID = "Producto" Then
                        DT_Sql_Pro.SetValue("IdProd", nRow, oCmbxProd.GetSelectedValue(pVal.Row).Description)
                    End If
                    If pVal.ColUID = "Eq.Mont" Then
                        DT_Sql_Pro.GetValue("IdMont", nRow).ToString()
                        DT_Sql_Pro.SetValue("IdMont", nRow, oCmbxMont.GetSelectedValue(pVal.Row).Description)
                    End If
                    DT_Sql_Pro.SetValue("Modif", nRow, "Y")
                End If
            Catch ex As Exception
                Application.SBO_Application.StatusBar.SetText(ex.Message)
            Finally
                If bGuardar Then
                    ActualizaProyecto(pVal.Row, pVal.ColUID)
                End If
                Funciones.FreezeForm(oForm, False)
            End Try

        End Sub

        Private Sub Button0_ClickBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles Button0.ClickBefore
            Try
                Me.UIAPIRawForm.Close()
            Catch ex As Exception
            End Try
        End Sub

        Private Sub Grd_PlanifMont_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grd_PlanifMont.ClickAfter

            Try
                Grd_PlanifMont.Rows.SelectedRows.Add(pVal.Row)
                UD_Row.ValueEx = pVal.Row
            Catch ex As Exception
            End Try

        End Sub

        Private Sub Button1_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button1.ClickAfter

            Select Case Button1.Caption
                Case "Solo Recepcionados"
                    Button1.Caption = "Sin Recepcionar"
                    Call Cargar_Grid_Gestion_Montajes(Button1.Caption, "")
                    Grd_PlanifMont.AutoResizeColumns()
                Case "Sin Recepcionar"
                    Button1.Caption = "Solo Recepcionados"
                    Call Cargar_Grid_Gestion_Montajes(Button1.Caption, "")
                    Grd_PlanifMont.AutoResizeColumns()
            End Select

        End Sub


        Private Sub Button2_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button2.ClickAfter

            If Me.EditText0.Value.Trim().Length > 0 Then
                Dim sLike As String = Me.EditText0.Value.ToUpper().Trim()
                Call Cargar_Grid_Gestion_Montajes(Button1.Caption, sLike)
                Me.Grd_PlanifMont.AutoResizeColumns()
            Else
                Call Cargar_Grid_Gestion_Montajes(Button1.Caption, "")
                Me.Grd_PlanifMont.AutoResizeColumns()
            End If
            'Call Cargar_Grid_Gestion_Montajes(Button1.Caption, "")
            'Me.Grd_PlanifMont.AutoResizeColumns()

        End Sub

        Private Sub Button3_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button3.ClickAfter


            If Me.EditText0.Value.Trim().Length > 0 Then
                Dim sLike As String = Me.EditText0.Value.ToUpper().Trim()
                Call Cargar_Grid_Gestion_Montajes(Button1.Caption, sLike)
                Me.Grd_PlanifMont.AutoResizeColumns()
            Else
                Call Cargar_Grid_Gestion_Montajes(Button1.Caption, "")
                Me.Grd_PlanifMont.AutoResizeColumns()
            End If

        End Sub

        Private Sub EditText0_KeyDownAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText0.KeyDownAfter

            Select Case pVal.CharPressed
                Case 13
                    Me.Button2.Item.Click()
            End Select

        End Sub




        Private Sub Button4_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button4.ClickAfter

            Try
                Dim nRow As Integer = Grd_PlanifMont.Rows.SelectedRows.Item(0, SAPbouiCOM.BoOrderType.ot_RowOrder)
                Dim dtRow As Integer = Grd_PlanifMont.GetDataTableRowIndex(nRow)
                'oCmbx05 = Grd_PlanifMont.Columns.Item("Desc.Est.")
                'oCmbx05.SetSelectedValue("7", oCmbx05.ValidValues.Item(1))
                Grd_PlanifMont.DataTable.SetValue("Desc.Est.", dtRow, "Recepcionada")
                DT_Sql_Pro.SetValue("IdEstado", dtRow, "7")
                ActualizaProyecto(nRow, "")
            Catch ex As Exception
            End Try

        End Sub

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '  PROCEDIMIENTOS Y FUNCIONES
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------

        Private Sub ActualizaProyecto(vRow As Integer, vCol As String)

            'Me.Edt_Estado.Item.Visible = True
            'Me.Edt_Estado.String = "Guardando Modificaciones"
            vRow = Me.Grd_PlanifMont.GetDataTableRowIndex(vRow)
            Try
                Funciones.FreezeForm(oForm, True)
                Dim NumProyec As String = DT_Sql_Pro.GetValue("Projecto", vRow)
                Dim Sql_UppDate_Pro As String
                Dim FecIni As String = DT_Sql_Pro.GetValue("Fec.Ini.", vRow)
                Dim FecTer As String = DT_Sql_Pro.GetValue("Fec.Ter.", vRow)
                Dim FecRec As String = DT_Sql_Pro.GetValue("Fec.Recep.", vRow)
                'Actualiza Datos del Proyecto en ZINFOP
                Sql_UppDate_Pro = "UPDATE [" + sBDComercial.Trim() + "].DBO.[@ZINFOP]  Set " &
                                  " U_Estado_M =   '" & DT_Sql_Pro.GetValue("IdEstado", vRow).ToString() & "' " &
                                  ",U_Fec_Estado_M = '" & DateTime.Now.ToString("yyyyMMdd hh:mm") & "'" &
                                  ",U_Cod_SupervM = '" & DT_Sql_Pro.GetValue("IdSuperv", vRow).ToString() & "' " &
                                  ",U_Cod_ProdM = '" & DT_Sql_Pro.GetValue("IdProd", vRow).ToString() & "' " &
                                  ",U_Cat_ProdM = '" & DT_Sql_Pro.GetValue("Posic", vRow).ToString() & "' " &
                                  ",U_Cod_JefeM = '" & DT_Sql_Pro.GetValue("IdJefe", vRow).ToString() & "' " &
                                  ",U_CIudadM = '" & DT_Sql_Pro.GetValue("Ciudad", vRow).ToString() & "'" &
                                  ",U_Cod_MontM = '" & DT_Sql_Pro.GetValue("IdMont", vRow).ToString() & "' " &
                                  ",U_Cant_MontaM = " & DT_Sql_Pro.GetValue("N° Trab.", vRow).ToString() & " " &
                                 ",U_ObservaM = '" & DT_Sql_Pro.GetValue("Observaciones", vRow).ToString() & "' " &
                                 ",U_Fec_Real_Ini_Mon = CONVERT(DATE,'" & FecIni & "',103) " &
                                 ",U_Fec_Real_Fin_Mon = CONVERT(DATE,'" & FecTer & "',103) " &
                                 ",U_Fec_Real_Recep_Mon = CONVERT(DATE,'" & FecRec & "',103) " &
                                 ",U_Cod_MaqM = '" & DT_Sql_Pro.GetValue("Maquina", vRow).ToString() & "' " &
                                  "Where convert(nvarchar(max),U_PrjCode) = '" & NumProyec & "'"
                Try
                    DT_SQL1.ExecuteQuery(Sql_UppDate_Pro)
                Catch ex As Exception
                    Application.SBO_Application.StatusBar.SetText(ex.Message)
                End Try

                'Inserta registro de Historico en ZHFSMON para el proyecto afectado
                'ZHFSMON
                Dim nProx As Integer = oFunciones.Proximo_Codigo_Correlativo("@ZHFSMON", "Code", DT_SQL1)
                sPSql = " INSERT INTO [" + sBDComercial.Trim() + "].[dbo].[@ZHFSMON] " &
                        " ([Code] " &
                        " ,[DocEntry] " &
                        " ,[Object] " &
                        " ,[UserSign] " &
                        " ,[CreateDate] " &
                        " ,[CreateTime] " &
                        " ,[DataSource] " &
                        " ,[U_PrjCode] " &
                        " ,[U_Fec_Ini_Mont] " &
                        " ,[U_Fec_Ter_Mont] " &
                        " ,[U_Cod_Usuario] " &
                        " ,[U_Nom_Usuario] " &
                        " ,[U_Fec_Registro] " &
                        " ,[U_Hora_Registro] " &
                        " ,[U_Cod_Estado_Prj]) " &
                        "      VALUES(" &
                        " '" + nProx.ToString + "'" &
                        " ,'" + nProx.ToString + "' " &
                        " , 'ZHFSMON'" &
                        " ,'" + oConectarAplicacion.sCodUsuActual + "' " &
                        " ,CONVERT(DATE,'" + Date.Now + "',103) " &
                        " ,'" + Now.ToString("HH:mm").Replace(":", "") + "' " &
                        " ,'O'" &
                        " ,'" + NumProyec + "' " &
                        " ,CONVERT(DATE,'" + FecIni + "',103) " &
                        " ,CONVERT(DATE,'" + FecTer + "',103) " &
                        " ,'" + oConectarAplicacion.sCodUsuActual + "' " &
                        " ,'" + oConectarAplicacion.sNomUsuActual + "' " &
                        " ,CONVERT(DATE,'" + Date.Now + "',103) " &
                        " ,'" + Now.ToString("HH:mm:ss").Replace(":", "") + "' " &
                        " ,'" + DT_Sql_Pro.GetValue("IdEstado", vRow).ToString() + "') "

                Try
                    DT_SQL1.ExecuteQuery(sPSql)
                Catch ex As Exception
                    Application.SBO_Application.StatusBar.SetText(ex.Message)
                End Try
                'Try
                '    Dim Resp = NSimulacionMontaje.InsertarHistoricoMontaje(NumProyec,
                '                                                            New Date(1900, 1, 1),
                '                                                            New Date(1900, 1, 1),
                '                                                            oConectarAplicacion.sCodUsuActual,
                '                                                            oConectarAplicacion.sNomUsuActual,
                '                                                            Date.Now,
                '                                                            Now.ToString("HH:mm").Replace(":", ""),
                '                                                            DT_Sql_Pro.GetValue("IdEstado", vRow).ToString(),
                '                                                            "")
                'Catch ex As Exception
                'End Try
                'Codigo anterior en ZHFSMON de la Region #Codigo Anterior

                nProx = oFunciones.Proximo_Codigo_Correlativo("@ZHCEP", "Code", DT_SQL1)
                sPSql = " INSERT INTO [" + sBDComercial.Trim() + "].[dbo].[@ZHCEP] " & _
                      " ([Code],[Name],[U_PrjCode]" & _
                      " ,[U_User_ID],[U_User_Name],[U_Fec_Registro]" & _
                      " ,[U_Hora_Registro],[U_Estado_Proc],[U_Tipo_Proc]" & _
                      " ,[U_Doc_Anexo],[U_Fec_Inic],[U_Fec_Fin])" & _
                      "  VALUES" & _
                      " ('" + nProx.ToString + "' ,'" + nProx.ToString + "' ,'" + NumProyec + "'" & _
                      " ,'" + oConectarAplicacion.sCodUsuActual + "','" + oConectarAplicacion.sNomUsuActual + "',convert(datetime,'" + DateTime.Now.ToString() + "',103)" & _
                      " ,'" + DateTime.Now.ToLongTimeString + "','" + DT_Sql_Pro.GetValue("Desc.Est.", vRow).ToString() + "','MONTAJE'" & _
                      " ,'',convert(datetime,'" + DateTime.Now.ToString() + "',103),convert(datetime,'" + DateTime.Now.ToString() + "',103))"

                Try
                    DT_SQL1.ExecuteQuery(sPSql)
                Catch ex As Exception
                    oConectarAplicacion.Conectar_Aplicacion(oCompany)
                    DT_SQL1.ExecuteQuery(sPSql)
                End Try

            Catch ex As Exception
                Application.SBO_Application.StatusBar.SetText(ex.Message)
            Finally
                Funciones.FreezeForm(oForm, False)
            End Try

        End Sub

        Private Sub Agregar_Registro_Estado_Pedidos(nRow As Integer)

            Try

Grabar:
                Dim oGeneralService As SAPbobsCOM.GeneralService
                Dim oGeneralData As SAPbobsCOM.GeneralData

                'Dim oHeaderParams As SAPbobsCOM.GeneralDataParams
                'Dim oHeadTableRow As SAPbobsCOM.GeneralData

                'Dim oChild As SAPbobsCOM.GeneralData
                'Dim oChildren As SAPbobsCOM.GeneralDataCollection
                'Dim oGeneralParams As SAPbobsCOM.GeneralDataParams

                'Get GeneralService (oCmpSrv is the CompanyService)
                Dim sCmp As SAPbobsCOM.CompanyService = oCompany.GetCompanyService
                oGeneralService = sCmp.GetGeneralService("MIN_ESTADO")
                'oGeneralService = oCmpSrv.GetGeneralService("MIN_ESTADO")

                'Create data for new row in main UDO
                oGeneralData = oGeneralService.GetDataInterface(SAPbobsCOM.GeneralServiceDataInterfaces.gsGeneralData)
                'oGeneralData.SetProperty("U_MIN_DocNum", "First")
                oGeneralData.SetProperty("U_MIN_Proyecto", Grd_PlanifMont.DataTable.GetValue(0, nRow))
                'oGeneralData.SetProperty("U_MIN_Cliente", Grd_PlanifMont.DataTable.GetValue(1, nRow))
                oGeneralData.SetProperty("U_MIN_PrjName", Grd_PlanifMont.DataTable.GetValue(1, nRow))
                oGeneralData.SetProperty("U_MIN_Estado", oCmbx05.GetSelectedValue(nRow).Description)
                oGeneralData.SetProperty("U_MIN_Comments", Grd_PlanifMont.DataTable.GetValue("Observaciones", nRow))
                oGeneralData.SetProperty("U_MIN_Usuario", oCompany.UserName)
                'oGeneralData.SetProperty("U_MIN_Adjunto", "my data")

                'Create data for a row in the child table
                'oChildren = oGeneralData.Child("ChildUDO")
                'oChild = oChildren.Add
                'oChild.SetProperty("U_Data", "child data")
                'oChild.SetProperty("U_Type", 6)

                'Add the new row, including children, to database
                oGeneralService.Add(oGeneralData)
            Catch ex As Exception
                oConectarAplicacion.Conectar_Aplicacion(oCompany)
                'GoTo Grabar
            End Try


        End Sub

        Function cuantos(ByVal cadena As String, ByVal caracter As String) As Integer
            Dim i As Integer, num As Integer
            For i = 1 To Len(cadena)
                If Mid(cadena, i, 1) = caracter Then num = num + 1
            Next
            cuantos = num
        End Function

        Private Sub Cargar_Grid_Gestion_Montajes(TipoCarga As String, CondiBusqueda As String)

            Try

                Application.SBO_Application.StatusBar.SetText("Cargando Datos de Planificación de Montajes, Espere un momento ...", SAPbouiCOM.BoMessageTime.bmt_Medium, SAPbouiCOM.BoStatusBarMessageType.smt_Warning)

                Me.Edt_Estado.String = "Cargando Planificación de Montajes"
                Dim Sql_Planf As String
                Dim Sql_BuscaSC As String
                Dim Sql_Superv As String
                Dim FormID As String = Me.UIAPIRawForm.UniqueID
                Dim GridID As String = Grd_PlanifMont.Item.UniqueID

                Funciones.FreezeForm(oForm, True)

                'STORE PROCEDURE QUE CONTIENE LA CONSULTA PARA ARMAR LA SIMULACION DE MONTAJES
                If TipoCarga = "Solo Recepcionados" Then
                    Sql_Planf = "exec [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Simulacion_Gestion_MontajesN] 'NR','" + CondiBusqueda + "'"
                Else
                    Sql_Planf = "exec [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Simulacion_Gestion_MontajesN] 'R','" + CondiBusqueda + "'"
                End If


                DT_Sql_Pro.ExecuteQuery(Sql_Planf)
                DTSqlProR.CopyFrom(DT_Sql_Pro)

                'Asignar Numero de Columna de cada Campo a variables
                ColProjecto = oFunciones.Numero_Columna_Grid(FormID, GridID, "Proyecto")
                ColPrjNombre = oFunciones.Numero_Columna_Grid(FormID, GridID, "Prj.Nombre")
                ColMulta = oFunciones.Numero_Columna_Grid(FormID, GridID, "Multa")
                ColFecIniMont = oFunciones.Numero_Columna_Grid(FormID, GridID, "Fec.Ini.Mont")
                ColFecTerMont = oFunciones.Numero_Columna_Grid(FormID, GridID, "Fec.Ter.Mont")
                ColDiasDisp = oFunciones.Numero_Columna_Grid(FormID, GridID, "Dias Disp.")
                ColIdEstado = oFunciones.Numero_Columna_Grid(FormID, GridID, "IdEstado")
                ColVend = oFunciones.Numero_Columna_Grid(FormID, GridID, "Vend.")
                ColIdSuperv = oFunciones.Numero_Columna_Grid(FormID, GridID, "IdSuperv")
                ColPInd = oFunciones.Numero_Columna_Grid(FormID, GridID, "% Ind")
                ColPDesp = oFunciones.Numero_Columna_Grid(FormID, GridID, "% Desp")
                ColIdMont = oFunciones.Numero_Columna_Grid(FormID, GridID, "IdMont")
                ColDesEst = oFunciones.Numero_Columna_Grid(FormID, GridID, "Desc.Est.")
                ColPPCI = oFunciones.Numero_Columna_Grid(FormID, GridID, "% PCIs")
                ColFecRecep = oFunciones.Numero_Columna_Grid(FormID, GridID, "Fec.Recep.")

                Me.Grd_PlanifMont.Columns.Item("Projecto").TitleObject.Caption = "Proyecto"
                Me.Grd_PlanifMont.Columns.Item("Projecto").TitleObject.Sortable = True
                Me.Grd_PlanifMont.Columns.Item("Projecto").Width = 65
                Me.Grd_PlanifMont.Columns.Item("Projecto").RightJustified = True
                Me.Grd_PlanifMont.Columns.Item("Projecto").Editable = False
                oEditCol = Me.Grd_PlanifMont.Columns.Item("Projecto")
                oEditCol.LinkedObjectType = 63

                Me.Grd_PlanifMont.Columns.Item("Prj.Nombre").TitleObject.Caption = "Cliente"
                Me.Grd_PlanifMont.Columns.Item("Prj.Nombre").TitleObject.Sortable = True
                Me.Grd_PlanifMont.Columns.Item("Prj.Nombre").Width = 200
                Me.Grd_PlanifMont.Columns.Item("Prj.Nombre").RightJustified = False
                Me.Grd_PlanifMont.Columns.Item("Prj.Nombre").Editable = False

                Me.Grd_PlanifMont.Columns.Item("Multa").TitleObject.Caption = "PCVs - (M)"
                Me.Grd_PlanifMont.Columns.Item("Multa").TitleObject.Sortable = True
                Me.Grd_PlanifMont.Columns.Item("Multa").Width = 25
                Me.Grd_PlanifMont.Columns.Item("Multa").RightJustified = False
                Me.Grd_PlanifMont.Columns.Item("Multa").Editable = False
                oEditCol = Me.Grd_PlanifMont.Columns.Item("Multa")
                oEditCol.LinkedObjectType = 63


                Me.Grd_PlanifMont.Columns.Item("Fec.Ini.Mont").TitleObject.Caption = "Fec.Ini.Est."
                Me.Grd_PlanifMont.Columns.Item("Fec.Ini.Mont").TitleObject.Sortable = True
                Me.Grd_PlanifMont.Columns.Item("Fec.Ini.Mont").Width = 55
                Me.Grd_PlanifMont.Columns.Item("Fec.Ini.Mont").RightJustified = True
                Me.Grd_PlanifMont.Columns.Item("Fec.Ini.Mont").Editable = False

                Me.Grd_PlanifMont.Columns.Item("Fec.Ter.Mont").TitleObject.Caption = "Fec.Ter.Est."
                Me.Grd_PlanifMont.Columns.Item("Fec.Ter.Mont").TitleObject.Sortable = True
                Me.Grd_PlanifMont.Columns.Item("Fec.Ter.Mont").Width = 55
                Me.Grd_PlanifMont.Columns.Item("Fec.Ter.Mont").RightJustified = True
                Me.Grd_PlanifMont.Columns.Item("Fec.Ter.Mont").Editable = False

                Me.Grd_PlanifMont.Columns.Item("Dias Disp.").RightJustified = True
                Me.Grd_PlanifMont.Columns.Item("Dias Disp.").Editable = False

                Me.Grd_PlanifMont.Columns.Item("IdEstado").TitleObject.Caption = "Cod_Est"
                Me.Grd_PlanifMont.Columns.Item("IdEstado").Visible = False

                Me.Grd_PlanifMont.Columns.Item("Desc.Est.").TitleObject.Caption = "Desc.Est."
                Me.Grd_PlanifMont.Columns.Item("Desc.Est.").TitleObject.Sortable = True
                Me.Grd_PlanifMont.Columns.Item("Desc.Est.").Width = 100
                Me.Grd_PlanifMont.Columns.Item("Desc.Est.").Editable = True
                'Estado Proyecto
                Me.Grd_PlanifMont.Columns.Item("Desc.Est.").Type = SAPbouiCOM.BoGridColumnType.gct_ComboBox
                oCmbx05 = Me.Grd_PlanifMont.Columns.Item("Desc.Est.")

                Sql_BuscaSC = "SELECT 
	                                FldValue, Descr
                                FROM 
	                                [" + sBDMontaje.Trim() + "].dbo.[UFD1] 
                                WHERE 
	                                TableID ='@MIN_ESTADO' and FieldID=7  and FldValue != 8
                                ORDER BY 
	                                Descr "

                oFunciones.Inicializar_ComboBoxColumn(Me.UIAPIRawForm.UniqueID, Grd_PlanifMont.Item.UniqueID, oCmbx05.UniqueID)

                oFunciones.Cargar_ComboBoxColumn(Me.UIAPIRawForm.UniqueID, Grd_PlanifMont.Item.UniqueID, oCmbx05.UniqueID, DT_Estado.UniqueID, Sql_BuscaSC, 1, 0, False)

                'Me.Grd_PlanifMont.Columns.Item("Fec.Estado").TitleObject.Caption = "Fecha Estado"
                'Me.Grd_PlanifMont.Columns.Item("Fec.Estado").Editable = False
                Me.Grd_PlanifMont.Columns.Item("Vend.").TitleObject.Caption = "Ve."
                Me.Grd_PlanifMont.Columns.Item("Vend.").Editable = False

                Me.Grd_PlanifMont.Columns.Item("Doc.Adj.").TitleObject.Caption = "Doc.Adj."
                Me.Grd_PlanifMont.Columns.Item("Doc.Adj.").Editable = False
                oEditCol = Me.Grd_PlanifMont.Columns.Item("Doc.Adj.")
                oEditCol.LinkedObjectType = 63
                'Me.Grd_PlanifMont.Columns.Item("Doc.Adj.").Type = SAPbouiCOM.BoGridColumnType.gct_Picture
                'Dim oPicCol As SAPbouiCOM.PictureColumn = Me.Grd_PlanifMont.Columns.Item("Doc.Adj.")
                'oPicCol.Visible = True
                'oPicCol.Type = SAPbouiCOM.BoGridColumnType.gct_Picture
                'For i = 0 To Me.Grd_PlanifMont.DataTable.Rows.Count - 1
                '    oPicCol.SetPath(i, "C:\Users\Programador\Downloads\browse.bmp")
                'Next

                'Me.Grd_PlanifMont.DataTable.SetValue("Doc.Adj.", 0, "CHOOSE_ICON")

                'Supervisor
                Me.Grd_PlanifMont.Columns.Item("IdSuperv").TitleObject.Caption = "Id_Sup"
                Me.Grd_PlanifMont.Columns.Item("IdSuperv").Visible = False
                Me.Grd_PlanifMont.Columns.Item("Supervisor").TitleObject.Sortable = True
                Me.Grd_PlanifMont.Columns.Item("Supervisor").TitleObject.Caption = "Supervisor"

                Me.Grd_PlanifMont.Columns.Item("Supervisor").Type = SAPbouiCOM.BoGridColumnType.gct_ComboBox
                oCmbxSuperv = Me.Grd_PlanifMont.Columns.Item("Supervisor")

                Sql_Superv = "Select empID ,  (lastName +'  ' + left(ltrim(firstName),1)+'.') As Nombre, position " & _
                              "From [" + sBDMontaje.Trim() + "].DBO.[OHEM] where (position = 5 Or position = 8 ) and Active = 'Y' order by firstName "

                oFunciones.Inicializar_ComboBoxColumn(Me.UIAPIRawForm.UniqueID, Grd_PlanifMont.Item.UniqueID, oCmbxSuperv.UniqueID)

                oFunciones.Cargar_ComboBoxColumn(Me.UIAPIRawForm.UniqueID, Grd_PlanifMont.Item.UniqueID, oCmbxSuperv.UniqueID, DT_Superv.UniqueID, Sql_Superv, 1, 0, True)

                '    'Jefe de Proyecto 
                Me.Grd_PlanifMont.Columns.Item("IdJefe").TitleObject.Caption = "IdJefe"
                Me.Grd_PlanifMont.Columns.Item("IdJefe").Visible = False
                Me.Grd_PlanifMont.Columns.Item("IdJefe").TitleObject.Sortable = True
                Me.Grd_PlanifMont.Columns.Item("Jefe.Proy.").TitleObject.Caption = "Jefe.Proy."
                Me.Grd_PlanifMont.Columns.Item("Jefe.Proy.").TitleObject.Sortable = True
                Me.Grd_PlanifMont.Columns.Item("Jefe.Proy.").Type = SAPbouiCOM.BoGridColumnType.gct_ComboBox
                oCmbxJefe = Me.Grd_PlanifMont.Columns.Item("Jefe.Proy.")

                Sql_BuscaSC = "Select empID , (lastName +'  ' + left(ltrim(firstName),1)+'.') As Nombre, position " & _
                              "From [" + sBDMontaje.Trim() + "].DBO.[OHEM] where (position = 13 and Active = 'Y') order by firstName "

                oFunciones.Inicializar_ComboBoxColumn(Me.UIAPIRawForm.UniqueID, Grd_PlanifMont.Item.UniqueID, oCmbxJefe.UniqueID)

                oFunciones.Cargar_ComboBoxColumn(Me.UIAPIRawForm.UniqueID, Grd_PlanifMont.Item.UniqueID, oCmbxJefe.UniqueID, DT_JProy.UniqueID, Sql_BuscaSC, 1, 0, True)

                'Producto
                Me.Grd_PlanifMont.Columns.Item("IdProd").TitleObject.Caption = "IdProd"
                Me.Grd_PlanifMont.Columns.Item("IdProd").Visible = False
                Me.Grd_PlanifMont.Columns.Item("Producto").TitleObject.Caption = "Producto"
                Me.Grd_PlanifMont.Columns.Item("Producto").Visible = False
                Me.Grd_PlanifMont.Columns.Item("Producto").Type = SAPbouiCOM.BoGridColumnType.gct_ComboBox
                oCmbxProd = Me.Grd_PlanifMont.Columns.Item("Producto")
                Sql_BuscaSC = "Select Code, Name " & _
                              "From [" + sBDComercial.Trim() + "].DBO.[@MIN_FAMILIA] "

                oFunciones.Inicializar_ComboBoxColumn(Me.UIAPIRawForm.UniqueID, Grd_PlanifMont.Item.UniqueID, oCmbxProd.UniqueID)

                oFunciones.Cargar_ComboBoxColumn(Me.UIAPIRawForm.UniqueID, Grd_PlanifMont.Item.UniqueID, oCmbxProd.UniqueID, DT_Produ.UniqueID, Sql_BuscaSC, 1, 0, True)

                Me.Grd_PlanifMont.Columns.Item("Posic").TitleObject.Caption = "Cant."
                Me.Grd_PlanifMont.Columns.Item("Posic").Visible = False
                ''Me.Grd_PlanifMont.Columns.Item(14).BackColor = RGB(224, 255, 255) 'cian claro
                Me.Grd_PlanifMont.Columns.Item("Ciudad").TitleObject.Caption = "Ciudad"
                ''Me.Grd_PlanifMont.Columns.Item(15).BackColor = RGB(224, 255, 255) 'cian claro
                Me.Grd_PlanifMont.Columns.Item("% Ind").TitleObject.Caption = "% Ind"
                Me.Grd_PlanifMont.Columns.Item("% Ind").Editable = False
                Me.Grd_PlanifMont.Columns.Item("% Ind").TitleObject.Sortable = True
                Me.Grd_PlanifMont.Columns.Item("% Ind").RightJustified = True
                Me.Grd_PlanifMont.Columns.Item("% Desp").TitleObject.Caption = "% Desp"
                Me.Grd_PlanifMont.Columns.Item("% Desp").Editable = False
                Me.Grd_PlanifMont.Columns.Item("% Desp").TitleObject.Sortable = True
                Me.Grd_PlanifMont.Columns.Item("% Desp").RightJustified = True
                'Instalador o Montajistas
                Me.Grd_PlanifMont.Columns.Item("IdMont").TitleObject.Caption = "IdMont"
                Me.Grd_PlanifMont.Columns.Item("IdMont").Visible = False
                Me.Grd_PlanifMont.Columns.Item("Eq.Mont").TitleObject.Caption = "Eq.Mont"
                Me.Grd_PlanifMont.Columns.Item("Eq.Mont").Type = SAPbouiCOM.BoGridColumnType.gct_ComboBox
                Me.Grd_PlanifMont.Columns.Item("Eq.Mont").TitleObject.Sortable = True
                oCmbxMont = Me.Grd_PlanifMont.Columns.Item("Eq.Mont")
                Sql_BuscaSC = "Select empID , (lastName +'  ' + left(ltrim(firstName),1)+'.') As Nombre, position " & _
                              "From [" + sBDMontaje.Trim() + "].DBO.[OHEM] where (position = 6 and Active = 'Y') order by firstName "
                oFunciones.Inicializar_ComboBoxColumn(Me.UIAPIRawForm.UniqueID, Grd_PlanifMont.Item.UniqueID, oCmbxMont.UniqueID)

                oFunciones.Cargar_ComboBoxColumn(Me.UIAPIRawForm.UniqueID, Grd_PlanifMont.Item.UniqueID, oCmbxMont.UniqueID, DT_Monta.UniqueID, Sql_BuscaSC, 1, 0, True)

                Me.Grd_PlanifMont.Columns.Item("N° Trab.").Visible = False

                'Maquinaria para Montaje
                Me.Grd_PlanifMont.Columns.Item("Maquina").Type = SAPbouiCOM.BoGridColumnType.gct_ComboBox
                oCmbx18 = Me.Grd_PlanifMont.Columns.Item("Maquina")
                oCmbx18.ValidValues.Add("Sí", "")
                oCmbx18.ValidValues.Add("No", "")
                '-----------------------------------
                Me.Grd_PlanifMont.Columns.Item("Fec.Ini.").TitleObject.Caption = "Fecha Inicio"
                Me.Grd_PlanifMont.Columns.Item("Fec.Ini.").Width = 80
                Me.Grd_PlanifMont.Columns.Item("Fec.Ini.").TitleObject.Sortable = True

                Me.Grd_PlanifMont.Columns.Item("Fec.Ter.").TitleObject.Caption = "Fecha Termino"
                Me.Grd_PlanifMont.Columns.Item("Fec.Ter.").Width = 80

                Me.Grd_PlanifMont.Columns.Item("Fec.Recep.").TitleObject.Caption = "Fec. Recepcion"
                Me.Grd_PlanifMont.Columns.Item("Fec.Recep.").Width = 80
                Me.Grd_PlanifMont.Columns.Item("Fec.Recep.").Editable = False

                Me.Grd_PlanifMont.Columns.Item("% PCIs").TitleObject.Caption = "% PCIs"
                Me.Grd_PlanifMont.Columns.Item("% PCIs").Editable = False
                Me.Grd_PlanifMont.Columns.Item("% PCIs").TitleObject.Sortable = True
                Me.Grd_PlanifMont.Columns.Item("% PCIs").RightJustified = True
                oEditCol = Me.Grd_PlanifMont.Columns.Item("% PCIs")
                oEditCol.LinkedObjectType = 63

                Me.Grd_PlanifMont.Columns.Item("Modif").Visible = False

                Me.Grd_PlanifMont.Columns.Item("Fec.Ini.Desp").Editable = False
                Me.Grd_PlanifMont.Columns.Item("Fec.Ini.Desp").RightJustified = True

                Me.Grd_PlanifMont.Columns.Item("Primer Desp.").Editable = False
                Me.Grd_PlanifMont.Columns.Item("Primer Desp.").RightJustified = True

                Me.Grd_PlanifMont.Columns.Item("Ultimo Desp.").Editable = False
                Me.Grd_PlanifMont.Columns.Item("Ultimo Desp.").RightJustified = True

            Catch ex As Exception
                Application.SBO_Application.StatusBar.SetText(ex.Message)
            Finally
                Call Grd_PlanifMont_BackColor()
                'Call Numero_Fila_Grid(Grd_PlanifMont)
                Me.Edt_Estado.Item.Visible = False
                Me.StaticText0.Caption = "Nº Proyectos = " + Grd_PlanifMont.DataTable.Rows.Count().ToString()
                Funciones.FreezeForm(oForm, False)

                Application.SBO_Application.StatusBar.SetText("Datos Cargados", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success)

            End Try

        End Sub

        Private Sub Grd_PlanifMont_BackColor()
            Me.Edt_Estado.Item.Visible = True
            Me.Edt_Estado.String = "Coloreando Grilla"

            Dim FormID As String = Me.UIAPIRawForm.UniqueID
            Dim GridID As String = Grd_PlanifMont.Item.UniqueID

            Try
                Funciones.FreezeForm(oForm, True)

                Me.Grd_PlanifMont.Columns.Item("Projecto").BackColor = RGB(224, 255, 255) 'Cian claro
                Me.Grd_PlanifMont.Columns.Item("Prj.Nombre").BackColor = RGB(224, 255, 255) 'Cian claro
                Me.Grd_PlanifMont.Columns.Item("Multa").BackColor = RGB(224, 255, 255) 'Cian claro
                Me.Grd_PlanifMont.Columns.Item("Fec.Ini.Mont").BackColor = RGB(224, 255, 255) 'Cian claro
                Me.Grd_PlanifMont.Columns.Item("Fec.Ter.Mont").BackColor = RGB(224, 255, 255) 'Cian claro
                Me.Grd_PlanifMont.Columns.Item("Desc.Est.").BackColor = RGB(255, 255, 255) 'Blanco, se coloca toda la columan para volver a colorear
                'Me.Grd_PlanifMont.Columns.Item("Fec.Estado").BackColor = RGB(224, 255, 255) 'Cian claro
                Me.Grd_PlanifMont.Columns.Item("Vend.").BackColor = RGB(224, 255, 255) 'Cian claro
                Me.Grd_PlanifMont.Columns.Item("% Ind").BackColor = RGB(224, 255, 255) 'Cian claro
                Me.Grd_PlanifMont.Columns.Item("% Desp").BackColor = RGB(224, 255, 255) 'Cian claro
                Me.Grd_PlanifMont.Columns.Item("% PCIs").BackColor = RGB(224, 255, 255) 'Cian claro
                Me.Grd_PlanifMont.Columns.Item("Fec.Recep.").BackColor = RGB(224, 255, 255) 'Cian claro
                Me.Grd_PlanifMont.Columns.Item("Fec.Ini.Desp").BackColor = RGB(224, 255, 255) 'Cian claro
                Me.Grd_PlanifMont.Columns.Item("Primer Desp.").BackColor = RGB(224, 255, 255) 'Cian claro
                Me.Grd_PlanifMont.Columns.Item("Ultimo Desp.").BackColor = RGB(224, 255, 255) 'Cian claro


                Dim nRow As Integer = 0
                For Row = 0 To Grd_PlanifMont.Rows.Count - 1
                    nRow = Grd_PlanifMont.GetDataTableRowIndex(Row)
                    'Asignar Color a Columna
                    If Grd_PlanifMont.DataTable.GetValue("Multa", nRow).ToString = "Si" Then
                        If Row < Grd_PlanifMont.Rows.Count Then
                            'Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, 1, RGB(240, 128, 128))
                            'Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, 2, RGB(240, 128, 128))
                            Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, ColMulta + 1, RGB(240, 128, 128))
                        End If
                    End If

                    Dim dPorc As Double = 0
                    Dim sEstado As String = ""

                    'Asignar Color a las Filas de Estado "En proceso"
                    sEstado = Grd_PlanifMont.DataTable.GetValue("Desc.Est.", nRow).ToString.Trim()
                    If sEstado = "En proceso" Then
                        Me.Grd_PlanifMont.CommonSetting.SetRowBackColor(Row + 1, RGB(250, 250, 210))
                    ElseIf sEstado = "Suspendida" Or sEstado = "Comercial" Or sEstado = "Ingenieria" Or sEstado = "Produccion" Or sEstado = "Despacho" Then
                        Me.Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, ColDesEst + 1, RGB(240, 128, 128))
                    End If

                    'Asignar Color al Porcentaje de Industrial
                    Call Porc_Industrial_BackColor(Row)
                    Call Dias_Disponibles_BackColor(Row)

                Next
            Catch ex As Exception
                Funciones.FreezeForm(oForm, False)
                Application.SBO_Application.StatusBar.SetText(ex.Message)
                Me.Edt_Estado.String = "Error Graba al Coloreando Grilla"

            Finally
                Funciones.FreezeForm(oForm, False)
                Me.Edt_Estado.Item.Visible = False
            End Try
        End Sub

        Private Sub Grid_Row_BackColor(Row As Integer)

            Try
                Dim FormID As String = Me.UIAPIRawForm.UniqueID
                Dim GridID As String = Grd_PlanifMont.Item.UniqueID

                Funciones.FreezeForm(oForm, True)
                Me.Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, ColProjecto + 1, RGB(224, 255, 255))
                Me.Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, ColPrjNombre + 1, RGB(224, 255, 255))
                Me.Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, ColMulta + 1, RGB(224, 255, 255))
                Me.Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, ColFecIniMont + 1, RGB(224, 255, 255))
                Me.Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, ColFecTerMont + 1, RGB(224, 255, 255))
                Me.Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, ColVend + 1, RGB(224, 255, 255))
                Me.Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, ColPInd + 1, RGB(224, 255, 255))
                Me.Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, ColPDesp + 1, RGB(224, 255, 255))
                Me.Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, ColPPCI + 1, RGB(224, 255, 255))
                Me.Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, ColFecRecep + 1, RGB(224, 255, 255))

                Dim nRow As Integer = 0

                nRow = Grd_PlanifMont.GetDataTableRowIndex(Row)
                'Asignar Color a Columna
                If Grd_PlanifMont.DataTable.GetValue("Multa", nRow).ToString = "Si" Then
                    If Row < Grd_PlanifMont.Rows.Count Then
                        'Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, 1, RGB(240, 128, 128))
                        'Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, 2, RGB(240, 128, 128))
                        Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, ColMulta + 1, RGB(240, 128, 128))
                    End If
                End If

                Dim dPorc As Double = 0
                Dim sEstado As String = ""

                'Asignar Color a las Filas de Estado "En proceso"
                sEstado = Grd_PlanifMont.DataTable.GetValue("Desc.Est.", nRow).ToString.Trim()
                If sEstado = "En proceso" Then
                    Me.Grd_PlanifMont.CommonSetting.SetRowBackColor(Row + 1, RGB(250, 250, 210))
                ElseIf sEstado = "Suspendida" Or sEstado = "Comercial" Or sEstado = "Ingenieria" Or sEstado = "Produccion" Or sEstado = "Despacho" Then
                    Me.Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, ColDesEst + 1, RGB(240, 128, 128))
                End If

                'Asignar Color al Porcentaje de Industrial
                Call Porc_Industrial_BackColor(Row)
                Call Dias_Disponibles_BackColor(Row)

            Catch ex As Exception
                Application.SBO_Application.StatusBar.SetText(ex.Message)
            Finally
                Funciones.FreezeForm(oForm, False)
            End Try

        End Sub

        Private Sub Porc_Industrial_BackColor(Row As Integer)

            Dim nRow As Integer = Grd_PlanifMont.GetDataTableRowIndex(Row)
            Dim dPorc As Double = 0
            Dim FormID As String = Me.UIAPIRawForm.UniqueID
            Dim GridID As String = Grd_PlanifMont.Item.UniqueID

            'Asignar Color al Porcentaje de Industrial
            dPorc = CDbl(Replace(Replace(Grd_PlanifMont.DataTable.GetValue("% Ind", nRow).ToString.Trim(), "%", ""), ".", ","))
            If dPorc = 100 Then
                Me.Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, ColPInd + 1, RGB(48, 204, 0))
            ElseIf dPorc >= 75 And dPorc <= 99.99 Then
                Me.Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, ColPInd + 1, RGB(60, 254, 0))
            ElseIf dPorc >= 50 And dPorc <= 74.99 Then
                Me.Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, ColPInd + 1, RGB(117, 255, 75))
            ElseIf dPorc >= 25 And dPorc <= 49.99 Then
                Me.Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, ColPInd + 1, RGB(117, 255, 153))
            ElseIf dPorc >= 0.01 And dPorc <= 24.99 Then
                Me.Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, ColPInd + 1, RGB(234, 255, 177))
            Else
                Me.Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, ColPInd + 1, RGB(240, 128, 128))
            End If

        End Sub

        Private Sub Dias_Disponibles_BackColor(Row As Integer)

            If Button1.Caption = "Solo Recepcionados" Then

                Dim nRow As Integer = Grd_PlanifMont.GetDataTableRowIndex(Row)

                'Asignar Color a Dias Disponibles
                Dim FecIni As Date = Grd_PlanifMont.DataTable.GetValue("Fec.Ini.Mont", nRow)
                Dim FecFin As Date = Grd_PlanifMont.DataTable.GetValue("Fec.Ter.Mont", nRow)
                Dim FecAct As Date = FormatDateTime(Date.Now, DateFormat.ShortDate)

                If (FecAct < FecIni) Then
                    Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, ColDiasDisp + 1, RGB(48, 204, 0))
                ElseIf (FecAct >= FecIni And FecAct <= FecFin) Then
                    Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, ColDiasDisp + 1, RGB(250, 250, 210))
                ElseIf (FecAct > FecFin) Then
                    Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, ColDiasDisp + 1, RGB(240, 128, 128))
                End If

            Else
                Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, ColDiasDisp + 1, RGB(250, 250, 250))
            End If

        End Sub

        Private Sub Asignar_Documento(nProyecto As String, Estado As String)

            Dim FormDoc As New FrmDocumentos

            Dim oUDS As SAPbouiCOM.UserDataSource = FormDoc.UIAPIRawForm.DataSources.UserDataSources.Item("UD_0")
            oUDS.ValueEx = Me.UIAPIRawForm.UniqueID   'Aca asignamos el FormUID de Formulario al Valor del  User Data Source

            oUDS = FormDoc.UIAPIRawForm.DataSources.UserDataSources.Item("UD_1")
            oUDS.ValueEx = nProyecto.ToString()   'Aca asignamos el Codigo del Proyecto al User Data Source

            Dim oForm As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(FormDoc.UIAPIRawForm.UniqueID)
            oStatic = oForm.Items.Item("Item_2").Specific
            oStatic.Caption = "Documento de " + Estado

            FormDoc.Show()

        End Sub

#Region "Declaracion Items"
        Private WithEvents oCmbx05 As SAPbouiCOM.ComboBoxColumn
        Private WithEvents oCmbxSuperv As SAPbouiCOM.ComboBoxColumn
        Private WithEvents oCmbxJefe As SAPbouiCOM.ComboBoxColumn
        Private WithEvents oCmbxProd As SAPbouiCOM.ComboBoxColumn
        Private WithEvents oCmbxMont As SAPbouiCOM.ComboBoxColumn
        Private WithEvents oCmbx18 As SAPbouiCOM.ComboBoxColumn
        Private WithEvents Grd_PlanifMont As SAPbouiCOM.Grid
        Private WithEvents DT_Sql_Pro As SAPbouiCOM.DataTable
        Private WithEvents DTSqlProR As SAPbouiCOM.DataTable
        Private WithEvents DT_Estado As SAPbouiCOM.DataTable
        Private WithEvents DT_Superv As SAPbouiCOM.DataTable
        Private WithEvents DT_JProy As SAPbouiCOM.DataTable
        Private WithEvents DT_Produ As SAPbouiCOM.DataTable
        Private WithEvents DT_Monta As SAPbouiCOM.DataTable
        Private WithEvents DT_SQL1 As SAPbouiCOM.DataTable
        Private WithEvents Edt_Estado As SAPbouiCOM.EditText
        Private WithEvents Button0 As SAPbouiCOM.Button
        Private WithEvents Folder0 As SAPbouiCOM.Folder
        Private WithEvents Button1 As SAPbouiCOM.Button
        Private WithEvents Button2 As SAPbouiCOM.Button
        Private WithEvents Button3 As SAPbouiCOM.Button
        Private WithEvents EditText0 As SAPbouiCOM.EditText
        Private WithEvents Button4 As SAPbouiCOM.Button
        Private WithEvents UD_Row As SAPbouiCOM.UserDataSource
        Private WithEvents UD_Col As SAPbouiCOM.UserDataSource
        Private WithEvents StaticText0 As SAPbouiCOM.StaticText
#End Region

#Region "Codigo Anterior"
        'ZHFSMON
        'Dim nProx As Integer = oFunciones.Proximo_Codigo_Correlativo("@ZHFSMON", "Code", DT_SQL1)
        '        sPSql = " INSERT INTO [" + sBDComercial.Trim() + "].[dbo].[@ZHFSMON] " & _
        '                " ([Code] " & _
        '                " ,[Name] " & _
        '                " ,[U_PrjCode] " & _
        '                " ,[U_Fec_Ini_Mont] " & _
        '                " ,[U_Fec_Ter_Mont] " & _
        '                " ,[U_Cod_Usuario] " & _
        '                " ,[U_Nom_Usuario] " & _
        '                " ,[U_Fec_Registro] " & _
        '                " ,[U_Hora_Registro] " & _
        '                " ,[U_Cod_Estado_Prj]) " & _
        '                "      VALUES(" & _
        '                " '" + nProx.ToString + "'" & _
        '                " ,'" + nProx.ToString + "' " & _
        '                " ,'" + NumProyec + "' " & _
        '                " ,CONVERT(DATE,'" + FecIni + "',103) " & _
        '                " ,CONVERT(DATE,'" + FecTer + "',103) " & _
        '                " ,'" + oConectarAplicacion.sCodUsuActual + "' " & _
        '                " ,'" + oConectarAplicacion.sNomUsuActual + "' " & _
        '                " ,CONVERT(DATE,'" + Date.Now + "',103) " & _
        '                " ,'" + Now.ToString("HH:mm:ss").Replace(":", "") + "' " & _
        '                " ,'" + DT_Sql_Pro.GetValue("IdEstado", vRow).ToString() + "') "

        '        Try
        '            DT_SQL1.ExecuteQuery(sPSql)
        '        Catch ex As Exception
        '            oConectarAplicacion.Conectar_Aplicacion(oCompany)
        '            DT_SQL1.ExecuteQuery(sPSql)
        '        End Try
#End Region

    End Class
End Namespace
