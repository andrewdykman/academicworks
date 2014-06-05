Option Strict On
Public Class frmLottery

    Private rand As New Random

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        Dim numbers As String = txtNumbers.Text
        Dim chosenNumbers(5) As Char
        Dim lotteryArray() As Integer
        Dim count As Integer

        If IsNumeric(numbers) And numbers.Length = 5 Then
            lblLotteryNumberLabel.Text = "Lottery Numbers"
            lblYourNum.Text = " Your Selection"
            chosenNumbers = txtNumbers.Text.ToCharArray
            lblYourNum.Text = chosenNumbers(0).ToString & "                        " & chosenNumbers(1).ToString & "                        " & chosenNumbers(2).ToString _
                & "                        " & chosenNumbers(3).ToString & "                        " & chosenNumbers(4).ToString

            lotteryArray = FillArray()
            For count = 0 To chosenNumbers.Length - 1
                LabelFill(count, lotteryArray)
            Next

            txtNumbers.Text = ""
            txtNumbers.Focus()

            'Calls Win sub
            Win(lotteryArray, chosenNumbers)



        Else
            'Error message
            MessageBox.Show("Please enter five numbers", "", MessageBoxButtons.OK, MessageBoxIcon.None)
            txtNumbers.Text = ""
            txtNumbers.Focus()
        End If
    End Sub

    Function FillArray() As Integer()
        'Set variables
        Dim lotteryNumbers(5) As Integer
        Dim count As Integer

        'get random numbers
        For count = 0 To lotteryNumbers.Length - 1
            lotteryNumbers(count) = rand.Next(10)
        Next
        'return
        Return lotteryNumbers
    End Function

    Sub LabelFill(ByVal count As Integer, ByVal lot() As Integer)
        Select Case count
            Case 0
                lblLottNum1.Text = lot(0).ToString
            Case 1
                lblLottNum2.Text = lot(1).ToString
            Case 2
                lblLottNum3.Text = lot(2).ToString
            Case 3
                lblLottNum4.Text = lot(3).ToString
            Case 4
                lblLottNum5.Text = lot(4).ToString
        End Select

    End Sub

    Private Sub frmLottery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNumbers.Focus()

    End Sub

    Private Sub Win(ByRef lot() As Integer, ByRef cn() As Char)
        Dim howMany As Integer = 0
        Dim count As Integer
        If lot(0) = CInt(Val(cn(0))) And lot(1) = CInt(Val(cn(1))) And lot(2) = CInt(Val(cn(2))) And lot(3) = CInt(Val(cn(3))) And lot(4) = CInt(Val(cn(4))) Then
            Dim win As New frmWin
            frmWin.ShowDialog()
        Else
            For count = 0 To cn.Length - 1
                If lot(count) = CInt(Val(cn(count))) Then
                    howMany += 1
                End If
            Next
            Dim view As New frmFinish
            frmFinish.Show()
            If howMany = 1 Then
                frmFinish.lblShow.Text = "You have " & howMany & " correct pick!"
            Else
                frmFinish.lblShow.Text = "You have " & howMany & " correct picks!"
            End If
        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtNumbers.Text = ""
        lblLottNum5.Text = ""
        lblLotteryNumber1.Text = ""
        lblLotteryNumber2.Text = ""
        lblLotteryNumber3.Text = ""
        lblLotteryNumber4.Text = ""
        lblYourNum.Text = ""
        lblYourNum.Text = ""
        lblLotteryNumberLabel.Text = ""

        txtNumbers.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class