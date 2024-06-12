Public Class Form1
    Dim suma As Integer = 0
    Dim mayor As Integer = Integer.MinValue
    Dim menor As Integer = Integer.MaxValue
    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim num As Integer
        If Integer.TryParse(txtIngresar.Text, num) Then
            If num = -999 Then
                txtIngresar.Enabled = False
                cmdAgregar.Enabled = False
            Else
                suma = suma + num
                If num > mayor Then
                    mayor = num
                End If
                If num < menor Then
                    menor = num
                End If
            End If
        End If
        txtIngresar.Clear()
        txtIngresar.Focus()

    End Sub
    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        lblMostrarMa.Text = "el mayor es " & mayor
        lblMostrarMe.Text = "el menor es " & menor
        lblMostrarSum.Text = "la suma de los numeros es " & suma
    End Sub
End Class
