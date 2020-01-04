<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmL7Q1
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
        Me.txtnumber1 = New System.Windows.Forms.TextBox()
        Me.txtnumber2 = New System.Windows.Forms.TextBox()
        Me.rbsub = New System.Windows.Forms.GroupBox()
        Me.rbmax = New System.Windows.Forms.RadioButton()
        Me.rbmin = New System.Windows.Forms.RadioButton()
        Me.rbdevid = New System.Windows.Forms.RadioButton()
        Me.rbexponet = New System.Windows.Forms.RadioButton()
        Me.rbmul = New System.Windows.Forms.RadioButton()
        Me.rbremind = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.rbadd = New System.Windows.Forms.RadioButton()
        Me.txtresult = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btncalcuate = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.rbsub.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Number 2"
        '
        'txtnumber1
        '
        Me.txtnumber1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtnumber1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnumber1.ForeColor = System.Drawing.Color.LightGray
        Me.txtnumber1.Location = New System.Drawing.Point(58, 99)
        Me.txtnumber1.Name = "txtnumber1"
        Me.txtnumber1.Size = New System.Drawing.Size(136, 20)
        Me.txtnumber1.TabIndex = 1
        '
        'txtnumber2
        '
        Me.txtnumber2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtnumber2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnumber2.ForeColor = System.Drawing.Color.LightGray
        Me.txtnumber2.Location = New System.Drawing.Point(58, 158)
        Me.txtnumber2.Name = "txtnumber2"
        Me.txtnumber2.Size = New System.Drawing.Size(136, 20)
        Me.txtnumber2.TabIndex = 1
        '
        'rbsub
        '
        Me.rbsub.Controls.Add(Me.rbmax)
        Me.rbsub.Controls.Add(Me.rbmin)
        Me.rbsub.Controls.Add(Me.rbdevid)
        Me.rbsub.Controls.Add(Me.rbexponet)
        Me.rbsub.Controls.Add(Me.rbmul)
        Me.rbsub.Controls.Add(Me.rbremind)
        Me.rbsub.Controls.Add(Me.RadioButton2)
        Me.rbsub.Controls.Add(Me.rbadd)
        Me.rbsub.ForeColor = System.Drawing.Color.LightGray
        Me.rbsub.Location = New System.Drawing.Point(223, 46)
        Me.rbsub.Name = "rbsub"
        Me.rbsub.Size = New System.Drawing.Size(154, 249)
        Me.rbsub.TabIndex = 2
        Me.rbsub.TabStop = False
        Me.rbsub.Text = "Operation"
        '
        'rbmax
        '
        Me.rbmax.AutoSize = True
        Me.rbmax.Location = New System.Drawing.Point(21, 203)
        Me.rbmax.Name = "rbmax"
        Me.rbmax.Size = New System.Drawing.Size(48, 17)
        Me.rbmax.TabIndex = 0
        Me.rbmax.TabStop = True
        Me.rbmax.Text = "MAX"
        Me.rbmax.UseVisualStyleBackColor = True
        '
        'rbmin
        '
        Me.rbmin.AutoSize = True
        Me.rbmin.Location = New System.Drawing.Point(21, 180)
        Me.rbmin.Name = "rbmin"
        Me.rbmin.Size = New System.Drawing.Size(45, 17)
        Me.rbmin.TabIndex = 0
        Me.rbmin.TabStop = True
        Me.rbmin.Text = "MIN"
        Me.rbmin.UseVisualStyleBackColor = True
        '
        'rbdevid
        '
        Me.rbdevid.AutoSize = True
        Me.rbdevid.Location = New System.Drawing.Point(21, 104)
        Me.rbdevid.Name = "rbdevid"
        Me.rbdevid.Size = New System.Drawing.Size(76, 17)
        Me.rbdevid.TabIndex = 0
        Me.rbdevid.TabStop = True
        Me.rbdevid.Text = "DEVISION"
        Me.rbdevid.UseVisualStyleBackColor = True
        '
        'rbexponet
        '
        Me.rbexponet.AutoSize = True
        Me.rbexponet.Location = New System.Drawing.Point(21, 153)
        Me.rbexponet.Name = "rbexponet"
        Me.rbexponet.Size = New System.Drawing.Size(84, 17)
        Me.rbexponet.TabIndex = 0
        Me.rbexponet.TabStop = True
        Me.rbexponet.Text = "EXPONENT"
        Me.rbexponet.UseVisualStyleBackColor = True
        '
        'rbmul
        '
        Me.rbmul.AutoSize = True
        Me.rbmul.Location = New System.Drawing.Point(21, 81)
        Me.rbmul.Name = "rbmul"
        Me.rbmul.Size = New System.Drawing.Size(114, 17)
        Me.rbmul.TabIndex = 0
        Me.rbmul.TabStop = True
        Me.rbmul.Text = "MULTIPLICATION"
        Me.rbmul.UseVisualStyleBackColor = True
        '
        'rbremind
        '
        Me.rbremind.AutoSize = True
        Me.rbremind.Location = New System.Drawing.Point(21, 130)
        Me.rbremind.Name = "rbremind"
        Me.rbremind.Size = New System.Drawing.Size(83, 17)
        Me.rbremind.TabIndex = 0
        Me.rbremind.TabStop = True
        Me.rbremind.Text = "REMINDER"
        Me.rbremind.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(21, 54)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(102, 17)
        Me.RadioButton2.TabIndex = 0
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "SUBTRACTION"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'rbadd
        '
        Me.rbadd.AutoSize = True
        Me.rbadd.Location = New System.Drawing.Point(21, 31)
        Me.rbadd.Name = "rbadd"
        Me.rbadd.Size = New System.Drawing.Size(77, 17)
        Me.rbadd.TabIndex = 0
        Me.rbadd.TabStop = True
        Me.rbadd.Text = "ADDITION"
        Me.rbadd.UseVisualStyleBackColor = True
        '
        'txtresult
        '
        Me.txtresult.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtresult.ForeColor = System.Drawing.Color.Gold
        Me.txtresult.Location = New System.Drawing.Point(493, 100)
        Me.txtresult.Name = "txtresult"
        Me.txtresult.ReadOnly = True
        Me.txtresult.Size = New System.Drawing.Size(136, 20)
        Me.txtresult.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(480, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "RESULT"
        '
        'btncalcuate
        '
        Me.btncalcuate.BackColor = System.Drawing.Color.SteelBlue
        Me.btncalcuate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncalcuate.Location = New System.Drawing.Point(513, 199)
        Me.btncalcuate.Name = "btncalcuate"
        Me.btncalcuate.Size = New System.Drawing.Size(106, 29)
        Me.btncalcuate.TabIndex = 3
        Me.btncalcuate.Text = "Calculate"
        Me.btncalcuate.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.DarkBlue
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexit.Location = New System.Drawing.Point(513, 249)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(106, 29)
        Me.btnexit.TabIndex = 3
        Me.btnexit.Text = "exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'frmL7Q1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(702, 348)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btncalcuate)
        Me.Controls.Add(Me.rbsub)
        Me.Controls.Add(Me.txtnumber2)
        Me.Controls.Add(Me.txtresult)
        Me.Controls.Add(Me.txtnumber1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmL7Q1"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab sheet  7 q1"
        Me.rbsub.ResumeLayout(False)
        Me.rbsub.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnumber1 As System.Windows.Forms.TextBox
    Friend WithEvents txtnumber2 As System.Windows.Forms.TextBox
    Friend WithEvents rbsub As System.Windows.Forms.GroupBox
    Friend WithEvents rbmax As System.Windows.Forms.RadioButton
    Friend WithEvents rbmin As System.Windows.Forms.RadioButton
    Friend WithEvents rbdevid As System.Windows.Forms.RadioButton
    Friend WithEvents rbexponet As System.Windows.Forms.RadioButton
    Friend WithEvents rbmul As System.Windows.Forms.RadioButton
    Friend WithEvents rbremind As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbadd As System.Windows.Forms.RadioButton
    Friend WithEvents txtresult As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btncalcuate As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button

End Class
