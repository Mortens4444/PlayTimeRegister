Imports LanguageService
Imports LanguageService.Windows.Forms

Public Class PoolTable
    Public Property Interval As TimeSpan
    Public Property Price As Decimal
    Public Property Currency As String

    Public Sub New()
        InitializeComponent()
        Moveable = False
        P_Middle.BackColor = Free
        Translator.Translate(Me)
    End Sub


    Public Property Stopped As Color = Color.DarkRed
    Public Property Running As Color = Color.LightBlue
    Public Property Free As Color = Color.ForestGreen
    Public Property Moveable As Boolean

    Public Property ID As String
    Private changeLocation As Boolean
    Private lastMousePosition As Point

    Private Sub P_Middle_Paint(sender As Object, e As PaintEventArgs) Handles P_Middle.Paint
        e.Graphics.DrawString(Me.Interval.ToString(), Me.Font, Brushes.Black, New PointF(10, 10))
        e.Graphics.DrawString($"{Me.Price} {Currency} / {Lng.Elem("hour")}", Me.Font, Brushes.Black, New PointF(10, 30))

        Dim font As New Font(Me.Font.Name, 20, FontStyle.Bold)
        e.Graphics.DrawString(ID, font, Brushes.White, New PointF(50, 90))

        Dim summa As String = $"{(Me.Price * Convert.ToDecimal(Me.Interval.TotalHours)):0.000} {Currency}"
        e.Graphics.DrawString(summa, Me.Font, Brushes.Black, New PointF(10, 50))
    End Sub

    Private Sub Counter_Tick(sender As Object, e As EventArgs) Handles T_Counter.Tick
        Me.Interval = Me.Interval.Add(TimeSpan.FromSeconds(1))
        Me.Refresh()
    End Sub


    Private Sub Btn_StartStop_Click(sender As Object, e As EventArgs) Handles Btn_StartStop.Click
        If T_Counter.Enabled Then
            T_Counter.Enabled = False
            Btn_StartStop.Text = Lng.Elem("Start")
            Me.P_Middle.BackColor = Stopped
        Else
            T_Counter.Enabled = True
            Btn_StartStop.Text = Lng.Elem("Stop")
            Me.P_Middle.BackColor = Running
        End If
    End Sub

    Private Sub Tsmi_SetPrice_Click(sender As Object, e As EventArgs) Handles Tsmi_SetPrice.Click
        Dim spf = New SetPriceForm(Me.Price, Me.Currency)
        If spf.ShowDialog() = DialogResult.OK Then
            Price = spf.Price
            Currency = spf.Currency
            Me.Refresh()
        End If
    End Sub

    Private Sub P_Middle_MouseMove(sender As Object, e As MouseEventArgs) Handles P_Middle.MouseMove
        If Moveable Then
            If changeLocation And e.Button = MouseButtons.Left Then
                Me.Location = New Point(Me.Location.X + (e.X - lastMousePosition.X), Me.Location.Y + (e.Y - lastMousePosition.Y))
            Else
                lastMousePosition = e.Location
            End If
        End If
    End Sub

    Private Sub P_Middle_MouseUp(sender As Object, e As MouseEventArgs) Handles P_Middle.MouseUp
        If Moveable Then
            changeLocation = False
            P_Middle.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub P_Middle_MouseDown(sender As Object, e As MouseEventArgs) Handles P_Middle.MouseDown
        If Moveable Then
            changeLocation = True
            P_Middle.Cursor = Cursors.SizeAll
            lastMousePosition = e.Location
        End If
    End Sub

    Private Sub Tsmi_ClearTimer_Click(sender As Object, e As EventArgs) Handles Tsmi_ClearTimer.Click
        Me.Interval = New TimeSpan()
        Me.P_Middle.BackColor = Free
        Me.Refresh()
        T_Counter.Enabled = False
        Btn_StartStop.Text = Lng.Elem("Start")
    End Sub

    Private Sub Tsmi_DeleteTable_Click(sender As Object, e As EventArgs) Handles Tsmi_DeleteTable.Click
        Me.Dispose()
    End Sub
End Class
