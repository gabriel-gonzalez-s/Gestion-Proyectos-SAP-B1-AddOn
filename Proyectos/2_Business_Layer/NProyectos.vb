Imports SBOAddonProject1

Public Class NProyectos

    Public Shared Function InsertarProyectoBase(U_PrjCode As String, U_PrjName As String, U_CardCode As String, U_CardName As String, ByVal U_Fec_Vta As Date,
                                            U_Fec_Prom As Date, U_Fec_Ter_Desa As Date, U_Fec_Ter_Prod As Date, U_Fec_Ini_Desp As Date, U_Fec_Ini_Mont As Date,
                                            U_Fec_Ter_Mont As Date, U_Multa As String, U_Comentario As String, U_Multa_Desp As String, U_Multa_Mont As String,
                                            U_Fec_Ini_Multa As Date, U_Poc_Multa As Double, U_Tope_Multa As Double, U_Frec_Multa As String, U_Coment_Multa As String,
                                            U_SlpCode As String, U_SlpName As String, U_Nro_Oport As String, U_Nro_OC_Cliente As String, U_DocEntry As Integer,
                                            U_UserSign As Integer, U_CreateDate As Date, U_Contrato_Cli As String, U_Con_Montaje As Integer, U_Con_Despacho As Integer,
                                            U_Monto_OCC As Double, U_Desa_Asigna As String, U_Pro_Ing_Entreg As String, U_Condicion_Pago As String, U_Porc_Anticipo As Double,
                                            U_Dias_Pago As Integer, U_Medio_Pago As String, U_Monto_OCCE As Double, U_Contrato_Constru As String, U_Prj_Code_Ini As String,
                                            U_Tipo_Pryecto As String) As String

        Dim Obj As New DProyectos()
        Obj.U_PrjCode = U_PrjCode
        Obj.U_PrjName = U_PrjName
        Obj.U_CardCode = U_CardCode
        Obj.U_CardName = U_CardName
        Obj.U_Fec_Vta = U_Fec_Vta
        Obj.U_Fec_Prom = U_Fec_Prom
        Obj.U_Fec_Ter_Desa = U_Fec_Ter_Desa
        Obj.U_Fec_Ter_Prod = U_Fec_Ter_Prod
        Obj.U_Fec_Ini_Desp = U_Fec_Ini_Desp
        Obj.U_Fec_Ini_Mont = U_Fec_Ini_Mont
        Obj.U_Fec_Ter_Mont = U_Fec_Ter_Mont
        Obj.U_Multa = U_Multa
        Obj.U_Comentario = U_Comentario
        Obj.U_Multa_Desp = U_Multa_Desp
        Obj.U_Multa_Mont = U_Multa_Mont
        Obj.U_Fec_Ini_Multa = U_Fec_Ini_Multa
        Obj.U_Poc_Multa = U_Poc_Multa
        Obj.U_Tope_Multa = U_Tope_Multa
        Obj.U_Frec_Multa = U_Frec_Multa
        Obj.U_Coment_Multa = U_Coment_Multa
        Obj.U_SlpCode = U_SlpCode
        Obj.U_SlpName = U_SlpName
        Obj.U_Nro_Oport = U_Nro_Oport
        Obj.U_Nro_OC_Cliente = U_Nro_OC_Cliente
        Obj.U_DocEntry = U_DocEntry
        Obj.U_UserSign = U_UserSign
        Obj.U_CreateDate = U_CreateDate
        Obj.U_Contrato_Cli = U_Contrato_Cli
        Obj.U_Con_Montaje = U_Con_Montaje
        Obj.U_Con_Despacho = U_Con_Despacho
        Obj.U_Monto_OCC = U_Monto_OCC
        Obj.U_Desa_Asigna = U_Desa_Asigna
        Obj.U_Pro_Ing_Entreg = U_Pro_Ing_Entreg
        Obj.U_Condicion_Pago = U_Condicion_Pago
        Obj.U_Porc_Anticipo = U_Porc_Anticipo
        Obj.U_Dias_Pago = U_Dias_Pago
        Obj.U_Medio_Pago = U_Medio_Pago
        Obj.U_Monto_OCCE = U_Monto_OCCE
        Obj.U_Contrato_Constru = U_Contrato_Constru
        Obj.U_Prj_Code_Ini = U_Prj_Code_Ini
        Obj.U_Tipo_Pryecto = U_Tipo_Pryecto

        Return Obj.InsertarProyecto(Obj)

    End Function

    Public Shared Function InsertarProyectoCompleto(U_PrjCode As String, U_PrjName As String, U_CardCode As String, U_CardName As String, ByVal U_Fec_Vta As Date,
                                            U_Fec_Prom As Date, U_Fec_Ter_Desa As Date, U_Fec_Ter_Prod As Date, U_Fec_Ini_Desp As Date, U_Fec_Ini_Mont As Date,
                                            U_Fec_Ter_Mont As Date, U_Multa As String, U_Comentario As String, U_Multa_Desp As String, U_Multa_Mont As String,
                                            U_Fec_Ini_Multa As Date, U_Poc_Multa As Double, U_Tope_Multa As Double, U_Frec_Multa As String, U_Coment_Multa As String,
                                            U_SlpCode As String, U_SlpName As String, U_Nro_Oport As String, U_Nro_OC_Cliente As String, U_DocEntry As Integer,
                                            U_UserSign As Integer, U_CreateDate As Date, U_Fec_Real_Ter_Des As Date, U_Fec_Real_Ini_Mon As Date, U_Fec_Real_Fin_Mon As Date,
                                            U_Fec_Real_Recep_Mon As Date, U_Contrato_Cli As String, U_Estado_M As String, U_Fec_Estado_M As Date, U_Cod_SupervM As String,
                                            U_Cod_ProdM As String, U_Cat_ProdM As String, U_Cod_JefeM As String, U_CIudadM As String, U_Cod_MontM As String,
                                            U_Cant_MontaM As Integer, U_ObservaM As String, U_Cod_MaqM As String, U_Con_Montaje As Integer, U_Con_Despacho As Integer,
                                            U_Monto_OCC As Double, U_Desa_Asigna As String, U_Fec_Recep_Ing As Date, U_Usu_Recep_Ing As String, U_Fec_Distri_Ing As Date,
                                            U_Usu_Distri_Ing As String, U_Fec_Visita_Ing As Date, U_Usu_Visita_Ing As String, U_Fec_Plano_Ing As Date, U_Usu_Plano_Ing As String,
                                            U_Fec_Cubicacion_Ing As Date, U_Usu_Cubicacion_Ing As String, U_Fec_Receta_Ing As Date, U_Usu_Receta_Ing As String, U_Fec_PCV_Ing As Date,
                                            U_Usu_PCV_Ing As String, U_Fec_OC_Ind_Ing As Date, U_Usu_OC_Ind_Ing As String, U_Fec_OC_Mont_Ing As Date, U_Usu_OC_Mont_Ing As String,
                                            U_Fec_Cierre_Ing As Date, U_Usu_Cierre_Ing As String, U_Comentario_Ing As String, U_Visita_Tec As String, U_Pro_Ing_Entreg As String,
                                            U_Usu_Entrega_Pro As String, U_Mens_Montajes As String, U_ColorMensaje As String, U_EstadoMnsMont As String) As String

        Dim Obj As New DProyectos()
        Obj.U_PrjCode = U_PrjCode
        Obj.U_PrjName = U_PrjName
        Obj.U_CardCode = U_CardCode
        Obj.U_CardName = U_CardName
        Obj.U_Fec_Vta = U_Fec_Vta
        Obj.U_Fec_Prom = U_Fec_Prom
        Obj.U_Fec_Ter_Desa = U_Fec_Ter_Desa
        Obj.U_Fec_Ter_Prod = U_Fec_Ter_Prod
        Obj.U_Fec_Ini_Desp = U_Fec_Ini_Desp
        Obj.U_Fec_Ini_Mont = U_Fec_Ini_Mont
        Obj.U_Fec_Ter_Mont = U_Fec_Ter_Mont
        Obj.U_Multa = U_Multa
        Obj.U_Comentario = U_Comentario
        Obj.U_Multa_Desp = U_Multa_Desp
        Obj.U_Multa_Mont = U_Multa_Mont
        Obj.U_Fec_Ini_Multa = U_Fec_Ini_Multa
        Obj.U_Poc_Multa = U_Poc_Multa
        Obj.U_Tope_Multa = U_Tope_Multa
        Obj.U_Frec_Multa = U_Frec_Multa
        Obj.U_Coment_Multa = U_Coment_Multa
        Obj.U_SlpCode = U_SlpCode
        Obj.U_SlpName = U_SlpName
        Obj.U_Nro_Oport = U_Nro_Oport
        Obj.U_Nro_OC_Cliente = U_Nro_OC_Cliente
        Obj.U_DocEntry = U_DocEntry
        Obj.U_UserSign = U_UserSign
        Obj.U_CreateDate = U_CreateDate
        Obj.U_Fec_Real_Ter_Des = U_Fec_Real_Ter_Des
        Obj.U_Fec_Real_Ini_Mon = U_Fec_Real_Ini_Mon
        Obj.U_Fec_Real_Fin_Mon = U_Fec_Real_Fin_Mon
        Obj.U_Fec_Real_Recep_Mon = U_Fec_Real_Recep_Mon
        Obj.U_Contrato_Cli = U_Contrato_Cli
        Obj.U_Estado_M = U_Estado_M
        Obj.U_Fec_Estado_M = U_Fec_Estado_M
        Obj.U_Cod_SupervM = U_Cod_SupervM
        Obj.U_Cod_ProdM = U_Cod_ProdM
        Obj.U_Cat_ProdM = U_Cat_ProdM
        Obj.U_Cod_JefeM = U_Cod_JefeM
        Obj.U_CIudadM = U_CIudadM
        Obj.U_Cod_MontM = U_Cod_MontM
        Obj.U_Cant_MontaM = U_Cant_MontaM
        Obj.U_ObservaM = U_ObservaM
        Obj.U_Cod_MaqM = U_Cod_MaqM
        Obj.U_Con_Montaje = U_Con_Montaje
        Obj.U_Con_Despacho = U_Con_Despacho
        Obj.U_Monto_OCC = U_Monto_OCC
        Obj.U_Desa_Asigna = U_Desa_Asigna
        Obj.U_Fec_Recep_Ing = U_Fec_Recep_Ing
        Obj.U_Usu_Recep_Ing = U_Usu_Recep_Ing
        Obj.U_Fec_Distri_Ing = U_Fec_Distri_Ing
        Obj.U_Usu_Distri_Ing = U_Usu_Distri_Ing
        Obj.U_Fec_Visita_Ing = U_Fec_Visita_Ing
        Obj.U_Usu_Visita_Ing = U_Usu_Visita_Ing
        Obj.U_Fec_Plano_Ing = U_Fec_Plano_Ing
        Obj.U_Usu_Plano_Ing = U_Usu_Plano_Ing
        Obj.U_Fec_Cubicacion_Ing = U_Fec_Cubicacion_Ing
        Obj.U_Usu_Cubicacion_Ing = U_Usu_Cubicacion_Ing
        Obj.U_Fec_Receta_Ing = U_Fec_Receta_Ing
        Obj.U_Usu_Receta_Ing = U_Usu_Receta_Ing
        Obj.U_Fec_PCV_Ing = U_Fec_PCV_Ing
        Obj.U_Usu_PCV_Ing = U_Usu_PCV_Ing
        Obj.U_Fec_OC_Ind_Ing = U_Fec_OC_Ind_Ing
        Obj.U_Usu_OC_Ind_Ing = U_Usu_OC_Ind_Ing
        Obj.U_Fec_OC_Mont_Ing = U_Fec_OC_Mont_Ing
        Obj.U_Usu_OC_Mont_Ing = U_Usu_OC_Mont_Ing
        Obj.U_Fec_Cierre_Ing = U_Fec_Cierre_Ing
        Obj.U_Usu_Cierre_Ing = U_Usu_Cierre_Ing
        Obj.U_Comentario_Ing = U_Comentario_Ing
        Obj.U_Visita_Tec = U_Visita_Tec
        Obj.U_Pro_Ing_Entreg = U_Pro_Ing_Entreg
        Obj.U_Usu_Entrega_Pro = U_Usu_Entrega_Pro
        Obj.U_Mens_Montajes = U_Mens_Montajes
        Obj.U_ColorMensaje = U_ColorMensaje
        Obj.U_EstadoMnsMont = U_EstadoMnsMont

        Return Obj.InsertarProyecto(Obj)

    End Function

    Public Shared Function CargarProyecto(Proyecto As DProyectos, CodigoProyecto As String) As String

        Dim Obj As New DProyectos()

        Return Obj.CargarProyecto(Proyecto, CodigoProyecto)

    End Function

End Class
