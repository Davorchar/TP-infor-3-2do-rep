Public Class Form1
    Dim suma, cuenta As Integer
    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim num As Integer
        If Integer.TryParse(txtBox.Text, num) Then

            If num = 0 Then
                txtBox.Enabled = False
                cmdAgregar.Enabled = False
            Else
                suma += num
                cuenta += 1
                txtBox.Clear()
                txtBox.Focus()
            End If
        End If
    End Sub

    Private Sub CmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim promedio As Double
        If cuenta > 0 Then
            promedio = suma / cuenta
        Else
            promedio = 0
        End If
        lblMostar1.Text = "la suma es " & suma
        lblMostrar2.Text = "se ingresaron " & cuenta & "numeros"
        lblMostrar3.Text = "el promedio es " & promedio

    End Sub



End Class
