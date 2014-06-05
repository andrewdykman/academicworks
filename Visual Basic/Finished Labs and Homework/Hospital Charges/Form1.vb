' Lab 5 by Andrew Dykman
' Visual Basic

Option Strict On
Public Class frmHospitalCharges

    Const DailyCharges As Integer = 350

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnClearForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearForm.Click
        Clear()
    End Sub

    Private Sub btnCalculateCharges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculateCharges.Click

        Dim Stay As Decimal
        Dim MedicationCost As Decimal
        Dim SurgicalCost As Decimal
        Dim LabCost As Decimal
        Dim PhysicalRehabCost As Decimal
        Dim TotalStayCost As Decimal
        Dim MiscellaneousChargesCost As Decimal
        Dim TotalCost As String
        Dim ProviderCost As String
        Dim Insurance As Boolean

        If CheckNumeric(txtLengthOfStay.Text) = True And CheckNumeric(txtMedicationCharges.Text) = True And CheckNumeric(txtPhysicalRehab.Text) = True _
            And CheckNumeric(txtSurgicalCharges.Text) = True And CheckNumeric(txtLabFees.Text) = True Then

            If txtLengthOfStay.Text = "" Then
                Stay = 0
            Else
                Stay = CDec(txtLengthOfStay.Text)
            End If

            If txtMedicationCharges.Text = "" Then
                MedicationCost = 0
            Else
                MedicationCost = CDec(txtMedicationCharges.Text)
            End If
            If txtSurgicalCharges.Text = "" Then
                SurgicalCost = 0
            Else
                SurgicalCost = CDec(txtSurgicalCharges.Text)
            End If
            If txtLabFees.Text = "" Then
                LabCost = 0
            Else
                LabCost = CDec(txtLabFees.Text)
            End If
            If txtPhysicalRehab.Text = "" Then
                PhysicalRehabCost = 0
            Else
                PhysicalRehabCost = CDec(txtPhysicalRehab.Text)
            End If
            If chkInsured.Checked = True Then
                Insurance = True
            End If

            If Stay >= 0 And MedicationCost >= 0 And SurgicalCost >= 0 And LabCost >= 0 And PhysicalRehabCost >= 0 Then

                TotalStayCost = CalcStayCharges(Stay)
                MiscellaneousChargesCost = CalcMiscCharges(MedicationCost, SurgicalCost, LabCost, PhysicalRehabCost)
                TotalCost = CalcAndFormatPatientCharges(TotalStayCost, MiscellaneousChargesCost, Insurance)
                Dim TotalCost2 As Decimal
                TotalCost2 = TotalStayCost + MiscellaneousChargesCost
                Dim CostCalculation3 As Decimal
                CostCalculation3 = CDec(TotalCost)
                ProviderCost = CalcAndFormatProviderCharges(TotalCost2, CostCalculation3)
                Dim strIsTheCost As String
                strIsTheCost = CStr(TotalCost)
                If TotalCost = "$0.00" Then
                    txtTotalCost.Text = "N/A"
                Else
                    txtTotalCost.Text = strIsTheCost
                    btnClearForm.Focus()
                End If
                If Insurance = True Then
                    txtTotalProviderCost.Text = ProviderCost
                Else
                    txtTotalProviderCost.Text = "N/A"
                End If

            Else
                'Error message for negative numbers
                MessageBox.Show("You cannot enter a negative number.", "1D107 Error.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Clear()

            End If
            Else
                'Error message for letters
                MessageBox.Show("You must enter numeric values.", "1D107 Error.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Clear()
            End If

      

    End Sub

    Private Sub Clear()
        txtLengthOfStay.Text = ""
        txtMedicationCharges.Text = ""
        txtSurgicalCharges.Text = ""
        txtPhysicalRehab.Text = ""
        txtLabFees.Text = ""
        txtTotalCost.Text = ""
        chkInsured.Checked = False
    End Sub


    Function CalcStayCharges(ByVal a As Decimal) As Decimal
        Return a * DailyCharges
    End Function

    Function CalcMiscCharges(ByVal a As Decimal, b As Decimal, c As Decimal, d As Decimal) As Decimal
        Return a + b + c + d
    End Function

    Function CalcAndFormatPatientCharges(ByVal a As Decimal, ByVal b As Decimal, ByVal c As Boolean) As String
        Dim CostCalculation As String
        Dim CostCalculationDecimal As Decimal
        If c = True Then
            CostCalculationDecimal = CDec((a + b) * 0.08)
        Else
            CostCalculationDecimal = CDec(a + b)
        End If
        CostCalculation = FormatCurrency(CostCalculationDecimal)
        Return CostCalculation

    End Function

    Function CalcAndFormatProviderCharges(ByVal a As Decimal, ByVal b As Decimal) As String
        Dim ProviderCostCalculation1 As Decimal
        Dim ProviderCostCalculation2 As String
        ProviderCostCalculation1 = CDec(a - b)
        ProviderCostCalculation2 = FormatCurrency(ProviderCostCalculation1)
        Return ProviderCostCalculation2

    End Function

        Function CheckNumeric(a As String) As Boolean
        If a = "" Then
            Return True
        ElseIf IsNumeric(a) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub frmHospitalCharges_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtLengthOfStay.Focus()
    End Sub
End Class
