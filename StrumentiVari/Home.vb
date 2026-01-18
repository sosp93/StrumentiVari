Public Class Home
    Private Sub BtnSaluta_Click(sender As Object, e As EventArgs) Handles BtnSaluta.Click
        MsgBox("Benvenuto!", vbOKOnly, "Placeholder")
    End Sub

    Private Sub BtnConvertitore_Click(sender As Object, e As EventArgs) Handles BtnConvertitore.Click
        UnitaDiMisura.Show()
    End Sub

    Private Sub BtnTaratrimmer_Click(sender As Object, e As EventArgs) Handles BtnTaratrimmer.Click
        Taratrimmer.Show()
    End Sub
End Class
