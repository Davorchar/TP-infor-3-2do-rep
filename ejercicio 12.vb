Public Class Form1
    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim num, suma, digito As Integer
        If Integer.TryParse(txtIngresar.Text, num) Then
            While num > 0
                digito = num Mod 10
                suma = suma + digito
                num = Fix(num / 10)
            End While
            While suma > 9
                num = suma
                suma = 0
                While num > 0
                    digito = num Mod 10
                    suma = suma + digito
                    num = Fix(num / 10)
                End While
            End While
        End If
        lblMostrar.Text = "la minima unidad es " & suma

    End Sub
End Class
