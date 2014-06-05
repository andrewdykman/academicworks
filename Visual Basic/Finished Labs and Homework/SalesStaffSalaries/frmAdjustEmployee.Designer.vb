<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectingSalesStaff
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
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.lblSalaryDescriptor = New System.Windows.Forms.Label
        Me.txtHireDateDescriptor = New System.Windows.Forms.Label
        Me.chkFullTime = New System.Windows.Forms.CheckBox
        Me.txtId = New System.Windows.Forms.TextBox
        Me.lblIdDescriptor = New System.Windows.Forms.Label
        Me.cmbNames = New System.Windows.Forms.ComboBox
        Me.lblSelectaNameDescriptor = New System.Windows.Forms.Label
        Me.cmbHireDate = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(60, 156)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 17
        '
        'lblSalaryDescriptor
        '
        Me.lblSalaryDescriptor.AutoSize = True
        Me.lblSalaryDescriptor.Location = New System.Drawing.Point(15, 163)
        Me.lblSalaryDescriptor.Name = "lblSalaryDescriptor"
        Me.lblSalaryDescriptor.Size = New System.Drawing.Size(39, 13)
        Me.lblSalaryDescriptor.TabIndex = 16
        Me.lblSalaryDescriptor.Text = "Salary:"
        '
        'txtHireDateDescriptor
        '
        Me.txtHireDateDescriptor.AutoSize = True
        Me.txtHireDateDescriptor.Location = New System.Drawing.Point(12, 128)
        Me.txtHireDateDescriptor.Name = "txtHireDateDescriptor"
        Me.txtHireDateDescriptor.Size = New System.Drawing.Size(55, 13)
        Me.txtHireDateDescriptor.TabIndex = 15
        Me.txtHireDateDescriptor.Text = "Hire Date:"
        '
        'chkFullTime
        '
        Me.chkFullTime.AutoSize = True
        Me.chkFullTime.Location = New System.Drawing.Point(18, 97)
        Me.chkFullTime.Name = "chkFullTime"
        Me.chkFullTime.Size = New System.Drawing.Size(68, 17)
        Me.chkFullTime.TabIndex = 13
        Me.chkFullTime.Text = "Full Time"
        Me.chkFullTime.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(43, 59)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 12
        '
        'lblIdDescriptor
        '
        Me.lblIdDescriptor.AutoSize = True
        Me.lblIdDescriptor.Location = New System.Drawing.Point(15, 67)
        Me.lblIdDescriptor.Name = "lblIdDescriptor"
        Me.lblIdDescriptor.Size = New System.Drawing.Size(21, 13)
        Me.lblIdDescriptor.TabIndex = 11
        Me.lblIdDescriptor.Text = "ID:"
        '
        'cmbNames
        '
        Me.cmbNames.FormattingEnabled = True
        Me.cmbNames.Location = New System.Drawing.Point(15, 26)
        Me.cmbNames.Name = "cmbNames"
        Me.cmbNames.Size = New System.Drawing.Size(121, 21)
        Me.cmbNames.TabIndex = 10
        '
        'lblSelectaNameDescriptor
        '
        Me.lblSelectaNameDescriptor.AutoSize = True
        Me.lblSelectaNameDescriptor.Location = New System.Drawing.Point(12, 9)
        Me.lblSelectaNameDescriptor.Name = "lblSelectaNameDescriptor"
        Me.lblSelectaNameDescriptor.Size = New System.Drawing.Size(80, 13)
        Me.lblSelectaNameDescriptor.TabIndex = 9
        Me.lblSelectaNameDescriptor.Text = "Select a Name:"
        '
        'cmbHireDate
        '
        Me.cmbHireDate.FormattingEnabled = True
        Me.cmbHireDate.Location = New System.Drawing.Point(73, 128)
        Me.cmbHireDate.Name = "cmbHireDate"
        Me.cmbHireDate.Size = New System.Drawing.Size(121, 21)
        Me.cmbHireDate.TabIndex = 14
        '
        'frmSelectingSalesStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 194)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblSalaryDescriptor)
        Me.Controls.Add(Me.txtHireDateDescriptor)
        Me.Controls.Add(Me.cmbHireDate)
        Me.Controls.Add(Me.chkFullTime)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblIdDescriptor)
        Me.Controls.Add(Me.cmbNames)
        Me.Controls.Add(Me.lblSelectaNameDescriptor)
        Me.Name = "frmSelectingSalesStaff"
        Me.Text = "Selecting Sales Staff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblSalaryDescriptor As System.Windows.Forms.Label
    Friend WithEvents txtHireDateDescriptor As System.Windows.Forms.Label
    Friend WithEvents chkFullTime As System.Windows.Forms.CheckBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblIdDescriptor As System.Windows.Forms.Label
    Friend WithEvents cmbNames As System.Windows.Forms.ComboBox
    Friend WithEvents lblSelectaNameDescriptor As System.Windows.Forms.Label
    Friend WithEvents cmbHireDate As System.Windows.Forms.ComboBox
End Class
