<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jogo
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
        Me.lblInsNum = New System.Windows.Forms.Label()
        Me.txbNumJ1 = New System.Windows.Forms.TextBox()
        Me.btnTryLuck = New System.Windows.Forms.Button()
        Me.lblVitoria = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInsNum
        '
        Me.lblInsNum.AutoSize = True
        Me.lblInsNum.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblInsNum.Location = New System.Drawing.Point(3, 35)
        Me.lblInsNum.Name = "lblInsNum"
        Me.lblInsNum.Size = New System.Drawing.Size(253, 22)
        Me.lblInsNum.TabIndex = 0
        Me.lblInsNum.Text = "Insira um número entre 0 e 100:"
        '
        'txbNumJ1
        '
        Me.txbNumJ1.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txbNumJ1.Location = New System.Drawing.Point(253, 35)
        Me.txbNumJ1.Name = "txbNumJ1"
        Me.txbNumJ1.Size = New System.Drawing.Size(60, 32)
        Me.txbNumJ1.TabIndex = 1
        '
        'btnTryLuck
        '
        Me.btnTryLuck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTryLuck.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnTryLuck.Location = New System.Drawing.Point(101, 141)
        Me.btnTryLuck.Name = "btnTryLuck"
        Me.btnTryLuck.Size = New System.Drawing.Size(138, 68)
        Me.btnTryLuck.TabIndex = 2
        Me.btnTryLuck.Text = "Tentar a sorte"
        Me.btnTryLuck.UseVisualStyleBackColor = True
        '
        'lblVitoria
        '
        Me.lblVitoria.AutoSize = True
        Me.lblVitoria.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblVitoria.Location = New System.Drawing.Point(3, 81)
        Me.lblVitoria.Name = "lblVitoria"
        Me.lblVitoria.Size = New System.Drawing.Size(0, 22)
        Me.lblVitoria.TabIndex = 3
        '
        'jogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 221)
        Me.Controls.Add(Me.lblVitoria)
        Me.Controls.Add(Me.btnTryLuck)
        Me.Controls.Add(Me.txbNumJ1)
        Me.Controls.Add(Me.lblInsNum)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "jogo"
        Me.Text = "Guess The Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInsNum As Label
    Friend WithEvents txbNumJ1 As TextBox
    Friend WithEvents btnTryLuck As Button
    Friend WithEvents lblVitoria As Label
End Class
