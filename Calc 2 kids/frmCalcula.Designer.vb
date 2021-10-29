<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalcula
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSoma = New System.Windows.Forms.Button()
        Me.btnSubtracao = New System.Windows.Forms.Button()
        Me.btnMultiplica = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.lblLinha = New System.Windows.Forms.Label()
        Me.txbOperacao1 = New System.Windows.Forms.TextBox()
        Me.txbOperacao2 = New System.Windows.Forms.TextBox()
        Me.txbResultado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSoma
        '
        Me.btnSoma.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSoma.Location = New System.Drawing.Point(78, 69)
        Me.btnSoma.Name = "btnSoma"
        Me.btnSoma.Size = New System.Drawing.Size(75, 73)
        Me.btnSoma.TabIndex = 0
        Me.btnSoma.Text = " +"
        Me.btnSoma.UseVisualStyleBackColor = True
        '
        'btnSubtracao
        '
        Me.btnSubtracao.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSubtracao.Location = New System.Drawing.Point(179, 69)
        Me.btnSubtracao.Name = "btnSubtracao"
        Me.btnSubtracao.Size = New System.Drawing.Size(75, 74)
        Me.btnSubtracao.TabIndex = 1
        Me.btnSubtracao.Text = " -"
        Me.btnSubtracao.UseVisualStyleBackColor = True
        '
        'btnMultiplica
        '
        Me.btnMultiplica.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMultiplica.Location = New System.Drawing.Point(78, 165)
        Me.btnMultiplica.Name = "btnMultiplica"
        Me.btnMultiplica.Size = New System.Drawing.Size(75, 67)
        Me.btnMultiplica.TabIndex = 2
        Me.btnMultiplica.Text = " X"
        Me.btnMultiplica.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Font = New System.Drawing.Font("Arial Black", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDivide.Location = New System.Drawing.Point(179, 165)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(75, 67)
        Me.btnDivide.TabIndex = 3
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'lblLinha
        '
        Me.lblLinha.AutoSize = True
        Me.lblLinha.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLinha.Location = New System.Drawing.Point(424, 270)
        Me.lblLinha.Name = "lblLinha"
        Me.lblLinha.Size = New System.Drawing.Size(289, 20)
        Me.lblLinha.TabIndex = 4
        Me.lblLinha.Text = "________________________________________"
        '
        'txbOperacao1
        '
        Me.txbOperacao1.Location = New System.Drawing.Point(436, 69)
        Me.txbOperacao1.Multiline = True
        Me.txbOperacao1.Name = "txbOperacao1"
        Me.txbOperacao1.Size = New System.Drawing.Size(207, 73)
        Me.txbOperacao1.TabIndex = 5
        Me.txbOperacao1.Text = "."
        Me.txbOperacao1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txbOperacao2
        '
        Me.txbOperacao2.BackColor = System.Drawing.SystemColors.Window
        Me.txbOperacao2.Location = New System.Drawing.Point(436, 165)
        Me.txbOperacao2.Multiline = True
        Me.txbOperacao2.Name = "txbOperacao2"
        Me.txbOperacao2.Size = New System.Drawing.Size(207, 73)
        Me.txbOperacao2.TabIndex = 6
        Me.txbOperacao2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txbResultado
        '
        Me.txbResultado.Location = New System.Drawing.Point(436, 310)
        Me.txbResultado.Multiline = True
        Me.txbResultado.Name = "txbResultado"
        Me.txbResultado.Size = New System.Drawing.Size(207, 73)
        Me.txbResultado.TabIndex = 7
        Me.txbResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmCalcula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 442)
        Me.Controls.Add(Me.txbResultado)
        Me.Controls.Add(Me.txbOperacao2)
        Me.Controls.Add(Me.txbOperacao1)
        Me.Controls.Add(Me.lblLinha)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnMultiplica)
        Me.Controls.Add(Me.btnSubtracao)
        Me.Controls.Add(Me.btnSoma)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCalcula"
        Me.ShowIcon = False
        Me.Text = " Calc 2 Kids"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSoma As Button
    Friend WithEvents btnSubtracao As Button
    Friend WithEvents btnMultiplica As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents lblLinha As Label
    Friend WithEvents txbOperacao1 As TextBox
    Friend WithEvents txbOperacao2 As TextBox
    Friend WithEvents txbResultado As TextBox
End Class
