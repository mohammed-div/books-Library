Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Label92.Left < Me.Width Then
            Label92.Left += 9
        Else
            Label92.Left = -Label92.Width
        End If
    End Sub

    Private Sub الصفحهالرئيسيةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles الصفحهالرئيسيةToolStripMenuItem.Click
        Panel18.BringToFront()
    End Sub

    Private Sub السلةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles السلةToolStripMenuItem.Click
        Panel7.BringToFront()
    End Sub

    Private Sub كتبخياليةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles كتبخياليةToolStripMenuItem.Click
        Panel1.BringToFront()
    End Sub

    Private Sub كتبمالواعمالToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles كتبمالواعمالToolStripMenuItem.Click
        Panel2.BringToFront()
    End Sub

    Private Sub كتبسيرذاتيةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles كتبسيرذاتيةToolStripMenuItem.Click
        Panel3.BringToFront()
    End Sub

    Private Sub كتبالجريمةوالغموضToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles كتبالجريمةوالغموضToolStripMenuItem.Click
        Panel4.BringToFront()
    End Sub

    Private Sub كتبالطهيToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles كتبالطهيToolStripMenuItem.Click
        Panel5.BringToFront()
    End Sub

    Private Sub كتبالتاريخToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles كتبالتاريخToolStripMenuItem.Click
        Panel6.BringToFront()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Panel71.Visible = True
        PictureBox72.Image = PictureBox90.Image
        TextBox58.Text = Label90.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        panel60.Visible = True
        PictureBox73.Image = PictureBox3.Image
        textBox56.Text = Label1.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        panel59.Visible = True
        PictureBox74.Image = PictureBox5.Image
        textBox55.Text = Label2.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        panel58.Visible = True
        PictureBox75.Image = PictureBox7.Image
        textBox54.Text = Label3.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        panel57.Visible = True
        PictureBox76.Image = PictureBox9.Image
        textBox53.Text = Label4.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        panel56.Visible = True
        PictureBox77.Image = PictureBox11.Image
        textBox52.Text = Label5.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox22.Click
        panel55.Visible = True
        PictureBox78.Image = PictureBox23.Image
        textBox51.Text = Label11.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox20.Click
        panel54.Visible = True
        PictureBox79.Image = PictureBox21.Image
        textBox50.Text = Label10.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.Click
        panel53.Visible = True
        PictureBox80.Image = PictureBox19.Image
        textBox49.Text = Label9.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        panel52.Visible = True
        PictureBox81.Image = PictureBox17.Image
        textBox48.Text = Label8.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        panel51.Visible = True
        PictureBox82.Image = PictureBox15.Image
        textBox47.Text = Label7.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        panel50.Visible = True
        PictureBox83.Image = PictureBox13.Image
        textBox46.Text = Label6.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox34.Click
        panel49.Visible = True
        PictureBox84.Image = PictureBox35.Image
        textBox45.Text = Label17.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox32.Click
        panel48.Visible = True
        PictureBox85.Image = PictureBox33.Image
        textBox44.Text = Label16.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox30.Click
        panel47.Visible = True
        PictureBox86.Image = PictureBox31.Image
        textBox43.Text = Label15.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox28.Click
        panel46.Visible = True
        PictureBox87.Image = PictureBox29.Image
        textBox42.Text = Label14.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox26.Click
        panel45.Visible = True
        PictureBox88.Image = PictureBox27.Image
        textBox41.Text = Label13.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox24.Click
        panel44.Visible = True
        PictureBox89.Image = PictureBox25.Image
        textBox40.Text = Label12.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox46.Click
        panel43.Visible = True
        PictureBox91.Image = PictureBox47.Image
        textBox39.Text = Label23.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox44.Click
        panel42.Visible = True
        PictureBox97.Image = PictureBox45.Image
        textBox38.Text = Label22.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox42.Click
        panel41.Visible = True
        PictureBox98.Image = PictureBox43.Image
        textBox37.Text = Label21.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox40.Click
        panel40.Visible = True
        PictureBox99.Image = PictureBox41.Image
        textBox36.Text = Label20.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox38.Click
        panel39.Visible = True
        PictureBox100.Image = PictureBox39.Image
        textBox35.Text = Label19.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox36.Click
        panel38.Visible = True
        PictureBox101.Image = PictureBox37.Image
        textBox34.Text = Label18.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox58.Click
        panel37.Visible = True
        PictureBox102.Image = PictureBox59.Image
        textBox33.Text = Label29.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox56.Click
        panel36.Visible = True
        PictureBox103.Image = PictureBox57.Image
        textBox32.Text = Label28.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox54.Click
        panel35.Visible = True
        PictureBox104.Image = PictureBox55.Image
        textBox31.Text = Label27.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox52.Click
        panel34.Visible = True
        PictureBox105.Image = PictureBox53.Image
        textBox30.Text = Label26.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox50.Click
        panel33.Visible = True
        PictureBox106.Image = PictureBox51.Image
        textBox29.Text = Label25.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox48.Click
        panel32.Visible = True
        PictureBox107.Image = PictureBox49.Image
        textBox28.Text = Label24.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox70.Click
        panel31.Visible = True
        PictureBox108.Image = PictureBox71.Image
        textBox27.Text = Label35.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox68.Click
        panel30.Visible = True
        PictureBox109.Image = PictureBox69.Image
        textBox26.Text = Label34.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox66.Click
        Panel12.Visible = True
        PictureBox113.Image = PictureBox67.Image
        TextBox4.Text = Label33.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox64.Click
        Panel11.Visible = True
        PictureBox112.Image = PictureBox65.Image
        TextBox3.Text = Label32.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox62.Click
        Panel10.Visible = True
        PictureBox111.Image = PictureBox63.Image
        TextBox2.Text = Label31.Text
        button57.Visible = True
    End Sub

    Private Sub PictureBox60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox60.Click
        Panel9.Visible = True
        PictureBox110.Image = PictureBox61.Image
        TextBox1.Text = Label30.Text
        button57.Visible = True
    End Sub

    Private Sub button57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button57.Click
        button58.Visible = True
        textBox57.Visible = True
        textBox57.Text = Val(TextBox58.Text) + Val(textBox56.Text) + Val(textBox55.Text) + Val(textBox54.Text) + Val(textBox53.Text) + Val(textBox52.Text) + Val(textBox51.Text) + Val(textBox50.Text) + Val(textBox49.Text) + Val(textBox48.Text) + Val(textBox47.Text) + Val(textBox46.Text) + Val(textBox45.Text) + Val(textBox44.Text) + Val(textBox43.Text) + Val(textBox42.Text) + Val(textBox41.Text) + Val(textBox40.Text) + Val(textBox39.Text) + Val(textBox38.Text) + Val(textBox37.Text) + Val(textBox36.Text) + Val(textBox35.Text) + Val(textBox34.Text) + Val(textBox33.Text) + Val(textBox32.Text) + Val(textBox31.Text) + Val(textBox30.Text) + Val(textBox29.Text) + Val(textBox28.Text) + Val(textBox27.Text) + Val(textBox26.Text) + Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text)
    End Sub

    Private Sub Button59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button59.Click
        If TextBox5.Text = "" And TextBox6.Text = "" Then
            MessageBox.Show("ادخل البيانات")
        Else
            MessageBox.Show("تم الشراء بنجاح")
            Panel18.BringToFront()
        End If
    End Sub

    Private Sub button58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button58.Click
        Panel63.BringToFront()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Panel1.BringToFront()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Panel5.BringToFront()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Panel6.BringToFront()
    End Sub
End Class
