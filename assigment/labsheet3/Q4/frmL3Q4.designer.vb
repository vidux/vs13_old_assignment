<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmL3Q4
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
        Me.btnteam = New System.Windows.Forms.Button()
        Me.btngame = New System.Windows.Forms.Button()
        Me.btnlost = New System.Windows.Forms.Button()
        Me.btnwinprecent = New System.Windows.Forms.Button()
        Me.btnclr = New System.Windows.Forms.Button()
        Me.btnext = New System.Windows.Forms.Button()
        Me.txtTeam = New System.Windows.Forms.TextBox()
        Me.txtwon = New System.Windows.Forms.TextBox()
        Me.txtlost = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnteam
        '
        Me.btnteam.Location = New System.Drawing.Point(12, 12)
        Me.btnteam.Name = "btnteam"
        Me.btnteam.Size = New System.Drawing.Size(75, 23)
        Me.btnteam.TabIndex = 0
        Me.btnteam.Text = "team"
        Me.btnteam.UseVisualStyleBackColor = True
        '
        'btngame
        '
        Me.btngame.Location = New System.Drawing.Point(12, 50)
        Me.btngame.Name = "btngame"
        Me.btngame.Size = New System.Drawing.Size(75, 23)
        Me.btngame.TabIndex = 0
        Me.btngame.Text = "games won"
        Me.btngame.UseVisualStyleBackColor = True
        '
        'btnlost
        '
        Me.btnlost.Location = New System.Drawing.Point(12, 85)
        Me.btnlost.Name = "btnlost"
        Me.btnlost.Size = New System.Drawing.Size(75, 23)
        Me.btnlost.TabIndex = 0
        Me.btnlost.Text = "games lost"
        Me.btnlost.UseVisualStyleBackColor = True
        '
        'btnwinprecent
        '
        Me.btnwinprecent.Location = New System.Drawing.Point(64, 153)
        Me.btnwinprecent.Name = "btnwinprecent"
        Me.btnwinprecent.Size = New System.Drawing.Size(142, 23)
        Me.btnwinprecent.TabIndex = 0
        Me.btnwinprecent.Text = "winning precentage"
        Me.btnwinprecent.UseVisualStyleBackColor = True
        '
        'btnclr
        '
        Me.btnclr.Location = New System.Drawing.Point(64, 206)
        Me.btnclr.Name = "btnclr"
        Me.btnclr.Size = New System.Drawing.Size(75, 23)
        Me.btnclr.TabIndex = 0
        Me.btnclr.Text = "clear"
        Me.btnclr.UseVisualStyleBackColor = True
        '
        'btnext
        '
        Me.btnext.Location = New System.Drawing.Point(156, 206)
        Me.btnext.Name = "btnext"
        Me.btnext.Size = New System.Drawing.Size(75, 23)
        Me.btnext.TabIndex = 0
        Me.btnext.Text = "exit"
        Me.btnext.UseVisualStyleBackColor = True
        '
        'txtTeam
        '
        Me.txtTeam.BackColor = System.Drawing.Color.White
        Me.txtTeam.Location = New System.Drawing.Point(106, 14)
        Me.txtTeam.Name = "txtTeam"
        Me.txtTeam.ReadOnly = True
        Me.txtTeam.Size = New System.Drawing.Size(125, 20)
        Me.txtTeam.TabIndex = 1
        '
        'txtwon
        '
        Me.txtwon.BackColor = System.Drawing.Color.White
        Me.txtwon.Location = New System.Drawing.Point(106, 50)
        Me.txtwon.Name = "txtwon"
        Me.txtwon.ReadOnly = True
        Me.txtwon.Size = New System.Drawing.Size(125, 20)
        Me.txtwon.TabIndex = 1
        '
        'txtlost
        '
        Me.txtlost.BackColor = System.Drawing.Color.White
        Me.txtlost.Location = New System.Drawing.Point(106, 85)
        Me.txtlost.Name = "txtlost"
        Me.txtlost.ReadOnly = True
        Me.txtlost.Size = New System.Drawing.Size(125, 20)
        Me.txtlost.TabIndex = 1
        '
        'frmL3Q4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 254)
        Me.Controls.Add(Me.txtlost)
        Me.Controls.Add(Me.txtwon)
        Me.Controls.Add(Me.txtTeam)
        Me.Controls.Add(Me.btnext)
        Me.Controls.Add(Me.btnclr)
        Me.Controls.Add(Me.btnlost)
        Me.Controls.Add(Me.btnwinprecent)
        Me.Controls.Add(Me.btngame)
        Me.Controls.Add(Me.btnteam)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmL3Q4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "wining team"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnteam As System.Windows.Forms.Button
    Friend WithEvents btngame As System.Windows.Forms.Button
    Friend WithEvents btnlost As System.Windows.Forms.Button
    Friend WithEvents btnwinprecent As System.Windows.Forms.Button
    Friend WithEvents btnclr As System.Windows.Forms.Button
    Friend WithEvents btnext As System.Windows.Forms.Button
    Friend WithEvents txtTeam As System.Windows.Forms.TextBox
    Friend WithEvents txtwon As System.Windows.Forms.TextBox
    Friend WithEvents txtlost As System.Windows.Forms.TextBox
End Class
