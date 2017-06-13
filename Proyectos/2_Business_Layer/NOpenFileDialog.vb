Imports SAPbouiCOM.Framework
Imports System.Windows.Forms

Public Class NOpenFileDialog

    Private FileName As String

    Public Shared Function ShowOpenFileDialog() As String

        Dim OpenFileDialog As New NOpenFileDialog()

        Dim ShowFolderBrowserThread As Threading.Thread
        Try
            ShowFolderBrowserThread = New Threading.Thread(AddressOf OpenFileDialog.ShowFolderBrowser)
            If ShowFolderBrowserThread.ThreadState = System.Threading.ThreadState.Unstarted Then
                ShowFolderBrowserThread.SetApartmentState(System.Threading.ApartmentState.STA)
                ShowFolderBrowserThread.Start()
            ElseIf ShowFolderBrowserThread.ThreadState = System.Threading.ThreadState.Stopped Then
                ShowFolderBrowserThread.Start()
                ShowFolderBrowserThread.Join()

            End If
            While ShowFolderBrowserThread.ThreadState = Threading.ThreadState.Running
                Windows.Forms.Application.DoEvents()
            End While
            If OpenFileDialog.FileName <> "" Then
                Return OpenFileDialog.FileName
            End If
        Catch ex As Exception
            SAPbouiCOM.Framework.Application.SBO_Application.MessageBox("FileFile" & ex.Message)
        End Try

        Return OpenFileDialog.FileName

    End Function

    Public Sub ShowFolderBrowser()

        Dim MyProcs() As System.Diagnostics.Process
        FileName = ""
        Dim OpenFile As New OpenFileDialog

        Try
            OpenFile.Multiselect = False
            OpenFile.Filter = "All files(*.CSV)|*.CSV"
            Dim filterindex As Integer = 0
            'Try
            '    filterindex = 0
            'Catch ex As Exception
            'End Try

            OpenFile.FilterIndex = filterindex

            OpenFile.RestoreDirectory = True
            MyProcs = System.Diagnostics.Process.GetProcessesByName("SAP Business One")

            If MyProcs.Length = 1 Then
                For i As Integer = 0 To MyProcs.Length - 1

                    Dim MyWindow As New WindowWrapper(MyProcs(i).MainWindowHandle)
                    Dim ret As DialogResult = OpenFile.ShowDialog(MyWindow)
                    If ret = DialogResult.OK Then
                        FileName = OpenFile.FileName
                        OpenFile.Dispose()
                    Else
                        System.Windows.Forms.Application.ExitThread()
                    End If
                Next
            End If
        Catch ex As Exception
            'SBO_Application.StatusBar.SetText(ex.Message)
            MessageBox.Show(ex.ToString())
            FileName = ""
        Finally
            OpenFile.Dispose()
        End Try

    End Sub

    Private Class WindowWrapper
        Implements System.Windows.Forms.IWin32Window
        Private _hwnd As System.IntPtr

        Public Sub New(ByVal handle As System.IntPtr)
            _hwnd = handle
        End Sub

        Private ReadOnly Property Handle() As System.IntPtr Implements System.Windows.Forms.IWin32Window.Handle
            Get
                Return _hwnd
            End Get
        End Property
    End Class


End Class
