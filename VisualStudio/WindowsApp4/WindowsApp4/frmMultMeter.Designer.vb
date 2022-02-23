<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultMeter
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblconexao = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Idleitura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Datadaleitura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TemepraturaLida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.humidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OK = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 110)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Abrir Conexão"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(199, 328)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(181, 110)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Conectar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10"})
        Me.ComboBox1.Location = New System.Drawing.Point(387, 416)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(514, 277)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(205, 161)
        Me.TextBox1.TabIndex = 3
        '
        'lblconexao
        '
        Me.lblconexao.AutoSize = True
        Me.lblconexao.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconexao.Location = New System.Drawing.Point(12, 277)
        Me.lblconexao.Name = "lblconexao"
        Me.lblconexao.Size = New System.Drawing.Size(263, 33)
        Me.lblconexao.TabIndex = 8
        Me.lblconexao.Text = "Estado da conexão"
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM8"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Idleitura, Me.Datadaleitura, Me.TemepraturaLida, Me.humidade, Me.OK})
        Me.DataGridView1.Location = New System.Drawing.Point(18, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(543, 193)
        Me.DataGridView1.TabIndex = 9
        '
        'Idleitura
        '
        Me.Idleitura.HeaderText = "ID leitura"
        Me.Idleitura.Name = "Idleitura"
        '
        'Datadaleitura
        '
        Me.Datadaleitura.HeaderText = "Data da leitura"
        Me.Datadaleitura.Name = "Datadaleitura"
        '
        'TemepraturaLida
        '
        Me.TemepraturaLida.HeaderText = "Temepratura Lida"
        Me.TemepraturaLida.Name = "TemepraturaLida"
        '
        'humidade
        '
        Me.humidade.HeaderText = "Humidade Lida"
        Me.humidade.Name = "humidade"
        '
        'OK
        '
        Me.OK.HeaderText = "ok"
        Me.OK.Name = "OK"
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'frmMultMeter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblconexao)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmMultMeter"
        Me.Text = "MultiMeter"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblconexao As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Idleitura As DataGridViewTextBoxColumn
    Friend WithEvents Datadaleitura As DataGridViewTextBoxColumn
    Friend WithEvents TemepraturaLida As DataGridViewTextBoxColumn
    Friend WithEvents humidade As DataGridViewTextBoxColumn
    Friend WithEvents OK As DataGridViewCheckBoxColumn
    Friend WithEvents Timer1 As Timer
End Class
