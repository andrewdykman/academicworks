<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollCalculator
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblEmployeeFirst = New System.Windows.Forms.Label
        Me.lblEmployeeLast = New System.Windows.Forms.Label
        Me.txtEmployeeFirst = New System.Windows.Forms.TextBox
        Me.txtEmployeeLast = New System.Windows.Forms.TextBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.txtHoursWorked = New System.Windows.Forms.TextBox
        Me.lblHoursWorked = New System.Windows.Forms.Label
        Me.cmbEmployeeType = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.grpEmployeeInformation = New System.Windows.Forms.GroupBox
        Me.lblOwnership = New System.Windows.Forms.Label
        Me.grpEmployeeInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Payroll Calculator"
        '
        'lblEmployeeFirst
        '
        Me.lblEmployeeFirst.AutoSize = True
        Me.lblEmployeeFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeFirst.Location = New System.Drawing.Point(20, 65)
        Me.lblEmployeeFirst.Name = "lblEmployeeFirst"
        Me.lblEmployeeFirst.Size = New System.Drawing.Size(168, 20)
        Me.lblEmployeeFirst.TabIndex = 1
        Me.lblEmployeeFirst.Text = "Employee Name, First:"
        '
        'lblEmployeeLast
        '
        Me.lblEmployeeLast.AutoSize = True
        Me.lblEmployeeLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeLast.Location = New System.Drawing.Point(20, 45)
        Me.lblEmployeeLast.Name = "lblEmployeeLast"
        Me.lblEmployeeLast.Size = New System.Drawing.Size(168, 20)
        Me.lblEmployeeLast.TabIndex = 2
        Me.lblEmployeeLast.Text = "Employee Name, Last:"
        '
        'txtEmployeeFirst
        '
        Me.txtEmployeeFirst.Location = New System.Drawing.Point(210, 67)
        Me.txtEmployeeFirst.Name = "txtEmployeeFirst"
        Me.txtEmployeeFirst.Size = New System.Drawing.Size(194, 20)
        Me.txtEmployeeFirst.TabIndex = 3
        '
        'txtEmployeeLast
        '
        Me.txtEmployeeLast.Location = New System.Drawing.Point(210, 44)
        Me.txtEmployeeLast.Name = "txtEmployeeLast"
        Me.txtEmployeeLast.Size = New System.Drawing.Size(194, 20)
        Me.txtEmployeeLast.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(324, 301)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(102, 36)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(27, 301)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(102, 36)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "C&alculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(177, 301)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(102, 36)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtHoursWorked
        '
        Me.txtHoursWorked.Location = New System.Drawing.Point(210, 151)
        Me.txtHoursWorked.Name = "txtHoursWorked"
        Me.txtHoursWorked.Size = New System.Drawing.Size(53, 20)
        Me.txtHoursWorked.TabIndex = 9
        '
        'lblHoursWorked
        '
        Me.lblHoursWorked.AutoSize = True
        Me.lblHoursWorked.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursWorked.Location = New System.Drawing.Point(77, 149)
        Me.lblHoursWorked.Name = "lblHoursWorked"
        Me.lblHoursWorked.Size = New System.Drawing.Size(115, 20)
        Me.lblHoursWorked.TabIndex = 8
        Me.lblHoursWorked.Text = "Hours Worked:"
        '
        'cmbEmployeeType
        '
        Me.cmbEmployeeType.FormattingEnabled = True
        Me.cmbEmployeeType.Items.AddRange(New Object() {"Trainee", "Employee", "Manager"})
        Me.cmbEmployeeType.Location = New System.Drawing.Point(210, 124)
        Me.cmbEmployeeType.Name = "cmbEmployeeType"
        Me.cmbEmployeeType.Size = New System.Drawing.Size(194, 21)
        Me.cmbEmployeeType.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Employee Type:"
        '
        'grpEmployeeInformation
        '
        Me.grpEmployeeInformation.Controls.Add(Me.Label2)
        Me.grpEmployeeInformation.Controls.Add(Me.cmbEmployeeType)
        Me.grpEmployeeInformation.Controls.Add(Me.txtHoursWorked)
        Me.grpEmployeeInformation.Controls.Add(Me.lblHoursWorked)
        Me.grpEmployeeInformation.Controls.Add(Me.txtEmployeeLast)
        Me.grpEmployeeInformation.Controls.Add(Me.txtEmployeeFirst)
        Me.grpEmployeeInformation.Controls.Add(Me.lblEmployeeLast)
        Me.grpEmployeeInformation.Controls.Add(Me.lblEmployeeFirst)
        Me.grpEmployeeInformation.Location = New System.Drawing.Point(12, 69)
        Me.grpEmployeeInformation.Name = "grpEmployeeInformation"
        Me.grpEmployeeInformation.Size = New System.Drawing.Size(442, 212)
        Me.grpEmployeeInformation.TabIndex = 12
        Me.grpEmployeeInformation.TabStop = False
        Me.grpEmployeeInformation.Text = "Employee Information"
        '
        'lblOwnership
        '
        Me.lblOwnership.AutoSize = True
        Me.lblOwnership.Location = New System.Drawing.Point(146, 38)
        Me.lblOwnership.Name = "lblOwnership"
        Me.lblOwnership.Size = New System.Drawing.Size(191, 13)
        Me.lblOwnership.TabIndex = 13
        Me.lblOwnership.Text = "Lab 3 - Version 1.0 by Andrew Dykman"
        '
        'frmPayrollCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 349)
        Me.Controls.Add(Me.lblOwnership)
        Me.Controls.Add(Me.grpEmployeeInformation)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPayrollCalculator"
        Me.Text = "Payroll Calculator"
        Me.grpEmployeeInformation.ResumeLayout(False)
        Me.grpEmployeeInformation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeFirst As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeLast As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeFirst As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeLast As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtHoursWorked As System.Windows.Forms.TextBox
    Friend WithEvents lblHoursWorked As System.Windows.Forms.Label
    Friend WithEvents cmbEmployeeType As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpEmployeeInformation As System.Windows.Forms.GroupBox
    Friend WithEvents lblOwnership As System.Windows.Forms.Label

End Class
