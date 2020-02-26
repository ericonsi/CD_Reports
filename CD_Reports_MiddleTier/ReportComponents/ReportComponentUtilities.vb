Public Class ReportComponentUtilities

    Public Function GetReportComponentArray(FormChoices As Boolean()) As List(Of IReportComponent)

        Dim rc As New List(Of IReportComponent)
        Dim rc_three As New ReportComponent_3MonthScreenDue
        Dim rc_six As New ReportComponent_6MonthScreenDue
        Dim i As Integer = 0

        For Each fc In FormChoices

            If fc Then
                Select Case i
                    Case 0
                        rc.Add(rc_three)

                    Case 1
                        rc.Add(rc_six)

                End Select
            End If

            i = i + 1
        Next
        Return rc

    End Function

End Class
