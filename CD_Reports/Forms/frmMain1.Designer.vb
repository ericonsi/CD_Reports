<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain1
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
        Me.chk3MonthDue = New System.Windows.Forms.CheckBox()
        Me.chk6MonthDue = New System.Windows.Forms.CheckBox()
        Me.chkMDDue = New System.Windows.Forms.CheckBox()
        Me.chkOtherReminderInfo = New System.Windows.Forms.CheckBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.pnlReportComponents = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chk3MonthDue
        '
        Me.chk3MonthDue.AutoSize = True
        Me.chk3MonthDue.BackColor = System.Drawing.Color.LightBlue
        Me.chk3MonthDue.Location = New System.Drawing.Point(66, 82)
        Me.chk3MonthDue.Name = "chk3MonthDue"
        Me.chk3MonthDue.Size = New System.Drawing.Size(147, 17)
        Me.chk3MonthDue.TabIndex = 0
        Me.chk3MonthDue.Text = "Three Month Screen Due"
        Me.chk3MonthDue.UseVisualStyleBackColor = False
        '
        'chk6MonthDue
        '
        Me.chk6MonthDue.AutoSize = True
        Me.chk6MonthDue.BackColor = System.Drawing.Color.LightBlue
        Me.chk6MonthDue.Location = New System.Drawing.Point(66, 111)
        Me.chk6MonthDue.Name = "chk6MonthDue"
        Me.chk6MonthDue.Size = New System.Drawing.Size(133, 17)
        Me.chk6MonthDue.TabIndex = 1
        Me.chk6MonthDue.Text = "Six Month Screen Due"
        Me.chk6MonthDue.UseVisualStyleBackColor = False
        '
        'chkMDDue
        '
        Me.chkMDDue.AutoSize = True
        Me.chkMDDue.BackColor = System.Drawing.Color.LightBlue
        Me.chkMDDue.Location = New System.Drawing.Point(66, 140)
        Me.chkMDDue.Name = "chkMDDue"
        Me.chkMDDue.Size = New System.Drawing.Size(91, 17)
        Me.chkMDDue.TabIndex = 3
        Me.chkMDDue.Text = "MD Appt Due"
        Me.chkMDDue.UseVisualStyleBackColor = False
        '
        'chkOtherReminderInfo
        '
        Me.chkOtherReminderInfo.AutoSize = True
        Me.chkOtherReminderInfo.BackColor = System.Drawing.Color.LightBlue
        Me.chkOtherReminderInfo.Location = New System.Drawing.Point(66, 169)
        Me.chkOtherReminderInfo.Name = "chkOtherReminderInfo"
        Me.chkOtherReminderInfo.Size = New System.Drawing.Size(121, 17)
        Me.chkOtherReminderInfo.TabIndex = 5
        Me.chkOtherReminderInfo.Text = "Other Reminder Info"
        Me.chkOtherReminderInfo.UseVisualStyleBackColor = False
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(94, 222)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 6
        Me.btnGo.Text = "Go!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'pnlReportComponents
        '
        Me.pnlReportComponents.BackColor = System.Drawing.Color.LightBlue
        Me.pnlReportComponents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlReportComponents.Location = New System.Drawing.Point(40, 71)
        Me.pnlReportComponents.Name = "pnlReportComponents"
        Me.pnlReportComponents.Size = New System.Drawing.Size(184, 130)
        Me.pnlReportComponents.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "HealthConnect Client Call List"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Choose one or more report components:"
        '
        'frmMain1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(271, 273)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.chkOtherReminderInfo)
        Me.Controls.Add(Me.chkMDDue)
        Me.Controls.Add(Me.chk6MonthDue)
        Me.Controls.Add(Me.chk3MonthDue)
        Me.Controls.Add(Me.pnlReportComponents)
        Me.Name = "frmMain1"
        Me.Text = "frmMain1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chk3MonthDue As CheckBox
    Friend WithEvents chk6MonthDue As CheckBox
    Friend WithEvents chkMDDue As CheckBox
    Friend WithEvents chkOtherReminderInfo As CheckBox
    Friend WithEvents btnGo As Button
    Friend WithEvents pnlReportComponents As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
