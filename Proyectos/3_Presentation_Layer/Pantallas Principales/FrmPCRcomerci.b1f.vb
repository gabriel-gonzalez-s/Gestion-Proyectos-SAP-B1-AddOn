Option Strict Off
Option Explicit On

Imports SAPbouiCOM.Framework

Namespace SBOAddonProject1
    <FormAttribute("SBOAddonProject1.FrmPCRcomerci", "3_Presentation_Layer/Pantallas Principales/FrmPCRcomerci.b1f")>
    Friend Class FrmPCRcomerci
        Inherits UserFormBase

        Public Sub New()
        End Sub

        Public Overrides Sub OnInitializeComponent()
            Me.Grid0 = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.Grid)
            Me.DT_SQL = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_SQL")
            Me.DT_PCR = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_PCR")
            Me.OnCustomInitialize()

        End Sub

        Public Overrides Sub OnInitializeFormEvents()
            AddHandler ResizeAfter, AddressOf Me.FrmPCRcomerci_ResizeAfter

        End Sub


        Private Sub OnCustomInitialize()

            sPSql = "exec [" + sBDComercial.Trim() + "].[dbo].[MIN_GPR_Informe_PCR_Comercial]"

            Try
                Grid0.DataTable.ExecuteQuery(sPSql)
                Call Formato_Grid()
            Catch ex As Exception

            End Try

        End Sub

        Private Sub FrmPCRcomerci_ResizeAfter(pVal As SAPbouiCOM.SBOItemEventArg) Handles Me.ResizeAfter
            Grid0.Columns.Item("N1").Width = 150
            Grid0.Columns.Item("N2").Width = 250
            Grid0.Columns.Item("N2A").Width = 650
            Grid0.Columns.Item("N3").Width = 250
            Grid0.Columns.Item("N3A").Width = 650
            Grid0.Columns.Item("N4").Width = 250
            Grid0.Columns.Item("N4A").Width = 650
        End Sub

        Private Sub Grid0_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid0.ClickAfter

            Try

                Grid0.Rows.SelectedRows.Add(pVal.Row)

            Catch ex As Exception

            End Try

        End Sub

        Private Sub Formato_Grid()

            Dim oEditN1 As SAPbouiCOM.EditTextColumn = Nothing
            Dim oEditCol2 As SAPbouiCOM.EditTextColumn = Nothing
            Dim bProgBar As Boolean = True

            Try

                Grid0.Columns.Item("N1").Width = 150
                Grid0.Columns.Item("N1").TitleObject.Caption = "Nivel 1"
                Grid0.Columns.Item("N1").BackColor = RGB(224, 255, 255)
                Grid0.Columns.Item("N2").Width = 250
                Grid0.Columns.Item("N2").TitleObject.Caption = "Nivel 2"
                Grid0.Columns.Item("N2").BackColor = RGB(224, 255, 255)
                Grid0.Columns.Item("N2A").Width = 650
                Grid0.Columns.Item("N2A").TitleObject.Caption = "PCRs Nivel 2"
                Grid0.Columns.Item("N3").Width = 250
                Grid0.Columns.Item("N3").TitleObject.Caption = "Nivel 3"
                Grid0.Columns.Item("N3").BackColor = RGB(224, 255, 255)
                Grid0.Columns.Item("N3A").Width = 650
                Grid0.Columns.Item("N3A").TitleObject.Caption = "PCRs Nivel 3"
                Grid0.Columns.Item("N4").Width = 250
                Grid0.Columns.Item("N4").TitleObject.Caption = "Nivel 4"
                Grid0.Columns.Item("N4").BackColor = RGB(224, 255, 255)
                Grid0.Columns.Item("N4A").Width = 650
                Grid0.Columns.Item("N4A").TitleObject.Caption = "PCRs Nivel 4"

                oEditCol = Me.Grid0.Columns.Item("N2A")
                oEditCol.LinkedObjectType = 63
                oEditCol = Me.Grid0.Columns.Item("N3A")
                oEditCol.LinkedObjectType = 63
                oEditCol = Me.Grid0.Columns.Item("N4A")
                oEditCol.LinkedObjectType = 63

                Grid0.CollapseLevel = 6

                '********************* PROGRESS BAR
                Try
                    bProgBar = Funciones.Create_ProgressBar(oProgBar, "Cargando Datos de PCRs", Me.Grid0.Rows.Count)
                    If bProgBar = False Then
                        Application.SBO_Application.StatusBar.SetText("Cargando Datos de PCRs, Espere un momento ...", SAPbouiCOM.BoMessageTime.bmt_Long, SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
                    End If
                Catch ex As Exception
                End Try

                'Aplicar Collapse a las Cabeceras con Detalles
                Dim iProx As Integer = 0
                oEditN1 = Me.Grid0.Columns.Item(0)
                oEditCol = Me.Grid0.Columns.Item(3)
                oEditCol2 = Me.Grid0.Columns.Item(5)

                For k As Integer = 0 To (Me.Grid0.Rows.Count - 1)
                    If k = Me.Grid0.Rows.Count - 1 Then
                        iProx = k
                    Else
                        iProx = k + 1
                    End If


                    Try ' Contraer Nivel 2 sin desglose
                        If Me.Grid0.Rows.IsLeaf(k) = False And Me.Grid0.Rows.IsLeaf(iProx + 2) And oEditCol.GetText(iProx + 2).Trim.Length = 0 Then
                            Me.Grid0.Rows.Collapse(k)
                            Me.Grid0.Rows.Collapse(k - 1)
                        End If
                    Catch ex As Exception

                    End Try

                    Try ' Contraer Nivel 2 sin desglose
                        If Me.Grid0.Rows.IsLeaf(k) = False And Me.Grid0.Rows.IsLeaf(iProx + 1) And oEditCol2.GetText(iProx + 1).Trim.Length = 0 Then
                            Me.Grid0.Rows.Collapse(k)
                            'Me.Grid0.Rows.Collapse(k - 1)
                        End If
                    Catch ex As Exception

                    End Try

                    '********************* PROGRESS BAR
                    Try
                        If bProgBar Then
                            bProgBar = Funciones.Increment_ProgressBar(oProgBar, 1)
                        End If
                    Catch ex As Exception
                    End Try

                Next

                '********************* PROGRESS BAR
                Try
                    If bProgBar = False Then
                        Application.SBO_Application.StatusBar.SetText("Datos Cargados", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success)
                    End If
                    bProgBar = Funciones.Close_ProgressBar(oProgBar)
                Catch ex As Exception
                End Try

            Catch ex As Exception

            End Try


        End Sub

        Private Sub Grid_BackColor()

            Dim nRow As Integer = 0
            For Row = 0 To Grid0.Rows.Count - 1
                nRow = Grid0.GetDataTableRowIndex(Row)
            Next

        End Sub

        Private WithEvents Grid0 As SAPbouiCOM.Grid
        Private WithEvents DT_SQL As SAPbouiCOM.DataTable
        Private WithEvents DT_PCR As SAPbouiCOM.DataTable


    End Class
End Namespace
