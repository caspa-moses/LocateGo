<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EachCompany
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MoverCard1 = New MoverCard()
        SuspendLayout()
        ' 
        ' MoverCard1
        ' 
        MoverCard1.Location = New Point(129, 12)
        MoverCard1.Name = "MoverCard1"
        MoverCard1.Size = New Size(273, 429)
        MoverCard1.TabIndex = 0
        ' 
        ' EachCompany
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(552, 443)
        Controls.Add(MoverCard1)
        Name = "EachCompany"
        Text = "EachCompany"
        ResumeLayout(False)
    End Sub

    Friend WithEvents MoverCard1 As MoverCard
End Class
