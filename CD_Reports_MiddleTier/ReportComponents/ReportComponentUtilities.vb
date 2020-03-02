Public Class ReportComponentUtilities

    Public Function GetReportComponentArray(FormChoices As Boolean()) As List(Of IReportComponent)

        Dim rc As New List(Of IReportComponent)
        Dim rc_three As New ReportComponent_3MonthScreenDue
        Dim rc_six As New ReportComponent_6MonthScreenDue
        Dim rc_link As New ReportComponent_Linkages
        Dim rc_reminders As New ReportComponent_RemindersList

        Dim i As Integer = 0

        For Each fc In FormChoices

            If fc Then
                Select Case i
                    Case 0
                        rc.Add(rc_three)

                    Case 1
                        rc.Add(rc_six)

                    Case 2
                        rc.Add(rc_link)

                    Case 3
                        rc.Add(rc_reminders)

                End Select
            End If

            i = i + 1
        Next
        Return rc

    End Function

End Class
