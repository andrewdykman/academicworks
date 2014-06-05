<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPropertyData
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
        Me.grpPropertyInfo = New System.Windows.Forms.GroupBox()
        Me.dtpAvailableDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radCommercial = New System.Windows.Forms.RadioButton()
        Me.txtSquareFeet = New System.Windows.Forms.TextBox()
        Me.radResidential = New System.Windows.Forms.RadioButton()
        Me.chkSold = New System.Windows.Forms.CheckBox()
        Me.txtPropPrice = New System.Windows.Forms.TextBox()
        Me.txtAcreage = New System.Windows.Forms.TextBox()
        Me.txtAgentName = New System.Windows.Forms.TextBox()
        Me.txtSellerName = New System.Windows.Forms.TextBox()
        Me.grpAddressInfo = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.grpPropertyDescription = New System.Windows.Forms.GroupBox()
        Me.txtPropDescription = New System.Windows.Forms.TextBox()
        Me.btnSaveInfo = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.sfdPropertyInfo = New System.Windows.Forms.SaveFileDialog()
        Me.btnClearInfo = New System.Windows.Forms.Button()
        Me.PropertiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RealEstateDataSet = New cs120Final_Project.RealEstateDataSet()
        Me.PropertiesTableAdapter = New cs120Final_Project.RealEstateDataSetTableAdapters.PropertiesTableAdapter()
        Me.grpPropertyInfo.SuspendLayout()
        Me.grpAddressInfo.SuspendLayout()
        Me.grpPropertyDescription.SuspendLayout()
        CType(Me.PropertiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RealEstateDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpPropertyInfo
        '
        Me.grpPropertyInfo.Controls.Add(Me.dtpAvailableDate)
        Me.grpPropertyInfo.Controls.Add(Me.Label6)
        Me.grpPropertyInfo.Controls.Add(Me.Label5)
        Me.grpPropertyInfo.Controls.Add(Me.Label4)
        Me.grpPropertyInfo.Controls.Add(Me.Label3)
        Me.grpPropertyInfo.Controls.Add(Me.Label2)
        Me.grpPropertyInfo.Controls.Add(Me.Label1)
        Me.grpPropertyInfo.Controls.Add(Me.radCommercial)
        Me.grpPropertyInfo.Controls.Add(Me.txtSquareFeet)
        Me.grpPropertyInfo.Controls.Add(Me.radResidential)
        Me.grpPropertyInfo.Controls.Add(Me.chkSold)
        Me.grpPropertyInfo.Controls.Add(Me.txtPropPrice)
        Me.grpPropertyInfo.Controls.Add(Me.txtAcreage)
        Me.grpPropertyInfo.Controls.Add(Me.txtAgentName)
        Me.grpPropertyInfo.Controls.Add(Me.txtSellerName)
        Me.grpPropertyInfo.Location = New System.Drawing.Point(12, 12)
        Me.grpPropertyInfo.Name = "grpPropertyInfo"
        Me.grpPropertyInfo.Size = New System.Drawing.Size(200, 234)
        Me.grpPropertyInfo.TabIndex = 0
        Me.grpPropertyInfo.TabStop = False
        Me.grpPropertyInfo.Text = "Property Information"
        '
        'dtpAvailableDate
        '
        Me.dtpAvailableDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAvailableDate.Location = New System.Drawing.Point(94, 72)
        Me.dtpAvailableDate.Name = "dtpAvailableDate"
        Me.dtpAvailableDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpAvailableDate.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Acreage"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Square Feet"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Date Available"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Agent's Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Seller's Name"
        '
        'radCommercial
        '
        Me.radCommercial.AutoSize = True
        Me.radCommercial.Location = New System.Drawing.Point(94, 197)
        Me.radCommercial.Name = "radCommercial"
        Me.radCommercial.Size = New System.Drawing.Size(79, 17)
        Me.radCommercial.TabIndex = 7
        Me.radCommercial.Text = "Commercial"
        Me.radCommercial.UseVisualStyleBackColor = True
        '
        'txtSquareFeet
        '
        Me.txtSquareFeet.Location = New System.Drawing.Point(94, 98)
        Me.txtSquareFeet.Name = "txtSquareFeet"
        Me.txtSquareFeet.Size = New System.Drawing.Size(100, 20)
        Me.txtSquareFeet.TabIndex = 3
        '
        'radResidential
        '
        Me.radResidential.AutoSize = True
        Me.radResidential.Checked = True
        Me.radResidential.Location = New System.Drawing.Point(94, 177)
        Me.radResidential.Name = "radResidential"
        Me.radResidential.Size = New System.Drawing.Size(77, 17)
        Me.radResidential.TabIndex = 6
        Me.radResidential.TabStop = True
        Me.radResidential.Text = "Residential"
        Me.radResidential.UseVisualStyleBackColor = True
        '
        'chkSold
        '
        Me.chkSold.AutoSize = True
        Me.chkSold.Location = New System.Drawing.Point(31, 188)
        Me.chkSold.Name = "chkSold"
        Me.chkSold.Size = New System.Drawing.Size(47, 17)
        Me.chkSold.TabIndex = 8
        Me.chkSold.Text = "Sold"
        Me.chkSold.UseVisualStyleBackColor = True
        '
        'txtPropPrice
        '
        Me.txtPropPrice.Location = New System.Drawing.Point(94, 150)
        Me.txtPropPrice.Name = "txtPropPrice"
        Me.txtPropPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPropPrice.TabIndex = 5
        '
        'txtAcreage
        '
        Me.txtAcreage.Location = New System.Drawing.Point(94, 124)
        Me.txtAcreage.Name = "txtAcreage"
        Me.txtAcreage.Size = New System.Drawing.Size(100, 20)
        Me.txtAcreage.TabIndex = 4
        '
        'txtAgentName
        '
        Me.txtAgentName.Location = New System.Drawing.Point(94, 46)
        Me.txtAgentName.Name = "txtAgentName"
        Me.txtAgentName.Size = New System.Drawing.Size(100, 20)
        Me.txtAgentName.TabIndex = 1
        '
        'txtSellerName
        '
        Me.txtSellerName.Location = New System.Drawing.Point(94, 20)
        Me.txtSellerName.Name = "txtSellerName"
        Me.txtSellerName.Size = New System.Drawing.Size(100, 20)
        Me.txtSellerName.TabIndex = 0
        '
        'grpAddressInfo
        '
        Me.grpAddressInfo.Controls.Add(Me.Label7)
        Me.grpAddressInfo.Controls.Add(Me.Label8)
        Me.grpAddressInfo.Controls.Add(Me.Label9)
        Me.grpAddressInfo.Controls.Add(Me.Label10)
        Me.grpAddressInfo.Controls.Add(Me.cboState)
        Me.grpAddressInfo.Controls.Add(Me.txtZipCode)
        Me.grpAddressInfo.Controls.Add(Me.txtCity)
        Me.grpAddressInfo.Controls.Add(Me.txtAddress)
        Me.grpAddressInfo.Location = New System.Drawing.Point(218, 12)
        Me.grpAddressInfo.Name = "grpAddressInfo"
        Me.grpAddressInfo.Size = New System.Drawing.Size(200, 121)
        Me.grpAddressInfo.TabIndex = 1
        Me.grpAddressInfo.TabStop = False
        Me.grpAddressInfo.Text = "Address Information"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "City"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "State"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Zip Code"
        '
        'cboState
        '
        Me.cboState.FormattingEnabled = True
        Me.cboState.Items.AddRange(New Object() {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.cboState.Location = New System.Drawing.Point(94, 65)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(51, 21)
        Me.cboState.TabIndex = 2
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(94, 91)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(100, 20)
        Me.txtZipCode.TabIndex = 3
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(94, 38)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(100, 20)
        Me.txtCity.TabIndex = 1
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(94, 13)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtAddress.TabIndex = 0
        '
        'grpPropertyDescription
        '
        Me.grpPropertyDescription.Controls.Add(Me.txtPropDescription)
        Me.grpPropertyDescription.Location = New System.Drawing.Point(218, 139)
        Me.grpPropertyDescription.Name = "grpPropertyDescription"
        Me.grpPropertyDescription.Size = New System.Drawing.Size(200, 107)
        Me.grpPropertyDescription.TabIndex = 2
        Me.grpPropertyDescription.TabStop = False
        Me.grpPropertyDescription.Text = "Property Description"
        '
        'txtPropDescription
        '
        Me.txtPropDescription.Location = New System.Drawing.Point(6, 19)
        Me.txtPropDescription.Multiline = True
        Me.txtPropDescription.Name = "txtPropDescription"
        Me.txtPropDescription.Size = New System.Drawing.Size(188, 82)
        Me.txtPropDescription.TabIndex = 15
        '
        'btnSaveInfo
        '
        Me.btnSaveInfo.Location = New System.Drawing.Point(57, 252)
        Me.btnSaveInfo.Name = "btnSaveInfo"
        Me.btnSaveInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveInfo.TabIndex = 3
        Me.btnSaveInfo.Text = "Save"
        Me.btnSaveInfo.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.CausesValidation = False
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(291, 252)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClearInfo
        '
        Me.btnClearInfo.Location = New System.Drawing.Point(168, 252)
        Me.btnClearInfo.Name = "btnClearInfo"
        Me.btnClearInfo.Size = New System.Drawing.Size(82, 23)
        Me.btnClearInfo.TabIndex = 6
        Me.btnClearInfo.Text = "New Property"
        Me.btnClearInfo.UseVisualStyleBackColor = True
        '
        'PropertiesBindingSource
        '
        Me.PropertiesBindingSource.DataMember = "Properties"
        Me.PropertiesBindingSource.DataSource = Me.RealEstateDataSet
        '
        'RealEstateDataSet
        '
        Me.RealEstateDataSet.DataSetName = "RealEstateDataSet"
        Me.RealEstateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PropertiesTableAdapter
        '
        Me.PropertiesTableAdapter.ClearBeforeFill = True
        '
        'frmPropertyData
        '
        Me.AcceptButton = Me.btnSaveInfo
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(429, 287)
        Me.Controls.Add(Me.btnClearInfo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSaveInfo)
        Me.Controls.Add(Me.grpPropertyDescription)
        Me.Controls.Add(Me.grpAddressInfo)
        Me.Controls.Add(Me.grpPropertyInfo)
        Me.Name = "frmPropertyData"
        Me.Text = "Property Information"
        Me.grpPropertyInfo.ResumeLayout(False)
        Me.grpPropertyInfo.PerformLayout()
        Me.grpAddressInfo.ResumeLayout(False)
        Me.grpAddressInfo.PerformLayout()
        Me.grpPropertyDescription.ResumeLayout(False)
        Me.grpPropertyDescription.PerformLayout()
        CType(Me.PropertiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RealEstateDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpPropertyInfo As System.Windows.Forms.GroupBox
    Friend WithEvents grpAddressInfo As System.Windows.Forms.GroupBox
    Friend WithEvents grpPropertyDescription As System.Windows.Forms.GroupBox
    Friend WithEvents btnSaveInfo As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents radCommercial As System.Windows.Forms.RadioButton
    Friend WithEvents radResidential As System.Windows.Forms.RadioButton
    Friend WithEvents chkSold As System.Windows.Forms.CheckBox
    Friend WithEvents txtPropPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtAcreage As System.Windows.Forms.TextBox
    Friend WithEvents txtSquareFeet As System.Windows.Forms.TextBox
    Friend WithEvents txtAgentName As System.Windows.Forms.TextBox
    Friend WithEvents txtSellerName As System.Windows.Forms.TextBox
    Friend WithEvents txtPropDescription As System.Windows.Forms.TextBox
    Friend WithEvents cboState As System.Windows.Forms.ComboBox
    Friend WithEvents txtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents dtpAvailableDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents sfdPropertyInfo As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnClearInfo As System.Windows.Forms.Button
    Friend WithEvents PropertiesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RealEstateDataSet As cs120Final_Project.RealEstateDataSet
    Friend WithEvents PropertiesTableAdapter As cs120Final_Project.RealEstateDataSetTableAdapters.PropertiesTableAdapter
End Class
