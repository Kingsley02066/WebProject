Public Class DashboardForm
    Private Sub btnHospitalBilling_Click(sender As Object, e As EventArgs) Handles btnHospitalBilling.Click
        ' For HospitalBilling
        Dim HospitalBilling As New HospitalBillingForm()
        HospitalBilling.Show()
    End Sub

    Private Sub btnStudentLoan_Click(sender As Object, e As EventArgs) Handles btnStudentLoan.Click
        'For Loan
        Dim StudentLoan As New StudentLoanForm()
        StudentLoan.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' For Logout
        Dim Login As New Form1()
        Login.Show()
        Me.Close()
    End Sub
End Class