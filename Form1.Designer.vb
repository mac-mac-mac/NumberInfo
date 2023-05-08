<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radWord = New System.Windows.Forms.RadioButton()
        Me.radPrimes = New System.Windows.Forms.RadioButton()
        Me.radRoman = New System.Windows.Forms.RadioButton()
        Me.radHex = New System.Windows.Forms.RadioButton()
        Me.radBin = New System.Windows.Forms.RadioButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblNumberInfo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.Font = New System.Drawing.Font("Trebuchet MS", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Gold
        Me.lblHeading.Location = New System.Drawing.Point(12, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(710, 100)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "NUMBER INFO"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radWord)
        Me.GroupBox1.Controls.Add(Me.radPrimes)
        Me.GroupBox1.Controls.Add(Me.radRoman)
        Me.GroupBox1.Controls.Add(Me.radHex)
        Me.GroupBox1.Controls.Add(Me.radBin)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnCalculate)
        Me.GroupBox1.Controls.Add(Me.txtNumber)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 212)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(710, 125)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'radWord
        '
        Me.radWord.AutoSize = True
        Me.radWord.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radWord.ForeColor = System.Drawing.Color.Maroon
        Me.radWord.Location = New System.Drawing.Point(462, 93)
        Me.radWord.Name = "radWord"
        Me.radWord.Size = New System.Drawing.Size(130, 22)
        Me.radWord.TabIndex = 7
        Me.radWord.TabStop = True
        Me.radWord.Text = "Show Word Form"
        Me.radWord.UseVisualStyleBackColor = True
        '
        'radPrimes
        '
        Me.radPrimes.AutoSize = True
        Me.radPrimes.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPrimes.ForeColor = System.Drawing.Color.Maroon
        Me.radPrimes.Location = New System.Drawing.Point(462, 73)
        Me.radPrimes.Name = "radPrimes"
        Me.radPrimes.Size = New System.Drawing.Size(183, 22)
        Me.radPrimes.TabIndex = 6
        Me.radPrimes.TabStop = True
        Me.radPrimes.Text = "Show Prime Factorization"
        Me.radPrimes.UseVisualStyleBackColor = True
        '
        'radRoman
        '
        Me.radRoman.AutoSize = True
        Me.radRoman.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRoman.ForeColor = System.Drawing.Color.Maroon
        Me.radRoman.Location = New System.Drawing.Point(462, 53)
        Me.radRoman.Name = "radRoman"
        Me.radRoman.Size = New System.Drawing.Size(197, 22)
        Me.radRoman.TabIndex = 5
        Me.radRoman.TabStop = True
        Me.radRoman.Text = "Convert to Roman Numerals"
        Me.radRoman.UseVisualStyleBackColor = True
        '
        'radHex
        '
        Me.radHex.AutoSize = True
        Me.radHex.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radHex.ForeColor = System.Drawing.Color.Maroon
        Me.radHex.Location = New System.Drawing.Point(462, 33)
        Me.radHex.Name = "radHex"
        Me.radHex.Size = New System.Drawing.Size(234, 22)
        Me.radHex.TabIndex = 4
        Me.radHex.TabStop = True
        Me.radHex.Text = "Convert to Hexadecimal (Base 16)"
        Me.radHex.UseVisualStyleBackColor = True
        '
        'radBin
        '
        Me.radBin.AutoSize = True
        Me.radBin.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBin.ForeColor = System.Drawing.Color.Maroon
        Me.radBin.Location = New System.Drawing.Point(462, 13)
        Me.radBin.Name = "radBin"
        Me.radBin.Size = New System.Drawing.Size(188, 22)
        Me.radBin.TabIndex = 3
        Me.radBin.TabStop = True
        Me.radBin.Text = "Convert to Binary (Base 2)"
        Me.radBin.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Gold
        Me.btnClear.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Maroon
        Me.btnClear.Location = New System.Drawing.Point(262, 69)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(171, 50)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Gold
        Me.btnCalculate.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Maroon
        Me.btnCalculate.Location = New System.Drawing.Point(262, 13)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(171, 50)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Courier New", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.ForeColor = System.Drawing.Color.Maroon
        Me.txtNumber.Location = New System.Drawing.Point(50, 35)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(159, 62)
        Me.txtNumber.TabIndex = 0
        Me.txtNumber.Text = "1000"
        Me.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblInstructions
        '
        Me.lblInstructions.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.ForeColor = System.Drawing.Color.Maroon
        Me.lblInstructions.Location = New System.Drawing.Point(12, 109)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(710, 100)
        Me.lblInstructions.TabIndex = 2
        Me.lblInstructions.Text = "Type an integer between 1 and 1000, select an option, and click the Calculate but" &
    "ton to display that information about your number below"
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumberInfo
        '
        Me.lblNumberInfo.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberInfo.ForeColor = System.Drawing.Color.Gold
        Me.lblNumberInfo.Location = New System.Drawing.Point(12, 347)
        Me.lblNumberInfo.Name = "lblNumberInfo"
        Me.lblNumberInfo.Size = New System.Drawing.Size(710, 225)
        Me.lblNumberInfo.TabIndex = 3
        Me.lblNumberInfo.Text = "abc"
        Me.lblNumberInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 575)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(710, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(734, 711)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblNumberInfo)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Number Info"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radWord As RadioButton
    Friend WithEvents radPrimes As RadioButton
    Friend WithEvents radRoman As RadioButton
    Friend WithEvents radHex As RadioButton
    Friend WithEvents radBin As RadioButton
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblNumberInfo As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
