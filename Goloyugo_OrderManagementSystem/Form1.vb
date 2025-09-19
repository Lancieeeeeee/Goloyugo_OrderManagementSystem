Imports System.Linq.Expressions

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If String.IsNullOrWhiteSpace(txtBox.Text) Then
                MessageBox.Show("Enter Customer Name", "Missing Information")
                Return
            End If
            If comB.SelectedIndex = -1 Then
                MessageBox.Show("Select Beverage", "Missing Information")
                Return
            End If
            If QuadM.Value <= 0 Then
                MessageBox.Show("Select Quantity", "Invalid Quantity")
                Return
            End If

            Dim selectedBeverage As String = comB.SelectedItem.ToString()
            Dim price As Decimal = 0

            Select Case selectedBeverage
                Case "Espresso"
                    price = 120
                Case "Latte"
                    price = 150
                Case "Cappuccino"
                    price = 160
                Case "Americano"
                    price = 130
                Case "Mocha"
                    price = 170
            End Select

            Dim quantity As Integer = QuadM.Value
            Dim subtotal As Decimal = price * quantity
            Dim discount As Decimal = subtotal * 0.1
            Dim finalTotal As Decimal = subtotal - discount

            If CheckB.Checked Then
                discount = subtotal * 0.1
                finalTotal = subtotal = discount
            End If

            lblSub.Text = subtotal.ToString() & "PHP"
            lblDis.Text = discount.ToString() & "PHP"
            lblFinal.Text = finalTotal.ToString() & "PHP"

            MessageBox.Show("Order " & txtBox.Text & "submitted Total:  " & finalTotal.ToString)
        Catch lblFinal As Exception
            MessageBox.Show("An error occurred: " & lblFinal.Message, "Error")
        End Try





    End Sub


End Class
