Public Class NDocumProyecto

    Public Shared Function Insertar_Documento(U_PrjCode As String, U_PathOrigen As String, U_PtahServer As String, U_Fec_Registro As Date, U_Hora_Registro As String, U_User_Id As String, U_Tipo_Plano As String, U_Comentario As String, U_Status As String, U_Tipo_Documento As String, U_Renglon As Integer) As String
        Dim Obj As New DDocumProyecto()
        Dim SBO_Empresa As String = ""

        Obj.U_PrjCode = U_PrjCode
        Obj.U_PathOrigen = U_PathOrigen
        Obj.U_PtahServer = U_PtahServer
        Obj.U_Fec_Registro = U_Fec_Registro
        Obj.U_Hora_Registro = U_Hora_Registro
        Obj.U_User_Id = U_User_Id
        Obj.U_Tipo_Plano = U_Tipo_Plano
        Obj.U_Comentario = U_Comentario
        Obj.U_Status = U_Status
        Obj.U_Tipo_Documento = U_Tipo_Documento
        Obj.U_Renglon = U_Renglon

        If DConectarAplicacion.sCurrentCompanyDBS <> DConectarAplicacion.sBDComercial Then
            SBO_Empresa = DConectarAplicacion.sBDComercial
        End If

        Return Obj.Insertar_Documento(Obj, SBO_Empresa)

    End Function

    Public Shared Function Modificar_Documento(U_PrjCode As String, U_PathOrigen As String, U_PtahServer As String, U_Fec_Registro As Date, U_Hora_Registro As String, U_User_Id As String, U_Tipo_Plano As String, U_Comentario As String, U_Status As String, U_Tipo_Documento As String, U_Renglon As Integer) As String
        Dim Obj As New DDocumProyecto()
        Dim SBO_Empresa As String = ""

        Obj.U_PrjCode = U_PrjCode
        Obj.U_PathOrigen = U_PathOrigen
        Obj.U_PtahServer = U_PtahServer
        Obj.U_Fec_Registro = U_Fec_Registro
        Obj.U_Hora_Registro = U_Hora_Registro
        Obj.U_User_Id = U_User_Id
        Obj.U_Tipo_Plano = U_Tipo_Plano
        Obj.U_Comentario = U_Comentario
        Obj.U_Status = U_Status
        Obj.U_Tipo_Documento = U_Tipo_Documento
        Obj.U_Renglon = U_Renglon

        If DConectarAplicacion.sCurrentCompanyDBS <> DConectarAplicacion.sBDComercial Then
            SBO_Empresa = DConectarAplicacion.sBDComercial
        End If

        Return Obj.Modificar_Documento(Obj, SBO_Empresa)

    End Function

    Public Shared Function Eliminar_Documento(U_PrjCode As String, U_Renglon As Integer) As String

        Dim Obj As New DDocumProyecto()
        Dim SBO_Empresa As String = ""

        Obj.U_PrjCode = U_PrjCode
        Obj.U_Renglon = U_Renglon

        If DConectarAplicacion.sCurrentCompanyDBS <> DConectarAplicacion.sBDComercial Then
            SBO_Empresa = DConectarAplicacion.sBDComercial
        End If

        Return Obj.Eliminar_Documento(Obj, SBO_Empresa)

    End Function

End Class
