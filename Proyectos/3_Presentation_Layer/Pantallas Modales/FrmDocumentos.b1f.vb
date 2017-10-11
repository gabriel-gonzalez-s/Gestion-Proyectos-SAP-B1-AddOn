Option Strict Off
Option Explicit On

Imports SAPbouiCOM.Framework

Namespace SBOAddonProject1
    <FormAttribute("SBOAddonProject1.FrmDocumentos", "3_Presentation_Layer/Pantallas Modales/FrmDocumentos.b1f")>
    Friend Class FrmDocumentos
        Inherits UserFormBase

        Dim conta As Integer = 0

        Public Sub New()
        End Sub

        Public Overrides Sub OnInitializeComponent()
            Me.EditText0 = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.EditText)
            Me.Button0 = CType(Me.GetItem("Item_1").Specific, SAPbouiCOM.Button)
            Me.StaticText0 = CType(Me.GetItem("Item_2").Specific, SAPbouiCOM.StaticText)
            Me.Button1 = CType(Me.GetItem("Item_3").Specific, SAPbouiCOM.Button)
            Me.Grid0 = CType(Me.GetItem("Item_5").Specific, SAPbouiCOM.Grid)
            Me.Button3 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.Button)
            Me.StaticText1 = CType(Me.GetItem("Item_7").Specific, SAPbouiCOM.StaticText)
            Me.StaticText2 = CType(Me.GetItem("Item_8").Specific, SAPbouiCOM.StaticText)
            Me.UD_1 = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_1")
            Me.UD_2 = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_2")
            Me.UD_FT = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_FT")
            Me.UD_FR = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_FR")
            Me.UD_EDO = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_EDO")
            Me.UD_CHK = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_CHK")
            Me.UD_ROW = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_ROW")
            Me.DT_SQL = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_SQL")
            Me.StaticText3 = CType(Me.GetItem("Item_9").Specific, SAPbouiCOM.StaticText)
            Me.EditText1 = CType(Me.GetItem("Item_10").Specific, SAPbouiCOM.EditText)
            Me.StaticText4 = CType(Me.GetItem("Item_11").Specific, SAPbouiCOM.StaticText)
            Me.Button4 = CType(Me.GetItem("Item_13").Specific, SAPbouiCOM.Button)
            Me.Button6 = CType(Me.GetItem("Item_14").Specific, SAPbouiCOM.Button)
            Me.OptionBtn0 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.OptionBtn)
            Me.OptionBtn1 = CType(Me.GetItem("Item_12").Specific, SAPbouiCOM.OptionBtn)
            'Me.Folder1 = CType(Me.GetItem("Item_20").Specific, SAPbouiCOM.Folder)
            Me.StaticText7 = CType(Me.GetItem("Item_15").Specific, SAPbouiCOM.StaticText)
            Me.EditText7 = CType(Me.GetItem("Item_18").Specific, SAPbouiCOM.EditText)
            Me.StaticText8 = CType(Me.GetItem("Item_17").Specific, SAPbouiCOM.StaticText)
            Me.EditText8 = CType(Me.GetItem("Item_16").Specific, SAPbouiCOM.EditText)
            Me.CheckBox0 = CType(Me.GetItem("Item_23").Specific, SAPbouiCOM.CheckBox)
            Me.Folder2 = CType(Me.GetItem("Item_25").Specific, SAPbouiCOM.Folder)
            Me.PictureBox0 = CType(Me.GetItem("Item_26").Specific, SAPbouiCOM.PictureBox)
            Me.OnCustomInitialize()

        End Sub

        Public Overrides Sub OnInitializeFormEvents()
            AddHandler ResizeAfter, AddressOf Me.Form_ResizeAfter
        End Sub

        Private Sub Form_ResizeAfter(pVal As SAPbouiCOM.SBOItemEventArg)
            If conta = 0 Then
                conta += 1
                Call Cargar_Grid_Documentos()
            End If
        End Sub

        Private Sub OnCustomInitialize()
            'Call Cargar_Grid_Documentos()
            oForm = Application.SBO_Application.Forms.Item(Me.UIAPIRawForm.UniqueID)
            Me.Button4.Item.Visible = False
            Me.Button6.Item.Visible = False
            'Me.UIAPIRawForm.ReportType = "Modal"
            Me.OptionBtn1.GroupWith("Item_4")
            CheckBox0.Item.Width = 140
            oForm.DataSources.UserDataSources.Item("OptBtn").ValueEx = 1

        End Sub

        Private Sub Button0_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button0.ClickAfter
            oFunciones.Abre_Dialogo_y_Asigna_Path3(Me.EditText0, DialogType.OPEN)
        End Sub

        Private Sub Button3_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button3.ClickAfter
            Try

                If Me.EditText0.Value.Trim().Length > 0 Then
                    Me.UIAPIRawForm.Freeze(True)

                    Select Case Me.Button3.Caption

                        Case "Agregar"
                            Registrar_Documento()
                        Case "Modificar"
                            Modificar_Documento()
                    End Select
                End If

            Catch ex As Exception
                Application.SBO_Application.MessageBox("Agregar a Grid:" + ex.Message.ToString())
            Finally
                Me.UIAPIRawForm.Freeze(False)
            End Try

        End Sub

        Private Sub Button4_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button4.ClickAfter

            Try

                Me.UIAPIRawForm.Freeze(True)

                Me.Button4.Item.Visible = False
                Me.Button3.Caption = "Agregar"
                Me.EditText0.Value = ""
                Me.EditText1.Value = ""

            Catch ex As Exception
            Finally
                Me.UIAPIRawForm.Freeze(False)
            End Try


        End Sub

        Private Sub Grid0_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid0.ClickAfter

            Grid0.Rows.SelectedRows.Add(pVal.Row)

            Try

                Me.UIAPIRawForm.Freeze(True)

                Me.Button3.Caption = "Modificar"
                Me.Button4.Item.Visible = True
                Me.EditText0.Value = Grid0.DataTable.GetValue("RutaInic", pVal.Row)
                Me.EditText1.Value = Grid0.DataTable.GetValue("Comentario", pVal.Row)
                Dim s As String = Grid0.DataTable.GetValue("Tipo", pVal.Row)
                oForm.DataSources.UserDataSources.Item("OptBtn").ValueEx = If(Grid0.DataTable.GetValue("Tipo", pVal.Row) = "DOCUMENTO", 1, 2)

            Catch ex As Exception
            Finally
                Me.UIAPIRawForm.Freeze(False)
            End Try

        End Sub

        Private Sub Grid0_DoubleClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid0.DoubleClickAfter

            If pVal.ColUID = "Archivo" Then
                oFunciones.Open_File(Grid0.DataTable.GetValue("Archivo", pVal.Row).ToString.Trim)
            End If

        End Sub


        Private Sub Button1_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button1.ClickAfter

            Try
                If UD_EDO.ValueEx <> "7" Then
                    If CheckBox0.Checked And CheckBox0.Item.Enabled Then

                        Dim nEncu As Integer = 0
                        Dim nDocu As Integer = 0

                        For iRow = 0 To Grid0.DataTable.Rows.Count() - 1

                            If Grid0.DataTable.GetValue("Tipo", iRow) = "DOCUMENTO" Then
                                nDocu += 1
                            Else
                                nEncu += 1
                            End If

                        Next

                        If nDocu > 0 And nEncu > 0 Then

                            Dim oUDS As SAPbouiCOM.UserDataSource = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_0")
                            Dim FormPID As String = oUDS.ValueEx        'Aca nos traemos el FormUID del Formulario Principal guardado en el User Data Source

                            Dim oFormP As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(FormPID)
                            oGrid = oFormP.Items.Item("Item_0").Specific
                            Dim nRow = oGrid.Rows.SelectedRows.Item(0, SAPbouiCOM.BoOrderType.ot_RowOrder) 'Convert.ToInt32(UD_ROW.ValueEx)
                            Dim FecRec = Convert.ToDateTime(EditText7.String).ToString("yyyyMMdd")
                            oGrid.DataTable.SetValue("Fec.Recep.", oGrid.GetDataTableRowIndex(nRow), FecRec)
                            oButton = oFormP.Items.Item("Item_9").Specific
                            oButton.Item.Visible = True
                            oButton.Item.Click()
                            oButton.Item.Visible = False
                            Me.UIAPIRawForm.Close()

                        Else
                            Application.SBO_Application.MessageBox("Para Recepcionar el Proyecto debe Registrar Encuesta y Documento")
                        End If
                    Else
                        Me.UIAPIRawForm.Close()
                    End If
                Else
                    Me.UIAPIRawForm.Close()
                End If
            Catch ex As Exception
            End Try

        End Sub

        Private Sub EditText0_DoubleClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText0.DoubleClickAfter

            If EditText0.Value.Trim.Length > 0 Then
                If Button3.Caption = "Modificar" Then
                    oFunciones.Open_File(Grid0.DataTable.GetValue("Archivo", Grid0.Rows.SelectedRows.Item(0, SAPbouiCOM.BoOrderType.ot_RowOrder)).ToString.Trim)
                Else
                    oFunciones.Open_File(EditText0.Value.Trim)
                End If
            End If

        End Sub

        Private Sub Button6_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button6.ClickAfter

            Try

                'Dim rowNum As Integer = Grid0.GetCellFocus.rowIndex
                Dim rowNum As Integer = Grid0.Rows.SelectedRows.Item(0, SAPbouiCOM.BoOrderType.ot_RowOrder)

                If rowNum >= 0 Then

                    'sPSql = " DELETE FROM " + sBDComercial.Trim() + ".[dbo].[@ZPLAP] " & _
                    '        " WHERE [U_PrjCode] = '" + UD_1.ValueEx.Trim + "' AND [U_Renglon] = '" + Grid0.DataTable.GetValue("Fila", rowNum).ToString + "'"

                    Try
                        sPSql = NDocumProyecto.Eliminar_Documento(UD_1.ValueEx.Trim, Grid0.DataTable.GetValue("Fila", rowNum).ToString)
                        'DT_SQL.ExecuteQuery(sPSql)

                    Catch ex As Exception
                    End Try

                    Grid0.DataTable.Rows.Remove(rowNum)

                    Me.Button4.Item.Visible = False
                    Me.Button3.Caption = "Agregar"
                    Me.EditText0.Value = ""
                    Me.EditText1.Value = ""

                End If

            Catch ex As Exception

            End Try

        End Sub

        Private Sub CheckBox0_PressedAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles CheckBox0.PressedAfter
            If CheckBox0.Checked Then
                Application.SBO_Application.MessageBox("Recuerde Verificar la Fecha de Recepcion Final Real")
                EditText7.Item.Click()
            End If
        End Sub


        Private Sub Cargar_Grid_Documentos()

            StaticText1.Caption = "CODIGO PROYECTO: " + UD_1.ValueEx.Trim
            StaticText2.Caption = "NOMBRE PROYECTO: " + UD_2.ValueEx.Trim
            'Cliente Final
            sPSql = " SELECT F.DocNum,F.Series,F.TaxDate,F.Project,U_MIN_PCVC,U_MIN_Cliente " & _
                    " from [" + sBDComercial + "].[DBO].ORDR F  " & _
                    " where F.CANCELED!='Y' and F.Project = '" + UD_1.ValueEx + "'"
            Try
                DT_SQL.ExecuteQuery(sPSql)
            Catch ex As Exception

            End Try

            If DT_SQL.IsEmpty = False Then

                StaticText3.Caption = "CLIENTE FINAL: " + DT_SQL.GetValue("U_MIN_Cliente", 0).ToString.Trim

            End If

            sPSql = " select [U_Renglon] as Fila, [U_PtahServer] as Archivo,[U_Fec_Registro] as Fecha,[U_Hora_Registro] as Hora,[U_Comentario] as Comentario,[U_PathOrigen] as RutaInic, IIF(U_Tipo_Documento = 'DOCUMONTA','DOCUMENTO','ENCUESTA') as Tipo" & _
                    " from  " + sBDComercial.Trim() + ".[dbo].[@ZPLAP]   " & _
                    " where (U_Tipo_Documento = 'DOCUMONTA' OR U_Tipo_Documento = 'ENCUMONTA') and U_PrjCode = '" + UD_1.ValueEx.Trim + "' order by U_Renglon "
            Try
                Me.Grid0.DataTable.ExecuteQuery(sPSql)
                If Grid0.DataTable.IsEmpty Then
                    Grid0.DataTable.Rows.Clear()
                End If

                Grid0.Columns.Item("Fila").Visible = False
                Grid0.AutoResizeColumns()

            Catch ex As Exception

            End Try

            sPSql = " select U_PrjCode,[U_Fec_Real_Fin_Mon],[U_Fec_Real_Recep_Mon],[U_Estado_M]" & _
                    " from  " + sBDComercial.Trim() + ".[dbo].[@ZINFOP]   " & _
                    " where U_PrjCode = '" + UD_1.ValueEx.Trim + "'"
            Try
                DT_SQL.ExecuteQuery(sPSql)
                If Not DT_SQL.IsEmpty Then
                    UD_FT.ValueEx = Convert.ToDateTime(DT_SQL.GetValue("U_Fec_Real_Fin_Mon", 0)).ToString("yyyyMMdd")
                    UD_FT.ValueEx = If(UD_FT.ValueEx = "00010101", "", UD_FT.ValueEx)
                    UD_FR.ValueEx = Convert.ToDateTime(DT_SQL.GetValue("U_Fec_Real_Recep_Mon", 0)).ToString("yyyyMMdd")
                    UD_FR.ValueEx = If(UD_FT.ValueEx <> "", UD_FT.ValueEx, If(UD_FR.ValueEx = "00010101", "", UD_FR.ValueEx))
                    UD_EDO.ValueEx = DT_SQL.GetValue("U_Estado_M", 0)
                    If DT_SQL.GetValue("U_Estado_M", 0) = "7" Then
                        UD_CHK.ValueEx = "Y"
                        'CheckBox0.Checked = True
                        CheckBox0.Caption = "Proyecto Recepcionado"
                        CheckBox0.Item.Enabled = False
                        Folder2.Item.Click()
                        EditText7.Item.Enabled = False
                    End If
                End If
            Catch ex As Exception

            End Try

        End Sub

        Private Sub Registrar_Documento()

            Dim sTipo = If(oForm.DataSources.UserDataSources.Item("OptBtn").ValueEx = "1", "DOCUMONTA", "ENCUMONTA")
            Dim sTipoD = If(oForm.DataSources.UserDataSources.Item("OptBtn").ValueEx = "1", "DOCUMENTO", "ENCUESTA")

            Dim lastRowIndex As Integer = 0

            Grid0.DataTable.Rows.Add()
            lastRowIndex = Grid0.DataTable.Rows.Count - 1

            Grid0.DataTable.SetValue("Fila", lastRowIndex, lastRowIndex + 1)
            Grid0.DataTable.SetValue("Archivo", lastRowIndex, Me.EditText0.Value.Trim())
            Grid0.DataTable.SetValue("Fecha", lastRowIndex, Date.Now)
            Grid0.DataTable.SetValue("Hora", lastRowIndex, DateTime.Now.ToLongTimeString())
            Grid0.DataTable.SetValue("Comentario", lastRowIndex, Me.EditText1.Value.Trim())
            Grid0.DataTable.SetValue("RutaInic", lastRowIndex, Me.EditText0.Value.Trim())
            Grid0.DataTable.SetValue("Tipo", lastRowIndex, sTipoD)

            Grid0.AutoResizeColumns()

            Dim Prox As Integer = oFunciones.Proximo_Codigo_Correlativo("@ZPLAP", "Code", DT_SQL)
            Dim ArchivoO As String = ""
            Dim ArchivoD As String = ""

            Verifica_Copia_Archivo(lastRowIndex, ArchivoO, ArchivoD)

            Try

                sPSql = " INSERT INTO  " + sBDComercial.Trim() + ".[dbo].[@ZPLAP] " & _
                      " ([Code],[Name],[U_PrjCode],[U_PathOrigen] " & _
                      " ,[U_PtahServer],[U_Fec_Registro],[U_Hora_Registro],[U_User_Id] " & _
                      " ,[U_Tipo_Plano],[U_Comentario],[U_Status],[U_Tipo_Documento],[U_Renglon]) " & _
                      " VALUES " & _
                      " ('" + Prox.ToString() + "','" + Prox.ToString() + "','" + UD_1.ValueEx.Trim + "','" + ArchivoO + "'" & _
                      " ,'" + ArchivoD + "',convert(date,'" + Date.Now + "',103) ,'" + DateTime.Now.ToLongTimeString() + "','" + oCompany.UserSignature.ToString() + "'" & _
                      " ,'DOC','" + Me.EditText1.Value.Trim() + "','','" + sTipo + "','" + lastRowIndex.ToString + "')"

                DT_SQL.ExecuteQuery(sPSql)
                'sPSql = NDocumProyecto.Insertar_Documento(UD_1.ValueEx.Trim,
                '                                    ArchivoO,
                '                                    ArchivoD,
                '                                    Date.Now,
                '                                    DateTime.Now.ToLongTimeString(),
                '                                    oCompany.UserSignature.ToString(),
                '                                    "DOC",
                '                                    Me.EditText1.Value.Trim(),
                '                                    "",
                '                                    sTipo,
                '                                    lastRowIndex.ToString)
            Catch ex As Exception
            End Try

            Me.EditText0.Value = ""
            Me.EditText1.Value = ""
            Grid0.DataTable.SetValue("Archivo", lastRowIndex, ArchivoD.Trim())

        End Sub

        Private Sub Modificar_Documento()

            Dim sTipo = If(oForm.DataSources.UserDataSources.Item("OptBtn").ValueEx = "1", "DOCUMONTA", "ENCUMONTA")
            Dim sTipoD = If(oForm.DataSources.UserDataSources.Item("OptBtn").ValueEx = "1", "DOCUMENTO", "ENCUESTA")

            Dim nRow As Integer = Grid0.Rows.SelectedRows.Item(0, SAPbouiCOM.BoOrderType.ot_RowOrder)

            Grid0.DataTable.SetValue("Archivo", nRow, Me.EditText0.Value.Trim())
            Grid0.DataTable.SetValue("Fecha", nRow, Date.Now)
            Grid0.DataTable.SetValue("Hora", nRow, DateTime.Now.ToLongTimeString())
            Grid0.DataTable.SetValue("Comentario", nRow, Me.EditText1.Value.Trim())
            Grid0.DataTable.SetValue("RutaInic", nRow, Me.EditText0.Value.Trim())
            Grid0.DataTable.SetValue("Tipo", nRow, sTipoD)

            Grid0.AutoResizeColumns()

            Dim ArchivoO As String = ""
            Dim ArchivoD As String = ""

            Verifica_Copia_Archivo(nRow, ArchivoO, ArchivoD)

            Grid0.DataTable.SetValue("Archivo", nRow, ArchivoD.Trim())

            Try
                sPSql = " UPDATE " + sBDComercial.Trim() + ".[dbo].[@ZPLAP] " & _
                        " SET [U_PathOrigen] = '" + ArchivoO + "'" & _
                        "   ,[U_PtahServer] = '" + ArchivoD + "'" & _
                        "   ,[U_Fec_Registro] = convert(date,'" + Date.Now + "',103)" & _
                        "   ,[U_Hora_Registro] = '" + DateTime.Now.ToLongTimeString() + "'" & _
                        "   ,[U_User_Id] = '" + oCompany.UserSignature.ToString() + "'" & _
                        "   ,[U_Comentario] = '" + Me.EditText1.Value.Trim() + "'" & _
                        "   ,[U_Tipo_Documento] = '" + sTipo + "'" & _
                        "   WHERE [U_PrjCode] = '" + UD_1.ValueEx.Trim + "' AND [U_Renglon] = '" + Grid0.DataTable.GetValue("Fila", nRow).ToString + "'"

                DT_SQL.ExecuteQuery(sPSql)

                'sPSql = NDocumProyecto.Modificar_Documento(UD_1.ValueEx.Trim,
                '                                    ArchivoO,
                '                                    ArchivoD,
                '                                    Date.Now,
                '                                    DateTime.Now.ToLongTimeString(),
                '                                    oCompany.UserSignature.ToString(),
                '                                    "DOC",
                '                                    Me.EditText1.Value.Trim(),
                '                                    "",
                '                                    sTipo,
                '                                    Grid0.DataTable.GetValue("Fila", nRow).ToString)
            Catch ex As Exception
            End Try

        End Sub

        Private Sub Verifica_Copia_Archivo(nRow, ByRef ArchivoO, ByRef ArchivoD)

            Try
                ArchivoD = ""
                ArchivoO = Grid0.DataTable.GetValue("RutaInic", nRow)

                If Not ArchivoO.Contains(sPathAnexos) And System.IO.File.Exists(ArchivoO) Then  ' Solo Copiara a la carpeta Anexos del Servidor los archivos nuevos

                    Dim Path = IO.Path.GetDirectoryName(ArchivoO)
                    Dim FileName = IO.Path.GetFileName(ArchivoO)
                    Dim NuevoNombre = If(oForm.DataSources.UserDataSources.Item("OptBtn").ValueEx = "1", "DOCU", "ENCU") + FileName
                    Dim ArchivoF = sPathAnexos + NuevoNombre
                    If System.IO.File.Exists(ArchivoF) Then
                        If Application.SBO_Application.MessageBox("El Archivo '" + ArchivoF + "' ya Existe, ¿Desea Sobrescribirlo? ", 1, "Sobrescribir", "Cancelar") = 1 Then
                            oFunciones.Delete_File(ArchivoF)
                            oFunciones.Copiar_Documentos_Anexos_a_Servidor(Me.EditText0, NuevoNombre)
                        Else
                            ArchivoO = Grid0.DataTable.GetValue("RutaInic", nRow) 'Ruta Local
                            ArchivoD = Grid0.DataTable.GetValue("Archivo", nRow) 'Ruta Servidor
                        End If
                    Else
                        oFunciones.Copiar_Documentos_Anexos_a_Servidor(Me.EditText0, NuevoNombre)
                    End If
                    ArchivoD = Me.EditText0.Value()  'Ruta Servidor

                Else

                    ArchivoO = Grid0.DataTable.GetValue("RutaInic", nRow) 'Ruta Local
                    ArchivoD = Grid0.DataTable.GetValue("Archivo", nRow) 'Ruta Servidor

                End If
            Catch ex As Exception

            End Try

        End Sub


        Private WithEvents EditText0 As SAPbouiCOM.EditText
        Private WithEvents Button0 As SAPbouiCOM.Button
        Private WithEvents StaticText0 As SAPbouiCOM.StaticText
        Private WithEvents Button1 As SAPbouiCOM.Button
        Private WithEvents Grid0 As SAPbouiCOM.Grid
        Private WithEvents Button3 As SAPbouiCOM.Button
        Private WithEvents StaticText1 As SAPbouiCOM.StaticText
        Private WithEvents StaticText2 As SAPbouiCOM.StaticText
        Private WithEvents UD_1 As SAPbouiCOM.UserDataSource
        Private WithEvents UD_2 As SAPbouiCOM.UserDataSource
        Private WithEvents UD_FT As SAPbouiCOM.UserDataSource
        Private WithEvents UD_FR As SAPbouiCOM.UserDataSource
        Private WithEvents UD_EDO As SAPbouiCOM.UserDataSource
        Private WithEvents UD_CHK As SAPbouiCOM.UserDataSource
        Private WithEvents UD_ROW As SAPbouiCOM.UserDataSource
        Private WithEvents DT_SQL As SAPbouiCOM.DataTable
        Private WithEvents StaticText3 As SAPbouiCOM.StaticText
        Private WithEvents EditText1 As SAPbouiCOM.EditText
        Private WithEvents StaticText4 As SAPbouiCOM.StaticText
        Private WithEvents Button4 As SAPbouiCOM.Button
        Private WithEvents Button6 As SAPbouiCOM.Button
        Private WithEvents OptionBtn0 As SAPbouiCOM.OptionBtn
        Private WithEvents OptionBtn1 As SAPbouiCOM.OptionBtn
        'Private WithEvents Folder1 As SAPbouiCOM.Folder
        Private WithEvents StaticText7 As SAPbouiCOM.StaticText
        Private WithEvents EditText7 As SAPbouiCOM.EditText
        Private WithEvents StaticText8 As SAPbouiCOM.StaticText
        Private WithEvents EditText8 As SAPbouiCOM.EditText
        Private WithEvents CheckBox0 As SAPbouiCOM.CheckBox
        Private WithEvents Folder2 As SAPbouiCOM.Folder
        Private WithEvents PictureBox0 As SAPbouiCOM.PictureBox



