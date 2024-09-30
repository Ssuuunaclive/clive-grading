<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gradingScale
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
        txtEnterMarks = New Label()
        lblGrade = New Label()
        txtMarks = New TextBox()
        btnEvaluate = New Button()
        txtGrade = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(155, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(364, 25)
        Label1.TabIndex = 0
        Label1.Text = "GRADING SCALE CALCULATOR"
        ' 
        ' txtEnterMarks
        ' 
        txtEnterMarks.AutoSize = True
        txtEnterMarks.Font = New Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtEnterMarks.ForeColor = SystemColors.ControlLightLight
        txtEnterMarks.Location = New Point(12, 93)
        txtEnterMarks.Name = "txtEnterMarks"
        txtEnterMarks.Size = New Size(152, 25)
        txtEnterMarks.TabIndex = 1
        txtEnterMarks.Text = "Enter Marks"
        ' 
        ' lblGrade
        ' 
        lblGrade.AutoSize = True
        lblGrade.Font = New Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGrade.ForeColor = SystemColors.ControlLightLight
        lblGrade.Location = New Point(47, 139)
        lblGrade.Name = "lblGrade"
        lblGrade.Size = New Size(82, 25)
        lblGrade.TabIndex = 2
        lblGrade.Text = "Grade"
        ' 
        ' txtMarks
        ' 
        txtMarks.Location = New Point(178, 95)
        txtMarks.Margin = New Padding(3, 2, 3, 2)
        txtMarks.Name = "txtMarks"
        txtMarks.Size = New Size(403, 23)
        txtMarks.TabIndex = 4
        ' 
        ' btnEvaluate
        ' 
        btnEvaluate.Font = New Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEvaluate.ForeColor = Color.ForestGreen
        btnEvaluate.Location = New Point(268, 187)
        btnEvaluate.Margin = New Padding(3, 2, 3, 2)
        btnEvaluate.Name = "btnEvaluate"
        btnEvaluate.Size = New Size(195, 33)
        btnEvaluate.TabIndex = 5
        btnEvaluate.Text = "Evaluate"
        btnEvaluate.UseVisualStyleBackColor = True
        ' 
        ' txtGrade
        ' 
        txtGrade.Location = New Point(178, 141)
        txtGrade.Margin = New Padding(3, 2, 3, 2)
        txtGrade.Name = "txtGrade"
        txtGrade.Size = New Size(403, 23)
        txtGrade.TabIndex = 6
        ' 
        ' gradingScale
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.HotTrack
        ClientSize = New Size(700, 338)
        Controls.Add(txtGrade)
        Controls.Add(btnEvaluate)
        Controls.Add(txtMarks)
        Controls.Add(lblGrade)
        Controls.Add(txtEnterMarks)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "gradingScale"
        Text = "SSUUNA CLIVE"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtEnterMarks As Label
    Friend WithEvents lblGrade As Label
    Friend WithEvents txtMarks As TextBox
    Friend WithEvents btnEvaluate As Button
    Friend WithEvents txtGrade As TextBox

End Class
