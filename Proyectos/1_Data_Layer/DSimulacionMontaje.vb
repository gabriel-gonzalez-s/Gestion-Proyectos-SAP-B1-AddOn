Imports SBOAddonProject1

Public Class DSimulacionMontaje


    Private _U_PrjCode As String = ""
    Private _U_Fec_Ini_Mont As Date = Date.Now
    Private _U_Fec_Ter_Mont As Date = Date.Now
    Private _U_Cod_Usuario As String = ""
    Private _U_Nom_Usuario As String = ""
    Private _U_Fec_Registro As Date = Date.Now
    Private _U_Hora_Registro As String = ""
    Private _U_Cod_Estado_Prj As String = ""
    Private _U_NumeroPCV As String = ""

    Public Property U_PrjCode() As String
        Get
            Return _U_PrjCode
        End Get
        Set(ByVal Value As String)
            _U_PrjCode = Value
        End Set
    End Property

    Public Property U_Fec_Ini_Mont() As Date
        Get
            Return _U_Fec_Ini_Mont
        End Get
        Set(ByVal Value As Date)
            _U_Fec_Ini_Mont = Value
        End Set
    End Property

    Public Property U_Fec_Ter_Mont() As Date
        Get
            Return _U_Fec_Ter_Mont
        End Get
        Set(ByVal Value As Date)
            _U_Fec_Ter_Mont = Value
        End Set
    End Property

    Public Property U_Cod_Usuario() As String
        Get
            Return _U_Cod_Usuario
        End Get
        Set(ByVal Value As String)
            _U_Cod_Usuario = Value
        End Set
    End Property

    Public Property U_Nom_Usuario() As String
        Get
            Return _U_Nom_Usuario
        End Get
        Set(ByVal Value As String)
            _U_Nom_Usuario = Value
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

    Public Property U_Cod_Estado_Prj() As String
        Get
            Return _U_Cod_Estado_Prj
        End Get
        Set(ByVal Value As String)
            _U_Cod_Estado_Prj = Value
        End Set
    End Property

    Public Property U_NumeroPCV() As String
        Get
            Return _U_NumeroPCV
        End Get
        Set(ByVal Value As String)
            _U_NumeroPCV = Value
        End Set
    End Property

    Sub New()
    End Sub

    Sub New(U_PrjCode As String, U_Fec_Ini_Mont As Date, U_Fec_Ter_Mont As Date, U_Cod_Usuario As String, U_Nom_Usuario As String, U_Fec_Registro As Date, U_Hora_Registro As String, U_Cod_Estado_Prj As String, U_NumeroPCV As String)
        Me.U_PrjCode = U_PrjCode
        Me.U_Fec_Ini_Mont = U_Fec_Ini_Mont
        Me.U_Fec_Ter_Mont = U_Fec_Ter_Mont
        Me.U_Cod_Usuario = U_Cod_Usuario
        Me.U_Nom_Usuario = U_Nom_Usuario
        Me.U_Fec_Registro = U_Fec_Registro
        Me.U_Hora_Registro = U_Hora_Registro
        Me.U_Cod_Estado_Prj = U_Cod_Estado_Prj
        Me.U_NumeroPCV = U_NumeroPCV
    End Sub

    Public Function InsertarHistoricoMontaje(Historico As DSimulacionMontaje) As String

        Dim DetalleObjeto As New List(Of Object)

        Dim rpta As String = "N"

        Try
            rpta = FuncionesUDO.InsertRecord("ZHFSMON", Historico, "", DetalleObjeto)
        Catch ex As Exception
        End Try

        Return rpta


    End Function

    Public Function ModificarDatosMontajes(InfoMontaje As DProyectos, CodigoArchivo As String) As String

        Dim DetalleObjeto As New List(Of Object)

        Dim rpta As String = "N"

        Try
            rpta = FuncionesUDO.UpdateRecordHead("ZINFOP", InfoMontaje, CodigoArchivo)
        Catch ex As Exception
        End Try

        Return rpta


    End Function


End Class