#Region "Codigo Anterior"
        'sPSql = " INSERT INTO  " + sBDComercial.Trim() + ".[dbo].[@ZPLAP] " & _
        '      " ([Code],[Name],[U_PrjCode],[U_PathOrigen] " & _
        '      " ,[U_PtahServer],[U_Fec_Registro],[U_Hora_Registro],[U_User_Id] " & _
        '      " ,[U_Tipo_Plano],[U_Comentario],[U_Status],[U_Tipo_Documento],[U_Renglon]) " & _
        '      " VALUES " & _
        '      " ('" + Prox.ToString() + "','" + Prox.ToString() + "','" + UD_1.ValueEx.Trim + "','" + ArchivoO + "'" & _
        '      " ,'" + ArchivoD + "',convert(date,'" + Date.Now + "',103) ,'" + DateTime.Now.ToLongTimeString() + "','" + oCompany.UserSignature.ToString() + "'" & _
        '      " ,'DOC','" + Me.EditText1.Value.Trim() + "','','" + sTipo + "','" + lastRowIndex.ToString + "')"

        'DT_SQL.ExecuteQuery(sPSql)

        'sPSql = " UPDATE " + sBDComercial.Trim() + ".[dbo].[@ZPLAP] " & _
        '        " SET [U_PathOrigen] = '" + ArchivoO + "'" & _
        '        "   ,[U_PtahServer] = '" + ArchivoD + "'" & _
        '        "   ,[U_Fec_Registro] = convert(date,'" + Date.Now + "',103)" & _
        '        "   ,[U_Hora_Registro] = '" + DateTime.Now.ToLongTimeString() + "'" & _
        '        "   ,[U_User_Id] = '" + oCompany.UserSignature.ToString() + "'" & _
        '        "   ,[U_Comentario] = '" + Me.EditText1.Value.Trim() + "'" & _
        '        "   ,[U_Tipo_Documento] = '" + sTipo + "'" & _
        '        "   WHERE [U_PrjCode] = '" + UD_1.ValueEx.Trim + "' AND [U_Renglon] = '" + Grid0.DataTable.GetValue("Fila", nRow).ToString + "'"


#End Region

    End Class
End Namespace




