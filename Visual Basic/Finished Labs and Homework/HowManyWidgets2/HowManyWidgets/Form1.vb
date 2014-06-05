' Andrew Dykman, Programming Challenge 5, Pg.185 (Lab 1.1) - Week 2

Public Class frmHowManyWidgets

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'Exits When Clicked
        Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Clears Text Values for 2 Inputs and Total Widgets When Clicked
        txtTotalWeight.Text = ""
        txtWeightOfPallet.Text = ""
        lblTotalWidgets.Text = ""
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Try
            ' Starts a structured exception handler.
            ' Place executable statements that may generate 
            ' an exception in this block.
            ' Ends a structured exception handler.

            'Dim Vars as Decimal Data Type

            Dim decWidgetsTotal As Decimal
            Dim decTotalWeight As Decimal
            Dim decWeightOfPallet As Decimal
            Dim decWidgetsWeight As Decimal
            'Perform Calculations After Doing Decimal Conversion from String
            decTotalWeight = CDec(txtTotalWeight.Text)
            decWeightOfPallet = CDec(txtWeightOfPallet.Text)
            decWidgetsWeight = decTotalWeight - decWeightOfPallet
            'Do Our Math (Each Widget Weighs 9.3 lbs.)
            decWidgetsTotal = decWidgetsWeight / 9.3
            'Display Our Total Calculation to the User
            lblTotalWidgets.Text = decWidgetsTotal
        Catch
            lblError.Visible = True
        Finally
            ' This code always runs immediately before
            ' the Try statement exits.
        End Try

    End Sub

    Private Sub frmHowManyWidgets_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Show a Window with the Current Time / Date, Disable Widget Form, Bring frmWelcome to Front, Focus Okay Button
        frmWelcome.Show()
        frmWelcome.lblSystemTime.Text = Now
        frmWelcome.Activate()
        frmWelcome.btnOkay.Focus()
    End Sub
End Class
