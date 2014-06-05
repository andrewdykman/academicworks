' Andrew Dykman, Lab 8
' Visual Basic w/ Sean Yergensen

Option Strict On
Imports System
Imports System.IO
Imports System.Collections
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms

Public Class frmStudentTestScores
    Dim SaveFileDialog1 As New SaveFileDialog()
    Dim OpenFileDialog1 As New OpenFileDialog()
    Dim printDialog1 As New PrintDialog()
    Dim PrintFileDialog1 As New PrintDialog()
    Dim documentName As String = String.Empty
    Dim modify As Boolean = False
    Dim strTempDataHolder As String
    Dim strArrayDataHolder(0 To 17) As String

    Private Sub CalculateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateToolStripMenuItem.Click
        Dim testStudent1(4) As Single
        Dim testStudent2(4) As Single
        Dim testStudent3(4) As Single
        Dim count As Integer
        Dim temp As Single = 0
        Dim check As Boolean = True

        If IsNumeric(txtTestScore1Student1.Text) And IsNumeric(txtTestScore1Student2.Text) And IsNumeric(txtTestScore1Student3.Text) And _
            IsNumeric(txtTestScore2Student1.Text) And IsNumeric(txtTestScore2Student2.Text) And IsNumeric(txtTestScore2Student3.Text) And _
            IsNumeric(txtTestScore3Student1.Text) And IsNumeric(txtTestScore3Student2.Text) And IsNumeric(txtTestScore3Student3.Text) And _
            IsNumeric(txtTestScore4Student1.Text) And IsNumeric(txtTestScore4Student2.Text) And IsNumeric(txtTestScore4Student3.Text) And _
            IsNumeric(txtTestScore5Student1.Text) And IsNumeric(txtTestScore5Student2.Text) And IsNumeric(txtTestScore5Student3.Text) Then

            If Not txtStudentName1.Text = "" And Not txtStudentName2.Text = "" And Not txtStudentName3.Text = "" Then

                testStudent1(0) = CSng(txtTestScore1Student1.Text)
                testStudent1(1) = CSng(txtTestScore2Student1.Text)
                testStudent1(2) = CSng(txtTestScore3Student1.Text)
                testStudent1(3) = CSng(txtTestScore4Student1.Text)
                testStudent1(4) = CSng(txtTestScore5Student1.Text)
                testStudent2(0) = CSng(txtTestScore1Student2.Text)
                testStudent2(1) = CSng(txtTestScore2Student2.Text)
                testStudent2(2) = CSng(txtTestScore3Student2.Text)
                testStudent2(3) = CSng(txtTestScore4Student2.Text)
                testStudent2(4) = CSng(txtTestScore5Student2.Text)
                testStudent3(0) = CSng(txtTestScore1Student3.Text)
                testStudent3(1) = CSng(txtTestScore2Student3.Text)
                testStudent3(2) = CSng(txtTestScore3Student3.Text)
                testStudent3(3) = CSng(txtTestScore4Student3.Text)
                testStudent3(4) = CSng(txtTestScore5Student3.Text)


                For count = 0 To testStudent1.Length - 1
                    If testStudent1(count) >= 0 And testStudent1(count) <= 100 Then
                        temp += testStudent1(count)
                        lblAverageStudent1.Text = (temp / 5).ToString
                    Else
                        check = False
                    End If
                Next

                temp = 0

                For count = 0 To testStudent2.Length - 1
                    If testStudent2(count) >= 0 And testStudent2(count) <= 100 Then
                        temp += testStudent2(count)
                        lblAverageStudent2.Text = (temp / 5).ToString
                    Else
                        check = False
                    End If
                Next

                temp = 0

                For count = 0 To testStudent3.Length - 1
                    If testStudent3(count) >= 0 And testStudent3(count) <= 100 Then
                        temp += testStudent3(count)
                        lblAverageStudent3.Text = (temp / 5).ToString
                    Else
                        check = False
                    End If
                Next

                If check = False Then
                    MessageBox.Show("Valid Test Scores are Between 0 to 100.", "Hey! Stop Being Dumb (error)!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Clear()
                End If


            Else
                MessageBox.Show("Enter a Student's Name", "Hey, Stop Being Dumb (error)!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Clear()
            End If

        Else
            MessageBox.Show("Enter a Number.", "Hey, Stop Being Dumb (error)!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Clear()
        End If

    End Sub


    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        Clear()
    End Sub

    Sub Clear()
        txtStudentName1.Text = ""
        txtStudentName2.Text = ""
        txtStudentName3.Text = ""
        txtTestScore1Student1.Text = ""
        txtTestScore1Student2.Text = ""
        txtTestScore1Student3.Text = ""
        txtTestScore2Student1.Text = ""
        txtTestScore2Student2.Text = ""
        txtTestScore2Student3.Text = ""
        txtTestScore3Student1.Text = ""
        txtTestScore3Student2.Text = ""
        txtTestScore3Student3.Text = ""
        txtTestScore4Student1.Text = ""
        txtTestScore4Student2.Text = ""
        txtTestScore4Student3.Text = ""
        txtTestScore5Student1.Text = ""
        txtTestScore5Student2.Text = ""
        txtTestScore5Student3.Text = ""
        lblAverageStudent1.Text = ""
        lblAverageStudent2.Text = ""
        lblAverageStudent3.Text = ""

        txtStudentName1.Focus()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PrintToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem1.Click
        PrintMyDoc()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        SaveData()
    End Sub

    Private Sub OpenPreviousToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenPreviousToolStripMenuItem.Click
        OpenData()
    End Sub

    Sub OpenData()
        Dim fileDoc As StreamReader
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            documentName = OpenFileDialog1.FileName
            fileDoc = File.OpenText(documentName)
            strTempDataHolder = CStr(fileDoc.ReadLine())
            fileDoc.Close()

            Dim intCount As Integer
            strArrayDataHolder = Split(strTempDataHolder, ",")
            For intCount = LBound(strArrayDataHolder) To UBound(strArrayDataHolder)
                Debug.Print(Trim(strArrayDataHolder(intCount)))
            Next

            txtStudentName1.Text = strArrayDataHolder(0)
            txtTestScore1Student1.Text = strArrayDataHolder(1)
            txtTestScore2Student1.Text = strArrayDataHolder(2)
            txtTestScore3Student1.Text = strArrayDataHolder(3)
            txtTestScore4Student1.Text = strArrayDataHolder(4)
            txtTestScore5Student1.Text = strArrayDataHolder(5)

            txtStudentName2.Text = strArrayDataHolder(6)
            txtTestScore1Student2.Text = strArrayDataHolder(7)
            txtTestScore2Student2.Text = strArrayDataHolder(8)
            txtTestScore3Student2.Text = strArrayDataHolder(9)
            txtTestScore4Student2.Text = strArrayDataHolder(10)
            txtTestScore5Student2.Text = strArrayDataHolder(11)

            txtStudentName3.Text = strArrayDataHolder(12)
            txtTestScore1Student3.Text = strArrayDataHolder(13)
            txtTestScore2Student3.Text = strArrayDataHolder(14)
            txtTestScore3Student3.Text = strArrayDataHolder(15)
            txtTestScore4Student3.Text = strArrayDataHolder(16)
            txtTestScore5Student3.Text = strArrayDataHolder(17)


        End If
    End Sub

    Sub SaveData()
        Dim myStream As Stream
        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            myStream = saveFileDialog1.OpenFile()

            Using sw As StreamWriter = New StreamWriter(myStream)
                sw.WriteLine(txtStudentName1.Text & ", " & txtTestScore1Student1.Text & ", " & txtTestScore2Student1.Text & ", " & txtTestScore3Student1.Text & _
                              ", " & txtTestScore4Student1.Text & ", " & txtTestScore5Student1.Text & ", " & lblAverageStudent1.Text & txtStudentName2.Text & ", " & txtTestScore1Student2.Text & ", " & txtTestScore2Student2.Text & ", " & txtTestScore3Student2.Text & _
                              ", " & txtTestScore4Student2.Text & ", " & txtTestScore5Student2.Text & ", " & lblAverageStudent2.Text & txtStudentName3.Text & ", " & txtTestScore1Student3.Text & ", " & txtTestScore2Student3.Text & ", " & txtTestScore3Student3.Text & _
                              ", " & txtTestScore4Student3.Text & ", " & txtTestScore5Student3.Text & ", " & lblAverageStudent3.Text)
                sw.Close()
            End Using

            If (myStream IsNot Nothing) Then
                myStream.Close()
            End If
        End If

        modify = False

    End Sub

    Private Sub PrintMyDoc()
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim seperator As String = ", "
        Dim font As New Font("MS Sans Serif", 12, FontStyle.Regular)

        e.Graphics.DrawString(txtStudentName1.Text & seperator & txtTestScore1Student1.Text & seperator & _
                              txtTestScore2Student1.Text & seperator & txtTestScore3Student1.Text & seperator & _
                              txtTestScore4Student1.Text & seperator & txtTestScore5Student1.Text & seperator, font, Brushes.Black, 10, 10)
        e.Graphics.DrawString(txtStudentName2.Text & seperator & txtTestScore1Student2.Text & seperator & _
                              txtTestScore2Student2.Text & seperator & txtTestScore3Student2.Text & seperator & _
                              txtTestScore4Student2.Text & seperator & txtTestScore5Student2.Text & seperator, font, Brushes.Black, 10, 20)
        e.Graphics.DrawString(txtStudentName3.Text & seperator & txtTestScore1Student3.Text & seperator & _
                              txtTestScore2Student3.Text & seperator & txtTestScore3Student3.Text & seperator & _
                              txtTestScore4Student3.Text & seperator & txtTestScore5Student3.Text & seperator, font, Brushes.Black, 10, 30)
    End Sub

End Class
