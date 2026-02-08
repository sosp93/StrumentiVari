Public Class Taratura
    Private zeroDesiderato As Double
    Private fsDesiderato As Double
    Private diffDesiderata As Double

    Public Sub New(zero As Double, fondoscala As Double)
        Me.zeroDesiderato = zero
        Me.fsDesiderato = fondoscala
        Me.diffDesiderata = fsDesiderato - zeroDesiderato
    End Sub
    Public Sub New(zeroString As String, fondoscalaString As String)
        If Not IsNumeric(zeroString) Then Throw New System.Exception("Zero non è un valore numerico")
        If Not IsNumeric(fondoscalaString) Then Throw New System.Exception("Fondoscala non è un valore numerico")
        Me.zeroDesiderato = CDbl(zeroString)
        Me.fsDesiderato = CDbl(fondoscalaString)
        Me.diffDesiderata = fsDesiderato - zeroDesiderato
    End Sub

    Private Function getRapportoTaratura(zeroAttuale As Double, fsAttuale As Double) As Double
        Return diffDesiderata / (fsAttuale - zeroAttuale)
    End Function

    Public Function daTrovareFs(zeroAttuale As Double, fsAttuale As Double) As Double
        'Dim diffAttuale As Double
        'diffAttuale = fsAttuale - zeroAttuale
        'Return fsAttuale / diffAttuale * diffDesiderata
        Return fsAttuale * getRapportoTaratura(zeroAttuale, fsAttuale)
    End Function

    Public Function daTrovareZero(zeroAttuale As Double, fsAttuale As Double) As Double
        Return zeroAttuale * getRapportoTaratura(zeroAttuale, fsAttuale)
    End Function


End Class
