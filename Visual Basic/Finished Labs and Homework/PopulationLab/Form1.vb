Option Strict On
Public Class frmPopluationLab
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Set focus on load
        cboOrganism.Focus()
    End Sub


    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        'Initialize variables
        Dim organisms As Decimal
        Dim increase As Decimal
        Dim days As Integer
        Dim counter As Integer
        Dim calculation As Decimal
        Dim organismCheck As Integer
        Dim dayCheck As Integer

        'Clear the list box for a new figure
        lstShow.Items.Clear()

        'Check to see if the boxes are numeric
        If Not IsNumeric(cboOrganism.Text) Or Not IsNumeric(txtIncrease.Text) Or Not IsNumeric(cboDays.Text) Then
            MessageBox.Show("Please enter numbers", "error", MessageBoxButtons.OK, MessageBoxIcon.Hand)

            'Set Focus on section that needs attention
            If Not IsNumeric(cboOrganism.Text) Then
                cboOrganism.Focus()
            ElseIf Not IsNumeric(txtIncrease.Text) Then
                txtIncrease.Focus()
            Else
                cboDays.Focus()
            End If
        Else
            'Set variables if passed numeric test
            organisms = CDec(cboOrganism.Text)
            organismCheck = CInt(organisms)
            increase = CDec(txtIncrease.Text) * CDec(0.01)
            days = CInt(cboDays.Text)
            dayCheck = CInt(days)

            'Check and make sure all fields pass test
            If organisms >= 2 And organisms <= 50 And organisms = organismCheck And days > 1 And increase > 0 And dayCheck = days _
                And days <= 100 And increase <= 50 Then

                'Set the first couple of lines
                lstShow.Items.Add("Day          Approximate Population")
                lstShow.Items.Add("    1                            " & FormatNumber(organisms).ToString)

                'Set the loop to continue setting the list box
                For counter = 2 To days
                    calculation = CDec(organisms + organisms * increase)
                    organisms = CDec(calculation)

                    'Set format for viewing
                    If counter < 10 Then
                        lstShow.Items.Add("    " & counter.ToString() & "                            " & FormatNumber(calculation).ToString)
                    ElseIf counter >= 100 Then
                        lstShow.Items.Add(counter.ToString() & "                            " & FormatNumber(calculation).ToString)
                    Else
                        lstShow.Items.Add("  " & counter.ToString() & "                            " & FormatNumber(calculation).ToString)
                    End If
                Next
            Else

                'Error message if if statement failed
                MessageBox.Show("Please a whole number 2 or greater.", "error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                cboOrganism.Focus()
            End If


        End If



    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Clear fields
        cboDays.Text = ""
        cboOrganism.Text = ""
        txtIncrease.Text = ""
        lstShow.Items.Clear()

        'Reset focus
        cboOrganism.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'Close program
        Me.Close()
    End Sub
End Class