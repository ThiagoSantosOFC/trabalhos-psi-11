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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMultMeter))
        Me.btnsave = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnAbrir = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblStatusS = New System.Windows.Forms.Label()
        Me.Timer_POP = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.75!)
        Me.btnsave.Location = New System.Drawing.Point(0, 32)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(195, 81)
        Me.btnsave.TabIndex = 10
        Me.btnsave.Text = "Guardar Leituras"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnOpen
        '
        Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.75!)
        Me.btnOpen.Location = New System.Drawing.Point(221, 30)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(195, 85)
        Me.btnOpen.TabIndex = 11
        Me.btnOpen.Text = "Abrir Leituras"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.btnSearch.Location = New System.Drawing.Point(12, 170)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(195, 81)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "Pesquisar leituras"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.btnRead.Location = New System.Drawing.Point(12, 83)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(195, 81)
        Me.btnRead.TabIndex = 14
        Me.btnRead.Text = "Ler Temperatura"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.btnInfo.Location = New System.Drawing.Point(233, 169)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(195, 80)
        Me.btnInfo.TabIndex = 15
        Me.btnInfo.Text = "Outras informações"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'btnAbrir
        '
        Me.btnAbrir.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.btnAbrir.Location = New System.Drawing.Point(233, 83)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(195, 80)
        Me.btnAbrir.TabIndex = 16
        Me.btnAbrir.Text = "Ver historico de leituras"
        Me.btnAbrir.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.lblTitulo.Location = New System.Drawing.Point(24, 21)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(356, 20)
        Me.lblTitulo.TabIndex = 17
        Me.lblTitulo.Text = "MultiMeter - Leitor de temperatura e humidade"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblStatusS)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.btnOpen)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 298)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 140)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestão de Ficheiros:"
        '
        'lblStatusS
        '
        Me.lblStatusS.AutoSize = True
        Me.lblStatusS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.lblStatusS.Location = New System.Drawing.Point(126, 116)
        Me.lblStatusS.Name = "lblStatusS"
        Me.lblStatusS.Size = New System.Drawing.Size(158, 20)
        Me.lblStatusS.TabIndex = 12
        Me.lblStatusS.Text = "Ficheiro guardado!!!"
        Me.lblStatusS.Visible = False
        '
        'Timer_POP
        '
        Me.Timer_POP.Interval = 1000
        '
        'frmMultMeter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnAbrir)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnSearch)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMultMeter"
        Me.Text = "MultiMeter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsave As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnOpen As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents btnInfo As Button
    Friend WithEvents btnAbrir As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Timer_POP As Timer
    Friend WithEvents lblStatusS As Label
End Class
