
Option Strict Off
Option Explicit On

Imports SAPbouiCOM.Framework

Namespace SBOAddonProject1
    <FormAttribute("SBOAddonProject1.NewForm_3_b1f", "3_Presentation_Layer/Pantallas Secundarias/FrmGestionFecha 3.b1f")>
    Friend Class NewForm_3_b1f
        Inherits UserFormBase


        Public Sub New()
        End Sub

#Region "Respaldo de OnInitializeComponent"
        'Me.EditText1 = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.EditText)
        '    Me.Button0 = CType(Me.GetItem("Item_81").Specific, SAPbouiCOM.Button)
        '    Me.EditText2 = CType(Me.GetItem("Item_2").Specific, SAPbouiCOM.EditText)
        '    Me.EditText3 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.EditText)
        '    Me.EditText4 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.EditText)
        '    Me.EditText5 = CType(Me.GetItem("Item_8").Specific, SAPbouiCOM.EditText)
        '    Me.EditText6 = CType(Me.GetItem("Item_10").Specific, SAPbouiCOM.EditText)
        '    Me.EditText7 = CType(Me.GetItem("Item_12").Specific, SAPbouiCOM.EditText)
        '    Me.EditText8 = CType(Me.GetItem("Item_14").Specific, SAPbouiCOM.EditText)
        '    Me.EditText9 = CType(Me.GetItem("Item_16").Specific, SAPbouiCOM.EditText)
        '    Me.EditText10 = CType(Me.GetItem("Item_18").Specific, SAPbouiCOM.EditText)
        '    Me.EditText11 = CType(Me.GetItem("Item_20").Specific, SAPbouiCOM.EditText)
        '    Me.EditText12 = CType(Me.GetItem("Item_32").Specific, SAPbouiCOM.EditText)
        '    Me.EditText13 = CType(Me.GetItem("Item_41").Specific, SAPbouiCOM.EditText)
        '    Me.EditText14 = CType(Me.GetItem("Item_53").Specific, SAPbouiCOM.EditText)
        '    Me.EditText15 = CType(Me.GetItem("Item_62").Specific, SAPbouiCOM.EditText)
        '    Me.EditText16 = CType(Me.GetItem("Item_22").Specific, SAPbouiCOM.EditText)
        '    Me.EditText17 = CType(Me.GetItem("Item_34").Specific, SAPbouiCOM.EditText)
        '    Me.EditText18 = CType(Me.GetItem("Item_43").Specific, SAPbouiCOM.EditText)
        '    Me.EditText19 = CType(Me.GetItem("Item_55").Specific, SAPbouiCOM.EditText)
        '    Me.EditText20 = CType(Me.GetItem("Item_63").Specific, SAPbouiCOM.EditText)
        '    Me.EditText21 = CType(Me.GetItem("Item_23").Specific, SAPbouiCOM.EditText)
        '    Me.EditText22 = CType(Me.GetItem("Item_36").Specific, SAPbouiCOM.EditText)
        '    Me.EditText23 = CType(Me.GetItem("Item_44").Specific, SAPbouiCOM.EditText)
        '    Me.EditText24 = CType(Me.GetItem("Item_57").Specific, SAPbouiCOM.EditText)
        '    Me.EditText25 = CType(Me.GetItem("Item_64").Specific, SAPbouiCOM.EditText)
        '    Me.EditText26 = CType(Me.GetItem("Item_24").Specific, SAPbouiCOM.EditText)
        '    Me.EditText27 = CType(Me.GetItem("Item_38").Specific, SAPbouiCOM.EditText)
        '    Me.EditText28 = CType(Me.GetItem("Item_45").Specific, SAPbouiCOM.EditText)
        '    Me.EditText29 = CType(Me.GetItem("Item_59").Specific, SAPbouiCOM.EditText)
        '    Me.EditText30 = CType(Me.GetItem("Item_65").Specific, SAPbouiCOM.EditText)
        '    Me.EditText31 = CType(Me.GetItem("Item_29").Specific, SAPbouiCOM.EditText)
        '    Me.EditText32 = CType(Me.GetItem("Item_40").Specific, SAPbouiCOM.EditText)
        '    Me.EditText33 = CType(Me.GetItem("Item_77").Specific, SAPbouiCOM.EditText)
        '    Me.EditText34 = CType(Me.GetItem("Item_50").Specific, SAPbouiCOM.EditText)
        '    Me.EditText35 = CType(Me.GetItem("Item_61").Specific, SAPbouiCOM.EditText)
        '    Me.EditText36 = CType(Me.GetItem("Item_66").Specific, SAPbouiCOM.EditText)
        '    Me.EditText37 = CType(Me.GetItem("Item_76").Specific, SAPbouiCOM.EditText)
        '    Me.EditText38 = CType(Me.GetItem("Item_86").Specific, SAPbouiCOM.EditText)
        '    Me.Button1 = CType(Me.GetItem("Item_67").Specific, SAPbouiCOM.Button)
        '    Me.Button2 = CType(Me.GetItem("Item_69").Specific, SAPbouiCOM.Button)
        '    Me.Button3 = CType(Me.GetItem("Item_70").Specific, SAPbouiCOM.Button)
        '    Me.Button4 = CType(Me.GetItem("Item_71").Specific, SAPbouiCOM.Button)
        '    Me.Button5 = CType(Me.GetItem("Item_72").Specific, SAPbouiCOM.Button)
        '    Me.Button6 = CType(Me.GetItem("Item_83").Specific, SAPbouiCOM.Button)
        '    Me.EditText0 = CType(Me.GetItem("Item_42").Specific, SAPbouiCOM.EditText)
        '    Me.StaticText0 = CType(Me.GetItem("Item_46").Specific, SAPbouiCOM.StaticText)
        '    Me.EditText39 = CType(Me.GetItem("Item_47").Specific, SAPbouiCOM.EditText)
        '    Me.EditText40 = CType(Me.GetItem("Item_48").Specific, SAPbouiCOM.EditText)
        '    Me.EditText41 = CType(Me.GetItem("Item_49").Specific, SAPbouiCOM.EditText)
        '    Me.EditText42 = CType(Me.GetItem("Item_68").Specific, SAPbouiCOM.EditText)
        '    Me.EditText43 = CType(Me.GetItem("Item_84").Specific, SAPbouiCOM.EditText)
        '    Me.EditText44 = CType(Me.GetItem("Item_87").Specific, SAPbouiCOM.EditText)
        '    Me.EditText45 = CType(Me.GetItem("Item_88").Specific, SAPbouiCOM.EditText)
        '    Me.EditText46 = CType(Me.GetItem("Item_89").Specific, SAPbouiCOM.EditText)
        '    Me.StaticText1 = CType(Me.GetItem("Item_90").Specific, SAPbouiCOM.StaticText)
        '    Me.StaticText2 = CType(Me.GetItem("Item_91").Specific, SAPbouiCOM.StaticText)
        '    Me.EditText47 = CType(Me.GetItem("Item_92").Specific, SAPbouiCOM.EditText)
        '    Me.StaticText3 = CType(Me.GetItem("Item_93").Specific, SAPbouiCOM.StaticText)
        '    Me.EditText48 = CType(Me.GetItem("Item_94").Specific, SAPbouiCOM.EditText)
        '    Me.StaticText4 = CType(Me.GetItem("Item_95").Specific, SAPbouiCOM.StaticText)
        '    Me.EditText49 = CType(Me.GetItem("Item_96").Specific, SAPbouiCOM.EditText)
        '    Me.StaticText5 = CType(Me.GetItem("Item_97").Specific, SAPbouiCOM.StaticText)
        '    Me.EditText50 = CType(Me.GetItem("Item_98").Specific, SAPbouiCOM.EditText)
        '    Me.StaticText6 = CType(Me.GetItem("Item_99").Specific, SAPbouiCOM.StaticText)
        '    Me.EditText51 = CType(Me.GetItem("Item_100").Specific, SAPbouiCOM.EditText)
        '    Me.StaticText7 = CType(Me.GetItem("Item_101").Specific, SAPbouiCOM.StaticText)
        '    Me.Folder0 = CType(Me.GetItem("Item_103").Specific, SAPbouiCOM.Folder)
        '    Me.EditText52 = CType(Me.GetItem("Item_104").Specific, SAPbouiCOM.EditText)
        '    Me.StaticText8 = CType(Me.GetItem("Item_105").Specific, SAPbouiCOM.StaticText)
        '    Me.StaticText9 = CType(Me.GetItem("Item_106").Specific, SAPbouiCOM.StaticText)
        '    Me.EditText53 = CType(Me.GetItem("Item_107").Specific, SAPbouiCOM.EditText)
        '    Me.StaticText10 = CType(Me.GetItem("Item_108").Specific, SAPbouiCOM.StaticText)
        '    Me.Button7 = CType(Me.GetItem("Item_109").Specific, SAPbouiCOM.Button)
