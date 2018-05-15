Option Strict Off
Option Explicit On
Imports FuncionalidadesSDKB1
Imports SAPbouiCOM.Framework

Namespace SBOAddonProject1
    <FormAttribute("SBOAddonProject1.FrmRegistrar_Proy", "3_Presentation_Layer/Pantallas Principales/FrmRegistrar_Proy.b1f")>
    Friend Class FrmRegistrar_Proy
        Inherits UserFormBase

        Public WithEvents oFormP As SAPbouiCOM.Form

        Public Sub New()
        End Sub

#Region "Respaldo de OnInitializeComponent"
        'Me.EditText0 = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText0 = CType(Me.GetItem("Item_1").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText1 = CType(Me.GetItem("Item_2").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText1 = CType(Me.GetItem("Item_3").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText2 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText2 = CType(Me.GetItem("Item_5").Specific, SAPbouiCOM.StaticText)
        '   Me.StaticText3 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText3 = CType(Me.GetItem("Item_7").Specific, SAPbouiCOM.EditText)
        '   Me.LinkedButton0 = CType(Me.GetItem("Item_8").Specific, SAPbouiCOM.LinkedButton)
        '   Me.EditText4 = CType(Me.GetItem("Item_9").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText4 = CType(Me.GetItem("Item_10").Specific, SAPbouiCOM.StaticText)
        '   Me.StaticText5 = CType(Me.GetItem("Item_11").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText5 = CType(Me.GetItem("Item_12").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText6 = CType(Me.GetItem("Item_13").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText6 = CType(Me.GetItem("Item_14").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText7 = CType(Me.GetItem("Item_15").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText7 = CType(Me.GetItem("Item_16").Specific, SAPbouiCOM.EditText)
        '   Me.CheckBox0 = CType(Me.GetItem("Item_17").Specific, SAPbouiCOM.CheckBox)
        '   Me.CheckBox1 = CType(Me.GetItem("Item_18").Specific, SAPbouiCOM.CheckBox)
        '   Me.StaticText8 = CType(Me.GetItem("Item_19").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText8 = CType(Me.GetItem("Item_20").Specific, SAPbouiCOM.EditText)
        '   Me.OptionBtn0 = CType(Me.GetItem("Item_21").Specific, SAPbouiCOM.OptionBtn)
        '   Me.OptionBtn1 = CType(Me.GetItem("Item_22").Specific, SAPbouiCOM.OptionBtn)
        '   Me.StaticText9 = CType(Me.GetItem("Item_23").Specific, SAPbouiCOM.StaticText)
        '   Me.Button0 = CType(Me.GetItem("Item_24").Specific, SAPbouiCOM.Button)
        '   Me.Button1 = CType(Me.GetItem("Item_25").Specific, SAPbouiCOM.Button)
        '   Me.Button2 = CType(Me.GetItem("Item_26").Specific, SAPbouiCOM.Button)
        '   Me.EditText9 = CType(Me.GetItem("Item_27").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText10 = CType(Me.GetItem("Item_28").Specific, SAPbouiCOM.StaticText)
        '   Me.Button3 = CType(Me.GetItem("Item_29").Specific, SAPbouiCOM.Button)
        '   Me.Folder0 = CType(Me.GetItem("Item_31").Specific, SAPbouiCOM.Folder)
        '   Me.Folder1 = CType(Me.GetItem("Item_32").Specific, SAPbouiCOM.Folder)
        '   Me.Folder2 = CType(Me.GetItem("Item_34").Specific, SAPbouiCOM.Folder)
        '   Me.ComboBox0 = CType(Me.GetItem("Item_35").Specific, SAPbouiCOM.ComboBox)
        '   Me.StaticText11 = CType(Me.GetItem("Item_36").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText10 = CType(Me.GetItem("Item_37").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText12 = CType(Me.GetItem("Item_38").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText11 = CType(Me.GetItem("Item_39").Specific, SAPbouiCOM.EditText)
        '   Me.EditText12 = CType(Me.GetItem("Item_40").Specific, SAPbouiCOM.EditText)
        '   Me.EditText13 = CType(Me.GetItem("Item_41").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText13 = CType(Me.GetItem("Item_42").Specific, SAPbouiCOM.StaticText)
        '   Me.StaticText14 = CType(Me.GetItem("Item_43").Specific, SAPbouiCOM.StaticText)
        '   Me.StaticText15 = CType(Me.GetItem("Item_44").Specific, SAPbouiCOM.StaticText)
        '   Me.StaticText16 = CType(Me.GetItem("Item_45").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText14 = CType(Me.GetItem("Item_46").Specific, SAPbouiCOM.EditText)
        '   Me.EditText15 = CType(Me.GetItem("Item_47").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText17 = CType(Me.GetItem("Item_48").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText16 = CType(Me.GetItem("Item_49").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText18 = CType(Me.GetItem("Item_50").Specific, SAPbouiCOM.StaticText)
        '   Me.StaticText19 = CType(Me.GetItem("Item_51").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText17 = CType(Me.GetItem("Item_52").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText20 = CType(Me.GetItem("Item_53").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText18 = CType(Me.GetItem("Item_54").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText21 = CType(Me.GetItem("Item_55").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText19 = CType(Me.GetItem("Item_56").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText22 = CType(Me.GetItem("Item_57").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText20 = CType(Me.GetItem("Item_58").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText23 = CType(Me.GetItem("Item_59").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText21 = CType(Me.GetItem("Item_60").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText24 = CType(Me.GetItem("Item_61").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText22 = CType(Me.GetItem("Item_62").Specific, SAPbouiCOM.EditText)
        '   Me.EditText23 = CType(Me.GetItem("Item_63").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText25 = CType(Me.GetItem("Item_64").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText24 = CType(Me.GetItem("Item_65").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText26 = CType(Me.GetItem("Item_66").Specific, SAPbouiCOM.StaticText)
        '   Me.CheckBox2 = CType(Me.GetItem("Item_67").Specific, SAPbouiCOM.CheckBox)
        '   Me.CheckBox3 = CType(Me.GetItem("Item_68").Specific, SAPbouiCOM.CheckBox)
        '   Me.OptionBtn2 = CType(Me.GetItem("Item_69").Specific, SAPbouiCOM.OptionBtn)
        '   Me.OptionBtn3 = CType(Me.GetItem("Item_70").Specific, SAPbouiCOM.OptionBtn)
        '   Me.OptionBtn4 = CType(Me.GetItem("Item_71").Specific, SAPbouiCOM.OptionBtn)
        '   Me.StaticText27 = CType(Me.GetItem("Item_72").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText25 = CType(Me.GetItem("Item_73").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText28 = CType(Me.GetItem("Item_74").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText26 = CType(Me.GetItem("Item_75").Specific, SAPbouiCOM.EditText)
        '   Me.Matrix0 = CType(Me.GetItem("Item_76").Specific, SAPbouiCOM.Matrix)
        '   Me.EditText27 = CType(Me.GetItem("Item_77").Specific, SAPbouiCOM.EditText)
        '   Me.Button4 = CType(Me.GetItem("Item_78").Specific, SAPbouiCOM.Button)
        '   Me.StaticText29 = CType(Me.GetItem("Item_79").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText28 = CType(Me.GetItem("Item_80").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText30 = CType(Me.GetItem("Item_81").Specific, SAPbouiCOM.StaticText)
        '   Me.Button5 = CType(Me.GetItem("Item_82").Specific, SAPbouiCOM.Button)
        '   Me.Button6 = CType(Me.GetItem("Item_83").Specific, SAPbouiCOM.Button)
        '   Me.Folder3 = CType(Me.GetItem("Item_85").Specific, SAPbouiCOM.Folder)
        '   Me.StaticText31 = CType(Me.GetItem("Item_86").Specific, SAPbouiCOM.StaticText)
        '   Me.PictureBox0 = CType(Me.GetItem("Item_87").Specific, SAPbouiCOM.PictureBox)

        '   Me.DT_0X = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_0X")
        '   Me.DT_SQLX = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_SQLX")
