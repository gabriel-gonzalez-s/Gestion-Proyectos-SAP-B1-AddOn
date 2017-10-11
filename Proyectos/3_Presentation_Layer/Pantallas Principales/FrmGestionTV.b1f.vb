Option Strict Off
Option Explicit On

Imports SAPbouiCOM.Framework

Namespace SBOAddonProject1
    <FormAttribute("SBOAddonProject1.FrmGestionTV", "3_Presentation_Layer/Pantallas Principales/FrmGestionTV.b1f")>
    Friend Class FrmGestionTV
        Inherits UserFormBase

        Private ValIni As String = ""
        Private ValAnt As String = ""
        Private MaxMens As Integer = 50
        Private Tope As Boolean = False

        Public Sub New()
        End Sub

        Public Overrides Sub OnInitializeComponent()
            Me.Grid0 = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.Grid)
            Me.EditText0 = CType(Me.GetItem("Item_1").Specific, SAPbouiCOM.EditText)
            Me.EditText1 = CType(Me.GetItem("Item_2").Specific, SAPbouiCOM.EditText)
            Me.EditText2 = CType(Me.GetItem("Item_3").Specific, SAPbouiCOM.EditText)
            Me.EditText3 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.EditText)
            Me.EditText4 = CType(Me.GetItem("Item_5").Specific, SAPbouiCOM.EditText)
            Me.StaticText0 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.StaticText)
            Me.StaticText1 = CType(Me.GetItem("Item_7").Specific, SAPbouiCOM.StaticText)
            Me.StaticText2 = CType(Me.GetItem("Item_8").Specific, SAPbouiCOM.StaticText)
            Me.StaticText3 = CType(Me.GetItem("Item_9").Specific, SAPbouiCOM.StaticText)
            Me.StaticText4 = CType(Me.GetItem("Item_10").Specific, SAPbouiCOM.StaticText)
            Me.Folder0 = CType(Me.GetItem("Item_12").Specific, SAPbouiCOM.Folder)
            Me.Button0 = CType(Me.GetItem("Item_13").Specific, SAPbouiCOM.Button)
            Me.Button1 = CType(Me.GetItem("Item_14").Specific, SAPbouiCOM.Button)
            Me.EditText5 = CType(Me.GetItem("Item_15").Specific, SAPbouiCOM.EditText)
            Me.StaticText5 = CType(Me.GetItem("Item_16").Specific, SAPbouiCOM.StaticText)
            Me.DT_SQL = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_SQL")
            Me.DT_MENS = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_MENS")
            Me.Button2 = CType(Me.GetItem("Item_17").Specific, SAPbouiCOM.Button)
            Me.Button3 = CType(Me.GetItem("Item_18").Specific, SAPbouiCOM.Button)
            Me.StaticText6 = CType(Me.GetItem("Item_19").Specific, SAPbouiCOM.StaticText)
            Me.Button4 = CType(Me.GetItem("Item_20").Specific, SAPbouiCOM.Button)
            Me.OnCustomInitialize()

        End Sub

        Public Overrides Sub OnInitializeFormEvents()

        End Sub


        Private Sub OnCustomInitialize()

            Button2.Item.Visible = False
            Button3.Item.Visible = False
            Me.UIAPIRawForm.EnableMenu(1281, False)
            Me.UIAPIRawForm.EnableMenu(1282, False)
            Call Inicializar_Pantalla_Gestion_TV()
            Call Cargar_Grid_Mensajes_TV()


        End Sub

        Private Sub Grid0_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid0.ClickAfter
            Try

                Grid0.Rows.SelectedRows.Add(pVal.Row)

                Dim FecDesde As String = Grid0.DataTable.GetValue(2, pVal.Row)
                Dim FecHasta As String = Grid0.DataTable.GetValue(4, pVal.Row)

                Me.UIAPIRawForm.Freeze(True)

                EditText0.Value = Grid0.DataTable.GetValue(1, pVal.Row)
                StaticText6.Caption = "Caracteres Restantes: " + (MaxMens - EditText0.Value.Trim.Length).ToString
                EditText1.String = FecDesde
                EditText2.String = FecHasta
                EditText3.Value = Grid0.DataTable.GetValue(3, pVal.Row)
                EditText4.Value = Grid0.DataTable.GetValue(5, pVal.Row)

                EditText5.Value = Grid0.DataTable.GetValue(0, pVal.Row)

                Button0.Caption = "Actualizar"
                Me.UIAPIRawForm.EnableMenu(1282, True)
                Me.Folder0.Item.Click()

            Catch ex As Exception
            Finally
                Me.UIAPIRawForm.Freeze(False)
            End Try
        End Sub

        Private Sub Button0_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button0.ClickAfter

            oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)

            Dim Valida As String = Validar_Campos()

            If Valida.Trim.Length = 0 Then ' Valida que los campos ingresados sean correctos

                Select Case Button0.Caption.Trim

                    Case "Crear"

                        Try



                            Dim nProx As Integer = oFunciones.Proximo_Codigo_Correlativo("@ZTVMONT", "Code", DT_SQL)
                            Dim FecDesde As String = Me.EditText1.String.Trim() + " " + EditText3.Value.Trim()
                            Dim FecHasta As String = Me.EditText2.String.Trim() + " " + EditText4.Value.Trim()

                            'Insertar Registro en la Tabla de AFPs

                            sPSql = " INSERT INTO [" + sBDComercial + "].[dbo].[@ZTVMONT] " &
                                    " ([Code] " &
                                    " ,[Name] " &
                                    " ,[U_Texto] " &
                                    " ,[U_FecInicio] " &
                                    " ,[U_HoraInicio] " &
                                    " ,[U_FecFinal] " &
                                    " ,[U_HoraFinal]) " &
                                    "                 VALUES " &
                                    " (" + nProx.ToString + " " &
                                    " ," + nProx.ToString + " " &
                                    " ,'" + EditText0.Value.Trim() + "' " &
                                    " ,convert(date,'" + FecDesde.Trim() + "',103) " &
                                    " ," + oFunciones.Hora_a_HoraSAPBD(EditText3.Value.Trim()) + " " &
                                    " ,convert(date,'" + FecHasta.Trim() + "',103) " &
                                    " ," + oFunciones.Hora_a_HoraSAPBD(EditText4.Value.Trim()) + ")  "

                            Try
                                DT_SQL.ExecuteQuery(sPSql)
                            Catch ex As Exception

                            End Try

                            Application.SBO_Application.StatusBar.SetText("Registro Exitoso de Mensaje de Marquesina", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success)

                            oForm.Freeze(True)
                            Call Cargar_Grid_Mensajes_TV()
                            Call Inicializar_Pantalla_Gestion_TV()

                        Catch ex As Exception

                        Finally
                            oForm.Freeze(False)
                        End Try

                    Case "Actualizar"

                        Try

                            Dim FecDesde As String = Me.EditText1.String.Trim() + " " + EditText3.Value.Trim()
                            Dim FecHasta As String = Me.EditText2.String.Trim() + " " + EditText4.Value.Trim()

                            sPSql = " UPDATE [" + sBDComercial + "].[dbo].[@ZTVMONT] " &
                                    " SET [U_Texto] = '" + EditText0.Value.Trim() + "'" &
                                    "     ,[U_FecInicio] = convert(date,'" + FecDesde.Trim() + "',103) " &
                                    "     ,[U_HoraInicio] = " + oFunciones.Hora_a_HoraSAPBD(EditText3.Value.Trim()) + " " &
                                    "     ,[U_FecFinal] = convert(date,'" + FecHasta.Trim() + "',103) " &
                                    "     ,[U_HoraFinal] = " + oFunciones.Hora_a_HoraSAPBD(EditText4.Value.Trim()) + " " &
                                    " WHERE Code  = " + EditText5.Value.Trim()

                            Try
                                DT_SQL.ExecuteQuery(sPSql)
                            Catch ex As Exception

                            End Try

                            Application.SBO_Application.StatusBar.SetText("Actualizacion Exitosa de de Mensaje de Marquesina", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success)
                            oForm.Freeze(True)
                            Call Cargar_Grid_Mensajes_TV()

                        Catch ex As Exception

                        Finally
                            oForm.Freeze(False)
                        End Try

                End Select

            Else
                Application.SBO_Application.MessageBox(Valida.Trim)
            End If

        End Sub

        Private Sub Button1_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button1.ClickAfter

            Me.UIAPIRawForm.Close()

        End Sub

        Private Sub Button2_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button2.ClickAfter

            Inicializar_Pantalla_Gestion_TV()
            Me.UIAPIRawForm.EnableMenu(1282, False)
            Grid0.Rows.SelectedRows.Clear()

        End Sub

        Private Sub Button3_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button3.ClickAfter

            Try

                'Dim rowNum As Integer = Grid0.GetCellFocus.rowIndex
                Dim rowNum As Integer = Grid0.Rows.SelectedRows.Item(0, SAPbouiCOM.BoOrderType.ot_RowOrder)

                If rowNum >= 0 Then

                    Call Eliminar_MensajeBD(Grid0.DataTable.GetValue(0, rowNum))
                    DT_MENS.Rows.Remove(rowNum)
                    Call Inicializar_Pantalla_Gestion_TV()

                End If

            Catch ex As Exception

            End Try

        End Sub

        Private Sub EditText3_KeyDownBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles EditText3.KeyDownBefore

            ValAnt = EditText3.Value.Trim

            If (pVal.CharPressed = 8 Or pVal.CharPressed = 36) And EditText3.Value.Trim.Length = 6 Then
                BubbleEvent = False
            End If


        End Sub

        Private Sub EditText3_KeyDownAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText3.KeyDownAfter

            If EditText3.Value.Trim.Length < 6 Then
                EditText3.Value = "00:00:00"
            ElseIf EditText3.Value.Trim.Length > 1 And EditText3.Value.Trim.Length < 6 Then
                EditText3.Value = ValAnt
            ElseIf EditText3.Value.Trim.Length > 8 Then
                Application.SBO_Application.SendKeys("{BACKSPACE}")
            ElseIf oFunciones.Cantidad_Caracter(EditText3.Value, ":") < 2 Then
                EditText3.Value = ValAnt
            End If

            If Not oFunciones.Teclas_Control_Permitidas(pVal, EditText3) Then

                If Not oFunciones.KeyHoraLarga(pVal, EditText3) Then
                    Application.SBO_Application.SendKeys("{BACKSPACE}")
                End If

                If Not oFunciones.HoraValidaHHMMSS(EditText3.Value) Then
                    Application.SBO_Application.SendKeys("{BACKSPACE}")
                End If

            End If

        End Sub

        Private Sub EditText3_ValidateAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText3.ValidateAfter
            Try
                If ValIni <> EditText3.Value.Trim() Then

                    If Not oFunciones.EsCadenaEntero(Left(EditText3.Value.Trim(), 2)) Then
                        EditText3.Value = "0" + EditText3.Value.Trim
                    End If

                    If Not oFunciones.EsCadenaEntero(Right(EditText3.Value.Trim(), 2)) Then
                        EditText3.Value = EditText3.Value.Trim.Substring(0, EditText3.Value.Length - 1) + "0" + Right(EditText3.Value.Trim(), 1)
                    End If

                    If Not oFunciones.EsCadenaEntero(EditText3.Value.Trim.Substring(3, 2)) Then
                        EditText3.Value = EditText3.Value.Trim.Substring(0, EditText3.Value.Length - 4) + "0" + Right(EditText3.Value.Trim(), 4)

                    End If

                    ValIni = EditText3.Value.Trim()

                End If
            Catch ex As Exception

            End Try

        End Sub

        Private Sub EditText3_GotFocusAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText3.GotFocusAfter

            ValIni = EditText3.Value.Trim

        End Sub

        Private Sub EditText4_KeyDownBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles EditText4.KeyDownBefore

            ValAnt = EditText4.Value.Trim

            If (pVal.CharPressed = 8 Or pVal.CharPressed = 36) And EditText4.Value.Trim.Length = 6 Then
                BubbleEvent = False
            End If


        End Sub

        Private Sub EditText4_KeyDownAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText4.KeyDownAfter

            If EditText4.Value.Trim.Length < 6 Then
                EditText4.Value = "00:00:00"
            ElseIf EditText4.Value.Trim.Length > 1 And EditText4.Value.Trim.Length < 6 Then
                EditText4.Value = ValAnt
            ElseIf EditText4.Value.Trim.Length > 8 Then
                Application.SBO_Application.SendKeys("{BACKSPACE}")
            ElseIf oFunciones.Cantidad_Caracter(EditText4.Value, ":") < 2 Then
                EditText4.Value = ValAnt
            End If

            If Not oFunciones.Teclas_Control_Permitidas(pVal, EditText4) Then

                If Not oFunciones.KeyHoraLarga(pVal, EditText4) Then
                    Application.SBO_Application.SendKeys("{BACKSPACE}")
                End If

                If Not oFunciones.HoraValidaHHMMSS(EditText4.Value) Then
                    Application.SBO_Application.SendKeys("{BACKSPACE}")
                End If

            End If

        End Sub

        Private Sub EditText4_ValidateAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText4.ValidateAfter

            Try
                If ValIni <> EditText4.Value.Trim() Then

                    If Not oFunciones.EsCadenaEntero(Left(EditText4.Value.Trim(), 2)) Then
                        EditText4.Value = "0" + EditText4.Value.Trim
                    End If

                    If Not oFunciones.EsCadenaEntero(Right(EditText4.Value.Trim(), 2)) Then
                        EditText4.Value = EditText4.Value.Trim.Substring(0, EditText4.Value.Length - 1) + "0" + Right(EditText4.Value.Trim(), 1)
                    End If

                    If Not oFunciones.EsCadenaEntero(EditText4.Value.Trim.Substring(3, 2)) Then
                        EditText4.Value = EditText4.Value.Trim.Substring(0, EditText4.Value.Length - 4) + "0" + Right(EditText4.Value.Trim(), 4)

                    End If

                    ValIni = EditText4.Value.Trim()

                End If
            Catch ex As Exception

            End Try

        End Sub

        Private Sub EditText4_GotFocusAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText4.GotFocusAfter

            ValIni = EditText4.Value.Trim

        End Sub


        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '  PROCEDIMIENTOS Y FUNCIONES
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------

        Private Sub Cargar_Grid_Mensajes_TV()

            sPSql = " SELECT Code as Num,U_Texto as Mensaje, U_FecInicio as 'Fecha Inicio'," &
                    " CAST(U_HoraInicio as nvarchar) as 'Hora Inicio',U_FecFinal as 'Fecha Final',CAST(U_HoraFinal as nvarchar) as 'Hora Final' " &
                    " FROM [" + sBDComercial + "].[DBO].[@ZTVMONT] ORDER BY CAST(Code as INT)"

            Try

                Grid0.DataTable.ExecuteQuery(sPSql)

                Dim HoraInicio As String = ""
                Dim HoraFinal As String = ""
                For i = 0 To Grid0.DataTable.Rows.Count - 1

                    HoraInicio = oFunciones.HoraSAPBD_a_Hora(Grid0.DataTable.GetValue(3, i))
                    HoraFinal = oFunciones.HoraSAPBD_a_Hora(Grid0.DataTable.GetValue(5, i))
                    Grid0.DataTable.SetValue(3, i, HoraInicio)
                    Grid0.DataTable.SetValue(5, i, HoraFinal)

                Next
            Catch ex As Exception

            End Try

        End Sub

        Private Sub Inicializar_Pantalla_Gestion_TV()

            Try

                Me.UIAPIRawForm.Freeze(True)

                Button0.Caption = "Crear"
                EditText0.Value = ""
                EditText1.String = Date.Now.ToShortDateString
                EditText2.String = Date.Now.ToShortDateString
                EditText3.Value = "00:00:00"
                EditText4.Value = "00:00:00"
                EditText5.Value = ""
                StaticText6.Caption = "Caracteres Restantes: " + If(MaxMens = 0, 50, MaxMens).ToString

                Me.Folder0.Item.Click()

            Catch ex As Exception
            Finally
                Me.UIAPIRawForm.Freeze(False)
            End Try


        End Sub

        Private Function Validar_Campos() As String

            Validar_Campos = ""

            If EditText0.Value.Trim.Length = 0 Then
                Return "Ingresar un Mensaje"
            End If

            If EditText1.Value.Trim.Length = 0 Then
                Return "Ingresar una Fecha de Inicio"
            End If

            If EditText2.Value.Trim.Length = 0 Then
                Return "Ingresar una Fecha Final"
            End If

            If EditText3.Value.Trim.Length = 0 Then
                Return "Ingresar una Hora de Inicio"
            End If

            If EditText4.Value.Trim.Length = 0 Then
                Return "Ingresar una Hora Final"
            End If


        End Function

        Private Sub Eliminar_MensajeBD(Codigo As Integer)

            sPSql = " DELETE FROM [" + sBDComercial + "].[DBO].[@ZTVMONT] " &
                    " WHERE Code = " + Codigo.ToString

            Try
                DT_SQL.ExecuteQuery(sPSql)
            Catch ex As Exception

            End Try


        End Sub

        Private WithEvents Grid0 As SAPbouiCOM.Grid
        Private WithEvents EditText0 As SAPbouiCOM.EditText
        Private WithEvents EditText1 As SAPbouiCOM.EditText
        Private WithEvents EditText2 As SAPbouiCOM.EditText
        Private WithEvents EditText3 As SAPbouiCOM.EditText
        Private WithEvents EditText4 As SAPbouiCOM.EditText
        Private WithEvents StaticText0 As SAPbouiCOM.StaticText
        Private WithEvents StaticText1 As SAPbouiCOM.StaticText
        Private WithEvents StaticText2 As SAPbouiCOM.StaticText
        Private WithEvents StaticText3 As SAPbouiCOM.StaticText
        Private WithEvents StaticText4 As SAPbouiCOM.StaticText
        Private WithEvents Folder0 As SAPbouiCOM.Folder
        Private WithEvents Button0 As SAPbouiCOM.Button
        Private WithEvents Button1 As SAPbouiCOM.Button
        Private WithEvents EditText5 As SAPbouiCOM.EditText
        Private WithEvents StaticText5 As SAPbouiCOM.StaticText
        Private WithEvents DT_SQL As SAPbouiCOM.DataTable
        Private WithEvents DT_MENS As SAPbouiCOM.DataTable
        Private WithEvents Button2 As SAPbouiCOM.Button
        Private WithEvents Button3 As SAPbouiCOM.Button
        Private WithEvents StaticText6 As SAPbouiCOM.StaticText




        Private Sub EditText0_KeyDownAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText0.KeyDownAfter

            If EditText0.Value.Trim.Length() > MaxMens Then
                Application.SBO_Application.SendKeys("{BACKSPACE}")
            Else
                StaticText6.Caption = "Caracteres Restantes: " + (MaxMens - EditText0.Value.Trim.Length).ToString
            End If


        End Sub


        Private Sub EditText0_KeyDownBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles EditText0.KeyDownBefore

            'If EditText0.Value.Trim.Length() >= MaxMens Then
            '    Application.SBO_Application.SendKeys("{BACKSPACE}")
            'End If

        End Sub

        Private WithEvents Button4 As SAPbouiCOM.Button

        Private Sub Button4_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg)
            Throw New System.NotImplementedException()

        End Sub
    End Class

End Namespace
