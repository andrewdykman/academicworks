' Lab 3 by Andrew Dykman, Visual Basic w/ Sean Yergensen
' 4/10/2012

Option Strict On
Public Class frmPayrollCalculator

    Private Sub frmPayrollCalculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmSummary.Hide()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        'Close the Program
        Close()
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'Declare Payroll Vars and Initial Vars
        Dim intPayRate As Integer = 0
        Dim intRegularHours As Integer = 0
        Dim dblRegularWage As Double = 0.0
        Dim intOvertimeHours As Integer = 0
        Dim dblOvertimeWage As Double = 0.0
        Dim dblTotalWage As Double = 0.0
        Dim intTotalHours As Integer = 0
        Dim intEmployeeWage As Integer = 0

        'Hours for Validation
        Dim intEmployeeHours As Integer = 0
        Dim intEmployeeHoursCorrect As Integer = 0
        Dim intHoursWorkedNull As Integer = 0

        'Set the Default Option to Didn't Select Anything in the Combo Box
        Dim intOptionSelected As Integer = 0
        'Set the Flag for the Form as Having No Form Data Errors by Default
        Dim intHasFormErrors As Integer = 0
        'Set String and Boolean Vars to Check If Name Input Is a Number Then Do the Check
        Dim bolFirstNameCheck As Boolean
        Dim bolLastNameCheck As Boolean
        Dim strNameFirst As String
        Dim strNameLast As String
        strNameFirst = txtEmployeeFirst.Text
        strNameLast = txtEmployeeLast.Text
        bolFirstNameCheck = IsNumeric(strNameFirst)
        bolLastNameCheck = IsNumeric(strNameLast)

        'Check Employee Name Field for Valid Input
        If txtEmployeeLast.Text = "" Then
            intHasFormErrors = 1
            MessageBox.Show("1D107 Error: You did not enter an Employee Last Name.")
        End If
        If txtEmployeeFirst.Text = "" Then
            intHasFormErrors = 1
            MessageBox.Show("1D107 Error: You did not enter an Employee First Name.")
        End If
        If bolFirstNameCheck = True Then
            intHasFormErrors = 1
            MessageBox.Show("1D107 Error: You entered a NUMBER where you should have entered a NAME in the First Name Field.")
        End If
        If bolLastNameCheck = True Then
            intHasFormErrors = 1
            MessageBox.Show("1D107 Error: You entered a NUMBER where you should have entered a NAME in the Last Name Field.")
        End If

        'Check Hours Field for Valid Input (in case of retarded user.)
        Dim bolHoursCheck As Boolean
        bolHoursCheck = IsNumeric(txtHoursWorked.Text)

        If txtHoursWorked.Text = "" Then
            intHasFormErrors = 1
            intHoursWorkedNull = 1
            MessageBox.Show("1D107 Error: You did not enter the Employee's Hours.")
        Else
            intEmployeeHoursCorrect += 1
        End If

        If bolHoursCheck = False And intHoursWorkedNull = 0 Then
            intHasFormErrors = 1
            MessageBox.Show("1D107 Error: You entered NON-NUMBERS in the employee hours field, where you should have entered NUMBERS.")
        Else
            intEmployeeHoursCorrect += 1
        End If


        If intEmployeeHoursCorrect = 2 Then
            intEmployeeHours = CInt(txtHoursWorked.Text)
        End If

        If intEmployeeHours > 60 Then
            intHasFormErrors = 1
            MessageBox.Show("1D107 Error: You exceeded the 60 maximum hours!")
        End If

        'In case of a REALLY retarded user.

        If intEmployeeHours < 0 Then
            intHasFormErrors = 1
            MessageBox.Show("1D107 Error: You can't work NEGATIVE hours!")
        End If

       
        Dim strEmployeeType As String = ""

        If cmbEmployeeType.Text = "Trainee" Then
            intOptionSelected = 1
            intEmployeeWage = 10
        End If
        If cmbEmployeeType.Text = "Employee" Then
            intOptionSelected = 2
            intEmployeeWage = 15
        End If
        If cmbEmployeeType.Text = "Manager" Then
            intOptionSelected = 3
            intEmployeeWage = 20
        End If

        'Get the Correct Wage
        If intEmployeeHours <= 40 And intHasFormErrors = 0 Then
            dblTotalWage = intEmployeeHours * intEmployeeWage
            dblRegularWage = dblTotalWage
            intTotalHours = intEmployeeHours
            intRegularHours = intEmployeeHours
        End If
        If intEmployeeHours > 40 And intHasFormErrors = 0 Then
            dblRegularWage = 40 * intEmployeeWage
            intOvertimeHours = intEmployeeHours - 40
            dblOvertimeWage = intOvertimeHours * intEmployeeWage * 1.5
            intTotalHours = intEmployeeHours
            intRegularHours = 40
            dblTotalWage = dblOvertimeWage + dblRegularWage
        End If


        ' Lets See What the User Picked. If Bad, We Will Error on Them and Insult Their Intelligence.
        Select Case intOptionSelected
            Case 1
                strEmployeeType = "Trainee"
            Case 2
                strEmployeeType = "Employee"
            Case 3
                strEmployeeType = "Manager"
            Case Else
                MessageBox.Show("1D107 Error: You did not select an Employee Type.")
                ' Flag the Form Data as Error-Ridden
                intHasFormErrors = 1
        End Select

        ' If Form Has Form Data Errors Then Make Them Fix Their Input Before Showing Final Box
        If intHasFormErrors = 0 Then
            Me.Hide()
            frmSummary.Show()
            frmSummary.lblSummaryEmployeeName.Text = txtEmployeeFirst.Text & " " & txtEmployeeLast.Text
            frmSummary.lblEmployeeSummaryType.Text = cmbEmployeeType.Text
            frmSummary.lblEmployeeSummaryPayRate.Text = "$" & CStr(intEmployeeWage) & ".00"
            frmSummary.lblSummaryTotalHours.Text = CStr(intTotalHours)
            frmSummary.lblSummaryRegularHours.Text = CStr(intRegularHours)
            frmSummary.lblSummaryRegularWage.Text = "$" & CStr(dblRegularWage)
            frmSummary.lblSummaryOvertimeHours.Text = CStr(intOvertimeHours)
            frmSummary.lblSummaryOvertimeWage.Text = "$" & CStr(dblOvertimeWage)
            frmSummary.lblSummaryTotalWage.Text = "$" & CStr(dblTotalWage)
        End If
        If intHasFormErrors = 1 Then
            MessageBox.Show("Please Fix Your Form Data Input Errors Before Continuing.")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtEmployeeFirst.Text = ""
        txtEmployeeLast.Text = ""
        txtHoursWorked.Text = ""
        cmbEmployeeType.Text = ""
    End Sub
End Class
