Public Class frmCalcula
    Private Sub frmCalcula_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNum3_Click(sender As Object, e As EventArgs) Handles btnNum3.Click
        If btnVisor.Text = lblValor1.Text Then
            btnVisor.Text = "3"
        ElseIf btnVisor.Text = "0." Then
            btnVisor.Text = "3"
        ElseIf btnVisor.Text = lblValor3.Text Then
            btnVisor.Text = "3"
        Else
            btnVisor.Text = btnVisor.Text & "3"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        btnVisor.Text = "0."
        lblValor1.Text = ""
        lblValor2.Text = ""
        lblValor3.Text = ""
    End Sub

    Private Sub btnSoma_Click(sender As Object, e As EventArgs) Handles btnSoma.Click
        lblValor2.Text = "+"
        lblValor1.Text = btnVisor.Text
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        If lblValor1.Text > "" And lblValor2.Text = "+" Then
            btnVisor.Text = Val(lblValor1.Text) + Val(btnVisor.Text)
            lblValor3.Text = btnVisor.Text

        ElseIf lblValor2.Text > "" And lblValor2.Text = "-" Then
            btnVisor.Text = Val(lblValor1.Text) - Val(btnVisor.Text)
            lblValor3.Text = btnVisor.Text

        ElseIf lblValor2.Text > "" And lblValor2.Text = "x" Then
            btnVisor.Text = Val(lblValor1.Text) * Val(btnVisor.Text)
            lblValor3.Text = btnVisor.Text

        ElseIf lblValor2.Text > "" And lblValor2.Text = "/" Then
            btnVisor.Text = Val(lblValor1.Text) / Val(btnVisor.Text)
            lblValor3.Text = btnVisor.Text

        End If
    End Sub

    Private Sub btnPonto_Click(sender As Object, e As EventArgs) Handles btnPonto.Click
        If btnVisor.Text = "0." Then
            btnVisor.Text = "."

        ElseIf btnVisor.Text = lblValor3.Text Then
            btnVisor.Text = "."


        ElseIf btnVisor.Text = lblValor1.Text Then
            btnVisor.Text = "."

        Else
            If btnVisor.Text.Contains(".") Then
            Else
                btnVisor.Text = btnVisor.Text = "."
            End If
        End If

    End Sub

    Private Sub btnNum0_Click(sender As Object, e As EventArgs) Handles btnNum0.Click
        If btnVisor.Text = lblValor1.Text Then
            btnVisor.Text = "0."

        ElseIf btnVisor.Text = "0." Then
            btnVisor.Text = "0."

        ElseIf btnVisor.Text = "0" Then
            btnVisor.Text = "0."

        ElseIf btnVisor.Text = lblValor3.text Then
            btnVisor.Text = "0."

        Else
            btnVisor.Text = btnVisor.Text & "0"
        End If
    End Sub

    Private Sub btnSubtrai_Click(sender As Object, e As EventArgs) Handles btnSubtrai.Click
        lblValor2.Text = "-"
        lblValor1.Text = btnVisor.Text
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        End
    End Sub

    Private Sub btnNum2_Click(sender As Object, e As EventArgs) Handles btnNum2.Click
        If btnVisor.Text = lblValor1.Text Then
            btnVisor.Text = "2"
        ElseIf btnVisor.Text = "0." Then
            btnVisor.Text = "2"
        ElseIf btnVisor.Text = lblValor3.Text Then
            btnVisor.Text = "2"
        Else
            btnVisor.Text = btnVisor.Text & "2"
        End If
    End Sub

    Private Sub btnNum1_Click(sender As Object, e As EventArgs) Handles btnNum1.Click
        If btnVisor.Text = lblValor1.Text Then
            btnVisor.Text = "1"
        ElseIf btnVisor.Text = "0." Then
            btnVisor.Text = "1"
        ElseIf btnVisor.Text = lblValor3.Text Then
            btnVisor.Text = "1"
        Else
            btnVisor.Text = btnVisor.Text & "1"
        End If
    End Sub

    Private Sub btnMultiplica_Click(sender As Object, e As EventArgs) Handles btnMultiplica.Click
        lblValor2.Text = "x"
        lblValor1.Text = btnVisor.Text
    End Sub

    Private Sub btnNum6_Click(sender As Object, e As EventArgs) Handles btnNum6.Click
        If btnVisor.Text = lblValor1.Text Then
            btnVisor.Text = "6"
        ElseIf btnVisor.Text = "0." Then
            btnVisor.Text = "6"
        ElseIf btnVisor.Text = lblValor3.Text Then
            btnVisor.Text = "6"
        Else
            btnVisor.Text = btnVisor.Text & "6"
        End If
    End Sub

    Private Sub btnNum5_Click(sender As Object, e As EventArgs) Handles btnNum5.Click
        If btnVisor.Text = lblValor1.Text Then
            btnVisor.Text = "5"
        ElseIf btnVisor.Text = "0." Then
            btnVisor.Text = "5"
        ElseIf btnVisor.Text = lblValor3.Text Then
            btnVisor.Text = "5"
        Else
            btnVisor.Text = btnVisor.Text & "5"
        End If
    End Sub

    Private Sub btnNum4_Click(sender As Object, e As EventArgs) Handles btnNum4.Click
        If btnVisor.Text = lblValor1.Text Then
            btnVisor.Text = "4"
        ElseIf btnVisor.Text = "0." Then
            btnVisor.Text = "4"
        ElseIf btnVisor.Text = lblValor3.Text Then
            btnVisor.Text = "4"
        Else
            btnVisor.Text = btnVisor.Text & "4"
        End If
    End Sub

    Private Sub btnBarra_Click(sender As Object, e As EventArgs) Handles btnBarra.Click
        lblValor2.Text = "/"
        lblValor1.Text = btnVisor.Text
    End Sub

    Private Sub btnNum9_Click(sender As Object, e As EventArgs) Handles btnNum9.Click
        If btnVisor.Text = lblValor1.Text Then
            btnVisor.Text = "9"
        ElseIf btnVisor.Text = "0." Then
            btnVisor.Text = "9"
        ElseIf btnVisor.Text = lblValor3.Text Then
            btnVisor.Text = "9"
        Else
            btnVisor.Text = btnVisor.Text & "9"
        End If
    End Sub

    Private Sub BtnNum8_Click(sender As Object, e As EventArgs) Handles BtnNum8.Click
        If btnVisor.Text = lblValor1.Text Then
            btnVisor.Text = "8"
        ElseIf btnVisor.Text = "0." Then
            btnVisor.Text = "8"
        ElseIf btnVisor.Text = lblValor3.Text Then
            btnVisor.Text = "8"
        Else
            btnVisor.Text = btnVisor.Text & "8"
        End If
    End Sub

    Private Sub btnNum7_Click(sender As Object, e As EventArgs) Handles btnNum7.Click
        If btnVisor.Text = lblValor1.Text Then
            btnVisor.Text = "7"
        ElseIf btnVisor.Text = "0." Then
            btnVisor.Text = "7"
        ElseIf btnVisor.Text = lblValor3.Text Then
            btnVisor.Text = "7"
        Else
            btnVisor.Text = btnVisor.Text & "7"
        End If
    End Sub

    Private Sub btnVisor_Click(sender As Object, e As EventArgs) Handles btnVisor.Click

    End Sub
End Class
