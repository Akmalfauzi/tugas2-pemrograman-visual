Imports System.Data.Odbc
Public Class FormLogin

    Private Sub BtnKeluar_AkmalFauzi_Click(sender As Object, e As EventArgs) Handles BtnKeluar_AkmalFauzi.Click
        Me.Close()
    End Sub

    Sub Terbuka()
        FormMenuUtama.MasterToolStripMenuItem.Visible = True
        FormMenuUtama.LogoutToolStripMenuItem.Visible = True
        FormMenuUtama.MasterToolStripMenuItem.Visible = True
    End Sub

    Sub ProcessLogin()
        If TxtUsername_AkmalFauzi.Text = "" Or TxtPassword_AkmalFauzi.Text = "" Then
            MessageBox.Show("Silahkan isi Username dan Password!")
        Else
            Try
                Call Koneksi()
                Dim Login As String = "SELECT * FROM admin WHERE username='" & TxtUsername_AkmalFauzi.Text & "' AND password='" & TxtPassword_AkmalFauzi.Text & "'"
                Cmd = New OdbcCommand(Login, Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Not Rd.HasRows Then
                    MessageBox.Show("Username atau Password Salah!")
                Else
                    MessageBox.Show("Login Berhasil")
                    FormMenuUtama.ToolStripStatusLabel2_1_AkmalFauzi.Text = Rd.Item("username")
                    FormMenuUtama.ToolStripStatusLabel1_1_AkmalFauzi.Text = Rd.Item("kode")
                    FormMenuUtama.ToolStripStatusLabel3_1_AkmalFauzi.Text = Rd.Item("level")
                    FormMenuUtama.LoginToolStripMenuItem.Visible = False
                    Me.Close()
                    Call Terbuka()
                End If
            Catch ex As Exception
                MessageBox.Show("Login Gagal")
            End Try
        End If
    End Sub

    Private Sub BtnLogin_AkmalFauzi_Click(sender As Object, e As EventArgs) Handles BtnLogin_AkmalFauzi.Click
        Call ProcessLogin()
    End Sub

    Private Sub CheckboxShowPassword_AkmalFauzi_CheckedChanged(sender As Object, e As EventArgs) Handles CheckboxShowPassword_AkmalFauzi.CheckedChanged
        If CheckboxShowPassword_AkmalFauzi.Checked = True Then
            TxtPassword_AkmalFauzi.UseSystemPasswordChar = False
        Else
            TxtPassword_AkmalFauzi.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TxtPassword_AkmalFauzi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassword_AkmalFauzi.KeyPress
        If e.KeyChar = Chr(13) Then
            Call ProcessLogin()
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtPassword_AkmalFauzi.UseSystemPasswordChar = True
    End Sub
End Class