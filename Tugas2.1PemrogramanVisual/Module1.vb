Imports System.Data.Odbc
Module Module1

    'Prosedur Umum
    Public Conn As OdbcConnection
    Public Cmd As OdbcCommand
    Public Rd As OdbcDataReader
    Public Da As OdbcDataAdapter
    Public Ds As New DataSet
    Public str As String

    'Prosedur untuk koneksi ke database
    Public Sub Koneksi()

        Try
            str = "DSN=dsn_pelanggan"
            Conn = New OdbcConnection(str)
            If CONN.State = ConnectionState.Closed Then
                Conn.Open()
                'MessageBox.Show("Database Berhasil Terkoneksi", "warning")
            End If
        Catch ex As Exception
            MessageBox.Show("Database Tidak terkoneksi", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module