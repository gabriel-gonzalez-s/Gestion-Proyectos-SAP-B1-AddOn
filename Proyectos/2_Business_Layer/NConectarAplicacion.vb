Imports SAPbouiCOM.Framework
Imports SAPbobsCOM
Imports SBOAddonProject1

Public Class NConectarAplicacion

    Public oDConectarAplicacion As New DConectarAplicacion
    Public oCompany As SAPbobsCOM.Company = oDConectarAplicacion.oCompany
    Public Shared oCompanySH As SAPbobsCOM.Company = Nothing
    Public sCodUsuActual As String = oDConectarAplicacion.sCodUsuActual
    Public sAliasUsuActual As String = oDConectarAplicacion.sAliasUsuActual
    Public sNomUsuActual As String = oDConectarAplicacion.sNomUsuActual
    Public sCurrentCompanyDB As String = oDConectarAplicacion.sCurrentCompanyDB
    Public Shared sCurrentCompanyDBSH As String = Nothing

    Public Sub Conectar_Aplicacion(ByRef oCompany As SAPbobsCOM.Company)

        oDConectarAplicacion.Conectar_Aplicacion()
        oCompany = oDConectarAplicacion.oCompany
        oCompanySH = DConectarAplicacion.oCompanyPS

        sCodUsuActual = oDConectarAplicacion.sCodUsuActual
        sAliasUsuActual = oDConectarAplicacion.sAliasUsuActual
        sNomUsuActual = oDConectarAplicacion.sNomUsuActual
        sCurrentCompanyDB = oDConectarAplicacion.sCurrentCompanyDB
        sCurrentCompanyDBSH = oDConectarAplicacion.sCurrentCompanyDB

    End Sub

    Public Shared Function Conectar_Empresa(SBO_Company As SAPbobsCOM.Company, CompanyDB As String) As SAPbobsCOM.Company

        If SBO_Company.Connect = False Then
            Dim oNConectarAplicacion As New NConectarAplicacion
            oNConectarAplicacion.Conectar_Aplicacion(SBO_Company)
        End If

        Dim oDConectarAplicacion As New DConectarAplicacion
        Return oDConectarAplicacion.Conectar_Empresa(SBO_Company, CompanyDB)

    End Function

End Class




