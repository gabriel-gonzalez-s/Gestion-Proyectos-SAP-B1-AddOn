Option Strict Off
Option Explicit On

Imports SAPbouiCOM.Framework

Namespace SBOAddonProject1
    <FormAttribute("SBOAddonProject1.FrmBuscaProyecto", "3_Presentation_Layer/Pantallas Modales/FrmBuscaProyecto.b1f")>
    Friend Class FrmBuscaProyecto
        Inherits UserFormBase

        Private WithEvents oFormFrm As SAPbouiCOM.Form
        Public Sub New()
        End Sub

        Public Overrides Sub OnInitializeComponent()
            Me.EditText0 = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.EditText)
            Me.StaticText0 = CType(Me.GetItem("Item_1").Specific, SAPbouiCOM.StaticText)
            Me.Button0 = CType(Me.GetItem("Item_2").Specific, SAPbouiCOM.Button)
            Me.Button1 = CType(Me.GetItem("Item_3").Specific, SAPbouiCOM.Button)
            Me.Button2 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.Button)
            Me.Folder0 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.Folder)
            Me.DT_SQL = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_SQL")
            Me.Grid0 = CType(Me.GetItem("Item_7").Specific, SAPbouiCOM.Grid)
            Me.Grid0.Item.FromPane = 0
            Me.Grid0.Item.ToPane = 0
            Me.OnCustomInitialize()

        End Sub

        Public Overrides Sub OnInitializeFormEvents()

        End Sub

        Private WithEvents EditText0 As SAPbouiCOM.EditText

        Private Sub OnCustomInitialize()
            oFormFrm = Application.SBO_Application.Forms.Item(Me.UIAPIRawForm.UniqueID)
            'AddHandler Me.Button2.ClickAfter, AddressOf Me.Button1.ClickAfter

            Me.Grid1 = CType(oFormFrm.Items.Add("Grid_1", SAPbouiCOM.BoFormItemTypes.it_GRID).Specific, SAPbouiCOM.Grid) ' CType(Me.GetItem("Item_7").Specific, SAPbouiCOM.Grid)
            ' AddHandler Me.Grid1.ClickAfter, AddressOf Me.Grid0.ClickAfter

            'oItem = oFormFrm.Items.Add("Grid_1", SAPbouiCOM.BoFormItemTypes.it_GRID)
            'oItem = oFormFrm.Items.Item("Grid_1")
            Me.Grid1.Item.Top = 70
            Me.Grid1.Item.Left = 280
            Me.Grid1.Item.Height = 171
            Me.Grid1.Item.Width = 195
            Me.Grid1.Item.FromPane = 0
            Me.Grid1.Item.ToPane = 0


        End Sub

        Private WithEvents StaticText0 As SAPbouiCOM.StaticText
        Private WithEvents Button0 As SAPbouiCOM.Button
        Private WithEvents Button1 As SAPbouiCOM.Button
        Private WithEvents Button2 As SAPbouiCOM.Button
        Private WithEvents Folder0 As SAPbouiCOM.Folder
        Private WithEvents DT_SQL As SAPbouiCOM.DataTable
        Private WithEvents Grid0 As SAPbouiCOM.Grid
        Private WithEvents Grid1 As SAPbouiCOM.Grid

        Private Sub Grid0_ValidateAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid0.ValidateAfter

        End Sub


        Private Sub Grid0_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Grid0.ClickAfter

            Application.SBO_Application.StatusBar.SetText("CLick en Grid", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success)

        End Sub

        Private Sub Button1_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg)
            Application.SBO_Application.StatusBar.SetText("CLick en Grid", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Success)
        End Sub
    End Class
End Namespace
