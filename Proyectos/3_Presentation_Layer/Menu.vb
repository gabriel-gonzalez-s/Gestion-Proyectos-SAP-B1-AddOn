Imports SAPbouiCOM.Framework
Imports AdicionalesProyectos

Namespace SBOAddonProject1
    Public Class Menu

        Private WithEvents SBO_Application As SAPbouiCOM.Application

        Sub New()
            SBO_Application = Application.SBO_Application
        End Sub

        Sub AddMenuItems()

            Dim oMenus As SAPbouiCOM.Menus
            Dim oMenuItem As SAPbouiCOM.MenuItem
            oMenus = Application.SBO_Application.Menus

            Dim oCreationPackage As SAPbouiCOM.MenuCreationParams
            oCreationPackage = (Application.SBO_Application.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams))
            oMenuItem = Application.SBO_Application.Menus.Item("43520") 'Modules

            oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_POPUP
            oCreationPackage.UniqueID = "SBOAddonProject1"
            oCreationPackage.String = "Gestion Proyectos"
            oCreationPackage.Image = sPathAnexos + "images\Proyecto4.png"
            oCreationPackage.Enabled = True
            oCreationPackage.Position = 3

            If SBO_Application.Menus.Exists("SBOAddonProject1") Then

                SBO_Application.Menus.RemoveEx("SBOAddonProject1")

            End If

            oMenus = oMenuItem.SubMenus


            If Not SBO_Application.Menus.Exists("SBOAddonProject1") Then
                Try
                    'If the manu already exists this code will fail
                    oMenus.AddEx(oCreationPackage)
                Catch
                End Try

                Try
                    'Get the menu collection of the newly added pop-up item
                    oMenuItem = Application.SBO_Application.Menus.Item("SBOAddonProject1")
                    oMenus = oMenuItem.SubMenus

                    'Create s sub menu

                    oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING

                    'Please replace following 2 "Form1" with real form class in current project
                    oCreationPackage.UniqueID = "SBOAddonProject1.FrmRegistrar_Proy"
                    oCreationPackage.String = "Registrar Nuevo Proyecto"
                    oCreationPackage.Position = 1
                    oMenus.AddEx(oCreationPackage)
                    oCreationPackage.UniqueID = "SBOAddonProject1.Form1"
                    oCreationPackage.String = "Gestion de Proyectos"
                    oCreationPackage.Position = 2
                    oMenus.AddEx(oCreationPackage)
                    oCreationPackage.UniqueID = "SBOAddonProject1.FrmGestion_Ingenieria"
                    oCreationPackage.String = "Gestion de Ingenieria"
                    oCreationPackage.Position = 3
                    oMenus.AddEx(oCreationPackage)
                    oCreationPackage.UniqueID = "SBOAddonProject1.Form11"
                    oCreationPackage.String = "Gestion de Planos"
                    oCreationPackage.Position = 4
                    oMenus.AddEx(oCreationPackage)
                    oCreationPackage.UniqueID = "SBOAddonProject1.Form_PlanifMontajes"
                    oCreationPackage.String = "Gestion de Montaje"
                    oCreationPackage.Position = 5
                    oMenus.AddEx(oCreationPackage)
                    oCreationPackage.UniqueID = "SBOAddonProject1.GestionFinanzas"
                    oCreationPackage.String = "Gestion de Finanzas"
                    oCreationPackage.Position = 6
                    oMenus.AddEx(oCreationPackage)
                    oCreationPackage.UniqueID = "SBOAddonProject1.FrmGestionTV"
                    oCreationPackage.String = "Gestion TV"
                    oCreationPackage.Position = 7
                    oMenus.AddEx(oCreationPackage)
                    oCreationPackage.UniqueID = "SBOAddonProject1.FrmPCRcomerci"
                    oCreationPackage.String = "Informe PCRs activas"
                    oCreationPackage.Position = 8
                    oMenus.AddEx(oCreationPackage)


                    'oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_POPUP
                    'oCreationPackage.UniqueID = "Informes"
                    'oCreationPackage.String = "Informes"
                    'oCreationPackage.Position = 7
                    'oMenus.AddEx(oCreationPackage)

                    'oMenuItem = Application.SBO_Application.Menus.Item("Informes")
                    'oMenus = oMenuItem.SubMenus
                    'oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING
                    'oCreationPackage.UniqueID = "SBOAddonProject1.FrmPCRcomerci"
                    'oCreationPackage.String = "Informe PCRs activas"
                    'oCreationPackage.Position = 8
                    'oMenus.AddEx(oCreationPackage)
                Catch
                    'Menu already exists
                    Application.SBO_Application.SetStatusBarMessage("Menu Already Exists", SAPbouiCOM.BoMessageTime.bmt_Short, True)
                End Try
            End If


        End Sub


        Sub SBO_Application_MenuEvent(ByRef pVal As SAPbouiCOM.MenuEvent, ByRef BubbleEvent As Boolean) Handles SBO_Application.MenuEvent
            BubbleEvent = True

            Try

                If (pVal.BeforeAction And pVal.MenuUID = "SBOAddonProject1.Form1") Then
                    Dim activeForm As FrmEstado_Global
                    activeForm = New FrmEstado_Global
                    activeForm.Show()
                End If

                If (pVal.BeforeAction And pVal.MenuUID = "SBOAddonProject1.FrmRegistrar_Proy") Then
                    If NConectarAplicacion.sCurrentCompanyDBSH <> sBDComercial Then
                        Application.SBO_Application.StatusBar.SetText("Unicamente se Pueden Registrar Proyectos por la Comercial", SAPbouiCOM.BoMessageTime.bmt_Short, SAPbouiCOM.BoStatusBarMessageType.smt_Error)
                    Else
                        Dim activeForm As FrmRegistrar_Proy
                        activeForm = New FrmRegistrar_Proy
                        activeForm.Show()
                    End If
                End If

                If (pVal.BeforeAction And pVal.MenuUID = "SBOAddonProject1.FrmGestion_Ingenieria") Then
                    Dim activeForm As FrmGestion_Ingenieria
                    activeForm = New FrmGestion_Ingenieria
                    activeForm.Show()
                End If

                If (pVal.BeforeAction And pVal.MenuUID = "SBOAddonProject1.Form11") Then
                    Dim activeForm As Form11
                    activeForm = New Form11
                    activeForm.Show()
                End If

                If (pVal.BeforeAction And pVal.MenuUID = "SBOAddonProject1.Form_PlanifMontajes") Then
                    Dim activeForm As Form_PlanifMontajes
                    activeForm = New Form_PlanifMontajes
                    activeForm.Show()
                End If

                If (pVal.BeforeAction And pVal.MenuUID = "SBOAddonProject1.GestionFinanzas") Then
                    Dim activeForm As GestionFinanzas
                    activeForm = New GestionFinanzas
                    activeForm.Show()
                End If

                If (pVal.BeforeAction And pVal.MenuUID = "SBOAddonProject1.FrmGestionTV") Then
                    Dim activeForm As FrmGestionTV
                    activeForm = New FrmGestionTV
                    activeForm.Show()
                End If

                If (pVal.BeforeAction And pVal.MenuUID = "SBOAddonProject1.FrmPCRcomerci") Then
                    Dim activeForm As FrmPCRcomerci
                    activeForm = New FrmPCRcomerci
                    activeForm.Show()
                End If

            Catch ex As System.Exception
                Application.SBO_Application.MessageBox(ex.ToString(), 1, "Ok", "", "")
            End Try

        End Sub

    End Class
End Namespace