#End Region

        Public Overrides Sub OnInitializeComponent()
            Me.EditText0 = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.EditText)
            Me.StaticText0 = CType(Me.GetItem("Item_1").Specific, SAPbouiCOM.StaticText)
            Me.EditText1 = CType(Me.GetItem("Item_2").Specific, SAPbouiCOM.EditText)
            Me.StaticText1 = CType(Me.GetItem("Item_3").Specific, SAPbouiCOM.StaticText)
            Me.EditText2 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.EditText)
            Me.StaticText2 = CType(Me.GetItem("Item_5").Specific, SAPbouiCOM.StaticText)
            Me.StaticText3 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.StaticText)
            Me.EditText3 = CType(Me.GetItem("Item_7").Specific, SAPbouiCOM.EditText)
            Me.LinkedButton0 = CType(Me.GetItem("Item_8").Specific, SAPbouiCOM.LinkedButton)
            Me.EditText4 = CType(Me.GetItem("Item_9").Specific, SAPbouiCOM.EditText)
            Me.StaticText4 = CType(Me.GetItem("Item_10").Specific, SAPbouiCOM.StaticText)
            Me.StaticText5 = CType(Me.GetItem("Item_11").Specific, SAPbouiCOM.StaticText)
            Me.EditText5 = CType(Me.GetItem("Item_12").Specific, SAPbouiCOM.EditText)
            Me.StaticText6 = CType(Me.GetItem("Item_13").Specific, SAPbouiCOM.StaticText)
            Me.EditText6 = CType(Me.GetItem("Item_14").Specific, SAPbouiCOM.EditText)
            Me.StaticText7 = CType(Me.GetItem("Item_15").Specific, SAPbouiCOM.StaticText)
            Me.EditText7 = CType(Me.GetItem("Item_16").Specific, SAPbouiCOM.EditText)
            Me.CheckBox0 = CType(Me.GetItem("Item_17").Specific, SAPbouiCOM.CheckBox)
            Me.CheckBox1 = CType(Me.GetItem("Item_18").Specific, SAPbouiCOM.CheckBox)
            Me.StaticText8 = CType(Me.GetItem("Item_19").Specific, SAPbouiCOM.StaticText)
            Me.EditText8 = CType(Me.GetItem("Item_20").Specific, SAPbouiCOM.EditText)
            Me.OptionBtn0 = CType(Me.GetItem("Item_21").Specific, SAPbouiCOM.OptionBtn)
            Me.OptionBtn1 = CType(Me.GetItem("Item_22").Specific, SAPbouiCOM.OptionBtn)
            Me.StaticText9 = CType(Me.GetItem("Item_23").Specific, SAPbouiCOM.StaticText)
            Me.Button0 = CType(Me.GetItem("Item_24").Specific, SAPbouiCOM.Button)
            Me.Button1 = CType(Me.GetItem("Item_25").Specific, SAPbouiCOM.Button)
            Me.Button2 = CType(Me.GetItem("Item_26").Specific, SAPbouiCOM.Button)
            Me.EditText9 = CType(Me.GetItem("Item_27").Specific, SAPbouiCOM.EditText)
            Me.StaticText10 = CType(Me.GetItem("Item_28").Specific, SAPbouiCOM.StaticText)
            Me.Button3 = CType(Me.GetItem("Item_29").Specific, SAPbouiCOM.Button)
            Me.Folder0 = CType(Me.GetItem("Item_31").Specific, SAPbouiCOM.Folder)
            Me.Folder1 = CType(Me.GetItem("Item_32").Specific, SAPbouiCOM.Folder)
            Me.Folder2 = CType(Me.GetItem("Item_34").Specific, SAPbouiCOM.Folder)
            Me.ComboBox0 = CType(Me.GetItem("Item_35").Specific, SAPbouiCOM.ComboBox)
            Me.StaticText11 = CType(Me.GetItem("Item_36").Specific, SAPbouiCOM.StaticText)
            Me.EditText10 = CType(Me.GetItem("Item_37").Specific, SAPbouiCOM.EditText)
            Me.StaticText12 = CType(Me.GetItem("Item_38").Specific, SAPbouiCOM.StaticText)
            Me.EditText11 = CType(Me.GetItem("Item_39").Specific, SAPbouiCOM.EditText)
            Me.EditText12 = CType(Me.GetItem("Item_40").Specific, SAPbouiCOM.EditText)
            Me.EditText13 = CType(Me.GetItem("Item_41").Specific, SAPbouiCOM.EditText)
            Me.StaticText13 = CType(Me.GetItem("Item_42").Specific, SAPbouiCOM.StaticText)
            Me.StaticText14 = CType(Me.GetItem("Item_43").Specific, SAPbouiCOM.StaticText)
            Me.StaticText15 = CType(Me.GetItem("Item_44").Specific, SAPbouiCOM.StaticText)
            Me.StaticText16 = CType(Me.GetItem("Item_45").Specific, SAPbouiCOM.StaticText)
            Me.EditText14 = CType(Me.GetItem("Item_46").Specific, SAPbouiCOM.EditText)
            Me.EditText15 = CType(Me.GetItem("Item_47").Specific, SAPbouiCOM.EditText)
            Me.StaticText17 = CType(Me.GetItem("Item_48").Specific, SAPbouiCOM.StaticText)
            Me.EditText16 = CType(Me.GetItem("Item_49").Specific, SAPbouiCOM.EditText)
            Me.StaticText18 = CType(Me.GetItem("Item_50").Specific, SAPbouiCOM.StaticText)
            Me.StaticText19 = CType(Me.GetItem("Item_51").Specific, SAPbouiCOM.StaticText)
            Me.EditText17 = CType(Me.GetItem("Item_52").Specific, SAPbouiCOM.EditText)
            Me.StaticText20 = CType(Me.GetItem("Item_53").Specific, SAPbouiCOM.StaticText)
            Me.EditText18 = CType(Me.GetItem("Item_54").Specific, SAPbouiCOM.EditText)
            Me.StaticText21 = CType(Me.GetItem("Item_55").Specific, SAPbouiCOM.StaticText)
            Me.EditText19 = CType(Me.GetItem("Item_56").Specific, SAPbouiCOM.EditText)
            Me.StaticText22 = CType(Me.GetItem("Item_57").Specific, SAPbouiCOM.StaticText)
            Me.EditText20 = CType(Me.GetItem("Item_58").Specific, SAPbouiCOM.EditText)
            Me.StaticText23 = CType(Me.GetItem("Item_59").Specific, SAPbouiCOM.StaticText)
            Me.EditText21 = CType(Me.GetItem("Item_60").Specific, SAPbouiCOM.EditText)
            Me.StaticText24 = CType(Me.GetItem("Item_61").Specific, SAPbouiCOM.StaticText)
            Me.EditText22 = CType(Me.GetItem("Item_62").Specific, SAPbouiCOM.EditText)
            Me.EditText23 = CType(Me.GetItem("Item_63").Specific, SAPbouiCOM.EditText)
            Me.StaticText25 = CType(Me.GetItem("Item_64").Specific, SAPbouiCOM.StaticText)
            Me.EditText24 = CType(Me.GetItem("Item_65").Specific, SAPbouiCOM.EditText)
            Me.StaticText26 = CType(Me.GetItem("Item_66").Specific, SAPbouiCOM.StaticText)
            Me.CheckBox2 = CType(Me.GetItem("Item_67").Specific, SAPbouiCOM.CheckBox)
            Me.CheckBox3 = CType(Me.GetItem("Item_68").Specific, SAPbouiCOM.CheckBox)
            Me.OptionBtn2 = CType(Me.GetItem("Item_69").Specific, SAPbouiCOM.OptionBtn)
            Me.OptionBtn3 = CType(Me.GetItem("Item_70").Specific, SAPbouiCOM.OptionBtn)
            Me.OptionBtn4 = CType(Me.GetItem("Item_71").Specific, SAPbouiCOM.OptionBtn)
            Me.StaticText27 = CType(Me.GetItem("Item_72").Specific, SAPbouiCOM.StaticText)
            Me.EditText25 = CType(Me.GetItem("Item_73").Specific, SAPbouiCOM.EditText)
            Me.StaticText28 = CType(Me.GetItem("Item_74").Specific, SAPbouiCOM.StaticText)
            Me.EditText26 = CType(Me.GetItem("Item_75").Specific, SAPbouiCOM.EditText)
            Me.Matrix0 = CType(Me.GetItem("Item_76").Specific, SAPbouiCOM.Matrix)
            Me.EditText27 = CType(Me.GetItem("Item_77").Specific, SAPbouiCOM.EditText)
            Me.Button4 = CType(Me.GetItem("Item_78").Specific, SAPbouiCOM.Button)
            Me.StaticText29 = CType(Me.GetItem("Item_79").Specific, SAPbouiCOM.StaticText)
            Me.EditText28 = CType(Me.GetItem("Item_80").Specific, SAPbouiCOM.EditText)
            Me.StaticText30 = CType(Me.GetItem("Item_81").Specific, SAPbouiCOM.StaticText)
            Me.Button5 = CType(Me.GetItem("Item_82").Specific, SAPbouiCOM.Button)
            Me.Button6 = CType(Me.GetItem("Item_83").Specific, SAPbouiCOM.Button)
            Me.Folder3 = CType(Me.GetItem("Item_85").Specific, SAPbouiCOM.Folder)
            Me.StaticText31 = CType(Me.GetItem("Item_86").Specific, SAPbouiCOM.StaticText)
            Me.PictureBox0 = CType(Me.GetItem("Item_87").Specific, SAPbouiCOM.PictureBox)
            Me.DT_0X = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_0X")
            Me.DT_SQLX = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_SQLX")
            Me.ComboBox1 = CType(Me.GetItem("Item_88").Specific, SAPbouiCOM.ComboBox)
            Me.StaticText32 = CType(Me.GetItem("Item_89").Specific, SAPbouiCOM.StaticText)
            Me.EditText29 = CType(Me.GetItem("Item_90").Specific, SAPbouiCOM.EditText)
            Me.EditText30 = CType(Me.GetItem("Item_91").Specific, SAPbouiCOM.EditText)
            Me.StaticText33 = CType(Me.GetItem("Item_92").Specific, SAPbouiCOM.StaticText)
            Me.StaticText34 = CType(Me.GetItem("Item_93").Specific, SAPbouiCOM.StaticText)
            Me.ComboBox2 = CType(Me.GetItem("Item_94").Specific, SAPbouiCOM.ComboBox)
            Me.StaticText35 = CType(Me.GetItem("Item_95").Specific, SAPbouiCOM.StaticText)
            Me.Folder4 = CType(Me.GetItem("Item_97").Specific, SAPbouiCOM.Folder)
            Me.OptionBtn5 = CType(Me.GetItem("Item_98").Specific, SAPbouiCOM.OptionBtn)
            Me.OptionBtn6 = CType(Me.GetItem("Item_99").Specific, SAPbouiCOM.OptionBtn)
            Me.StaticText36 = CType(Me.GetItem("Item_100").Specific, SAPbouiCOM.StaticText)
            Me.StaticText37 = CType(Me.GetItem("Item_101").Specific, SAPbouiCOM.StaticText)
            Me.EditText31 = CType(Me.GetItem("Item_102").Specific, SAPbouiCOM.EditText)
            Me.OptionBtn7 = CType(Me.GetItem("Item_103").Specific, SAPbouiCOM.OptionBtn)
            Me.OptionBtn8 = CType(Me.GetItem("Item_104").Specific, SAPbouiCOM.OptionBtn)
            Me.StaticText38 = CType(Me.GetItem("Item_105").Specific, SAPbouiCOM.StaticText)
            Me.StaticText39 = CType(Me.GetItem("Item_106").Specific, SAPbouiCOM.StaticText)
            Me.EditText32 = CType(Me.GetItem("Item_107").Specific, SAPbouiCOM.EditText)
            Me.Button7 = CType(Me.GetItem("Item_108").Specific, SAPbouiCOM.Button)
            Me.OnCustomInitialize()

        End Sub

        Public Overrides Sub OnInitializeFormEvents()

        End Sub


        Private Sub OnCustomInitialize()

            oFormP = Application.SBO_Application.Forms.Item(Me.UIAPIRawForm.UniqueID)

            Me.EditText15.String = Date.Now.ToShortDateString
            Me.EditText16.String = Date.Now.ToShortDateString
            Me.EditText10.String = Date.Now.ToShortDateString
            Me.EditText11.String = Date.Now.ToShortDateString
            Me.EditText12.String = Date.Now.ToShortDateString
            Me.EditText13.String = Date.Now.ToShortDateString
            Me.EditText14.String = Date.Now.ToShortDateString
            Me.EditText23.String = Date.Now.ToShortDateString

            Me.EditText17.Value = "0"
            Me.EditText18.Value = "0"
            Me.EditText19.Value = "0"
            Me.EditText20.Value = "0"
            Me.EditText21.Value = "0"
            Me.EditText31.Value = "0"

            Call oFunciones.FiltrarChooseFromList(Me.UIAPIRawForm.UniqueID, "CFL_0")
            Call oFunciones.FiltrarChooseFromList(Me.UIAPIRawForm.UniqueID, "CFL_1")
            Call oFunciones.FiltrarChooseFromListSLP(Me.UIAPIRawForm.UniqueID, "CFL_2")

            Me.ComboBox0.Select("No")
            Me.ComboBox2.Select("CH")

            Me.CheckBox0.Checked = True
            Me.CheckBox1.Checked = True
            Me.CheckBox2.Checked = False
            Me.CheckBox3.Checked = False

            Me.OptionBtn3.GroupWith("Item_69")
            Me.OptionBtn4.GroupWith("Item_69")

            Me.OptionBtn1.GroupWith("Item_21")

            Me.OptionBtn6.GroupWith("Item_98")

            Me.OptionBtn8.GroupWith("Item_103")

            Me.PictureBox0 = CType(Me.GetItem("Item_87").Specific, SAPbouiCOM.PictureBox)
            Me.PictureBox0.Picture = sPathAnexos + "images\User.png"
            Me.Button1.Item.Enabled = False

            Me.EditText0.Value = oFunciones.Proximo_Codigo_OPRJ(DT_SQLX)

            'Cargar Combo Condiciones Pago
            Dim Sql = "SELECT U_CondCode,U_CondDesc FROM [" + sBDComercial.Trim() + "].[dbo].[@MIN_CONDPAG] ORDER BY 1"
            ComboBoxExtensions.LoadComboQueryDataTable(ComboBox1, DT_SQLX, Sql, 0, 1, False)

            Me.OptionBtn0.Selected = True
            Me.OptionBtn5.Selected = True
            Me.OptionBtn7.Selected = True

            StaticText37.Item.Visible = False
            StaticText39.Item.Visible = False
            EditText31.Item.Visible = False
            EditText32.Item.Visible = False
            Button7.Item.Visible = False
            EditText32.Value = ""

            Me.Folder0.Item.Click()
            Me.EditText2.Item.Click()

            Me.EditText0.Item.AffectsFormMode = False
            Me.EditText1.Item.AffectsFormMode = False
            Me.EditText2.Item.AffectsFormMode = False
            Me.EditText3.Item.AffectsFormMode = False
            Me.LinkedButton0.Item.AffectsFormMode = False
            Me.EditText4.Item.AffectsFormMode = False
            Me.EditText5.Item.AffectsFormMode = False
            Me.EditText6.Item.AffectsFormMode = False
            Me.EditText7.Item.AffectsFormMode = False
            Me.CheckBox0.Item.AffectsFormMode = False
            Me.CheckBox1.Item.AffectsFormMode = False
            Me.EditText8.Item.AffectsFormMode = False
            Me.OptionBtn0.Item.AffectsFormMode = False
            Me.OptionBtn1.Item.AffectsFormMode = False
            Me.Button0.Item.AffectsFormMode = False
            Me.Button1.Item.AffectsFormMode = False
            Me.Button2.Item.AffectsFormMode = False
            Me.EditText9.Item.AffectsFormMode = False
            Me.Button3.Item.AffectsFormMode = False
            Me.Folder0.Item.AffectsFormMode = False
            Me.Folder1.Item.AffectsFormMode = False
            Me.Folder2.Item.AffectsFormMode = False
            Me.ComboBox0.Item.AffectsFormMode = False
            Me.ComboBox1.Item.AffectsFormMode = False
            Me.ComboBox2.Item.AffectsFormMode = False
            Me.EditText10.Item.AffectsFormMode = False
            Me.EditText11.Item.AffectsFormMode = False
            Me.EditText12.Item.AffectsFormMode = False
            Me.EditText13.Item.AffectsFormMode = False
            Me.EditText14.Item.AffectsFormMode = False
            Me.EditText15.Item.AffectsFormMode = False
            Me.EditText16.Item.AffectsFormMode = False
            Me.EditText17.Item.AffectsFormMode = False
            Me.EditText18.Item.AffectsFormMode = False
            Me.EditText19.Item.AffectsFormMode = False
            Me.EditText20.Item.AffectsFormMode = False
            Me.EditText21.Item.AffectsFormMode = False
            Me.EditText22.Item.AffectsFormMode = False
            Me.EditText23.Item.AffectsFormMode = False
            Me.EditText24.Item.AffectsFormMode = False
            Me.EditText25.Item.AffectsFormMode = False
            Me.EditText26.Item.AffectsFormMode = False
            Me.EditText27.Item.AffectsFormMode = False
            Me.EditText28.Item.AffectsFormMode = False
            Me.EditText29.Item.AffectsFormMode = False
            Me.EditText30.Item.AffectsFormMode = False
            Me.EditText31.Item.AffectsFormMode = False
            Me.EditText32.Item.AffectsFormMode = False
            Me.CheckBox2.Item.AffectsFormMode = False
            Me.CheckBox3.Item.AffectsFormMode = False
            Me.OptionBtn2.Item.AffectsFormMode = False
            Me.OptionBtn3.Item.AffectsFormMode = False
            Me.OptionBtn4.Item.AffectsFormMode = False
            Me.OptionBtn5.Item.AffectsFormMode = False
            Me.OptionBtn6.Item.AffectsFormMode = False
            Me.OptionBtn7.Item.AffectsFormMode = False
            Me.OptionBtn8.Item.AffectsFormMode = False
            Me.Matrix0.Item.AffectsFormMode = False
            Me.Button4.Item.AffectsFormMode = False
            Me.Button5.Item.AffectsFormMode = False
            Me.Button6.Item.AffectsFormMode = False
            Me.Folder3.Item.AffectsFormMode = False
            Me.PictureBox0.Item.AffectsFormMode = False

        End Sub

        Private Sub Button0_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button0.ClickAfter

            Application.SBO_Application.OpenForm(SAPbouiCOM.BoFormObjectEnum.fo_ProjectCodes, "", oCompany.GetNewObjectKey)

        End Sub

        Private Sub Button1_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button1.ClickAfter
            If Button1.Item.Enabled Then
                Call Registrar_Proyecto()
            End If
        End Sub

        Private Sub Button2_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button2.ClickAfter

            Application.SBO_Application.Forms.ActiveForm.Close()

        End Sub


        Private Sub Button3_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button3.ClickAfter

            Application.SBO_Application.ActivateMenuItem("SBOAddonProject1.Form1")

        End Sub

        Private Sub Button4_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button4.ClickAfter

            oFunciones.Abre_Dialogo_y_Asigna_Path3(Me.EditText27, DialogType.OPEN)

        End Sub

        Private Sub Button5_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button5.ClickAfter

            Call Agregar_Archivo_a_Matrix()

        End Sub

        Private Sub Button6_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button6.ClickAfter

            Dim rowNum As Integer = Me.Matrix0.GetNextSelectedRow(0, SAPbouiCOM.BoOrderType.ot_RowOrder) - 1

            Try
                Me.DT_0X.Rows.Remove(rowNum)

                For index = 0 To Me.DT_0X.Rows.Count - 1
                    DT_0X.SetValue("Fila", index, index + 1)
                Next

                oForm.Freeze(True)

                Me.Matrix0.Clear()
                Me.Matrix0.LoadFromDataSource()

            Catch ex As Exception
            Finally
                oForm.Freeze(False)
            End Try

        End Sub

        Private Sub Button7_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button7.ClickAfter

            Dim activeForm2 As Form2
            activeForm2 = New Form2

            Dim oUDS As SAPbouiCOM.UserDataSource = activeForm2.UIAPIRawForm.DataSources.UserDataSources.Item("UD_0")
            oUDS.ValueEx = Me.UIAPIRawForm.UniqueID
            oUDS = activeForm2.UIAPIRawForm.DataSources.UserDataSources.Item("UD_1")
            oUDS.ValueEx = "REGISTRO"

            activeForm2.Show()

        End Sub


        Private Sub PictureBox0_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles PictureBox0.ClickAfter

            If Me.Button1.Item.Enabled = False Then
                Dim Formp2 As Form12
                Formp2 = New Form12

                Dim oUDS As SAPbouiCOM.UserDataSource = Formp2.UIAPIRawForm.DataSources.UserDataSources.Item("UD_0")
                oUDS.ValueEx = Me.UIAPIRawForm.UniqueID   'Aca asignamos el FormUID de Formulario al Valor del  User Data Source

                Dim oUDS2 As SAPbouiCOM.UserDataSource = Formp2.UIAPIRawForm.DataSources.UserDataSources.Item("UD_1")
                oUDS2.ValueEx = "PROYECTO"

                Formp2.Show()
            End If

        End Sub

        Private Sub EditText0_LostFocusAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText0.LostFocusAfter

            If (EditText0.Value.Trim.Length > 0) Then
                If (Right(EditText0.Value.Trim, 1) = 1) Then
                    OptionBtn7.Selected = True
                Else
                    OptionBtn8.Selected = True
                    EditText32.Value = EditText0.Value.Trim.Substring(0, EditText0.Value.Trim.Length - 1) + "1"
                End If
            End If

        End Sub

        Private Sub EditText27_DoubleClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText27.DoubleClickAfter

            oFunciones.Open_File(Me.EditText27.Value.Trim)

        End Sub

        Private Sub ComboBox0_ComboSelectAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles ComboBox0.ComboSelectAfter

            If Me.ComboBox0.Selected.Value = "Si" Then
                Me.EditText22.Item.Enabled = True
                Me.EditText23.Item.Enabled = True
                Me.EditText25.Item.Enabled = True
                Me.EditText26.Item.Enabled = True
                Me.CheckBox2.Item.Enabled = True
                Me.CheckBox3.Item.Enabled = True
                Me.OptionBtn2.Item.Enabled = True
                Me.OptionBtn3.Item.Enabled = True
                Me.OptionBtn4.Item.Enabled = True
            Else
                Me.EditText22.Item.Enabled = False
                Me.EditText23.Item.Enabled = False
                Me.EditText25.Item.Enabled = False
                Me.EditText26.Item.Enabled = False
                Me.CheckBox2.Item.Enabled = False
                Me.CheckBox3.Item.Enabled = False
                Me.OptionBtn2.Item.Enabled = False
                Me.OptionBtn3.Item.Enabled = False
                Me.OptionBtn4.Item.Enabled = False
            End If

        End Sub

        Private Sub Matrix0_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Matrix0.ClickAfter

            oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
            oMatrix = oForm.Items.Item("Item_76").Specific 'matrix
            Dim rowNum As Integer = oMatrix.GetNextSelectedRow(0, SAPbouiCOM.BoOrderType.ot_RowOrder)
            Try
                oMatrix.SelectRow(pVal.Row, True, False)
            Catch
            End Try

        End Sub

        Private Sub Matrix0_DoubleClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Matrix0.DoubleClickAfter

            If pVal.ColUID = "Col_0" Then
                oedit = Me.Matrix0.Columns.Item(pVal.ColUID).Cells.Item(pVal.Row).Specific ' Selecciona el contenido de la celda
                oFunciones.Open_File(oedit.Value.Trim)
            End If

        End Sub

        Private Sub CheckBox1_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles CheckBox1.ClickAfter

            If CheckBox1.Checked = False Then
                EditText13.Item.Enabled = True
                EditText14.Item.Enabled = True
            Else
                EditText13.Item.Enabled = False
                EditText14.Item.Enabled = False
            End If

        End Sub

        Private Sub CheckBox0_DoubleClickBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles CheckBox0.DoubleClickBefore

            BubbleEvent = False

        End Sub

        Private Sub CheckBox0_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles CheckBox0.ClickAfter

            If CheckBox0.Checked = False Then
                EditText12.Item.Enabled = True
            Else
                EditText12.Item.Enabled = False
            End If

        End Sub

        Private Sub CheckBox1_DoubleClickBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles CheckBox1.DoubleClickBefore

            BubbleEvent = False

        End Sub

        Private Sub EditText10_LostFocusAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText10.LostFocusAfter

            oFunciones.Valida_Fecha_Calcula_Dias(Me.EditText10, Me.EditText15, Me.EditText17)

        End Sub

        Private Sub EditText11_LostFocusAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText11.LostFocusAfter

            oFunciones.Valida_Fecha_Calcula_Dias(Me.EditText11, Me.EditText10, Me.EditText18)

        End Sub

        Private Sub EditText12_LostFocusAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText12.LostFocusAfter

            oFunciones.Valida_Fecha_Calcula_Dias(Me.EditText12, Me.EditText11, Me.EditText19)

        End Sub

        Private Sub EditText13_LostFocusAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText13.LostFocusAfter

            oFunciones.Valida_Fecha_Calcula_Dias(Me.EditText13, Me.EditText12, Me.EditText20)

        End Sub

        Private Sub EditText14_LostFocusAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText14.LostFocusAfter

            oFunciones.Valida_Fecha_Calcula_Dias(Me.EditText14, Me.EditText13, Me.EditText21)

        End Sub

        Private Sub EditText15_LostFocusAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText15.LostFocusAfter

            Dim dFecha1 As Date
            Dim dFecha2 As Date

            If Me.EditText16.Value.Trim.Length = 0 Then
                Me.EditText16.Value = Me.EditText15.Value
            End If

            dFecha1 = DateTime.ParseExact(EditText15.Value, "yyyyMMdd", Nothing).ToString("dd\/MM\/yyyy")
            dFecha2 = DateTime.ParseExact(EditText16.Value, "yyyyMMdd", Nothing).ToString("dd\/MM\/yyyy")
            Me.EditText22.Value = DateDiff(DateInterval.Day, dFecha1, dFecha2)

        End Sub


        Private Sub EditText16_LostFocusAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText16.LostFocusAfter

            Dim dFecha1 As Date
            Dim dFecha2 As Date

            dFecha1 = DateTime.ParseExact(EditText15.Value, "yyyyMMdd", Nothing).ToString("dd\/MM\/yyyy")
            dFecha2 = DateTime.ParseExact(EditText16.Value, "yyyyMMdd", Nothing).ToString("dd\/MM\/yyyy")
            Me.EditText22.Value = DateDiff(DateInterval.Day, dFecha1, dFecha2)

        End Sub

        Private Sub OptionBtn7_PressedAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles OptionBtn7.PressedAfter

            oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)

            Try
                oForm.Freeze(True)
                StaticText37.Item.Visible = False
                StaticText39.Item.Visible = False
                EditText31.Active = False
                EditText31.Item.Visible = False
                EditText32.Active = False
                EditText32.Item.Visible = False
                Button7.Item.Visible = False
                EditText32.Value = ""
            Catch ex As Exception
            Finally
                oForm.Freeze(False)
            End Try


        End Sub

        Private Sub OptionBtn8_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles OptionBtn8.ClickAfter

            oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)

            Try
                oForm.Freeze(True)
                StaticText37.Item.Visible = True
                StaticText39.Item.Visible = True
                EditText31.Item.Visible = True
                EditText32.Item.Visible = True
                Button7.Item.Visible = True
                EditText32.Value = EditText0.Value.Trim.Substring(0, EditText0.Value.Trim.Length - 1) + "1"
            Catch ex As Exception
            Finally
                oForm.Freeze(False)
            End Try

        End Sub

        Private Sub Agregar_Archivo_a_Matrix()

            If Me.EditText27.Value.Trim.Length() > 0 Then

                oForm = Application.SBO_Application.Forms.ActiveForm()

                Try

                    DT_0X.Rows.Add()
                    Dim rowNum As Integer = DT_0X.Rows.Count - 1
                    DT_0X.SetValue("Archivo", rowNum, Me.EditText27.Value.Trim())
                    DT_0X.SetValue("Fecha", rowNum, Date.Now)
                    DT_0X.SetValue("Hora", rowNum, DateTime.Now.ToLongTimeString())
                    DT_0X.SetValue("Comentario", rowNum, Me.EditText28.Value.Trim())
                    DT_0X.SetValue("Fila", rowNum, rowNum + 1)

                Catch ex As Exception

                    Application.SBO_Application.MessageBox("Error al Cargar el DataTable 'DTO_0'")

                End Try

                Try

                    Me.Matrix0.Columns.Item("#").DataBind.Bind("DT_0X", "Fila")
                    Me.Matrix0.Columns.Item("Col_0").DataBind.Bind("DT_0X", "Archivo")
                    Me.Matrix0.Columns.Item("Col_1").DataBind.Bind("DT_0X", "Fecha")
                    Me.Matrix0.Columns.Item("Col_2").DataBind.Bind("DT_0X", "Hora")
                    Me.Matrix0.Columns.Item("Col_3").DataBind.Bind("DT_0X", "Comentario")

                    oForm.Freeze(True)

                    Me.Matrix0.Clear()
                    Me.Matrix0.LoadFromDataSource()
                    Me.EditText27.Value = ""
                    Me.EditText28.Value = ""
                    Me.EditText27.Item.Click()

                Catch ex As Exception

                    Application.SBO_Application.MessageBox("Error al Cargar Matrix desde el DataTable 'DTO_0'")

                Finally

                    oForm.Freeze(False)

                End Try

            End If

        End Sub

        Private Sub Registrar_Proyecto()

            Dim Validador As Boolean = False

            Dim sCodPro As String = Me.EditText0.Value.Trim()
            oForm = Application.SBO_Application.Forms.Item(Me.UIAPIRawForm.UniqueID)
            Dim oUDS As SAPbouiCOM.UserDataSource = oForm.DataSources.UserDataSources.Item("UD_DESDEF")
            Dim sFormOrig As String = oUDS.ValueEx
            Dim nProx As Integer = 0

            If Me.EditText0.Value.Trim.Length() > 0 Then

                If Validar_Codigo_Proyecto(Me.EditText0.Value.Trim()) Then

                    If Validar_Campos_Requeridos() Then

                        'Conectar_Aplicacion()
                        'If Application.SBO_Application.MessageBox("Registrar el Proyecto", 2, "Registrar", "Cancelar") = 1 Then

                        '------------------------------------------------------------------------------------
                        ' Registro de Nuevo Proyecto en la UDT (@ZINFOP)
                        '------------------------------------------------------------------------------------
                        oUDS = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UDS_CFLSLP")
                        Dim sCodVend As String = oUDS.ValueEx        'Aca nos traemos el Codigo del Vendedor guardado en el User Data Source cargado por el CFL
                        Dim sVendName As String = Me.EditText4.Value.Trim.Replace("'", "''")
                        Dim sCardName As String = Me.EditText1.Value.Trim.Replace("'", "''")
                        Dim sPrjName As String = Me.EditText2.Value.Trim.Replace("'", "''")
                        Dim sql As String
                        Dim ProyIni As String = If(Me.OptionBtn7.Selected, EditText0.Value, EditText32.Value)
                        Dim MontoOCCE = If(Me.OptionBtn7.Selected, Me.EditText8.String.Trim(), Me.EditText31.String.Trim())


                        Try

                            NProyectos.InsertarProyectoBase(Me.EditText0.Value.Trim(),
                                sPrjName,
                                Me.EditText3.String.Trim(),
                                sCardName,
                                Me.EditText15.String.Trim(),
                                Me.EditText16.String.Trim(),
                                Me.EditText10.String.Trim(),
                                Me.EditText11.String.Trim(),
                                Me.EditText12.String.Trim(),
                                Me.EditText13.String.Trim(),
                                Me.EditText14.String.Trim(),
                                If(Me.ComboBox0.Value = "Si", "Y", "N"),
                                Me.EditText9.String.Trim(),
                                If(Me.CheckBox3.Checked, "Y", "N"),
                                If(Me.CheckBox2.Checked, "Y", "N"),
                                Me.EditText23.String.Trim(),
                                Me.EditText25.String.Trim(),
                                Me.EditText26.String.Trim(),
                                If(Me.OptionBtn2.Selected, "D", If(Me.OptionBtn3.Selected, "S", If(Me.OptionBtn4.Selected, "M", ""))),
                                Me.EditText24.String.Trim(),
                                sCodVend,
                                sVendName,
                                Me.EditText5.String.Trim(),
                                Me.EditText6.String.Trim(),
                                nProx.ToString,
                                oConectarAplicacion.sCodUsuActual.ToString(),
                                DateTime.Now.ToString(),
                                Me.EditText7.String.Trim(),
                                If(Me.CheckBox1.Checked, "1", "0"),
                                If(Me.CheckBox0.Checked, "1", "0"),
                                Me.EditText8.String.Trim(),
                                If(Me.OptionBtn0.Selected, "C", "I"),
                                "N",
                                 ComboBox1.Value,
                                 EditText29.String.Trim(),
                                 EditText30.String.Trim(),
                                 ComboBox2.Selected.Value,
                                MontoOCCE,
                                If(Me.OptionBtn5.Selected, "Y", "N"),
                                ProyIni.Trim(),
                                If(Me.OptionBtn7.Selected, "U", "E"))

                            Validador = True

                        Catch ex As Exception
                            Application.SBO_Application.MessageBox(ex.Message)
                            Validador = False
                        End Try

                        'Codigo Anterior en insertar #proyecto en  #Region "Codigo Anterior"

                        '------------------------------------------------------------------------------------
                        ' Registro de Nuevo Proyecto en la tabla OPRJ (Se registrara en Industrial y Montaje por el B1if)
                        '------------------------------------------------------------------------------------
                        ' Comercial
                        '------------------------------------------------------------------------------------
                        If Validador Then

                            Try
                                Dim Add = NProjectSAP.AddProject(Me.EditText0.Value.Trim(),
                                                       sPrjName,
                                                       Me.EditText3.Value.Trim(),
                                                       sCardName)
                                If Add = "S" Then
                                    Validador = True
                                Else
                                    Validador = False
                                    Application.SBO_Application.MessageBox(Add)
                                End If

                            Catch ex As Exception
                                Validador = False
                            End Try

                        End If

                        '------------------------------------------------------------------------------------
                        ' Registro de Documentos Anexos al Proyecto (@ZPLAP)
                        '------------------------------------------------------------------------------------

                        If Validador Then

                            'Recorrer la Matrix
                            Dim rowNum As Integer = 0
                            Dim ArchivoO As String = ""
                            Dim ArchivoD As String = ""
                            Dim Fecha As Date
                            Dim Hora As String = ""
                            Dim Comentario As String

                            For index = 1 To Me.Matrix0.RowCount

                                'rowNum = Me.Matrix0.GetNextSelectedRow(0, SAPbouiCOM.BoOrderType.ot_RowOrder) - 1

                                ArchivoO = Me.Matrix0.Columns.Item("Col_0").Cells.Item(index).Specific.Value()

                                Application.SBO_Application.Forms.ActiveForm.Freeze(True)

                                Me.EditText27.Value = ArchivoO
                                oFunciones.Copiar_Documentos_Anexos_a_Servidor(Me.EditText27)
                                ArchivoD = Me.EditText27.Value()
                                Fecha = DateTime.ParseExact(Me.Matrix0.Columns.Item("Col_1").Cells.Item(index).Specific.Value(), "yyyyMMdd", Nothing).ToString("dd\/MM\/yyyy")
                                Hora = Me.Matrix0.Columns.Item("Col_2").Cells.Item(index).Specific.Value()
                                Comentario = Me.Matrix0.Columns.Item("Col_3").Cells.Item(index).Specific.Value()

                                Try
                                    sql = NDocumProyecto.Insertar_Documento(Me.EditText0.Value.Trim(),
                                                                    ArchivoO,
                                                                    ArchivoD,
                                                                    Fecha,
                                                                    Hora,
                                                                    oCompany.UserSignature.ToString(),
                                                                    "DOC",
                                                                    Comentario,
                                                                    "",
                                                                    "DOCUMENTO",
                                                                    index.ToString)
                                    Validador = True
                                Catch ex As Exception
                                    Application.SBO_Application.MessageBox(ex.Message)
                                    Validador = False
                                Finally
                                    Me.EditText27.Value = ""
                                    Application.SBO_Application.Forms.ActiveForm.Freeze(False)
                                End Try
                            Next

                        End If

                        '------------------------------------------------------------------------------------
                        ' Verificacion de que todos los INSERT se realizaron correctamente
                        '------------------------------------------------------------------------------------

                        If Validador Then
                            Application.SBO_Application.StatusBar.SetText("Registro de Nuevo Proyecto Exitoso", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success)
                            Me.UIAPIRawForm.Close()
                        End If

                        '-----------------------------------------------------------------------------------------
                        ' Si el Formulario fue llamado desde el Form de Pedidos, se carga los datos del proyecto
                        '-----------------------------------------------------------------------------------------
                        If AbiertoDesdeForm And Validador Then

                            AbiertoDesdeForm = False

                            SystemForm2.Cargar_Datos_Al_Seleccionar_Proyecto(sFormOrig, sCodPro)

                        End If
                    End If
                End If
            Else
                Application.SBO_Application.MessageBox("Debe Ingresar un Codigo para el Nuevo Proyecto", 1)
            End If

        End Sub

        Private Function Validar_Codigo_Proyecto(sCodigo As String) As Boolean

            Dim sql As String = "SELECT PrjCode as Codigo ,PrjName as Nombre FROM [" + sBDComercial.Trim() + "].[dbo].[OPRJ] where PrjCode = '" + sCodigo + "'"

            Try
                Try
                    DT_SQLX.ExecuteQuery(sql)
                Catch ex As Exception
                End Try
            Catch ex As Exception
                Application.SBO_Application.MessageBox(sql)
                Application.SBO_Application.MessageBox(ex.Message)
            End Try

            If DT_SQLX.Rows.Count > 0 And DT_SQLX.IsEmpty = False Then
                Application.SBO_Application.MessageBox("Ya Existe un Proyecto Asociado al Codigo '" + Me.EditText0.Value.Trim() + "'", 1)
                Return False
            Else
                Return True
            End If

        End Function

        Private Function Validar_Campos_Requeridos() As Boolean

            Dim Validador As Boolean = False

            If Me.EditText3.Value.Trim.Length() = 0 Then
                Application.SBO_Application.MessageBox("Debe Seleccionar un Codigo de Cliente")
                Validador = False
            ElseIf Me.EditText1.Value.Trim.Length() = 0 Then
                Application.SBO_Application.MessageBox("Debe Seleccionar un Nombre de Cliente")
                Validador = False
            ElseIf Me.EditText4.Value.Trim.Length() = 0 Then
                Application.SBO_Application.MessageBox("Debe Seleccionar un Nombre de Vendedor")
                Validador = False
            ElseIf Me.EditText15.Value.Trim.Length() = 0 Then
                Application.SBO_Application.MessageBox("Debe Seleccionar una Fecha de Venta Valida")
                Validador = False
            ElseIf Me.EditText16.Value.Trim.Length() = 0 Then
                Application.SBO_Application.MessageBox("Debe Seleccionar una Fecha Prometida Valida")
                Validador = False
            ElseIf Me.EditText10.Value.Trim.Length() = 0 Then
                Application.SBO_Application.MessageBox("Debe Seleccionar una Fecha de Termino de Desarrollo Valida")
                Validador = False
            ElseIf Me.EditText11.Value.Trim.Length() = 0 Then
                Application.SBO_Application.MessageBox("Debe Seleccionar una Fecha de Termino de Produccion Valida")
                Validador = False
            ElseIf Me.EditText12.Value.Trim.Length() = 0 Then
                Application.SBO_Application.MessageBox("Debe Seleccionar una Fecha de Inicio de Despacho Valida")
                Validador = False
            ElseIf Me.EditText13.Value.Trim.Length() = 0 Then
                Application.SBO_Application.MessageBox("Debe Seleccionar una Fecha de Inicio de Montaje Valida")
                Validador = False
            ElseIf Me.EditText14.Value.Trim.Length() = 0 Then
                Application.SBO_Application.MessageBox("Debe Seleccionar una Fecha de Termino de Montaje Valida")
                Validador = False
            ElseIf Me.EditText2.Value.Trim.Length() = 0 Then
                Application.SBO_Application.MessageBox("Debe Ingresar el Nombre del Proyecto")
                Validador = False
            ElseIf (Me.CheckBox2.Checked = False And Me.CheckBox3.Checked = False And Me.ComboBox0.Value = "Si") Then
                Application.SBO_Application.MessageBox("Debe Seleccionar al Menos un Tipo de Multa")
                Validador = False
            Else
                Validador = True
            End If

            If Me.EditText5.Value.Trim().Length > 0 And Validador Then
                Dim sql As String = "SELECT  Opprid,CardCode FROM [" + sBDComercial.Trim() + "].[dbo].[OOPR] where OpprId = '" + EditText5.Value.Trim() + "'"

                Try

                    DT_SQLX.ExecuteQuery(sql)
                    If DT_SQLX.IsEmpty = False Then
                        If Me.EditText3.Value.Trim <> DT_SQLX.GetValue("CardCode", 0) Then
                            If Application.SBO_Application.MessageBox("EL Codigo del Cliente del Proyecto es Distinto al de la Oportunidad de Venta, ¿Continuar con el Registro?", 1, "Registrar", "Cancelar") = 1 Then
                                Validador = True
                            Else
                                Validador = False
                            End If
                        End If
                    Else
                        Application.SBO_Application.MessageBox("El Numero de Oportunidad de Venta No Existe")
                        Validador = False
                    End If

                Catch ex As Exception

                    Application.SBO_Application.MessageBox(sql)
                    Application.SBO_Application.MessageBox(ex.Message)
                    Validador = False

                End Try
            End If

            Return Validador

        End Function

        Public Shared Sub Obtener_Proyecto_Asociado(FormID As String, sProyecto As String)

            Dim oFormP As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(FormID)
            oedit = oFormP.Items.Item("Item_107").Specific
            oedit.Value = sProyecto

        End Sub


