Option Strict Off
Option Explicit On

Imports SAPbouiCOM.Framework
Imports System.IO
Imports SAPbobsCOM

Namespace SBOAddonProject1
    <FormAttribute("SBOAddonProject1.Form14", "3_Presentation_Layer/System Forms/zFrmPruebaDI.b1f")>
    Friend Class Form14
        Inherits UserFormBase

        Public Sub New()
        End Sub

#Region "Respaldo de OnInitializeComponent"
        'Me.EditText0 = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText0 = CType(Me.GetItem("Item_1").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText1 = CType(Me.GetItem("Item_2").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText1 = CType(Me.GetItem("Item_3").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText2 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText2 = CType(Me.GetItem("Item_5").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText3 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText3 = CType(Me.GetItem("Item_7").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText4 = CType(Me.GetItem("Item_8").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText4 = CType(Me.GetItem("Item_9").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText5 = CType(Me.GetItem("Item_10").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText5 = CType(Me.GetItem("Item_11").Specific, SAPbouiCOM.StaticText)
        '   Me.EditText6 = CType(Me.GetItem("Item_12").Specific, SAPbouiCOM.EditText)
        '   Me.StaticText6 = CType(Me.GetItem("Item_13").Specific, SAPbouiCOM.StaticText)
        '   Me.Folder0 = CType(Me.GetItem("Item_15").Specific, SAPbouiCOM.Folder)
        '   Me.Button0 = CType(Me.GetItem("Item_16").Specific, SAPbouiCOM.Button)
        '   Me.OnCustomInitialize()
