Public Class mt_Data
    Public Class DataEntryUpdateAndDelete
        Public Sub DeleteAllCallListTableRecords()
            Try

                Dim ehq As New EH_DataUtilities.EH_QueryBuilder
                ehq.ASSIGN_FIRST_LINE("Delete * from tblMasterCallList_HC")
                ehq.EXECUTE_NONQUERY()

            Catch ex As Exception

                Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
                HandleStandardException.HANDLE_EXCEPTION(ex, True, "The table is not empty.")

            End Try
        End Sub
        Public Sub UpdateBenchmark(iIndicatorID As Integer, sOldValue As String, sNewValue As String)
            Try

                'Dim ehq As New EH_DataUtilities.EH_QueryBuilder
                ' ehq.ASSIGN_FIRST_LINE("UPDATE tblIndicators Set Indicator = '" & sNewValue & "'")
                ' ehq.ADD_TO_WHERE("IndicatorID = " & iIndicatorID)
                ' ehq.EXECUTE_NONQUERY()

            Catch ex As Exception

                Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
                HandleStandardException.HANDLE_EXCEPTION(ex, True, "The indicator is not updated")

            End Try
        End Sub
        Public Sub AddBenchmark()
            Try

                Dim ehq As New EH_DataUtilities.EH_QueryBuilder
                ' ehq.ASSIGN_FIRST_LINE("UPDATE tblIndicators Set Indicator = '" & sNewValue & "'")
                ' ehq.ADD_TO_WHERE("IndicatorID = " & iIndicatorID)
                ' ehq.EXECUTE_NONQUERY()

            Catch ex As Exception

                Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
                HandleStandardException.HANDLE_EXCEPTION(ex, True, "The indicator is not added")

            End Try
        End Sub
        Public Sub BuildNewMonth(SelectedMonthID As Integer)

            Try

                Dim ehq As New EH_DataUtilities.EH_QueryBuilder

                ehq.ASSIGN_FIRST_LINE("INSERT INTO tblMonthlyBenchmarks ( IndicatorID, MonthID, TargetValue, Details, bOptional )" &
                        "  Select tblIndicators.IndicatorID, " & SelectedMonthID & ", tblIndicators.Projected, tblIndicators.Notes, tblIndicators.bOptional")
                ehq.ASSIGN_FROM_STATEMENT("tblDepartments INNER Join (tblIndicators INNER Join tblPrograms On tblIndicators.ProgramID = tblPrograms.ProgramID) ON tblDepartments.DepartmentID = tblPrograms.DepartmentID")
                ehq.ADD_TO_WHERE("tblDepartments.include = 'True' And tblIndicators.Include = 'True' And tblPrograms.Include = 'True'")
                ehq.EXECUTE_NONQUERY()
                MessageBox.Show("Done.")

            Catch ex As Exception
                Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
                HandleStandardException.HANDLE_EXCEPTION(ex, True, "The month build has failed.")
            End Try
        End Sub
    End Class
End Class
