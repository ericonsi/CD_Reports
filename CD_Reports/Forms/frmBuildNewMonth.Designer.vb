<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuildNewMonth
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuildNewMonth))
        Me.CD_ReportsDataSet = New CD_Reports.CD_ReportsDataSet()
        Me.TblDepartmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblDepartmentsTableAdapter = New CD_Reports.CD_ReportsDataSetTableAdapters.tblDepartmentsTableAdapter()
        Me.TableAdapterManager = New CD_Reports.CD_ReportsDataSetTableAdapters.TableAdapterManager()
        Me.TblIndicatorsTableAdapter = New CD_Reports.CD_ReportsDataSetTableAdapters.tblIndicatorsTableAdapter()
        Me.TblProgramsTableAdapter = New CD_Reports.CD_ReportsDataSetTableAdapters.tblProgramsTableAdapter()
        Me.TblDepartmentsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblDepartmentsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblProgramsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblIndicatorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKtblDepartmentstblProgramsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKtblIndicatortblProgramsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblDepartmentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TblProgramsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FKtblIndicatortblProgramsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProgramsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnBuildMonth = New System.Windows.Forms.Button()
        Me.cmbMonths = New System.Windows.Forms.ComboBox()
        Me.tblIndicatorsDataGridView = New System.Windows.Forms.DataGridView()
        Me.FKtblMonthlyBenchmarkstblIndicatorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblMonthlyBenchmarksTableAdapter = New CD_Reports.CD_ReportsDataSetTableAdapters.tblMonthlyBenchmarksTableAdapter()
        Me.IndicatorIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndicatorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncludeDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProgramIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataentererDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UpdatedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BOptionalDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ContractDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContractYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContractNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManagerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartMonthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DashboardDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IndicatorOrderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PercentageOrAverageDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.CD_ReportsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDepartmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDepartmentsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblDepartmentsBindingNavigator.SuspendLayout()
        CType(Me.TblProgramsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblIndicatorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKtblDepartmentstblProgramsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKtblIndicatortblProgramsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDepartmentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProgramsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKtblIndicatortblProgramsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProgramsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblIndicatorsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKtblMonthlyBenchmarkstblIndicatorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CD_ReportsDataSet
        '
        Me.CD_ReportsDataSet.DataSetName = "CD_ReportsDataSet"
        Me.CD_ReportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblDepartmentsBindingSource
        '
        Me.TblDepartmentsBindingSource.DataMember = "tblDepartments"
        Me.TblDepartmentsBindingSource.DataSource = Me.CD_ReportsDataSet
        '
        'TblDepartmentsTableAdapter
        '
        Me.TblDepartmentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblDepartmentsTableAdapter = Me.TblDepartmentsTableAdapter
        Me.TableAdapterManager.tblIndicatorGroupIndsTableAdapter = Nothing
        Me.TableAdapterManager.tblIndicatorGroupsTableAdapter = Nothing
        Me.TableAdapterManager.tblIndicatorsTableAdapter = Me.TblIndicatorsTableAdapter
        Me.TableAdapterManager.tblMonthlyBenchmarksTableAdapter = Nothing
        Me.TableAdapterManager.tblMonths1TableAdapter = Nothing
        Me.TableAdapterManager.tblMonthsTableAdapter = Nothing
        Me.TableAdapterManager.tblProgramsTableAdapter = Me.TblProgramsTableAdapter
        Me.TableAdapterManager.tblSettingsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CD_Reports.CD_ReportsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblIndicatorsTableAdapter
        '
        Me.TblIndicatorsTableAdapter.ClearBeforeFill = True
        '
        'TblProgramsTableAdapter
        '
        Me.TblProgramsTableAdapter.ClearBeforeFill = True
        '
        'TblDepartmentsBindingNavigator
        '
        Me.TblDepartmentsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblDepartmentsBindingNavigator.BindingSource = Me.TblDepartmentsBindingSource
        Me.TblDepartmentsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblDepartmentsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblDepartmentsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblDepartmentsBindingNavigatorSaveItem})
        Me.TblDepartmentsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblDepartmentsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblDepartmentsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblDepartmentsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblDepartmentsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblDepartmentsBindingNavigator.Name = "TblDepartmentsBindingNavigator"
        Me.TblDepartmentsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblDepartmentsBindingNavigator.Size = New System.Drawing.Size(874, 25)
        Me.TblDepartmentsBindingNavigator.TabIndex = 0
        Me.TblDepartmentsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TblDepartmentsBindingNavigatorSaveItem
        '
        Me.TblDepartmentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblDepartmentsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblDepartmentsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblDepartmentsBindingNavigatorSaveItem.Name = "TblDepartmentsBindingNavigatorSaveItem"
        Me.TblDepartmentsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblDepartmentsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblProgramsBindingSource
        '
        Me.TblProgramsBindingSource.DataMember = "tblPrograms"
        Me.TblProgramsBindingSource.DataSource = Me.CD_ReportsDataSet
        '
        'TblIndicatorsBindingSource
        '
        Me.TblIndicatorsBindingSource.DataMember = "tblIndicators"
        Me.TblIndicatorsBindingSource.DataSource = Me.CD_ReportsDataSet
        '
        'FKtblDepartmentstblProgramsBindingSource
        '
        Me.FKtblDepartmentstblProgramsBindingSource.DataMember = "FK_tblDepartments_tblPrograms"
        Me.FKtblDepartmentstblProgramsBindingSource.DataSource = Me.TblDepartmentsBindingSource
        '
        'FKtblIndicatortblProgramsBindingSource
        '
        Me.FKtblIndicatortblProgramsBindingSource.DataMember = "FK_tblIndicator_tblPrograms"
        Me.FKtblIndicatortblProgramsBindingSource.DataSource = Me.TblProgramsBindingSource
        '
        'TblDepartmentsDataGridView
        '
        Me.TblDepartmentsDataGridView.AutoGenerateColumns = False
        Me.TblDepartmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblDepartmentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewImageColumn1})
        Me.TblDepartmentsDataGridView.DataSource = Me.TblDepartmentsBindingSource
        Me.TblDepartmentsDataGridView.Location = New System.Drawing.Point(12, 78)
        Me.TblDepartmentsDataGridView.Name = "TblDepartmentsDataGridView"
        Me.TblDepartmentsDataGridView.Size = New System.Drawing.Size(361, 181)
        Me.TblDepartmentsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DepartmentID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "DepartmentID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Department"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Department"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Details"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Details"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "include"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "include"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "SSMA_TimeStamp"
        Me.DataGridViewImageColumn1.HeaderText = "SSMA_TimeStamp"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Visible = False
        '
        'TblProgramsDataGridView
        '
        Me.TblProgramsDataGridView.AutoGenerateColumns = False
        Me.TblProgramsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblProgramsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.TblProgramsDataGridView.DataSource = Me.FKtblDepartmentstblProgramsBindingSource
        Me.TblProgramsDataGridView.Location = New System.Drawing.Point(379, 78)
        Me.TblProgramsDataGridView.Name = "TblProgramsDataGridView"
        Me.TblProgramsDataGridView.Size = New System.Drawing.Size(476, 181)
        Me.TblProgramsDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ProgramID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ProgramID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Program"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Program"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DepartmentID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DepartmentID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Include"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Include"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Fiscal_Start"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fiscal_Start"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Fiscal_End"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fiscal_End"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'FKtblIndicatortblProgramsBindingSource1
        '
        Me.FKtblIndicatortblProgramsBindingSource1.DataMember = "FK_tblIndicator_tblPrograms"
        Me.FKtblIndicatortblProgramsBindingSource1.DataSource = Me.FKtblDepartmentstblProgramsBindingSource
        '
        'TblProgramsBindingSource1
        '
        Me.TblProgramsBindingSource1.DataMember = "FK_tblDepartments_tblPrograms"
        Me.TblProgramsBindingSource1.DataSource = Me.TblDepartmentsBindingSource
        '
        'btnBuildMonth
        '
        Me.btnBuildMonth.Location = New System.Drawing.Point(12, 38)
        Me.btnBuildMonth.Name = "btnBuildMonth"
        Me.btnBuildMonth.Size = New System.Drawing.Size(75, 23)
        Me.btnBuildMonth.TabIndex = 5
        Me.btnBuildMonth.Text = "Build Month"
        Me.btnBuildMonth.UseVisualStyleBackColor = True
        '
        'cmbMonths
        '
        Me.cmbMonths.FormattingEnabled = True
        Me.cmbMonths.Location = New System.Drawing.Point(93, 40)
        Me.cmbMonths.Name = "cmbMonths"
        Me.cmbMonths.Size = New System.Drawing.Size(121, 21)
        Me.cmbMonths.TabIndex = 6
        '
        'tblIndicatorsDataGridView
        '
        Me.tblIndicatorsDataGridView.AutoGenerateColumns = False
        Me.tblIndicatorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblIndicatorsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IndicatorIDDataGridViewTextBoxColumn, Me.IndicatorDataGridViewTextBoxColumn, Me.ValueDataGridViewTextBoxColumn, Me.NotesDataGridViewTextBoxColumn, Me.IncludeDataGridViewCheckBoxColumn, Me.ProgramIDDataGridViewTextBoxColumn, Me.ProjectedDataGridViewTextBoxColumn, Me.DataentererDataGridViewTextBoxColumn, Me.UpdatedateDataGridViewTextBoxColumn, Me.BOptionalDataGridViewCheckBoxColumn, Me.ContractDataGridViewTextBoxColumn, Me.ContractYearDataGridViewTextBoxColumn, Me.ContractNumberDataGridViewTextBoxColumn, Me.ManagerDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.StartMonthDataGridViewTextBoxColumn, Me.DashboardDataGridViewCheckBoxColumn, Me.IndicatorOrderDataGridViewTextBoxColumn, Me.PercentageOrAverageDataGridViewCheckBoxColumn})
        Me.tblIndicatorsDataGridView.DataSource = Me.FKtblIndicatortblProgramsBindingSource
        Me.tblIndicatorsDataGridView.Location = New System.Drawing.Point(13, 265)
        Me.tblIndicatorsDataGridView.Name = "tblIndicatorsDataGridView"
        Me.tblIndicatorsDataGridView.Size = New System.Drawing.Size(842, 150)
        Me.tblIndicatorsDataGridView.TabIndex = 7
        '
        'FKtblMonthlyBenchmarkstblIndicatorsBindingSource
        '
        Me.FKtblMonthlyBenchmarkstblIndicatorsBindingSource.DataMember = "FK_tblMonthlyBenchmarks_tblIndicators"
        Me.FKtblMonthlyBenchmarkstblIndicatorsBindingSource.DataSource = Me.FKtblIndicatortblProgramsBindingSource
        '
        'TblMonthlyBenchmarksTableAdapter
        '
        Me.TblMonthlyBenchmarksTableAdapter.ClearBeforeFill = True
        '
        'IndicatorIDDataGridViewTextBoxColumn
        '
        Me.IndicatorIDDataGridViewTextBoxColumn.DataPropertyName = "IndicatorID"
        Me.IndicatorIDDataGridViewTextBoxColumn.HeaderText = "IndicatorID"
        Me.IndicatorIDDataGridViewTextBoxColumn.Name = "IndicatorIDDataGridViewTextBoxColumn"
        Me.IndicatorIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IndicatorDataGridViewTextBoxColumn
        '
        Me.IndicatorDataGridViewTextBoxColumn.DataPropertyName = "Indicator"
        Me.IndicatorDataGridViewTextBoxColumn.HeaderText = "Indicator"
        Me.IndicatorDataGridViewTextBoxColumn.Name = "IndicatorDataGridViewTextBoxColumn"
        '
        'ValueDataGridViewTextBoxColumn
        '
        Me.ValueDataGridViewTextBoxColumn.DataPropertyName = "Value"
        Me.ValueDataGridViewTextBoxColumn.HeaderText = "Value"
        Me.ValueDataGridViewTextBoxColumn.Name = "ValueDataGridViewTextBoxColumn"
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "Notes"
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "Notes"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        '
        'IncludeDataGridViewCheckBoxColumn
        '
        Me.IncludeDataGridViewCheckBoxColumn.DataPropertyName = "Include"
        Me.IncludeDataGridViewCheckBoxColumn.HeaderText = "Include"
        Me.IncludeDataGridViewCheckBoxColumn.Name = "IncludeDataGridViewCheckBoxColumn"
        '
        'ProgramIDDataGridViewTextBoxColumn
        '
        Me.ProgramIDDataGridViewTextBoxColumn.DataPropertyName = "ProgramID"
        Me.ProgramIDDataGridViewTextBoxColumn.HeaderText = "ProgramID"
        Me.ProgramIDDataGridViewTextBoxColumn.Name = "ProgramIDDataGridViewTextBoxColumn"
        '
        'ProjectedDataGridViewTextBoxColumn
        '
        Me.ProjectedDataGridViewTextBoxColumn.DataPropertyName = "Projected"
        Me.ProjectedDataGridViewTextBoxColumn.HeaderText = "Projected"
        Me.ProjectedDataGridViewTextBoxColumn.Name = "ProjectedDataGridViewTextBoxColumn"
        '
        'DataentererDataGridViewTextBoxColumn
        '
        Me.DataentererDataGridViewTextBoxColumn.DataPropertyName = "data_enterer"
        Me.DataentererDataGridViewTextBoxColumn.HeaderText = "data_enterer"
        Me.DataentererDataGridViewTextBoxColumn.Name = "DataentererDataGridViewTextBoxColumn"
        '
        'UpdatedateDataGridViewTextBoxColumn
        '
        Me.UpdatedateDataGridViewTextBoxColumn.DataPropertyName = "update_date"
        Me.UpdatedateDataGridViewTextBoxColumn.HeaderText = "update_date"
        Me.UpdatedateDataGridViewTextBoxColumn.Name = "UpdatedateDataGridViewTextBoxColumn"
        '
        'BOptionalDataGridViewCheckBoxColumn
        '
        Me.BOptionalDataGridViewCheckBoxColumn.DataPropertyName = "bOptional"
        Me.BOptionalDataGridViewCheckBoxColumn.HeaderText = "bOptional"
        Me.BOptionalDataGridViewCheckBoxColumn.Name = "BOptionalDataGridViewCheckBoxColumn"
        '
        'ContractDataGridViewTextBoxColumn
        '
        Me.ContractDataGridViewTextBoxColumn.DataPropertyName = "Contract"
        Me.ContractDataGridViewTextBoxColumn.HeaderText = "Contract"
        Me.ContractDataGridViewTextBoxColumn.Name = "ContractDataGridViewTextBoxColumn"
        '
        'ContractYearDataGridViewTextBoxColumn
        '
        Me.ContractYearDataGridViewTextBoxColumn.DataPropertyName = "ContractYear"
        Me.ContractYearDataGridViewTextBoxColumn.HeaderText = "ContractYear"
        Me.ContractYearDataGridViewTextBoxColumn.Name = "ContractYearDataGridViewTextBoxColumn"
        '
        'ContractNumberDataGridViewTextBoxColumn
        '
        Me.ContractNumberDataGridViewTextBoxColumn.DataPropertyName = "ContractNumber"
        Me.ContractNumberDataGridViewTextBoxColumn.HeaderText = "ContractNumber"
        Me.ContractNumberDataGridViewTextBoxColumn.Name = "ContractNumberDataGridViewTextBoxColumn"
        '
        'ManagerDataGridViewTextBoxColumn
        '
        Me.ManagerDataGridViewTextBoxColumn.DataPropertyName = "Manager"
        Me.ManagerDataGridViewTextBoxColumn.HeaderText = "Manager"
        Me.ManagerDataGridViewTextBoxColumn.Name = "ManagerDataGridViewTextBoxColumn"
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "Location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        '
        'StartMonthDataGridViewTextBoxColumn
        '
        Me.StartMonthDataGridViewTextBoxColumn.DataPropertyName = "StartMonth"
        Me.StartMonthDataGridViewTextBoxColumn.HeaderText = "StartMonth"
        Me.StartMonthDataGridViewTextBoxColumn.Name = "StartMonthDataGridViewTextBoxColumn"
        '
        'DashboardDataGridViewCheckBoxColumn
        '
        Me.DashboardDataGridViewCheckBoxColumn.DataPropertyName = "Dashboard"
        Me.DashboardDataGridViewCheckBoxColumn.HeaderText = "Dashboard"
        Me.DashboardDataGridViewCheckBoxColumn.Name = "DashboardDataGridViewCheckBoxColumn"
        '
        'IndicatorOrderDataGridViewTextBoxColumn
        '
        Me.IndicatorOrderDataGridViewTextBoxColumn.DataPropertyName = "IndicatorOrder"
        Me.IndicatorOrderDataGridViewTextBoxColumn.HeaderText = "IndicatorOrder"
        Me.IndicatorOrderDataGridViewTextBoxColumn.Name = "IndicatorOrderDataGridViewTextBoxColumn"
        '
        'PercentageOrAverageDataGridViewCheckBoxColumn
        '
        Me.PercentageOrAverageDataGridViewCheckBoxColumn.DataPropertyName = "PercentageOrAverage"
        Me.PercentageOrAverageDataGridViewCheckBoxColumn.HeaderText = "PercentageOrAverage"
        Me.PercentageOrAverageDataGridViewCheckBoxColumn.Name = "PercentageOrAverageDataGridViewCheckBoxColumn"
        '
        'frmBuildNewMonth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(874, 717)
        Me.Controls.Add(Me.tblIndicatorsDataGridView)
        Me.Controls.Add(Me.cmbMonths)
        Me.Controls.Add(Me.btnBuildMonth)
        Me.Controls.Add(Me.TblProgramsDataGridView)
        Me.Controls.Add(Me.TblDepartmentsDataGridView)
        Me.Controls.Add(Me.TblDepartmentsBindingNavigator)
        Me.Name = "frmBuildNewMonth"
        Me.Text = "frmBuildNewMonth"
        CType(Me.CD_ReportsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDepartmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDepartmentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblDepartmentsBindingNavigator.ResumeLayout(False)
        Me.TblDepartmentsBindingNavigator.PerformLayout()
        CType(Me.TblProgramsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblIndicatorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKtblDepartmentstblProgramsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKtblIndicatortblProgramsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDepartmentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProgramsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKtblIndicatortblProgramsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProgramsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblIndicatorsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKtblMonthlyBenchmarkstblIndicatorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CD_ReportsDataSet As CD_ReportsDataSet
    Friend WithEvents TblDepartmentsBindingSource As BindingSource
    Friend WithEvents TblDepartmentsTableAdapter As CD_ReportsDataSetTableAdapters.tblDepartmentsTableAdapter
    Friend WithEvents TableAdapterManager As CD_ReportsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblDepartmentsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TblDepartmentsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TblProgramsTableAdapter As CD_ReportsDataSetTableAdapters.tblProgramsTableAdapter
    Friend WithEvents TblProgramsBindingSource As BindingSource
    Friend WithEvents TblIndicatorsTableAdapter As CD_ReportsDataSetTableAdapters.tblIndicatorsTableAdapter
    Friend WithEvents TblIndicatorsBindingSource As BindingSource
    Friend WithEvents FKtblDepartmentstblProgramsBindingSource As BindingSource
    Friend WithEvents FKtblIndicatortblProgramsBindingSource As BindingSource
    Friend WithEvents TblDepartmentsDataGridView As DataGridView
    Friend WithEvents TblProgramsDataGridView As DataGridView
    Friend WithEvents FKtblIndicatortblProgramsBindingSource1 As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents TblProgramsBindingSource1 As BindingSource
    Friend WithEvents btnBuildMonth As Button
    Friend WithEvents cmbMonths As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents tblIndicatorsDataGridView As DataGridView
    Friend WithEvents FKtblMonthlyBenchmarkstblIndicatorsBindingSource As BindingSource
    Friend WithEvents TblMonthlyBenchmarksTableAdapter As CD_ReportsDataSetTableAdapters.tblMonthlyBenchmarksTableAdapter
    Friend WithEvents IndicatorIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndicatorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IncludeDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ProgramIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProjectedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataentererDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UpdatedateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BOptionalDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ContractDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContractYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContractNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManagerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartMonthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DashboardDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IndicatorOrderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PercentageOrAverageDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
