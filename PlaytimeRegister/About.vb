Imports LanguageService.Windows.Forms

Public Class About

    Public Sub New()
        InitializeComponent()
        Translator.Translate(Me)
    End Sub

    Private Sub LLbl_SendMail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLbl_SendMail.LinkClicked
        Process.Start("mailto: mortens.4444@gmail.com")
    End Sub
End Class