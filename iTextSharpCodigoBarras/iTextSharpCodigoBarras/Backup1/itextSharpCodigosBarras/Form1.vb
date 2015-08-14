'Original código Java para pdf: http://itextpdf.com/examples/iia.php?id=297
'checker pdf417 :   http://www.turbulence.org/Works/swipe/barcode.html
'app online pdf417: http://www.turbulence.org/Works/swipe/barcode_app.html
'decoder datamatrix (hay que agrandar las imagenes que se le envían usando una escala >=4 y en formato BMP): http://www.2dtg.com/decode.html
'Generador online de diversos códigos: http://www.bcgen.com/linear-barcode-creator.html
Public Class Form1
    Private Enum eTiposCodigo
        Codabar = 0
        Ean13
        Ean13Nochecksum
        Code39
        Code128
        PDF417
        Datamatrix
    End Enum
    Private ActualCode As eTiposCodigo

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim names As String() = [Enum].GetNames(GetType(BarCode.Code128SubTypes))
        For i As Integer = 0 To names.Length - 1
            ComboBox1.Items.Add(names(i))
        Next
        ComboBox1.SelectedIndex = ComboBox1.FindString("CODE128")
        RbtCodabar.Checked = True
    End Sub

#Region "       Botones de seleccion"
    Private Sub RbtCodabar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtCodabar.CheckedChanged
        If RbtCodabar.Checked Then
            TextBox1.Text = "A1234567890B"
            ActualCode = eTiposCodigo.Codabar
        End If

    End Sub

    Private Sub RbtEan13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtEan13.CheckedChanged
        If RbtEan13.Checked Then
            TextBox1.Text = "5901234123457"
            ActualCode = eTiposCodigo.Ean13
        End If
    End Sub

    Private Sub RbtEan13NoChecksum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtEan13NoChecksum.CheckedChanged
        If RbtEan13NoChecksum.Checked Then
            TextBox1.Text = "590123412345"
            ActualCode = eTiposCodigo.Ean13Nochecksum
        End If
    End Sub

    Private Sub RbtCode39_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtCode39.CheckedChanged
        If RbtCode39.Checked Then
            TextBox1.Text = "12345678901234567890"
            ActualCode = eTiposCodigo.Code39
        End If

    End Sub

    Private Sub RbtCode128_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtCode128.CheckedChanged
        If RbtCode128.Checked Then
            TextBox1.Text = "(01)00000090311314(10)ABC123(15)060916"
            ActualCode = eTiposCodigo.Code128
        End If

    End Sub

    Private Sub RbtPDF417_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtPDF417.CheckedChanged
        If RbtPDF417.Checked Then
            TextBox1.Text = "ETKT: 099843838838392122982|FLIGHT: KLM9999 CIA:KLMDUTCH |FROM: MAD | TO: AMS | DATE: 2010-12-23| HOUR:11:00 | SEAT: 20D |SMOKING: NO | PASS: APELLIDO1APELLIDO2/NOMBRE | ID: 00000000X***"
            ActualCode = eTiposCodigo.PDF417
        End If

    End Sub

    Private Sub RbtDatamatrix_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtDatamatrix.CheckedChanged
        If RbtDatamatrix.Checked Then
            'TextBox1.Text = "p.x#89.968;p.y#-178.807;p.z#0.163;r#0-rV1"
            TextBox1.Text = "Hola mundo dentro de un datamatrix."
            ActualCode = eTiposCodigo.Datamatrix
        End If
    End Sub
#End Region
#Region "       Encode"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Trim = "" Then
            MessageBox.Show("No hay texto")
            TextBox1.Focus()
            Exit Sub
        End If
        Try
            Dim iHeight As Single = 0

            If MaskedTextBox1.Text.Trim <> "" Then
                iHeight = Convert.ToSingle(MaskedTextBox1.Text)
            End If
            Dim bm As Bitmap = Nothing
            Select Case ActualCode
                Case eTiposCodigo.Codabar
                    bm = BarCode.CodeCodABAR(TextBox1.Text, CheckBox1.Checked, iHeight)
                Case eTiposCodigo.Code128
                    Dim iType As BarCode.Code128SubTypes = DirectCast([Enum].Parse(GetType(BarCode.Code128SubTypes), ComboBox1.Text), BarCode.Code128SubTypes)
                    bm = BarCode.Code128(TextBox1.Text, iType, CheckBox1.Checked, iHeight)
                Case eTiposCodigo.Code39
                    bm = BarCode.Code39(TextBox1.Text, CheckBox1.Checked, iHeight)
                Case eTiposCodigo.Datamatrix
                    If MaskedTextBox2.Text.Trim = "" Then MaskedTextBox2.Text = "1"
                    bm = BarCode.DataMatrix(TextBox1.Text, MaskedTextBox2.Text)
                Case eTiposCodigo.Ean13
                    bm = BarCode.CodeEAN13(TextBox1.Text, CheckBox1.Checked, iHeight)
                Case eTiposCodigo.Ean13Nochecksum
                    bm = BarCode.CodeEAN13AutoGenerateChecksum(TextBox1.Text, CheckBox1.Checked, iHeight)
                Case eTiposCodigo.PDF417
                    If MaskedTextBox2.Text.Trim = "" Then MaskedTextBox2.Text = "1"
                    bm = BarCode.PDF417(TextBox1.Text, MaskedTextBox2.Text)
            End Select
            If Not IsNothing(bm) Then
                PictureBox1.Image = bm
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
#End Region
#Region "       Save"
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If IsNothing(PictureBox1.Image) Then
            MessageBox.Show("No hay nada que grabar. Codifica primero un texto")
            Exit Sub
        End If
        Dim saveFileDialog1 As New SaveFileDialog

        saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png"
        saveFileDialog1.Title = "Save"
        saveFileDialog1.FileName = String.Empty
        saveFileDialog1.ShowDialog()

        If (saveFileDialog1.FileName <> "") Then
            Select Case saveFileDialog1.FilterIndex
                Case 1
                    PictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                Case 2
                    PictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
                Case 3
                    PictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Gif)
                Case 4
                    PictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png)
            End Select
        End If
    End Sub
#End Region
#Region "       Print"
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If IsNothing(PictureBox1.Image) Then
            MessageBox.Show("No hay nada que imprimir. Codifica primero un texto")
            Exit Sub
        End If

        PrintDialog1.Document = PrintDocument1

        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(PictureBox1.Image, 0, 0)
    End Sub
#End Region

End Class
