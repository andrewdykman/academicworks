<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Me.grpCreditScore = New System.Windows.Forms.GroupBox()
        Me.radPoorScore = New System.Windows.Forms.RadioButton()
        Me.radGoodScore = New System.Windows.Forms.RadioButton()
        Me.radGreatScore = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListingAgentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SellerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SqFootageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvailabilityDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcreageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AskingPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommercialDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SoldDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PropertiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RealEstateDataSet = New cs120Final_Project.RealEstateDataSet()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDownPayment = New System.Windows.Forms.TextBox()
        Me.PropertiesTableAdapter = New cs120Final_Project.RealEstateDataSetTableAdapters.PropertiesTableAdapter()
        Me.grpCreditScore.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RealEstateDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCreditScore
        '
        Me.grpCreditScore.Controls.Add(Me.radPoorScore)
        Me.grpCreditScore.Controls.Add(Me.radGoodScore)
        Me.grpCreditScore.Controls.Add(Me.radGreatScore)
        Me.grpCreditScore.Location = New System.Drawing.Point(176, 12)
        Me.grpCreditScore.Name = "grpCreditScore"
        Me.grpCreditScore.Size = New System.Drawing.Size(232, 65)
        Me.grpCreditScore.TabIndex = 1
        Me.grpCreditScore.TabStop = False
        Me.grpCreditScore.Text = "Credit Score"
        '
        'radPoorScore
        '
        Me.radPoorScore.AutoSize = True
        Me.radPoorScore.Checked = True
        Me.radPoorScore.Location = New System.Drawing.Point(136, 20)
        Me.radPoorScore.Name = "radPoorScore"
        Me.radPoorScore.Size = New System.Drawing.Size(47, 17)
        Me.radPoorScore.TabIndex = 2
        Me.radPoorScore.TabStop = True
        Me.radPoorScore.Text = "Poor"
        Me.radPoorScore.UseVisualStyleBackColor = True
        '
        'radGoodScore
        '
        Me.radGoodScore.AutoSize = True
        Me.radGoodScore.Location = New System.Drawing.Point(74, 40)
        Me.radGoodScore.Name = "radGoodScore"
        Me.radGoodScore.Size = New System.Drawing.Size(51, 17)
        Me.radGoodScore.TabIndex = 1
        Me.radGoodScore.Text = "Good"
        Me.radGoodScore.UseVisualStyleBackColor = True
        '
        'radGreatScore
        '
        Me.radGreatScore.AutoSize = True
        Me.radGreatScore.Location = New System.Drawing.Point(17, 20)
        Me.radGreatScore.Name = "radGreatScore"
        Me.radGreatScore.Size = New System.Drawing.Size(51, 17)
        Me.radGreatScore.TabIndex = 0
        Me.radGreatScore.TabStop = True
        Me.radGreatScore.Text = "Great"
        Me.radGreatScore.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.ZipCodeDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.ListingAgentDataGridViewTextBoxColumn, Me.SellerDataGridViewTextBoxColumn, Me.SqFootageDataGridViewTextBoxColumn, Me.AvailabilityDateDataGridViewTextBoxColumn, Me.AcreageDataGridViewTextBoxColumn, Me.AskingPriceDataGridViewTextBoxColumn, Me.CommercialDataGridViewCheckBoxColumn, Me.SoldDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.PropertiesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 83)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(396, 205)
        Me.DataGridView1.TabIndex = 6
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        Me.StateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ZipCodeDataGridViewTextBoxColumn
        '
        Me.ZipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode"
        Me.ZipCodeDataGridViewTextBoxColumn.HeaderText = "ZipCode"
        Me.ZipCodeDataGridViewTextBoxColumn.Name = "ZipCodeDataGridViewTextBoxColumn"
        Me.ZipCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ListingAgentDataGridViewTextBoxColumn
        '
        Me.ListingAgentDataGridViewTextBoxColumn.DataPropertyName = "ListingAgent"
        Me.ListingAgentDataGridViewTextBoxColumn.HeaderText = "ListingAgent"
        Me.ListingAgentDataGridViewTextBoxColumn.Name = "ListingAgentDataGridViewTextBoxColumn"
        Me.ListingAgentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SellerDataGridViewTextBoxColumn
        '
        Me.SellerDataGridViewTextBoxColumn.DataPropertyName = "Seller"
        Me.SellerDataGridViewTextBoxColumn.HeaderText = "Seller"
        Me.SellerDataGridViewTextBoxColumn.Name = "SellerDataGridViewTextBoxColumn"
        Me.SellerDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SqFootageDataGridViewTextBoxColumn
        '
        Me.SqFootageDataGridViewTextBoxColumn.DataPropertyName = "SqFootage"
        Me.SqFootageDataGridViewTextBoxColumn.HeaderText = "SqFootage"
        Me.SqFootageDataGridViewTextBoxColumn.Name = "SqFootageDataGridViewTextBoxColumn"
        Me.SqFootageDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AvailabilityDateDataGridViewTextBoxColumn
        '
        Me.AvailabilityDateDataGridViewTextBoxColumn.DataPropertyName = "AvailabilityDate"
        Me.AvailabilityDateDataGridViewTextBoxColumn.HeaderText = "AvailabilityDate"
        Me.AvailabilityDateDataGridViewTextBoxColumn.Name = "AvailabilityDateDataGridViewTextBoxColumn"
        Me.AvailabilityDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AcreageDataGridViewTextBoxColumn
        '
        Me.AcreageDataGridViewTextBoxColumn.DataPropertyName = "Acreage"
        Me.AcreageDataGridViewTextBoxColumn.HeaderText = "Acreage"
        Me.AcreageDataGridViewTextBoxColumn.Name = "AcreageDataGridViewTextBoxColumn"
        Me.AcreageDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AskingPriceDataGridViewTextBoxColumn
        '
        Me.AskingPriceDataGridViewTextBoxColumn.DataPropertyName = "AskingPrice"
        Me.AskingPriceDataGridViewTextBoxColumn.HeaderText = "AskingPrice"
        Me.AskingPriceDataGridViewTextBoxColumn.Name = "AskingPriceDataGridViewTextBoxColumn"
        Me.AskingPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CommercialDataGridViewCheckBoxColumn
        '
        Me.CommercialDataGridViewCheckBoxColumn.DataPropertyName = "Commercial"
        Me.CommercialDataGridViewCheckBoxColumn.HeaderText = "Commercial"
        Me.CommercialDataGridViewCheckBoxColumn.Name = "CommercialDataGridViewCheckBoxColumn"
        Me.CommercialDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'SoldDataGridViewCheckBoxColumn
        '
        Me.SoldDataGridViewCheckBoxColumn.DataPropertyName = "Sold"
        Me.SoldDataGridViewCheckBoxColumn.HeaderText = "Sold"
        Me.SoldDataGridViewCheckBoxColumn.Name = "SoldDataGridViewCheckBoxColumn"
        Me.SoldDataGridViewCheckBoxColumn.ReadOnly = True
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
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(49, 306)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(169, 306)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.CausesValidation = False
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(312, 306)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Down Payment Available:"
        '
        'txtDownPayment
        '
        Me.txtDownPayment.Location = New System.Drawing.Point(37, 57)
        Me.txtDownPayment.Name = "txtDownPayment"
        Me.txtDownPayment.Size = New System.Drawing.Size(100, 20)
        Me.txtDownPayment.TabIndex = 0
        '
        'PropertiesTableAdapter
        '
        Me.PropertiesTableAdapter.ClearBeforeFill = True
        '
        'frmSearch
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(420, 340)
        Me.Controls.Add(Me.txtDownPayment)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.grpCreditScore)
        Me.Name = "frmSearch"
        Me.Text = "Search Estates"
        Me.grpCreditScore.ResumeLayout(False)
        Me.grpCreditScore.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RealEstateDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpCreditScore As System.Windows.Forms.GroupBox
    Friend WithEvents radPoorScore As System.Windows.Forms.RadioButton
    Friend WithEvents radGoodScore As System.Windows.Forms.RadioButton
    Friend WithEvents radGreatScore As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDownPayment As System.Windows.Forms.TextBox
    Friend WithEvents RealEstateDataSet As cs120Final_Project.RealEstateDataSet
    Friend WithEvents PropertiesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PropertiesTableAdapter As cs120Final_Project.RealEstateDataSetTableAdapters.PropertiesTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZipCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ListingAgentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SellerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SqFootageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvailabilityDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AcreageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AskingPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommercialDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SoldDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DateSoldDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalePriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
