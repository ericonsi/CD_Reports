Imports CD_Reports_MiddleTier.AppSetter
Public Class ReportComponent_6MonthScreenDue
    Implements IReportComponent

    Function GetOrdinal() As Integer Implements IReportComponent.GetOrdinal
        Return 1
    End Function
    Function GetDescription() As String Implements IReportComponent.GetDescription
        Return "Six Month Screen Due"
    End Function
    Function GetSelectQuery() As EH_DataUtilities.EH_QueryBuilder Implements IReportComponent.GetSelectQuery

        Dim ehq As New EH_DataUtilities.EH_QueryBuilder(GetHostsqlserver())

        ehq.ADD_TO_SELECT(" tblServices.ClientID")
        ehq.ASSIGN_FROM_STATEMENT("tblServices INNER Join tblVitalSigns On tblServices.ServiceID = tblVitalSigns.ServiceID")
        ehq.ADD_TO_WHERE("(((tblServices.Program) ='HealthConnect') AND ((tblVitalSigns.Type)='blood pressure' Or (tblVitalSigns.Type)='A1C') AND ((tblVitalSigns.Stage)='baseline') AND ((DateDiff(Month,[date of service],GetDate()))>=5))")
        ehq.ADD_TO_GROUPBY("tblServices.ClientID")

        Return ehq

    End Function
    Function GetUpdateQuery(CID As Integer) As EH_DataUtilities.EH_QueryBuilder Implements IReportComponent.GetUpdateQuery

        Dim ehq As New EH_DataUtilities.EH_QueryBuilder(GetHostsqlserver())

        ehq.ASSIGN_FIRST_LINE("UPDATE tblMasterClientCallList_HC SET Six_Month_Screen_Due = 'TRUE'")
        ehq.ADD_TO_WHERE("ClientID =" & CID)
        Return ehq

    End Function

End Class
