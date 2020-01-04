<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmL4Q4
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtyear = New System.Windows.Forms.TextBox()
        Me.txtmonth = New System.Windows.Forms.TextBox()
        Me.txtday = New System.Windows.Forms.TextBox()
        Me.lbldisplay = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblactime = New System.Windows.Forms.Label()
        Me.lblhr = New System.Windows.Forms.Label()
        Me.lblminu = New System.Windows.Forms.Label()
        Me.lblsec = New System.Windows.Forms.Label()
        Me.txtenteredtime = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tm1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(172, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "show message"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtyear
        '
        Me.txtyear.BackColor = System.Drawing.Color.White
        Me.txtyear.Location = New System.Drawing.Point(92, 34)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.ReadOnly = True
        Me.txtyear.Size = New System.Drawing.Size(42, 20)
        Me.txtyear.TabIndex = 1
        '
        'txtmonth
        '
        Me.txtmonth.BackColor = System.Drawing.Color.White
        Me.txtmonth.Location = New System.Drawing.Point(222, 34)
        Me.txtmonth.Name = "txtmonth"
        Me.txtmonth.ReadOnly = True
        Me.txtmonth.Size = New System.Drawing.Size(42, 20)
        Me.txtmonth.TabIndex = 1
        '
        'txtday
        '
        Me.txtday.BackColor = System.Drawing.Color.White
        Me.txtday.Location = New System.Drawing.Point(324, 34)
        Me.txtday.Name = "txtday"
        Me.txtday.ReadOnly = True
        Me.txtday.Size = New System.Drawing.Size(42, 20)
        Me.txtday.TabIndex = 1
        '
        'lbldisplay
        '
        Me.lbldisplay.AutoSize = True
        Me.lbldisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldisplay.Location = New System.Drawing.Point(114, 205)
        Me.lbldisplay.Name = "lbldisplay"
        Me.lbldisplay.Size = New System.Drawing.Size(0, 16)
        Me.lbldisplay.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(164, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "month"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(282, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "day"
        '
        'lblactime
        '
        Me.lblactime.AutoSize = True
        Me.lblactime.Location = New System.Drawing.Point(77, 9)
        Me.lblactime.Name = "lblactime"
        Me.lblactime.Size = New System.Drawing.Size(61, 13)
        Me.lblactime.TabIndex = 2
        Me.lblactime.Text = "actual time:"
        '
        'lblhr
        '
        Me.lblhr.AutoSize = True
        Me.lblhr.Location = New System.Drawing.Point(55, 79)
        Me.lblhr.Name = "lblhr"
        Me.lblhr.Size = New System.Drawing.Size(28, 13)
        Me.lblhr.TabIndex = 2
        Me.lblhr.Text = "hour"
        '
        'lblminu
        '
        Me.lblminu.AutoSize = True
        Me.lblminu.Location = New System.Drawing.Point(177, 79)
        Me.lblminu.Name = "lblminu"
        Me.lblminu.Size = New System.Drawing.Size(43, 13)
        Me.lblminu.TabIndex = 2
        Me.lblminu.Text = "minutes"
        '
        'lblsec
        '
        Me.lblsec.AutoSize = True
        Me.lblsec.Location = New System.Drawing.Point(295, 79)
        Me.lblsec.Name = "lblsec"
        Me.lblsec.Size = New System.Drawing.Size(47, 13)
        Me.lblsec.TabIndex = 2
        Me.lblsec.Text = "seconds"
        '
        'txtenteredtime
        '
        Me.txtenteredtime.Location = New System.Drawing.Point(172, 129)
        Me.txtenteredtime.Name = "txtenteredtime"
        Me.txtenteredtime.Size = New System.Drawing.Size(121, 20)
        Me.txtenteredtime.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "enter your time(in 24 hour)"
        '
        'tm1
        '
        Me.tm1.Enabled = True
        Me.tm1.Interval = 1000
        '
        'frmL4Q4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 247)
        Me.Controls.Add(Me.txtenteredtime)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblactime)
        Me.Controls.Add(Me.lblsec)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblminu)
        Me.Controls.Add(Me.lblhr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbldisplay)
        Me.Controls.Add(Me.txtday)
        Me.Controls.Add(Me.txtmonth)
        Me.Controls.Add(Me.txtyear)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmL4Q4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "greeting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtyear As System.Windows.Forms.TextBox
    Friend WithEvents txtmonth As System.Windows.Forms.TextBox
    Friend WithEvents txtday As System.Windows.Forms.TextBox
    Friend WithEvents lbldisplay As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblactime As System.Windows.Forms.Label
    Friend WithEvents lblhr As System.Windows.Forms.Label
    Friend WithEvents lblminu As System.Windows.Forms.Label
    Friend WithEvents lblsec As System.Windows.Forms.Label
    Friend WithEvents txtenteredtime As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tm1 As System.Windows.Forms.Timer
End Class
