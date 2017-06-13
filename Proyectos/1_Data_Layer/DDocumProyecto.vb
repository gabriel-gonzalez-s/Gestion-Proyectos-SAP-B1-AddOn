Public Class DDocumProyecto

    Public Shared oCompany As SAPbobsCOM.Company = DConectarAplicacion.oCompanyPS

    Private _U_PrjCode As String = ""
    Private _U_PathOrigen As String = ""
    Private _U_PtahServer As String = ""
    Private _U_Fec_Registro As Date = Date.Now
    Private _U_Hora_Registro As String = ""
    Private _U_User_Id As String = ""
    Private _U_Tipo_Plano As String = ""
    Private _U_Comentario As String = ""
    Private _U_Status As String = ""
    Private _U_Tipo_Documento As String = ""
    Private _U_Renglon As Integer = 0

    Public Property U_PrjCode() As String
        Get
            Return _U_PrjCode
        End Get
        Set(ByVal Value As String)
            _U_PrjCode = Value
        End Set
    End Property

    Public Property U_PathOrigen() As String
        Get
            Return _U_PathOrigen
        End Get
        Set(ByVal Value As String)
            _U_PathOrigen = Value
        End Set
    End Property

    Public Property U_PtahServer() As String
        Get
            Return _U_PtahServer
        End Get
        Set(ByVal Value As String)
            _U_PtahServer = Value
        End Set
    End Property

    Public Property U_Fec_Registro() As Date
        Get
            Return _U_Fec_Registro
        End Get
        Set(ByVal Value As Date)
            _U_Fec_Registro = Value
        End Set
    End Property

    Public Property U_Hora_Registro() As String
        Get
            Return _U_Hora_Registro
        End Get
        Set(ByVal Value As String)
            _U_Hora_Registro = Value
        End Set
    End Property

    Public Property U_User_Id() As String
        Get
            Return _U_User_Id
        End Get
        Set(ByVal Value As String)
            _U_User_Id = Value
        End Set
    End Property

    Public Property U_Tipo_Plano() As String
        Get
            Return _U_Tipo_Plano
        End Get
        Set(ByVal Value As String)
            _U_Tipo_Plano = Value
        End Set
    End Property

    Public Property U_Comentario() As String
        Get
            Return _U_Comentario
        End Get
        Set(ByVal Value As String)
            _U_Comentario = Value
        End Set
    End Property

    Public Property U_Status() As String
        Get
            Return _U_Status
        End Get
        Set(ByVal Value As String)
            _U_Status = Value
        End Set
    End Property

    Public Property U_Tipo_Documento() As String
        Get
            Return _U_Tipo_Documento
        End Get
        Set(ByVal Value As String)
            _U_Tipo_Documento = Value
        End Set
    End Property

    Public Property U_Renglon() As Integer
        Get
            Return _U_Renglon
        End Get
        Set(ByVal Value As Integer)
            _U_Renglon = Value
        End Set
    End Property

    Sub New()
    End Sub

    Sub New(U_PrjCode As String, U_PathOrigen As String, U_PtahServer As String, U_Fec_Registro As Date, U_Hora_Registro As String, U_User_Id As String, U_Tipo_Plano As String, U_Comentario As String, U_Status As String, U_Tipo_Documento As String, U_Renglon As Integer)
        Me.U_PrjCode = U_PrjCode
        Me.U_PathOrigen = U_PathOrigen
        Me.U_PtahServer = U_PtahServer
        Me.U_Fec_Registro = U_Fec_Registro
        Me.U_Hora_Registro = U_Hora_Registro
        Me.U_User_Id = U_User_Id
        Me.U_Tipo_Plano = U_Tipo_Plano
        Me.U_Comentario = U_Comentario
        Me.U_Status = U_Status
        Me.U_Tipo_Documento = U_Tipo_Documento
        Me.U_Renglon = U_Renglon
    End Sub

    Public Function Insertar_Documento(Documento As DDocumProyecto, Optional SBO_Empresa As String = "") As String
        Dim rpta As String = "N"

        Try
            rpta = FuncionesUDT.InsertRecord("ZPLAP", Documento, SBO_Empresa)
        Catch ex As Exception
        End Try

        Return rpta
    End Function

    Public Function Modificar_Documento(Documento As DDocumProyecto, Optional SBO_Empresa As String = "") As String
        Dim rpta As String = "N"

        Try
            Dim oCode As String = CodigoObjeto(Documento, SBO_Empresa)
            rpta = FuncionesUDT.UpdateRecord("ZPLAP", Documento, oCode, SBO_Empresa)
        Catch ex As Exception
        End Try

        Return rpta
    End Function

    Public Function Eliminar_Documento(Documento As DDocumProyecto, Optional SBO_Empresa As String = "") As String
        Dim rpta As String = "N"

        Try
            Dim oCode As String = CodigoObjeto(Documento, SBO_Empresa)
            rpta = FuncionesUDT.DeleteRecord("ZPLAP", oCode, SBO_Empresa)
        Catch ex As Exception
        End Try

        Return rpta
    End Function

    Private Function CodigoObjeto(Documento As DDocumProyecto, Optional SBO_Empresa As String = "") As String
        Dim rpta As String = "N"

        Try
            Dim sCondi As String = " WHERE [U_PrjCode] = '" + Documento.U_PrjCode + "' AND [U_Renglon] = '" + Documento.U_Renglon.ToString + "'"

            rpta = FuncionesUDT.GetCodeUDT("ZPLAP", sCondi, SBO_Empresa)
        Catch ex As Exception
        End Try

        Return rpta
    End Function



End Class
