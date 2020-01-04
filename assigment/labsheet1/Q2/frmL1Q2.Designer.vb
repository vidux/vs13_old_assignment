<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmL1Q2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmL1Q2))
        Me.lbID = New System.Windows.Forms.Label()
        Me.lbname = New System.Windows.Forms.Label()
        Me.lbaddr = New System.Windows.Forms.Label()
        Me.lbage = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddr = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Location = New System.Drawing.Point(41, 41)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(58, 13)
        Me.lbID.TabIndex = 0
        Me.lbID.Text = "Student ID"
        '
        'lbname
        '
        Me.lbname.AutoSize = True
        Me.lbname.Location = New System.Drawing.Point(41, 69)
        Me.lbname.Name = "lbname"
        Me.lbname.Size = New System.Drawing.Size(75, 13)
        Me.lbname.TabIndex = 0
        Me.lbname.Text = "Student Name"
        '
        'lbaddr
        '
        Me.lbaddr.AutoSize = True
        Me.lbaddr.Location = New System.Drawing.Point(41, 100)
        Me.lbaddr.Name = "lbaddr"
        Me.lbaddr.Size = New System.Drawing.Size(78, 13)
        Me.lbaddr.TabIndex = 0
        Me.lbaddr.Text = "Student adress"
        '
        'lbage
        '
        Me.lbage.AutoSize = True
        Me.lbage.Location = New System.Drawing.Point(41, 131)
        Me.lbage.Name = "lbage"
        Me.lbage.Size = New System.Drawing.Size(65, 13)
        Me.lbage.TabIndex = 0
        Me.lbage.Text = "Student age"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.Orange
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(134, 33)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(167, 26)
        Me.txtID.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.Yellow
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(134, 66)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(167, 26)
        Me.txtName.TabIndex = 2
        '
        'txtAddr
        '
        Me.txtAddr.BackColor = System.Drawing.Color.Blue
        Me.txtAddr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddr.Location = New System.Drawing.Point(134, 97)
        Me.txtAddr.Name = "txtAddr"
        Me.txtAddr.Size = New System.Drawing.Size(167, 26)
        Me.txtAddr.TabIndex = 3
        '
        'txtage
        '
        Me.txtage.BackColor = System.Drawing.Color.Green
        Me.txtage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.Location = New System.Drawing.Point(134, 128)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(167, 26)
        Me.txtage.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(134, 204)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(235, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 45)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(24, 221)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 45)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmL1Q2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(366, 335)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.txtAddr)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lbage)
        Me.Controls.Add(Me.lbaddr)
        Me.Controls.Add(Me.lbname)
        Me.Controls.Add(Me.lbID)
        Me.MaximizeBox = False
        Me.Name = "frmL1Q2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmL1Q2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents lbname As System.Windows.Forms.Label
    Friend WithEvents lbaddr As System.Windows.Forms.Label
    Friend WithEvents lbage As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddr As System.Windows.Forms.TextBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
