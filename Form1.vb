Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Informations.Click
        'makes label texts visible and makes button invisible
        More_Information.Visible = True
        Button_Informations.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'makes Label text invisible
        More_Information.Visible = False

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Motto_Half.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles More_Information.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Title.Click

    End Sub
End Class
