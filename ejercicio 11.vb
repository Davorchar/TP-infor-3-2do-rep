Public Class Form1
    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim cuenta1, cuenta2, cuenta3, cuenta4, cuenta5, cuenta6, cuenta7, cuenta8, cuenta9 As Integer

        For cuenta1 = 101 To 191 Step 10
            ListBox1.Items.Add(cuenta1)
        Next
        For cuenta2 = 202 To 292 Step 10
            ListBox1.Items.Add(cuenta2)
        Next
        For cuenta3 = 303 To 393 Step 10
            ListBox1.Items.Add(cuenta3)
        Next
        For cuenta4 = 404 To 494 Step 10
            ListBox1.Items.Add(cuenta4)
        Next
        For cuenta5 = 505 To 595 Step 10
            ListBox1.Items.Add(cuenta5)
        Next
        For cuenta6 = 606 To 696 Step 10
            ListBox1.Items.Add(cuenta6)
        Next
        For cuenta7 = 707 To 797 Step 10
            ListBox1.Items.Add(cuenta7)
        Next
        For cuenta8 = 808 To 898 Step 10
            ListBox1.Items.Add(cuenta8)
        Next
        For cuenta9 = 909 To 999 Step 10
            ListBox1.Items.Add(cuenta9)
        Next
    End Sub
End Class
