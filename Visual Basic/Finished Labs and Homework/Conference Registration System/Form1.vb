'Main Form
Option Strict On
Public Class frmMain
    Const DINNER As Integer = 30
    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        lblTotal.Text = ""
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SelectionOptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectionOptionsToolStripMenuItem.Click
        frmOptions.ShowDialog()
        Dim dinnerOption As Boolean = frmOptions.cckDinner.Checked
        Dim conferenceOption As Boolean = frmOptions.cckConference.Checked
        Dim total As Integer
        Dim preConference As Integer = frmOptions.lstPreconference.SelectedIndex
        total = CalcTotal(conferenceOption, preConference)
        If dinnerOption Then
            total = total + DINNER
        End If
        lblTotal.Text = FormatCurrency(total.ToString)
        Clear()

    End Sub
End Class