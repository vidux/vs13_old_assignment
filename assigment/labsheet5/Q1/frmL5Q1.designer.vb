<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmL5Q1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtstart = New System.Windows.Forms.TextBox()
        Me.txtend = New System.Windows.Forms.TextBox()
        Me.txtmul = New System.Windows.Forms.TextBox()
        Me.lbmul = New System.Windows.Forms.ListBox()
        Me.btngo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "start at"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "end at"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "multipiler"
        '
        'txtstart
        '
        Me.txtstart.Location = New System.Drawing.Point(158, 33)
        Me.txtstart.Name = "txtstart"
        Me.txtstart.Size = New System.Drawing.Size(100, 20)
        Me.txtstart.TabIndex = 1
        '
        'txtend
        '
        Me.txtend.Location = New System.Drawing.Point(158, 73)
        Me.txtend.Name = "txtend"
        Me.txtend.Size = New System.Drawing.Size(100, 20)
        Me.txtend.TabIndex = 1
        '
        'txtmul
        '
        Me.txtmul.Location = New System.Drawing.Point(158, 115)
        Me.txtmul.Name = "txtmul"
        Me.txtmul.Size = New System.Drawing.Size(100, 20)
        Me.txtmul.TabIndex = 1
        '
        'lbmul
        '
        Me.lbmul.FormattingEnabled = True
        Me.lbmul.Location = New System.Drawing.Point(24, 201)
        Me.lbmul.Name = "lbmul"
        Me.lbmul.Size = New System.Drawing.Size(257, 95)
        Me.lbmul.TabIndex = 2
        '
        'btngo
        '
        Me.btngo.Location = New System.Drawing.Point(158, 159)
        Me.btngo.Name = "btngo"
        Me.btngo.Size = New System.Drawing.Size(100, 23)
        Me.btngo.TabIndex = 3
        Me.btngo.Text = "go"
        Me.btngo.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(206, 314)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmL5Q1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 349)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btngo)
        Me.Controls.Add(Me.lbmul)
        Me.Controls.Add(Me.txtmul)
        Me.Controls.Add(Me.txtend)
        Me.Controls.Add(Me.txtstart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmL5Q1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "times table"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtstart As System.Windows.Forms.TextBox
    Friend WithEvents txtend As System.Windows.Forms.TextBox
    Friend WithEvents txtmul As System.Windows.Forms.TextBox
    Friend WithEvents lbmul As System.Windows.Forms.ListBox
    Friend WithEvents btngo As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
