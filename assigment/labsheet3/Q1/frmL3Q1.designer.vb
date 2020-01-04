<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmL3Q1
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
        Me.lbdisplay = New System.Windows.Forms.ListBox()
        Me.btncomput = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbdisplay
        '
        Me.lbdisplay.FormattingEnabled = True
        Me.lbdisplay.Location = New System.Drawing.Point(12, 21)
        Me.lbdisplay.Name = "lbdisplay"
        Me.lbdisplay.Size = New System.Drawing.Size(249, 121)
        Me.lbdisplay.TabIndex = 0
        '
        'btncomput
        '
        Me.btncomput.Location = New System.Drawing.Point(45, 173)
        Me.btncomput.Name = "btncomput"
        Me.btncomput.Size = New System.Drawing.Size(75, 23)
        Me.btncomput.TabIndex = 1
        Me.btncomput.Text = "compute"
        Me.btncomput.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(172, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmL3Q1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 208)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btncomput)
        Me.Controls.Add(Me.lbdisplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmL3Q1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dislplay value in list box"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbdisplay As System.Windows.Forms.ListBox
    Friend WithEvents btncomput As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
