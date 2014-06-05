'Secondary Dialog Box for System Time
Public Class frmWelcome

    Private Sub btnOkay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkay.Click
        'Enable Widget Form, Activate Close
        frmHowManyWidgets.Enabled = True
        Close()
    End Sub
End Class