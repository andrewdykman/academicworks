Option Strict On
Public Class frmMain
    Dim title() As String = {"Andrew Dykman"}

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblDateTime.Text = FormatDateTime(Now, DateFormat.GeneralDate)
        Dim random As New Random
        Dim numberR As Integer = random.Next(10)

        lblRandomGenerator.Text = "Created by, " & title(numberR)

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lblDateTime.Text = FormatDateTime(Now, DateFormat.GeneralDate)
    End Sub

    Private Sub mnuFilePrint_Click(sender As System.Object, e As System.EventArgs) Handles mnuFilePrint.Click

        With ofdOpenFile
            .Filter = "Text Files (*.txt)|*.txt"
            .InitialDirectory = "C:\Data"
            .Title = "Open File"
            .ShowDialog()
        End With
        OpenFile(ofdOpenFile.FileName)
        PrintDocument1.Print()
    End Sub

    Private Sub mnuRealEstateAddNew_Click(sender As System.Object, e As System.EventArgs) Handles mnuRealEstateAddNew.Click
        Dim addProperty As New frmPropertyData
        addProperty.ShowDialog()
    End Sub

    Private Sub mnuRealEstateSearch_Click(sender As System.Object, e As System.EventArgs) Handles mnuRealEstateSearch.Click
        Dim searchProperty As New frmSearch
        searchProperty.ShowDialog()
    End Sub

    Private Sub mnuFileExit_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sure you want to quit?", "Exit Confirmation?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        e.Graphics.DrawString("Real Estate Properties", New Font("courier New", 12, FontStyle.Bold), Brushes.Black, 150, 10)
        e.Graphics.DrawString(String.Format("{0, -14} {1, -12} {2, -8} {3, -16} {4, -8} {5, -10} {6, -6} {7, -5} {8, -25} {9, -12} {10, -5} {11, -7} {12, -20}", "Agent Name", "Seller Name", "Sq Ft", "Date Available", "Acreage", "Price", "Sold", "Residential", "Address", "City", "State", "Zip", "Description"), New Font("courier New", 7, FontStyle.Bold), Brushes.Black, 10, 66)

    End Sub

    Private Sub PrintDocument1_QueryPageSettings(sender As Object, e As System.Drawing.Printing.QueryPageSettingsEventArgs) Handles PrintDocument1.QueryPageSettings
        e.PageSettings.Landscape = True
    End Sub
End Class


