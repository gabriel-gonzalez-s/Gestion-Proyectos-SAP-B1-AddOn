Option Strict Off
Option Explicit On

Imports SAPbouiCOM.Framework

Namespace SBOAddonProject1
    <FormAttribute("SBOAddonProject1.GestionFinanzas", "3_Presentation_Layer/Pantallas Principales/GestionFinanzas.b1f")>
    Friend Class GestionFinanzas
        Inherits UserFormBase

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
            Me.EditText24 = CType(Me.GetItem("Item_69").Specific, SAPbouiCOM.EditText)
            Me.EditText25 = CType(Me.GetItem("Item_70").Specific, SAPbouiCOM.EditText)
            Me.OnCustomInitialize()

        End Sub

        Public Overrides Sub OnInitializeFormEvents()

        End Sub

        Private WithEvents Folder0 As SAPbouiCOM.Folder

        Private Sub OnCustomInitialize()

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

        Public Shared Sub Cargar_Campos_Estado_Global(FormID As String, sCodiP As String, DT_SQLX As SAPbouiCOM.DataTable)

            Dim oFormP As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(FormID)

            Dim txt As SAPbouiCOM.EditText
            Dim txt2 As SAPbouiCOM.EditText

            'Variables para el calculo de Dias
            Dim dFecVenta As Date
            Dim dFecEntreg As Date
            Dim dFecFinDes As Date
            Dim dFecFinPro As Date
            Dim dFecIniDes As Date
            Dim dFecIniMon As Date
            Dim dFecFinMon As Date

            'Variables fechas Reales para Tipear
            Dim dFecRealFinDesa As String
            Dim dFecRealIniMont As String
            Dim dFecReaFinMont As String

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
                        'txt.Item.Enabled = True
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
                        txt = oFormP.Items.Item("Item_22").Specific
                        txt.Value = DT_SQLX.GetValue("U_Nro_OC_Cliente", 0)
                        txt = oFormP.Items.Item("Item_43").Specific
                        txt.Value = DT_SQLX.GetValue("U_Contrato_Cli", 0)
                        txt = oFormP.Items.Item("Item_33").Specific
                        txt.Value = DT_SQLX.GetValue("U_Monto_OCC", 0)
                        txt = oFormP.Items.Item("Item_53").Specific
                        txt.Value = DT_SQLX.GetValue("U_Monto_OCCE", 0)
                        txt = oFormP.Items.Item("Item_57").Specific
                        txt.Value = DT_SQLX.GetValue("U_Prj_Code_Ini", 0)

                        'Condiciones de Pago
                        oComboBox = oFormP.Items.Item("Item_210").Specific
                        oComboBox.Select(DT_SQLX.GetValue("U_Condicion_Pago", 0), SAPbouiCOM.BoSearchKey.psk_ByDescription)
                        'Medio de Pago
                        oComboBox = oFormP.Items.Item("Item_211").Specific
                        oComboBox.Select(DT_SQLX.GetValue("U_Medio_Pago", 0), SAPbouiCOM.BoSearchKey.psk_ByDescription)
                        'Porcentaje Anticipo
                        oFormP.DataSources.UserDataSources.Item("UDPORC").ValueEx = DT_SQLX.GetValue("U_Porc_Anticipo", 0)
                        'Dias Pago
                        oFormP.DataSources.UserDataSources.Item("UDDIASP").ValueEx = DT_SQLX.GetValue("U_Dias_Pago", 0)
                        'Option Button Desarrollo
                        oFormP.DataSources.UserDataSources.Item("OptBnt3").ValueEx = IIf(DT_SQLX.GetValue("U_Contrato_Constru", 0).ToString.Trim = "Y", "1", "2")
                        'Option Button Tipo Proyecto
                        oFormP.DataSources.UserDataSources.Item("OptBnt4").ValueEx = IIf(DT_SQLX.GetValue("U_Tipo_Pryecto", 0).ToString.Trim = "U", "1", "2")

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



                    End If

                Catch ex As Exception
                Finally
                    oFormP.Freeze(False)  'Se Descongela el Form luego de Actualizar u Ocurrir alguna excepcion
                End Try

            Catch ex As Exception

                Application.SBO_Application.MessageBox(sql)
                Application.SBO_Application.MessageBox(ex.Message)

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
        Private WithEvents EditText24 As SAPbouiCOM.EditText
        Private WithEvents EditText25 As SAPbouiCOM.EditText
    End Class
End Namespace
