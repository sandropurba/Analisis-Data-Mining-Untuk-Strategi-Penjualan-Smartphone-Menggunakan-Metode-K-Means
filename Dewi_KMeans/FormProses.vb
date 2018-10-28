Imports System.Data.OleDb
Public Class FormProses
    Sub inisialisasi()
        ' delete dulu
        Using koneksi As New OleDbConnection(Vkoneksi)
            Using tindakan As New OleDbCommand("delete * from Temp_Inisialisasi", koneksi)
                koneksi.Open()
                tindakan.CommandType = CommandType.Text
                tindakan.ExecuteNonQuery()
            End Using
        End Using

        Dim jumlahterjual, spesifikasi, harga As Integer

        Try
            Using kon As New OleDbConnection(Vkoneksi)
                Using perintah As New OleDbCommand("select * from Tbl_hp order by kodehp", kon)
                    kon.Open()
                    Using Data As OleDbDataReader = perintah.ExecuteReader
                        While Data.Read

                            If Data("jumlahterjual") = "49-0" Then
                                jumlahterjual = 1
                            ElseIf Data("alamat") = "99-50" Then
                                jumlahterjual = 2
                            ElseIf Data("alamat") = "200-100" Then
                                jumlahterjual = 3
                            Else
                                jumlahterjual = 2
                           
                            End If

                            If Data("spesifikasi") = "Tidak Canggih" Then
                                spesifikasi = 1
                            ElseIf Data("spesifikasi") = "Kurang Canggih" Then
                                spesifikasi = 2
                            ElseIf Data("spesifikasi") = "Cukup Canggih" Then
                                spesifikasi = 3
                            ElseIf Data("spesifikasi") = "Canggih" Then
                                spesifikasi = 4
                            ElseIf Data("spesifikasi") = "Sangat Canggih" Then
                                spesifikasi = 5

                            End If

                            If Data("harga") = "Sangat Murah" Then
                                harga = 1
                            ElseIf Data("harga") = "Sedang" Then
                                harga = 2
                            ElseIf Data("harga") = "Sangat Mahal" Then
                                harga = 3
                            End If

                            ' lalu insert
                            Using koneksi As New OleDbConnection(Vkoneksi)
                                Using tindakan As New OleDbCommand("insert into Temp_Inisialisasi values ('" & Data("kodehp") & "','" & Data("typehp") & "','" & jumlahterjual & "','" & spesifikasi & "','" & harga & "')", koneksi)
                                    koneksi.Open()
                                    tindakan.CommandType = CommandType.Text
                                    tindakan.ExecuteNonQuery()
                                End Using
                            End Using


                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub
    Private Sub FormProses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inisialisasi()

        'tampil
        Try
            Using kon As New OleDbConnection(Vkoneksi)
                Using perintah As New OleDbCommand("select * from Temp_Inisialisasi order by kodehp", kon)
                    kon.Open()
                    Using Data As OleDbDataReader = perintah.ExecuteReader
                        Dim II As Integer
                        ListView1.Items.Clear()
                        While Data.Read
                            ListView1.Items.Add(IIf(IsDBNull(Data("kodehp")) = True, "", Data("kodehp")))
                            ListView1.Items(II).SubItems.Add(IIf(IsDBNull(Data("typehp")) = True, "", Data("typehp")))
                            ListView1.Items(II).SubItems.Add(IIf(IsDBNull(Data("jumlahterjual")) = True, "", Data("jumlahterjual")))
                            ListView1.Items(II).SubItems.Add(IIf(IsDBNull(Data("spesifikasi")) = True, "", Data("spesifikasi")))
                            ListView1.Items(II).SubItems.Add(IIf(IsDBNull(Data("harga")) = True, "", Data("harga")))
                            II = II + 1
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        ListView2.Items.Clear()
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Dim str(5) As String
        Dim itm As ListViewItem
        str(0) = ListView1.SelectedItems(0).Text.ToString
        str(1) = ListView1.SelectedItems(0).SubItems(1).Text.ToString
        str(2) = ListView1.SelectedItems(0).SubItems(2).Text.ToString
        str(3) = ListView1.SelectedItems(0).SubItems(3).Text.ToString
        str(4) = ListView1.SelectedItems(0).SubItems(4).Text.ToString

        itm = New ListViewItem(str)
        ListView2.Items.Add(itm)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' cek data
        Dim jumlah As Integer
        For i As Integer = 0 To ListView2.Items.Count - 1
            jumlah += 1
        Next
        If jumlah <> 3 Then
            MsgBox("Hanya Boleh 3 Titik Pusat Cluster !", MsgBoxStyle.Exclamation)
            Exit Sub
        End If


        ' delete dulu
        Using koneksi As New OleDbConnection(Vkoneksi)
            Using tindakan As New OleDbCommand("delete * from Temp_PusatCluster1", koneksi)
                koneksi.Open()
                tindakan.CommandType = CommandType.Text
                tindakan.ExecuteNonQuery()
            End Using
        End Using
        Dim cluster = 1
        For i As Integer = 0 To ListView2.Items.Count - 1
            Using koneksi As New OleDbConnection(Vkoneksi)
                Using perintah As New OleDbCommand("insert into Temp_PusatCluster1 values ('" & cluster & "','" & ListView2.Items(i).SubItems(0).Text & "','" & ListView2.Items(i).SubItems(1).Text & "','" & ListView2.Items(i).SubItems(2).Text & "','" & ListView2.Items(i).SubItems(3).Text & "','" & ListView2.Items(i).SubItems(4).Text & "')", koneksi)
                    koneksi.Open()
                    perintah.CommandType = CommandType.Text
                    perintah.ExecuteNonQuery()
                End Using
            End Using
            cluster += 1
        Next
        MsgBox("Titik Pusat Cluster Telah Disimpan.", MsgBoxStyle.Information)
    End Sub
    Private Sub ListView2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListView2.KeyDown
        If e.KeyCode = Keys.Delete Then
            For Each lvItem As ListViewItem In ListView2.SelectedItems
                lvItem.Remove()
            Next
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class