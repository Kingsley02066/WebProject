<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HospitalBillingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HospitalBillingForm))
        Me.GroupBox1 = New GroupBox()
        Me.rbPrivate = New RadioButton()
        Me.rbSemi = New RadioButton()
        Me.rbGeneral = New RadioButton()
        Me.gbServices = New GroupBox()
        Me.rbSurgery = New RadioButton()
        Me.rbXray = New RadioButton()
        Me.rbLab = New RadioButton()
        Me.Label1 = New Label()
        Me.Label2 = New Label()
        Me.txtPatientName = New TextBox()
        Me.txtDays = New TextBox()
        Me.btnCalculate = New Button()
        Me.Label3 = New Label()
        Me.txtAmount = New TextBox()
        Me.btnBack = New Button()
        Me.btnPrint = New Button()
        Me.GroupBox1.SuspendLayout()
        Me.gbServices.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        Me.GroupBox1.Controls.Add(Me.rbPrivate)
        Me.GroupBox1.Controls.Add(Me.rbSemi)
        Me.GroupBox1.Controls.Add(Me.rbGeneral)
        Me.GroupBox1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.GroupBox1.Location = New Point(29, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New Size(300, 150)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ward"
        ' 
        ' rbPrivate
        ' 
        Me.rbPrivate.AutoSize = True
        Me.rbPrivate.Location = New Point(9, 100)
        Me.rbPrivate.Name = "rbPrivate"
        Me.rbPrivate.Size = New Size(164, 30)
        Me.rbPrivate.TabIndex = 2
        Me.rbPrivate.TabStop = True
        Me.rbPrivate.Text = "Private(500)"
        Me.rbPrivate.UseVisualStyleBackColor = True
        ' 
        ' rbSemi
        ' 
        Me.rbSemi.AutoSize = True
        Me.rbSemi.Location = New Point(9, 64)
        Me.rbSemi.Name = "rbSemi"
        Me.rbSemi.Size = New Size(222, 30)
        Me.rbSemi.TabIndex = 1
        Me.rbSemi.TabStop = True
        Me.rbSemi.Text = "Semi-Private(350)"
        Me.rbSemi.UseVisualStyleBackColor = True
        ' 
        ' rbGeneral
        ' 
        Me.rbGeneral.AutoSize = True
        Me.rbGeneral.Location = New Point(9, 28)
        Me.rbGeneral.Name = "rbGeneral"
        Me.rbGeneral.Size = New Size(172, 30)
        Me.rbGeneral.TabIndex = 0
        Me.rbGeneral.TabStop = True
        Me.rbGeneral.Text = "General(200)"
        Me.rbGeneral.UseVisualStyleBackColor = True
        ' 
        ' gbServices
        ' 
        Me.gbServices.Controls.Add(Me.rbSurgery)
        Me.gbServices.Controls.Add(Me.rbXray)
        Me.gbServices.Controls.Add(Me.rbLab)
        Me.gbServices.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.gbServices.Location = New Point(479, 123)
        Me.gbServices.Name = "gbServices"
        Me.gbServices.Size = New Size(300, 150)
        Me.gbServices.TabIndex = 1
        Me.gbServices.TabStop = False
        Me.gbServices.Text = "Services"
        ' 
        ' rbSurgery
        ' 
        Me.rbSurgery.AutoSize = True
        Me.rbSurgery.Location = New Point(4, 104)
        Me.rbSurgery.Name = "rbSurgery"
        Me.rbSurgery.Size = New Size(184, 30)
        Me.rbSurgery.TabIndex = 2
        Me.rbSurgery.TabStop = True
        Me.rbSurgery.Text = "Surgery(1000)"
        Me.rbSurgery.UseVisualStyleBackColor = True
        ' 
        ' rbXray
        ' 
        Me.rbXray.AutoSize = True
        Me.rbXray.Location = New Point(5, 66)
        Me.rbXray.Name = "rbXray"
        Me.rbXray.Size = New Size(154, 30)
        Me.rbXray.TabIndex = 1
        Me.rbXray.TabStop = True
        Me.rbXray.Text = "X-Ray(100)"
        Me.rbXray.UseVisualStyleBackColor = True
        ' 
        ' rbLab
        ' 
        Me.rbLab.AutoSize = True
        Me.rbLab.Location = New Point(5, 28)
        Me.rbLab.Name = "rbLab"
        Me.rbLab.Size = New Size(177, 30)
        Me.rbLab.TabIndex = 0
        Me.rbLab.TabStop = True
        Me.rbLab.Text = "Lab Test(150)"
        Me.rbLab.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Me.Label1.AutoSize = True
        Me.Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.Label1.Location = New Point(35, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(159, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Patient Name:"
        ' 
        ' Label2
        ' 
        Me.Label2.AutoSize = True
        Me.Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.Label2.Location = New Point(479, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(70, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Days:"
        ' 
        ' txtPatientName
        ' 
        Me.txtPatientName.Location = New Point(200, 28)
        Me.txtPatientName.Multiline = True
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New Size(201, 44)
        Me.txtPatientName.TabIndex = 4
        ' 
        ' txtDays
        ' 
        Me.txtDays.Location = New Point(556, 26)
        Me.txtDays.Multiline = True
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New Size(214, 46)
        Me.txtDays.TabIndex = 5
        ' 
        ' btnCalculate
        ' 
        Me.btnCalculate.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.btnCalculate.Location = New Point(321, 310)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New Size(185, 51)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate Bill"
        Me.btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Me.Label3.AutoSize = True
        Me.Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.Label3.Location = New Point(53, 382)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(219, 26)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Amount To Be Paid:"
        ' 
        ' txtAmount
        ' 
        Me.txtAmount.Location = New Point(278, 382)
        Me.txtAmount.Multiline = True
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New Size(228, 46)
        Me.txtAmount.TabIndex = 8
        ' 
        ' btnBack
        ' 
        Me.btnBack.Location = New Point(597, 382)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New Size(112, 46)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        Me.btnPrint.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.btnPrint.Location = New Point(556, 310)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New Size(197, 51)
        Me.btnPrint.TabIndex = 10
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        ' 
        ' HospitalBillingForm
        ' 
        Me.AutoScaleDimensions = New SizeF(10F, 25F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.ClientSize = New Size(800, 450)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtDays)
        Me.Controls.Add(Me.txtPatientName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbServices)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "HospitalBillingForm"
        Me.Text = "HospitalBillingForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbServices.ResumeLayout(False)
        Me.gbServices.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gbServices As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents txtDays As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents rbPrivate As RadioButton
    Friend WithEvents rbSemi As RadioButton
    Friend WithEvents rbGeneral As RadioButton
    Friend WithEvents rbSurgery As RadioButton
    Friend WithEvents rbXray As RadioButton
    Friend WithEvents rbLab As RadioButton
    Friend WithEvents btnBack As Button
    Friend WithEvents btnPrint As Button
End Class
