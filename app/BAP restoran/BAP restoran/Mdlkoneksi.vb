Imports System.Data.OleDb
Module Mdlkoneksi
    Public cn As OleDbConnection
    Public CMD As OleDbCommand
    Public DA As OleDbDataAdapter
    Public DR As OleDbDataReader
    Public DS As DataSet
    Public sql, msg As String

    Public Sub runsql()
        Try
            konek()
            CMD = New OleDb.OleDbCommand(sql, cn)
            CMD.ExecuteNonQuery()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub konek()
        Try
            cn = New OleDbConnection("provider =microsoft.jet.oledb.4.0;data source=db_restoran.mdb")
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
        Catch ex As Exception
            MsgBox("Error Koneksi")
        End Try
    End Sub
End Module