#Region "Codigo Anterior Registrar Proyecto"
        '" INSERT INTO [" + sBDComercial.Trim() + "].[dbo].[@ZINFOP] " & _
        '  " ([U_DocEntry] " & _
        '  " ,[U_UserSign] " & _
        '  " ,[U_CreateDate] " & _
        '  " ,[U_PrjCode] " & _
        '  " ,[U_PrjName] " & _
        '  " ,[U_CardCode] " & _
        '  " ,[U_CardName]" & _
        '  " ,[U_Fec_Vta]  " & _
        '  " ,[U_Fec_Prom] " & _
        '  " ,[U_Fec_Ter_Desa] " & _
        '  " ,[U_Fec_Ter_Prod] " & _
        '  " ,[U_Fec_Ini_Desp] " & _
        '  " ,[U_Fec_Ini_Mont] " & _
        '  " ,[U_Fec_Ter_Mont] " & _
        '  " ,[U_Multa]" & _
        '  " ,[Code] " & _
        '  " ,[Name] " & _
        '  " ,[U_Comentario] " & _
        '  " ,[U_Multa_Desp] " & _
        '  " ,[U_Multa_Mont] " & _
        '  " ,[U_Fec_Ini_Multa] " & _
        '  " ,[U_Poc_Multa] " & _
        '  " ,[U_Tope_Multa] " & _
        '  " ,[U_Frec_Multa] " & _
        '  " ,[U_Coment_Multa] " & _
        '  " ,[U_Nro_Oport] " & _
        '  " ,[U_Nro_OC_Cliente] " & _
        '  " ,[U_SlpCode] " & _
        '  " ,[U_SlpName] " & _
        '  " ,[U_Contrato_Cli] " & _
        '  " ,[U_Con_Montaje] " & _
        '  " ,[U_Con_Despacho] " & _
        '  " ,[U_Monto_OCC] " & _
        '  " ,[U_Desa_Asigna]) " & _
        '  "  VALUES(" & _
        '  "  '" + nProx.ToString + "'" & _
        '  " ,'" + sCodUsuActual.ToString() + "'" & _
        '  " ,convert(datetime,'" + DateTime.Now.ToString() + "',103)," & _
        '  " '" + Me.EditText0.Value.Trim() + "'" & _
        '  " ,'" + sPrjName + "'" & _
        '  " ,'" + Me.EditText3.Value.Trim() + "' " & _
        '  " ,'" + sCardName + "'" & _
        '  " ,convert(date,'" + Me.EditText15.Value.Trim() + "',103) " & _
        '  " ,convert(date,'" + Me.EditText16.Value.Trim() + "',103) " & _
        '  " ,convert(date,'" + Me.EditText10.Value.Trim() + "',103) " & _
        '  " ,convert(date,'" + Me.EditText11.Value.Trim() + "',103) " & _
        '  " ,convert(date,'" + Me.EditText12.Value.Trim() + "',103) " & _
        '  " ,convert(date,'" + Me.EditText13.Value.Trim() + "',103) " & _
        '  " ,convert(date,'" + Me.EditText14.Value.Trim() + "',103)" & _
        '  " ,'" + If(Me.ComboBox0.Value = "Si", "Y", "N") + "'" & _
        '  " ,'" + nProx.ToString + "' " & _
        '  " ,'" + Me.EditText0.Value.Trim() + "' " & _
        '  " ,'" + Me.EditText9.Value.Trim() + "'" & _
        '  " ,'" + If(Me.CheckBox3.Checked, "Y", "N") + "'" & _
        '  " ,'" + If(Me.CheckBox2.Checked, "Y", "N") + "'" & _
        '  " ,convert(datetime,'" + Me.EditText23.Value.Trim() + "',103) " & _
        '  " , ISNULL(CAST(NULLIF('" + Me.EditText25.Value.Trim() + "', 'NULL') AS numeric(10, 2)), 0) " & _
        '  " , ISNULL(CAST(NULLIF('" + Me.EditText26.Value.Trim() + "', 'NULL') AS numeric(10, 2)), 0) " & _
        '  " ,'" + If(Me.OptionBtn2.Selected, "D", If(Me.OptionBtn3.Selected, "S", If(Me.OptionBtn4.Selected, "M", ""))) + "'" & _
        '  " ,'" + Me.EditText24.Value.Trim() + "'" & _
        '  " ,'" + Me.EditText15.Value.Trim() + "'" & _
        '  " ,'" + Me.EditText16.Value.Trim() + "'" & _
        '  " ,'" + sCodVend + "'" & _
        '  " ,'" + sVendName + "'" & _
        '  " ,'" + Me.EditText7.Value.Trim() + "'" & _
        '  " ," + If(Me.CheckBox1.Checked, "1", "0") + "" & _
        '  " ," + If(Me.CheckBox0.Checked, "1", "0") + "" & _
        '  " , ISNULL(CAST(NULLIF('" + Me.EditText8.Value.Trim() + "', 'NULL') AS numeric(10, 2)), 0) " & _
        '  " , '" + If(Me.OptionBtn0.Selected, "C", "I") + "')"




        ''------------------------------------------------------------------------------------
        '' Registro de Nuevo Proyecto en la tabla OPRJ de las 3 sociedades
        ''------------------------------------------------------------------------------------
        '' Comercial
        ''------------------------------------------------------------------------------------
        'If Validador Then

        '    sql = " INSERT INTO [" + sBDComercial.Trim() + "].[dbo].[OPRJ] " & _
        '          " ([PrjCode] " & _
        '          " ,[PrjName] " & _
        '          "  ,[Locked] " & _
        '          "  ,[DataSource] " & _
        '          "  ,[UserSign] " & _
        '          "  ,[Active] " & _
        '          "  ,[LogInstanc] " & _
        '          "  ,[U_CardCode],[U_CardName]) " & _
        '          "  VALUES(" & _
        '          "   '" + Me.EditText0.Value.Trim() + "'" & _
        '          "  ,'" + sPrjName + "'" & _
        '          "  ,'N'" & _
        '          "  ,'I'" & _
        '          "  ,'" + sCodUsuActual.ToString() + "'" & _
        '          "  ,'Y' " & _
        '          "  ,0 " & _
        '          " ,'" + Me.EditText3.Value.Trim() + "','" + sCardName + "') "

        '    Try

        '        DT_SQLX.ExecuteQuery(sql)
        '        Validador = True

        '    Catch ex As Exception

        '        Application.SBO_Application.MessageBox(sql)
        '        Me.EditText9.Value = sql
        '        Application.SBO_Application.MessageBox(ex.Message)
        '        Validador = False

        '    End Try

        'End If

        ''------------------------------------------------------------------------------------
        '' INDUSTRIAL
        ''------------------------------------------------------------------------------------
        'If Validador Then

        '    sql = " INSERT INTO [" + sBDIndustrial.Trim() + "].[dbo].[OPRJ] " & _
        '      " ([PrjCode] " & _
        '      " ,[PrjName] " & _
        '      "  ,[Locked] " & _
        '      "  ,[DataSource] " & _
        '      "  ,[UserSign] " & _
        '      "  ,[Active] " & _
        '      "  ,[LogInstanc]) " & _
        '      "  VALUES(" & _
        '      "   '" + Me.EditText0.Value.Trim() + "'" & _
        '      "  ,'" + sPrjName + "'" & _
        '      "  ,'N'" & _
        '      "  ,'I'" & _
        '      "  ,'1'" & _
        '      "  ,'Y' " & _
        '      "  ,0) "

        '    Try

        '        DT_SQLX.ExecuteQuery(sql)
        '        Validador = True

        '    Catch ex As Exception

        '        Application.SBO_Application.MessageBox(sql)
        '        Me.EditText9.Value = sql
        '        Application.SBO_Application.MessageBox(ex.Message)
        '        Validador = False

        '    End Try

        'End If

        ''------------------------------------------------------------------------------------
        '' MONTAJE
        ''------------------------------------------------------------------------------------

        'If Validador Then

        '    sql = " INSERT INTO [" + sBDMontaje.Trim() + "].[dbo].[OPRJ] " & _
        '          " ([PrjCode] " & _
        '          " ,[PrjName] " & _
        '          "  ,[Locked] " & _
        '          "  ,[DataSource] " & _
        '          "  ,[UserSign] " & _
        '          "  ,[Active] " & _
        '          "  ,[LogInstanc]) " & _
        '          "  VALUES(" & _
        '          "   '" + Me.EditText0.Value.Trim() + "'" & _
        '          "  ,'" + sPrjName + "'" & _
        '          "  ,'N'" & _
        '          "  ,'I'" & _
        '          "  ,'1'" & _
        '          "  ,'Y' " & _
        '          "  ,0) "

        '    Try

        '        DT_SQLX.ExecuteQuery(sql)
        '        Validador = True

        '    Catch ex As Exception

        '        Application.SBO_Application.MessageBox(sql)
        '        Me.EditText9.Value = sql
        '        Application.SBO_Application.MessageBox(ex.Message)
        '        Validador = False

        '    End Try

        'End If
