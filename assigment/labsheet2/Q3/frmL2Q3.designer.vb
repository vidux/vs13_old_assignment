<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmL2Q3
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
        Me.lblnnmb = New System.Windows.Forms.Label()
        Me.lbnnmb2 = New System.Windows.Forms.Label()
        Me.lblrs = New System.Windows.Forms.Label()
        Me.txtdispaly = New System.Windows.Forms.TextBox()
        Me.txtnumber2 = New System.Windows.Forms.TextBox()
        Me.txtnumber1 = New System.Windows.Forms.TextBox()
        Me.btnplus = New System.Windows.Forms.Button()
        Me.btnminus = New System.Windows.Forms.Button()
        Me.btnmul = New System.Windows.Forms.Button()
        Me.btndev = New System.Windows.Forms.Button()
        Me.btnmod = New System.Windows.Forms.Button()
        Me.btnpow = New System.Windows.Forms.Button()
        Me.btnclr = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblnnmb
        '
        Me.lblnnmb.AutoSize = True
        Me.lblnnmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnnmb.Location = New System.Drawing.Point(23, 20)
        Me.lblnnmb.Name = "lblnnmb"
        Me.lblnnmb.Size = New System.Drawing.Size(64, 15)
        Me.lblnnmb.TabIndex = 0
        Me.lblnnmb.Text = "number1"
        '
        'lbnnmb2
        '
        Me.lbnnmb2.AutoSize = True
        Me.lbnnmb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbnnmb2.Location = New System.Drawing.Point(23, 51)
        Me.lbnnmb2.Name = "lbnnmb2"
        Me.lbnnmb2.Size = New System.Drawing.Size(64, 15)
        Me.lbnnmb2.TabIndex = 0
        Me.lbnnmb2.Text = "number2"
        '
        'lblrs
        '
        Me.lblrs.AutoSize = True
        Me.lblrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrs.Location = New System.Drawing.Point(44, 85)
        Me.lblrs.Name = "lblrs"
        Me.lblrs.Size = New System.Drawing.Size(43, 15)
        Me.lblrs.TabIndex = 0
        Me.lblrs.Text = "result"
        '
        'txtdispaly
        '
        Me.txtdispaly.BackColor = System.Drawing.Color.White
        Me.txtdispaly.Location = New System.Drawing.Point(128, 85)
        Me.txtdispaly.Name = "txtdispaly"
        Me.txtdispaly.ReadOnly = True
        Me.txtdispaly.Size = New System.Drawing.Size(100, 20)
        Me.txtdispaly.TabIndex = 1
        '
        'txtnumber2
        '
        Me.txtnumber2.Location = New System.Drawing.Point(128, 46)
        Me.txtnumber2.Name = "txtnumber2"
        Me.txtnumber2.Size = New System.Drawing.Size(100, 20)
        Me.txtnumber2.TabIndex = 1
        '
        'txtnumber1
        '
        Me.txtnumber1.Location = New System.Drawing.Point(128, 20)
        Me.txtnumber1.Name = "txtnumber1"
        Me.txtnumber1.Size = New System.Drawing.Size(100, 20)
        Me.txtnumber1.TabIndex = 1
        '
        'btnplus
        '
        Me.btnplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnplus.ForeColor = System.Drawing.Color.Fuchsia
        Me.btnplus.Location = New System.Drawing.Point(46, 149)
        Me.btnplus.Name = "btnplus"
        Me.btnplus.Size = New System.Drawing.Size(40, 36)
        Me.btnplus.TabIndex = 2
        Me.btnplus.Text = "+"
        Me.btnplus.UseVisualStyleBackColor = True
        '
        'btnminus
        '
        Me.btnminus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnminus.ForeColor = System.Drawing.Color.Fuchsia
        Me.btnminus.Location = New System.Drawing.Point(104, 149)
        Me.btnminus.Name = "btnminus"
        Me.btnminus.Size = New System.Drawing.Size(40, 36)
        Me.btnminus.TabIndex = 2
        Me.btnminus.Text = "-"
        Me.btnminus.UseVisualStyleBackColor = True
        '
        'btnmul
        '
        Me.btnmul.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmul.ForeColor = System.Drawing.Color.Fuchsia
        Me.btnmul.Location = New System.Drawing.Point(158, 149)
        Me.btnmul.Name = "btnmul"
        Me.btnmul.Size = New System.Drawing.Size(40, 36)
        Me.btnmul.TabIndex = 2
        Me.btnmul.Text = "*"
        Me.btnmul.UseVisualStyleBackColor = True
        '
        'btndev
        '
        Me.btndev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndev.ForeColor = System.Drawing.Color.Fuchsia
        Me.btndev.Location = New System.Drawing.Point(208, 149)
        Me.btndev.Name = "btndev"
        Me.btndev.Size = New System.Drawing.Size(40, 36)
        Me.btndev.TabIndex = 2
        Me.btndev.Text = "/"
        Me.btndev.UseVisualStyleBackColor = True
        '
        'btnmod
        '
        Me.btnmod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmod.ForeColor = System.Drawing.Color.Purple
        Me.btnmod.Location = New System.Drawing.Point(47, 191)
        Me.btnmod.Name = "btnmod"
        Me.btnmod.Size = New System.Drawing.Size(97, 36)
        Me.btnmod.TabIndex = 2
        Me.btnmod.Text = "MOD"
        Me.btnmod.UseVisualStyleBackColor = True
        '
        'btnpow
        '
        Me.btnpow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpow.ForeColor = System.Drawing.Color.Purple
        Me.btnpow.Location = New System.Drawing.Point(158, 191)
        Me.btnpow.Name = "btnpow"
        Me.btnpow.Size = New System.Drawing.Size(90, 36)
        Me.btnpow.TabIndex = 2
        Me.btnpow.Text = "POWER"
        Me.btnpow.UseVisualStyleBackColor = True
        '
        'btnclr
        '
        Me.btnclr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclr.ForeColor = System.Drawing.Color.Purple
        Me.btnclr.Location = New System.Drawing.Point(46, 233)
        Me.btnclr.Name = "btnclr"
        Me.btnclr.Size = New System.Drawing.Size(98, 36)
        Me.btnclr.TabIndex = 2
        Me.btnclr.Text = "CLEAR"
        Me.btnclr.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.Purple
        Me.btnexit.Location = New System.Drawing.Point(158, 233)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(90, 36)
        Me.btnexit.TabIndex = 2
        Me.btnexit.Text = "exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'frmL2Q3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 286)
        Me.Controls.Add(Me.btndev)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnclr)
        Me.Controls.Add(Me.btnmul)
        Me.Controls.Add(Me.btnpow)
        Me.Controls.Add(Me.btnminus)
        Me.Controls.Add(Me.btnmod)
        Me.Controls.Add(Me.btnplus)
        Me.Controls.Add(Me.txtnumber1)
        Me.Controls.Add(Me.txtnumber2)
        Me.Controls.Add(Me.txtdispaly)
        Me.Controls.Add(Me.lblrs)
        Me.Controls.Add(Me.lbnnmb2)
        Me.Controls.Add(Me.lblnnmb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmL2Q3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "simple calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblnnmb As System.Windows.Forms.Label
    Friend WithEvents lbnnmb2 As System.Windows.Forms.Label
    Friend WithEvents lblrs As System.Windows.Forms.Label
    Friend WithEvents txtdispaly As System.Windows.Forms.TextBox
    Friend WithEvents txtnumber2 As System.Windows.Forms.TextBox
    Friend WithEvents txtnumber1 As System.Windows.Forms.TextBox
    Friend WithEvents btnplus As System.Windows.Forms.Button
    Friend WithEvents btnminus As System.Windows.Forms.Button
    Friend WithEvents btnmul As System.Windows.Forms.Button
    Friend WithEvents btndev As System.Windows.Forms.Button
    Friend WithEvents btnmod As System.Windows.Forms.Button
    Friend WithEvents btnpow As System.Windows.Forms.Button
    Friend WithEvents btnclr As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
End Class
