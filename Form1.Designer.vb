<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRushingyards
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
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.Btnconfirm = New System.Windows.Forms.Button()
        Me.Lblheading = New System.Windows.Forms.Label()
        Me.G = New System.Windows.Forms.GroupBox()
        Me.RadElliot = New System.Windows.Forms.RadioButton()
        Me.RadBell = New System.Windows.Forms.RadioButton()
        Me.RadMccoy = New System.Windows.Forms.RadioButton()
        Me.RadHenry = New System.Windows.Forms.RadioButton()
        Me.Txtyearinput = New System.Windows.Forms.TextBox()
        Me.LblYear = New System.Windows.Forms.Label()
        Me.LblYards = New System.Windows.Forms.Label()
        Me.Btnexit = New System.Windows.Forms.Button()
        Me.Lblchoice = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.G.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.DarkBlue
        Me.BtnClear.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.White
        Me.BtnClear.Location = New System.Drawing.Point(367, 392)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(128, 37)
        Me.BtnClear.TabIndex = 6
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'Btnconfirm
        '
        Me.Btnconfirm.BackColor = System.Drawing.Color.DarkBlue
        Me.Btnconfirm.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnconfirm.ForeColor = System.Drawing.Color.White
        Me.Btnconfirm.Location = New System.Drawing.Point(100, 392)
        Me.Btnconfirm.Name = "Btnconfirm"
        Me.Btnconfirm.Size = New System.Drawing.Size(128, 37)
        Me.Btnconfirm.TabIndex = 5
        Me.Btnconfirm.Text = "Confirm"
        Me.Btnconfirm.UseVisualStyleBackColor = False
        '
        'Lblheading
        '
        Me.Lblheading.Font = New System.Drawing.Font("Century", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblheading.ForeColor = System.Drawing.Color.White
        Me.Lblheading.Location = New System.Drawing.Point(348, 8)
        Me.Lblheading.Name = "Lblheading"
        Me.Lblheading.Size = New System.Drawing.Size(440, 44)
        Me.Lblheading.TabIndex = 4
        Me.Lblheading.Text = "Running back rushing yards totals"
        '
        'G
        '
        Me.G.Controls.Add(Me.RadElliot)
        Me.G.Controls.Add(Me.RadBell)
        Me.G.Controls.Add(Me.RadMccoy)
        Me.G.Controls.Add(Me.RadHenry)
        Me.G.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G.ForeColor = System.Drawing.Color.White
        Me.G.Location = New System.Drawing.Point(353, 87)
        Me.G.Name = "G"
        Me.G.Size = New System.Drawing.Size(424, 197)
        Me.G.TabIndex = 7
        Me.G.TabStop = False
        Me.G.Text = "Running backs"
        '
        'RadElliot
        '
        Me.RadElliot.AutoSize = True
        Me.RadElliot.Location = New System.Drawing.Point(17, 158)
        Me.RadElliot.Name = "RadElliot"
        Me.RadElliot.Size = New System.Drawing.Size(119, 20)
        Me.RadElliot.TabIndex = 3
        Me.RadElliot.TabStop = True
        Me.RadElliot.Text = "Ezekiel Elliot"
        Me.RadElliot.UseVisualStyleBackColor = True
        '
        'RadBell
        '
        Me.RadBell.AutoSize = True
        Me.RadBell.Location = New System.Drawing.Point(17, 115)
        Me.RadBell.Name = "RadBell"
        Me.RadBell.Size = New System.Drawing.Size(112, 20)
        Me.RadBell.TabIndex = 2
        Me.RadBell.TabStop = True
        Me.RadBell.Text = "Le'Veon Bell"
        Me.RadBell.UseVisualStyleBackColor = True
        '
        'RadMccoy
        '
        Me.RadMccoy.AutoSize = True
        Me.RadMccoy.Location = New System.Drawing.Point(17, 72)
        Me.RadMccoy.Name = "RadMccoy"
        Me.RadMccoy.Size = New System.Drawing.Size(121, 20)
        Me.RadMccoy.TabIndex = 1
        Me.RadMccoy.TabStop = True
        Me.RadMccoy.Text = "Lesean Mccoy"
        Me.RadMccoy.UseVisualStyleBackColor = True
        '
        'RadHenry
        '
        Me.RadHenry.AutoSize = True
        Me.RadHenry.Location = New System.Drawing.Point(17, 31)
        Me.RadHenry.Name = "RadHenry"
        Me.RadHenry.Size = New System.Drawing.Size(127, 20)
        Me.RadHenry.TabIndex = 0
        Me.RadHenry.TabStop = True
        Me.RadHenry.Text = "Derrick Henry"
        Me.RadHenry.UseVisualStyleBackColor = True
        '
        'Txtyearinput
        '
        Me.Txtyearinput.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtyearinput.Location = New System.Drawing.Point(475, 301)
        Me.Txtyearinput.Name = "Txtyearinput"
        Me.Txtyearinput.Size = New System.Drawing.Size(113, 23)
        Me.Txtyearinput.TabIndex = 8
        '
        'LblYear
        '
        Me.LblYear.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblYear.ForeColor = System.Drawing.Color.White
        Me.LblYear.Location = New System.Drawing.Point(12, 301)
        Me.LblYear.Name = "LblYear"
        Me.LblYear.Size = New System.Drawing.Size(416, 28)
        Me.LblYear.TabIndex = 9
        Me.LblYear.Text = "Please insert a year from 2016-2020:"
        '
        'LblYards
        '
        Me.LblYards.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblYards.ForeColor = System.Drawing.Color.White
        Me.LblYards.Location = New System.Drawing.Point(144, 348)
        Me.LblYards.Name = "LblYards"
        Me.LblYards.Size = New System.Drawing.Size(568, 29)
        Me.LblYards.TabIndex = 10
        Me.LblYards.Text = "Label1"
        Me.LblYards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btnexit
        '
        Me.Btnexit.BackColor = System.Drawing.Color.DarkBlue
        Me.Btnexit.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnexit.ForeColor = System.Drawing.Color.White
        Me.Btnexit.Location = New System.Drawing.Point(625, 392)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(128, 37)
        Me.Btnexit.TabIndex = 11
        Me.Btnexit.Text = "Exit"
        Me.Btnexit.UseVisualStyleBackColor = False
        '
        'Lblchoice
        '
        Me.Lblchoice.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblchoice.ForeColor = System.Drawing.Color.White
        Me.Lblchoice.Location = New System.Drawing.Point(421, 52)
        Me.Lblchoice.Name = "Lblchoice"
        Me.Lblchoice.Size = New System.Drawing.Size(267, 32)
        Me.Lblchoice.TabIndex = 12
        Me.Lblchoice.Text = "Please choose a running back "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Visual_Basic_final_project.My.Resources.Resources.download__3_
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(331, 222)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FrmRushingyards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lblchoice)
        Me.Controls.Add(Me.Btnexit)
        Me.Controls.Add(Me.LblYards)
        Me.Controls.Add(Me.LblYear)
        Me.Controls.Add(Me.Txtyearinput)
        Me.Controls.Add(Me.G)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.Btnconfirm)
        Me.Controls.Add(Me.Lblheading)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FrmRushingyards"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Running back rushing yards"
        Me.G.ResumeLayout(False)
        Me.G.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnClear As Button
    Friend WithEvents Btnconfirm As Button
    Friend WithEvents Lblheading As Label
    Friend WithEvents G As GroupBox
    Friend WithEvents RadElliot As RadioButton
    Friend WithEvents RadBell As RadioButton
    Friend WithEvents RadMccoy As RadioButton
    Friend WithEvents RadHenry As RadioButton
    Friend WithEvents Txtyearinput As TextBox
    Friend WithEvents LblYear As Label
    Friend WithEvents LblYards As Label
    Friend WithEvents Btnexit As Button
    Friend WithEvents Lblchoice As Label
End Class
