<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesStaffSalaries
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
        Me.lblEmploymentStatusDescriptor = New System.Windows.Forms.Label
        Me.rdbFullTime = New System.Windows.Forms.RadioButton
        Me.rdbPartTime = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtAverageSalary = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FullTimeDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.HireDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SalesStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyDataSet = New SalesStaffSalaries.CompanyDataSet
        Me.SalesStaffTableAdapter = New SalesStaffSalaries.CompanyDataSetTableAdapters.SalesStaffTableAdapter
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEmploymentStatusDescriptor
        '
        Me.lblEmploymentStatusDescriptor.AutoSize = True
        Me.lblEmploymentStatusDescriptor.Location = New System.Drawing.Point(12, 18)
        Me.lblEmploymentStatusDescriptor.Name = "lblEmploymentStatusDescriptor"
        Me.lblEmploymentStatusDescriptor.Size = New System.Drawing.Size(100, 13)
        Me.lblEmploymentStatusDescriptor.TabIndex = 0
        Me.lblEmploymentStatusDescriptor.Text = "Employment Status:"
        '
        'rdbFullTime
        '
        Me.rdbFullTime.AutoSize = True
        Me.rdbFullTime.Location = New System.Drawing.Point(141, 14)
        Me.rdbFullTime.Name = "rdbFullTime"
        Me.rdbFullTime.Size = New System.Drawing.Size(67, 17)
        Me.rdbFullTime.TabIndex = 1
        Me.rdbFullTime.TabStop = True
        Me.rdbFullTime.Text = "Full Time"
        Me.rdbFullTime.UseVisualStyleBackColor = True
        '
        'rdbPartTime
        '
        Me.rdbPartTime.AutoSize = True
        Me.rdbPartTime.Location = New System.Drawing.Point(234, 14)
        Me.rdbPartTime.Name = "rdbPartTime"
        Me.rdbPartTime.Size = New System.Drawing.Size(70, 17)
        Me.rdbPartTime.TabIndex = 2
        Me.rdbPartTime.TabStop = True
        Me.rdbPartTime.Text = "Part Time"
        Me.rdbPartTime.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Average Salary:"
        '
        'txtAverageSalary
        '
        Me.txtAverageSalary.Enabled = False
        Me.txtAverageSalary.Location = New System.Drawing.Point(114, 46)
        Me.txtAverageSalary.Name = "txtAverageSalary"
        Me.txtAverageSalary.Size = New System.Drawing.Size(190, 20)
        Me.txtAverageSalary.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.FullTimeDataGridViewCheckBoxColumn, Me.HireDateDataGridViewTextBoxColumn, Me.SalaryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SalesStaffBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 102)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(289, 246)
        Me.DataGridView1.TabIndex = 5
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'FullTimeDataGridViewCheckBoxColumn
        '
        Me.FullTimeDataGridViewCheckBoxColumn.DataPropertyName = "Full_Time"
        Me.FullTimeDataGridViewCheckBoxColumn.HeaderText = "Full_Time"
        Me.FullTimeDataGridViewCheckBoxColumn.Name = "FullTimeDataGridViewCheckBoxColumn"
        '
        'HireDateDataGridViewTextBoxColumn
        '
        Me.HireDateDataGridViewTextBoxColumn.DataPropertyName = "Hire_Date"
        Me.HireDateDataGridViewTextBoxColumn.HeaderText = "Hire_Date"
        Me.HireDateDataGridViewTextBoxColumn.Name = "HireDateDataGridViewTextBoxColumn"
        '
        'SalaryDataGridViewTextBoxColumn
        '
        Me.SalaryDataGridViewTextBoxColumn.DataPropertyName = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.HeaderText = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.Name = "SalaryDataGridViewTextBoxColumn"
        '
        'SalesStaffBindingSource
        '
        Me.SalesStaffBindingSource.DataMember = "SalesStaff"
        Me.SalesStaffBindingSource.DataSource = Me.CompanyDataSet
        '
        'CompanyDataSet
        '
        Me.CompanyDataSet.DataSetName = "CompanyDataSet"
        Me.CompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesStaffTableAdapter
        '
        Me.SalesStaffTableAdapter.ClearBeforeFill = True
        '
        'frmSalesStaffSalaries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 370)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtAverageSalary)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rdbPartTime)
        Me.Controls.Add(Me.rdbFullTime)
        Me.Controls.Add(Me.lblEmploymentStatusDescriptor)
        Me.Name = "frmSalesStaffSalaries"
        Me.Text = "Sales Staff Salaries"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEmploymentStatusDescriptor As System.Windows.Forms.Label
    Friend WithEvents rdbFullTime As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPartTime As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAverageSalary As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CompanyDataSet As SalesStaffSalaries.CompanyDataSet
    Friend WithEvents SalesStaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesStaffTableAdapter As SalesStaffSalaries.CompanyDataSetTableAdapters.SalesStaffTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullTimeDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents HireDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalaryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
