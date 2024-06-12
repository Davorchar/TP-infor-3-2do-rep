Public Class Form1
    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim num1, num2, num3 As Integer
        Dim producto As Integer
        Integer.TryParse(txtIngresarDat.Text, num1)
        Integer.TryParse(txtIngresar2.Text, num2)
        num3 = 1
        producto = 0
        For num3 = 1 To num1 Step 1
            producto = producto + num2
        Next
        lblMostrar.Text = "el producto de estos numeros es " & producto
    End Sub
End Class
