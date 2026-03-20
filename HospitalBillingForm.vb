Public Class HospitalBillingForm
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles rbPrivate.CheckedChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim days As Integer
        Dim wardRate As Double
        Dim treatment As Double = 0

        days = Val(txtDays.Text)

        ' Ward selection
        If rbGeneral.Checked Then
            wardRate = 200
        ElseIf rbSemi.Checked Then
            wardRate = 350
        ElseIf rbPrivate.Checked Then
            wardRate = 500
        End If

        ' Optional services
        If rbLab.Checked Then
            treatment = treatment + 150
        End If

        If rbXray.Checked Then
            treatment = treatment + 100
        End If

        If rbSurgery.Checked Then
            treatment = treatment + 1000
        End If

        ' Calculations
        Dim wardCharges As Double = wardRate * days
        Dim subtotal As Double = wardCharges + treatment
        Dim vat As Double = subtotal * 0.12
        Dim finalBill As Double = subtotal + vat

        ' Show result
        txtAmount.Text = finalBill.ToString()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        DashboardForm.Show()
        Me.Hide()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles btnPrint.Click
        Dim y As Integer = 50

        ' Title
        e.Graphics.DrawString("HOSPITAL BILL RECEIPT", New Font("Arial", 14, FontStyle.Bold), Brushes.Black, 100, y)
        y += 40

        ' Patient details
        e.Graphics.DrawString("Patient Name: " & txtPatientName.Text, New Font("Arial", 10), Brushes.Black, 50, y)
        y += 25

        e.Graphics.DrawString("Days: " & txtDays.Text, New Font("Arial", 10), Brushes.Black, 50, y)
        y += 25

        ' Ward
        Dim ward As String = ""
        Dim wardRate As Double = 0

        If rbGeneral.Checked Then
            ward = "General Ward"
            wardRate = 200
        ElseIf rbSemi.Checked Then
            ward = "Semi-Private"
            wardRate = 350
        ElseIf rbPrivate.Checked Then
            ward = "Private"
            wardRate = 500
        End If

        e.Graphics.DrawString("Ward Type: " & ward, New Font("Arial", 10), Brushes.Black, 50, y)
        y += 25

        ' Treatments
        Dim treatment As Double = 0

        If rbLab.Checked Then
            e.Graphics.DrawString("Lab Test: 150", New Font("Arial", 10), Brushes.Black, 50, y)
            treatment += 150
            y += 20
        End If

        If rbXray.Checked Then
            e.Graphics.DrawString("X-Ray: 100", New Font("Arial", 10), Brushes.Black, 50, y)
            treatment += 100
            y += 20
        End If

        If rbSurgery.Checked Then
            e.Graphics.DrawString("Surgery: 1000", New Font("Arial", 10), Brushes.Black, 50, y)
            treatment += 1000
            y += 20
        End If

        ' Calculations
        Dim days As Integer = Val(txtDays.Text)
        Dim wardCharges As Double = wardRate * days
        Dim subtotal As Double = wardCharges + treatment
        Dim vat As Double = subtotal * 0.12
        Dim finalBill As Double = subtotal + vat

        y += 20
        e.Graphics.DrawString("Ward Charges: " & wardCharges.ToString("F2"), New Font("Arial", 10), Brushes.Black, 50, y)
        y += 25

        e.Graphics.DrawString("Subtotal: " & subtotal.ToString("F2"), New Font("Arial", 10), Brushes.Black, 50, y)
        y += 25

        e.Graphics.DrawString("VAT (12%): " & vat.ToString("F2"), New Font("Arial", 10), Brushes.Black, 50, y)
        y += 25

        e.Graphics.DrawString("Final Bill: " & finalBill.ToString("F2"), New Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, y)
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As EventArgs)

    End Sub
End Class