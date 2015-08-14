Imports Libersoft
Imports System.Drawing.Printing
Imports System.IO
Imports System.Text
Public Class Form2
    Dim pd As New PrintDocument
    Private Ticket As New cTicket
    Private Barcode As New cBarCode
    Private Sub GenerarFactura(ByVal IdFactura As Integer, ByVal CantLineas As Integer)

        pd.DocumentName = "FAC" & IdFactura
        Dim Alto As Integer = 500
        Dim Tamaño As New Printing.PaperSize("Factura", 190, Alto)

        pd.DefaultPageSettings.PaperSize = Tamaño
        pd.PrinterSettings.DefaultPageSettings.Margins.Top = 0
        pd.PrinterSettings.DefaultPageSettings.Margins.Bottom = 0
        pd.PrinterSettings.DefaultPageSettings.Margins.Left = 0
        pd.PrinterSettings.DefaultPageSettings.Margins.Right = 0

        AddHandler pd.PrintPage, AddressOf prt_PrintPage
        PrintPreviewDialog1 = Nothing
        PrintPreviewDialog1.Document = pd
        PrintPreviewDialog1.Show()
        'Factura.Print()
    End Sub

    Private Sub prt_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim dd As Integer = 190
        Dim fontTitulo As New Font("Arial", 14, FontStyle.Bold)
        Dim fontEncabezado As New Font("Arial", 9, FontStyle.Regular)
        Dim fontCuerpo As New Font("Arial", 8, FontStyle.Regular)
        Dim fontTituloColumna As New Font("Arial", 8, FontStyle.Bold)

        Dim FormatoCentro As New StringFormat
        FormatoCentro.Alignment = StringAlignment.Center
        FormatoCentro.LineAlignment = StringAlignment.Center
        Dim FormatoIzquierda As New StringFormat()
        FormatoIzquierda.Alignment = StringAlignment.Near
        FormatoIzquierda.LineAlignment = StringAlignment.Center
        Dim FormatoDerecha As New StringFormat()
        FormatoDerecha.Alignment = StringAlignment.Far
        FormatoDerecha.LineAlignment = StringAlignment.Center

        Dim Parrafo As Rectangle
        Parrafo = New Rectangle(0, 5, dd, 16)
        e.Graphics.DrawString("DICO S.A.", fontTitulo, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(0, 20, dd, 12)
        MsgBox(e.Graphics.MeasureString("Distribuidora y Comercializadora", fontEncabezado).ToString)
        e.Graphics.DrawString("Distribuidora y Comercializadora", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(0, 35, 291, 12)
        e.Graphics.DrawString("de Oriente S.A.", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(0, 50, dd, 12)
        e.Graphics.DrawString("Finca El Oasis, La Fragua, Zacapa", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(0, 65, dd, 12)
        e.Graphics.DrawString("Nit: 8027636-9", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(0, 80, dd, 12)
        e.Graphics.DrawString("Tel: 50168594", fontEncabezado, Brushes.Black, Parrafo, FormatoCentro)

        Parrafo = New Rectangle(0, 105, dd, 12)
        e.Graphics.DrawString("RES:2007-1-28-18731", fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(0, 120, dd, 12)
        e.Graphics.DrawString("DE FECHA: 21/03/2014", fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(0, 135, dd, 12)
        e.Graphics.DrawString("VALE", fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(0, 150, dd, 12)
        'e.Graphics.DrawString("SERIE: " & vSerie & " NO. " & vIdVenta, fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(0, 165, dd, 12)
        'e.Graphics.DrawString("FECHA EMISION: " & lblFecha.Text, fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)

        Parrafo = New Rectangle(0, 190, dd, 12)
        'e.Graphics.DrawString("CODIGO: " & FrmPDV.txtCodigo.Text, fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(0, 205, dd, 12)
        'e.Graphics.DrawString("NIT: " & FrmPDV.lblNit.Text, fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(0, 220, dd, 12)
        e.Graphics.DrawString("NOMBRE:", fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(0, 235, dd, 12)
        'e.Graphics.DrawString(FrmPDV.lblNombre.Text, fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)

        Parrafo = New Rectangle(0, 260, 50, 15)
        e.Graphics.DrawString("CANT.", fontTituloColumna, Brushes.Black, Parrafo, FormatoCentro)
        Parrafo = New Rectangle(50, 260, 175, 15)
        e.Graphics.DrawString("DESCRIPCION", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(225, 260, 50, 15)
        e.Graphics.DrawString("COSTO", fontTituloColumna, Brushes.Black, Parrafo, FormatoDerecha)

        Dim Linea As Integer = 275

        Dim CantLinea As Integer = 0
        'For n As Integer = 0 To FrmPDV.ListView1.Items.Count - 1
        'Parrafo = New Rectangle(0, Linea + (n * 15), 50, 12)
        'e.Graphics.DrawString(FrmPDV.ListView1.Items(n).SubItems(1).Text, fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)
        'Parrafo = New Rectangle(50, Linea + (n * 15), 175, 12)
        'e.Graphics.DrawString(FrmPDV.ListView1.Items(n).SubItems(2).Text, fontCuerpo, Brushes.Black, Parrafo, FormatoIzquierda)
        'Parrafo = New Rectangle(225, Linea + (n * 15), 50, 12)
        'e.Graphics.DrawString(FormatNumber(FrmPDV.ListView1.Items(n).SubItems(4).Text), fontCuerpo, Brushes.Black, Parrafo, FormatoDerecha)
        CantLinea = 50
        'Next

        Linea += CantLinea + 10
        Parrafo = New Rectangle(225, Linea, 50, 12)
        e.Graphics.DrawString("---------------", fontCuerpo, Brushes.Black, Parrafo, FormatoDerecha)
        Linea += 10
        Parrafo = New Rectangle(50, Linea, 175, 15)
        e.Graphics.DrawString("TOTAL", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(225, Linea, 50, 12)
        'e.Graphics.DrawString(lblMonto.Text, fontCuerpo, Brushes.Black, Parrafo, FormatoDerecha)
        Linea += 15
        Parrafo = New Rectangle(50, Linea, 175, 15)
        e.Graphics.DrawString("EFECTIVO", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(225, Linea, 50, 12)
        'e.Graphics.DrawString(txtPago.Text, fontCuerpo, Brushes.Black, Parrafo, FormatoDerecha)
        Linea += 15
        Parrafo = New Rectangle(50, Linea, 175, 15)
        e.Graphics.DrawString("VUELTO", fontTituloColumna, Brushes.Black, Parrafo, FormatoIzquierda)
        Parrafo = New Rectangle(225, Linea, 50, 12)
        'e.Graphics.DrawString(lblVuelto.Text, fontCuerpo, Brushes.Black, Parrafo, FormatoDerecha)

        Linea += 50
        Parrafo = New Rectangle(0, Linea, dd, 12)
        e.Graphics.DrawString("- - - - - SUJETO A PAGOS TRIMESTRALES - - - - -", fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)
        Linea += 15
        Parrafo = New Rectangle(0, Linea, dd, 12)
        e.Graphics.DrawString("GRACIAS POR SU COMPRA, VUELVA PRONTO", fontCuerpo, Brushes.Black, Parrafo, FormatoCentro)
        e.HasMorePages = False
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ticket.Logotipo = PictureBox1.Image
        Ticket.BarCode_Text = txt1.Text
        Ticket.BarCode_Ima = Barcode.CodigoDeBarra(txt1.Text)
        Ticket.Efectivo = 2000
        Ticket.Tabla = DGV
        Ticket.ImprimirTicket()
        'DGV.Item(1, 0).Value = "hola"
    End Sub
End Class