<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHowManyWidgets
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
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblWeightofPallet = New System.Windows.Forms.Label
        Me.lblTotalWeight = New System.Windows.Forms.Label
        Me.lblWeightDescription = New System.Windows.Forms.Label
        Me.lblTotalWidgets = New System.Windows.Forms.Label
        Me.txtWeightOfPallet = New System.Windows.Forms.TextBox
        Me.txtTotalWeight = New System.Windows.Forms.TextBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(230, 230)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 31)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblWeightofPallet
        '
        Me.lblWeightofPallet.AutoSize = True
        Me.lblWeightofPallet.Location = New System.Drawing.Point(7, 16)
        Me.lblWeightofPallet.Name = "lblWeightofPallet"
        Me.lblWeightofPallet.Size = New System.Drawing.Size(141, 13)
        Me.lblWeightofPallet.TabIndex = 1
        Me.lblWeightofPallet.Text = "Weight of the pallet by Itself:"
        '
        'lblTotalWeight
        '
        Me.lblTotalWeight.AutoSize = True
        Me.lblTotalWeight.Location = New System.Drawing.Point(7, 52)
        Me.lblTotalWeight.Name = "lblTotalWeight"
        Me.lblTotalWeight.Size = New System.Drawing.Size(166, 13)
        Me.lblTotalWeight.TabIndex = 2
        Me.lblTotalWeight.Text = "Weight of the pallet with Widgets:"
        '
        'lblWeightDescription
        '
        Me.lblWeightDescription.AutoSize = True
        Me.lblWeightDescription.Location = New System.Drawing.Point(12, 103)
        Me.lblWeightDescription.Name = "lblWeightDescription"
        Me.lblWeightDescription.Size = New System.Drawing.Size(189, 13)
        Me.lblWeightDescription.TabIndex = 3
        Me.lblWeightDescription.Text = "The number of widgets on the pallet is:"
        '
        'lblTotalWidgets
        '
        Me.lblTotalWidgets.AutoSize = True
        Me.lblTotalWidgets.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalWidgets.Location = New System.Drawing.Point(66, 145)
        Me.lblTotalWidgets.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblTotalWidgets.Name = "lblTotalWidgets"
        Me.lblTotalWidgets.Size = New System.Drawing.Size(0, 26)
        Me.lblTotalWidgets.TabIndex = 4
        '
        'txtWeightOfPallet
        '
        Me.txtWeightOfPallet.Location = New System.Drawing.Point(182, 9)
        Me.txtWeightOfPallet.Name = "txtWeightOfPallet"
        Me.txtWeightOfPallet.Size = New System.Drawing.Size(100, 20)
        Me.txtWeightOfPallet.TabIndex = 5
        '
        'txtTotalWeight
        '
        Me.txtTotalWeight.Location = New System.Drawing.Point(182, 45)
        Me.txtTotalWeight.Name = "txtTotalWeight"
        Me.txtTotalWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalWeight.TabIndex = 6
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(114, 230)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(98, 31)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(10, 230)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(98, 31)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmHowManyWidgets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 273)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtTotalWeight)
        Me.Controls.Add(Me.txtWeightOfPallet)
        Me.Controls.Add(Me.lblTotalWidgets)
        Me.Controls.Add(Me.lblWeightDescription)
        Me.Controls.Add(Me.lblTotalWeight)
        Me.Controls.Add(Me.lblWeightofPallet)
        Me.Controls.Add(Me.btnExit)
        Me.Enabled = False
        Me.Name = "frmHowManyWidgets"
        Me.Text = "How Many Widgets?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblWeightofPallet As System.Windows.Forms.Label
    Friend WithEvents lblTotalWeight As System.Windows.Forms.Label
    Friend WithEvents lblWeightDescription As System.Windows.Forms.Label
    Friend WithEvents lblTotalWidgets As System.Windows.Forms.Label
    Friend WithEvents txtWeightOfPallet As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalWeight As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button

End Class
