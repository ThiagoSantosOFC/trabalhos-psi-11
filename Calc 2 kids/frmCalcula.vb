Public Class frmCalcula

    Private Sub btnSoma_Click(sender As Object, e As EventArgs) Handles btnSoma.Click
        txbResultado.Text = Val(txbOperacao1.Text) + Val(txbOperacao2.Text)
    End Sub

    Private Sub btnSubtracao_Click(sender As Object, e As EventArgs) Handles btnSubtracao.Click
        txbResultado.Text = Val(txbOperacao1.Text) - Val(txbOperacao2.Text)
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        txbResultado.Text = Val(txbOperacao1.Text) / Val(txbOperacao2.Text)
    End Sub

    Private Sub btnMultiplica_Click(sender As Object, e As EventArgs) Handles btnMultiplica.Click
        txbResultado.Text = Val(txbOperacao1.Text) * Val(txbOperacao2.Text)
    End Sub
End Class
