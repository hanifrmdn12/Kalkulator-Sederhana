<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        TxtBil1 = New TextBox()
        TxtBil2 = New TextBox()
        BtnPerkalian = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(284, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 25)
        Label1.TabIndex = 0
        Label1.Text = "Bilangan 1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(284, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 25)
        Label2.TabIndex = 1
        Label2.Text = "Bilangan 2"
        ' 
        ' TxtBil1
        ' 
        TxtBil1.Location = New Point(383, 68)
        TxtBil1.Name = "TxtBil1"
        TxtBil1.Size = New Size(175, 31)
        TxtBil1.TabIndex = 2
        ' 
        ' TxtBil2
        ' 
        TxtBil2.Location = New Point(383, 105)
        TxtBil2.Name = "TxtBil2"
        TxtBil2.Size = New Size(175, 31)
        TxtBil2.TabIndex = 3
        ' 
        ' BtnPerkalian
        ' 
        BtnPerkalian.Location = New Point(367, 169)
        BtnPerkalian.Name = "BtnPerkalian"
        BtnPerkalian.Size = New Size(112, 34)
        BtnPerkalian.TabIndex = 4
        BtnPerkalian.Text = "Perkalian"
        BtnPerkalian.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnPerkalian)
        Controls.Add(TxtBil2)
        Controls.Add(TxtBil1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBil1 As TextBox
    Friend WithEvents TxtBil2 As TextBox
    Friend WithEvents BtnPerkalian As Button

End Class
