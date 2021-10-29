Public Class Form1
    Private Sub frmBemVindo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        Dim nome As String
        nome = txbNome.Text
        MessageBox.Show("Olá " & nome & "! Bem vindo ao Visual Basic")
    End Sub

    Private Sub txbNome_TextChanged(sender As Object, e As EventArgs) Handles txbNome.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblH.Click

    End Sub
End Class
