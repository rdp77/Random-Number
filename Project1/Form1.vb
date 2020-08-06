Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Start" Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
        If Timer1.Enabled = True Then
            Button1.Text = "Stop"
        End If
        If Timer1.Enabled = False Then
            Button1.Text = "Start"
        End If
        TextBox1.Text = Label1.Text + Label2.Text + Label3.Text
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim Acak As Integer
        Dim Awal As Integer = 1
        Dim Akhir As Integer = 10
        Randomize()
        Acak = CInt(Int((Akhir - Awal + 1) * Rnd() + Awal))
        Label1.Text = Int(Rnd() * 10)
        Label2.Text = Int(Rnd() * 10)
        Label3.Text = Int(Rnd() * 10)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label1.Text = "0"
        Label2.Text = "0"
        Label3.Text = "0"
        TextBox1.Clear()
    End Sub

End Class