Public Class jogo

    Dim intNum As Integer
    Dim rand As New Random
    Dim decGuess As Decimal
    Dim intCount As Integer


    Private Sub txbNumJ1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txbNumInsJogador2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnTryLuck_Click(sender As Object, e As EventArgs)

        txbNumJ1.Clear()
        intNum = rand.Next(0, 100)



    End Sub
End Class