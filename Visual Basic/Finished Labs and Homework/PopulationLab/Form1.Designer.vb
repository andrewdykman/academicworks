<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPopluationLab
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnGo = New System.Windows.Forms.Button
        Me.lstShow = New System.Windows.Forms.ListBox
        Me.cboOrganism = New System.Windows.Forms.ComboBox
        Me.cboDays = New System.Windows.Forms.ComboBox
        Me.txtIncrease = New System.Windows.Forms.TextBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblNumberofOrganisms = New System.Windows.Forms.Label
        Me.lblAvgDailyIncreaseinPer = New System.Windows.Forms.Label
        Me.lblNumberofDays = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(273, 325)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(147, 37)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "&Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'lstShow
        '
        Me.lstShow.FormattingEnabled = True
        Me.lstShow.Location = New System.Drawing.Point(12, 12)
        Me.lstShow.Name = "lstShow"
        Me.lstShow.Size = New System.Drawing.Size(239, 394)
        Me.lstShow.TabIndex = 1
        '
        'cboOrganism
        '
        Me.cboOrganism.FormattingEnabled = True
        Me.cboOrganism.Location = New System.Drawing.Point(273, 28)
        Me.cboOrganism.Name = "cboOrganism"
        Me.cboOrganism.Size = New System.Drawing.Size(147, 21)
        Me.cboOrganism.TabIndex = 2
        '
        'cboDays
        '
        Me.cboDays.FormattingEnabled = True
        Me.cboDays.Location = New System.Drawing.Point(273, 244)
        Me.cboDays.Name = "cboDays"
        Me.cboDays.Size = New System.Drawing.Size(147, 21)
        Me.cboDays.TabIndex = 3
        '
        'txtIncrease
        '
        Me.txtIncrease.Location = New System.Drawing.Point(273, 133)
        Me.txtIncrease.Name = "txtIncrease"
        Me.txtIncrease.Size = New System.Drawing.Size(145, 20)
        Me.txtIncrease.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(273, 368)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(73, 37)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(352, 368)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(68, 37)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblNumberofOrganisms
        '
        Me.lblNumberofOrganisms.AutoSize = True
        Me.lblNumberofOrganisms.Location = New System.Drawing.Point(270, 12)
        Me.lblNumberofOrganisms.Name = "lblNumberofOrganisms"
        Me.lblNumberofOrganisms.Size = New System.Drawing.Size(111, 13)
        Me.lblNumberofOrganisms.TabIndex = 7
        Me.lblNumberofOrganisms.Text = "Number of Organisms:"
        '
        'lblAvgDailyIncreaseinPer
        '
        Me.lblAvgDailyIncreaseinPer.AutoSize = True
        Me.lblAvgDailyIncreaseinPer.Location = New System.Drawing.Point(270, 117)
        Me.lblAvgDailyIncreaseinPer.Name = "lblAvgDailyIncreaseinPer"
        Me.lblAvgDailyIncreaseinPer.Size = New System.Drawing.Size(148, 13)
        Me.lblAvgDailyIncreaseinPer.TabIndex = 8
        Me.lblAvgDailyIncreaseinPer.Text = "Average Daily Increase (in %):"
        '
        'lblNumberofDays
        '
        Me.lblNumberofDays.AutoSize = True
        Me.lblNumberofDays.Location = New System.Drawing.Point(272, 228)
        Me.lblNumberofDays.Name = "lblNumberofDays"
        Me.lblNumberofDays.Size = New System.Drawing.Size(86, 13)
        Me.lblNumberofDays.TabIndex = 9
        Me.lblNumberofDays.Text = "Number of Days:"
        '
        'frmPopluationLab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 417)
        Me.Controls.Add(Me.lblNumberofDays)
        Me.Controls.Add(Me.lblAvgDailyIncreaseinPer)
        Me.Controls.Add(Me.lblNumberofOrganisms)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtIncrease)
        Me.Controls.Add(Me.cboDays)
        Me.Controls.Add(Me.cboOrganism)
        Me.Controls.Add(Me.lstShow)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "frmPopluationLab"
        Me.Text = "Population Lab"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents lstShow As System.Windows.Forms.ListBox
    Friend WithEvents cboOrganism As System.Windows.Forms.ComboBox
    Friend WithEvents cboDays As System.Windows.Forms.ComboBox
    Friend WithEvents txtIncrease As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblNumberofOrganisms As System.Windows.Forms.Label
    Friend WithEvents lblAvgDailyIncreaseinPer As System.Windows.Forms.Label
    Friend WithEvents lblNumberofDays As System.Windows.Forms.Label

End Class
