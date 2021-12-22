<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmContaBanco
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
        Me.btnAbrirConta = New System.Windows.Forms.Button()
        Me.btnEfetuar_Deposito = New System.Windows.Forms.Button()
        Me.btnMostra_Movimentos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAbrirConta
        '
        Me.btnAbrirConta.Location = New System.Drawing.Point(64, 190)
        Me.btnAbrirConta.Name = "btnAbrirConta"
        Me.btnAbrirConta.Size = New System.Drawing.Size(75, 23)
        Me.btnAbrirConta.TabIndex = 0
        Me.btnAbrirConta.Text = "Abrir conta"
        Me.btnAbrirConta.UseVisualStyleBackColor = True
        '
        'btnEfetuar_Deposito
        '
        Me.btnEfetuar_Deposito.Location = New System.Drawing.Point(271, 173)
        Me.btnEfetuar_Deposito.Name = "btnEfetuar_Deposito"
        Me.btnEfetuar_Deposito.Size = New System.Drawing.Size(75, 56)
        Me.btnEfetuar_Deposito.TabIndex = 1
        Me.btnEfetuar_Deposito.Text = "Efetuar deposito"
        Me.btnEfetuar_Deposito.UseVisualStyleBackColor = True
        '
        'btnMostra_Movimentos
        '
        Me.btnMostra_Movimentos.Location = New System.Drawing.Point(407, 173)
        Me.btnMostra_Movimentos.Name = "btnMostra_Movimentos"
        Me.btnMostra_Movimentos.Size = New System.Drawing.Size(75, 59)
        Me.btnMostra_Movimentos.TabIndex = 2
        Me.btnMostra_Movimentos.Text = "Mostrar movimentos"
        Me.btnMostra_Movimentos.UseVisualStyleBackColor = True
        '
        'frmContaBanco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnMostra_Movimentos)
        Me.Controls.Add(Me.btnEfetuar_Deposito)
        Me.Controls.Add(Me.btnAbrirConta)
        Me.Name = "frmContaBanco"
        Me.Text = "Thigas Banking"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAbrirConta As Button
    Friend WithEvents btnEfetuar_Deposito As Button
    Friend WithEvents btnMostra_Movimentos As Button
End Class
