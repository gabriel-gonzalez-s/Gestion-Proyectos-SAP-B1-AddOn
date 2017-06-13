Option Strict Off
Option Explicit On

Imports SAPbouiCOM.Framework

Namespace SBOAddonProject1
    <FormAttribute("SBOAddonProject1.Form10", "3_Presentation_Layer/Pantallas Secundarias/FrmHistori_Fecha.b1f")>
    Friend Class Form10
        Inherits UserFormBase

        Public Sub New()
        End Sub

#Region "Respaldo de OnInitializeComponent"
        'Me.Matrix0 = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.Matrix)
        '     Me.EditText0 = CType(Me.GetItem("Item_1").Specific, SAPbouiCOM.EditText)
        '     Me.StaticText0 = CType(Me.GetItem("Item_2").Specific, SAPbouiCOM.StaticText)
        '     Me.EditText1 = CType(Me.GetItem("Item_3").Specific, SAPbouiCOM.EditText)
        '     Me.StaticText1 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.StaticText)
        '     Me.EditText2 = CType(Me.GetItem("Item_5").Specific, SAPbouiCOM.EditText)
        '     Me.StaticText2 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.StaticText)
        '     Me.DT_1 = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_1")
        '     Me.Button0 = CType(Me.GetItem("Item_7").Specific, SAPbouiCOM.Button)
        '     Me.DT_1.ExecuteQuery(sPSql)
        '     Me.Matrix0.Columns.Item("Col_0").DataBind.Bind("DT_1", "Fecha")
        '     Me.Matrix0.Columns.Item("Col_1").DataBind.Bind("DT_1", "hora")
        '     Me.Matrix0.Columns.Item("Col_2").DataBind.Bind("DT_1", "Venta")
        '     Me.Matrix0.Columns.Item("Col_3").DataBind.Bind("DT_1", "Prometida")
        '     Me.Matrix0.Columns.Item("Col_4").DataBind.Bind("DT_1", "Ter_desarr")
        '     Me.Matrix0.Columns.Item("Col_5").DataBind.Bind("DT_1", "Ter_Prod")
        '     Me.Matrix0.Columns.Item("Col_6").DataBind.Bind("DT_1", "Ini_Desp")
        '     Me.Matrix0.Columns.Item("Col_7").DataBind.Bind("DT_1", "Ini_Mont")
        '     Me.Matrix0.Columns.Item("Col_8").DataBind.Bind("DT_1", "Ter_Mont")
        '     Me.Matrix0.Columns.Item("Col_9").DataBind.Bind("DT_1", "usuario")
        '     Me.Matrix0.Columns.Item("Col_10").DataBind.Bind("DT_1", "U_Doc_Ter_Desa")
        '     Me.Matrix0.Columns.Item("Col_11").DataBind.Bind("DT_1", "U_Doc_Ter_Prod")
        '     Me.Matrix0.Columns.Item("Col_12").DataBind.Bind("DT_1", "U_Doc_Ini_Despa")
        '     Me.Matrix0.Columns.Item("Col_13").DataBind.Bind("DT_1", "U_Doc_Ini_Monta")
        '     Me.Matrix0.Columns.Item("Col_14").DataBind.Bind("DT_1", "U_Doc_Term_Monta")
        '     Me.Matrix0.Columns.Item("Col_15").DataBind.Bind("DT_1", "Comentario")
        '     Me.Matrix0.Clear()
        '     Me.Matrix0.LoadFromDataSource()
        '     Me.Matrix0.AutoResizeColumns()
