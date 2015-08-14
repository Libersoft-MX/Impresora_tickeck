Imports System.IO

Public Class TamañoPapel
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAncho As System.Windows.Forms.TextBox
    Friend WithEvents txtAlto As System.Windows.Forms.TextBox
    Friend WithEvents btnCrear As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSeleccionarImpresora As System.Windows.Forms.Button
    Friend WithEvents prdImpresoras As System.Windows.Forms.PrintDialog
    Friend WithEvents lblImpresoraActual As System.Windows.Forms.Label
    Friend WithEvents ppdDocumento As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents prdoDocumento As System.Drawing.Printing.PrintDocument
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TamañoPapel))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAncho = New System.Windows.Forms.TextBox
        Me.txtAlto = New System.Windows.Forms.TextBox
        Me.btnCrear = New System.Windows.Forms.Button
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnSeleccionarImpresora = New System.Windows.Forms.Button
        Me.prdImpresoras = New System.Windows.Forms.PrintDialog
        Me.lblImpresoraActual = New System.Windows.Forms.Label
        Me.prdoDocumento = New System.Drawing.Printing.PrintDocument
        Me.ppdDocumento = New System.Windows.Forms.PrintPreviewDialog
        Me.btnVer = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ancho"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alto"
        '
        'txtAncho
        '
        Me.txtAncho.Location = New System.Drawing.Point(64, 96)
        Me.txtAncho.Name = "txtAncho"
        Me.txtAncho.TabIndex = 2
        Me.txtAncho.Text = "600"
        '
        'txtAlto
        '
        Me.txtAlto.Location = New System.Drawing.Point(64, 128)
        Me.txtAlto.Name = "txtAlto"
        Me.txtAlto.TabIndex = 3
        Me.txtAlto.Text = "320"
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(176, 128)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.TabIndex = 4
        Me.btnCrear.Text = "&Crear"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(64, 64)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.Text = "personal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre"
        '
        'btnSeleccionarImpresora
        '
        Me.btnSeleccionarImpresora.Location = New System.Drawing.Point(16, 24)
        Me.btnSeleccionarImpresora.Name = "btnSeleccionarImpresora"
        Me.btnSeleccionarImpresora.Size = New System.Drawing.Size(144, 23)
        Me.btnSeleccionarImpresora.TabIndex = 0
        Me.btnSeleccionarImpresora.Text = "Seleccionar &Impresora..."
        '
        'lblImpresoraActual
        '
        Me.lblImpresoraActual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblImpresoraActual.Location = New System.Drawing.Point(168, 24)
        Me.lblImpresoraActual.Name = "lblImpresoraActual"
        Me.lblImpresoraActual.Size = New System.Drawing.Size(168, 23)
        Me.lblImpresoraActual.TabIndex = 8
        Me.lblImpresoraActual.Text = "(Ninguna)"
        Me.lblImpresoraActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'prdoDocumento
        '
        '
        'ppdDocumento
        '
        Me.ppdDocumento.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ppdDocumento.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ppdDocumento.ClientSize = New System.Drawing.Size(398, 298)
        Me.ppdDocumento.Document = Me.prdoDocumento
        Me.ppdDocumento.Enabled = True
        Me.ppdDocumento.Icon = CType(resources.GetObject("ppdDocumento.Icon"), System.Drawing.Icon)
        Me.ppdDocumento.Location = New System.Drawing.Point(272, 15)
        Me.ppdDocumento.MinimumSize = New System.Drawing.Size(375, 250)
        Me.ppdDocumento.Name = "ppdDocumento"
        Me.ppdDocumento.TransparencyKey = System.Drawing.Color.Empty
        Me.ppdDocumento.Visible = False
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(256, 128)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.TabIndex = 5
        Me.btnVer.Text = "&Ver"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(256, 184)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.Text = "C&errar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(8, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 8)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'TamañoPapel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(346, 216)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.lblImpresoraActual)
        Me.Controls.Add(Me.btnSeleccionarImpresora)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.txtAlto)
        Me.Controls.Add(Me.txtAncho)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TamañoPapel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Definir Tamaño de Papel"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ImpresoraActual As New Printing.PrinterSettings
    Private Lector As StreamReader

    Private Sub btnCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrear.Click
        Dim TamañoPersonal As Printing.PaperSize
        Dim Ancho As Short
        Dim Alto As Short
        Try
            Ancho = Short.Parse(txtAncho.Text)
            Alto = Short.Parse(txtAlto.Text)
            TamañoPersonal = New Printing.PaperSize(txtNombre.Text, Ancho, Alto)

            prdoDocumento.PrinterSettings = ImpresoraActual
            prdoDocumento.DefaultPageSettings.PaperSize = TamañoPersonal
            MessageBox.Show("Nuevo tamaño asignado a documento")
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnSeleccionarImpresora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionarImpresora.Click
        Try
            prdImpresoras.PrinterSettings = ImpresoraActual
            If prdImpresoras.ShowDialog = DialogResult.OK Then
                ImpresoraActual = prdImpresoras.PrinterSettings
                lblImpresoraActual.Text = ImpresoraActual.PrinterName
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub prdoDocumento_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles prdoDocumento.PrintPage
        Try
            Dim linea As String = Nothing
            Dim posicion As Integer = 10
            Dim NroLineasImpresas As Integer = 0
            Dim Fuente As New Font("Verdana", 8)

            ' Calulando el numero de lineas por pagina
            Dim NroLineasPagina As Integer = e.PageBounds.Height / Fuente.GetHeight(e.Graphics)

            While NroLineasImpresas < NroLineasPagina
                linea = Lector.ReadLine()
                If Not linea Is Nothing Then
                    e.Graphics.DrawString(linea, Fuente, Brushes.Black, 10, posicion)
                    posicion += 15
                    NroLineasImpresas += 1
                Else
                    Exit While
                End If
            End While

            If Not linea Is Nothing Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
                Lector.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
        ppdDocumento.ShowDialog(Me)
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub prdoDocumento_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles prdoDocumento.BeginPrint
        Lector = New StreamReader("..\documento.txt", System.Text.ASCIIEncoding.Default)
    End Sub
End Class
