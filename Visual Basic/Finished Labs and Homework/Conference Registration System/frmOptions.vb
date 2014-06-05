'Second Form
Option Strict On
Public Class frmOptions

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        'close form
        frmMain.lblTotal.Text = ""
        Me.Close()

    End Sub




    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        'Clear form
        Clear()
    End Sub

    Private Sub frmOptions_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Makes sure Conference is checked
        If Not cckConference.Checked Then
            MessageBox.Show("You must select Conference.", "1D107 Error.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            e.Cancel = True
        End If
    End Sub

    Private Sub frmOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Sets Focus
        cckConference.Focus()
    End Sub
End Class