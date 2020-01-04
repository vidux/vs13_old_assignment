<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmL4Q5
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
        Me.txtday = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbld = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtday
        '
        Me.txtday.Location = New System.Drawing.Point(65, 29)
        Me.txtday.Name = "txtday"
        Me.txtday.Size = New System.Drawing.Size(100, 20)
        Me.txtday.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(61, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "display a day"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbld
        '
        Me.lbld.AutoSize = True
        Me.lbld.Location = New System.Drawing.Point(76, 68)
        Me.lbld.Name = "lbld"
        Me.lbld.Size = New System.Drawing.Size(0, 13)
        Me.lbld.TabIndex = 2
        '
        'frmL4Q5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 158)
        Me.Controls.Add(Me.lbld)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtday)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmL4Q5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "selecting a day"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtday As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbld As System.Windows.Forms.Label
End Class
