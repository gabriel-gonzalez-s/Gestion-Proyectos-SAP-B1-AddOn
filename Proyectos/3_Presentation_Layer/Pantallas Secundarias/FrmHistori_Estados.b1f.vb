Option Strict Off
Option Explicit On

Imports SAPbouiCOM.Framework

Namespace SBOAddonProject1
    <FormAttribute("SBOAddonProject1.Form13", "3_Presentation_Layer/Pantallas Secundarias/FrmHistori_Estados.b1f")>
    Friend Class Form13
        Inherits UserFormBase

        Public Sub New()
        End Sub

        Public Overrides Sub OnInitializeComponent()
            Me.EditText0 = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.EditText)
            Me.StaticText0 = CType(Me.GetItem("Item_1").Specific, SAPbouiCOM.StaticText)
            Me.EditText1 = CType(Me.GetItem("Item_2").Specific, SAPbouiCOM.EditText)
            Me.StaticText1 = CType(Me.GetItem("Item_3").Specific, SAPbouiCOM.StaticText)
            Me.EditText2 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.EditText)
            Me.StaticText2 = CType(Me.GetItem("Item_5").Specific, SAPbouiCOM.StaticText)
            Me.Button0 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.Button)
            Me.DT_1 = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_1")
            Me.Grid0 = CType(Me.GetItem("Item_8").Specific, SAPbouiCOM.Grid)
            Me.OnCustomInitialize()

        End Sub

        Public Overrides Sub OnInitializeFormEvents()

        End Sub


        Private Sub OnCustomInitialize()

            Dim oUDS As SAPbouiCOM.UserDataSource = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_1")
            Dim sCodPrj As String = oUDS.ValueEx

            Try

                Me.DT_1.ExecuteQuery(sPSql)

                If Me.DT_1.Rows.Count > 0 Then

                    Me.Grid0.DataTable = DT_1
                    Me.Grid0.CollapseLevel = 0

                End If

            Catch ex As Exception

                Application.SBO_Application.MessageBox(sPSql)
                Application.SBO_Application.MessageBox(ex.Message)

            End Try

        End Sub


        Private Sub Button0_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button0.ClickAfter
            Dim query As String = " select U_Estado_Proc as Estado, U_Fec_Registro as Fecha_Cambio,U_Hora_Registro as Hora_Cambio,U_User_Name as Usuario " & _
                                  " from [" + sBDComercial.Trim() + "].[dbo].[@ZHCEP] " & _
                                  " where U_Tipo_Proc = 'COMER_ING' and U_PrjCode = '" + Me.EditText0.Value.ToString() + "'"
            Try

                Me.DT_1.ExecuteQuery(query)

                If Me.DT_1.Rows.Count > 0 Then

                    Me.Grid0.DataTable = DT_1
                    Me.Grid0.CollapseLevel = 0

                End If

            Catch ex As Exception

                Application.SBO_Application.MessageBox(query)
                Application.SBO_Application.MessageBox(ex.Message)

            End Try
        End Sub

        Private WithEvents EditText0 As SAPbouiCOM.EditText
        Private WithEvents StaticText0 As SAPbouiCOM.StaticText
        Private WithEvents EditText1 As SAPbouiCOM.EditText
        Private WithEvents StaticText1 As SAPbouiCOM.StaticText
        Private WithEvents EditText2 As SAPbouiCOM.EditText
        Private WithEvents StaticText2 As SAPbouiCOM.StaticText
        Private WithEvents Button0 As SAPbouiCOM.Button
        Private WithEvents DT_1 As SAPbouiCOM.DataTable
        Private WithEvents Grid0 As SAPbouiCOM.Grid

    End Class
End Namespace
