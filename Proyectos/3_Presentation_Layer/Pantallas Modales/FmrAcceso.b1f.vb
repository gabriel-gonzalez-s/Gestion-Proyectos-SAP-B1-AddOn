Option Strict Off
Option Explicit On

Imports SAPbouiCOM.Framework

Namespace SBOAddonProject1
    <FormAttribute("SBOAddonProject1.Form12", "3_Presentation_Layer/Pantallas Modales/FmrAcceso.b1f")>
    Friend Class Form12
        Inherits UserFormBase

        Public Sub New()
        End Sub

        Public Overrides Sub OnInitializeComponent()
            Me.Button0 = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.Button)
            Me.Button1 = CType(Me.GetItem("Item_1").Specific, SAPbouiCOM.Button)
            Me.StaticText0 = CType(Me.GetItem("Item_2").Specific, SAPbouiCOM.StaticText)
            Me.EditText0 = CType(Me.GetItem("Item_3").Specific, SAPbouiCOM.EditText)
            Me.StaticText1 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.StaticText)
            Me.EditText1 = CType(Me.GetItem("Item_5").Specific, SAPbouiCOM.EditText)
            Me.PictureBox0 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.PictureBox)
            Me.PictureBox0.Picture = sPathAnexos + "images\User.png"
            Me.PictureBox1 = CType(Me.GetItem("Item_7").Specific, SAPbouiCOM.PictureBox)
            Me.PictureBox1.Picture = sPathAnexos + "images\LogoSapB1.png"
            Me.DT_SQL = Me.UIAPIRawForm.DataSources.DataTables.Item("DT_SQL")

            Try
                Me.UIAPIRawForm.ReportType = "Modal"
            Catch ex As Exception

            End Try

            Me.OnCustomInitialize()

        End Sub

        Public Overrides Sub OnInitializeFormEvents()

        End Sub

        Private Sub OnCustomInitialize()
            Me.EditText0.Value = "Admin"
            Me.EditText1.Item.Click()
        End Sub

        Private Sub Button1_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button1.ClickAfter
            Application.SBO_Application.Forms.Item(pVal.FormUID).Close()
        End Sub

        Private Sub Button0_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button0.ClickAfter

            Dim sClave As String = ""
            sPSql = "SELECT * FROM [" + sBDComercial + "].dbo.[OUSR] where USER_Code ='" + oConectarAplicacion.sAliasUsuActual + "'"

            Try
                DT_SQL.ExecuteQuery(sPSql)
                sClave = DT_SQL.GetValue("U_Gestion_Proyectos", 0)
            Catch ex As Exception

            End Try

            If Me.EditText0.Value.Trim = "Admin" And Me.EditText1.Value = sClave Then

                Dim oUDS As SAPbouiCOM.UserDataSource = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_0")
                Dim _x As String = oUDS.ValueEx        'Aca nos traemos el FormUID del Formulario Principal guardado en el User Data Source
                Dim oUDS2 As SAPbouiCOM.UserDataSource = Me.UIAPIRawForm.DataSources.UserDataSources.Item("UD_1")
                Dim sOrig As String = oUDS2.ValueEx      'Aca nos traemos el valor que nos determina el Form de Origen  

                Dim oFormP As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(_x)

                Try
                    oFormP.Freeze(True)

                    Select Case sOrig
                        Case "GLOBAL"
                            Dim Btn As SAPbouiCOM.Button = oFormP.Items.Item("Item_68").Specific
                            Btn.Item.Enabled = True
                            Btn = oFormP.Items.Item("Item_83").Specific
                            Btn.Item.Enabled = True
                            Btn = oFormP.Items.Item("Item_86").Specific
                            Btn.Item.Enabled = True
                            Btn = oFormP.Items.Item("Item_89").Specific
                            Btn.Item.Enabled = True
                            Btn = oFormP.Items.Item("Item_92").Specific
                            Btn.Item.Enabled = True
                            Btn = oFormP.Items.Item("Item_205").Specific
                            If (Btn.Item.Visible = True) Then
                                Btn.Item.Enabled = True
                            End If
                            Btn = oFormP.Items.Item("Item_113").Specific
                            Btn.Item.Enabled = True
                            Btn = oFormP.Items.Item("Item_127").Specific
                            Btn.Item.Enabled = True
                            Btn = oFormP.Items.Item("Item_145").Specific
                            Btn.Item.Enabled = True
                            Btn = oFormP.Items.Item("Item_155").Specific
                            Btn.Item.Enabled = True

                        Case "PROYECTO"
                            Dim Btn As SAPbouiCOM.Button = oFormP.Items.Item("Item_25").Specific
                            Btn.Item.Enabled = True
                    End Select

                    Application.SBO_Application.Forms.Item(pVal.FormUID).Close()
                Catch ex As Exception
                Finally
                    oFormP.Freeze(False)  'Se Descongela el Form luego de Actualizar u Ocurrir alguna excepcion
                End Try
            Else
                Application.SBO_Application.StatusBar.SetText("Usuario o Clave Invalida", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
            End If

        End Sub

        Private Sub EditText1_KeyDownAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles EditText1.KeyDownAfter
            If pVal.CharPressed = 13 Then
                Me.Button0_ClickAfter(sboObject, pVal)
            End If
        End Sub

        Private WithEvents Button0 As SAPbouiCOM.Button
        Private WithEvents Button1 As SAPbouiCOM.Button
        Private WithEvents StaticText0 As SAPbouiCOM.StaticText
        Private WithEvents EditText0 As SAPbouiCOM.EditText
        Private WithEvents StaticText1 As SAPbouiCOM.StaticText
        Private WithEvents EditText1 As SAPbouiCOM.EditText
        Private WithEvents PictureBox0 As SAPbouiCOM.PictureBox
        Private WithEvents PictureBox1 As SAPbouiCOM.PictureBox
        Private WithEvents DT_SQL As SAPbouiCOM.DataTable

    End Class
End Namespace
