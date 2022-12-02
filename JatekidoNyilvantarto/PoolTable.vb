Public Class BilliardTable
    Public Property Interval As TimeSpan
    Public Property Price As Double = 500

    Public Sub New()
        InitializeComponent()
        Moveable = False
        P_Middle.BackColor = Free
    End Sub


    Public Property Stopped As Color = Color.DarkRed
    Public Property Running As Color = Color.LightBlue
    Public Property Free As Color = Color.ForestGreen
    Public Property Moveable As Boolean

    Public Property ID As String
    Private change_location As Boolean
    Private last_mouse_position As Point

    Private Sub P_Middle_Paint(sender As Object, e As PaintEventArgs) Handles P_Middle.Paint
        e.Graphics.DrawString(Me.Interval.ToString(), Me.Font, Brushes.Black, New PointF(10, 10))
        e.Graphics.DrawString(Me.Price.ToString() + " HUF / óra", Me.Font, Brushes.Black, New PointF(10, 30))
        Dim summa As String
        summa = (Me.Price * Me.Interval.TotalHours).ToString()

        Dim font As New Font(Me.Font.Name, 20, FontStyle.Bold)
        e.Graphics.DrawString(ID, font, Brushes.White, New PointF(50, 90))

        Dim max As Integer = 0
        If (summa.IndexOf(",") <> -1) Then
            max = summa.IndexOf(",") + 3
        ElseIf (summa.IndexOf(".") <> -1) Then
            max = summa.IndexOf(".") + 3
        End If

        If summa.Length < max Then
            max = summa.Length
        End If

        If (max = 0) Then
            summa += " HUF"
        Else
            summa = summa.Substring(0, max) + " HUF"
        End If

        e.Graphics.DrawString(summa, Me.Font, Brushes.Black, New PointF(10, 50))
    End Sub

    Private Sub Counter_Tick(sender As Object, e As EventArgs) Handles T_Counter.Tick
        Me.Interval = Me.Interval.Add(TimeSpan.FromSeconds(1))
        Me.Refresh()
    End Sub


    Private Sub Btn_StartStop_Click(sender As Object, e As EventArgs) Handles Btn_StartStop.Click
        If T_Counter.Enabled Then
            T_Counter.Enabled = False
            Btn_StartStop.Text = "Start"
            Me.P_Middle.BackColor = Stopped
        Else
            T_Counter.Enabled = True
            Btn_StartStop.Text = "Stop"
            Me.P_Middle.BackColor = Running
        End If
    End Sub

    Private Sub Tsmi_SetPrice_Click(sender As Object, e As EventArgs) Handles Tsmi_SetPrice.Click
        Dim spf = New SetPriceForm(Me.Price)
        If spf.ShowDialog() = DialogResult.OK Then
            Price = spf.price
            Me.Refresh()
        End If
    End Sub

    Private Sub P_Middle_MouseMove(sender As Object, e As MouseEventArgs) Handles P_Middle.MouseMove
        If Moveable Then
            If change_location And e.Button = Windows.Forms.MouseButtons.Left Then
                Me.Location = New Point(Me.Location.X + (e.X - last_mouse_position.X), Me.Location.Y + (e.Y - last_mouse_position.Y))
            Else
                last_mouse_position = e.Location
            End If
        End If
    End Sub

    Private Sub P_Middle_MouseUp(sender As Object, e As MouseEventArgs) Handles P_Middle.MouseUp
        If Moveable Then
            change_location = False
            P_Middle.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub P_Middle_MouseDown(sender As Object, e As MouseEventArgs) Handles P_Middle.MouseDown
        If Moveable Then
            change_location = True
            P_Middle.Cursor = Cursors.SizeAll
            last_mouse_position = e.Location
        End If
    End Sub

    Private Sub Tsmi_ClearTimer_Click(sender As Object, e As EventArgs) Handles Tsmi_ClearTimer.Click
        Me.Interval = New TimeSpan()
        Me.P_Middle.BackColor = Free
        Me.Refresh()
        T_Counter.Enabled = False
        Btn_StartStop.Text = "Start"
    End Sub

    Private Sub Tsmi_DeleteTable_Click(sender As Object, e As EventArgs) Handles Tsmi_DeleteTable.Click
        Me.Dispose()
    End Sub
End Class
