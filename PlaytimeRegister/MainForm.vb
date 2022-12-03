Imports System.IO
Imports LanguageService.Windows.Forms

Public Class MainForm

    Private Const Delta As Int32 = 10
    Private ReadOnly PoolTableSize As New PoolTable()

    Private numberOfTables As Integer
    Private numberOfTablesInRow As Integer
    Private numberOfTablesInColumn As Integer
    Private price As Decimal = 500
    Private currency As String = "HUF"

    Public Sub New()
        InitializeComponent()
        GetRowsAndColumnsForTables()
        Translator.Translate(Me)
    End Sub

    Private Sub TableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TableToolStripMenuItem.Click
        CreateTable()
    End Sub

    Private Sub CreateTable()
        If (numberOfTables \ numberOfTablesInRow < numberOfTablesInColumn) Then
            Dim poolTable As PoolTable
            poolTable = New PoolTable With {
                .Name = $"PoolTable{numberOfTables}",
                .Interval = TimeSpan.Parse("00:00:00"),
                .Price = Me.price,
                .Currency = Me.currency,
                .ID = $"{numberOfTables + 1}",
                .TabIndex = numberOfTables,
                .Location = New Point((numberOfTables Mod numberOfTablesInRow) * (PoolTableSize.Width + Delta) + Delta, (numberOfTables \ numberOfTablesInRow) * (PoolTableSize.Height + Delta) + Delta)
            }
            numberOfTables += 1
            Me.P_ClientArea.Controls.Add(poolTable)
        End If
    End Sub

    Private Sub Tsmi_Exit_Click(sender As Object, e As EventArgs) Handles Tsmi_Exit.Click
        Me.Close()
    End Sub

    Private Sub GetRowsAndColumnsForTables()
        numberOfTablesInRow = (Me.Size.Width - Delta) \ (PoolTableSize.Width + Delta)
        numberOfTablesInColumn = (Me.Size.Height - Delta) \ (PoolTableSize.Height + Delta)
    End Sub

    Private Sub MainForm_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        GetRowsAndColumnsForTables()
    End Sub

    Private Sub Tsmi_About_Click(sender As Object, e As EventArgs) Handles Tsmi_About.Click
        Dim a = New About()
        a.ShowDialog()
    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        LoadTables()
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveTables()
    End Sub

    Private Sub LoadTables()
        Dim path As String = GetPath()
        If File.Exists(path) Then
            Dim content As String = File.ReadAllText(path)
            Dim lines() As String = content.Split(vbCrLf)
            Dim line As String
            For Each line In lines
                Dim values() As String = line.Split("=")

                values(0) = values(0).Trim()
                If (values(0) = "PositionX") Then
                    Me.Location = New Point(Convert.ToInt32(values(1)), Me.Location.Y)
                ElseIf (values(0) = "PositionY") Then
                    Me.Location = New Point(Me.Location.X, Convert.ToInt32(values(1)))
                ElseIf (values(0) = "SizeW") Then
                    Me.Size = New Size(Convert.ToInt32(values(1)), Me.Size.Height)
                ElseIf (values(0) = "SizeH") Then
                    Me.Size = New Size(Me.Size.Width, Convert.ToInt32(values(1)))
                ElseIf (values(0) = "Price") Then
                    Me.price = Convert.ToDecimal(values(1))
                ElseIf (values(0) = "Currency") Then
                    Me.currency = values(1)
                ElseIf (values(0) = "NumberOfTables") Then
                    Dim tables As Integer = Convert.ToInt32(values(1))
                    Dim i As Integer
                    For i = 1 To tables
                        CreateTable()
                    Next
                End If
            Next
        Else
            CreateTable()
        End If
    End Sub

    Private Sub SaveTables()
        Dim path As String = GetPath()
        Dim sw = File.CreateText(path)
        sw.WriteLine("PositionX=" & Me.Location.X)
        sw.WriteLine("PositionY=" & Me.Location.Y)
        sw.WriteLine("SizeW=" & Me.Size.Width)
        sw.WriteLine("SizeH=" & Me.Size.Height)
        sw.WriteLine("Price=" & Me.price)
        sw.WriteLine("Currency=" & Me.currency)
        sw.WriteLine("NumberOfTables=" & Me.numberOfTables)
        sw.Close()
    End Sub

    Private Shared Function GetPath() As String
        Dim dir As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PlaytimeRegister")
        If (Not Directory.Exists(dir)) Then
            Directory.CreateDirectory(dir)
        End If

        Dim path As String = IO.Path.Combine(dir, "options.ini")
        Return path
    End Function
End Class
