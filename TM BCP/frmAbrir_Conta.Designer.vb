<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbrir_Conta
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
        Me.btnAbrir_Conta = New System.Windows.Forms.Button()
        Me.txbNomeCliente = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblNif = New System.Windows.Forms.Label()
        Me.txbNIF_Cliente = New System.Windows.Forms.TextBox()
        Me.lblNumCliente = New System.Windows.Forms.Label()
        Me.txbNumero_Cliente = New System.Windows.Forms.TextBox()
        Me.lblNumConta = New System.Windows.Forms.Label()
        Me.txbNumConta_Cliente = New System.Windows.Forms.TextBox()
        Me.lblProfissao = New System.Windows.Forms.Label()
        Me.txbProfissãoCliente = New System.Windows.Forms.TextBox()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.txbEnderecoCliente = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAbrir_Conta
        '
        Me.btnAbrir_Conta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAbrir_Conta.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAbrir_Conta.Location = New System.Drawing.Point(307, 331)
        Me.btnAbrir_Conta.Name = "btnAbrir_Conta"
        Me.btnAbrir_Conta.Size = New System.Drawing.Size(99, 70)
        Me.btnAbrir_Conta.TabIndex = 0
        Me.btnAbrir_Conta.Text = "Abrir conta"
        Me.btnAbrir_Conta.UseVisualStyleBackColor = True
        '
        'txbNomeCliente
        '
        Me.txbNomeCliente.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txbNomeCliente.Location = New System.Drawing.Point(58, 53)
        Me.txbNomeCliente.Name = "txbNomeCliente"
        Me.txbNomeCliente.Size = New System.Drawing.Size(194, 25)
        Me.txbNomeCliente.TabIndex = 1
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNome.Location = New System.Drawing.Point(58, 32)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(184, 20)
        Me.lblNome.TabIndex = 2
        Me.lblNome.Text = "Nome completo do cliente"
        '
        'lblNif
        '
        Me.lblNif.AutoSize = True
        Me.lblNif.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNif.Location = New System.Drawing.Point(58, 118)
        Me.lblNif.Name = "lblNif"
        Me.lblNif.Size = New System.Drawing.Size(101, 20)
        Me.lblNif.TabIndex = 4
        Me.lblNif.Text = "NIF do cliente"
        '
        'txbNIF_Cliente
        '
        Me.txbNIF_Cliente.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txbNIF_Cliente.Location = New System.Drawing.Point(58, 139)
        Me.txbNIF_Cliente.Name = "txbNIF_Cliente"
        Me.txbNIF_Cliente.Size = New System.Drawing.Size(194, 25)
        Me.txbNIF_Cliente.TabIndex = 3
        '
        'lblNumCliente
        '
        Me.lblNumCliente.AutoSize = True
        Me.lblNumCliente.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNumCliente.Location = New System.Drawing.Point(58, 185)
        Me.lblNumCliente.Name = "lblNumCliente"
        Me.lblNumCliente.Size = New System.Drawing.Size(137, 20)
        Me.lblNumCliente.TabIndex = 6
        Me.lblNumCliente.Text = "Número  do cliente"
        '
        'txbNumero_Cliente
        '
        Me.txbNumero_Cliente.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txbNumero_Cliente.Location = New System.Drawing.Point(58, 206)
        Me.txbNumero_Cliente.Name = "txbNumero_Cliente"
        Me.txbNumero_Cliente.Size = New System.Drawing.Size(194, 25)
        Me.txbNumero_Cliente.TabIndex = 5
        '
        'lblNumConta
        '
        Me.lblNumConta.AutoSize = True
        Me.lblNumConta.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNumConta.Location = New System.Drawing.Point(464, 32)
        Me.lblNumConta.Name = "lblNumConta"
        Me.lblNumConta.Size = New System.Drawing.Size(195, 20)
        Me.lblNumConta.TabIndex = 8
        Me.lblNumConta.Text = "Número de conta do cliente"
        '
        'txbNumConta_Cliente
        '
        Me.txbNumConta_Cliente.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txbNumConta_Cliente.Location = New System.Drawing.Point(464, 53)
        Me.txbNumConta_Cliente.Name = "txbNumConta_Cliente"
        Me.txbNumConta_Cliente.Size = New System.Drawing.Size(195, 25)
        Me.txbNumConta_Cliente.TabIndex = 7
        '
        'lblProfissao
        '
        Me.lblProfissao.AutoSize = True
        Me.lblProfissao.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblProfissao.Location = New System.Drawing.Point(464, 118)
        Me.lblProfissao.Name = "lblProfissao"
        Me.lblProfissao.Size = New System.Drawing.Size(138, 20)
        Me.lblProfissao.TabIndex = 10
        Me.lblProfissao.Text = "Profissão do cliente"
        '
        'txbProfissãoCliente
        '
        Me.txbProfissãoCliente.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txbProfissãoCliente.Location = New System.Drawing.Point(464, 139)
        Me.txbProfissãoCliente.Name = "txbProfissãoCliente"
        Me.txbProfissãoCliente.Size = New System.Drawing.Size(195, 25)
        Me.txbProfissãoCliente.TabIndex = 9
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEndereco.Location = New System.Drawing.Point(464, 185)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(140, 20)
        Me.lblEndereco.TabIndex = 12
        Me.lblEndereco.Text = "Endereço do cliente"
        '
        'txbEnderecoCliente
        '
        Me.txbEnderecoCliente.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txbEnderecoCliente.Location = New System.Drawing.Point(464, 206)
        Me.txbEnderecoCliente.Name = "txbEnderecoCliente"
        Me.txbEnderecoCliente.Size = New System.Drawing.Size(195, 25)
        Me.txbEnderecoCliente.TabIndex = 11
        '
        'frmAbrir_Conta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 449)
        Me.Controls.Add(Me.lblEndereco)
        Me.Controls.Add(Me.txbEnderecoCliente)
        Me.Controls.Add(Me.lblProfissao)
        Me.Controls.Add(Me.txbProfissãoCliente)
        Me.Controls.Add(Me.lblNumConta)
        Me.Controls.Add(Me.txbNumConta_Cliente)
        Me.Controls.Add(Me.lblNumCliente)
        Me.Controls.Add(Me.txbNumero_Cliente)
        Me.Controls.Add(Me.lblNif)
        Me.Controls.Add(Me.txbNIF_Cliente)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.txbNomeCliente)
        Me.Controls.Add(Me.btnAbrir_Conta)
        Me.Name = "frmAbrir_Conta"
        Me.Text = "Abrir contas T&M BCP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbrir_Conta As Button
    Friend WithEvents txbNomeCliente As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents lblNif As Label
    Friend WithEvents txbNIF_Cliente As TextBox
    Friend WithEvents lblNumCliente As Label
    Friend WithEvents txbNumero_Cliente As TextBox
    Friend WithEvents lblNumConta As Label
    Friend WithEvents txbNumConta_Cliente As TextBox
    Friend WithEvents lblProfissao As Label
    Friend WithEvents txbProfissãoCliente As TextBox
    Friend WithEvents lblEndereco As Label
    Friend WithEvents txbEnderecoCliente As TextBox
End Class
