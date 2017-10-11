Imports System.Threading
Imports System.Windows.Forms

Public Enum DialogType
    SAVE
    OPEN
    FOLDER
End Enum


Public Class NSelectFileDialog
    Private shutdownEvent As New ManualResetEvent(False)
    Public Property SelectedFile() As String
        Get
            Return m_SelectedFile
        End Get
        Private Set
            m_SelectedFile = Value
        End Set
    End Property
    Private m_SelectedFile As String
    Public Property SelectedFolder() As String
        Get
            Return m_SelectedFolder
        End Get
        Private Set
            m_SelectedFolder = Value
        End Set
    End Property
    Private m_SelectedFolder As String


    Private folder As String, file As String, filter As String
    Private type As DialogType


    Public Sub New(folder As String, file As String, filter As String, type As DialogType)
        If folder Is Nothing OrElse file Is Nothing OrElse filter Is Nothing Then
            Throw New ArgumentException("Faltan Parametros")
        End If


        Me.folder = folder
        Me.file = file
        Me.filter = filter
        Me.type = type
    End Sub


    Private Sub InternalSelectFileDialog()
        Dim form = New System.Windows.Forms.Form()


        form.TopMost = True
        form.Height = 0
        form.Width = 0
        form.WindowState = FormWindowState.Minimized
        form.Visible = True


        Select Case type
            Case DialogType.FOLDER
                FolderDialog(form)
                Exit Select
            Case DialogType.OPEN
                OpenDialog(form)
                Exit Select
            Case DialogType.SAVE
                SaveDialog(form)
                Exit Select
        End Select
        shutdownEvent.[Set]()
    End Sub


    Private Sub FolderDialog(form As System.Windows.Forms.Form)
        Dim dialog As New FolderBrowserDialog()


        dialog.Description = "FolderDialogTitle"
        dialog.RootFolder = Environment.SpecialFolder.MyComputer
        '----------------------------------------------------------------//
        If dialog.ShowDialog() = DialogResult.OK Then
            form.Close()
            SelectedFolder = dialog.SelectedPath
        Else
            form.Close()
            SelectedFolder = ""
        End If
    End Sub


    Private Sub OpenDialog(form As System.Windows.Forms.Form)
        Dim dialog As New OpenFileDialog()
        OpenOrSaveDialog(dialog, form)
    End Sub


    Private Sub SaveDialog(form As System.Windows.Forms.Form)
        Dim dialog As New SaveFileDialog()
        OpenOrSaveDialog(dialog, form)
    End Sub


    Private Sub OpenOrSaveDialog(dialog As FileDialog, form As System.Windows.Forms.Form)
        dialog.Title = "FileDialogTitle"
        dialog.Filter = filter
        '"TXT files (*.txt)|*.txt|All files (*.*)|*.*";
        dialog.InitialDirectory = folder
        dialog.FileName = file
        '----------------------------------------------------------------//
        If dialog.ShowDialog() = DialogResult.OK Then
            form.Close()
            SelectedFile = dialog.FileName
        Else
            form.Close()
            SelectedFile = ""
        End If
    End Sub


    Public Sub Open()
        Dim t As New Thread(New ThreadStart(AddressOf Me.InternalSelectFileDialog))
        t.SetApartmentState(ApartmentState.STA)
        t.Start()
        shutdownEvent.WaitOne()
    End Sub
End Class
