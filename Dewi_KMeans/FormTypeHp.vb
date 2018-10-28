Imports System.Data.OleDb
Public Class FormTypeHp
    Sub tampil()
        Try
            Using kon As New OleDbConnection(Vkoneksi)
                Using perintah As New OleDbCommand("select * from Tbl_hp order by kodehp", kon)
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

    Sub mati()
        btnEdit.Enabled = False
        btnHapus.Enabled = False
        btnSimpan.Enabled = False
        BtnTambah.Enabled = True
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Call bersih()
        Call tampil()
        Call mati()
        Call non_aktif()
    End Sub

    Sub bersih()
        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox3.Text = ""
        ComboBox2.Text = ""
        ComboBox1.Text = ""
        'TextBox7.Clear()

        btnSimpan.Enabled = True
    End Sub

    Sub aktif()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        ComboBox3.Enabled = True
        ComboBox2.Enabled = True
        ComboBox1.Enabled = True
    End Sub

    Sub non_aktif()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        ComboBox3.Enabled = False
        ComboBox2.Enabled = False
        ComboBox1.Enabled = False
    End Sub
    Sub oto_number()
        Try
            Using konek As New OleDbConnection(Vkoneksi)
                Using perintah As New OleDbCommand("select max(right(kodehp,2)) as nomor from Tbl_hp", konek)
                    konek.Open()
                    Using Data As OleDbDataReader = perintah.ExecuteReader
                        Data.Read()
                        If Data.HasRows = True Then
                            Dim x, nomor_max As Integer
                            nomor_max = Microsoft.VisualBasic.Right(Data("nomor").ToString, 2)
                            x = nomor_max + 1
                            If Len(Trim(x)) = 1 Then
                                TextBox1.Text = "0" & x
                            ElseIf Len(Trim(x)) = 2 Then
                                TextBox1.Text = x
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch kesalahan As Exception
            MsgBox(kesalahan.Message())
        End Try
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        Call aktif()
        btnSimpan.Enabled = True
        BtnTambah.Enabled = False
        btnEdit.Enabled = False
        btnHapus.Enabled = False

        oto_number()
        TextBox2.Focus()
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        TextBox1.Text = ListView1.SelectedItems(0).Text.ToString
        TextBox2.Text = ListView1.SelectedItems(0).SubItems(1).Text.ToString
        ComboBox3.Text = ListView1.SelectedItems(0).SubItems(2).Text.ToString
        ComboBox2.Text = ListView1.SelectedItems(0).SubItems(3).Text.ToString
        ComboBox1.Text = ListView1.SelectedItems(0).SubItems(4).Text.ToString

        btnSimpan.Enabled = False
        btnEdit.Enabled = True
        btnHapus.Enabled = True
        Call aktif()
    End Sub
    Private Sub ListView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListView1.KeyDown
        If e.KeyCode = 13 Then
            ListView1_DoubleClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        Call bersih()
        Close()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Data belum lengkap !", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Using koneksi As New OleDbConnection(Vkoneksi)
                Using tindakan As New OleDbCommand("insert into Tbl_hp values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox3.Text & "','" & ComboBox2.Text & "','" & ComboBox1.Text & "')", koneksi)
                    koneksi.Open()
                    tindakan.CommandType = CommandType.Text
                    tindakan.ExecuteNonQuery()
                    MsgBox("Data telah ditambahkan", MsgBoxStyle.Information, "Program Information")
                    Call tampil()
                    Call bersih()
                    btnRefresh_Click(Nothing, Nothing)
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If TextBox1.Text = "" Then
            MsgBox("Pilih data yang diedit !", MsgBoxStyle.Information)
            Exit Sub
        End If

        Try
            Using koneksi As New OleDbConnection(Vkoneksi)
                Using tindakan As New OleDbCommand("Update Tbl_hp set typehp='" & TextBox2.Text & "',jumlahterjual='" & ComboBox3.Text & "',spesifikasi='" & ComboBox2.Text & "',harga= '" & ComboBox1.Text & _
                                                   "' where kodehp= '" & TextBox1.Text & "'", koneksi)
                    koneksi.Open()
                    tindakan.CommandType = CommandType.Text
                    tindakan.ExecuteNonQuery()
                    MsgBox("Data berhasil diedit", MsgBoxStyle.Information, "Program Information")
                    Call tampil()
                    Call bersih()
                    btnRefresh_Click(Nothing, Nothing)
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If TextBox1.Text = "" Then
            MsgBox("Harap pilih data yang dihapus !", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            ' untuk menghapus data
            Using koneksi As New OleDbConnection(Vkoneksi)
                Dim tombol As Integer
                tombol = MsgBox("Yakin akan menghapus data ini ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pesan Peringatan")
                If tombol = vbYes Then
                    Using tindakan As New OleDbCommand("delete * from Tbl_hp where kodehp= '" & TextBox1.Text & "'", koneksi)
                        koneksi.Open()
                        tindakan.CommandType = CommandType.Text
                        tindakan.ExecuteNonQuery()
                        MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Program Information")
                        Call tampil()
                        Call bersih()
                        btnRefresh_Click(Nothing, Nothing)
                    End Using
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Private Sub FormTypeHp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampil()
        Call non_aktif()
    End Sub
End Class