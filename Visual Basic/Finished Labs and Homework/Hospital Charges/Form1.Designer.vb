<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHospitalCharges
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
        Me.grpHospitalStay = New System.Windows.Forms.GroupBox
        Me.txtPhysicalRehab = New System.Windows.Forms.TextBox
        Me.lblPhysicalRehab = New System.Windows.Forms.Label
        Me.txtLabFees = New System.Windows.Forms.TextBox
        Me.lblLabFees = New System.Windows.Forms.Label
        Me.txtSurgicalCharges = New System.Windows.Forms.TextBox
        Me.lblSurgicalCharges = New System.Windows.Forms.Label
        Me.txtMedicationCharges = New System.Windows.Forms.TextBox
        Me.lblMedicationCharges = New System.Windows.Forms.Label
        Me.txtLengthOfStay = New System.Windows.Forms.TextBox
        Me.lblLengthOfStay = New System.Windows.Forms.Label
        Me.grpTotalCost = New System.Windows.Forms.GroupBox
        Me.txtTotalProviderCost = New System.Windows.Forms.TextBox
        Me.lblTotalProviderCost = New System.Windows.Forms.Label
        Me.chkInsured = New System.Windows.Forms.CheckBox
        Me.txtTotalCost = New System.Windows.Forms.TextBox
        Me.lblTotalCost = New System.Windows.Forms.Label
        Me.btnCalculateCharges = New System.Windows.Forms.Button
        Me.btnClearForm = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.grpHospitalStay.SuspendLayout()
        Me.grpTotalCost.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpHospitalStay
        '
        Me.grpHospitalStay.Controls.Add(Me.txtPhysicalRehab)
        Me.grpHospitalStay.Controls.Add(Me.lblPhysicalRehab)
        Me.grpHospitalStay.Controls.Add(Me.txtLabFees)
        Me.grpHospitalStay.Controls.Add(Me.lblLabFees)
        Me.grpHospitalStay.Controls.Add(Me.txtSurgicalCharges)
        Me.grpHospitalStay.Controls.Add(Me.lblSurgicalCharges)
        Me.grpHospitalStay.Controls.Add(Me.txtMedicationCharges)
        Me.grpHospitalStay.Controls.Add(Me.lblMedicationCharges)
        Me.grpHospitalStay.Controls.Add(Me.txtLengthOfStay)
        Me.grpHospitalStay.Controls.Add(Me.lblLengthOfStay)
        Me.grpHospitalStay.Location = New System.Drawing.Point(9, 13)
        Me.grpHospitalStay.Name = "grpHospitalStay"
        Me.grpHospitalStay.Size = New System.Drawing.Size(320, 171)
        Me.grpHospitalStay.TabIndex = 0
        Me.grpHospitalStay.TabStop = False
        Me.grpHospitalStay.Text = "Hospital Stay Information:"
        '
        'txtPhysicalRehab
        '
        Me.txtPhysicalRehab.Location = New System.Drawing.Point(130, 131)
        Me.txtPhysicalRehab.Name = "txtPhysicalRehab"
        Me.txtPhysicalRehab.Size = New System.Drawing.Size(165, 20)
        Me.txtPhysicalRehab.TabIndex = 9
        '
        'lblPhysicalRehab
        '
        Me.lblPhysicalRehab.AutoSize = True
        Me.lblPhysicalRehab.Location = New System.Drawing.Point(15, 138)
        Me.lblPhysicalRehab.Name = "lblPhysicalRehab"
        Me.lblPhysicalRehab.Size = New System.Drawing.Size(109, 13)
        Me.lblPhysicalRehab.TabIndex = 8
        Me.lblPhysicalRehab.Text = "Length of &Stay (Days)"
        '
        'txtLabFees
        '
        Me.txtLabFees.Location = New System.Drawing.Point(130, 104)
        Me.txtLabFees.Name = "txtLabFees"
        Me.txtLabFees.Size = New System.Drawing.Size(165, 20)
        Me.txtLabFees.TabIndex = 7
        '
        'lblLabFees
        '
        Me.lblLabFees.AutoSize = True
        Me.lblLabFees.Location = New System.Drawing.Point(73, 111)
        Me.lblLabFees.Name = "lblLabFees"
        Me.lblLabFees.Size = New System.Drawing.Size(51, 13)
        Me.lblLabFees.TabIndex = 6
        Me.lblLabFees.Text = "Lab &Fees"
        '
        'txtSurgicalCharges
        '
        Me.txtSurgicalCharges.Location = New System.Drawing.Point(130, 77)
        Me.txtSurgicalCharges.Name = "txtSurgicalCharges"
        Me.txtSurgicalCharges.Size = New System.Drawing.Size(165, 20)
        Me.txtSurgicalCharges.TabIndex = 5
        '
        'lblSurgicalCharges
        '
        Me.lblSurgicalCharges.AutoSize = True
        Me.lblSurgicalCharges.Location = New System.Drawing.Point(37, 84)
        Me.lblSurgicalCharges.Name = "lblSurgicalCharges"
        Me.lblSurgicalCharges.Size = New System.Drawing.Size(87, 13)
        Me.lblSurgicalCharges.TabIndex = 4
        Me.lblSurgicalCharges.Text = "S&urgical Charges"
        '
        'txtMedicationCharges
        '
        Me.txtMedicationCharges.Location = New System.Drawing.Point(130, 50)
        Me.txtMedicationCharges.Name = "txtMedicationCharges"
        Me.txtMedicationCharges.Size = New System.Drawing.Size(165, 20)
        Me.txtMedicationCharges.TabIndex = 3
        '
        'lblMedicationCharges
        '
        Me.lblMedicationCharges.AutoSize = True
        Me.lblMedicationCharges.Location = New System.Drawing.Point(23, 57)
        Me.lblMedicationCharges.Name = "lblMedicationCharges"
        Me.lblMedicationCharges.Size = New System.Drawing.Size(101, 13)
        Me.lblMedicationCharges.TabIndex = 2
        Me.lblMedicationCharges.Text = "&Medication Charges"
        '
        'txtLengthOfStay
        '
        Me.txtLengthOfStay.Location = New System.Drawing.Point(130, 23)
        Me.txtLengthOfStay.Name = "txtLengthOfStay"
        Me.txtLengthOfStay.Size = New System.Drawing.Size(165, 20)
        Me.txtLengthOfStay.TabIndex = 1
        '
        'lblLengthOfStay
        '
        Me.lblLengthOfStay.AutoSize = True
        Me.lblLengthOfStay.Location = New System.Drawing.Point(15, 30)
        Me.lblLengthOfStay.Name = "lblLengthOfStay"
        Me.lblLengthOfStay.Size = New System.Drawing.Size(109, 13)
        Me.lblLengthOfStay.TabIndex = 0
        Me.lblLengthOfStay.Text = "Length of &Stay (Days)"
        '
        'grpTotalCost
        '
        Me.grpTotalCost.Controls.Add(Me.txtTotalProviderCost)
        Me.grpTotalCost.Controls.Add(Me.lblTotalProviderCost)
        Me.grpTotalCost.Controls.Add(Me.chkInsured)
        Me.grpTotalCost.Controls.Add(Me.txtTotalCost)
        Me.grpTotalCost.Controls.Add(Me.lblTotalCost)
        Me.grpTotalCost.Location = New System.Drawing.Point(9, 208)
        Me.grpTotalCost.Name = "grpTotalCost"
        Me.grpTotalCost.Size = New System.Drawing.Size(317, 109)
        Me.grpTotalCost.TabIndex = 1
        Me.grpTotalCost.TabStop = False
        '
        'txtTotalProviderCost
        '
        Me.txtTotalProviderCost.Location = New System.Drawing.Point(146, 68)
        Me.txtTotalProviderCost.Name = "txtTotalProviderCost"
        Me.txtTotalProviderCost.Size = New System.Drawing.Size(165, 20)
        Me.txtTotalProviderCost.TabIndex = 14
        '
        'lblTotalProviderCost
        '
        Me.lblTotalProviderCost.AutoSize = True
        Me.lblTotalProviderCost.Location = New System.Drawing.Point(12, 71)
        Me.lblTotalProviderCost.Name = "lblTotalProviderCost"
        Me.lblTotalProviderCost.Size = New System.Drawing.Size(112, 13)
        Me.lblTotalProviderCost.TabIndex = 13
        Me.lblTotalProviderCost.Text = "Total Cost to Provider:"
        '
        'chkInsured
        '
        Me.chkInsured.AutoSize = True
        Me.chkInsured.Location = New System.Drawing.Point(15, 19)
        Me.chkInsured.Name = "chkInsured"
        Me.chkInsured.Size = New System.Drawing.Size(67, 17)
        Me.chkInsured.TabIndex = 12
        Me.chkInsured.Text = "Insured?"
        Me.chkInsured.UseVisualStyleBackColor = True
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Location = New System.Drawing.Point(146, 42)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(165, 20)
        Me.txtTotalCost.TabIndex = 10
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(12, 45)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(106, 13)
        Me.lblTotalCost.TabIndex = 10
        Me.lblTotalCost.Text = "Total Cost to Patient:"
        '
        'btnCalculateCharges
        '
        Me.btnCalculateCharges.Location = New System.Drawing.Point(12, 349)
        Me.btnCalculateCharges.Name = "btnCalculateCharges"
        Me.btnCalculateCharges.Size = New System.Drawing.Size(90, 44)
        Me.btnCalculateCharges.TabIndex = 2
        Me.btnCalculateCharges.Text = "&Calculate Charges"
        Me.btnCalculateCharges.UseVisualStyleBackColor = True
        '
        'btnClearForm
        '
        Me.btnClearForm.Location = New System.Drawing.Point(120, 349)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(86, 44)
        Me.btnClearForm.TabIndex = 3
        Me.btnClearForm.Text = "C&lear Form"
        Me.btnClearForm.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(230, 349)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 44)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmHospitalCharges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 404)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.btnCalculateCharges)
        Me.Controls.Add(Me.grpTotalCost)
        Me.Controls.Add(Me.grpHospitalStay)
        Me.Name = "frmHospitalCharges"
        Me.Text = "Hospital Charges"
        Me.grpHospitalStay.ResumeLayout(False)
        Me.grpHospitalStay.PerformLayout()
        Me.grpTotalCost.ResumeLayout(False)
        Me.grpTotalCost.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpHospitalStay As System.Windows.Forms.GroupBox
    Friend WithEvents txtPhysicalRehab As System.Windows.Forms.TextBox
    Friend WithEvents lblPhysicalRehab As System.Windows.Forms.Label
    Friend WithEvents txtLabFees As System.Windows.Forms.TextBox
    Friend WithEvents lblLabFees As System.Windows.Forms.Label
    Friend WithEvents txtSurgicalCharges As System.Windows.Forms.TextBox
    Friend WithEvents lblSurgicalCharges As System.Windows.Forms.Label
    Friend WithEvents txtMedicationCharges As System.Windows.Forms.TextBox
    Friend WithEvents lblMedicationCharges As System.Windows.Forms.Label
    Friend WithEvents txtLengthOfStay As System.Windows.Forms.TextBox
    Friend WithEvents lblLengthOfStay As System.Windows.Forms.Label
    Friend WithEvents grpTotalCost As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents btnCalculateCharges As System.Windows.Forms.Button
    Friend WithEvents btnClearForm As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents chkInsured As System.Windows.Forms.CheckBox
    Friend WithEvents txtTotalProviderCost As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalProviderCost As System.Windows.Forms.Label

End Class
