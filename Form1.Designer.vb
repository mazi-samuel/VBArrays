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
        btnDivisibility = New Button()
        txtArrays = New TextBox()
        lblK = New Label()
        txtK = New TextBox()
        lblResult = New Label()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnDivisibility
        ' 
        btnDivisibility.BackColor = Color.IndianRed
        btnDivisibility.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDivisibility.Location = New Point(367, 252)
        btnDivisibility.Name = "btnDivisibility"
        btnDivisibility.Size = New Size(139, 34)
        btnDivisibility.TabIndex = 0
        btnDivisibility.Text = "CHECK DIVISIBILITY"
        btnDivisibility.UseVisualStyleBackColor = False
        ' 
        ' txtArrays
        ' 
        txtArrays.BackColor = SystemColors.Window
        txtArrays.Location = New Point(396, 124)
        txtArrays.Name = "txtArrays"
        txtArrays.Size = New Size(79, 23)
        txtArrays.TabIndex = 1
        ' 
        ' lblK
        ' 
        lblK.AutoSize = True
        lblK.BackColor = Color.Silver
        lblK.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblK.Location = New Point(58, 132)
        lblK.Name = "lblK"
        lblK.Size = New Size(332, 15)
        lblK.TabIndex = 2
        lblK.Text = "ENTER THE ARRAY OF NUMBERS SEPERATED BY A COMMA"
        ' 
        ' txtK
        ' 
        txtK.BackColor = SystemColors.Window
        txtK.Location = New Point(396, 186)
        txtK.Name = "txtK"
        txtK.Size = New Size(79, 23)
        txtK.TabIndex = 3
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.BackColor = Color.Silver
        lblResult.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResult.Location = New Point(125, 194)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(265, 15)
        lblResult.TabIndex = 4
        lblResult.Text = "ENTER THE INTEGER K TO CHECK DIVISIBILITY"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Disibility_3
        PictureBox1.Location = New Point(-8, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(811, 372)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.IndianRed
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(455, 317)
        Button1.Name = "Button1"
        Button1.Size = New Size(51, 34)
        Button1.TabIndex = 6
        Button1.Text = "EXIT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.IndianRed
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(367, 317)
        Button2.Name = "Button2"
        Button2.Size = New Size(51, 34)
        Button2.TabIndex = 7
        Button2.Text = "CLEAR"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(lblResult)
        Controls.Add(txtK)
        Controls.Add(lblK)
        Controls.Add(txtArrays)
        Controls.Add(btnDivisibility)
        Controls.Add(PictureBox1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "AN APP TO DETERMINE THE NUMBER OF (i,j) PAIRS WHERE I < j AND ar[i] + ar[j] IS DIVISIBLE BY K"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnDivisibility As Button
    Friend WithEvents txtArrays As TextBox
    Friend WithEvents lblK As Label
    Friend WithEvents txtK As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
