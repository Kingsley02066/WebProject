Imports System.Drawing.Printing

Public Class StudentLoanForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        DashboardForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim gpa As Double
        Dim income As Double

        gpa = Val(txtGPA.Text)
        income = Val(txtIncome.Text)

        If gpa >= 2.5 And income < 40000 Then
            MessageBox.Show("Loan Application Approved")
            btnRepayment.Enabled = True
        Else
            MessageBox.Show("Loan Application Rejected")
            btnRepayment.Enabled = False
        End If

    End Sub

    Private Sub btnRepayment_Click(sender As Object, e As EventArgs) Handles btnRepayment.Click
        Dim P As Double
        Dim r As Double
        Dim n As Integer
        Dim monthly As Double
        Dim total As Double

        P = Val(txtLoanAmount.Text)
        r = 0.08 / 12
        n = 60

        monthly = (P * r * (1 + r) ^ n) / ((1 + r) ^ n - 1)
        total = monthly * n

        txtMonthly.Text = monthly.ToString("F2")

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles btnPrint.Click

        Dim y As Integer = 50

        ' Title
        e.Graphics.DrawString("STUDENT LOAN DETAILS", New Font("Arial", 14, FontStyle.Bold), Brushes.Black, 100, y)
        y += 40

        ' Student details
        e.Graphics.DrawString("Student Name: " & txtStudentName.Text, New Font("Arial", 10), Brushes.Black, 50, y)
        y += 25

        e.Graphics.DrawString("GPA: " & txtGPA.Text, New Font("Arial", 10), Brushes.Black, 50, y)
        y += 25

        e.Graphics.DrawString("Family Income: " & txtIncome.Text, New Font("Arial", 10), Brushes.Black, 50, y)
        y += 25

        e.Graphics.DrawString("Loan Amount: " & txtLoanAmount.Text, New Font("Arial", 10), Brushes.Black, 50, y)
        y += 25

        e.Graphics.DrawString("Monthly Payment: " & txtMonthly.Text, New Font("Arial", 10), Brushes.Black, 50, y)
        y += 40

        ' Eligibility
        Dim gpa As Double = Val(txtGPA.Text)
        Dim income As Double = Val(txtIncome.Text)
        Dim status As String

        If gpa >= 2.5 And income <= 3000 Then
            status = "Eligible"
        Else
            status = "Not Eligible"
        End If

        e.Graphics.DrawString("Eligibility Status: " & status, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, y)
        y += 40

        ' Footer
        e.Graphics.DrawString("Thank you for using the system", New Font("Arial", 9, FontStyle.Italic), Brushes.Black, 50, y)

    End Sub
End Class