#End Region

        Public Overrides Sub OnInitializeComponent()

            Me.Matrix0 = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.Matrix)
            Me.EditText0 = CType(Me.GetItem("Item_1").Specific, SAPbouiCOM.EditText)
            Me.StaticText0 = CType(Me.GetItem("Item_2").Specific, SAPbouiCOM.StaticText)
            Me.EditText1 = CType(Me.GetItem("Item_3").Specific, SAPbouiCOM.EditText)
            Me.StaticText1 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.StaticText)
            Me.EditText2 = CType(Me.GetItem("Item_5").Specific, SAPbouiCOM.EditText)
            Me.StaticText2 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.StaticText)
            Me.DT_1 = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_1")
            Me.Button0 = CType(Me.GetItem("Item_7").Specific, SAPbouiCOM.Button)
            Me.DT_1.ExecuteQuery(sPSql)
            Me.Matrix0.Columns.Item("Col_0").DataBind.Bind("DT_1", "Fecha")
            Me.Matrix0.Columns.Item("Col_1").DataBind.Bind("DT_1", "hora")
            Me.Matrix0.Columns.Item("Col_2").DataBind.Bind("DT_1", "Venta")
            Me.Matrix0.Columns.Item("Col_3").DataBind.Bind("DT_1", "Prometida")
            Me.Matrix0.Columns.Item("Col_4").DataBind.Bind("DT_1", "Ter_desarr")
            Me.Matrix0.Columns.Item("Col_5").DataBind.Bind("DT_1", "Ter_Prod")
            Me.Matrix0.Columns.Item("Col_6").DataBind.Bind("DT_1", "Ini_Desp")
            Me.Matrix0.Columns.Item("Col_7").DataBind.Bind("DT_1", "Ini_Mont")
            Me.Matrix0.Columns.Item("Col_8").DataBind.Bind("DT_1", "Ter_Mont")
            Me.Matrix0.Columns.Item("Col_9").DataBind.Bind("DT_1", "usuario")
            Me.Matrix0.Columns.Item("Col_10").DataBind.Bind("DT_1", "U_Doc_Ter_Desa")
            Me.Matrix0.Columns.Item("Col_11").DataBind.Bind("DT_1", "U_Doc_Ter_Prod")
            Me.Matrix0.Columns.Item("Col_12").DataBind.Bind("DT_1", "U_Doc_Ini_Despa")
            Me.Matrix0.Columns.Item("Col_13").DataBind.Bind("DT_1", "U_Doc_Ini_Monta")
            Me.Matrix0.Columns.Item("Col_14").DataBind.Bind("DT_1", "U_Doc_Term_Monta")
            Me.Matrix0.Columns.Item("Col_15").DataBind.Bind("DT_1", "Comentario")
            Me.Matrix0.Clear()
            Me.Matrix0.LoadFromDataSource()
            Me.Matrix0.AutoResizeColumns()

            Me.OnCustomInitialize()

        End Sub

        Public Overrides Sub OnInitializeFormEvents()
            AddHandler LoadAfter, AddressOf Me.Form_LoadAfter

        End Sub


        Private Sub OnCustomInitialize()

            'Dim oUDS As SAPbouiCOM.UserDataSource = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_1")
            'Dim sCodPrj As String = oUDS.ValueEx
            'Application.SBO_Application.MessageBox(sCodPrj)

            'Dim query As String = (" select convert(char(10),U_Fecha_Registro,103)  as Fecha,U_Hora_Registro2 as hora, convert(char(10),U_Fecha_Venta,103) as Venta, " & _
            '                       " convert(char(10),U_Fecha_Promet_Nvo,103) as Prometida,convert(char(10),U_Ter_Desar_Nvo ,103) as Ter_desarr,convert(char(10),U_Ter_Desar_Nvo ,103) as Ter_Prod, " & _
            '                       " convert(char(10),U_Ter_Desp_Nvo ,103) as Ini_Desp, convert(char(10),U_Ini_Mont_Nvo,103) as Ini_Mont, convert(char(10),U_Ter_Mont_Nvo ,103) as Ter_Mont, " & _
            '                       " U_Nom_Usuario as usuario " & _
            '                       " from [" + sBDComercial.Trim() + "].[dbo].[@ZHFPM]  " & _
            '                       " where U_PrjCode = '" + sCodProyecto.Trim() + "'" & _
            '                       " order by U_Fecha_Registro ")
            'Try

            '    Me.DT_1.ExecuteQuery(query)
            '    Me.Matrix0.Columns.Item("Col_0").DataBind.Bind("DT_1", "Fecha")
            '    Me.Matrix0.Columns.Item("Col_1").DataBind.Bind("DT_1", "hora")
            '    Me.Matrix0.Columns.Item("Col_2").DataBind.Bind("DT_1", "Venta")
            '    Me.Matrix0.Columns.Item("Col_3").DataBind.Bind("DT_1", "Prometida")
            '    Me.Matrix0.Columns.Item("Col_4").DataBind.Bind("DT_1", "Ter_desarr")
            '    Me.Matrix0.Columns.Item("Col_5").DataBind.Bind("DT_1", "Ter_Prod")
            '    Me.Matrix0.Columns.Item("Col_6").DataBind.Bind("DT_1", "Ini_Desp")
            '    Me.Matrix0.Columns.Item("Col_7").DataBind.Bind("DT_1", "Ini_Mont")
            '    Me.Matrix0.Columns.Item("Col_8").DataBind.Bind("DT_1", "Ter_Mont")
            '    Me.Matrix0.Columns.Item("Col_9").DataBind.Bind("DT_1", "usuario")

            '    Me.Matrix0.Clear()
            '    Me.Matrix0.LoadFromDataSource()
            '    Me.Matrix0.AutoResizeColumns()

            'Catch ex As Exception

            '    Application.SBO_Application.MessageBox(query)
            '    Application.SBO_Application.MessageBox(ex.Message)

            'End Try



        End Sub



        Private Sub Form_LoadAfter(pVal As SAPbouiCOM.SBOItemEventArg)


        End Sub



        Private Sub Button0_ClickBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles Button0.ClickBefore
            'Dim oUDS As SAPbouiCOM.UserDataSource = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_1")
            'Dim sCodPrj As String = oUDS.ValueEx
            'Application.SBO_Application.MessageBox(sCodPrj)

            Dim query As String = (" select convert(char(10),U_Fecha_Registro,103)  as Fecha,U_Hora_Registro2 as hora, convert(char(10),U_Fecha_Venta,103) as Venta, " & _
                                   " convert(char(10),U_Fecha_Promet_Nvo,103) as Prometida,convert(char(10),U_Ter_Desar_Nvo ,103) as Ter_desarr,convert(char(10),U_Ter_Desar_Nvo ,103) as Ter_Prod, " & _
                                   " convert(char(10),U_Ter_Desp_Nvo ,103) as Ini_Desp, convert(char(10),U_Ini_Mont_Nvo,103) as Ini_Mont, convert(char(10),U_Ter_Mont_Nvo ,103) as Ter_Mont, " & _
                                   " U_Nom_Usuario as usuario,[U_Doc_Ter_Desa],[U_Doc_Ter_Prod],[U_Doc_Ini_Despa],[U_Doc_Ini_Monta],[U_Doc_Term_Monta],isnull(U_Comentario,'')  as comentario " & _
                                   " from [" + sBDComercial.Trim() + "].[dbo].[@ZHFPM]  " & _
                                   " where U_PrjCode = '" + Me.EditText0.Value.Trim() + "'" & _
                                   " order by U_Fecha_Registro ")
            Try

                Me.DT_1.ExecuteQuery(query)
                Me.Matrix0.Columns.Item("Col_0").DataBind.Bind("DT_1", "Fecha")
                Me.Matrix0.Columns.Item("Col_1").DataBind.Bind("DT_1", "hora")
                Me.Matrix0.Columns.Item("Col_2").DataBind.Bind("DT_1", "Venta")
                Me.Matrix0.Columns.Item("Col_3").DataBind.Bind("DT_1", "Prometida")
                Me.Matrix0.Columns.Item("Col_4").DataBind.Bind("DT_1", "Ter_desarr")
                Me.Matrix0.Columns.Item("Col_5").DataBind.Bind("DT_1", "Ter_Prod")
                Me.Matrix0.Columns.Item("Col_6").DataBind.Bind("DT_1", "Ini_Desp")
                Me.Matrix0.Columns.Item("Col_7").DataBind.Bind("DT_1", "Ini_Mont")
                Me.Matrix0.Columns.Item("Col_8").DataBind.Bind("DT_1", "Ter_Mont")
                Me.Matrix0.Columns.Item("Col_9").DataBind.Bind("DT_1", "usuario")
                Me.Matrix0.Columns.Item("Col_10").DataBind.Bind("DT_1", "U_Doc_Ter_Desa")
                Me.Matrix0.Columns.Item("Col_11").DataBind.Bind("DT_1", "U_Doc_Ter_Prod")
                Me.Matrix0.Columns.Item("Col_12").DataBind.Bind("DT_1", "U_Doc_Ini_Despa")
                Me.Matrix0.Columns.Item("Col_13").DataBind.Bind("DT_1", "U_Doc_Ini_Monta")
                Me.Matrix0.Columns.Item("Col_14").DataBind.Bind("DT_1", "U_Doc_Term_Monta")
                Me.Matrix0.Columns.Item("Col_14").DataBind.Bind("DT_1", "Comentario")

                Me.Matrix0.Clear()
                Me.Matrix0.LoadFromDataSource()
                Me.Matrix0.AutoResizeColumns()

            Catch ex As Exception

                Application.SBO_Application.MessageBox(query)
                Application.SBO_Application.MessageBox(ex.Message)

            End Try

        End Sub

        Private Sub Matrix0_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Matrix0.ClickAfter

            oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
            oMatrix = oForm.Items.Item("Item_0").Specific 'matrix
            Dim rowNum As Integer = oMatrix.GetNextSelectedRow(0, SAPbouiCOM.BoOrderType.ot_RowOrder)
            Try
                oMatrix.SelectRow(pVal.Row, True, False)
            Catch
            End Try

        End Sub

        Private Sub Matrix0_DoubleClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Matrix0.DoubleClickAfter

            oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
            oMatrix = oForm.Items.Item("Item_0").Specific 'Seleccionar Matrix

            If pVal.ColUID = "Col_10" Then
                oedit = oMatrix.Columns.Item(pVal.ColUID).Cells.Item(pVal.Row).Specific ' Selecciona el contenido de la celda
                oFunciones.Open_File(oedit.Value.Trim)
            End If

            If pVal.ColUID = "Col_11" Then
                oedit = oMatrix.Columns.Item(pVal.ColUID).Cells.Item(pVal.Row).Specific ' Selecciona el contenido de la celda
                oFunciones.Open_File(oedit.Value.Trim)
            End If

            If pVal.ColUID = "Col_12" Then
                oedit = oMatrix.Columns.Item(pVal.ColUID).Cells.Item(pVal.Row).Specific ' Selecciona el contenido de la celda
                oFunciones.Open_File(oedit.Value.Trim)
            End If

            If pVal.ColUID = "Col_13" Then
                oedit = oMatrix.Columns.Item(pVal.ColUID).Cells.Item(pVal.Row).Specific ' Selecciona el contenido de la celda
                oFunciones.Open_File(oedit.Value.Trim)
            End If

            If pVal.ColUID = "Col_14" Then
                oedit = oMatrix.Columns.Item(pVal.ColUID).Cells.Item(pVal.Row).Specific ' Selecciona el contenido de la celda
                oFunciones.Open_File(oedit.Value.Trim)
            End If

        End Sub


        Private WithEvents Matrix0 As SAPbouiCOM.Matrix
        Private WithEvents EditText0 As SAPbouiCOM.EditText
        Private WithEvents StaticText0 As SAPbouiCOM.StaticText
        Private WithEvents EditText1 As SAPbouiCOM.EditText
        Private WithEvents StaticText1 As SAPbouiCOM.StaticText
        Private WithEvents EditText2 As SAPbouiCOM.EditText
        Private WithEvents StaticText2 As SAPbouiCOM.StaticText
        Private WithEvents DT_1 As SAPbouiCOM.DataTable
        Private WithEvents Button0 As SAPbouiCOM.Button


    End Class
End Namespace
