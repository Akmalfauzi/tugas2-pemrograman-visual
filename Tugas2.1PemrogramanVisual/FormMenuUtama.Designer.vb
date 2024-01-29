<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataAnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1_AkmalFauzi = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1_1_AkmalFauzi = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2_AkmalFauzi = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2_1_AkmalFauzi = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3_AkmalFauzi = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3_1_AkmalFauzi = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4_AkmalFauzi = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4_1_AkmalFauzi = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5_AkmalFauzi = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5_1_AkmalFauzi = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MasterToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(997, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(120, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataAnggotaToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'DataAnggotaToolStripMenuItem
        '
        Me.DataAnggotaToolStripMenuItem.Name = "DataAnggotaToolStripMenuItem"
        Me.DataAnggotaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.DataAnggotaToolStripMenuItem.Text = "Data Pelanggan"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1_AkmalFauzi, Me.ToolStripStatusLabel1_1_AkmalFauzi, Me.ToolStripStatusLabel2_AkmalFauzi, Me.ToolStripStatusLabel2_1_AkmalFauzi, Me.ToolStripStatusLabel3_AkmalFauzi, Me.ToolStripStatusLabel3_1_AkmalFauzi, Me.ToolStripStatusLabel4_AkmalFauzi, Me.ToolStripStatusLabel4_1_AkmalFauzi, Me.ToolStripStatusLabel5_AkmalFauzi, Me.ToolStripStatusLabel5_1_AkmalFauzi})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 439)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(997, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1_AkmalFauzi
        '
        Me.ToolStripStatusLabel1_AkmalFauzi.Name = "ToolStripStatusLabel1_AkmalFauzi"
        Me.ToolStripStatusLabel1_AkmalFauzi.Size = New System.Drawing.Size(43, 17)
        Me.ToolStripStatusLabel1_AkmalFauzi.Text = "Kode : "
        '
        'ToolStripStatusLabel1_1_AkmalFauzi
        '
        Me.ToolStripStatusLabel1_1_AkmalFauzi.Name = "ToolStripStatusLabel1_1_AkmalFauzi"
        Me.ToolStripStatusLabel1_1_AkmalFauzi.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel2_AkmalFauzi
        '
        Me.ToolStripStatusLabel2_AkmalFauzi.Name = "ToolStripStatusLabel2_AkmalFauzi"
        Me.ToolStripStatusLabel2_AkmalFauzi.Size = New System.Drawing.Size(48, 17)
        Me.ToolStripStatusLabel2_AkmalFauzi.Text = "Nama : "
        '
        'ToolStripStatusLabel2_1_AkmalFauzi
        '
        Me.ToolStripStatusLabel2_1_AkmalFauzi.Name = "ToolStripStatusLabel2_1_AkmalFauzi"
        Me.ToolStripStatusLabel2_1_AkmalFauzi.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel3_AkmalFauzi
        '
        Me.ToolStripStatusLabel3_AkmalFauzi.Name = "ToolStripStatusLabel3_AkmalFauzi"
        Me.ToolStripStatusLabel3_AkmalFauzi.Size = New System.Drawing.Size(43, 17)
        Me.ToolStripStatusLabel3_AkmalFauzi.Text = "Level : "
        '
        'ToolStripStatusLabel3_1_AkmalFauzi
        '
        Me.ToolStripStatusLabel3_1_AkmalFauzi.Name = "ToolStripStatusLabel3_1_AkmalFauzi"
        Me.ToolStripStatusLabel3_1_AkmalFauzi.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel4_AkmalFauzi
        '
        Me.ToolStripStatusLabel4_AkmalFauzi.Name = "ToolStripStatusLabel4_AkmalFauzi"
        Me.ToolStripStatusLabel4_AkmalFauzi.Size = New System.Drawing.Size(57, 17)
        Me.ToolStripStatusLabel4_AkmalFauzi.Text = "Tanggal : "
        '
        'ToolStripStatusLabel4_1_AkmalFauzi
        '
        Me.ToolStripStatusLabel4_1_AkmalFauzi.Name = "ToolStripStatusLabel4_1_AkmalFauzi"
        Me.ToolStripStatusLabel4_1_AkmalFauzi.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel5_AkmalFauzi
        '
        Me.ToolStripStatusLabel5_AkmalFauzi.Name = "ToolStripStatusLabel5_AkmalFauzi"
        Me.ToolStripStatusLabel5_AkmalFauzi.Size = New System.Drawing.Size(37, 17)
        Me.ToolStripStatusLabel5_AkmalFauzi.Text = "Jam : "
        '
        'ToolStripStatusLabel5_1_AkmalFauzi
        '
        Me.ToolStripStatusLabel5_1_AkmalFauzi.Name = "ToolStripStatusLabel5_1_AkmalFauzi"
        Me.ToolStripStatusLabel5_1_AkmalFauzi.Size = New System.Drawing.Size(0, 17)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Tugas2._1PemrogramanVisual.My.Resources.Resources.Biru_Gradasi_Projek_Kelompok_Teknologi_Presentasi__7_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(997, 461)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenuUtama"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Menu Utama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataAnggotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1_AkmalFauzi As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2_AkmalFauzi As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3_AkmalFauzi As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4_AkmalFauzi As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5_AkmalFauzi As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel1_1_AkmalFauzi As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2_1_AkmalFauzi As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3_1_AkmalFauzi As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4_1_AkmalFauzi As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5_1_AkmalFauzi As System.Windows.Forms.ToolStripStatusLabel

End Class
