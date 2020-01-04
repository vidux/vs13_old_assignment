<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmL3Q2
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
        Me.btncompute = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.txtspeed = New System.Windows.Forms.TextBox()
        Me.txttime = New System.Windows.Forms.TextBox()
        Me.lbdisplay = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btncompute
        '
        Me.btncompute.Location = New System.Drawing.Point(38, 221)
        Me.btncompute.Name = "btncompute"
        Me.btncompute.Size = New System.Drawing.Size(75, 23)
        Me.btncompute.TabIndex = 0
        Me.btncompute.Text = "compute"
        Me.btncompute.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(151, 221)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 0
        Me.btnexit.Text = "exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'txtspeed
        '
        Me.txtspeed.Location = New System.Drawing.Point(126, 28)
        Me.txtspeed.Name = "txtspeed"
        Me.txtspeed.Size = New System.Drawing.Size(100, 20)
        Me.txtspeed.TabIndex = 1
        '
        'txttime
        '
        Me.txttime.Location = New System.Drawing.Point(126, 68)
        Me.txttime.Name = "txttime"
        Me.txttime.Size = New System.Drawing.Size(100, 20)
        Me.txttime.TabIndex = 2
        '
        'lbdisplay
        '
        Me.lbdisplay.FormattingEnabled = True
        Me.lbdisplay.Location = New System.Drawing.Point(73, 112)
        Me.lbdisplay.Name = "lbdisplay"
        Me.lbdisplay.Size = New System.Drawing.Size(153, 82)
        Me.lbdisplay.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "speed"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "time elapsed"
        '
        'frmL3Q2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 267)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbdisplay)
        Me.Controls.Add(Me.txttime)
        Me.Controls.Add(Me.txtspeed)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btncompute)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmL3Q2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "creating veriable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncompute As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents txtspeed As System.Windows.Forms.TextBox
    Friend WithEvents txttime As System.Windows.Forms.TextBox
    Friend WithEvents lbdisplay As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
