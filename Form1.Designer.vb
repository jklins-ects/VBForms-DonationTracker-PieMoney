<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDonationAmt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDonate = New System.Windows.Forms.Button()
        Me.cboStudents = New System.Windows.Forms.ComboBox()
        Me.lstDonations = New System.Windows.Forms.ListBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblStudentTotal = New System.Windows.Forms.Label()
        Me.lblClassTotal = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblHighest = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'txtDonationAmt
        '
        Me.txtDonationAmt.Location = New System.Drawing.Point(388, 50)
        Me.txtDonationAmt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDonationAmt.Name = "txtDonationAmt"
        Me.txtDonationAmt.Size = New System.Drawing.Size(132, 22)
        Me.txtDonationAmt.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(271, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Donation Amount"
        '
        'btnDonate
        '
        Me.btnDonate.Location = New System.Drawing.Point(537, 48)
        Me.btnDonate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDonate.Name = "btnDonate"
        Me.btnDonate.Size = New System.Drawing.Size(270, 28)
        Me.btnDonate.TabIndex = 4
        Me.btnDonate.Text = "Add Donation"
        Me.btnDonate.UseVisualStyleBackColor = True
        '
        'cboStudents
        '
        Me.cboStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStudents.FormattingEnabled = True
        Me.cboStudents.Location = New System.Drawing.Point(92, 50)
        Me.cboStudents.Margin = New System.Windows.Forms.Padding(4)
        Me.cboStudents.Name = "cboStudents"
        Me.cboStudents.Size = New System.Drawing.Size(160, 24)
        Me.cboStudents.Sorted = True
        Me.cboStudents.TabIndex = 5
        '
        'lstDonations
        '
        Me.lstDonations.FormattingEnabled = True
        Me.lstDonations.ItemHeight = 16
        Me.lstDonations.Location = New System.Drawing.Point(43, 101)
        Me.lstDonations.Name = "lstDonations"
        Me.lstDonations.Size = New System.Drawing.Size(209, 84)
        Me.lstDonations.TabIndex = 6
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(274, 101)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(118, 28)
        Me.btnRemove.TabIndex = 7
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lblStudentTotal
        '
        Me.lblStudentTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStudentTotal.Location = New System.Drawing.Point(149, 201)
        Me.lblStudentTotal.Name = "lblStudentTotal"
        Me.lblStudentTotal.Size = New System.Drawing.Size(48, 16)
        Me.lblStudentTotal.TabIndex = 8
        '
        'lblClassTotal
        '
        Me.lblClassTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClassTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassTotal.Location = New System.Drawing.Point(537, 243)
        Me.lblClassTotal.Name = "lblClassTotal"
        Me.lblClassTotal.Size = New System.Drawing.Size(270, 32)
        Me.lblClassTotal.TabIndex = 9
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(43, 243)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save All"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(298, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 32)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Total Donations:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Student Total: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(417, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Highest Donors:"
        '
        'lblHighest
        '
        Me.lblHighest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHighest.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighest.Location = New System.Drawing.Point(537, 101)
        Me.lblHighest.Name = "lblHighest"
        Me.lblHighest.Size = New System.Drawing.Size(270, 116)
        Me.lblHighest.TabIndex = 14
        Me.lblHighest.Text = "Label6"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 331)
        Me.Controls.Add(Me.lblHighest)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblClassTotal)
        Me.Controls.Add(Me.lblStudentTotal)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lstDonations)
        Me.Controls.Add(Me.cboStudents)
        Me.Controls.Add(Me.btnDonate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDonationAmt)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.Text = "Pie in the Face Donations!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDonationAmt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDonate As Button
    Friend WithEvents cboStudents As ComboBox
    Friend WithEvents lstDonations As ListBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents lblStudentTotal As Label
    Friend WithEvents lblClassTotal As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblHighest As Label
End Class
