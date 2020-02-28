Imports CD_Reports_MiddleTier.AppSetter
Public Class ReportComponent_RemindersList
    Implements IReportComponent

    Function GetOrdinal() As Integer Implements IReportComponent.GetOrdinal
        Return 1
    End Function
    Function GetDescription() As String Implements IReportComponent.GetDescription
        Return "Reminders List items"
    End Function
    Function GetSelectQuery() As EH_DataUtilities.EH_QueryBuilder Implements IReportComponent.GetSelectQuery

        Dim ehq As New EH_DataUtilities.EH_QueryBuilder(GetHostSqlServer())

        ehq.ADD_TO_SELECT("ClientID, Item, Details ")
        ehq.ASSIGN_FROM_STATEMENT("tblReminder")
        ehq.ADD_TO_WHERE("Program ='HealthConnect' AND Reminder_date >= getdate()")

        Return ehq

    End Function
    Function GetUpdateQuery(CID As Integer) As EH_DataUtilities.EH_QueryBuilder Implements IReportComponent.GetUpdateQuery

        Dim ehq As New EH_DataUtilities.EH_QueryBuilder(GetHostSqlServer())

        ehq.ASSIGN_FIRST_LINE("UPDATE tblMasterClientCallList_HC SET Six_Month_Screen_Due = 'TRUE'")
        ehq.ADD_TO_WHERE("ClientID =" & CID)
        Return ehq

    End Function

End Class
