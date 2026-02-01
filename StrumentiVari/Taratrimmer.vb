Imports System.ComponentModel
Imports System.Drawing.Text

Public Class Taratrimmer
    Private modificaInCorso As Boolean
    Private zero, fs As Double
    Private diffDesiderata As Double

    Private Sub Taratrimmer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modificaInCorso = False
        zero = 1.0
        fs = 7.34
        diffDesiderata = 6.34
    End Sub

    Private Sub Modifica() Handles BtnValDesModifica.Click
        If modificaInCorso Then
            Dim z, f As String
            z = TxtZeroDesiderato.Text
            fs = TxtFsDesiderato.Text
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
            TxtZeroDesiderato.Focus()
        End If
    End Sub

    Private Sub Calcola()
        Dim zeroAttuale, fsAttuale, diffAttuale, rapporto As Double
        Dim zeroFinale, fsFinale As Double
        CancellaCampi(True, False)
        Try
        zeroAttuale = CDbl(TxtZeroAttuale.Text)
        fsAttuale = CDbl(TxtFsAttuale.Text)
        diffAttuale = fsAttuale - zeroAttuale

        rapporto = diffDesiderata / diffAttuale
        zeroFinale = zeroAttuale * rapporto
        fsFinale = fsAttuale * rapporto

            TxtZeroAttuale.Text = zeroAttuale.ToString("0.000")
            TxtFsAttuale.Text = fsAttuale.ToString("0.000")
        TxtZeroDaTrovare.Text = zeroFinale.ToString("0.000")
        TxtFsDaTrovare.Text = fsFinale.ToString("0.000")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERRORE CALCOLO")
            Exit Sub
        End Try
    End Sub

    Private Sub BtnCalcola_Click(sender As Object, e As EventArgs) Handles BtnCalcola.Click
        Calcola()

        TxtZeroAttuale.Focus()
    End Sub

    Private Sub cancellaCampi()
        CancellaCampi(True, True)
    End Sub
    Private Sub CancellaCampi(daTrovare As Boolean, attuali As Boolean)
        If daTrovare Then
            TxtZeroDaTrovare.Text = "-"
            TxtFsDaTrovare.Text = "-"
        End If
        If attuali Then
            TxtZeroAttuale.Text = ""
            TxtFsAttuale.Text = ""
        End If
    End Sub
End Class