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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContaBanco))
        Me.btnAbrirConta = New System.Windows.Forms.Button()
        Me.btnEfetuar_Deposito = New System.Windows.Forms.Button()
        Me.btnMostra_Movimentos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAbrirConta
        '
        Me.btnAbrirConta.Location = New System.Drawing.Point(12, 399)
        Me.btnAbrirConta.Name = "btnAbrirConta"
        Me.btnAbrirConta.Size = New System.Drawing.Size(128, 39)
        Me.btnAbrirConta.TabIndex = 0
        Me.btnAbrirConta.Text = "Abrir conta"
        Me.btnAbrirConta.UseVisualStyleBackColor = True
        '
        'btnEfetuar_Deposito
        '
        Me.btnEfetuar_Deposito.Location = New System.Drawing.Point(146, 399)
        Me.btnEfetuar_Deposito.Name = "btnEfetuar_Deposito"
        Me.btnEfetuar_Deposito.Size = New System.Drawing.Size(128, 39)
        Me.btnEfetuar_Deposito.TabIndex = 1
        Me.btnEfetuar_Deposito.Text = "Efetuar deposito"
        Me.btnEfetuar_Deposito.UseVisualStyleBackColor = True
        '
        'btnMostra_Movimentos
        '
        Me.btnMostra_Movimentos.Location = New System.Drawing.Point(280, 399)
        Me.btnMostra_Movimentos.Name = "btnMostra_Movimentos"
        Me.btnMostra_Movimentos.Size = New System.Drawing.Size(128, 39)
        Me.btnMostra_Movimentos.TabIndex = 2
        Me.btnMostra_Movimentos.Text = "Mostrar movimentos"
        Me.btnMostra_Movimentos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Conta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label2.Location = New System.Drawing.Point(12, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Operação"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(12, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 28)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Valor"
        '
        'frmContaBanco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMostra_Movimentos)
        Me.Controls.Add(Me.btnEfetuar_Deposito)
        Me.Controls.Add(Me.btnAbrirConta)
        Me.Name = "frmContaBanco"
        Me.Text = "Thigas Banking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbrirConta As Button
    Friend WithEvents btnEfetuar_Deposito As Button
    Friend WithEvents btnMostra_Movimentos As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
