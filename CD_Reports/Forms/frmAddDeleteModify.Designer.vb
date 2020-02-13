<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddDeleteModify
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddDeleteModify))
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
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblIndicatorsDataGridView = New System.Windows.Forms.DataGridView()
        Me.FKtblIndicatortblProgramsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProgramsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnBuildMonth = New System.Windows.Forms.Button()
        Me.cmbMonths = New System.Windows.Forms.ComboBox()
        Me.radAdd = New System.Windows.Forms.RadioButton()
        Me.radDelete = New System.Windows.Forms.RadioButton()
        Me.radModify = New System.Windows.Forms.RadioButton()
        Me.gbxAction = New System.Windows.Forms.GroupBox()
        Me.gbxTimeFrame = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTimeFrameEndMonth = New System.Windows.Forms.TextBox()
        Me.txtTimeFrameStartMonth = New System.Windows.Forms.TextBox()
        Me.radAllMonths = New System.Windows.Forms.RadioButton()
        Me.radCustom = New System.Windows.Forms.RadioButton()
        Me.Indicator = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Include = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Projected = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bOptional = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Dashboard = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IndicatorOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PercentageOrAverage = New System.Windows.Forms.DataGridViewCheckBoxColumn()
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
        CType(Me.TblIndicatorsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKtblIndicatortblProgramsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProgramsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxAction.SuspendLayout()
        Me.gbxTimeFrame.SuspendLayout()
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
        Me.TblDepartmentsBindingNavigator.Size = New System.Drawing.Size(933, 25)
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
        Me.TblDepartmentsDataGridView.Location = New System.Drawing.Point(12, 113)
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
        Me.TblProgramsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewImageColumn2, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.TblProgramsDataGridView.DataSource = Me.FKtblDepartmentstblProgramsBindingSource
        Me.TblProgramsDataGridView.Location = New System.Drawing.Point(379, 113)
        Me.TblProgramsDataGridView.Name = "TblProgramsDataGridView"
        Me.TblProgramsDataGridView.Size = New System.Drawing.Size(530, 181)
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
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.DataPropertyName = "SSMA_TimeStamp"
        Me.DataGridViewImageColumn2.HeaderText = "SSMA_TimeStamp"
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Visible = False
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
        'TblIndicatorsDataGridView
        '
        Me.TblIndicatorsDataGridView.AutoGenerateColumns = False
        Me.TblIndicatorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblIndicatorsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Indicator, Me.Include, Me.Projected, Me.Notes, Me.bOptional, Me.Dashboard, Me.IndicatorOrder, Me.PercentageOrAverage})
        Me.TblIndicatorsDataGridView.DataSource = Me.FKtblIndicatortblProgramsBindingSource1
        Me.TblIndicatorsDataGridView.Location = New System.Drawing.Point(12, 300)
        Me.TblIndicatorsDataGridView.Name = "TblIndicatorsDataGridView"
        Me.TblIndicatorsDataGridView.Size = New System.Drawing.Size(897, 367)
        Me.TblIndicatorsDataGridView.TabIndex = 3
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
        Me.btnBuildMonth.Location = New System.Drawing.Point(12, 673)
        Me.btnBuildMonth.Name = "btnBuildMonth"
        Me.btnBuildMonth.Size = New System.Drawing.Size(75, 23)
        Me.btnBuildMonth.TabIndex = 5
        Me.btnBuildMonth.Text = "Build Month"
        Me.btnBuildMonth.UseVisualStyleBackColor = True
        '
        'cmbMonths
        '
        Me.cmbMonths.FormattingEnabled = True
        Me.cmbMonths.Location = New System.Drawing.Point(93, 675)
        Me.cmbMonths.Name = "cmbMonths"
        Me.cmbMonths.Size = New System.Drawing.Size(121, 21)
        Me.cmbMonths.TabIndex = 6
        '
        'radAdd
        '
        Me.radAdd.AutoSize = True
        Me.radAdd.Location = New System.Drawing.Point(130, 19)
        Me.radAdd.Name = "radAdd"
        Me.radAdd.Size = New System.Drawing.Size(44, 17)
        Me.radAdd.TabIndex = 0
        Me.radAdd.TabStop = True
        Me.radAdd.Text = "Add"
        Me.radAdd.UseVisualStyleBackColor = True
        '
        'radDelete
        '
        Me.radDelete.AutoSize = True
        Me.radDelete.Location = New System.Drawing.Point(68, 19)
        Me.radDelete.Name = "radDelete"
        Me.radDelete.Size = New System.Drawing.Size(56, 17)
        Me.radDelete.TabIndex = 1
        Me.radDelete.Text = "Delete"
        Me.radDelete.UseVisualStyleBackColor = True
        '
        'radModify
        '
        Me.radModify.AutoSize = True
        Me.radModify.Checked = True
        Me.radModify.Location = New System.Drawing.Point(6, 19)
        Me.radModify.Name = "radModify"
        Me.radModify.Size = New System.Drawing.Size(56, 17)
        Me.radModify.TabIndex = 2
        Me.radModify.TabStop = True
        Me.radModify.Text = "Modify"
        Me.radModify.UseVisualStyleBackColor = True
        '
        'gbxAction
        '
        Me.gbxAction.BackColor = System.Drawing.Color.DarkKhaki
        Me.gbxAction.Controls.Add(Me.radModify)
        Me.gbxAction.Controls.Add(Me.radAdd)
        Me.gbxAction.Controls.Add(Me.radDelete)
        Me.gbxAction.Location = New System.Drawing.Point(12, 42)
        Me.gbxAction.Name = "gbxAction"
        Me.gbxAction.Size = New System.Drawing.Size(199, 50)
        Me.gbxAction.TabIndex = 7
        Me.gbxAction.TabStop = False
        Me.gbxAction.Text = "Action"
        '
        'gbxTimeFrame
        '
        Me.gbxTimeFrame.BackColor = System.Drawing.Color.DarkKhaki
        Me.gbxTimeFrame.Controls.Add(Me.Label1)
        Me.gbxTimeFrame.Controls.Add(Me.txtTimeFrameEndMonth)
        Me.gbxTimeFrame.Controls.Add(Me.txtTimeFrameStartMonth)
        Me.gbxTimeFrame.Controls.Add(Me.radAllMonths)
        Me.gbxTimeFrame.Controls.Add(Me.radCustom)
        Me.gbxTimeFrame.Location = New System.Drawing.Point(217, 42)
        Me.gbxTimeFrame.Name = "gbxTimeFrame"
        Me.gbxTimeFrame.Size = New System.Drawing.Size(334, 50)
        Me.gbxTimeFrame.TabIndex = 9
        Me.gbxTimeFrame.TabStop = False
        Me.gbxTimeFrame.Text = "Time Frame"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(242, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "to"
        '
        'txtTimeFrameEndMonth
        '
        Me.txtTimeFrameEndMonth.Location = New System.Drawing.Point(264, 19)
        Me.txtTimeFrameEndMonth.Name = "txtTimeFrameEndMonth"
        Me.txtTimeFrameEndMonth.Size = New System.Drawing.Size(61, 20)
        Me.txtTimeFrameEndMonth.TabIndex = 3
        '
        'txtTimeFrameStartMonth
        '
        Me.txtTimeFrameStartMonth.Location = New System.Drawing.Point(175, 19)
        Me.txtTimeFrameStartMonth.Name = "txtTimeFrameStartMonth"
        Me.txtTimeFrameStartMonth.Size = New System.Drawing.Size(61, 20)
        Me.txtTimeFrameStartMonth.TabIndex = 2
        '
        'radAllMonths
        '
        Me.radAllMonths.AutoSize = True
        Me.radAllMonths.Checked = True
        Me.radAllMonths.Location = New System.Drawing.Point(17, 19)
        Me.radAllMonths.Name = "radAllMonths"
        Me.radAllMonths.Size = New System.Drawing.Size(74, 17)
        Me.radAllMonths.TabIndex = 1
        Me.radAllMonths.TabStop = True
        Me.radAllMonths.Text = "All Months"
        Me.radAllMonths.UseVisualStyleBackColor = True
        '
        'radCustom
        '
        Me.radCustom.AutoSize = True
        Me.radCustom.Location = New System.Drawing.Point(105, 19)
        Me.radCustom.Name = "radCustom"
        Me.radCustom.Size = New System.Drawing.Size(63, 17)
        Me.radCustom.TabIndex = 0
        Me.radCustom.Text = "Custom:"
        Me.radCustom.UseVisualStyleBackColor = True
        '
        'Indicator
        '
        Me.Indicator.DataPropertyName = "Indicator"
        Me.Indicator.HeaderText = "Indicator"
        Me.Indicator.Name = "Indicator"
        Me.Indicator.Width = 350
        '
        'Include
        '
        Me.Include.DataPropertyName = "Include"
        Me.Include.HeaderText = "Include"
        Me.Include.Name = "Include"
        Me.Include.Width = 50
        '
        'Projected
        '
        Me.Projected.DataPropertyName = "Projected"
        Me.Projected.HeaderText = "Projected"
        Me.Projected.Name = "Projected"
        Me.Projected.Width = 75
        '
        'Notes
        '
        Me.Notes.DataPropertyName = "Notes"
        Me.Notes.HeaderText = "Notes"
        Me.Notes.Name = "Notes"
        Me.Notes.Width = 150
        '
        'bOptional
        '
        Me.bOptional.DataPropertyName = "bOptional"
        Me.bOptional.HeaderText = "bOptional"
        Me.bOptional.Name = "bOptional"
        Me.bOptional.Width = 50
        '
        'Dashboard
        '
        Me.Dashboard.DataPropertyName = "Dashboard"
        Me.Dashboard.HeaderText = "Dashboard"
        Me.Dashboard.Name = "Dashboard"
        Me.Dashboard.Width = 50
        '
        'IndicatorOrder
        '
        Me.IndicatorOrder.DataPropertyName = "IndicatorOrder"
        Me.IndicatorOrder.HeaderText = "IndicatorOrder"
        Me.IndicatorOrder.Name = "IndicatorOrder"
        Me.IndicatorOrder.Width = 50
        '
        'PercentageOrAverage
        '
        Me.PercentageOrAverage.DataPropertyName = "PercentageOrAverage"
        Me.PercentageOrAverage.HeaderText = "PercentageOrAverage"
        Me.PercentageOrAverage.Name = "PercentageOrAverage"
        Me.PercentageOrAverage.Width = 50
        '
        'frmAddDeleteModify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(933, 717)
        Me.Controls.Add(Me.gbxTimeFrame)
        Me.Controls.Add(Me.gbxAction)
        Me.Controls.Add(Me.cmbMonths)
        Me.Controls.Add(Me.btnBuildMonth)
        Me.Controls.Add(Me.TblIndicatorsDataGridView)
        Me.Controls.Add(Me.TblProgramsDataGridView)
        Me.Controls.Add(Me.TblDepartmentsDataGridView)
        Me.Controls.Add(Me.TblDepartmentsBindingNavigator)
        Me.Name = "frmAddDeleteModify"
        Me.Text = "frmAddDeleteModify"
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
        CType(Me.TblIndicatorsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKtblIndicatortblProgramsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProgramsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxAction.ResumeLayout(False)
        Me.gbxAction.PerformLayout()
        Me.gbxTimeFrame.ResumeLayout(False)
        Me.gbxTimeFrame.PerformLayout()
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
    Friend WithEvents TblIndicatorsDataGridView As DataGridView
    Friend WithEvents FKtblIndicatortblProgramsBindingSource1 As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents TblProgramsBindingSource1 As BindingSource
    Friend WithEvents btnBuildMonth As Button
    Friend WithEvents cmbMonths As ComboBox
    Friend WithEvents radAdd As RadioButton
    Friend WithEvents radDelete As RadioButton
    Friend WithEvents radModify As RadioButton
    Friend WithEvents gbxAction As GroupBox
    Friend WithEvents gbxTimeFrame As GroupBox
    Friend WithEvents radAllMonths As RadioButton
    Friend WithEvents radCustom As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTimeFrameEndMonth As TextBox
    Friend WithEvents txtTimeFrameStartMonth As TextBox
    Friend WithEvents Indicator As DataGridViewTextBoxColumn
    Friend WithEvents Include As DataGridViewCheckBoxColumn
    Friend WithEvents Projected As DataGridViewTextBoxColumn
    Friend WithEvents Notes As DataGridViewTextBoxColumn
    Friend WithEvents bOptional As DataGridViewCheckBoxColumn
    Friend WithEvents Dashboard As DataGridViewCheckBoxColumn
    Friend WithEvents IndicatorOrder As DataGridViewTextBoxColumn
    Friend WithEvents PercentageOrAverage As DataGridViewCheckBoxColumn
End Class
