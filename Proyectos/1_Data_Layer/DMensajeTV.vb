Public Class DMensajeTV

    Private _U_Texto As String = ""
    Private _U_FecInicio As Date = Date.Now
    Private _U_HoraInicio As Integer = 0
    Private _U_FecFinal As Date = Date.Now
    Private _U_HoraFinal As Integer = 0

    Public Property U_Texto() As String
        Get
            Return _U_Texto
        End Get
        Set(ByVal Value As String)
            _U_Texto = Value
        End Set
    End Property

    Public Property U_FecInicio() As Date
        Get
            Return _U_FecInicio
        End Get
        Set(ByVal Value As Date)
            _U_FecInicio = Value
        End Set
    End Property

    Public Property U_HoraInicio() As Integer
        Get
            Return _U_HoraInicio
        End Get
        Set(ByVal Value As Integer)
            _U_HoraInicio = Value
        End Set
    End Property

    Public Property U_FecFinal() As Date
        Get
            Return _U_FecFinal
        End Get
        Set(ByVal Value As Date)
            _U_FecFinal = Value
        End Set
    End Property

    Public Property U_HoraFinal() As Integer
        Get
            Return _U_HoraFinal
        End Get
        Set(ByVal Value As Integer)
            _U_HoraFinal = Value
        End Set
    End Property

    Sub New()
    End Sub

    Sub New(ByVal U_Texto As String, ByVal U_FecInicio As Date, ByVal U_HoraInicio As Integer, ByVal U_FecFinal As Date, ByVal U_HoraFinal As Integer)

        Me.U_Texto = U_Texto
        Me.U_FecInicio = U_FecInicio
        Me.U_HoraInicio = U_HoraInicio
        Me.U_FecFinal = U_FecFinal
        Me.U_HoraFinal = U_HoraFinal
    End Sub



End Class
