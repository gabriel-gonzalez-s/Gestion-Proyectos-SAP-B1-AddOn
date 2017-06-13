Option Strict Off
Option Explicit On

Imports SAPbouiCOM.Framework

Namespace SBOAddonProject1
    <FormAttribute("SBOAddonProject1.FrmGestion_Ingenieria", "3_Presentation_Layer/Pantallas Principales/FrmGestion_Ingenieria.b1f")>
    Friend Class FrmGestion_Ingenieria
        Inherits UserFormBase

        Private WithEvents SBO_Application As SAPbouiCOM.Application
        Private nCountEvent As Integer = 0

        Private ColMulta As Integer
        Private ColMultaI As Integer
        Private ColVisitaTec As Integer
        Private DiasAtra As Integer
        Private DiasDisp As Integer
        Private Comb_DatAnt As String
        Private Col_DatAnt As String
        Private TomadoPorCbx As Boolean = False

        Public Sub New()
            SBO_Application = Application.SBO_Application
        End Sub

        Public Overrides Sub OnInitializeComponent()
            Me.Folder0 = CType(Me.GetItem("Item_1").Specific, SAPbouiCOM.Folder)
            Me.Folder1 = CType(Me.GetItem("Item_2").Specific, SAPbouiCOM.Folder)
            Me.Grid0 = CType(Me.GetItem("Item_3").Specific, SAPbouiCOM.Grid)
            Me.Grid1 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.Grid)
            Me.Button0 = CType(Me.GetItem("Item_5").Specific, SAPbouiCOM.Button)
            Me.Button1 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.Button)
            Me.Button2 = CType(Me.GetItem("Item_7").Specific, SAPbouiCOM.Button)
            Me.DT_SQL = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_SQL")
            Me.DT_PR = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_PR")
            Me.DT_INT = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_INT")
            Me.Button3 = CType(Me.GetItem("Item_8").Specific, SAPbouiCOM.Button)
            Me.EditText0 = CType(Me.GetItem("Item_9").Specific, SAPbouiCOM.EditText)
            Me.OnCustomInitialize()

        End Sub

        Public Overrides Sub OnInitializeFormEvents()
            AddHandler ResizeAfter, AddressOf Me.Form_ResizeAfter

        End Sub


        Private Sub OnCustomInitialize()

            'AddHandler Application.SBO_Application.ItemEvent, AddressOf Me.Ing_Item_Event

            Call Cargar_Grids_Gestion_Ingenieria()
            Me.Folder0.Item.Click()

        End Sub

        Private Sub Grid0_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid0.ClickAfter

            Try

                Grid0.Rows.SelectedRows.Add(pVal.Row)

            Catch ex As Exception

            End Try

        End Sub

        Private Sub Grid1_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid1.ClickAfter

            Try

                Grid1.Rows.SelectedRows.Add(pVal.Row)

                If pVal.ColUID = "Proyecto Cerrado" Then

                    oChkCol = Grid1.Columns.Item("Proyecto Cerrado")

                    If oChkCol.IsChecked(pVal.Row) Then

                        If Application.SBO_Application.MessageBox("¿Actualizar Fecha de Confirmacion y Entrega de Proyecto?", 2, "Actualizar", "Mantener") = 1 Then

                            Try
                                Dim vRow As Integer = Me.Grid1.GetDataTableRowIndex(pVal.Row)

                                Grid1.DataTable.SetValue("Confirmación y Cierre Proy.", vRow, Date.Now)
                                Grid1.DataTable.SetValue("Usuario Asociado 10", vRow, oConectarAplicacion.sNomUsuActual)
                            Catch ex As Exception

                            End Try

                        End If

                    End If

                End If


            Catch ex As Exception

            End Try

        End Sub



        Private Sub Form_ResizeAfter(pVal As SAPbouiCOM.SBOItemEventArg)

            oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
            oItem = oForm.Items.Item("Item_0")
            oItem.Top = 23
            oItem.Left = 16
            oItem.Height = oForm.Height - 105
            oItem.Width = oForm.Width - 52
            Me.Grid0.AutoResizeColumns()
            Me.Grid0.Item.Width = oItem.Width - 36
            Me.Grid0.Item.Height = oItem.Height - 40
            Me.Grid1.AutoResizeColumns()
            Me.Grid1.Item.Width = oItem.Width - 36
            Me.Grid1.Item.Height = oItem.Height - 40

        End Sub

        Private Sub Grid1_ComboSelectBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles Grid1.ComboSelectBefore

            Try
                Dim dtRow As Integer = Grid1.GetDataTableRowIndex(pVal.Row)
                Comb_DatAnt = Grid1.DataTable.GetValue(pVal.ColUID, dtRow).ToString()
                TomadoPorCbx = True
            Catch ex As Exception

            End Try


        End Sub

        Private Sub Grid1_ComboSelectAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid1.ComboSelectAfter

            Try
                Dim dtRow As Integer = Grid1.GetDataTableRowIndex(pVal.Row)
                Dim Comb_DatAct = Grid1.DataTable.GetValue(pVal.ColUID, dtRow).ToString()

                If Comb_DatAnt <> Comb_DatAct And TomadoPorCbx = True Then
                    Try
                        TomadoPorCbx = False
                        ActualizaProyecto(pVal.Row, pVal.ColUID)

                        If Grid1.DataTable.GetValue("Con Visita Tec.", dtRow) = "No" Then

                            Grid1.CommonSetting.SetCellEditable(pVal.Row + 1, ColVisitaTec + 1, False)


                        Else

                            Grid1.CommonSetting.SetCellEditable(pVal.Row + 1, ColVisitaTec + 1, True)

                        End If

                    Catch ex As Exception

                    End Try
                End If

            Catch ex As Exception

            End Try

        End Sub

        Private Sub Grid1_LostFocusAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid1.LostFocusAfter

            Try
                Dim dtRow As Integer = Grid1.GetDataTableRowIndex(pVal.Row)
                Dim Col_DatAct = Convert.ToString(Grid1.DataTable.GetValue(pVal.ColUID, dtRow))
                Dim vRow As Integer = 0

                If Col_DatAnt <> Col_DatAct And TomadoPorCbx = False And pVal.ColUID <> "Con Visita Tec." And
                   Grid1.Columns.Item(pVal.ColUID).Editable Then
                    Try

                        Me.UIAPIRawForm.Freeze(True)

                        vRow = Me.Grid1.GetDataTableRowIndex(pVal.Row)

                        If (pVal.ColUID <> "Observaciones") Then

                            Dim FormID As String = Me.UIAPIRawForm.UniqueID
                            Dim GridID As String = Grid1.Item.UniqueID
                            Dim nCol As Integer = oFunciones.Numero_Columna_Grid(FormID, GridID, pVal.ColUID)
                            Grid1.DataTable.SetValue(nCol + 1, vRow, oConectarAplicacion.sNomUsuActual)
                            ActualizaProyecto(pVal.Row, pVal.ColUID)
                        Else
                            ActualizaProyecto(pVal.Row, pVal.ColUID)
                        End If

                    Catch ex As Exception

                    Finally
                        Me.UIAPIRawForm.Freeze(False)
                    End Try
                End If

            Catch ex As Exception

            End Try

        End Sub

        Private Sub Grid1_GotFocusAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid1.GotFocusAfter

            Try
                If TomadoPorCbx = False Then
                    Dim dtRow As Integer = Grid1.GetDataTableRowIndex(pVal.Row)
                    Col_DatAnt = Convert.ToString(Grid1.DataTable.GetValue(pVal.ColUID, dtRow))
                End If

            Catch ex As Exception

            End Try

        End Sub

        Private Sub Button2_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button2.ClickAfter
            Try

                Me.UIAPIRawForm.Freeze(True)
                Me.Button2.Caption = If(Me.Button2.Caption = "Proyectos Cerrados", "Proyectos Abiertos", "Proyectos Cerrados")
                Cargar_Grids_Gestion_Ingenieria()

            Catch ex As Exception
            Finally
                Me.UIAPIRawForm.Freeze(False)
            End Try

        End Sub

        Private Sub EditText0_KeyDownAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText0.KeyDownAfter

            Select Case pVal.CharPressed
                Case 13
                    Me.Button3.Item.Click()
            End Select

        End Sub

        Private Sub Button3_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button3.ClickAfter

            Try

                Me.UIAPIRawForm.Freeze(True)
                Cargar_Grids_Gestion_Ingenieria()

            Catch ex As Exception
            Finally
                Me.UIAPIRawForm.Freeze(False)
            End Try

        End Sub

        Private Sub Button1_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button1.ClickAfter

            Try

                Me.UIAPIRawForm.Freeze(True)
                EditText0.Item.Click()
                Cargar_Grids_Gestion_Ingenieria()

            Catch ex As Exception
            Finally
                Me.UIAPIRawForm.Freeze(False)
            End Try

        End Sub


        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '  PROCEDIMIENTOS Y FUNCIONES
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------

        Private Sub Cargar_Grids_Gestion_Ingenieria()

            Dim bProgBar As Boolean = True

            '********************* PROGRESS BAR
            Try
                bProgBar = Funciones.Create_ProgressBar(oProgBar, "Cargando Gestion de Ingenieria", 2)
            Catch ex As Exception
            End Try

            Call Cargar_Grid_Estado_Proyectos()
            Call Cargar_Grid_Control_Interno()

            '********************* PROGRESS BAR
            Try
                bProgBar = Funciones.Increment_ProgressBar(oProgBar, 1)
                bProgBar = Funciones.Close_ProgressBar(oProgBar)
            Catch ex As Exception
            End Try

        End Sub

        Private Sub Cargar_Grid_Estado_Proyectos()

            Dim FormID As String = Me.UIAPIRawForm.UniqueID
            Dim GridID As String = Grid0.Item.UniqueID
            Dim sLike As String = Me.EditText0.Value.ToUpper().Trim()

            sPSql = "exec [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Gestion_Ingenieria_Resumen] '" + If(sLike.Trim().Length = 0, "", sLike) + "','" + If(Me.Button2.Caption = "Proyectos Cerrados", "N", "Y") + "'"

            Try
                DT_PR.ExecuteQuery(sPSql)

            Catch ex As Exception

            End Try

            ColMulta = oFunciones.Numero_Columna_Grid(FormID, GridID, "Multa")
            DiasAtra = oFunciones.Numero_Columna_Grid(FormID, GridID, "Dias Atraso")
            DiasDisp = oFunciones.Numero_Columna_Grid(FormID, GridID, "Dias Disp.")

            Me.Grid0.Columns.Item("Projecto").TitleObject.Sortable = True
            Me.Grid0.Columns.Item("Projecto").RightJustified = False
            Me.Grid0.Columns.Item("Projecto").Editable = False
            oEditCol = Me.Grid0.Columns.Item("Projecto")
            oEditCol.LinkedObjectType = 63

            Me.Grid0.Columns.Item("Prj.Nombre").TitleObject.Sortable = True
            Me.Grid0.Columns.Item("Prj.Nombre").Visible = False

            Me.Grid0.Columns.Item("Cliente").TitleObject.Sortable = True
            Me.Grid0.Columns.Item("Cliente").Editable = False
            Me.Grid0.Columns.Item("Cliente").Width = 250

            'Me.Grid0.Columns.Item("Area Asignada").Editable = False

            Me.Grid0.Columns.Item("Multa").Editable = False

            Me.Grid0.Columns.Item("PCVs").Editable = False
            Me.Grid0.Columns.Item("PCVs").RightJustified = True
            oEditCol = Me.Grid0.Columns.Item("PCVs")
            oEditCol.LinkedObjectType = 63

            Me.Grid0.Columns.Item("Visita Tecnica").Editable = False

            Me.Grid0.Columns.Item("Precio Venta").RightJustified = True
            Me.Grid0.Columns.Item("Precio Venta").Editable = False

            Me.Grid0.Columns.Item("Ingreso Ing. GANTT").Editable = False
            Me.Grid0.Columns.Item("Ingreso Ing. GANTT").RightJustified = True

            Me.Grid0.Columns.Item("Ingreso Ing. Real").Editable = False
            Me.Grid0.Columns.Item("Ingreso Ing. Real").RightJustified = True
            If Me.Button2.Caption = "Proyectos Cerrados" Then
                Me.Grid0.Columns.Item("Ingreso Ing. Real").Visible = True
            Else
                Me.Grid0.Columns.Item("Ingreso Ing. Real").Visible = False
            End If

            Me.Grid0.Columns.Item("Salida Ing. GANTT").Editable = False
            Me.Grid0.Columns.Item("Salida Ing. GANTT").RightJustified = True

            Me.Grid0.Columns.Item("Salida Ing. Real").Editable = False
            Me.Grid0.Columns.Item("Salida Ing. Real").RightJustified = True
            If Me.Button2.Caption = "Proyectos Cerrados" Then
                Me.Grid0.Columns.Item("Salida Ing. Real").Visible = False
            Else
                Me.Grid0.Columns.Item("Salida Ing. Real").Visible = True
            End If

            Me.Grid0.Columns.Item("Dias Asignados").Editable = False
            Me.Grid0.Columns.Item("Dias Asignados").RightJustified = True

            Me.Grid0.Columns.Item("Dias Atraso").Editable = False
            Me.Grid0.Columns.Item("Dias Atraso").RightJustified = True

            Me.Grid0.Columns.Item("Dias Disp.").Editable = False
            Me.Grid0.Columns.Item("Dias Disp.").RightJustified = True

            Me.Grid0.Columns.Item("Emision OC Ind.").Editable = False
            Me.Grid0.Columns.Item("Emision OC Ind.").RightJustified = True

            Me.Grid0.Columns.Item("Emision OC Mont.").Editable = False
            Me.Grid0.Columns.Item("Emision OC Mont.").RightJustified = True

            Me.Grid0.Columns.Item("Estado Ingenieria").Editable = False

            Me.Grid0.Columns.Item("Vend.").Editable = False

            Me.Grid0.Columns.Item("Observaciones").Editable = False

            Call Grid_Edo_Proyectos_BackColor()

            Call oFunciones.Numero_Fila_Grid(Grid0)

            Me.Grid0.AutoResizeColumns()

        End Sub

        Private Sub Cargar_Grid_Control_Interno()

            Dim FormID As String = Me.UIAPIRawForm.UniqueID
            Dim GridID As String = Grid1.Item.UniqueID
            Dim sLike As String = Me.EditText0.Value.ToUpper().Trim()

            sPSql = "exec [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Gestion_Ingenieria_Interna] '" + If(sLike.Trim().Length = 0, "", sLike) + "','" + If(Me.Button2.Caption = "Proyectos Cerrados", "N", "Y") + "'"

            Try
                DT_INT.ExecuteQuery(sPSql)

            Catch ex As Exception

            End Try

            ColMultaI = oFunciones.Numero_Columna_Grid(FormID, GridID, "Multa")
            ColVisitaTec = oFunciones.Numero_Columna_Grid(FormID, GridID, "Visita Tecnica")

            Me.Grid1.Columns.Item("Projecto").TitleObject.Sortable = True
            Me.Grid1.Columns.Item("Projecto").RightJustified = False
            Me.Grid1.Columns.Item("Projecto").Editable = False
            oEditCol = Me.Grid1.Columns.Item("Projecto")
            oEditCol.LinkedObjectType = 63

            Me.Grid1.Columns.Item("Prj.Nombre").TitleObject.Sortable = True
            Me.Grid1.Columns.Item("Prj.Nombre").Visible = False

            Me.Grid1.Columns.Item("Cliente").TitleObject.Sortable = True
            Me.Grid1.Columns.Item("Cliente").Editable = False
            Me.Grid1.Columns.Item("Cliente").Width = 250

            'Me.Grid1.Columns.Item("Area Asignada").Editable = False

            Me.Grid1.Columns.Item("Multa").Editable = False

            Me.Grid1.Columns.Item("PCVs").Editable = False
            Me.Grid1.Columns.Item("PCVs").RightJustified = True
            oEditCol = Me.Grid1.Columns.Item("PCVs")
            oEditCol.LinkedObjectType = 63

            Me.Grid1.Columns.Item("Con Visita Tec.").Type = SAPbouiCOM.BoGridColumnType.gct_ComboBox
            oCmbx01 = Me.Grid1.Columns.Item("Con Visita Tec.")
            oCmbx01.ValidValues.Add("", "")
            oCmbx01.ValidValues.Add("Si", "S")
            oCmbx01.ValidValues.Add("No", "N")

            Me.Grid1.Columns.Item("Vend.").Editable = False

            For i = 1 To 11
                Me.Grid1.Columns.Item("Usuario Asociado " + Convert.ToString(i).Trim).Editable = False
            Next

            Me.Grid1.Columns.Item("Usuario Asociado 11").Visible = False

            For i = 0 To Grid1.DataTable.Rows.Count - 1

                If Grid1.DataTable.GetValue("Con Visita Tec.", i) = "No" Then
                    Grid1.CommonSetting.SetCellEditable(i + 1, ColVisitaTec + 1, False)
                Else
                    Grid1.CommonSetting.SetCellEditable(i + 1, ColVisitaTec + 1, True)
                End If
            Next

            Me.Grid1.Columns.Item("Proyecto Cerrado").Type = SAPbouiCOM.BoGridColumnType.gct_CheckBox

            Call Grid_Interno_BackColor()

            Call oFunciones.Numero_Fila_Grid(Grid1)

            Me.Grid1.AutoResizeColumns()

        End Sub

        Private Sub Grid_Edo_Proyectos_BackColor()

            Grid0.Columns.Item("Projecto").BackColor = RGB(224, 255, 255) 'Cian claro
            Grid0.Columns.Item("Cliente").BackColor = RGB(224, 255, 255) 'Cian claro
            'Grid0.Columns.Item("Area Asignada").BackColor = RGB(224, 255, 255) 'Cian claro
            Grid0.Columns.Item("Vend.").BackColor = RGB(224, 255, 255) 'Cian claro
            Grid0.Columns.Item("Observaciones").BackColor = RGB(255, 255, 255) 'Blanco
            Grid0.Columns.Item("Dias Atraso").BackColor = RGB(255, 255, 255) 'Blanco
            Grid0.Columns.Item("Dias Disp.").BackColor = RGB(255, 255, 255) 'Blanco

            Dim nRow As Integer = 0
            For Row = 0 To Grid0.Rows.Count - 1
                nRow = Grid0.GetDataTableRowIndex(Row)
                'Asignar Color a Columna
                If Grid0.DataTable.GetValue("Multa", nRow).ToString = "Si" Then
                    If Row < Grid0.Rows.Count Then
                        Grid0.CommonSetting.SetCellBackColor(Row + 1, ColMulta + 1, RGB(240, 128, 128))
                    End If
                End If

                If (Grid0.DataTable.GetValue("Dias Disp.", nRow) = 0 And Grid0.DataTable.GetValue("Dias Atraso", nRow) = 0) Then
                    Me.Grid0.CommonSetting.SetCellBackColor(Row + 1, DiasDisp + 1, RGB(234, 255, 177))
                    Me.Grid0.CommonSetting.SetCellBackColor(Row + 1, DiasAtra + 1, RGB(234, 255, 177))
                End If

                If Grid0.DataTable.GetValue("Dias Disp.", nRow) > 0 Then
                    Me.Grid0.CommonSetting.SetCellBackColor(Row + 1, DiasDisp + 1, RGB(48, 204, 0))
                End If

                If Grid0.DataTable.GetValue("Dias Atraso", nRow) > 0 Then
                    Me.Grid0.CommonSetting.SetCellBackColor(Row + 1, DiasAtra + 1, RGB(240, 128, 128))
                End If

            Next

        End Sub

        Private Sub Grid_Interno_BackColor()

            Grid1.Columns.Item("Projecto").BackColor = RGB(224, 255, 255) 'Cian claro
            Grid1.Columns.Item("Cliente").BackColor = RGB(224, 255, 255) 'Cian claro
            'Grid1.Columns.Item("Area Asignada").BackColor = RGB(224, 255, 255) 'Cian claro
            Grid1.Columns.Item("Vend.").BackColor = RGB(224, 255, 255) 'Cian claro
            Grid1.Columns.Item("PCVs").BackColor = RGB(255, 255, 255) 'Blanco
            Grid1.Columns.Item("Multa").BackColor = RGB(255, 255, 255) 'Blanco


            For i = 1 To 11
                Me.Grid1.Columns.Item("Usuario Asociado " + Convert.ToString(i).Trim).BackColor = RGB(224, 255, 255) 'Cian claro
            Next

            Dim nRow As Integer = 0
            For Row = 0 To Grid1.Rows.Count - 1
                nRow = Grid1.GetDataTableRowIndex(Row)
                'Asignar Color a Columna
                If Grid1.DataTable.GetValue("Multa", nRow).ToString = "Si" Then
                    If Row < Grid1.Rows.Count Then
                        'Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, 1, RGB(240, 128, 128))
                        'Grd_PlanifMont.CommonSetting.SetCellBackColor(Row + 1, 2, RGB(240, 128, 128))
                        Grid1.CommonSetting.SetCellBackColor(Row + 1, ColMultaI + 1, RGB(240, 128, 128))
                    End If
                End If

            Next

        End Sub

        Private Sub ActualizaProyecto(vRow As Integer, vCol As String)

            'Me.UIAPIRawForm.Freeze(False)

            vRow = Me.Grid1.GetDataTableRowIndex(vRow)
            Try
                Me.UIAPIRawForm.Freeze(True)
                Dim NumProyec As String = Grid1.DataTable.GetValue("Projecto", vRow)
                Dim FecRecepcion As String = Grid1.DataTable.GetValue("Recepción Carpeta/Creación de OT", vRow)
                Dim FecDistribucion As String = Grid1.DataTable.GetValue("Distribución Proyecto", vRow)
                Dim FecVisita As String = Grid1.DataTable.GetValue("Visita Tecnica", vRow)
                Dim FecPlano As String = Grid1.DataTable.GetValue("Plano Proyecto", vRow)
                Dim FecCubicacion As String = Grid1.DataTable.GetValue("Cubicación", vRow)
                Dim FecReceta As String = Grid1.DataTable.GetValue("Creación Codigos/Recetas", vRow)
                Dim FecPCV As String = Grid1.DataTable.GetValue("Grabación de PCV", vRow)
                Dim FecOCInd As String = Grid1.DataTable.GetValue("Generación OC Industrial", vRow)
                Dim FecOCMont As String = Grid1.DataTable.GetValue("Generación OC Montaje", vRow)
                Dim FecCierre As String = Grid1.DataTable.GetValue("Confirmación y Cierre Proy.", vRow)
                Dim Entregado As String = Grid1.DataTable.GetValue("Proyecto Cerrado", vRow)

                'Actualiza Datos del Proyecto en ZINFOP
                sPSql = "UPDATE [" + sBDComercial.Trim() + "].DBO.[@ZINFOP]  Set " & _
               " [U_Visita_Tec]     =     '" + Grid1.DataTable.GetValue("Con Visita Tec.", vRow).ToString() + "'" & _
               ",[U_Fec_Recep_Ing]  =     IIF(LEN(LTRIM(RTRIM('" + FecRecepcion + "')))=0,null,CONVERT(DATE,'" + FecRecepcion + "',103)) " & _
               ",[U_Usu_Recep_Ing]	=	  '" + Grid1.DataTable.GetValue("Usuario Asociado 1", vRow).ToString() + "'" & _
               ",[U_Fec_Distri_Ing]	=	  IIF(LEN(LTRIM(RTRIM('" + FecDistribucion + "')))=0,null,CONVERT(DATE,'" + FecDistribucion + "',103)) " & _
               ",[U_Usu_Distri_Ing]	=	  '" + Grid1.DataTable.GetValue("Usuario Asociado 2", vRow).ToString() + "'" & _
               ",[U_Fec_Visita_Ing]	=	  IIF(LEN(LTRIM(RTRIM('" + FecVisita + "')))=0,null,CONVERT(DATE,'" + FecVisita + "',103)) " & _
               ",[U_Usu_Visita_Ing]	=	  '" + Grid1.DataTable.GetValue("Usuario Asociado 3", vRow).ToString() + "'" & _
               ",[U_Fec_Plano_Ing]	=	  IIF(LEN(LTRIM(RTRIM('" + FecPlano + "')))=0,null,CONVERT(DATE,'" + FecPlano + "',103)) " & _
               ",[U_Usu_Plano_Ing]	=	  '" + Grid1.DataTable.GetValue("Usuario Asociado 4", vRow).ToString() + "'" & _
               ",[U_Fec_Cubicacion_Ing] = IIF(LEN(LTRIM(RTRIM('" + FecCubicacion + "')))=0,null,CONVERT(DATE,'" + FecCubicacion + "',103)) " & _
               ",[U_Usu_Cubicacion_Ing]	= '" + Grid1.DataTable.GetValue("Usuario Asociado 5", vRow).ToString() + "'" & _
               ",[U_Fec_Receta_Ing]	=	  IIF(LEN(LTRIM(RTRIM('" + FecReceta + "')))=0,null,CONVERT(DATE,'" + FecReceta + "',103)) " & _
               ",[U_Usu_Receta_Ing]	=	  '" + Grid1.DataTable.GetValue("Usuario Asociado 6", vRow).ToString() + "'" & _
               ",[U_Fec_PCV_Ing]	=	  IIF(LEN(LTRIM(RTRIM('" + FecPCV + "')))=0,null,CONVERT(DATE,'" + FecPCV + "',103)) " & _
               ",[U_Usu_PCV_Ing]	=	  '" + Grid1.DataTable.GetValue("Usuario Asociado 7", vRow).ToString() + "'" & _
               ",[U_Fec_OC_Ind_Ing]	=	  IIF(LEN(LTRIM(RTRIM('" + FecOCInd + "')))=0,null,CONVERT(DATE,'" + FecOCInd + "',103)) " & _
               ",[U_Usu_OC_Ind_Ing]	=	  '" + Grid1.DataTable.GetValue("Usuario Asociado 8", vRow).ToString() + "'" & _
               ",[U_Fec_OC_Mont_Ing] =	  IIF(LEN(LTRIM(RTRIM('" + FecOCMont + "')))=0,null,CONVERT(DATE,'" + FecOCMont + "',103)) " & _
               ",[U_Usu_OC_Mont_Ing] =	  '" + Grid1.DataTable.GetValue("Usuario Asociado 9", vRow).ToString() + "'" & _
               ",[U_Fec_Cierre_Ing]	=	  IIF(LEN(LTRIM(RTRIM('" + FecCierre + "')))=0,null,CONVERT(DATE,'" + FecCierre + "',103)) " & _
               ",[U_Usu_Cierre_Ing]	=	  '" + Grid1.DataTable.GetValue("Usuario Asociado 10", vRow).ToString() + "'" & _
               ",[U_Comentario_Ing]	=	  '" + Grid1.DataTable.GetValue("Observaciones", vRow).ToString() + "'" & _
               ",[U_Pro_Ing_Entreg] =     '" + Entregado + "'" & _
               ",[U_Usu_Entrega_Pro] =    '" + Grid1.DataTable.GetValue("Usuario Asociado 11", vRow).ToString() + "'" & _
               ",[U_Fec_Real_Ter_Des] =   IIF(LEN(LTRIM(RTRIM('" + FecCierre + "')))=0,null,CONVERT(DATE,'" + FecCierre + "',103)) " & _
               " Where convert(nvarchar(max),U_PrjCode) = '" + NumProyec + "'"

                Try
                    DT_SQL.ExecuteQuery(sPSql)
                Catch ex As Exception

                End Try

                'Inserta registro de Historico en @ZHFGING para el proyecto afectado
                Dim nProx As Integer = oFunciones.Proximo_Codigo_Correlativo("@ZHFGING", "Code", DT_SQL)
                sPSql = " INSERT INTO [dbo].[@ZHFGING] " & _
                        " ([Code]" & _
                        " ,[Name]" & _
                        " ,[U_PrjCode]" & _
                        " ,[U_Cod_Usuario]" & _
                        " ,[U_Nom_Usuario]" & _
                        " ,[U_Fec_Registro]" & _
                        " ,[U_Hora_Registro]" & _
                        " ,[U_Fec_Recep_Ing]" & _
                        " ,[U_Usu_Recep_Ing]" & _
                        " ,[U_Fec_Distri_Ing]" & _
                        " ,[U_Usu_Distri_Ing]" & _
                        " ,[U_Fec_Visita_Ing]" & _
                        " ,[U_Usu_Visita_Ing]" & _
                        " ,[U_Fec_Plano_Ing]" & _
                        " ,[U_Usu_Plano_Ing]" & _
                        " ,[U_Fec_Cubicacion_Ing]" & _
                        " ,[U_Usu_Cubicacion_Ing]" & _
                        " ,[U_Fec_Receta_Ing]" & _
                        " ,[U_Usu_Receta_Ing]" & _
                        " ,[U_Fec_PCV_Ing]" & _
                        " ,[U_Usu_PCV_Ing]" & _
                        " ,[U_Fec_OC_Ind_Ing]" & _
                        " ,[U_Usu_OC_Ind_Ing]" & _
                        " ,[U_Fec_OC_Mont_Ing]" & _
                        " ,[U_Usu_OC_Mont_Ing]" & _
                        " ,[U_Fec_Cierre_Ing]" & _
                        " ,[U_Usu_Cierre_Ing]" & _
                        " ,[U_Comentario_Ing]" & _
                        " ,[U_Visita_Tec]" & _
                        " ,[U_Pro_Ing_Entreg]" & _
                        " ,[U_Usu_Entrega_Pro])" & _
                        "      VALUES( " & _
                        " '" + nProx.ToString + "'" & _
                        " ,'" + nProx.ToString + "' " & _
                        " ,'" + NumProyec + "' " & _
                        " ,'" + oConectarAplicacion.sCodUsuActual + "' " & _
                        " ,'" + oConectarAplicacion.sNomUsuActual + "' " & _
                        " ,CONVERT(DATE,'" + Date.Now + "',103) " & _
                        " ,'" + Now.ToString("HH:mm:ss").Replace(":", "") + "' " & _
                        ",IIF(LEN(LTRIM(RTRIM('" + FecRecepcion + "')))=0,null,CONVERT(DATE,'" + FecRecepcion + "',103)) " & _
                        ",'" + Grid1.DataTable.GetValue("Usuario Asociado 1", vRow).ToString() + "'" & _
                        ",IIF(LEN(LTRIM(RTRIM('" + FecDistribucion + "')))=0,null,CONVERT(DATE,'" + FecDistribucion + "',103)) " & _
                        ",'" + Grid1.DataTable.GetValue("Usuario Asociado 2", vRow).ToString() + "'" & _
                        ",IIF(LEN(LTRIM(RTRIM('" + FecVisita + "')))=0,null,CONVERT(DATE,'" + FecVisita + "',103)) " & _
                        ",'" + Grid1.DataTable.GetValue("Usuario Asociado 3", vRow).ToString() + "'" & _
                        ",IIF(LEN(LTRIM(RTRIM('" + FecPlano + "')))=0,null,CONVERT(DATE,'" + FecPlano + "',103)) " & _
                        ",'" + Grid1.DataTable.GetValue("Usuario Asociado 4", vRow).ToString() + "'" & _
                        ",IIF(LEN(LTRIM(RTRIM('" + FecCubicacion + "')))=0,null,CONVERT(DATE,'" + FecCubicacion + "',103)) " & _
                        ",'" + Grid1.DataTable.GetValue("Usuario Asociado 5", vRow).ToString() + "'" & _
                        ",IIF(LEN(LTRIM(RTRIM('" + FecReceta + "')))=0,null,CONVERT(DATE,'" + FecReceta + "',103)) " & _
                        ",'" + Grid1.DataTable.GetValue("Usuario Asociado 6", vRow).ToString() + "'" & _
                        ",IIF(LEN(LTRIM(RTRIM('" + FecPCV + "')))=0,null,CONVERT(DATE,'" + FecPCV + "',103)) " & _
                        ",'" + Grid1.DataTable.GetValue("Usuario Asociado 7", vRow).ToString() + "'" & _
                        ",IIF(LEN(LTRIM(RTRIM('" + FecOCInd + "')))=0,null,CONVERT(DATE,'" + FecOCInd + "',103)) " & _
                        ",'" + Grid1.DataTable.GetValue("Usuario Asociado 8", vRow).ToString() + "'" & _
                        ",IIF(LEN(LTRIM(RTRIM('" + FecOCMont + "')))=0,null,CONVERT(DATE,'" + FecOCMont + "',103)) " & _
                        ",'" + Grid1.DataTable.GetValue("Usuario Asociado 9", vRow).ToString() + "'" & _
                        ",IIF(LEN(LTRIM(RTRIM('" + FecCierre + "')))=0,null,CONVERT(DATE,'" + FecCierre + "',103)) " & _
                        ",'" + Grid1.DataTable.GetValue("Usuario Asociado 10", vRow).ToString() + "'" & _
                        ",'" + Grid1.DataTable.GetValue("Observaciones", vRow).ToString() + "'" & _
                        ",'" + Grid1.DataTable.GetValue("Con Visita Tec.", vRow).ToString() + "'" & _
                        ",'" + Entregado + "'" & _
                        ",'" + Grid1.DataTable.GetValue("Usuario Asociado 11", vRow).ToString() + "')"

                Try
                    DT_SQL.ExecuteQuery(sPSql)
                Catch ex As Exception

                End Try

            Catch ex As Exception
                Application.SBO_Application.StatusBar.SetText(ex.Message)
            Finally
                Me.UIAPIRawForm.Freeze(False)
            End Try

        End Sub

        'Public Overridable Sub Ing_Item_Event(ByVal FormUID As String, ByRef pVal As SAPbouiCOM.ItemEvent, ByRef BubbleEvent As Boolean)

        '    If pVal.FormTypeEx = "SBOAddonProject1.FrmGestion_Ingenieria" And pVal.EventType = SAPbouiCOM.BoEventTypes.et_GOT_FOCUS And
        '        pVal.BeforeAction = False Then

        '        If nCountEvent = 0 Then
        '            nCountEvent += 1
        '        Else
        '            nCountEvent = 0
        '            BubbleEvent = False
        '        End If

        '    End If



        'End Sub


        Private WithEvents Folder0 As SAPbouiCOM.Folder
        Private WithEvents Folder1 As SAPbouiCOM.Folder
        Private WithEvents Grid0 As SAPbouiCOM.Grid
        Private WithEvents Grid1 As SAPbouiCOM.Grid
        Private WithEvents Button0 As SAPbouiCOM.Button
        Private WithEvents Button1 As SAPbouiCOM.Button
        Private WithEvents Button2 As SAPbouiCOM.Button
        Private WithEvents DT_SQL As SAPbouiCOM.DataTable
        Private WithEvents DT_PR As SAPbouiCOM.DataTable
        Private WithEvents DT_INT As SAPbouiCOM.DataTable
        Private WithEvents oCmbx01 As SAPbouiCOM.ComboBoxColumn
        Private WithEvents Button3 As SAPbouiCOM.Button
        Private WithEvents EditText0 As SAPbouiCOM.EditText



    End Class
End Namespace
