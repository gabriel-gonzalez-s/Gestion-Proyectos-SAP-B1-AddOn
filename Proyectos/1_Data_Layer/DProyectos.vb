Imports SBOAddonProject1

Public Class DProyectos

    Private _U_PrjCode As String = ""
    Private _U_PrjName As String = ""
    Private _U_CardCode As String = ""
    Private _U_CardName As String = ""
    Private _U_Fec_Vta As Date = New Date(1900, 1, 1)
    Private _U_Fec_Prom As Date = New Date(1900, 1, 1)
    Private _U_Fec_Ter_Desa As Date = New Date(1900, 1, 1)
    Private _U_Fec_Ter_Prod As Date = New Date(1900, 1, 1)
    Private _U_Fec_Ini_Desp As Date = New Date(1900, 1, 1)
    Private _U_Fec_Ini_Mont As Date = New Date(1900, 1, 1)
    Private _U_Fec_Ter_Mont As Date = New Date(1900, 1, 1)
    Private _U_Multa As String = ""
    Private _U_Comentario As String = ""
    Private _U_Multa_Desp As String = ""
    Private _U_Multa_Mont As String = ""
    Private _U_Fec_Ini_Multa As Date = New Date(1900, 1, 1)
    Private _U_Poc_Multa As Double = 0.0
    Private _U_Tope_Multa As Double = 0.0
    Private _U_Frec_Multa As String = ""
    Private _U_Coment_Multa As String = ""
    Private _U_SlpCode As String = ""
    Private _U_SlpName As String = ""
    Private _U_Nro_Oport As String = ""
    Private _U_Nro_OC_Cliente As String = ""
    Private _U_DocEntry As Integer = 0
    Private _U_UserSign As Integer = 0
    Private _U_CreateDate As Date = New Date(1900, 1, 1)
    Private _U_Fec_Real_Ter_Des As Date = New Date(1900, 1, 1)
    Private _U_Fec_Real_Ini_Mon As Date = New Date(1900, 1, 1)
    Private _U_Fec_Real_Fin_Mon As Date = New Date(1900, 1, 1)
    Private _U_Contrato_Cli As String = ""
    Private _U_Estado_M As String = ""
    Private _U_Fec_Estado_M As Date = New Date(1900, 1, 1)
    Private _U_Cod_SupervM As String = ""
    Private _U_Cod_ProdM As String = ""
    Private _U_Cat_ProdM As String = ""
    Private _U_Cod_JefeM As String = ""
    Private _U_CIudadM As String = ""
    Private _U_Cod_MontM As String = ""
    Private _U_Cant_MontaM As Integer = 0
    Private _U_ObservaM As String = ""
    Private _U_Cod_MaqM As String = ""
    Private _U_Con_Montaje As Integer = 0
    Private _U_Con_Despacho As Integer = 0
    Private _U_Monto_OCC As Double = 0.0
    Private _U_Desa_Asigna As String = ""
    Private _U_Fec_Recep_Ing As Date = New Date(1900, 1, 1)
    Private _U_Usu_Recep_Ing As String = ""
    Private _U_Fec_Distri_Ing As Date = New Date(1900, 1, 1)
    Private _U_Usu_Distri_Ing As String = ""
    Private _U_Fec_Visita_Ing As Date = New Date(1900, 1, 1)
    Private _U_Usu_Visita_Ing As String = ""
    Private _U_Fec_Plano_Ing As Date = New Date(1900, 1, 1)
    Private _U_Usu_Plano_Ing As String = ""
    Private _U_Fec_Cubicacion_Ing As Date = New Date(1900, 1, 1)
    Private _U_Usu_Cubicacion_Ing As String = ""
    Private _U_Fec_Receta_Ing As Date = New Date(1900, 1, 1)
    Private _U_Usu_Receta_Ing As String = ""
    Private _U_Fec_PCV_Ing As Date = New Date(1900, 1, 1)
    Private _U_Usu_PCV_Ing As String = ""
    Private _U_Fec_OC_Ind_Ing As Date = New Date(1900, 1, 1)
    Private _U_Usu_OC_Ind_Ing As String = ""
    Private _U_Fec_OC_Mont_Ing As Date = New Date(1900, 1, 1)
    Private _U_Usu_OC_Mont_Ing As String = ""
    Private _U_Fec_Cierre_Ing As Date = New Date(1900, 1, 1)
    Private _U_Usu_Cierre_Ing As String = ""
    Private _U_Comentario_Ing As String = ""
    Private _U_Visita_Tec As String = ""
    Private _U_Pro_Ing_Entreg As String = ""
    Private _U_Usu_Entrega_Pro As String = ""
    Private _U_Mens_Montajes As String = ""
    Private _U_ColorMensaje As String = ""
    Private _U_EstadoMnsMont As String = ""
    Private _U_Fec_Real_Recep_Mon As Date = New Date(1900, 1, 1)
    Private _U_Condicion_Pago As String
    Private _U_Porc_Anticipo As Double = 0.0
    Private _U_Dias_Pago As Integer = 0
    Private _U_Medio_Pago As String
    Private _U_Monto_OCCE As Double
    Private _U_Contrato_Constru As String
    Private _U_Prj_Code_Ini As String
    Private _U_Tipo_Pryecto As String



    Public Property U_PrjCode() As String
        Get
            Return _U_PrjCode
        End Get
        Set(ByVal Value As String)
            _U_PrjCode = Value
        End Set
    End Property

    Public Property U_PrjName() As String
        Get
            Return _U_PrjName
        End Get
        Set(ByVal Value As String)
            _U_PrjName = Value
        End Set
    End Property

    Public Property U_CardCode() As String
        Get
            Return _U_CardCode
        End Get
        Set(ByVal Value As String)
            _U_CardCode = Value
        End Set
    End Property

    Public Property U_CardName() As String
        Get
            Return _U_CardName
        End Get
        Set(ByVal Value As String)
            _U_CardName = Value
        End Set
    End Property

    Public Property U_Fec_Vta() As Date
        Get
            Return _U_Fec_Vta
        End Get
        Set(ByVal Value As Date)
            _U_Fec_Vta = Value
        End Set
    End Property

    Public Property U_Fec_Prom() As Date
        Get
            Return _U_Fec_Prom
        End Get
        Set(ByVal Value As Date)
            _U_Fec_Prom = Value
        End Set
    End Property

    Public Property U_Fec_Ter_Desa() As Date
        Get
            Return _U_Fec_Ter_Desa
        End Get
        Set(ByVal Value As Date)
            _U_Fec_Ter_Desa = Value
        End Set
    End Property

    Public Property U_Fec_Ter_Prod() As Date
        Get
            Return _U_Fec_Ter_Prod
        End Get
        Set(ByVal Value As Date)
            _U_Fec_Ter_Prod = Value
        End Set
    End Property

    Public Property U_Fec_Ini_Desp() As Date
        Get
            Return _U_Fec_Ini_Desp
        End Get
        Set(ByVal Value As Date)
            _U_Fec_Ini_Desp = Value
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

    Public Property U_Multa() As String
        Get
            Return _U_Multa
        End Get
        Set(ByVal Value As String)
            _U_Multa = Value
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

    Public Property U_Multa_Desp() As String
        Get
            Return _U_Multa_Desp
        End Get
        Set(ByVal Value As String)
            _U_Multa_Desp = Value
        End Set
    End Property

    Public Property U_Multa_Mont() As String
        Get
            Return _U_Multa_Mont
        End Get
        Set(ByVal Value As String)
            _U_Multa_Mont = Value
        End Set
    End Property

    Public Property U_Fec_Ini_Multa() As Date
        Get
            Return _U_Fec_Ini_Multa
        End Get
        Set(ByVal Value As Date)
            _U_Fec_Ini_Multa = Value
        End Set
    End Property

    Public Property U_Poc_Multa() As Double
        Get
            Return _U_Poc_Multa
        End Get
        Set(ByVal Value As Double)
            _U_Poc_Multa = Value
        End Set
    End Property

    Public Property U_Tope_Multa() As Double
        Get
            Return _U_Tope_Multa
        End Get
        Set(ByVal Value As Double)
            _U_Tope_Multa = Value
        End Set
    End Property

    Public Property U_Frec_Multa() As String
        Get
            Return _U_Frec_Multa
        End Get
        Set(ByVal Value As String)
            _U_Frec_Multa = Value
        End Set
    End Property

    Public Property U_Coment_Multa() As String
        Get
            Return _U_Coment_Multa
        End Get
        Set(ByVal Value As String)
            _U_Coment_Multa = Value
        End Set
    End Property

    Public Property U_SlpCode() As String
        Get
            Return _U_SlpCode
        End Get
        Set(ByVal Value As String)
            _U_SlpCode = Value
        End Set
    End Property

    Public Property U_SlpName() As String
        Get
            Return _U_SlpName
        End Get
        Set(ByVal Value As String)
            _U_SlpName = Value
        End Set
    End Property

    Public Property U_Nro_Oport() As String
        Get
            Return _U_Nro_Oport
        End Get
        Set(ByVal Value As String)
            _U_Nro_Oport = Value
        End Set
    End Property

    Public Property U_Nro_OC_Cliente() As String
        Get
            Return _U_Nro_OC_Cliente
        End Get
        Set(ByVal Value As String)
            _U_Nro_OC_Cliente = Value
        End Set
    End Property

    Public Property U_DocEntry() As Integer
        Get
            Return _U_DocEntry
        End Get
        Set(ByVal Value As Integer)
            _U_DocEntry = Value
        End Set
    End Property

    Public Property U_UserSign() As Integer
        Get
            Return _U_UserSign
        End Get
        Set(ByVal Value As Integer)
            _U_UserSign = Value
        End Set
    End Property

    Public Property U_CreateDate() As Date
        Get
            Return _U_CreateDate
        End Get
        Set(ByVal Value As Date)
            _U_CreateDate = Value
        End Set
    End Property

    Public Property U_Fec_Real_Ter_Des() As Date
        Get
            Return _U_Fec_Real_Ter_Des
        End Get
        Set(ByVal Value As Date)
            _U_Fec_Real_Ter_Des = Value
        End Set
    End Property

    Public Property U_Fec_Real_Ini_Mon() As Date
        Get
            Return _U_Fec_Real_Ini_Mon
        End Get
        Set(ByVal Value As Date)
            _U_Fec_Real_Ini_Mon = Value
        End Set
    End Property

    Public Property U_Fec_Real_Fin_Mon() As Date
        Get
            Return _U_Fec_Real_Fin_Mon
        End Get
        Set(ByVal Value As Date)
            _U_Fec_Real_Fin_Mon = Value
        End Set
    End Property

    Public Property U_Contrato_Cli() As String
        Get
            Return _U_Contrato_Cli
        End Get
        Set(ByVal Value As String)
            _U_Contrato_Cli = Value
        End Set
    End Property

    Public Property U_Estado_M() As String
        Get
            Return _U_Estado_M
        End Get
        Set(ByVal Value As String)
            _U_Estado_M = Value
        End Set
    End Property

    Public Property U_Fec_Estado_M() As Date
        Get
            Return _U_Fec_Estado_M
        End Get
        Set(ByVal Value As Date)
            _U_Fec_Estado_M = Value
        End Set
    End Property

    Public Property U_Cod_SupervM() As String
        Get
            Return _U_Cod_SupervM
        End Get
        Set(ByVal Value As String)
            _U_Cod_SupervM = Value
        End Set
    End Property

    Public Property U_Cod_ProdM() As String
        Get
            Return _U_Cod_ProdM
        End Get
        Set(ByVal Value As String)
            _U_Cod_ProdM = Value
        End Set
    End Property

    Public Property U_Cat_ProdM() As String
        Get
            Return _U_Cat_ProdM
        End Get
        Set(ByVal Value As String)
            _U_Cat_ProdM = Value
        End Set
    End Property

    Public Property U_Cod_JefeM() As String
        Get
            Return _U_Cod_JefeM
        End Get
        Set(ByVal Value As String)
            _U_Cod_JefeM = Value
        End Set
    End Property

    Public Property U_CIudadM() As String
        Get
            Return _U_CIudadM
        End Get
        Set(ByVal Value As String)
            _U_CIudadM = Value
        End Set
    End Property

    Public Property U_Cod_MontM() As String
        Get
            Return _U_Cod_MontM
        End Get
        Set(ByVal Value As String)
            _U_Cod_MontM = Value
        End Set
    End Property

    Public Property U_Cant_MontaM() As Integer
        Get
            Return _U_Cant_MontaM
        End Get
        Set(ByVal Value As Integer)
            _U_Cant_MontaM = Value
        End Set
    End Property

    Public Property U_ObservaM() As String
        Get
            Return _U_ObservaM
        End Get
        Set(ByVal Value As String)
            _U_ObservaM = Value
        End Set
    End Property

    Public Property U_Cod_MaqM() As String
        Get
            Return _U_Cod_MaqM
        End Get
        Set(ByVal Value As String)
            _U_Cod_MaqM = Value
        End Set
    End Property

    Public Property U_Con_Montaje() As Integer
        Get
            Return _U_Con_Montaje
        End Get
        Set(ByVal Value As Integer)
            _U_Con_Montaje = Value
        End Set
    End Property

    Public Property U_Con_Despacho() As Integer
        Get
            Return _U_Con_Despacho
        End Get
        Set(ByVal Value As Integer)
            _U_Con_Despacho = Value
        End Set
    End Property

    Public Property U_Monto_OCC() As Double
        Get
            Return _U_Monto_OCC
        End Get
        Set(ByVal Value As Double)
            _U_Monto_OCC = Value
        End Set
    End Property

    Public Property U_Desa_Asigna() As String
        Get
            Return _U_Desa_Asigna
        End Get
        Set(ByVal Value As String)
            _U_Desa_Asigna = Value
        End Set
    End Property

    Public Property U_Fec_Recep_Ing() As Date
        Get
            Return _U_Fec_Recep_Ing
        End Get
        Set(ByVal Value As Date)
            _U_Fec_Recep_Ing = Value
        End Set
    End Property

    Public Property U_Usu_Recep_Ing() As String
        Get
            Return _U_Usu_Recep_Ing
        End Get
        Set(ByVal Value As String)
            _U_Usu_Recep_Ing = Value
        End Set
    End Property

    Public Property U_Fec_Distri_Ing() As Date
        Get
            Return _U_Fec_Distri_Ing
        End Get
        Set(ByVal Value As Date)
            _U_Fec_Distri_Ing = Value
        End Set
    End Property

    Public Property U_Usu_Distri_Ing() As String
        Get
            Return _U_Usu_Distri_Ing
        End Get
        Set(ByVal Value As String)
            _U_Usu_Distri_Ing = Value
        End Set
    End Property

    Public Property U_Fec_Visita_Ing() As Date
        Get
            Return _U_Fec_Visita_Ing
        End Get
        Set(ByVal Value As Date)
            _U_Fec_Visita_Ing = Value
        End Set
    End Property

    Public Property U_Usu_Visita_Ing() As String
        Get
            Return _U_Usu_Visita_Ing
        End Get
        Set(ByVal Value As String)
            _U_Usu_Visita_Ing = Value
        End Set
    End Property

    Public Property U_Fec_Plano_Ing() As Date
        Get
            Return _U_Fec_Plano_Ing
        End Get
        Set(ByVal Value As Date)
            _U_Fec_Plano_Ing = Value
        End Set
    End Property

    Public Property U_Usu_Plano_Ing() As String
        Get
            Return _U_Usu_Plano_Ing
        End Get
        Set(ByVal Value As String)
            _U_Usu_Plano_Ing = Value
        End Set
    End Property

    Public Property U_Fec_Cubicacion_Ing() As Date
        Get
            Return _U_Fec_Cubicacion_Ing
        End Get
        Set(ByVal Value As Date)
            _U_Fec_Cubicacion_Ing = Value
        End Set
    End Property

    Public Property U_Usu_Cubicacion_Ing() As String
        Get
            Return _U_Usu_Cubicacion_Ing
        End Get
        Set(ByVal Value As String)
            _U_Usu_Cubicacion_Ing = Value
        End Set
    End Property

    Public Property U_Fec_Receta_Ing() As Date
        Get
            Return _U_Fec_Receta_Ing
        End Get
        Set(ByVal Value As Date)
            _U_Fec_Receta_Ing = Value
        End Set
    End Property

    Public Property U_Usu_Receta_Ing() As String
        Get
            Return _U_Usu_Receta_Ing
        End Get
        Set(ByVal Value As String)
            _U_Usu_Receta_Ing = Value
        End Set
    End Property

    Public Property U_Fec_PCV_Ing() As Date
        Get
            Return _U_Fec_PCV_Ing
        End Get
        Set(ByVal Value As Date)
            _U_Fec_PCV_Ing = Value
        End Set
    End Property

    Public Property U_Usu_PCV_Ing() As String
        Get
            Return _U_Usu_PCV_Ing
        End Get
        Set(ByVal Value As String)
            _U_Usu_PCV_Ing = Value
        End Set
    End Property

    Public Property U_Fec_OC_Ind_Ing() As Date
        Get
            Return _U_Fec_OC_Ind_Ing
        End Get
        Set(ByVal Value As Date)
            _U_Fec_OC_Ind_Ing = Value
        End Set
    End Property

    Public Property U_Usu_OC_Ind_Ing() As String
        Get
            Return _U_Usu_OC_Ind_Ing
        End Get
        Set(ByVal Value As String)
            _U_Usu_OC_Ind_Ing = Value
        End Set
    End Property

    Public Property U_Fec_OC_Mont_Ing() As Date
        Get
            Return _U_Fec_OC_Mont_Ing
        End Get
        Set(ByVal Value As Date)
            _U_Fec_OC_Mont_Ing = Value
        End Set
    End Property

    Public Property U_Usu_OC_Mont_Ing() As String
        Get
            Return _U_Usu_OC_Mont_Ing
        End Get
        Set(ByVal Value As String)
            _U_Usu_OC_Mont_Ing = Value
        End Set
    End Property

    Public Property U_Fec_Cierre_Ing() As Date
        Get
            Return _U_Fec_Cierre_Ing
        End Get
        Set(ByVal Value As Date)
            _U_Fec_Cierre_Ing = Value
        End Set
    End Property

    Public Property U_Usu_Cierre_Ing() As String
        Get
            Return _U_Usu_Cierre_Ing
        End Get
        Set(ByVal Value As String)
            _U_Usu_Cierre_Ing = Value
        End Set
    End Property

    Public Property U_Comentario_Ing() As String
        Get
            Return _U_Comentario_Ing
        End Get
        Set(ByVal Value As String)
            _U_Comentario_Ing = Value
        End Set
    End Property

    Public Property U_Visita_Tec() As String
        Get
            Return _U_Visita_Tec
        End Get
        Set(ByVal Value As String)
            _U_Visita_Tec = Value
        End Set
    End Property

    Public Property U_Pro_Ing_Entreg() As String
        Get
            Return _U_Pro_Ing_Entreg
        End Get
        Set(ByVal Value As String)
            _U_Pro_Ing_Entreg = Value
        End Set
    End Property

    Public Property U_Usu_Entrega_Pro() As String
        Get
            Return _U_Usu_Entrega_Pro
        End Get
        Set(ByVal Value As String)
            _U_Usu_Entrega_Pro = Value
        End Set
    End Property

    Public Property U_Mens_Montajes() As String
        Get
            Return _U_Mens_Montajes
        End Get
        Set(ByVal Value As String)
            _U_Mens_Montajes = Value
        End Set
    End Property

    Public Property U_ColorMensaje() As String
        Get
            Return _U_ColorMensaje
        End Get
        Set(ByVal Value As String)
            _U_ColorMensaje = Value
        End Set
    End Property

    Public Property U_EstadoMnsMont() As String
        Get
            Return _U_EstadoMnsMont
        End Get
        Set(ByVal Value As String)
            _U_EstadoMnsMont = Value
        End Set
    End Property

    Public Property U_Fec_Real_Recep_Mon() As Date
        Get
            Return _U_Fec_Real_Recep_Mon
        End Get
        Set(ByVal Value As Date)
            _U_Fec_Real_Recep_Mon = Value
        End Set
    End Property

    Public Property U_Condicion_Pago() As String
        Get
            Return _U_Condicion_Pago
        End Get
        Set(ByVal value As String)
            _U_Condicion_Pago = value
        End Set
    End Property

    Public Property U_Porc_Anticipo As Double
        Get
            Return _U_Porc_Anticipo
        End Get
        Set(value As Double)
            _U_Porc_Anticipo = value
        End Set
    End Property

    Public Property U_Dias_Pago As Integer
        Get
            Return _U_Dias_Pago
        End Get
        Set(value As Integer)
            _U_Dias_Pago = value
        End Set
    End Property

    Public Property U_Medio_Pago As String
        Get
            Return _U_Medio_Pago
        End Get
        Set(value As String)
            _U_Medio_Pago = value
        End Set
    End Property

    Public Property U_Monto_OCCE() As Double
        Get
            Return _U_Monto_OCCE
        End Get
        Set(ByVal value As Double)
            _U_Monto_OCCE = value
        End Set
    End Property

    Public Property U_Contrato_Constru As String
        Get
            Return _U_Contrato_Constru
        End Get
        Set(value As String)
            _U_Contrato_Constru = value
        End Set
    End Property

    Public Property U_Prj_Code_Ini As String
        Get
            Return _U_Prj_Code_Ini
        End Get
        Set(value As String)
            _U_Prj_Code_Ini = value
        End Set
    End Property

    Public Property U_Tipo_Pryecto As String
        Get
            Return _U_Tipo_Pryecto
        End Get
        Set(value As String)
            _U_Tipo_Pryecto = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(U_PrjCode As String, U_PrjName As String, U_CardCode As String, U_CardName As String, ByVal U_Fec_Vta As Date, U_Fec_Prom As Date, U_Fec_Ter_Desa As Date, U_Fec_Ter_Prod As Date, U_Fec_Ini_Desp As Date, U_Fec_Ini_Mont As Date, U_Fec_Ter_Mont As Date, U_Multa As String, U_Comentario As String, U_Multa_Desp As String, U_Multa_Mont As String, U_Fec_Ini_Multa As Date, U_Poc_Multa As Double, U_Tope_Multa As Double, U_Frec_Multa As String, U_Coment_Multa As String, U_SlpCode As String, U_SlpName As String, U_Nro_Oport As String, U_Nro_OC_Cliente As String, U_DocEntry As Integer, U_UserSign As Integer, U_CreateDate As Date, U_Fec_Real_Ter_Des As Date, U_Fec_Real_Ini_Mon As Date, U_Fec_Real_Fin_Mon As Date, U_Contrato_Cli As String, U_Estado_M As String, U_Fec_Estado_M As Date, U_Cod_SupervM As String, U_Cod_ProdM As String, U_Cat_ProdM As String, U_Cod_JefeM As String, U_CIudadM As String, U_Cod_MontM As String, U_Cant_MontaM As Integer, U_ObservaM As String, U_Cod_MaqM As String, U_Con_Montaje As Integer, U_Con_Despacho As Integer, U_Monto_OCC As Double, U_Desa_Asigna As String, U_Fec_Recep_Ing As Date, U_Usu_Recep_Ing As String, U_Fec_Distri_Ing As Date, U_Usu_Distri_Ing As String, U_Fec_Visita_Ing As Date, U_Usu_Visita_Ing As String, U_Fec_Plano_Ing As Date, U_Usu_Plano_Ing As String, U_Fec_Cubicacion_Ing As Date, U_Usu_Cubicacion_Ing As String, U_Fec_Receta_Ing As Date, U_Usu_Receta_Ing As String, U_Fec_PCV_Ing As Date, U_Usu_PCV_Ing As String, U_Fec_OC_Ind_Ing As Date, U_Usu_OC_Ind_Ing As String, U_Fec_OC_Mont_Ing As Date, U_Usu_OC_Mont_Ing As String, U_Fec_Cierre_Ing As Date, U_Usu_Cierre_Ing As String, U_Comentario_Ing As String, U_Visita_Tec As String, U_Pro_Ing_Entreg As String, U_Usu_Entrega_Pro As String, U_Mens_Montajes As String, U_ColorMensaje As String, U_EstadoMnsMont As String, U_Fec_Real_Recep_Mon As Date)
        Me.U_PrjCode = U_PrjCode
        Me.U_PrjName = U_PrjName
        Me.U_CardCode = U_CardCode
        Me.U_CardName = U_CardName
        Me.U_Fec_Vta = U_Fec_Vta
        Me.U_Fec_Prom = U_Fec_Prom
        Me.U_Fec_Ter_Desa = U_Fec_Ter_Desa
        Me.U_Fec_Ter_Prod = U_Fec_Ter_Prod
        Me.U_Fec_Ini_Desp = U_Fec_Ini_Desp
        Me.U_Fec_Ini_Mont = U_Fec_Ini_Mont
        Me.U_Fec_Ter_Mont = U_Fec_Ter_Mont
        Me.U_Multa = U_Multa
        Me.U_Comentario = U_Comentario
        Me.U_Multa_Desp = U_Multa_Desp
        Me.U_Multa_Mont = U_Multa_Mont
        Me.U_Fec_Ini_Multa = U_Fec_Ini_Multa
        Me.U_Poc_Multa = U_Poc_Multa
        Me.U_Tope_Multa = U_Tope_Multa
        Me.U_Frec_Multa = U_Frec_Multa
        Me.U_Coment_Multa = U_Coment_Multa
        Me.U_SlpCode = U_SlpCode
        Me.U_SlpName = U_SlpName
        Me.U_Nro_Oport = U_Nro_Oport
        Me.U_Nro_OC_Cliente = U_Nro_OC_Cliente
        Me.U_DocEntry = U_DocEntry
        Me.U_UserSign = U_UserSign
        Me.U_CreateDate = U_CreateDate
        Me.U_Fec_Real_Ter_Des = U_Fec_Real_Ter_Des
        Me.U_Fec_Real_Ini_Mon = U_Fec_Real_Ini_Mon
        Me.U_Fec_Real_Fin_Mon = U_Fec_Real_Fin_Mon
        Me.U_Contrato_Cli = U_Contrato_Cli
        Me.U_Estado_M = U_Estado_M
        Me.U_Fec_Estado_M = U_Fec_Estado_M
        Me.U_Cod_SupervM = U_Cod_SupervM
        Me.U_Cod_ProdM = U_Cod_ProdM
        Me.U_Cat_ProdM = U_Cat_ProdM
        Me.U_Cod_JefeM = U_Cod_JefeM
        Me.U_CIudadM = U_CIudadM
        Me.U_Cod_MontM = U_Cod_MontM
        Me.U_Cant_MontaM = U_Cant_MontaM
        Me.U_ObservaM = U_ObservaM
        Me.U_Cod_MaqM = U_Cod_MaqM
        Me.U_Con_Montaje = U_Con_Montaje
        Me.U_Con_Despacho = U_Con_Despacho
        Me.U_Monto_OCC = U_Monto_OCC
        Me.U_Desa_Asigna = U_Desa_Asigna
        Me.U_Fec_Recep_Ing = U_Fec_Recep_Ing
        Me.U_Usu_Recep_Ing = U_Usu_Recep_Ing
        Me.U_Fec_Distri_Ing = U_Fec_Distri_Ing
        Me.U_Usu_Distri_Ing = U_Usu_Distri_Ing
        Me.U_Fec_Visita_Ing = U_Fec_Visita_Ing
        Me.U_Usu_Visita_Ing = U_Usu_Visita_Ing
        Me.U_Fec_Plano_Ing = U_Fec_Plano_Ing
        Me.U_Usu_Plano_Ing = U_Usu_Plano_Ing
        Me.U_Fec_Cubicacion_Ing = U_Fec_Cubicacion_Ing
        Me.U_Usu_Cubicacion_Ing = U_Usu_Cubicacion_Ing
        Me.U_Fec_Receta_Ing = U_Fec_Receta_Ing
        Me.U_Usu_Receta_Ing = U_Usu_Receta_Ing
        Me.U_Fec_PCV_Ing = U_Fec_PCV_Ing
        Me.U_Usu_PCV_Ing = U_Usu_PCV_Ing
        Me.U_Fec_OC_Ind_Ing = U_Fec_OC_Ind_Ing
        Me.U_Usu_OC_Ind_Ing = U_Usu_OC_Ind_Ing
        Me.U_Fec_OC_Mont_Ing = U_Fec_OC_Mont_Ing
        Me.U_Usu_OC_Mont_Ing = U_Usu_OC_Mont_Ing
        Me.U_Fec_Cierre_Ing = U_Fec_Cierre_Ing
        Me.U_Usu_Cierre_Ing = U_Usu_Cierre_Ing
        Me.U_Comentario_Ing = U_Comentario_Ing
        Me.U_Visita_Tec = U_Visita_Tec
        Me.U_Pro_Ing_Entreg = U_Pro_Ing_Entreg
        Me.U_Usu_Entrega_Pro = U_Usu_Entrega_Pro
        Me.U_Mens_Montajes = U_Mens_Montajes
        Me.U_ColorMensaje = U_ColorMensaje
        Me.U_EstadoMnsMont = U_EstadoMnsMont
        Me.U_Fec_Real_Recep_Mon = U_Fec_Real_Recep_Mon
    End Sub

    Public Function InsertarProyecto(Proyecto As DProyectos) As String

        Dim DetalleObjeto As New List(Of Object)

        Dim rpta As String = "N"

        Try
            rpta = FuncionesUDO.InsertRecord("ZINFOP", Proyecto, "", DetalleObjeto)
        Catch ex As Exception
        End Try

        Return rpta

    End Function

    Public Function CargarProyecto(Proyecto As DProyectos, CodigoProyecto As String) As String

        Dim rpta As String = "N"
        'get company service
        Try
            rpta = FuncionesUDO.LoadObjectInfoFromRecordset(Proyecto, "@ZINFOP", " Where U_PrjCode = '" + CodigoProyecto + "'")
        Catch ex As Exception
        End Try

        Return rpta

    End Function




End Class
