Public Class frmBoasVindas

    Private Sub frmBoasVindas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub lblNome_Click(sender As Object, e As EventArgs) Handles lblNome.Click

    End Sub


    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim nome As String
        nome = TextBox1.Text

        MessageBox.Show("Olá " & nome & "! Bem-vindo ao Visual Basic")

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
