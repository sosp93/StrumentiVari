Public Class Taratura
    Private zeroDesiderato As Double
    Private fsDesiderato As Double
    Private diffDesiderata As Double
    Private stringaFormatoValori As String

    Public Sub New(zero As Double, fondoscala As Double)
        Me.zeroDesiderato = zero
        Me.fsDesiderato = fondoscala
        Me.diffDesiderata = fsDesiderato - zeroDesiderato
        Me.stringaFormatoValori = "0.000"
    End Sub
    Public Sub New(zeroString As String, fondoscalaString As String)
        If Not IsNumeric(zeroString) Then Throw New System.Exception("Zero non è un valore numerico")
        If Not IsNumeric(fondoscalaString) Then Throw New System.Exception("Fondoscala non è un valore numerico")
        Me.zeroDesiderato = CDbl(zeroString)
        Me.fsDesiderato = CDbl(fondoscalaString)
        Me.diffDesiderata = fsDesiderato - zeroDesiderato
        Me.stringaFormatoValori = "0.000"
    End Sub

    Public Function setDecimali(cifre As Short) As Boolean
        Dim i As Short
        Dim s As String
        If cifre = 0 Then
            s = "0"
            Return True
        ElseIf cifre >= 0 Then
            s = "0."
            For i = 1 To cifre
                s &= "0"
            Next
            Return True
        End If
        Return False
    End Function

    Private Function getRapportoTaratura(zeroAttuale As Double, fsAttuale As Double) As Double
        Return diffDesiderata / (fsAttuale - zeroAttuale)
    End Function

    'restituiscono i valori calcolati in formato numerico
    Public Function daTrovareFs(zeroAttuale As Double, fsAttuale As Double) As Double
        Return fsAttuale * getRapportoTaratura(zeroAttuale, fsAttuale)
    End Function

    Public Function daTrovareZero(zeroAttuale As Double, fsAttuale As Double) As Double
        Return zeroAttuale * getRapportoTaratura(zeroAttuale, fsAttuale)
    End Function

    'Restituiscono valori calcolati in stringa con quantità decimali impostata
    Public Function daTrovareFsString(zeroAttuale As Double, fsAttuale As Double)
        Return daTrovareFs(zeroAttuale, fsAttuale).ToString(stringaFormatoValori)
    End Function
    Public Function daTrovareZeroString(zeroAttuale As Double, fsAttuale As Double) As String
        Return daTrovareZero(zeroAttuale, fsAttuale).ToString(stringaFormatoValori)
    End Function

End Class
