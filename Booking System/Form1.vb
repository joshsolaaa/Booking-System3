Public Class Form1
    Dim Animal As String
    Dim Location As String
    Dim f2 As New Form2

    Private Sub button1_Click(sender As Object, e As EventArgs)
        Animal = "Dog"

        If txtPet.Text = "Dog" Then
            txtPet.Text = "Dog"
        End If
        txtPet.Text = "Dog"
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Animal = "Cat"

        If txtPet.Text = "Cat" Then
            txtPet.Text = "Cat"
        End If
        txtPet.Text = "Cat"
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Animal = "Rabbit"

        If txtPet.Text = "Rabbit" Then
            txtPet.Text = "Rabbit"
        End If
        txtPet.Text = "Rabbit"
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Location = "Walthamstow"

        If txtLoc.Text = "Walthamstow" Then
            txtLoc.Text = "Walthamstow"
        End If
        txtLoc.Text = "Walthamstow"
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Location = "Kennignton"

        If txtLoc.Text = "Kennignton " Then
            txtLoc.Text = "Kennignton"
        End If
        txtLoc.Text = "Kennignton"
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        Location = "Ladbroke Grove "

        If txtLoc.Text = "Ladbroke Grove  " Then
            txtLoc.Text = "Ladbroke Grove "
        End If
        txtLoc.Text = "Ladbroke Grove "
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Location = "Edmonton Green  "

        If txtLoc.Text = "Edmonton Green   " Then
            txtLoc.Text = "Edmonton Green  "
        End If
        txtLoc.Text = "Edmonton Green"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        Dim obj As New Form2
            obj.stringpass = rtReceipt.Text
            obj.Show()
            Me.Hide()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then


            panel1.BackColor = ColorDialog1.Color


            panel2.BackColor = ColorDialog1.Color


            panel3.BackColor = ColorDialog1.Color


        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If FontDialog1.ShowDialog = DialogResult.OK Then


            label10.Font = FontDialog1.Font


            label13.Font = FontDialog1.Font


            label4.Font = FontDialog1.Font


            label5.Font = FontDialog1.Font


            label6.Font = FontDialog1.Font


            label7.Font = FontDialog1.Font


            label8.Font = FontDialog1.Font


            label9.Font = FontDialog1.Font


            label11.Font = FontDialog1.Font


            label12.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub label10_Click(sender As Object, e As EventArgs) Handles label10.Click

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        rtReceipt.AppendText("*******************************" + vbNewLine)

        rtReceipt.AppendText("Your Full Name" + vbTab + txtName.Text + vbNewLine)

        rtReceipt.AppendText("Address 1" + vbTab + txtAdd1.Text + vbNewLine)

        rtReceipt.AppendText("Address 2" + vbTab + txtAdd2.Text + vbNewLine)

        rtReceipt.AppendText("Post Code" + vbTab + txtpc.Text + vbNewLine)

        rtReceipt.AppendText("Email" + vbTab + txtEmail.Text + vbNewLine)

        rtReceipt.AppendText("Phone Number" + vbTab + txtpn.Text + vbNewLine)

        rtReceipt.AppendText("Selected Animal" + vbTab + txtPet.Text + vbNewLine)

        rtReceipt.AppendText("Choose Date" + vbTab + txtDate.Text + vbNewLine)

        rtReceipt.AppendText("Choose Time" + vbTab + txttime.Text + vbNewLine)

        rtReceipt.AppendText("Choose Location" + vbTab + txtLoc.Text + vbNewLine)

        rtReceipt.AppendText("******Thank YouFor Your Booking.******" + vbNewLine)

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        Dim obj As New Form2
        obj.stringpass = rtReceipt.Text
        obj.Show()
        Me.Hide()

    End Sub

    Private Sub txtPet_TextChanged(sender As Object, e As EventArgs) Handles txtPet.TextChanged

    End Sub
End Class
