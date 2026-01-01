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
        SuspendLayout()
        ' 
        ' BtnSaluta
        ' 
        BtnSaluta.Location = New Point(34, 39)
        BtnSaluta.Name = "BtnSaluta"
        BtnSaluta.Size = New Size(139, 83)
        BtnSaluta.TabIndex = 0
        BtnSaluta.Text = "Saluta"
        BtnSaluta.UseVisualStyleBackColor = True
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnSaluta)
        Name = "Home"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnSaluta As Button

End Class
