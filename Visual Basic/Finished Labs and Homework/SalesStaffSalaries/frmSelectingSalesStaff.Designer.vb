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
        Me.components = New System.ComponentModel.Container
        Me.lblSelectaNameDescriptor = New System.Windows.Forms.Label
        Me.cmbNames = New System.Windows.Forms.ComboBox
        Me.lblIdDescriptor = New System.Windows.Forms.Label
        Me.txtId = New System.Windows.Forms.TextBox
        Me.chkFullTime = New System.Windows.Forms.CheckBox
        Me.cmbHireDate = New System.Windows.Forms.ComboBox
        Me.txtHireDateDescriptor = New System.Windows.Forms.Label
        Me.lblSalaryDescriptor = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.CompanyDataSet = New SalesStaffSalaries.CompanyDataSet
        Me.SalesStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesStaffTableAdapter = New SalesStaffSalaries.CompanyDataSetTableAdapters.SalesStaffTableAdapter
        Me.FillBy1ToolStrip = New System.Windows.Forms.ToolStrip
        Me.FillBy1ToolStripButton = New System.Windows.Forms.ToolStripButton
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy1ToolStrip.SuspendLayout()
        Me.SuspendLayout()
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
        'cmbNames
        '
        Me.cmbNames.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesStaffBindingSource, "Last_Name", True))
        Me.cmbNames.FormattingEnabled = True
        Me.cmbNames.Location = New System.Drawing.Point(15, 26)
        Me.cmbNames.Name = "cmbNames"
        Me.cmbNames.Size = New System.Drawing.Size(121, 21)
        Me.cmbNames.TabIndex = 10
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
        'txtId
        '
        Me.txtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesStaffBindingSource, "ID", True))
        Me.txtId.Location = New System.Drawing.Point(43, 59)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 12
        '
        'chkFullTime
        '
        Me.chkFullTime.AutoSize = True
        Me.chkFullTime.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SalesStaffBindingSource, "Full_Time", True))
        Me.chkFullTime.Location = New System.Drawing.Point(18, 97)
        Me.chkFullTime.Name = "chkFullTime"
        Me.chkFullTime.Size = New System.Drawing.Size(68, 17)
        Me.chkFullTime.TabIndex = 13
        Me.chkFullTime.Text = "Full Time"
        Me.chkFullTime.UseVisualStyleBackColor = True
        '
        'cmbHireDate
        '
        Me.cmbHireDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesStaffBindingSource, "Hire_Date", True))
        Me.cmbHireDate.FormattingEnabled = True
        Me.cmbHireDate.Location = New System.Drawing.Point(73, 128)
        Me.cmbHireDate.Name = "cmbHireDate"
        Me.cmbHireDate.Size = New System.Drawing.Size(121, 21)
        Me.cmbHireDate.TabIndex = 14
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
        'lblSalaryDescriptor
        '
        Me.lblSalaryDescriptor.AutoSize = True
        Me.lblSalaryDescriptor.Location = New System.Drawing.Point(15, 163)
        Me.lblSalaryDescriptor.Name = "lblSalaryDescriptor"
        Me.lblSalaryDescriptor.Size = New System.Drawing.Size(39, 13)
        Me.lblSalaryDescriptor.TabIndex = 16
        Me.lblSalaryDescriptor.Text = "Salary:"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesStaffBindingSource, "Salary", True))
        Me.TextBox1.Location = New System.Drawing.Point(60, 156)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 17
        '
        'CompanyDataSet
        '
        Me.CompanyDataSet.DataSetName = "CompanyDataSet"
        Me.CompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesStaffBindingSource
        '
        Me.SalesStaffBindingSource.DataMember = "SalesStaff"
        Me.SalesStaffBindingSource.DataSource = Me.CompanyDataSet
        '
        'SalesStaffTableAdapter
        '
        Me.SalesStaffTableAdapter.ClearBeforeFill = True
        '
        'FillBy1ToolStrip
        '
        Me.FillBy1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillBy1ToolStripButton})
        Me.FillBy1ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBy1ToolStrip.Name = "FillBy1ToolStrip"
        Me.FillBy1ToolStrip.Size = New System.Drawing.Size(234, 25)
        Me.FillBy1ToolStrip.TabIndex = 18
        Me.FillBy1ToolStrip.Text = "FillBy1ToolStrip"
        '
        'FillBy1ToolStripButton
        '
        Me.FillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy1ToolStripButton.Name = "FillBy1ToolStripButton"
        Me.FillBy1ToolStripButton.Size = New System.Drawing.Size(45, 22)
        Me.FillBy1ToolStripButton.Text = "FillBy1"
        '
        'frmSelectingSalesStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 196)
        Me.Controls.Add(Me.FillBy1ToolStrip)
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
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy1ToolStrip.ResumeLayout(False)
        Me.FillBy1ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSelectaNameDescriptor As System.Windows.Forms.Label
    Friend WithEvents cmbNames As System.Windows.Forms.ComboBox
    Friend WithEvents lblIdDescriptor As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents chkFullTime As System.Windows.Forms.CheckBox
    Friend WithEvents cmbHireDate As System.Windows.Forms.ComboBox
    Friend WithEvents txtHireDateDescriptor As System.Windows.Forms.Label
    Friend WithEvents lblSalaryDescriptor As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CompanyDataSet As SalesStaffSalaries.CompanyDataSet
    Friend WithEvents SalesStaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesStaffTableAdapter As SalesStaffSalaries.CompanyDataSetTableAdapters.SalesStaffTableAdapter
    Friend WithEvents FillBy1ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillBy1ToolStripButton As System.Windows.Forms.ToolStripButton
End Class
