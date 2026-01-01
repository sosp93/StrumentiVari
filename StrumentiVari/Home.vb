Public Class Home
    Private Sub BtnSaluta_Click(sender As Object, e As EventArgs) Handles BtnSaluta.Click
        MsgBox("Benvenuto!", vbOKOnly, "Placeholder")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UnitaDiMisura.Show()
    End Sub
End Class
