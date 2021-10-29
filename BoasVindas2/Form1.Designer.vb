<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.lblInsiraNome = New System.Windows.Forms.Label()
        Me.txbNome = New System.Windows.Forms.TextBox()
        Me.lblH = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnContinuar
        '
        resources.ApplyResources(Me.btnContinuar, "btnContinuar")
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.UseVisualStyleBackColor = True
        '
        'lblInsiraNome
        '
        resources.ApplyResources(Me.lblInsiraNome, "lblInsiraNome")
        Me.lblInsiraNome.Name = "lblInsiraNome"
        '
        'txbNome
        '
        resources.ApplyResources(Me.txbNome, "txbNome")
        Me.txbNome.Name = "txbNome"
        '
        'lblH
        '
        resources.ApplyResources(Me.lblH, "lblH")
        Me.lblH.Name = "lblH"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(204, Byte), Integer))
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.lblH)
        Me.Controls.Add(Me.txbNome)
        Me.Controls.Add(Me.lblInsiraNome)
        Me.Controls.Add(Me.btnContinuar)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.TransparencyKey = System.Drawing.Color.SeaGreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnContinuar As Button
    Friend WithEvents lblInsiraNome As Label
    Friend WithEvents txbNome As TextBox
    Friend WithEvents lblH As Label
End Class
