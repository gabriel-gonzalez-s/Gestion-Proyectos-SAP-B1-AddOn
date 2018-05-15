Module FrmEstadoGlobalResp
    '    Option Strict Off
    '    Option Explicit On

    '    Imports SAPbouiCOM.Framework
    '    Imports System.Reflection
    '    Imports FuncionalidadesSDKB1

    'Namespace SBOAddonProject1
    '    <FormAttribute("SBOAddonProject1.FrmEstado_Global", "3_Presentation_Layer/Pantallas Principales/FrmEstado_Global.b1f")>
    '    Friend Class FrmEstado_Global
    '        Inherits UserFormBase

    '        Public Sub New()
    '        End Sub

    '#Region "Respaldo de OnInitializeComponent"
    '        'Me.Button0 = CType(Me.GetItem("Item_68").Specific, SAPbouiCOM.Button)
    '        'Me.EditText0 = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText1 = CType(Me.GetItem("Item_2").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText2 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText3 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText4 = CType(Me.GetItem("Item_28").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText5 = CType(Me.GetItem("Item_30").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText6 = CType(Me.GetItem("Item_49").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText7 = CType(Me.GetItem("Item_54").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText8 = CType(Me.GetItem("Item_8").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText9 = CType(Me.GetItem("Item_18").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText10 = CType(Me.GetItem("Item_39").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText11 = CType(Me.GetItem("Item_50").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText12 = CType(Me.GetItem("Item_59").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText13 = CType(Me.GetItem("Item_10").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText14 = CType(Me.GetItem("Item_20").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText15 = CType(Me.GetItem("Item_41").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText16 = CType(Me.GetItem("Item_48").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText17 = CType(Me.GetItem("Item_61").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText18 = CType(Me.GetItem("Item_11").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText19 = CType(Me.GetItem("Item_21").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText20 = CType(Me.GetItem("Item_43").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText21 = CType(Me.GetItem("Item_32").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText22 = CType(Me.GetItem("Item_53").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText23 = CType(Me.GetItem("Item_63").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText24 = CType(Me.GetItem("Item_12").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText25 = CType(Me.GetItem("Item_22").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText26 = CType(Me.GetItem("Item_34").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText27 = CType(Me.GetItem("Item_45").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText28 = CType(Me.GetItem("Item_55").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText29 = CType(Me.GetItem("Item_65").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText30 = CType(Me.GetItem("Item_17").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText31 = CType(Me.GetItem("Item_27").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText32 = CType(Me.GetItem("Item_36").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText33 = CType(Me.GetItem("Item_47").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText34 = CType(Me.GetItem("Item_57").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText35 = CType(Me.GetItem("Item_67").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText36 = CType(Me.GetItem("Item_74").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText37 = CType(Me.GetItem("Item_75").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText38 = CType(Me.GetItem("Item_77").Specific, SAPbouiCOM.EditText)
    '        'Me.Button1 = CType(Me.GetItem("Item_105").Specific, SAPbouiCOM.Button)
    '        'Me.Button2 = CType(Me.GetItem("Item_98").Specific, SAPbouiCOM.Button)
    '        'Me.Button3 = CType(Me.GetItem("Item_83").Specific, SAPbouiCOM.Button)
    '        'Me.Button4 = CType(Me.GetItem("Item_86").Specific, SAPbouiCOM.Button)
    '        'Me.Button5 = CType(Me.GetItem("Item_89").Specific, SAPbouiCOM.Button)
    '        'Me.Button6 = CType(Me.GetItem("Item_92").Specific, SAPbouiCOM.Button)
    '        'Me.Button7 = CType(Me.GetItem("Item_95").Specific, SAPbouiCOM.Button)
    '        'Me.Folder0 = CType(Me.GetItem("Item_104").Specific, SAPbouiCOM.Folder)
    '        'Me.EditText40 = CType(Me.GetItem("Item_106").Specific, SAPbouiCOM.EditText)
    '        'Me.StaticText0 = CType(Me.GetItem("Item_107").Specific, SAPbouiCOM.StaticText)
    '        'Me.EditText41 = CType(Me.GetItem("Item_102").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText42 = CType(Me.GetItem("Item_101").Specific, SAPbouiCOM.EditText)
    '        'Me.StaticText1 = CType(Me.GetItem("Item_108").Specific, SAPbouiCOM.StaticText)
    '        'Me.ComboBox7 = CType(Me.GetItem("Item_81").Specific, SAPbouiCOM.ComboBox)
    '        'Me.StaticText2 = CType(Me.GetItem("Item_84").Specific, SAPbouiCOM.StaticText)
    '        'Me.ComboBox0 = CType(Me.GetItem("Item_85").Specific, SAPbouiCOM.ComboBox)
    '        'Me.StaticText3 = CType(Me.GetItem("Item_87").Specific, SAPbouiCOM.StaticText)
    '        'Me.ComboBox1 = CType(Me.GetItem("Item_88").Specific, SAPbouiCOM.ComboBox)
    '        'Me.StaticText4 = CType(Me.GetItem("Item_90").Specific, SAPbouiCOM.StaticText)
    '        'Me.ComboBox2 = CType(Me.GetItem("Item_91").Specific, SAPbouiCOM.ComboBox)
    '        'Me.StaticText5 = CType(Me.GetItem("Item_93").Specific, SAPbouiCOM.StaticText)
    '        'Me.ComboBox3 = CType(Me.GetItem("Item_94").Specific, SAPbouiCOM.ComboBox)
    '        'Me.StaticText6 = CType(Me.GetItem("Item_96").Specific, SAPbouiCOM.StaticText)
    '        'Me.ComboBox4 = CType(Me.GetItem("Item_97").Specific, SAPbouiCOM.ComboBox)
    '        'Me.StaticText7 = CType(Me.GetItem("Item_99").Specific, SAPbouiCOM.StaticText)
    '        'Me.ComboBox5 = CType(Me.GetItem("Item_100").Specific, SAPbouiCOM.ComboBox)
    '        'Me.Folder1 = CType(Me.GetItem("Item_109").Specific, SAPbouiCOM.Folder)
    '        'Me.Folder2 = CType(Me.GetItem("Item_110").Specific, SAPbouiCOM.Folder)
    '        'Me.EditText43 = CType(Me.GetItem("Item_112").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText45 = CType(Me.GetItem("Item_114").Specific, SAPbouiCOM.EditText)
    '        'Me.Button8 = CType(Me.GetItem("Item_115").Specific, SAPbouiCOM.Button)
    '        'Me.StaticText8 = CType(Me.GetItem("Item_116").Specific, SAPbouiCOM.StaticText)
    '        'Me.StaticText9 = CType(Me.GetItem("Item_117").Specific, SAPbouiCOM.StaticText)
    '        'Me.Button9 = CType(Me.GetItem("Item_118").Specific, SAPbouiCOM.Button)
    '        'Me.Button10 = CType(Me.GetItem("Item_119").Specific, SAPbouiCOM.Button)
    '        'Me.DT_0X = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_0X")
    '        'Me.DT_INFO = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_INFO")
    '        'Me.DT_SQL1 = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_SQL1")
    '        'Me.DT_SQL2 = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_SQL1")
    '        'Me.Button11 = CType(Me.GetItem("Item_113").Specific, SAPbouiCOM.Button)
    '        'Me.EditText44 = CType(Me.GetItem("Item_120").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText46 = CType(Me.GetItem("Item_121").Specific, SAPbouiCOM.EditText)
    '        'Me.Button12 = CType(Me.GetItem("Item_122").Specific, SAPbouiCOM.Button)
    '        'Me.EditText47 = CType(Me.GetItem("Item_123").Specific, SAPbouiCOM.EditText)
    '        'Me.StaticText10 = CType(Me.GetItem("Item_124").Specific, SAPbouiCOM.StaticText)
    '        'Me.LinkedButton0 = CType(Me.GetItem("Item_125").Specific, SAPbouiCOM.LinkedButton)
    '        'Me.FiltrarChooseFromList(Me.UIAPIRawForm.UniqueID, "CFL_3")
    '        'Me.FiltrarChooseFromList(Me.UIAPIRawForm.UniqueID, "CFL_4")
    '        'Me.Button13 = CType(Me.GetItem("Item_127").Specific, SAPbouiCOM.Button)
    '        'Me.EditText48 = CType(Me.GetItem("Item_126").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText50 = CType(Me.GetItem("Item_79").Specific, SAPbouiCOM.EditText)
    '        'Me.PictureBox0 = CType(Me.GetItem("Item_128").Specific, SAPbouiCOM.PictureBox)
    '        'Me.PictureBox0.Picture = (Module1.sPathAnexos).Trim() + "images\User.png"
    '        'Me.Folder3 = CType(Me.GetItem("Item_129").Specific, SAPbouiCOM.Folder)
    '        'Me.EditText39 = CType(Me.GetItem("Item_130").Specific, SAPbouiCOM.EditText)
    '        'Me.OptionBtn0 = CType(Me.GetItem("Item_131").Specific, SAPbouiCOM.OptionBtn)
    '        'Me.OptionBtn1 = CType(Me.GetItem("Item_132").Specific, SAPbouiCOM.OptionBtn)
    '        'Me.OptionBtn2 = CType(Me.GetItem("Item_133").Specific, SAPbouiCOM.OptionBtn)
    '        'Me.CheckBox0 = CType(Me.GetItem("Item_134").Specific, SAPbouiCOM.CheckBox)
    '        'Me.CheckBox1 = CType(Me.GetItem("Item_135").Specific, SAPbouiCOM.CheckBox)
    '        'Me.EditText49 = CType(Me.GetItem("Item_136").Specific, SAPbouiCOM.EditText)
    '        'Me.StaticText11 = CType(Me.GetItem("Item_137").Specific, SAPbouiCOM.StaticText)
    '        'Me.StaticText12 = CType(Me.GetItem("Item_138").Specific, SAPbouiCOM.StaticText)
    '        'Me.EditText51 = CType(Me.GetItem("Item_139").Specific, SAPbouiCOM.EditText)
    '        'Me.StaticText13 = CType(Me.GetItem("Item_140").Specific, SAPbouiCOM.StaticText)
    '        'Me.EditText52 = CType(Me.GetItem("Item_141").Specific, SAPbouiCOM.EditText)
    '        'Me.StaticText14 = CType(Me.GetItem("Item_142").Specific, SAPbouiCOM.StaticText)
    '        'Me.StaticText15 = CType(Me.GetItem("Item_143").Specific, SAPbouiCOM.StaticText)
    '        'Me.StaticText16 = CType(Me.GetItem("Item_144").Specific, SAPbouiCOM.StaticText)
    '        'Me.Button14 = CType(Me.GetItem("Item_145").Specific, SAPbouiCOM.Button)
    '        'Me.Button15 = CType(Me.GetItem("Item_146").Specific, SAPbouiCOM.Button)
    '        'Me.EditText53 = CType(Me.GetItem("Item_147").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText54 = CType(Me.GetItem("Item_148").Specific, SAPbouiCOM.EditText)
    '        'Me.StaticText17 = CType(Me.GetItem("Item_149").Specific, SAPbouiCOM.StaticText)
    '        'Me.ComboBox6 = CType(Me.GetItem("Item_152").Specific, SAPbouiCOM.ComboBox)
    '        'Me.StaticText18 = CType(Me.GetItem("Item_153").Specific, SAPbouiCOM.StaticText)
    '        'Me.Folder4 = CType(Me.GetItem("Item_154").Specific, SAPbouiCOM.Folder)
    '        'Me.Button16 = CType(Me.GetItem("Item_155").Specific, SAPbouiCOM.Button)
    '        'Me.Button17 = CType(Me.GetItem("Item_156").Specific, SAPbouiCOM.Button)
    '        'Me.EditText55 = CType(Me.GetItem("Item_157").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText56 = CType(Me.GetItem("Item_158").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText57 = CType(Me.GetItem("Item_159").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText58 = CType(Me.GetItem("Item_160").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText59 = CType(Me.GetItem("Item_161").Specific, SAPbouiCOM.EditText)
    '        'Me.StaticText19 = CType(Me.GetItem("Item_162").Specific, SAPbouiCOM.StaticText)
    '        'Me.StaticText20 = CType(Me.GetItem("Item_163").Specific, SAPbouiCOM.StaticText)
    '        'Me.StaticText21 = CType(Me.GetItem("Item_164").Specific, SAPbouiCOM.StaticText)
    '        'Me.Button18 = CType(Me.GetItem("Item_165").Specific, SAPbouiCOM.Button)
    '        'Me.StaticText22 = CType(Me.GetItem("Item_151").Specific, SAPbouiCOM.StaticText)
    '        'Me.StaticText23 = CType(Me.GetItem("Item_166").Specific, SAPbouiCOM.StaticText)
    '        'Me.EditText61 = CType(Me.GetItem("Item_168").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText62 = CType(Me.GetItem("Item_169").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText66 = CType(Me.GetItem("Item_173").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText67 = CType(Me.GetItem("Item_174").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText68 = CType(Me.GetItem("Item_175").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText69 = CType(Me.GetItem("Item_176").Specific, SAPbouiCOM.EditText)
    '        'Me.StaticText24 = CType(Me.GetItem("Item_177").Specific, SAPbouiCOM.StaticText)
    '        'Me.EditText71 = CType(Me.GetItem("Item_179").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText72 = CType(Me.GetItem("Item_180").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText63 = CType(Me.GetItem("Item_19").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText64 = CType(Me.GetItem("Item_181").Specific, SAPbouiCOM.EditText)
    '        'Me.Button19 = CType(Me.GetItem("Item_23").Specific, SAPbouiCOM.Button)
    '        'Me.StaticText25 = CType(Me.GetItem("Item_31").Specific, SAPbouiCOM.StaticText)
    '        'Me.StaticText26 = CType(Me.GetItem("Item_51").Specific, SAPbouiCOM.StaticText)
    '        'Me.StaticText27 = CType(Me.GetItem("Item_58").Specific, SAPbouiCOM.StaticText)
    '        'Me.StaticText28 = CType(Me.GetItem("Item_60").Specific, SAPbouiCOM.StaticText)
    '        'Me.StaticText29 = CType(Me.GetItem("Item_62").Specific, SAPbouiCOM.StaticText)
    '        'Me.StaticText30 = CType(Me.GetItem("Item_64").Specific, SAPbouiCOM.StaticText)
    '        'Me.StaticText31 = CType(Me.GetItem("Item_66").Specific, SAPbouiCOM.StaticText)
    '        'Me.EditText60 = CType(Me.GetItem("Item_24").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText70 = CType(Me.GetItem("Item_25").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText73 = CType(Me.GetItem("Item_26").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText74 = CType(Me.GetItem("Item_40").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText75 = CType(Me.GetItem("Item_42").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText65 = CType(Me.GetItem("Item_44").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText76 = CType(Me.GetItem("Item_46").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText77 = CType(Me.GetItem("Item_167").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText78 = CType(Me.GetItem("Item_170").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText79 = CType(Me.GetItem("Item_171").Specific, SAPbouiCOM.EditText)
    '        'Me.StaticText32 = CType(Me.GetItem("Item_182").Specific, SAPbouiCOM.StaticText)
    '        'Me.StaticText33 = CType(Me.GetItem("Item_183").Specific, SAPbouiCOM.StaticText)
    '        'Me.StaticText34 = CType(Me.GetItem("Item_184").Specific, SAPbouiCOM.StaticText)
    '        'Me.EditText80 = CType(Me.GetItem("Item_172").Specific, SAPbouiCOM.EditText)
    '        'Me.PictureBox2 = CType(Me.GetItem("Item_70").Specific, SAPbouiCOM.PictureBox)
    '        'Me.PictureBox3 = CType(Me.GetItem("Item_71").Specific, SAPbouiCOM.PictureBox)
    '        'Me.PictureBox4 = CType(Me.GetItem("Item_72").Specific, SAPbouiCOM.PictureBox)
    '        'Me.PictureBox5 = CType(Me.GetItem("Item_73").Specific, SAPbouiCOM.PictureBox)
    '        'Me.PictureBox6 = CType(Me.GetItem("Item_178").Specific, SAPbouiCOM.PictureBox)
    '        'Me.StaticText35 = CType(Me.GetItem("Item_33").Specific, SAPbouiCOM.StaticText)
    '        'Me.StaticText36 = CType(Me.GetItem("Item_35").Specific, SAPbouiCOM.StaticText)
    '        'Me.StaticText37 = CType(Me.GetItem("Item_37").Specific, SAPbouiCOM.StaticText)
    '        'Me.StaticText38 = CType(Me.GetItem("Item_186").Specific, SAPbouiCOM.StaticText)
    '        'Me.EditText82 = CType(Me.GetItem("Item_185").Specific, SAPbouiCOM.EditText)
    '        'Me.Folder5 = CType(Me.GetItem("Item_188").Specific, SAPbouiCOM.Folder)
    '        'Me.CheckBox2 = CType(Me.GetItem("Item_189").Specific, SAPbouiCOM.CheckBox)
    '        'Me.CheckBox3 = CType(Me.GetItem("Item_190").Specific, SAPbouiCOM.CheckBox)
    '        'Me.EditText81 = CType(Me.GetItem("Item_191").Specific, SAPbouiCOM.EditText)
    '        'Me.StaticText39 = CType(Me.GetItem("Item_192").Specific, SAPbouiCOM.StaticText)
    '        'Me.OptionBtn3 = CType(Me.GetItem("Item_193").Specific, SAPbouiCOM.OptionBtn)
    '        'Me.OptionBtn4 = CType(Me.GetItem("Item_194").Specific, SAPbouiCOM.OptionBtn)
    '        'Me.StaticText40 = CType(Me.GetItem("Item_195").Specific, SAPbouiCOM.StaticText)
    '        'Me.StaticText41 = CType(Me.GetItem("Item_196").Specific, SAPbouiCOM.StaticText)
    '        'Me.Button20 = CType(Me.GetItem("Item_197").Specific, SAPbouiCOM.Button)
    '        'Me.Button21 = CType(Me.GetItem("Item_198").Specific, SAPbouiCOM.Button)
    '        'Me.EditText83 = CType(Me.GetItem("Item_199").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText84 = CType(Me.GetItem("Item_200").Specific, SAPbouiCOM.EditText)
    '        'Me.StaticText42 = CType(Me.GetItem("Item_201").Specific, SAPbouiCOM.StaticText)
    '        'Me.EditText85 = CType(Me.GetItem("Item_202").Specific, SAPbouiCOM.EditText)
    '        'Me.StaticText43 = CType(Me.GetItem("Item_203").Specific, SAPbouiCOM.StaticText)
    '        'Me.EditText86 = CType(Me.GetItem("Item_204").Specific, SAPbouiCOM.EditText)
    '        'Me.Button22 = CType(Me.GetItem("Item_205").Specific, SAPbouiCOM.Button)
    '        'Me.PictureBox9 = CType(Me.GetItem("Item_213").Specific, SAPbouiCOM.PictureBox)
    '        'Me.PictureBox10 = CType(Me.GetItem("Item_214").Specific, SAPbouiCOM.PictureBox)
    '        'Me.Button23 = CType(Me.GetItem("Item_206").Specific, SAPbouiCOM.Button)
    '        'Me.PictureBox1 = CType(Me.GetItem("Item_150").Specific, SAPbouiCOM.PictureBox)
    '        'Me.Button37 = CType(Me.GetItem("Item_209").Specific, SAPbouiCOM.Button)
    '        'Me.ComboBox8 = CType(Me.GetItem("Item_207").Specific, SAPbouiCOM.ComboBox)
    '        'Me.StaticText44 = CType(Me.GetItem("Item_208").Specific, SAPbouiCOM.StaticText)
    '        'Me.Matrix1 = CType(Me.GetItem("Item_111").Specific, SAPbouiCOM.Matrix)
    '        'Me.ComboBox9 = CType(Me.GetItem("Item_210").Specific, SAPbouiCOM.ComboBox)
    '        'Me.ComboBox10 = CType(Me.GetItem("Item_211").Specific, SAPbouiCOM.ComboBox)
    '        'Me.StaticText45 = CType(Me.GetItem("Item_212").Specific, SAPbouiCOM.StaticText)
    '        'Me.StaticText46 = CType(Me.GetItem("Item_215").Specific, SAPbouiCOM.StaticText)
    '        'Me.StaticText47 = CType(Me.GetItem("Item_216").Specific, SAPbouiCOM.StaticText)
    '        'Me.StaticText48 = CType(Me.GetItem("Item_218").Specific, SAPbouiCOM.StaticText)
    '        'Me.EditText87 = CType(Me.GetItem("Item_217").Specific, SAPbouiCOM.EditText)
    '        'Me.EditText88 = CType(Me.GetItem("Item_219").Specific, SAPbouiCOM.EditText)

    '#End Region

    '        Public Overrides Sub OnInitializeComponent()
    '            Me.Button0 = CType(Me.GetItem("Item_68").Specific, SAPbouiCOM.Button)
    '            Me.EditText0 = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.EditText)
    '            Me.EditText1 = CType(Me.GetItem("Item_2").Specific, SAPbouiCOM.EditText)
    '            Me.EditText2 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.EditText)
    '            Me.EditText3 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.EditText)
    '            Me.EditText4 = CType(Me.GetItem("Item_28").Specific, SAPbouiCOM.EditText)
    '            Me.EditText5 = CType(Me.GetItem("Item_30").Specific, SAPbouiCOM.EditText)
    '            Me.EditText6 = CType(Me.GetItem("Item_49").Specific, SAPbouiCOM.EditText)
    '            Me.EditText7 = CType(Me.GetItem("Item_54").Specific, SAPbouiCOM.EditText)
    '            Me.EditText8 = CType(Me.GetItem("Item_8").Specific, SAPbouiCOM.EditText)
    '            Me.EditText9 = CType(Me.GetItem("Item_18").Specific, SAPbouiCOM.EditText)
    '            Me.EditText10 = CType(Me.GetItem("Item_39").Specific, SAPbouiCOM.EditText)
    '            Me.EditText11 = CType(Me.GetItem("Item_50").Specific, SAPbouiCOM.EditText)
    '            Me.EditText12 = CType(Me.GetItem("Item_59").Specific, SAPbouiCOM.EditText)
    '            Me.EditText13 = CType(Me.GetItem("Item_10").Specific, SAPbouiCOM.EditText)
    '            Me.EditText14 = CType(Me.GetItem("Item_20").Specific, SAPbouiCOM.EditText)
    '            Me.EditText15 = CType(Me.GetItem("Item_41").Specific, SAPbouiCOM.EditText)
    '            Me.EditText16 = CType(Me.GetItem("Item_48").Specific, SAPbouiCOM.EditText)
    '            Me.EditText17 = CType(Me.GetItem("Item_61").Specific, SAPbouiCOM.EditText)
    '            Me.EditText18 = CType(Me.GetItem("Item_11").Specific, SAPbouiCOM.EditText)
    '            Me.EditText19 = CType(Me.GetItem("Item_21").Specific, SAPbouiCOM.EditText)
    '            Me.EditText20 = CType(Me.GetItem("Item_43").Specific, SAPbouiCOM.EditText)
    '            Me.EditText21 = CType(Me.GetItem("Item_32").Specific, SAPbouiCOM.EditText)
    '            Me.EditText22 = CType(Me.GetItem("Item_53").Specific, SAPbouiCOM.EditText)
    '            Me.EditText23 = CType(Me.GetItem("Item_63").Specific, SAPbouiCOM.EditText)
    '            Me.EditText24 = CType(Me.GetItem("Item_12").Specific, SAPbouiCOM.EditText)
    '            Me.EditText25 = CType(Me.GetItem("Item_22").Specific, SAPbouiCOM.EditText)
    '            Me.EditText26 = CType(Me.GetItem("Item_34").Specific, SAPbouiCOM.EditText)
    '            Me.EditText27 = CType(Me.GetItem("Item_45").Specific, SAPbouiCOM.EditText)
    '            Me.EditText28 = CType(Me.GetItem("Item_55").Specific, SAPbouiCOM.EditText)
    '            Me.EditText29 = CType(Me.GetItem("Item_65").Specific, SAPbouiCOM.EditText)
    '            Me.EditText30 = CType(Me.GetItem("Item_17").Specific, SAPbouiCOM.EditText)
    '            Me.EditText31 = CType(Me.GetItem("Item_27").Specific, SAPbouiCOM.EditText)
    '            Me.EditText32 = CType(Me.GetItem("Item_36").Specific, SAPbouiCOM.EditText)
    '            Me.EditText33 = CType(Me.GetItem("Item_47").Specific, SAPbouiCOM.EditText)
    '            Me.EditText34 = CType(Me.GetItem("Item_57").Specific, SAPbouiCOM.EditText)
    '            Me.EditText35 = CType(Me.GetItem("Item_67").Specific, SAPbouiCOM.EditText)
    '            Me.EditText36 = CType(Me.GetItem("Item_74").Specific, SAPbouiCOM.EditText)
    '            Me.EditText37 = CType(Me.GetItem("Item_75").Specific, SAPbouiCOM.EditText)
    '            Me.EditText38 = CType(Me.GetItem("Item_77").Specific, SAPbouiCOM.EditText)
    '            Me.Button1 = CType(Me.GetItem("Item_105").Specific, SAPbouiCOM.Button)
    '            Me.Button2 = CType(Me.GetItem("Item_98").Specific, SAPbouiCOM.Button)
    '            Me.Button3 = CType(Me.GetItem("Item_83").Specific, SAPbouiCOM.Button)
    '            Me.Button4 = CType(Me.GetItem("Item_86").Specific, SAPbouiCOM.Button)
    '            Me.Button5 = CType(Me.GetItem("Item_89").Specific, SAPbouiCOM.Button)
    '            Me.Button6 = CType(Me.GetItem("Item_92").Specific, SAPbouiCOM.Button)
    '            Me.Button7 = CType(Me.GetItem("Item_95").Specific, SAPbouiCOM.Button)
    '            Me.Folder0 = CType(Me.GetItem("Item_104").Specific, SAPbouiCOM.Folder)
    '            Me.EditText40 = CType(Me.GetItem("Item_106").Specific, SAPbouiCOM.EditText)
    '            Me.StaticText0 = CType(Me.GetItem("Item_107").Specific, SAPbouiCOM.StaticText)
    '            Me.EditText41 = CType(Me.GetItem("Item_102").Specific, SAPbouiCOM.EditText)
    '            Me.EditText42 = CType(Me.GetItem("Item_101").Specific, SAPbouiCOM.EditText)
    '            Me.StaticText1 = CType(Me.GetItem("Item_108").Specific, SAPbouiCOM.StaticText)
    '            Me.ComboBox7 = CType(Me.GetItem("Item_81").Specific, SAPbouiCOM.ComboBox)
    '            Me.StaticText2 = CType(Me.GetItem("Item_84").Specific, SAPbouiCOM.StaticText)
    '            Me.ComboBox0 = CType(Me.GetItem("Item_85").Specific, SAPbouiCOM.ComboBox)
    '            Me.StaticText3 = CType(Me.GetItem("Item_87").Specific, SAPbouiCOM.StaticText)
    '            Me.ComboBox1 = CType(Me.GetItem("Item_88").Specific, SAPbouiCOM.ComboBox)
    '            Me.StaticText4 = CType(Me.GetItem("Item_90").Specific, SAPbouiCOM.StaticText)
    '            Me.ComboBox2 = CType(Me.GetItem("Item_91").Specific, SAPbouiCOM.ComboBox)
    '            Me.StaticText5 = CType(Me.GetItem("Item_93").Specific, SAPbouiCOM.StaticText)
    '            Me.ComboBox3 = CType(Me.GetItem("Item_94").Specific, SAPbouiCOM.ComboBox)
    '            Me.StaticText6 = CType(Me.GetItem("Item_96").Specific, SAPbouiCOM.StaticText)
    '            Me.ComboBox4 = CType(Me.GetItem("Item_97").Specific, SAPbouiCOM.ComboBox)
    '            Me.StaticText7 = CType(Me.GetItem("Item_99").Specific, SAPbouiCOM.StaticText)
    '            Me.ComboBox5 = CType(Me.GetItem("Item_100").Specific, SAPbouiCOM.ComboBox)
    '            Me.Folder1 = CType(Me.GetItem("Item_109").Specific, SAPbouiCOM.Folder)
    '            Me.Folder2 = CType(Me.GetItem("Item_110").Specific, SAPbouiCOM.Folder)
    '            Me.EditText43 = CType(Me.GetItem("Item_112").Specific, SAPbouiCOM.EditText)
    '            Me.EditText45 = CType(Me.GetItem("Item_114").Specific, SAPbouiCOM.EditText)
    '            Me.Button8 = CType(Me.GetItem("Item_115").Specific, SAPbouiCOM.Button)
    '            Me.StaticText8 = CType(Me.GetItem("Item_116").Specific, SAPbouiCOM.StaticText)
    '            Me.StaticText9 = CType(Me.GetItem("Item_117").Specific, SAPbouiCOM.StaticText)
    '            Me.Button9 = CType(Me.GetItem("Item_118").Specific, SAPbouiCOM.Button)
    '            Me.Button10 = CType(Me.GetItem("Item_119").Specific, SAPbouiCOM.Button)
    '            Me.DT_0X = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_0X")
    '            Me.DT_INFO = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_INFO")
    '            Me.DT_SQL1 = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_SQL1")
    '            Me.DT_SQL2 = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_SQL1")
    '            Me.Button11 = CType(Me.GetItem("Item_113").Specific, SAPbouiCOM.Button)
    '            Me.EditText44 = CType(Me.GetItem("Item_120").Specific, SAPbouiCOM.EditText)
    '            Me.EditText46 = CType(Me.GetItem("Item_121").Specific, SAPbouiCOM.EditText)
    '            Me.Button12 = CType(Me.GetItem("Item_122").Specific, SAPbouiCOM.Button)
    '            Me.EditText47 = CType(Me.GetItem("Item_123").Specific, SAPbouiCOM.EditText)
    '            Me.StaticText10 = CType(Me.GetItem("Item_124").Specific, SAPbouiCOM.StaticText)
    '            Me.LinkedButton0 = CType(Me.GetItem("Item_125").Specific, SAPbouiCOM.LinkedButton)
    '            Me.FiltrarChooseFromList(Me.UIAPIRawForm.UniqueID, "CFL_3")
    '            Me.FiltrarChooseFromList(Me.UIAPIRawForm.UniqueID, "CFL_4")
    '            Me.Button13 = CType(Me.GetItem("Item_127").Specific, SAPbouiCOM.Button)
    '            Me.EditText48 = CType(Me.GetItem("Item_126").Specific, SAPbouiCOM.EditText)
    '            Me.EditText50 = CType(Me.GetItem("Item_79").Specific, SAPbouiCOM.EditText)
    '            Me.PictureBox0 = CType(Me.GetItem("Item_128").Specific, SAPbouiCOM.PictureBox)
    '            Me.PictureBox0.Picture = (Module1.sPathAnexos).Trim() + "images\User.png"
    '            Me.Folder3 = CType(Me.GetItem("Item_129").Specific, SAPbouiCOM.Folder)
    '            Me.EditText39 = CType(Me.GetItem("Item_130").Specific, SAPbouiCOM.EditText)
    '            Me.OptionBtn0 = CType(Me.GetItem("Item_131").Specific, SAPbouiCOM.OptionBtn)
    '            Me.OptionBtn1 = CType(Me.GetItem("Item_132").Specific, SAPbouiCOM.OptionBtn)
    '            Me.OptionBtn2 = CType(Me.GetItem("Item_133").Specific, SAPbouiCOM.OptionBtn)
    '            Me.CheckBox0 = CType(Me.GetItem("Item_134").Specific, SAPbouiCOM.CheckBox)
    '            Me.CheckBox1 = CType(Me.GetItem("Item_135").Specific, SAPbouiCOM.CheckBox)
    '            Me.EditText49 = CType(Me.GetItem("Item_136").Specific, SAPbouiCOM.EditText)
    '            Me.StaticText11 = CType(Me.GetItem("Item_137").Specific, SAPbouiCOM.StaticText)
    '            Me.StaticText12 = CType(Me.GetItem("Item_138").Specific, SAPbouiCOM.StaticText)
    '            Me.EditText51 = CType(Me.GetItem("Item_139").Specific, SAPbouiCOM.EditText)
    '            Me.StaticText13 = CType(Me.GetItem("Item_140").Specific, SAPbouiCOM.StaticText)
    '            Me.EditText52 = CType(Me.GetItem("Item_141").Specific, SAPbouiCOM.EditText)
    '            Me.StaticText14 = CType(Me.GetItem("Item_142").Specific, SAPbouiCOM.StaticText)
    '            Me.StaticText15 = CType(Me.GetItem("Item_143").Specific, SAPbouiCOM.StaticText)
    '            Me.StaticText16 = CType(Me.GetItem("Item_144").Specific, SAPbouiCOM.StaticText)
    '            Me.Button14 = CType(Me.GetItem("Item_145").Specific, SAPbouiCOM.Button)
    '            Me.Button15 = CType(Me.GetItem("Item_146").Specific, SAPbouiCOM.Button)
    '            Me.EditText53 = CType(Me.GetItem("Item_147").Specific, SAPbouiCOM.EditText)
    '            Me.EditText54 = CType(Me.GetItem("Item_148").Specific, SAPbouiCOM.EditText)
    '            Me.StaticText17 = CType(Me.GetItem("Item_149").Specific, SAPbouiCOM.StaticText)
    '            Me.ComboBox6 = CType(Me.GetItem("Item_152").Specific, SAPbouiCOM.ComboBox)
    '            Me.StaticText18 = CType(Me.GetItem("Item_153").Specific, SAPbouiCOM.StaticText)
    '            Me.Folder4 = CType(Me.GetItem("Item_154").Specific, SAPbouiCOM.Folder)
    '            Me.Button16 = CType(Me.GetItem("Item_155").Specific, SAPbouiCOM.Button)
    '            Me.Button17 = CType(Me.GetItem("Item_156").Specific, SAPbouiCOM.Button)
    '            Me.EditText55 = CType(Me.GetItem("Item_157").Specific, SAPbouiCOM.EditText)
    '            Me.EditText56 = CType(Me.GetItem("Item_158").Specific, SAPbouiCOM.EditText)
    '            Me.EditText57 = CType(Me.GetItem("Item_159").Specific, SAPbouiCOM.EditText)
    '            Me.EditText58 = CType(Me.GetItem("Item_160").Specific, SAPbouiCOM.EditText)
    '            Me.EditText59 = CType(Me.GetItem("Item_161").Specific, SAPbouiCOM.EditText)
    '            Me.StaticText19 = CType(Me.GetItem("Item_162").Specific, SAPbouiCOM.StaticText)
    '            Me.StaticText20 = CType(Me.GetItem("Item_163").Specific, SAPbouiCOM.StaticText)
    '            Me.StaticText21 = CType(Me.GetItem("Item_164").Specific, SAPbouiCOM.StaticText)
    '            Me.Button18 = CType(Me.GetItem("Item_165").Specific, SAPbouiCOM.Button)
    '            Me.StaticText22 = CType(Me.GetItem("Item_151").Specific, SAPbouiCOM.StaticText)
    '            Me.StaticText23 = CType(Me.GetItem("Item_166").Specific, SAPbouiCOM.StaticText)
    '            Me.EditText61 = CType(Me.GetItem("Item_168").Specific, SAPbouiCOM.EditText)
    '            Me.EditText62 = CType(Me.GetItem("Item_169").Specific, SAPbouiCOM.EditText)
    '            Me.EditText66 = CType(Me.GetItem("Item_173").Specific, SAPbouiCOM.EditText)
    '            Me.EditText67 = CType(Me.GetItem("Item_174").Specific, SAPbouiCOM.EditText)
    '            Me.EditText68 = CType(Me.GetItem("Item_175").Specific, SAPbouiCOM.EditText)
    '            Me.EditText69 = CType(Me.GetItem("Item_176").Specific, SAPbouiCOM.EditText)
    '            Me.StaticText24 = CType(Me.GetItem("Item_177").Specific, SAPbouiCOM.StaticText)
    '            Me.EditText71 = CType(Me.GetItem("Item_179").Specific, SAPbouiCOM.EditText)
    '            Me.EditText72 = CType(Me.GetItem("Item_180").Specific, SAPbouiCOM.EditText)
    '            Me.EditText63 = CType(Me.GetItem("Item_19").Specific, SAPbouiCOM.EditText)
    '            Me.EditText64 = CType(Me.GetItem("Item_181").Specific, SAPbouiCOM.EditText)
    '            Me.Button19 = CType(Me.GetItem("Item_23").Specific, SAPbouiCOM.Button)
    '            Me.StaticText25 = CType(Me.GetItem("Item_31").Specific, SAPbouiCOM.StaticText)
    '            Me.StaticText26 = CType(Me.GetItem("Item_51").Specific, SAPbouiCOM.StaticText)
    '            Me.StaticText27 = CType(Me.GetItem("Item_58").Specific, SAPbouiCOM.StaticText)
    '            Me.StaticText28 = CType(Me.GetItem("Item_60").Specific, SAPbouiCOM.StaticText)
    '            Me.StaticText29 = CType(Me.GetItem("Item_62").Specific, SAPbouiCOM.StaticText)
    '            Me.StaticText30 = CType(Me.GetItem("Item_64").Specific, SAPbouiCOM.StaticText)
    '            Me.StaticText31 = CType(Me.GetItem("Item_66").Specific, SAPbouiCOM.StaticText)
    '            Me.EditText60 = CType(Me.GetItem("Item_24").Specific, SAPbouiCOM.EditText)
    '            Me.EditText70 = CType(Me.GetItem("Item_25").Specific, SAPbouiCOM.EditText)
    '            Me.EditText73 = CType(Me.GetItem("Item_26").Specific, SAPbouiCOM.EditText)
    '            Me.EditText74 = CType(Me.GetItem("Item_40").Specific, SAPbouiCOM.EditText)
    '            Me.EditText75 = CType(Me.GetItem("Item_42").Specific, SAPbouiCOM.EditText)
    '            Me.EditText65 = CType(Me.GetItem("Item_44").Specific, SAPbouiCOM.EditText)
    '            Me.EditText76 = CType(Me.GetItem("Item_46").Specific, SAPbouiCOM.EditText)
    '            Me.EditText77 = CType(Me.GetItem("Item_167").Specific, SAPbouiCOM.EditText)
    '            Me.EditText78 = CType(Me.GetItem("Item_170").Specific, SAPbouiCOM.EditText)
    '            Me.EditText79 = CType(Me.GetItem("Item_171").Specific, SAPbouiCOM.EditText)
    '            Me.StaticText32 = CType(Me.GetItem("Item_182").Specific, SAPbouiCOM.StaticText)
    '            Me.StaticText33 = CType(Me.GetItem("Item_183").Specific, SAPbouiCOM.StaticText)
    '            Me.StaticText34 = CType(Me.GetItem("Item_184").Specific, SAPbouiCOM.StaticText)
    '            Me.EditText80 = CType(Me.GetItem("Item_172").Specific, SAPbouiCOM.EditText)
    '            Me.PictureBox2 = CType(Me.GetItem("Item_70").Specific, SAPbouiCOM.PictureBox)
    '            Me.PictureBox3 = CType(Me.GetItem("Item_71").Specific, SAPbouiCOM.PictureBox)
    '            Me.PictureBox4 = CType(Me.GetItem("Item_72").Specific, SAPbouiCOM.PictureBox)
    '            Me.PictureBox5 = CType(Me.GetItem("Item_73").Specific, SAPbouiCOM.PictureBox)
    '            Me.PictureBox6 = CType(Me.GetItem("Item_178").Specific, SAPbouiCOM.PictureBox)
    '            Me.StaticText35 = CType(Me.GetItem("Item_33").Specific, SAPbouiCOM.StaticText)
    '            Me.StaticText36 = CType(Me.GetItem("Item_35").Specific, SAPbouiCOM.StaticText)
    '            Me.StaticText37 = CType(Me.GetItem("Item_37").Specific, SAPbouiCOM.StaticText)
    '            Me.StaticText38 = CType(Me.GetItem("Item_186").Specific, SAPbouiCOM.StaticText)
    '            Me.EditText82 = CType(Me.GetItem("Item_185").Specific, SAPbouiCOM.EditText)
    '            Me.Folder5 = CType(Me.GetItem("Item_188").Specific, SAPbouiCOM.Folder)
    '            Me.CheckBox2 = CType(Me.GetItem("Item_189").Specific, SAPbouiCOM.CheckBox)
    '            Me.CheckBox3 = CType(Me.GetItem("Item_190").Specific, SAPbouiCOM.CheckBox)
    '            Me.EditText81 = CType(Me.GetItem("Item_191").Specific, SAPbouiCOM.EditText)
    '            Me.StaticText39 = CType(Me.GetItem("Item_192").Specific, SAPbouiCOM.StaticText)
    '            Me.OptionBtn3 = CType(Me.GetItem("Item_193").Specific, SAPbouiCOM.OptionBtn)
    '            Me.OptionBtn4 = CType(Me.GetItem("Item_194").Specific, SAPbouiCOM.OptionBtn)
    '            Me.StaticText40 = CType(Me.GetItem("Item_195").Specific, SAPbouiCOM.StaticText)
    '            Me.StaticText41 = CType(Me.GetItem("Item_196").Specific, SAPbouiCOM.StaticText)
    '            Me.Button20 = CType(Me.GetItem("Item_197").Specific, SAPbouiCOM.Button)
    '            Me.Button21 = CType(Me.GetItem("Item_198").Specific, SAPbouiCOM.Button)
    '            Me.EditText83 = CType(Me.GetItem("Item_199").Specific, SAPbouiCOM.EditText)
    '            Me.EditText84 = CType(Me.GetItem("Item_200").Specific, SAPbouiCOM.EditText)
    '            Me.StaticText42 = CType(Me.GetItem("Item_201").Specific, SAPbouiCOM.StaticText)
    '            Me.EditText85 = CType(Me.GetItem("Item_202").Specific, SAPbouiCOM.EditText)
    '            Me.StaticText43 = CType(Me.GetItem("Item_203").Specific, SAPbouiCOM.StaticText)
    '            Me.EditText86 = CType(Me.GetItem("Item_204").Specific, SAPbouiCOM.EditText)
    '            Me.Button22 = CType(Me.GetItem("Item_205").Specific, SAPbouiCOM.Button)
    '            Me.PictureBox9 = CType(Me.GetItem("Item_213").Specific, SAPbouiCOM.PictureBox)
    '            Me.PictureBox10 = CType(Me.GetItem("Item_214").Specific, SAPbouiCOM.PictureBox)
    '            Me.Button23 = CType(Me.GetItem("Item_206").Specific, SAPbouiCOM.Button)
    '            Me.PictureBox1 = CType(Me.GetItem("Item_150").Specific, SAPbouiCOM.PictureBox)
    '            Me.Button37 = CType(Me.GetItem("Item_209").Specific, SAPbouiCOM.Button)
    '            Me.ComboBox8 = CType(Me.GetItem("Item_207").Specific, SAPbouiCOM.ComboBox)
    '            Me.StaticText44 = CType(Me.GetItem("Item_208").Specific, SAPbouiCOM.StaticText)
    '            Me.Matrix1 = CType(Me.GetItem("Item_111").Specific, SAPbouiCOM.Matrix)
    '            Me.ComboBox9 = CType(Me.GetItem("Item_210").Specific, SAPbouiCOM.ComboBox)
    '            Me.ComboBox10 = CType(Me.GetItem("Item_211").Specific, SAPbouiCOM.ComboBox)
    '            Me.StaticText45 = CType(Me.GetItem("Item_212").Specific, SAPbouiCOM.StaticText)
    '            Me.StaticText46 = CType(Me.GetItem("Item_215").Specific, SAPbouiCOM.StaticText)
    '            Me.StaticText47 = CType(Me.GetItem("Item_216").Specific, SAPbouiCOM.StaticText)
    '            Me.StaticText48 = CType(Me.GetItem("Item_218").Specific, SAPbouiCOM.StaticText)
    '            Me.EditText87 = CType(Me.GetItem("Item_217").Specific, SAPbouiCOM.EditText)
    '            Me.EditText88 = CType(Me.GetItem("Item_219").Specific, SAPbouiCOM.EditText)
    '            Me.OptionBtn5 = CType(Me.GetItem("Item_220").Specific, SAPbouiCOM.OptionBtn)
    '            Me.OptionBtn6 = CType(Me.GetItem("Item_221").Specific, SAPbouiCOM.OptionBtn)
    '            Me.StaticText49 = CType(Me.GetItem("Item_222").Specific, SAPbouiCOM.StaticText)
    '            Me.EditText89 = CType(Me.GetItem("Item_223").Specific, SAPbouiCOM.EditText)
    '            Me.StaticText50 = CType(Me.GetItem("Item_224").Specific, SAPbouiCOM.StaticText)
    '            Me.EditText90 = CType(Me.GetItem("Item_225").Specific, SAPbouiCOM.EditText)
    '            Me.StaticText51 = CType(Me.GetItem("Item_226").Specific, SAPbouiCOM.StaticText)
    '            Me.OptionBtn7 = CType(Me.GetItem("Item_227").Specific, SAPbouiCOM.OptionBtn)
    '            Me.OptionBtn8 = CType(Me.GetItem("Item_228").Specific, SAPbouiCOM.OptionBtn)
    '            Me.StaticText52 = CType(Me.GetItem("Item_229").Specific, SAPbouiCOM.StaticText)
    '            Me.Button25 = CType(Me.GetItem("Item_230").Specific, SAPbouiCOM.Button)
    '            Me.OnCustomInitialize()

    '        End Sub

    '        Public Overrides Sub OnInitializeFormEvents()
    '            AddHandler LoadAfter, AddressOf Me.Form_LoadAfter

    '        End Sub


    '        Private Sub OnCustomInitialize()

    '            Me.Matrix0 = CType(Me.GetItem("Item_111").Specific, SAPbouiCOM.Matrix)
    '            Matrix0.Item.FromPane = 2
    '            Matrix0.Item.ToPane = 2

    '            Me.FiltrarChooseFromListSLP(Me.UIAPIRawForm.UniqueID, "CFL_5")

    '            Cargar_Combo_JefesProyectos()
    '            Cargar_Combo_CondicionesPagos()

    '            Me.Button0.Item.Enabled = False
    '            Me.Button3.Item.Enabled = False

    '            Me.OptionBtn1.GroupWith("Item_131")
    '            Me.OptionBtn2.GroupWith("Item_131")

    '            Me.OptionBtn3.GroupWith("Item_194")

    '            Me.OptionBtn6.GroupWith("Item_220")

    '            Me.OptionBtn8.GroupWith("Item_227")

    '            Me.EditText63.Item.Visible = False

    '            Me.UIAPIRawForm.EnableMenu(1281, True)  'Buscar
    '            Me.UIAPIRawForm.EnableMenu(1282, False) 'Crear

    '            'If NConectarAplicacion.sCurrentCompanyDBSH <> sBDComercial Then
    '            Button11.Item.Enabled = False
    '            Button13.Item.Enabled = False
    '            Button14.Item.Enabled = False
    '            Button16.Item.Enabled = False
    '            'End If

    '            Me.Folder0.Item.AffectsFormMode = False
    '            Me.Folder1.Item.AffectsFormMode = False
    '            Me.Folder2.Item.AffectsFormMode = False
    '            Me.Folder3.Item.AffectsFormMode = False
    '            Me.Folder4.Item.AffectsFormMode = False
    '            Me.EditText0.Item.AffectsFormMode = False
    '            Me.EditText1.Item.AffectsFormMode = False
    '            Me.EditText2.Item.AffectsFormMode = False
    '            Me.EditText3.Item.AffectsFormMode = False
    '            Me.EditText4.Item.AffectsFormMode = False
    '            Me.EditText5.Item.AffectsFormMode = False
    '            Me.EditText6.Item.AffectsFormMode = False
    '            Me.EditText7.Item.AffectsFormMode = False
    '            Me.EditText8.Item.AffectsFormMode = False
    '            Me.EditText9.Item.AffectsFormMode = False
    '            Me.EditText10.Item.AffectsFormMode = False
    '            Me.EditText11.Item.AffectsFormMode = False
    '            Me.EditText12.Item.AffectsFormMode = False
    '            Me.EditText13.Item.AffectsFormMode = False
    '            Me.EditText14.Item.AffectsFormMode = False
    '            Me.EditText15.Item.AffectsFormMode = False
    '            Me.EditText16.Item.AffectsFormMode = False
    '            Me.EditText17.Item.AffectsFormMode = False
    '            Me.EditText18.Item.AffectsFormMode = False
    '            Me.EditText19.Item.AffectsFormMode = False
    '            Me.EditText20.Item.AffectsFormMode = False
    '            Me.EditText21.Item.AffectsFormMode = False
    '            Me.EditText22.Item.AffectsFormMode = False
    '            Me.EditText23.Item.AffectsFormMode = False
    '            Me.EditText24.Item.AffectsFormMode = False
    '            Me.EditText25.Item.AffectsFormMode = False
    '            Me.EditText26.Item.AffectsFormMode = False
    '            Me.EditText27.Item.AffectsFormMode = False
    '            Me.EditText28.Item.AffectsFormMode = False
    '            Me.EditText29.Item.AffectsFormMode = False
    '            Me.EditText30.Item.AffectsFormMode = False
    '            Me.EditText31.Item.AffectsFormMode = False
    '            Me.EditText32.Item.AffectsFormMode = False
    '            Me.EditText33.Item.AffectsFormMode = False
    '            Me.EditText34.Item.AffectsFormMode = False
    '            Me.EditText35.Item.AffectsFormMode = False
    '            Me.EditText36.Item.AffectsFormMode = False
    '            Me.EditText37.Item.AffectsFormMode = False
    '            Me.EditText38.Item.AffectsFormMode = False
    '            Me.EditText39.Item.AffectsFormMode = False
    '            Me.EditText40.Item.AffectsFormMode = False
    '            Me.EditText41.Item.AffectsFormMode = False
    '            Me.EditText42.Item.AffectsFormMode = False
    '            Me.EditText43.Item.AffectsFormMode = False
    '            Me.EditText45.Item.AffectsFormMode = False
    '            Me.EditText49.Item.AffectsFormMode = False
    '            Me.EditText51.Item.AffectsFormMode = False
    '            Me.EditText52.Item.AffectsFormMode = False
    '            Me.EditText57.Item.AffectsFormMode = False
    '            Me.EditText58.Item.AffectsFormMode = False
    '            Me.EditText59.Item.AffectsFormMode = False
    '            Me.ComboBox6.Item.AffectsFormMode = False
    '            Me.CheckBox0.Item.AffectsFormMode = False
    '            Me.CheckBox1.Item.AffectsFormMode = False
    '            Me.OptionBtn0.Item.AffectsFormMode = False
    '            Me.OptionBtn1.Item.AffectsFormMode = False
    '            Me.OptionBtn2.Item.AffectsFormMode = False
    '            Me.OptionBtn3.Item.AffectsFormMode = False
    '            Me.OptionBtn4.Item.AffectsFormMode = False
    '            Me.OptionBtn5.Item.AffectsFormMode = False
    '            Me.OptionBtn6.Item.AffectsFormMode = False
    '            Me.OptionBtn7.Item.AffectsFormMode = False
    '            Me.OptionBtn8.Item.AffectsFormMode = False
    '            Me.ComboBox0.Item.AffectsFormMode = False
    '            Me.ComboBox1.Item.AffectsFormMode = False
    '            Me.ComboBox2.Item.AffectsFormMode = False
    '            Me.ComboBox3.Item.AffectsFormMode = False
    '            Me.ComboBox4.Item.AffectsFormMode = False
    '            Me.ComboBox5.Item.AffectsFormMode = False
    '            Me.ComboBox6.Item.AffectsFormMode = False
    '            Me.ComboBox7.Item.AffectsFormMode = False
    '            Me.ComboBox8.Item.AffectsFormMode = False
    '            Me.ComboBox9.Item.AffectsFormMode = False
    '            Me.ComboBox10.Item.AffectsFormMode = False
    '            Me.EditText77.Item.AffectsFormMode = False
    '            Me.EditText78.Item.AffectsFormMode = False
    '            Me.EditText79.Item.AffectsFormMode = False
    '            Me.EditText82.Item.AffectsFormMode = False
    '            Me.CheckBox2.Item.AffectsFormMode = False
    '            Me.CheckBox3.Item.AffectsFormMode = False
    '            Me.EditText81.Item.AffectsFormMode = False
    '            Me.EditText83.Item.AffectsFormMode = False
    '            Me.EditText84.Item.AffectsFormMode = False
    '            Me.StaticText42.Item.AffectsFormMode = False
    '            Me.EditText85.Item.AffectsFormMode = False
    '            Me.StaticText43.Item.AffectsFormMode = False
    '            Me.StaticText44.Item.AffectsFormMode = False
    '            Me.StaticText45.Item.AffectsFormMode = False
    '            Me.StaticText46.Item.AffectsFormMode = False
    '            Me.StaticText47.Item.AffectsFormMode = False
    '            Me.StaticText48.Item.AffectsFormMode = False
    '            Me.EditText86.Item.AffectsFormMode = False
    '            Me.EditText87.Item.AffectsFormMode = False
    '            Me.EditText88.Item.AffectsFormMode = False
    '            Me.EditText89.Item.AffectsFormMode = False
    '            Me.EditText90.Item.AffectsFormMode = False
    '            Me.PictureBox9.Item.AffectsFormMode = False
    '            Me.PictureBox10.Item.AffectsFormMode = False
    '            Me.PictureBox1.Item.AffectsFormMode = False
    '            Me.Matrix1.Item.AffectsFormMode = False

    '            Folder0.Item.Click()

    '        End Sub

    '        Private Sub Cargar_Combo_CondicionesPagos()
    '            'Cargar Combo Condiciones Pago
    '            ComboBoxExtensions.CleanComboBox(ComboBox9)
    '            Dim Sql = "SELECT U_CondCode,U_CondDesc FROM [" + sBDComercial.Trim() + "].[dbo].[@MIN_CONDPAG] ORDER BY 1"
    '            ComboBoxExtensions.LoadComboQueryDataTable(ComboBox9, DT_SQL2, Sql, 0, 1, True)
    '        End Sub

    '        Private Sub Cargar_Combo_JefesProyectos()
    '            ComboBoxExtensions.CleanComboBox(ComboBox8)
    '            Dim Sql As String = " SELECT  " &
    '                                 "       empID,lastName + ', '+ firstName as Name " &
    '                                 "   FROM " &
    '                                 "       OHEM " &
    '                                 "   WHERE " &
    '                                 "       empID IN (SELECT empID FROM HEM6 WHERE roleID = 1)"

    '            ComboBoxExtensions.LoadComboQueryDataTable(ComboBox8, DT_SQL2, Sql, 0, 1, True)
    '        End Sub

    '        Private Sub FiltrarChooseFromListSLP(ByVal FormUID As String, ByVal CFL_ID As String)
    '            Try
    '                Dim oConditions As SAPbouiCOM.Conditions
    '                Dim oCondition As SAPbouiCOM.Condition
    '                Dim oChooseFromList As SAPbouiCOM.ChooseFromList
    '                Dim emptyCon As New SAPbouiCOM.Conditions
    '                oChooseFromList = Application.SBO_Application.Forms.Item(FormUID).ChooseFromLists.Item(CFL_ID)
    '                oChooseFromList.SetConditions(emptyCon)
    '                oConditions = oChooseFromList.GetConditions()
    '                oCondition = oConditions.Add
    '                oCondition.Alias = "Active"
    '                oCondition.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL
    '                oCondition.CondVal = "Y"
    '                oChooseFromList.SetConditions(oConditions)
    '            Catch ex As Exception
    '                Application.SBO_Application.StatusBar.SetText(ex.Message)
    '            End Try
    '        End Sub

    '        Private Sub Button0_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button0.ClickAfter

    '            If Me.Button0.Item.Enabled Then
    '                If Me.EditText0.Value.Trim.Length() > 0 Then
    '                    Enviar_Datos_Gestion_Fechas(sboObject, pVal)
    '                Else
    '                    Application.SBO_Application.MessageBox("Debe Seleccionar un Proyecto", 1)
    '                End If
    '            End If

    '        End Sub

    '        Private Sub Form_LoadAfter(pVal As SAPbouiCOM.SBOItemEventArg)

    '            sFormID_Principal = Me.UIAPIRawForm.UniqueID

    '        End Sub

    '        Private Sub Enviar_Datos_Gestion_Fechas(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg)

    '            Dim oFormP As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(Me.UIAPIRawForm.UniqueID)

    '            Dim Formp2 As NewForm_3_b1f
    '            Formp2 = New NewForm_3_b1f

    '            Dim oUDS As SAPbouiCOM.UserDataSource = Formp2.UIAPIRawForm.DataSources.UserDataSources.Item("UD_0")
    '            oUDS.ValueEx = Me.UIAPIRawForm.UniqueID   'Aca asignamos el FormUID de Formulario al Valor del  User Data Source

    '            Dim oForm As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(Formp2.UIAPIRawForm.UniqueID)
    '            Dim txt As SAPbouiCOM.EditText

    '            'Cargar Datos de Despacho, Montajes y Asignacion de Ingenieria
    '            Try
    '                If (OptionBtn3.Selected) Then
    '                    oForm.DataSources.UserDataSources.Item("OptBnt2").ValueEx = 2
    '                Else
    '                    oForm.DataSources.UserDataSources.Item("OptBnt2").ValueEx = 1
    '                End If

    '                If (CheckBox2.Checked) Then
    '                    oForm.DataSources.UserDataSources.Item("CheckDS4").ValueEx = "Y"
    '                End If

    '                If (CheckBox3.Checked) Then
    '                    oForm.DataSources.UserDataSources.Item("CheckDS3").ValueEx = "Y"
    '                End If

    '            Catch ex As Exception

    '            End Try

    '            'Asignar Fechas Iniciales
    '            Try
    '                txt = oForm.Items.Item("Item_0").Specific
    '                txt.Value = EditText0.Value.ToString()
    '                txt = oForm.Items.Item("Item_2").Specific
    '                txt.Value = EditText1.Value.ToString()
    '                txt = oForm.Items.Item("Item_4").Specific
    '                txt.Value = EditText2.Value.ToString()
    '                txt = oForm.Items.Item("Item_6").Specific
    '                txt.Value = EditText3.Value.ToString()
    '                txt = oForm.Items.Item("Item_8").Specific
    '                txt.Value = EditText4.Value.ToString()
    '                txt = oForm.Items.Item("Item_10").Specific
    '                txt.Value = EditText5.Value.ToString()

    '                oForm.DataSources.UserDataSources.Item("FDESAINI").ValueEx = Convert.ToDateTime(EditText8.Value).ToString("yyyyMMdd")
    '                oForm.DataSources.UserDataSources.Item("FPRODINI").ValueEx = Convert.ToDateTime(EditText13.Value).ToString("yyyyMMdd")
    '                oForm.DataSources.UserDataSources.Item("FDESPINI").ValueEx = Convert.ToDateTime(EditText18.Value).ToString("yyyyMMdd")
    '                oForm.DataSources.UserDataSources.Item("FIMONINI").ValueEx = Convert.ToDateTime(EditText24.Value).ToString("yyyyMMdd")
    '                oForm.DataSources.UserDataSources.Item("FTMONINI").ValueEx = Convert.ToDateTime(EditText30.Value).ToString("yyyyMMdd")
    '            Catch ex As Exception

    '            End Try

    '            'Asignar dias Iniciales
    '            txt = oForm.Items.Item("Item_12").Specific
    '            txt.Value = EditText6.Value.ToString()
    '            txt = oForm.Items.Item("Item_32").Specific
    '            txt.Value = EditText10.Value.ToString()
    '            txt = oForm.Items.Item("Item_34").Specific
    '            txt.Value = EditText15.Value.ToString()
    '            txt = oForm.Items.Item("Item_36").Specific
    '            txt.Value = EditText20.Value.ToString()
    '            txt = oForm.Items.Item("Item_38").Specific
    '            txt.Value = EditText27.Value.ToString()
    '            txt = oForm.Items.Item("Item_40").Specific
    '            txt.Value = EditText33.Value.ToString()
    '            'Asignar dias de Atraso
    '            txt = oForm.Items.Item("Item_14").Specific
    '            txt.Value = EditText7.Value.ToString()

    '            'Suma de Dias Iniciales
    '            txt = oForm.Items.Item("Item_76").Specific
    '            Try
    '                txt.Value = Convert.ToInt32(EditText6.Value) + Convert.ToInt32(EditText10.Value) + Convert.ToInt32(EditText15.Value) +
    '                            Convert.ToInt32(EditText20.Value) + Convert.ToInt32(EditText33.Value)
    '            Catch ex As Exception
    '                txt.Value = "0"
    '            End Try

    '            'Asignar Fechas Actuales
    '            Try
    '                oForm.DataSources.UserDataSources.Item("FDESACT").ValueEx = oFormP.DataSources.UserDataSources.Item("UD_FDESA").ValueEx
    '                oForm.DataSources.UserDataSources.Item("FPRODACT").ValueEx = oFormP.DataSources.UserDataSources.Item("UD_FPRO").ValueEx
    '                oForm.DataSources.UserDataSources.Item("FDESPACT").ValueEx = oFormP.DataSources.UserDataSources.Item("UD_FDESP").ValueEx
    '                oForm.DataSources.UserDataSources.Item("FIMONACT").ValueEx = oFormP.DataSources.UserDataSources.Item("UD_FIMON").ValueEx
    '                oForm.DataSources.UserDataSources.Item("FTMONACT").ValueEx = oFormP.DataSources.UserDataSources.Item("UD_FFMON").ValueEx
    '                txt = oForm.Items.Item("Item_107").Specific
    '                txt.Value = EditText40.Value.ToString()
    '            Catch ex As Exception
    '            End Try


    '            'Asignar dias Actuales
    '            txt = oForm.Items.Item("Item_53").Specific
    '            txt.Value = EditText11.Value.ToString()
    '            txt = oForm.Items.Item("Item_55").Specific
    '            txt.Value = EditText16.Value.ToString()
    '            txt = oForm.Items.Item("Item_57").Specific
    '            txt.Value = EditText22.Value.ToString()
    '            txt = oForm.Items.Item("Item_59").Specific
    '            txt.Value = EditText28.Value.ToString()
    '            txt = oForm.Items.Item("Item_61").Specific
    '            txt.Value = EditText34.Value.ToString()

    '            'Suma de Dias Actuales
    '            txt = oForm.Items.Item("Item_104").Specific
    '            Try
    '                txt.Value = Convert.ToInt32(EditText11.Value) + Convert.ToInt32(EditText16.Value) + Convert.ToInt32(EditText22.Value) +
    '                            Convert.ToInt32(EditText28.Value) + Convert.ToInt32(EditText34.Value)
    '            Catch ex As Exception
    '                txt.Value = "0"
    '            End Try

    '            'Inicializar en 0 los dias a modificar
    '            'Asignar dias Actuales
    '            txt = oForm.Items.Item("Item_92").Specific
    '            txt.Value = "0"
    '            txt = oForm.Items.Item("Item_94").Specific
    '            txt.Value = "0"
    '            txt = oForm.Items.Item("Item_96").Specific
    '            txt.Value = "0"
    '            txt = oForm.Items.Item("Item_98").Specific
    '            txt.Value = "0"
    '            txt = oForm.Items.Item("Item_100").Specific
    '            txt.Value = "0"

    '            txt = oForm.Items.Item("Item_86").Specific
    '            txt.Value = oFunciones.Nombre_Usuario_Actual()

    '            txt = oForm.Items.Item("Item_42").Specific
    '            txt.Value = Replace(DateTime.Now.ToString("dd/MM/yyyy"), "-", "/")

    '            Formp2.Show()

    '        End Sub

    '        Private Sub Button1_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button1.ClickAfter

    '            If Me.Button13.Caption = "Bloq. Cli." Then
    '                Me.Button13.Item.Click()
    '            End If

    '            If Me.EditText57.Item.Enabled Then
    '                Me.Button16.Item.Click()
    '            End If

    '            Dim activeForm2 As Form2
    '            activeForm2 = New Form2

    '            Dim oUDS As SAPbouiCOM.UserDataSource = activeForm2.UIAPIRawForm.DataSources.UserDataSources.Item("UD_0")
    '            oUDS.ValueEx = Me.UIAPIRawForm.UniqueID
    '            oUDS = activeForm2.UIAPIRawForm.DataSources.UserDataSources.Item("UD_1")
    '            oUDS.ValueEx = "GLOBAL"

    '            activeForm2.Show()

    '        End Sub

    '        Private Sub Button2_ClickBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles Button2.ClickBefore
    '            'Dim Formp3 As Form3
    '            'Formp3 = New Form3

    '            'Dim oUDS As SAPbouiCOM.UserDataSource = Formp3.UIAPIRawForm.DataSources.UserDataSources.Item("UD_0")
    '            'oUDS.ValueEx = Me.UIAPIRawForm.UniqueID   'Aca asignamos el FormUID de Formulario al Valor del  User Data Source

    '            'Dim oForm As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(Formp3.UIAPIRawForm.UniqueID)
    '            'Dim txt As SAPbouiCOM.EditText = oForm.Items.Item("Item_7").Specific
    '            'txt.Value = EditText0.Value.ToString()
    '            'txt = oForm.Items.Item("Item_9").Specific
    '            'txt.Value = EditText1.Value.ToString()
    '            'txt = oForm.Items.Item("Item_11").Specific
    '            'txt.Value = EditText2.Value.ToString()
    '            'txt = oForm.Items.Item("Item_13").Specific
    '            'txt.Value = EditText3.Value.ToString()
    '            'txt = oForm.Items.Item("Item_15").Specific
    '            'txt.Value = EditText4.Value.ToString()
    '            'txt = oForm.Items.Item("Item_17").Specific
    '            'txt.Value = EditText5.Value.ToString()
    '            'txt = oForm.Items.Item("Item_19").Specific
    '            'txt.Value = EditText6.Value.ToString()

    '            'Try
    '            '    sPSql = "select Code, U_Empresa from OUSR "
    '            '    DT_SQL1.ExecuteQuery(sPSql)
    '            'Catch ex As Exception
    '            '    oConectarAplicacion.Conectar_Aplicacion(oCompany)
    '            '    DT_SQL1.ExecuteQuery(sPSql)
    '            'End Try

    '            'txt = oForm.Items.Item("Item_26").Specific
    '            'txt.Value = oFunciones.Nombre_Usuario_Actual()
    '            'txt = oForm.Items.Item("Item_33").Specific
    '            'txt.Value = oFunciones.Nombre_Usuario_Actual()

    '            'txt = oForm.Items.Item("Item_28").Specific
    '            'txt.Value = Replace(DateTime.Now.ToString("dd/MM/yyyy"), "-", "/")
    '            'txt = oForm.Items.Item("Item_35").Specific
    '            'txt.Value = Replace(Format(Date.Now, "dd/MM/yyyy"), "-", "/")

    '            'txt = oForm.Items.Item("Item_51").Specific
    '            'txt.Value = oFunciones.Nombre_Usuario_Actual()
    '            'txt = oForm.Items.Item("Item_57").Specific
    '            'txt.Value = oFunciones.Nombre_Usuario_Actual()

    '            'txt = oForm.Items.Item("Item_53").Specific
    '            'txt.Value = Replace(DateTime.Now.ToString("dd/MM/yyyy"), "-", "/")
    '            'txt = oForm.Items.Item("Item_59").Specific
    '            'txt.Value = Replace(Format(Date.Now, "dd/MM/yyyy"), "-", "/")

    '            'txt = oForm.Items.Item("Item_74").Specific
    '            'txt.Value = oFunciones.Nombre_Usuario_Actual()
    '            'txt = oForm.Items.Item("Item_80").Specific
    '            'txt.Value = oFunciones.Nombre_Usuario_Actual()

    '            'txt = oForm.Items.Item("Item_76").Specific
    '            'txt.Value = Replace(DateTime.Now.ToString("dd/MM/yyyy"), "-", "/")
    '            'txt = oForm.Items.Item("Item_82").Specific
    '            'txt.Value = Replace(Format(Date.Now, "dd/MM/yyyy"), "-", "/")

    '            'txt = oForm.Items.Item("Item_97").Specific
    '            'txt.Value = oFunciones.Nombre_Usuario_Actual()
    '            'txt = oForm.Items.Item("Item_103").Specific
    '            'txt.Value = oFunciones.Nombre_Usuario_Actual()

    '            'txt = oForm.Items.Item("Item_99").Specific
    '            'txt.Value = Replace(DateTime.Now.ToString("dd/MM/yyyy"), "-", "/")
    '            'txt = oForm.Items.Item("Item_105").Specific
    '            'txt.Value = Replace(Format(Date.Now, "dd/MM/yyyy"), "-", "/")

    '            ''Asignar Date Picker a campos fechas editables
    '            'txt = oForm.Items.Item("Item_43").Specific
    '            'txt.DataBind.SetBound(True, "", "UDDate1")
    '            'txt = oForm.Items.Item("Item_45").Specific
    '            'txt.DataBind.SetBound(True, "", "UDDate2")
    '            'txt = oForm.Items.Item("Item_47").Specific
    '            'txt.DataBind.SetBound(True, "", "UDDate3")
    '            'txt = oForm.Items.Item("Item_113").Specific
    '            'txt.DataBind.SetBound(True, "", "UDDate4")
    '            'txt = oForm.Items.Item("Item_115").Specific
    '            'txt.DataBind.SetBound(True, "", "UDDate5")
    '            'txt = oForm.Items.Item("Item_117").Specific
    '            'txt.DataBind.SetBound(True, "", "UDDate6")
    '            'txt = oForm.Items.Item("Item_90").Specific
    '            'txt.DataBind.SetBound(True, "", "UDDate7")
    '            'txt = oForm.Items.Item("Item_92").Specific
    '            'txt.DataBind.SetBound(True, "", "UDDate8")
    '            'txt = oForm.Items.Item("Item_94").Specific
    '            'txt.DataBind.SetBound(True, "", "UDDate9")
    '            'txt = oForm.Items.Item("Item_67").Specific
    '            'txt.DataBind.SetBound(True, "", "UDDate10")
    '            'txt = oForm.Items.Item("Item_69").Specific
    '            'txt.DataBind.SetBound(True, "", "UDDate11")
    '            'txt = oForm.Items.Item("Item_71").Specific
    '            'txt.DataBind.SetBound(True, "", "UDDate12")

    '            'Formp3.Show()

    '        End Sub
    '        Private Sub Button3_ClickBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles Button3.ClickBefore
    '            ''----------------------------------------------------------------------------------------------------------------------------------------------------------
    '            ''Abre la Pantalla de Estado Comercial e Ingenieria, envia los Querys para hacer la consulta y mostrar los datos en el Grid al cargar el Form

    '            'If Me.Button3.Item.Enabled Then

    '            '    If Me.EditText0.Value.Trim.Length() > 0 Then

    '            '        sPSql = "exec [" + sBDComercial.Trim() + "].[dbo].[MIN_GPR_Estado_Ventas_Comercial] '" + Me.EditText0.Value.Trim() + "'"

    '            '        sPSql2 = "select * from [" + sBDComercial.Trim() + "].[DBO].[@ZHCEP] where U_Tipo_Proc = 'COMER_ING' and U_PrjCode = '" + Me.EditText0.Value.Trim() + "'"

    '            '        sPSql3 = "exec [" + sBDComercial.Trim() + "].[dbo].[MIN_GPR_Estado_Compras_Comercial] '" + Me.EditText0.Value.Trim() + "'"

    '            '        sPSql4 = "exec [" + sBDComercial.Trim() + "].[dbo].[MIN_GPR_Estado_PCV_Comercial_Industrial] '" + Me.EditText0.Value.Trim() + "'"

    '            '        sPSql5 = "exec [" + sBDComercial.Trim() + "].[dbo].[MIN_GPR_Estado_PCV_Comercial_Montaje] '" + Me.EditText0.Value.Trim() + "'"


    '            '        Dim Formp4 As Form4
    '            '        Formp4 = New Form4

    '            '        Dim oUDS As SAPbouiCOM.UserDataSource = Formp4.UIAPIRawForm.DataSources.UserDataSources.Item("UD_0")
    '            '        oUDS.ValueEx = Me.UIAPIRawForm.UniqueID   'Aca asignamos el FormUID de Formulario al Valor del  User Data Source

    '            '        Dim oUDS2 As SAPbouiCOM.UserDataSource = Formp4.UIAPIRawForm.DataSources.UserDataSources.Item("UD_1")
    '            '        oUDS2.ValueEx = Me.EditText0.Value.Trim()   'Aca asignamos el Codigo del Proyecto al User Data Source

    '            '        Dim oForm As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(Formp4.UIAPIRawForm.UniqueID)
    '            '        Dim txt As SAPbouiCOM.EditText = oForm.Items.Item("Item_1").Specific
    '            '        txt.Value = EditText0.Value.ToString()
    '            '        txt = oForm.Items.Item("Item_3").Specific
    '            '        txt.Value = EditText1.Value.ToString()
    '            '        txt = oForm.Items.Item("Item_5").Specific
    '            '        txt.Value = EditText2.Value.ToString()
    '            '        txt = oForm.Items.Item("Item_7").Specific
    '            '        txt.Value = EditText3.Value.ToString()
    '            '        txt = oForm.Items.Item("Item_9").Specific
    '            '        txt.Value = EditText4.Value.ToString()
    '            '        txt = oForm.Items.Item("Item_11").Specific
    '            '        txt.Value = EditText5.Value.ToString()
    '            '        txt = oForm.Items.Item("Item_13").Specific
    '            '        txt.Value = EditText6.Value.ToString()
    '            '        txt = oForm.Items.Item("Item_15").Specific
    '            '        txt.Value = EditText7.Value.ToString()

    '            '        txt = oForm.Items.Item("Item_24").Specific
    '            '        txt.Value = oFunciones.Nombre_Usuario_Actual()

    '            '        txt = oForm.Items.Item("Item_26").Specific
    '            '        txt.Value = Replace(DateTime.Now.ToString("dd/MM/yyyy"), "-", "/")


    '            '        Formp4.Show()

    '            '    Else
    '            '        Application.SBO_Application.MessageBox("Debe Seleccionar un Proyecto", 1)
    '            '    End If

    '            'End If

    '        End Sub
    '        Private Sub Button4_ClickBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles Button4.ClickBefore
    '            'If Me.Button3.Item.Enabled Then

    '            '    If Me.EditText0.Value.Trim.Length() > 0 Then

    '            '        'Asignamos la Consulta antes de llamar al Form
    '            '        sPSql = " select distinct  isnull(PC.DocNum,0) as Pedido_de_Ventas,case PC.Series when '27' then 'PCV'  when '47' then 'PCR' when '46' then 'PCG' end as Tipo_Pedido, " & _
    '            '                 " isnull(PC.TaxDate,'') as Fecha_Emision,isnull(OT.DocNum,'') as Orden_Fabricacion,isnull(OT.PostDate,'') as Fecha_Emision,isnull(OT.DueDate,'') as Fecha_Entrega  " & _
    '            '                 " from [" + sBDIndustrial.Trim() + "].[DBO].OPRJ PR LEFT JOIN [" + sBDIndustrial.Trim() + "].[DBO].ORDR PC on PR.PrjCode = PC.Project  " & _
    '            '                 " LEFT JOIN [" + sBDIndustrial.Trim() + "].[DBO].OWOR OT on PC.DocNum = OT.OriginNum " & _
    '            '                 " where pc.Project = '" + Me.EditText0.Value.Trim() + "'"



    '            '        sPSql2 = "select * from [" + sBDComercial.Trim() + "].[DBO].[@ZHCEP] where U_Tipo_Proc = 'INDUSTRIAL' and U_PrjCode = '" + Me.EditText0.Value.Trim() + "'"

    '            '        sPSql3 = " select distinct  isnull(PC.DocNum,0) as Pedido_de_Ventas,case PC.Series when '27' then 'PCV'  when '47' then 'PCR' when '46' then 'PCG' end as Tipo_Pedido, " & _
    '            '                 " isnull(PC.TaxDate,'') as Fecha_Emision,isnull(GE.DocNum,'') as Guia_de_Entrega,isnull(GE.TaxDate,'') as Fecha_Emision " & _
    '            '                 " from [" + sBDIndustrial.Trim() + "].[DBO].OPRJ PR LEFT JOIN [" + sBDIndustrial.Trim() + "].[DBO].ORDR PC on PR.PrjCode = PC.Project  " & _
    '            '                 " LEFT JOIN (select F.DocNum,R.BaseRef,F.Series,F.TaxDate,F.Project,R.DocEntry from [" + sBDIndustrial.Trim() + "].[DBO].ODLN F join [" + sBDIndustrial.Trim() + "].[DBO].DLN1 R on F.DocEntry = R.DocEntry)  GE on PR.PrjCode = GE.Project and isnull(GE.BaseRef,'') = isnull(PC.DocNum,'')  " & _
    '            '                 " where pc.Project = '" + Me.EditText0.Value.Trim() + "'"

    '            '        Dim Formp5 As Form5
    '            '        Formp5 = New Form5

    '            '        Dim oUDS As SAPbouiCOM.UserDataSource = Formp5.UIAPIRawForm.DataSources.UserDataSources.Item("UD_0")
    '            '        oUDS.ValueEx = Me.UIAPIRawForm.UniqueID   'Aca asignamos el FormUID de Formulario al Valor del  User Data Source

    '            '        Dim oForm As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(Formp5.UIAPIRawForm.UniqueID)
    '            '        Dim txt As SAPbouiCOM.EditText = oForm.Items.Item("Item_1").Specific
    '            '        txt.Value = EditText0.Value.ToString()
    '            '        txt = oForm.Items.Item("Item_3").Specific
    '            '        txt.Value = EditText1.Value.ToString()
    '            '        txt = oForm.Items.Item("Item_5").Specific
    '            '        txt.Value = EditText2.Value.ToString()
    '            '        txt = oForm.Items.Item("Item_7").Specific
    '            '        txt.Value = EditText3.Value.ToString()
    '            '        txt = oForm.Items.Item("Item_9").Specific
    '            '        txt.Value = EditText4.Value.ToString()
    '            '        txt = oForm.Items.Item("Item_11").Specific
    '            '        txt.Value = EditText5.Value.ToString()
    '            '        txt = oForm.Items.Item("Item_13").Specific
    '            '        txt.Value = EditText6.Value.ToString()

    '            '        txt = oForm.Items.Item("Item_22").Specific
    '            '        txt.Value = oFunciones.Nombre_Usuario_Actual()

    '            '        txt = oForm.Items.Item("Item_24").Specific
    '            '        txt.Value = Replace(DateTime.Now.ToString("dd/MM/yyyy"), "-", "/")

    '            '        Formp5.Show()

    '            '    Else
    '            '        Application.SBO_Application.MessageBox("Debe Seleccionar un Proyecto", 1)
    '            '    End If

    '            'End If

    '        End Sub
    '        Private Sub Button5_ClickBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles Button5.ClickBefore

    '            'If Me.Button4.Item.Enabled Then

    '            '    If Me.EditText0.Value.Trim.Length() > 0 Then

    '            '        sPSql = "exec [" + sBDComercial.Trim() + "].[dbo].[MIN_GPR_Estado_PCV_Comercial_Industrial] '" + Me.EditText0.Value.Trim() + "'"

    '            '        sPSql2 = "select * from [" + sBDComercial.Trim() + "].[DBO].[@ZHCEP] where U_Tipo_Proc = 'DESPACHO' and U_PrjCode = '" + Me.EditText0.Value.Trim() + "'"

    '            '        Dim Formp6 As Form7
    '            '        Formp6 = New Form7

    '            '        Dim oUDS As SAPbouiCOM.UserDataSource = Formp6.UIAPIRawForm.DataSources.UserDataSources.Item("UD_0")
    '            '        oUDS.ValueEx = Me.UIAPIRawForm.UniqueID   'Aca asignamos el FormUID de Formulario al Valor del  User Data Source

    '            '        Dim oForm As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(Formp6.UIAPIRawForm.UniqueID)
    '            '        Dim txt As SAPbouiCOM.EditText = oForm.Items.Item("Item_0").Specific
    '            '        txt.Value = EditText0.Value.ToString()
    '            '        txt = oForm.Items.Item("Item_2").Specific
    '            '        txt.Value = EditText1.Value.ToString()
    '            '        txt = oForm.Items.Item("Item_4").Specific
    '            '        txt.Value = EditText2.Value.ToString()
    '            '        txt = oForm.Items.Item("Item_6").Specific
    '            '        txt.Value = EditText3.Value.ToString()
    '            '        txt = oForm.Items.Item("Item_8").Specific
    '            '        txt.Value = EditText4.Value.ToString()
    '            '        txt = oForm.Items.Item("Item_10").Specific
    '            '        txt.Value = EditText5.Value.ToString()
    '            '        txt = oForm.Items.Item("Item_12").Specific
    '            '        txt.Value = EditText6.Value.ToString()

    '            '        txt = oForm.Items.Item("Item_21").Specific
    '            '        txt.Value = oFunciones.Nombre_Usuario_Actual()

    '            '        txt = oForm.Items.Item("Item_23").Specific
    '            '        txt.Value = Replace(DateTime.Now.ToString("dd/MM/yyyy"), "-", "/")

    '            '        Formp6.Show()

    '            '    Else
    '            '        Application.SBO_Application.MessageBox("Debe Seleccionar un Proyecto", 1)
    '            '    End If

    '            'End If

    '        End Sub
    '        Private Sub Button6_ClickBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles Button6.ClickBefore

    '            'If Me.Button6.Item.Enabled Then

    '            '    If Me.EditText0.Value.Trim.Length() > 0 Then

    '            '        sPSql = "exec [" + sBDComercial.Trim() + "].[dbo].[SP_Estado_PCV_Montaje] '" + Me.EditText0.Value.Trim() + "'"

    '            '        sPSql2 = "select * from [" + sBDComercial.Trim() + "].[DBO].[@ZHCEP] where U_Tipo_Proc = 'MONTAJE' and U_PrjCode = '" + Me.EditText0.Value.Trim() + "'"

    '            '        Dim Formp6 As Form8
    '            '        Formp6 = New Form8

    '            '        Dim oUDS As SAPbouiCOM.UserDataSource = Formp6.UIAPIRawForm.DataSources.UserDataSources.Item("UD_0")
    '            '        oUDS.ValueEx = Me.UIAPIRawForm.UniqueID   'Aca asignamos el FormUID de Formulario al Valor del  User Data Source

    '            '        Dim oForm As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(Formp6.UIAPIRawForm.UniqueID)
    '            '        Dim txt As SAPbouiCOM.EditText = oForm.Items.Item("Item_0").Specific
    '            '        txt.Value = EditText0.Value.ToString()
    '            '        txt = oForm.Items.Item("Item_2").Specific
    '            '        txt.Value = EditText1.Value.ToString()
    '            '        txt = oForm.Items.Item("Item_4").Specific
    '            '        txt.Value = EditText2.Value.ToString()
    '            '        txt = oForm.Items.Item("Item_6").Specific
    '            '        txt.Value = EditText3.Value.ToString()
    '            '        txt = oForm.Items.Item("Item_8").Specific
    '            '        txt.Value = EditText4.Value.ToString()
    '            '        txt = oForm.Items.Item("Item_10").Specific
    '            '        txt.Value = EditText5.Value.ToString()
    '            '        txt = oForm.Items.Item("Item_12").Specific
    '            '        txt.Value = EditText6.Value.ToString()

    '            '        txt = oForm.Items.Item("Item_21").Specific
    '            '        txt.Value = oFunciones.Nombre_Usuario_Actual()

    '            '        txt = oForm.Items.Item("Item_23").Specific
    '            '        txt.Value = Replace(DateTime.Now.ToString("dd/MM/yyyy"), "-", "/")

    '            '        Formp6.Show()

    '            '    Else
    '            '        Application.SBO_Application.MessageBox("Debe Seleccionar un Proyecto", 1)
    '            '    End If

    '            'End If


    '        End Sub
    '        Private Sub Button7_ClickBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles Button7.ClickBefore

    '            Application.SBO_Application.MessageBox(oFunciones.HoraEnEntero(Date.Now))

    '            'Dim SboGuiApi As New SAPbouiCOM.SboGuiApi
    '            'Dim SBO_App As SAPbouiCOM.Application
    '            'Dim oCompany As New SAPbobsCOM.Company
    '            'SboGuiApi.Connect("0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056")
    '            'SBO_App = SboGuiApi.GetApplication()
    '            'oCompany = SBO_App.Company.GetDICompany()

    '            'Conectar_Aplicacion()
    '            'Application.SBO_Application.MessageBox(oCompany.UserSignature)

    '            Application.SBO_Application.MessageBox(oConectarAplicacion.sCodUsuActual)

    '            'Dim sLoggedInUser As String
    '            'oForm = Application.SBO_Application.Forms.GetForm(169, 0)
    '            'oStatic = oForm.Items.Item("8").Specific
    '            'sLoggedInUser = oStatic.Caption
    '            'Application.SBO_Application.MessageBox("The current logged in User is " & sLoggedInUser)


    '            'Application.SBO_Application.MessageBox(Application.SBO_Application.Company.GetDICompany(oCompany.).UserSignatur())
    '            'Application.SBO_Application.MessageBox(Application.SBO_Application.Company.GetDICompany(Application.SBO_Application.Company.Name))

    '        End Sub
    '        Private Sub Button8_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button8.ClickAfter

    '            oFunciones.Abre_Dialogo_y_Asigna_Path3(Me.EditText43, DialogType.OPEN)

    '        End Sub

    '        Private Sub Button9_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button9.ClickAfter
    '            ' Insertar un nuevo registro en la Matrix por medio del DataTable

    '            If Me.EditText43.Value.Trim.Length() > 0 Then

    '                oForm = Application.SBO_Application.Forms.ActiveForm()

    '                Try

    '                    If Me.Matrix0.RowCount > 0 Then
    '                        DT_0X.Rows.Add()
    '                    End If

    '                    Dim nRow As Integer = DT_0X.Rows.Count - 1
    '                    DT_0X.SetValue("Archivo", nRow, Me.EditText43.Value.Trim())
    '                    DT_0X.SetValue("Fecha", nRow, Date.Now)
    '                    DT_0X.SetValue("Hora", nRow, DateTime.Now.ToLongTimeString())
    '                    DT_0X.SetValue("Comentario", nRow, Me.EditText45.Value.Trim())
    '                    DT_0X.SetValue("Fila", nRow, nRow + 1)
    '                    DT_0X.SetValue("RutaInic", nRow, Me.EditText43.Value.Trim())

    '                Catch ex As Exception

    '                    Application.SBO_Application.MessageBox("Error al Cargar el DataTable 'DTO_0'")

    '                End Try

    '                Try

    '                    Me.Matrix0.Columns.Item("#").DataBind.Bind("DT_0X", "Fila")
    '                    Me.Matrix0.Columns.Item("Col_0").DataBind.Bind("DT_0X", "Archivo")
    '                    Me.Matrix0.Columns.Item("Col_1").DataBind.Bind("DT_0X", "Fecha")
    '                    Me.Matrix0.Columns.Item("Col_2").DataBind.Bind("DT_0X", "Hora")
    '                    Me.Matrix0.Columns.Item("Col_3").DataBind.Bind("DT_0X", "Comentario")
    '                    Me.Matrix0.Columns.Item("Col_4").DataBind.Bind("DT_0X", "RutaInic")

    '                    oForm.Freeze(True)

    '                    Me.Matrix0.Clear()
    '                    Me.Matrix0.LoadFromDataSource()
    '                    Me.Matrix0.AutoResizeColumns()

    '                    Me.EditText43.Value = ""
    '                    Me.EditText45.Value = ""
    '                    Me.EditText45.Item.Click()

    '                Catch ex As Exception

    '                    Application.SBO_Application.MessageBox("Error al Cargar Matrix desde el DataTable 'DTO_0'")

    '                Finally

    '                    oForm.Freeze(False)

    '                End Try

    '            End If


    '        End Sub

    '        Private Sub Button10_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button10.ClickAfter
    '            'Eliminar una fila de la Matrix mediante el DataTable
    '            oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
    '            Dim rowNum As Integer = Me.Matrix0.GetNextSelectedRow(0, SAPbouiCOM.BoOrderType.ot_RowOrder) - 1

    '            Try

    '                oForm.Freeze(True)

    '                Me.DT_0X.Rows.Remove(rowNum)

    '                For index = 0 To Me.DT_0X.Rows.Count - 1
    '                    DT_0X.SetValue("Fila", index, index + 1)
    '                Next

    '                Me.Matrix0.Clear()
    '                Me.Matrix0.LoadFromDataSource()

    '            Catch ex As Exception
    '            Finally
    '                oForm.Freeze(False)
    '            End Try

    '        End Sub

    '        Private Sub Button11_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button11.ClickAfter
    '            'Actualizar los Datos de los documentos en la tabla ZPLAP con las modificaciones realizadas sobre la matrix
    '            Dim sql As String
    '            oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
    '            If Me.Button11.Item.Enabled Then
    '                If Me.Matrix0.RowCount > 0 Then

    '                    Dim Validador As Boolean = False
    '                    Dim rowNum As Integer = 0
    '                    Dim ArchivoO As String = ""
    '                    Dim ArchivoD As String = ""
    '                    Dim Fecha As Date
    '                    Dim Hora As String = ""
    '                    Dim Comentario As String = ""
    '                    Dim index As Integer
    '                    Dim ProximoC As Integer = 0

    '                    'Borrar los registros Anteriores para insertar los actuales
    '                    sql = "delete from " + sBDComercial.Trim() + ".[dbo].[@ZPLAP]   where  cast(U_Tipo_Plano as nvarchar) = 'DOC' and U_Tipo_Documento = 'DOCUMENTO'  and  U_PrjCode ='" + Me.EditText0.Value.Trim() + "'"
    '                    Try
    '                        DT_SQL1.ExecuteQuery(sql)
    '                        Validador = True
    '                    Catch ex As Exception
    '                        Application.SBO_Application.MessageBox(sql)
    '                        Me.EditText17.Value = sql
    '                        Application.SBO_Application.MessageBox(ex.Message)
    '                        Validador = False
    '                    End Try

    '                    For index = 1 To Me.Matrix0.RowCount ' Recorre la Matrix e inserta los registros en la BD

    '                        oForm.Freeze(True)
    '                        ArchivoO = Me.Matrix0.Columns.Item("Col_0").Cells.Item(index).Specific.Value()

    '                        If Not ArchivoO.Contains(sPathAnexos) Then  ' Solo Copiara a la carpeta Anexos del Servidor los archivos nuevos
    '                            Me.EditText43.Value = ArchivoO   ' Ruta local
    '                            oFunciones.Copiar_Documentos_Anexos_a_Servidor(Me.EditText43)
    '                            ArchivoD = Me.EditText43.Value()  'Ruta Servidor
    '                        Else
    '                            ArchivoO = Me.Matrix0.Columns.Item("Col_4").Cells.Item(index).Specific.Value() 'Ruta Local
    '                            ArchivoD = Me.Matrix0.Columns.Item("Col_0").Cells.Item(index).Specific.Value() 'Ruta Servidor
    '                        End If

    '                        Fecha = DateTime.ParseExact(Me.Matrix0.Columns.Item("Col_1").Cells.Item(index).Specific.Value(), "yyyyMMdd", Nothing).ToString("dd\/MM\/yyyy")
    '                        Hora = Me.Matrix0.Columns.Item("Col_2").Cells.Item(index).Specific.Value()
    '                        Comentario = Me.Matrix0.Columns.Item("Col_3").Cells.Item(index).Specific.Value()

    '                        'ProximoC = Proximo_Codigo_ZPLAP()

    '                        'sql = " INSERT INTO  " + sBDComercial.Trim() + ".[dbo].[@ZPLAP] " & _
    '                        '      " ([Code],[Name],[U_PrjCode],[U_PathOrigen] " & _
    '                        '      " ,[U_PtahServer],[U_Fec_Registro],[U_Hora_Registro],[U_User_Id] " & _
    '                        '      " ,[U_Tipo_Plano],[U_Comentario],[U_Status],[U_Tipo_Documento],[U_Renglon]) " & _
    '                        '      " VALUES " & _
    '                        '      " ('" + ProximoC.ToString() + "','" + ProximoC.ToString() + "','" + Me.EditText0.Value.Trim() + "','" + ArchivoO + "'" & _
    '                        '      " ,'" + ArchivoD + "',convert(date,'" + Fecha + "',103) ,'" + Hora + "','" + oCompany.UserSignature.ToString() + "'" & _
    '                        '      " ,'DOC','" + Comentario + "','','DOCUMENTO','" + index.ToString + "')"

    '                        Try

    '                            sql = NDocumProyecto.Insertar_Documento(Me.EditText0.Value.Trim(),
    '                                                                        ArchivoO,
    '                                                                        ArchivoD,
    '                                                                        Fecha,
    '                                                                        Hora,
    '                                                                        oCompany.UserSignature.ToString(),
    '                                                                        "DOC",
    '                                                                        Comentario,
    '                                                                        "",
    '                                                                        "DOCUMENTO",
    '                                                                        index.ToString)
    '                            'DT_SQL1.ExecuteQuery(sql)
    '                            Validador = True

    '                        Catch ex As Exception
    '                            Application.SBO_Application.MessageBox(sql)
    '                            Me.EditText17.Value = sql
    '                            Application.SBO_Application.MessageBox(ex.Message)
    '                            Validador = False
    '                        Finally
    '                            Me.EditText43.Value = ""
    '                            oForm.Freeze(False)
    '                        End Try
    '                    Next

    '                    '------------------------------------------------------------------------------------
    '                    ' Verificacion de que todos los INSERT y UPDATE se realizaron correctamente
    '                    '------------------------------------------------------------------------------------
    '                    If Validador Then
    '                        oForm.Freeze(True)
    '                        Cargar_Matrix()
    '                        oForm.Freeze(False)
    '                        Application.SBO_Application.MessageBox("Se han Actualizado los Documentos")
    '                    End If

    '                Else  ' Aca se verifica la condicion: Si la matrix esta vacia y existen documento en la BD, se confirme borrar todos los datos en la BD.

    '                    If Me.EditText0.Value.Trim().Length > 0 Then
    '                        'Se buscan si existen registros en la BD
    '                        sql = " select [U_PtahServer] as Archivo,[U_Fec_Registro] as Fecha,[U_Hora_Registro] as Hora,[U_Comentario] as Comentario,[U_Renglon] as Fila,[U_PathOrigen] as RutaInic" &
    '                        " from  " + sBDComercial.Trim() + ".[dbo].[@ZPLAP]   " &
    '                        " where U_Tipo_Documento = 'DOCUMENTO' and U_PrjCode = '" + Me.EditText0.Value.Trim() + "' order by U_Renglon "

    '                        Try
    '                            DT_SQL1.ExecuteQuery(sql)
    '                        Catch ex As Exception
    '                            Application.SBO_Application.MessageBox(sql)
    '                            Application.SBO_Application.MessageBox(ex.Message)
    '                        End Try

    '                        If DT_SQL1.IsEmpty = False Then
    '                            If Application.SBO_Application.MessageBox("Con esto Eliminara Todos los Documentos Asociados al Proyecto", 2, "Eliminar Todo", "Cancelar") = 1 Then

    '                                sql = "delete from " + sBDComercial.Trim() + ".[dbo].[@ZPLAP]   where  cast(U_Tipo_Plano as nvarchar) = 'DOC' and U_Tipo_Documento = 'DOCUMENTO'  and  U_PrjCode ='" + Me.EditText0.Value.Trim() + "'"

    '                                Try
    '                                    DT_SQL1.ExecuteQuery(sql)
    '                                Catch ex As Exception
    '                                    Application.SBO_Application.MessageBox(sql)
    '                                    Application.SBO_Application.MessageBox(ex.Message)
    '                                End Try
    '                            End If
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        End Sub

    '        Private Sub Button12_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button12.ClickAfter
    '            'Recargar la Matrix
    '            oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)

    '            If Me.EditText0.Value.Trim.Length > 0 Then

    '                If Application.SBO_Application.MessageBox("Recargar los Datos desde la BD, se Perderan los Cambios sin Actualizar", 2, "Recargar", "Cancelar") = 1 Then

    '                    Try
    '                        oForm.Freeze(True)
    '                        Cargar_Matrix()
    '                    Catch ex As Exception

    '                    Finally
    '                        oForm.Freeze(False)
    '                    End Try


    '                End If

    '            End If


    '        End Sub

    '        Private Sub Button13_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button13.ClickAfter
    '            If Me.Button13.Item.Enabled Then
    '                If Me.Button13.Caption = "Mod. Cli." And Me.EditText0.Value.Trim.Length > 0 Then
    '                    Me.EditText1.Item.Enabled = True
    '                    Me.EditText1.Active = True
    '                    Me.EditText47.Item.Enabled = True
    '                    Me.EditText47.Active = True
    '                    Me.EditText48.Value = Me.EditText47.Value
    '                    Me.EditText47.Value = ""
    '                    Me.Button13.Caption = "Bloq. Cli."
    '                    Me.EditText47.Active = True
    '                    Application.SBO_Application.SendKeys("{TAB}")
    '                Else
    '                    Me.Button13.Caption = "Mod. Cli."
    '                    Me.EditText48.Item.Click()
    '                    Me.EditText1.Active = False
    '                    Me.EditText1.Item.Enabled = False
    '                    Me.EditText48.Item.Click()
    '                    If Me.EditText47.Value.Trim.Length = 0 Then
    '                        Me.EditText47.Value = Me.EditText48.Value
    '                    End If
    '                    Me.EditText47.Active = False
    '                    Me.EditText47.Item.Enabled = False
    '                End If
    '            End If
    '        End Sub

    '        Private Sub Button14_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button14.ClickAfter

    '            If Button14.Item.Enabled Then
    '                If Me.Button14.Caption = "Habilitar Campos" Then

    '                    Me.Button14.Caption = "Bloquear Campos"
    '                    Me.Button15.Item.Enabled = True
    '                    Me.EditText39.Item.Enabled = True
    '                    Me.EditText49.Item.Enabled = True
    '                    Me.EditText51.Item.Enabled = True
    '                    Me.EditText52.Item.Enabled = True
    '                    Me.CheckBox0.Item.Enabled = True
    '                    Me.CheckBox1.Item.Enabled = True
    '                    Me.OptionBtn0.Item.Enabled = True
    '                    Me.OptionBtn1.Item.Enabled = True
    '                    Me.OptionBtn2.Item.Enabled = True
    '                    Me.ComboBox6.Item.Enabled = True
    '                    Me.EditText49.Item.Click()

    '                Else

    '                    oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
    '                    oForm.Freeze(True)
    '                    Try

    '                        Me.Folder2.Item.Click()
    '                        Me.Button14.Caption = "Habilitar Campos"
    '                        Me.Button15.Item.Enabled = False
    '                        Me.EditText39.Active = False
    '                        Me.EditText39.Item.Enabled = False
    '                        Me.EditText49.Active = False
    '                        Me.EditText49.Item.Enabled = False
    '                        Me.EditText51.Active = False
    '                        Me.EditText51.Item.Enabled = False
    '                        Me.Folder2.Item.Click()
    '                        Me.EditText52.Active = False
    '                        Me.EditText52.Item.Enabled = False
    '                        Me.CheckBox0.Item.Enabled = False
    '                        Me.CheckBox1.Item.Enabled = False
    '                        Me.OptionBtn0.Item.Enabled = False
    '                        Me.OptionBtn1.Item.Enabled = False
    '                        Me.OptionBtn2.Item.Enabled = False
    '                        Me.ComboBox6.Item.Enabled = False

    '                    Catch ex As Exception
    '                    Finally
    '                        oForm.Freeze(False)
    '                    End Try

    '                End If
    '            End If

    '        End Sub

    '        Private Sub Button15_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button15.ClickAfter

    '            If Me.Button15.Item.Enabled Then

    '                If Application.SBO_Application.MessageBox("¿Actualizar Cambios en Multa del Proyecto?", 2, "Actualizar", "Cancelar") = 1 Then



    '                    'TOMAMOS LOS DATOS DE LA MULTA CARGADOS DESDE LA SELECCION DEL PROYECTO Y COLOCADOS EN DT_INFO
    '                    Dim Multa As String = If(Me.DT_INFO.GetValue("Multa", 0) = "Si", "Y", "N")
    '                    Dim Multa_Desp As String = Me.DT_INFO.GetValue("Multa_Despa", 0)
    '                    Dim Multa_Mont As String = Me.DT_INFO.GetValue("Multa_Monta", 0)
    '                    Dim Fec_Ini_Multa As String = Me.DT_INFO.GetValue("Fecha_Ini_Multa", 0)
    '                    Dim Poc_Multa As String = Replace(Me.DT_INFO.GetValue("Porc_Multa", 0), ",", ".")
    '                    Dim Tope_Multa As String = Replace(Me.DT_INFO.GetValue("Tope_Multa", 0), ",", ".")
    '                    Dim Frec_Multa As String = Me.DT_INFO.GetValue("Frecuencia_Multa", 0)
    '                    Dim Coment_Multa As String = Me.DT_INFO.GetValue("Comentario_Multa", 0)
    '                    Dim sProxCod As Integer = Proximo_Codigo_ZHCMP()

    '                    Dim sql = " INSERT INTO " + sBDComercial.Trim() + ".[dbo].[@ZHCMP] " &
    '                             " ([Code] " &
    '                             " ,[Name] " &
    '                             " ,[U_Multa_Ant] " &
    '                             " ,[U_Multa_Nvo] " &
    '                             " ,[U_Multa_Desp_Ant] " &
    '                             " ,[U_Multa_Desp_Nvo] " &
    '                             " ,[U_Multa_Mont_Ant] " &
    '                             " ,[U_Multa_Mont_Nvo] " &
    '                             " ,[U_Fec_Ini_Multa_Ant] " &
    '                             " ,[U_Fec_Ini_Multa_Nvo] " &
    '                             " ,[U_Porc_Multa_Ant] " &
    '                             " ,[U_Porc_Multa_Nvo] " &
    '                             " ,[U_Tope_Multa_Ant] " &
    '                             " ,[U_Tope_Multa_Nvo] " &
    '                             " ,[U_Frec_Multa_Ant] " &
    '                             " ,[U_Frec_Multa_Nvo] " &
    '                             " ,[U_Coment_Multa_Ant] " &
    '                             " ,[U_Coment_Multa_Nvo] " &
    '                             " ,[U_User_ID] " &
    '                             " ,[U_User_Name] " &
    '                             " ,[U_Fecha_Registro] " &
    '                             " ,[U_Hora_Registro] " &
    '                             " ,[U_PrjName]" &
    '                             " ,[U_PrjCode]) " &
    '                                      " VALUES( " &
    '                             " '" + sProxCod.ToString() + "'" &
    '                             " ,'" + sProxCod.ToString() + "'" &
    '                             " ,'" + Multa + "' " &
    '                             " ,'" + If(Me.ComboBox6.Value = "Si", "Y", "N") + "' " &
    '                             " ,'" + Multa_Desp + "' " &
    '                             " ,'" + If(Me.CheckBox0.Checked, "Y", "N") + "'" &
    '                             " ,'" + Multa_Mont + "' " &
    '                             " ,'" + If(Me.CheckBox1.Checked, "Y", "N") + "'" &
    '                             " ,convert(date,'" + Fec_Ini_Multa + "',103)  " &
    '                             " ,convert(date,'" + Me.EditText49.Value.Trim() + "',103) " &
    '                             " , ISNULL(CAST(NULLIF('" + Poc_Multa + "', 'NULL') AS numeric(10, 2)), 0)" &
    '                             " , ISNULL(CAST(NULLIF('" + Me.EditText51.Value.Trim() + "', 'NULL') AS numeric(10, 2)), 0)" &
    '                             " , ISNULL(CAST(NULLIF('" + Tope_Multa + "', 'NULL') AS numeric(10, 2)), 0) " &
    '                             " , ISNULL(CAST(NULLIF('" + Me.EditText52.Value.Trim() + "', 'NULL') AS numeric(10, 2)), 0)" &
    '                             " ,'" + Frec_Multa + "' " &
    '                             " ,'" + If(Me.OptionBtn0.Selected, "D", If(Me.OptionBtn1.Selected, "S", If(Me.OptionBtn2.Selected, "M", ""))) + "'" &
    '                             " ,'" + Coment_Multa + "' " &
    '                             " ,'" + Me.EditText39.Value.Trim() + "'" &
    '                             " ,'" + oCompany.UserSignature.ToString() + "'" &
    '                             " ,'" + oFunciones.Nombre_Usuario_Actual() + "'" &
    '                             " ,convert(datetime,'" + DateTime.Now.ToString() + "',103) " &
    '                             " ,'" + DateTime.Now.ToLongTimeString + "'" &
    '                             " ,'" + Me.EditText2.Value.Trim() + "'" &
    '                             " ,'" + Me.EditText0.Value.Trim() + "')"


    '                    Dim sqlx = " UPDATE [dbo].[@ZINFOP] " &
    '                              "  SET [U_Multa] = '" + If(Me.ComboBox6.Value = "Si", "Y", "N") + "' " &
    '                              "     ,[U_Multa_Desp] = '" + If(Me.CheckBox0.Checked, "Y", "N") + "'" &
    '                              "     ,[U_Multa_Mont] = '" + If(Me.CheckBox1.Checked, "Y", "N") + "'" &
    '                              "     ,[U_Fec_Ini_Multa] = convert(date,'" + Me.EditText49.Value.Trim() + "',103)" &
    '                              "     ,[U_Poc_Multa] = '" + Me.EditText51.Value.Trim() + "'" &
    '                              "     ,[U_Tope_Multa] ='" + Me.EditText52.Value.Trim() + "'" &
    '                              "     ,[U_Frec_Multa] = '" + If(Me.OptionBtn0.Selected, "D", If(Me.OptionBtn1.Selected, "S", If(Me.OptionBtn2.Selected, "M", ""))) + "'" &
    '                              "     ,[U_Coment_Multa] = '" + Me.EditText39.Value.Trim() + "'" &
    '                              " WHERE cast(U_PrjCode as nvarchar) = '" + Me.EditText0.Value.Trim() + "'"

    '                    Try

    '                        DT_SQL1.ExecuteQuery(sql)
    '                        DT_SQL1.ExecuteQuery(sqlx)
    '                        Application.SBO_Application.StatusBar.SetText("Actualizacion de Datos de Multa Concluida", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success)

    '                        If ComboBox6.Value = "Si" Then
    '                            EditText3.Value = "Si"
    '                            PictureBox1.Picture = sPathAnexos + "images\Rojo.png"
    '                        Else
    '                            EditText3.Value = "No"
    '                            PictureBox1.Picture = sPathAnexos + "images\Verde.png"
    '                        End If

    '                        If Me.EditText49.Item.Enabled Then
    '                            Me.Button14.Item.Click()
    '                        End If

    '                    Catch ex As Exception

    '                        Application.SBO_Application.MessageBox(sql)
    '                        Application.SBO_Application.MessageBox(ex.Message)

    '                    End Try

    '                End If

    '            End If

    '        End Sub

    '        Private Sub Button16_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button16.ClickAfter

    '            If Button16.Item.Enabled Then
    '                If Me.Button16.Caption = "Habilitar Campos" Then

    '                    Me.Button16.Caption = "Bloquear Campos"
    '                    Me.Button17.Item.Enabled = True
    '                    Me.EditText57.Item.Enabled = True
    '                    Me.EditText58.Item.Enabled = True
    '                    Me.EditText59.Item.Enabled = True
    '                    Me.EditText77.Item.Enabled = True
    '                    Me.EditText78.Item.Enabled = True
    '                    Me.EditText79.Item.Enabled = True
    '                    Me.EditText82.Item.Enabled = True
    '                    Me.EditText81.Item.Enabled = True
    '                    Me.EditText87.Item.Enabled = True
    '                    Me.EditText88.Item.Enabled = True
    '                    Me.CheckBox2.Item.Enabled = True
    '                    Me.CheckBox3.Item.Enabled = True
    '                    Me.OptionBtn3.Item.Enabled = True
    '                    Me.OptionBtn4.Item.Enabled = True
    '                    Me.ComboBox8.Item.Enabled = True
    '                    Me.ComboBox9.Item.Enabled = True
    '                    Me.ComboBox10.Item.Enabled = True
    '                    Me.OptionBtn5.Item.Enabled = True
    '                    Me.OptionBtn6.Item.Enabled = True
    '                    Me.OptionBtn7.Item.Enabled = True
    '                    Me.OptionBtn8.Item.Enabled = True
    '                    Me.EditText89.Item.Enabled = True
    '                    Me.EditText90.Item.Enabled = True

    '                    Me.EditText57.Item.Click()

    '                Else

    '                    oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
    '                    oForm.Freeze(True)
    '                    Try

    '                        Me.Folder3.Item.Click()
    '                        Me.Button16.Caption = "Habilitar Campos"
    '                        Me.Button17.Item.Enabled = False
    '                        Me.EditText57.Active = False
    '                        Me.EditText57.Item.Enabled = False
    '                        Me.EditText58.Active = False
    '                        Me.EditText58.Item.Enabled = False
    '                        Me.EditText59.Active = False
    '                        Me.EditText59.Item.Enabled = False
    '                        Me.EditText77.Active = False
    '                        Me.EditText77.Item.Enabled = False
    '                        Me.EditText78.Active = False
    '                        Me.EditText78.Item.Enabled = False
    '                        Me.EditText79.Active = False
    '                        Me.EditText79.Item.Enabled = False
    '                        Me.EditText82.Active = False
    '                        Me.EditText82.Item.Enabled = False
    '                        Me.EditText81.Active = False
    '                        Me.EditText81.Item.Enabled = False
    '                        Me.EditText87.Active = False
    '                        Me.EditText87.Item.Enabled = False
    '                        Me.EditText88.Active = False
    '                        Me.EditText88.Item.Enabled = False
    '                        Me.EditText89.Active = False
    '                        Me.EditText89.Item.Enabled = False
    '                        Me.EditText90.Active = False
    '                        Me.EditText90.Item.Enabled = False
    '                        Me.CheckBox2.Item.Enabled = False
    '                        Me.CheckBox3.Item.Enabled = False
    '                        Me.OptionBtn3.Item.Enabled = False
    '                        Me.OptionBtn4.Item.Enabled = False
    '                        Me.ComboBox8.Item.Enabled = False
    '                        Me.ComboBox9.Item.Enabled = False
    '                        Me.ComboBox10.Item.Enabled = False
    '                        Me.OptionBtn5.Item.Enabled = False
    '                        Me.OptionBtn6.Item.Enabled = False
    '                        Me.OptionBtn7.Item.Enabled = False
    '                        Me.OptionBtn8.Item.Enabled = False
    '                        Me.Folder3.Item.Click()

    '                    Catch ex As Exception
    '                    Finally
    '                        oForm.Freeze(False)
    '                    End Try
    '                End If
    '            End If

    '        End Sub

    '        Private Shared Sub Bloquear_Campos_Otros_Datos(oFormP As SAPbouiCOM.Form)

    '            Try

    '                oFormP.Items.Item("Item_129").Specific.Item.Click()
    '                oFormP.Items.Item("Item_155").Specific.Caption = "Habilitar Campos"
    '                oFormP.Items.Item("Item_156").Specific.Item.Enabled = False
    '                oFormP.Items.Item("Item_159").Specific.Active = False
    '                oFormP.Items.Item("Item_159").Specific.Item.Enabled = False
    '                oFormP.Items.Item("Item_160").Specific.Active = False
    '                oFormP.Items.Item("Item_160").Specific.Item.Enabled = False
    '                oFormP.Items.Item("Item_161").Specific.Active = False
    '                oFormP.Items.Item("Item_161").Specific.Item.Enabled = False
    '                'oFormP.Items.Item("Item_167").Specific.Active = False
    '                oFormP.Items.Item("Item_167").Specific.Item.Enabled = False
    '                'oFormP.Items.Item("Item_170").Specific.Active = False
    '                oFormP.Items.Item("Item_170").Specific.Item.Enabled = False
    '                'oFormP.Items.Item("Item_171").Specific.Active = False
    '                oFormP.Items.Item("Item_171").Specific.Item.Enabled = False
    '                'oFormP.Items.Item("Item_185").Specific.Active = False
    '                oFormP.Items.Item("Item_185").Specific.Item.Enabled = False
    '                'oFormP.Items.Item("Item_191").Specific.Active = False
    '                oFormP.Items.Item("Item_191").Specific.Item.Enabled = False
    '                oFormP.Items.Item("Item_189").Specific.Item.Enabled = False
    '                oFormP.Items.Item("Item_190").Specific.Item.Enabled = False
    '                oFormP.Items.Item("Item_193").Specific.Item.Enabled = False
    '                oFormP.Items.Item("Item_194").Specific.Item.Enabled = False
    '                oFormP.Items.Item("Item_207").Specific.Item.Enabled = False
    '                oFormP.Items.Item("Item_129").Specific.Item.Click()
    '            Catch ex As Exception

    '            End Try

    '        End Sub


    '        Private Sub Button17_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button17.ClickAfter

    '            If Me.Button17.Item.Enabled Then

    '                If Application.SBO_Application.MessageBox("¿Actualizar Datos del Proyeto?", 2, "Actualizar", "Cancelar") = 1 Then

    '                    Dim sFecTerDesa As String = If(Me.EditText79.String.Trim.Length() = 0, "U_Fec_Real_Ter_Des", "convert(date,'" + Me.EditText79.Value.Trim() + "',103) ")
    '                    Dim sFecIniMont As String = If(Me.EditText77.String.Trim.Length() = 0, "U_Fec_Real_Ini_Mon", "convert(date,'" + Me.EditText77.Value.Trim() + "',103) ")
    '                    Dim sFecTerMont As String = If(Me.EditText78.String.Trim.Length() = 0, "U_Fec_Real_Fin_Mon", "convert(date,'" + Me.EditText78.Value.Trim() + "',103) ")
    '                    Dim sJefeProyectoCod As String = ComboBox8.Selected.Value
    '                    Dim sJefeProyecto As String = ComboBox8.Selected.Description


    '                    Dim Sql = " UPDATE " + sBDComercial.Trim() + ".[dbo].[@ZINFOP] " &
    '                               " SET [U_Fec_Real_Ter_Des] = " + sFecTerDesa + " " &
    '                               "     ,[U_Fec_Real_Ini_Mon] = " + sFecIniMont + " " &
    '                               "     ,[U_Fec_Real_Fin_Mon] = " + sFecTerMont + " " &
    '                               "     ,[U_Contrato_Cli] = '" + EditText82.Value.Trim() + "'" &
    '                               "     ,[U_Con_Despacho] = " + If(Me.CheckBox2.Checked, "1", "0") + "" &
    '                               "     ,[U_Con_Montaje] =  " + If(Me.CheckBox3.Checked, "1", "0") + "" &
    '                               "     ,[U_Monto_OCC] = ISNULL(CAST(NULLIF('" + Me.EditText81.Value.Trim() + "', 'NULL') AS numeric(20, 6)), 0)" &
    '                               "     ,[U_Desa_Asigna] = '" + If(Me.OptionBtn3.Selected, "C", "I") + "'" &
    '                               "     ,[U_Cod_Jefe_Proy_Com] = '" + sJefeProyectoCod + "' " &
    '                               "     ,[U_Jefe_Proy_Com] = '" + sJefeProyecto + "'" &
    '                               "     ,[U_Condicion_Pago] = '" + ComboBox9.Selected.Value + "'" &
    '                               "     ,[U_Porc_Anticipo] = ISNULL(CAST(NULLIF('" + Me.EditText87.Value.Trim() + "', 'NULL') AS numeric(8, 2)), 0)" &
    '                               "     ,[U_Dias_Pago] = ISNULL(CAST(NULLIF('" + Me.EditText88.Value.Trim() + "', 'NULL') AS numeric(8, 2)), 0)" &
    '                               "     ,[U_Medio_Pago] = '" + ComboBox10.Selected.Value + "'" &
    '                               "     ,[U_Monto_OCCE] = ISNULL(CAST(NULLIF('" + Me.EditText89.Value.Trim() + "', 'NULL') AS numeric(20, 6)), 0)" &
    '                               "     ,[U_Contrato_Constru] = '" + If(Me.OptionBtn5.Selected, "Y", "N") + "'" &
    '                               "     ,[U_Prj_Code_Ini] = '" + EditText90.Value.Trim() + "'" &
    '                               "     ,[U_Tipo_Pryecto] = '" + If(Me.OptionBtn7.Selected, "U", "E") + "'" &
    '                               " WHERE cast(U_PrjCode as nvarchar) = '" + Me.EditText0.Value.Trim() + "'"


    '                    Try

    '                        DT_SQL1.ExecuteQuery(Sql)
    '                        Application.SBO_Application.StatusBar.SetText("Actualizacion de Datos Concluida", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success)

    '                        'If Me.EditText76.Item.Enabled Then
    '                        Me.Button16.Item.Click()
    '                        'End If

    '                        Me.EditText76.String = If(Me.EditText79.String.Trim.Length() = 0, Me.EditText76.String, Me.EditText79.String.Trim)
    '                        Me.EditText68.String = If(Me.EditText77.String.Trim.Length() = 0, Me.EditText68.String, Me.EditText77.String.Trim)
    '                        Me.EditText69.String = If(Me.EditText78.String.Trim.Length() = 0, Me.EditText69.String, Me.EditText78.String.Trim)
    '                        Me.EditText80.Value = "T"

    '                    Catch ex As Exception

    '                        Application.SBO_Application.MessageBox(Sql)
    '                        Application.SBO_Application.MessageBox(ex.Message)

    '                    End Try

    '                End If

    '            End If

    '        End Sub

    '        Private Sub Button18_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button18.ClickAfter

    '            If Me.EditText57.Item.Enabled Then

    '                Me.EditText57.Item.Click()
    '                Me.EditText57.Value = ""
    '                Me.EditText57.Active = True
    '                Application.SBO_Application.SendKeys("{TAB}")

    '            End If

    '        End Sub

    '        Private Sub Button19_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button19.ClickAfter
    '            '----------------------------------------------------------------------------------------------------------------------------------------------------------
    '            'Abre la Pantalla de Estado Comercial e Ingenieria, envia los Querys para hacer la consulta y mostrar los datos en el Grid al cargar el Form
    '            '----------------------------------------------------------------------------------------------------------------------------------------------------------
    '            Try

    '                If Me.EditText0.Value.Trim.Length() > 0 Then
    '                    Try
    '                        Dim Formp4 As New FormMapaD()
    '                        Dim oFormD As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(Formp4.UIAPIRawForm.UniqueID)

    '                        Dim oUDS As SAPbouiCOM.UserDataSource = oFormD.DataSources.UserDataSources.Item("UD_0")
    '                        oUDS.ValueEx = pVal.FormUID   'Aca asignamos el FormUID de Formulario al Valor del  User Data Source

    '                        Dim oUDS2 As SAPbouiCOM.UserDataSource = oFormD.DataSources.UserDataSources.Item("UD_1")
    '                        oUDS2.ValueEx = Me.EditText0.Value.Trim()   'Aca asignamos el Codigo del Proyecto al User Data Source

    '                        Dim txt As SAPbouiCOM.EditText = oFormD.Items.Item("Item_10").Specific
    '                        txt.Value = EditText0.Value.ToString()
    '                        txt = oFormD.Items.Item("Item_12").Specific
    '                        txt.Value = EditText1.Value.ToString()
    '                        txt = oFormD.Items.Item("Item_14").Specific
    '                        txt.Value = EditText2.Value.ToString()
    '                        txt = oFormD.Items.Item("Item_16").Specific
    '                        txt.Value = EditText3.Value.ToString()
    '                        txt = oFormD.Items.Item("Item_18").Specific
    '                        txt.Value = EditText4.Value.ToString()
    '                        txt = oFormD.Items.Item("Item_20").Specific
    '                        txt.Value = EditText5.Value.ToString()
    '                        txt = oFormD.Items.Item("Item_22").Specific
    '                        txt.Value = EditText6.Value.ToString()
    '                        txt = oFormD.Items.Item("Item_24").Specific
    '                        txt.Value = EditText7.Value.ToString()

    '                        Formp4.Show()
    '                        oFormD.Select()

    '                    Catch ex As Exception
    '                        Application.SBO_Application.StatusBar.SetText(ex.Message)
    '                    Finally
    '                    End Try
    '                Else
    '                    Application.SBO_Application.MessageBox("Debe Seleccionar un Proyecto", 1)
    '                End If

    '            Catch ex As Exception

    '            End Try

    '            '----------------------------------------------------------------------------------------------------------------------------------------------------------
    '            '   PRUEBA DE PROCESO PARA EJECUTAR UNA FORMULA MATEMATICA CONTENIDA EN UNA VARIABLE DE TIPO STRING
    '            '----------------------------------------------------------------------------------------------------------------------------------------------------------

    '            ''Application.SBO_Application.MessageBox(oCompany.CompanyName())
    '            ''Application.SBO_Application.MessageBox(oCompany.CompanyDB)


    '            'Dim oSC As New MSScriptControl.ScriptControl()
    '            'Dim expMath As String
    '            'Dim expToEval As String

    '            'oSC.Language = "VBScript"

    '            'expMath = "X ^ 2 + 2 * X + 1"
    '            'expToEval = Replace(expMath, "X", 5)

    '            'Application.SBO_Application.MessageBox(oSC.Eval(expToEval))

    '            'Dim sc As New MSScriptControl.ScriptControl()
    '            '' You always need to initialize a language engine
    '            'sc.Language = "VBScript"
    '            '' this is the expression - in a real program it will probably be
    '            '' read from a textbox control 
    '            'Dim expr As String = "12 + 3 * 10"
    '            'Dim res As Double = sc.Eval(expr)

    '            '' display the result
    '            'Application.SBO_Application.MessageBox(res)

    '        End Sub

    '        Private Sub Button20_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button20.ClickAfter

    '            Dim RetVal As Long
    '            Dim ErrCode As Long
    '            Dim ErrMsg As String = ""
    '            Dim ItemCode As String = ""
    '            Dim vItem As SAPbobsCOM.BusinessPartners


    '            'sPSql = " select ItemCode " &
    '            '        " from [SBO_COMERCIAL].[DBO].OITM WHERE ItemCode NOT IN (Select DISTINCT ItemCode FROM [SBO_COMERCIAL].[DBO].OINM) " &
    '            '        " and ItemCode NOT IN (Select DISTINCT ItemCode FROM [SBO_COMERCIAL].[DBO].OIVL) " &
    '            '        " ORDER BY ItemCode "

    '            sPSql = "select CardCode from [xxx_fre_Test_Industrial].dbo.OCRD where CardName NOT like '%MINDUG%'"

    '            Try
    '                DT_SQL2.ExecuteQuery(sPSql)
    '            Catch ex As Exception

    '            End Try

    '            Try
    '                'oConectarAplicacion.Conectar_Aplicacion(oCompany)
    '                vItem = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners)

    '                For i = 0 To DT_SQL2.Rows.Count - 1

    '                    ItemCode = DT_SQL2.GetValue("CardCode", i)
    '                    'Retrieve the record to remove from the database
    '                    RetVal = vItem.GetByKey(ItemCode)
    '                    If RetVal <> 0 And RetVal <> -1 Then
    '                        oCompany.GetLastError(ErrCode, ErrMsg)
    '                        'MsgBox("Failed to Retrieve the record " & ErrCode & " " & ErrMsg)
    '                        'Exit Sub
    '                    End If
    '                    'Remove the record from the table in the DB
    '                    RetVal = vItem.Remove
    '                    If RetVal <> 0 Then
    '                        oCompany.GetLastError(ErrCode, ErrMsg)
    '                        'MsgBox("Failed to Remove the record " & ErrCode & " " & ErrMsg)
    '                        'Exit Sub
    '                    End If

    '                Next

    '            Catch ex As Exception

    '            End Try

    '        End Sub

    '        Private Sub Button21_ClickBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles Button21.ClickBefore

    '            Dim oDocumentoXML As Xml.XmlDocument

    '            Dim sResultado As String

    '            Try
    '                oDocumentoXML = New Xml.XmlDocument

    '                oDocumentoXML.Load("C:\Users\Programador\Desktop\Proyecto Mindugar\Proyectos 2\Proyectos\bin\x86\Menu2.xml")

    '                Application.SBO_Application.LoadBatchActions(oDocumentoXML.InnerXml)

    '                sResultado = Application.SBO_Application.GetLastBatchResults()

    '                Dim oXmlDoc As Xml.XmlDocument

    '                oXmlDoc = New Xml.XmlDocument

    '                '// load the content of the XML File

    '                oXmlDoc.Load("C:\Users\Programador\Desktop\Proyecto Mindugar\Proyectos 2\Proyectos\bin\x86\Menu2.xml")

    '                '// load the form to the SBO application in one batch
    '                Application.SBO_Application.LoadBatchActions(oXmlDoc.InnerXml)
    '            Catch ex As Exception

    '            End Try


    '        End Sub

    '        Private Sub Button22_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button22.ClickAfter

    '            If Me.Button22.Item.Enabled Then

    '                If (Button22.Caption <> "PROYECTO RECEPCIONADO") Then

    '                    If (Application.SBO_Application.MessageBox("Se Recepcionara el Proyecto '" + Me.EditText0.Value.Trim() + "'. Confirmar Accion", 1, "Recepcionar", "Cancelar") = 1) Then

    '                        Dim Sql As String = "UPDATE [" + sBDComercial.Trim() + "].DBO.[@ZINFOP]  Set " &
    '                                      " U_Estado_M = '7' " &
    '                                      " Where U_PrjCode = '" + Me.EditText0.Value.Trim() + "'"

    '                        Try
    '                            DT_SQL2.ExecuteQuery(Sql)
    '                            Button22.Caption = "PROYECTO RECEPCIONADO"
    '                        Catch ex As Exception

    '                        End Try

    '                    End If

    '                Else

    '                    If (Application.SBO_Application.MessageBox("Revertir Recepcion del Proyecto '" + Me.EditText0.Value.Trim() + "'. Confirmar Accion", 1, "Revertir", "Cancelar") = 1) Then

    '                        Dim Sql As String = "UPDATE [" + sBDComercial.Trim() + "].DBO.[@ZINFOP]  Set " &
    '                                      " U_Estado_M = null " &
    '                                      " Where U_PrjCode = '" + Me.EditText0.Value.Trim() + "'"

    '                        Try
    '                            DT_SQL2.ExecuteQuery(Sql)
    '                            Button22.Caption = "Recepcionar Proyecto Sin Montaje (Entregado)"
    '                        Catch ex As Exception

    '                        End Try

    '                    End If

    '                End If

    '            End If


    '        End Sub

    '        Private Sub Button23_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button23.ClickAfter

    '            Dim SBO_Company As SAPbobsCOM.Company = DConectarAplicacion.oCompanyPS
    '            Dim DetalleObjeto As New List(Of Object)
    '            Dim Objeto As New DProyectos()

    '            NProyectos.CargarProyecto(Objeto, EditText0.String.Trim())

    '            'get company service
    '            Try
    '                If Not SBO_Company.Connected Then
    '                    Dim oConectarAplicacion As New DConectarAplicacion()
    '                    oConectarAplicacion.Conectar_Aplicacion()
    '                    SBO_Company = oConectarAplicacion.oCompany
    '                End If

    '                Dim oRecordSet As SAPbobsCOM.Recordset = SBO_Company.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

    '                Dim sql As String = "select * from [@ZINFOP] where U_PrjCode = '" + EditText0.String + "'"
    '                oRecordSet.DoQuery(sql)

    '                'If oRecordSet.RecordCount > 0 Then
    '                '    For index = 0 To oRecordSet.Fields.Count - 1
    '                '        Dim campo = oRecordSet.Fields.Item(index).Name.Trim().Substring(0, 2)
    '                '        If oRecordSet.Fields.Item(index).Name.Trim().Substring(0, 2) = "U_" Then

    '                '        End If
    '                '    Next
    '                'End If

    '                For Each propiedad As PropertyInfo In Objeto.GetType.GetProperties
    '                    Try
    '                        Dim tipoPropiedad As String = propiedad.PropertyType.Name
    '                        Dim NombrePropiedad As String = propiedad.Name
    '                        Dim valorPropiedad = propiedad.GetValue(Objeto, Nothing)
    '                        propiedad.SetValue(Objeto, Convert.ChangeType(oRecordSet.Fields.Item(NombrePropiedad).Value, propiedad.PropertyType), Nothing)
    '                    Catch ex As Exception

    '                    End Try

    '                Next

    '                ' nProx = oRecordSet.Fields.Item("Proximo").Value

    '            Catch ex As Exception
    '            End Try

    '        End Sub

    '        Private Sub EditText43_DoubleClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText43.DoubleClickAfter

    '            oFunciones.Open_File(Me.EditText43.Value.Trim)

    '        End Sub

    '        Private Sub Matrix0_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Matrix0.ClickAfter

    '            Dim rowNum As Integer = Me.Matrix0.GetNextSelectedRow(0, SAPbouiCOM.BoOrderType.ot_RowOrder)
    '            Try
    '                Me.Matrix0.SelectRow(pVal.Row, True, False)
    '            Catch
    '            End Try

    '        End Sub

    '        Private Sub Matrix0_DoubleClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Matrix0.DoubleClickAfter
    '            If pVal.ColUID = "Col_0" Then
    '                oedit = Me.Matrix0.Columns.Item(pVal.ColUID).Cells.Item(pVal.Row).Specific ' Selecciona el contenido de la celda
    '                oFunciones.Open_File(oedit.Value.Trim)
    '            End If
    '        End Sub

    '        Private Function Proximo_Codigo_ZPLAP() As Integer

    '            Dim sql As String = "select isnull(max(cast(isnull(case when ISNUMERIC(code) = 1 then code else '0' end,'0') as int)),0)+1 as Proximo from [" + sBDComercial.Trim() + "].[dbo].[@ZPLAP]"

    '            Try

    '                DT_SQL1.ExecuteQuery(sql)

    '            Catch ex As Exception

    '                Application.SBO_Application.MessageBox(sql)
    '                Me.EditText45.Value = sql
    '                Application.SBO_Application.MessageBox(ex.Message)

    '            End Try

    '            Return DT_SQL1.GetValue("Proximo", 0)

    '        End Function

    '        Private Function Proximo_Codigo_ZHCMP() As Integer

    '            Dim sql As String = "select isnull(max(cast(isnull(case when ISNUMERIC(code) = 1 then code else '0' end,'0') as int)),0)+1 as Proximo from [" + sBDComercial.Trim() + "].[dbo].[@ZHCMP]"

    '            Try

    '                DT_SQL1.ExecuteQuery(sql)

    '            Catch ex As Exception

    '                Application.SBO_Application.MessageBox(sql)
    '                Me.EditText45.Value = sql
    '                Application.SBO_Application.MessageBox(ex.Message)

    '            End Try

    '            Return DT_SQL1.GetValue("Proximo", 0)

    '        End Function

    '        Private Sub Cargar_Matrix()

    '            Me.Matrix0.Clear()

    '            Dim sql As String
    '            sql = " select [U_PtahServer] as Archivo,[U_Fec_Registro] as Fecha,[U_Hora_Registro] as Hora,[U_Comentario] as Comentario,[U_Renglon] as Fila,[U_PathOrigen] as RutaInic" &
    '                    " from  " + sBDComercial.Trim() + ".[dbo].[@ZPLAP]   " &
    '                    " where U_Tipo_Documento = 'DOCUMENTO' and U_PrjCode = '" + Me.EditText0.Value.Trim() + "' order by U_Renglon "

    '            '------------------ CARGAR MATRIX
    '            Try

    '                Me.DT_0X.ExecuteQuery(sql)

    '                If Me.DT_0X.Rows.Count > 0 Then

    '                    Me.Matrix0.Columns.Item("#").DataBind.Bind("DT_0X", "Fila")
    '                    Me.Matrix0.Columns.Item("Col_0").DataBind.Bind("DT_0X", "Archivo")
    '                    Me.Matrix0.Columns.Item("Col_1").DataBind.Bind("DT_0X", "Fecha")
    '                    Me.Matrix0.Columns.Item("Col_2").DataBind.Bind("DT_0X", "Hora")
    '                    Me.Matrix0.Columns.Item("Col_3").DataBind.Bind("DT_0X", "Comentario")
    '                    Me.Matrix0.Columns.Item("Col_4").DataBind.Bind("DT_0X", "RutaInic")

    '                    Me.Matrix0.Clear()
    '                    Me.Matrix0.LoadFromDataSource()
    '                    Me.Matrix0.AutoResizeColumns()

    '                End If

    '            Catch ex As Exception

    '            End Try
    '        End Sub

    '        Private Sub FiltrarChooseFromList(ByVal FormUID As String, ByVal CFL_ID As String)
    '            Try
    '                Dim oConditions As SAPbouiCOM.Conditions
    '                Dim oCondition As SAPbouiCOM.Condition
    '                Dim oChooseFromList As SAPbouiCOM.ChooseFromList
    '                Dim emptyCon As New SAPbouiCOM.Conditions
    '                oChooseFromList = Application.SBO_Application.Forms.Item(FormUID).ChooseFromLists.Item(CFL_ID)
    '                oChooseFromList.SetConditions(emptyCon)
    '                oConditions = oChooseFromList.GetConditions()
    '                oCondition = oConditions.Add
    '                oCondition.Alias = "CardType"
    '                oCondition.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL
    '                oCondition.CondVal = "C"
    '                oChooseFromList.SetConditions(oConditions)
    '            Catch ex As Exception
    '                Application.SBO_Application.StatusBar.SetText(ex.Message)
    '            End Try
    '        End Sub

    '        Private Sub PictureBox0_ClickBefore(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As Boolean) Handles PictureBox0.ClickBefore

    '            Try

    '                If Me.Button0.Item.Enabled = False And esPantallaModal = False Then

    '                    Dim Formp2 As Form12
    '                    Formp2 = New Form12

    '                    Dim oUDS As SAPbouiCOM.UserDataSource = Formp2.UIAPIRawForm.DataSources.UserDataSources.Item("UD_0")
    '                    oUDS.ValueEx = Me.UIAPIRawForm.UniqueID   'Aca asignamos el FormUID de Formulario al Valor del  User Data Source

    '                    Dim oUDS2 As SAPbouiCOM.UserDataSource = Formp2.UIAPIRawForm.DataSources.UserDataSources.Item("UD_1")
    '                    oUDS2.ValueEx = "GLOBAL"

    '                    Formp2.Show()

    '                End If

    '            Catch ex As Exception

    '            End Try



    '        End Sub

    '        Private Sub Actualizar_Campos_Multa(pVal As SAPbouiCOM.SBOItemEventArg)

    '            Dim PaneAct As Integer = oForm.PaneLevel
    '            oForm = Application.SBO_Application.Forms.Item(pVal.FormUID)
    '            oUDataTable = oForm.DataSources.DataTables.Item("DT_INFO")

    '            oForm.Freeze(True)
    '            oForm.PaneLevel = 3

    '            If oUDataTable.Rows.Count > 0 Then

    '                oCheckBox = oForm.Items.Item("Item_134").Specific
    '                oCheckBox.Item.Enabled = True
    '                If oUDataTable.GetValue("Multa_Despa", 0).ToString.Trim = "Y" Then
    '                    oCheckBox.Checked = True
    '                Else
    '                    oCheckBox.Checked = False
    '                End If
    '                oCheckBox.Item.Enabled = False

    '                oCheckBox = oForm.Items.Item("Item_135").Specific
    '                oCheckBox.Item.Enabled = True
    '                If oUDataTable.GetValue("Multa_Monta", 0).ToString.Trim = "Y" Then
    '                    oCheckBox.Checked = True
    '                Else
    '                    oCheckBox.Checked = False
    '                End If
    '                oCheckBox.Item.Enabled = False

    '                Select Case oUDataTable.GetValue("Frecuencia_Multa", 0).ToString.Trim()
    '                    Case "D"
    '                        oOptionBtn = oForm.Items.Item("Item_131").Specific
    '                        oOptionBtn.Item.Enabled = True
    '                        oOptionBtn.Selected = True
    '                        oOptionBtn.Item.Enabled = False
    '                    Case "S"
    '                        oOptionBtn = oForm.Items.Item("Item_132").Specific
    '                        oOptionBtn.Item.Enabled = True
    '                        oOptionBtn.Selected = True
    '                        oOptionBtn.Item.Enabled = False
    '                    Case "M"
    '                        oOptionBtn = oForm.Items.Item("Item_133").Specific
    '                        oOptionBtn.Item.Enabled = True
    '                        oOptionBtn.Selected = True
    '                        oOptionBtn.Item.Enabled = False
    '                End Select
    '            End If

    '            oForm.PaneLevel = PaneAct
    '            oForm.Freeze(False)

    '        End Sub

    '        '------------------------------------------------------------------------------------------------------------------------------------------------------
    '        '    CARGA LOS DATOS DE LA PANTALLA ESTADO GLOBAL EN BASE A UN PROJECTO
    '        '------------------------------------------------------------------------------------------------------------------------------------------------------
    '        Public Shared Sub Cargar_Campos_Estado_Global(FormID As String, sCodiP As String, DT_SQLX As SAPbouiCOM.DataTable, DT_SQL2 As SAPbouiCOM.DataTable)

    '            Dim oFormP As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(FormID)

    '            Dim txt As SAPbouiCOM.EditText
    '            Dim txt2 As SAPbouiCOM.EditText

    '            'Variables para el calculo de Dias
    '            Dim dFecVenta As Date
    '            Dim dFecEntreg As Date
    '            Dim dFecFinDes As Date
    '            Dim dFecFinPro As Date
    '            Dim dFecIniDes As Date
    '            Dim dFecIniMon As Date
    '            Dim dFecFinMon As Date

    '            'Variables fechas Reales para Tipear
    '            Dim dFecRealFinDesa As String
    '            Dim dFecRealIniMont As String
    '            Dim dFecReaFinMont As String

    '            'Variables DEspacho y Montaje
    '            Dim sConDespacho = "0"
    '            Dim sConMontaje = "0"

    '            'Enviar demas Datos a Form Principal
    '            '---------------------------------------------------------------------------------------------------------------------------
    '            'Busqueda de Datos en la Tabla ZINFOP o si no existe, en la PCV
    '            '---------------------------------------------------------------------------------------------------------------------------
    '            Dim sql As String

    '            sql = "EXEC	" + sBDComercial.Trim() + ".[dbo].[Min_GPR_Consultar_Datos_Proyecto_GLOBAL]	@sCodPro = '" + sCodiP.Trim() + "'"

    '            Try

    '                Try
    '                    DT_SQLX.ExecuteQuery(sql)
    '                    oUDataTable = oFormP.DataSources.DataTables.Item("DT_INFO")
    '                    oUDataTable.ExecuteQuery(sql)

    '                Catch ex As Exception
    '                    oConectarAplicacion.Conectar_Aplicacion(oCompany)
    '                    DT_SQLX.ExecuteQuery(sql)
    '                    oUDataTable = oFormP.DataSources.DataTables.Item("DT_INFO")
    '                    oUDataTable.ExecuteQuery(sql)
    '                End Try

    '                sConDespacho = DT_SQLX.GetValue("U_Con_Despacho", 0)
    '                sConMontaje = DT_SQLX.GetValue("U_Con_Montaje", 0)

    '            Catch ex As Exception

    '                Application.SBO_Application.MessageBox(sql)
    '                Application.SBO_Application.MessageBox(ex.Message)

    '            End Try

    '            If DT_SQLX.IsEmpty Then ' Si el Proyecto no existe en la Tabla ZINFOP, tomamos los datos de la primera PCV

    '                sql = " Select docnum As Pedido, PC.Project,PR.PrjName,PC.CardCode,PC.CardName,Case When PC.U_MIN_Multa = 'Y' then 'Si' else 'No' end as Multa, " &
    '                  " convert(char(10),PC.TaxDate,103) as Fecha_Pedido,convert(char(10),PC.DocDueDate ,103) as Fecha_Prom_Cli,  " &
    '                  " isnull(convert(char(10),PC.U_MIN_FinDesarr ,103),'') as Fecha_Fin_Desarr,isnull(convert(char(10),PC.U_MIN_FinProduccion ,103),'') as Fecha_Fin_Produc, " &
    '                  " isnull(convert(char(10),PC.U_MIN_IniDespacho ,103),'') as Fecha_Ini_Despa,isnull(convert(char(10),PC.U_MIN_IniMontaje ,103),'') as Fecha_Ini_Monta, " &
    '                  " isnull(convert(char(10),PC.U_MIN_FinMontaje ,103),'') as Fecha_Fin_Monta,isnull(convert(char(10),PC.U_MIN_FechaVenta ,103),'') as Fecha_Venta, '' as Comentario, " &
    '                  " '' as Multa_Despa, '' as Multa_Monta,convert(char(10),'',103) as Fecha_Ini_Multa," &
    '                  " '' as Porc_Multa, '' as Tope_Multa,'' as Frecuencia_Multa," &
    '                  " '' as Comentario_Multa,PR.UserSign,'' as U_SlpCode,'' as U_SlpName,'' as U_Nro_Oport,'' as U_Nro_OC_Cliente,isnull(convert(char(10),PC.CreateDate ,103),'') as U_CreateDate,  " &
    '                  " '' as Fecha_Real_Fin_Desarr, " &
    '                  " '' as Fecha_Real_Ini_Monta, " &
    '                  " '' as Fecha_Real_Fin_Monta " &
    '                  " from " + sBDComercial.Trim() + ".DBO.ORDR PC join " + sBDComercial.Trim() + ".DBO.OPRJ PR on PC.Project = PR.PrjCode " &
    '                  " where PC.DocNum in (select DocNum  from (select Project,min(DocNum) as DocNum from " + sBDComercial.Trim() + ".DBO.ORDR group by Project) as Primer_Pedido)" &
    '                  " and series = 27 and PC.Project = '" + sCodiP.Trim() + "'" &
    '                  " order by Project "

    '                Try
    '                    DT_SQLX.ExecuteQuery(sql)
    '                    oUDataTable = oFormP.DataSources.DataTables.Item("DT_INFO")
    '                    oUDataTable.ExecuteQuery(sql)
    '                Catch ex As Exception
    '                    Application.SBO_Application.MessageBox(sql)
    '                    Application.SBO_Application.MessageBox(ex.Message)
    '                End Try

    '            End If

    '            Try
    '                oFormP.Freeze(True) ' Se congelar el formulario para comenzar la actualizacion de los campos

    '                If DT_SQLX.IsEmpty = False Then

    '                    txt = oFormP.Items.Item("Item_0").Specific
    '                    txt.Value = DT_SQLX.GetValue("Project", 0)
    '                    txt = oFormP.Items.Item("Item_123").Specific
    '                    txt.Value = DT_SQLX.GetValue("CardCode", 0)
    '                    'txt.Item.Enabled = True
    '                    txt = oFormP.Items.Item("Item_2").Specific
    '                    txt.Value = DT_SQLX.GetValue("CardName", 0)
    '                    txt = oFormP.Items.Item("Item_4").Specific
    '                    txt.Value = DT_SQLX.GetValue("PrjName", 0)
    '                    txt = oFormP.Items.Item("Item_6").Specific
    '                    txt.Value = DT_SQLX.GetValue("Multa", 0)
    '                    oPicture = oFormP.Items.Item("Item_150").Specific
    '                    If DT_SQLX.GetValue("Multa", 0) = "Si" Then
    '                        oPicture.Picture = sPathAnexos + "images\Rojo.png"
    '                    Else
    '                        oPicture.Picture = sPathAnexos + "images\Verde.png"
    '                    End If
    '                    txt = oFormP.Items.Item("Item_28").Specific
    '                    txt.Value = DT_SQLX.GetValue("Fecha_Venta", 0)
    '                    txt = oFormP.Items.Item("Item_30").Specific
    '                    txt.Value = DT_SQLX.GetValue("Fecha_Prom_Cli", 0)
    '                    txt = oFormP.Items.Item("Item_8").Specific
    '                    txt.Value = DT_SQLX.GetValue("Fecha_Fin_Desarr", 0)
    '                    txt = oFormP.Items.Item("Item_10").Specific
    '                    txt.Value = DT_SQLX.GetValue("Fecha_Fin_Produc", 0)
    '                    txt = oFormP.Items.Item("Item_11").Specific
    '                    txt.Value = DT_SQLX.GetValue("Fecha_Ini_Despa", 0)
    '                    txt = oFormP.Items.Item("Item_12").Specific
    '                    txt.Value = DT_SQLX.GetValue("Fecha_Ini_Monta", 0)
    '                    txt = oFormP.Items.Item("Item_17").Specific
    '                    txt.Value = DT_SQLX.GetValue("Fecha_Fin_Monta", 0)
    '                    txt = oFormP.Items.Item("Item_101").Specific
    '                    txt.Value = DT_SQLX.GetValue("Comentario", 0)

    '                    txt = oFormP.Items.Item("Item_44").Specific
    '                    txt.Value = DT_SQLX.GetValue("U_CreateDate", 0)

    '                    'Datos Fechas de Inicio y Culminacion Reales de Desarrollo y Montaje

    '                    txt = oFormP.Items.Item("Item_46").Specific
    '                    txt.String = Replace(DT_SQLX.GetValue("Fecha_Real_Fin_Desarr", 0), "-", "/")
    '                    dFecRealFinDesa = txt.String
    '                    txt = oFormP.Items.Item("Item_175").Specific
    '                    txt.String = Replace(DT_SQLX.GetValue("Fecha_Real_Ini_Monta", 0), "-", "/")
    '                    dFecRealIniMont = txt.String
    '                    txt = oFormP.Items.Item("Item_176").Specific
    '                    Dim FechaRecep As String = DT_SQLX.GetValue("Fecha_Real_Fin_Monta", 0)
    '                    FechaRecep = If(FechaRecep.Trim.Length = 0, DT_SQLX.GetValue("U_Fec_Real_Recep_Mon", 0), FechaRecep)
    '                    txt.String = Replace(FechaRecep, "-", "/")
    '                    dFecReaFinMont = txt.String
    '                    txt = oFormP.Items.Item("Item_172").Specific
    '                    txt.Value = IIf(Convert.ToString(DT_SQLX.GetValue("U_Desa_Asigna", 0)) = "C", "T", IIf(DT_SQLX.GetValue("U_Pro_Ing_Entreg", 0) = "Y", "T", "P"))
    '                    'IIf(DT_SQLX.GetValue("U_Desa_Asigna", 0).ToString ='C','T','')   ' IIf(dFecRealFinDesa.Trim.Length() = 0, "P", "T")


    '                    ' Fechas Reales en Pestaña Otros Datos
    '                    Dim PaneAct0 As Integer = oFormP.PaneLevel
    '                    oFormP.PaneLevel = 4
    '                    txt = oFormP.Items.Item("Item_171").Specific
    '                    txt.String = Replace(DT_SQLX.GetValue("Fecha_Real_Fin_Desarr", 0), "-", "/")
    '                    'dFecRealFinDesa = Replace(oRsSUers.Fields.Item("Fecha_Real_Fin_Desarr").Value, "-", "/")
    '                    txt = oFormP.Items.Item("Item_167").Specific
    '                    txt.String = Replace(DT_SQLX.GetValue("Fecha_Real_Ini_Monta", 0), "-", "/")
    '                    'dFecRealIniMont = Replace(oRsSUers.Fields.Item("Fecha_Real_Ini_Monta").Value, "-", "/")
    '                    txt = oFormP.Items.Item("Item_170").Specific
    '                    txt.String = Replace(DT_SQLX.GetValue("Fecha_Real_Fin_Monta", 0), "-", "/")
    '                    'dFecReaFinMont = Replace(oRsSUers.Fields.Item("Fecha_Real_Fin_Monta").Value, "-", "/")
    '                    oFormP.PaneLevel = PaneAct0

    '                    'Datos Creacion del Proyecto
    '                    oStatic = oFormP.Items.Item("Item_149").Specific
    '                    Dim sDatos As String = "Usuario Creador: " + oFunciones.Consulta_Nombre_Usuario(DT_SQLX.GetValue("UserSign", 0), DT_SQL2)
    '                    oStatic.Caption = sDatos.Trim()

    '                    'Datos de la Multa
    '                    txt = oFormP.Items.Item("Item_136").Specific
    '                    txt.String = Replace(DT_SQLX.GetValue("Fecha_Ini_Multa", 0), "-", "/")
    '                    txt = oFormP.Items.Item("Item_139").Specific
    '                    txt.String = Replace(DT_SQLX.GetValue("Porc_Multa", 0).ToString(), ".", ",")
    '                    txt = oFormP.Items.Item("Item_141").Specific
    '                    txt.String = Replace(DT_SQLX.GetValue("Tope_Multa", 0).ToString(), ".", ",")
    '                    txt = oFormP.Items.Item("Item_130").Specific
    '                    txt.Value = DT_SQLX.GetValue("Comentario_Multa", 0)

    '                    Dim PaneAct As Integer = oFormP.PaneLevel
    '                    oFormP.PaneLevel = 3
    '                    oComboBox = oFormP.Items.Item("Item_152").Specific
    '                    oComboBox.Select(DT_SQLX.GetValue("Multa", 0), SAPbouiCOM.BoSearchKey.psk_ByValue)
    '                    oCheckBox = oFormP.Items.Item("Item_134").Specific
    '                    Dim bEstado As Boolean = oCheckBox.Item.Enabled
    '                    oCheckBox.Item.Enabled = True
    '                    If DT_SQLX.GetValue("Multa_Despa", 0).ToString.Trim = "Y" Then
    '                        oFormP.DataSources.UserDataSources.Item("CheckDS1").ValueEx = "Y"
    '                    Else
    '                        oFormP.DataSources.UserDataSources.Item("CheckDS1").ValueEx = "N"
    '                    End If
    '                    oCheckBox.Item.Enabled = bEstado

    '                    oCheckBox = oFormP.Items.Item("Item_135").Specific
    '                    bEstado = oCheckBox.Item.Enabled
    '                    oCheckBox.Item.Enabled = True
    '                    If DT_SQLX.GetValue("Multa_Monta", 0).ToString.Trim = "Y" Then
    '                        oFormP.DataSources.UserDataSources.Item("CheckDS2").ValueEx = "Y"
    '                    Else
    '                        oFormP.DataSources.UserDataSources.Item("CheckDS2").ValueEx = "N"
    '                    End If
    '                    oCheckBox.Item.Enabled = bEstado

    '                    Select Case DT_SQLX.GetValue("Frecuencia_Multa", 0).ToString.Trim()
    '                        Case "D"
    '                            oFormP.DataSources.UserDataSources.Item("OpBtnDS").ValueEx = "1"
    '                            'oOptionBtn = oFormP.Items.Item("Item_131").Specific
    '                            'bEstado = oOptionBtn.Item.Enabled
    '                            'oOptionBtn.Item.Enabled = True
    '                            'oOptionBtn.Selected = True
    '                            'oOptionBtn.Item.Enabled = bEstado
    '                        Case "S"
    '                            oFormP.DataSources.UserDataSources.Item("OpBtnDS").ValueEx = "2"
    '                            'oOptionBtn = oFormP.Items.Item("Item_132").Specific
    '                            'bEstado = oOptionBtn.Item.Enabled
    '                            'oOptionBtn.Item.Enabled = True
    '                            'oOptionBtn.Selected = True
    '                            'oOptionBtn.Item.Enabled = bEstado
    '                        Case "M"
    '                            oFormP.DataSources.UserDataSources.Item("OpBtnDS").ValueEx = "3"
    '                            'oOptionBtn = oFormP.Items.Item("Item_133").Specific
    '                            'bEstado = oOptionBtn.Item.Enabled
    '                            'oOptionBtn.Item.Enabled = True
    '                            'oOptionBtn.Selected = True
    '                            'oOptionBtn.Item.Enabled = bEstado
    '                    End Select

    '                    oFormP.PaneLevel = 4
    '                    'Asignar Otros Datos
    '                    txt = oFormP.Items.Item("Item_159").Specific
    '                    txt.Value = DT_SQLX.GetValue("U_SlpName", 0)
    '                    txt = oFormP.Items.Item("Item_160").Specific
    '                    txt.Value = DT_SQLX.GetValue("U_Nro_Oport", 0)
    '                    txt = oFormP.Items.Item("Item_161").Specific
    '                    txt.Value = DT_SQLX.GetValue("U_Nro_OC_Cliente", 0)
    '                    txt = oFormP.Items.Item("Item_185").Specific
    '                    txt.Value = DT_SQLX.GetValue("U_Contrato_Cli", 0)
    '                    txt = oFormP.Items.Item("Item_191").Specific
    '                    txt.Value = DT_SQLX.GetValue("U_Monto_OCC", 0)
    '                    txt = oFormP.Items.Item("Item_223").Specific
    '                    txt.Value = DT_SQLX.GetValue("U_Monto_OCCE", 0)
    '                    txt = oFormP.Items.Item("Item_225").Specific
    '                    txt.Value = DT_SQLX.GetValue("U_Prj_Code_Ini", 0)
    '                    oCheckBox = oFormP.Items.Item("Item_189").Specific
    '                    bEstado = oCheckBox.Item.Enabled
    '                    oCheckBox.Item.Enabled = True
    '                    If DT_SQLX.GetValue("U_Con_Despacho", 0).ToString.Trim = "1" Then
    '                        oFormP.DataSources.UserDataSources.Item("CheckDS4").ValueEx = "Y"
    '                    Else
    '                        oFormP.DataSources.UserDataSources.Item("CheckDS4").ValueEx = "N"
    '                    End If
    '                    oCheckBox.Item.Enabled = bEstado
    '                    oCheckBox = oFormP.Items.Item("Item_190").Specific
    '                    bEstado = oCheckBox.Item.Enabled
    '                    oCheckBox.Item.Enabled = True
    '                    If DT_SQLX.GetValue("U_Con_Montaje", 0).ToString.Trim = "1" Then
    '                        oFormP.DataSources.UserDataSources.Item("CheckDS3").ValueEx = "Y"
    '                    Else
    '                        oFormP.DataSources.UserDataSources.Item("CheckDS3").ValueEx = "N"
    '                    End If
    '                    oCheckBox.Item.Enabled = bEstado
    '                    'Option Button Desarrollo
    '                    Dim Desarrollo = DT_SQLX.GetValue("U_Desa_Asigna", 0).ToString.Trim
    '                    oFormP.DataSources.UserDataSources.Item("OptBnt2").ValueEx = IIf(DT_SQLX.GetValue("U_Desa_Asigna", 0).ToString.Trim = "C", "2", "1")
    '                    'Jefe de Proyecto Comercial
    '                    oComboBox = oFormP.Items.Item("Item_207").Specific
    '                    Dim sJefe As String = DT_SQLX.GetValue("U_Jefe_Proy_Com", 0).ToString()
    '                    oComboBox.Select(DT_SQLX.GetValue("U_Jefe_Proy_Com", 0), SAPbouiCOM.BoSearchKey.psk_ByDescription)
    '                    'Condiciones de Pago
    '                    oComboBox = oFormP.Items.Item("Item_210").Specific
    '                    oComboBox.Select(DT_SQLX.GetValue("U_Condicion_Pago", 0), SAPbouiCOM.BoSearchKey.psk_ByDescription)
    '                    'Medio de Pago
    '                    oComboBox = oFormP.Items.Item("Item_211").Specific
    '                    oComboBox.Select(DT_SQLX.GetValue("U_Medio_Pago", 0), SAPbouiCOM.BoSearchKey.psk_ByDescription)
    '                    'Porcentaje Anticipo
    '                    oFormP.DataSources.UserDataSources.Item("UDPORC").ValueEx = DT_SQLX.GetValue("U_Porc_Anticipo", 0)
    '                    'Dias Pago
    '                    oFormP.DataSources.UserDataSources.Item("UDDIASP").ValueEx = DT_SQLX.GetValue("U_Dias_Pago", 0)
    '                    'Option Button Desarrollo
    '                    oFormP.DataSources.UserDataSources.Item("OptBnt3").ValueEx = IIf(DT_SQLX.GetValue("U_Contrato_Constru", 0).ToString.Trim = "Y", "1", "2")
    '                    'Option Button Tipo Proyecto
    '                    oFormP.DataSources.UserDataSources.Item("OptBnt4").ValueEx = IIf(DT_SQLX.GetValue("U_Tipo_Pryecto", 0).ToString.Trim = "U", "1", "2")

    '                    oFormP.PaneLevel = PaneAct

    '                    'Asignar Fechas a variables para el calculo de dias
    '                    dFecVenta = DT_SQLX.GetValue("Fecha_Venta", 0)
    '                    dFecEntreg = DT_SQLX.GetValue("Fecha_Prom_Cli", 0)
    '                    dFecFinDes = IIf(DT_SQLX.GetValue("Fecha_Fin_Desarr", 0).ToString.Trim.Length() = 0, DT_SQLX.GetValue("Fecha_Venta", 0), DT_SQLX.GetValue("Fecha_Fin_Desarr", 0))
    '                    dFecFinPro = IIf(DT_SQLX.GetValue("Fecha_Fin_Produc", 0).ToString.Trim.Length() = 0, DT_SQLX.GetValue("Fecha_Venta", 0), DT_SQLX.GetValue("Fecha_Fin_Produc", 0))
    '                    dFecIniDes = IIf(DT_SQLX.GetValue("Fecha_Ini_Despa", 0).ToString.Trim.Length() = 0, DT_SQLX.GetValue("Fecha_Venta", 0), DT_SQLX.GetValue("Fecha_Ini_Despa", 0))
    '                    dFecIniMon = IIf(DT_SQLX.GetValue("Fecha_Ini_Monta", 0).ToString.Trim.Length() = 0, DT_SQLX.GetValue("Fecha_Venta", 0), DT_SQLX.GetValue("Fecha_Ini_Monta", 0))
    '                    dFecFinMon = IIf(DT_SQLX.GetValue("Fecha_Fin_Monta", 0).ToString.Trim.Length() = 0, DT_SQLX.GetValue("Fecha_Venta", 0), DT_SQLX.GetValue("Fecha_Fin_Monta", 0))

    '                    'Cargar_Dias_Asignados
    '                    txt = oFormP.Items.Item("Item_49").Specific
    '                    txt.Value = DateDiff(DateInterval.Day, DT_SQLX.GetValue("Fecha_Venta", 0), DT_SQLX.GetValue("Fecha_Prom_Cli", 0))
    '                    txt = oFormP.Items.Item("Item_39").Specific
    '                    txt.Value = oFunciones.Dias_Habiles(DT_SQLX.GetValue("Fecha_Venta", 0), dFecFinDes)
    '                    txt = oFormP.Items.Item("Item_41").Specific
    '                    txt.Value = oFunciones.Dias_Habiles(dFecFinDes, dFecFinPro)
    '                    txt = oFormP.Items.Item("Item_43").Specific
    '                    txt.Value = oFunciones.Dias_Habiles(dFecFinPro, dFecIniDes)
    '                    txt = oFormP.Items.Item("Item_45").Specific
    '                    txt.Value = oFunciones.Dias_Habiles(dFecIniDes, dFecIniMon)
    '                    txt = oFormP.Items.Item("Item_47").Specific
    '                    txt.Value = oFunciones.Dias_Habiles(dFecIniMon, dFecFinMon)

    '                Else

    '                    'Cargar_Dias_Asignados a 0
    '                    txt = oFormP.Items.Item("Item_49").Specific
    '                    txt.Value = "0"
    '                    txt = oFormP.Items.Item("Item_39").Specific
    '                    txt.Value = "0"
    '                    txt = oFormP.Items.Item("Item_41").Specific
    '                    txt.Value = "0"
    '                    txt = oFormP.Items.Item("Item_43").Specific
    '                    txt.Value = "0"
    '                    txt = oFormP.Items.Item("Item_45").Specific
    '                    txt.Value = "0"
    '                    txt = oFormP.Items.Item("Item_47").Specific
    '                    txt.Value = "0"

    '                End If

    '                '---------------------------------------------------------------------------------------------------------------------------
    '                'Busqueda de Ultima Guia de Despacho
    '                '---------------------------------------------------------------------------------------------------------------------------
    '                sql = " select DocNum, TaxDate " &
    '                      " from " + sBDComercial.Trim() + ".DBO.ODLN " &
    '                      " where DocNum  in (select max(DocNum) from " + sBDComercial.Trim() + ".DBO.ODLN where Project = '" + sCodiP.Trim() + "')"
    '                Try
    '                    DT_SQLX.ExecuteQuery(sql)
    '                Catch ex As Exception
    '                    Application.SBO_Application.MessageBox(sql)
    '                    Application.SBO_Application.MessageBox(ex.Message)
    '                End Try

    '                If DT_SQLX.IsEmpty = False Then
    '                    txt = oFormP.Items.Item("Item_32").Specific
    '                    txt.Value = Replace(DT_SQLX.GetValue("TaxDate", 0), "-", "/")

    '                End If

    '                '---------------------------------------------------------------------------------------------------------------------------
    '                'Busqueda de Modificacion de Fechas 
    '                '---------------------------------------------------------------------------------------------------------------------------

    '                sql = "EXEC	" + sBDComercial.Trim() + ".[dbo].[Min_GPR_Consultar_Ultimas_Fechas_Proyecto_GLOBAL] @sCodPro = '" + sCodiP.Trim() + "'"

    '                Try
    '                    DT_SQLX.ExecuteQuery(sql)
    '                Catch ex As Exception
    '                    Application.SBO_Application.MessageBox(sql)
    '                    Application.SBO_Application.MessageBox(ex.Message)
    '                End Try

    '                If DT_SQLX.IsEmpty = False Then
    '                    'Existen Modificaciones, se toman las fechas del ultimo regitro (de mayor fecha)

    '                    txt = oFormP.Items.Item("Item_106").Specific
    '                    txt.Value = Replace(DT_SQLX.GetValue("U_Fecha_Promet_Nvo", 0), "-", "/")
    '                    txt = oFormP.Items.Item("Item_18").Specific
    '                    txt.Value = Replace(DT_SQLX.GetValue("U_Ter_Desar_Nvo", 0), "-", "/")
    '                    txt = oFormP.Items.Item("Item_20").Specific
    '                    txt.Value = Replace(DT_SQLX.GetValue("U_Ter_Prod_Nvo", 0), "-", "/")
    '                    txt = oFormP.Items.Item("Item_21").Specific
    '                    txt.Value = If(sConDespacho = "1", Replace(DT_SQLX.GetValue("U_Ter_Desp_Nvo", 0), "-", "/"), "")
    '                    txt = oFormP.Items.Item("Item_22").Specific
    '                    txt.Value = If(sConMontaje = "1", Replace(DT_SQLX.GetValue("U_Ini_Mont_Nvo", 0), "-", "/"), "")
    '                    txt = oFormP.Items.Item("Item_27").Specific
    '                    txt.Value = If(sConMontaje = "1", Replace(DT_SQLX.GetValue("U_Ter_Mont_Nvo", 0), "-", "/"), "")
    '                    txt = oFormP.Items.Item("Item_49").Specific
    '                    txt.Value = DateDiff(DateInterval.Day, DT_SQLX.GetValue("U_Fecha_Venta", 0), DT_SQLX.GetValue("U_Fecha_Promet_Nvo", 0))

    '                    dFecVenta = DT_SQLX.GetValue("U_Fecha_Venta", 0)
    '                    dFecEntreg = DT_SQLX.GetValue("U_Fecha_Promet_Nvo", 0)
    '                    dFecFinDes = DT_SQLX.GetValue("U_Ter_Desar_Nvo", 0)
    '                    dFecFinPro = DT_SQLX.GetValue("U_Ter_Prod_Nvo", 0)
    '                    dFecIniDes = DT_SQLX.GetValue("U_Ter_Desp_Nvo", 0)
    '                    dFecIniMon = DT_SQLX.GetValue("U_Ini_Mont_Nvo", 0)
    '                    dFecFinMon = DT_SQLX.GetValue("U_Ter_Mont_Nvo", 0)

    '                Else
    '                    ' No existen Modificaciones, se toman las fechas iniciales como reales
    '                    txt = oFormP.Items.Item("Item_8").Specific
    '                    txt2 = oFormP.Items.Item("Item_18").Specific
    '                    txt2.Value = txt.Value
    '                    txt = oFormP.Items.Item("Item_10").Specific
    '                    txt2 = oFormP.Items.Item("Item_20").Specific
    '                    txt2.Value = txt.Value
    '                    txt = oFormP.Items.Item("Item_11").Specific
    '                    txt2 = oFormP.Items.Item("Item_21").Specific
    '                    txt2.Value = If(sConDespacho = "1", txt.Value, "")
    '                    txt = oFormP.Items.Item("Item_12").Specific
    '                    txt2 = oFormP.Items.Item("Item_22").Specific
    '                    txt2.Value = If(sConMontaje = "1", txt.Value, "")
    '                    txt = oFormP.Items.Item("Item_17").Specific
    '                    txt2 = oFormP.Items.Item("Item_27").Specific
    '                    txt2.Value = If(sConMontaje = "1", txt.Value, "")
    '                    txt = oFormP.Items.Item("Item_30").Specific
    '                    txt2 = oFormP.Items.Item("Item_106").Specific
    '                    txt2.Value = txt.Value

    '                End If

    '                'Asignar Fechas a UserDataSources
    '                Try
    '                    oFormP.DataSources.UserDataSources.Item("UD_FVTA").ValueEx = dFecVenta.ToString("yyyyMMdd")
    '                    oFormP.DataSources.UserDataSources.Item("UD_FENT").ValueEx = dFecEntreg.ToString("yyyyMMdd")
    '                    oFormP.DataSources.UserDataSources.Item("UD_FDESA").ValueEx = dFecFinDes.ToString("yyyyMMdd")
    '                    oFormP.DataSources.UserDataSources.Item("UD_FPRO").ValueEx = dFecFinPro.ToString("yyyyMMdd")
    '                    oFormP.DataSources.UserDataSources.Item("UD_FDESP").ValueEx = dFecIniDes.ToString("yyyyMMdd")
    '                    oFormP.DataSources.UserDataSources.Item("UD_FIMON").ValueEx = dFecIniMon.ToString("yyyyMMdd")
    '                    oFormP.DataSources.UserDataSources.Item("UD_FFMON").ValueEx = dFecFinMon.ToString("yyyyMMdd")
    '                Catch ex As Exception
    '                End Try

    '                'Cargar Dias reales asignados
    '                txt = oFormP.Items.Item("Item_50").Specific
    '                Dim nDias1 As Integer = oFunciones.Dias_Habiles(dFecVenta, dFecFinDes)
    '                txt.Value = oFunciones.Dias_Habiles(dFecVenta, dFecFinDes)
    '                txt = oFormP.Items.Item("Item_48").Specific
    '                Dim nDias2 As Integer = oFunciones.Dias_Habiles(dFecFinDes, dFecFinPro)
    '                txt.Value = oFunciones.Dias_Habiles(dFecFinDes, dFecFinPro)
    '                txt = oFormP.Items.Item("Item_53").Specific
    '                Dim nDias3 As Integer = oFunciones.Dias_Habiles(dFecFinPro, dFecIniDes)
    '                txt.Value = If(sConDespacho = "1", oFunciones.Dias_Habiles(dFecFinPro, dFecIniDes), "")
    '                txt = oFormP.Items.Item("Item_55").Specific
    '                Dim nDias4 As Integer = oFunciones.Dias_Habiles(dFecIniDes, dFecIniMon)
    '                txt.Value = If(sConMontaje = "1", oFunciones.Dias_Habiles(dFecIniDes, dFecIniMon), "")
    '                txt = oFormP.Items.Item("Item_57").Specific
    '                Dim nDias5 As Integer = oFunciones.Dias_Habiles(dFecIniMon, dFecFinMon)
    '                txt.Value = If(sConMontaje = "1", oFunciones.Dias_Habiles(dFecIniMon, dFecFinMon), "")

    '                'Suma Dias
    '                txt = oFormP.Items.Item("Item_74").Specific      ' TOTAL DIAS LABORALES PARA PROYECTO
    '                txt.Value = nDias1 + nDias2 + nDias3 + nDias4 + nDias5

    '                'Carga Dias Despachos
    '                txt = oFormP.Items.Item("Item_34").Specific
    '                txt.Value = oFunciones.Dias_Habiles(dFecIniDes, dFecIniMon)
    '                txt = oFormP.Items.Item("Item_36").Specific
    '                txt2 = oFormP.Items.Item("Item_32").Specific 'Ultima Guia de Despacho
    '                If IsDate(txt2.Value) Then
    '                    txt.Value = oFunciones.Dias_Habiles(txt2.Value, dFecFinMon)
    '                Else
    '                    txt.Value = 0
    '                End If

    '                'Carga Dias para proxima Etapa
    '                txt = oFormP.Items.Item("Item_59").Specific
    '                nDias1 = oFunciones.Dias_Habiles(dFecFinDes, dFecEntreg)
    '                txt.Value = nDias1
    '                txt = oFormP.Items.Item("Item_61").Specific
    '                nDias2 = oFunciones.Dias_Habiles(dFecFinPro, dFecEntreg)
    '                txt.Value = nDias2
    '                txt = oFormP.Items.Item("Item_63").Specific
    '                nDias3 = oFunciones.Dias_Habiles(dFecIniDes, dFecEntreg)
    '                txt.Value = nDias3
    '                txt = oFormP.Items.Item("Item_65").Specific
    '                nDias4 = oFunciones.Dias_Habiles(dFecIniMon, dFecEntreg)
    '                txt.Value = nDias4
    '                txt = oFormP.Items.Item("Item_67").Specific
    '                nDias5 = oFunciones.Dias_Habiles(dFecFinMon, dFecEntreg)
    '                txt.Value = nDias5
    '                txt = oFormP.Items.Item("Item_54").Specific
    '                Dim nDias6 As Integer = oFunciones.Dias_Habiles(dFecFinMon, dFecEntreg)
    '                txt.Value = nDias6
    '                ''Suma Dias
    '                'txt = oFormP.Items.Item("Item_74").Specific
    '                'txt.Value = nDias1 + nDias2 + nDias3 + nDias4 + nDias5

    '                '---------------------------------------------------------------------------------------------------------------------------
    '                'Busqueda de Datos de Avance del Proyecto
    '                '---------------------------------------------------------------------------------------------------------------------------
    '                ' AVANCE DE INDUSTRIAL
    '                sql = "EXEC	" + sBDComercial.Trim() + ".[dbo].[Min_GPR_Consultar_Avance_Industrial_Proyecto_GLOBAL] @sCodPro = '" + sCodiP.Trim() + "'"

    '                Try
    '                    DT_SQLX.ExecuteQuery(sql)
    '                Catch ex As Exception
    '                    Application.SBO_Application.MessageBox(sql)
    '                    Application.SBO_Application.MessageBox(ex.Message)
    '                End Try

    '                If DT_SQLX.IsEmpty = False Then
    '                    txt = oFormP.Items.Item("Item_168").Specific
    '                    txt.Value = Replace(DT_SQLX.GetValue("PriDesp", 0), "-", "/")
    '                    txt = oFormP.Items.Item("Item_173").Specific
    '                    txt.Value = Replace(DT_SQLX.GetValue("UltDesp", 0), "-", "/")
    '                    txt = oFormP.Items.Item("Item_179").Specific
    '                    txt.Value = IIf(DT_SQLX.GetValue("MontoNetoD", 0) = 0, Math.Round(Val(DT_SQLX.GetValue("%_Ind2", 0).ToString), 2), Math.Round(Val(DT_SQLX.GetValue("%_Ind", 0).ToString), 2))
    '                Else
    '                    txt = oFormP.Items.Item("Item_168").Specific
    '                    txt.Value = ""
    '                    txt = oFormP.Items.Item("Item_173").Specific
    '                    txt.Value = ""
    '                    txt = oFormP.Items.Item("Item_179").Specific
    '                    txt.Value = "0"
    '                End If

    '                ' AVANCE DE DESPACHO
    '                sql = "EXEC	" + sBDComercial.Trim() + ".[dbo].[Min_GPR_Consultar_Avance_Despacho_Proyecto_GLOBAL] @sCodPro = '" + sCodiP.Trim() + "'"

    '                Try
    '                    DT_SQLX.ExecuteQuery(sql)
    '                Catch ex As Exception
    '                    Application.SBO_Application.MessageBox(sql)
    '                    Application.SBO_Application.MessageBox(ex.Message)
    '                End Try

    '                If DT_SQLX.IsEmpty = False Then
    '                    txt = oFormP.Items.Item("Item_169").Specific
    '                    txt.Value = If(sConDespacho = "1", Replace(DT_SQLX.GetValue("PriDesp", 0), "-", "/"), "")
    '                    txt = oFormP.Items.Item("Item_174").Specific
    '                    txt.Value = If(sConDespacho = "1", Replace(DT_SQLX.GetValue("UltDesp", 0), "-", "/"), "")
    '                    txt = oFormP.Items.Item("Item_180").Specific
    '                    txt.Value = If(sConDespacho = "1", Math.Round(Val(DT_SQLX.GetValue("%_Despacho", 0).ToString), 2), "")
    '                Else
    '                    txt = oFormP.Items.Item("Item_169").Specific
    '                    txt.Value = ""
    '                    txt = oFormP.Items.Item("Item_174").Specific
    '                    txt.Value = ""
    '                    txt = oFormP.Items.Item("Item_180").Specific
    '                    txt.Value = ""
    '                End If


    '                '---------------------------------------------------------------------------------------------------------------------------
    '                'Calculo de Dias de Atraso en Base a Ultimas Fechas
    '                '---------------------------------------------------------------------------------------------------------------------------
    '                'Desarrollo
    '                txt = oFormP.Items.Item("Item_46").Specific
    '                dFecRealFinDesa = txt.String
    '                txt = oFormP.Items.Item("Item_175").Specific
    '                dFecRealIniMont = txt.String
    '                txt = oFormP.Items.Item("Item_176").Specific
    '                dFecReaFinMont = txt.String

    '                txt = oFormP.Items.Item("Item_25").Specific
    '                Dim dFecCalculo As Date = If(dFecRealFinDesa.Trim.Length() = 0, Date.Now(), dFecRealFinDesa)
    '                Dim nAtraso As Integer = If(dFecCalculo > dFecFinDes, -1, 1)
    '                txt.Value = Math.Abs(oFunciones.Dias_Habiles(dFecFinDes, dFecCalculo)) * nAtraso
    '                oPicture = oFormP.Items.Item("Item_70").Specific
    '                oPicture.Picture = ""
    '                If dFecRealFinDesa.Trim.Length() = 0 Then
    '                    Select Case nAtraso
    '                        Case -1
    '                            oPicture.Picture = sPathAnexos + "images\SRojo.png"
    '                        Case 1
    '                            oPicture.Picture = sPathAnexos + "images\SVerde.png"
    '                    End Select
    '                End If
    '                'Termino Industrial
    '                txt = oFormP.Items.Item("Item_24").Specific
    '                dFecCalculo = If(oFormP.Items.Item("Item_179").Specific.value < 99, Date.Now(), oFormP.Items.Item("Item_173").Specific.Value)
    '                nAtraso = If(dFecCalculo > dFecFinPro, -1, 1)
    '                txt.Value = Math.Abs(oFunciones.Dias_Habiles(dFecFinPro, dFecCalculo)) * nAtraso
    '                oPicture = oFormP.Items.Item("Item_71").Specific
    '                oPicture.Picture = ""
    '                If oFormP.Items.Item("Item_179").Specific.value < 99 Then

    '                    Select Case nAtraso
    '                        Case -1
    '                            oPicture.Picture = sPathAnexos + "images\SRojo.png"
    '                        Case 1
    '                            oPicture.Picture = sPathAnexos + "images\SVerde.png"
    '                    End Select

    '                End If
    '                'Inicio Despacho
    '                If sConDespacho = "1" Then
    '                    txt = oFormP.Items.Item("Item_26").Specific
    '                    Dim valors = If(oFormP.Items.Item("Item_180").Specific.value = "", 0, oFormP.Items.Item("Item_180").Specific.value)
    '                    dFecCalculo = If(valors < 99, Date.Now(), oFormP.Items.Item("Item_174").Specific.Value)
    '                    nAtraso = If(dFecCalculo > dFecIniDes, -1, 1)
    '                    txt.Value = Math.Abs(oFunciones.Dias_Habiles(dFecIniDes, dFecCalculo)) * nAtraso
    '                    oPicture = oFormP.Items.Item("Item_72").Specific
    '                    oPicture.Picture = ""
    '                    If valors < 99 Then

    '                        Select Case nAtraso
    '                            Case -1
    '                                oPicture.Picture = sPathAnexos + "images\SRojo.png"
    '                            Case 1
    '                                oPicture.Picture = sPathAnexos + "images\SVerde.png"
    '                        End Select

    '                    End If
    '                Else
    '                    txt = oFormP.Items.Item("Item_26").Specific
    '                    txt.Value = ""
    '                    oPicture = oFormP.Items.Item("Item_72").Specific
    '                    oPicture.Picture = ""
    '                End If

    '                'Inicio Montaje
    '                If sConMontaje = "1" Then
    '                    txt = oFormP.Items.Item("Item_40").Specific
    '                    dFecCalculo = If(dFecRealIniMont.Trim.Length() = 0, Date.Now(), dFecRealIniMont)
    '                    nAtraso = If(dFecCalculo > dFecIniMon, -1, 1)
    '                    txt.Value = If(dFecRealIniMont = "01/01/1900", 0, Math.Abs(oFunciones.Dias_Habiles(dFecIniMon, dFecCalculo)) * nAtraso)
    '                    oPicture = oFormP.Items.Item("Item_73").Specific
    '                    oPicture.Picture = If(nAtraso = 1, sPathAnexos + "images\SVerde.png", "")
    '                    If dFecRealIniMont.Trim.Length() > 0 Then

    '                        Select Case nAtraso
    '                            Case -1
    '                                oPicture.Picture = sPathAnexos + "images\SRojo.png"
    '                            Case 1
    '                                oPicture.Picture = sPathAnexos + "images\SVerde.png"
    '                        End Select

    '                    End If
    '                Else
    '                    txt = oFormP.Items.Item("Item_40").Specific
    '                    txt.Value = ""
    '                    oPicture = oFormP.Items.Item("Item_73").Specific
    '                    oPicture.Picture = ""
    '                End If

    '                'Termino Montaje
    '                If sConMontaje = "1" Then
    '                    txt = oFormP.Items.Item("Item_42").Specific
    '                    dFecCalculo = If(dFecReaFinMont.Trim.Length() = 0, Date.Now(), dFecReaFinMont)
    '                    nAtraso = If(dFecCalculo > dFecFinMon, -1, 1)
    '                    txt.Value = Math.Abs(oFunciones.Dias_Habiles(dFecFinMon, dFecCalculo)) * nAtraso
    '                    oPicture = oFormP.Items.Item("Item_178").Specific
    '                    oPicture.Picture = ""
    '                    If dFecReaFinMont.Trim.Length() = 0 Then

    '                        Select Case nAtraso
    '                            Case -1
    '                                oPicture.Picture = sPathAnexos + "images\SRojo.png"
    '                            Case 1
    '                                oPicture.Picture = sPathAnexos + "images\SVerde.png"
    '                        End Select

    '                    End If
    '                Else
    '                    txt = oFormP.Items.Item("Item_42").Specific
    '                    txt.Value = ""
    '                    oPicture = oFormP.Items.Item("Item_178").Specific
    '                    oPicture.Picture = ""
    '                End If

    '                '---------------------------------------------------------------------------------------------------------------------------
    '                'Busqueda y Carga de Estados por Etapas
    '                '---------------------------------------------------------------------------------------------------------------------------

    '                sql = " EXEC [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Estados_por_Etapa_GLOBAL] '" + sCodiP.Trim() + "'"

    '                Try
    '                    DT_SQLX.ExecuteQuery(sql)

    '                    txt = oFormP.Items.Item("Item_199").Specific
    '                    If (oFormP.DataSources.UserDataSources.Item("OptBnt2").ValueEx = "1") Then
    '                        txt.Value = DT_SQLX.GetValue("Estado Ingenieria", 0)
    '                    Else
    '                        txt.Value = "PROYECTO SIN DESARROLLO"
    '                        txt = oFormP.Items.Item("Item_50").Specific
    '                        txt.Value = ""
    '                        txt = oFormP.Items.Item("Item_18").Specific
    '                        txt.Value = ""
    '                        txt = oFormP.Items.Item("Item_44").Specific
    '                        txt.Value = ""
    '                        txt = oFormP.Items.Item("Item_46").Specific
    '                        txt.Value = ""
    '                        txt = oFormP.Items.Item("Item_172").Specific
    '                        txt.Value = ""
    '                        txt = oFormP.Items.Item("Item_25").Specific
    '                        txt.Value = ""
    '                        oPicture = oFormP.Items.Item("Item_70").Specific
    '                        oPicture.Picture = ""
    '                    End If

    '                    txt = oFormP.Items.Item("Item_204").Specific
    '                    txt.Value = DT_SQLX.GetValue("% Avance Industrial", 0)
    '                    oFunciones.BackColor_Percent_Edit(txt)
    '                    Dim Valor = CDbl(Replace(Replace(txt.Value.ToString.Trim(), "%", ""), ".", ","))
    '                    CType(oFormP.Items.Item("Item_213").Specific, SAPbouiCOM.PictureBox).Item.Width = (CType(oFormP.Items.Item("Item_213").Specific, SAPbouiCOM.PictureBox).Item.Width / 100) * Valor

    '                    txt = oFormP.Items.Item("Item_200").Specific
    '                    oButton = oFormP.Items.Item("Item_205").Specific
    '                    If (oFormP.DataSources.UserDataSources.Item("CheckDS3").ValueEx = "Y") Then
    '                        txt.Value = DT_SQLX.GetValue("Estado Montajes", 0)
    '                        oButton.Item.Visible = False
    '                        If (DT_SQLX.GetValue("Estado Montajes", 0).trim() = "Recepcionada") Then
    '                            oButton.Caption = "PROYECTO RECEPCIONADO"
    '                            txt.BackColor = RGB(48, 204, 0)
    '                        End If
    '                    Else
    '                        txt.BackColor = RGB(212, 208, 200)
    '                        txt.Value = "PROYECTO SIN MONTAJE"
    '                        oButton.Item.Visible = True
    '                    End If
    '                    txt = oFormP.Items.Item("Item_202").Specific
    '                    If (oFormP.DataSources.UserDataSources.Item("CheckDS4").ValueEx = "Y") Then
    '                        txt.Value = DT_SQLX.GetValue("% Despachado", 0)
    '                        oFunciones.BackColor_Percent_Edit(txt)
    '                        Valor = CDbl(Replace(Replace(txt.Value.ToString.Trim(), "%", ""), ".", ","))
    '                        CType(oFormP.Items.Item("Item_214").Specific, SAPbouiCOM.PictureBox).Item.Width = (CType(oFormP.Items.Item("Item_214").Specific, SAPbouiCOM.PictureBox).Item.Width / 100) * Valor
    '                    Else
    '                        txt.BackColor = RGB(212, 208, 200)
    '                        txt.Value = "PROYECTO SIN DESPACHO"
    '                    End If

    '                Catch ex As Exception
    '                    Application.SBO_Application.MessageBox(sql)
    '                    Application.SBO_Application.MessageBox(ex.Message)
    '                End Try

    '                '---------------------------------------------------------------------------------------------------------------------------
    '                'Busqueda de Datos en las PCR
    '                '---------------------------------------------------------------------------------------------------------------------------
    '                sql = " select 
    '                            cast(isnull(sum(DocTotal - VatSum),0) as decimal(10,2))  as MontoPCRs
    '                            , Count(DocNum) as CantidadPCRs
    '                            , max(isnull(convert(Char(10),TaxDate,103),'')) as UltimaPCR 
    '                        from 
    '                            " + sBDComercial.Trim() + ".DBO.ordr 
    '                        where 
    '                             series = 47 and Project  = '" + sCodiP.Trim() + "'"

    '                Try
    '                    DT_SQLX.ExecuteQuery(sql)
    '                Catch ex As Exception
    '                    Application.SBO_Application.MessageBox(sql)
    '                    Application.SBO_Application.MessageBox(ex.Message)
    '                End Try

    '                If DT_SQLX.IsEmpty = False Then

    '                    txt = oFormP.Items.Item("Item_75").Specific
    '                    txt.Value = DT_SQLX.GetValue("CantidadPCRs", 0)
    '                    txt = oFormP.Items.Item("Item_77").Specific
    '                    txt.Value = DT_SQLX.GetValue("UltimaPCR", 0)
    '                    txt = oFormP.Items.Item("Item_79").Specific
    '                    txt.String = DT_SQLX.GetValue("MontoPCRs", 0)
    '                    'txt.Value = "$  " + FormatNumber(DT_SQLX.GetValue("MontoPCRs", 0), 0, , , TriState.True)

    '                End If

    '                '---------------------------------------------------------------------------------------------------------------------------
    '                'Busqueda y carga de los Documentos Anexos
    '                '---------------------------------------------------------------------------------------------------------------------------

    '                sql = " EXEC [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Consultar_Anexos_Proyecto_GLOBAL]  @sCodPro = '" + sCodiP.Trim() + "'"

    '                Dim UDataTable As SAPbouiCOM.DataTable
    '                UDataTable = oFormP.DataSources.DataTables.Item("DT_0X")
    '                UDataTable.Clear()

    '                Try
    '                    UDataTable.ExecuteQuery(sql)
    '                Catch ex As Exception
    '                    Application.SBO_Application.MessageBox(sql)
    '                    Application.SBO_Application.MessageBox(ex.Message)
    '                End Try

    '                oMatrix = oFormP.Items.Item("Item_111").Specific
    '                oMatrix.Clear()

    '                If UDataTable.Rows.Count > 0 Then


    '                    oMatrix.Columns.Item("#").DataBind.Bind("DT_0X", "Fila")
    '                    oMatrix.Columns.Item("Col_0").DataBind.Bind("DT_0X", "Archivo")
    '                    oMatrix.Columns.Item("Col_1").DataBind.Bind("DT_0X", "Fecha")
    '                    oMatrix.Columns.Item("Col_2").DataBind.Bind("DT_0X", "Hora")
    '                    oMatrix.Columns.Item("Col_3").DataBind.Bind("DT_0X", "Comentario")
    '                    oMatrix.Columns.Item("Col_4").DataBind.Bind("DT_0X", "RutaInic")

    '                    oMatrix.Clear()
    '                    oMatrix.LoadFromDataSource()
    '                    oMatrix.AutoResizeColumns()

    '                End If

    '            Catch ex As Exception
    '            Finally
    '                oFormP.Freeze(False)  'Se Descongela el Form luego de Actualizar u Ocurrir alguna excepcion
    '            End Try


    '            '---------------------------------------------------------------------------------------------------------------------------
    '            'Busqueda y carga de las Modificaciones de Fecha del Proyecto en el ComboBox
    '            '---------------------------------------------------------------------------------------------------------------------------
    '            Try

    '                oFormP.Freeze(True)

    '                'Cargar Historico de Fechas
    '                sql = " EXEC [" + sBDComercial.Trim() + "].[dbo].[Min_GPR_Consultar_Cambios_Fechas_Proyecto_GLOBAL] '" + sCodiP.Trim() + "'"


    '                Try

    '                    DT_SQLX.ExecuteQuery(sql)
    '                    oComboBox = oFormP.Items.Item("Item_81").Specific
    '                    Dim i As Integer = 0

    '                    While oComboBox.ValidValues.Count > 0
    '                        Try
    '                            oComboBox.ValidValues.Remove(i, SAPbouiCOM.BoSearchKey.psk_Index)
    '                        Catch ex As Exception

    '                        End Try
    '                    End While


    '                    If DT_SQLX.IsEmpty = False Then

    '                        For i = 0 To DT_SQLX.Rows.Count - 1
    '                            oComboBox.ValidValues.Add(DT_SQLX.GetValue("Modificacion", i), "")
    '                        Next
    '                    Else
    '                        oComboBox.ValidValues.Add("Fechas sin Modificar", "")
    '                    End If

    '                    oComboBox.Select(0, SAPbouiCOM.BoSearchKey.psk_Index)

    '                Catch ex As Exception
    '                    Application.SBO_Application.MessageBox(sql)
    '                    Application.SBO_Application.MessageBox(ex.Message)
    '                End Try


    '                '---------------------------------------------------------------------------------------------------------------------------
    '                'Busqueda y carga de los estados en los ComboBox
    '                '---------------------------------------------------------------------------------------------------------------------------
    '                'Cargar_Combo_Estados_Proyecto(oFormP, sCodiP, DT_SQLX)

    '            Catch ex As Exception
    '            Finally
    '                oFormP.Freeze(False)  'Se Descongela el Form luego de Actualizar u Ocurrir alguna excepcion
    '            End Try

    '            '---------------------------------------------------------------------------------------------------------------------------

    '        End Sub

    '        Public Shared Sub Cargar_Combo_Estados_Proyecto(oFormP As SAPbouiCOM.Form, sCodiP As String, DT_SQLX As SAPbouiCOM.DataTable)
    '            'Cargar Estados Comercial Ingenieria
    '            Dim Sql As String = "select * from [" + sBDComercial.Trim() + "].[DBO].[@ZHCEP] where code in (select code from (select max(code) as code ,max(U_Fec_Registro) as fecha from [" + sBDComercial.Trim() + "].[DBO].[@ZHCEP] where U_Tipo_Proc = 'COMER_ING' and U_PrjCode = '" + sCodiP.Trim() + "') as Ultimo )"

    '            Try


    '                DT_SQLX.ExecuteQuery(Sql)
    '                oComboBox = oFormP.Items.Item("Item_85").Specific
    '                Dim i As Integer = 0

    '                While oComboBox.ValidValues.Count > 0
    '                    Try
    '                        oComboBox.ValidValues.Remove(i, SAPbouiCOM.BoSearchKey.psk_Index)
    '                    Catch ex As Exception

    '                    End Try
    '                End While


    '                If DT_SQLX.IsEmpty = False Then

    '                    For i = 0 To DT_SQLX.Rows.Count - 1
    '                        oComboBox.ValidValues.Add(DT_SQLX.GetValue("U_Estado_Proc", i), "")
    '                    Next
    '                Else
    '                    oComboBox.ValidValues.Add("En Desarrollo", "")
    '                End If

    '                oComboBox.Select(0, SAPbouiCOM.BoSearchKey.psk_Index)

    '            Catch ex As Exception
    '                Application.SBO_Application.MessageBox(Sql)
    '                Application.SBO_Application.MessageBox(ex.Message)
    '            End Try

    '            'Cargar Estados Industrial
    '            Sql = "select * from [" + sBDComercial.Trim() + "].[DBO].[@ZHCEP] where code in (select code from (select max(code) as code ,max(U_Fec_Registro) as fecha from [" + sBDComercial.Trim() + "].[DBO].[@ZHCEP] where U_Tipo_Proc = 'INDUSTRIAL' and U_PrjCode = '" + sCodiP.Trim() + "') as Ultimo )"

    '            Try


    '                DT_SQLX.ExecuteQuery(Sql)
    '                oComboBox = oFormP.Items.Item("Item_88").Specific
    '                Dim i As Integer = 0

    '                While oComboBox.ValidValues.Count > 0
    '                    Try
    '                        oComboBox.ValidValues.Remove(i, SAPbouiCOM.BoSearchKey.psk_Index)
    '                    Catch ex As Exception

    '                    End Try
    '                End While


    '                If DT_SQLX.IsEmpty = False Then

    '                    For i = 0 To DT_SQLX.Rows.Count - 1
    '                        oComboBox.ValidValues.Add(DT_SQLX.GetValue("U_Estado_Proc", i), "")
    '                    Next
    '                Else
    '                    oComboBox.ValidValues.Add("En Proceso", "")
    '                End If

    '                oComboBox.Select(0, SAPbouiCOM.BoSearchKey.psk_Index)

    '            Catch ex As Exception
    '                Application.SBO_Application.MessageBox(Sql)
    '                Application.SBO_Application.MessageBox(ex.Message)
    '            End Try

    '            'Cargar Estados Despacho
    '            Sql = "select * from [" + sBDComercial.Trim() + "].[DBO].[@ZHCEP] where code in (select code from (select max(code) as code ,max(U_Fec_Registro) as fecha from [" + sBDComercial.Trim() + "].[DBO].[@ZHCEP] where U_Tipo_Proc = 'DESPACHO' and U_PrjCode = '" + sCodiP.Trim() + "') as Ultimo )"

    '            Try


    '                DT_SQLX.ExecuteQuery(Sql)
    '                oComboBox = oFormP.Items.Item("Item_91").Specific
    '                Dim i As Integer = 0

    '                While oComboBox.ValidValues.Count > 0
    '                    Try
    '                        oComboBox.ValidValues.Remove(i, SAPbouiCOM.BoSearchKey.psk_Index)
    '                    Catch ex As Exception

    '                    End Try
    '                End While


    '                If DT_SQLX.IsEmpty = False Then

    '                    For i = 0 To DT_SQLX.Rows.Count - 1
    '                        oComboBox.ValidValues.Add(DT_SQLX.GetValue("U_Estado_Proc", i), "")
    '                    Next
    '                Else
    '                    oComboBox.ValidValues.Add("Sin Despachos", "")
    '                End If

    '                oComboBox.Select(0, SAPbouiCOM.BoSearchKey.psk_Index)

    '            Catch ex As Exception
    '                Application.SBO_Application.MessageBox(Sql)
    '                Application.SBO_Application.MessageBox(ex.Message)
    '            End Try

    '            'Cargar Estados Montaje
    '            Sql = "select * from [" + sBDComercial.Trim() + "].[DBO].[@ZHCEP] where code in (select code from (select max(code) as code ,max(U_Fec_Registro) as fecha from [" + sBDComercial.Trim() + "].[DBO].[@ZHCEP] where U_Tipo_Proc = 'MONTAJE' and U_PrjCode = '" + sCodiP.Trim() + "') as Ultimo )"

    '            Try

    '                DT_SQLX.ExecuteQuery(Sql)
    '                oComboBox = oFormP.Items.Item("Item_94").Specific
    '                Dim i As Integer = 0

    '                While oComboBox.ValidValues.Count > 0
    '                    Try
    '                        oComboBox.ValidValues.Remove(i, SAPbouiCOM.BoSearchKey.psk_Index)
    '                    Catch ex As Exception

    '                    End Try
    '                End While


    '                If DT_SQLX.IsEmpty = False Then

    '                    For i = 0 To DT_SQLX.Rows.Count - 1
    '                        oComboBox.ValidValues.Add(DT_SQLX.GetValue("U_Estado_Proc", i), "")
    '                    Next
    '                Else
    '                    oComboBox.ValidValues.Add("Por Programar", "")
    '                End If

    '                oComboBox.Select(0, SAPbouiCOM.BoSearchKey.psk_Index)

    '            Catch ex As Exception
    '                Application.SBO_Application.MessageBox(Sql)
    '                Application.SBO_Application.MessageBox(ex.Message)
    '            End Try
    '        End Sub


    '        Private Sub Folder1_ClickBefore(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As Boolean)
    '            PictureBox0.Item.Visible = False
    '        End Sub

    '        Private Sub Button37_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button37.ClickAfter

    '            Dim activeForm2 As FrmBuscaProyecto = New FrmBuscaProyecto()
    '            activeForm2.Show()

    '        End Sub

    '        Private Sub Button25_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button25.ClickAfter

    '            If Me.EditText57.Item.Enabled Then
    '                Dim activeForm2 As Form2
    '                activeForm2 = New Form2

    '                Dim oUDS As SAPbouiCOM.UserDataSource = activeForm2.UIAPIRawForm.DataSources.UserDataSources.Item("UD_0")
    '                oUDS.ValueEx = Me.UIAPIRawForm.UniqueID
    '                oUDS = activeForm2.UIAPIRawForm.DataSources.UserDataSources.Item("UD_1")
    '                oUDS.ValueEx = "GLOBALPR"

    '                activeForm2.Show()
    '            End If

    '        End Sub

    '        Public Shared Sub Obtener_Proyecto_Asociado(FormID As String, sProyecto As String)

    '            Dim oFormP As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(FormID)
    '            oedit = oFormP.Items.Item("Item_225").Specific
    '            oedit.Value = sProyecto

    '        End Sub


    '#Region "Private WithEvents"
    '        Private WithEvents Button18 As SAPbouiCOM.Button
    '        Private WithEvents EditText0 As SAPbouiCOM.EditText
    '        Private WithEvents EditText1 As SAPbouiCOM.EditText
    '        Private WithEvents EditText2 As SAPbouiCOM.EditText
    '        Private WithEvents EditText3 As SAPbouiCOM.EditText
    '        Private WithEvents EditText4 As SAPbouiCOM.EditText
    '        Private WithEvents EditText5 As SAPbouiCOM.EditText
    '        Private WithEvents EditText6 As SAPbouiCOM.EditText
    '        Private WithEvents EditText7 As SAPbouiCOM.EditText
    '        Private WithEvents EditText8 As SAPbouiCOM.EditText
    '        Private WithEvents EditText9 As SAPbouiCOM.EditText
    '        Private WithEvents EditText10 As SAPbouiCOM.EditText
    '        Private WithEvents EditText11 As SAPbouiCOM.EditText
    '        Private WithEvents EditText12 As SAPbouiCOM.EditText
    '        Private WithEvents EditText13 As SAPbouiCOM.EditText
    '        Private WithEvents EditText14 As SAPbouiCOM.EditText
    '        Private WithEvents EditText15 As SAPbouiCOM.EditText
    '        Private WithEvents EditText16 As SAPbouiCOM.EditText
    '        Private WithEvents EditText17 As SAPbouiCOM.EditText
    '        Private WithEvents EditText18 As SAPbouiCOM.EditText
    '        Private WithEvents EditText19 As SAPbouiCOM.EditText
    '        Private WithEvents EditText20 As SAPbouiCOM.EditText
    '        Private WithEvents EditText21 As SAPbouiCOM.EditText
    '        Private WithEvents EditText22 As SAPbouiCOM.EditText
    '        Private WithEvents EditText23 As SAPbouiCOM.EditText
    '        Private WithEvents EditText24 As SAPbouiCOM.EditText
    '        Private WithEvents EditText25 As SAPbouiCOM.EditText
    '        Private WithEvents EditText26 As SAPbouiCOM.EditText
    '        Private WithEvents EditText27 As SAPbouiCOM.EditText
    '        Private WithEvents EditText28 As SAPbouiCOM.EditText
    '        Private WithEvents EditText29 As SAPbouiCOM.EditText
    '        Private WithEvents EditText30 As SAPbouiCOM.EditText
    '        Private WithEvents EditText31 As SAPbouiCOM.EditText
    '        Private WithEvents EditText32 As SAPbouiCOM.EditText
    '        Private WithEvents EditText33 As SAPbouiCOM.EditText
    '        Private WithEvents EditText34 As SAPbouiCOM.EditText
    '        Private WithEvents EditText35 As SAPbouiCOM.EditText
    '        Private WithEvents EditText36 As SAPbouiCOM.EditText
    '        Private WithEvents EditText37 As SAPbouiCOM.EditText
    '        Private WithEvents EditText38 As SAPbouiCOM.EditText
    '        Private WithEvents Button0 As SAPbouiCOM.Button
    '        Private WithEvents Button1 As SAPbouiCOM.Button
    '        Private WithEvents Button2 As SAPbouiCOM.Button
    '        Private WithEvents Folder0 As SAPbouiCOM.Folder
    '        Private WithEvents EditText40 As SAPbouiCOM.EditText
    '        Private WithEvents StaticText0 As SAPbouiCOM.StaticText
    '        Private WithEvents EditText41 As SAPbouiCOM.EditText
    '        Private WithEvents EditText42 As SAPbouiCOM.EditText
    '        Private WithEvents StaticText1 As SAPbouiCOM.StaticText
    '        Private WithEvents StaticText2 As SAPbouiCOM.StaticText
    '        Private WithEvents ComboBox0 As SAPbouiCOM.ComboBox
    '        Private WithEvents StaticText3 As SAPbouiCOM.StaticText
    '        Private WithEvents ComboBox1 As SAPbouiCOM.ComboBox
    '        Private WithEvents StaticText4 As SAPbouiCOM.StaticText
    '        Private WithEvents ComboBox2 As SAPbouiCOM.ComboBox
    '        Private WithEvents StaticText5 As SAPbouiCOM.StaticText
    '        Private WithEvents ComboBox3 As SAPbouiCOM.ComboBox
    '        Private WithEvents StaticText6 As SAPbouiCOM.StaticText
    '        Private WithEvents ComboBox4 As SAPbouiCOM.ComboBox
    '        Private WithEvents StaticText7 As SAPbouiCOM.StaticText
    '        Private WithEvents ComboBox5 As SAPbouiCOM.ComboBox
    '        Private WithEvents ComboBox6 As SAPbouiCOM.ComboBox
    '        Private WithEvents Folder1 As SAPbouiCOM.Folder
    '        Private WithEvents Folder2 As SAPbouiCOM.Folder
    '        Private WithEvents EditText43 As SAPbouiCOM.EditText
    '        Private WithEvents EditText45 As SAPbouiCOM.EditText
    '        Private WithEvents Button3 As SAPbouiCOM.Button
    '        Private WithEvents Button4 As SAPbouiCOM.Button
    '        Private WithEvents Button5 As SAPbouiCOM.Button
    '        Private WithEvents Button6 As SAPbouiCOM.Button
    '        Private WithEvents Button7 As SAPbouiCOM.Button
    '        Private WithEvents Button8 As SAPbouiCOM.Button
    '        Private WithEvents StaticText8 As SAPbouiCOM.StaticText
    '        Private WithEvents StaticText9 As SAPbouiCOM.StaticText
    '        Private WithEvents Button9 As SAPbouiCOM.Button
    '        Private WithEvents Button10 As SAPbouiCOM.Button
    '        Private WithEvents DT_0X As SAPbouiCOM.DataTable
    '        Private WithEvents DT_INFO As SAPbouiCOM.DataTable
    '        Private WithEvents DT_SQL1 As SAPbouiCOM.DataTable
    '        Private WithEvents DT_SQL2 As SAPbouiCOM.DataTable
    '        Private WithEvents Button11 As SAPbouiCOM.Button
    '        Private WithEvents Button12 As SAPbouiCOM.Button
    '        Private WithEvents EditText44 As SAPbouiCOM.EditText
    '        Private WithEvents EditText46 As SAPbouiCOM.EditText
    '        Private WithEvents EditText47 As SAPbouiCOM.EditText
    '        Private WithEvents StaticText10 As SAPbouiCOM.StaticText
    '        Private WithEvents LinkedButton0 As SAPbouiCOM.LinkedButton
    '        Private WithEvents Button13 As SAPbouiCOM.Button
    '        Private WithEvents EditText48 As SAPbouiCOM.EditText
    '        Private WithEvents EditText50 As SAPbouiCOM.EditText
    '        Private WithEvents PictureBox0 As SAPbouiCOM.PictureBox
    '        Private WithEvents Folder3 As SAPbouiCOM.Folder
    '        Private WithEvents EditText39 As SAPbouiCOM.EditText
    '        Private WithEvents OptionBtn0 As SAPbouiCOM.OptionBtn
    '        Private WithEvents OptionBtn1 As SAPbouiCOM.OptionBtn
    '        Private WithEvents OptionBtn2 As SAPbouiCOM.OptionBtn
    '        Private WithEvents CheckBox0 As SAPbouiCOM.CheckBox
    '        Private WithEvents CheckBox1 As SAPbouiCOM.CheckBox
    '        Private WithEvents EditText49 As SAPbouiCOM.EditText
    '        Private WithEvents StaticText11 As SAPbouiCOM.StaticText
    '        Private WithEvents StaticText12 As SAPbouiCOM.StaticText
    '        Private WithEvents EditText51 As SAPbouiCOM.EditText
    '        Private WithEvents StaticText13 As SAPbouiCOM.StaticText
    '        Private WithEvents EditText52 As SAPbouiCOM.EditText
    '        Private WithEvents StaticText14 As SAPbouiCOM.StaticText
    '        Private WithEvents StaticText15 As SAPbouiCOM.StaticText
    '        Private WithEvents StaticText16 As SAPbouiCOM.StaticText
    '        Private WithEvents Button14 As SAPbouiCOM.Button
    '        Private WithEvents Button15 As SAPbouiCOM.Button
    '        Private WithEvents EditText53 As SAPbouiCOM.EditText
    '        Private WithEvents EditText54 As SAPbouiCOM.EditText
    '        Private WithEvents StaticText17 As SAPbouiCOM.StaticText
    '        Private WithEvents ComboBox7 As SAPbouiCOM.ComboBox
    '        Private WithEvents StaticText18 As SAPbouiCOM.StaticText
    '        Private WithEvents Folder4 As SAPbouiCOM.Folder
    '        Private WithEvents Button16 As SAPbouiCOM.Button
    '        Private WithEvents Button17 As SAPbouiCOM.Button
    '        Private WithEvents EditText55 As SAPbouiCOM.EditText
    '        Private WithEvents EditText56 As SAPbouiCOM.EditText
    '        Private WithEvents EditText57 As SAPbouiCOM.EditText
    '        Private WithEvents EditText58 As SAPbouiCOM.EditText
    '        Private WithEvents EditText59 As SAPbouiCOM.EditText
    '        Private WithEvents StaticText19 As SAPbouiCOM.StaticText
    '        Private WithEvents StaticText20 As SAPbouiCOM.StaticText
    '        Private WithEvents StaticText21 As SAPbouiCOM.StaticText
    '        Private WithEvents StaticText22 As SAPbouiCOM.StaticText
    '        Private WithEvents StaticText23 As SAPbouiCOM.StaticText
    '        Private WithEvents EditText61 As SAPbouiCOM.EditText
    '        Private WithEvents EditText62 As SAPbouiCOM.EditText
    '        Private WithEvents EditText66 As SAPbouiCOM.EditText
    '        Private WithEvents EditText67 As SAPbouiCOM.EditText
    '        Private WithEvents EditText68 As SAPbouiCOM.EditText
    '        Private WithEvents EditText69 As SAPbouiCOM.EditText
    '        Private WithEvents StaticText24 As SAPbouiCOM.StaticText
    '        Private WithEvents EditText71 As SAPbouiCOM.EditText
    '        Private WithEvents EditText72 As SAPbouiCOM.EditText
    '        Private WithEvents EditText63 As SAPbouiCOM.EditText
    '        Private WithEvents EditText64 As SAPbouiCOM.EditText
    '        Private WithEvents Button19 As SAPbouiCOM.Button
    '        Private WithEvents StaticText25 As SAPbouiCOM.StaticText
    '        Private WithEvents StaticText26 As SAPbouiCOM.StaticText
    '        Private WithEvents StaticText27 As SAPbouiCOM.StaticText
    '        Private WithEvents StaticText28 As SAPbouiCOM.StaticText
    '        Private WithEvents StaticText29 As SAPbouiCOM.StaticText
    '        Private WithEvents StaticText30 As SAPbouiCOM.StaticText
    '        Private WithEvents StaticText31 As SAPbouiCOM.StaticText
    '        Private WithEvents EditText60 As SAPbouiCOM.EditText
    '        Private WithEvents EditText70 As SAPbouiCOM.EditText
    '        Private WithEvents EditText73 As SAPbouiCOM.EditText
    '        Private WithEvents EditText74 As SAPbouiCOM.EditText
    '        Private WithEvents EditText75 As SAPbouiCOM.EditText
    '        Private WithEvents EditText65 As SAPbouiCOM.EditText
    '        Private WithEvents EditText76 As SAPbouiCOM.EditText
    '        Private WithEvents EditText77 As SAPbouiCOM.EditText
    '        Private WithEvents EditText78 As SAPbouiCOM.EditText
    '        Private WithEvents EditText79 As SAPbouiCOM.EditText
    '        Private WithEvents StaticText32 As SAPbouiCOM.StaticText
    '        Private WithEvents StaticText33 As SAPbouiCOM.StaticText
    '        Private WithEvents StaticText34 As SAPbouiCOM.StaticText
    '        Private WithEvents EditText80 As SAPbouiCOM.EditText
    '        Private WithEvents PictureBox2 As SAPbouiCOM.PictureBox
    '        Private WithEvents PictureBox3 As SAPbouiCOM.PictureBox
    '        Private WithEvents PictureBox4 As SAPbouiCOM.PictureBox
    '        Private WithEvents PictureBox5 As SAPbouiCOM.PictureBox
    '        Private WithEvents PictureBox6 As SAPbouiCOM.PictureBox
    '        Private WithEvents StaticText35 As SAPbouiCOM.StaticText
    '        Private WithEvents StaticText36 As SAPbouiCOM.StaticText
    '        Private WithEvents StaticText37 As SAPbouiCOM.StaticText
    '        Private WithEvents StaticText38 As SAPbouiCOM.StaticText
    '        Private WithEvents EditText82 As SAPbouiCOM.EditText
    '        Private WithEvents Folder5 As SAPbouiCOM.Folder
    '        Private WithEvents CheckBox2 As SAPbouiCOM.CheckBox
    '        Private WithEvents CheckBox3 As SAPbouiCOM.CheckBox
    '        Private WithEvents EditText81 As SAPbouiCOM.EditText
    '        Private WithEvents StaticText39 As SAPbouiCOM.StaticText
    '        Private WithEvents OptionBtn3 As SAPbouiCOM.OptionBtn
    '        Private WithEvents OptionBtn4 As SAPbouiCOM.OptionBtn
    '        Private WithEvents StaticText40 As SAPbouiCOM.StaticText
    '        Private WithEvents StaticText41 As SAPbouiCOM.StaticText
    '        Private WithEvents Button20 As SAPbouiCOM.Button
    '        Private WithEvents Button21 As SAPbouiCOM.Button
    '        Private WithEvents EditText83 As SAPbouiCOM.EditText
    '        Private WithEvents EditText84 As SAPbouiCOM.EditText
    '        Private WithEvents StaticText42 As SAPbouiCOM.StaticText
    '        Private WithEvents EditText85 As SAPbouiCOM.EditText
    '        Private WithEvents StaticText43 As SAPbouiCOM.StaticText
    '        Private WithEvents EditText86 As SAPbouiCOM.EditText
    '        Private WithEvents Button22 As SAPbouiCOM.Button
    '        Private WithEvents PictureBox9 As SAPbouiCOM.PictureBox
    '        Private WithEvents PictureBox10 As SAPbouiCOM.PictureBox
    '        Private WithEvents Button23 As SAPbouiCOM.Button
    '        Private WithEvents PictureBox1 As SAPbouiCOM.PictureBox
    '        Private WithEvents Matrix0 As SAPbouiCOM.Matrix
    '        Private WithEvents Button37 As SAPbouiCOM.Button
    '        Private WithEvents ComboBox8 As SAPbouiCOM.ComboBox
    '        Private WithEvents StaticText44 As SAPbouiCOM.StaticText
    '        Private WithEvents Matrix1 As SAPbouiCOM.Matrix
    '        Private WithEvents ComboBox9 As SAPbouiCOM.ComboBox
    '        Private WithEvents ComboBox10 As SAPbouiCOM.ComboBox
    '        Private WithEvents StaticText45 As SAPbouiCOM.StaticText
    '        Private WithEvents StaticText46 As SAPbouiCOM.StaticText
    '        Private WithEvents StaticText47 As SAPbouiCOM.StaticText
    '        Private WithEvents StaticText48 As SAPbouiCOM.StaticText
    '        Private WithEvents EditText87 As SAPbouiCOM.EditText
    '        Private WithEvents EditText88 As SAPbouiCOM.EditText
    '        Private WithEvents OptionBtn5 As SAPbouiCOM.OptionBtn
    '        Private WithEvents OptionBtn6 As SAPbouiCOM.OptionBtn
    '        Private WithEvents StaticText49 As SAPbouiCOM.StaticText
    '        Private WithEvents EditText89 As SAPbouiCOM.EditText
    '        Private WithEvents StaticText50 As SAPbouiCOM.StaticText
    '        Private WithEvents EditText90 As SAPbouiCOM.EditText
    '        Private WithEvents StaticText51 As SAPbouiCOM.StaticText
    '        Private WithEvents OptionBtn7 As SAPbouiCOM.OptionBtn
    '        Private WithEvents OptionBtn8 As SAPbouiCOM.OptionBtn
    '        Private WithEvents StaticText52 As SAPbouiCOM.StaticText
    '        Private WithEvents Button24 As SAPbouiCOM.Button
    '        Private WithEvents Button25 As SAPbouiCOM.Button


    '        'Private WithEvents UD_14 As SAPbouiCOM.UserDataSource

    '#End Region


    '#Region "Codigo Antiguo"
    '        'Private WithEvents Button8 As SAPbouiCOM.Button



    '        'Private Sub Button8_ClickBefore(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg, ByRef BubbleEvent As System.Boolean) Handles Button8.ClickBefore

    '        '    'Declarar, seleccionar y exportar el objeto de la tabla en XML
    '        '    oCompany.XmlExportType = SAPbobsCOM.BoXmlExportTypes.xet_ExportImportMode
    '        '    Dim oUserTablesMD As SAPbobsCOM.UserTablesMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserTables)

    '        '    'If (oUserTablesMD.GetByKey("ZINFOP")) Then

    '        '    '    oUserTablesMD.SaveToFile("C:\Users\Programador\Documents\" + oUserTablesMD.TableName + ".xml")

    '        '    'End If

    '        '    ''Recuperar la lista de ID campos de usuarios desde la tabla CUFD y exportarlos en XML
    '        '    'Dim oUserFieldsMD As SAPbobsCOM.UserFieldsMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)
    '        '    'Dim UDTName As String = "ZINFOP"
    '        '    'Dim UDF_ID As Integer = 5

    '        '    'If (oUserFieldsMD.GetByKey(UDTName, UDF_ID)) Then

    '        '    '    oUserTablesMD.SaveToFile("C:\Users\Programador\Documents\" + oUserFieldsMD.FieldID + ".xml")

    '        '    'End If

    '        '    oCompany.GetBusinessObjectFromXML("C:\Users\Programador\Documents\ZHFPM.xml", 0)
    '        '    oCompany.GetBusinessObjectFromXML("C:\Users\Programador\Documents\ZINFOP.xml", 0)

    '        'End Sub

    '#End Region

    '    End Class
    'End Namespace
End Module
