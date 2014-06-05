<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStateAbbreviations
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
        Me.lblAppDescription = New System.Windows.Forms.Label()
        Me.btnVirginia = New System.Windows.Forms.Button()
        Me.btnNorthCarolina = New System.Windows.Forms.Button()
        Me.btnGeorgia = New System.Windows.Forms.Button()
        Me.btnSouthCarolina = New System.Windows.Forms.Button()
        Me.btnAlabama = New System.Windows.Forms.Button()
        Me.btnFlorida = New System.Windows.Forms.Button()
        Me.lblStateAbbreviation = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblStateAbbrDesciption = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAppDescription
        '
        Me.lblAppDescription.AutoSize = True
        Me.lblAppDescription.Location = New System.Drawing.Point(8, 10)
        Me.lblAppDescription.Name = "lblAppDescription"
        Me.lblAppDescription.Size = New System.Drawing.Size(225, 13)
        Me.lblAppDescription.TabIndex = 0
        Me.lblAppDescription.Text = "Click a button to see that State's Abbreviation!"
        '
        'btnVirginia
        '
        Me.btnVirginia.Location = New System.Drawing.Point(7, 36)
        Me.btnVirginia.Name = "btnVirginia"
        Me.btnVirginia.Size = New System.Drawing.Size(110, 35)
        Me.btnVirginia.TabIndex = 1
        Me.btnVirginia.Text = "Virginia"
        Me.btnVirginia.UseVisualStyleBackColor = True
        '
        'btnNorthCarolina
        '
        Me.btnNorthCarolina.Location = New System.Drawing.Point(123, 36)
        Me.btnNorthCarolina.Name = "btnNorthCarolina"
        Me.btnNorthCarolina.Size = New System.Drawing.Size(109, 34)
        Me.btnNorthCarolina.TabIndex = 2
        Me.btnNorthCarolina.Text = "North Carolina"
        Me.btnNorthCarolina.UseVisualStyleBackColor = True
        '
        'btnGeorgia
        '
        Me.btnGeorgia.Location = New System.Drawing.Point(7, 77)
        Me.btnGeorgia.Name = "btnGeorgia"
        Me.btnGeorgia.Size = New System.Drawing.Size(110, 35)
        Me.btnGeorgia.TabIndex = 3
        Me.btnGeorgia.Text = "Georgia"
        Me.btnGeorgia.UseVisualStyleBackColor = True
        '
        'btnSouthCarolina
        '
        Me.btnSouthCarolina.Location = New System.Drawing.Point(123, 77)
        Me.btnSouthCarolina.Name = "btnSouthCarolina"
        Me.btnSouthCarolina.Size = New System.Drawing.Size(109, 34)
        Me.btnSouthCarolina.TabIndex = 4
        Me.btnSouthCarolina.Text = "South Carolina"
        Me.btnSouthCarolina.UseVisualStyleBackColor = True
        '
        'btnAlabama
        '
        Me.btnAlabama.Location = New System.Drawing.Point(7, 118)
        Me.btnAlabama.Name = "btnAlabama"
        Me.btnAlabama.Size = New System.Drawing.Size(110, 35)
        Me.btnAlabama.TabIndex = 5
        Me.btnAlabama.Text = "Alabama"
        Me.btnAlabama.UseVisualStyleBackColor = True
        '
        'btnFlorida
        '
        Me.btnFlorida.Location = New System.Drawing.Point(123, 118)
        Me.btnFlorida.Name = "btnFlorida"
        Me.btnFlorida.Size = New System.Drawing.Size(110, 35)
        Me.btnFlorida.TabIndex = 6
        Me.btnFlorida.Text = "Florida"
        Me.btnFlorida.UseVisualStyleBackColor = True
        '
        'lblStateAbbreviation
        '
        Me.lblStateAbbreviation.AutoSize = True
        Me.lblStateAbbreviation.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateAbbreviation.Location = New System.Drawing.Point(89, 186)
        Me.lblStateAbbreviation.Name = "lblStateAbbreviation"
        Me.lblStateAbbreviation.Size = New System.Drawing.Size(0, 45)
        Me.lblStateAbbreviation.TabIndex = 7
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(11, 233)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 23)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblStateAbbrDesciption
        '
        Me.lblStateAbbrDesciption.AutoSize = True
        Me.lblStateAbbrDesciption.Location = New System.Drawing.Point(20, 173)
        Me.lblStateAbbrDesciption.Name = "lblStateAbbrDesciption"
        Me.lblStateAbbrDesciption.Size = New System.Drawing.Size(97, 13)
        Me.lblStateAbbrDesciption.TabIndex = 9
        Me.lblStateAbbrDesciption.Text = "State Abbreviation:"
        '
        'frmStateAbbreviations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 262)
        Me.Controls.Add(Me.lblStateAbbrDesciption)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblStateAbbreviation)
        Me.Controls.Add(Me.btnFlorida)
        Me.Controls.Add(Me.btnAlabama)
        Me.Controls.Add(Me.btnSouthCarolina)
        Me.Controls.Add(Me.btnGeorgia)
        Me.Controls.Add(Me.btnNorthCarolina)
        Me.Controls.Add(Me.btnVirginia)
        Me.Controls.Add(Me.lblAppDescription)
        Me.Name = "frmStateAbbreviations"
        Me.Text = "State Abbreviations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAppDescription As System.Windows.Forms.Label
    Friend WithEvents btnVirginia As System.Windows.Forms.Button
    Friend WithEvents btnNorthCarolina As System.Windows.Forms.Button
    Friend WithEvents btnGeorgia As System.Windows.Forms.Button
    Friend WithEvents btnSouthCarolina As System.Windows.Forms.Button
    Friend WithEvents btnAlabama As System.Windows.Forms.Button
    Friend WithEvents btnFlorida As System.Windows.Forms.Button
    Friend WithEvents lblStateAbbreviation As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblStateAbbrDesciption As System.Windows.Forms.Label

End Class
