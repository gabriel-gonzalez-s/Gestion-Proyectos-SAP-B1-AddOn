Option Strict Off
Option Explicit On

Imports SAPbouiCOM.Framework

Namespace SBOAddonProject1
    <FormAttribute("SBOAddonProject1.FrmPCVing", "3_Presentation_Layer/Pantallas Modales/FrmPCVing.b1f")>
    Friend Class FrmPCVing
        Inherits UserFormBase

        Private WithEvents oFilters As SAPbouiCOM.EventFilters
        Private WithEvents oFilter As SAPbouiCOM.EventFilter
        Private nCountEvent As Integer = 0
        Private nRowAnt As Integer = -1

        Public Sub New()
            'Call SetFilters()
        End Sub

        Public Overrides Sub OnInitializeComponent()
            Me.Grid0 = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.Grid)
            Me.Button0 = CType(Me.GetItem("Item_1").Specific, SAPbouiCOM.Button)
            Me.StaticText0 = CType(Me.GetItem("Item_2").Specific, SAPbouiCOM.StaticText)
            Me.StaticText1 = CType(Me.GetItem("Item_3").Specific, SAPbouiCOM.StaticText)
            Me.Folder0 = CType(Me.GetItem("Item_5").Specific, SAPbouiCOM.Folder)
            Me.UD_0 = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_0")
            Me.UD_1 = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_1")
            Me.UD_2 = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_2")
            Me.DT_SQL = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_SQL")
            Me.DT_PCV = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_PCV")
            Me.OnCustomInitialize()

        End Sub

        Public Overrides Sub OnInitializeFormEvents()
            AddHandler VisibleAfter, AddressOf Me.Form_VisibleAfter
            AddHandler ResizeAfter, AddressOf Me.Form_ResizeAfter
            AddHandler VisibleAfter, AddressOf Me.Form_VisibleAfter

        End Sub


        Private Sub OnCustomInitialize()

            AddHandler Application.SBO_Application.ItemEvent, AddressOf Me.PCV_Item_Event

        End Sub

        Private Sub Form_ResizeAfter(pVal As SAPbouiCOM.SBOItemEventArg)

            Try
                Me.UIAPIRawForm.Freeze(True)

                sPSql = "EXEC [dbo].[Min_GPR_PCVs_Proyecto] '" + UD_1.ValueEx.Trim + "'"
                Try
                    DT_PCV.ExecuteQuery(sPSql)
                Catch ex As Exception

                End Try

                StaticText0.Caption = "NOMBRE PROYECTO: " + UD_2.ValueEx.Trim
                StaticText1.Caption = "CLIENTE FINAL: " + UD_0.ValueEx.Trim

                oEditCol = Me.Grid0.Columns.Item(0)
                oEditCol.LinkedObjectType = "17"

                Me.Grid0.Columns.Item(3).RightJustified = True

                Me.Grid0.AutoResizeColumns()

            Catch ex As Exception
            Finally
                Me.UIAPIRawForm.Freeze(False)
            End Try

        End Sub

        Private Sub Form_VisibleAfter(pVal As SAPbouiCOM.SBOItemEventArg) Handles Me.VisibleAfter

        End Sub

        Private Sub Grid0_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid0.ClickAfter

            Grid0.Rows.SelectedRows.Add(pVal.Row)

        End Sub

        Private Sub Button0_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button0.ClickAfter

            Me.UIAPIRawForm.Close()

        End Sub

        Private Sub PCV_Item_Event(ByVal FormUID As String, ByRef pVal As SAPbouiCOM.ItemEvent, ByRef BubbleEvent As Boolean)

            '------------------------------------------------------------------------------------------------------------------------------------------------
            '  ESTE EVENTO ABRE LAS PCV EN LA PANTALLA DE LISTADOS DE PCV EN GESTION DE INGENIERIA
            '------------------------------------------------------------------------------------------------------------------------------------------------

            If pVal.FormTypeEx = "SBOAddonProject1.FrmPCVing" And
                pVal.EventType = SAPbouiCOM.BoEventTypes.et_MATRIX_LINK_PRESSED And
                pVal.ItemUID = "Item_0" And pVal.BeforeAction = True Then

                If nRowAnt <> -1 Then
                    If nRowAnt <> pVal.Row Then
                        nCountEvent = 0
                    End If
                End If
                nRowAnt = pVal.Row

                If nCountEvent = 0 Then
                    nCountEvent += 1

                    oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
                    oGrid = oForm.Items.Item(pVal.ItemUID).Specific
                    oGrid.Rows.SelectedRows.Add(pVal.Row)
                    Dim sCodigo As String = oGrid.DataTable.GetValue(0, pVal.Row)

                    BubbleEvent = False
                    Select Case pVal.ColUID
                        Case "N° PCV"

                            Select Case oConectarAplicacion.sCurrentCompanyDB
                                Case sBDComercial
                                    oFunciones.LinkedObjectForm(pVal.FormUID, "2050", "8", sCodigo)
                                Case sBDMontaje
                                    Cargar_Pedidos_Clientes_Externo(sBDComercial.Trim(), pVal.FormUID, sCodigo, "Pedidos Clientes MINDUGAR COMERCIAL")
                                Case sBDIndustrial
                                    Cargar_Pedidos_Clientes_Externo(sBDComercial.Trim(), pVal.FormUID, sCodigo, "Pedidos Clientes MINDUGAR COMERCIAL")
                            End Select

                    End Select

                Else
                    nCountEvent = 0
                    BubbleEvent = False
                End If

            End If

            If pVal.FormTypeEx = "SBOAddonProject1.FrmPCVing" And
                pVal.EventType = SAPbouiCOM.BoEventTypes.et_CLICK And
                pVal.ItemUID = "Item_0" And pVal.ColUID = "N° PCV" And
                pVal.BeforeAction = True Then

                Try
                    If nRowAnt <> -1 Then
                        If nRowAnt <> pVal.Row Then
                            nCountEvent = 0
                        End If
                    End If
                    nRowAnt = pVal.Row
                Catch ex As Exception

                End Try

            End If

        End Sub

        'Private Sub SetFilters()

        '    Try
        '        '// Create a new EventFilters object
        '        oFilters = New SAPbouiCOM.EventFilters()

        '        '// add an event type to the container
        '        '// this method returns an EventFilter object
        '        oFilter = oFilters.Add(SAPbouiCOM.BoEventTypes.et_MATRIX_LINK_PRESSED)

        '        '// assign the form type on which the event would be processed
        '        oFilter.AddEx("SBOAddonProject1.FrmPCVing") 'FrmPCVing.b1f

        '        Application.SBO_Application.SetFilter(oFilters)
        '    Catch ex As Exception

        '    End Try


        'End Sub


        Private WithEvents Grid0 As SAPbouiCOM.Grid
        Private WithEvents Button0 As SAPbouiCOM.Button
        Private WithEvents StaticText0 As SAPbouiCOM.StaticText
        Private WithEvents StaticText1 As SAPbouiCOM.StaticText
        Private WithEvents Folder0 As SAPbouiCOM.Folder
        Private WithEvents UD_0 As SAPbouiCOM.UserDataSource
        Private WithEvents UD_1 As SAPbouiCOM.UserDataSource
        Private WithEvents UD_2 As SAPbouiCOM.UserDataSource
        Private WithEvents DT_SQL As SAPbouiCOM.DataTable
        Private WithEvents DT_PCV As SAPbouiCOM.DataTable



    End Class
End Namespace
