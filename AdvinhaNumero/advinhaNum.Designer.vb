<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class advinhaNum
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnJogar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSair
        '
        Me.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSair.Location = New System.Drawing.Point(317, 228)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(125, 106)
        Me.btnSair.TabIndex = 0
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnJogar
        '
        Me.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnJogar.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnJogar.Location = New System.Drawing.Point(97, 236)
        Me.btnJogar.Name = "btnJogar"
        Me.btnJogar.Size = New System.Drawing.Size(127, 98)
        Me.btnJogar.TabIndex = 1
        Me.btnJogar.Text = "Jogar"
        Me.btnJogar.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Trebuchet MS", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblTitulo.Location = New System.Drawing.Point(-9, 73)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(593, 81)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Guess The Number"
        '
        'advinhaNum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 414)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnJogar)
        Me.Controls.Add(Me.btnSair)
        Me.Name = "advinhaNum"
        Me.Text = "Guess The Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSair As Button
    Friend WithEvents btnJogar As Button
    Friend WithEvents lblTitulo As Label
End Class
