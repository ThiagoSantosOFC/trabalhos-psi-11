<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaises_E_Cidades
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
        Me.lbCidades = New System.Windows.Forms.ListBox()
        Me.lbPaises = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnAddPais = New System.Windows.Forms.Button()
        Me.btnAddCidade = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbCidades
        '
        Me.lbCidades.FormattingEnabled = True
        Me.lbCidades.ItemHeight = 15
        Me.lbCidades.Location = New System.Drawing.Point(398, 36)
        Me.lbCidades.Name = "lbCidades"
        Me.lbCidades.Size = New System.Drawing.Size(231, 304)
        Me.lbCidades.TabIndex = 0
        '
        'lbPaises
        '
        Me.lbPaises.FormattingEnabled = True
        Me.lbPaises.ItemHeight = 15
        Me.lbPaises.Location = New System.Drawing.Point(61, 36)
        Me.lbPaises.Name = "lbPaises"
        Me.lbPaises.Size = New System.Drawing.Size(231, 304)
        Me.lbPaises.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Paises"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(491, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cidades"
        '
        'btnAddPais
        '
        Me.btnAddPais.Location = New System.Drawing.Point(61, 347)
        Me.btnAddPais.Name = "btnAddPais"
        Me.btnAddPais.Size = New System.Drawing.Size(231, 62)
        Me.btnAddPais.TabIndex = 4
        Me.btnAddPais.Text = "Adicionar Pais"
        Me.btnAddPais.UseVisualStyleBackColor = True
        '
        'btnAddCidade
        '
        Me.btnAddCidade.Location = New System.Drawing.Point(398, 347)
        Me.btnAddCidade.Name = "btnAddCidade"
        Me.btnAddCidade.Size = New System.Drawing.Size(231, 62)
        Me.btnAddCidade.TabIndex = 5
        Me.btnAddCidade.Text = "Adicionar Cidade"
        Me.btnAddCidade.UseVisualStyleBackColor = True
        '
        'frmPaises_E_Cidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 450)
        Me.Controls.Add(Me.btnAddCidade)
        Me.Controls.Add(Me.btnAddPais)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbPaises)
        Me.Controls.Add(Me.lbCidades)
        Me.Name = "frmPaises_E_Cidades"
        Me.Text = "Cidades & Paises"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbCidades As ListBox
    Friend WithEvents lbPaises As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnAddPais As Button
    Friend WithEvents btnAddCidade As Button
End Class
