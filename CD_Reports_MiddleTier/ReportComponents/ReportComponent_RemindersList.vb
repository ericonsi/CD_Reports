Imports CD_Reports_MiddleTier.AppSetter

Public Class ReportComponent_RemindersList
    Implements IReportComponent

    Function GetOrdinal() As Integer Implements IReportComponent.GetOrdinal
        Return 1
    End Function
    Function GetDescription() As String Implements IReportComponent.GetDescription
        Return "Reminder List Items"
    End Function
    Function GetSelectQuery() As EH_DataUtilities.EH_QueryBuilder Implements IReportComponent.GetSelectQuery

        Dim ehq As New EH_DataUtilities.EH_QueryBuilder(GetHostSqlServer())

        ehq.ADD_TO_SELECT("tblReminder.ClientID, tblReminder.Program, tblReminder.Reminder_date, tblReminder.Item, tblReminder.Details")
        ehq.ASSIGN_FROM_STATEMENT("tblReminder")
        ehq.ADD_TO_WHERE("tblReminder.Program ='HealthConnect' AND tblReminder.Reminder_date<=getdate() AND tblReminder.Item Not Like '%followup%' And tblReminder.ClientID Is Not Null")

        Return ehq

    End Function
    Function GetUpdateQuery(CID As Integer) As EH_DataUtilities.EH_QueryBuilder Implements IReportComponent.GetUpdateQuery

        Dim ehq As New EH_DataUtilities.EH_QueryBuilder(GetHostSqlServer())
        Return ehq

    End Function
    Function GetUpdateQuery(rm As Reminder) As EH_DataUtilities.EH_QueryBuilder

        Dim ehq As New EH_DataUtilities.EH_QueryBuilder(GetHostSqlServer())

        ehq.ASSIGN_FIRST_LINE("UPDATE tblMasterClientCallList_HC SET ReminderDetail ='" & rm.ReminderDetail & "', ReminderItem = '" & rm.ReminderItem & "'")
        ehq.ADD_TO_WHERE("ClientID =" & rm.ClientID)
        Return ehq

    End Function

End Class
