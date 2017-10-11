Option Strict Off
Option Explicit On

Imports SAPbouiCOM.Framework
Imports System.IO
Imports SAPbobsCOM

Namespace SBOAddonProject1
    <FormAttribute("SBOAddonProject1.Form11", "3_Presentation_Layer/Pantallas Principales/FrmGestion_Planos.b1f")>
    Friend Class Form11
        Inherits UserFormBase

        Dim SelecRow As Integer = 0

        Public Sub New()
        End Sub

#Region "Respaldo de OnInitializeComponent"
        'Me.EditText0 = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.EditText)
        '     Me.EditText1 = CType(Me.GetItem("Item_3").Specific, SAPbouiCOM.EditText)
        '     Me.Matrix0 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.Matrix)
        '     Me.EditText2 = CType(Me.GetItem("Item_5").Specific, SAPbouiCOM.EditText)
        '     Me.StaticText0 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.StaticText)
        '     Me.StaticText1 = CType(Me.GetItem("Item_7").Specific, SAPbouiCOM.StaticText)
        '     Me.EditText3 = CType(Me.GetItem("Item_8").Specific, SAPbouiCOM.EditText)
        '     Me.StaticText2 = CType(Me.GetItem("Item_9").Specific, SAPbouiCOM.StaticText)
        '     Me.StaticText3 = CType(Me.GetItem("Item_10").Specific, SAPbouiCOM.StaticText)
        '     Me.Button1 = CType(Me.GetItem("Item_11").Specific, SAPbouiCOM.Button)
        '     Me.Button2 = CType(Me.GetItem("Item_12").Specific, SAPbouiCOM.Button)
        '     Me.CFL_0 = Me.UIAPIRawForm.ChooseFromLists.Item("CFL_0")
        '     Me.EditText4 = CType(Me.GetItem("Item_1").Specific, SAPbouiCOM.EditText)
        '     Me.Button4 = CType(Me.GetItem("Item_14").Specific, SAPbouiCOM.Button)
        '     Me.StaticText4 = CType(Me.GetItem("Item_15").Specific, SAPbouiCOM.StaticText)
        '     Me.ComboBox0 = CType(Me.GetItem("Item_16").Specific, SAPbouiCOM.ComboBox)
        '     Me.StaticText5 = CType(Me.GetItem("Item_17").Specific, SAPbouiCOM.StaticText)
        '     Me.EditText5 = CType(Me.GetItem("Item_18").Specific, SAPbouiCOM.EditText)
        '     Me.StaticText6 = CType(Me.GetItem("Item_19").Specific, SAPbouiCOM.StaticText)
        '     Me.ComboBox1 = CType(Me.GetItem("Item_20").Specific, SAPbouiCOM.ComboBox)
        '     Me.StaticText7 = CType(Me.GetItem("Item_21").Specific, SAPbouiCOM.StaticText)
        '     Me.Button0 = CType(Me.GetItem("Item_24").Specific, SAPbouiCOM.Button)
        '     Me.DT_0 = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_0")
        '     Me.DT_1 = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_1")
        '     Me.DT_2 = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_2")
        '     Me.DT_SQL = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_SQL")
        '     Me.Button3 = CType(Me.GetItem("Item_29").Specific, SAPbouiCOM.Button)
        '     Me.Button5 = CType(Me.GetItem("Item_25").Specific, SAPbouiCOM.Button)
        '     Me.Folder3 = CType(Me.GetItem("Item_33").Specific, SAPbouiCOM.Folder)
        '     Me.Folder5 = CType(Me.GetItem("Item_35").Specific, SAPbouiCOM.Folder)
        '     Me.Matrix1 = CType(Me.GetItem("Item_37").Specific, SAPbouiCOM.Matrix)
        '     Me.StaticText8 = CType(Me.GetItem("Item_38").Specific, SAPbouiCOM.StaticText)
        '     Me.ComboBox0.Select("Produccion", CType(0, SAPbouiCOM.BoSearchKey))
        '     Me.ComboBox1.Select("Activo", CType(0, SAPbouiCOM.BoSearchKey))
        '     Me.LinkedButton0 = CType(Me.GetItem("Item_26").Specific, SAPbouiCOM.LinkedButton)
        '     Me.CheckBox0 = CType(Me.GetItem("Item_22").Specific, SAPbouiCOM.CheckBox)
        '     Me.EditText0.Item.AffectsFormMode = False
        '     Me.EditText1.Item.AffectsFormMode = False
        '     Me.EditText2.Item.AffectsFormMode = False
        '     Me.EditText3.Item.AffectsFormMode = False
        '     Me.EditText4.Item.AffectsFormMode = False
        '     Me.EditText5.Item.AffectsFormMode = False
        '     Me.ComboBox0.Item.AffectsFormMode = False
        '     Me.ComboBox1.Item.AffectsFormMode = False
        '     Me.CheckBox0.Item.AffectsFormMode = False
        '     Me.Folder3.Item.AffectsFormMode = False
        '     Me.Folder5.Item.AffectsFormMode = False
        '     Me.Matrix0.Item.AffectsFormMode = False
        '     Me.Matrix1.Item.AffectsFormMode = False
        '     Me.CheckBox0.Item.Width = 150
        '     Me.CheckBox0.Checked = True
        '     Me.Button6 = CType(Me.GetItem("Item_23").Specific, SAPbouiCOM.Button)
        '     Me.PictureBox0 = CType(Me.GetItem("Item_30").Specific, SAPbouiCOM.PictureBox)
        '     Me.PictureBox1 = CType(Me.GetItem("Item_31").Specific, SAPbouiCOM.PictureBox)
        '     Me.OnCustomInitialize()
