Public Class Form_Utama

    Private Sub DataPasienToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPasienToolStripMenuItem.Click
        FormTypeHp.Show()
    End Sub

    Private Sub PenentuanTitikPusatClusterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenentuanTitikPusatClusterToolStripMenuItem.Click
        FormProses.Show()
    End Sub

    Private Sub ProsesClusterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProsesClusterToolStripMenuItem.Click
        FormProses2.Show()
    End Sub

    Private Sub LaporanHandphoneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanHandphoneToolStripMenuItem.Click
        Laporan.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub
End Class