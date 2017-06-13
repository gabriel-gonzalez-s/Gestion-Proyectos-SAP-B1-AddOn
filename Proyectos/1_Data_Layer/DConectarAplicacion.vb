Imports SAPbouiCOM.Framework
Imports SAPbobsCOM

Public Class DConectarAplicacion

    Public sCodUsuActual As String = ""
    Public sAliasUsuActual As String = ""
    Public sNomUsuActual As String = ""
    Public sCurrentCompanyDB As String = ""

    Public Shared sBDComercial As String = "SBO_COMERCIAL"
    Public Shared sBDIndustrial As String = "SBO_INDUSTRIAL"
    Public Shared sBDMontaje As String = "SBO_MONTAJE"
    Public Shared UsuarioSUComercial As String = "manager"
    Public Shared PassSUComercial As String = "rgnm"
    Public Shared sCurrentCompanyDBS As String = ""

    'Variables de Conexion a las BD DI - UI API
    '------------------------------------------------------------
    Public SboGuiApi As New SAPbouiCOM.SboGuiApi
    Public SBO_App As SAPbouiCOM.Application
    Public oCompany As New SAPbobsCOM.Company
    Public Shared oCompanyPS As SAPbobsCOM.Company


    Public Sub Conectar_Aplicacion()

        SboGuiApi.Connect("0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056")
        SBO_App = SboGuiApi.GetApplication()
        oCompany = SBO_App.Company.GetDICompany()

        sCodUsuActual = oCompany.UserSignature
        sNomUsuActual = Nombre_Usuario_Actual()
        sAliasUsuActual = oCompany.UserName
        sCurrentCompanyDB = oCompany.CompanyDB
        sCurrentCompanyDBS = sCurrentCompanyDB
        oCompanyPS = oCompany

    End Sub

    Public Function Conectar_Empresa(SBO_Company As SAPbobsCOM.Company, CompanyDB As String) As SAPbobsCOM.Company

        Dim oCompanyDI As SAPbobsCOM.Company = New SAPbobsCOM.Company
        Dim retCode As Integer = 0

        If (SBO_Company.Connect) Then
            Try
                Dim cookie = oCompanyDI.GetContextCookie
                Dim context = Application.SBO_Application.Company.GetConnectionContext(cookie)

                retCode = oCompanyDI.SetSboLoginContext(context)
                oCompanyDI.CompanyDB = CompanyDB
                oCompanyDI.UserName = UsuarioSUComercial '"manager"
                oCompanyDI.Password = PassSUComercial '"rgnm"

                retCode = oCompanyDI.Connect()
                If retCode <> 0 Then
                    Application.SBO_Application.MessageBox("Cannot set login context. Connection failed !")
                End If

            Catch exception As Exception
            End Try
        End If
        Return oCompanyDI

    End Function

    Public Sub Disconnect_Company(SBO_Company As SAPbobsCOM.Company)

        Try
            SBO_Company.Disconnect()
        Catch ex As Exception
        Finally
            Runtime.InteropServices.Marshal.FinalReleaseComObject(SBO_Company)
        End Try

    End Sub


    Private Function Nombre_Usuario_Actual()

        Dim sNombreUsu As String
        Dim oForm As SAPbouiCOM.Form = Application.SBO_Application.Forms.GetForm(169, 0) 'Toma la Descripcion del Usuario Actual del Menu Principal
        Dim oStatic As SAPbouiCOM.StaticText = oForm.Items.Item("8").Specific
        sNombreUsu = oStatic.Caption
        Return sNombreUsu

    End Function

End Class



