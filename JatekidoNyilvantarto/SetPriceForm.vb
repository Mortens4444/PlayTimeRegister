Public Class SetPriceForm

    Public price As Double

    Public Sub New(ByVal price As Double)
        InitializeComponent()
        Me.price = price
        Nud_Price.Value = price
    End Sub

    Private Sub Btn_OK_Click(sender As System.Object, e As System.EventArgs) Handles Btn_OK.Click
        price = Convert.ToDouble(Nud_Price.Value)
    End Sub
End Class