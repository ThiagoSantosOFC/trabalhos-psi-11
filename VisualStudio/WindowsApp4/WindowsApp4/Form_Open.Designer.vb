<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Open
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Open))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Temp_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hum_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Flag_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_1, Me.Temp_1, Me.hum_1, Me.Flag_1, Me.date_1})
        Me.DataGridView1.Location = New System.Drawing.Point(23, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(516, 339)
        Me.DataGridView1.TabIndex = 0
        '
        'ID_1
        '
        Me.ID_1.HeaderText = "ID"
        Me.ID_1.Name = "ID_1"
        '
        'Temp_1
        '
        Me.Temp_1.HeaderText = "Temperatura"
        Me.Temp_1.Name = "Temp_1"
        '
        'hum_1
        '
        Me.hum_1.HeaderText = "Humidade"
        Me.hum_1.Name = "hum_1"
        '
        'Flag_1
        '
        Me.Flag_1.HeaderText = "Tipo"
        Me.Flag_1.Name = "Flag_1"
        '
        'date_1
        '
        Me.date_1.HeaderText = "Data/Hora"
        Me.date_1.Name = "date_1"
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.btnUpdate.Location = New System.Drawing.Point(23, 357)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(516, 30)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Atualizar"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Form_Open
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 393)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Open"
        Me.Text = "Historico de leituras"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ID_1 As DataGridViewTextBoxColumn
    Friend WithEvents Temp_1 As DataGridViewTextBoxColumn
    Friend WithEvents hum_1 As DataGridViewTextBoxColumn
    Friend WithEvents Flag_1 As DataGridViewTextBoxColumn
    Friend WithEvents date_1 As DataGridViewTextBoxColumn
    Friend WithEvents btnUpdate As Button
End Class
