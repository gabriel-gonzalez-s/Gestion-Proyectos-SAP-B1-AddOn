Option Strict Off
Option Explicit On

Imports SAPbouiCOM.Framework

Namespace SBOAddonProject1
    <FormAttribute("SBOAddonProject1.FrmListaDocumentos", "3_Presentation_Layer/Pantallas Modales/FrmListaDocumentos.b1f")>
    Friend Class FrmListaDocumentos
        Inherits UserFormBase

        Dim conta As Integer = 0

        Public Sub New()
        End Sub

        Public Overrides Sub OnInitializeComponent()
            Me.StaticText1 = CType(Me.GetItem("Item_2").Specific, SAPbouiCOM.StaticText)
            Me.Grid0 = CType(Me.GetItem("Item_3").Specific, SAPbouiCOM.Grid)
            Me.Button0 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.Button)
            Me.OnCustomInitialize()

        End Sub

        Public Overrides Sub OnInitializeFormEvents()
            AddHandler ResizeAfter, AddressOf Me.Form_ResizeAfter

        End Sub

        Private Sub OnCustomInitialize()

        End Sub
        Private WithEvents StaticText1 As SAPbouiCOM.StaticText
        Private WithEvents Grid0 As SAPbouiCOM.Grid
        Private WithEvents Button0 As SAPbouiCOM.Button

        Private Sub Form_ResizeAfter(pVal As SAPbouiCOM.SBOItemEventArg)

            If conta = 0 Then

                conta += 1
                Try
                    Me.UIAPIRawForm.Freeze(True)
                    Cargar_Grid_Documentos()
                Catch ex As Exception
                Finally
                    Me.UIAPIRawForm.Freeze(False)
                End Try

            End If
        End Sub

        Private Sub Cargar_Grid_Documentos()
            Try

                Dim oFormP As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(Me.UIAPIRawForm.UniqueID)

                Dim UD_0 As SAPbouiCOM.UserDataSource = oFormP.DataSources.UserDataSources.Item("UD_0")
                Dim UD_1 As SAPbouiCOM.UserDataSource = oFormP.DataSources.UserDataSources.Item("UD_1")

                Dim sql As String = ""

                Select Case UD_1.ValueEx
                    Case "PR"
                        sql = "[dbo].[Min_GPR_Consultar_Documentos_Proyecto]
		                        @sCodPro = N'" + UD_0.ValueEx + "',
		                        @TipoQry = N'PR'"
                    Case "OC"
                        sql = "[dbo].[Min_GPR_Consultar_Documentos_Proyecto]
		                        @sCodPro = N'" + UD_0.ValueEx + "',
		                        @TipoQry = N'OC'"
                End Select


                Try
                    oUDataTable = oFormP.DataSources.DataTables.Item("DT_SQL")
                    oUDataTable.ExecuteQuery(sql)

                Catch ex As Exception
                    Application.SBO_Application.MessageBox(sql)
                    Application.SBO_Application.MessageBox(ex.Message)
                End Try

                oGrid = oForm.Items.Item("Item_3").Specific
                'oGrid.RowHeaders.Width = 0

                Dim Col_Justif = {2}
                oGrid.Columns.Item(3).Visible = False
                oGrid.Columns.Item(5).Visible = False

                For index = 0 To oGrid.DataTable.Columns.Count - 1
                    oGrid.Columns.Item(index).Editable = False
                    oGrid.Columns.Item(index).BackColor = RGB(255, 255, 255) 'Blanco
                    If Col_Justif.Contains(index) Then
                        oGrid.Columns.Item(index).RightJustified = True
                    End If
                Next

                oFunciones.Numero_Fila_Grid(oGrid)

                oGrid.AutoResizeColumns()
            Catch ex As Exception

            End Try

        End Sub

        Private Sub Grid0_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid0.ClickAfter
            Try
                oGrid = CType(sboObject, SAPbouiCOM.Grid)
                oGrid.Rows.SelectedRows.Add(pVal.Row)
            Catch ex As Exception
            End Try
        End Sub

        Private Sub Grid0_DoubleClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid0.DoubleClickAfter

            Dim sPath As String = Grid0.DataTable.GetValue(1, Grid0.GetDataTableRowIndex(pVal.Row))
            oFunciones.Open_File(sPath)

        End Sub
    End Class
End Namespace
