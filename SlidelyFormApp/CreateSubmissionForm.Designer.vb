<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        txtGitHubLink = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        txtName = New TextBox()
        btnToggleStopwatch = New Button()
        btnSubmit = New Button()
        Label6 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtStopwatchTime = New TextBox()
        SuspendLayout()
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.Location = New Point(383, 230)
        txtGitHubLink.Multiline = True
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.Size = New Size(257, 42)
        txtGitHubLink.TabIndex = 8
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(383, 181)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(257, 23)
        txtPhone.TabIndex = 7
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(383, 131)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(257, 23)
        txtEmail.TabIndex = 6
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(383, 82)
        txtName.Name = "txtName"
        txtName.Size = New Size(257, 23)
        txtName.TabIndex = 5
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.Gold
        btnToggleStopwatch.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnToggleStopwatch.Location = New Point(53, 309)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(321, 42)
        btnToggleStopwatch.TabIndex = 10
        btnToggleStopwatch.Text = "Toggle Stopwatch (Ctrl + T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.DarkTurquoise
        btnSubmit.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSubmit.Location = New Point(160, 382)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(423, 41)
        btnSubmit.TabIndex = 11
        btnSubmit.Text = "Submit (Ctrl + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(206, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(418, 22)
        Label6.TabIndex = 13
        Label6.Text = "Kalpit Rathi, Slidely Task 2 - Create Submissions"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(181, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 22)
        Label1.TabIndex = 14
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(181, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 22)
        Label2.TabIndex = 15
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(181, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 22)
        Label3.TabIndex = 16
        Label3.Text = "Phone Num"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(181, 227)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 44)
        Label4.TabIndex = 17
        Label4.Text = "Github Link " & vbCrLf & "For Task 2"
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Location = New Point(443, 321)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.Size = New Size(156, 23)
        txtStopwatchTime.TabIndex = 18
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtStopwatchTime)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label6)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(txtGitHubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStopwatchTime As TextBox
End Class
