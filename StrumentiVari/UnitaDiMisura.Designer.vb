<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnitaDiMisura
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
        TxtDaVal = New TextBox()
        TxtAVal = New TextBox()
        CboxDaUm = New ComboBox()
        CboxAUm = New ComboBox()
        RtbStorico = New RichTextBox()
        BtnCalcola = New Button()
        BtnEsci = New Button()
        SuspendLayout()
        ' 
        ' TxtDaVal
        ' 
        TxtDaVal.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        TxtDaVal.Location = New Point(12, 57)
        TxtDaVal.Name = "TxtDaVal"
        TxtDaVal.Size = New Size(205, 43)
        TxtDaVal.TabIndex = 1
        ' 
        ' TxtAVal
        ' 
        TxtAVal.BackColor = SystemColors.Window
        TxtAVal.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        TxtAVal.Location = New Point(12, 109)
        TxtAVal.Name = "TxtAVal"
        TxtAVal.ReadOnly = True
        TxtAVal.Size = New Size(205, 43)
        TxtAVal.TabIndex = 3
        ' 
        ' CboxDaUm
        ' 
        CboxDaUm.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        CboxDaUm.FormattingEnabled = True
        CboxDaUm.Location = New Point(223, 57)
        CboxDaUm.Name = "CboxDaUm"
        CboxDaUm.Size = New Size(112, 45)
        CboxDaUm.TabIndex = 2
        ' 
        ' CboxAUm
        ' 
        CboxAUm.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        CboxAUm.FormattingEnabled = True
        CboxAUm.Location = New Point(223, 108)
        CboxAUm.Name = "CboxAUm"
        CboxAUm.Size = New Size(112, 45)
        CboxAUm.TabIndex = 4
        ' 
        ' RtbStorico
        ' 
        RtbStorico.Font = New Font("Segoe UI", 10F)
        RtbStorico.Location = New Point(12, 165)
        RtbStorico.Name = "RtbStorico"
        RtbStorico.Size = New Size(423, 226)
        RtbStorico.TabIndex = 7
        RtbStorico.Text = ""
        ' 
        ' BtnCalcola
        ' 
        BtnCalcola.Location = New Point(341, 57)
        BtnCalcola.Name = "BtnCalcola"
        BtnCalcola.Size = New Size(94, 96)
        BtnCalcola.TabIndex = 6
        BtnCalcola.Text = "&CALCOLA"
        BtnCalcola.UseVisualStyleBackColor = True
        ' 
        ' BtnEsci
        ' 
        BtnEsci.Location = New Point(341, 409)
        BtnEsci.Name = "BtnEsci"
        BtnEsci.Size = New Size(94, 29)
        BtnEsci.TabIndex = 8
        BtnEsci.Text = "&Esci"
        BtnEsci.UseVisualStyleBackColor = True
        ' 
        ' UnitaDiMisura
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = BtnEsci
        ClientSize = New Size(451, 450)
        Controls.Add(BtnEsci)
        Controls.Add(BtnCalcola)
        Controls.Add(RtbStorico)
        Controls.Add(CboxAUm)
        Controls.Add(CboxDaUm)
        Controls.Add(TxtAVal)
        Controls.Add(TxtDaVal)
        MaximizeBox = False
        Name = "UnitaDiMisura"
        Text = "UnitaDiMisura"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtDaVal As TextBox
    Friend WithEvents TxtAVal As TextBox
    Friend WithEvents CboxDaUm As ComboBox
    Friend WithEvents CboxAUm As ComboBox
    Friend WithEvents RtbStorico As RichTextBox
    Friend WithEvents BtnCalcola As Button
    Friend WithEvents BtnEsci As Button
End Class
