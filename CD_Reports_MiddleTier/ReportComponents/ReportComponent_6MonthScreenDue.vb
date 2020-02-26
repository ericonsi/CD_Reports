Public Class ReportComponent_6MonthScreenDue
    Implements IReportComponent

    Function GetOrdinal() As Integer Implements IReportComponent.GetOrdinal
        Return 0
    End Function
    Function GetDescription() As String Implements IReportComponent.GetDescription
        Return "Six Month Screen Due"
    End Function
    Function GetSelectQuery() As EH_DataUtilities.EH_QueryBuilder Implements IReportComponent.GetSelectQuery

        Dim ehq As New EH_DataUtilities.EH_QueryBuilder

        ehq.ADD_TO_SELECT(" tblClients.ClientID")
        ehq.ASSIGN_FROM_STATEMENT("tblClients")
        ehq.ADD_TO_WHERE("ClubHealthConnect = 'Member'")
        Return ehq

    End Function
    Function GetUpdateQuery(CID As Integer) As EH_DataUtilities.EH_QueryBuilder Implements IReportComponent.GetUpdateQuery

        Dim ehq As New EH_DataUtilities.EH_QueryBuilder

        ehq.ASSIGN_FIRST_LINE("UPDATE tblMasterClientCallList_HC SET ClubHC_Status = 'TRUE'")
        ehq.ADD_TO_WHERE("ClientID =" & CID)
        Return ehq

    End Function

End Class
