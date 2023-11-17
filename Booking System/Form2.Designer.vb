<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Reciept = New System.Windows.Forms.TabControl()
        Me.Receipt = New System.Windows.Forms.TabPage()
        Me.rtReceipt = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Reciept.SuspendLayout()
        Me.Receipt.SuspendLayout()
        Me.SuspendLayout()
        '
        'Reciept
        '
        Me.Reciept.Controls.Add(Me.Receipt)
        Me.Reciept.Location = New System.Drawing.Point(12, -1)
        Me.Reciept.Name = "Reciept"
        Me.Reciept.SelectedIndex = 0
        Me.Reciept.Size = New System.Drawing.Size(1483, 812)
        Me.Reciept.TabIndex = 17
        '
        'Receipt
        '
        Me.Receipt.Controls.Add(Me.Label2)
        Me.Receipt.Controls.Add(Me.Label1)
        Me.Receipt.Controls.Add(Me.rtReceipt)
        Me.Receipt.Location = New System.Drawing.Point(4, 22)
        Me.Receipt.Name = "Receipt"
        Me.Receipt.Padding = New System.Windows.Forms.Padding(3)
        Me.Receipt.Size = New System.Drawing.Size(1475, 786)
        Me.Receipt.TabIndex = 0
        Me.Receipt.Text = "Confirmation Page"
        Me.Receipt.UseVisualStyleBackColor = True
        '
        'rtReceipt
        '
        Me.rtReceipt.Location = New System.Drawing.Point(7, 11)
        Me.rtReceipt.Name = "rtReceipt"
        Me.rtReceipt.Size = New System.Drawing.Size(1462, 769)
        Me.rtReceipt.TabIndex = 0
        Me.rtReceipt.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(243, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(908, 108)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Booking confirmed! "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1113, 125)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1518, 823)
        Me.Controls.Add(Me.Reciept)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Reciept.ResumeLayout(False)
        Me.Receipt.ResumeLayout(False)
        Me.Receipt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Reciept As TabControl
    Friend WithEvents Receipt As TabPage
    Friend WithEvents rtReceipt As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
