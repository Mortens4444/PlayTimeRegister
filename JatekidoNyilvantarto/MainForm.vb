Imports System.IO

Public Class MainForm

    Private number_of_tables As Integer
    Private number_of_tables_in_a_row As Integer
    Private number_of_tables_in_a_column As Integer

    Public Sub New()
        InitializeComponent()
        GetRowsAndColumnsForTables()
    End Sub

    Private Sub TableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TableToolStripMenuItem.Click
        If (number_of_tables \ number_of_tables_in_a_row < number_of_tables_in_a_column) Then
            Dim BilliardTable1 As BilliardTable
            BilliardTable1 = New BilliardTable With {
                .BackColor = Color.Black,
                .BorderStyle = BorderStyle.Fixed3D,
                .Interval = TimeSpan.Parse("00:00:00"),
                .Location = New Point((number_of_tables Mod number_of_tables_in_a_row) * 140 + 12, (number_of_tables \ number_of_tables_in_a_row) * 210 + 12),
                .Name = "BilliardTable1",
                .Price = 500.0R,
                .ID = number_of_tables.ToString(),
                .Size = New Size(131, 199),
                .TabIndex = 0
            }
            number_of_tables += 1
            Me.P_ClientArea.Controls.Add(BilliardTable1)
        End If
    End Sub

    Private Sub Tsmi_Exit_Click(sender As Object, e As EventArgs) Handles Tsmi_Exit.Click
        Me.Close()
    End Sub

    Private Sub GetRowsAndColumnsForTables()
        number_of_tables_in_a_row = (Me.Size.Width - 12) \ 140
        number_of_tables_in_a_column = (Me.Size.Height - 12) \ 210
    End Sub

    Private Sub MainForm_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        GetRowsAndColumnsForTables()
    End Sub

    Private Sub Tsmi_About_Click(sender As Object, e As EventArgs) Handles Tsmi_About.Click
        Dim a = New About()
        a.ShowDialog()
    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim dir As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\\JatekIdoNyilvantarto"
        If (Not Directory.Exists(dir)) Then
            Directory.CreateDirectory(dir)
        End If

        Dim path As String = dir + "\\options.ini"
        If (Not File.Exists(path)) Then
            Dim sw = File.CreateText(path)
            sw.WriteLine("PositionX=" & Me.Location.X)
            sw.WriteLine("PositionY=" & Me.Location.Y)
            sw.WriteLine("SizeW=" & Me.Size.Width)
            sw.WriteLine("SizeH=" & Me.Size.Height)
            sw.WriteLine("NumberOfTables=" & number_of_tables)
            sw.Close()
        Else
            Dim content As String
            content = File.ReadAllText(path)
            Dim lines() As String
            lines = content.Split(vbCrLf)
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
                ElseIf (values(0) = "NumberOfTables") Then
                    Dim tables As Integer = Convert.ToInt32(values(1))
                    Dim i As Integer
                    For i = 1 To tables
                        TableToolStripMenuItem.PerformClick()
                    Next
                End If
            Next
        End If
    End Sub
End Class
