Option Strict Off
Option Explicit On

Imports SAPbouiCOM.Framework

Namespace SBOAddonProject1
    <FormAttribute("SBOAddonProject1.FrmConsultaDat", "3_Presentation_Layer/Pantallas Secundarias/FrmConsultaDat.b1f")>
    Friend Class FrmConsultaDat
        Inherits UserFormBase

        Public Sub New()
        End Sub

        Public Overrides Sub OnInitializeComponent()
            Me.Button0 = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.Button)
            Me.Grid0 = CType(Me.GetItem("Item_1").Specific, SAPbouiCOM.Grid)
            Me.Folder0 = CType(Me.GetItem("Item_3").Specific, SAPbouiCOM.Folder)
            Me.EditText0 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.EditText)
            Me.StaticText0 = CType(Me.GetItem("Item_5").Specific, SAPbouiCOM.StaticText)
            Me.EditText1 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.EditText)
            Me.StaticText1 = CType(Me.GetItem("Item_7").Specific, SAPbouiCOM.StaticText)
            Me.EditText2 = CType(Me.GetItem("Item_8").Specific, SAPbouiCOM.EditText)
            Me.StaticText2 = CType(Me.GetItem("Item_9").Specific, SAPbouiCOM.StaticText)
            Me.EditText3 = CType(Me.GetItem("Item_10").Specific, SAPbouiCOM.EditText)
            Me.StaticText3 = CType(Me.GetItem("Item_11").Specific, SAPbouiCOM.StaticText)
            Me.EditText4 = CType(Me.GetItem("Item_12").Specific, SAPbouiCOM.EditText)
            Me.StaticText4 = CType(Me.GetItem("Item_13").Specific, SAPbouiCOM.StaticText)
            Me.EditText5 = CType(Me.GetItem("Item_14").Specific, SAPbouiCOM.EditText)
            Me.StaticText5 = CType(Me.GetItem("Item_15").Specific, SAPbouiCOM.StaticText)
            Me.EditText7 = CType(Me.GetItem("Item_18").Specific, SAPbouiCOM.EditText)
            Me.StaticText7 = CType(Me.GetItem("Item_19").Specific, SAPbouiCOM.StaticText)
            Me.EditText8 = CType(Me.GetItem("Item_20").Specific, SAPbouiCOM.EditText)
            Me.DT_ENCA = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_ENCA")
            Me.OnCustomInitialize()

        End Sub

        Public Overrides Sub OnInitializeFormEvents()
            AddHandler LoadAfter, AddressOf Me.Form_LoadAfter
            AddHandler VisibleAfter, AddressOf Me.Form_VisibleAfter

        End Sub


        Private Sub OnCustomInitialize()

        End Sub

        Private Sub Form_LoadAfter(pVal As SAPbouiCOM.SBOItemEventArg)

        End Sub

        Private Sub Form_VisibleAfter(pVal As SAPbouiCOM.SBOItemEventArg)

        End Sub


        Private Sub Grid0_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid0.ClickAfter
            Try

                Grid0.Rows.SelectedRows.Add(pVal.Row)

            Catch ex As Exception

            End Try
        End Sub

        Private Sub Button0_ClickAfter(sboObject As System.Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button0.ClickAfter
            Try
                Me.UIAPIRawForm.Close()
            Catch ex As Exception

            End Try
        End Sub


        Private WithEvents Button0 As SAPbouiCOM.Button
        Private WithEvents Grid0 As SAPbouiCOM.Grid
        Private WithEvents Folder0 As SAPbouiCOM.Folder
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
        Private WithEvents EditText7 As SAPbouiCOM.EditText
        Private WithEvents StaticText7 As SAPbouiCOM.StaticText
        Private WithEvents EditText8 As SAPbouiCOM.EditText
        Private WithEvents DT_ENCA As SAPbouiCOM.DataTable

    End Class
End Namespace
