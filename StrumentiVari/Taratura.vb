Public Class Taratura
    Private zeroDesiderato As Double
    Private fsDesiderato As Double
    Private diffDesiderata As Double

    Public Sub New(zero As Double, fondoscala As Double)
        Me.zeroDesiderato = zero
        Me.fsDesiderato = fondoscala
        Me.diffDesiderata = fsDesiderato - zeroDesiderato
    End Sub

    Private Function getRapportoTaratura(zeroAttuale As Double, fsAttuale As Double)
        Return diffDesiderata / (fsAttuale - zeroAttuale)
    End Function

    Public Function daTrovareFs(zeroAttuale As Double, fsAttuale As Double)
        'Dim diffAttuale As Double
        'diffAttuale = fsAttuale - zeroAttuale
        'Return fsAttuale / diffAttuale * diffDesiderata
        Return fsAttuale * getRapportoTaratura(zeroAttuale, fsAttuale)
    End Function

    Public Function daTrovareZero(zeroAttuale As Double, fsAttuale As Double)
        Return zeroAttuale * getRapportoTaratura(zeroAttuale, fsAttuale)
    End Function


End Class
