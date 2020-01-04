<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmL5Q7
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbldisplay = New System.Windows.Forms.ListBox()
        Me.eix = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(27, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 47)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "read student" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "details"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(153, 42)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 47)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "display student" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "details"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lbldisplay
        '
        Me.lbldisplay.FormattingEnabled = True
        Me.lbldisplay.Items.AddRange(New Object() {"name" & Global.Microsoft.VisualBasic.ChrW(9) & "address" & Global.Microsoft.VisualBasic.ChrW(9) & "age"})
        Me.lbldisplay.Location = New System.Drawing.Point(57, 117)
        Me.lbldisplay.Name = "lbldisplay"
        Me.lbldisplay.Size = New System.Drawing.Size(144, 82)
        Me.lbldisplay.TabIndex = 1
        '
        'eix
        '
        Me.eix.Location = New System.Drawing.Point(197, 226)
        Me.eix.Name = "eix"
        Me.eix.Size = New System.Drawing.Size(75, 23)
        Me.eix.TabIndex = 2
        Me.eix.Text = "exit"
        Me.eix.UseVisualStyleBackColor = True
        '
        'frmLQ7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.eix)
        Me.Controls.Add(Me.lbldisplay)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLQ7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "student details"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lbldisplay As System.Windows.Forms.ListBox
    Friend WithEvents eix As System.Windows.Forms.Button

End Class
