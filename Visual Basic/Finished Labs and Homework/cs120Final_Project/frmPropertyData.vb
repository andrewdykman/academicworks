Option Strict On
Public Class frmPropertyData
    Dim fileName As String = ""
    Private Sub btnSaveInfo_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveInfo.Click
        If String.IsNullOrEmpty(txtAcreage.Text) Or String.IsNullOrEmpty(txtAddress.Text) Or String.IsNullOrEmpty(txtAgentName.Text) Or String.IsNullOrEmpty(txtCity.Text) Or String.IsNullOrEmpty(txtPropDescription.Text) Or String.IsNullOrEmpty(txtPropPrice.Text) Or String.IsNullOrEmpty(txtSellerName.Text) Or String.IsNullOrEmpty(txtSquareFeet.Text) Or String.IsNullOrEmpty(txtZipCode.Text) Or cboState.SelectedIndex <= -1 Then
            MessageBox.Show("Information required", "Data Needed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation)
            txtSellerName.Focus()
        Else
            Dim propertyInformation As PropertyData

            With propertyInformation
                .address = txtAddress.Text
                .city = txtCity.Text
                .state = CStr(cboState.SelectedItem)
                .zipcode = txtZipCode.Text
                .sellerName = txtSellerName.Text
                .agentName = txtAgentName.Text
                .description = txtPropDescription.Text
                .squareFeet = txtSquareFeet.Text
                .acres = txtAcreage.Text
                .dateReady = CStr(dtpAvailableDate.Value)
                .propPrice = txtPropPrice.Text
                .propSold = CStr(chkSold.Checked)
                .residential = radResidential.Checked
            End With

            If fileName = "" Then
                With sfdPropertyInfo
                    .Filter = "Text Files (*.txt)|*.txt"
                    .InitialDirectory = "C:\Data"
                    .Title = "Save As"
                    .ShowDialog()
                End With
                fileName = sfdPropertyInfo.FileName
                If fileName = "" Then
                    fileName = CStr(InputBox("Please name your file"))
                End If
            End If
            SaveFile(fileName, propertyInformation)
            PropertiesTableAdapter.addProperty(Address:=propertyInformation.address, AskingPrice:=CType(propertyInformation.propPrice, Decimal?), AvailabilityDate:=CType(propertyInformation.dateReady, Date?), Commercial:=propertyInformation.residential, Acreage:=CType(propertyInformation.acres, Decimal?), City:=propertyInformation.city, Description:=propertyInformation.description, ListingAgent:=propertyInformation.agentName, Seller:=propertyInformation.sellerName, Sold:=CBool(propertyInformation.propSold), SqFootage:=CType(propertyInformation.squareFeet, Integer?), State:=propertyInformation.state, ZipCode:=propertyInformation.zipcode)
        End If
    End Sub

    Private Sub btnClearInfo_Click(sender As System.Object, e As System.EventArgs) Handles btnClearInfo.Click
        ResetData()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ResetData()
        txtAcreage.ResetText()
        txtAddress.ResetText()
        txtAgentName.ResetText()
        txtCity.ResetText()
        txtPropDescription.ResetText()
        txtPropPrice.ResetText()
        txtSellerName.ResetText()
        txtSquareFeet.ResetText()
        txtZipCode.ResetText()
        radResidential.Checked = True
        chkSold.Checked = False
        cboState.SelectedIndex = -1
        cboState.ResetText()
        dtpAvailableDate.Value = Now
    End Sub

    Private Sub txtAcreage_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAcreage.Validating
        If IsNumeric(txtAcreage.Text) Then
            e.Cancel = False
        Else
            e.Cancel = True
            MessageBox.Show("Enter how many Acres the property is on", "Entry Required", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If
    End Sub

    Private Sub txtAddress_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAddress.Validating
        If String.IsNullOrEmpty(txtAddress.Text) Then
            e.Cancel = True
            MessageBox.Show("Enter a valid Address", "Entry Required", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub txtAgentName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAgentName.Validating
        If String.IsNullOrEmpty(txtAgentName.Text) Then
            e.Cancel = True
            MessageBox.Show("Enter the Agent's Name", "Entry Required", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub txtCity_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCity.Validating
        If String.IsNullOrEmpty(txtCity.Text) Then
            e.Cancel = True
            MessageBox.Show("Enter a City", "Entry Required", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub txtPropDescription_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPropDescription.Validating
        If String.IsNullOrEmpty(txtPropDescription.Text) Then
            e.Cancel = True
            MessageBox.Show("Enter a small description of the property", "Entry Required", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub txtPropPrice_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPropPrice.Validating
        If IsNumeric(txtPropPrice.Text) Then
            e.Cancel = False
        Else
            e.Cancel = True
            MessageBox.Show("Enter the price of the property", "Entry Required", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If
    End Sub

    Private Sub txtSellerName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtSellerName.Validating
        If String.IsNullOrEmpty(txtSellerName.Text) Then
            e.Cancel = True
            MessageBox.Show("Enter the seller's name", "Entry Required", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub txtSquareFeet_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtSquareFeet.Validating
        If IsNumeric(txtSquareFeet.Text) Then
            e.Cancel = False
        Else
            e.Cancel = True
            MessageBox.Show("Enter the square footage of the property", "Entry Required", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If
    End Sub

    Private Sub txtZipCode_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtZipCode.Validating
        If IsNumeric(txtZipCode.Text) Then
            e.Cancel = False
        Else
            e.Cancel = True
            MessageBox.Show("Enter a valid zipcode", "Entry Required", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If
    End Sub

    Private Sub cboState_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboState.Validating
        If cboState.SelectedIndex <= -1 Then
            e.Cancel = True
            MessageBox.Show("Please select a state", "Entry Required", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub frmPropertyData_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Return to Main Menu?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
            txtSellerName.Focus()
        End If
    End Sub
End Class