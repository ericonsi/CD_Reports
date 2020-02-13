Public Class mt_Validation
    Public Shared Function VALIDATE_that_BenchMarkID_is_not_null(dgv As DataGridView, e As DataGridViewCellCancelEventArgs) As Boolean

        If Not IsDBNull(dgv.Rows(e.RowIndex).Cells("MonthlyBenchmarkID").Value) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
