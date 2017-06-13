Option Strict Off
Option Explicit On

Imports SAPbouiCOM.Framework

Namespace SBOAddonProject1
    <FormAttribute("SBOAddonProject1.FrmPCImonta", "3_Presentation_Layer/Pantallas Secundarias/FrmPCImonta.b1f")>
    Friend Class FrmPCImonta
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
            Me.Button1 = CType(Me.GetItem("Item_1").Specific, SAPbouiCOM.Button)
            Me.OnCustomInitialize()

        End Sub

        Public Overrides Sub OnInitializeFormEvents()
            AddHandler ActivateAfter, AddressOf Me.FrmPCImonta_ActivateAfter

        End Sub

        Private Sub FrmPCImonta_ActivateAfter(pVal As SAPbouiCOM.SBOItemEventArg) Handles Me.ActivateAfter

            If conta = 0 Then
                conta += 1
                Call Cargar_Grid_PCI()
            End If

        End Sub

        Private Sub OnCustomInitialize()

            'Me.UIAPIRawForm.ReportType = "Modal"
            Button1.Item.Enabled = False

        End Sub

        Private Sub Button0_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button0.ClickAfter

            Me.UIAPIRawForm.Close()

        End Sub


        Private Sub Grid0_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid0.ClickAfter

            Grid0.Rows.SelectedRows.Add(pVal.Row)
            If Grid0.DataTable.GetValue(1, pVal.Row).ToString = "Abierta" And Grid0.DataTable.GetValue(3, pVal.Row).ToString <> "100.00" And
                oConectarAplicacion.sCurrentCompanyDB = sBDMontaje Then
                Button1.Item.Enabled = True
                Button1.Caption = "Nuevo Avance PCI N° " + Grid0.DataTable.GetValue(0, pVal.Row).ToString
            Else
                Button1.Item.Enabled = False
                Button1.Caption = "Nuevo Avance PCI "
            End If

        End Sub

        Private Sub Grid0_GotFocusAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid0.GotFocusAfter
            Dim dtRow As Integer = Grid0.GetDataTableRowIndex(pVal.Row)
            Col_DatAnt = Grid0.DataTable.GetValue(pVal.ColUID, dtRow).ToString()
        End Sub

        Private Sub Button1_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button1.ClickAfter

            Try

                Dim rowNum As Integer = Grid0.Rows.SelectedRows.Item(0, SAPbouiCOM.BoOrderType.ot_RowOrder)

                If rowNum >= 0 And oConectarAplicacion.sCurrentCompanyDB = sBDMontaje Then

                    Application.SBO_Application.ActivateMenuItem("SBOAddonProject2.frmAvance")

                    For frm As Integer = 0 To Application.SBO_Application.Forms.Count - 1

                        Dim sCad As String = Application.SBO_Application.Forms.Item(frm).UniqueID
                        Dim sTit As String = Application.SBO_Application.Forms.Item(frm).Title
                        If sTit = "Avance - Solo Pedidos abiertos" Then

                            oForm = Application.SBO_Application.Forms.Item(sCad)
                            oForm.Select()

                            oForm.Freeze(True)

                            oForm.Mode = SAPbouiCOM.BoFormMode.fm_ADD_MODE

                            oedit = oForm.Items.Item("4").Specific
                            oedit.Item.Enabled = True
                            oedit.Value = Trim(Grid0.DataTable.GetValue(0, rowNum).ToString)

                            oedit = oForm.Items.Item("31").Specific
                            oedit.Item.Click()

                            oForm.Freeze(False)

                            Exit For

                        End If

                    Next

                End If

            Catch ex As Exception

            End Try

        End Sub

        Private Sub Cargar_Grid_PCI()

            sPSql = " SELECT DISTINCT PP.DocNum as 'PCI Montajes', " & _
                    " CASE	WHEN PP.DocStatus='C' AND PP.CANCELED='N'  THEN 'Cerrada' " & _
                    "		WHEN PP.DocStatus='O' AND PP.CANCELED='N'    THEN 'Abierta'   " & _
                    "		WHEN (PP.DocStatus='O' OR PP.DocStatus='C') AND PP.CANCELED='Y'  THEN 'Nula'   " & _
                    "		END as 'PCI Estado'  " & _
                    " ,PP.CardName as 'Titular PCI' " & _
                    " ,PP.U_MIN_Avance as 'Avance' " & _
                    " ,PP.Project as  'Proyecto'   " & _
                    " FROM SBO_MONTAJE.dbo.OPOR PP JOIN SBO_MONTAJE.dbo.POR1 PPD ON (PP.DocEntry=PPD.DocEntry  AND PPD.BaseType IN ('17','1470000113')) " & _
                    " LEFT JOIN SBO_MONTAJE.dbo.NNM1 S ON PP.Series = S.Series " & _
                    " WHERE PP.project  = '" + UD_1.ValueEx + "' AND PP.U_MIN_Grp_Socio IN ('104','105','106')"

            Try

                StaticText0.Caption = "NOMBRE PROYECTO: " + UD_2.ValueEx.Trim

                Grid0.DataTable.ExecuteQuery(sPSql)

                Call Grid_PCI_BackColor()

                oEditCol = Me.Grid0.Columns.Item(0)
                oEditCol.LinkedObjectType = "22"

                'Me.Grid0.Columns.Item(2).Editable = False
                'Me.Grid0.Columns.Item(2).BackColor = RGB(255, 255, 255)
                'Me.Grid0.Columns.Item(4).Editable = False
                'Me.Grid0.Columns.Item(4).BackColor = RGB(255, 255, 255)

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

        Private Sub Grid_PCI_BackColor()

            ''Asignar Color a Combo segun estados
            'Dim nRow As Integer = 0
            'Dim sEstado As String = ""

            'For Row = 0 To Grid0.Rows.Count - 1
            '    nRow = Grid0.GetDataTableRowIndex(Row)
            '    sEstado = Grid0.DataTable.GetValue("Estado Actual", nRow).ToString.Trim()
            '    If sEstado = "En proceso" Then
            '        Grid0.CommonSetting.SetRowBackColor(Row + 1, RGB(250, 250, 210))
            '    ElseIf sEstado = "Suspendida" Then
            '        Grid0.CommonSetting.SetCellBackColor(Row + 1, 6, RGB(240, 128, 128))
            '    End If
            'Next

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
        Private WithEvents Button1 As SAPbouiCOM.Button




    End Class
End Namespace
