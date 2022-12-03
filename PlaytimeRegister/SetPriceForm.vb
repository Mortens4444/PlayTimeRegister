Imports LanguageService.Windows.Forms

Public Class SetPriceForm

    Public Price As Decimal
    Public Currency As String

    Public Sub New(price As Double, currency As String)
        InitializeComponent()
        Me.Price = price
        Me.Currency = currency
        Nud_Price.Value = price
        Tb_Currency.Text = currency
        Translator.Translate(Me)
    End Sub

    Private Sub Btn_OK_Click(sender As Object, e As EventArgs) Handles Btn_OK.Click
        Price = Convert.ToDecimal(Nud_Price.Value)
        Currency = Tb_Currency.Text
    End Sub
End Class