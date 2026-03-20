<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnLogin = New Button()
        Me.Label1 = New Label()
        Me.Label2 = New Label()
        Me.txtUsername = New TextBox()
        Me.txtPassword = New TextBox()
        Me.btnClose = New Button()
        Me.Button1 = New Button()
        Me.PictureBox1 = New PictureBox()
        CType(Me.PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' btnLogin
        ' 
        Me.btnLogin.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.btnLogin.Location = New Point(396, 321)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New Size(112, 67)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Me.Label1.AutoSize = True
        Me.Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.Label1.Location = New Point(63, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(123, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Me.Label2.AutoSize = True
        Me.Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.Label2.Location = New Point(67, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(118, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        ' 
        ' txtUsername
        ' 
        Me.txtUsername.Location = New Point(200, 81)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New Size(275, 39)
        Me.txtUsername.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        Me.txtPassword.Location = New Point(200, 213)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = "*"c
        Me.txtPassword.Size = New Size(275, 39)
        Me.txtPassword.TabIndex = 4
        ' 
        ' btnClose
        ' 
        Me.btnClose.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.btnClose.Location = New Point(566, 321)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New Size(112, 67)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Me.Button1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.Button1.Location = New Point(526, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New Size(179, 34)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Load Photo"
        Me.Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        Me.PictureBox1.Location = New Point(518, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Size(218, 183)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        ' 
        ' LoginForm
        ' 
        Me.AutoScaleDimensions = New SizeF(10F, 25F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.ClientSize = New Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogin)
        Me.Name = "LoginForm"
        Me.Text = "LoginForm"
        CType(Me.PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
