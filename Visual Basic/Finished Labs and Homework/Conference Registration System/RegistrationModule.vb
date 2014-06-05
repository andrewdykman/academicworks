'Module
Option Strict On
Module RegistrationModule

    Const COSTREGISTRATION As Integer = 895


    Public Function CalcTotal(ByVal conferenceSelection As Boolean, ByVal preConferenceSelection As Integer) As Integer
        Select Case preConferenceSelection
            Case 0, 1
                preConferenceSelection = 295
            Case 2, 3
                preConferenceSelection = 395
            Case Else
                preConferenceSelection = 0
        End Select

        Return COSTREGISTRATION + preConferenceSelection
    End Function

    Public Function Clear() As Boolean
        'Clear Everything and Restore Focus to Conference
        frmOptions.cckConference.Checked = False
        frmOptions.cckDinner.Checked = False
        frmOptions.lstPreconference.SelectedIndex = -1
        frmOptions.cckConference.Focus()

    End Function
End Module