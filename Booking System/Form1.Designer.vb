<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim button1 As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.Reciept = New System.Windows.Forms.TabControl()
        Me.Receipt = New System.Windows.Forms.TabPage()
        Me.rtReceipt = New System.Windows.Forms.RichTextBox()
        Me.txtPet = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtAdd1 = New System.Windows.Forms.TextBox()
        Me.txtAdd2 = New System.Windows.Forms.TextBox()
        Me.txtpc = New System.Windows.Forms.TextBox()
        Me.txtpn = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.txttime = New System.Windows.Forms.TextBox()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        button1 = New System.Windows.Forms.Button()
        Me.panel2.SuspendLayout()
        Me.Reciept.SuspendLayout()
        Me.Receipt.SuspendLayout()
        Me.panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'button1
        '
        button1.BackgroundImage = CType(resources.GetObject("button1.BackgroundImage"), System.Drawing.Image)
        button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        button1.Location = New System.Drawing.Point(25, 101)
        button1.Name = "button1"
        button1.Size = New System.Drawing.Size(228, 221)
        button1.TabIndex = 2
        button1.Text = "Dog "
        button1.UseVisualStyleBackColor = True
        AddHandler button1.Click, AddressOf Me.button1_Click
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.panel2.Controls.Add(Me.Reciept)
        Me.panel2.Controls.Add(Me.txtPet)
        Me.panel2.Controls.Add(Me.label10)
        Me.panel2.Controls.Add(Me.button3)
        Me.panel2.Controls.Add(Me.button2)
        Me.panel2.Controls.Add(button1)
        Me.panel2.Controls.Add(Me.label2)
        Me.panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel2.Location = New System.Drawing.Point(547, 7)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(506, 819)
        Me.panel2.TabIndex = 3
        '
        'Reciept
        '
        Me.Reciept.Controls.Add(Me.Receipt)
        Me.Reciept.Location = New System.Drawing.Point(3, 591)
        Me.Reciept.Name = "Reciept"
        Me.Reciept.SelectedIndex = 0
        Me.Reciept.Size = New System.Drawing.Size(495, 220)
        Me.Reciept.TabIndex = 16
        '
        'Receipt
        '
        Me.Receipt.Controls.Add(Me.rtReceipt)
        Me.Receipt.Location = New System.Drawing.Point(4, 38)
        Me.Receipt.Name = "Receipt"
        Me.Receipt.Padding = New System.Windows.Forms.Padding(3)
        Me.Receipt.Size = New System.Drawing.Size(487, 178)
        Me.Receipt.TabIndex = 0
        Me.Receipt.Text = "Receipt"
        Me.Receipt.UseVisualStyleBackColor = True
        '
        'rtReceipt
        '
        Me.rtReceipt.Location = New System.Drawing.Point(7, 11)
        Me.rtReceipt.Name = "rtReceipt"
        Me.rtReceipt.Size = New System.Drawing.Size(469, 157)
        Me.rtReceipt.TabIndex = 0
        Me.rtReceipt.Text = ""
        '
        'txtPet
        '
        Me.txtPet.Location = New System.Drawing.Point(307, 556)
        Me.txtPet.Name = "txtPet"
        Me.txtPet.Size = New System.Drawing.Size(140, 35)
        Me.txtPet.TabIndex = 15
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(139, 559)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(162, 29)
        Me.label10.TabIndex = 14
        Me.label10.Text = "Chosen Pet: "
        '
        'button3
        '
        Me.button3.BackgroundImage = CType(resources.GetObject("button3.BackgroundImage"), System.Drawing.Image)
        Me.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button3.Location = New System.Drawing.Point(25, 328)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(228, 228)
        Me.button3.TabIndex = 4
        Me.button3.Text = "Rabbit "
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.BackgroundImage = CType(resources.GetObject("button2.BackgroundImage"), System.Drawing.Image)
        Me.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button2.Location = New System.Drawing.Point(259, 180)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(239, 220)
        Me.button2.TabIndex = 3
        Me.button2.Text = "Cat"
        Me.button2.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(91, 31)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(300, 55)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Choose Pet:"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.panel1.Controls.Add(Me.pictureBox1)
        Me.panel1.Controls.Add(Me.txtAdd1)
        Me.panel1.Controls.Add(Me.txtAdd2)
        Me.panel1.Controls.Add(Me.txtpc)
        Me.panel1.Controls.Add(Me.txtpn)
        Me.panel1.Controls.Add(Me.txtEmail)
        Me.panel1.Controls.Add(Me.txtName)
        Me.panel1.Controls.Add(Me.label9)
        Me.panel1.Controls.Add(Me.label8)
        Me.panel1.Controls.Add(Me.label7)
        Me.panel1.Controls.Add(Me.label6)
        Me.panel1.Controls.Add(Me.label5)
        Me.panel1.Controls.Add(Me.label4)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(35, 7)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(506, 819)
        Me.panel1.TabIndex = 2
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImage = CType(resources.GetObject("pictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(10, 529)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(452, 248)
        Me.pictureBox1.TabIndex = 13
        Me.pictureBox1.TabStop = False
        '
        'txtAdd1
        '
        Me.txtAdd1.Location = New System.Drawing.Point(201, 202)
        Me.txtAdd1.Name = "txtAdd1"
        Me.txtAdd1.Size = New System.Drawing.Size(223, 20)
        Me.txtAdd1.TabIndex = 12
        '
        'txtAdd2
        '
        Me.txtAdd2.Location = New System.Drawing.Point(185, 272)
        Me.txtAdd2.Name = "txtAdd2"
        Me.txtAdd2.Size = New System.Drawing.Size(223, 20)
        Me.txtAdd2.TabIndex = 11
        '
        'txtpc
        '
        Me.txtpc.Location = New System.Drawing.Point(185, 337)
        Me.txtpc.Name = "txtpc"
        Me.txtpc.Size = New System.Drawing.Size(223, 20)
        Me.txtpc.TabIndex = 10
        '
        'txtpn
        '
        Me.txtpn.Location = New System.Drawing.Point(213, 469)
        Me.txtpn.Name = "txtpn"
        Me.txtpn.Size = New System.Drawing.Size(223, 20)
        Me.txtpn.TabIndex = 9
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(142, 399)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(223, 20)
        Me.txtEmail.TabIndex = 8
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(201, 141)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(223, 20)
        Me.txtName.TabIndex = 7
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(0, 460)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(207, 29)
        Me.label9.TabIndex = 6
        Me.label9.Text = "Mobile Number: "
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(0, 394)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(86, 29)
        Me.label8.TabIndex = 5
        Me.label8.Text = "Email:"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(3, 328)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(142, 29)
        Me.label7.TabIndex = 4
        Me.label7.Text = "Post Code:"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(5, 263)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(137, 29)
        Me.label6.TabIndex = 3
        Me.label6.Text = "Address 2:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(0, 193)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(137, 29)
        Me.label5.TabIndex = 2
        Me.label5.Text = "Address 1:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(3, 132)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(140, 29)
        Me.label4.TabIndex = 1
        Me.label4.Text = "Full Name:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(40, 31)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(422, 55)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Customer Details:"
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.SystemColors.Highlight
        Me.panel3.Controls.Add(Me.Button12)
        Me.panel3.Controls.Add(Me.Button11)
        Me.panel3.Controls.Add(Me.Button10)
        Me.panel3.Controls.Add(Me.Button9)
        Me.panel3.Controls.Add(Me.Button8)
        Me.panel3.Controls.Add(Me.txtDate)
        Me.panel3.Controls.Add(Me.txttime)
        Me.panel3.Controls.Add(Me.txtLoc)
        Me.panel3.Controls.Add(Me.button7)
        Me.panel3.Controls.Add(Me.button6)
        Me.panel3.Controls.Add(Me.button5)
        Me.panel3.Controls.Add(Me.button4)
        Me.panel3.Controls.Add(Me.label13)
        Me.panel3.Controls.Add(Me.label12)
        Me.panel3.Controls.Add(Me.label11)
        Me.panel3.Controls.Add(Me.label3)
        Me.panel3.Location = New System.Drawing.Point(1069, 7)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(506, 819)
        Me.panel3.TabIndex = 4
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(350, 782)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(93, 34)
        Me.Button12.TabIndex = 29
        Me.Button12.Text = "Print"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(356, 724)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(144, 55)
        Me.Button11.TabIndex = 28
        Me.Button11.Text = "Book"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(206, 724)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(144, 55)
        Me.Button10.TabIndex = 27
        Me.Button10.Text = "Confirm All"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.Location = New System.Drawing.Point(124, 726)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(76, 55)
        Me.Button9.TabIndex = 26
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.Location = New System.Drawing.Point(30, 725)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(76, 55)
        Me.Button8.TabIndex = 25
        Me.Button8.UseVisualStyleBackColor = True
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(180, 138)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(200, 20)
        Me.txtDate.TabIndex = 24
        '
        'txttime
        '
        Me.txttime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttime.Location = New System.Drawing.Point(193, 180)
        Me.txttime.Name = "txttime"
        Me.txttime.Size = New System.Drawing.Size(223, 26)
        Me.txttime.TabIndex = 23
        '
        'txtLoc
        '
        Me.txtLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoc.Location = New System.Drawing.Point(232, 231)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(223, 26)
        Me.txtLoc.TabIndex = 22
        '
        'button7
        '
        Me.button7.BackgroundImage = CType(resources.GetObject("button7.BackgroundImage"), System.Drawing.Image)
        Me.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button7.Location = New System.Drawing.Point(226, 529)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(217, 169)
        Me.button7.TabIndex = 20
        Me.button7.Text = "Edmonton Green "
        Me.button7.UseVisualStyleBackColor = True
        '
        'button6
        '
        Me.button6.BackgroundImage = CType(resources.GetObject("button6.BackgroundImage"), System.Drawing.Image)
        Me.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button6.Location = New System.Drawing.Point(3, 529)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(217, 169)
        Me.button6.TabIndex = 19
        Me.button6.Text = "Ladbroke Grove "
        Me.button6.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.BackgroundImage = CType(resources.GetObject("button5.BackgroundImage"), System.Drawing.Image)
        Me.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button5.Location = New System.Drawing.Point(226, 320)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(217, 169)
        Me.button5.TabIndex = 18
        Me.button5.Text = "Kennignton "
        Me.button5.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.BackgroundImage = CType(resources.GetObject("button4.BackgroundImage"), System.Drawing.Image)
        Me.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button4.Location = New System.Drawing.Point(3, 320)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(217, 169)
        Me.button4.TabIndex = 17
        Me.button4.Text = "Walthamstow"
        Me.button4.UseVisualStyleBackColor = True
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.Location = New System.Drawing.Point(3, 227)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(223, 29)
        Me.label13.TabIndex = 16
        Me.label13.Text = "Choose Location: "
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(3, 180)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(177, 29)
        Me.label12.TabIndex = 15
        Me.label12.Text = "Choose Time:"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(3, 132)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(171, 29)
        Me.label11.TabIndex = 14
        Me.label11.Text = "Choose Date:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(-10, 31)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(472, 55)
        Me.label3.TabIndex = 1
        Me.label3.Text = "Time Date Location:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1601, 838)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.Reciept.ResumeLayout(False)
        Me.Receipt.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel2 As Panel
    Private WithEvents txtPet As TextBox
    Private WithEvents label10 As Label
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents label2 As Label
    Private WithEvents panel1 As Panel
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents txtAdd1 As TextBox
    Private WithEvents txtAdd2 As TextBox
    Private WithEvents txtpc As TextBox
    Private WithEvents txtpn As TextBox
    Private WithEvents txtEmail As TextBox
    Private WithEvents txtName As TextBox
    Private WithEvents label9 As Label
    Private WithEvents label8 As Label
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label1 As Label
    Private WithEvents panel3 As Panel
    Friend WithEvents txtDate As DateTimePicker
    Private WithEvents txttime As TextBox
    Private WithEvents txtLoc As TextBox
    Private WithEvents button7 As Button
    Private WithEvents button6 As Button
    Private WithEvents button5 As Button
    Private WithEvents button4 As Button
    Private WithEvents label13 As Label
    Private WithEvents label12 As Label
    Private WithEvents label11 As Label
    Private WithEvents label3 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Reciept As TabControl
    Friend WithEvents Receipt As TabPage
    Friend WithEvents rtReceipt As RichTextBox
End Class
