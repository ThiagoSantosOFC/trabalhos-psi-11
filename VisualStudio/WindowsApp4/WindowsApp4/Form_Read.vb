Public Class Form_Read
    Dim port_saver As String ' String que irá guardar o nome da porta caso acontecer algo que tenha que ser revertida a ação
    Public yessir As Integer = 0 ' Caso for para sair do programa
    Public ranger As Integer ' número a frente da palavra COM
    Public applied As Integer = 0 ' Caso for clicado no botão "aplicar" para não encerrar o programa se for cancelada a ação
    Public problem_arose As Integer = 0 ' Caso haja problema nas portas e que tenha que ser chamada as funções acerca das portas
    Public first_time As Integer = 0 ' Caso for aberta a Form pela primeira vez

    Private SDel As New SerialDelegate(AddressOf Displaydata) ' Criação de ponteiro tipo SerialDelegate direcionada a DisplayData
    Private Delegate Sub SerialDelegate(ByVal Buffer As String) ' Criação de instanciamento de um metodo em string

    Public Sub Displaydata(ByVal myString As String) ' Função que mete os valores em textbox e listbox
        txtHum.Text = ((Val(myString)))
        txtCels.Text = ((Val(myString)))
        ListBox1.Items.Add(((Val(myString))) & "ºC")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load  ' Quando a Form carrega
        txtBaud.Text = SerialPort_Arduino.BaudRate ' Meter o valor da BaudRate à vista do utilizador
        first_time = 1 ' Caso for a ligada a Form
        PortVerification() ' Total analise da porta
        PortVerification_lite() ' Parcial analise da porta (ver se pode ser aberta)
        first_time = 0
        forceit = 0 ' Obrigar a fechar a porta caso esteja aberta
    End Sub

    Private Sub SerialPort_Arduino_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort_Arduino.DataReceived ' Função que recebe os valores do Arduino
        If forceit <> 1 Then ' Caso esteja aberta a porta
            Dim ReceivedData As String = SerialPort_Arduino.ReadLine() ' Receber os valores do Arduino
            Me.Invoke(SDel, ReceivedData) ' executar o método
        End If

    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click ' Botão de aplicar porta/BaudRate
        applied = 1 ' Caso for clicado neste botao
        PortVerification_lite() ' chamar a função de parcial analise
        applied = 0
    End Sub

    Public Sub PortVerification() ' Analise Total da porta para que não haja problemas
        problem_arose = 1 ' Caso estiver a percorrer esta função, ou seja, tem algum problema ou para ser aplicada as novas alterações
        SerialPort_Arduino.BaudRate = txtBaud.Text ' Aplicar a nova BaudRate
        Try ' Tentar percorrer o seguinte código, ou seja tentar mudar a porta
            SerialPort_Arduino.Open() ' Tentar abrir a porta
            port_saver = SerialPort_Arduino.PortName ' Guardar a porta anterior para que a ação seja revertida caso for preciso
            If port_saver = "COM1" Then ' Se for a porta COM1
                MsgBox("Aviso!" & vbCrLf & vbCrLf & "A porta COM1 poderá estar inativa já que é a porta predefinida dos arduinos!" & vbCrLf & "Caso não houver transmissão de dados, insire uma outra porta compativel!")
            End If
            cbPort.Text = port_saver ' Mostrar ao utilizador a nova porta selecionada
        Catch ex As System.IO.IOException ' Caso for escolhida uma porta também inativa
            Do ' Repetir até houver alguma porta funcional
                port_saver = InputBox("A porta predefinida selecionada (" & SerialPort_Arduino.PortName & ") no programa está inativa" & vbCrLf & "Insire uma porta compativel")
                Try ' Tentar aplicar a porta
                    If port_saver = "" Then ' Se não for escolhido nada
                        If MsgBox("Pretende sair do programa, já que foi dada uma resposta em branco?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            If applied <> 1 Then ' Se foi no inicio da Form
                                yessir = 1 ' Guardar informação para desligar o programa
                            End If
                            Exit Do ' Sair do ciclo
                        ElseIf MsgBoxResult.No Then ' Caso responder que não
                            Exit Try ' Sair da tentativa
                        End If
                    End If
                    Dim mytext As String = port_saver ' Guardar informação da porta para uma string
                    Dim dummytext As String = Nothing ' Uma string que vai ter os numeros à frente da palavra COM
                    Dim myChars() As Char = mytext.ToCharArray() ' Array de caracteres
                    For Each ch As Char In myChars ' Para cada caracter
                        If Char.IsDigit(ch) Then ' Caso for um numero
                            dummytext += (ch) ' Meter esse numero na string
                        End If
                    Next ' proximo caracter
                    ranger = Val(dummytext) ' meter numa variavel os numeros
                    Select Case ranger
                        Case 0 To 100
                            If port_saver = ("COM" & ranger) Then
                                SerialPort_Arduino.PortName = port_saver
                                cbPort.Text = port_saver
                                Exit Do ' Parar o ciclo
                            End If
                        Case Else
                    End Select
                Catch exi As System.IO.IOException ' Se houver algum erro
                    MsgBox("Ocorreu um Erro!")
                Finally ' Para finalizar a tentativa
                    If port_saver = "COM1" Then
                        MsgBox("Aviso!" & vbCrLf & vbCrLf & "A porta COM1 poderá também estar inativa já que é a porta predefinida dos arduinos!" & vbCrLf & "Caso não houver transmissão de dados, insire uma outra porta compativel!")
                    End If
                End Try
            Loop
            If yessir = 1 Then ' Se quiser desligar o programa
                Me.Close()
            Else

            End If
        End Try
        problem_arose = 0 ' Guardar informação que acabou a analise
    End Sub



    Private Sub Form_Read_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing  ' Caso a From fechar
        If (SerialPort_Arduino.IsOpen = False) Then ' Se estiver a porta fechada
            If problem_arose = 1 Then ' Se estiver uma analise no momento

            ElseIf problem_arose = 0 Then
                SerialPort_Arduino.Open()
                SerialPort_Arduino.Write("2") ' Mandar ao Arduino parar o ciclo
                forceit = 1
                SerialPort_Arduino.Close()
            End If
        Else
            If problem_arose = 1 Then

            ElseIf problem_arose = 0 Then
                SerialPort_Arduino.Write("2")
                forceit = 1
                SerialPort_Arduino.Close()
            End If
        End If

    End Sub

    Public Sub PortVerification_lite() ' Analise parcial da porta
        If yessir <> 1 Then ' Caso não quiser desligar o programa
            Try ' Tentar ligar a porta
                SerialPort_Arduino.Close()
                SerialPort_Arduino.PortName = cbPort.Text
            Catch ex As System.IO.IOException
                SerialPort_Arduino.Close()
                MsgBox("Algo aconteceu de errado em termos de portas..." & vbCrLf & "Verifique a porta em uso em ambos Arduino e Programa")
                SerialPort_Arduino.PortName = port_saver
            Finally
                Try ' Tentar ligar a porta por uma outra maneira
                    port_saver = SerialPort_Arduino.PortName
                    SerialPort_Arduino.Open()
                Catch ex As System.IO.IOException
                    MsgBox("Algo aconteceu de errado em termos de portas..." & vbCrLf & "Verifique a porta em uso em ambos Arduino e Programa")
                    PortVerification()
                End Try
                If first_time = 0 Then
                    If port_saver = "COM1" Then
                        MsgBox("Aviso!" & vbCrLf & vbCrLf & "A porta COM1 poderá estar inativa já que é a porta predefinida dos arduinos!" & vbCrLf & "Caso não houver transmissão de dados, insire uma outra porta compativel!")
                    End If
                End If
                cbPort.Text = port_saver
            End Try
        Else
            Me.Close()
        End If
    End Sub

    Private Sub trAuto_scroll(sender As Object, e As EventArgs) Handles trAuto.Scroll ' Caso for mudado o tempo "automatico"
        Auto_Save() ' Chamar a função para aplicar as alterações do tempo
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer_Save.Tick ' Cada vez passar um certo tempo
        Save_Values() ' Guardar os dados
    End Sub

    Private Sub Timer_POP_Tick(sender As Object, e As EventArgs) Handles Timer_POP.Tick ' Tempo para aparecer a "label"
        lblPOP.Visible = False
        Timer_POP.Enabled = False ' Desligar o cronometro
    End Sub

    Public Sub Save_Values() ' Guardar os dados na ArrayList
        couting = couting + 1 ' Contagem de registos
        Try ' Tentar guardar os valores
            Timer_POP.Enabled = True
            lblPOP.Visible = True
            IdTMP._data = Date.Now ' O valor da data e hora do momento
            IdTMP._id = couting ' Valor da identificação
            If (CDec(txtCels.Text) >= 10 And CDec(txtCels.Text) <= 20) Then ' Caso estiver entre 10 a 20 graus
                IdTMP._tipo = True
            Else ' senão
                IdTMP._tipo = False
            End If
            IdTMP._humidade = txtHum.Text 'valor da humidade 
            IdTMP._valor = txtCels.Text ' Valor da temperatura da TextBox
            IdTMP.StoredTMP.Add(New Class_Main(IdTMP._id, IdTMP._data, IdTMP._humidade, IdTMP._valor, IdTMP._tipo)) ' Guardar todos os valores na ArrayList
        Catch ex As Exception ' Se houver algum valor corrompido ou não existente
            MsgBox("Algo aconteceu de errado" & vbCrLf & "Talvez foi tentado guardar algo que ainda não existe!")
        End Try

    End Sub

    Private Sub btnManual_Click(sender As Object, e As EventArgs) Handles btnManual.Click ' Se quiser guardar os valores manualmente
        Save_Values() ' Chamar a sua função
    End Sub

    Public Sub Auto_Save() ' Função de guardar os valores automaticamente
        If trAuto.Value = 0 Then
            chkAuto.Checked = False
            chkAuto.Enabled = False
            chkAuto.Text = "Desligado"
        ElseIf trAuto.Value = 1 Then
            chkAuto.Checked = True
            chkAuto.Enabled = True
            chkAuto.Text = "A cada 30 segundos"
            Timer_Save.Interval = 30000
        ElseIf trAuto.Value = 2 Then
            chkAuto.Checked = True
            chkAuto.Enabled = True
            chkAuto.Text = "A cada minuto"
            Timer_Save.Interval = 60000
        ElseIf trAuto.Value = 3 Then
            chkAuto.Checked = True
            chkAuto.Enabled = True
            chkAuto.Text = "A cada 2 minutos"
            Timer_Save.Interval = 120000
        ElseIf trAuto.Value = 4 Then
            chkAuto.Checked = True
            chkAuto.Enabled = True
            chkAuto.Text = "A cada 3 minutos"
            Timer_Save.Interval = 180000
        ElseIf trAuto.Value = 5 Then
            chkAuto.Checked = True
            chkAuto.Enabled = True
            chkAuto.Text = "A cada 5 minutos"
            Timer_Save.Interval = 300000
        End If
    End Sub


    Private Sub btnStart_Click_1(sender As Object, e As EventArgs) Handles btnStart.Click
        If (SerialPort_Arduino.IsOpen = False) Then ' Caso a porta estiver fechada
            SerialPort_Arduino.Open() ' Abri-la
        End If
        SerialPort_Arduino.Write("1") ' Mandar informação ao Arduino para começar a leitura
    End Sub

End Class
