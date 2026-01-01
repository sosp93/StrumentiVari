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
        RichTextBox1 = New RichTextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' TxtDaVal
        ' 
        TxtDaVal.Location = New Point(12, 57)
        TxtDaVal.Name = "TxtDaVal"
        TxtDaVal.Size = New Size(125, 27)
        TxtDaVal.TabIndex = 1
        ' 
        ' TxtAVal
        ' 
        TxtAVal.Location = New Point(367, 57)
        TxtAVal.Name = "TxtAVal"
        TxtAVal.Size = New Size(125, 27)
        TxtAVal.TabIndex = 3
        ' 
        ' CboxDaUm
        ' 
        CboxDaUm.FormattingEnabled = True
        CboxDaUm.Location = New Point(143, 57)
        CboxDaUm.Name = "CboxDaUm"
        CboxDaUm.Size = New Size(151, 28)
        CboxDaUm.TabIndex = 2
        ' 
        ' CboxAUm
        ' 
        CboxAUm.FormattingEnabled = True
        CboxAUm.Location = New Point(498, 56)
        CboxAUm.Name = "CboxAUm"
        CboxAUm.Size = New Size(151, 28)
        CboxAUm.TabIndex = 4
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(12, 103)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(449, 288)
        RichTextBox1.TabIndex = 5
        RichTextBox1.Text = ""
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(523, 156)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 6
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' UnitaDiMisura
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(RichTextBox1)
        Controls.Add(CboxAUm)
        Controls.Add(CboxDaUm)
        Controls.Add(TxtAVal)
        Controls.Add(TxtDaVal)
        Name = "UnitaDiMisura"
        Text = "UnitaDiMisura"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtDaVal As TextBox
    Friend WithEvents TxtAVal As TextBox
    Friend WithEvents CboxDaUm As ComboBox
    Friend WithEvents CboxAUm As ComboBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
End Class
