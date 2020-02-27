Imports CD_Reports_MiddleTier.AppSetter
Public Class ReportComponent_3MonthScreenDue
    Implements IReportComponent

    Function GetOrdinal() As Integer Implements IReportComponent.GetOrdinal
        Return 0
    End Function
    Function GetDescription() As String Implements IReportComponent.GetDescription
        Return "Three Month Screen Due"
    End Function
    Function GetSelectQuery() As EH_DataUtilities.EH_QueryBuilder Implements IReportComponent.GetSelectQuery

        Dim ehq As New EH_DataUtilities.EH_QueryBuilder(GetHostSqlServer())

        ehq.ADD_TO_SELECT(" tblServices.ClientID")
        ehq.ASSIGN_FROM_STATEMENT("tblServices INNER Join tblVitalSigns On tblServices.ServiceID = tblVitalSigns.ServiceID")
        ehq.ADD_TO_WHERE("(((tblServices.Program) ='HealthConnect') AND ((tblVitalSigns.Type)='blood pressure' Or (tblVitalSigns.Type)='A1C') AND ((tblVitalSigns.Stage)='baseline') AND ((DateDiff(Month,[date of service],GetDate()))>=2))")
        ehq.ADD_TO_WHERE("clientid  NOT IN " &
                            "(SELECT tblServices.ClientID " &
                            " From tblServices INNER Join tblVitalSigns On tblServices.ServiceID = tblVitalSigns.ServiceID" &
                            " Where (tblVitalSigns.Type ='blood pressure' Or tblVitalSigns.Type='A1C')  AND tblServices.Program='healthconnect' AND tblVitalSigns.Stage='3 month' AND tblServices.clientID = tblServices.clientID)")
        ehq.ADD_TO_GROUPBY("tblServices.ClientID")

        Return ehq

    End Function
    Function GetUpdateQuery(CID As Integer) As EH_DataUtilities.EH_QueryBuilder Implements IReportComponent.GetUpdateQuery

        Dim ehq As New EH_DataUtilities.EH_QueryBuilder(GetHostsqlserver())

        ehq.ASSIGN_FIRST_LINE("UPDATE tblMasterClientCallList_HC SET Three_Month_Screen_Due = 'TRUE'")
        ehq.ADD_TO_WHERE("ClientID =" & CID)
        Return ehq

    End Function

End Class
