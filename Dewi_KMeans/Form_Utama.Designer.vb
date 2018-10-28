<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Utama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProsesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataPasienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PenentuanTitikPusatClusterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProsesClusterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanHandphoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProsesToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(900, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataPasienToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ProsesToolStripMenuItem
        '
        Me.ProsesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenentuanTitikPusatClusterToolStripMenuItem, Me.ProsesClusterToolStripMenuItem})
        Me.ProsesToolStripMenuItem.Name = "ProsesToolStripMenuItem"
        Me.ProsesToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ProsesToolStripMenuItem.Text = "Proses"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanHandphoneToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'DataPasienToolStripMenuItem
        '
        Me.DataPasienToolStripMenuItem.Name = "DataPasienToolStripMenuItem"
        Me.DataPasienToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DataPasienToolStripMenuItem.Text = "Data HP"
        '
        'PenentuanTitikPusatClusterToolStripMenuItem
        '
        Me.PenentuanTitikPusatClusterToolStripMenuItem.Name = "PenentuanTitikPusatClusterToolStripMenuItem"
        Me.PenentuanTitikPusatClusterToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.PenentuanTitikPusatClusterToolStripMenuItem.Text = "Penentuan Titik Pusat Cluster"
        '
        'ProsesClusterToolStripMenuItem
        '
        Me.ProsesClusterToolStripMenuItem.Name = "ProsesClusterToolStripMenuItem"
        Me.ProsesClusterToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.ProsesClusterToolStripMenuItem.Text = "Proses Cluster"
        '
        'LaporanHandphoneToolStripMenuItem
        '
        Me.LaporanHandphoneToolStripMenuItem.Name = "LaporanHandphoneToolStripMenuItem"
        Me.LaporanHandphoneToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.LaporanHandphoneToolStripMenuItem.Text = "Laporan Handphone"
        '
        'Form_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 485)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form_Utama"
        Me.Text = "Form_Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProsesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPasienToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenentuanTitikPusatClusterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProsesClusterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanHandphoneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