#End Region

        '------------------------------------------------------

        Private WithEvents EditText0 As SAPbouiCOM.EditText
        Private WithEvents StaticText0 As SAPbouiCOM.StaticText
        Private WithEvents EditText1 As SAPbouiCOM.EditText
        Private WithEvents StaticText1 As SAPbouiCOM.StaticText
        Private WithEvents EditText2 As SAPbouiCOM.EditText
        Private WithEvents StaticText2 As SAPbouiCOM.StaticText
        Private WithEvents StaticText3 As SAPbouiCOM.StaticText
        Private WithEvents EditText3 As SAPbouiCOM.EditText
        Private WithEvents LinkedButton0 As SAPbouiCOM.LinkedButton
        Private WithEvents EditText4 As SAPbouiCOM.EditText
        Private WithEvents StaticText4 As SAPbouiCOM.StaticText
        Private WithEvents StaticText5 As SAPbouiCOM.StaticText
        Private WithEvents EditText5 As SAPbouiCOM.EditText
        Private WithEvents StaticText6 As SAPbouiCOM.StaticText
        Private WithEvents EditText6 As SAPbouiCOM.EditText
        Private WithEvents StaticText7 As SAPbouiCOM.StaticText
        Private WithEvents EditText7 As SAPbouiCOM.EditText
        Private WithEvents CheckBox0 As SAPbouiCOM.CheckBox
        Private WithEvents CheckBox1 As SAPbouiCOM.CheckBox
        Private WithEvents StaticText8 As SAPbouiCOM.StaticText
        Private WithEvents EditText8 As SAPbouiCOM.EditText
        Private WithEvents OptionBtn0 As SAPbouiCOM.OptionBtn
        Private WithEvents OptionBtn1 As SAPbouiCOM.OptionBtn
        Private WithEvents StaticText9 As SAPbouiCOM.StaticText
        Private WithEvents Button0 As SAPbouiCOM.Button
        Private WithEvents Button1 As SAPbouiCOM.Button
        Private WithEvents Button2 As SAPbouiCOM.Button
        Private WithEvents EditText9 As SAPbouiCOM.EditText
        Private WithEvents StaticText10 As SAPbouiCOM.StaticText
        Private WithEvents Button3 As SAPbouiCOM.Button
        Private WithEvents Folder0 As SAPbouiCOM.Folder
        Private WithEvents Folder1 As SAPbouiCOM.Folder
        Private WithEvents Folder2 As SAPbouiCOM.Folder
        Private WithEvents ComboBox0 As SAPbouiCOM.ComboBox
        Private WithEvents StaticText11 As SAPbouiCOM.StaticText
        Private WithEvents EditText10 As SAPbouiCOM.EditText
        Private WithEvents StaticText12 As SAPbouiCOM.StaticText
        Private WithEvents EditText11 As SAPbouiCOM.EditText
        Private WithEvents EditText12 As SAPbouiCOM.EditText
        Private WithEvents EditText13 As SAPbouiCOM.EditText
        Private WithEvents StaticText13 As SAPbouiCOM.StaticText
        Private WithEvents StaticText14 As SAPbouiCOM.StaticText
        Private WithEvents StaticText15 As SAPbouiCOM.StaticText
        Private WithEvents StaticText16 As SAPbouiCOM.StaticText
        Private WithEvents EditText14 As SAPbouiCOM.EditText
        Private WithEvents EditText15 As SAPbouiCOM.EditText
        Private WithEvents StaticText17 As SAPbouiCOM.StaticText
        Private WithEvents EditText16 As SAPbouiCOM.EditText
        Private WithEvents StaticText18 As SAPbouiCOM.StaticText
        Private WithEvents StaticText19 As SAPbouiCOM.StaticText
        Private WithEvents EditText17 As SAPbouiCOM.EditText
        Private WithEvents StaticText20 As SAPbouiCOM.StaticText
        Private WithEvents EditText18 As SAPbouiCOM.EditText
        Private WithEvents StaticText21 As SAPbouiCOM.StaticText
        Private WithEvents EditText19 As SAPbouiCOM.EditText
        Private WithEvents StaticText22 As SAPbouiCOM.StaticText
        Private WithEvents EditText20 As SAPbouiCOM.EditText
        Private WithEvents StaticText23 As SAPbouiCOM.StaticText
        Private WithEvents EditText21 As SAPbouiCOM.EditText
        Private WithEvents StaticText24 As SAPbouiCOM.StaticText
        Private WithEvents EditText22 As SAPbouiCOM.EditText
        Private WithEvents EditText23 As SAPbouiCOM.EditText
        Private WithEvents StaticText25 As SAPbouiCOM.StaticText
        Private WithEvents EditText24 As SAPbouiCOM.EditText
        Private WithEvents StaticText26 As SAPbouiCOM.StaticText
        Private WithEvents CheckBox2 As SAPbouiCOM.CheckBox
        Private WithEvents CheckBox3 As SAPbouiCOM.CheckBox
        Private WithEvents OptionBtn2 As SAPbouiCOM.OptionBtn
        Private WithEvents OptionBtn3 As SAPbouiCOM.OptionBtn
        Private WithEvents OptionBtn4 As SAPbouiCOM.OptionBtn
        Private WithEvents StaticText27 As SAPbouiCOM.StaticText
        Private WithEvents EditText25 As SAPbouiCOM.EditText
        Private WithEvents StaticText28 As SAPbouiCOM.StaticText
        Private WithEvents EditText26 As SAPbouiCOM.EditText
        Private WithEvents Matrix0 As SAPbouiCOM.Matrix
        Private WithEvents EditText27 As SAPbouiCOM.EditText
        Private WithEvents Button4 As SAPbouiCOM.Button
        Private WithEvents StaticText29 As SAPbouiCOM.StaticText
        Private WithEvents EditText28 As SAPbouiCOM.EditText
        Private WithEvents StaticText30 As SAPbouiCOM.StaticText
        Private WithEvents Button5 As SAPbouiCOM.Button
        Private WithEvents Button6 As SAPbouiCOM.Button
        Private WithEvents Folder3 As SAPbouiCOM.Folder
        Private WithEvents StaticText31 As SAPbouiCOM.StaticText
        Private WithEvents PictureBox0 As SAPbouiCOM.PictureBox
        Private WithEvents DT_0X As SAPbouiCOM.DataTable
        Private WithEvents DT_SQLX As SAPbouiCOM.DataTable
        Private WithEvents ComboBox1 As SAPbouiCOM.ComboBox
        Private WithEvents StaticText32 As SAPbouiCOM.StaticText
        Private WithEvents EditText29 As SAPbouiCOM.EditText
        Private WithEvents EditText30 As SAPbouiCOM.EditText
        Private WithEvents StaticText33 As SAPbouiCOM.StaticText
        Private WithEvents StaticText34 As SAPbouiCOM.StaticText
        Private WithEvents ComboBox2 As SAPbouiCOM.ComboBox
        Private WithEvents StaticText35 As SAPbouiCOM.StaticText
        Private WithEvents Folder4 As SAPbouiCOM.Folder
        Private WithEvents OptionBtn5 As SAPbouiCOM.OptionBtn
        Private WithEvents OptionBtn6 As SAPbouiCOM.OptionBtn
        Private WithEvents StaticText36 As SAPbouiCOM.StaticText
        Private WithEvents StaticText37 As SAPbouiCOM.StaticText
        Private WithEvents EditText31 As SAPbouiCOM.EditText
        Private WithEvents OptionBtn7 As SAPbouiCOM.OptionBtn
        Private WithEvents OptionBtn8 As SAPbouiCOM.OptionBtn
        Private WithEvents StaticText38 As SAPbouiCOM.StaticText
        Private WithEvents StaticText39 As SAPbouiCOM.StaticText
        Private WithEvents EditText32 As SAPbouiCOM.EditText
        Private WithEvents Button7 As SAPbouiCOM.Button






        '------------------------------------------------------

