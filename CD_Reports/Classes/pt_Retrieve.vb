Public Class pt_Retrieve
    Public Shared Function RETRIEVE_ArrayOfSelectedReportComponentsFromFrmMain() As Boolean()

        Dim ComponentsArray() As Boolean = {False, False, False, False}

        If frmMain1.chk3MonthDue.Checked Then
            ComponentsArray(0) = True
        End If

        If frmMain1.chk6MonthDue.Checked Then
            ComponentsArray(1) = True
        End If

        If frmMain1.chkMDDue.Checked Then
            ComponentsArray(2) = True
        End If

        If frmMain1.chkOtherReminderInfo.Checked Then
            ComponentsArray(3) = True
        End If

        Return ComponentsArray

    End Function
    Public Shared Function RETRIEVE_SelectedMonthIDfromFrmMain() As Integer

        Return frmMain.cmbMonth.SelectedValue

    End Function
    Public Shared Function RETRIEVE_SelectedProgramID() As Integer

        Return frmMain.dgvPrograms.CurrentRow.Cells(0).Value

    End Function

    Private Function RETRIEVE_month_ordinal_for_now_month() As Integer

        Return DateDiff(DateInterval.Month, #1/1/2016#, Now)

    End Function
    Public Shared Function RETRIEVE_month_ordinal_for_now_month_minus_one() As Integer

        Return DateDiff(DateInterval.Month, #2/1/2016#, Now)

    End Function
    Public Shared Function RETRIEVE_All_Or_Selected_ForIndicators() As String

        If frmMain.radAllIndicators.Checked = True Then
            Return "All"
        Else
            Return "Selected"
        End If

    End Function
End Class


