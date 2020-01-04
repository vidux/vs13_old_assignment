<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmL3Q5
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
        Me.txtfiled = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtfield = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtfiled
        '
        Me.txtfiled.BackColor = System.Drawing.Color.White
        Me.txtfiled.Location = New System.Drawing.Point(37, 176)
        Me.txtfiled.Multiline = True
        Me.txtfiled.Name = "txtfiled"
        Me.txtfiled.ReadOnly = True
        Me.txtfiled.Size = New System.Drawing.Size(194, 91)
        Me.txtfiled.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(90, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 38)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "calculate salary"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(155, 129)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "load text file"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtfield
        '
        Me.txtfield.Location = New System.Drawing.Point(8, 132)
        Me.txtfield.Name = "txtfield"
        Me.txtfield.Size = New System.Drawing.Size(137, 20)
        Me.txtfield.TabIndex = 4
        Me.txtfield.Text = "text.txt"
        '
        'frmL3Q5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 282)
        Me.Controls.Add(Me.txtfield)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtfiled)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmL3Q5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "read text file"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtfiled As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtfield As System.Windows.Forms.TextBox
End Class
