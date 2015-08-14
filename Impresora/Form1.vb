
Public Class Form1
    Private _Logotipo As Image          'Logotipo de la empresa         ID ->1
    Private _Empresa As String          'Nombre de la empresa
    Private _Calle As String            'Nombre de la calle donde esta ubicada
    Private _Colonia As String          'Nombre de la colonia
    Private _Ciudad As String           'Nombre del ciudad
    Private _Telefono As String         'Telefono
    Private _CP As String = ""          'Código Postal
    Private _BarCode_Text As String     'Code 39
    Private _Barcode_Ima As Image       'Imagen del código de barra     ID ->0
    Private _Tabla As DataGridView      'Número del codigo de barra
    Private _Impresora As String        'Nombre de la impresora
    Private _Mensaje As String          'Mensaje de fin de ticket : "Gracias por su preferencia"
    Private _Art As Integer             'Indice de la columna articulo en el DataGridView
    Private _Cant As Integer            'Indice de la columna cantidad en el DataGridView
    Private _Sub As Integer             'Indice de la columna subtotal en el DataGridView
    Private _Total As String            'Total dela venta
    Private _Correo As String           'Correo de la empresa
    Private _Cambio As String           'Cambio de la venta


    Public Const eClear As String = Chr(27) + "@"
    Public Const eCentre As String = Chr(27) + Chr(97) + "1"
    Public Const eLeft As String = Chr(27) + Chr(97) + "0"
    Public Const eRight As String = Chr(27) + Chr(97) + "2"
    Public Const eDrawer As String = eClear + Chr(27) + "p" + Chr(0) + ".}"
    Public Const eCut As String = Chr(27) + "i" + vbCrLf
    Public Const eSmlText As String = Chr(27) + "!" + Chr(1)
    Public Const eNmlText As String = Chr(27) + "!" + Chr(0)
    Public Const eInit As String = eNmlText + Chr(13) + Chr(27) + _
    "c6" + Chr(1) + Chr(27) + "R3" + vbCrLf
    Public Const eBigCharOn As String = Chr(27) + "!" + Chr(56)
    Public Const eBigCharOff As String = Chr(27) + "!" + Chr(0)

    Private prn As New RawPrinterHelper

    Private PrinterName As String = "POS58"

    Public Sub StartPrint()
        prn.OpenPrint(PrinterName)
    End Sub

    Public Sub PrintHeader()
        'eInit Espacio en blanco
        Print(eCentre + "Tel:0123 456 7890")
        Print("Calle Lino Merino SN")
        Print("Colonia Centro")
        Print("Villahermosa Tabasco Mex" + eLeft)
        PrintLinea()
    End Sub

    Public Sub PrintFooter()
        PrintLinea()
        Print(eCentre + "Gracias por tu preferencia!" + eLeft)
        Print(vbLf + vbCrLf + eCut + eDrawer)
    End Sub

    Public Sub Print(Line As String)
        prn.SendStringToPrinter(PrinterName, Line + vbLf)
    End Sub

    Public Sub PrintLinea()
        Print(eInit + "- - - - - - - - - - - - - - - -" + eInit)
    End Sub

    Public Sub EndPrint()
        prn.ClosePrint()
    End Sub

    Private Sub btnexir_Click(sender As Object, e As EventArgs) Handles btnexir.Click
        prn.ClosePrint()
        Me.Close()
    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        StartPrint()

        If prn.PrinterIsOpen = True Then
            PrintHeader()

            PrintFooter()
            EndPrint()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DB.Item(2, 0).Value = "HOLA"
    End Sub

    ''' <summary>
    ''' Convierte un número a texto especificando los pesos y centavos
    ''' </summary>
    ''' <param name="Num">Número a convertir a texto</param>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function NumeroToTexto(ByVal Num As Decimal) As String
        Dim Num2 As Integer
        Dim Cadena As String
        Num2 = Fix(Num)
        Cadena = NumToTex(Num2) + "pesos"
        Num2 = (Num - Num2) * 100
        If Num2 Then
            Cadena = Cadena + " y " + NumToTex(Num2) + "centavos"
        End If
        Return StrConv(Cadena, VbStrConv.ProperCase)
    End Function


    ''' <summary>
    ''' Recibe como parametro un numero y devuelve el numero expresado en cadena
    ''' </summary>
    ''' <param name="Num">Número a convertir a texto</param>
    ''' <returns>Cadena</returns>
    ''' <remarks></remarks>
    Private Function NumToTex(ByVal Num As String) As String
        Dim Num2 As Integer
        Dim Num3 As Integer
        Dim Cd As String = ""
        Dim ant As Boolean = False
        Num2 = Num
        While Not Num2 = 0
            If Num2 > 999 Then
                If Num2 < 2000 Then
                    Cd = "mil "
                ElseIf Num2 < 20000 Then
                    Cd = Numero(CInt(Num2 \ 1000)) + " " + Numero(1000) + " "
                Else
                    Num3 = CInt(Num2 \ 1000)
                    Cd = Numero(CInt(Num3 \ 10) * 10) + " "
                    Num3 = Num3 Mod 10
                    If Num3 Then
                        Cd = Cd + " y " + Numero(Num3) + " mil "
                    Else
                        Cd = Cd + " mil "
                    End If
                End If
                Num2 = Num2 Mod 1000
            ElseIf Num2 > 99 Then
                If Num2 = 100 Then
                    Cd = Cd + "cien "
                Else
                    Cd = Cd + Numero(CInt(Num2 \ 100) * 100) + " "
                End If
                Num2 = Num2 Mod 100
            ElseIf Num2 > 19 Then
                Cd = Cd + Numero(CInt(Num2 \ 10) * 10) + " "
                Num2 = Num2 Mod 10
                ant = True
            Else
                If ant Then
                    Cd = Cd + "y " + Numero(Num2) + " "
                Else
                    Cd = Cd + Numero(Num2) + " "
                End If

                Num2 = 0
            End If
        End While

        Return Cd
    End Function

    Private Function Numero(ByVal Num As Integer) As String
        Select Case Num
            Case 1
                Return "uno"
            Case 2
                Return "dos"
            Case 3
                Return "tres"
            Case 4
                Return "cuatro"
            Case 5
                Return "cinco"
            Case 6
                Return "seis"
            Case 7
                Return "siete"
            Case 8
                Return "ocho"
            Case 9
                Return "nueve"
            Case 10
                Return "diez"
            Case 11
                Return "once"
            Case 12
                Return "doce"
            Case 13
                Return "trece"
            Case 14
                Return "catorce"
            Case 15
                Return "quince"
            Case 16
                Return "dieciséis"
            Case 17
                Return "diecisiete"
            Case 18
                Return "dieciocho"
            Case 19
                Return "diecinueve"
            Case 20
                Return "veinte"
            Case 30
                Return "treinta"
            Case 40
                Return "cuarenta"
            Case 50
                Return "cincuenta"
            Case 60
                Return "sesenta"
            Case 70
                Return "setenta"
            Case 80
                Return "ochenta"
            Case 90
                Return "noventa"
            Case 100
                Return "ciento"
            Case 200
                Return "doscientos"
            Case 300
                Return "trescientos"
            Case 400
                Return "cuatrocientos"
            Case 500
                Return "quinientos"
            Case 600
                Return "seiscientos"
            Case 700
                Return "setecientos"
            Case 800
                Return "ochocientos"
            Case 900
                Return "novecientos"
            Case 1000
                Return "mil"
        End Select
        Return ""
    End Function
End Class
