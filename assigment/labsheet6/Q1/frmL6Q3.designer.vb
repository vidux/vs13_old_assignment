<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmL6Q3
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
        Me.txtlen = New System.Windows.Forms.TextBox()
        Me.txtwid = New System.Windows.Forms.TextBox()
        Me.btndis = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtarea = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "length"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "width"
        '
        'txtlen
        '
        Me.txtlen.Location = New System.Drawing.Point(108, 21)
        Me.txtlen.Name = "txtlen"
        Me.txtlen.Size = New System.Drawing.Size(100, 20)
        Me.txtlen.TabIndex = 1
        '
        'txtwid
        '
        Me.txtwid.Location = New System.Drawing.Point(108, 61)
        Me.txtwid.Name = "txtwid"
        Me.txtwid.Size = New System.Drawing.Size(100, 20)
        Me.txtwid.TabIndex = 1
        '
        'btndis
        '
        Me.btndis.Location = New System.Drawing.Point(108, 107)
        Me.btndis.Name = "btndis"
        Me.btndis.Size = New System.Drawing.Size(75, 23)
        Me.btndis.TabIndex = 2
        Me.btndis.Text = "display area"
        Me.btndis.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "area:"
        '
        'txtarea
        '
        Me.txtarea.Location = New System.Drawing.Point(108, 145)
        Me.txtarea.Name = "txtarea"
        Me.txtarea.Size = New System.Drawing.Size(100, 20)
        Me.txtarea.TabIndex = 1
        '
        'frmL6Q3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 189)
        Me.Controls.Add(Me.btndis)
        Me.Controls.Add(Me.txtarea)
        Me.Controls.Add(Me.txtwid)
        Me.Controls.Add(Me.txtlen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmL6Q3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "functions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtlen As System.Windows.Forms.TextBox
    Friend WithEvents txtwid As System.Windows.Forms.TextBox
    Friend WithEvents btndis As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtarea As System.Windows.Forms.TextBox

End Class
