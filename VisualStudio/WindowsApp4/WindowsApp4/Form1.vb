Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SerialPort1.PortName = ComboBox1.Text
        Try
            SerialPort1.Open()

            Label5.Text = "Conexão Ativa"
        Catch ex As Exception
            MsgBox("Porta não está aberta")
            If SerialPort1.IsOpen = False Then
                MsgBox("Portá não está aberta")
            End If
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Timer1.Enabled = True

        Catch ex As Exception
            MsgBox("Com Errada")
            Label5.Text = "Sem Conexão"

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            TextBox1.Text = SerialPort1.ReadExisting
            Dim TemperaturaSensor As String
            TemperaturaSensor = (TextBox1.Lines(1).ToString)

            Dim UmidadeSensor As String
            UmidadeSensor = (TextBox1.Lines(0).ToString)

            Label1.Text = TemperaturaSensor / 100.0
            Label2.Text = UmidadeSensor / 100.0



        Catch ex As Exception


        End Try
    End Sub
End Class
