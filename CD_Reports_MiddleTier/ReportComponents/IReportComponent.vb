Imports EH_DataUtilities.EH_QueryBuilder
Public Interface IReportComponent
    Function GetOrdinal() As Integer
    Function GetDescription() As String
    Function GetSelectQuery() As EH_DataUtilities.EH_QueryBuilder
    Function GetUpdateQuery(CID As Integer) As EH_DataUtilities.EH_QueryBuilder
End Interface
