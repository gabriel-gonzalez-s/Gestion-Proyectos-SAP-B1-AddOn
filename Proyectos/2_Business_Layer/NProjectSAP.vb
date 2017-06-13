Imports System.Reflection
Imports SBOAddonProject1

Public Class NProjectSAP

    Public Shared Function AddProject(PrjCode As String, PrjName As String, CardCode As String, CardName As String) As String

        Dim SBO_Company As SAPbobsCOM.Company = NConectarAplicacion.oCompanySH
        Dim oCmpSrv As SAPbobsCOM.CompanyService
        Dim projectService As SAPbobsCOM.IProjectsService
        Dim project As SAPbobsCOM.IProject
        Dim rpta As String = ""

        Try
            'get company service
            If Not SBO_Company.Connected Then
                Dim oConectarAplicacion As New NConectarAplicacion()
                oConectarAplicacion.Conectar_Aplicacion(SBO_Company)
            End If

            oCmpSrv = SBO_Company.GetCompanyService
            projectService = oCmpSrv.GetBusinessService(SAPbobsCOM.ServiceTypes.ProjectsService)

            project = projectService.GetDataInterface(SAPbobsCOM.ProjectsServiceDataInterfaces.psProject)

            project.Code = PrjCode
            project.Name = PrjName
            project.UserFields.Item("U_CardCode").Value = CardCode
            project.UserFields.Item("U_CardName").Value = CardName
            projectService.AddProject(project)

            rpta = "S"
        Catch ex As Exception
            rpta = ex.Message
        End Try

        Return rpta

    End Function

End Class
