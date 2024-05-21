Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BtnPerkalian_Click(sender As Object, e As EventArgs) Handles BtnPerkalian.Click
        MsgBox("Perkalian : " & Val(TxtBil1.Text) * Val(TxtBil2.Text))
    End Sub
End Class
