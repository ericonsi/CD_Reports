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
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chk3MonthDue
        '
        Me.chk3MonthDue.AutoSize = True
        Me.chk3MonthDue.Location = New System.Drawing.Point(66, 70)
        Me.chk3MonthDue.Name = "chk3MonthDue"
        Me.chk3MonthDue.Size = New System.Drawing.Size(110, 17)
        Me.chk3MonthDue.TabIndex = 0
        Me.chk3MonthDue.Text = "Three Month Due"
        Me.chk3MonthDue.UseVisualStyleBackColor = True
        '
        'chk6MonthDue
        '
        Me.chk6MonthDue.AutoSize = True
        Me.chk6MonthDue.Location = New System.Drawing.Point(66, 99)
        Me.chk6MonthDue.Name = "chk6MonthDue"
        Me.chk6MonthDue.Size = New System.Drawing.Size(133, 17)
        Me.chk6MonthDue.TabIndex = 1
        Me.chk6MonthDue.Text = "Six Month Screen Due"
        Me.chk6MonthDue.UseVisualStyleBackColor = True
        '
        'chkMDDue
        '
        Me.chkMDDue.AutoSize = True
        Me.chkMDDue.Location = New System.Drawing.Point(66, 128)
        Me.chkMDDue.Name = "chkMDDue"
        Me.chkMDDue.Size = New System.Drawing.Size(91, 17)
        Me.chkMDDue.TabIndex = 3
        Me.chkMDDue.Text = "MD Appt Due"
        Me.chkMDDue.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(66, 157)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(121, 17)
        Me.CheckBox6.TabIndex = 5
        Me.CheckBox6.Text = "Other Reminder Info"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(104, 198)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 6
        Me.btnGo.Text = "Go!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'frmMain1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 285)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.chkMDDue)
        Me.Controls.Add(Me.chk6MonthDue)
        Me.Controls.Add(Me.chk3MonthDue)
        Me.Name = "frmMain1"
        Me.Text = "frmMain1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chk3MonthDue As CheckBox
    Friend WithEvents chk6MonthDue As CheckBox
    Friend WithEvents chkMDDue As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents btnGo As Button
End Class
