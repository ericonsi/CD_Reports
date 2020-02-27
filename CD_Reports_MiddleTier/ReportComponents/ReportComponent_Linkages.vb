Imports CD_Reports_MiddleTier.AppSetter
Public Class ReportComponent_Linkages
    Implements IReportComponent

    Function GetOrdinal() As Integer Implements IReportComponent.GetOrdinal
        Return 2
    End Function
    Function GetDescription() As String Implements IReportComponent.GetDescription
        Return "No Linkage"
    End Function
    Function GetSelectQuery() As EH_DataUtilities.EH_QueryBuilder Implements IReportComponent.GetSelectQuery

        Dim ehq As New EH_DataUtilities.EH_QueryBuilder(GetHostSqlServer())

        ehq.ADD_TO_SELECT(" tblClients.ClientID")
        ehq.ASSIGN_FROM_STATEMENT("tblClients")
        ehq.ADD_TO_WHERE("ClubHealthConnect = 'member'")
        ehq.ADD_TO_WHERE("clientid  NOT IN " &
                            "(SELECT tblServices.ClientID" &
                                    " FROM tblServices INNER JOIN tblLinkAppts ON tblServices.ServiceID = tblLinkAppts.ServiceID " &
                                    " WHERE (((tblServices.Program)='healthconnect') AND ((tblLinkAppts.Linked)='True')) AND tblClients.ClientID = tblServices.ServiceID)")

        Return ehq

    End Function
    Function GetUpdateQuery(CID As Integer) As EH_DataUtilities.EH_QueryBuilder Implements IReportComponent.GetUpdateQuery

        Dim ehq As New EH_DataUtilities.EH_QueryBuilder(GetHostSqlServer())

        ehq.ASSIGN_FIRST_LINE("UPDATE tblMasterClientCallList_HC SET MD_Appt_Due = 'TRUE'")
        ehq.ADD_TO_WHERE("ClientID =" & CID)
        Return ehq

    End Function

End Class
