Public Class MainForm
    Dim valorh1 As Integer = 0
    Dim valorh2 As Integer = 0
    Dim valorh3 As Integer = 0
    Dim valorh4 As Integer = 0

    Dim valorm1 As Integer = 0
    Dim valorm2 As Integer = 0
    Dim valorm3 As Integer = 0
    Dim valorm4 As Integer = 0

    Dim valorc1 As Integer = 0
    Dim valorc2 As Integer = 0
    Dim valorc3 As Integer = 0
    Dim valorc4 As Integer = 0

    Dim valorac1 As Integer = 0
    Dim valorac2 As Integer = 0
    Dim valorac3 As Integer = 0
    Dim valorac4 As Integer = 0

    Dim hombres As Boolean
    Dim mujeres As Boolean
    Dim calzado As Boolean
    Dim accesorios As Boolean

    Dim tipo As String
    Dim caso As String
    Dim total As Double



    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hombres = True
        mujeres = False
        calzado = False
        accesorios = False
        tipo = "H"
        caso = "1"
        calcular()


        btnhombres.ForeColor = Color.SteelBlue
        btnmujeres.ForeColor = Color.Black
        btncalzado.ForeColor = Color.Black
        btnaccesorios.ForeColor = Color.Black

        lblhombres1.Text = "Camisa de Algadon"
        lblprecio1.Text = "$120"


        lblhombres2.Text = "Blazer Mezcla de Lana"
        lblprecio2.Text = "$240"

        lblhombres3.Text = "Jersey Cuello Pico"
        lblprecio3.Text = "$160"

        lblhombres4.Text = "Polo Cuello Redondo"
        lblprecio4.Text = "$70"


    End Sub



    Private Sub btnhombres_Click(sender As Object, e As EventArgs) Handles btnhombres.Click
        hombres = True
        mujeres = False
        calzado = False
        accesorios = False
        tipo = "H"
        caso = "1"
        btnhombres.ForeColor = Color.SteelBlue
        btnmujeres.ForeColor = Color.Black
        btncalzado.ForeColor = Color.Black
        btnaccesorios.ForeColor = Color.Black


        lblhombres1.Text = "Camisa de Algadon"
        lblprecio1.Text = "$120"


        lblhombres2.Text = "Blazer Mezcla de Lana"
        lblprecio2.Text = "$240"

        lblhombres3.Text = "Jersey Cuello Pico"
        lblprecio3.Text = "$160"

        lblhombres4.Text = "Polo Cuello Redondo"
        lblprecio4.Text = "$70"
        lblcantidad1.Text = valorh1.ToString
        lblcantidad2.Text = valorh2.ToString
        lblcantidad3.Text = valorh3.ToString
        lblcantidad4.Text = valorh4.ToString

        calcular()

    End Sub

    Private Sub btnmujeres_Click(sender As Object, e As EventArgs) Handles btnmujeres.Click
        hombres = False
        mujeres = True
        calzado = False
        accesorios = False
        tipo = "M"
        caso = "1"
        btnmujeres.ForeColor = Color.SteelBlue
        btnhombres.ForeColor = Color.Black
        btncalzado.ForeColor = Color.Black
        btnaccesorios.ForeColor = Color.Black

        lblhombres1.Text = "Polo Rayas Cuello Redondo"
        lblprecio1.Text = "$80"

        lblhombres2.Text = "Chompa Lana Cuello Redondo"
        lblprecio2.Text = "$150"

        lblhombres3.Text = "Casaca de Jean"
        lblprecio3.Text = "$220"

        lblhombres4.Text = "Abrigo Mezcla Lana"
        lblprecio4.Text = "$270"

        lblcantidad1.Text = valorm1.ToString
        lblcantidad2.Text = valorm2.ToString
        lblcantidad3.Text = valorm3.ToString
        lblcantidad4.Text = valorm4.ToString


        calcular()

    End Sub

    Private Sub btncalzado_Click(sender As Object, e As EventArgs) Handles btncalzado.Click
        hombres = False
        mujeres = False
        calzado = True
        accesorios = False
        tipo = "C"
        caso = "1"
        btncalzado.ForeColor = Color.SteelBlue
        btnhombres.ForeColor = Color.Black
        btnmujeres.ForeColor = Color.Black
        btnaccesorios.ForeColor = Color.Black

        lblhombres1.Text = "Zapatos Oxfords"
        lblprecio1.Text = "$120"

        lblhombres2.Text = "Zapatos Derby"
        lblprecio2.Text = "$140"

        lblhombres3.Text = "Botines"
        lblprecio3.Text = "$160"

        lblhombres4.Text = "Loafers"
        lblprecio4.Text = "$80"

        lblcantidad1.Text = valorc1.ToString
        lblcantidad2.Text = valorc2.ToString
        lblcantidad3.Text = valorc3.ToString
        lblcantidad4.Text = valorc4.ToString
        calcular()
    End Sub

    Private Sub btnaccesorios_Click(sender As Object, e As EventArgs) Handles btnaccesorios.Click
        hombres = False
        mujeres = False
        calzado = False
        accesorios = True
        tipo = "AC"
        caso = "1"
        btnaccesorios.ForeColor = Color.SteelBlue
        btnhombres.ForeColor = Color.Black
        btnmujeres.ForeColor = Color.Black
        btncalzado.ForeColor = Color.Black


        lblhombres1.Text = "Reloj de Acero"
        lblprecio1.Text = "$380"

        lblhombres2.Text = "Cinturon de Cuero"
        lblprecio2.Text = "$70"

        lblhombres3.Text = "Billetera de Cuero"
        lblprecio3.Text = "$190"

        lblhombres4.Text = "Gorra Clasica"
        lblprecio4.Text = "$50"

        lblcantidad1.Text = valorac1.ToString
        lblcantidad2.Text = valorac2.ToString
        lblcantidad3.Text = valorac3.ToString
        lblcantidad4.Text = valorac4.ToString

        calcular()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        caso = "1"
        calcular()


    End Sub
    Private Sub calcular()
        Select Case tipo
            Case "H"
                If caso = "1" Then
                    pbxpanel.Image = ilProductos.Images.Item(0)
                    lblTituloProducto.Text = ("Camisa de Algadon").ToUpper
                    lblpreciopanel.Text = "$120"
                    lbltalla1.Text = "XS"
                    lbltalla2.Text = "S"
                    lbltalla3.Text = "M"
                    lbltalla4.Text = "L"
                    lbltalla5.Text = "XL"
                    lbltalla1.ForeColor = Color.Black
                    lbltalla2.ForeColor = Color.Black
                    lbltalla3.ForeColor = Color.Black
                    lbltalla4.ForeColor = Color.Black
                    lbltalla5.ForeColor = Color.Black
                    lbltallas.ForeColor = Color.Black
                ElseIf caso = "2" Then
                    pbxpanel.Image = ilProductos.Images.Item(1)
                    lblTituloProducto.Text = "Blazer Mezcla de Lana".ToUpper
                    lblpreciopanel.Text = "$240"
                    lbltalla1.Text = "XS"

                    lbltalla2.Text = "S"
                    lbltalla3.Text = "M"
                    lbltalla4.Text = "L"
                    lbltalla5.Text = "XL"
                    lbltalla1.ForeColor = Color.Black
                    lbltalla2.ForeColor = Color.Black
                    lbltalla3.ForeColor = Color.Black
                    lbltalla4.ForeColor = Color.Black
                    lbltalla5.ForeColor = Color.Black
                    lbltallas.ForeColor = Color.Black

                ElseIf caso = "3" Then
                    pbxpanel.Image = ilProductos.Images.Item(2)
                    lblTituloProducto.Text = "Jersey Cuello Pico".ToUpper
                    lblpreciopanel.Text = "$160"
                    lbltalla1.Text = "XS"
                    lbltalla2.Text = "S"
                    lbltalla3.Text = "M"
                    lbltalla4.Text = "L"
                    lbltalla5.Text = "XL"
                    lbltalla1.ForeColor = Color.Black
                    lbltalla2.ForeColor = Color.Black
                    lbltalla3.ForeColor = Color.Black
                    lbltalla4.ForeColor = Color.Black
                    lbltalla5.ForeColor = Color.Black
                    lbltallas.ForeColor = Color.Black
                ElseIf caso = "4" Then
                    pbxpanel.Image = ilProductos.Images.Item(3)
                    lblTituloProducto.Text = "Polo Cuello Redondo".ToUpper
                    lblpreciopanel.Text = "$70"
                    lbltalla1.Text = "XS"
                    lbltalla2.Text = "S"
                    lbltalla3.Text = "M"
                    lbltalla4.Text = "L"
                    lbltalla5.Text = "XL"
                    lbltalla1.ForeColor = Color.Black
                    lbltalla2.ForeColor = Color.Black
                    lbltalla3.ForeColor = Color.Black
                    lbltalla4.ForeColor = Color.Black
                    lbltalla5.ForeColor = Color.Black
                    lbltallas.ForeColor = Color.Black
                End If


                'mujeres
            Case "M"
                If caso = "1" Then
                    lblTituloProducto.Text = "Polo Rayas Cuello Redondo".ToUpper
                    lblpreciopanel.Text = "$80"

                    pbxpanel.Image = ilProductos.Images.Item(4)

                    lbltalla1.Text = "XS"
                    lbltalla2.Text = "S"
                    lbltalla3.Text = "M"
                    lbltalla4.Text = "L"
                    lbltalla5.Text = "XL"
                    lbltalla1.ForeColor = Color.Silver
                    lbltalla2.ForeColor = Color.Black
                    lbltalla3.ForeColor = Color.Black
                    lbltalla4.ForeColor = Color.Black
                    lbltalla5.ForeColor = Color.Silver
                    lbltallas.ForeColor = Color.Black
                ElseIf caso = "2" Then
                    pbxpanel.Image = ilProductos.Images.Item(5)
                    lblTituloProducto.Text = "Chompa Lana Cuello Redondo".ToUpper
                    lblpreciopanel.Text = "$150"
                    lbltalla1.Text = "XS"
                    lbltalla2.Text = "S"
                    lbltalla3.Text = "M"
                    lbltalla4.Text = "L"
                    lbltalla5.Text = "XL"
                    lbltalla1.ForeColor = Color.Silver
                    lbltalla2.ForeColor = Color.Black
                    lbltalla3.ForeColor = Color.Black
                    lbltalla4.ForeColor = Color.Black
                    lbltalla5.ForeColor = Color.Silver
                    lbltallas.ForeColor = Color.Black
                ElseIf caso = "3" Then
                    pbxpanel.Image = ilProductos.Images.Item(6)
                    lblTituloProducto.Text = "Casaca de Jean".ToUpper
                    lblpreciopanel.Text = "$220"
                    lbltalla1.Text = "XS"
                    lbltalla2.Text = "S"
                    lbltalla3.Text = "M"
                    lbltalla4.Text = "L"
                    lbltalla5.Text = "XL"
                    lbltalla1.ForeColor = Color.Silver
                    lbltalla2.ForeColor = Color.Black
                    lbltalla3.ForeColor = Color.Black
                    lbltalla4.ForeColor = Color.Black
                    lbltalla5.ForeColor = Color.Silver
                    lbltallas.ForeColor = Color.Black
                ElseIf caso = "4" Then
                    pbxpanel.Image = ilProductos.Images.Item(7)
                    lblTituloProducto.Text = "Abrigo Mezcla Lana".ToUpper
                    lblpreciopanel.Text = "$270"

                    lbltalla1.Text = "XS"
                    lbltalla2.Text = "S"
                    lbltalla3.Text = "M"
                    lbltalla4.Text = "L"
                    lbltalla5.Text = "XL"
                    lbltalla1.ForeColor = Color.Silver
                    lbltalla2.ForeColor = Color.Black
                    lbltalla3.ForeColor = Color.Black
                    lbltalla4.ForeColor = Color.Black
                    lbltalla5.ForeColor = Color.Silver
                    lbltallas.ForeColor = Color.Black
                End If


                'calzado
            Case "C"
                If caso = "1" Then
                    lblTituloProducto.Text = "Zapatos Oxfords".ToUpper
                    lblpreciopanel.Text = "$120"


                    pbxpanel.Image = ilProductos.Images.Item(8)

                    lbltalla1.Text = "37"
                    lbltalla2.Text = "38"
                    lbltalla3.Text = "40"
                    lbltalla4.Text = "42"
                    lbltalla5.Text = "44"
                    lbltalla1.ForeColor = Color.Silver
                    lbltalla2.ForeColor = Color.Black
                    lbltalla3.ForeColor = Color.Black
                    lbltalla4.ForeColor = Color.Black
                    lbltalla5.ForeColor = Color.Silver
                    lbltallas.ForeColor = Color.Black

                ElseIf caso = "2" Then
                    pbxpanel.Image = ilProductos.Images.Item(9)

                    lblTituloProducto.Text = "Zapatos Derby".ToUpper
                    lblpreciopanel.Text = "$140"

                    lbltalla1.Text = "37"
                    lbltalla2.Text = "38"
                    lbltalla3.Text = "40"
                    lbltalla4.Text = "42"
                    lbltalla5.Text = "44"
                    lbltalla1.ForeColor = Color.Silver
                    lbltalla2.ForeColor = Color.Black
                    lbltalla3.ForeColor = Color.Black
                    lbltalla4.ForeColor = Color.Black
                    lbltalla5.ForeColor = Color.Silver
                    lbltallas.ForeColor = Color.Black
                ElseIf caso = "3" Then
                    pbxpanel.Image = ilProductos.Images.Item(10)

                    lblTituloProducto.Text = "Botines".ToUpper
                    lblpreciopanel.Text = "$160"


                    lbltalla1.Text = "37"
                    lbltalla2.Text = "38"
                    lbltalla3.Text = "40"
                    lbltalla4.Text = "42"
                    lbltalla5.Text = "44"
                    lbltalla1.ForeColor = Color.Silver
                    lbltalla2.ForeColor = Color.Black
                    lbltalla3.ForeColor = Color.Black
                    lbltalla4.ForeColor = Color.Black
                    lbltalla5.ForeColor = Color.Silver
                    lbltallas.ForeColor = Color.Black
                ElseIf caso = "4" Then
                    pbxpanel.Image = ilProductos.Images.Item(11)

                    lblTituloProducto.Text = "Loafers".ToUpper
                    lblpreciopanel.Text = "$80"
                    lbltalla1.Text = "37"
                    lbltalla2.Text = "38"
                    lbltalla3.Text = "40"
                    lbltalla4.Text = "42"
                    lbltalla5.Text = "44"
                    lbltalla1.ForeColor = Color.Silver
                    lbltalla2.ForeColor = Color.Black
                    lbltalla3.ForeColor = Color.Black
                    lbltalla4.ForeColor = Color.Black
                    lbltalla5.ForeColor = Color.Silver
                    lbltallas.ForeColor = Color.Black
                End If
                'Accesorios
            Case "AC"
                If caso = "1" Then
                    pbxpanel.Image = ilProductos.Images.Item(12)

                    lblTituloProducto.Text = "Reloj de Acero".ToUpper
                    lblpreciopanel.Text = "$380"
                    lbltalla1.Text = "XS"
                    lbltalla2.Text = "S"
                    lbltalla3.Text = "M"
                    lbltalla4.Text = "L"
                    lbltalla5.Text = "XL"
                    lbltalla1.ForeColor = Color.Silver
                    lbltalla2.ForeColor = Color.Silver
                    lbltalla3.ForeColor = Color.Silver
                    lbltalla4.ForeColor = Color.Silver
                    lbltalla5.ForeColor = Color.Silver
                    lbltallas.ForeColor = Color.Silver
                ElseIf caso = "2" Then
                    pbxpanel.Image = ilProductos.Images.Item(13)

                    lblTituloProducto.Text = "Cinturon de Cuero".ToUpper
                    lblpreciopanel.Text = "$70"
                    lbltalla1.Text = "XS"
                    lbltalla2.Text = "S"
                    lbltalla3.Text = "M"
                    lbltalla4.Text = "L"
                    lbltalla5.Text = "XL"
                    lbltalla1.ForeColor = Color.Silver
                    lbltalla2.ForeColor = Color.Silver
                    lbltalla3.ForeColor = Color.Silver
                    lbltalla4.ForeColor = Color.Silver
                    lbltalla5.ForeColor = Color.Silver
                    lbltallas.ForeColor = Color.Silver
                ElseIf caso = "3" Then
                    pbxpanel.Image = ilProductos.Images.Item(14)

                    lblTituloProducto.Text = "Billetera de Cuero".ToUpper
                    lblpreciopanel.Text = "$190"
                    lbltalla1.Text = "XS"
                    lbltalla2.Text = "S"
                    lbltalla3.Text = "M"
                    lbltalla4.Text = "L"
                    lbltalla5.Text = "XL"
                    lbltalla1.ForeColor = Color.Silver
                    lbltalla2.ForeColor = Color.Silver
                    lbltalla3.ForeColor = Color.Silver
                    lbltalla4.ForeColor = Color.Silver
                    lbltalla5.ForeColor = Color.Silver
                    lbltallas.ForeColor = Color.Silver
                ElseIf caso = "4" Then
                    pbxpanel.Image = ilProductos.Images.Item(15)

                    lblTituloProducto.Text = "Gorra Clasica".ToUpper
                    lblpreciopanel.Text = "$50"
                    lbltalla1.Text = "XS"
                    lbltalla2.Text = "S"
                    lbltalla3.Text = "M"
                    lbltalla4.Text = "L"
                    lbltalla5.Text = "XL"
                    lbltalla1.ForeColor = Color.Silver
                    lbltalla2.ForeColor = Color.Silver
                    lbltalla3.ForeColor = Color.Silver
                    lbltalla4.ForeColor = Color.Silver
                    lbltalla5.ForeColor = Color.Silver
                    lbltallas.ForeColor = Color.Silver

                End If

        End Select

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        caso = "2"
        calcular()
    End Sub

    Private Sub lblbaja3_Click(sender As Object, e As EventArgs) Handles lblbaja3.Click
        Dim CantAx3 As Integer = CInt(lblcantidad3.Text)
        Dim precioAx3 As Integer
        If CantAx3 = 0 Then Exit Sub
        CantAx3 = CantAx3 - 1
        precioAx3 = CInt(lblprecio3.Text.Substring(1))
        If hombres Then
            valorh3 = CantAx3

        End If
        If mujeres Then
            valorm3 = CantAx3
        End If
        If calzado Then
            valorc3 = CantAx3

        End If
        If accesorios Then
            valorac3 = CantAx3

        End If

        lblcantidad3.Text = CantAx3.ToString
        total = total - precioAx3
        lblTotal.Text = String.Format("${0:0}", total)

    End Sub

    Private Sub btnbaja4_Click(sender As Object, e As EventArgs) Handles btnbaja4.Click
        Dim CantAx4 As Integer = CInt(lblcantidad4.Text)
        Dim precioAx4 As Integer
        If CantAx4 = 0 Then Exit Sub
        CantAx4 = CantAx4 - 1
        precioAx4 = CInt(lblprecio4.Text.Substring(1))
        If hombres Then
            valorh4 = CantAx4

        End If
        If mujeres Then
            valorm4 = CantAx4
        End If
        If calzado Then
            valorc4 = CantAx4

        End If
        If accesorios Then
            valorac4 = CantAx4

        End If

        lblcantidad4.Text = CantAx4.ToString
        total = total - precioAx4
        lblTotal.Text = String.Format("${0:0}", total)

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub lblsube3_Click(sender As Object, e As EventArgs) Handles lblsube3.Click
        Dim CantAx3 As Integer = CInt(lblcantidad3.Text)
        Dim precioAx3 As Integer
        If CantAx3 = 9 Then Exit Sub
        CantAx3 = CantAx3 + 1
        precioAx3 = CInt(lblprecio3.Text.Substring(1))
        If hombres Then
            valorh3 = CantAx3

        End If
        If mujeres Then
            valorm3 = CantAx3
        End If
        If calzado Then
            valorc3 = CantAx3

        End If
        If accesorios Then
            valorac3 = CantAx3
        End If


        lblcantidad3.Text = CantAx3.ToString
        total = total + precioAx3
        lblTotal.Text = String.Format("${0:0}", total)
    End Sub

    Private Sub btnsube4_Click(sender As Object, e As EventArgs) Handles btnsube4.Click
        Dim CantAx4 As Integer = CInt(lblcantidad4.Text)
        Dim precioAx4 As Integer
        If CantAx4 = 9 Then Exit Sub
        CantAx4 = CantAx4 + 1
        precioAx4 = CInt(lblprecio4.Text.Substring(1))
        If hombres Then
            valorh4 = CantAx4

        End If
        If mujeres Then
            valorm4 = CantAx4
        End If
        If calzado Then
            valorc4 = CantAx4

        End If
        If accesorios Then
            valorac4 = CantAx4

        End If

        lblcantidad4.Text = CantAx4.ToString
        total = total + precioAx4
        lblTotal.Text = String.Format("${0:0}", total)
    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        comprar()
    End Sub
    Private Sub comprar()
        If total <> 0 Then
            valorh1 = 0
            valorh2 = 0
            valorh3 = 0
            valorh4 = 0

            valorm1 = 0
            valorm2 = 0
            valorm3 = 0
            valorm4 = 0

            valorc1 = 0
            valorc2 = 0
            valorc3 = 0
            valorc4 = 0

            valorac1 = 0
            valorac2 = 0
            valorac3 = 0
            valorac4 = 0

            lblcantidad1.Text = "0"
            lblcantidad2.Text = "0"
            lblcantidad3.Text = "0"
            lblcantidad4.Text = "0"
            total = 0
            lblTotal.Text = String.Format("${0:0}", total)
            MsgBox("Compra satisfactoria...")
        Else
            MsgBox("No ha seleccionado ningun producto...")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        caso = "3"
        calcular()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles lblbaja2.Click
        Dim CantAx2 As Integer = CInt(lblcantidad2.Text)
        Dim precioAx2 As Integer
        If CantAx2 = 0 Then Exit Sub
        CantAx2 = CantAx2 - 1
        precioAx2 = CInt(lblprecio2.Text.Substring(1))
        If hombres Then
            valorh2 = CantAx2

        End If
        If mujeres Then
            valorm2 = CantAx2
        End If
        If calzado Then
            valorc2 = CantAx2

        End If
        If accesorios Then
            valorac2 = CantAx2

        End If

        lblcantidad2.Text = CantAx2.ToString
        total = total - precioAx2
        lblTotal.Text = String.Format("${0:0}", total)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles lblsube2.Click
        Dim CantAx2 As Integer = CInt(lblcantidad2.Text)
        Dim precioAx2 As Integer
        If CantAx2 = 9 Then Exit Sub
        CantAx2 = CantAx2 + 1
        precioAx2 = CInt(lblprecio2.Text.Substring(1))
        If hombres Then
            valorh2 = CantAx2

        End If
        If mujeres Then
            valorm2 = CantAx2
        End If
        If calzado Then
            valorc2 = CantAx2

        End If
        If accesorios Then
            valorac2 = CantAx2

        End If

        lblcantidad2.Text = CantAx2.ToString
        total = total + precioAx2
        lblTotal.Text = String.Format("${0:0}", total)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        caso = "4"
        calcular()
    End Sub

    Private Sub btnbaja1_Click(sender As Object, e As EventArgs) Handles btnbaja1.Click
        Dim CantAx1 As Integer = CInt(lblcantidad1.Text)
        Dim precioAx1 As Integer
        If CantAx1 = 0 Then Exit Sub
        CantAx1 = CantAx1 - 1
        precioAx1 = CInt(lblprecio1.Text.Substring(1))
        If hombres Then
            valorh1 = CantAx1

        End If
        If mujeres Then
            valorm1 = CantAx1
        End If
        If calzado Then
            valorc1 = CantAx1

        End If
        If accesorios Then
            valorac1 = CantAx1

        End If

        lblcantidad1.Text = CantAx1.ToString
        total = total - precioAx1
        lblTotal.Text = String.Format("${0:0}", total)

    End Sub

    Private Sub btnsube1_Click(sender As Object, e As EventArgs) Handles btnsube1.Click
        Dim CantAx1 As Integer = CInt(lblcantidad1.Text)
        Dim precioAx1 As Integer
        If CantAx1 = 9 Then Exit Sub
        CantAx1 = CantAx1 + 1
        precioAx1 = CInt(lblprecio1.Text.Substring(1))
        If hombres Then
            valorh1 = CantAx1
        End If
        If mujeres Then
            valorm1 = CantAx1
        End If
        If calzado Then
            valorc1 = CantAx1
        End If
        If accesorios Then
            valorac1 = CantAx1
        End If
        lblcantidad1.Text = CantAx1.ToString
        total = total + precioAx1
        lblTotal.Text = String.Format("${0:0}", total)
    End Sub
End Class