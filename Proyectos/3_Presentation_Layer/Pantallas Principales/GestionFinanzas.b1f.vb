Option Strict Off
Option Explicit On
Imports FuncionalidadesSDKB1
Imports SAPbouiCOM.Framework

Namespace SBOAddonProject1
    <FormAttribute("SBOAddonProject1.GestionFinanzas", "3_Presentation_Layer/Pantallas Principales/GestionFinanzas.b1f")>
    Friend Class GestionFinanzas
        Inherits UserFormBase

        Private WithEvents oForm As SAPbouiCOM.Form

        Public Shared TotDesp As Double
        Public Shared TotFact As Double
        Public Shared TotNDB As Double
        Public Shared TotNCR As Double
        Public Shared TotDev As Double
        Public Shared TotDespOC As Double
        Public Shared TotFactOC As Double
        Public Shared TotNDBOC As Double
        Public Shared TotNCROC As Double
        Public Shared TotDevOC As Double


        Public Sub New()
        End Sub

        Public Overrides Sub OnInitializeComponent()
            Me.Folder0 = CType(Me.GetItem("Item_1").Specific, SAPbouiCOM.Folder)
            Me.EditText0 = CType(Me.GetItem("Item_2").Specific, SAPbouiCOM.EditText)
            Me.StaticText0 = CType(Me.GetItem("Item_3").Specific, SAPbouiCOM.StaticText)
            Me.EditText1 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.EditText)
            Me.StaticText1 = CType(Me.GetItem("Item_5").Specific, SAPbouiCOM.StaticText)
            Me.EditText2 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.EditText)
            Me.StaticText2 = CType(Me.GetItem("Item_7").Specific, SAPbouiCOM.StaticText)
            Me.EditText3 = CType(Me.GetItem("Item_8").Specific, SAPbouiCOM.EditText)
            Me.StaticText3 = CType(Me.GetItem("Item_9").Specific, SAPbouiCOM.StaticText)
            Me.EditText4 = CType(Me.GetItem("Item_10").Specific, SAPbouiCOM.EditText)
            Me.StaticText4 = CType(Me.GetItem("Item_11").Specific, SAPbouiCOM.StaticText)
            Me.EditText5 = CType(Me.GetItem("Item_12").Specific, SAPbouiCOM.EditText)
            Me.StaticText5 = CType(Me.GetItem("Item_13").Specific, SAPbouiCOM.StaticText)
            Me.EditText6 = CType(Me.GetItem("Item_14").Specific, SAPbouiCOM.EditText)
            Me.StaticText6 = CType(Me.GetItem("Item_15").Specific, SAPbouiCOM.StaticText)
            Me.Button0 = CType(Me.GetItem("Item_16").Specific, SAPbouiCOM.Button)
            Me.EditText7 = CType(Me.GetItem("Item_17").Specific, SAPbouiCOM.EditText)
            Me.StaticText7 = CType(Me.GetItem("Item_18").Specific, SAPbouiCOM.StaticText)
            Me.EditText8 = CType(Me.GetItem("Item_19").Specific, SAPbouiCOM.EditText)
            Me.StaticText8 = CType(Me.GetItem("Item_20").Specific, SAPbouiCOM.StaticText)
            Me.LinkedButton0 = CType(Me.GetItem("Item_21").Specific, SAPbouiCOM.LinkedButton)
            Me.PictureBox0 = CType(Me.GetItem("Item_23").Specific, SAPbouiCOM.PictureBox)
            Me.Grid0 = CType(Me.GetItem("Item_24").Specific, SAPbouiCOM.Grid)
            Me.Grid1 = CType(Me.GetItem("Item_25").Specific, SAPbouiCOM.Grid)
            Me.Grid2 = CType(Me.GetItem("Item_26").Specific, SAPbouiCOM.Grid)
            Me.StaticText9 = CType(Me.GetItem("Item_27").Specific, SAPbouiCOM.StaticText)
            Me.StaticText10 = CType(Me.GetItem("Item_28").Specific, SAPbouiCOM.StaticText)
            Me.StaticText11 = CType(Me.GetItem("Item_29").Specific, SAPbouiCOM.StaticText)
            Me.StaticText12 = CType(Me.GetItem("Item_30").Specific, SAPbouiCOM.StaticText)
            Me.Grid3 = CType(Me.GetItem("Item_31").Specific, SAPbouiCOM.Grid)
            Me.StaticText13 = CType(Me.GetItem("Item_32").Specific, SAPbouiCOM.StaticText)
            Me.EditText9 = CType(Me.GetItem("Item_33").Specific, SAPbouiCOM.EditText)
            Me.EditText10 = CType(Me.GetItem("Item_34").Specific, SAPbouiCOM.EditText)
            Me.StaticText14 = CType(Me.GetItem("Item_35").Specific, SAPbouiCOM.StaticText)
            Me.EditText11 = CType(Me.GetItem("Item_36").Specific, SAPbouiCOM.EditText)
            Me.StaticText15 = CType(Me.GetItem("Item_37").Specific, SAPbouiCOM.StaticText)
            Me.EditText12 = CType(Me.GetItem("Item_38").Specific, SAPbouiCOM.EditText)
            Me.StaticText16 = CType(Me.GetItem("Item_39").Specific, SAPbouiCOM.StaticText)
            Me.EditText13 = CType(Me.GetItem("Item_40").Specific, SAPbouiCOM.EditText)
            Me.StaticText17 = CType(Me.GetItem("Item_41").Specific, SAPbouiCOM.StaticText)
            Me.EditText14 = CType(Me.GetItem("Item_22").Specific, SAPbouiCOM.EditText)
            Me.StaticText18 = CType(Me.GetItem("Item_42").Specific, SAPbouiCOM.StaticText)
            Me.EditText15 = CType(Me.GetItem("Item_43").Specific, SAPbouiCOM.EditText)
            Me.StaticText19 = CType(Me.GetItem("Item_44").Specific, SAPbouiCOM.StaticText)
            Me.Grid4 = CType(Me.GetItem("Item_45").Specific, SAPbouiCOM.Grid)
            Me.StaticText20 = CType(Me.GetItem("Item_46").Specific, SAPbouiCOM.StaticText)
            Me.EditText16 = CType(Me.GetItem("Item_47").Specific, SAPbouiCOM.EditText)
            Me.StaticText21 = CType(Me.GetItem("Item_48").Specific, SAPbouiCOM.StaticText)
            Me.Grid5 = CType(Me.GetItem("Item_49").Specific, SAPbouiCOM.Grid)
            Me.StaticText22 = CType(Me.GetItem("Item_50").Specific, SAPbouiCOM.StaticText)
            Me.EditText17 = CType(Me.GetItem("Item_51").Specific, SAPbouiCOM.EditText)
            Me.StaticText23 = CType(Me.GetItem("Item_52").Specific, SAPbouiCOM.StaticText)
            Me.EditText18 = CType(Me.GetItem("Item_53").Specific, SAPbouiCOM.EditText)
            Me.StaticText24 = CType(Me.GetItem("Item_54").Specific, SAPbouiCOM.StaticText)
            Me.StaticText25 = CType(Me.GetItem("Item_55").Specific, SAPbouiCOM.StaticText)
            Me.StaticText26 = CType(Me.GetItem("Item_56").Specific, SAPbouiCOM.StaticText)
            Me.EditText19 = CType(Me.GetItem("Item_57").Specific, SAPbouiCOM.EditText)
            Me.StaticText27 = CType(Me.GetItem("Item_58").Specific, SAPbouiCOM.StaticText)
            Me.EditText20 = CType(Me.GetItem("Item_59").Specific, SAPbouiCOM.EditText)
            Me.EditText21 = CType(Me.GetItem("Item_60").Specific, SAPbouiCOM.EditText)
            Me.StaticText28 = CType(Me.GetItem("Item_63").Specific, SAPbouiCOM.StaticText)
            Me.StaticText29 = CType(Me.GetItem("Item_64").Specific, SAPbouiCOM.StaticText)
            Me.StaticText30 = CType(Me.GetItem("Item_65").Specific, SAPbouiCOM.StaticText)
            Me.EditText22 = CType(Me.GetItem("Item_66").Specific, SAPbouiCOM.EditText)
            Me.StaticText31 = CType(Me.GetItem("Item_67").Specific, SAPbouiCOM.StaticText)
            Me.EditText23 = CType(Me.GetItem("Item_68").Specific, SAPbouiCOM.EditText)
            Me.ComboBox2 = CType(Me.GetItem("Item_71").Specific, SAPbouiCOM.ComboBox)
            Me.ComboBox3 = CType(Me.GetItem("Item_72").Specific, SAPbouiCOM.ComboBox)
            Me.DT_SQL1 = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_SQL1")
            Me.DT_SQL2 = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_SQL1")
            Me.Button1 = CType(Me.GetItem("Item_73").Specific, SAPbouiCOM.Button)
            Me.Folder1 = CType(Me.GetItem("Item_61").Specific, SAPbouiCOM.Folder)
            Me.Grid6 = CType(Me.GetItem("Item_70").Specific, SAPbouiCOM.Grid)
            Me.Folder3 = CType(Me.GetItem("Item_74").Specific, SAPbouiCOM.Folder)
            Me.Grid7 = CType(Me.GetItem("Item_75").Specific, SAPbouiCOM.Grid)
            Me.Folder4 = CType(Me.GetItem("Item_76").Specific, SAPbouiCOM.Folder)
            Me.Grid8 = CType(Me.GetItem("Item_77").Specific, SAPbouiCOM.Grid)
            Me.Grid9 = CType(Me.GetItem("Item_78").Specific, SAPbouiCOM.Grid)
            Me.Grid10 = CType(Me.GetItem("Item_79").Specific, SAPbouiCOM.Grid)
            Me.StaticText33 = CType(Me.GetItem("Item_81").Specific, SAPbouiCOM.StaticText)
            Me.StaticText34 = CType(Me.GetItem("Item_82").Specific, SAPbouiCOM.StaticText)
            Me.StaticText35 = CType(Me.GetItem("Item_83").Specific, SAPbouiCOM.StaticText)
            Me.Grid11 = CType(Me.GetItem("Item_84").Specific, SAPbouiCOM.Grid)
            Me.StaticText36 = CType(Me.GetItem("Item_85").Specific, SAPbouiCOM.StaticText)
            Me.EditText25 = CType(Me.GetItem("Item_87").Specific, SAPbouiCOM.EditText)
            Me.StaticText37 = CType(Me.GetItem("Item_88").Specific, SAPbouiCOM.StaticText)
            Me.EditText26 = CType(Me.GetItem("Item_89").Specific, SAPbouiCOM.EditText)
            Me.StaticText38 = CType(Me.GetItem("Item_90").Specific, SAPbouiCOM.StaticText)
            Me.EditText27 = CType(Me.GetItem("Item_91").Specific, SAPbouiCOM.EditText)
            Me.StaticText39 = CType(Me.GetItem("Item_92").Specific, SAPbouiCOM.StaticText)
            Me.EditText28 = CType(Me.GetItem("Item_93").Specific, SAPbouiCOM.EditText)
            Me.StaticText40 = CType(Me.GetItem("Item_94").Specific, SAPbouiCOM.StaticText)
            Me.Grid12 = CType(Me.GetItem("Item_95").Specific, SAPbouiCOM.Grid)
            Me.StaticText41 = CType(Me.GetItem("Item_96").Specific, SAPbouiCOM.StaticText)
            Me.EditText29 = CType(Me.GetItem("Item_97").Specific, SAPbouiCOM.EditText)
            Me.StaticText42 = CType(Me.GetItem("Item_98").Specific, SAPbouiCOM.StaticText)
            Me.Grid13 = CType(Me.GetItem("Item_99").Specific, SAPbouiCOM.Grid)
            Me.StaticText43 = CType(Me.GetItem("Item_100").Specific, SAPbouiCOM.StaticText)
            Me.EditText30 = CType(Me.GetItem("Item_101").Specific, SAPbouiCOM.EditText)
            Me.StaticText44 = CType(Me.GetItem("Item_102").Specific, SAPbouiCOM.StaticText)
            Me.StaticText53 = CType(Me.GetItem("Item_119").Specific, SAPbouiCOM.StaticText)
            Me.EditText37 = CType(Me.GetItem("Item_120").Specific, SAPbouiCOM.EditText)
            Me.StaticText54 = CType(Me.GetItem("Item_122").Specific, SAPbouiCOM.StaticText)
            Me.Grid14 = CType(Me.GetItem("Item_123").Specific, SAPbouiCOM.Grid)
            Me.Button2 = CType(Me.GetItem("Item_124").Specific, SAPbouiCOM.Button)
            Me.Folder5 = CType(Me.GetItem("Item_125").Specific, SAPbouiCOM.Folder)
            Me.ComboBox4 = CType(Me.GetItem("Item_126").Specific, SAPbouiCOM.ComboBox)
            Me.StaticText55 = CType(Me.GetItem("Item_127").Specific, SAPbouiCOM.StaticText)
            Me.Grid15 = CType(Me.GetItem("Item_128").Specific, SAPbouiCOM.Grid)
            Me.Grid16 = CType(Me.GetItem("Item_62").Specific, SAPbouiCOM.Grid)
            Me.StaticText32 = CType(Me.GetItem("Item_69").Specific, SAPbouiCOM.StaticText)
            Me.EditText24 = CType(Me.GetItem("Item_80").Specific, SAPbouiCOM.EditText)
            Me.StaticText45 = CType(Me.GetItem("Item_86").Specific, SAPbouiCOM.StaticText)
            Me.Grid17 = CType(Me.GetItem("Item_103").Specific, SAPbouiCOM.Grid)
            Me.StaticText46 = CType(Me.GetItem("Item_104").Specific, SAPbouiCOM.StaticText)
            Me.EditText31 = CType(Me.GetItem("Item_105").Specific, SAPbouiCOM.EditText)
            Me.StaticText47 = CType(Me.GetItem("Item_106").Specific, SAPbouiCOM.StaticText)
            Me.Button3 = CType(Me.GetItem("Item_107").Specific, SAPbouiCOM.Button)
            Me.Button4 = CType(Me.GetItem("Item_108").Specific, SAPbouiCOM.Button)
            Me.EditText32 = CType(Me.GetItem("Item_109").Specific, SAPbouiCOM.EditText)
            Me.StaticText48 = CType(Me.GetItem("Item_110").Specific, SAPbouiCOM.StaticText)
            Me.EditText33 = CType(Me.GetItem("Item_111").Specific, SAPbouiCOM.EditText)
            Me.StaticText49 = CType(Me.GetItem("Item_112").Specific, SAPbouiCOM.StaticText)
            Me.EditText34 = CType(Me.GetItem("Item_113").Specific, SAPbouiCOM.EditText)
            Me.StaticText50 = CType(Me.GetItem("Item_114").Specific, SAPbouiCOM.StaticText)
            Me.EditText35 = CType(Me.GetItem("Item_115").Specific, SAPbouiCOM.EditText)
            Me.StaticText51 = CType(Me.GetItem("Item_116").Specific, SAPbouiCOM.StaticText)
            Me.EditText36 = CType(Me.GetItem("Item_117").Specific, SAPbouiCOM.EditText)
            Me.StaticText52 = CType(Me.GetItem("Item_118").Specific, SAPbouiCOM.StaticText)
            Me.EditText38 = CType(Me.GetItem("Item_121").Specific, SAPbouiCOM.EditText)
            Me.StaticText56 = CType(Me.GetItem("Item_129").Specific, SAPbouiCOM.StaticText)
            Me.EditText39 = CType(Me.GetItem("Item_130").Specific, SAPbouiCOM.EditText)
            Me.StaticText57 = CType(Me.GetItem("Item_131").Specific, SAPbouiCOM.StaticText)
            Me.EditText40 = CType(Me.GetItem("Item_132").Specific, SAPbouiCOM.EditText)
            Me.StaticText58 = CType(Me.GetItem("Item_133").Specific, SAPbouiCOM.StaticText)
            Me.StaticText59 = CType(Me.GetItem("Item_134").Specific, SAPbouiCOM.StaticText)
            Me.ComboBox0 = CType(Me.GetItem("Item_135").Specific, SAPbouiCOM.ComboBox)
            Me.StaticText60 = CType(Me.GetItem("Item_136").Specific, SAPbouiCOM.StaticText)
            Me.ComboBox1 = CType(Me.GetItem("Item_137").Specific, SAPbouiCOM.ComboBox)
            Me.OnCustomInitialize()

        End Sub

        Public Overrides Sub OnInitializeFormEvents()
            AddHandler ResizeAfter, AddressOf Me.Form_ResizeAfter

        End Sub

        Private WithEvents Folder0 As SAPbouiCOM.Folder

        Private Sub OnCustomInitialize()

            oForm = Application.SBO_Application.Forms.Item(Me.UIAPIRawForm.UniqueID)
            Me.UIAPIRawForm.EnableMenu(1281, True)  'Buscar
            Me.UIAPIRawForm.EnableMenu(1282, False) 'Crear

            Cargar_Combo_CondicionesPagos()
            ComboBox0.Select(0, SAPbouiCOM.BoSearchKey.psk_Index)
            Cargar_Grid_Proyectos_Anticipos()
            ComboBox1.Select(0, SAPbouiCOM.BoSearchKey.psk_Index)
            Cargar_Grid_Proyectos_Despachados()

            oForm.Items.Item("Item_1").Click()

        End Sub

        Private Sub Button0_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button0.ClickAfter
            Dim activeForm2 As Form2
            activeForm2 = New Form2

            Dim oUDS As SAPbouiCOM.UserDataSource = activeForm2.UIAPIRawForm.DataSources.UserDataSources.Item("UD_0")
            oUDS.ValueEx = Me.UIAPIRawForm.UniqueID
            oUDS = activeForm2.UIAPIRawForm.DataSources.UserDataSources.Item("UD_1")
            oUDS.ValueEx = "FINANZAS"

            activeForm2.Show()
        End Sub

        Private Sub Button1_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button1.ClickAfter
            '----------------------------------------------------------------------------------------------------------------------------------------------------------
            'Abre la Pantalla de Estado Comercial e Ingenieria, envia los Querys para hacer la consulta y mostrar los datos en el Grid al cargar el Form
            '----------------------------------------------------------------------------------------------------------------------------------------------------------
            Try

                If Me.EditText0.Value.Trim.Length() > 0 Then
                    Try
                        Dim Formp4 As New FormMapaD()
                        Dim oFormD As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(Formp4.UIAPIRawForm.UniqueID)

                        Dim oUDS As SAPbouiCOM.UserDataSource = oFormD.DataSources.UserDataSources.Item("UD_0")
                        oUDS.ValueEx = pVal.FormUID   'Aca asignamos el FormUID de Formulario al Valor del  User Data Source

                        Dim oUDS2 As SAPbouiCOM.UserDataSource = oFormD.DataSources.UserDataSources.Item("UD_1")
                        oUDS2.ValueEx = Me.EditText0.Value.Trim()   'Aca asignamos el Codigo del Proyecto al User Data Source

                        Dim txt As SAPbouiCOM.EditText = oFormD.Items.Item("Item_10").Specific
                        txt.Value = EditText0.Value.ToString()
                        txt = oFormD.Items.Item("Item_12").Specific
                        txt.Value = EditText1.Value.ToString()
                        txt = oFormD.Items.Item("Item_14").Specific
                        txt.Value = EditText2.Value.ToString()
                        txt = oFormD.Items.Item("Item_16").Specific
                        txt.Value = EditText3.Value.ToString()
                        txt = oFormD.Items.Item("Item_18").Specific
                        txt.Value = EditText4.Value.ToString()
                        txt = oFormD.Items.Item("Item_20").Specific
                        txt.Value = EditText5.Value.ToString()
                        txt = oFormD.Items.Item("Item_22").Specific
                        txt.Value = EditText6.Value.ToString()
                        txt = oFormD.Items.Item("Item_24").Specific
                        txt.Value = EditText7.Value.ToString()

                        Formp4.Show()
                        oFormD.Select()

                    Catch ex As Exception
                        Application.SBO_Application.StatusBar.SetText(ex.Message)
                    Finally
                    End Try
                Else
                    Application.SBO_Application.MessageBox("Debe Seleccionar un Proyecto", 1)
                End If

            Catch ex As Exception

            End Try

        End Sub

        Private Sub Button2_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button2.ClickAfter
            If (EditText0.Value.Trim().Length() > 0) Then
                Try
                    Dim bProgBar As Boolean = True

                    Try
                        bProgBar = Funciones.Create_ProgressBar(oProgBar, "Abriendo Estado de Proyectos", 2)
                    Catch ex As Exception
                    End Try

                    Dim EstadoGlobal As FrmEstado_Global
                    EstadoGlobal = New FrmEstado_Global

                    Try

                        Dim sCodigo = EditText0.Value.Trim()

                        Dim oFormP As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(EstadoGlobal.UIAPIRawForm.UniqueID)
                        oDTSQL = oFormP.DataSources.DataTables.Item("DT_SQL1")
                        oDTSQL2 = oFormP.DataSources.DataTables.Item("DT_SQL2")

                        FrmEstado_Global.Cargar_Campos_Estado_Global(oFormP.UniqueID, sCodigo, oDTSQL, oDTSQL2)
                        'Cargar_Campos_Form_Principal(pVal)
                        'Application.SBO_Application.Forms.Item(pVal.FormUID).Close()
                    Catch
                    End Try


                    Try
                        bProgBar = Funciones.Increment_ProgressBar(oProgBar, 1)
                        bProgBar = Funciones.Close_ProgressBar(oProgBar)
                    Catch ex As Exception
                    End Try

                    EstadoGlobal.Show()
                Catch ex As Exception
                End Try
            Else
                Application.SBO_Application.MessageBox("Debe Seleccionar un Proyecto", 1)
            End If

        End Sub

        Private Sub Button3_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button3.ClickAfter

            If (EditText0.Value.Trim().Length() > 0) Then
                Dim activeForm2 As FrmListaDocumentos
                activeForm2 = New FrmListaDocumentos

                Dim oUDS As SAPbouiCOM.UserDataSource = activeForm2.UIAPIRawForm.DataSources.UserDataSources.Item("UD_0")
                oUDS.ValueEx = EditText0.Value.Trim()
                oUDS = activeForm2.UIAPIRawForm.DataSources.UserDataSources.Item("UD_1")
                oUDS.ValueEx = "PR"

                activeForm2.Show()
            Else
                Application.SBO_Application.MessageBox("Debe Seleccionar un Proyecto", 1)
            End If

        End Sub

        Private Sub Button4_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button4.ClickAfter

            If (EditText0.Value.Trim().Length() > 0) Then
                Dim activeForm2 As FrmListaDocumentos
                activeForm2 = New FrmListaDocumentos

                Dim oUDS As SAPbouiCOM.UserDataSource = activeForm2.UIAPIRawForm.DataSources.UserDataSources.Item("UD_0")
                oUDS.ValueEx = EditText0.Value.Trim()
                oUDS = activeForm2.UIAPIRawForm.DataSources.UserDataSources.Item("UD_1")
                oUDS.ValueEx = "OC"

                activeForm2.Show()
            Else
                Application.SBO_Application.MessageBox("Debe Seleccionar un Proyecto", 1)
            End If

        End Sub

        Private Sub Grid_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid0.ClickAfter, Grid1.ClickAfter, Grid2.ClickAfter, Grid3.ClickAfter, Grid4.ClickAfter, Grid5.ClickAfter, Grid6.ClickAfter, Grid7.ClickAfter, Grid8.ClickAfter, Grid9.ClickAfter, Grid10.ClickAfter, Grid11.ClickAfter, Grid12.ClickAfter, Grid13.ClickAfter, Grid15.ClickAfter, Grid16.ClickAfter, Grid17.ClickAfter
            Try
                oGrid = CType(sboObject, SAPbouiCOM.Grid)
                oGrid.Rows.SelectedRows.Add(pVal.Row)
            Catch ex As Exception
            End Try

        End Sub

        Private Sub Grid14_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid14.ClickAfter
            Try
                If (Grid14.Columns.Item(pVal.ColUID).TitleObject.Caption <> "Total") Then
                    oUDataTable = oForm.DataSources.DataTables.Item("DT_TOTOC2")
                    EditText37.String = oUDataTable.GetValue(pVal.ColUID, 1).ToString()
                End If

            Catch ex As Exception

            End Try
        End Sub

        Private Sub Grid6_DoubleClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid6.DoubleClickAfter
            Try
                oGrid = oForm.Items.Item("Item_70").Specific
                oUDataTable = oForm.DataSources.DataTables.Item("DT_SQLX")
                Dim sProy As String = oGrid.DataTable.GetValue(0, oGrid.GetDataTableRowIndex(pVal.Row))
                Cargar_Campos_Estado_Global(oForm.UniqueID, sProy, oUDataTable)
                Cargar_Grids_OC(oForm.UniqueID, sProy)
            Catch ex As Exception
            End Try
        End Sub

        Private Sub Grid6_LinkPressedAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid6.LinkPressedAfter
            Try
                oGrid = oForm.Items.Item("Item_70").Specific
                oUDataTable = oForm.DataSources.DataTables.Item("DT_SQLX")
                Dim sProy As String = oGrid.DataTable.GetValue(0, oGrid.GetDataTableRowIndex(pVal.Row))
                Cargar_Campos_Estado_Global(oForm.UniqueID, sProy, oUDataTable)
                Cargar_Grids_OC(oForm.UniqueID, sProy)
            Catch ex As Exception
            End Try
        End Sub

        Private Sub Grid7_DoubleClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid7.DoubleClickAfter
            Try
                oGrid = oForm.Items.Item("Item_75").Specific
                oUDataTable = oForm.DataSources.DataTables.Item("DT_SQL2")
                Dim sProy As String = oGrid.DataTable.GetValue(0, oGrid.GetDataTableRowIndex(pVal.Row))
                Cargar_Campos_Estado_Global(oForm.UniqueID, sProy, oUDataTable)
                Cargar_Grids_OC(oForm.UniqueID, sProy)
            Catch ex As Exception
            End Try
        End Sub

        Private Sub GridOC_DoubleClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid8.DoubleClickAfter, Grid9.DoubleClickAfter, Grid10.DoubleClickAfter, Grid11.DoubleClickAfter, Grid12.DoubleClickAfter, Grid13.DoubleClickAfter, Grid14.DoubleClickAfter, Grid17.DoubleClickAfter
            Try
                oGrid = CType(sboObject, SAPbouiCOM.Grid)
                oUDataTable = oForm.DataSources.DataTables.Item("DT_SQLX")
                Dim sProy As String = If(oGrid.Item.UniqueID = "Item_123", oGrid.Columns.Item(pVal.ColUID).TitleObject.Caption, oGrid.DataTable.GetValue(0, oGrid.GetDataTableRowIndex(pVal.Row)))
                If sProy <> "Total" Then
                    Cargar_Campos_Estado_Global(oForm.UniqueID, sProy, oUDataTable)
                End If

            Catch ex As Exception
            End Try

        End Sub

        Private Sub Grid15_DoubleClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid15.DoubleClickAfter
            Try
                oGrid = oForm.Items.Item("Item_128").Specific
                oUDataTable = oForm.DataSources.DataTables.Item("DT_SQLX")
                Dim sProy As String = oGrid.DataTable.GetValue(0, oGrid.GetDataTableRowIndex(pVal.Row))
                Cargar_Campos_Estado_Global(oForm.UniqueID, sProy, oUDataTable)
                Cargar_Grids_OC(oForm.UniqueID, sProy)
            Catch ex As Exception
            End Try
        End Sub

        Private Sub Form_ResizeAfter(pVal As SAPbouiCOM.SBOItemEventArg)

            Dim dWidth As Decimal = oForm.Items.Item("Item_0").Width * (13.18 / 100)

            Grid0.Item.Width = dWidth
            Grid1.Item.Left = Grid0.Item.Left + dWidth + 12
            Grid1.Item.Width = dWidth
            Grid2.Item.Left = Grid1.Item.Left + dWidth + 12
            Grid2.Item.Width = dWidth
            Grid4.Item.Left = Grid2.Item.Left + dWidth + 12
            Grid4.Item.Width = dWidth
            Grid5.Item.Left = Grid4.Item.Left + dWidth + 12
            Grid5.Item.Width = dWidth
            Grid3.Item.Left = Grid5.Item.Left + dWidth + 12
            Grid3.Item.Width = dWidth
            Grid16.Item.Left = Grid3.Item.Left + dWidth + 12
            Grid16.Item.Width = dWidth

            Grid8.Item.Width = dWidth
            Grid9.Item.Left = Grid8.Item.Left + dWidth + 12
            Grid9.Item.Width = dWidth
            Grid10.Item.Left = Grid9.Item.Left + dWidth + 12
            Grid10.Item.Width = dWidth
            Grid12.Item.Left = Grid10.Item.Left + dWidth + 12
            Grid12.Item.Width = dWidth
            Grid13.Item.Left = Grid12.Item.Left + dWidth + 12
            Grid13.Item.Width = dWidth
            Grid11.Item.Left = Grid13.Item.Left + dWidth + 12
            Grid11.Item.Width = dWidth
            Grid17.Item.Left = Grid11.Item.Left + dWidth + 12
            Grid17.Item.Width = dWidth

            Grid14.Item.Height = 38

            StaticText10.Item.Left = Grid0.Item.Left
            StaticText11.Item.Left = Grid1.Item.Left
            StaticText12.Item.Left = Grid2.Item.Left
            StaticText13.Item.Left = Grid3.Item.Left
            StaticText20.Item.Left = Grid4.Item.Left
            StaticText22.Item.Left = Grid5.Item.Left
            StaticText32.Item.Left = Grid16.Item.Left
            StaticText48.Item.Left = Grid1.Item.Left
            StaticText49.Item.Left = Grid2.Item.Left
            StaticText50.Item.Left = Grid3.Item.Left
            StaticText58.Item.Left = Grid1.Item.Left

            StaticText33.Item.Left = Grid8.Item.Left
            StaticText34.Item.Left = Grid9.Item.Left
            StaticText35.Item.Left = Grid10.Item.Left
            StaticText41.Item.Left = Grid12.Item.Left
            StaticText43.Item.Left = Grid13.Item.Left
            StaticText36.Item.Left = Grid11.Item.Left
            StaticText46.Item.Left = Grid17.Item.Left

            StaticText14.Item.Left = Grid0.Item.Left
            StaticText15.Item.Left = Grid1.Item.Left
            StaticText16.Item.Left = Grid2.Item.Left
            StaticText17.Item.Left = Grid3.Item.Left
            StaticText21.Item.Left = Grid4.Item.Left
            StaticText23.Item.Left = Grid5.Item.Left
            StaticText45.Item.Left = Grid16.Item.Left

            StaticText37.Item.Left = Grid8.Item.Left
            StaticText38.Item.Left = Grid9.Item.Left
            StaticText39.Item.Left = Grid10.Item.Left
            StaticText42.Item.Left = Grid12.Item.Left
            StaticText44.Item.Left = Grid13.Item.Left
            StaticText40.Item.Left = Grid11.Item.Left
            StaticText47.Item.Left = Grid17.Item.Left
            StaticText51.Item.Left = Grid9.Item.Left
            StaticText52.Item.Left = Grid10.Item.Left
            StaticText56.Item.Left = Grid11.Item.Left
            StaticText57.Item.Left = Grid9.Item.Left

            EditText10.Item.Left = Grid0.Item.Left + Grid0.Item.Width - EditText10.Item.Width
            EditText11.Item.Left = Grid1.Item.Left + Grid1.Item.Width - EditText11.Item.Width
            EditText12.Item.Left = Grid2.Item.Left + Grid2.Item.Width - EditText12.Item.Width
            EditText13.Item.Left = Grid3.Item.Left + Grid3.Item.Width - EditText13.Item.Width
            EditText16.Item.Left = Grid4.Item.Left + Grid4.Item.Width - EditText16.Item.Width
            EditText17.Item.Left = Grid5.Item.Left + Grid5.Item.Width - EditText17.Item.Width
            EditText24.Item.Left = Grid16.Item.Left + Grid16.Item.Width - EditText24.Item.Width
            EditText32.Item.Left = Grid1.Item.Left + Grid1.Item.Width - EditText32.Item.Width
            EditText33.Item.Left = Grid2.Item.Left + Grid2.Item.Width - EditText33.Item.Width
            EditText34.Item.Left = Grid3.Item.Left + Grid3.Item.Width - EditText34.Item.Width
            EditText40.Item.Left = Grid1.Item.Left + Grid1.Item.Width - EditText40.Item.Width

            EditText25.Item.Left = Grid8.Item.Left + Grid8.Item.Width - EditText25.Item.Width
            EditText26.Item.Left = Grid9.Item.Left + Grid9.Item.Width - EditText26.Item.Width
            EditText27.Item.Left = Grid10.Item.Left + Grid10.Item.Width - EditText27.Item.Width
            EditText29.Item.Left = Grid12.Item.Left + Grid12.Item.Width - EditText29.Item.Width
            EditText30.Item.Left = Grid13.Item.Left + Grid13.Item.Width - EditText30.Item.Width
            EditText28.Item.Left = Grid11.Item.Left + Grid11.Item.Width - EditText28.Item.Width
            EditText31.Item.Left = Grid17.Item.Left + Grid17.Item.Width - EditText31.Item.Width
            EditText35.Item.Left = Grid9.Item.Left + Grid9.Item.Width - EditText35.Item.Width
            EditText36.Item.Left = Grid10.Item.Left + Grid10.Item.Width - EditText36.Item.Width
            EditText38.Item.Left = Grid11.Item.Left + Grid11.Item.Width - EditText38.Item.Width
            EditText39.Item.Left = Grid9.Item.Left + Grid9.Item.Width - EditText39.Item.Width

            Try
                Grid0.AutoResizeColumns()
                Grid1.AutoResizeColumns()
                Grid2.AutoResizeColumns()
                Grid4.AutoResizeColumns()
                Grid5.AutoResizeColumns()
                Grid3.AutoResizeColumns()
                Grid16.AutoResizeColumns()

                Grid8.AutoResizeColumns()
                Grid9.AutoResizeColumns()
                Grid10.AutoResizeColumns()
                Grid12.AutoResizeColumns()
                Grid13.AutoResizeColumns()
                Grid11.AutoResizeColumns()
                Grid14.AutoResizeColumns()
                Grid17.AutoResizeColumns()

            Catch ex As Exception
            End Try


        End Sub

        Private Sub ComboBox0_ComboSelectAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles ComboBox0.ComboSelectAfter
            Cargar_Grid_Proyectos_Anticipos()
        End Sub

        Private Sub ComboBox1_ComboSelectAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles ComboBox1.ComboSelectAfter
            Cargar_Grid_Proyectos_Despachados()
        End Sub

        Private Sub ComboBox4_ComboSelectAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles ComboBox4.ComboSelectAfter

            Dim oFormP As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(pVal.FormUID)

            Select Case ComboBox4.Selected.Value
                Case 1
                    Cargar_Grid_Resumen_Gestion_Finanzas(oFormP)
                Case 2
                    Cargar_Grid_PCV_Servicios_Facturas(oFormP)
                Case 3

            End Select

        End Sub

        Private Sub Cargar_Grid_Resumen_Gestion_Finanzas(oFormP As SAPbouiCOM.Form)

            Try

                Application.SBO_Application.StatusBar.SetText("Consultando Datos, Espere un momento ...", SAPbouiCOM.BoMessageTime.bmt_Medium, SAPbouiCOM.BoStatusBarMessageType.smt_Warning)

                oFormP.Freeze(True)

                Dim sql As String

                sql = "EXEC	" + sBDComercial.Trim() + ".[dbo].[Min_GPR_Consultar_Resumen_Gestion_Finanzas_OC]"

                Try
                    oUDataTable = oFormP.DataSources.DataTables.Item("DT_OTROS")
                    oUDataTable.ExecuteQuery(sql)

                Catch ex As Exception
                    Application.SBO_Application.MessageBox(sql)
                    Application.SBO_Application.MessageBox(ex.Message)
                End Try

                oGrid = oForm.Items.Item("Item_128").Specific
                'oGrid.RowHeaders.Width = 0

                Dim Col_Justif = {0, 1, 2}

                For index = 0 To oGrid.DataTable.Columns.Count - 1
                    oGrid.Columns.Item(index).Editable = False
                    oGrid.Columns.Item(index).TitleObject.Sortable = True
                    oGrid.Columns.Item(index).BackColor = RGB(255, 255, 255) 'Blanco
                    If Col_Justif.Contains(index) Then
                        oGrid.Columns.Item(index).RightJustified = False
                    Else
                        oGrid.Columns.Item(index).RightJustified = True
                    End If
                Next

                oFunciones.Numero_Fila_Grid(oGrid)

                oGrid.AutoResizeColumns()
            Catch ex As Exception
            Finally
                oFormP.Freeze(False)
                Application.SBO_Application.StatusBar.SetText("Datos Cargados", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success)

            End Try

        End Sub

        Private Sub Cargar_Grid_PCV_Servicios_Facturas(oFormP As SAPbouiCOM.Form)

            Try
                oFormP.Freeze(True)

                Dim sql As String

                sql = "EXEC	" + sBDComercial.Trim() + ".[dbo].[Min_GPR_Consultar_Proyectos_Solo_Servicios_Factura_Gestion_Finanzas]"

                Try
                    oUDataTable = oFormP.DataSources.DataTables.Item("DT_OTROS")
                    oUDataTable.ExecuteQuery(sql)

                Catch ex As Exception
                    Application.SBO_Application.MessageBox(sql)
                    Application.SBO_Application.MessageBox(ex.Message)
                End Try

                oGrid = oForm.Items.Item("Item_128").Specific
                'oGrid.RowHeaders.Width = 0

                Dim Col_Justif = {5, 7, 8, 9, 10, 11}

                oEditCol = oGrid.Columns.Item(6)
                oEditCol.LinkedObjectType = 17

                For index = 0 To oGrid.DataTable.Columns.Count - 1
                    oGrid.Columns.Item(index).Editable = False
                    oGrid.Columns.Item(index).TitleObject.Sortable = True
                    oGrid.Columns.Item(index).BackColor = RGB(255, 255, 255) 'Blanco
                    If Col_Justif.Contains(index) Then
                        oGrid.Columns.Item(index).RightJustified = True
                    End If
                Next

                oFunciones.Numero_Fila_Grid(oGrid)

                oGrid.AutoResizeColumns()
            Catch ex As Exception
            Finally
                oFormP.Freeze(False)
            End Try

        End Sub

        Public Shared Sub Cargar_Campos_Estado_Global(FormID As String, sCodiP As String, DT_SQLX As SAPbouiCOM.DataTable)

            Dim oFormP As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(FormID)

            Dim txt As SAPbouiCOM.EditText

            'Variables para el calculo de Dias
            Dim dFecVenta As Date
            Dim dFecEntreg As Date
            Dim dFecFinDes As Date
            Dim dFecFinPro As Date
            Dim dFecIniDes As Date
            Dim dFecIniMon As Date
            Dim dFecFinMon As Date

            'Variables DEspacho y Montaje
            Dim sConDespacho = "0"
            Dim sConMontaje = "0"

            'Enviar demas Datos a Form Principal
            '---------------------------------------------------------------------------------------------------------------------------
            'Busqueda de Datos en la Tabla ZINFOP o si no existe, en la PCV
            '---------------------------------------------------------------------------------------------------------------------------
            Dim sql As String

            sql = "EXEC	" + sBDComercial.Trim() + ".[dbo].[Min_GPR_Consultar_Datos_Proyecto_GLOBAL]	@sCodPro = '" + sCodiP.Trim() + "'"

            Try

                Application.SBO_Application.StatusBar.SetText("Cargando Datos del Proyecto, Espere un momento ...", SAPbouiCOM.BoMessageTime.bmt_Medium, SAPbouiCOM.BoStatusBarMessageType.smt_Warning)

                Try
                    DT_SQLX.ExecuteQuery(sql)
                    oUDataTable = oFormP.DataSources.DataTables.Item("DT_INFO")
                    oUDataTable.ExecuteQuery(sql)

                Catch ex As Exception
                    oConectarAplicacion.Conectar_Aplicacion(oCompany)
                    DT_SQLX.ExecuteQuery(sql)
                    oUDataTable = oFormP.DataSources.DataTables.Item("DT_INFO")
                    oUDataTable.ExecuteQuery(sql)
                End Try

                sConDespacho = DT_SQLX.GetValue("U_Con_Despacho", 0)
                sConMontaje = DT_SQLX.GetValue("U_Con_Montaje", 0)

                Try
                    oFormP.Freeze(True) ' Se congelar el formulario para comenzar la actualizacion de los campos

                    If DT_SQLX.IsEmpty = False Then

                        txt = oFormP.Items.Item("Item_2").Specific
                        txt.Value = DT_SQLX.GetValue("Project", 0)
                        txt = oFormP.Items.Item("Item_19").Specific
                        txt.Value = DT_SQLX.GetValue("CardCode", 0)
                        txt = oFormP.Items.Item("Item_4").Specific
                        txt.Value = DT_SQLX.GetValue("CardName", 0)
                        txt = oFormP.Items.Item("Item_6").Specific
                        txt.Value = DT_SQLX.GetValue("PrjName", 0)
                        txt = oFormP.Items.Item("Item_8").Specific
                        txt.Value = DT_SQLX.GetValue("Multa", 0)
                        oPicture = oFormP.Items.Item("Item_23").Specific
                        If DT_SQLX.GetValue("Multa", 0) = "Si" Then
                            oPicture.Picture = sPathAnexos + "images\Rojo.png"
                        Else
                            oPicture.Picture = sPathAnexos + "images\Verde.png"
                        End If
                        'Option Button Desarrollo
                        txt = oFormP.Items.Item("Item_22").Specific
                        txt.Value = DT_SQLX.GetValue("U_Nro_OC_Cliente", 0)
                        'Option Button Desarrollo
                        txt = oFormP.Items.Item("Item_43").Specific
                        txt.Value = DT_SQLX.GetValue("U_Contrato_Cli", 0)
                        'Monto OC Cliente
                        oFormP.DataSources.UserDataSources.Item("MontoOCC").ValueEx = DT_SQLX.GetValue("U_Monto_OCC", 0)
                        oFormP.DataSources.UserDataSources.Item("MontoOCC2").ValueEx = DT_SQLX.GetValue("U_Monto_OCC", 0)
                        'Monto Proyecto
                        oFormP.DataSources.UserDataSources.Item("MontoOCCE").ValueEx = IIf(DT_SQLX.GetValue("U_Tipo_Pryecto", 0).ToString.Trim = "U", DT_SQLX.GetValue("U_Monto_OCC", 0), DT_SQLX.GetValue("U_Monto_OCCE", 0))

                        'COntrato COnstruccion
                        txt = oFormP.Items.Item("Item_60").Specific
                        txt.Value = IIf(DT_SQLX.GetValue("U_Contrato_Constru", 0).ToString.Trim = "Y", "Si", "No")
                        'Tipo de Proyecto
                        txt = oFormP.Items.Item("Item_59").Specific
                        txt.Value = IIf(DT_SQLX.GetValue("U_Tipo_Pryecto", 0).ToString.Trim = "U", "Unico", "OC mas de un Proyecto")
                        'Proyecto Inicial
                        txt = oFormP.Items.Item("Item_57").Specific
                        txt.Value = IIf(DT_SQLX.GetValue("U_Tipo_Pryecto", 0).ToString.Trim = "U", DT_SQLX.GetValue("Project", 0), DT_SQLX.GetValue("U_Prj_Code_Ini", 0))
                        'Condiciones de Pago
                        oComboBox = oFormP.Items.Item("Item_71").Specific
                        oComboBox.Select(DT_SQLX.GetValue("U_Condicion_Pago", 0), SAPbouiCOM.BoSearchKey.psk_ByDescription)
                        'Medio de Pago
                        oComboBox = oFormP.Items.Item("Item_72").Specific
                        oComboBox.Select(DT_SQLX.GetValue("U_Medio_Pago", 0), SAPbouiCOM.BoSearchKey.psk_ByDescription)
                        'Porcentaje Anticipo
                        oFormP.DataSources.UserDataSources.Item("UDPORC").ValueEx = DT_SQLX.GetValue("U_Porc_Anticipo", 0)
                        'Dias Pago
                        oFormP.DataSources.UserDataSources.Item("UDDIASP").ValueEx = DT_SQLX.GetValue("U_Dias_Pago", 0)


                        sql = "EXEC	" + sBDComercial.Trim() + ".[dbo].[Min_GPR_Consultar_Ultimas_Fechas_Proyecto_GLOBAL] @sCodPro = '" + sCodiP.Trim() + "'"

                        Try
                            DT_SQLX.ExecuteQuery(sql)
                        Catch ex As Exception
                            Application.SBO_Application.MessageBox(sql)
                            Application.SBO_Application.MessageBox(ex.Message)
                        End Try

                        If DT_SQLX.IsEmpty = False Then 'SI EXISTEN MODIFICACIONES DE FECHA
                            dFecVenta = DT_SQLX.GetValue("U_Fecha_Venta", 0)
                            dFecEntreg = DT_SQLX.GetValue("U_Fecha_Promet_Nvo", 0)
                            dFecFinDes = DT_SQLX.GetValue("U_Ter_Desar_Nvo", 0)
                            dFecFinPro = DT_SQLX.GetValue("U_Ter_Prod_Nvo", 0)
                            dFecIniDes = DT_SQLX.GetValue("U_Ter_Desp_Nvo", 0)
                            dFecIniMon = DT_SQLX.GetValue("U_Ini_Mont_Nvo", 0)
                            dFecFinMon = DT_SQLX.GetValue("U_Ter_Mont_Nvo", 0)
                        Else
                            DT_SQLX.CopyFrom(oUDataTable) ' RESTABLECER DATATABLE A QUERY INICIAL
                            dFecVenta = DT_SQLX.GetValue("Fecha_Venta", 0)
                            dFecEntreg = DT_SQLX.GetValue("Fecha_Prom_Cli", 0)
                            dFecFinDes = DT_SQLX.GetValue("Fecha_Fin_Desarr", 0)
                            dFecFinPro = DT_SQLX.GetValue("Fecha_Fin_Produc", 0)
                            dFecIniDes = DT_SQLX.GetValue("Fecha_Ini_Despa", 0)
                            dFecIniMon = DT_SQLX.GetValue("Fecha_Ini_Monta", 0)
                            dFecFinMon = DT_SQLX.GetValue("Fecha_Fin_Monta", 0)
                        End If

                        txt = oFormP.Items.Item("Item_10").Specific
                        txt.Value = Replace(dFecVenta, "-", "/")
                        txt = oFormP.Items.Item("Item_17").Specific
                        txt.Value = Replace(dFecEntreg, "-", "/")
                        txt = oFormP.Items.Item("Item_12").Specific
                        txt.Value = DateDiff(DateInterval.Day, dFecVenta, dFecEntreg)
                        txt = oFormP.Items.Item("Item_14").Specific
                        Dim nDias6 As Integer = oFunciones.Dias_Habiles(dFecFinMon, dFecEntreg)
                        txt.Value = nDias6

                        'Cargar Grid PCV
                        Cargar_Grid_PCV(oFormP, sCodiP.Trim())
                        Cargar_Grid_DESP(oFormP, sCodiP.Trim())
                        Cargar_Grid_FACT(oFormP, sCodiP.Trim())
                        Cargar_Grid_NDB(oFormP, sCodiP.Trim())
                        Cargar_Grid_NCR(oFormP, sCodiP.Trim())
                        Cargar_Grid_PAG(oFormP, sCodiP.Trim())
                        Cargar_Grid_DEV(oFormP, sCodiP.Trim())

                    End If

                Catch ex As Exception
                Finally
                    oFormP.Freeze(False)  'Se Descongela el Form luego de Actualizar u Ocurrir alguna excepcion
                    Application.SBO_Application.StatusBar.SetText("Datos Cargados", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success)

                End Try

            Catch ex As Exception

                Application.SBO_Application.MessageBox(sql)
                Application.SBO_Application.MessageBox(ex.Message)

            End Try

        End Sub

        Private Sub Cargar_Combo_CondicionesPagos()
            'Cargar Combo Condiciones Pago
            ComboBoxExtensions.CleanComboBox(ComboBox2)
            Dim Sql = "SELECT U_CondCode,U_CondDesc FROM [" + sBDComercial.Trim() + "].[dbo].[@MIN_CONDPAG] ORDER BY 1"
            ComboBoxExtensions.LoadComboQueryDataTable(ComboBox2, DT_SQL2, Sql, 0, 1, True)
        End Sub

        Public Shared Sub Cargar_Grids_OC(FormID As String, sCodiP As String)

            Dim oFormP As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(FormID)

            Try
                Application.SBO_Application.StatusBar.SetText("Cargando Datos de la OC, Espere un momento ...", SAPbouiCOM.BoMessageTime.bmt_Medium, SAPbouiCOM.BoStatusBarMessageType.smt_Warning)

                oFormP.Freeze(True) ' Se congelar el formulario para comenzar la actualizacion de los campos

                Cargar_Grid_PCV_OC(oFormP, sCodiP.Trim())
                Cargar_Grid_DESP_OC(oFormP, sCodiP.Trim())
                Cargar_Grid_FACT_OC(oFormP, sCodiP.Trim())
                Cargar_Grid_NDB_OC(oFormP, sCodiP.Trim())
                Cargar_Grid_NCR_OC(oFormP, sCodiP.Trim())
                Cargar_Grid_PAG_OC(oFormP, sCodiP.Trim())
                Cargar_Grid_DEV_OC(oFormP, sCodiP.Trim())
                Cargar_Grid_TOTAL_OC(oFormP, sCodiP.Trim())

            Catch ex As Exception
            Finally
                oFormP.Freeze(False)  'Se Descongela el Form luego de Actualizar u Ocurrir alguna excepcion
                Application.SBO_Application.StatusBar.SetText("Datos Cargados", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success)
            End Try


        End Sub

        Public Shared Sub Cargar_Grid_PCV(oForm As SAPbouiCOM.Form, sCodiP As String)

            Try
                Dim Sql = "EXEC [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Consultar_Datos_Gestion_Finanzas] @sCodPro = '" + sCodiP.Trim() + "', @TipoDoc = 'ORDR'"

                Try
                    oUDataTable = oForm.DataSources.DataTables.Item("DT_PCV")
                    oUDataTable.ExecuteQuery(Sql)
                Catch ex As Exception
                    Application.SBO_Application.MessageBox(Sql)
                    Application.SBO_Application.MessageBox(ex.Message)
                End Try

                oGrid = oForm.Items.Item("Item_24").Specific
                oGrid.RowHeaders.Width = 0
                oGrid.Columns.Item("DocNum").Editable = False
                oGrid.Columns.Item("DocNum").RightJustified = True
                oEditCol = oGrid.Columns.Item("DocNum")
                oEditCol.LinkedObjectType = 17

                oGrid.Columns.Item("DocTotal").Editable = False
                oGrid.Columns.Item("DocTotal").RightJustified = True

                oGrid.Columns.Item("Total").Visible = False

                oForm.DataSources.UserDataSources.Item("TotPCV").ValueEx = oUDataTable.GetValue("Total", 0)

                oGrid.Columns.Item("DocNum").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("DocTotal").BackColor = RGB(255, 255, 255) 'Blanco

                oGrid.AutoResizeColumns()

            Catch ex As Exception

            End Try

        End Sub

        Public Shared Sub Cargar_Grid_PCV_OC(oForm As SAPbouiCOM.Form, sCodiP As String)

            Try
                Dim Sql = "EXEC [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Consultar_Datos_Gestion_Finanzas_OC] @sCodPro = '" + sCodiP.Trim() + "', @TipoDoc = 'ORDR'"

                Try
                    oUDataTable = oForm.DataSources.DataTables.Item("DT_PCVOC")
                    oUDataTable.ExecuteQuery(Sql)
                Catch ex As Exception
                    Application.SBO_Application.MessageBox(Sql)
                    Application.SBO_Application.MessageBox(ex.Message)
                End Try

                oGrid = oForm.Items.Item("Item_77").Specific
                oGrid.RowHeaders.Width = 0
                oGrid.Columns.Item("Project").Editable = False
                oGrid.Columns.Item("DocNum").Editable = False
                oGrid.Columns.Item("DocNum").RightJustified = True
                oEditCol = oGrid.Columns.Item("DocNum")
                oEditCol.LinkedObjectType = 17

                oGrid.Columns.Item("DocTotal").Editable = False
                oGrid.Columns.Item("DocTotal").RightJustified = True

                oGrid.Columns.Item("Total").Visible = False

                oForm.DataSources.UserDataSources.Item("TotPCVOC").ValueEx = oUDataTable.GetValue("Total", 0)

                oGrid.Columns.Item("Project").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("DocNum").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("DocTotal").BackColor = RGB(255, 255, 255) 'Blanco

                oGrid.AutoResizeColumns()

            Catch ex As Exception

            End Try

        End Sub

        Public Shared Sub Cargar_Grid_DESP(oForm As SAPbouiCOM.Form, sCodiP As String)

            Try
                Dim Sql = "EXEC [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Consultar_Datos_Gestion_Finanzas] @sCodPro = '" + sCodiP.Trim() + "', @TipoDoc = 'ODLN'"

                Try
                    oUDataTable = oForm.DataSources.DataTables.Item("DT_DESP")
                    oUDataTable.Clear()
                    oUDataTable.ExecuteQuery(Sql)
                Catch ex As Exception
                    Application.SBO_Application.MessageBox(Sql)
                    Application.SBO_Application.MessageBox(ex.Message)
                End Try

                oGrid = oForm.Items.Item("Item_25").Specific
                oGrid.RowHeaders.Width = 0
                oGrid.Columns.Item("DocNum").Editable = False
                oGrid.Columns.Item("DocNum").RightJustified = True
                oEditCol = oGrid.Columns.Item("DocNum")
                oEditCol.LinkedObjectType = 15

                oGrid.Columns.Item("DocTotal").Editable = False
                oGrid.Columns.Item("DocTotal").RightJustified = True
                oGrid.Columns.Item("Folio").Editable = False

                oGrid.Columns.Item("Total").Visible = False
                oGrid.Columns.Item("%_Despacho").Visible = False

                oGrid.Columns.Item("DocNum").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("DocTotal").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("Folio").BackColor = RGB(255, 255, 255) 'Blanco


                oGrid.AutoResizeColumns()

                Dim Res As String = String.Format("{0:N2}", oUDataTable.GetValue("Total", 0))
                oedit = oForm.Items.Item("Item_36").Specific
                oedit.String = oUDataTable.GetValue("Total", 0)
                'oedit.Value = String.Format("{0:#,#.00}", oUDataTable.GetValue("Total", 0))
                'oedit.String = IIf(oedit.String = ",00", "0,00", oedit.String)
                TotDesp = oUDataTable.GetValue("Total", 0)

                Dim Porc As Double = oUDataTable.GetValue("%_Despacho", 0)
                oedit = oForm.Items.Item("Item_132").Specific
                oedit.String = Porc
                oForm.DataSources.UserDataSources.Item("TotDESP").ValueEx = String.Format("{0:#,#.00}", oUDataTable.GetValue("Total", 0))

            Catch ex As Exception

            End Try

        End Sub


        Public Shared Sub Cargar_Grid_DESP_OC(oForm As SAPbouiCOM.Form, sCodiP As String)

            Try
                Dim Sql = "EXEC [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Consultar_Datos_Gestion_Finanzas_OC] @sCodPro = '" + sCodiP.Trim() + "', @TipoDoc = 'ODLN'"

                Try
                    oUDataTable = oForm.DataSources.DataTables.Item("DT_DESPOC")
                    oUDataTable.Clear()
                    oUDataTable.ExecuteQuery(Sql)
                Catch ex As Exception
                    Application.SBO_Application.MessageBox(Sql)
                    Application.SBO_Application.MessageBox(ex.Message)
                End Try

                oGrid = oForm.Items.Item("Item_78").Specific
                oGrid.RowHeaders.Width = 0
                oGrid.Columns.Item("Project").Editable = False
                oGrid.Columns.Item("DocNum").Editable = False
                oGrid.Columns.Item("DocNum").RightJustified = True
                oEditCol = oGrid.Columns.Item("DocNum")
                oEditCol.LinkedObjectType = 15

                oGrid.Columns.Item("DocTotal").Editable = False
                oGrid.Columns.Item("DocTotal").RightJustified = True
                oGrid.Columns.Item("Folio").Editable = False

                oGrid.Columns.Item("Total").Visible = False
                oGrid.Columns.Item("%_Despacho").Visible = False

                oGrid.Columns.Item("Project").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("DocNum").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("DocTotal").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("Folio").BackColor = RGB(255, 255, 255) 'Blanco

                oGrid.AutoResizeColumns()

                Dim Res As String = String.Format("{0:N2}", oUDataTable.GetValue("Total", 0))
                oedit = oForm.Items.Item("Item_89").Specific
                oedit.String = oUDataTable.GetValue("Total", 0) 'String.Format("{0:#,#.00}", oUDataTable.GetValue("Total", 0))
                'oedit.Value = IIf(oedit.Value = ",00", "0,00", oedit.Value)
                'oedit.Value = (oedit.Value).ToString.Replace(",00", "")cc
                TotDespOC = oUDataTable.GetValue("Total", 0)

                Dim Porc As Double = Math.Round(oUDataTable.GetValue("%_Despacho", 0), 2)
                oedit = oForm.Items.Item("Item_130").Specific
                oedit.String = Porc
                oForm.DataSources.UserDataSources.Item("PorcDESPOC").ValueEx = oUDataTable.GetValue("%_Despacho", 0)

                oForm.DataSources.UserDataSources.Item("TotDESPOC").ValueEx = String.Format("{0:#,#.00}", oUDataTable.GetValue("Total", 0))

            Catch ex As Exception

            End Try

        End Sub

        Public Shared Sub Cargar_Grid_FACT(oForm As SAPbouiCOM.Form, sCodiP As String)

            Try
                Dim Sql = "EXEC [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Consultar_Datos_Gestion_Finanzas] @sCodPro = '" + sCodiP.Trim() + "', @TipoDoc = 'OINV'"

                Try
                    oUDataTable = oForm.DataSources.DataTables.Item("DT_FACT")
                    oUDataTable.ExecuteQuery(Sql)
                Catch ex As Exception
                    Application.SBO_Application.MessageBox(Sql)
                    Application.SBO_Application.MessageBox(ex.Message)
                End Try

                oGrid = oForm.Items.Item("Item_26").Specific
                oGrid.RowHeaders.Width = 0
                oGrid.Columns.Item("DocNum").Editable = False
                oGrid.Columns.Item("DocNum").RightJustified = True
                oEditCol = oGrid.Columns.Item("DocNum")
                oEditCol.LinkedObjectType = 13

                oGrid.Columns.Item("DocTotal").Editable = False
                oGrid.Columns.Item("DocTotal").RightJustified = True
                oGrid.Columns.Item("Folio").Editable = False

                oGrid.Columns.Item("Total").Visible = False

                oForm.DataSources.UserDataSources.Item("TotFACT").ValueEx = oUDataTable.GetValue("Total", 0)
                TotFact = oUDataTable.GetValue("Total", 0)

                oGrid.Columns.Item("DocNum").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("DocTotal").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("Folio").BackColor = RGB(255, 255, 255) 'Blanco

                oGrid.AutoResizeColumns()

            Catch ex As Exception

            End Try

        End Sub

        Public Shared Sub Cargar_Grid_FACT_OC(oForm As SAPbouiCOM.Form, sCodiP As String)

            Try
                Dim Sql = "EXEC [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Consultar_Datos_Gestion_Finanzas_OC] @sCodPro = '" + sCodiP.Trim() + "', @TipoDoc = 'OINV'"

                Try
                    oUDataTable = oForm.DataSources.DataTables.Item("DT_FACTOC")
                    oUDataTable.ExecuteQuery(Sql)
                Catch ex As Exception
                    Application.SBO_Application.MessageBox(Sql)
                    Application.SBO_Application.MessageBox(ex.Message)
                End Try

                oGrid = oForm.Items.Item("Item_79").Specific
                oGrid.RowHeaders.Width = 0
                oGrid.Columns.Item("Project").Editable = False
                oGrid.Columns.Item("DocNum").Editable = False
                oGrid.Columns.Item("DocNum").RightJustified = True
                oEditCol = oGrid.Columns.Item("DocNum")
                oEditCol.LinkedObjectType = 13

                oGrid.Columns.Item("DocTotal").Editable = False
                oGrid.Columns.Item("DocTotal").RightJustified = True
                oGrid.Columns.Item("Folio").Editable = False

                oGrid.Columns.Item("Total").Visible = False

                oForm.DataSources.UserDataSources.Item("TotFACTOC").ValueEx = oUDataTable.GetValue("Total", 0)
                TotFactOC = oUDataTable.GetValue("Total", 0)

                oGrid.Columns.Item("Project").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("DocNum").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("DocTotal").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("Folio").BackColor = RGB(255, 255, 255) 'Blanco

                oGrid.AutoResizeColumns()

            Catch ex As Exception

            End Try

        End Sub

        Public Shared Sub Cargar_Grid_NDB(oForm As SAPbouiCOM.Form, sCodiP As String)

            Try
                Dim Sql = "EXEC [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Consultar_Datos_Gestion_Finanzas] @sCodPro = '" + sCodiP.Trim() + "', @TipoDoc = 'N/DB'"

                Try
                    oUDataTable = oForm.DataSources.DataTables.Item("DT_NDB")
                    oUDataTable.ExecuteQuery(Sql)
                Catch ex As Exception
                    Application.SBO_Application.MessageBox(Sql)
                    Application.SBO_Application.MessageBox(ex.Message)
                End Try

                oGrid = oForm.Items.Item("Item_45").Specific
                oGrid.RowHeaders.Width = 0
                oGrid.Columns.Item("DocNum").Editable = False
                oGrid.Columns.Item("DocNum").RightJustified = True
                oEditCol = oGrid.Columns.Item("DocNum")
                oEditCol.LinkedObjectType = 17

                oGrid.Columns.Item("DocTotal").Editable = False
                oGrid.Columns.Item("DocTotal").RightJustified = True
                oGrid.Columns.Item("Folio").Editable = False

                oGrid.Columns.Item("Total").Visible = False

                oGrid.Columns.Item("DocNum").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("DocTotal").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("Folio").BackColor = RGB(255, 255, 255) 'Blanco

                oForm.DataSources.UserDataSources.Item("TotNDB").ValueEx = oUDataTable.GetValue("Total", 0)
                TotNDB = oUDataTable.GetValue("Total", 0)

                oGrid.AutoResizeColumns()

            Catch ex As Exception

            End Try

        End Sub

        Public Shared Sub Cargar_Grid_NDB_OC(oForm As SAPbouiCOM.Form, sCodiP As String)

            Try
                Dim Sql = "EXEC [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Consultar_Datos_Gestion_Finanzas_OC] @sCodPro = '" + sCodiP.Trim() + "', @TipoDoc = 'N/DB'"

                Try
                    oUDataTable = oForm.DataSources.DataTables.Item("DT_NDBOC")
                    oUDataTable.ExecuteQuery(Sql)
                Catch ex As Exception
                    Application.SBO_Application.MessageBox(Sql)
                    Application.SBO_Application.MessageBox(ex.Message)
                End Try

                oGrid = oForm.Items.Item("Item_95").Specific
                oGrid.RowHeaders.Width = 0
                oGrid.Columns.Item("Project").Editable = False
                oGrid.Columns.Item("DocNum").Editable = False
                oGrid.Columns.Item("DocNum").RightJustified = True
                oEditCol = oGrid.Columns.Item("DocNum")
                oEditCol.LinkedObjectType = 17

                oGrid.Columns.Item("DocTotal").Editable = False
                oGrid.Columns.Item("DocTotal").RightJustified = True
                oGrid.Columns.Item("Folio").Editable = False

                oGrid.Columns.Item("Total").Visible = False

                oGrid.Columns.Item("Project").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("DocNum").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("DocTotal").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("Folio").BackColor = RGB(255, 255, 255) 'Blanco

                oForm.DataSources.UserDataSources.Item("TotNDBOC").ValueEx = oUDataTable.GetValue("Total", 0)
                TotNDBOC = oUDataTable.GetValue("Total", 0)

                oGrid.AutoResizeColumns()

            Catch ex As Exception

            End Try

        End Sub

        Public Shared Sub Cargar_Grid_NCR(oForm As SAPbouiCOM.Form, sCodiP As String)

            Try
                Dim Sql = "EXEC [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Consultar_Datos_Gestion_Finanzas] @sCodPro = '" + sCodiP.Trim() + "', @TipoDoc = 'ORIN'"

                Try
                    oUDataTable = oForm.DataSources.DataTables.Item("DT_NCR")
                    oUDataTable.ExecuteQuery(Sql)
                Catch ex As Exception
                    Application.SBO_Application.MessageBox(Sql)
                    Application.SBO_Application.MessageBox(ex.Message)
                End Try

                oGrid = oForm.Items.Item("Item_49").Specific
                oGrid.RowHeaders.Width = 0
                oGrid.Columns.Item("DocNum").Editable = False
                oGrid.Columns.Item("DocNum").RightJustified = True
                oEditCol = oGrid.Columns.Item("DocNum")
                oEditCol.LinkedObjectType = 17

                oGrid.Columns.Item("DocTotal").Editable = False
                oGrid.Columns.Item("DocTotal").RightJustified = True
                oGrid.Columns.Item("Folio").Editable = False

                oGrid.Columns.Item("Total").Visible = False

                oGrid.Columns.Item("DocNum").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("DocTotal").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("Folio").BackColor = RGB(255, 255, 255) 'Blanco

                oForm.DataSources.UserDataSources.Item("TotNCR").ValueEx = oUDataTable.GetValue("Total", 0)
                TotNCR = oUDataTable.GetValue("Total", 0)
                oForm.DataSources.UserDataSources.Item("TotFACTR").ValueEx = TotFact + TotNDB - TotNCR


                oGrid.AutoResizeColumns()

            Catch ex As Exception

            End Try

        End Sub

        Public Shared Sub Cargar_Grid_NCR_OC(oForm As SAPbouiCOM.Form, sCodiP As String)

            Try
                Dim Sql = "EXEC [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Consultar_Datos_Gestion_Finanzas_OC] @sCodPro = '" + sCodiP.Trim() + "', @TipoDoc = 'ORIN'"

                Try
                    oUDataTable = oForm.DataSources.DataTables.Item("DT_NCROC")
                    oUDataTable.ExecuteQuery(Sql)
                Catch ex As Exception
                    Application.SBO_Application.MessageBox(Sql)
                    Application.SBO_Application.MessageBox(ex.Message)
                End Try

                oGrid = oForm.Items.Item("Item_99").Specific
                oGrid.RowHeaders.Width = 0
                oGrid.Columns.Item("Project").Editable = False
                oGrid.Columns.Item("DocNum").Editable = False
                oGrid.Columns.Item("DocNum").RightJustified = True
                oEditCol = oGrid.Columns.Item("DocNum")
                oEditCol.LinkedObjectType = 17

                oGrid.Columns.Item("DocTotal").Editable = False
                oGrid.Columns.Item("DocTotal").RightJustified = True
                oGrid.Columns.Item("Folio").Editable = False

                oGrid.Columns.Item("Total").Visible = False

                oGrid.Columns.Item("Project").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("DocNum").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("DocTotal").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("Folio").BackColor = RGB(255, 255, 255) 'Blanco

                oForm.DataSources.UserDataSources.Item("TotNCROC").ValueEx = oUDataTable.GetValue("Total", 0)
                TotNCROC = oUDataTable.GetValue("Total", 0)
                oForm.DataSources.UserDataSources.Item("TotFACTROC").ValueEx = TotFactOC + TotNDBOC - TotNCROC

                oGrid.AutoResizeColumns()

            Catch ex As Exception

            End Try

        End Sub

        Public Shared Sub Cargar_Grid_PAG(oForm As SAPbouiCOM.Form, sCodiP As String)

            Try
                Dim Sql = "EXEC [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Consultar_Datos_Gestion_Finanzas] @sCodPro = '" + sCodiP.Trim() + "', @TipoDoc = 'ORCT'"

                Try
                    oUDataTable = oForm.DataSources.DataTables.Item("DT_PAG")
                    oUDataTable.ExecuteQuery(Sql)
                Catch ex As Exception
                    Application.SBO_Application.MessageBox(Sql)
                    Application.SBO_Application.MessageBox(ex.Message)
                End Try

                oGrid = oForm.Items.Item("Item_31").Specific
                oGrid.RowHeaders.Width = 0
                oGrid.Columns.Item(0).Editable = False
                oGrid.Columns.Item(0).RightJustified = True
                oEditCol = oGrid.Columns.Item(0)
                oEditCol.LinkedObjectType = 17

                oGrid.Columns.Item(1).Editable = False
                oGrid.Columns.Item(1).RightJustified = True

                oGrid.Columns.Item(2).Editable = False
                oGrid.Columns.Item(2).RightJustified = True

                oGrid.Columns.Item(3).Editable = False
                oGrid.Columns.Item(4).Editable = False
                oGrid.Columns.Item(4).RightJustified = True

                oGrid.Columns.Item(0).BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item(1).BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item(2).BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item(3).BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item(4).BackColor = RGB(255, 255, 255) 'Blanco

                Dim nTotal As Double = 0

                For index = 0 To oGrid.DataTable.Rows.Count - 1
                    nTotal += oUDataTable.GetValue(4, index)
                Next

                oedit = oForm.Items.Item("Item_40").Specific
                oedit.String = nTotal
                oedit = oForm.Items.Item("Item_113").Specific
                oedit.String = nTotal * 1.19
                'oForm.DataSources.UserDataSources.Item("TotPAG").ValueEx = nTotal

                oGrid.AutoResizeColumns()

            Catch ex As Exception

            End Try

        End Sub

        Public Shared Sub Cargar_Grid_PAG_OC(oForm As SAPbouiCOM.Form, sCodiP As String)

            Try
                Dim Sql = "EXEC [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Consultar_Datos_Gestion_Finanzas_OC] @sCodPro = '" + sCodiP.Trim() + "', @TipoDoc = 'ORCT'"

                Try
                    oUDataTable = oForm.DataSources.DataTables.Item("DT_PAGOC")
                    oUDataTable.ExecuteQuery(Sql)
                Catch ex As Exception
                    Application.SBO_Application.MessageBox(Sql)
                    Application.SBO_Application.MessageBox(ex.Message)
                End Try

                oGrid = oForm.Items.Item("Item_84").Specific
                oGrid.RowHeaders.Width = 0
                oGrid.Columns.Item(0).Editable = False
                oGrid.Columns.Item(1).Editable = False
                oGrid.Columns.Item(1).RightJustified = True
                oEditCol = oGrid.Columns.Item(1)
                oEditCol.LinkedObjectType = 17

                oGrid.Columns.Item(2).Editable = False
                oGrid.Columns.Item(2).RightJustified = True

                oGrid.Columns.Item(3).Editable = False
                oGrid.Columns.Item(3).RightJustified = True

                oGrid.Columns.Item(4).Editable = False
                oGrid.Columns.Item(5).Editable = False
                oGrid.Columns.Item(5).RightJustified = True

                oGrid.Columns.Item(0).BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item(1).BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item(2).BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item(3).BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item(4).BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item(5).BackColor = RGB(255, 255, 255) 'Blanco

                Dim nTotal As Double = 0

                For index = 0 To oGrid.DataTable.Rows.Count - 1
                    nTotal += oUDataTable.GetValue(5, index)
                Next

                oedit = oForm.Items.Item("Item_93").Specific
                oedit.String = nTotal
                oedit = oForm.Items.Item("Item_121").Specific
                oedit.String = nTotal * 1.19
                'oForm.DataSources.UserDataSources.Item("TotPAGOC").ValueEx = nTotal

                oGrid.AutoResizeColumns()

            Catch ex As Exception
            End Try

        End Sub

        Public Shared Sub Cargar_Grid_DEV(oForm As SAPbouiCOM.Form, sCodiP As String)

            Try
                Dim Sql = "EXEC [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Consultar_Datos_Gestion_Finanzas] @sCodPro = '" + sCodiP.Trim() + "', @TipoDoc = 'ORDN'"

                Try
                    oUDataTable = oForm.DataSources.DataTables.Item("DT_DEV")
                    oUDataTable.ExecuteQuery(Sql)
                Catch ex As Exception
                    Application.SBO_Application.MessageBox(Sql)
                    Application.SBO_Application.MessageBox(ex.Message)
                End Try

                oGrid = oForm.Items.Item("Item_62").Specific
                oGrid.RowHeaders.Width = 0

                oGrid.Columns.Item("DocNum").Editable = False
                oGrid.Columns.Item("DocNum").RightJustified = True
                oEditCol = oGrid.Columns.Item("DocNum")
                oEditCol.LinkedObjectType = 13

                oGrid.Columns.Item("DocTotal").Editable = False
                oGrid.Columns.Item("DocTotal").RightJustified = True
                oGrid.Columns.Item("Folio").Editable = False

                oGrid.Columns.Item("Total").Visible = False

                oForm.DataSources.UserDataSources.Item("TotDEV").ValueEx = oUDataTable.GetValue("Total", 0)
                TotDev = oUDataTable.GetValue("Total", 0)
                oForm.DataSources.UserDataSources.Item("TotDESPR").ValueEx = TotDesp - TotDev

                oGrid.Columns.Item("DocNum").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("DocTotal").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("Folio").BackColor = RGB(255, 255, 255) 'Blanco

                oGrid.AutoResizeColumns()

            Catch ex As Exception

            End Try

        End Sub

        Public Shared Sub Cargar_Grid_DEV_OC(oForm As SAPbouiCOM.Form, sCodiP As String)

            Try
                Dim Sql = "EXEC [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Consultar_Datos_Gestion_Finanzas_OC] @sCodPro = '" + sCodiP.Trim() + "', @TipoDoc = 'ORDN'"

                Try
                    oUDataTable = oForm.DataSources.DataTables.Item("DT_DEVOC")
                    oUDataTable.ExecuteQuery(Sql)
                Catch ex As Exception
                    Application.SBO_Application.MessageBox(Sql)
                    Application.SBO_Application.MessageBox(ex.Message)
                End Try

                oGrid = oForm.Items.Item("Item_103").Specific
                oGrid.RowHeaders.Width = 0
                oGrid.Columns.Item("Project").Editable = False
                oGrid.Columns.Item("DocNum").Editable = False
                oGrid.Columns.Item("DocNum").RightJustified = True
                oEditCol = oGrid.Columns.Item("DocNum")
                oEditCol.LinkedObjectType = 17

                oGrid.Columns.Item("DocTotal").Editable = False
                oGrid.Columns.Item("DocTotal").RightJustified = True
                oGrid.Columns.Item("Folio").Editable = False

                oGrid.Columns.Item("Total").Visible = False

                oGrid.Columns.Item("Project").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("DocNum").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("DocTotal").BackColor = RGB(255, 255, 255) 'Blanco
                oGrid.Columns.Item("Folio").BackColor = RGB(255, 255, 255) 'Blanco

                oForm.DataSources.UserDataSources.Item("TotDEVOC").ValueEx = oUDataTable.GetValue("Total", 0)
                oForm.DataSources.UserDataSources.Item("TotDESPROC").ValueEx = TotDespOC - TotDevOC

                oGrid.AutoResizeColumns()

            Catch ex As Exception

            End Try

        End Sub

        Public Shared Sub Cargar_Grid_TOTAL_OC(oForm As SAPbouiCOM.Form, sCodiP As String)

            Try
                Dim Sql = "EXEC [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Consultar_Datos_Gestion_Finanzas_OC] @sCodPro = '" + sCodiP.Trim() + "', @TipoDoc = 'TOTAL'"

                Try
                    oUDataTable = oForm.DataSources.DataTables.Item("DT_TOTOC2")
                    oUDataTable.ExecuteQuery(Sql)
                    oUDataTable = oForm.DataSources.DataTables.Item("DT_TOTOC")
                    oUDataTable.ExecuteQuery(Sql)
                Catch ex As Exception
                    Application.SBO_Application.MessageBox(Sql)
                    Application.SBO_Application.MessageBox(ex.Message)
                End Try

                oGrid = oForm.Items.Item("Item_123").Specific
                oGrid.RowHeaders.Width = 0
                oGrid.Columns.Item(0).Visible = False

                For index = 1 To oGrid.DataTable.Columns.Count - 1
                    oGrid.Columns.Item(index).Editable = False
                    oGrid.Columns.Item(index).BackColor = RGB(255, 255, 255) 'Blanco
                    oGrid.Columns.Item(index).RightJustified = True
                Next

                oGrid.AutoResizeColumns()

                oUDataTable.Rows.Remove(1)

            Catch ex As Exception
            End Try

        End Sub

        Sub Cargar_Grid_Proyectos_Anticipos()

            Try

                Application.SBO_Application.StatusBar.SetText("Cargando Datos, Espere un momento ...", SAPbouiCOM.BoMessageTime.bmt_Medium, SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
                oForm.Freeze(True)

                Dim Sql = ""

                Select Case ComboBox0.Selected.Value
                    Case 1
                        Sql = "EXEC [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Consultar_Proyectos_Anticipos_Gestion_Finanzas_OC]"
                    Case 2
                        Sql = "EXEC [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Consultar_Proyectos_Anticipos_Gestion_Finanzas]"
                End Select


                Try
                    oUDataTable = oForm.DataSources.DataTables.Item("DT_ANTI")
                    oUDataTable.ExecuteQuery(Sql)
                Catch ex As Exception
                    Application.SBO_Application.MessageBox(Sql)
                    Application.SBO_Application.MessageBox(ex.Message)
                End Try

                oGrid = oForm.Items.Item("Item_70").Specific
                'oGrid.RowHeaders.Width = 0

                Dim Col_Justif = {4, 5, 6, 8, 9, 10, 11, 12}

                'oEditCol = oGrid.Columns.Item(0)
                'oEditCol.LinkedObjectType = 17

                For index = 0 To oGrid.DataTable.Columns.Count - 1
                    oGrid.Columns.Item(index).Editable = False
                    oGrid.Columns.Item(index).TitleObject.Sortable = True
                    oGrid.Columns.Item(index).BackColor = RGB(255, 255, 255) 'Blanco
                    If Col_Justif.Contains(index) Then
                        oGrid.Columns.Item(index).RightJustified = True
                    End If
                Next

                oFunciones.Numero_Fila_Grid(oGrid)

                oGrid.AutoResizeColumns()

            Catch ex As Exception
            Finally
                oForm.Freeze(False)
                Application.SBO_Application.StatusBar.SetText("Datos Cargados", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success)
            End Try

        End Sub

        Sub Cargar_Grid_Proyectos_Despachados()

            Try
                Application.SBO_Application.StatusBar.SetText("Cargando Datos, Espere un momento ...", SAPbouiCOM.BoMessageTime.bmt_Medium, SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
                oForm.Freeze(True)

                Dim Sql = ""

                Select Case ComboBox1.Selected.Value
                    Case 1
                        Sql = "EXEC [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Consultar_Proyectos_Despachados_Factura_Gestion_Finanzas_OC]"
                    Case 2
                        Sql = "EXEC [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Consultar_Proyectos_Despachados_Factura_Gestion_Finanzas]"
                End Select

                Try
                    oUDataTable = oForm.DataSources.DataTables.Item("DT_ENTF")
                    oUDataTable.ExecuteQuery(Sql)
                Catch ex As Exception
                    Application.SBO_Application.MessageBox(Sql)
                    Application.SBO_Application.MessageBox(ex.Message)
                End Try

                oGrid = oForm.Items.Item("Item_75").Specific
                'oGrid.RowHeaders.Width = 0

                Dim Col_Justif = {5, 7, 8, 9, 10, 11, 13}

                'oEditCol = oGrid.Columns.Item(0)
                'oEditCol.LinkedObjectType = 17
                If ComboBox1.Selected.Value = 1 Then
                    oGrid.Columns.Item(6).Visible = False
                    oGrid.Columns.Item(7).Visible = False
                End If

                For index = 0 To oGrid.DataTable.Columns.Count - 1
                    oGrid.Columns.Item(index).Editable = False
                    oGrid.Columns.Item(index).TitleObject.Sortable = True
                    oGrid.Columns.Item(index).BackColor = RGB(255, 255, 255) 'Blanco
                    If Col_Justif.Contains(index) Then
                        oGrid.Columns.Item(index).RightJustified = True
                    End If
                Next

                oFunciones.Numero_Fila_Grid(oGrid)

                oGrid.AutoResizeColumns()

            Catch ex As Exception
            Finally
                oForm.Freeze(False)
                Application.SBO_Application.StatusBar.SetText("Datos Cargados", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success)
            End Try

        End Sub

        Private WithEvents EditText0 As SAPbouiCOM.EditText
        Private WithEvents StaticText0 As SAPbouiCOM.StaticText
        Private WithEvents EditText1 As SAPbouiCOM.EditText
        Private WithEvents StaticText1 As SAPbouiCOM.StaticText
        Private WithEvents EditText2 As SAPbouiCOM.EditText
        Private WithEvents StaticText2 As SAPbouiCOM.StaticText
        Private WithEvents EditText3 As SAPbouiCOM.EditText
        Private WithEvents StaticText3 As SAPbouiCOM.StaticText
        Private WithEvents EditText4 As SAPbouiCOM.EditText
        Private WithEvents StaticText4 As SAPbouiCOM.StaticText
        Private WithEvents EditText5 As SAPbouiCOM.EditText
        Private WithEvents StaticText5 As SAPbouiCOM.StaticText
        Private WithEvents EditText6 As SAPbouiCOM.EditText
        Private WithEvents StaticText6 As SAPbouiCOM.StaticText
        Private WithEvents Button0 As SAPbouiCOM.Button
        Private WithEvents EditText7 As SAPbouiCOM.EditText
        Private WithEvents StaticText7 As SAPbouiCOM.StaticText
        Private WithEvents EditText8 As SAPbouiCOM.EditText
        Private WithEvents StaticText8 As SAPbouiCOM.StaticText
        Private WithEvents LinkedButton0 As SAPbouiCOM.LinkedButton
        Private WithEvents PictureBox0 As SAPbouiCOM.PictureBox
        Private WithEvents Grid0 As SAPbouiCOM.Grid
        Private WithEvents Grid1 As SAPbouiCOM.Grid
        Private WithEvents Grid2 As SAPbouiCOM.Grid
        Private WithEvents StaticText9 As SAPbouiCOM.StaticText
        Private WithEvents StaticText10 As SAPbouiCOM.StaticText
        Private WithEvents StaticText11 As SAPbouiCOM.StaticText
        Private WithEvents StaticText12 As SAPbouiCOM.StaticText
        Private WithEvents Grid3 As SAPbouiCOM.Grid
        Private WithEvents StaticText13 As SAPbouiCOM.StaticText
        Private WithEvents EditText9 As SAPbouiCOM.EditText
        Private WithEvents EditText10 As SAPbouiCOM.EditText
        Private WithEvents StaticText14 As SAPbouiCOM.StaticText
        Private WithEvents EditText11 As SAPbouiCOM.EditText
        Private WithEvents StaticText15 As SAPbouiCOM.StaticText
        Private WithEvents EditText12 As SAPbouiCOM.EditText
        Private WithEvents StaticText16 As SAPbouiCOM.StaticText
        Private WithEvents EditText13 As SAPbouiCOM.EditText
        Private WithEvents StaticText17 As SAPbouiCOM.StaticText
        Private WithEvents EditText14 As SAPbouiCOM.EditText
        Private WithEvents StaticText18 As SAPbouiCOM.StaticText
        Private WithEvents EditText15 As SAPbouiCOM.EditText
        Private WithEvents StaticText19 As SAPbouiCOM.StaticText
        Private WithEvents Grid4 As SAPbouiCOM.Grid
        Private WithEvents StaticText20 As SAPbouiCOM.StaticText
        Private WithEvents EditText16 As SAPbouiCOM.EditText
        Private WithEvents StaticText21 As SAPbouiCOM.StaticText
        Private WithEvents Grid5 As SAPbouiCOM.Grid
        Private WithEvents StaticText22 As SAPbouiCOM.StaticText
        Private WithEvents EditText17 As SAPbouiCOM.EditText
        Private WithEvents StaticText23 As SAPbouiCOM.StaticText
        Private WithEvents EditText18 As SAPbouiCOM.EditText
        Private WithEvents StaticText24 As SAPbouiCOM.StaticText
        Private WithEvents StaticText25 As SAPbouiCOM.StaticText
        Private WithEvents StaticText26 As SAPbouiCOM.StaticText
        Private WithEvents EditText19 As SAPbouiCOM.EditText
        Private WithEvents StaticText27 As SAPbouiCOM.StaticText
        Private WithEvents EditText20 As SAPbouiCOM.EditText
        Private WithEvents EditText21 As SAPbouiCOM.EditText
        Private WithEvents StaticText28 As SAPbouiCOM.StaticText
        Private WithEvents StaticText29 As SAPbouiCOM.StaticText
        Private WithEvents StaticText30 As SAPbouiCOM.StaticText
        Private WithEvents EditText22 As SAPbouiCOM.EditText
        Private WithEvents StaticText31 As SAPbouiCOM.StaticText
        Private WithEvents EditText23 As SAPbouiCOM.EditText
        Private WithEvents ComboBox2 As SAPbouiCOM.ComboBox
        Private WithEvents ComboBox3 As SAPbouiCOM.ComboBox
        Private WithEvents DT_SQL1 As SAPbouiCOM.DataTable
        Private WithEvents DT_SQL2 As SAPbouiCOM.DataTable
        Private WithEvents Button1 As SAPbouiCOM.Button
        Private WithEvents Folder1 As SAPbouiCOM.Folder
        Private WithEvents Grid6 As SAPbouiCOM.Grid
        Private WithEvents Folder3 As SAPbouiCOM.Folder



        Private WithEvents Grid7 As SAPbouiCOM.Grid
        Private WithEvents Folder4 As SAPbouiCOM.Folder
        Private WithEvents Grid8 As SAPbouiCOM.Grid
        Private WithEvents Grid9 As SAPbouiCOM.Grid
        Private WithEvents Grid10 As SAPbouiCOM.Grid
        Private WithEvents StaticText33 As SAPbouiCOM.StaticText
        Private WithEvents StaticText34 As SAPbouiCOM.StaticText
        Private WithEvents StaticText35 As SAPbouiCOM.StaticText
        Private WithEvents Grid11 As SAPbouiCOM.Grid
        Private WithEvents StaticText36 As SAPbouiCOM.StaticText
        Private WithEvents EditText25 As SAPbouiCOM.EditText
        Private WithEvents StaticText37 As SAPbouiCOM.StaticText
        Private WithEvents EditText26 As SAPbouiCOM.EditText
        Private WithEvents StaticText38 As SAPbouiCOM.StaticText
        Private WithEvents EditText27 As SAPbouiCOM.EditText
        Private WithEvents StaticText39 As SAPbouiCOM.StaticText
        Private WithEvents EditText28 As SAPbouiCOM.EditText
        Private WithEvents StaticText40 As SAPbouiCOM.StaticText
        Private WithEvents Grid12 As SAPbouiCOM.Grid
        Private WithEvents StaticText41 As SAPbouiCOM.StaticText
        Private WithEvents EditText29 As SAPbouiCOM.EditText
        Private WithEvents StaticText42 As SAPbouiCOM.StaticText
        Private WithEvents Grid13 As SAPbouiCOM.Grid
        Private WithEvents StaticText43 As SAPbouiCOM.StaticText
        Private WithEvents EditText30 As SAPbouiCOM.EditText
        Private WithEvents StaticText44 As SAPbouiCOM.StaticText
        Private WithEvents StaticText53 As SAPbouiCOM.StaticText
        Private WithEvents EditText37 As SAPbouiCOM.EditText
        Private WithEvents StaticText54 As SAPbouiCOM.StaticText
        Private WithEvents Grid14 As SAPbouiCOM.Grid
        Private WithEvents Button2 As SAPbouiCOM.Button
        Private WithEvents Folder5 As SAPbouiCOM.Folder
        Private WithEvents ComboBox4 As SAPbouiCOM.ComboBox
        Private WithEvents StaticText55 As SAPbouiCOM.StaticText
        Private WithEvents Grid15 As SAPbouiCOM.Grid
        Private WithEvents Grid16 As SAPbouiCOM.Grid
        Private WithEvents StaticText32 As SAPbouiCOM.StaticText
        Private WithEvents EditText24 As SAPbouiCOM.EditText
        Private WithEvents StaticText45 As SAPbouiCOM.StaticText
        Private WithEvents Grid17 As SAPbouiCOM.Grid
        Private WithEvents StaticText46 As SAPbouiCOM.StaticText
        Private WithEvents EditText31 As SAPbouiCOM.EditText
        Private WithEvents StaticText47 As SAPbouiCOM.StaticText
        Private WithEvents Button3 As SAPbouiCOM.Button
        Private WithEvents Button4 As SAPbouiCOM.Button
        Private WithEvents EditText32 As SAPbouiCOM.EditText
        Private WithEvents StaticText48 As SAPbouiCOM.StaticText
        Private WithEvents EditText33 As SAPbouiCOM.EditText
        Private WithEvents StaticText49 As SAPbouiCOM.StaticText
        Private WithEvents EditText34 As SAPbouiCOM.EditText
        Private WithEvents StaticText50 As SAPbouiCOM.StaticText
        Private WithEvents EditText35 As SAPbouiCOM.EditText
        Private WithEvents StaticText51 As SAPbouiCOM.StaticText
        Private WithEvents EditText36 As SAPbouiCOM.EditText
        Private WithEvents StaticText52 As SAPbouiCOM.StaticText
        Private WithEvents EditText38 As SAPbouiCOM.EditText
        Private WithEvents StaticText56 As SAPbouiCOM.StaticText
        Private WithEvents EditText39 As SAPbouiCOM.EditText
        Private WithEvents StaticText57 As SAPbouiCOM.StaticText
        Private WithEvents EditText40 As SAPbouiCOM.EditText
        Private WithEvents StaticText58 As SAPbouiCOM.StaticText
        Private WithEvents StaticText59 As SAPbouiCOM.StaticText
        Private WithEvents ComboBox0 As SAPbouiCOM.ComboBox
        Private WithEvents StaticText60 As SAPbouiCOM.StaticText
        Private WithEvents ComboBox1 As SAPbouiCOM.ComboBox
    End Class
End Namespace
