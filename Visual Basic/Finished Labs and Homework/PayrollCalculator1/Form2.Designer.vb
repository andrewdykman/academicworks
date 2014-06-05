<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSummary
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
        Me.btnOkay = New System.Windows.Forms.Button
        Me.lblSummaryEmployeeNameDescriptor = New System.Windows.Forms.Label
        Me.lblSummaryEmployeeName = New System.Windows.Forms.Label
        Me.lblEmployeeSummaryTypeDescriptor = New System.Windows.Forms.Label
        Me.lblEmployeeSummaryType = New System.Windows.Forms.Label
        Me.lblEmployeeSummaryPayRateDescriptor = New System.Windows.Forms.Label
        Me.lblEmployeeSummaryPayRate = New System.Windows.Forms.Label
        Me.lblSummaryTotalHoursDescriptor = New System.Windows.Forms.Label
        Me.lblSummaryTotalHours = New System.Windows.Forms.Label
        Me.lblSummaryRegularHours = New System.Windows.Forms.Label
        Me.lblSummaryRegularHoursDescription = New System.Windows.Forms.Label
        Me.lblSummaryRegularWage = New System.Windows.Forms.Label
        Me.lblSummaryRegularWageDescriptor = New System.Windows.Forms.Label
        Me.lblSummaryOvertimeHours = New System.Windows.Forms.Label
        Me.lblSummaryOvertimeHoursDescriptor = New System.Windows.Forms.Label
        Me.lblSummaryOvertimeWage = New System.Windows.Forms.Label
        Me.lblSummaryOvertimeWageDescriptor = New System.Windows.Forms.Label
        Me.lblSummaryTotalWage = New System.Windows.Forms.Label
        Me.lblSummaryTotalWageDescriptor = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnOkay
        '
        Me.btnOkay.Location = New System.Drawing.Point(338, 216)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(96, 34)
        Me.btnOkay.TabIndex = 0
        Me.btnOkay.Text = "Ok."
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'lblSummaryEmployeeNameDescriptor
        '
        Me.lblSummaryEmployeeNameDescriptor.AutoSize = True
        Me.lblSummaryEmployeeNameDescriptor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummaryEmployeeNameDescriptor.Location = New System.Drawing.Point(12, 9)
        Me.lblSummaryEmployeeNameDescriptor.Name = "lblSummaryEmployeeNameDescriptor"
        Me.lblSummaryEmployeeNameDescriptor.Size = New System.Drawing.Size(143, 20)
        Me.lblSummaryEmployeeNameDescriptor.TabIndex = 1
        Me.lblSummaryEmployeeNameDescriptor.Text = "Employee Name:"
        '
        'lblSummaryEmployeeName
        '
        Me.lblSummaryEmployeeName.AutoSize = True
        Me.lblSummaryEmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummaryEmployeeName.Location = New System.Drawing.Point(161, 9)
        Me.lblSummaryEmployeeName.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblSummaryEmployeeName.Name = "lblSummaryEmployeeName"
        Me.lblSummaryEmployeeName.Size = New System.Drawing.Size(0, 20)
        Me.lblSummaryEmployeeName.TabIndex = 2
        '
        'lblEmployeeSummaryTypeDescriptor
        '
        Me.lblEmployeeSummaryTypeDescriptor.AutoSize = True
        Me.lblEmployeeSummaryTypeDescriptor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeSummaryTypeDescriptor.Location = New System.Drawing.Point(19, 41)
        Me.lblEmployeeSummaryTypeDescriptor.Name = "lblEmployeeSummaryTypeDescriptor"
        Me.lblEmployeeSummaryTypeDescriptor.Size = New System.Drawing.Size(135, 20)
        Me.lblEmployeeSummaryTypeDescriptor.TabIndex = 3
        Me.lblEmployeeSummaryTypeDescriptor.Text = "Employee Type:"
        '
        'lblEmployeeSummaryType
        '
        Me.lblEmployeeSummaryType.AutoSize = True
        Me.lblEmployeeSummaryType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeSummaryType.Location = New System.Drawing.Point(160, 41)
        Me.lblEmployeeSummaryType.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblEmployeeSummaryType.Name = "lblEmployeeSummaryType"
        Me.lblEmployeeSummaryType.Size = New System.Drawing.Size(0, 20)
        Me.lblEmployeeSummaryType.TabIndex = 4
        '
        'lblEmployeeSummaryPayRateDescriptor
        '
        Me.lblEmployeeSummaryPayRateDescriptor.AutoSize = True
        Me.lblEmployeeSummaryPayRateDescriptor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeSummaryPayRateDescriptor.Location = New System.Drawing.Point(4, 86)
        Me.lblEmployeeSummaryPayRateDescriptor.Name = "lblEmployeeSummaryPayRateDescriptor"
        Me.lblEmployeeSummaryPayRateDescriptor.Size = New System.Drawing.Size(150, 16)
        Me.lblEmployeeSummaryPayRateDescriptor.TabIndex = 5
        Me.lblEmployeeSummaryPayRateDescriptor.Text = "Employee Pay Rate:"
        '
        'lblEmployeeSummaryPayRate
        '
        Me.lblEmployeeSummaryPayRate.AutoSize = True
        Me.lblEmployeeSummaryPayRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeSummaryPayRate.Location = New System.Drawing.Point(154, 83)
        Me.lblEmployeeSummaryPayRate.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblEmployeeSummaryPayRate.Name = "lblEmployeeSummaryPayRate"
        Me.lblEmployeeSummaryPayRate.Size = New System.Drawing.Size(0, 20)
        Me.lblEmployeeSummaryPayRate.TabIndex = 6
        '
        'lblSummaryTotalHoursDescriptor
        '
        Me.lblSummaryTotalHoursDescriptor.AutoSize = True
        Me.lblSummaryTotalHoursDescriptor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummaryTotalHoursDescriptor.Location = New System.Drawing.Point(61, 102)
        Me.lblSummaryTotalHoursDescriptor.Name = "lblSummaryTotalHoursDescriptor"
        Me.lblSummaryTotalHoursDescriptor.Size = New System.Drawing.Size(93, 16)
        Me.lblSummaryTotalHoursDescriptor.TabIndex = 7
        Me.lblSummaryTotalHoursDescriptor.Text = "Total Hours:"
        '
        'lblSummaryTotalHours
        '
        Me.lblSummaryTotalHours.AutoSize = True
        Me.lblSummaryTotalHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummaryTotalHours.Location = New System.Drawing.Point(154, 99)
        Me.lblSummaryTotalHours.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblSummaryTotalHours.Name = "lblSummaryTotalHours"
        Me.lblSummaryTotalHours.Size = New System.Drawing.Size(0, 20)
        Me.lblSummaryTotalHours.TabIndex = 8
        '
        'lblSummaryRegularHours
        '
        Me.lblSummaryRegularHours.AutoSize = True
        Me.lblSummaryRegularHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummaryRegularHours.Location = New System.Drawing.Point(155, 115)
        Me.lblSummaryRegularHours.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblSummaryRegularHours.Name = "lblSummaryRegularHours"
        Me.lblSummaryRegularHours.Size = New System.Drawing.Size(0, 20)
        Me.lblSummaryRegularHours.TabIndex = 10
        '
        'lblSummaryRegularHoursDescription
        '
        Me.lblSummaryRegularHoursDescription.AutoSize = True
        Me.lblSummaryRegularHoursDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummaryRegularHoursDescription.Location = New System.Drawing.Point(42, 118)
        Me.lblSummaryRegularHoursDescription.Name = "lblSummaryRegularHoursDescription"
        Me.lblSummaryRegularHoursDescription.Size = New System.Drawing.Size(112, 16)
        Me.lblSummaryRegularHoursDescription.TabIndex = 9
        Me.lblSummaryRegularHoursDescription.Text = "Regular Hours:"
        '
        'lblSummaryRegularWage
        '
        Me.lblSummaryRegularWage.AutoSize = True
        Me.lblSummaryRegularWage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummaryRegularWage.Location = New System.Drawing.Point(156, 131)
        Me.lblSummaryRegularWage.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblSummaryRegularWage.Name = "lblSummaryRegularWage"
        Me.lblSummaryRegularWage.Size = New System.Drawing.Size(0, 20)
        Me.lblSummaryRegularWage.TabIndex = 12
        '
        'lblSummaryRegularWageDescriptor
        '
        Me.lblSummaryRegularWageDescriptor.AutoSize = True
        Me.lblSummaryRegularWageDescriptor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummaryRegularWageDescriptor.Location = New System.Drawing.Point(43, 134)
        Me.lblSummaryRegularWageDescriptor.Name = "lblSummaryRegularWageDescriptor"
        Me.lblSummaryRegularWageDescriptor.Size = New System.Drawing.Size(112, 16)
        Me.lblSummaryRegularWageDescriptor.TabIndex = 11
        Me.lblSummaryRegularWageDescriptor.Text = "Regular Wage:"
        '
        'lblSummaryOvertimeHours
        '
        Me.lblSummaryOvertimeHours.AutoSize = True
        Me.lblSummaryOvertimeHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummaryOvertimeHours.Location = New System.Drawing.Point(157, 147)
        Me.lblSummaryOvertimeHours.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblSummaryOvertimeHours.Name = "lblSummaryOvertimeHours"
        Me.lblSummaryOvertimeHours.Size = New System.Drawing.Size(0, 20)
        Me.lblSummaryOvertimeHours.TabIndex = 14
        '
        'lblSummaryOvertimeHoursDescriptor
        '
        Me.lblSummaryOvertimeHoursDescriptor.AutoSize = True
        Me.lblSummaryOvertimeHoursDescriptor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummaryOvertimeHoursDescriptor.Location = New System.Drawing.Point(37, 150)
        Me.lblSummaryOvertimeHoursDescriptor.Name = "lblSummaryOvertimeHoursDescriptor"
        Me.lblSummaryOvertimeHoursDescriptor.Size = New System.Drawing.Size(119, 16)
        Me.lblSummaryOvertimeHoursDescriptor.TabIndex = 13
        Me.lblSummaryOvertimeHoursDescriptor.Text = "Overtime Hours:"
        '
        'lblSummaryOvertimeWage
        '
        Me.lblSummaryOvertimeWage.AutoSize = True
        Me.lblSummaryOvertimeWage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummaryOvertimeWage.Location = New System.Drawing.Point(158, 164)
        Me.lblSummaryOvertimeWage.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblSummaryOvertimeWage.Name = "lblSummaryOvertimeWage"
        Me.lblSummaryOvertimeWage.Size = New System.Drawing.Size(0, 20)
        Me.lblSummaryOvertimeWage.TabIndex = 16
        '
        'lblSummaryOvertimeWageDescriptor
        '
        Me.lblSummaryOvertimeWageDescriptor.AutoSize = True
        Me.lblSummaryOvertimeWageDescriptor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummaryOvertimeWageDescriptor.Location = New System.Drawing.Point(38, 167)
        Me.lblSummaryOvertimeWageDescriptor.Name = "lblSummaryOvertimeWageDescriptor"
        Me.lblSummaryOvertimeWageDescriptor.Size = New System.Drawing.Size(119, 16)
        Me.lblSummaryOvertimeWageDescriptor.TabIndex = 15
        Me.lblSummaryOvertimeWageDescriptor.Text = "Overtime Wage:"
        '
        'lblSummaryTotalWage
        '
        Me.lblSummaryTotalWage.AutoSize = True
        Me.lblSummaryTotalWage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummaryTotalWage.Location = New System.Drawing.Point(156, 194)
        Me.lblSummaryTotalWage.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblSummaryTotalWage.Name = "lblSummaryTotalWage"
        Me.lblSummaryTotalWage.Size = New System.Drawing.Size(0, 20)
        Me.lblSummaryTotalWage.TabIndex = 18
        '
        'lblSummaryTotalWageDescriptor
        '
        Me.lblSummaryTotalWageDescriptor.AutoSize = True
        Me.lblSummaryTotalWageDescriptor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummaryTotalWageDescriptor.Location = New System.Drawing.Point(62, 197)
        Me.lblSummaryTotalWageDescriptor.Name = "lblSummaryTotalWageDescriptor"
        Me.lblSummaryTotalWageDescriptor.Size = New System.Drawing.Size(93, 16)
        Me.lblSummaryTotalWageDescriptor.TabIndex = 17
        Me.lblSummaryTotalWageDescriptor.Text = "Total Wage:"
        '
        'frmSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 262)
        Me.Controls.Add(Me.lblSummaryTotalWage)
        Me.Controls.Add(Me.lblSummaryTotalWageDescriptor)
        Me.Controls.Add(Me.lblSummaryOvertimeWage)
        Me.Controls.Add(Me.lblSummaryOvertimeWageDescriptor)
        Me.Controls.Add(Me.lblSummaryOvertimeHours)
        Me.Controls.Add(Me.lblSummaryOvertimeHoursDescriptor)
        Me.Controls.Add(Me.lblSummaryRegularWage)
        Me.Controls.Add(Me.lblSummaryRegularWageDescriptor)
        Me.Controls.Add(Me.lblSummaryRegularHours)
        Me.Controls.Add(Me.lblSummaryRegularHoursDescription)
        Me.Controls.Add(Me.lblSummaryTotalHours)
        Me.Controls.Add(Me.lblSummaryTotalHoursDescriptor)
        Me.Controls.Add(Me.lblEmployeeSummaryPayRate)
        Me.Controls.Add(Me.lblEmployeeSummaryPayRateDescriptor)
        Me.Controls.Add(Me.lblEmployeeSummaryType)
        Me.Controls.Add(Me.lblEmployeeSummaryTypeDescriptor)
        Me.Controls.Add(Me.lblSummaryEmployeeName)
        Me.Controls.Add(Me.lblSummaryEmployeeNameDescriptor)
        Me.Controls.Add(Me.btnOkay)
        Me.Name = "frmSummary"
        Me.Text = "Summary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOkay As System.Windows.Forms.Button
    Friend WithEvents lblSummaryEmployeeNameDescriptor As System.Windows.Forms.Label
    Friend WithEvents lblSummaryEmployeeName As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeSummaryTypeDescriptor As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeSummaryType As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeSummaryPayRateDescriptor As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeSummaryPayRate As System.Windows.Forms.Label
    Friend WithEvents lblSummaryTotalHoursDescriptor As System.Windows.Forms.Label
    Friend WithEvents lblSummaryTotalHours As System.Windows.Forms.Label
    Friend WithEvents lblSummaryRegularHours As System.Windows.Forms.Label
    Friend WithEvents lblSummaryRegularHoursDescription As System.Windows.Forms.Label
    Friend WithEvents lblSummaryRegularWage As System.Windows.Forms.Label
    Friend WithEvents lblSummaryRegularWageDescriptor As System.Windows.Forms.Label
    Friend WithEvents lblSummaryOvertimeHours As System.Windows.Forms.Label
    Friend WithEvents lblSummaryOvertimeHoursDescriptor As System.Windows.Forms.Label
    Friend WithEvents lblSummaryOvertimeWage As System.Windows.Forms.Label
    Friend WithEvents lblSummaryOvertimeWageDescriptor As System.Windows.Forms.Label
    Friend WithEvents lblSummaryTotalWage As System.Windows.Forms.Label
    Friend WithEvents lblSummaryTotalWageDescriptor As System.Windows.Forms.Label
End Class
