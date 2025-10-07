Public Class Form1
    Private ReadOnly beveragePrices As New Dictionary(Of String, Decimal)() From {
        {"Espresso", 120D},
        {"Latte", 150D},
        {"Cappuccino", 160D},
        {"Americano", 130D},
        {"Mocha", 170D}
    }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each beverageName As String In beveragePrices.Keys
            cmbBeverage.Items.Add(beverageName)
        Next
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            If String.IsNullOrWhiteSpace(txtCustomersName.Text) Then
                MessageBox.Show("Please enter a customer name.")
                txtCustomersName.Focus()
                Exit Sub
            End If

            If cmbBeverage.SelectedIndex = -1 Then
                MessageBox.Show("Please select a beverage.")
                cmbBeverage.Focus()
                Exit Sub
            End If

            If numQuantity.Value <= 0 Then
                MessageBox.Show("Quantity must be greater than zero.")
                numQuantity.Focus()
                Exit Sub
            End If


            Dim beverage As String = cmbBeverage.SelectedItem.ToString()

            Dim itemPrice As Decimal = beveragePrices(beverage)

            Dim quantity As Integer = CInt(numQuantity.Value)

            Dim subtotal As Decimal = itemPrice * quantity

            Dim discountAmount As Decimal = 0
            If chkDiscount.Checked Then
                discountAmount = subtotal * 0.1D
            End If

            Dim finalTotal As Decimal = subtotal - discountAmount


            txtSubtotal.Text = subtotal.ToString("₱#,##0.00")


            txtFinalTotal.Text = finalTotal.ToString("₱#,##0.00")

            MessageBox.Show($"Order for {txtCustomersName.Text} submitted. Total: {finalTotal.ToString("₱#,##0.00")}")

        Catch ex As KeyNotFoundException
            MessageBox.Show("Error: Price not found for the selected beverage.")
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message)
        End Try
    End Sub
End Class