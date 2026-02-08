<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Taratrimmer
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        GBoxValoriDesiderati = New GroupBox()
        BtnValDesModifica = New Button()
        TxtFsDesiderato = New TextBox()
        LblFsDesiderato = New Label()
        TxtZeroDesiderato = New TextBox()
        LblZeroDesiderato = New Label()
        GBoxValoriAttuali = New GroupBox()
        BtnCalcola = New Button()
        TxtFsAttuale = New TextBox()
        LblFsAttuale = New Label()
        TxtZeroAttuale = New TextBox()
        LblZeroAttuale = New Label()
        GBoxDaTrovare = New GroupBox()
        Label3 = New Label()
        TxtFsDaTrovare = New TextBox()
        LblFsDaTrovare = New Label()
        TxtZeroDaTrovare = New TextBox()
        LblZeroDaTrovare = New Label()
        GBoxValoriDesiderati.SuspendLayout()
        GBoxValoriAttuali.SuspendLayout()
        GBoxDaTrovare.SuspendLayout()
        SuspendLayout()
        ' 
        ' GBoxValoriDesiderati
        ' 
        GBoxValoriDesiderati.Controls.Add(BtnValDesModifica)
        GBoxValoriDesiderati.Controls.Add(TxtFsDesiderato)
        GBoxValoriDesiderati.Controls.Add(LblFsDesiderato)
        GBoxValoriDesiderati.Controls.Add(TxtZeroDesiderato)
        GBoxValoriDesiderati.Controls.Add(LblZeroDesiderato)
        GBoxValoriDesiderati.Location = New Point(12, 12)
        GBoxValoriDesiderati.Name = "GBoxValoriDesiderati"
        GBoxValoriDesiderati.Size = New Size(279, 179)
        GBoxValoriDesiderati.TabIndex = 0
        GBoxValoriDesiderati.TabStop = False
        GBoxValoriDesiderati.Text = "Valori desiderati"
        ' 
        ' BtnValDesModifica
        ' 
        BtnValDesModifica.Location = New Point(148, 139)
        BtnValDesModifica.Name = "BtnValDesModifica"
        BtnValDesModifica.Size = New Size(125, 29)
        BtnValDesModifica.TabIndex = 30
        BtnValDesModifica.Text = "Modifica"
        BtnValDesModifica.UseVisualStyleBackColor = True
        ' 
        ' TxtFsDesiderato
        ' 
        TxtFsDesiderato.Font = New Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold)
        TxtFsDesiderato.Location = New Point(148, 85)
        TxtFsDesiderato.Name = "TxtFsDesiderato"
        TxtFsDesiderato.ReadOnly = True
        TxtFsDesiderato.Size = New Size(125, 51)
        TxtFsDesiderato.TabIndex = 20
        TxtFsDesiderato.Text = "7,34"
        TxtFsDesiderato.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblFsDesiderato
        ' 
        LblFsDesiderato.AutoSize = True
        LblFsDesiderato.Location = New Point(6, 108)
        LblFsDesiderato.Name = "LblFsDesiderato"
        LblFsDesiderato.Size = New Size(84, 20)
        LblFsDesiderato.TabIndex = 0
        LblFsDesiderato.Text = "Fondoscala"
        ' 
        ' TxtZeroDesiderato
        ' 
        TxtZeroDesiderato.Font = New Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold)
        TxtZeroDesiderato.Location = New Point(148, 28)
        TxtZeroDesiderato.Name = "TxtZeroDesiderato"
        TxtZeroDesiderato.ReadOnly = True
        TxtZeroDesiderato.Size = New Size(125, 51)
        TxtZeroDesiderato.TabIndex = 10
        TxtZeroDesiderato.Text = "1,00"
        TxtZeroDesiderato.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblZeroDesiderato
        ' 
        LblZeroDesiderato.AutoSize = True
        LblZeroDesiderato.Location = New Point(6, 51)
        LblZeroDesiderato.Name = "LblZeroDesiderato"
        LblZeroDesiderato.Size = New Size(40, 20)
        LblZeroDesiderato.TabIndex = 0
        LblZeroDesiderato.Text = "Zero"
        ' 
        ' GBoxValoriAttuali
        ' 
        GBoxValoriAttuali.Controls.Add(BtnCalcola)
        GBoxValoriAttuali.Controls.Add(TxtFsAttuale)
        GBoxValoriAttuali.Controls.Add(LblFsAttuale)
        GBoxValoriAttuali.Controls.Add(TxtZeroAttuale)
        GBoxValoriAttuali.Controls.Add(LblZeroAttuale)
        GBoxValoriAttuali.Location = New Point(12, 197)
        GBoxValoriAttuali.Name = "GBoxValoriAttuali"
        GBoxValoriAttuali.Size = New Size(279, 183)
        GBoxValoriAttuali.TabIndex = 1
        GBoxValoriAttuali.TabStop = False
        GBoxValoriAttuali.Text = "Valori attuali"
        ' 
        ' BtnCalcola
        ' 
        BtnCalcola.Location = New Point(148, 148)
        BtnCalcola.Name = "BtnCalcola"
        BtnCalcola.Size = New Size(125, 29)
        BtnCalcola.TabIndex = 30
        BtnCalcola.Text = "Calcola"
        BtnCalcola.UseVisualStyleBackColor = True
        ' 
        ' TxtFsAttuale
        ' 
        TxtFsAttuale.Font = New Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold)
        TxtFsAttuale.Location = New Point(148, 83)
        TxtFsAttuale.Name = "TxtFsAttuale"
        TxtFsAttuale.Size = New Size(125, 51)
        TxtFsAttuale.TabIndex = 20
        TxtFsAttuale.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblFsAttuale
        ' 
        LblFsAttuale.AutoSize = True
        LblFsAttuale.Location = New Point(6, 106)
        LblFsAttuale.Name = "LblFsAttuale"
        LblFsAttuale.Size = New Size(84, 20)
        LblFsAttuale.TabIndex = 0
        LblFsAttuale.Text = "Fondoscala"
        ' 
        ' TxtZeroAttuale
        ' 
        TxtZeroAttuale.Font = New Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold)
        TxtZeroAttuale.Location = New Point(148, 26)
        TxtZeroAttuale.Name = "TxtZeroAttuale"
        TxtZeroAttuale.Size = New Size(125, 51)
        TxtZeroAttuale.TabIndex = 1
        TxtZeroAttuale.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblZeroAttuale
        ' 
        LblZeroAttuale.AutoSize = True
        LblZeroAttuale.Location = New Point(6, 49)
        LblZeroAttuale.Name = "LblZeroAttuale"
        LblZeroAttuale.Size = New Size(40, 20)
        LblZeroAttuale.TabIndex = 0
        LblZeroAttuale.Text = "Zero"
        ' 
        ' GBoxDaTrovare
        ' 
        GBoxDaTrovare.Controls.Add(Label3)
        GBoxDaTrovare.Controls.Add(TxtFsDaTrovare)
        GBoxDaTrovare.Controls.Add(LblFsDaTrovare)
        GBoxDaTrovare.Controls.Add(TxtZeroDaTrovare)
        GBoxDaTrovare.Controls.Add(LblZeroDaTrovare)
        GBoxDaTrovare.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GBoxDaTrovare.Location = New Point(12, 386)
        GBoxDaTrovare.Name = "GBoxDaTrovare"
        GBoxDaTrovare.Size = New Size(279, 195)
        GBoxDaTrovare.TabIndex = 2
        GBoxDaTrovare.TabStop = False
        GBoxDaTrovare.Text = "Da trovare"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(195, 40)
        Label3.TabIndex = 1
        Label3.Text = "Regola il trimmer del FS per" & vbCrLf & "trovare i seguenti valori"
        ' 
        ' TxtFsDaTrovare
        ' 
        TxtFsDaTrovare.Font = New Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold)
        TxtFsDaTrovare.Location = New Point(148, 128)
        TxtFsDaTrovare.Name = "TxtFsDaTrovare"
        TxtFsDaTrovare.ReadOnly = True
        TxtFsDaTrovare.Size = New Size(125, 51)
        TxtFsDaTrovare.TabIndex = 20
        TxtFsDaTrovare.Text = "--,--"
        TxtFsDaTrovare.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblFsDaTrovare
        ' 
        LblFsDaTrovare.AutoSize = True
        LblFsDaTrovare.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LblFsDaTrovare.Location = New Point(6, 144)
        LblFsDaTrovare.Name = "LblFsDaTrovare"
        LblFsDaTrovare.Size = New Size(113, 28)
        LblFsDaTrovare.TabIndex = 0
        LblFsDaTrovare.Text = "Fondoscala"
        ' 
        ' TxtZeroDaTrovare
        ' 
        TxtZeroDaTrovare.Font = New Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold)
        TxtZeroDaTrovare.Location = New Point(148, 71)
        TxtZeroDaTrovare.Name = "TxtZeroDaTrovare"
        TxtZeroDaTrovare.ReadOnly = True
        TxtZeroDaTrovare.Size = New Size(125, 51)
        TxtZeroDaTrovare.TabIndex = 10
        TxtZeroDaTrovare.Text = "--,--"
        TxtZeroDaTrovare.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblZeroDaTrovare
        ' 
        LblZeroDaTrovare.AutoSize = True
        LblZeroDaTrovare.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LblZeroDaTrovare.Location = New Point(6, 87)
        LblZeroDaTrovare.Name = "LblZeroDaTrovare"
        LblZeroDaTrovare.Size = New Size(54, 28)
        LblZeroDaTrovare.TabIndex = 0
        LblZeroDaTrovare.Text = "Zero"
        ' 
        ' Taratrimmer
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(306, 590)
        Controls.Add(GBoxDaTrovare)
        Controls.Add(GBoxValoriAttuali)
        Controls.Add(GBoxValoriDesiderati)
        KeyPreview = True
        Name = "Taratrimmer"
        Text = "Taratrimmer"
        GBoxValoriDesiderati.ResumeLayout(False)
        GBoxValoriDesiderati.PerformLayout()
        GBoxValoriAttuali.ResumeLayout(False)
        GBoxValoriAttuali.PerformLayout()
        GBoxDaTrovare.ResumeLayout(False)
        GBoxDaTrovare.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GBoxValoriDesiderati As GroupBox
    Friend WithEvents LblZeroDesiderato As Label
    Friend WithEvents TxtZeroDesiderato As TextBox
    Friend WithEvents TxtFsDesiderato As TextBox
    Friend WithEvents LblFsDesiderato As Label
    Friend WithEvents BtnValDesModifica As Button
    Friend WithEvents GBoxValoriAttuali As GroupBox
    Friend WithEvents BtnCalcola As Button
    Friend WithEvents TxtFsAttuale As TextBox
    Friend WithEvents LblFsAttuale As Label
    Friend WithEvents TxtZeroAttuale As TextBox
    Friend WithEvents LblZeroAttuale As Label
    Friend WithEvents GBoxDaTrovare As GroupBox
    Friend WithEvents TxtFsDaTrovare As TextBox
    Friend WithEvents LblFsDaTrovare As Label
    Friend WithEvents TxtZeroDaTrovare As TextBox
    Friend WithEvents LblZeroDaTrovare As Label
    Friend WithEvents Label3 As Label
End Class
