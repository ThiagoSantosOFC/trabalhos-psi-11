Public Class Form_Find
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click ' Procurar o registo
        If Val(txtSearch.Text) <= 0 Or Val(txtSearch.Text) > couting Then ' Caso for um registo invalido
            MsgBox("Id inválido!")
        Else
            Try ' Tentar procurar informação sobre o registo
                For Each obj As Class_Main In IdTMP.StoredTMP ' Criar uma variavel que vai passar pela ArrayList toda
                    If obj._id = Val(txtSearch.Text) Then ' Se o id na ArrayList for o pretendente
                        lblDate.Text = ("Data/Hora: " & obj._data)
                        lblTMP.Text = ("Temperatura: " & obj._valor & "ºC")
                        lblHUM.Text = ("Humidade:" & obj._humidade & "%")
                        If obj._tipo = True Then
                            lblType.Text = ("Está entre 10 a 20 ºC ?: Sim")
                        Else
                            lblType.Text = ("Está entre 10 a 20 ºC ?: Não")
                        End If
                    End If
                Next obj
            Catch ex As Exception ' Caso houver algum erro no processo
                MsgBox("Informação não existente ou corrompida")
            End Try
        End If
    End Sub
End Class

