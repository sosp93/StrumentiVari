Imports System.Drawing.Text

Public Class Taratrimmer
    Private modificaInCorso As Boolean
    Private zero, fs As Double


    Private Sub Taratrimmer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modificaInCorso = False
        zero = 1.0
        fs = 7.34
    End Sub

    Private Sub Modifica() Handles BtnValDesModifica.Click
        If modificaInCorso Then
            Dim z, f As String
            z = TxtZeroDesiderato.Text
            f = TxtFsDesiderato.Text
            'controllo che i due valori siano numerici
            If Not IsNumeric(z) Then MsgBox("Correggi il valore di zero.", vbAbort, "Necessario valore numerico") : Exit Sub
            If Not IsNumeric(fs) Then MsgBox("Correggi il valore di zero.", vbAbort, "Necessario valore numerico") : Exit Sub
            'salvo i numeri nelle variabili
            zero = CDbl(z)
            fs = CDbl(fs)
            'riscrivo i valori così come arrivano dalle variabili
            TxtZeroDesiderato.Text = zero.ToString("#0.00")
            TxtFsDesiderato.Text = fs.ToString("#0.00")

            modificaInCorso = False 'modifica terminata
            GBoxValoriAttuali.Enabled = True
            TxtZeroDesiderato.ReadOnly = True
            TxtFsDesiderato.ReadOnly = True
        Else
            modificaInCorso = True 'modifica iniziata
            GBoxValoriAttuali.Enabled = False
            TxtZeroDesiderato.ReadOnly = False
            TxtFsDesiderato.ReadOnly = False
        End If
    End Sub
End Class