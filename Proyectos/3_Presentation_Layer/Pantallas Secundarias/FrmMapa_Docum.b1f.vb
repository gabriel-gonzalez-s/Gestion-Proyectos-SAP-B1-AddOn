Option Strict Off
Option Explicit On

Imports SAPbouiCOM.Framework

Namespace SBOAddonProject1
    <FormAttribute("SBOAddonProject1.FormMapaD", "3_Presentation_Layer/Pantallas Secundarias/FrmMapa_Docum.b1f")>
    Friend Class FormMapaD
        Inherits UserFormBase

        Dim conta As Integer = 0

        Public Sub New()
        End Sub

        Public Overrides Sub OnInitializeComponent()
            Me.StaticText2 = CType(Me.GetItem("Item_9").Specific, SAPbouiCOM.StaticText)
            Me.EditText0 = CType(Me.GetItem("Item_10").Specific, SAPbouiCOM.EditText)
            Me.StaticText3 = CType(Me.GetItem("Item_11").Specific, SAPbouiCOM.StaticText)
            Me.EditText1 = CType(Me.GetItem("Item_12").Specific, SAPbouiCOM.EditText)
            Me.StaticText4 = CType(Me.GetItem("Item_13").Specific, SAPbouiCOM.StaticText)
            Me.EditText2 = CType(Me.GetItem("Item_14").Specific, SAPbouiCOM.EditText)
            Me.StaticText5 = CType(Me.GetItem("Item_15").Specific, SAPbouiCOM.StaticText)
            Me.EditText3 = CType(Me.GetItem("Item_16").Specific, SAPbouiCOM.EditText)
            Me.StaticText6 = CType(Me.GetItem("Item_17").Specific, SAPbouiCOM.StaticText)
            Me.EditText4 = CType(Me.GetItem("Item_18").Specific, SAPbouiCOM.EditText)
            Me.StaticText7 = CType(Me.GetItem("Item_19").Specific, SAPbouiCOM.StaticText)
            Me.EditText5 = CType(Me.GetItem("Item_20").Specific, SAPbouiCOM.EditText)
            Me.StaticText8 = CType(Me.GetItem("Item_21").Specific, SAPbouiCOM.StaticText)
            Me.EditText6 = CType(Me.GetItem("Item_22").Specific, SAPbouiCOM.EditText)
            Me.StaticText9 = CType(Me.GetItem("Item_23").Specific, SAPbouiCOM.StaticText)
            Me.EditText7 = CType(Me.GetItem("Item_24").Specific, SAPbouiCOM.EditText)
            Me.StaticText10 = CType(Me.GetItem("Item_25").Specific, SAPbouiCOM.StaticText)
            Me.DT_COMER = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_COMER")
            Me.DT_NOCOM = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_NOCOM")
            Me.DT_INDUSTRIAL = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_INDUSTRIAL")
            Me.DT_MONTAJE = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_MONTAJE")
            Me.DT_SQL = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_SQL")
            Me.Folder0 = CType(Me.GetItem("Item_1").Specific, SAPbouiCOM.Folder)
            Me.Folder1 = CType(Me.GetItem("Item_2").Specific, SAPbouiCOM.Folder)
            Me.Folder2 = CType(Me.GetItem("Item_3").Specific, SAPbouiCOM.Folder)
            Me.Folder3 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.Folder)
            Me.Grid0 = CType(Me.GetItem("Item_5").Specific, SAPbouiCOM.Grid)
            Me.Grid1 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.Grid)
            Me.Grid2 = CType(Me.GetItem("Item_7").Specific, SAPbouiCOM.Grid)
            Me.Grid3 = CType(Me.GetItem("Item_8").Specific, SAPbouiCOM.Grid)
            Me.StaticText0 = CType(Me.GetItem("Item_26").Specific, SAPbouiCOM.StaticText)
            Me.StaticText1 = CType(Me.GetItem("Item_27").Specific, SAPbouiCOM.StaticText)
            Me.OnCustomInitialize()

        End Sub

        Public Overrides Sub OnInitializeFormEvents()
            AddHandler ResizeAfter, AddressOf Me.Form_ResizeAfter
        End Sub

        Private Sub Form_ResizeAfter(pVal As SAPbouiCOM.SBOItemEventArg)

            If conta = 0 Then
                conta += 1
                Try
                    Me.UIAPIRawForm.Freeze(True)
                    Call Cargar_Grids_Documentos()
                Catch ex As Exception
                Finally
                    Me.UIAPIRawForm.Freeze(False)
                End Try
            End If

        End Sub

        Private Sub OnCustomInitialize()
        End Sub

        Private Sub Cargar_Grids_Documentos()

            Dim bProgBar As Boolean = True

            'Try
            '    bProgBar = Funciones.Create_ProgressBar(oProgBar, "Generando Mapa de Documentos", 2)
            '    If bProgBar = False Then
            '        Application.SBO_Application.StatusBar.SetText("Generando Mapa de Documentos, Espere un momento ...", SAPbouiCOM.BoMessageTime.bmt_Medium, SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
            '    End If
            'Catch ex As Exception
            'End Try

            Application.SBO_Application.StatusBar.SetText("Cargando Mapa de Relacion de Documentos, Espere un momento ...", SAPbouiCOM.BoMessageTime.bmt_Medium, SAPbouiCOM.BoStatusBarMessageType.smt_Warning)

            Try

                Dim oUDS As SAPbouiCOM.UserDataSource = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_1")
                Dim sCodPrj As String = oUDS.ValueEx
                Dim oCol As SAPbouiCOM.EditTextColumn

                sPSql = "exec [" + sBDComercial.Trim() + "].[dbo].[MIN_GPR_Estado_Ventas_Comercial] '" + sCodPrj.Trim() + "'"

                sPSql2 = "select * from [" + sBDComercial.Trim() + "].[DBO].[@ZHCEP] where U_Tipo_Proc = 'COMER_ING' and U_PrjCode = '" + sCodPrj.Trim() + "'"

                sPSql3 = "exec [" + sBDComercial.Trim() + "].[dbo].[MIN_GPR_Estado_Compras_Comercial] '" + sCodPrj.Trim() + "'"

                sPSql4 = "exec [" + sBDComercial.Trim() + "].[dbo].[MIN_GPR_Estado_PCV_Comercial_Industrial] '" + sCodPrj.Trim() + "'"

                sPSql5 = "exec [" + sBDComercial.Trim() + "].[dbo].[MIN_GPR_Estado_PCV_Comercial_Montaje] '" + sCodPrj.Trim() + "'"


                Try

                    DT_COMER.Clear()
                    DT_COMER.ExecuteQuery(sPSql)

                    If Me.DT_COMER.Rows.Count > 0 Then

                        Me.Grid0.DataTable = DT_COMER

                        'Me.Grid0.CommonSetting.FixedColumnsCount = 4

                        ''==============================================
                        ''// LINKED BUTTON
                        ''==============================================
                        oCol = Me.Grid0.Columns.Item("Oportunidad de Ventas")
                        oCol.LinkedObjectType = "97"
                        oCol = Me.Grid0.Columns.Item("Oferta de Ventas")
                        oCol.LinkedObjectType = "23"
                        oCol = Me.Grid0.Columns.Item("Pedido de Ventas  <*>") '"Pedido de Ventas      Tipo Pedido       % Avance Proyecto     % Avance Pedido"
                        oCol.LinkedObjectType = "17"
                        oCol = Me.Grid0.Columns.Item("Guia de Entrega")
                        oCol.LinkedObjectType = "15"

                        Grid0.Columns.Item("Pedido de Ventas  <*>").TitleObject.Caption = "Pedido de Ventas      Tipo Pedido       % Avance Proyecto     % Avance Pedido"
                        Me.Grid0.CollapseLevel = 3
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
                        oCol = Me.Grid1.Columns.Item("Pedido Compras  <*>") '("Pedido Compras    Fecha Pedido   % Entrad Totales   % Ent. PC")
                        'oCol = Me.Grid1.Columns.Item(1)
                        oCol.LinkedObjectType = "22"
                        oCol = Me.Grid1.Columns.Item("Entrada de Mercaderia")
                        oCol.LinkedObjectType = "20"

                        Grid1.Columns.Item("Pedido Compras  <*>").TitleObject.Caption = "Pedido Compras    Fecha Pedido   % Entrad Totales   % Ent. PC"
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
                        oCol = Me.Grid2.Columns.Item("Pedido Industrial <*>")
                        oCol.LinkedObjectType = "17"
                        'oCol = Me.Grid0.Columns.Item("Orden_Fabricacion")
                        'oCol.LinkedObjectType = "202"
                        oCol = Me.Grid2.Columns.Item(3)
                        oCol.LinkedObjectType = "15"

                        Grid2.Columns.Item("Pedido Industrial <*>").TitleObject.Caption = "Pedido Industrial    Tipo Pedido   Fecha Emision"


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
                        oCol = Me.Grid3.Columns.Item("Pedido Ventas Montaje <*>")
                        oCol.LinkedObjectType = "17"
                        oCol = Me.Grid3.Columns.Item(1)
                        oCol.LinkedObjectType = "23"
                        oCol = Me.Grid3.Columns.Item(3)
                        oCol.LinkedObjectType = "1470000113"
                        oCol = Me.Grid3.Columns.Item(4)
                        oCol.LinkedObjectType = "22"

                        Grid3.Columns.Item("Pedido Ventas Montaje <*>").TitleObject.Caption = "Pedido Ventas Montaje     Tipo_Pedido       Estado_PCV       "
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

                Me.Folder0.Item.Click()

            Catch ex As Exception
            Finally
                Application.SBO_Application.StatusBar.SetText("Datos Cargados", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success)
                'If bProgBar = False Then
                '    Application.SBO_Application.StatusBar.SetText("Datos Cargados", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success)
                'End If
                'bProgBar = Funciones.Increment_ProgressBar(oProgBar, 1)
                'bProgBar = Funciones.Close_ProgressBar(oProgBar)
            End Try



        End Sub

        Private WithEvents StaticText2 As SAPbouiCOM.StaticText
        Private WithEvents EditText0 As SAPbouiCOM.EditText
        Private WithEvents StaticText3 As SAPbouiCOM.StaticText
        Private WithEvents EditText1 As SAPbouiCOM.EditText
        Private WithEvents StaticText4 As SAPbouiCOM.StaticText
        Private WithEvents EditText2 As SAPbouiCOM.EditText
        Private WithEvents StaticText5 As SAPbouiCOM.StaticText
        Private WithEvents EditText3 As SAPbouiCOM.EditText
        Private WithEvents StaticText6 As SAPbouiCOM.StaticText
        Private WithEvents EditText4 As SAPbouiCOM.EditText
        Private WithEvents StaticText7 As SAPbouiCOM.StaticText
        Private WithEvents EditText5 As SAPbouiCOM.EditText
        Private WithEvents StaticText8 As SAPbouiCOM.StaticText
        Private WithEvents EditText6 As SAPbouiCOM.EditText
        Private WithEvents StaticText9 As SAPbouiCOM.StaticText
        Private WithEvents EditText7 As SAPbouiCOM.EditText
        Private WithEvents StaticText10 As SAPbouiCOM.StaticText
        Private WithEvents DT_COMER As SAPbouiCOM.DataTable
        Private WithEvents DT_NOCOM As SAPbouiCOM.DataTable
        Private WithEvents DT_INDUSTRIAL As SAPbouiCOM.DataTable
        Private WithEvents DT_MONTAJE As SAPbouiCOM.DataTable
        Private WithEvents DT_SQL As SAPbouiCOM.DataTable
        Private WithEvents Folder0 As SAPbouiCOM.Folder
        Private WithEvents Folder1 As SAPbouiCOM.Folder
        Private WithEvents Folder2 As SAPbouiCOM.Folder
        Private WithEvents Folder3 As SAPbouiCOM.Folder
        Private WithEvents Grid0 As SAPbouiCOM.Grid
        Private WithEvents Grid1 As SAPbouiCOM.Grid
        Private WithEvents Grid2 As SAPbouiCOM.Grid
        Private WithEvents Grid3 As SAPbouiCOM.Grid
        Private WithEvents StaticText0 As SAPbouiCOM.StaticText
        Private WithEvents StaticText1 As SAPbouiCOM.StaticText


    End Class
End Namespace
