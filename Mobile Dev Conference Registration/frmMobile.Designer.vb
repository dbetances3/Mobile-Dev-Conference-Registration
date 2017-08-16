<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMobile
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
        Me.picMobile = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblCorporationID = New System.Windows.Forms.Label()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.grpConference = New System.Windows.Forms.GroupBox()
        Me.radWindows = New System.Windows.Forms.RadioButton()
        Me.radAndroid = New System.Windows.Forms.RadioButton()
        Me.grpCourses = New System.Windows.Forms.GroupBox()
        Me.radMobileDatabases = New System.Windows.Forms.RadioButton()
        Me.radMobileDesign = New System.Windows.Forms.RadioButton()
        Me.radMobileSecurity = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblCosts = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtCorporationID = New System.Windows.Forms.TextBox()
        CType(Me.picMobile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConference.SuspendLayout()
        Me.grpCourses.SuspendLayout()
        Me.SuspendLayout()
        '
        'picMobile
        '
        Me.picMobile.Image = Global.Mobile_Dev_Conference_Registration.My.Resources.Resources.Mobile
        Me.picMobile.Location = New System.Drawing.Point(182, 12)
        Me.picMobile.Name = "picMobile"
        Me.picMobile.Size = New System.Drawing.Size(300, 100)
        Me.picMobile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMobile.TabIndex = 0
        Me.picMobile.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(142, 100)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(380, 64)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Mobile Developer's" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Conference Registration"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCorporationID
        '
        Me.lblCorporationID.AutoSize = True
        Me.lblCorporationID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorporationID.Location = New System.Drawing.Point(205, 196)
        Me.lblCorporationID.Name = "lblCorporationID"
        Me.lblCorporationID.Size = New System.Drawing.Size(119, 16)
        Me.lblCorporationID.TabIndex = 2
        Me.lblCorporationID.Text = "Corporation ID:"
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDays.Location = New System.Drawing.Point(30, 270)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(130, 16)
        Me.lblDays.TabIndex = 3
        Me.lblDays.Text = "Number Of Days:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(30, 230)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(92, 16)
        Me.lblFirstName.TabIndex = 4
        Me.lblFirstName.Text = "First Name:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(320, 230)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(90, 16)
        Me.lblLastName.TabIndex = 5
        Me.lblLastName.Text = "Last Name:"
        '
        'txtDays
        '
        Me.txtDays.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDays.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDays.Location = New System.Drawing.Point(165, 270)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(44, 23)
        Me.txtDays.TabIndex = 9
        Me.txtDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpConference
        '
        Me.grpConference.Controls.Add(Me.radWindows)
        Me.grpConference.Controls.Add(Me.radAndroid)
        Me.grpConference.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpConference.Location = New System.Drawing.Point(33, 300)
        Me.grpConference.Name = "grpConference"
        Me.grpConference.Size = New System.Drawing.Size(176, 97)
        Me.grpConference.TabIndex = 10
        Me.grpConference.TabStop = False
        Me.grpConference.Text = "Pre-Conference"
        '
        'radWindows
        '
        Me.radWindows.AutoSize = True
        Me.radWindows.Checked = True
        Me.radWindows.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radWindows.Location = New System.Drawing.Point(7, 60)
        Me.radWindows.Name = "radWindows"
        Me.radWindows.Size = New System.Drawing.Size(162, 17)
        Me.radWindows.TabIndex = 1
        Me.radWindows.TabStop = True
        Me.radWindows.Text = "Windows Store Track"
        Me.radWindows.UseVisualStyleBackColor = True
        '
        'radAndroid
        '
        Me.radAndroid.AutoSize = True
        Me.radAndroid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAndroid.Location = New System.Drawing.Point(7, 25)
        Me.radAndroid.Name = "radAndroid"
        Me.radAndroid.Size = New System.Drawing.Size(127, 30)
        Me.radAndroid.TabIndex = 0
        Me.radAndroid.Text = "Pre-Conference" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Android Track"
        Me.radAndroid.UseVisualStyleBackColor = True
        '
        'grpCourses
        '
        Me.grpCourses.Controls.Add(Me.radMobileDatabases)
        Me.grpCourses.Controls.Add(Me.radMobileDesign)
        Me.grpCourses.Controls.Add(Me.radMobileSecurity)
        Me.grpCourses.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCourses.Location = New System.Drawing.Point(321, 274)
        Me.grpCourses.Name = "grpCourses"
        Me.grpCourses.Size = New System.Drawing.Size(272, 117)
        Me.grpCourses.TabIndex = 11
        Me.grpCourses.TabStop = False
        Me.grpCourses.Text = "Courses"
        Me.grpCourses.Visible = False
        '
        'radMobileDatabases
        '
        Me.radMobileDatabases.AutoSize = True
        Me.radMobileDatabases.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMobileDatabases.Location = New System.Drawing.Point(7, 75)
        Me.radMobileDatabases.Name = "radMobileDatabases"
        Me.radMobileDatabases.Size = New System.Drawing.Size(139, 17)
        Me.radMobileDatabases.TabIndex = 2
        Me.radMobileDatabases.TabStop = True
        Me.radMobileDatabases.Text = "Mobile Databases"
        Me.radMobileDatabases.UseVisualStyleBackColor = True
        '
        'radMobileDesign
        '
        Me.radMobileDesign.AutoSize = True
        Me.radMobileDesign.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMobileDesign.Location = New System.Drawing.Point(7, 50)
        Me.radMobileDesign.Name = "radMobileDesign"
        Me.radMobileDesign.Size = New System.Drawing.Size(115, 17)
        Me.radMobileDesign.TabIndex = 1
        Me.radMobileDesign.TabStop = True
        Me.radMobileDesign.Text = "Mobile Design"
        Me.radMobileDesign.UseVisualStyleBackColor = True
        '
        'radMobileSecurity
        '
        Me.radMobileSecurity.AutoSize = True
        Me.radMobileSecurity.Checked = True
        Me.radMobileSecurity.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMobileSecurity.Location = New System.Drawing.Point(7, 25)
        Me.radMobileSecurity.Name = "radMobileSecurity"
        Me.radMobileSecurity.Size = New System.Drawing.Size(125, 17)
        Me.radMobileSecurity.TabIndex = 0
        Me.radMobileSecurity.TabStop = True
        Me.radMobileSecurity.Text = "Mobile Security"
        Me.radMobileSecurity.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.IndianRed
        Me.btnCalculate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Black
        Me.btnCalculate.Location = New System.Drawing.Point(148, 405)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(160, 40)
        Me.btnCalculate.TabIndex = 15
        Me.btnCalculate.Text = "Calculate Costs"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.IndianRed
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(356, 405)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(160, 40)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblCosts
        '
        Me.lblCosts.AutoSize = True
        Me.lblCosts.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCosts.ForeColor = System.Drawing.Color.Black
        Me.lblCosts.Location = New System.Drawing.Point(188, 460)
        Me.lblCosts.Name = "lblCosts"
        Me.lblCosts.Size = New System.Drawing.Size(288, 16)
        Me.lblCosts.TabIndex = 17
        Me.lblCosts.Text = "Total conference costs are: $X,XXX.XX"
        Me.lblCosts.Visible = False
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFirstName.Location = New System.Drawing.Point(165, 227)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(144, 23)
        Me.txtFirstName.TabIndex = 7
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLastName.Location = New System.Drawing.Point(415, 227)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(202, 23)
        Me.txtLastName.TabIndex = 8
        '
        'txtCorporationID
        '
        Me.txtCorporationID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorporationID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCorporationID.Location = New System.Drawing.Point(352, 193)
        Me.txtCorporationID.Name = "txtCorporationID"
        Me.txtCorporationID.Size = New System.Drawing.Size(66, 23)
        Me.txtCorporationID.TabIndex = 6
        '
        'frmMobile
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(664, 502)
        Me.Controls.Add(Me.txtCorporationID)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblCosts)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpCourses)
        Me.Controls.Add(Me.grpConference)
        Me.Controls.Add(Me.txtDays)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.lblCorporationID)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picMobile)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "frmMobile"
        Me.Text = "Register Today!"
        CType(Me.picMobile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConference.ResumeLayout(False)
        Me.grpConference.PerformLayout()
        Me.grpCourses.ResumeLayout(False)
        Me.grpCourses.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picMobile As System.Windows.Forms.PictureBox
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents lblCorporationID As System.Windows.Forms.Label
    Friend WithEvents lblDays As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtDays As System.Windows.Forms.TextBox
    Friend WithEvents grpConference As System.Windows.Forms.GroupBox
    Friend WithEvents radWindows As System.Windows.Forms.RadioButton
    Friend WithEvents radAndroid As System.Windows.Forms.RadioButton
    Friend WithEvents grpCourses As System.Windows.Forms.GroupBox
    Friend WithEvents radMobileDatabases As System.Windows.Forms.RadioButton
    Friend WithEvents radMobileDesign As System.Windows.Forms.RadioButton
    Friend WithEvents radMobileSecurity As System.Windows.Forms.RadioButton
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblCosts As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtCorporationID As System.Windows.Forms.TextBox

End Class
