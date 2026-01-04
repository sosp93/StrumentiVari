Imports System.Drawing.Text
Imports System.Globalization
Imports System.Security.Cryptography.X509Certificates

Public Class UnitaDiMisura
    Protected unitaMisura As New Dictionary(Of String, Double)
    'nome dell'unità di misura, valore pari a 1kg

    Private Sub UnitaDiMisura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        unitaMisura.Add("kg", 1)
        unitaMisura.Add("N", 9.806)
        unitaMisura.Add("daN", 0.9806)
        unitaMisura.Add("kN", 0.009806)
        unitaMisura.Add("g", 1000)
        unitaMisura.Add("hg", 10)
        unitaMisura.Add("q", 0.01)
        unitaMisura.Add("ton", 0.001)
        unitaMisura.Add("lb", 2.205)
        unitaMisura.Add("oz", 35.274)

        Dim name As String
        Dim val As Double

        For Each item In unitaMisura
            CboxDaUm.Items.Add(item.Key)
            CboxAUm.Items.Add(item.Key)
            'RichTextBox1.Text = RichTextBox1.Text & vbCrLf & item.ToString & " - CHIAVE" & item.Key & " - VALORE " & item.Value
        Next
        CboxDaUm.SelectedIndex = 0
        'CboxAUm.SelectedIndex = 1
    End Sub

    Private Sub BtnCalcola_Click(sender As Object, e As EventArgs) Handles BtnCalcola.Click
        Dim value As Double
        Calcola()
        Exit Sub


        Try
            unitaMisura.TryGetValue(CboxAUm.SelectedItem, value)
        Catch ex As Exception
            MsgBox(ex.Message)
            If CboxAUm.SelectedItem Is Nothing Then
                MsgBox("ciao")
            End If
        End Try
        RichTextBox1.Text = value
    End Sub

    Private Sub Calcola()
        'controlli
        If CboxDaUm.SelectedItem Is Nothing Then MsgBox("Unità misura di partenza non selezionata: imposto kg", vbExclamation) : CboxDaUm.SelectedItem = "kg"
        If CboxAUm.SelectedIndex < 0 Then MsgBox("Unità misura di destinazione non selezionata: imposto N", vbExclamation) : CboxAUm.SelectedItem = "N"
        If Not IsNumeric(TxtDaVal.Text) Then
            MsgBox("Inserisci un valore da convertire." & vbCrLf & "Sono accettati solamente numeri.", vbExclamation, "Errore valore")
            TxtDaVal.SelectAll()
            Exit Sub
        End If

        Dim coefficienteDa, coefficienteA As Double
        Dim iniziale, risultato As Double
        iniziale = CDbl(TxtDaVal.Text)

        unitaMisura.TryGetValue(CboxDaUm.SelectedItem, coefficienteDa)
        unitaMisura.TryGetValue(CboxAUm.SelectedItem, coefficienteA)

        risultato = iniziale / coefficienteDa * coefficienteA

        TxtAVal.Text = risultato.ToString("G", New CultureInfo("it-IT"))
        TxtDaVal.Focus()
        TxtDaVal.SelectAll()
    End Sub

    Private Sub CambiaPuntoInVirgola(sender As Object, e As KeyPressEventArgs) Handles TxtDaVal.KeyPress, TxtAVal.KeyPress
        If e.KeyChar = "." Then
            If sender.Text.contains(",") Then e.Handled = True
            e.KeyChar = ","
        ElseIf e.KeyChar = "," Then
            If sender.Text.contains(",") Then e.Handled = True
        End If
    End Sub

    Private Sub NumericValidation(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtAVal.Validating, TxtDaVal.Validating
        'Dim pattern = "[0-9][0-9]*(\,[0-9]+)?"
        If sender.text = Nothing Then
            e.Cancel = False
        ElseIf IsNumeric(sender.Text) Then
            e.Cancel = False
            sender.text = CDbl(sender.text).ToString("G", New CultureInfo("it-IT"))
        Else
            e.Cancel = True
            MsgBox("Puoi inserire solo valori numerici" & vbCrLf & vbCrLf & "Cifre e al massimo una virgola", vbObjectError, "ERRORE")
            sender.SelectAll
        End If
    End Sub

    Private Sub TxtDaVal_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtDaVal.KeyDown
        If e.KeyCode = Keys.Enter Then Calcola() : e.Handled = True : e.SuppressKeyPress = True
    End Sub

    Private Sub PremiInvioCbox(sender As Object, e As KeyEventArgs) Handles CboxDaUm.KeyDown, CboxAUm.KeyDown
        Dim cb As ComboBox
        cb = sender
        If e.KeyCode = Keys.Enter Then
            Calcola()
            e.Handled = True
            'affinchè non faccia il suono di errore quando premo invio sul combobox chiuso, devo mettere true
            'ma devo mettere false quando è aperto per poter selezionare con la tastiera
            If cb.DroppedDown Then e.SuppressKeyPress = False Else e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub CboxDaUm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboxDaUm.SelectedIndexChanged, CboxAUm.SelectedIndexChanged, TxtDaVal.TextChanged
        TxtAVal.Text = ""
    End Sub
End Class