Imports CD_Reports.pt_Data.GetSourceQueriesForDGVsAndCombos
Imports EH_ExceptionTrapping.EH_Exceptions
Imports CD_Reports.pt_Retrieve
Imports CD_Reports_MiddleTier
Public Class pt_Winforms
    Public Sub Assign_SourceQuery_To_dgvMonthlyBenchmarks()

        Dim ptd As New pt_Data.GetSourceQueriesForDGVsAndCombos
        Dim dgv As DataGridView = frmMain.dgvMonthlyBenchmarks

        dgv.DataSource = ptd.Get_SourceQuery_For_dgvMonthlyBenchmarks()
        Enable_Or_Not_Editing_Of_DGV(dgv, False)
        SetValueColumnProperties()



    End Sub
    Public Sub CALL_PROCEDURE_CreateList()

        Dim de As New CD_Reports_MiddleTier.mt_Data
        Dim FormChoices As Boolean()
        Dim rcu As New ReportComponentUtilities
        Dim RComponents As List(Of IReportComponent)

        de.DELETE_AllCallListTableRecords()
        FormChoices = RETRIEVE_ArrayOfSelectedReportComponentsFromFrmMain()
        RComponents = rcu.GetReportComponentArray(FormChoices)

        de.CALL_PROCEDURE_iterateThroughComponents(RComponents)

    End Sub
    Public Sub Assign_SourceQuery_To_cmbMonths(c As ComboBox)

        Dim ptd As New pt_Data.GetSourceQueriesForDGVsAndCombos

        c.DisplayMember = "Legible_Date"
        c.ValueMember = "MonthID"
        c.DataSource = ptd.Get_SourceQuery_For_cmbMonths

    End Sub
    Private Sub SetValueColumnProperties()

        Dim dgv As DataGridView = frmMain.dgvMonthlyBenchmarks

        With dgv

            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

            .Columns(0).HeaderText = "ID"
            .Columns(0).Width = 30
            .Columns(0).ValueType = GetType(Integer)
            .Columns(0).Visible = False
            .Columns(0).Name = "MonthlyBenchmarkID"

            .Columns(1).HeaderText = "Indicator"
            .Columns(1).Width = 360
            .Columns(1).Visible = True
            .Columns(1).ReadOnly = True
            .Columns(1).DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .Columns(1).Name = "Indicator"

            .Columns(2).HeaderText = "MonthID"
            .Columns(2).Width = 30
            .Columns(2).ValueType = GetType(Integer)
            .Columns(2).Visible = False

            .Columns(3).HeaderText = "IndicatorID"
            .Columns(3).Width = 300
            .Columns(3).ValueType = GetType(Integer)
            .Columns(3).Visible = False

            .Columns(4).HeaderText = "Actual"
            .Columns(4).Width = 65
            .Columns(4).ValueType = GetType(Integer)
            .Columns(4).Visible = True
            .Columns(4).Name = "PerformanceValue"

            .Columns(5).HeaderText = "Target"
            .Columns(5).Width = 65
            .Columns(5).ValueType = GetType(Integer)
            .Columns(5).ReadOnly = True
            .Columns(5).Visible = True

            .Columns(6).HeaderText = "data_enterer"
            .Columns(6).Width = 100
            .Columns(6).ValueType = GetType(String)
            .Columns(6).Visible = False

            .Columns(7).HeaderText = "insertion_date"
            .Columns(7).Width = 100
            .Columns(7).ValueType = GetType(Date)
            .Columns(7).Visible = False

            .Columns(8).HeaderText = "Notes"
            .Columns(8).Width = 200
            .Columns(8).ValueType = GetType(String)
            .Columns(8).Visible = True
            .Columns(8).Name = "Details"

            .Columns(9).HeaderText = "Internal?"
            .Columns(9).Width = 70
            .Columns(9).ValueType = GetType(Boolean)
            .Columns(9).Visible = True
            .Columns(9).ReadOnly = True
            .Columns(9).Name = "bOptional"

        End With


    End Sub
    Public Sub Enable_Toolstrip()

        Try

            Dim tObj As ToolStripItem
            For Each tObj In frmMain.tlsToolStrip.Items
                tObj.Enabled = True
            Next

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "The toolstrip cannot be enabled at this time.")
        End Try

    End Sub
    Public Sub Enable_Or_Not_Editing_Of_DGV(dgv As DataGridView, bolEnable As Boolean)
        Try

            dgv.AllowUserToAddRows = bolEnable
            dgv.AllowUserToDeleteRows = bolEnable

        Catch ex As Exception
            Dim HandleStandardException As New EH_ExceptionTrapping.EH_Exceptions.Exception_Handlers.StandardHandler
            HandleStandardException.HANDLE_EXCEPTION(ex, True, "Editing cannot be enabled at this time.")
        End Try
    End Sub

End Class
