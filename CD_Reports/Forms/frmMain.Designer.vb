<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TblMonthsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CD_ReportsDataSet = New CD_Reports.CD_ReportsDataSet()
        Me.TblDepartmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProgramsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvMonthlyBenchmarks = New System.Windows.Forms.DataGridView()
        Me.TblMonthlyBenchmarksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblMonthsTableAdapter = New CD_Reports.CD_ReportsDataSetTableAdapters.tblMonthsTableAdapter()
        Me.TableAdapterManager = New CD_Reports.CD_ReportsDataSetTableAdapters.TableAdapterManager()
        Me.TblDepartmentsTableAdapter = New CD_Reports.CD_ReportsDataSetTableAdapters.tblDepartmentsTableAdapter()
        Me.TblMonthlyBenchmarksTableAdapter = New CD_Reports.CD_ReportsDataSetTableAdapters.tblMonthlyBenchmarksTableAdapter()
        Me.TblProgramsTableAdapter = New CD_Reports.CD_ReportsDataSetTableAdapters.tblProgramsTableAdapter()
        Me.btnShowIndicators = New System.Windows.Forms.Button()
        Me.TblMonths1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblMonths1TableAdapter = New CD_Reports.CD_ReportsDataSetTableAdapters.tblMonths1TableAdapter()
        Me.VwLegible_MonthBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwLegible_MonthTableAdapter = New CD_Reports.CD_ReportsDataSetTableAdapters.vwLegible_MonthTableAdapter()
        Me.tlsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.btnBoardReport = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.FKtblDepartmentstblProgramsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.dgvPrograms = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Program = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlIndicatorSelect = New System.Windows.Forms.Panel()
        Me.radSelectIndicators = New System.Windows.Forms.RadioButton()
        Me.radAllIndicators = New System.Windows.Forms.RadioButton()
        CType(Me.TblMonthsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CD_ReportsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDepartmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProgramsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMonthlyBenchmarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMonthlyBenchmarksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMonths1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwLegible_MonthBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlsToolStrip.SuspendLayout()
        CType(Me.FKtblDepartmentstblProgramsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPrograms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlIndicatorSelect.SuspendLayout()
        Me.SuspendLayout()
        '
        'TblMonthsBindingSource
        '
        Me.TblMonthsBindingSource.DataMember = "tblMonths"
        Me.TblMonthsBindingSource.DataSource = Me.CD_ReportsDataSet
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
        'TblProgramsBindingSource
        '
        Me.TblProgramsBindingSource.DataMember = "FK_tblDepartments_tblPrograms"
        Me.TblProgramsBindingSource.DataSource = Me.TblDepartmentsBindingSource
        '
        'dgvMonthlyBenchmarks
        '
        Me.dgvMonthlyBenchmarks.BackgroundColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMonthlyBenchmarks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMonthlyBenchmarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkKhaki
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMonthlyBenchmarks.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMonthlyBenchmarks.Location = New System.Drawing.Point(276, 40)
        Me.dgvMonthlyBenchmarks.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.dgvMonthlyBenchmarks.Name = "dgvMonthlyBenchmarks"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMonthlyBenchmarks.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMonthlyBenchmarks.RowTemplate.Height = 24
        Me.dgvMonthlyBenchmarks.Size = New System.Drawing.Size(800, 450)
        Me.dgvMonthlyBenchmarks.TabIndex = 5
        '
        'TblMonthlyBenchmarksBindingSource
        '
        Me.TblMonthlyBenchmarksBindingSource.DataMember = "tblMonthlyBenchmarks"
        Me.TblMonthlyBenchmarksBindingSource.DataSource = Me.CD_ReportsDataSet
        '
        'TblMonthsTableAdapter
        '
        Me.TblMonthsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblDepartmentsTableAdapter = Me.TblDepartmentsTableAdapter
        Me.TableAdapterManager.tblIndicatorGroupIndsTableAdapter = Nothing
        Me.TableAdapterManager.tblIndicatorGroupsTableAdapter = Nothing
        Me.TableAdapterManager.tblIndicatorsTableAdapter = Nothing
        Me.TableAdapterManager.tblMonthlyBenchmarksTableAdapter = Me.TblMonthlyBenchmarksTableAdapter
        Me.TableAdapterManager.tblMonths1TableAdapter = Nothing
        Me.TableAdapterManager.tblMonthsTableAdapter = Me.TblMonthsTableAdapter
        Me.TableAdapterManager.tblProgramsTableAdapter = Me.TblProgramsTableAdapter
        Me.TableAdapterManager.tblQuarterlyBoardReport_dataTableAdapter = Nothing
        Me.TableAdapterManager.tblQuarterlyBoardReport_definitionTableAdapter = Nothing
        Me.TableAdapterManager.tblSettingsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CD_Reports.CD_ReportsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblDepartmentsTableAdapter
        '
        Me.TblDepartmentsTableAdapter.ClearBeforeFill = True
        '
        'TblMonthlyBenchmarksTableAdapter
        '
        Me.TblMonthlyBenchmarksTableAdapter.ClearBeforeFill = True
        '
        'TblProgramsTableAdapter
        '
        Me.TblProgramsTableAdapter.ClearBeforeFill = True
        '
        'btnShowIndicators
        '
        Me.btnShowIndicators.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnShowIndicators.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowIndicators.Location = New System.Drawing.Point(13, 29)
        Me.btnShowIndicators.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnShowIndicators.Name = "btnShowIndicators"
        Me.btnShowIndicators.Size = New System.Drawing.Size(155, 29)
        Me.btnShowIndicators.TabIndex = 10
        Me.btnShowIndicators.Text = "Show Indicators"
        Me.btnShowIndicators.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnShowIndicators.UseVisualStyleBackColor = False
        '
        'TblMonths1BindingSource
        '
        Me.TblMonths1BindingSource.DataMember = "tblMonths1"
        Me.TblMonths1BindingSource.DataSource = Me.CD_ReportsDataSet
        '
        'TblMonths1TableAdapter
        '
        Me.TblMonths1TableAdapter.ClearBeforeFill = True
        '
        'VwLegible_MonthBindingSource
        '
        Me.VwLegible_MonthBindingSource.DataMember = "vwLegible_Month"
        Me.VwLegible_MonthBindingSource.DataSource = Me.CD_ReportsDataSet
        '
        'VwLegible_MonthTableAdapter
        '
        Me.VwLegible_MonthTableAdapter.ClearBeforeFill = True
        '
        'tlsToolStrip
        '
        Me.tlsToolStrip.AutoSize = False
        Me.tlsToolStrip.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlsToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tlsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton5, Me.ToolStripButton1, Me.ToolStripButton8, Me.ToolStripButton2, Me.btnBoardReport, Me.ToolStripButton4, Me.ToolStripButton7, Me.ToolStripButton6})
        Me.tlsToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.tlsToolStrip.Margin = New System.Windows.Forms.Padding(1)
        Me.tlsToolStrip.Name = "tlsToolStrip"
        Me.tlsToolStrip.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tlsToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tlsToolStrip.Size = New System.Drawing.Size(1089, 25)
        Me.tlsToolStrip.TabIndex = 16
        Me.tlsToolStrip.Text = "ToolStrip1"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.AutoSize = False
        Me.ToolStripButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(140, 25)
        Me.ToolStripButton5.Text = "Reports"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(140, 25)
        Me.ToolStripButton1.Text = "Help"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.AutoSize = False
        Me.ToolStripButton8.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton8.Enabled = False
        Me.ToolStripButton8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(140, 25)
        Me.ToolStripButton8.Text = "Enable Editing"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AutoSize = False
        Me.ToolStripButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Enabled = False
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(140, 25)
        Me.ToolStripButton2.Text = "Build Month"
        '
        'btnBoardReport
        '
        Me.btnBoardReport.AutoSize = False
        Me.btnBoardReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnBoardReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnBoardReport.Enabled = False
        Me.btnBoardReport.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBoardReport.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnBoardReport.Image = CType(resources.GetObject("btnBoardReport.Image"), System.Drawing.Image)
        Me.btnBoardReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBoardReport.Name = "btnBoardReport"
        Me.btnBoardReport.Size = New System.Drawing.Size(140, 25)
        Me.btnBoardReport.Text = "Board Report"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.AutoSize = False
        Me.ToolStripButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.Enabled = False
        Me.ToolStripButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(140, 25)
        Me.ToolStripButton4.Text = "Admin"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.AutoSize = False
        Me.ToolStripButton7.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton7.Enabled = False
        Me.ToolStripButton7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(140, 25)
        Me.ToolStripButton7.Text = "Settings"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.AutoSize = False
        Me.ToolStripButton6.BackColor = System.Drawing.Color.DarkKhaki
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton6.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(90, 20)
        Me.ToolStripButton6.Text = "Enable Toolbar"
        '
        'FKtblDepartmentstblProgramsBindingSource
        '
        Me.FKtblDepartmentstblProgramsBindingSource.DataMember = "FK_tblDepartments_tblPrograms"
        Me.FKtblDepartmentstblProgramsBindingSource.DataSource = Me.TblDepartmentsBindingSource
        Me.FKtblDepartmentstblProgramsBindingSource.Filter = "Include = 1"
        '
        'cmbMonth
        '
        Me.cmbMonth.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMonths1BindingSource, "Legible_Month", True))
        Me.cmbMonth.DataSource = Me.TblMonths1BindingSource
        Me.cmbMonth.DisplayMember = "Legible_Month"
        Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonth.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Location = New System.Drawing.Point(12, 40)
        Me.cmbMonth.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(250, 25)
        Me.cmbMonth.TabIndex = 15
        Me.cmbMonth.ValueMember = "MonthID"
        '
        'cmbDepartment
        '
        Me.cmbDepartment.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDepartmentsBindingSource, "Department", True))
        Me.cmbDepartment.DataSource = Me.TblDepartmentsBindingSource
        Me.cmbDepartment.DisplayMember = "Department"
        Me.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Location = New System.Drawing.Point(13, 70)
        Me.cmbDepartment.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(250, 25)
        Me.cmbDepartment.TabIndex = 3
        Me.cmbDepartment.ValueMember = "DepartmentID"
        '
        'dgvPrograms
        '
        Me.dgvPrograms.AllowUserToAddRows = False
        Me.dgvPrograms.AllowUserToDeleteRows = False
        Me.dgvPrograms.AutoGenerateColumns = False
        Me.dgvPrograms.BackgroundColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPrograms.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPrograms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrograms.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Program, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.dgvPrograms.DataSource = Me.FKtblDepartmentstblProgramsBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkKhaki
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPrograms.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPrograms.Location = New System.Drawing.Point(12, 99)
        Me.dgvPrograms.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.dgvPrograms.MultiSelect = False
        Me.dgvPrograms.Name = "dgvPrograms"
        Me.dgvPrograms.ReadOnly = True
        Me.dgvPrograms.RowHeadersWidth = 40
        Me.dgvPrograms.Size = New System.Drawing.Size(250, 391)
        Me.dgvPrograms.TabIndex = 16
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProgramID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ProgramID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 400
        '
        'Program
        '
        Me.Program.DataPropertyName = "Program"
        Me.Program.HeaderText = "Program"
        Me.Program.Name = "Program"
        Me.Program.ReadOnly = True
        Me.Program.Width = 250
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DepartmentID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DepartmentID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Include"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Include"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Visible = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "SSMA_TimeStamp"
        Me.DataGridViewImageColumn1.HeaderText = "SSMA_TimeStamp"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fiscal_Start"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fiscal_Start"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Fiscal_End"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fiscal_End"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 498)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Version 11113"
        '
        'pnlIndicatorSelect
        '
        Me.pnlIndicatorSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlIndicatorSelect.Controls.Add(Me.radSelectIndicators)
        Me.pnlIndicatorSelect.Controls.Add(Me.radAllIndicators)
        Me.pnlIndicatorSelect.Controls.Add(Me.btnShowIndicators)
        Me.pnlIndicatorSelect.Location = New System.Drawing.Point(598, 225)
        Me.pnlIndicatorSelect.Name = "pnlIndicatorSelect"
        Me.pnlIndicatorSelect.Size = New System.Drawing.Size(184, 93)
        Me.pnlIndicatorSelect.TabIndex = 19
        '
        'radSelectIndicators
        '
        Me.radSelectIndicators.AutoSize = True
        Me.radSelectIndicators.Checked = True
        Me.radSelectIndicators.Location = New System.Drawing.Point(40, 33)
        Me.radSelectIndicators.Name = "radSelectIndicators"
        Me.radSelectIndicators.Size = New System.Drawing.Size(116, 17)
        Me.radSelectIndicators.TabIndex = 1
        Me.radSelectIndicators.TabStop = True
        Me.radSelectIndicators.Text = "Selected Indicators"
        Me.radSelectIndicators.UseVisualStyleBackColor = True
        Me.radSelectIndicators.Visible = False
        '
        'radAllIndicators
        '
        Me.radAllIndicators.AutoSize = True
        Me.radAllIndicators.Location = New System.Drawing.Point(40, 14)
        Me.radAllIndicators.Name = "radAllIndicators"
        Me.radAllIndicators.Size = New System.Drawing.Size(85, 17)
        Me.radAllIndicators.TabIndex = 0
        Me.radAllIndicators.Text = "All Indicators"
        Me.radAllIndicators.UseVisualStyleBackColor = True
        Me.radAllIndicators.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1089, 528)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvPrograms)
        Me.Controls.Add(Me.tlsToolStrip)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.cmbDepartment)
        Me.Controls.Add(Me.pnlIndicatorSelect)
        Me.Controls.Add(Me.dgvMonthlyBenchmarks)
        Me.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.Name = "frmMain"
        Me.Text = "Service Targets Database"
        CType(Me.TblMonthsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CD_ReportsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDepartmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProgramsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMonthlyBenchmarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMonthlyBenchmarksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMonths1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwLegible_MonthBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlsToolStrip.ResumeLayout(False)
        Me.tlsToolStrip.PerformLayout()
        CType(Me.FKtblDepartmentstblProgramsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPrograms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlIndicatorSelect.ResumeLayout(False)
        Me.pnlIndicatorSelect.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CD_ReportsDataSet As CD_ReportsDataSet
    Friend WithEvents TblMonthsBindingSource As BindingSource
    Friend WithEvents TblMonthsTableAdapter As CD_ReportsDataSetTableAdapters.tblMonthsTableAdapter
    Friend WithEvents TableAdapterManager As CD_ReportsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblDepartmentsTableAdapter As CD_ReportsDataSetTableAdapters.tblDepartmentsTableAdapter
    Friend WithEvents TblDepartmentsBindingSource As BindingSource
    Friend WithEvents TblProgramsTableAdapter As CD_ReportsDataSetTableAdapters.tblProgramsTableAdapter
    Friend WithEvents TblProgramsBindingSource As BindingSource
    Friend WithEvents TblMonthlyBenchmarksTableAdapter As CD_ReportsDataSetTableAdapters.tblMonthlyBenchmarksTableAdapter
    Friend WithEvents TblMonthlyBenchmarksBindingSource As BindingSource
    Friend WithEvents dgvMonthlyBenchmarks As DataGridView
    Friend WithEvents btnShowIndicators As Button
    Friend WithEvents TblMonths1BindingSource As BindingSource
    Friend WithEvents TblMonths1TableAdapter As CD_ReportsDataSetTableAdapters.tblMonths1TableAdapter
    Friend WithEvents VwLegible_MonthBindingSource As BindingSource
    Friend WithEvents VwLegible_MonthTableAdapter As CD_ReportsDataSetTableAdapters.vwLegible_MonthTableAdapter
    Friend WithEvents tlsToolStrip As ToolStrip
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents btnBoardReport As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents FKtblDepartmentstblProgramsBindingSource As BindingSource
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents dgvPrograms As DataGridView
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Program As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlIndicatorSelect As Panel
    Friend WithEvents radSelectIndicators As RadioButton
    Friend WithEvents radAllIndicators As RadioButton
End Class
