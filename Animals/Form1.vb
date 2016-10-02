Public Class Form1

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        enName.Text = "Bird"
        arName.Text = "عصفور"
        Refresh()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play("bird.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play("02. Peace - In Your Eyes.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("02. Peace - In Your Eyes.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        enName.Text = "Cat"
        arName.Text = "قطة"
        Refresh()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play("cat.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play("02. Peace - In Your Eyes.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        enName.Text = "Chicken"
        arName.Text = "دجاجة"
        Refresh()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play("chicken.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play("02. Peace - In Your Eyes.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        enName.Text = "Cow"
        arName.Text = "بفرة"
        Refresh()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play("cow.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play("02. Peace - In Your Eyes.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        enName.Text = "Dog"
        arName.Text = "كلب"
        Refresh()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play("dog.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play("02. Peace - In Your Eyes.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        enName.Text = "Donkey"
        arName.Text = "حمار"
        Refresh()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play("donkey.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play("02. Peace - In Your Eyes.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        enName.Text = "Horse"
        arName.Text = "حصان"
        Refresh()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play("horse.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play("02. Peace - In Your Eyes.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        enName.Text = "Roosetr"
        arName.Text = "ديك"
        Refresh()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play("rooster.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play("02. Peace - In Your Eyes.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        enName.Text = "Duck"
        arName.Text = "بطة"
        Refresh()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play("duck.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play("02. Peace - In Your Eyes.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        enName.Text = "Elephant"
        arName.Text = "فيل"
        Refresh()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play("elephant.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play("02. Peace - In Your Eyes.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        enName.Text = "Goat"
        arName.Text = "معزة"
        Refresh()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play("goat.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play("02. Peace - In Your Eyes.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        enName.Text = "Lamb"
        arName.Text = "حمل"
        Refresh()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play("lamb.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play("02. Peace - In Your Eyes.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        enName.Text = "Lion"
        arName.Text = "اسد"
        Refresh()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play("lion.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play("02. Peace - In Your Eyes.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        enName.Text = "Monkey"
        arName.Text = "قرد"
        Refresh()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play("monkey.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play("02. Peace - In Your Eyes.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        enName.Text = "Owl"
        arName.Text = "بومة"
        Refresh()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play("owl.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play("02. Peace - In Your Eyes.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        enName.Text = "Wolf"
        arName.Text = "ذئب"
        Refresh()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play("wolf.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play("02. Peace - In Your Eyes.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class
