<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmL3Q3
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
        Me.txtmark1 = New System.Windows.Forms.TextBox()
        Me.txtmark2 = New System.Windows.Forms.TextBox()
        Me.txtmark3 = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtavg = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtmark1
        '
        Me.txtmark1.Location = New System.Drawing.Point(109, 25)
        Me.txtmark1.Name = "txtmark1"
        Me.txtmark1.Size = New System.Drawing.Size(171, 20)
        Me.txtmark1.TabIndex = 0
        '
        'txtmark2
        '
        Me.txtmark2.Location = New System.Drawing.Point(109, 51)
        Me.txtmark2.Name = "txtmark2"
        Me.txtmark2.Size = New System.Drawing.Size(171, 20)
        Me.txtmark2.TabIndex = 1
        '
        'txtmark3
        '
        Me.txtmark3.Location = New System.Drawing.Point(109, 77)
        Me.txtmark3.Name = "txtmark3"
        Me.txtmark3.Size = New System.Drawing.Size(171, 20)
        Me.txtmark3.TabIndex = 1
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(117, 124)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(164, 20)
        Me.txttotal.TabIndex = 1
        '
        'txtavg
        '
        Me.txtavg.Location = New System.Drawing.Point(117, 150)
        Me.txtavg.Name = "txtavg"
        Me.txtavg.Size = New System.Drawing.Size(164, 20)
        Me.txtavg.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "mark 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "mark 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "mark 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "avg"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(23, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Calculate total"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(159, 210)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 28)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Calculate average"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(23, 259)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "clear"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(159, 259)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(109, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmL3Q3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 294)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtavg)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtmark3)
        Me.Controls.Add(Me.txtmark2)
        Me.Controls.Add(Me.txtmark1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmL3Q3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "marks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtmark1 As System.Windows.Forms.TextBox
    Friend WithEvents txtmark2 As System.Windows.Forms.TextBox
    Friend WithEvents txtmark3 As System.Windows.Forms.TextBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtavg As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
