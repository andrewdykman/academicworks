Option Strict On
Public Class frmSearch

    Const GREAT_CREDIT As Decimal = CDec(0.02)
    Const GOOD_CREDIT As Decimal = CDec(0.05)
    Const POOR_CREDIT As Decimal = CDec(0.1)

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        radPoorScore.Checked = True
        txtDownPayment.ResetText()
        txtDownPayment.Focus()
        DataGridView1.ClearSelection()
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        If txtDownPayment.Text = "" Then
            MessageBox.Show("You must enter a down payment amount", "Entry Required", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop)
            txtDownPayment.Focus()
        Else
            Dim downPayment As Decimal
            Dim requiredDownPayment As Decimal
            Dim availableByPrice As Decimal
            downPayment = CDec(txtDownPayment.Text)

            If radPoorScore.Checked = True Then
                requiredDownPayment = POOR_CREDIT
            ElseIf radGoodScore.Checked = True Then
                requiredDownPayment = GOOD_CREDIT
            Else
                requiredDownPayment = GREAT_CREDIT
            End If

            availableByPrice = ((1 / requiredDownPayment) * downPayment)
            PropertiesTableAdapter.Fill(Me.RealEstateDataSet.Properties, availableByPrice)
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtDownPayment_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDownPayment.Validating
        If IsNumeric(txtDownPayment.Text) Then
            e.Cancel = False
        Else
            e.Cancel = True
            MessageBox.Show("You must enter a numeric value for the down payment", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub frmSearch_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Return to Main Menu?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
            txtDownPayment.Focus()
        End If
    End Sub
End Class