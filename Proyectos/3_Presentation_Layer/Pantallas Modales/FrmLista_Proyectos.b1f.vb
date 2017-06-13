Option Strict Off
Option Explicit On

Imports SAPbouiCOM.Framework

Namespace SBOAddonProject1
    <FormAttribute("SBOAddonProject1.Form2", "3_Presentation_Layer/Pantallas Modales/FrmLista_Proyectos.b1f")>
    Friend Class Form2
        Inherits UserFormBase


        Public Ultima_Busqueda As String = ""

        Public Sub New()
        End Sub



#Region "Respaldo de OnInitializeComponent"
        'Me.Button0 = CType(Me.GetItem("Item_1").Specific, SAPbouiCOM.Button)
        '    Me.Button1 = CType(Me.GetItem("Item_2").Specific, SAPbouiCOM.Button)
        '    Me.EditText0 = CType(Me.GetItem("Item_3").Specific, SAPbouiCOM.EditText)
        '    Me.StaticText0 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.StaticText)
        '    Me.Matrix0 = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.Matrix)
        '    Me.DT_1 = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_1")
        'Dim query As String = ("SELECT PrjCode as Codigo ,PrjName as Nombre FROM [" + sBDComercial.Trim() + "].DBO.OPRJ where PrjCode in (select Pr" & _
        '    "" + "oject  from [" + sBDComercial.Trim() + "].DBO.ORDR)")
        'Try
        '        Application.SBO_Application.Forms.ActiveForm.Freeze(True)
        '        Me.DT_1.ExecuteQuery(query)
        ''Me.Matrix0.Columns.Item("#").DataBind.Bind("DT_1", "Row")
        '        Me.Matrix0.Columns.Item("Codigo").DataBind.Bind("DT_1", "Codigo")
        '        Me.Matrix0.Columns.Item("Desc").DataBind.Bind("DT_1", "Nombre")
        '        Me.Matrix0.Clear()
        '        Me.Matrix0.LoadFromDataSource()
        '        Me.Matrix0.AutoResizeColumns()
        '    Catch ex As Exception

        '    Finally
        '        Application.SBO_Application.Forms.ActiveForm.Freeze(False)
        '    End Try
        '    Me.EditText1 = CType(Me.GetItem("Item_5").Specific, SAPbouiCOM.EditText)
        '    Me.Button2 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.Button)
