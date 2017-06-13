Imports SBOAddonProject1

Public Class NSimulacionMontaje

    Public Shared Function InsertarHistoricoMontaje(U_PrjCode As String, U_Fec_Ini_Mont As Date, U_Fec_Ter_Mont As Date, U_Cod_Usuario As String, U_Nom_Usuario As String, U_Fec_Registro As Date, U_Hora_Registro As String, U_Cod_Estado_Prj As String, U_NumeroPCV As String) As String

        Dim Obj As New DSimulacionMontaje()

        Obj.U_PrjCode = U_PrjCode
        Obj.U_Fec_Ini_Mont = U_Fec_Ini_Mont
        Obj.U_Fec_Ter_Mont = U_Fec_Ter_Mont
        Obj.U_Cod_Usuario = U_Cod_Usuario
        Obj.U_Nom_Usuario = U_Nom_Usuario
        Obj.U_Fec_Registro = U_Fec_Registro
        Obj.U_Hora_Registro = U_Hora_Registro
        Obj.U_Cod_Estado_Prj = U_Cod_Estado_Prj
        Obj.U_NumeroPCV = U_NumeroPCV

        Return Obj.InsertarHistoricoMontaje(Obj)

    End Function

End Class
