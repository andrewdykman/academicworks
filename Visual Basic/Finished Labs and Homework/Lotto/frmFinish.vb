Public Class frmFinish
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmFinish_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmLottery.lblLotteryNumberLabel.Text = frmLottery.lblLottNum1.Text & " - " & frmLottery.lblLottNum2.Text & " - " & frmLottery.lblLottNum3.Text & " - " & frmLottery.lblLottNum4.Text & " - " & frmLottery.lblLottNum5.Text
    End Sub
End Class