Option Strict On
Imports System.Data.OleDb
Public Class frmSalesStaffSalaries

    Private Sub frmSalesStaffSalaries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rdbFullTime.Focus()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        frmSelectingSalesStaff.Show()
    End Sub

    Private Sub rdbPartTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbPartTime.CheckedChanged

    End Sub

    Private Sub rdbFullTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbFullTime.CheckedChanged

    End Sub
End Class