#End Region

        Public Overrides Sub OnInitializeComponent()
            Me.Button0 = CType(Me.GetItem("Item_1").Specific, SAPbouiCOM.Button)
            Me.Button1 = CType(Me.GetItem("Item_2").Specific, SAPbouiCOM.Button)
            Me.EditText0 = CType(Me.GetItem("Item_3").Specific, SAPbouiCOM.EditText)
            Me.StaticText0 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.StaticText)
            Me.Button2 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.Button)
            Me.Folder0 = CType(Me.GetItem("Item_8").Specific, SAPbouiCOM.Folder)
            Me.DT_1 = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_1")
            Me.DT_SQL = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_SQL")
            Me.DT_SQL2 = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_SQL2")

            Me.OnCustomInitialize()

        End Sub

        Public Overrides Sub OnInitializeFormEvents()
            AddHandler LoadAfter, AddressOf Me.Form_LoadAfter

        End Sub

        Private Sub OnCustomInitialize()

            Me.Matrix0 = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.Matrix)
            Me.Matrix0.Item.FromPane = 1
            Me.Matrix0.Item.ToPane = 1
            'Matrix0.Item.Visible = False

            Dim query As String = "EXEC [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Consultar_Proyecto] ''"

            Try
                'Application.SBO_Application.Forms.ActiveForm.Freeze(True)
                Me.DT_1.ExecuteQuery(query)
                'Me.Matrix0.Columns.Item("#").DataBind.Bind("DT_1", "Row")
                Me.Matrix0.Columns.Item("Codigo").DataBind.Bind("DT_1", "Codigo")
                Me.Matrix0.Columns.Item("Desc").DataBind.Bind("DT_1", "Nombre")
                Me.Matrix0.Clear()
                Me.Matrix0.LoadFromDataSource()
                Me.Matrix0.AutoResizeColumns()


            Catch ex As Exception

            Finally
                'Application.SBO_Application.Forms.ActiveForm.Freeze(False)
            End Try

            Me.UIAPIRawForm.ReportType = "Modal"

        End Sub

        Public Shared Sub SBO_Application_ItemEvent(ByVal FormUID As String, ByRef pVal As SAPbouiCOM.ItemEvent, ByRef BubbleEvent As Boolean)

            If (pVal.EventType = SAPbouiCOM.BoEventTypes.et_FORM_LOAD And pVal.BeforeAction = True) Then

                oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
                oItem = oForm.Items.Add("Matrix_0", SAPbouiCOM.BoFormItemTypes.it_MATRIX)
                oItem.Top = 58
                oItem.Left = 30
                oItem.Height = 202
                oItem.Width = 496
                oItem.FromPane = 1
                oItem.ToPane = 1

            End If

        End Sub
        Private Sub Form_LoadAfter(pVal As SAPbouiCOM.SBOItemEventArg)

            'oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
            'oItem = oForm.Items.Item("Matrix_0")
            'Me.Matrix_0 = CType(oItem.Specific, SAPbouiCOM.Matrix)
            'Me.Matrix_0.SelectionMode = SAPbouiCOM.BoMatrixSelect.ms_Single
            'oColumns = Matrix_0.Columns
            'oColumn = oColumns.Add("#", SAPbouiCOM.BoFormItemTypes.it_EDIT)
            'oColumn.TitleObject.Caption = "#"
            'oColumn.Width = 25
            'oColumn.Editable = False
            'oColumn = oColumns.Add("Codigo", SAPbouiCOM.BoFormItemTypes.it_EDIT)
            'oColumn.TitleObject.Caption = "Codigo de Proyecto"
            'oColumn.Width = 100
            'oColumn.Editable = False
            'oColumn = oColumns.Add("Desc", SAPbouiCOM.BoFormItemTypes.it_EDIT)
            'oColumn.TitleObject.Caption = "Nombre del Proyeto"
            'oColumn.Width = 350
            'oColumn.Editable = False

        End Sub
        Private Sub Button1_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button1.ClickAfter
            Application.SBO_Application.Forms.ActiveForm.Close()
        End Sub
        Private Sub Button0_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button0.ClickAfter

            Try
                Dim rowNum As Integer = Matrix0.GetNextSelectedRow(0, SAPbouiCOM.BoOrderType.ot_RowOrder)
                Dim sCodigo = Matrix0.Columns.Item("Codigo").Cells.Item(rowNum).Specific.Value ' Selecciona el contenido de la celda

                ' Enviar Codigo a Form Principal
                Dim oUDS As SAPbouiCOM.UserDataSource = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_0")
                Dim FormPID As String = oUDS.ValueEx        'Traer el FormUID del Formulario Principal guardado en el User Data Source
                oUDS = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_1")
                Dim sOrig As String = oUDS.ValueEx        'Traer el valor que nos determina el Form de Origen
                Dim oFormP As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(FormPID)

                Try
                    Select Case sOrig
                        Case "GLOBAL"
                            FrmEstado_Global.Cargar_Campos_Estado_Global(FormPID, sCodigo, DT_SQL, DT_SQL2)
                        Case "PLANOS"
                            oFormP.DataSources.UserDataSources.Item("UD_CFL").ValueEx = sCodigo
                            SBOAddonProject1.Form11.Cargar_Datos(FormPID)
                    End Select

                    Application.SBO_Application.Forms.Item(pVal.FormUID).Close()

                Catch ex As Exception
                End Try

                Me.UIAPIRawForm.Close()

            Catch
            End Try

        End Sub
        Private Sub EditText0_KeyDownAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText0.KeyDownAfter

            Select Case pVal.CharPressed
                Case 13

                    If EditText0.Value.Trim = Ultima_Busqueda Or (EditText0.Value.Trim.Length = 0 And Ultima_Busqueda = "°#TODOS LOS REGISTROS#°") Then
                        Me.Button0_ClickAfter(sboObject, pVal)
                    Else
                        Me.Button2_ClickAfter(sboObject, pVal)
                    End If

                Case 40

                    If Me.Matrix0.RowCount > 0 Then
                        Try
                            Dim rowNum As Integer = Me.Matrix0.GetNextSelectedRow(0, SAPbouiCOM.BoOrderType.ot_RowOrder)
                            Me.Matrix0.SelectRow(If(rowNum < 1, 1, rowNum + 1), True, False)
                        Catch ex As Exception

                        End Try
                    End If

                Case 38

                    If Me.Matrix0.RowCount > 0 Then
                        Try
                            Dim rowNum As Integer = Me.Matrix0.GetNextSelectedRow(0, SAPbouiCOM.BoOrderType.ot_RowOrder)
                            Me.Matrix0.SelectRow(If(rowNum < 1, 1, rowNum - 1), True, False)
                        Catch ex As Exception

                        End Try
                    End If

            End Select

        End Sub
        Private Sub Matrix0_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Matrix0.ClickAfter ', Matrix_0.ClickAfter
            oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
            oMatrix = oForm.Items.Item(pVal.ItemUID).Specific 'matrix
            Dim rowNum As Integer = oMatrix.GetNextSelectedRow(0, SAPbouiCOM.BoOrderType.ot_RowOrder)
            Try
                oMatrix.SelectRow(pVal.Row, True, False)
            Catch
            End Try

        End Sub
        Private Sub Matrix0_DoubleClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Matrix0.DoubleClickAfter

            Try
                Button0.Item.Click()
            Catch
            End Try

        End Sub
        Private Sub Button2_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button2.ClickAfter

            Try
                If EditText0.Value.Trim().Length > 0 Then
                    Dim query As String = "EXEC [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Consultar_Proyecto] '" + EditText0.Value.Trim() + "'"
                    Try
                        Application.SBO_Application.Forms.ActiveForm.Freeze(True)
                        Me.DT_1.ExecuteQuery(query)
                        Me.Matrix0.Columns.Item("Codigo").DataBind.Bind("DT_1", "Codigo")
                        Me.Matrix0.Columns.Item("Desc").DataBind.Bind("DT_1", "Nombre")
                        Me.Matrix0.Clear()
                        Me.Matrix0.LoadFromDataSource()
                        Me.Matrix0.AutoResizeColumns()

                        Ultima_Busqueda = EditText0.Value.Trim

                    Catch ex As Exception

                    Finally
                        Application.SBO_Application.Forms.ActiveForm.Freeze(False)
                    End Try

                Else
                    Dim query As String = "EXEC [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Consultar_Proyecto] ''"
                    Try
                        Application.SBO_Application.Forms.ActiveForm.Freeze(True)
                        Me.DT_1.ExecuteQuery(query)
                        Me.Matrix0.Columns.Item("Codigo").DataBind.Bind("DT_1", "Codigo")
                        Me.Matrix0.Columns.Item("Desc").DataBind.Bind("DT_1", "Nombre")
                        Me.Matrix0.Clear()
                        Me.Matrix0.LoadFromDataSource()
                        Me.Matrix0.AutoResizeColumns()

                        Ultima_Busqueda = "°#TODOS LOS REGISTROS#°"

                    Catch ex As Exception

                    Finally
                        Application.SBO_Application.Forms.ActiveForm.Freeze(False)
                    End Try

                End If
            Catch ex As Exception

            End Try

        End Sub


        Private WithEvents Button0 As SAPbouiCOM.Button
        Private WithEvents Button1 As SAPbouiCOM.Button
        Private WithEvents EditText0 As SAPbouiCOM.EditText
        Private WithEvents StaticText0 As SAPbouiCOM.StaticText
        Private WithEvents Button2 As SAPbouiCOM.Button
        Private WithEvents Folder0 As SAPbouiCOM.Folder
        Private WithEvents DT_1 As SAPbouiCOM.DataTable
        Private WithEvents DT_SQL As SAPbouiCOM.DataTable
        Private WithEvents DT_SQL2 As SAPbouiCOM.DataTable
        Private WithEvents Matrix0 As SAPbouiCOM.Matrix
        'Private WithEvents Matrix_0 As SAPbouiCOM.Matrix

        Private Sub Matrix0_ValidateAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg)

        End Sub
    End Class
End Namespace
