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
        btnByRef = New Button()
        btnByVal = New Button()
        btnClose = New Button()
        lblHeading = New Label()
        lblnput = New Label()
        txtNumber = New TextBox()
        SuspendLayout()
        ' 
        ' btnByRef
        ' 
        btnByRef.Location = New Point(244, 303)
        btnByRef.Name = "btnByRef"
        btnByRef.Size = New Size(94, 29)
        btnByRef.TabIndex = 0
        btnByRef.Text = "By Ref"
        btnByRef.UseVisualStyleBackColor = True
        ' 
        ' btnByVal
        ' 
        btnByVal.Location = New Point(487, 303)
        btnByVal.Name = "btnByVal"
        btnByVal.Size = New Size(94, 29)
        btnByVal.TabIndex = 0
        btnByVal.Text = "By Val"
        btnByVal.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(364, 374)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 0
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Snap ITC", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblHeading.ForeColor = SystemColors.Highlight
        lblHeading.Location = New Point(187, 42)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(394, 36)
        lblHeading.TabIndex = 1
        lblHeading.Text = "Calculate Square Root"
        ' 
        ' lblnput
        ' 
        lblnput.AutoSize = True
        lblnput.Location = New Point(95, 182)
        lblnput.Name = "lblnput"
        lblnput.Size = New Size(295, 20)
        lblnput.TabIndex = 2
        lblnput.Text = "Input a Number to calculate its Square root"
        ' 
        ' txtNumber
        ' 
        txtNumber.Location = New Point(487, 182)
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(125, 27)
        txtNumber.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(txtNumber)
        Controls.Add(lblnput)
        Controls.Add(lblHeading)
        Controls.Add(btnByVal)
        Controls.Add(btnClose)
        Controls.Add(btnByRef)
        Name = "Form1"
        Text = "Square Root Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnByRef As Button
    Friend WithEvents btnByVal As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblnput As Label
    Friend WithEvents txtNumber As TextBox
End Class
