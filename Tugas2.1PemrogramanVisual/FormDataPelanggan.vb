Imports System.Data.Odbc
Public Class FormDataPelanggan

    Private Sub FormDataPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Sub KondisiAwal()
        TxtIDPelanggan_AkmalFauzi.Focus()

        Call SetAutoNumberPelanggan()
        Call DisableForm()
        Call GetPelanggan()

    End Sub

    Sub GetPelanggan()
        Call Koneksi()
        Da = New OdbcDataAdapter("SELECT * FROM pelanggan", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Pelanggan")
        DataGridView1.DataSource = (Ds.Tables("Pelanggan"))
    End Sub

    Sub SetAutoNumberPelanggan()

        Call Koneksi()

        Dim tahun As String
        tahun = Format(Now, "yyyy")

        Cmd = New OdbcCommand("SELECT * FROM pelanggan where id in(select max(id) from pelanggan) order by id desc", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()

        If Rd.HasRows = 0 Then
            TxtIDPelanggan_AkmalFauzi.Text = "PLG-" & tahun & "000001"
        End If

        If Not Rd.HasRows Then
            TxtIDPelanggan_AkmalFauzi.Text = "PLG-" & tahun & "000001"
            Rd.Close()

        Else

            TxtIDPelanggan_AkmalFauzi.Text = Val(Microsoft.VisualBasic.Mid(Rd.Item("id").ToString, 9, 6)) + 1

            If Len(TxtIDPelanggan_AkmalFauzi.Text) = 1 Then
                TxtIDPelanggan_AkmalFauzi.Text = "PLG-" & tahun & "00000" & TxtIDPelanggan_AkmalFauzi.Text
            ElseIf Len(TxtIDPelanggan_AkmalFauzi.Text) = 2 Then
                TxtIDPelanggan_AkmalFauzi.Text = "PLG-" & tahun & "0000" & TxtIDPelanggan_AkmalFauzi.Text
            ElseIf Len(TxtIDPelanggan_AkmalFauzi.Text) = 3 Then
                TxtIDPelanggan_AkmalFauzi.Text = "PLG-" & tahun & "000" & TxtIDPelanggan_AkmalFauzi.Text
            ElseIf Len(TxtIDPelanggan_AkmalFauzi.Text) = 4 Then
                TxtIDPelanggan_AkmalFauzi.Text = "PLG-" & tahun & "00" & TxtIDPelanggan_AkmalFauzi.Text
            ElseIf Len(TxtIDPelanggan_AkmalFauzi.Text) = 5 Then
                TxtIDPelanggan_AkmalFauzi.Text = "PLG-" & tahun & "0" & TxtIDPelanggan_AkmalFauzi.Text
            End If
            Rd.Close()

        End If

    End Sub

    Sub EnableForm()
        TxtIDPelanggan_AkmalFauzi.Enabled = True
        TxtNama_AkmalFauzi.Enabled = True
        TxtEmail_AkmalFauzi.Enabled = True
        TxtNoTelepon_AkmalFauzi.Enabled = True
        TxtAlamat_AkmalFauzi.Enabled = True
        ComboBoxPendidikan_AkmalFauzi.Enabled = True
        RadioBtnLakiLaki_AkmalFauzi.Enabled = True
        RadioBtnPerempuan_AkmalFauzi.Enabled = True
        DateTimePicker1_AkmalFauzi.Enabled = True
    End Sub

    Sub DisableForm()
        TxtIDPelanggan_AkmalFauzi.Enabled = False
        TxtNama_AkmalFauzi.Enabled = False
        TxtEmail_AkmalFauzi.Enabled = False
        TxtNoTelepon_AkmalFauzi.Enabled = False
        TxtAlamat_AkmalFauzi.Enabled = False
        ComboBoxPendidikan_AkmalFauzi.Enabled = False
        RadioBtnLakiLaki_AkmalFauzi.Enabled = False
        RadioBtnPerempuan_AkmalFauzi.Enabled = False
        DateTimePicker1_AkmalFauzi.Enabled = False
    End Sub


    Private Sub BtnInput_AkmalFauzi_Click(sender As Object, e As EventArgs) Handles BtnInput_AkmalFauzi.Click

        If BtnInput_AkmalFauzi.Text = "INPUT" Then

            BtnInput_AkmalFauzi.Text = "SIMPAN"
            BtnTutup_AkmalFauzi.Text = "CANCEL"

            BtnEdit_AkmalFauzi.Enabled = False
            BtnHapus_AkmalFauzi.Enabled = False

            Call EnableForm()

        ElseIf BtnInput_AkmalFauzi.Text = "SIMPAN" Then

            If TxtIDPelanggan_AkmalFauzi.Text = "" Or TxtNama_AkmalFauzi.Text = "" Or TxtEmail_AkmalFauzi.Text = "" Or TxtNoTelepon_AkmalFauzi.Text = "" Or ComboBoxPendidikan_AkmalFauzi.Text = "" Or TxtAlamat_AkmalFauzi.Text = "" Or (RadioBtnLakiLaki_AkmalFauzi.Checked = False And RadioBtnPerempuan_AkmalFauzi.Checked = False) Then
                MessageBox.Show("Pastikan Semua field diisi!")
            Else
                Try
                    Call Koneksi()

                    Dim JenisKelamin As String
                    If RadioBtnLakiLaki_AkmalFauzi.Checked Then
                        JenisKelamin = "Laki-Laki"
                    Else
                        JenisKelamin = "Perempuan"
                    End If

                    Dim InputData As String = "INSERT INTO pelanggan VALUES ('" & TxtIDPelanggan_AkmalFauzi.Text & "', '" & TxtNama_AkmalFauzi.Text & "', '" & JenisKelamin.ToString & "', '" & TxtEmail_AkmalFauzi.Text & "', '" & TxtNoTelepon_AkmalFauzi.Text & "', '" & ComboBoxPendidikan_AkmalFauzi.Text & "', '" & TxtAlamat_AkmalFauzi.Text & "', '" & DateTimePicker1_AkmalFauzi.Text & "' )"
                    Cmd = New OdbcCommand(InputData, Conn)
                    Cmd.ExecuteNonQuery()

                    MessageBox.Show("Input Data Berhasil")

                    Call Bersih()
                    Call KondisiAwal()
                    Call EnableActionButton()

                    BtnTutup_AkmalFauzi.Text = "TUTUP"
                    BtnInput_AkmalFauzi.Text = "INPUT"

                Catch ex As Exception
                    MessageBox.Show("Input Data Gagal!")
                End Try
            End If

        End If

    End Sub

    Private Sub BtnBersih_AkmalFauzi_Click(sender As Object, e As EventArgs) Handles BtnBersih_AkmalFauzi.Click
        Call Bersih()
        Call SetAutoNumberPelanggan()
    End Sub

    Sub Bersih()
        TxtNama_AkmalFauzi.Text = ""
        TxtEmail_AkmalFauzi.Text = ""
        TxtNoTelepon_AkmalFauzi.Text = ""
        RadioBtnLakiLaki_AkmalFauzi.Checked = False
        RadioBtnPerempuan_AkmalFauzi.Checked = False
        ComboBoxPendidikan_AkmalFauzi.Text = ""
        TxtAlamat_AkmalFauzi.Text = ""
        TxtCari_AkmalFauzi.Text = ""
        DateTimePicker1_AkmalFauzi.Text = ""
    End Sub

    Private Sub BtnEdit_AkmalFauzi_Click(sender As Object, e As EventArgs) Handles BtnEdit_AkmalFauzi.Click

        If TxtIDPelanggan_AkmalFauzi.Text = "" Or TxtNama_AkmalFauzi.Text = "" Or TxtEmail_AkmalFauzi.Text = "" Or TxtNoTelepon_AkmalFauzi.Text = "" Or ComboBoxPendidikan_AkmalFauzi.Text = "" Or TxtAlamat_AkmalFauzi.Text = "" Or (RadioBtnLakiLaki_AkmalFauzi.Checked = False And RadioBtnPerempuan_AkmalFauzi.Checked = False) Then
            MessageBox.Show("Pastikan Semua field diisi!")
        Else

            Try
                Call Koneksi()

                Dim JenisKelamin As String
                If RadioBtnLakiLaki_AkmalFauzi.Checked Then
                    JenisKelamin = "Laki-Laki"
                Else
                    JenisKelamin = "Perempuan"
                End If

                Dim EditData As String = "UPDATE pelanggan SET id='" & TxtIDPelanggan_AkmalFauzi.Text & "', nama='" & TxtNama_AkmalFauzi.Text & "', jenis_kelamin='" & JenisKelamin & "', email='" & TxtEmail_AkmalFauzi.Text & "', no_telepon='" & TxtNoTelepon_AkmalFauzi.Text & "', pendidikan_terakhir='" & ComboBoxPendidikan_AkmalFauzi.Text & "', alamat='" & TxtAlamat_AkmalFauzi.Text & "' , tanggal='" & DateTimePicker1_AkmalFauzi.Text & "' WHERE id='" & TxtIDPelanggan_AkmalFauzi.Text & "' "
                Cmd = New OdbcCommand(EditData, Conn)
                Cmd.ExecuteNonQuery()
                MessageBox.Show("Edit Data Berhasil")

                Call Bersih()
                Call KondisiAwal()
            Catch ex As Exception
                MessageBox.Show("Edit Data Gagal!")
            End Try

        End If

    End Sub

    Private Sub BtnHapus_AkmalFauzi_Click(sender As Object, e As EventArgs) Handles BtnHapus_AkmalFauzi.Click
        If TxtIDPelanggan_AkmalFauzi.Text = "" Or TxtNama_AkmalFauzi.Text = "" Or TxtEmail_AkmalFauzi.Text = "" Or TxtNoTelepon_AkmalFauzi.Text = "" Or ComboBoxPendidikan_AkmalFauzi.Text = "" Or TxtAlamat_AkmalFauzi.Text = "" Or (RadioBtnLakiLaki_AkmalFauzi.Checked = False And RadioBtnPerempuan_AkmalFauzi.Checked = False) Then
            MessageBox.Show("Pastikan Semua field diisi!")
        Else
            Try
                Call Koneksi()

                Dim HapusData As String = "DELETE FROM pelanggan WHERE id='" & TxtIDPelanggan_AkmalFauzi.Text & "' "
                Cmd = New OdbcCommand(HapusData, Conn)
                Cmd.ExecuteNonQuery()
                MessageBox.Show("Hapus Data Berhasil")

                Call KondisiAwal()
                Call Bersih()
            Catch ex As Exception
                MessageBox.Show("Hapus Data Gagal!")
            End Try
        End If
    End Sub

    Sub EnableActionButton()
        BtnInput_AkmalFauzi.Text = "INPUT"

        BtnEdit_AkmalFauzi.Enabled = True
        BtnHapus_AkmalFauzi.Enabled = True
    End Sub

    Private Sub BtnTutup_AkmalFauzi_Click(sender As Object, e As EventArgs) Handles BtnTutup_AkmalFauzi.Click
        If BtnTutup_AkmalFauzi.Text = "CANCEL" Then
            BtnTutup_AkmalFauzi.Text = "TUTUP"
            Call EnableActionButton()
            Call DisableForm()
        Else
            End
        End If

    End Sub

    Sub SearchPelanggan()
        Cmd = New OdbcCommand("SELECT * FROM pelanggan WHERE id = '" & TxtCari_AkmalFauzi.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then

            If Rd.Item("jenis_kelamin") = "Laki-Laki" Then
                RadioBtnLakiLaki_AkmalFauzi.Checked = True
            Else
                RadioBtnPerempuan_AkmalFauzi.Checked = True
            End If

            TxtIDPelanggan_AkmalFauzi.Text = Rd.Item("id")
            TxtNama_AkmalFauzi.Text = Rd.Item("nama")
            TxtEmail_AkmalFauzi.Text = Rd.Item("email")
            TxtNoTelepon_AkmalFauzi.Text = Rd.Item("no_telepon")
            ComboBoxPendidikan_AkmalFauzi.Text = Rd.Item("pendidikan_terakhir")
            TxtAlamat_AkmalFauzi.Text = Rd.Item("alamat")
        Else
            MessageBox.Show("Data Tidak Ada")
        End If
    End Sub

    Sub SearchPelangganFromFilter()
        Call Koneksi()
        Da = New OdbcDataAdapter("SELECT * FROM pelanggan WHERE id = '" & TxtSearchPelanggan_AkmalFauzi.Text & "' OR nama = '" & TxtSearchPelanggan_AkmalFauzi.Text & "'", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Pelanggan")
        DataGridView1.DataSource = (Ds.Tables("Pelanggan"))
    End Sub

    Private Sub BtnCari_AkmalFauzi_Click(sender As Object, e As EventArgs) Handles BtnCari_AkmalFauzi.Click
        If TxtCari_AkmalFauzi.Text = "" Then
            MessageBox.Show("Field Cari Harus diisi!")
        Else
            Call SearchPelanggan()
            Call EnableForm()
        End If
    End Sub

    Private Sub BtnSearchPelanggan_AkmalFauzi_Click(sender As Object, e As EventArgs) Handles BtnSearchPelanggan_AkmalFauzi.Click
        If TxtSearchPelanggan_AkmalFauzi.Text = "" Then
            MessageBox.Show("Field Cari Harus diisi!")
        Else
            Call SearchPelangganFromFilter()
        End If
    End Sub

    Private Sub BtnReset_AkmalFauzi_Click(sender As Object, e As EventArgs) Handles BtnReset_AkmalFauzi.Click
        TxtSearchPelanggan_AkmalFauzi.Text = ""
        Da = New OdbcDataAdapter("SELECT * FROM pelanggan", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Pelanggan")
        DataGridView1.DataSource = (Ds.Tables("Pelanggan"))
    End Sub

    Private Sub TxtIDPelanggan_AkmalFauzi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtIDPelanggan_AkmalFauzi.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New OdbcCommand("SELECT * FROM pelanggan WHERE id = '" & TxtIDPelanggan_AkmalFauzi.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then

                If Rd.Item("jenis_kelamin") = "Laki-Laki" Then
                    RadioBtnLakiLaki_AkmalFauzi.Checked = True
                Else
                    RadioBtnPerempuan_AkmalFauzi.Checked = True
                End If

                TxtIDPelanggan_AkmalFauzi.Text = Rd.Item("id")
                TxtNama_AkmalFauzi.Text = Rd.Item("nama")
                TxtEmail_AkmalFauzi.Text = Rd.Item("email")
                TxtNoTelepon_AkmalFauzi.Text = Rd.Item("no_telepon")
                ComboBoxPendidikan_AkmalFauzi.Text = Rd.Item("pendidikan_terakhir")
                TxtAlamat_AkmalFauzi.Text = Rd.Item("alamat")
            Else
                MessageBox.Show("Data Tidak Ada")
            End If
        End If
    End Sub

End Class