#End Region

        Public Overrides Sub OnInitializeComponent()
            Me.EditText1 = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.EditText)
            Me.Button0 = CType(Me.GetItem("Item_81").Specific, SAPbouiCOM.Button)
            Me.EditText2 = CType(Me.GetItem("Item_2").Specific, SAPbouiCOM.EditText)
            Me.EditText3 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.EditText)
            Me.EditText4 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.EditText)
            Me.EditText5 = CType(Me.GetItem("Item_8").Specific, SAPbouiCOM.EditText)
            Me.EditText6 = CType(Me.GetItem("Item_10").Specific, SAPbouiCOM.EditText)
            Me.EditText7 = CType(Me.GetItem("Item_12").Specific, SAPbouiCOM.EditText)
            Me.EditText8 = CType(Me.GetItem("Item_14").Specific, SAPbouiCOM.EditText)
            Me.EditText9 = CType(Me.GetItem("Item_16").Specific, SAPbouiCOM.EditText)
            Me.EditText10 = CType(Me.GetItem("Item_18").Specific, SAPbouiCOM.EditText)
            Me.EditText11 = CType(Me.GetItem("Item_20").Specific, SAPbouiCOM.EditText)
            Me.EditText12 = CType(Me.GetItem("Item_32").Specific, SAPbouiCOM.EditText)
            Me.EditText13 = CType(Me.GetItem("Item_41").Specific, SAPbouiCOM.EditText)
            Me.EditText14 = CType(Me.GetItem("Item_53").Specific, SAPbouiCOM.EditText)
            Me.EditText15 = CType(Me.GetItem("Item_62").Specific, SAPbouiCOM.EditText)
            Me.EditText16 = CType(Me.GetItem("Item_22").Specific, SAPbouiCOM.EditText)
            Me.EditText17 = CType(Me.GetItem("Item_34").Specific, SAPbouiCOM.EditText)
            Me.EditText18 = CType(Me.GetItem("Item_43").Specific, SAPbouiCOM.EditText)
            Me.EditText19 = CType(Me.GetItem("Item_55").Specific, SAPbouiCOM.EditText)
            Me.EditText20 = CType(Me.GetItem("Item_63").Specific, SAPbouiCOM.EditText)
            Me.EditText21 = CType(Me.GetItem("Item_23").Specific, SAPbouiCOM.EditText)
            Me.EditText22 = CType(Me.GetItem("Item_36").Specific, SAPbouiCOM.EditText)
            Me.EditText23 = CType(Me.GetItem("Item_44").Specific, SAPbouiCOM.EditText)
            Me.EditText24 = CType(Me.GetItem("Item_57").Specific, SAPbouiCOM.EditText)
            Me.EditText25 = CType(Me.GetItem("Item_64").Specific, SAPbouiCOM.EditText)
            Me.EditText26 = CType(Me.GetItem("Item_24").Specific, SAPbouiCOM.EditText)
            Me.EditText27 = CType(Me.GetItem("Item_38").Specific, SAPbouiCOM.EditText)
            Me.EditText28 = CType(Me.GetItem("Item_45").Specific, SAPbouiCOM.EditText)
            Me.EditText29 = CType(Me.GetItem("Item_59").Specific, SAPbouiCOM.EditText)
            Me.EditText30 = CType(Me.GetItem("Item_65").Specific, SAPbouiCOM.EditText)
            Me.EditText31 = CType(Me.GetItem("Item_29").Specific, SAPbouiCOM.EditText)
            Me.EditText32 = CType(Me.GetItem("Item_40").Specific, SAPbouiCOM.EditText)
            Me.EditText33 = CType(Me.GetItem("Item_77").Specific, SAPbouiCOM.EditText)
            Me.EditText34 = CType(Me.GetItem("Item_50").Specific, SAPbouiCOM.EditText)
            Me.EditText35 = CType(Me.GetItem("Item_61").Specific, SAPbouiCOM.EditText)
            Me.EditText36 = CType(Me.GetItem("Item_66").Specific, SAPbouiCOM.EditText)
            Me.EditText37 = CType(Me.GetItem("Item_76").Specific, SAPbouiCOM.EditText)
            Me.EditText38 = CType(Me.GetItem("Item_86").Specific, SAPbouiCOM.EditText)
            Me.Button1 = CType(Me.GetItem("Item_67").Specific, SAPbouiCOM.Button)
            Me.Button2 = CType(Me.GetItem("Item_69").Specific, SAPbouiCOM.Button)
            Me.Button3 = CType(Me.GetItem("Item_70").Specific, SAPbouiCOM.Button)
            Me.Button4 = CType(Me.GetItem("Item_71").Specific, SAPbouiCOM.Button)
            Me.Button5 = CType(Me.GetItem("Item_72").Specific, SAPbouiCOM.Button)
            Me.Button6 = CType(Me.GetItem("Item_83").Specific, SAPbouiCOM.Button)
            Me.EditText0 = CType(Me.GetItem("Item_42").Specific, SAPbouiCOM.EditText)
            Me.StaticText0 = CType(Me.GetItem("Item_46").Specific, SAPbouiCOM.StaticText)
            Me.EditText39 = CType(Me.GetItem("Item_47").Specific, SAPbouiCOM.EditText)
            Me.EditText40 = CType(Me.GetItem("Item_48").Specific, SAPbouiCOM.EditText)
            Me.EditText41 = CType(Me.GetItem("Item_49").Specific, SAPbouiCOM.EditText)
            Me.EditText42 = CType(Me.GetItem("Item_68").Specific, SAPbouiCOM.EditText)
            Me.EditText43 = CType(Me.GetItem("Item_84").Specific, SAPbouiCOM.EditText)
            Me.EditText44 = CType(Me.GetItem("Item_87").Specific, SAPbouiCOM.EditText)
            Me.EditText45 = CType(Me.GetItem("Item_88").Specific, SAPbouiCOM.EditText)
            Me.EditText46 = CType(Me.GetItem("Item_89").Specific, SAPbouiCOM.EditText)
            Me.StaticText1 = CType(Me.GetItem("Item_90").Specific, SAPbouiCOM.StaticText)
            Me.StaticText2 = CType(Me.GetItem("Item_91").Specific, SAPbouiCOM.StaticText)
            Me.EditText47 = CType(Me.GetItem("Item_92").Specific, SAPbouiCOM.EditText)
            Me.StaticText3 = CType(Me.GetItem("Item_93").Specific, SAPbouiCOM.StaticText)
            Me.EditText48 = CType(Me.GetItem("Item_94").Specific, SAPbouiCOM.EditText)
            Me.StaticText4 = CType(Me.GetItem("Item_95").Specific, SAPbouiCOM.StaticText)
            Me.EditText49 = CType(Me.GetItem("Item_96").Specific, SAPbouiCOM.EditText)
            Me.StaticText5 = CType(Me.GetItem("Item_97").Specific, SAPbouiCOM.StaticText)
            Me.EditText50 = CType(Me.GetItem("Item_98").Specific, SAPbouiCOM.EditText)
            Me.StaticText6 = CType(Me.GetItem("Item_99").Specific, SAPbouiCOM.StaticText)
            Me.EditText51 = CType(Me.GetItem("Item_100").Specific, SAPbouiCOM.EditText)
            Me.StaticText7 = CType(Me.GetItem("Item_101").Specific, SAPbouiCOM.StaticText)
            Me.Folder0 = CType(Me.GetItem("Item_103").Specific, SAPbouiCOM.Folder)
            Me.EditText52 = CType(Me.GetItem("Item_104").Specific, SAPbouiCOM.EditText)
            Me.StaticText8 = CType(Me.GetItem("Item_105").Specific, SAPbouiCOM.StaticText)
            Me.StaticText9 = CType(Me.GetItem("Item_106").Specific, SAPbouiCOM.StaticText)
            Me.EditText53 = CType(Me.GetItem("Item_107").Specific, SAPbouiCOM.EditText)
            Me.StaticText10 = CType(Me.GetItem("Item_108").Specific, SAPbouiCOM.StaticText)
            Me.DT_SQL = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_SQL")
            Me.CheckBox0 = CType(Me.GetItem("Item_109").Specific, SAPbouiCOM.CheckBox)
            Me.CheckBox1 = CType(Me.GetItem("Item_110").Specific, SAPbouiCOM.CheckBox)
            Me.StaticText11 = CType(Me.GetItem("Item_111").Specific, SAPbouiCOM.StaticText)
            Me.OptionBtn2 = CType(Me.GetItem("Item_115").Specific, SAPbouiCOM.OptionBtn)
            Me.OptionBtn3 = CType(Me.GetItem("Item_116").Specific, SAPbouiCOM.OptionBtn)
            Me.StaticText12 = CType(Me.GetItem("Item_112").Specific, SAPbouiCOM.StaticText)
            Me.EditText54 = CType(Me.GetItem("Item_113").Specific, SAPbouiCOM.EditText)
            Me.OnCustomInitialize()

        End Sub

        Public Overrides Sub OnInitializeFormEvents()
            AddHandler LoadAfter, AddressOf Me.Form_LoadAfter

        End Sub

        Private Sub OnCustomInitialize()
            EditText1.Value = sCodProyecto

            Me.OptionBtn2.GroupWith("Item_116")

        End Sub
        Private Sub Form_LoadAfter(pVal As SAPbouiCOM.SBOItemEventArg)
            'Throw New System.NotImplementedException()
            'Me.EditText1.Value = "PRUEBA"
            'EditText1.Value = "Prueba"
            'Application.SBO_Application.MessageBox(pVal.FormUID.ToString())
            'Application.SBO_Application.Forms.ActiveForm.DataSources.UserDataSources.Add("UDDate2", SAPbouiCOM.BoDataType.dt_DATE, 10)
            'oItem = Application.SBO_Application.Forms.ActiveForm.Items.Add("txtDate", SAPbouiCOM.BoFormItemTypes.it_EDIT)
            'oItem.Top = 178
            'oItem.Left = 646
            'oItem.Height = 80
            'oItem.FromPane = 0
            'oItem.ToPane = 0
            'oedit = oItem.Specific
            ''bind the text edit item to the defined used data source
            'oedit.DataBind.SetBound(True, "", "UDDate2")

        End Sub



        Private Sub Button1_ClickBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles Button1.ClickBefore

            oFunciones.Abre_Dialogo_y_Asigna_Path(Me.EditText15)

        End Sub

        Private Sub Button2_ClickBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles Button2.ClickBefore

            oFunciones.Abre_Dialogo_y_Asigna_Path(Me.EditText20)

        End Sub

        Private Sub Button3_ClickBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles Button3.ClickBefore

            oFunciones.Abre_Dialogo_y_Asigna_Path(Me.EditText25)

        End Sub

        Private Sub Button4_ClickBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles Button4.ClickBefore

            oFunciones.Abre_Dialogo_y_Asigna_Path(Me.EditText30)

        End Sub

        Private Sub Button5_ClickBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles Button5.ClickBefore

            oFunciones.Abre_Dialogo_y_Asigna_Path(Me.EditText36)

        End Sub


        Private Sub Button0_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button0.ClickAfter

            Dim Validador As Boolean = False

            ' Se ocupan los campos con fechas vacias con la fecha actual correspondiente
            Llenar_Fechas_Vacias(sboObject, pVal)
            Me.EditText41.Active = True

            If Validar_Campos_Requeridos() Then

                If Application.SBO_Application.MessageBox("Actualizar las Fechas en Todos los Documentos relacionados al Proyecto", 2, "Actualizar", "Cancelar") = 1 Then

                    '------------------------------------------------------------------------------------
                    ' Registro de Nuevas Fechas en la tabla de Historicos (@ZHFPM)
                    '------------------------------------------------------------------------------------
                    'Copia los archivos Anexos a la carpeta del servidor y cambia la ruta en los Edit
                    Try
                        oFunciones.Copiar_Documentos_Anexos_a_Servidor(Me.EditText15)
                        oFunciones.Copiar_Documentos_Anexos_a_Servidor(Me.EditText20)
                        oFunciones.Copiar_Documentos_Anexos_a_Servidor(Me.EditText25)
                        oFunciones.Copiar_Documentos_Anexos_a_Servidor(Me.EditText30)
                        oFunciones.Copiar_Documentos_Anexos_a_Servidor(Me.EditText36)
                    Catch ex As Exception

                    End Try


                    Dim sql As String ' Registro de Nuevas Fechas en la tabla de Historicos (@ZHFPM)
                    sql = " INSERT INTO [" + sBDComercial.Trim() + "].[dbo].[@ZHFPM] " & _
                          " ([Code],[Name]" & _
                          ",[U_PrjCode],[U_Fecha_Registro]" & _
                          ",[U_Hora_Registro2],[U_Fecha_Venta],[U_Fecha_Promet_Ant]" & _
                          ",[U_Fecha_Promet_Nvo] ,[U_Ter_Desar_Ant],[U_Ter_Desar_Nvo]" & _
                          ",[U_Ter_Prod_Ant],[U_Ter_Prod_Nvo],[U_Ter_Desp_Ant]" & _
                          ",[U_Ter_Desp_Nvo],[U_Ini_Mont_Ant],[U_Ini_Mont_Nvo]" & _
                          ",[U_Ter_Mont_Ant],[U_Ter_Mont_Nvo],[U_Cod_Usuario] " & _
                          ",[U_Nom_Usuario],[U_Doc_Ter_Desa],[U_Doc_Ter_Prod] " & _
                          ",[U_Doc_Ini_Despa],[U_Doc_Ini_Monta],[U_Doc_Term_Monta],[U_Comentario])" & _
                          " VALUES " & _
                          " ('" + Proximo_Codigo_ZHFPM().ToString() + "','" + oFunciones.Nombre_Usuario_Actual() + " " + DateTime.Now.ToLongTimeString + "'" & _
                          ",'" + Me.EditText1.Value.Trim() + "' , convert(datetime,'" + DateTime.Now.ToString() + "',103)" & _
                          ",'" + DateTime.Now.ToLongTimeString + "' ,convert(date,'" + Me.EditText5.Value.Trim() + "',103), convert(date,'" + Me.EditText6.Value.Trim() + "',103)" & _
                          ",convert(date,'" + Me.EditText9.Value.Trim() + "',103),convert(date,'" + Me.EditText13.Value.Trim() + "',103),convert(date,'" + Me.EditText42.Value.Trim() + "',103)" & _
                          ",convert(date,'" + Me.EditText18.Value.Trim() + "',103),convert(date,'" + Me.EditText43.Value.Trim() + "',103),convert(date,'" + Me.EditText23.Value.Trim() + "',103)" & _
                          ",convert(date,'" + Me.EditText44.Value.Trim() + "',103),convert(date,'" + Me.EditText28.Value.Trim() + "',103),convert(date,'" + Me.EditText45.Value.Trim() + "',103)" & _
                          ",convert(date,'" + Me.EditText34.Value.Trim() + "',103),convert(date,'" + Me.EditText46.Value.Trim() + "',103), '" + oConectarAplicacion.sCodUsuActual + "'" & _
                          ",'" + Me.EditText38.Value.Trim() + "','" + Me.EditText15.Value.Trim() + "','" + Me.EditText20.Value.Trim() + "' " & _
                          ",'" + Me.EditText25.Value.Trim() + "','" + Me.EditText30.Value.Trim() + "','" + Me.EditText36.Value.Trim() + "','" + Me.EditText41.Value.Trim() + "'  ) "

                    Try

                        'Dim UpdateRec As SAPbobsCOM.Recordset
                        'UpdateRec = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
                        'UpdateRec.DoQuery(sql)
                        DT_SQL.ExecuteQuery(sql)
                        Validador = True

                    Catch ex As Exception

                        Application.SBO_Application.MessageBox(sql)
                        Me.EditText41.Value = sql
                        Application.SBO_Application.MessageBox(ex.Message)
                        Validador = False

                    End Try

                    '------------------------------------------------------------------------------------
                    ' Cargar un Array con los Nombres de todas las Tablas a Modificar
                    '------------------------------------------------------------------------------------

                    Dim Tablas_Update = {"OQUT", "ORDR", "ODLN", "OINV", "ORIN", "OPRQ", "OPQT", "OPOR", "OPCH", "ORPC"}
                    Dim Tabla_Ventas = {"OQUT", "ORDR", "ODLN", "OINV", "ORIN"}

                    '------------------------------------------------------------------------------------
                    ' Update de los Documentos Relacionados al Proyecto en Comercial
                    '------------------------------------------------------------------------------------

                    ' UPDATE DE LOS DOCUMENTOS TIPO PRELIMINAR, SI ES ORDR SOLO ACTUALIZA LAS PCV
                    sql = " UPDATE [" + sBDComercial.Trim() + "].[dbo].[ODRF] " & _
                              " SET DocDueDate = convert(date,'" + Me.EditText44.Value.Trim() + "',103)" & _
                              " ,U_MIN_FinDesarr = convert(date,'" + Me.EditText42.Value.Trim() + "',103) " & _
                              " ,U_MIN_FinProduccion = convert(date,'" + Me.EditText43.Value.Trim() + "',103) " & _
                              " ,U_MIN_IniDespacho = convert(date,'" + Me.EditText44.Value.Trim() + "',103) " & _
                              " ,U_MIN_IniMontaje = convert(date,'" + Me.EditText45.Value.Trim() + "',103) " & _
                              " ,U_MIN_FinMontaje = convert(date,'" + Me.EditText46.Value.Trim() + "',103)  " & _
                              " WHERE Project = '" + Me.EditText1.Value.Trim() + "' AND  Series BETWEEN IIF( ObjType = 17 , 27 , 0) AND IIF( ObjType = 17 , 27 , 999999999999999999999)"
                    Try
                        DT_SQL.ExecuteQuery(sql)
                        Validador = True
                    Catch ex As Exception
                        Validador = False
                    End Try

                    For index = 0 To Tablas_Update.GetUpperBound(0)     'Aca se ejecuta el FOR recorriendo el arreglo con todas las tablas a Modificar.

                        If Tabla_Ventas.Contains(Tablas_Update(index)) Then

                            sql = " UPDATE [" + sBDComercial.Trim() + "].[dbo].[" + Tablas_Update(index) + "] " & _
                              " SET DocDueDate = convert(date,'" + Me.EditText44.Value.Trim() + "',103)" & _
                              " ,U_MIN_FinDesarr = convert(date,'" + Me.EditText42.Value.Trim() + "',103) " & _
                              " ,U_MIN_FinProduccion = convert(date,'" + Me.EditText43.Value.Trim() + "',103) " & _
                              " ,U_MIN_IniDespacho = convert(date,'" + Me.EditText44.Value.Trim() + "',103) " & _
                              " ,U_MIN_IniMontaje = convert(date,'" + Me.EditText45.Value.Trim() + "',103) " & _
                              " ,U_MIN_FinMontaje = convert(date,'" + Me.EditText46.Value.Trim() + "',103)  " & _
                              " WHERE Project = '" + Me.EditText1.Value.Trim() + "'" + If(Tablas_Update(index) = "ORDR", " AND Series = 27 ", "")

                        Else 'Tabla de Compras

                            sql = " UPDATE [" + sBDComercial.Trim() + "].[dbo].[" + Tablas_Update(index) + "] " & _
                              " SET DocDueDate = IIF(CardCode ='P83073600',convert(date,'" + Me.EditText43.Value.Trim() + "',103),  IIF(CardCode ='P76033420', convert(date,'" + Me.EditText46.Value.Trim() + "',103), DocDueDate))" & _
                              " ,U_MIN_FinDesarr = convert(date,'" + Me.EditText42.Value.Trim() + "',103) " & _
                              " ,U_MIN_FinProduccion = convert(date,'" + Me.EditText43.Value.Trim() + "',103) " & _
                              " ,U_MIN_IniDespacho = convert(date,'" + Me.EditText44.Value.Trim() + "',103) " & _
                              " ,U_MIN_IniMontaje = convert(date,'" + Me.EditText45.Value.Trim() + "',103) " & _
                              " ,U_MIN_FinMontaje = convert(date,'" + Me.EditText46.Value.Trim() + "',103)  " & _
                              " WHERE Project = '" + Me.EditText1.Value.Trim() + "'"

                        End If



                        Try

                            DT_SQL.ExecuteQuery(sql)
                            Validador = True

                        Catch ex As Exception

                            Application.SBO_Application.MessageBox(sql)
                            Me.EditText41.Value = sql
                            Application.SBO_Application.MessageBox(ex.Message)
                            Validador = False

                        End Try

                    Next

                    '------------------------------------------------------------------------------------
                    ' Update de los Documentos Relacionados al Proyecto en Industrial
                    '------------------------------------------------------------------------------------
                    For index = 0 To Tablas_Update.GetUpperBound(0)   'Aca se ejecuta el FOR recorriendo el arreglo con todas las tablas a Modificar.

                        If Tablas_Update(index) = "ORDR" Or Tablas_Update(index) = "OQUT" Then

                            sql = " UPDATE [" + sBDIndustrial.Trim() + "].[dbo].[" + Tablas_Update(index) + "] " & _
                              " SET DocDueDate = IIF(CardCode ='C96588890',convert(date,'" + Me.EditText43.Value.Trim() + "',103),DocDueDate) " & _
                              " ,U_MIN_FinDesarr = convert(date,'" + Me.EditText42.Value.Trim() + "',103) " & _
                              " ,U_MIN_FinProduccion = convert(date,'" + Me.EditText43.Value.Trim() + "',103) " & _
                              " ,U_MIN_IniDespacho = convert(date,'" + Me.EditText44.Value.Trim() + "',103) " & _
                              " ,U_MIN_IniMontaje = convert(date,'" + Me.EditText45.Value.Trim() + "',103) " & _
                              " ,U_MIN_FinMontaje = convert(date,'" + Me.EditText46.Value.Trim() + "',103)  " & _
                              " WHERE Project = '" + Me.EditText1.Value.Trim() + "'" + If(Tablas_Update(index) = "ORDR", " AND Series = 27 ", "")

                        Else

                            sql = " UPDATE [" + sBDIndustrial.Trim() + "].[dbo].[" + Tablas_Update(index) + "] " & _
                              " SET U_MIN_FinDesarr = convert(date,'" + Me.EditText42.Value.Trim() + "',103) " & _
                              " ,U_MIN_FinProduccion = convert(date,'" + Me.EditText43.Value.Trim() + "',103) " & _
                              " ,U_MIN_IniDespacho = convert(date,'" + Me.EditText44.Value.Trim() + "',103) " & _
                              " ,U_MIN_IniMontaje = convert(date,'" + Me.EditText45.Value.Trim() + "',103) " & _
                              " ,U_MIN_FinMontaje = convert(date,'" + Me.EditText46.Value.Trim() + "',103)  " & _
                              " WHERE Project = '" + Me.EditText1.Value.Trim() + "'"

                        End If

                        Try

                            DT_SQL.ExecuteQuery(sql)
                            Validador = True

                        Catch ex As Exception

                            Application.SBO_Application.MessageBox(sql)
                            Me.EditText41.Value = sql
                            Application.SBO_Application.MessageBox(ex.Message)
                            Validador = False

                        End Try

                    Next

                    '------------------------------------------------------------------------------------
                    ' Update de los Documentos Relacionados al Proyecto en Montaje
                    '------------------------------------------------------------------------------------
                    For index = 0 To Tablas_Update.GetUpperBound(0)    'Aca se ejecuta el FOR recorriendo el arreglo con todas las tablas a Modificar.

                        If Tablas_Update(index) = "ORDR" Or Tablas_Update(index) = "OQUT" Then


                            sql = " UPDATE [" + sBDMontaje.Trim() + "].[dbo].[" + Tablas_Update(index) + "] " & _
                          " SET DocDueDate = IIF(CardCode ='C96588890' ,convert(date,'" + Me.EditText46.Value.Trim() + "',103),DocDueDate)" & _
                          " ,U_MIN_FinDesarr = convert(date,'" + Me.EditText42.Value.Trim() + "',103) " & _
                          " ,U_MIN_FinProduccion = convert(date,'" + Me.EditText43.Value.Trim() + "',103) " & _
                          " ,U_MIN_IniDespacho = convert(date,'" + Me.EditText44.Value.Trim() + "',103) " & _
                          " ,U_MIN_IniMontaje = convert(date,'" + Me.EditText45.Value.Trim() + "',103) " & _
                          " ,U_MIN_FinMontaje = convert(date,'" + Me.EditText46.Value.Trim() + "',103)  " & _
                          " WHERE Project = '" + Me.EditText1.Value.Trim() + "'" + If(Tablas_Update(index) = "ORDR", " AND Series = 27 ", "")



                        Else

                            sql = " UPDATE [" + sBDMontaje.Trim() + "].[dbo].[" + Tablas_Update(index) + "] " & _
                              " SET U_MIN_FinDesarr = convert(date,'" + Me.EditText42.Value.Trim() + "',103) " & _
                              " ,U_MIN_FinProduccion = convert(date,'" + Me.EditText43.Value.Trim() + "',103) " & _
                              " ,U_MIN_IniDespacho = convert(date,'" + Me.EditText44.Value.Trim() + "',103) " & _
                              " ,U_MIN_IniMontaje = convert(date,'" + Me.EditText45.Value.Trim() + "',103) " & _
                              " ,U_MIN_FinMontaje = convert(date,'" + Me.EditText46.Value.Trim() + "',103)  " & _
                              " WHERE Project = '" + Me.EditText1.Value.Trim() + "'"

                        End If


                        Try

                            DT_SQL.ExecuteQuery(sql)
                            Validador = True

                        Catch ex As Exception

                            Application.SBO_Application.MessageBox(sql)
                            Me.EditText41.Value = sql
                            Application.SBO_Application.MessageBox(ex.Message)
                            Validador = False

                        End Try

                    Next

                    If Validador Then

                        Application.SBO_Application.MessageBox("Actualizacion de Fechas Exitosa")
                        Cargar_Campos_Form_Principal(pVal)
                        Application.SBO_Application.Forms.Item(pVal.FormUID).Close()

                    End If

                End If

            End If

        End Sub

        Private Sub Button0_ClickBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles Button0.ClickBefore
            Me.EditText41.Active = True 'Coloca el foco fuera de cualquier campo fecha editable para que se calculen los dias antes de Modificar
        End Sub



        Private Sub Button6_ClickBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles Button6.ClickBefore

            'Asignamos la Consulta antes de llamar al Form
            sPSql = (" select convert(char(10),U_Fecha_Registro,103)  as Fecha,U_Hora_Registro2 as hora, convert(char(10),U_Fecha_Venta,103) as Venta, " & _
                                   " convert(char(10),U_Fecha_Promet_Nvo,103) as Prometida,convert(char(10),U_Ter_Desar_Nvo ,103) as Ter_desarr,convert(char(10),U_Ter_Desar_Nvo ,103) as Ter_Prod, " & _
                                   " convert(char(10),U_Ter_Desp_Nvo ,103) as Ini_Desp, convert(char(10),U_Ini_Mont_Nvo,103) as Ini_Mont, convert(char(10),U_Ter_Mont_Nvo ,103) as Ter_Mont, " & _
                                   " U_Nom_Usuario as usuario,[U_Doc_Ter_Desa],[U_Doc_Ter_Prod],[U_Doc_Ini_Despa],[U_Doc_Ini_Monta],[U_Doc_Term_Monta],isnull(U_Comentario,'')  as comentario " & _
                                   " from [" + sBDComercial.Trim() + "].[dbo].[@ZHFPM]  " & _
                                   " where U_PrjCode = '" + Me.EditText1.Value.ToString() + "'" & _
                                   " order by U_Fecha_Registro ")

            Dim Formp2 As Form10
            Formp2 = New Form10

            Dim oUDS As SAPbouiCOM.UserDataSource = Formp2.UIAPIRawForm.DataSources.UserDataSources.Item("UD_0")
            oUDS.ValueEx = Me.UIAPIRawForm.UniqueID   'Aca asignamos el FormUID de Formulario al Valor del  User Data Source

            oUDS = Formp2.UIAPIRawForm.DataSources.UserDataSources.Item("UD_1")
            oUDS.ValueEx = EditText1.Value.ToString()   'Aca asignamos el Codigo del Proyecto al User Data Source

            Dim oForm As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(Formp2.UIAPIRawForm.UniqueID)
            Dim txt As SAPbouiCOM.EditText

            'Asignar Encabezado
            txt = oForm.Items.Item("Item_1").Specific
            txt.Value = EditText1.Value.ToString()
            sCodProyecto = EditText1.Value.ToString()
            txt = oForm.Items.Item("Item_5").Specific
            txt.Value = EditText3.Value.ToString()
            txt = oForm.Items.Item("Item_3").Specific
            txt.Value = EditText2.Value.ToString()

            'Dim DT As SAPbouiCOM.DataTable = Formp2.UIAPIRawForm.DataSources.DataTables.Item("DT_1")
            'Dim query As String = (" select convert(char(10),U_Fecha_Registro,103)  as Fecha,U_Hora_Registro2 as hora, convert(char(10),U_Fecha_Venta,103) as Venta, " & _
            '                       " convert(char(10),U_Fecha_Promet_Nvo,103) as Prometida,convert(char(10),U_Ter_Desar_Nvo ,103) as Ter_desarr,convert(char(10),U_Ter_Desar_Nvo ,103) as Ter_Prod, " & _
            '                       " convert(char(10),U_Ter_Desp_Nvo ,103) as Ini_Desp, convert(char(10),U_Ini_Mont_Nvo,103) as Ini_Mont, convert(char(10),U_Ter_Mont_Nvo ,103) as Ter_Mont, " & _
            '                       " U_Nom_Usuario as usuario " & _
            '                       " from [" + sBDComercial.Trim() + "].[dbo].[@ZHFPM]  " & _
            '                       " where U_PrjCode = '" + Me.EditText0.Value.Trim() + "'" & _
            '                       " order by U_Fecha_Registro ")
            'DT.ExecuteQuery(query)

            'oMatrix = oForm.Items.Item("Item_0").Specific
            'oMatrix.Columns.Item("Col_0").DataBind.Bind("DT_1", "Fecha")
            'oMatrix.Columns.Item("Col_1").DataBind.Bind("DT_1", "hora")
            'oMatrix.Columns.Item("Col_2").DataBind.Bind("DT_1", "Venta")
            'oMatrix.Columns.Item("Col_3").DataBind.Bind("DT_1", "Prometida")
            'oMatrix.Columns.Item("Col_4").DataBind.Bind("DT_1", "Ter_desarr")
            'oMatrix.Columns.Item("Col_5").DataBind.Bind("DT_1", "Ter_Prod")
            'oMatrix.Columns.Item("Col_6").DataBind.Bind("DT_1", "Ini_Desp")
            'oMatrix.Columns.Item("Col_7").DataBind.Bind("DT_1", "Ini_Mont")
            'oMatrix.Columns.Item("Col_8").DataBind.Bind("DT_1", "Ter_Mont")
            'oMatrix.Columns.Item("Col_9").DataBind.Bind("DT_1", "usuario")

            'oMatrix.Clear()
            'oMatrix.LoadFromDataSource()
            'oMatrix.AutoResizeColumns()

            Formp2.Show()

            '---------------------------------------------------------------------------------------------------------------------------
            'Conectar_Aplicacion()
            'Application.SBO_Application.ActivateMenuItem("402-U-R")

            'Application.SBO_Application.OpenForm(149, "", oCompany.GetNewObjectKey)

            'Application.SBO_Application.OpenForm(SAPbouiCOM.BoFormObjectEnum.fo_ProjectCodes, "", oCompany.GetNewObjectKey)

            'Application.SBO_Application.OpenForm(SAPbouiCOM.BoFormObjectEnum.fo_UserDefinedObject, "", oCompany.GetNewObjectKey)

            'Application.SBO_Application.OpenForm(11018, "ZHFPM", oCompany.GetNewObjectKey)

            'muc_GoodsIssue = Me.muc_ParentAddOn.SBO_UserFormsCollection.Item(Me.SBO_Application.Forms.ActiveForm.UniqueID)

        End Sub

        Private Sub EditText42_LostFocusAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText42.LostFocusAfter

            oFunciones.Valida_Fecha_Calcula_Dias(Me.EditText42, Me.EditText5, Me.EditText47)
            Totaliza_Nuevos_Dias()

        End Sub

        Private Sub EditText43_LostFocusAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText43.LostFocusAfter

            If Me.EditText42.Value.Trim().Length() > 0 Then
                oFunciones.Valida_Fecha_Calcula_Dias(Me.EditText43, Me.EditText42, Me.EditText48)
            Else
                oFunciones.Valida_Fecha_Calcula_Dias(Me.EditText43, Me.EditText13, Me.EditText48)
            End If
            Totaliza_Nuevos_Dias()

        End Sub

        Private Sub EditText44_LostFocusAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText44.LostFocusAfter

            If Me.EditText43.Value.Trim().Length() > 0 Then
                oFunciones.Valida_Fecha_Calcula_Dias(Me.EditText44, Me.EditText43, Me.EditText49)
            Else
                oFunciones.Valida_Fecha_Calcula_Dias(Me.EditText44, Me.EditText18, Me.EditText49)
            End If
            Totaliza_Nuevos_Dias()

        End Sub

        Private Sub EditText45_LostFocusAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText45.LostFocusAfter

            If Me.EditText44.Value.Trim().Length() > 0 Then
                oFunciones.Valida_Fecha_Calcula_Dias(Me.EditText45, Me.EditText44, Me.EditText50)
            Else
                oFunciones.Valida_Fecha_Calcula_Dias(Me.EditText45, Me.EditText23, Me.EditText50)
            End If
            Totaliza_Nuevos_Dias()

        End Sub

        Private Sub EditText46_LostFocusAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText46.LostFocusAfter

            If Me.EditText45.Value.Trim().Length() > 0 Then
                oFunciones.Valida_Fecha_Calcula_Dias(Me.EditText46, Me.EditText45, Me.EditText51)
            Else
                oFunciones.Valida_Fecha_Calcula_Dias(Me.EditText46, Me.EditText28, Me.EditText51)
            End If

            If Me.EditText9.Value.Trim().Length() > 0 Then
                oFunciones.Valida_Fecha_Calcula_Dias(Me.EditText46, Me.EditText9, Me.EditText10)
            Else
                oFunciones.Valida_Fecha_Calcula_Dias(Me.EditText46, Me.EditText53, Me.EditText10)
            End If

            Totaliza_Nuevos_Dias()

        End Sub

        Private Sub Llenar_Fechas_Vacias(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg)

            If Me.EditText9.Value.Trim.Length() = 0 Then
                Me.EditText9.String = Me.EditText53.Value
            End If

            If Me.EditText42.Value.Trim.Length() = 0 Then
                Me.EditText42.String = Me.EditText13.Value
                Me.EditText42_LostFocusAfter(sboObject, pVal)
            End If

            If Me.EditText43.Value.Trim.Length() = 0 Then
                Me.EditText43.String = Me.EditText18.Value
                Me.EditText43_LostFocusAfter(sboObject, pVal)
            End If

            If Me.EditText44.Value.Trim.Length() = 0 Then
                Me.EditText44.String = Me.EditText23.Value
                Me.EditText44_LostFocusAfter(sboObject, pVal)
            End If

            If Me.EditText45.Value.Trim.Length() = 0 Then
                Me.EditText45.String = Me.EditText28.Value
                Me.EditText45_LostFocusAfter(sboObject, pVal)
            End If

            If Me.EditText46.Value.Trim.Length() = 0 Then
                Me.EditText46.String = Me.EditText34.Value
                Me.EditText46_LostFocusAfter(sboObject, pVal)
            End If

        End Sub

        Private Function Validar_Campos_Requeridos() As Boolean

            Dim Validador As Boolean = False
            If Me.EditText42.String <> Me.EditText13.Value And Me.EditText15.Value.Trim.Length() = 0 Then
                Application.SBO_Application.MessageBox("Debe Seleccionar un Documento de Respaldo para Modificacion de la Fecha de Termino de Desarrollo")
                Me.EditText15.Active = True
                Validador = False
            ElseIf Me.EditText43.String <> Me.EditText18.Value And Me.EditText20.Value.Trim.Length() = 0 Then
                Application.SBO_Application.MessageBox("Debe Seleccionar un Documento de Respaldo para Modificacion de la Fecha de Termino de Produccion")
                Me.EditText20.Active = True
                Validador = False
            ElseIf Me.EditText44.String <> Me.EditText23.Value And Me.EditText25.Value.Trim.Length() = 0 Then
                Application.SBO_Application.MessageBox("Debe Seleccionar un Documento de Respaldo para Modificacion de la Fecha de Inicio de Despacho")
                Me.EditText25.Active = True
                Validador = False
            ElseIf Me.EditText45.String <> Me.EditText28.Value And Me.EditText30.Value.Trim.Length() = 0 Then
                Application.SBO_Application.MessageBox("Debe Seleccionar un Documento de Respaldo para Modificacion de la Fecha de Inicio de Montaje")
                Me.EditText30.Active = True
                Validador = False
            ElseIf Me.EditText46.String <> Me.EditText34.Value And Me.EditText36.Value.Trim.Length() = 0 Then
                Application.SBO_Application.MessageBox("Debe Seleccionar un Documento de Respaldo para Modificacion de la Fecha de Termino de Montaje")
                Me.EditText36.Active = True
                Validador = False
            Else
                Validador = True
            End If

            Return Validador

        End Function

        Private Sub Totaliza_Nuevos_Dias()

            'Totaliza los nuevos dias al modificar alguno
            Me.EditText33.Value = Convert.ToInt32(Me.EditText47.Value) + Convert.ToInt32(Me.EditText48.Value) +
                                  Convert.ToInt32(Me.EditText49.Value) + Convert.ToInt32(Me.EditText50.Value) +
                                  Convert.ToInt32(Me.EditText51.Value)
            Me.EditText10.Value = Me.EditText33.Value

        End Sub

        Private Sub EditText42_ValidateAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText42.ValidateAfter

            'Valida_Fecha_Calcula_Dias(Me.EditText42, Me.EditText5, Me.EditText47)

            'Dim dFecha As Date

            'If Me.EditText42.Value.Trim().Length() > 0 Then

            '    Try
            '        dFecha = DateTime.ParseExact(Me.EditText42.Value, "yyyyMMdd", Nothing).ToString("dd\/MM\/yyyy")
            '        Application.SBO_Application.MessageBox(IsDate(dFecha))
            '        'Me.EditText47.Value = Dias_Habiles(Me.EditText5.Value, dFecha)
            '        'EditValidar.Value = False
            '    Catch ex As Exception
            '        Me.EditText42.ClickPicker()
            '        Me.EditText42.Active = True
            '    End Try

            '    Try
            '        Application.SBO_Application.MessageBox(Dias_Habiles(Me.EditText5.Value, dFecha))
            '        Me.EditText47.Value = Dias_Habiles(Me.EditText5.Value, dFecha)
            '    Catch ex As Exception
            '        Application.SBO_Application.MessageBox(ex.Message)
            '    End Try

            'End If


            'Application.SBO_Application.MessageBox(Format(Convert.ToDateTime(Me.EditText42.Value), "dd/MM/yyyy"))
            'Dim dFecha As Date
            ''Application.SBO_Application.MessageBox(DateTime.ParseExact(Me.EditText42.Value, "yyyyMMdd", Nothing).ToString("dd\/MM\/yyyy"))
            ''Application.SBO_Application.MessageBox(IsDate(dFecha))


            'If Me.EditText42.Value.Trim().Length() > 0 Then

            '    Try
            '        dFecha = DateTime.ParseExact(Me.EditText42.Value, "yyyyMMdd", Nothing).ToString("dd\/MM\/yyyy")
            '        Application.SBO_Application.MessageBox(IsDate(dFecha))
            '        Application.SBO_Application.MessageBox(Dias_Habiles(Me.EditText13.Value, dFecha))
            '        Me.EditText47.Value = Dias_Habiles(Me.EditText13.Value, dFecha)
            '    Catch ex As Exception
            '        Me.EditText42.ClickPicker()
            '        Me.EditText42.Active = True
            '    End Try



            'Try
            '    Me.EditText47.Value = Dias_Habiles(DateTime.ParseExact(Me.EditText13.Value, "yyyyMMdd", Nothing).ToString("dd\/MM\/yyyy"), DateTime.ParseExact(Me.EditText42.Value, "yyyyMMdd", Nothing).ToString("dd\/MM\/yyyy"))
            'Catch ex As Exception

            'End Try


            'End If

        End Sub

        Private Sub EditText15_DoubleClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText15.DoubleClickAfter
            If Me.EditText15.Value.Trim.Length() > 0 Then
                oFunciones.Open_File(Me.EditText15.Value.Trim)
            End If
        End Sub

        Private Sub EditText20_DoubleClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText20.DoubleClickAfter
            If Me.EditText20.Value.Trim.Length() > 0 Then
                oFunciones.Open_File(Me.EditText20.Value.Trim)
            End If
        End Sub

        Private Sub EditText25_DoubleClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText25.DoubleClickAfter
            If Me.EditText25.Value.Trim.Length() > 0 Then
                oFunciones.Open_File(Me.EditText25.Value.Trim)
            End If
        End Sub

        Private Sub EditText30_DoubleClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText30.DoubleClickAfter
            If Me.EditText30.Value.Trim.Length() > 0 Then
                oFunciones.Open_File(Me.EditText30.Value.Trim)
            End If
        End Sub

        Private Sub EditText36_DoubleClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText36.DoubleClickAfter
            If Me.EditText36.Value.Trim.Length() > 0 Then
                oFunciones.Open_File(Me.EditText36.Value.Trim)
            End If
        End Sub


        Private Sub Cargar_Campos_Form_Principal(pVal As SAPbouiCOM.SBOItemEventArg)

            ' Enviar Codigo a Form Principal
            Dim oUDS As SAPbouiCOM.UserDataSource = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_0")
            Dim _x As String = oUDS.ValueEx        'Aca nos traemos el FormUID del Formulario Principal guardado en el User Data Source
            Dim oFormP As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(_x)

            Dim txt As SAPbouiCOM.EditText = oFormP.Items.Item("Item_0").Specific
            Dim txt2 As SAPbouiCOM.EditText
            txt.Value = Me.EditText1.Value
            Dim sCodiP As String = Me.EditText1.Value

            'Variables para el calculo de Dias
            Dim dFecVenta As Date
            Dim dFecEntreg As Date
            Dim dFecFinDes As Date
            Dim dFecFinPro As Date
            Dim dFecIniDes As Date
            Dim dFecIniMon As Date
            Dim dFecFinMon As Date


            '---------------------------------------------------------------------------------------------------------------------------
            'Busqueda de Modificacion de Fechas 
            '---------------------------------------------------------------------------------------------------------------------------

            Dim Sql As String
            Sql = " SELECT U_PrjCode,U_Fecha_Registro,U_Hora_Registro,U_Fecha_Venta,U_Fecha_Promet_Ant,U_Fecha_Promet_Nvo,U_Ter_Desar_Ant,U_Ter_Desar_Nvo " & _
                  " ,U_Ter_Prod_Ant,U_Ter_Prod_Nvo,U_Ter_Desp_Ant,U_Ter_Desp_Nvo,U_Ini_Mont_Ant,U_Ini_Mont_Nvo,U_Ter_Mont_Ant,U_Ter_Mont_Nvo" & _
                  " FROM " + sBDComercial.Trim() + ".dbo.[@ZHFPM]" & _
                  " where U_Fecha_Registro in (select max(U_Fecha_Registro) from " + sBDComercial.Trim() + ".dbo.[@ZHFPM] where U_PrjCode = '" + sCodiP.Trim() + "')"

            Try
                Try
                    DT_SQL.ExecuteQuery(Sql)
                Catch ex As Exception

                End Try

            Catch ex As Exception

                Application.SBO_Application.MessageBox(Sql)
                Application.SBO_Application.MessageBox(ex.Message)

            End Try

            If DT_SQL.IsEmpty = False Then
                'Existen Modificaciones, se toman las fechas del ultimo regitro (de mayor fecha)

                txt = oFormP.Items.Item("Item_106").Specific
                txt.Value = Replace(DT_SQL.GetValue("U_Fecha_Promet_Nvo", 0), "-", "/")
                txt = oFormP.Items.Item("Item_18").Specific
                txt.Value = Replace(DT_SQL.GetValue("U_Ter_Desar_Nvo", 0), "-", "/")
                txt = oFormP.Items.Item("Item_20").Specific
                txt.Value = Replace(DT_SQL.GetValue("U_Ter_Prod_Nvo", 0), "-", "/")
                txt = oFormP.Items.Item("Item_21").Specific
                txt.Value = Replace(DT_SQL.GetValue("U_Ter_Desp_Nvo", 0), "-", "/")
                txt = oFormP.Items.Item("Item_22").Specific
                txt.Value = Replace(DT_SQL.GetValue("U_Ini_Mont_Nvo", 0), "-", "/")
                txt = oFormP.Items.Item("Item_27").Specific
                txt.Value = Replace(DT_SQL.GetValue("U_Ter_Mont_Nvo", 0), "-", "/")

                dFecVenta = DT_SQL.GetValue("U_Fecha_Venta", 0)
                dFecEntreg = DT_SQL.GetValue("U_Fecha_Promet_Nvo", 0)
                dFecFinDes = DT_SQL.GetValue("U_Ter_Desar_Nvo", 0)
                dFecFinPro = DT_SQL.GetValue("U_Ter_Prod_Nvo", 0)
                dFecIniDes = DT_SQL.GetValue("U_Ter_Desp_Nvo", 0)
                dFecIniMon = DT_SQL.GetValue("U_Ini_Mont_Nvo", 0)
                dFecFinMon = DT_SQL.GetValue("U_Ter_Mont_Nvo", 0)


            End If

            'Cargar Dias reales asignados
            txt = oFormP.Items.Item("Item_50").Specific
            txt.Value = oFunciones.Dias_Habiles(dFecVenta, dFecFinDes)
            txt = oFormP.Items.Item("Item_48").Specific
            txt.Value = oFunciones.Dias_Habiles(dFecFinDes, dFecFinPro)
            txt = oFormP.Items.Item("Item_53").Specific
            txt.Value = oFunciones.Dias_Habiles(dFecFinPro, dFecIniDes)
            txt = oFormP.Items.Item("Item_55").Specific
            txt.Value = oFunciones.Dias_Habiles(dFecIniDes, dFecIniMon)
            txt = oFormP.Items.Item("Item_57").Specific
            txt.Value = oFunciones.Dias_Habiles(dFecIniMon, dFecFinMon)

            'Carga Dias Despachos
            txt = oFormP.Items.Item("Item_34").Specific
            txt.Value = oFunciones.Dias_Habiles(dFecIniDes, dFecIniMon)
            txt = oFormP.Items.Item("Item_36").Specific
            txt2 = oFormP.Items.Item("Item_32").Specific 'Ultima Guia de Despacho
            If IsDate(txt2.Value) Then
                txt.Value = oFunciones.Dias_Habiles(txt2.Value, dFecFinMon)
            Else
                txt.Value = 0
            End If


            'Carga Dias para proxima Etapa
            txt = oFormP.Items.Item("Item_59").Specific
            Dim nDias1 As Integer = oFunciones.Dias_Habiles(dFecFinDes, dFecEntreg)
            txt.Value = nDias1
            txt = oFormP.Items.Item("Item_61").Specific
            Dim nDias2 As Integer = oFunciones.Dias_Habiles(dFecFinPro, dFecEntreg)
            txt.Value = nDias2
            txt = oFormP.Items.Item("Item_63").Specific
            Dim nDias3 As Integer = oFunciones.Dias_Habiles(dFecIniDes, dFecEntreg)
            txt.Value = nDias3
            txt = oFormP.Items.Item("Item_65").Specific
            Dim nDias4 As Integer = oFunciones.Dias_Habiles(dFecIniMon, dFecEntreg)
            txt.Value = nDias4
            txt = oFormP.Items.Item("Item_67").Specific
            Dim nDias5 As Integer = oFunciones.Dias_Habiles(dFecFinMon, dFecEntreg)
            txt.Value = nDias5

            'Suma Dias
            txt = oFormP.Items.Item("Item_74").Specific
            txt.Value = nDias1 + nDias2 + nDias3 + nDias4 + nDias5


            '---------------------------------------------------------------------------------------------------------------------------
            'Calculo de Dias de Atraso en Base a Ultimas Fechas
            '---------------------------------------------------------------------------------------------------------------------------
            Dim dFecRealFinDesa As String
            Dim dFecRealIniMont As String
            Dim dFecReaFinMont As String
            'Desarrollo
            txt = oFormP.Items.Item("Item_46").Specific
            dFecRealFinDesa = txt.String
            txt = oFormP.Items.Item("Item_175").Specific
            dFecRealIniMont = txt.String
            txt = oFormP.Items.Item("Item_176").Specific
            dFecReaFinMont = txt.String

            txt = oFormP.Items.Item("Item_25").Specific
            Dim dFecCalculo As Date = If(dFecRealFinDesa.Trim.Length() = 0, Date.Now(), dFecRealFinDesa)
            Dim nAtraso As Integer = If(dFecCalculo > dFecFinDes, -1, 1)
            txt.Value = Math.Abs(oFunciones.Dias_Habiles(dFecFinDes, dFecCalculo)) * nAtraso
            oPicture = oFormP.Items.Item("Item_70").Specific
            oPicture.Picture = ""
            If dFecRealFinDesa.Trim.Length() = 0 Then

                Select Case nAtraso
                    Case -1
                        oPicture.Picture = sPathAnexos + "images\SRojo.png"
                    Case 1
                        oPicture.Picture = sPathAnexos + "images\SVerde.png"
                End Select

            End If
            'Termino Industrial
            txt = oFormP.Items.Item("Item_24").Specific
            dFecCalculo = If(oFormP.Items.Item("Item_179").Specific.value < 99, Date.Now(), oFormP.Items.Item("Item_173").Specific.Value)
            nAtraso = If(dFecCalculo > dFecFinPro, -1, 1)
            txt.Value = Math.Abs(oFunciones.Dias_Habiles(dFecFinPro, dFecCalculo)) * nAtraso
            oPicture = oFormP.Items.Item("Item_71").Specific
            oPicture.Picture = ""
            If oFormP.Items.Item("Item_179").Specific.value < 99 Then

                Select Case nAtraso
                    Case -1
                        oPicture.Picture = sPathAnexos + "images\SRojo.png"
                    Case 1
                        oPicture.Picture = sPathAnexos + "images\SVerde.png"
                End Select

            End If
            'Inicio Despacho
            txt = oFormP.Items.Item("Item_26").Specific
            dFecCalculo = If(oFormP.Items.Item("Item_180").Specific.value < 99, Date.Now(), oFormP.Items.Item("Item_174").Specific.Value)
            nAtraso = If(dFecCalculo > dFecIniDes, -1, 1)
            txt.Value = Math.Abs(oFunciones.Dias_Habiles(dFecIniDes, dFecCalculo)) * nAtraso
            oPicture = oFormP.Items.Item("Item_72").Specific
            oPicture.Picture = ""
            If oFormP.Items.Item("Item_180").Specific.value < 99 Then

                Select Case nAtraso
                    Case -1
                        oPicture.Picture = sPathAnexos + "images\SRojo.png"
                    Case 1
                        oPicture.Picture = sPathAnexos + "images\SVerde.png"
                End Select

            End If
            'Inicio Montaje
            txt = oFormP.Items.Item("Item_40").Specific
            dFecCalculo = If(dFecRealIniMont.Trim.Length() = 0, Date.Now(), dFecRealIniMont)
            nAtraso = If(dFecCalculo > dFecIniMon, -1, 1)
            txt.Value = Math.Abs(oFunciones.Dias_Habiles(dFecIniMon, dFecCalculo)) * nAtraso
            oPicture = oFormP.Items.Item("Item_73").Specific
            oPicture.Picture = ""
            If dFecRealIniMont.Trim.Length() = 0 Then

                Select Case nAtraso
                    Case -1
                        oPicture.Picture = sPathAnexos + "images\SRojo.png"
                    Case 1
                        oPicture.Picture = sPathAnexos + "images\SVerde.png"
                End Select

            End If
            'Termino Montaje
            txt = oFormP.Items.Item("Item_42").Specific
            dFecCalculo = If(dFecReaFinMont.Trim.Length() = 0, Date.Now(), dFecReaFinMont)
            nAtraso = If(dFecCalculo > dFecFinMon, -1, 1)
            txt.Value = Math.Abs(oFunciones.Dias_Habiles(dFecFinMon, dFecCalculo)) * nAtraso
            oPicture = oFormP.Items.Item("Item_178").Specific
            oPicture.Picture = ""
            If dFecReaFinMont.Trim.Length() = 0 Then

                Select Case nAtraso
                    Case -1
                        oPicture.Picture = sPathAnexos + "images\SRojo.png"
                    Case 1
                        oPicture.Picture = sPathAnexos + "images\SVerde.png"
                End Select

            End If

        End Sub

        Private Function Proximo_Codigo_ZHFPM() As Integer

            Dim sql As String = "select isnull(max(cast(isnull(case when ISNUMERIC(code) = 1 then code else '0' end,'0') as int)),0)+1 as Proximo from [" + sBDComercial.Trim() + "].[dbo].[@ZHFPM]"

            Try

                DT_SQL.ExecuteQuery(sql)

            Catch ex As Exception

                Application.SBO_Application.MessageBox(sql)
                Me.EditText41.Value = sql
                Application.SBO_Application.MessageBox(ex.Message)

            End Try

            Return DT_SQL.GetValue("Proximo", 0)

        End Function

        Private WithEvents EditText1 As SAPbouiCOM.EditText
        Private WithEvents Button0 As SAPbouiCOM.Button
        Private WithEvents EditText2 As SAPbouiCOM.EditText
        Private WithEvents EditText3 As SAPbouiCOM.EditText
        Private WithEvents EditText4 As SAPbouiCOM.EditText
        Private WithEvents EditText5 As SAPbouiCOM.EditText
        Private WithEvents EditText6 As SAPbouiCOM.EditText
        Private WithEvents EditText7 As SAPbouiCOM.EditText
        Private WithEvents EditText8 As SAPbouiCOM.EditText
        Private WithEvents EditText9 As SAPbouiCOM.EditText
        Private WithEvents EditText10 As SAPbouiCOM.EditText
        Private WithEvents EditText11 As SAPbouiCOM.EditText
        Private WithEvents EditText12 As SAPbouiCOM.EditText
        Private WithEvents EditText13 As SAPbouiCOM.EditText
        Private WithEvents EditText14 As SAPbouiCOM.EditText
        Private WithEvents EditText15 As SAPbouiCOM.EditText
        Private WithEvents EditText16 As SAPbouiCOM.EditText
        Private WithEvents EditText17 As SAPbouiCOM.EditText
        Private WithEvents EditText18 As SAPbouiCOM.EditText
        Private WithEvents EditText19 As SAPbouiCOM.EditText
        Private WithEvents EditText20 As SAPbouiCOM.EditText
        Private WithEvents EditText21 As SAPbouiCOM.EditText
        Private WithEvents EditText22 As SAPbouiCOM.EditText
        Private WithEvents EditText23 As SAPbouiCOM.EditText
        Private WithEvents EditText24 As SAPbouiCOM.EditText
        Private WithEvents EditText25 As SAPbouiCOM.EditText
        Private WithEvents EditText26 As SAPbouiCOM.EditText
        Private WithEvents EditText27 As SAPbouiCOM.EditText
        Private WithEvents EditText28 As SAPbouiCOM.EditText
        Private WithEvents EditText29 As SAPbouiCOM.EditText
        Private WithEvents EditText30 As SAPbouiCOM.EditText
        Private WithEvents EditText31 As SAPbouiCOM.EditText
        Private WithEvents EditText32 As SAPbouiCOM.EditText
        Private WithEvents EditText33 As SAPbouiCOM.EditText
        Private WithEvents EditText34 As SAPbouiCOM.EditText
        Private WithEvents EditText35 As SAPbouiCOM.EditText
        Private WithEvents EditText36 As SAPbouiCOM.EditText
        Private WithEvents EditText37 As SAPbouiCOM.EditText
        Private WithEvents EditText38 As SAPbouiCOM.EditText
        Private WithEvents Button1 As SAPbouiCOM.Button
        Private WithEvents Button2 As SAPbouiCOM.Button
        Private WithEvents Button3 As SAPbouiCOM.Button
        Private WithEvents Button4 As SAPbouiCOM.Button
        Private WithEvents Button5 As SAPbouiCOM.Button
        Private WithEvents Button6 As SAPbouiCOM.Button
        Private WithEvents EditText0 As SAPbouiCOM.EditText
        Private WithEvents StaticText0 As SAPbouiCOM.StaticText
        Private WithEvents EditText39 As SAPbouiCOM.EditText
        Private WithEvents EditText40 As SAPbouiCOM.EditText
        Private WithEvents EditText41 As SAPbouiCOM.EditText
        Private WithEvents EditText42 As SAPbouiCOM.EditText
        Private WithEvents EditText43 As SAPbouiCOM.EditText
        Private WithEvents EditText44 As SAPbouiCOM.EditText
        Private WithEvents EditText45 As SAPbouiCOM.EditText
        Private WithEvents EditText46 As SAPbouiCOM.EditText
        Private WithEvents StaticText1 As SAPbouiCOM.StaticText
        Private WithEvents StaticText2 As SAPbouiCOM.StaticText
        Private WithEvents EditText47 As SAPbouiCOM.EditText
        Private WithEvents StaticText3 As SAPbouiCOM.StaticText
        Private WithEvents EditText48 As SAPbouiCOM.EditText
        Private WithEvents StaticText4 As SAPbouiCOM.StaticText
        Private WithEvents EditText49 As SAPbouiCOM.EditText
        Private WithEvents StaticText5 As SAPbouiCOM.StaticText
        Private WithEvents EditText50 As SAPbouiCOM.EditText
        Private WithEvents StaticText6 As SAPbouiCOM.StaticText
        Private WithEvents EditText51 As SAPbouiCOM.EditText
        Private WithEvents StaticText7 As SAPbouiCOM.StaticText
        Private WithEvents Folder0 As SAPbouiCOM.Folder
        Private WithEvents EditText52 As SAPbouiCOM.EditText
        Private WithEvents StaticText8 As SAPbouiCOM.StaticText
        Private WithEvents StaticText9 As SAPbouiCOM.StaticText
        Private WithEvents EditText53 As SAPbouiCOM.EditText
        Private WithEvents StaticText10 As SAPbouiCOM.StaticText
        Private WithEvents DT_SQL As SAPbouiCOM.DataTable
        Private WithEvents CheckBox0 As SAPbouiCOM.CheckBox
        Private WithEvents CheckBox1 As SAPbouiCOM.CheckBox
        Private WithEvents StaticText11 As SAPbouiCOM.StaticText
        Private WithEvents OptionBtn2 As SAPbouiCOM.OptionBtn
        Private WithEvents OptionBtn3 As SAPbouiCOM.OptionBtn
        Private WithEvents StaticText12 As SAPbouiCOM.StaticText
        Private WithEvents EditText54 As SAPbouiCOM.EditText



        'Private Sub Button7_ClickBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles Button7.ClickBefore

        '    Llenar_Fechas_Vacias(sboObject, pVal)
        '    Me.EditText41.Active = True
        '    Validar_Campos_Requeridos()

        'End Sub


    End Class
End Namespace
