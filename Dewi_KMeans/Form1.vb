Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TxtUser.Text = "dewi" And TxtPassword.Text = "1234" Then
            Form_Utama.Show()
            Me.Hide()
        Else
            MsgBox("Nama User atau Password Salah. Ulangi !", MsgBoxStyle.Critical)
            TxtUser.Text = ""
            TxtPassword.Text = ""
            TxtUser.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
