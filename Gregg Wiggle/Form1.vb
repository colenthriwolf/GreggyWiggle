Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim msg = "You booped Gregg's Snoot!"
        Dim title = "Boop!"
        MsgBox(msg, , title)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim chng = "Changelog:
        - Integrated boop feature.
        - Now 15% more infectious."
        Dim title2 = "Changelog"
        MsgBox(chng, , title2)
    End Sub
End Class
