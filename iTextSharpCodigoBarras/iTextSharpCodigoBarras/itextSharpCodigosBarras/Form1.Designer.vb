<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.RbtCodabar = New System.Windows.Forms.RadioButton
        Me.RbtEan13 = New System.Windows.Forms.RadioButton
        Me.RbtCode128 = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.RbtCode39 = New System.Windows.Forms.RadioButton
        Me.RbtDatamatrix = New System.Windows.Forms.RadioButton
        Me.RbtPDF417 = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.Label5 = New System.Windows.Forms.Label
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox
        Me.RbtEan13NoChecksum = New System.Windows.Forms.RadioButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(11, 191)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(354, 354)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(435, 62)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "Hola"
        '
        'RbtCodabar
        '
        Me.RbtCodabar.AutoSize = True
        Me.RbtCodabar.Location = New System.Drawing.Point(11, 99)
        Me.RbtCodabar.Name = "RbtCodabar"
        Me.RbtCodabar.Size = New System.Drawing.Size(65, 17)
        Me.RbtCodabar.TabIndex = 4
        Me.RbtCodabar.TabStop = True
        Me.RbtCodabar.Text = "Codabar"
        Me.RbtCodabar.UseVisualStyleBackColor = True
        '
        'RbtEan13
        '
        Me.RbtEan13.AutoSize = True
        Me.RbtEan13.Location = New System.Drawing.Point(81, 99)
        Me.RbtEan13.Name = "RbtEan13"
        Me.RbtEan13.Size = New System.Drawing.Size(59, 17)
        Me.RbtEan13.TabIndex = 5
        Me.RbtEan13.TabStop = True
        Me.RbtEan13.Text = "EAN13"
        Me.RbtEan13.UseVisualStyleBackColor = True
        '
        'RbtCode128
        '
        Me.RbtCode128.AutoSize = True
        Me.RbtCode128.Location = New System.Drawing.Point(218, 99)
        Me.RbtCode128.Name = "RbtCode128"
        Me.RbtCode128.Size = New System.Drawing.Size(68, 17)
        Me.RbtCode128.TabIndex = 6
        Me.RbtCode128.TabStop = True
        Me.RbtCode128.Text = "Code128"
        Me.RbtCode128.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(215, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Code128 Subtype:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(316, 116)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(130, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'RbtCode39
        '
        Me.RbtCode39.AutoSize = True
        Me.RbtCode39.Location = New System.Drawing.Point(147, 99)
        Me.RbtCode39.Name = "RbtCode39"
        Me.RbtCode39.Size = New System.Drawing.Size(65, 17)
        Me.RbtCode39.TabIndex = 9
        Me.RbtCode39.TabStop = True
        Me.RbtCode39.Text = "Code 39"
        Me.RbtCode39.UseVisualStyleBackColor = True
        '
        'RbtDatamatrix
        '
        Me.RbtDatamatrix.AutoSize = True
        Me.RbtDatamatrix.Location = New System.Drawing.Point(81, 168)
        Me.RbtDatamatrix.Name = "RbtDatamatrix"
        Me.RbtDatamatrix.Size = New System.Drawing.Size(79, 17)
        Me.RbtDatamatrix.TabIndex = 10
        Me.RbtDatamatrix.TabStop = True
        Me.RbtDatamatrix.Text = "Data Matrix"
        Me.RbtDatamatrix.UseVisualStyleBackColor = True
        '
        'RbtPDF417
        '
        Me.RbtPDF417.AutoSize = True
        Me.RbtPDF417.Location = New System.Drawing.Point(11, 168)
        Me.RbtPDF417.Name = "RbtPDF417"
        Me.RbtPDF417.Size = New System.Drawing.Size(64, 17)
        Me.RbtPDF417.TabIndex = 11
        Me.RbtPDF417.TabStop = True
        Me.RbtPDF417.Text = "PDF417"
        Me.RbtPDF417.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "1-D"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "2-D"
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(342, 168)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(104, 17)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "Ver code en 1-D"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(371, 249)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(371, 220)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(371, 191)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Encode"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "1-D Altura:"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(147, 77)
        Me.MaskedTextBox1.Mask = "999"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(33, 20)
        Me.MaskedTextBox1.TabIndex = 19
        Me.MaskedTextBox1.Text = "0"
        Me.ToolTip1.SetToolTip(Me.MaskedTextBox1, "El valor 0 proporciona una altura normalizada")
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "2D Scale:"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(147, 148)
        Me.MaskedTextBox2.Mask = "99"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(33, 20)
        Me.MaskedTextBox2.TabIndex = 21
        Me.MaskedTextBox2.Text = "1"
        '
        'RbtEan13NoChecksum
        '
        Me.RbtEan13NoChecksum.AutoSize = True
        Me.RbtEan13NoChecksum.Location = New System.Drawing.Point(81, 117)
        Me.RbtEan13NoChecksum.Name = "RbtEan13NoChecksum"
        Me.RbtEan13NoChecksum.Size = New System.Drawing.Size(126, 17)
        Me.RbtEan13NoChecksum.TabIndex = 22
        Me.RbtEan13NoChecksum.TabStop = True
        Me.RbtEan13NoChecksum.Text = "EAN13 no checksum"
        Me.RbtEan13NoChecksum.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 553)
        Me.Controls.Add(Me.RbtEan13NoChecksum)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RbtPDF417)
        Me.Controls.Add(Me.RbtDatamatrix)
        Me.Controls.Add(Me.RbtCode39)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RbtCode128)
        Me.Controls.Add(Me.RbtEan13)
        Me.Controls.Add(Me.RbtCodabar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "iTextSharp BarCode VB.NET -Ollydbg-"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RbtCodabar As System.Windows.Forms.RadioButton
    Friend WithEvents RbtEan13 As System.Windows.Forms.RadioButton
    Friend WithEvents RbtCode128 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents RbtCode39 As System.Windows.Forms.RadioButton
    Friend WithEvents RbtDatamatrix As System.Windows.Forms.RadioButton
    Friend WithEvents RbtPDF417 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents RbtEan13NoChecksum As System.Windows.Forms.RadioButton

End Class
