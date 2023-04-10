<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlayForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAttack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbPlayerHealth = New System.Windows.Forms.TextBox()
        Me.tbPlayerArmor = New System.Windows.Forms.TextBox()
        Me.tbPlayerMana = New System.Windows.Forms.TextBox()
        Me.tbOmenHealth = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-94, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(570, 522)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Ravie", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(341, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(627, 54)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fight The Boss, Omen!"
        '
        'btnAttack
        '
        Me.btnAttack.Font = New System.Drawing.Font("Ravie", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAttack.Location = New System.Drawing.Point(397, 84)
        Me.btnAttack.Name = "btnAttack"
        Me.btnAttack.Size = New System.Drawing.Size(116, 55)
        Me.btnAttack.TabIndex = 7
        Me.btnAttack.Text = "Attack"
        Me.btnAttack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(3, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 22)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Player Health:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Impact", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(8, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 22)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Omen Health:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Impact", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(7, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 22)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Player Armor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Impact", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(10, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 22)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Player Mana:"
        '
        'tbPlayerHealth
        '
        Me.tbPlayerHealth.Location = New System.Drawing.Point(119, 45)
        Me.tbPlayerHealth.Name = "tbPlayerHealth"
        Me.tbPlayerHealth.ReadOnly = True
        Me.tbPlayerHealth.Size = New System.Drawing.Size(215, 27)
        Me.tbPlayerHealth.TabIndex = 14
        Me.tbPlayerHealth.Text = "100 000"
        '
        'tbPlayerArmor
        '
        Me.tbPlayerArmor.Location = New System.Drawing.Point(119, 84)
        Me.tbPlayerArmor.Name = "tbPlayerArmor"
        Me.tbPlayerArmor.ReadOnly = True
        Me.tbPlayerArmor.Size = New System.Drawing.Size(215, 27)
        Me.tbPlayerArmor.TabIndex = 15
        Me.tbPlayerArmor.Text = "100"
        '
        'tbPlayerMana
        '
        Me.tbPlayerMana.Location = New System.Drawing.Point(119, 122)
        Me.tbPlayerMana.Name = "tbPlayerMana"
        Me.tbPlayerMana.ReadOnly = True
        Me.tbPlayerMana.Size = New System.Drawing.Size(215, 27)
        Me.tbPlayerMana.TabIndex = 16
        Me.tbPlayerMana.Text = "1000"
        '
        'tbOmenHealth
        '
        Me.tbOmenHealth.Location = New System.Drawing.Point(119, 182)
        Me.tbOmenHealth.Name = "tbOmenHealth"
        Me.tbOmenHealth.ReadOnly = True
        Me.tbOmenHealth.Size = New System.Drawing.Size(215, 27)
        Me.tbOmenHealth.TabIndex = 17
        Me.tbOmenHealth.Text = "500 000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Impact", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(214, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 22)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Status"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Indigo
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.tbOmenHealth)
        Me.Panel1.Controls.Add(Me.tbPlayerMana)
        Me.Panel1.Controls.Add(Me.tbPlayerArmor)
        Me.Panel1.Controls.Add(Me.tbPlayerHealth)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnAttack)
        Me.Panel1.Location = New System.Drawing.Point(482, 209)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(513, 249)
        Me.Panel1.TabIndex = 10
        '
        'PlayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(995, 551)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PlayForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Play"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAttack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbPlayerHealth As TextBox
    Friend WithEvents tbPlayerArmor As TextBox
    Friend WithEvents tbPlayerMana As TextBox
    Friend WithEvents tbOmenHealth As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
End Class
