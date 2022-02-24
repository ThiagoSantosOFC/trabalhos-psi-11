<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Read
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Read))
        Me.btnApply = New System.Windows.Forms.Button()
        Me.lblBaud = New System.Windows.Forms.Label()
        Me.txtBaud = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblFahr = New System.Windows.Forms.Label()
        Me.lblCelc = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.cbPort = New System.Windows.Forms.ComboBox()
        Me.txtFahr = New System.Windows.Forms.TextBox()
        Me.txtCels = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.gbSalvar = New System.Windows.Forms.GroupBox()
        Me.lblPOP = New System.Windows.Forms.Label()
        Me.btnManual = New System.Windows.Forms.Button()
        Me.lblAutoTr = New System.Windows.Forms.Label()
        Me.trAuto = New System.Windows.Forms.TrackBar()
        Me.chkAuto = New System.Windows.Forms.CheckBox()
        Me.Timer_Save = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_POP = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort_Arduino = New System.IO.Ports.SerialPort(Me.components)
        Me.lblHum = New System.Windows.Forms.Label()
        Me.txtHum = New System.Windows.Forms.TextBox()
        Me.gbSalvar.SuspendLayout()
        CType(Me.trAuto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(198, 425)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 22
        Me.btnApply.Text = "Aplicar"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'lblBaud
        '
        Me.lblBaud.AutoSize = True
        Me.lblBaud.Location = New System.Drawing.Point(140, 407)
        Me.lblBaud.Name = "lblBaud"
        Me.lblBaud.Size = New System.Drawing.Size(55, 13)
        Me.lblBaud.TabIndex = 21
        Me.lblBaud.Text = "BaudRate"
        '
        'txtBaud
        '
        Me.txtBaud.Location = New System.Drawing.Point(12, 401)
        Me.txtBaud.Name = "txtBaud"
        Me.txtBaud.Size = New System.Drawing.Size(121, 20)
        Me.txtBaud.TabIndex = 20
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(279, 425)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 19
        Me.btnStart.Text = "Começar"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblFahr
        '
        Me.lblFahr.AutoSize = True
        Me.lblFahr.Location = New System.Drawing.Point(179, 56)
        Me.lblFahr.Name = "lblFahr"
        Me.lblFahr.Size = New System.Drawing.Size(57, 13)
        Me.lblFahr.TabIndex = 18
        Me.lblFahr.Text = "Fahrenheit"
        '
        'lblCelc
        '
        Me.lblCelc.AutoSize = True
        Me.lblCelc.Location = New System.Drawing.Point(22, 56)
        Me.lblCelc.Name = "lblCelc"
        Me.lblCelc.Size = New System.Drawing.Size(40, 13)
        Me.lblCelc.TabIndex = 17
        Me.lblCelc.Text = "Celsius"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(139, 430)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(32, 13)
        Me.lblPort.TabIndex = 16
        Me.lblPort.Text = "Porta"
        '
        'cbPort
        '
        Me.cbPort.FormattingEnabled = True
        Me.cbPort.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8"})
        Me.cbPort.Location = New System.Drawing.Point(12, 427)
        Me.cbPort.Name = "cbPort"
        Me.cbPort.Size = New System.Drawing.Size(121, 21)
        Me.cbPort.TabIndex = 15
        '
        'txtFahr
        '
        Me.txtFahr.Location = New System.Drawing.Point(241, 56)
        Me.txtFahr.Name = "txtFahr"
        Me.txtFahr.Size = New System.Drawing.Size(100, 20)
        Me.txtFahr.TabIndex = 14
        '
        'txtCels
        '
        Me.txtCels.Location = New System.Drawing.Point(68, 53)
        Me.txtCels.Name = "txtCels"
        Me.txtCels.Size = New System.Drawing.Size(100, 20)
        Me.txtCels.TabIndex = 13
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 79)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(339, 316)
        Me.ListBox1.TabIndex = 12
        '
        'gbSalvar
        '
        Me.gbSalvar.Controls.Add(Me.lblPOP)
        Me.gbSalvar.Controls.Add(Me.btnManual)
        Me.gbSalvar.Controls.Add(Me.lblAutoTr)
        Me.gbSalvar.Controls.Add(Me.trAuto)
        Me.gbSalvar.Controls.Add(Me.chkAuto)
        Me.gbSalvar.Location = New System.Drawing.Point(12, 464)
        Me.gbSalvar.Name = "gbSalvar"
        Me.gbSalvar.Size = New System.Drawing.Size(342, 71)
        Me.gbSalvar.TabIndex = 23
        Me.gbSalvar.TabStop = False
        Me.gbSalvar.Text = "Guardar Valor Atual"
        '
        'lblPOP
        '
        Me.lblPOP.AutoSize = True
        Me.lblPOP.Location = New System.Drawing.Point(272, 48)
        Me.lblPOP.Name = "lblPOP"
        Me.lblPOP.Size = New System.Drawing.Size(57, 13)
        Me.lblPOP.TabIndex = 16
        Me.lblPOP.Text = "Guardado!"
        Me.lblPOP.Visible = False
        '
        'btnManual
        '
        Me.btnManual.Location = New System.Drawing.Point(191, 43)
        Me.btnManual.Name = "btnManual"
        Me.btnManual.Size = New System.Drawing.Size(75, 23)
        Me.btnManual.TabIndex = 15
        Me.btnManual.Text = "Guardar"
        Me.btnManual.UseVisualStyleBackColor = True
        '
        'lblAutoTr
        '
        Me.lblAutoTr.AutoSize = True
        Me.lblAutoTr.Location = New System.Drawing.Point(6, 51)
        Me.lblAutoTr.Name = "lblAutoTr"
        Me.lblAutoTr.Size = New System.Drawing.Size(178, 13)
        Me.lblAutoTr.TabIndex = 14
        Me.lblAutoTr.Text = "Tempo de guardar automaticamente"
        '
        'trAuto
        '
        Me.trAuto.Location = New System.Drawing.Point(6, 19)
        Me.trAuto.Maximum = 5
        Me.trAuto.Name = "trAuto"
        Me.trAuto.Size = New System.Drawing.Size(184, 45)
        Me.trAuto.TabIndex = 12
        Me.trAuto.Value = 4
        '
        'chkAuto
        '
        Me.chkAuto.AutoSize = True
        Me.chkAuto.Checked = True
        Me.chkAuto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAuto.Location = New System.Drawing.Point(196, 20)
        Me.chkAuto.Name = "chkAuto"
        Me.chkAuto.Size = New System.Drawing.Size(108, 17)
        Me.chkAuto.TabIndex = 13
        Me.chkAuto.Text = "A cada 3 minutos"
        Me.chkAuto.UseVisualStyleBackColor = True
        '
        'Timer_Save
        '
        Me.Timer_Save.Interval = 1900000
        '
        'Timer_POP
        '
        Me.Timer_POP.Interval = 1000
        '
        'SerialPort_Arduino
        '
        Me.SerialPort_Arduino.PortName = "COM8"
        '
        'lblHum
        '
        Me.lblHum.AutoSize = True
        Me.lblHum.Location = New System.Drawing.Point(12, 29)
        Me.lblHum.Name = "lblHum"
        Me.lblHum.Size = New System.Drawing.Size(55, 13)
        Me.lblHum.TabIndex = 25
        Me.lblHum.Text = "Humidade"
        '
        'txtHum
        '
        Me.txtHum.Location = New System.Drawing.Point(68, 26)
        Me.txtHum.Name = "txtHum"
        Me.txtHum.Size = New System.Drawing.Size(100, 20)
        Me.txtHum.TabIndex = 24
        '
        'Form_Read
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 559)
        Me.Controls.Add(Me.lblHum)
        Me.Controls.Add(Me.txtHum)
        Me.Controls.Add(Me.gbSalvar)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.lblBaud)
        Me.Controls.Add(Me.txtBaud)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblFahr)
        Me.Controls.Add(Me.lblCelc)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.cbPort)
        Me.Controls.Add(Me.txtFahr)
        Me.Controls.Add(Me.txtCels)
        Me.Controls.Add(Me.ListBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Read"
        Me.Text = "Leitor"
        Me.gbSalvar.ResumeLayout(False)
        Me.gbSalvar.PerformLayout()
        CType(Me.trAuto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnApply As Button
    Friend WithEvents lblBaud As Label
    Friend WithEvents txtBaud As TextBox
    Friend WithEvents btnStart As Button
    Friend WithEvents lblFahr As Label
    Friend WithEvents lblCelc As Label
    Friend WithEvents lblPort As Label
    Friend WithEvents cbPort As ComboBox
    Friend WithEvents txtFahr As TextBox
    Friend WithEvents txtCels As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents gbSalvar As GroupBox
    Friend WithEvents lblPOP As Label
    Friend WithEvents btnManual As Button
    Friend WithEvents lblAutoTr As Label
    Friend WithEvents trAuto As TrackBar
    Friend WithEvents chkAuto As CheckBox
    Friend WithEvents Timer_Save As Timer
    Friend WithEvents Timer_POP As Timer
    Friend WithEvents SerialPort_Arduino As IO.Ports.SerialPort
    Friend WithEvents lblHum As Label
    Friend WithEvents txtHum As TextBox
End Class
