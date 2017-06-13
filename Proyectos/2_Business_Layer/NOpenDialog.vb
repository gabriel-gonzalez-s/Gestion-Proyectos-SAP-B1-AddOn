Imports System.Security.Permissions
Imports SAPbouiCOM.Framework

Public Class NOpenDialog
    'Implements IDisposable

    Public Shared FileNamex As String = ""

    Public Enum eFileDialog
        en_OpenFile = 0
        en_SaveFile = 1
    End Enum

    <Runtime.InteropServices.DllImport("user32.dll")> _
    Private Shared Function GetForegroundWindow() As IntPtr
    End Function

    Private _oFileDialog As System.Windows.Forms.FileDialog
    ' Properties

    Public Property FileName() As String
        Get
            Return _oFileDialog.FileName
        End Get

        Set(value As String)
            _oFileDialog.FileName = value
        End Set
    End Property


    Public ReadOnly Property FileNames() As String()
        Get
            Return _oFileDialog.FileNames
        End Get
    End Property


    Public Property Filter() As String
        Get
            Return _oFileDialog.Filter
        End Get

        Set(value As String)
            _oFileDialog.Filter = value
        End Set
    End Property


    Public Property InitialDirectory() As String
        Get
            Return _oFileDialog.InitialDirectory
        End Get

        Set(value As String)
            _oFileDialog.InitialDirectory = value
        End Set
    End Property


    ' Constructor

    Public Sub New(dlg As eFileDialog)
        Select Case CInt(dlg)
            Case 0
                _oFileDialog = New System.Windows.Forms.OpenFileDialog()
                Exit Select

            Case 1
                _oFileDialog = New System.Windows.Forms.SaveFileDialog()
                Exit Select
            Case Else
                Throw New ApplicationException("GetFileNameClass incorrect parameter")
        End Select
    End Sub

    Public Sub New()
        Me.New(eFileDialog.en_OpenFile)
    End Sub

    ' Dispose

    Public Sub Dispose()
        _oFileDialog.Dispose()
    End Sub

    ' Methods

    Public Shared Function OpenFileDialog() As String
        Dim oGetFileName As New NOpenDialog()
        Dim FileName As String = ""
        FileNamex = ""

        oGetFileName.Filter = "All files (*.*)|*.*"

        'oGetFileName.InitialDirectory = "C:"

        Dim threadGetFile As New Threading.Thread(New Threading.ThreadStart(AddressOf oGetFileName.GetFileName))
        'Dim threadGetFile As New Threading.Thread(New Threading.ThreadStart(AddressOf oGetFileName.ShowFolderBrowser))

        threadGetFile.SetApartmentState(Threading.ApartmentState.STA)

        Try
            threadGetFile.Start()
            While Not threadGetFile.IsAlive

            End While
            ' Wait for thread to get started
            Threading.Thread.Sleep(1)
            ' Wait a sec more
            threadGetFile.Join()
            ' Wait for thread to end
            ' Use file name as you will here

            If oGetFileName.FileName <> String.Empty Then
                FileName = oGetFileName.FileName
                '
                ' ADD YOU CODE HERE!!!!
                '
            End If

            If FileNamex <> String.Empty Then
                FileName = FileNamex
                '
                ' ADD YOU CODE HERE!!!!
                '
            End If

            oGetFileName.Dispose()

        Catch ex As Exception
            Application.SBO_Application.MessageBox(ex.Message, 1, "OK", "", "")
        End Try

        Return FileName

    End Function


    Public Sub GetFileName()
        Dim f As New FileIOPermission(PermissionState.None)
        f.AllLocalFiles = FileIOPermissionAccess.AllAccess
        Dim MyProcs() As System.Diagnostics.Process
        Dim ptr As IntPtr = GetForegroundWindow()

        'Dim oWindow As New WindowWrapper(ptr)

        MyProcs = Process.GetProcessesByName("SAP Business One")

        If MyProcs.Length = 1 Then
            For i As Integer = 0 To MyProcs.Length - 1

                Dim oWindow As New WindowWrapper(MyProcs(i).MainWindowHandle)

                If _oFileDialog.ShowDialog(oWindow) = System.Windows.Forms.DialogResult.OK Then
                    '_oFileDialog.FileName = String.Empty
                    FileName = _oFileDialog.FileName
                    FileNamex = _oFileDialog.FileName
                    _oFileDialog.Dispose()
                Else
                    System.Windows.Forms.Application.ExitThread()
                End If
            Next
        Else
            Dim cProcess As System.Diagnostics.Process = System.Diagnostics.Process.GetCurrentProcess()
            Dim iSBOID As Integer = getProcessParentID(cProcess.ProcessName, cProcess.Id)
            Dim kProcs As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessById(iSBOID, cProcess.MachineName)
            Dim SAPWindow As New WindowWrapper(kProcs.MainWindowHandle)
            Dim ret As Windows.Forms.DialogResult = _oFileDialog.ShowDialog(SAPWindow)

            If ret = Windows.Forms.DialogResult.OK Then
                '_oFileDialog.FileName = String.Empty
                FileName = _oFileDialog.FileName
                FileNamex = _oFileDialog.FileName
                _oFileDialog.Dispose()
            Else
                System.Windows.Forms.Application.ExitThread()
            End If
        End If


        'oWindow = Nothing
    End Sub
    ' End of GetFileName


    Public Function getProcessParentID(ByVal cName As String, ByVal cID As Integer) As Integer
        Dim query As System.Management.SelectQuery = New SelectQuery("SELECT * FROM Win32_Process WHERE Name like '" & cName & ".exe' and ProcessId = " & cID)
        Dim mgmtSearcher As System.Management.ManagementObjectSearcher = New ManagementObjectSearcher(query)
        Dim iID As Integer = -1
        For Each p As System.Management.ManagementObject In mgmtSearcher.Get()
            Dim s(1) As String
            p.InvokeMethod("GetOwner", DirectCast(s, Object()))
            ' Source Code link : http://www.vbdotnetforums.com/windows-services/4022-kill-specific-process.html  
            ' More Object Reference at this link : http://msdn.microsoft.com/en-us/library/aa394372(VS.85).asp  
            iID = p("ParentProcessId")
        Next
        Return iID
    End Function

End Class

Public Class WindowWrapper
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