#End Region


        Public Overrides Sub OnInitializeComponent()
            Me.EditText0 = CType(Me.GetItem("Item_0").Specific, SAPbouiCOM.EditText)
            Me.StaticText0 = CType(Me.GetItem("Item_1").Specific, SAPbouiCOM.StaticText)
            Me.EditText1 = CType(Me.GetItem("Item_2").Specific, SAPbouiCOM.EditText)
            Me.StaticText1 = CType(Me.GetItem("Item_3").Specific, SAPbouiCOM.StaticText)
            Me.EditText2 = CType(Me.GetItem("Item_4").Specific, SAPbouiCOM.EditText)
            Me.StaticText2 = CType(Me.GetItem("Item_5").Specific, SAPbouiCOM.StaticText)
            Me.EditText3 = CType(Me.GetItem("Item_6").Specific, SAPbouiCOM.EditText)
            Me.StaticText3 = CType(Me.GetItem("Item_7").Specific, SAPbouiCOM.StaticText)
            Me.EditText4 = CType(Me.GetItem("Item_8").Specific, SAPbouiCOM.EditText)
            Me.StaticText4 = CType(Me.GetItem("Item_9").Specific, SAPbouiCOM.StaticText)
            Me.EditText5 = CType(Me.GetItem("Item_10").Specific, SAPbouiCOM.EditText)
            Me.StaticText5 = CType(Me.GetItem("Item_11").Specific, SAPbouiCOM.StaticText)
            Me.EditText6 = CType(Me.GetItem("Item_12").Specific, SAPbouiCOM.EditText)
            Me.StaticText6 = CType(Me.GetItem("Item_13").Specific, SAPbouiCOM.StaticText)
            Me.Folder0 = CType(Me.GetItem("Item_15").Specific, SAPbouiCOM.Folder)
            Me.Button0 = CType(Me.GetItem("Item_16").Specific, SAPbouiCOM.Button)
            Me.OnCustomInitialize()

        End Sub

        Public Overrides Sub OnInitializeFormEvents()

        End Sub
        Private WithEvents EditText0 As SAPbouiCOM.EditText

        Private Sub OnCustomInitialize()
            Me.EditText3.Value = "Bp Code"
            Me.EditText4.Value = "C93626000"

            Me.EditText5.Value = "2"
            Me.EditText6.Value = "C93626000"

            oFunciones.IniciarServicioMensajes()
        End Sub

        Private WithEvents StaticText0 As SAPbouiCOM.StaticText
        Private WithEvents EditText1 As SAPbouiCOM.EditText
        Private WithEvents StaticText1 As SAPbouiCOM.StaticText
        Private WithEvents EditText2 As SAPbouiCOM.EditText
        Private WithEvents StaticText2 As SAPbouiCOM.StaticText
        Private WithEvents EditText3 As SAPbouiCOM.EditText
        Private WithEvents StaticText3 As SAPbouiCOM.StaticText
        Private WithEvents EditText4 As SAPbouiCOM.EditText
        Private WithEvents StaticText4 As SAPbouiCOM.StaticText
        Private WithEvents EditText5 As SAPbouiCOM.EditText
        Private WithEvents StaticText5 As SAPbouiCOM.StaticText
        Private WithEvents EditText6 As SAPbouiCOM.EditText
        Private WithEvents StaticText6 As SAPbouiCOM.StaticText
        Private WithEvents Folder0 As SAPbouiCOM.Folder
        Private WithEvents Button0 As SAPbouiCOM.Button

        Private Sub Button0_ClickAfter(sboObject As Object, pVal As SAPbouiCOM.SBOItemEventArg) Handles Button0.ClickAfter




            'Dim pMessageDataColumns As MessageDataColumns
            'Dim pMessageDataColumn As MessageDataColumn
            'Dim oLines As MessageDataLines
            'Dim oLine As MessageDataLine
            'Dim oRecipientCollection As RecipientCollection

            Dim msgServ As SAPbobsCOM.MessagesService
            Dim oMessage As SAPbobsCOM.Message
            Dim DataColumn As SAPbobsCOM.MessageDataColumn
            Dim oRecordset As SAPbobsCOM.Recordset

            Try

                oRecordset = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

                msgServ = oCompany.GetCompanyService.GetBusinessService(SAPbobsCOM.ServiceTypes.MessagesService)
                oMessage = msgServ.GetDataInterface(SAPbobsCOM.MessagesServiceDataInterfaces.msdiMessage)

                oMessage.Subject = Me.EditText0.Value
                oMessage.Text = Me.EditText1.Value
                oMessage.Priority = SAPbobsCOM.BoMsgPriorities.pr_High


                With oMessage.RecipientCollection.Add()
                    .SendInternal = SAPbobsCOM.BoYesNoEnum.tYES
                    .UserCode = GetUserCode(Me.EditText2.Value)
                    .UserType = SAPbobsCOM.BoMsgRcpTypes.rt_InternalUser
                End With


                DataColumn = oMessage.MessageDataColumns.Add
                DataColumn.ColumnName = "Prj Code"
                DataColumn.Link = SAPbobsCOM.BoYesNoEnum.tYES


                oRecordset.DoQuery("SELECT PrjCode,PrjName from OPRJ where PrjCode like 'ZZ%'")
                If oRecordset.RecordCount > 0 Then
                    oRecordset.MoveFirst()

                    For ii As Integer = 0 To oRecordset.RecordCount - 1
                        With DataColumn.MessageDataLines.Add
                            .Value = oRecordset.Fields.Item("PrjCode").Value
                            .Object = "63"
                            .ObjectKey = oRecordset.Fields.Item("PrjCode").Value
                        End With
                        oRecordset.MoveNext()
                    Next

                    'With DataColumn.MessageDataLines.Add
                    '    .Value = "368351"
                    '    .Object = "63"
                    '    .ObjectKey = "368351"
                    'End With

                    DataColumn = oMessage.MessageDataColumns.Add
                    DataColumn.ColumnName = "Prj Code 2"
                    DataColumn.Link = SAPbobsCOM.BoYesNoEnum.tNO

                    oRecordset.MoveFirst()

                    For ii As Integer = 0 To oRecordset.RecordCount - 1
                        With DataColumn.MessageDataLines.Add
                            .Value = oRecordset.Fields.Item("PrjCode").Value
                        End With
                        oRecordset.MoveNext()
                    Next


                    msgServ.SendMessage(oMessage)
                End If



                '---------------------------------------------------------------------------------------------------------------------------------------------------------
                'Dim msgServ As SAPbobsCOM.MessagesService
                Dim oMessage2 As SAPbobsCOM.Message
                'Dim DataColumn As SAPbobsCOM.MessageDataColumn
                'Dim oRecordset As SAPbobsCOM.Recordset


                Try
                    oRecordset = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

                    msgServ = oCompany.GetCompanyService.GetBusinessService(SAPbobsCOM.ServiceTypes.MessagesService)
                    oMessage2 = msgServ.GetDataInterface(SAPbobsCOM.MessagesServiceDataInterfaces.msdiMessage)

                    oMessage2.Subject = "subj"
                    oMessage2.Text = "Mess"
                    oMessage2.Priority = SAPbobsCOM.BoMsgPriorities.pr_High

                    'oRecordset.DoQuery("select  U_apmuc  from [@TI_BITEMASAPR1]")
                    'If oRecordset.RecordCount > 0 Then
                    'oRecordset.MoveFirst()

                    'For ii As Integer = 0 To oRecordset.RecordCount - 1
                    With oMessage2.RecipientCollection.Add()
                        .SendInternal = SAPbobsCOM.BoYesNoEnum.tYES
                        .UserCode = GetUserCode(Me.EditText2.Value) 'CStr(oRecordset.Fields.Item(0).Value)
                        .UserType = SAPbobsCOM.BoMsgRcpTypes.rt_InternalUser
                    End With
                    'oRecordset.MoveNext()
                    'Next

                    DataColumn = oMessage2.MessageDataColumns.Add
                    DataColumn.ColumnName = "Order No."
                    DataColumn.Link = SAPbobsCOM.BoYesNoEnum.tYES

                    oRecordset.DoQuery("SELECT DocEntry, ObjType, DocNum FROM ORDR WHERE DocStatus = N'O'")
                    If oRecordset.RecordCount > 0 Then
                        oRecordset.MoveFirst()

                        For ii As Integer = 0 To oRecordset.RecordCount - 1
                            With DataColumn.MessageDataLines.Add
                                .Value = oRecordset.Fields.Item("DocNum").Value
                                .Object = oRecordset.Fields.Item("ObjType").Value
                                .ObjectKey = oRecordset.Fields.Item("DocEntry").Value
                            End With
                            oRecordset.MoveNext()
                        Next

                        msgServ.SendMessage(oMessage2)
                    End If
                    'End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                '---------------------------------------------------------------------------------------------------------------------------------------------------------


                'Application.SBO_Application.Forms.ActiveForm.Close()

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

        End Sub


        Private Function GetUserCode(ByVal sUserName As String) As String

            Dim oUsers As Users
            Dim oRecordSet As SAPbobsCOM.Recordset

            Try
                'get users object
                oUsers = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUsers)

                ' Get a new Recordset object
                oRecordSet = oCompany.GetBusinessObject(BoObjectTypes.BoRecordset)

                ' Perform the SELECT statement.
                ' The query result will be loaded
                ' into the Recordset object
                oRecordSet.DoQuery("Select USER_CODE from OUSR")

                ' Asign (link) the Recordset object
                ' to the Browser.Recordset property
                oUsers.Browser.Recordset = oRecordSet

                'find the username 
                While (oUsers.Browser.EoF = False)
                    If oUsers.UserName = sUserName Then
                        Exit While
                    End If
                    oUsers.Browser.MoveNext()
                End While

                'return the User Code 
                Return oUsers.UserCode

            Catch ex As Exception

                MsgBox(ex.Message())
                Return ""

            End Try

        End Function


    End Class
End Namespace
