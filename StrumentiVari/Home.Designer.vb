<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BtnSaluta = New Button()
        BtnConvertitore = New Button()
        SuspendLayout()
        ' 
        ' BtnSaluta
        ' 
        BtnSaluta.Location = New Point(34, 39)
        BtnSaluta.Name = "BtnSaluta"
        BtnSaluta.Size = New Size(139, 45)
        BtnSaluta.TabIndex = 0
        BtnSaluta.Text = "Saluta"
        BtnSaluta.UseVisualStyleBackColor = True
        ' 
        ' BtnConvertitore
        ' 
        BtnConvertitore.Location = New Point(34, 90)
        BtnConvertitore.Name = "BtnConvertitore"
        BtnConvertitore.Size = New Size(139, 44)
        BtnConvertitore.TabIndex = 1
        BtnConvertitore.Text = "Convertitore"
        BtnConvertitore.UseVisualStyleBackColor = True
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnConvertitore)
        Controls.Add(BtnSaluta)
        Name = "Home"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnSaluta As Button
    Friend WithEvents BtnConvertitore As Button

End Class
