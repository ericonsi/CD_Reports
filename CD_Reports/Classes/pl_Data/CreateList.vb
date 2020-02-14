Imports CD_Reports_MiddleTier.mt_Data
Imports CD_Reports.pt_Retrieve

Public Class CreateList
    Public Sub PROCEDURE_CALL_CreateList()

        Dim de As New DataEntryUpdateAndDelete
        Dim ReportComponents As Boolean()

        de.DELETE_AllCallListTableRecords()
        ReportComponents = RETRIEVE_ArrayOfSelectedReportComponentsFromFrmMain()

        For Each rc In ReportComponents



        Next


    End Sub
End Class
