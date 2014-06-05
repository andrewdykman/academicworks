Public Class frmSelectingSalesStaff

    Private Sub SalesStaffBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SalesStaffBindingSource.EndEdit()
        Me.SalesStaffTableAdapter.Update(Me.CompanyDataSet.SalesStaff)

    End Sub


    Private Sub frmSelectingSalesStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
        Me.SalesStaffTableAdapter.Fill(Me.CompanyDataSet.SalesStaff)

    End Sub

    Private Sub FillBy1ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillBy1ToolStripButton.Click
        Try
            Me.SalesStaffTableAdapter.FillBy1(Me.CompanyDataSet.SalesStaff)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class