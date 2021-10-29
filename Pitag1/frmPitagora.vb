Public Class frmPitagora
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If String.IsNullOrEmpty(txtA.Text) And String.IsNullOrEmpty(txtB.Text) And String.IsNullOrEmpty(txtH.Text) Then
            MessageBox.Show("Informe pelo menos dois valores para calcular...")
        ElseIf Not String.IsNullOrEmpty(txtA.Text) And Not String.IsNullOrEmpty(txtB.Text) Then
            Dim a As Single = Convert.ToSingle(txtA.Text)
            Dim b As Single = Convert.ToSingle(txtB.Text)
        End If
    End Sub

    Private Sub frmPitagora_Load(sender As Object, e As EventArgs)

    End Sub

End Class
