Public Class FormMenuUtama

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        FormLogin.MdiParent = Me
        FormLogin.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub DataAnggotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataAnggotaToolStripMenuItem.Click
        FormDataPelanggan.MdiParent = Me
        FormDataPelanggan.Show()
    End Sub

    Sub Terkunci()
        MasterToolStripMenuItem.Visible = False
        LoginToolStripMenuItem.Visible = True
        LogoutToolStripMenuItem.Visible = False

        FormDataPelanggan.Hide()
    End Sub

    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
        ToolStripStatusLabel4_1_AkmalFauzi.Text = Today
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call Terkunci()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel5_1_AkmalFauzi.Text = TimeOfDay
    End Sub

End Class
