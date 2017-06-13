Option Strict Off
Option Explicit On

Imports SAPbouiCOM.Framework

Namespace SBOAddonProject1
    <FormAttribute("SBOAddonProject1.Form4", "FrmEdo_Com_Ing.b1f")>
    Friend Class Form4
        Inherits UserFormBase

        Public Sub New()
        End Sub

        Public Overrides Sub OnInitializeComponent()
            Me.EditText0 = CType(Me.GetItem("Item_1").Specific, SAPbouiCOM.EditText)
            Me.StaticText0 = CType(Me.GetItem("Item_2").Specific, SAPbouiCOM.StaticText)
            Me.EditText1 = CType(Me.GetItem("Item_3").Specific, SAPbouiCOM.EditText)
            Me.StaticText1 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.StaticText)
            Me.EditText2 = CType(Me.GetItem("Item_5").Specific, SAPbouiCOM.EditText)
            Me.StaticText2 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.StaticText)
            Me.EditText3 = CType(Me.GetItem("Item_7").Specific, SAPbouiCOM.EditText)
            Me.StaticText3 = CType(Me.GetItem("Item_8").Specific, SAPbouiCOM.StaticText)
            Me.EditText4 = CType(Me.GetItem("Item_9").Specific, SAPbouiCOM.EditText)
            Me.StaticText4 = CType(Me.GetItem("Item_10").Specific, SAPbouiCOM.StaticText)
            Me.EditText5 = CType(Me.GetItem("Item_11").Specific, SAPbouiCOM.EditText)
            Me.StaticText5 = CType(Me.GetItem("Item_12").Specific, SAPbouiCOM.StaticText)
            Me.EditText6 = CType(Me.GetItem("Item_13").Specific, SAPbouiCOM.EditText)
            Me.StaticText6 = CType(Me.GetItem("Item_14").Specific, SAPbouiCOM.StaticText)
            Me.EditText7 = CType(Me.GetItem("Item_15").Specific, SAPbouiCOM.EditText)
            Me.StaticText7 = CType(Me.GetItem("Item_16").Specific, SAPbouiCOM.StaticText)
            Me.Folder0 = CType(Me.GetItem("Item_18").Specific, SAPbouiCOM.Folder)
            Me.EditText8 = CType(Me.GetItem("Item_19").Specific, SAPbouiCOM.EditText)
            Me.ComboBox0 = CType(Me.GetItem("Item_20").Specific, SAPbouiCOM.ComboBox)
            Me.EditText9 = CType(Me.GetItem("Item_21").Specific, SAPbouiCOM.EditText)
            Me.StaticText8 = CType(Me.GetItem("Item_22").Specific, SAPbouiCOM.StaticText)
            Me.StaticText9 = CType(Me.GetItem("Item_23").Specific, SAPbouiCOM.StaticText)
            Me.EditText10 = CType(Me.GetItem("Item_24").Specific, SAPbouiCOM.EditText)
            Me.StaticText10 = CType(Me.GetItem("Item_25").Specific, SAPbouiCOM.StaticText)
            Me.EditText11 = CType(Me.GetItem("Item_26").Specific, SAPbouiCOM.EditText)
            Me.StaticText11 = CType(Me.GetItem("Item_27").Specific, SAPbouiCOM.StaticText)
            Me.EditText12 = CType(Me.GetItem("Item_28").Specific, SAPbouiCOM.EditText)
            Me.StaticText12 = CType(Me.GetItem("Item_29").Specific, SAPbouiCOM.StaticText)
            Me.EditText13 = CType(Me.GetItem("Item_30").Specific, SAPbouiCOM.EditText)
            Me.StaticText13 = CType(Me.GetItem("Item_31").Specific, SAPbouiCOM.StaticText)
            Me.EditText14 = CType(Me.GetItem("Item_32").Specific, SAPbouiCOM.EditText)
            Me.StaticText14 = CType(Me.GetItem("Item_33").Specific, SAPbouiCOM.StaticText)
            Me.EditText15 = CType(Me.GetItem("Item_34").Specific, SAPbouiCOM.EditText)
            Me.StaticText15 = CType(Me.GetItem("Item_35").Specific, SAPbouiCOM.StaticText)
            Me.StaticText16 = CType(Me.GetItem("Item_36").Specific, SAPbouiCOM.StaticText)
            Me.Matrix0 = CType(Me.GetItem("Item_37").Specific, SAPbouiCOM.Matrix)
            Me.Matrix1 = CType(Me.GetItem("Item_38").Specific, SAPbouiCOM.Matrix)
            Me.Button1 = CType(Me.GetItem("Item_40").Specific, SAPbouiCOM.Button)
            Me.StaticText17 = CType(Me.GetItem("Item_41").Specific, SAPbouiCOM.StaticText)
            Me.StaticText18 = CType(Me.GetItem("Item_42").Specific, SAPbouiCOM.StaticText)
            Me.OnCustomInitialize()

            Me.ComboBox0.ValidValues.Add("DE", "En Desarrollo")
            Me.ComboBox0.ValidValues.Add("SU", "Suspendida (Comercial)")
            Me.ComboBox0.ValidValues.Add("PC", "PC Emitidas a Industrial y Montajes")

        End Sub

        Public Overrides Sub OnInitializeFormEvents()
            AddHandler LoadAfter, AddressOf Me.Form_LoadAfter

        End Sub

        Private Sub OnCustomInitialize()

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
        Private WithEvents EditText7 As SAPbouiCOM.EditText
        Private WithEvents StaticText7 As SAPbouiCOM.StaticText
        Private WithEvents Folder0 As SAPbouiCOM.Folder
        Private WithEvents EditText8 As SAPbouiCOM.EditText
        Private WithEvents ComboBox0 As SAPbouiCOM.ComboBox
        Private WithEvents EditText9 As SAPbouiCOM.EditText
        Private WithEvents StaticText8 As SAPbouiCOM.StaticText
        Private WithEvents StaticText9 As SAPbouiCOM.StaticText
        Private WithEvents EditText10 As SAPbouiCOM.EditText
        Private WithEvents StaticText10 As SAPbouiCOM.StaticText
        Private WithEvents EditText11 As SAPbouiCOM.EditText
        Private WithEvents StaticText11 As SAPbouiCOM.StaticText

        Private Sub Form_LoadAfter(pVal As SAPbouiCOM.SBOItemEventArg)

        End Sub
        Private WithEvents EditText12 As SAPbouiCOM.EditText
        Private WithEvents StaticText12 As SAPbouiCOM.StaticText
        Private WithEvents EditText13 As SAPbouiCOM.EditText
        Private WithEvents StaticText13 As SAPbouiCOM.StaticText
        Private WithEvents EditText14 As SAPbouiCOM.EditText
        Private WithEvents StaticText14 As SAPbouiCOM.StaticText
        Private WithEvents EditText15 As SAPbouiCOM.EditText
        Private WithEvents StaticText15 As SAPbouiCOM.StaticText
        Private WithEvents StaticText16 As SAPbouiCOM.StaticText
        Private WithEvents Matrix0 As SAPbouiCOM.Matrix
        Private WithEvents Matrix1 As SAPbouiCOM.Matrix
        Private WithEvents Button1 As SAPbouiCOM.Button
        Private WithEvents StaticText17 As SAPbouiCOM.StaticText
        Private WithEvents StaticText18 As SAPbouiCOM.StaticText
    End Class
End Namespace
