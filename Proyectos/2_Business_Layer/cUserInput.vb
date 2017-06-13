Imports SAPbouiCOM.Framework

Namespace SBOAddonProject1

    Public Class cUserInput

        Private sInput As String = ""

        Private sTitle As String = ""

        Private DT_Item As SAPbouiCOM.DataTable

        Private DT_Result As SAPbouiCOM.DataTable


        Public Function ShowInput(Title As String, Message As String, DTItems As SAPbouiCOM.DataTable, DTRetorno As SAPbouiCOM.DataTable) As SAPbouiCOM.DataTable

            bLoadInputEvents = True

            sTitle = Title

            'CARGAR DT ANTES DE LLAMAR AL FORM
            DT_Item = DTItems
            DT_Result = DTRetorno

            Application.SBO_Application.MessageBox(Message, 1)


            ShowInput = DT_Result

        End Function



        ' handles Form event trafic for the form associated to this class instance

        Public Overridable Sub ItemEvents(ByRef pVal As SAPbouiCOM.ItemEvent, ByRef BubbleEvent As Boolean)

            Try



                Select Case pVal.EventType

                    Case 1

                        e_ItemPressed(pVal, BubbleEvent)

                    Case 16

                        e_FormLoad(pVal, BubbleEvent)

                End Select



            Catch ex As Exception

                Application.SBO_Application.MessageBox(ex.Message)

            End Try



        End Sub



        Protected Overridable Sub e_FormLoad(ByRef pVal As SAPbouiCOM.ItemEvent, ByRef BubbleEvent As Boolean)

            If pVal.BeforeAction = False Then

                Dim oform As SAPbouiCOM.Form = Application.SBO_Application.Forms.Item(pVal.FormUID)



                oform.Title = sTitle

                Dim Top As Integer = oform.Items.Item("7").Top + oform.Items.Item("7").Height + 10
                Dim Left As Integer = oform.Items.Item("7").Left
                Dim Width As Integer = 120

                For i = 0 To DT_Item.Rows.Count - 1
                    'Static Text
                    oform.Items.Add("Static" + i.ToString, SAPbouiCOM.BoFormItemTypes.it_STATIC)
                    oform.Items.Item("Static" + i.ToString).Top = Top
                    oform.Items.Item("Static" + i.ToString).Left = Left
                    oform.Items.Item("Static" + i.ToString).Width = Width
                    oform.Items.Item("Static" + i.ToString).Specific.caption = DT_Item.GetValue(0, i)
                    'Edit Text
                    oform.Items.Add("Edit" + i.ToString, SAPbouiCOM.BoFormItemTypes.it_EDIT)
                    oform.Items.Item("Edit" + i.ToString).Top = Top
                    oform.Items.Item("Edit" + i.ToString).Left = Left + Width
                    oform.Items.Item("Edit" + i.ToString).Width = Width - 40

                    Top += 15

                Next

                oform = Nothing

            End If

        End Sub



        Protected Overridable Sub e_ItemPressed(ByRef pVal As SAPbouiCOM.ItemEvent, ByRef BubbleEvent As Boolean)

            Dim NoValidos As Integer = 0

            If pVal.ItemUID = "1" And pVal.BeforeAction Then


                For i = 0 To DT_Item.Rows.Count - 1

                    sInput = Application.SBO_Application.Forms.Item(pVal.FormUID).Items.Item("Edit" + i.ToString).Specific.String

                    If sInput = "" Or Not oFunciones.EsCadenaEntero(sInput) Then

                        NoValidos += 1

                    End If

                Next

                If NoValidos > 0 Then

                    Application.SBO_Application.StatusBar.SetText("Debe Ingresar Unicamente Numeros Enteros", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Warning)
                    BubbleEvent = False

                Else

                    DT_Result.Clear()
                    DT_Result.Columns.Add("Valor", SAPbouiCOM.BoFieldsType.ft_AlphaNumeric)
                    For i = 0 To DT_Item.Rows.Count - 1

                        DT_Result.Rows.Add()
                        DT_Result.SetValue(0, i, Application.SBO_Application.Forms.Item(pVal.FormUID).Items.Item("Edit" + i.ToString).Specific.String)

                    Next

                    bLoadInputEvents = False

                End If

            End If

        End Sub



    End Class


End Namespace




