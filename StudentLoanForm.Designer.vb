<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentLoanForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentLoanForm))
        Me.Label1 = New Label()
        Me.Label2 = New Label()
        Me.Label3 = New Label()
        Me.Label4 = New Label()
        Me.btnCheck = New Button()
        Me.btnBack = New Button()
        Me.btnRepayment = New Button()
        Me.Label5 = New Label()
        Me.txtStudentName = New TextBox()
        Me.txtGPA = New TextBox()
        Me.txtIncome = New TextBox()
        Me.txtLoanAmount = New TextBox()
        Me.txtMonthly = New TextBox()
        Me.btnPrint = New Button()
        Me.SuspendLayout()
        ' 
        ' Label1
        ' 
        Me.Label1.AutoSize = True
        Me.Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.Label1.Location = New Point(27, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(164, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Name:"
        ' 
        ' Label2
        ' 
        Me.Label2.AutoSize = True
        Me.Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.Label2.Location = New Point(581, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(68, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "GPA:"
        ' 
        ' Label3
        ' 
        Me.Label3.AutoSize = True
        Me.Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.Label3.Location = New Point(27, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(260, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Family Amount Income:"
        ' 
        ' Label4
        ' 
        Me.Label4.AutoSize = True
        Me.Label4.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.Label4.Location = New Point(581, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New Size(160, 26)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Loan Amount:"
        ' 
        ' btnCheck
        ' 
        Me.btnCheck.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.btnCheck.Location = New Point(370, 292)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New Size(148, 61)
        Me.btnCheck.TabIndex = 4
        Me.btnCheck.Text = "Check Elibility"
        Me.btnCheck.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        Me.btnBack.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.btnBack.Location = New Point(479, 385)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New Size(112, 34)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnRepayment
        ' 
        Me.btnRepayment.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.btnRepayment.Location = New Point(581, 292)
        Me.btnRepayment.Name = "btnRepayment"
        Me.btnRepayment.Size = New Size(164, 61)
        Me.btnRepayment.TabIndex = 6
        Me.btnRepayment.Text = "Calculate Repayment"
        Me.btnRepayment.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Me.Label5.AutoSize = True
        Me.Label5.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.Label5.Location = New Point(350, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New Size(166, 26)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Monthly Total:"
        ' 
        ' txtStudentName
        ' 
        Me.txtStudentName.Location = New Point(233, 45)
        Me.txtStudentName.Multiline = True
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New Size(150, 46)
        Me.txtStudentName.TabIndex = 8
        ' 
        ' txtGPA
        ' 
        Me.txtGPA.Location = New Point(775, 45)
        Me.txtGPA.Multiline = True
        Me.txtGPA.Name = "txtGPA"
        Me.txtGPA.Size = New Size(150, 46)
        Me.txtGPA.TabIndex = 9
        ' 
        ' txtIncome
        ' 
        Me.txtIncome.Location = New Point(311, 151)
        Me.txtIncome.Multiline = True
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New Size(150, 46)
        Me.txtIncome.TabIndex = 10
        ' 
        ' txtLoanAmount
        ' 
        Me.txtLoanAmount.Location = New Point(775, 156)
        Me.txtLoanAmount.Multiline = True
        Me.txtLoanAmount.Name = "txtLoanAmount"
        Me.txtLoanAmount.Size = New Size(150, 46)
        Me.txtLoanAmount.TabIndex = 11
        ' 
        ' txtMonthly
        ' 
        Me.txtMonthly.Location = New Point(565, 238)
        Me.txtMonthly.Multiline = True
        Me.txtMonthly.Name = "txtMonthly"
        Me.txtMonthly.Size = New Size(150, 46)
        Me.txtMonthly.TabIndex = 12
        ' 
        ' btnPrint
        ' 
        Me.btnPrint.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.btnPrint.Location = New Point(775, 237)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New Size(126, 47)
        Me.btnPrint.TabIndex = 13
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        ' 
        ' StudentLoanForm
        ' 
        Me.AutoScaleDimensions = New SizeF(10F, 25F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.ClientSize = New Size(1016, 450)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtMonthly)
        Me.Controls.Add(Me.txtLoanAmount)
        Me.Controls.Add(Me.txtIncome)
        Me.Controls.Add(Me.txtGPA)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnRepayment)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StudentLoanForm"
        Me.Text = "StudentLoanForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRepayment As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents txtGPA As TextBox
    Friend WithEvents txtIncome As TextBox
    Friend WithEvents txtLoanAmount As TextBox
    Friend WithEvents txtMonthly As TextBox
    Friend WithEvents btnPrint As Button
End Class