#Region "Codigo Anterior"

        '#Insertar Proyecto
        'sql = "exec [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Registrar_Proyecto] '" + nProx.ToString + "'" & _                       @U_DocEntry AS NVARCHAR(250)
        '      " ,'" + oConectarAplicacion.sCodUsuActual.ToString() + "'" & _                                                            ,@U_UserSign AS NVARCHAR(250)
        '      " ,'" + DateTime.Now.ToString() + "'" & _                                                                                 ,@U_CreateDate AS NVARCHAR(250)
        '      " ,'" + Me.EditText0.Value.Trim() + "'" & _                                                                               ,@U_PrjCode AS NVARCHAR(250)
        '      " ,'" + sPrjName + "'" & _                                                                                                ,@U_PrjName AS NVARCHAR(250)
        '      " ,'" + Me.EditText3.Value.Trim() + "'" & _                                                                               ,@U_CardCode AS NVARCHAR(250)
        '      " ,'" + sCardName + "'" & _                                                                                               ,@U_CardName AS NVARCHAR(250)
        '      " ,'" + Me.EditText15.Value.Trim() + "'" & _                                                                              ,@U_Fec_Vta  AS NVARCHAR(250)
        '      " ,'" + Me.EditText16.Value.Trim() + "'" & _                                                                              ,@U_Fec_Prom AS NVARCHAR(250)
        '      " ,'" + Me.EditText10.Value.Trim() + "'" & _                                                                              ,@U_Fec_Ter_Desa AS NVARCHAR(250)
        '      " ,'" + Me.EditText11.Value.Trim() + "'" & _                                                                              ,@U_Fec_Ter_Prod AS NVARCHAR(250)
        '      " ,'" + Me.EditText12.Value.Trim() + "'" & _                                                                              ,@U_Fec_Ini_Desp AS NVARCHAR(250)
        '      " ,'" + Me.EditText13.Value.Trim() + "'" & _                                                                              ,@U_Fec_Ini_Mont AS NVARCHAR(250)
        '      " ,'" + Me.EditText14.Value.Trim() + "'" & _                                                                              ,@U_Fec_Ter_Mont AS NVARCHAR(250)
        '      " ,'" + If(Me.ComboBox0.Value = "Si", "Y", "N") + "'" & _                                                                 ,@U_Multa AS NVARCHAR(250)
        '      " ,'" + nProx.ToString + "'" & _                                                                                          ,@Code AS NVARCHAR(250)
        '      " ,'" + Me.EditText0.Value.Trim() + "'" & _                                                                               ,@Name AS NVARCHAR(250)
        '      " ,'" + Me.EditText9.Value.Trim() + "'" & _                                                                               ,@U_Comentario AS NTEXT
        '      " ,'" + If(Me.CheckBox3.Checked, "Y", "N") + "'" & _                                                                      ,@U_Multa_Desp AS NVARCHAR(250)
        '      " ,'" + If(Me.CheckBox2.Checked, "Y", "N") + "'" & _                                                                      ,@U_Multa_Mont AS NVARCHAR(250)
        '      " ,'" + Me.EditText23.Value.Trim() + "'" & _                                                                              ,@U_Fec_Ini_Multa AS NVARCHAR(250)
        '      " ,'" + Me.EditText25.Value.Trim() + "'" & _                                                                              ,@U_Poc_Multa AS NVARCHAR(250)
        '      " ,'" + Me.EditText26.Value.Trim() + "'" & _                                                                              ,@U_Tope_Multa AS NVARCHAR(250)
        '      " ,'" + If(Me.OptionBtn2.Selected, "D", If(Me.OptionBtn3.Selected, "S", If(Me.OptionBtn4.Selected, "M", ""))) + "'" & _   ,@U_Frec_Multa AS NVARCHAR(250)
        '      " ,'" + Me.EditText24.Value.Trim() + "'" & _                                                                              ,@U_Coment_Multa AS NVARCHAR(250)
        '      " ,'" + Me.EditText15.Value.Trim() + "'" & _                                                                              ,@U_Nro_Oport AS NVARCHAR(250)
        '      " ,'" + Me.EditText16.Value.Trim() + "'" & _                                                                              ,@U_Nro_OC_Cliente AS NVARCHAR(250)
        '      " ,'" + sCodVend + "'" & _                                                                                                ,@U_SlpCode AS NVARCHAR(250)
        '      " ,'" + sVendName + "'" & _                                                                                               ,@U_SlpName AS NVARCHAR(250)
        '      " ,'" + Me.EditText7.Value.Trim() + "'" & _                                                                               ,@U_Contrato_Cli AS NVARCHAR(250)
        '      " ,'" + If(Me.CheckBox1.Checked, "1", "0") + "'" & _                                                                      ,@U_Con_Montaje AS NVARCHAR(250)
        '      " ,'" + If(Me.CheckBox0.Checked, "1", "0") + "'" & _                                                                      ,@U_Con_Despacho AS NVARCHAR(250)
        '      " ,'" + Me.EditText8.Value.Trim() + "'" & _                                                                               ,@U_Monto_OCC AS NVARCHAR(250)
        '      " ,'" + If(Me.OptionBtn0.Selected, "C", "I") + "'"                                                                        ,@U_Desa_Asigna AS NVARCHAR(250)


        'Try
        '    DT_SQLX.ExecuteQuery(sql)
        '    Validador = True

        'Catch ex As Exception
        '    Me.EditText9.Value = sql
        '    Application.SBO_Application.MessageBox(ex.Message)
        '    Validador = False

        'End Try

        'nProx = oFunciones.Proximo_Codigo_Correlativo("@ZINFOP", "U_DocEntry", DT_SQLX)

        'nProx = oFunciones.Proximo_Codigo_Correlativo("@ZPLAP", "code", DT_SQLX)

        'sql = " INSERT INTO  " + sBDComercial.Trim() + ".[dbo].[@ZPLAP] " & _
        '        " ([Code],[Name],[U_PrjCode],[U_PathOrigen] " & _
        '        " ,[U_PtahServer],[U_Fec_Registro],[U_Hora_Registro],[U_User_Id] " & _
        '        " ,[U_Tipo_Plano],[U_Comentario],[U_Status],[U_Tipo_Documento],[U_Renglon] )" & _
        '        " VALUES " & _
        '        " ('" + nProx.ToString() + "','" + nProx.ToString() + "','" + Me.EditText0.Value.Trim() + "','" + ArchivoO + "'" & _
        '        " ,'" + ArchivoD + "',convert(date,'" + Fecha + "',103) ,'" + Hora + "','" + oCompany.UserSignature.ToString() + "'" & _
        '        " ,'DOC','" + Comentario + "','','DOCUMENTO','" + index.ToString + "')"

        'DT_SQLX.ExecuteQuery(sql)

        'Try
        '    oForm = Application.SBO_Application.Forms.GetForm(sFormOrig, 0)
        '    oForm.Freeze(True)
        '    oForm.Select()
        '    oForm.Mode = SAPbouiCOM.BoFormMode.fm_ADD_MODE

        '    oForm.PaneLevel = 7
        '    oedit = oForm.Items.Item("157").Specific
        '    oedit.Item.Click()
        '    oedit.Value = sCodPro
        '    Application.SBO_Application.SendKeys("{TAB}")

        '    Dim oedit2 As SAPbouiCOM.EditText

        '    Call Cargar_Datos_Proyecto(oForm, sCodPro, oForm.UniqueID, "")

        '    oedit2 = oForm.Items.Item("157").Specific
        '    oedit2.Value = sCodPro

        '    oForm.Items.Item("14").Click()

        'Catch ex As Exception

        'Finally
        '    oForm.Freeze(False)
        'End Try
#End Region

    End Class
End Namespace
