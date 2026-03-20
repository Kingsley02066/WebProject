<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        Me.btnHospitalBilling = New Button()
        Me.btnStudentLoan = New Button()
        Me.btnLogout = New Button()
        Me.PictureBox1 = New PictureBox()
        Me.PictureBox2 = New PictureBox()
        Me.PictureBox3 = New PictureBox()
        CType(Me.PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' btnHospitalBilling
        ' 
        Me.btnHospitalBilling.BackColor = SystemColors.ActiveCaption
        Me.btnHospitalBilling.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.btnHospitalBilling.Location = New Point(356, 12)
        Me.btnHospitalBilling.Name = "btnHospitalBilling"
        Me.btnHospitalBilling.Size = New Size(181, 145)
        Me.btnHospitalBilling.TabIndex = 0
        Me.btnHospitalBilling.Text = "HospitalBilling"
        Me.btnHospitalBilling.UseVisualStyleBackColor = False
        ' 
        ' btnStudentLoan
        ' 
        Me.btnStudentLoan.BackColor = SystemColors.Info
        Me.btnStudentLoan.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.btnStudentLoan.Location = New Point(356, 163)
        Me.btnStudentLoan.Name = "btnStudentLoan"
        Me.btnStudentLoan.Size = New Size(181, 130)
        Me.btnStudentLoan.TabIndex = 1
        Me.btnStudentLoan.Text = "Student Loan"
        Me.btnStudentLoan.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        Me.btnLogout.BackColor = Color.Coral
        Me.btnLogout.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.btnLogout.Location = New Point(356, 299)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New Size(181, 130)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        Me.PictureBox1.Location = New Point(97, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Size(242, 145)
        Me.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        Me.PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        Me.PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), Image)
        Me.PictureBox2.Location = New Point(97, 163)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New Size(242, 130)
        Me.PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        Me.PictureBox3.Location = New Point(97, 299)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New Size(242, 130)
        Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        ' 
        ' DashboardForm
        ' 
        Me.AutoScaleDimensions = New SizeF(10F, 25F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = SystemColors.AppWorkspace
        Me.ClientSize = New Size(800, 450)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnStudentLoan)
        Me.Controls.Add(Me.btnHospitalBilling)
        Me.Name = "DashboardForm"
        Me.Text = "DashboardForm"
        CType(Me.PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents btnHospitalBilling As Button
    Friend WithEvents btnStudentLoan As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
