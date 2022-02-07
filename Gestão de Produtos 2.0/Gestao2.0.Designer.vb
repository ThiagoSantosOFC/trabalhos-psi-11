<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestaoProdutos
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
        Me.lbDados = New System.Windows.Forms.ListBox()
        Me.btnGuardaDados = New System.Windows.Forms.Button()
        Me.btnLimparDados = New System.Windows.Forms.Button()
        Me.btnInsereDados = New System.Windows.Forms.Button()
        Me.btnFecharPrograma = New System.Windows.Forms.Button()
        Me.txb1Codigo = New System.Windows.Forms.TextBox()
        Me.txb2Descricao = New System.Windows.Forms.TextBox()
        Me.txb3Categoria = New System.Windows.Forms.TextBox()
        Me.txb4Preco = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAtualizaDados = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbDados
        '
        Me.lbDados.FormattingEnabled = True
        Me.lbDados.Location = New System.Drawing.Point(451, 12)
        Me.lbDados.Name = "lbDados"
        Me.lbDados.Size = New System.Drawing.Size(186, 381)
        Me.lbDados.TabIndex = 0
        '
        'btnGuardaDados
        '
        Me.btnGuardaDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardaDados.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardaDados.Location = New System.Drawing.Point(199, 305)
        Me.btnGuardaDados.Name = "btnGuardaDados"
        Me.btnGuardaDados.Size = New System.Drawing.Size(186, 46)
        Me.btnGuardaDados.TabIndex = 1
        Me.btnGuardaDados.Text = "Gravar os dados"
        Me.btnGuardaDados.UseVisualStyleBackColor = True
        '
        'btnLimparDados
        '
        Me.btnLimparDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimparDados.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimparDados.Location = New System.Drawing.Point(7, 357)
        Me.btnLimparDados.Name = "btnLimparDados"
        Me.btnLimparDados.Size = New System.Drawing.Size(186, 46)
        Me.btnLimparDados.TabIndex = 2
        Me.btnLimparDados.Text = "Apagar os dados"
        Me.btnLimparDados.UseVisualStyleBackColor = True
        '
        'btnInsereDados
        '
        Me.btnInsereDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsereDados.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsereDados.Location = New System.Drawing.Point(7, 305)
        Me.btnInsereDados.Name = "btnInsereDados"
        Me.btnInsereDados.Size = New System.Drawing.Size(186, 46)
        Me.btnInsereDados.TabIndex = 3
        Me.btnInsereDados.Text = "Inserir os dados"
        Me.btnInsereDados.UseVisualStyleBackColor = True
        '
        'btnFecharPrograma
        '
        Me.btnFecharPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFecharPrograma.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFecharPrograma.Location = New System.Drawing.Point(519, 410)
        Me.btnFecharPrograma.Name = "btnFecharPrograma"
        Me.btnFecharPrograma.Size = New System.Drawing.Size(118, 46)
        Me.btnFecharPrograma.TabIndex = 4
        Me.btnFecharPrograma.Text = "Sair?"
        Me.btnFecharPrograma.UseVisualStyleBackColor = True
        '
        'txb1Codigo
        '
        Me.txb1Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txb1Codigo.Location = New System.Drawing.Point(7, 86)
        Me.txb1Codigo.Name = "txb1Codigo"
        Me.txb1Codigo.Size = New System.Drawing.Size(246, 26)
        Me.txb1Codigo.TabIndex = 5
        '
        'txb2Descricao
        '
        Me.txb2Descricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txb2Descricao.Location = New System.Drawing.Point(7, 146)
        Me.txb2Descricao.Name = "txb2Descricao"
        Me.txb2Descricao.Size = New System.Drawing.Size(246, 26)
        Me.txb2Descricao.TabIndex = 6
        '
        'txb3Categoria
        '
        Me.txb3Categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txb3Categoria.Location = New System.Drawing.Point(7, 207)
        Me.txb3Categoria.Name = "txb3Categoria"
        Me.txb3Categoria.Size = New System.Drawing.Size(246, 26)
        Me.txb3Categoria.TabIndex = 7
        '
        'txb4Preco
        '
        Me.txb4Preco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txb4Preco.Location = New System.Drawing.Point(7, 273)
        Me.txb4Preco.Name = "txb4Preco"
        Me.txb4Preco.Size = New System.Drawing.Size(246, 26)
        Me.txb4Preco.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(7, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 31)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Gestão de Produtos 2.0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(6, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Descrição"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(6, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Código"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label4.Location = New System.Drawing.Point(6, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Categoria"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label5.Location = New System.Drawing.Point(6, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Preço"
        '
        'btnAtualizaDados
        '
        Me.btnAtualizaDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtualizaDados.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtualizaDados.Location = New System.Drawing.Point(199, 357)
        Me.btnAtualizaDados.Name = "btnAtualizaDados"
        Me.btnAtualizaDados.Size = New System.Drawing.Size(186, 46)
        Me.btnAtualizaDados.TabIndex = 15
        Me.btnAtualizaDados.Text = "Atualizar os dados"
        Me.btnAtualizaDados.UseVisualStyleBackColor = True
        '
        'frmGestaoProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 468)
        Me.Controls.Add(Me.btnAtualizaDados)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txb4Preco)
        Me.Controls.Add(Me.txb3Categoria)
        Me.Controls.Add(Me.txb2Descricao)
        Me.Controls.Add(Me.txb1Codigo)
        Me.Controls.Add(Me.btnFecharPrograma)
        Me.Controls.Add(Me.btnInsereDados)
        Me.Controls.Add(Me.btnLimparDados)
        Me.Controls.Add(Me.btnGuardaDados)
        Me.Controls.Add(Me.lbDados)
        Me.Name = "frmGestaoProdutos"
        Me.Text = "Gestão De Produtos 2.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbDados As ListBox
    Friend WithEvents btnGuardaDados As Button
    Friend WithEvents btnLimparDados As Button
    Friend WithEvents btnInsereDados As Button
    Friend WithEvents btnFecharPrograma As Button
    Friend WithEvents txb1Codigo As TextBox
    Friend WithEvents txb2Descricao As TextBox
    Friend WithEvents txb3Categoria As TextBox
    Friend WithEvents txb4Preco As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAtualizaDados As Button
End Class
