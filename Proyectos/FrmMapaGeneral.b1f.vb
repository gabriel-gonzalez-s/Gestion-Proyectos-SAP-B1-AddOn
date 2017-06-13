Option Strict Off
Option Explicit On

Imports SAPbouiCOM.Framework

Namespace SBOAddonProject1
    <FormAttribute("SBOAddonProject1.FrmMapaGeneral", "FrmMapaGeneral.b1f")>
    Friend Class FrmMapaGeneral
        Inherits UserFormBase

        Public Sub New()
        End Sub

        Public Overrides Sub OnInitializeComponent()
            Me.StaticText0 = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.StaticText)
            Me.Grid0 = CType(Me.GetItem("Item_1").Specific, SAPbouiCOM.Grid)
            Me.Folder0 = CType(Me.GetItem(Nothing).Specific, SAPbouiCOM.Folder)
            Me.Folder1 = CType(Me.GetItem(Nothing).Specific, SAPbouiCOM.Folder)
            Me.Folder2 = CType(Me.GetItem(Nothing).Specific, SAPbouiCOM.Folder)
            Me.Folder3 = CType(Me.GetItem(Nothing).Specific, SAPbouiCOM.Folder)
            Me.DT_COMER = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_COMER")
            Me.DT_NOCOM = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_NOCOM")
            Me.DT_INDUSTRIAL = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_INDUSTRIAL")
            Me.DT_MONTAJE = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_MONTAJE")
            Me.OnCustomInitialize()

        End Sub

        Public Overrides Sub OnInitializeFormEvents()

        End Sub
        Private WithEvents StaticText0 As SAPbouiCOM.StaticText

        Private Sub OnCustomInitialize()

            Dim oUDS As SAPbouiCOM.UserDataSource = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_1")
            Dim sCodPrj As String = oUDS.ValueEx
            Dim oCol As SAPbouiCOM.EditTextColumn

            'sPSql = " select distinct  isnull(OPV.OpprId,0) as Oportunidad_de_Ventas, isnull(OV.DocNum,0) as Oferta_de_Ventas," & _
            '                " PC.DocNum as Pedido_de_Ventas,case PC.Series when '27' then 'PCV'  when '47' then 'PCR' when '46' then 'PCG' end as Tipo_Pedido," & _
            '                " isnull(GE.DocNum,'') as Guia_de_Entrega,GE.TaxDate	as Fecha_Entrega" & _
            '                " from [" + sBDComercial.Trim() + "].[DBO].OPRJ PR LEFT JOIN [" + sBDComercial.Trim() + "].[DBO].OOPR OPV on PR.PrjCode = OPV.PrjCode" & _
            '                " LEFT JOIN (select F.DocNum,R.BaseRef,F.Series,F.TaxDate,F.Project,R.DocEntry from [" + sBDComercial.Trim() + "].[DBO].OQUT F join [" + sBDComercial.Trim() + "].[DBO].QUT1 R on F.DocEntry = R.DocEntry ) OV on PR.PrjCode = OV.Project and isnull(OV.BaseRef,'') = isnull(OPV.OpprId,'')" & _
            '                " LEFT JOIN (select F.DocNum,R.BaseRef,F.Series,F.TaxDate,F.Project,R.DocEntry from [" + sBDComercial.Trim() + "].[DBO].ORDR F join [" + sBDComercial.Trim() + "].[DBO].RDR1 R on F.DocEntry = R.DocEntry)  PC on PR.PrjCode = PC.Project and isnull(PC.BaseRef,'') = isnull(OV.DocNum,'')  " & _
            '                " LEFT JOIN (select F.DocNum,R.BaseRef,F.Series,F.TaxDate,F.Project,R.DocEntry from [" + sBDComercial.Trim() + "].[DBO].ODLN F join [" + sBDComercial.Trim() + "].[DBO].DLN1 R on F.DocEntry = R.DocEntry)  GE on PR.PrjCode = GE.Project and isnull(GE.BaseRef,'') = isnull(PC.DocNum,'')" & _
            '                " where PR.PrjCode = '" + Me.EditText0.Value.Trim() + "'"

            'Cargar el primer Grid de Procesos Comercial
            Try

                Me.DT_COMER.ExecuteQuery(sPSql)

                If Me.DT_COMER.Rows.Count > 0 Then

                    Me.Grid0.DataTable = DT_COMER
                    Me.Grid0.CollapseLevel = 3
                    'Me.Grid0.CommonSetting.FixedColumnsCount = 4

                    ''==============================================
                    ''// LINKED BUTTON
                    ''==============================================
                    oCol = Me.Grid0.Columns.Item("Oportunidad de Ventas")
                    oCol.LinkedObjectType = "97"
                    oCol = Me.Grid0.Columns.Item("Oferta de Ventas")
                    oCol.LinkedObjectType = "23"
                    oCol = Me.Grid0.Columns.Item("Pedido de Ventas      Tipo Pedido       % Avance Proyecto     % Avance Pedido")
                    oCol.LinkedObjectType = "17"
                    oCol = Me.Grid0.Columns.Item("Guia de Entrega")
                    oCol.LinkedObjectType = "15"

                    'Aplicar Collapse a las Cabeceras con Detalles
                    Dim iProx As Integer = 0

                    For k As Integer = 0 To (Me.Grid0.Rows.Count - 1)
                        If k = Me.Grid0.Rows.Count - 1 Then
                            iProx = k
                        Else
                            iProx = k + 1
                        End If

                        If Me.Grid0.Rows.IsLeaf(k) = False And Me.Grid0.Rows.IsLeaf(iProx) Then
                            Me.Grid0.Rows.Collapse(k)
                        End If
                    Next

                End If

                'For k = 0 To Me.Grid0.Rows.Count - 1

                '    If Me.Grid0.Rows.IsLeaf(k) = True Then

                '        If Me.Grid0.Rows.IsLeaf(k - 1) = False Then
                '            oEditTextColumn.SetText(k - 1, sValor)
                '        End If
                '        oEditTextColumn.SetText(k, "")

                '    End If

                'Next

                'Dim oEditTextColumn As SAPbouiCOM.EditTextColumn
                'Dim sValor As String
                'oEditTextColumn = Me.Grid0.Columns.Item("Tipo_Pedido")
                'For k = 0 To Me.Grid0.Rows.Count - 1

                '    sValor = oEditTextColumn.GetText(k)
                '    If sValor.Trim.Length() > 0 And Me.Grid0.Rows.IsLeaf(k) = True Then

                '        If Me.Grid0.Rows.IsLeaf(k - 1) = False Then
                '            oEditTextColumn.SetText(k - 1, sValor)
                '        End If
                '        oEditTextColumn.SetText(k, "")

                '    End If

                'Next

            Catch ex As Exception
                Application.SBO_Application.MessageBox(sPSql)
                Application.SBO_Application.MessageBox(ex.Message)
            End Try

            'Cargar el Segundo Grid de Procesos Fuera de la comercial Comercial
            Try

                Me.DT_NOCOM.Clear()
                Me.DT_NOCOM.ExecuteQuery(sPSql3)

                If Me.DT_NOCOM.Rows.Count > 0 Then

                    Me.Grid1.DataTable = DT_NOCOM
                    Me.Grid1.CollapseLevel = 3
                    'Me.Grid1.CommonSetting.FixedColumnsCount = 2


                    ''==============================================
                    ''// LINKED BUTTON
                    ''==============================================
                    oCol = Me.Grid1.Columns.Item("Pedido Compras    Fecha Pedido   % Entrad Totales   % Ent. PC")
                    'oCol = Me.Grid1.Columns.Item(1)
                    oCol.LinkedObjectType = "22"
                    oCol = Me.Grid1.Columns.Item("Entrada de Mercaderia")
                    oCol.LinkedObjectType = "20"

                End If

                'Aplicar Collapse a las Cabeceras con Detalles
                Dim iProx As Integer = 0

                For k As Integer = 0 To (Me.Grid1.Rows.Count - 1)
                    If k = Me.Grid1.Rows.Count - 1 Then
                        iProx = k
                    Else
                        iProx = k + 1
                    End If

                    If Me.Grid1.Rows.IsLeaf(k) = False And Me.Grid1.Rows.IsLeaf(iProx) Then
                        Me.Grid1.Rows.Collapse(k)
                    End If
                Next

            Catch ex As Exception
                Application.SBO_Application.MessageBox(sPSql3)
                Application.SBO_Application.MessageBox(ex.Message)
            End Try

            'Cargar el TERCER Grid de Procesos de la Comercial en Industrial
            Try

                Me.DT_INDUSTRIAL.Clear()
                Me.DT_INDUSTRIAL.ExecuteQuery(sPSql4)

                If Me.DT_INDUSTRIAL.Rows.Count > 0 Then

                    Me.Grid2.DataTable = DT_INDUSTRIAL
                    Me.Grid2.CollapseLevel = 3
                    'Me.Grid1.CommonSetting.FixedColumnsCount = 2


                    ''==============================================
                    ''// LINKED BUTTON
                    ''==============================================
                    oCol = Me.Grid2.Columns.Item(0)
                    oCol.LinkedObjectType = "17"
                    oCol = Me.Grid2.Columns.Item(1)
                    oCol.LinkedObjectType = "17"
                    'oCol = Me.Grid0.Columns.Item("Orden_Fabricacion")
                    'oCol.LinkedObjectType = "202"
                    oCol = Me.Grid2.Columns.Item(3)
                    oCol.LinkedObjectType = "15"


                End If

                'Aplicar Collapse a las Cabeceras con Detalles
                Dim iProx As Integer = 0

                For k As Integer = 0 To (Me.Grid2.Rows.Count - 1)
                    If k = Me.Grid2.Rows.Count - 1 Then
                        iProx = k
                    Else
                        iProx = k + 1
                    End If

                    If Me.Grid2.Rows.IsLeaf(k) = False And Me.Grid2.Rows.IsLeaf(iProx) Then
                        Me.Grid2.Rows.Collapse(k)
                    End If
                Next

            Catch ex As Exception
                Application.SBO_Application.MessageBox(sPSql4)
                Application.SBO_Application.MessageBox(ex.Message)
            End Try

            'Cargar el CUARTO Grid de Procesos de la Comercial en Montaje
            Try

                Me.DT_MONTAJE.Clear()
                Me.DT_MONTAJE.ExecuteQuery(sPSql5)

                If Me.DT_MONTAJE.Rows.Count > 0 Then

                    Me.Grid3.DataTable = DT_MONTAJE
                    Me.Grid3.CollapseLevel = 4


                    ''==============================================
                    ''// LINKED BUTTON
                    ''==============================================
                    oCol = Me.Grid3.Columns.Item(0)
                    oCol.LinkedObjectType = "17"
                    oCol = Me.Grid3.Columns.Item(2)
                    oCol.LinkedObjectType = "17"
                    oCol = Me.Grid3.Columns.Item(1)
                    oCol.LinkedObjectType = "23"
                    oCol = Me.Grid3.Columns.Item(3)
                    oCol.LinkedObjectType = "1470000113"
                    oCol = Me.Grid3.Columns.Item(4)
                    oCol.LinkedObjectType = "22"
                    'oCol = Me.Grid1.Columns.Item("Pedido Compras    Fecha Pedido   % Entrad Totales   % Ent. PC")
                    ''oCol = Me.Grid1.Columns.Item(1)
                    'oCol.LinkedObjectType = "22"
                    'oCol = Me.Grid1.Columns.Item("Entrada de Mercaderia")
                    'oCol.LinkedObjectType = "20"

                End If

                'Aplicar Collapse a las Cabeceras con Detalles
                Dim iProx As Integer = 0

                For k As Integer = 0 To (Me.Grid3.Rows.Count - 1)
                    If k = Me.Grid3.Rows.Count - 1 Then
                        iProx = k
                    Else
                        iProx = k + 1
                    End If

                    If Me.Grid3.Rows.IsLeaf(k) = False And Me.Grid3.Rows.IsLeaf(iProx) Then
                        Me.Grid3.Rows.Collapse(k)
                    End If
                Next

            Catch ex As Exception
                Application.SBO_Application.MessageBox(sPSql4)
                Application.SBO_Application.MessageBox(ex.Message)
            End Try


        End Sub

        Private WithEvents Grid0 As SAPbouiCOM.Grid
        Private WithEvents Folder0 As SAPbouiCOM.Folder
        Private WithEvents Folder1 As SAPbouiCOM.Folder
        Private WithEvents Folder2 As SAPbouiCOM.Folder
        Private WithEvents Folder3 As SAPbouiCOM.Folder
        Private WithEvents DT_COMER As SAPbouiCOM.DataTable
        Private WithEvents DT_NOCOM As SAPbouiCOM.DataTable
        Private WithEvents DT_INDUSTRIAL As SAPbouiCOM.DataTable
        Private WithEvents DT_MONTAJE As SAPbouiCOM.DataTable

    End Class
End Namespace
