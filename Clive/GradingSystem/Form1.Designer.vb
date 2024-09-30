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
        TextBox1 = New TextBox()
        Label1 = New Label()
        txtmarks = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        txtgrade = New TextBox()
        btnEvaluate = New Button()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(247, 131)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(256, 27)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(151, 134)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 20)
        Label1.TabIndex = 2
        Label1.Text = "Label1"
        ' 
        ' txtmarks
        ' 
        txtmarks.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtmarks.Location = New Point(247, 131)
        txtmarks.Name = "txtmarks"
        txtmarks.Size = New Size(256, 27)
        txtmarks.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(127, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 20)
        Label2.TabIndex = 2
        Label2.Text = "Enter Marks"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(170, 197)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 20)
        Label3.TabIndex = 4
        Label3.Text = "Grade"
        ' 
        ' txtgrade
        ' 
        txtgrade.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtgrade.Location = New Point(247, 190)
        txtgrade.Name = "txtgrade"
        txtgrade.Size = New Size(256, 27)
        txtgrade.TabIndex = 3
        ' 
        ' btnEvaluate
        ' 
        btnEvaluate.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEvaluate.Location = New Point(247, 255)
        btnEvaluate.Name = "btnEvaluate"
        btnEvaluate.Size = New Size(108, 43)
        btnEvaluate.TabIndex = 5
        btnEvaluate.Text = "EVALUATE"
        btnEvaluate.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(109, 40)
        Label4.Name = "Label4"
        Label4.Size = New Size(410, 34)
        Label4.TabIndex = 6
        Label4.Text = "GRADING SCALE CALCULATOR"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(624, 376)
        Controls.Add(Label4)
        Controls.Add(btnEvaluate)
        Controls.Add(Label3)
        Controls.Add(txtgrade)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtmarks)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Grading Scale Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtmarks As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtgrade As TextBox
    Friend WithEvents btnEvaluate As Button
    Friend WithEvents Label4 As Label

End Class
