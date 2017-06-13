Option Strict Off
Option Explicit On

Imports SAPbouiCOM.Framework

Namespace SBOAddonProject1
    <FormAttribute("SBOAddonProject1.FrmPCVmonta", "3_Presentation_Layer/Pantallas Modales/FrmPCVmonta.b1f")>
    Friend Class FrmPCVmonta
        Inherits UserFormBase

        Private Col_DatAnt As String = ""

        Dim conta As Integer = 0

        Public Sub New()
        End Sub

        Public Overrides Sub OnInitializeComponent()
            Me.Grid0 = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.Grid)
            Me.Button0 = CType(Me.GetItem("Item_2").Specific, SAPbouiCOM.Button)
            Me.UD_1 = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_1")
            Me.UD_2 = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_2")
            Me.Folder0 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.Folder)
            Me.DT_SQL = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_SQL")
            Me.DT_ESTADO = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_ESTADO")
            Me.StaticText0 = CType(Me.GetItem("Item_5").Specific, SAPbouiCOM.StaticText)
            Me.StaticText1 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.StaticText)
            Me.ComboBox0 = CType(Me.GetItem("Item_1").Specific, SAPbouiCOM.ComboBox)
            Me.StaticText2 = CType(Me.GetItem("Item_7").Specific, SAPbouiCOM.StaticText)
            Me.OnCustomInitialize()

        End Sub

        Public Overrides Sub OnInitializeFormEvents()
            AddHandler ActivateAfter, AddressOf Me.FrmPCVmonta_ActivateAfter
            AddHandler VisibleAfter, AddressOf Me.FrmPCVmonta_VisibleAfter
            AddHandler ResizeAfter, AddressOf Me.Form_ResizeAfter

        End Sub

        Private Sub Form_ResizeAfter(pVal As SAPbouiCOM.SBOItemEventArg)
            If conta = 0 Then

                conta += 1
                Try
                    Me.UIAPIRawForm.Freeze(True)
                    Call Cargar_Grid_PCV()
                Catch ex As Exception
                Finally
                    Me.UIAPIRawForm.Freeze(False)
                End Try

            End If

        End Sub


        Private Sub FrmPCVmonta_ActivateAfter(pVal As SAPbouiCOM.SBOItemEventArg) Handles Me.ActivateAfter

            'Dim valor As String = UD_1.ValueEx
            'If conta = 0 Then
            '    conta += 1
            '    Call Cargar_Grid_PCV()
            'End If

        End Sub


        Private Sub FrmPCVmonta_VisibleAfter(pVal As SAPbouiCOM.SBOItemEventArg) Handles Me.VisibleAfter

            'If conta = 0 Then

            '    conta += 1
            '    Try
            '        Me.UIAPIRawForm.Freeze(True)
            '        Call Cargar_Grid_PCV()
            '    Catch ex As Exception
            '    Finally
            '        Me.UIAPIRawForm.Freeze(False)
            '    End Try

            'End If

        End Sub

        Private Sub OnCustomInitialize()

        End Sub

        Private Sub Button0_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button0.ClickAfter

            Me.UIAPIRawForm.Close()

        End Sub


        Private Sub Grid0_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid0.ClickAfter

            Grid0.Rows.SelectedRows.Add(pVal.Row)

        End Sub

        Private Sub Grid0_GotFocusAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid0.GotFocusAfter
            Dim dtRow As Integer = Grid0.GetDataTableRowIndex(pVal.Row)
            Col_DatAnt = Grid0.DataTable.GetValue(pVal.ColUID, dtRow).ToString()
        End Sub

        'Private Sub Grid0_ComboSelectBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles Grid0.ComboSelectBefore
        '    Dim dtRow As Integer = Grid0.GetDataTableRowIndex(pVal.Row)
        '    Col_DatAnt = Grid0.DataTable.GetValue(pVal.ColUID, dtRow).ToString()
        'End Sub

        Private Sub Grid0_ComboSelectAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid0.ComboSelectAfter

            If pVal.ColUID = "Estado Actual" Then

                oComboCol = Grid0.Columns.Item(2)

                Select Case oComboCol.GetSelectedValue(pVal.Row).Description
                    Case "8"
                        Grid0.CommonSetting.SetCellBackColor(pVal.Row + 1, 3, RGB(240, 128, 128))
                    Case Else
                        Grid0.CommonSetting.SetCellBackColor(pVal.Row + 1, 3, RGB(250, 250, 250))
                End Select

                Dim nPCV As Integer = Grid0.DataTable.GetValue(0, pVal.Row)
                Call Cambiar_Estado_PCV(nPCV, oComboCol.GetSelectedValue(pVal.Row).Description, pVal.Row)

            End If

        End Sub

        Private Sub ComboBox0_ComboSelectAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles ComboBox0.ComboSelectAfter

            If Application.SBO_Application.MessageBox("Cambiar a Estado '" + ComboBox0.Selected.Value.Trim + "' Todas las PCV Asociadas al Proyecto " + UD_1.ValueEx.Trim, 1, "Cambiar", "Cancelar") = 1 Then

                Try
                    Me.UIAPIRawForm.Freeze(True)

                    For i = 0 To Grid0.Rows.Count - 1

                        oComboCol = Grid0.Columns.Item(2)
                        oComboCol.SetSelectedValue(i, oComboCol.ValidValues.Item(ComboBox0.Selected.Value))

                    Next

                Catch ex As Exception
                Finally
                    Me.UIAPIRawForm.Freeze(False)
                End Try

            End If

        End Sub

        Private Sub Cargar_Grid_PCV()

            sPSql = " SELECT  distinct cast(isnull(PC.DocNum,0) as varchar) as 'N° PCV'," & _
                    " ISNULL(S.SeriesName,'') as 'Tipo'," & _
                    " EP.Descr as 'Estado Actual', " & _
                    " PC.Project as 'Proyecto'," & _
                    " '[...]' as 'Doc.Adj.'" & _
                    " FROM  (SELECT F.DocNum,F.U_MIN_Estado,R.BaseRef,F.Series,F.TaxDate,F.Project,R.DocEntry,U_MIN_PCVC,U_MIN_Cliente " & _
                    "           from [" + sBDMontaje + "].[DBO].ORDR F join [" + sBDMontaje + "].[DBO].RDR1 R on F.DocEntry = R.DocEntry  " & _
                    "           where F.CANCELED!='Y'" & _
                    "           )  PC  " & _
                    " LEFT JOIN (Select Est.FldValue, Est.Descr " & _
                    "            From [" + sBDMontaje + "].DBO.[ufd1] Est " & _
                    "            where (Est.TableID='@MIN_ESTADO') " & _
                    "            ) EP on PC.U_MIN_Estado = EP.FldValue   " & _
                    " LEFT JOIN [" + sBDMontaje + "].DBO.NNM1 S ON PC.Series = S.Series" & _
                    " WHERE  PC.Project = '" + UD_1.ValueEx + "'" & _
                    " order by 'N° PCV' "

            Try

                StaticText0.Caption = "NOMBRE PROYECTO: " + UD_2.ValueEx.Trim

                Grid0.DataTable.ExecuteQuery(sPSql)

                Grid0.Columns.Item(2).Type = SAPbouiCOM.BoGridColumnType.gct_ComboBox
                oComboCol = Grid0.Columns.Item(2)

                sPSql = "Select FldValue, Descr " & _
                        "FROM [" + sBDMontaje.Trim() + "].dbo.[UFD1] WHERE TableID ='@MIN_ESTADO' and FieldID=7  Order By Descr "

                Call oFunciones.Inicializar_ComboBoxColumn(Me.UIAPIRawForm.UniqueID, Grid0.Item.UniqueID, oComboCol.UniqueID)

                Call oFunciones.Cargar_ComboBoxColumn(Me.UIAPIRawForm.UniqueID, Grid0.Item.UniqueID, oComboCol.UniqueID, DT_ESTADO.UniqueID, sPSql, 1, 0, False)

                Call oFunciones.Cargar_ComboBox(Me.UIAPIRawForm.UniqueID, ComboBox0.Item.UniqueID, DT_ESTADO.UniqueID, sPSql, 1, 0, False)

                Call Grid_PCV_BackColor()

                oEditCol = Me.Grid0.Columns.Item(0)
                oEditCol.LinkedObjectType = "17"

                Grid0.Columns.Item("Doc.Adj.").TitleObject.Caption = "Doc.Adj."
                Grid0.Columns.Item("Doc.Adj.").Editable = False
                oEditCol = Grid0.Columns.Item("Doc.Adj.")
                oEditCol.LinkedObjectType = 63

                'Cliente Final
                sPSql = " SELECT F.DocNum,F.U_MIN_Estado,F.Series,F.TaxDate,F.Project,U_MIN_PCVC,U_MIN_Cliente " & _
                        " from [" + sBDMontaje + "].[DBO].ORDR F  " & _
                        " where F.CANCELED!='Y' and F.Project = '" + UD_1.ValueEx + "'"

                DT_SQL.ExecuteQuery(sPSql)
                If DT_SQL.IsEmpty = False Then

                    StaticText1.Caption = "CLIENTE FINAL: " + DT_SQL.GetValue("U_MIN_Cliente", 0).ToString.Trim

                End If


            Catch ex As Exception

            End Try

        End Sub

        Private Sub Grid_PCV_BackColor()

            'Asignar Color a Combo segun estados
            Dim nRow As Integer = 0
            Dim sEstado As String = ""

            For Row = 0 To Grid0.Rows.Count - 1
                nRow = Grid0.GetDataTableRowIndex(Row)
                sEstado = Grid0.DataTable.GetValue("Estado Actual", nRow).ToString.Trim()
                If sEstado = "En proceso" Then
                    Grid0.CommonSetting.SetRowBackColor(Row + 1, RGB(250, 250, 210))
                ElseIf sEstado = "Suspendida" Then
                    Grid0.CommonSetting.SetCellBackColor(Row + 1, 6, RGB(240, 128, 128))
                End If
            Next

        End Sub

        Private Sub Cambiar_Estado_PCV(NumPCV As Integer, nEstado As Integer, vRow As Integer)

            'Actualizar Estado de la PCV en Montajes
            sPSql = "UPDATE [" + sBDMontaje + "].[DBO].[ORDR] set [U_MIN_Estado] = " + nEstado.ToString + " where [DocNum] = " + NumPCV.ToString

            Try
                DT_SQL.ExecuteQuery(sPSql)
            Catch ex As Exception

            End Try

            'Inserta registro de Historico en ZHFSMON para cada PCV Afectada
            Try
                Dim nProx As Integer = oFunciones.Proximo_Codigo_Correlativo("@ZHFSMON", "Code", DT_SQL)
                oComboCol = Grid0.Columns.Item(2)

                sPSql = " INSERT INTO [" + sBDComercial.Trim() + "].[dbo].[@ZHFSMON] " & _
                        " ([Code] " & _
                        " ,[Name] " & _
                        " ,[U_PrjCode] " & _
                        " ,[U_Fec_Ini_Mont] " & _
                        " ,[U_Fec_Ter_Mont] " & _
                        " ,[U_Cod_Usuario] " & _
                        " ,[U_Nom_Usuario] " & _
                        " ,[U_Fec_Registro] " & _
                        " ,[U_Hora_Registro] " & _
                        " ,[U_Cod_Estado_Prj]" & _
                        " ,[U_NumeroPCV]) " & _
                        "      VALUES(" & _
                        " '" + nProx.ToString + "'" & _
                        " ,'" + nProx.ToString + "' " & _
                        " ,'" + UD_1.ValueEx + "' " & _
                        " ,CONVERT(DATE,'',103) " & _
                        " ,CONVERT(DATE,'',103) " & _
                        " ,'" + oConectarAplicacion.sCodUsuActual + "' " & _
                        " ,'" + oConectarAplicacion.sNomUsuActual + "' " & _
                        " ,CONVERT(DATE,'" + Date.Now + "',103) " & _
                        " ,'" + Now.ToString("HH:mm:ss").Replace(":", "") + "' " & _
                        " ,'" + oComboCol.GetSelectedValue(vRow).Description + "'" & _
                        ", '" + NumPCV.ToString + "') "


                DT_SQL.ExecuteQuery(sPSql)

            Catch ex As Exception

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
                oGeneralData.SetProperty("U_MIN_Proyecto", Grid0.DataTable.GetValue(0, nRow))
                'oGeneralData.SetProperty("U_MIN_Cliente", Grd_PlanifMont.DataTable.GetValue(1, nRow))
                oGeneralData.SetProperty("U_MIN_PrjName", Grid0.DataTable.GetValue(1, nRow))
                oGeneralData.SetProperty("U_MIN_Estado", Grid0.GetSelectedValue(nRow).Description)
                oGeneralData.SetProperty("U_MIN_Comments", Grid0.DataTable.GetValue("Observaciones", nRow))
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


        Private WithEvents Grid0 As SAPbouiCOM.Grid
        Private WithEvents Button0 As SAPbouiCOM.Button
        Private WithEvents UD_1 As SAPbouiCOM.UserDataSource
        Private WithEvents UD_2 As SAPbouiCOM.UserDataSource
        Private WithEvents Folder0 As SAPbouiCOM.Folder
        Private WithEvents DT_SQL As SAPbouiCOM.DataTable
        Private WithEvents DT_ESTADO As SAPbouiCOM.DataTable
        Private WithEvents StaticText0 As SAPbouiCOM.StaticText
        Private WithEvents StaticText1 As SAPbouiCOM.StaticText
        Private WithEvents ComboBox0 As SAPbouiCOM.ComboBox
        Private WithEvents StaticText2 As SAPbouiCOM.StaticText



    End Class
End Namespace
