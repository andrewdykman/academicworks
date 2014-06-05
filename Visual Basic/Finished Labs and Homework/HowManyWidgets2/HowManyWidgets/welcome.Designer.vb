<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
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
        Me.lblSystemTimeDescriptor = New System.Windows.Forms.Label
        Me.lblSystemTime = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnOkay
        '
        Me.btnOkay.Location = New System.Drawing.Point(96, 205)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(103, 37)
        Me.btnOkay.TabIndex = 0
        Me.btnOkay.Text = "Ok"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'lblSystemTimeDescriptor
        '
        Me.lblSystemTimeDescriptor.AutoSize = True
        Me.lblSystemTimeDescriptor.Location = New System.Drawing.Point(26, 20)
        Me.lblSystemTimeDescriptor.Name = "lblSystemTimeDescriptor"
        Me.lblSystemTimeDescriptor.Size = New System.Drawing.Size(97, 13)
        Me.lblSystemTimeDescriptor.TabIndex = 1
        Me.lblSystemTimeDescriptor.Text = "The current time is:"
        '
        'lblSystemTime
        '
        Me.lblSystemTime.AutoSize = True
        Me.lblSystemTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemTime.Location = New System.Drawing.Point(55, 84)
        Me.lblSystemTime.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblSystemTime.Name = "lblSystemTime"
        Me.lblSystemTime.Size = New System.Drawing.Size(0, 20)
        Me.lblSystemTime.TabIndex = 2
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblSystemTime)
        Me.Controls.Add(Me.lblSystemTimeDescriptor)
        Me.Controls.Add(Me.btnOkay)
        Me.Name = "frmWelcome"
        Me.Text = "Welcome!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOkay As System.Windows.Forms.Button
    Friend WithEvents lblSystemTimeDescriptor As System.Windows.Forms.Label
    Friend WithEvents lblSystemTime As System.Windows.Forms.Label
End Class
