Public Class frmLightManager
    Dim l1 = 0 'LED STATUS'
    Dim l2 = 0 'LED STATUS'
    Dim l3 = 0 'LED STATUS'
    Dim l4 = 0 'LED STATUS'

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If (l1 = 0) Then
            SerialPort1.Open()
            SerialPort1.Write("1")

            SerialPort1.Close()
            PictureBox1.Image = My.Resources.onLamp
            l1 = 1
        Else
            SerialPort1.Open()
            SerialPort1.Write("0")

            SerialPort1.Close()
            PictureBox1.Image = My.Resources.OffLamp
            l1 = 0
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If (l2 = 0) Then
            SerialPort1.Open()
            SerialPort1.Write("3")

            SerialPort1.Close()
            PictureBox2.Image = My.Resources.onLamp
            l2 = 1
        Else
            SerialPort1.Open()
            SerialPort1.Write("2")

            SerialPort1.Close()
            PictureBox2.Image = My.Resources.OffLamp
            l2 = 0
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If (l3 = 0) Then
            SerialPort1.Open()
            SerialPort1.Write("5")

            SerialPort1.Close()
            PictureBox3.Image = My.Resources.onLamp
            l3 = 1
        Else
            SerialPort1.Open()
            SerialPort1.Write("4")

            SerialPort1.Close()
            PictureBox3.Image = My.Resources.OffLamp
            l3 = 0
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If (l4 = 0) Then
            SerialPort1.Open()
            SerialPort1.Write("7")

            SerialPort1.Close()
            PictureBox4.Image = My.Resources.onLamp
            l4 = 1
        Else
            SerialPort1.Open()
            SerialPort1.Write("6")

            SerialPort1.Close()
            PictureBox4.Image = My.Resources.OffLamp
            l4 = 0
        End If
    End Sub
End Class
