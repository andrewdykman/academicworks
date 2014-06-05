<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFilePrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRealEstate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRealEstateAddNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRealEstateSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRandomGenerator = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.BackColor = System.Drawing.Color.Transparent
        Me.lblDateTime.Location = New System.Drawing.Point(-1, 304)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(0, 13)
        Me.lblDateTime.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuRealEstate})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(391, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFilePrint, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuFilePrint
        '
        Me.mnuFilePrint.Name = "mnuFilePrint"
        Me.mnuFilePrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuFilePrint.Size = New System.Drawing.Size(140, 22)
        Me.mnuFilePrint.Text = "Print"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuFileExit.Size = New System.Drawing.Size(140, 22)
        Me.mnuFileExit.Text = "Exit"
        '
        'mnuRealEstate
        '
        Me.mnuRealEstate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRealEstateAddNew, Me.mnuRealEstateSearch})
        Me.mnuRealEstate.Name = "mnuRealEstate"
        Me.mnuRealEstate.Size = New System.Drawing.Size(75, 20)
        Me.mnuRealEstate.Text = "Real Estate"
        '
        'mnuRealEstateAddNew
        '
        Me.mnuRealEstateAddNew.Name = "mnuRealEstateAddNew"
        Me.mnuRealEstateAddNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuRealEstateAddNew.Size = New System.Drawing.Size(165, 22)
        Me.mnuRealEstateAddNew.Text = "Add New"
        '
        'mnuRealEstateSearch
        '
        Me.mnuRealEstateSearch.Name = "mnuRealEstateSearch"
        Me.mnuRealEstateSearch.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuRealEstateSearch.Size = New System.Drawing.Size(165, 22)
        Me.mnuRealEstateSearch.Text = "Search"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(125, 273)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 43)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "This application allows users to search for available properties, add properties," & _
    " and check to see if they qualify for any properties. "
        '
        'lblRandomGenerator
        '
        Me.lblRandomGenerator.AutoSize = True
        Me.lblRandomGenerator.Location = New System.Drawing.Point(-3, 24)
        Me.lblRandomGenerator.MinimumSize = New System.Drawing.Size(64, 13)
        Me.lblRandomGenerator.Name = "lblRandomGenerator"
        Me.lblRandomGenerator.Size = New System.Drawing.Size(64, 13)
        Me.lblRandomGenerator.TabIndex = 4
        '
        'PrintDocument1
        '
        '
        'ofdOpenFile
        '
        Me.ofdOpenFile.FileName = "OpenFileDialog1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(391, 316)
        Me.Controls.Add(Me.lblRandomGenerator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Credit Approval Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFilePrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRealEstate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRealEstateAddNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRealEstateSearch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblRandomGenerator As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ofdOpenFile As System.Windows.Forms.OpenFileDialog

End Class
