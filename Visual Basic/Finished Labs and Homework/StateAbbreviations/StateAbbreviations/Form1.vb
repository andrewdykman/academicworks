' Lab 1.2 by Andrew Dykman
Public Class frmStateAbbreviations

    Private Sub btnVirginia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVirginia.Click
        ' Displays VA in lblStateAbbreviation when btnVirginia is clicked
        lblStateAbbreviation.Text = "VA"
    End Sub

    Private Sub btnNorthCarolina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNorthCarolina.Click
        ' Displays NC in lblStateAbbreviation when btnNorthCarolina is clicked
        lblStateAbbreviation.Text = "NC"
    End Sub

    Private Sub btnGeorgia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeorgia.Click
        ' Displays GA in lblStateAbbreviation when btnGeorgia is clicked
        lblStateAbbreviation.Text = "GA"
    End Sub

    Private Sub btnSouthCarolina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSouthCarolina.Click
        ' Displays SC in lblStateAbbreviation when btnSouthCarolina is clicked
        lblStateAbbreviation.Text = "SC"
    End Sub

    Private Sub btnAlabama_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlabama.Click
        ' Displays AL in lblStateAbbreviation when btnAlabama is clicked
        lblStateAbbreviation.Text = "AL"
    End Sub

    Private Sub btnFlorida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFlorida.Click
        ' Displays FL in lblStateAbbreviation when btnFlorida is clicked
        lblStateAbbreviation.Text = "FL"
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        ' Closes the Application when btnClose is clicked
        Close()
    End Sub

End Class