#End Region

        Public Overrides Sub OnInitializeComponent()
            Me.EditText0 = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.EditText)
            Me.EditText1 = CType(Me.GetItem("Item_3").Specific, SAPbouiCOM.EditText)
            Me.Matrix0 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.Matrix)
            Me.EditText2 = CType(Me.GetItem("Item_5").Specific, SAPbouiCOM.EditText)
            Me.StaticText0 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.StaticText)
            Me.StaticText1 = CType(Me.GetItem("Item_7").Specific, SAPbouiCOM.StaticText)
            Me.EditText3 = CType(Me.GetItem("Item_8").Specific, SAPbouiCOM.EditText)
            Me.StaticText2 = CType(Me.GetItem("Item_9").Specific, SAPbouiCOM.StaticText)
            Me.StaticText3 = CType(Me.GetItem("Item_10").Specific, SAPbouiCOM.StaticText)
            Me.Button1 = CType(Me.GetItem("Item_11").Specific, SAPbouiCOM.Button)
            Me.Button2 = CType(Me.GetItem("Item_12").Specific, SAPbouiCOM.Button)
            Me.EditText4 = CType(Me.GetItem("Item_1").Specific, SAPbouiCOM.EditText)
            Me.Button4 = CType(Me.GetItem("Item_14").Specific, SAPbouiCOM.Button)
            Me.StaticText4 = CType(Me.GetItem("Item_15").Specific, SAPbouiCOM.StaticText)
            Me.ComboBox0 = CType(Me.GetItem("Item_16").Specific, SAPbouiCOM.ComboBox)
            Me.StaticText5 = CType(Me.GetItem("Item_17").Specific, SAPbouiCOM.StaticText)
            Me.EditText5 = CType(Me.GetItem("Item_18").Specific, SAPbouiCOM.EditText)
            Me.StaticText6 = CType(Me.GetItem("Item_19").Specific, SAPbouiCOM.StaticText)
            Me.ComboBox1 = CType(Me.GetItem("Item_20").Specific, SAPbouiCOM.ComboBox)
            Me.StaticText7 = CType(Me.GetItem("Item_21").Specific, SAPbouiCOM.StaticText)
            Me.Button0 = CType(Me.GetItem("Item_24").Specific, SAPbouiCOM.Button)
            Me.DT_0 = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_0")
            Me.DT_1 = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_1")
            Me.DT_2 = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_2")
            Me.DT_SQL = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_SQL")
            Me.Button3 = CType(Me.GetItem("Item_29").Specific, SAPbouiCOM.Button)
            Me.Button5 = CType(Me.GetItem("Item_25").Specific, SAPbouiCOM.Button)
            Me.Folder3 = CType(Me.GetItem("Item_33").Specific, SAPbouiCOM.Folder)
            Me.Folder5 = CType(Me.GetItem("Item_35").Specific, SAPbouiCOM.Folder)
            Me.Matrix1 = CType(Me.GetItem("Item_37").Specific, SAPbouiCOM.Matrix)
            Me.StaticText8 = CType(Me.GetItem("Item_38").Specific, SAPbouiCOM.StaticText)
            Me.ComboBox0.Select("Produccion", CType(0, SAPbouiCOM.BoSearchKey))
            Me.ComboBox1.Select("Activo", CType(0, SAPbouiCOM.BoSearchKey))
            Me.CheckBox0 = CType(Me.GetItem("Item_22").Specific, SAPbouiCOM.CheckBox)
            Me.EditText0.Item.AffectsFormMode = False
            Me.EditText1.Item.AffectsFormMode = False
            Me.EditText2.Item.AffectsFormMode = False
            Me.EditText3.Item.AffectsFormMode = False
            Me.EditText4.Item.AffectsFormMode = False
            Me.EditText5.Item.AffectsFormMode = False
            Me.ComboBox0.Item.AffectsFormMode = False
            Me.ComboBox1.Item.AffectsFormMode = False
            Me.CheckBox0.Item.AffectsFormMode = False
            Me.Folder3.Item.AffectsFormMode = False
            Me.Folder5.Item.AffectsFormMode = False
            Me.Matrix0.Item.AffectsFormMode = False
            Me.Matrix1.Item.AffectsFormMode = False
            Me.CheckBox0.Item.Width = 150
            Me.CheckBox0.Checked = True
            Me.Button6 = CType(Me.GetItem("Item_23").Specific, SAPbouiCOM.Button)
            Me.Button7 = CType(Me.GetItem("Item_26").Specific, SAPbouiCOM.Button)
            Me.Button8 = CType(Me.GetItem("Item_27").Specific, SAPbouiCOM.Button)
            Me.Button9 = CType(Me.GetItem("Item_28").Specific, SAPbouiCOM.Button)
            Me.OnCustomInitialize()

        End Sub

        Public Overrides Sub OnInitializeFormEvents()
            AddHandler LoadAfter, AddressOf Me.Form_LoadAfter
            AddHandler ResizeAfter, AddressOf Me.Form_ResizeAfter

        End Sub


        Private Sub OnCustomInitialize()

            Me.UIAPIRawForm.EnableMenu(1281, True)  'Buscar
            Me.UIAPIRawForm.EnableMenu(1282, False) 'Crear
            Me.Button9.Item.Visible = False

            oForm = Application.SBO_Application.Forms.Item(Me.UIAPIRawForm.UniqueID)
            oForm.PaneLevel = 2
            Me.Button5.Item.Visible = False
            Me.Button6.Item.Visible = False
            oForm.PaneLevel = 1
            Me.Folder3.Item.Click()

        End Sub

        Private Sub Form_LoadAfter(pVal As SAPbouiCOM.SBOItemEventArg)
        End Sub

        Private Sub Form_ResizeAfter(pVal As SAPbouiCOM.SBOItemEventArg)
   
        End Sub

        Private Sub Button4_ClickBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles Button4.ClickBefore

            'Me.EditText4.String = NOpenFileDialog.ShowOpenFileDialog()
            'oForm = Application.SBO_Application.Forms.Item(Me.UIAPIRawForm.UniqueID)
            'oedit = oForm.Items.Item("Item_30").Specific
            'oedit.Item.Click(SAPbouiCOM.BoCellClickType.ct_Double)
            'Me.EditText4.String = NOpenDialog.OpenFileDialog()
            If EditText0.Value.Trim.Length > 0 Then
                oFunciones.Abre_Dialogo_y_Asigna_Path3(Me.EditText4, DialogType.OPEN)
            Else
                Application.SBO_Application.StatusBar.SetText("Debe Seleccionar un Proyecto", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
            End If

        End Sub

        Private Sub EditText4_DoubleClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText4.DoubleClickAfter
            If Me.EditText4.Value.Trim.Length() > 0 Then
                oFunciones.Open_File(Me.EditText4.Value.Trim)
            End If
        End Sub

        Private Sub Button2_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button2.ClickAfter

            ' Insertar un nuevo registro en la Matrix por medio del DataTable
            Try
                Me.UIAPIRawForm.Freeze(True)
                If EditText0.Value.Trim.Length > 0 Then
                    If Button2.Caption = "Agregar" Then
                        If Me.EditText4.Value.Trim.Length() > 0 Then

                            oForm = Application.SBO_Application.Forms.ActiveForm()

                            Try

                                If Me.Matrix0.RowCount > 0 Then
                                    DT_0.Rows.Add()
                                End If

                                Dim nRow As Integer = DT_0.Rows.Count - 1
                                DT_0.SetValue("Fila", nRow, nRow + 1)
                                DT_0.SetValue("Archivo", nRow, Me.EditText4.Value.Trim())
                                DT_0.SetValue("Estado", nRow, If(Me.ComboBox1.Value.Trim.Length > 0, Me.ComboBox1.Value.Trim(), "Activo"))
                                DT_0.SetValue("Destino", nRow, Me.ComboBox0.Value.Trim())
                                DT_0.SetValue("Fecha", nRow, Date.Now)
                                DT_0.SetValue("Hora", nRow, DateTime.Now.ToLongTimeString())
                                DT_0.SetValue("Comentario", nRow, Me.EditText5.Value.Trim())
                                DT_0.SetValue("RutaInic", nRow, Me.EditText4.Value.Trim())

                            Catch ex As Exception
                                Application.SBO_Application.MessageBox("Error al Cargar el DataTable 'DTO_0'")
                            End Try

                            Try

                                Me.Matrix0.Columns.Item("#").DataBind.Bind("DT_0", "Fila")
                                Me.Matrix0.Columns.Item("Col_0").DataBind.Bind("DT_0", "Archivo")
                                Me.Matrix0.Columns.Item("Col_2").DataBind.Bind("DT_0", "Estado")
                                Me.Matrix0.Columns.Item("Col_4").DataBind.Bind("DT_0", "Destino")
                                Me.Matrix0.Columns.Item("Col_1").DataBind.Bind("DT_0", "Fecha")
                                Me.Matrix0.Columns.Item("Col_3").DataBind.Bind("DT_0", "Hora")
                                Me.Matrix0.Columns.Item("Col_5").DataBind.Bind("DT_0", "Comentario")
                                Me.Matrix0.Columns.Item("Col_6").DataBind.Bind("DT_0", "RutaInic")

                                oForm.Freeze(True)

                                Me.Matrix0.Clear()
                                Me.Matrix0.LoadFromDataSource()
                                Me.Matrix0.AutoResizeColumns()

                                Me.EditText4.Value = ""
                                Me.EditText5.Value = ""
                                Me.EditText5.Item.Click()

                            Catch ex As Exception
                                Application.SBO_Application.MessageBox("Error al Cargar Matrix desde el DataTable 'DTO_0'")
                            Finally
                                oForm.Freeze(False)
                            End Try
                        End If
                    ElseIf Button2.Caption = "Modificar" Then

                        DT_0.SetValue("Estado", SelecRow - 1, If(Me.ComboBox1.Value.Trim.Length > 0, Me.ComboBox1.Value.Trim(), "Activo"))
                        DT_0.SetValue("Destino", SelecRow - 1, Me.ComboBox0.Value.Trim())
                        DT_0.SetValue("Fecha", SelecRow - 1, Date.Now)
                        DT_0.SetValue("Hora", SelecRow - 1, DateTime.Now.ToLongTimeString())
                        DT_0.SetValue("Comentario", SelecRow - 1, Me.EditText5.Value.Trim())

                        Me.Matrix0.Clear()
                        Me.Matrix0.LoadFromDataSource()
                        Me.Matrix0.AutoResizeColumns()

                    End If
                Else
                    Application.SBO_Application.StatusBar.SetText("Debe Seleccionar un Proyecto", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
                End If
            Catch ex As Exception
            Finally
                Me.UIAPIRawForm.Freeze(False)
            End Try

        End Sub

        Private Sub Matrix0_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Matrix0.ClickAfter

            Dim rowNum As Integer = Me.Matrix0.GetNextSelectedRow(0, SAPbouiCOM.BoOrderType.ot_RowOrder)
            Try
                Me.Matrix0.SelectRow(pVal.Row, True, False)

                Me.UIAPIRawForm.Freeze(True)

                SelecRow = pVal.Row
                Me.Button2.Caption = "Modificar"
                Me.Button9.Item.Visible = True
                ComboBox1.Select(Me.Matrix0.Columns.Item("Col_2").Cells.Item(pVal.Row).Specific.Value(), SAPbouiCOM.BoSearchKey.psk_ByDescription)
                ComboBox0.Select(Me.Matrix0.Columns.Item("Col_4").Cells.Item(pVal.Row).Specific.Value(), SAPbouiCOM.BoSearchKey.psk_ByDescription)
                EditText5.Value = Me.Matrix0.Columns.Item("Col_5").Cells.Item(pVal.Row).Specific.Value()
                EditText4.Value = Me.Matrix0.Columns.Item("Col_0").Cells.Item(pVal.Row).Specific.Value()
                'Fecha = DateTime.ParseExact(Me.Matrix0.Columns.Item("Col_1").Cells.Item(pVal.Row).Specific.Value(), "yyyyMMdd", Nothing).ToString("dd\/MM\/yyyy")
                'Hora = Me.Matrix0.Columns.Item("Col_3").Cells.Item(pVal.Row).Specific.Value()

            Catch
            Finally
                Me.UIAPIRawForm.Freeze(False)
            End Try

        End Sub

        Private Sub Matrix0_DoubleClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Matrix0.DoubleClickAfter


            If pVal.ColUID = "Col_0" Then
                oedit = Me.Matrix0.Columns.Item(pVal.ColUID).Cells.Item(pVal.Row).Specific ' Selecciona el contenido de la celda
                oFunciones.Open_File(oedit.Value.Trim)
            End If

        End Sub

        Private Sub Matrix1_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Matrix1.ClickAfter

            Dim rowNum As Integer = Me.Matrix1.GetNextSelectedRow(0, SAPbouiCOM.BoOrderType.ot_RowOrder)
            Try
                Me.Matrix1.SelectRow(pVal.Row, True, False)
            Catch
            End Try

        End Sub

        Private Sub Button1_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button1.ClickAfter
            'Eliminar una fila de la Matrix mediante el DataTable
            oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
            Dim rowNum As Integer = Me.Matrix0.GetNextSelectedRow(0, SAPbouiCOM.BoOrderType.ot_RowOrder) - 1

            Try
                oForm.Freeze(True)
                Me.DT_0.Rows.Remove(rowNum)

                For index = 0 To Me.DT_0.Rows.Count - 1
                    DT_0.SetValue("Fila", index, index + 1)
                Next

                Me.Matrix0.Clear()
                Me.Matrix0.LoadFromDataSource()
            Catch ex As Exception
            Finally
                oForm.Freeze(False)
            End Try
        End Sub


        Private Sub Button0_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button0.ClickAfter

            Dim oUDS As SAPbouiCOM.UserDataSource = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_CFL") ' Este dato se Carga en el evento "If pVal.FormTypeEx = "SBOAddonProject1.Form11" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_CHOOSE_FROM_LIST And pVal.BeforeAction = False"
            Dim sCodiP As String = oUDS.ValueEx

            'Actualizar los Datos de los documentos en la tabla ZPLAP con las modificaciones realizadas sobre la matrix
            If Me.Matrix0.RowCount > 0 Then
                Me.Registrar_Planos_Proyecto(sCodiP, pVal.FormUID)
            Else  ' Aca se verifica la condicion: Si la matrix esta vacia y existen documento en la BD, se confirme borrar todos los datos en la BD.
                If Me.EditText0.Value.Trim().Length > 0 Then
                    Eliminar_Todos_Planos_Proyecto(sCodiP)
                    Inicializar_Datos_Documetos()
                End If
            End If

            'Actualizar los Datos de los usuario a los cuales se le enviaran los mensajes en la tabla ZUSMS con las selecciones realizadas sobre la matrix
            If Me.Matrix1.RowCount > 0 Then
                Me.Registrar_Datos_Usuarios_Mensajes()
            End If

            

        End Sub

        Private Sub Button3_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button3.ClickAfter
            'Recargar la Matrix
            oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
            Dim oUDS As SAPbouiCOM.UserDataSource = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_CFL") ' Este dato se Carga en el evento "If pVal.FormTypeEx = "SBOAddonProject1.Form11" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_CHOOSE_FROM_LIST And pVal.BeforeAction = False"
            Dim sCodiP As String = oUDS.ValueEx

            If sCodiP.Trim.Length > 0 Then

                If Application.SBO_Application.MessageBox("Recargar los Datos desde la BD, se Perderan los Cambios sin Actualizar", 2, "Recargar", "Cancelar") = 1 Then

                    Try
                        oForm.Freeze(True)
                        Cargar_Matrix(sCodiP, pVal.FormUID)
                    Catch ex As Exception

                    Finally
                        oForm.Freeze(False)
                    End Try

                End If

            End If
        End Sub

        Private Sub Button5_ClickBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles Button5.ClickBefore

            Dim activeForm2 As Form14
            activeForm2 = New Form14

            activeForm2.Show()

            'Dim R As Integer = Val(InputBox$("Red Value"))
            'Dim B As Integer = Val(InputBox$("Blue Value"))
            'Dim G As Integer = Val(InputBox$("Green Value"))
            'Dim Lng As Long = B * 65536 + G * 256 + R
            'MsgBox(Lng)

        End Sub

        Private Sub Button6_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button6.ClickAfter
            Try
                'Application.SBO_Application.OpenForm(140, "", "100005437")
                Dim oFormp As SAPbouiCOM.Form = Application.SBO_Application.OpenForm(140, "", "10")
                'oFormp.Select()

            Catch ex As Exception

            End Try

        End Sub

        Private Sub Button7_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button7.ClickAfter

            Dim activeForm2 As Form2
            activeForm2 = New Form2

            Dim oUDS As SAPbouiCOM.UserDataSource = activeForm2.UIAPIRawForm.DataSources.UserDataSources.Item("UD_0")
            oUDS.ValueEx = Me.UIAPIRawForm.UniqueID
            oUDS = activeForm2.UIAPIRawForm.DataSources.UserDataSources.Item("UD_1")
            oUDS.ValueEx = "PLANOS"

            activeForm2.Show()

        End Sub

        Private Sub Button9_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button9.ClickAfter
            Try
                Inicializar_Datos_Documetos()
            Catch ex As Exception
            End Try
        End Sub

        Private Sub Button8_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button8.ClickAfter
            Me.UIAPIRawForm.Close()
        End Sub

        Private Sub Folder5_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Folder5.ClickAfter

            oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
            oItem = oForm.Items.Item("Item_32")
            oItem.Height = 278
            oFolder = oItem.Specific
            oForm.Freeze(True)
            'Me.Folder5.Item.Height = 298
            'Me.Folder3.Item.Height = 298
            Me.Matrix1.Item.Height = 263
            Me.Matrix0.Item.Height = 113
            Me.Matrix0.Item.Top = 345
            oForm.Freeze(False)

        End Sub

        Private Sub Folder3_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Folder3.ClickAfter

            oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
            oItem = oForm.Items.Item("Item_32")
            oItem.Height = 95
            oFolder = oItem.Specific
            oForm.Freeze(True)
            'Me.Folder5.Item.Height = 115
            'Me.Folder3.Item.Height = 115
            Me.Matrix1.Item.Height = 80
            Me.Matrix0.Item.Height = 297
            Me.Matrix0.Item.Top = 162
            oForm.Freeze(False)

        End Sub

        Private Shared Sub Inicializar_Datos_Documetos()
            Try

                oForm.Items.Item("Item_28").Specific.Item.Visible = False
                oForm.Items.Item("Item_12").Specific.Caption = "Agregar"
                oForm.Items.Item("Item_16").Specific.Select(0, SAPbouiCOM.BoSearchKey.psk_Index)
                oForm.Items.Item("Item_20").Specific.Select(0, SAPbouiCOM.BoSearchKey.psk_Index)
                oForm.Items.Item("Item_1").Specific.Value = ""
                oForm.Items.Item("Item_18").Specific.Value = ""

            Catch ex As Exception
            End Try
        End Sub

        Public Shared Sub Cargar_Datos(FormID As String)

            Try
                oForm = Application.SBO_Application.Forms.Item(FormID)
                Inicializar_Datos_Documetos()
                Dim oUDS As SAPbouiCOM.UserDataSource = oForm.DataSources.UserDataSources.Item("UD_CFL") ' Este dato se Carga en el evento "If pVal.FormTypeEx = "SBOAddonProject1.Form11" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_CHOOSE_FROM_LIST And pVal.BeforeAction = False"
                oUDataTable = oForm.DataSources.DataTables.Item("DT_SQL")
                Dim sCodiP As String = oUDS.ValueEx

                oForm.Freeze(True)

                '---------------------------------------------------------------------------------------------------------------------------
                'Busqueda de Datos en la Tabla ZINFOP o si no existe, en la PCV
                '---------------------------------------------------------------------------------------------------------------------------
                Dim sql As String
                sql = " select PC.U_PrjCode as Project ,PC.U_PrjName as PrjName,PC.U_CardCode as CardCode,PC.U_CardName as CardName,case when PC.U_Multa = 'Y' then 'Si' else 'No' end as Multa,   " & _
                      " isnull(convert(char(10),PC.U_Fec_Vta ,103),'') as Fecha_Venta,convert(char(10),PC.U_Fec_Prom ,103) as Fecha_Prom_Cli,  " & _
                      " isnull(convert(char(10),PC.U_Fec_Ter_Desa ,103),'') as Fecha_Fin_Desarr,isnull(convert(char(10),PC.U_Fec_Ter_Prod ,103),'') as Fecha_Fin_Produc,   " & _
                      " isnull(convert(char(10),PC.U_Fec_Ini_Desp ,103),'') as Fecha_Ini_Despa,isnull(convert(char(10),PC.U_Fec_Ini_Mont ,103),'') as Fecha_Ini_Monta,  " & _
                      " isnull(convert(char(10),PC.U_Fec_Ter_Mont ,103),'') as Fecha_Fin_Monta   " & _
                      " from " + sBDComercial.Trim() + ".DBO.[@ZINFOP] as PC  " & _
                      " where convert(nvarchar(max),U_PrjCode) = convert(nvarchar(max), '" + sCodiP.Trim() + "')"
                Try
                    oUDataTable.ExecuteQuery(sql)
                Catch ex As Exception
                    Application.SBO_Application.MessageBox(sql)
                    Application.SBO_Application.MessageBox(ex.Message)
                End Try

                If oUDataTable.IsEmpty Then ' Si el Proyecto no existe en la Tabla ZINFOP, tomamos los datos de la primera PCV
                    sql = " select docnum as Pedido, PC.Project,PR.PrjName,PC.CardCode,PC.CardName,case when PC.U_MIN_Multa = 'Y' then 'Si' else 'No' end as Multa, " & _
                      " convert(char(10),PC.TaxDate,103) as Fecha_Pedido,convert(char(10),PC.DocDueDate ,103) as Fecha_Prom_Cli,  " & _
                      " isnull(convert(char(10),PC.U_MIN_FinDesarr ,103),'') as Fecha_Fin_Desarr,isnull(convert(char(10),PC.U_MIN_FinProduccion ,103),'') as Fecha_Fin_Produc, " & _
                      " isnull(convert(char(10),PC.U_MIN_IniDespacho ,103),'') as Fecha_Ini_Despa,isnull(convert(char(10),PC.U_MIN_IniMontaje ,103),'') as Fecha_Ini_Monta, " & _
                      " isnull(convert(char(10),PC.U_MIN_FinMontaje ,103),'') as Fecha_Fin_Monta,isnull(convert(char(10),PC.U_MIN_FechaVenta ,103),'') as Fecha_Venta " & _
                      " from " + sBDComercial.Trim() + ".DBO.ORDR PC join " + sBDComercial.Trim() + ".DBO.OPRJ PR on PC.Project = PR.PrjCode " & _
                      " where PC.DocNum in (select DocNum  from (select Project,min(DocNum) as DocNum from " + sBDComercial.Trim() + ".DBO.ORDR group by Project) as Primer_Pedido)" & _
                      " and series = 27 and PC.Project = '" + sCodiP.Trim() + "'" & _
                      " order by Project "

                    Try
                        oUDataTable.ExecuteQuery(sql)
                    Catch ex As Exception
                        Application.SBO_Application.MessageBox(sql)
                        Application.SBO_Application.MessageBox(ex.Message)
                    End Try
                End If

                If oUDataTable.IsEmpty = False Then
                    oForm.Items.Item("Item_0").Specific.Value = oUDataTable.GetValue("Project", 0)
                    oForm.Items.Item("Item_3").Specific.Value = oUDataTable.GetValue("PrjName", 0)
                    oForm.Items.Item("Item_5").Specific.Value = oUDataTable.GetValue("CardCode", 0)
                    oForm.Items.Item("Item_8").Specific.Value = oUDataTable.GetValue("CardName", 0)
                Else
                    'Application.SBO_Application.MessageBox("Proyecto sin Datos Asociados")
                    oForm.Items.Item("Item_0").Specific.Value = ""
                    oForm.Items.Item("Item_3").Specific.Value = ""
                    oForm.Items.Item("Item_5").Specific.Value = ""
                    oForm.Items.Item("Item_8").Specific.Value = ""
                End If

                '---------------------------------------------------------------------------------------------------------------------------
                'Busqueda de Datos en la Tabla ZPLAP para cargar los Planos
                '---------------------------------------------------------------------------------------------------------------------------

                Cargar_Matrix(sCodiP, FormID)

            Catch ex As Exception
            Finally
                oForm.Freeze(False)
            End Try

        End Sub

        Private Shared Sub Cargar_Matrix(sCodProj As String, FormID As String)

            oForm = Application.SBO_Application.Forms.Item(FormID)
            oMatrix = oForm.Items.Item("Item_4").Specific
            oMatrix.Clear()

            Dim sql As String
            sql = " select [U_PtahServer] as Archivo,[U_Status] as Estado, [U_Tipo_Plano] as Destino,[U_Fec_Registro] as Fecha,[U_Hora_Registro] as Hora " & _
                  " ,[U_Comentario] as Comentario,[U_PathOrigen] as RutaInic,[U_Renglon] as Fila " & _
                  " from  " + sBDComercial.Trim() + ".[dbo].[@ZPLAP]   " & _
                  " where U_Tipo_Documento = 'PLANO' and U_PrjCode = '" + sCodProj.Trim() + "' order by U_Renglon "

            '------------------ CARGAR MATRIX
            Try
                oUDataTable2 = oForm.DataSources.DataTables.Item("DT_0")
                oUDataTable3 = oForm.DataSources.DataTables.Item("DT_1")
                oUDataTable2.ExecuteQuery(sql)
                oUDataTable3.ExecuteQuery(sql)

                If oUDataTable2.Rows.Count > 0 Then

                    oMatrix.Columns.Item("#").DataBind.Bind("DT_0", "Fila")
                    oMatrix.Columns.Item("Col_0").DataBind.Bind("DT_0", "Archivo")
                    oMatrix.Columns.Item("Col_2").DataBind.Bind("DT_0", "Estado")
                    oMatrix.Columns.Item("Col_4").DataBind.Bind("DT_0", "Destino")
                    oMatrix.Columns.Item("Col_1").DataBind.Bind("DT_0", "Fecha")
                    oMatrix.Columns.Item("Col_3").DataBind.Bind("DT_0", "Hora")
                    oMatrix.Columns.Item("Col_5").DataBind.Bind("DT_0", "Comentario")
                    oMatrix.Columns.Item("Col_6").DataBind.Bind("DT_0", "RutaInic")

                    oMatrix.Clear()
                    oMatrix.LoadFromDataSource()
                    oMatrix.AutoResizeColumns()

                End If
            Catch ex As Exception
            End Try

            For index = 1 To oMatrix.RowCount()
              
                If oMatrix.Columns.Item("Col_2").Cells.Item(index).Specific.Value = "Activo" Then
                    oMatrix.CommonSetting.SetCellBackColor(index, 2, oFunciones.Color_RGB_SAP(255, 255, 153))
                Else
                    oMatrix.CommonSetting.SetCellBackColor(index, 2, oFunciones.Color_RGB_SAP(255, 51, 51))
                End If
            Next

            sql = " Select U.USERID as Codigo1, U.USER_CODE as Codigo2, U.U_NAME as Nombre, isnull(M.U_Enviar_Msg,'') as Seleccion from " + sBDComercial.Trim() + ".[dbo].OUSR U LEFT join " + sBDComercial.Trim() + ".[dbo].[@ZUSMS] M on U.userid = M.U_UserId "

            '------------------ CARGAR MATRIX USUARIOS
            Try
                oMatrix = oForm.Items.Item("Item_37").Specific
                Dim oUDT As SAPbouiCOM.DataTable = oForm.DataSources.DataTables.Item("DT_2")

                oUDT.ExecuteQuery(sql)
                If oUDT.Rows.Count > 0 Then

                    oMatrix.Columns.Item("#").DataBind.Bind("DT_2", "Codigo1")
                    oMatrix.Columns.Item("Col_0").DataBind.Bind("DT_2", "Codigo2")
                    oMatrix.Columns.Item("Col_1").DataBind.Bind("DT_2", "Nombre")
                    oMatrix.Columns.Item("Col_2").DataBind.Bind("DT_2", "Seleccion")

                    oMatrix.Clear()
                    oMatrix.LoadFromDataSource()
                    oMatrix.AutoResizeColumns()

                    'For index = 1 To Me.Matrix1.RowCount
                    '    If DT_2.GetValue("Seleccion", index - 1) = "Y" Then
                    '        oCheckBox = Me.Matrix1.Columns.Item("Col_2").Cells.Item(index).Specific
                    '        oCheckBox.Checked = True
                    '    Else
                    '        oCheckBox = Me.Matrix1.Columns.Item("Col_2").Cells.Item(index).Specific
                    '        oCheckBox.Checked = False
                    '    End If

                    'Next

                End If
            Catch ex As Exception
            End Try

        End Sub


        Private Function Proximo_Codigo_ZUSMS() As Integer

            Dim sql As String = "select isnull(max(cast(isnull(case when ISNUMERIC(code) = 1 then code else '0' end,'0') as int)),0)+1 as Proximo from [" + sBDComercial.Trim() + "].[dbo].[@ZUSMS]"

            Try

                DT_SQL.ExecuteQuery(sql)

            Catch ex As Exception

                Application.SBO_Application.MessageBox(sql)
                Me.EditText5.Value = sql
                Application.SBO_Application.MessageBox(ex.Message)

            End Try

            Return DT_SQL.GetValue("Proximo", 0)

        End Function

        Private Sub Registrar_Datos_Usuarios_Mensajes()

            Dim sql As String
            Dim ProximoC As Integer = 0

            'Borrar los registros Anteriores para insertar los actuales
            Sql = "delete from " + sBDComercial.Trim() + ".[dbo].[@ZUSMS] "

            Try

                DT_SQL.ExecuteQuery(Sql)

            Catch ex As Exception

                Application.SBO_Application.MessageBox(Sql)
                Me.EditText5.Value = Sql
                Application.SBO_Application.MessageBox(ex.Message)

            End Try

            Dim Codigo1 As String = ""
            Dim Codigo2 As String = ""
            Dim Nombre As String = ""
            Dim Selec As String = ""

            For index = 1 To Me.Matrix1.RowCount

                ProximoC = Proximo_Codigo_ZUSMS()
                Codigo1 = Me.Matrix1.Columns.Item("#").Cells.Item(index).Specific.Value()
                Codigo2 = Me.Matrix1.Columns.Item("Col_0").Cells.Item(index).Specific.Value()
                Nombre = Me.Matrix1.Columns.Item("Col_1").Cells.Item(index).Specific.Value()
                Selec = If(Me.Matrix1.Columns.Item("Col_2").Cells.Item(index).Specific.Checked, "Y", "N")

                Sql = " INSERT INTO " + sBDComercial.Trim() + ".[dbo].[@ZUSMS] " & _
              " ([Code]" & _
              " ,[Name]" & _
              " ,[U_UserId]" & _
              " ,[U_User_Code]" & _
              " ,[U_UName]" & _
              " ,[U_PrjCode] " & _
              " ,[U_Enviar_Msg]) " & _
               " VALUES " & _
              " ('" + ProximoC.ToString() + "'" & _
              " ,'" + ProximoC.ToString() + "'" & _
              " ,'" + Codigo1 + "'" & _
              " ,'" + Codigo2 + "'" & _
              " ,'" + Nombre + "'" & _
              " , ' ' " & _
              " ,'" + Selec + "')"

                Try
                    DT_SQL.ExecuteQuery(Sql)
                Catch ex As Exception
                    Application.SBO_Application.MessageBox(Sql)
                    Me.EditText5.Value = Sql
                    Application.SBO_Application.MessageBox(ex.Message)
                End Try
            Next

        End Sub

        Private Sub Registrar_Planos_Proyecto(sCodiP As String, FormUID As String)

            oForm = Application.SBO_Application.Forms.Item(FormUID)
            Dim sql As String
            Dim Validador As Boolean = False
            Dim ExistenCambios As Boolean = False
            Dim ProximoC As Integer = 0

            Dim rowNum As Integer = 0
            Dim ArchivoO As String = ""
            Dim ArchivoD As String = ""
            Dim Fecha As Date
            Dim Hora As String = ""
            Dim Comentario As String = ""
            Dim index As Integer
            Dim Destino As String = ""
            Dim Estado As String = ""

            'Borrar los registros Anteriores para insertar los actuales
            sql = "delete from " + sBDComercial.Trim() + ".[dbo].[@ZPLAP]   where  U_Tipo_Documento = 'PLANO'  and  U_PrjCode ='" + sCodiP.Trim() + "'"

            Try
                DT_SQL.ExecuteQuery(sql)
                Validador = True
            Catch ex As Exception
                Application.SBO_Application.MessageBox(sql)
                Me.EditText5.Value = sql
                Application.SBO_Application.MessageBox(ex.Message)
                Validador = False
            End Try

            For index = 1 To Me.Matrix0.RowCount ' Recorre la Matrix e inserta los registros en la BD

                oForm.Freeze(True)

                ArchivoO = Me.Matrix0.Columns.Item("Col_0").Cells.Item(index).Specific.Value()

                If Not ArchivoO.Contains(sPathAnexos) Then  ' Solo Copiara a la carpeta Anexos del Servidor los archivos nuevos
                    Me.EditText4.Value = ArchivoO   ' Ruta local
                    oFunciones.Copiar_Documentos_Anexos_a_Servidor(Me.EditText4)
                    ArchivoD = Me.EditText4.Value()  'Ruta Servidor
                Else
                    ArchivoO = Me.Matrix0.Columns.Item("Col_6").Cells.Item(index).Specific.Value() 'Ruta Local
                    ArchivoD = Me.Matrix0.Columns.Item("Col_0").Cells.Item(index).Specific.Value() 'Ruta Servidor
                End If

                Estado = Me.Matrix0.Columns.Item("Col_2").Cells.Item(index).Specific.Value()
                Destino = Me.Matrix0.Columns.Item("Col_4").Cells.Item(index).Specific.Value()
                Fecha = DateTime.ParseExact(Me.Matrix0.Columns.Item("Col_1").Cells.Item(index).Specific.Value(), "yyyyMMdd", Nothing).ToString("dd\/MM\/yyyy")
                Hora = Me.Matrix0.Columns.Item("Col_3").Cells.Item(index).Specific.Value()
                Comentario = Me.Matrix0.Columns.Item("Col_5").Cells.Item(index).Specific.Value()

                Try
                    sql = NDocumProyecto.Insertar_Documento(sCodiP.Trim(),
                                                        ArchivoO,
                                                        ArchivoD,
                                                        Fecha,
                                                        Hora,
                                                        oCompany.UserSignature.ToString(),
                                                        Destino,
                                                        Comentario,
                                                        Estado,
                                                        "PLANO",
                                                        index.ToString)
                    Validador = True
                Catch ex As Exception
                    Application.SBO_Application.MessageBox(ex.Message)
                    Validador = False
                Finally
                    Me.EditText4.Value = ""
                    oForm.Freeze(False)
                End Try
            Next

            '------------------------------------------------------------------------------------
            ' Verificacion de que todos los INSERT y UPDATE se realizaron correctamente
            '------------------------------------------------------------------------------------
            If Validador Then
                If Me.CheckBox0.Checked Then
                    Enviar_Mensaje(sCodiP)
                End If

                oForm.Freeze(True)
                Cargar_Matrix(sCodiP, FormUID)
                oForm.Freeze(False)

                Application.SBO_Application.MessageBox("Se han Actualizado los Documentos")
            End If

        End Sub

        Private Sub Eliminar_Todos_Planos_Proyecto(sCodiP As String)

            Dim sql As String

            'Se buscan si existen registros en la BD
            Sql = " select [U_PtahServer] as Archivo,[U_Fec_Registro] as Fecha,[U_Hora_Registro] as Hora,[U_Comentario] as Comentario,[U_Renglon] as Fila,[U_PathOrigen] as RutaInic" & _
            " from  " + sBDComercial.Trim() + ".[dbo].[@ZPLAP]   " & _
            " where U_Tipo_Documento = 'PLANO' and U_PrjCode = '" + sCodiP.Trim() + "' order by U_Renglon "
            Try
                DT_SQL.ExecuteQuery(Sql)
            Catch ex As Exception
                Application.SBO_Application.MessageBox(Sql)
                Application.SBO_Application.MessageBox(ex.Message)
            End Try
            If DT_SQL.IsEmpty = False Then
                If Application.SBO_Application.MessageBox("Con esto Eliminara Todos los Documentos Asociados al Proyecto", 2, "Eliminar Todo", "Cancelar") = 1 Then
                    Sql = "delete from " + sBDComercial.Trim() + ".[dbo].[@ZPLAP]   where  U_Tipo_Documento = 'PLANO'  and  U_PrjCode ='" + sCodiP.Trim() + "'"
                    Try
                        DT_SQL.ExecuteQuery(sql)

                    Catch ex As Exception
                        Application.SBO_Application.MessageBox(Sql)
                        Application.SBO_Application.MessageBox(ex.Message)
                    End Try
                End If
            End If

        End Sub

        Private Sub Enviar_Mensaje(sProyecto As String)

            Dim msgServ As SAPbobsCOM.MessagesService
            Dim oMessage2 As SAPbobsCOM.Message
            Dim DataColumn As SAPbobsCOM.MessageDataColumn
            Dim oRecordset As SAPbobsCOM.Recordset
            Dim oCompany As SAPbobsCOM.Company = NConectarAplicacion.oCompanySH

            Try
                'get company service
                If Not oCompany.Connected Then
                    Dim oConectarAplicacion As New NConectarAplicacion()
                    oConectarAplicacion.Conectar_Aplicacion(oCompany)
                End If

                oRecordset = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

                msgServ = oCompany.GetCompanyService.GetBusinessService(SAPbobsCOM.ServiceTypes.MessagesService)
                oMessage2 = msgServ.GetDataInterface(SAPbobsCOM.MessagesServiceDataInterfaces.msdiMessage)

                oMessage2.Subject = "Modificacion de Planos en Proyecto " + sProyecto + " "
                oMessage2.Text = "Se ha modificado un Plano en el Proyecto de Codigo: '" + sProyecto + "'"
                oMessage2.Priority = SAPbobsCOM.BoMsgPriorities.pr_High

                'oRecordset.DoQuery("select  U_apmuc  from [@TI_BITEMASAPR1]")
                'If oRecordset.RecordCount > 0 Then
                'oRecordset.MoveFirst()

                For index = 1 To Me.Matrix1.RowCount

                    If Me.Matrix1.Columns.Item("Col_2").Cells.Item(index).Specific.Checked Then
                        With oMessage2.RecipientCollection.Add()
                            .SendInternal = SAPbobsCOM.BoYesNoEnum.tYES
                            .UserCode = Me.Matrix1.Columns.Item("Col_0").Cells.Item(index).Specific.Value()
                            .UserType = SAPbobsCOM.BoMsgRcpTypes.rt_InternalUser
                        End With
                    End If

                Next

                DataColumn = oMessage2.MessageDataColumns.Add
                DataColumn.ColumnName = "Pedido No."
                DataColumn.Link = SAPbobsCOM.BoYesNoEnum.tYES

                'DataColumn = oMessage2.MessageDataColumns.Add
                'DataColumn.ColumnName = "Proyecto No."
                'DataColumn.Link = SAPbobsCOM.BoYesNoEnum.tYES

                'DataColumn = oMessage2.MessageDataColumns.Add
                'DataColumn.ColumnName = "Nombre Proyecto."
                'DataColumn.Link = SAPbobsCOM.BoYesNoEnum.tNO

                'DataColumn = oMessage2.MessageDataColumns.Add
                'DataColumn.ColumnName = "Codigo Cliente."
                'DataColumn.Link = SAPbobsCOM.BoYesNoEnum.tYES

                'DataColumn = oMessage2.MessageDataColumns.Add
                'DataColumn.ColumnName = "Nombre Cliente"
                'DataColumn.Link = SAPbobsCOM.BoYesNoEnum.tNO

                'DataColumn = oMessage2.MessageDataColumns.Add
                'DataColumn.ColumnName = "Multa"
                'DataColumn.Link = SAPbobsCOM.BoYesNoEnum.tNO

                Dim Sql As String = " select docnum as Pedido, PC.Project,PR.PrjName,PC.CardCode,PC.CardName,case when PC.U_MIN_Multa = 'Y' then 'Si' else 'No' end as Multa, " & _
                                    " convert(char(10),PC.TaxDate,103) as Fecha_Pedido,convert(char(10),PC.DocDueDate ,103) as Fecha_Prom_Cli,  " & _
                                    " isnull(convert(char(10),PC.U_MIN_FinDesarr ,103),'') as Fecha_Fin_Desarr,isnull(convert(char(10),PC.U_MIN_FinProduccion ,103),'') as Fecha_Fin_Produc, " & _
                                    " isnull(convert(char(10),PC.U_MIN_IniDespacho ,103),'') as Fecha_Ini_Despa,isnull(convert(char(10),PC.U_MIN_IniMontaje ,103),'') as Fecha_Ini_Monta, " & _
                                    " isnull(convert(char(10),PC.U_MIN_FinMontaje ,103),'') as Fecha_Fin_Monta,isnull(convert(char(10),PC.U_MIN_FechaVenta ,103),'') as Fecha_Venta,PC.DocEntry,PC.ObjType " & _
                                    " from " + sBDComercial.Trim() + ".DBO.ORDR PC join " + sBDComercial.Trim() + ".DBO.OPRJ PR on PC.Project = PR.PrjCode " & _
                                    " where PC.DocNum in (select DocNum  from (select Project,min(DocNum) as DocNum from " + sBDComercial.Trim() + ".DBO.ORDR group by Project) as Primer_Pedido)" & _
                                    " and series = 27 and PC.Project = '" + sProyecto.Trim() + "'" & _
                                    " order by Project "

                oRecordset.DoQuery(Sql)

                If oRecordset.RecordCount > 0 Then

                    oRecordset.MoveFirst()
                    For ii As Integer = 0 To oRecordset.RecordCount - 1
                        With DataColumn.MessageDataLines.Add
                            .Value = oRecordset.Fields.Item("Pedido").Value
                            .Object = oRecordset.Fields.Item("ObjType").Value
                            .ObjectKey = oRecordset.Fields.Item("DocEntry").Value
                        End With

                        'With DataColumn.MessageDataLines.Add
                        '    .Value = oRecordset.Fields.Item("Project").Value
                        '    .Object = "63"
                        '    .ObjectKey = oRecordset.Fields.Item("Project").Value
                        'End With

                        oRecordset.MoveNext()
                    Next

                    msgServ.SendMessage(oMessage2)
                End If
                'End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End Sub


        Private WithEvents EditText2 As SAPbouiCOM.EditText
        Private WithEvents StaticText0 As SAPbouiCOM.StaticText
        Private WithEvents StaticText1 As SAPbouiCOM.StaticText
        Private WithEvents EditText3 As SAPbouiCOM.EditText
        Private WithEvents StaticText2 As SAPbouiCOM.StaticText
        Private WithEvents StaticText3 As SAPbouiCOM.StaticText
        Private WithEvents Button1 As SAPbouiCOM.Button
        Private WithEvents Button2 As SAPbouiCOM.Button
        Private WithEvents EditText0 As SAPbouiCOM.EditText
        Private WithEvents EditText1 As SAPbouiCOM.EditText
        Private WithEvents Matrix0 As SAPbouiCOM.Matrix
        Private WithEvents CFL_0 As SAPbouiCOM.ChooseFromList
        Private WithEvents EditText4 As SAPbouiCOM.EditText
        Private WithEvents Button4 As SAPbouiCOM.Button
        Private WithEvents StaticText4 As SAPbouiCOM.StaticText
        Private WithEvents ComboBox0 As SAPbouiCOM.ComboBox
        Private WithEvents StaticText5 As SAPbouiCOM.StaticText
        Private WithEvents EditText5 As SAPbouiCOM.EditText
        Private WithEvents StaticText6 As SAPbouiCOM.StaticText
        Private WithEvents ComboBox1 As SAPbouiCOM.ComboBox
        Private WithEvents StaticText7 As SAPbouiCOM.StaticText
        Private WithEvents Button0 As SAPbouiCOM.Button
        Private WithEvents DT_0 As SAPbouiCOM.DataTable
        Private WithEvents DT_1 As SAPbouiCOM.DataTable
        Private WithEvents DT_2 As SAPbouiCOM.DataTable
        Private WithEvents DT_SQL As SAPbouiCOM.DataTable
        Private WithEvents Button3 As SAPbouiCOM.Button
        Private WithEvents Button5 As SAPbouiCOM.Button
        Private WithEvents Folder3 As SAPbouiCOM.Folder
        Private WithEvents Folder5 As SAPbouiCOM.Folder
        Private WithEvents Matrix1 As SAPbouiCOM.Matrix
        Private WithEvents StaticText8 As SAPbouiCOM.StaticText
        Private WithEvents CheckBox0 As SAPbouiCOM.CheckBox
        Private WithEvents Button6 As SAPbouiCOM.Button
        Private WithEvents Button7 As SAPbouiCOM.Button
        Private WithEvents Button8 As SAPbouiCOM.Button
        Private WithEvents Button9 As SAPbouiCOM.Button

    End Class

#Region "Codigo Anterior"
    'ProximoC = Proximo_Codigo_ZPLAP()

    'sql = " INSERT INTO  " + sBDComercial.Trim() + ".[dbo].[@ZPLAP] " & _
    '      " ([Code],[Name],[U_PrjCode],[U_PathOrigen] " & _
    '      " ,[U_PtahServer],[U_Fec_Registro],[U_Hora_Registro],[U_User_Id] " & _
    '      " ,[U_Tipo_Plano],[U_Comentario],[U_Status],[U_Tipo_Documento],[U_Renglon]) " & _
    '      " VALUES " & _
    '      " ('" + ProximoC.ToString() + "','" + ProximoC.ToString() + "','" + sCodiP.Trim() + "','" + ArchivoO + "'" & _
    '      " ,'" + ArchivoD + "',convert(date,'" + Fecha + "',103) ,'" + Hora + "','" + oCompany.UserSignature.ToString() + "'" & _
    '      " ,'" + Destino + "','" + Comentario + "','" + Estado + "','PLANO','" + index.ToString + "')"
    'Try
    'DT_SQL.ExecuteQuery(sql)
#End Region
End Namespace
