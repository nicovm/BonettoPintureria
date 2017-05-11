using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Datos;

namespace Test
{
    class Test
    {
        
        static void Main(string[] args)
        {
			testABM.addVenta();
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }


        

    }

    static class testABM
    {
		static public void addVenta()
		{
			E_Venta venta = new E_Venta();
			E_DetalleVenta detalleVenta = new E_DetalleVenta();
			//cabecera de venta
			venta.anular = false;
			venta.cliente.idCliente = 1; //consumidor final
			venta.codVenta = 0; // lo busco en la base de datos
			venta.condPago.idCondPago = 1; //efectivo
			venta.cuit = "26-3547123";
			venta.direccion = "";
			venta.fecha = DateTime.Now; //fecha de hoy
			venta.observacion = "Realizado en test";
			//venta.usuario.idUsuario = 1;// Bonnetto
			venta.vendedor.idVendedor = 1;// Eamnuel Bonetto
			//Detalle
			BD_Articulo bdAritculo = new BD_Articulo();
			//AGREGAR ARTICULO
			E_Articulo nvoArticulo = bdAritculo.getOne_Articulo("P1");
			detalleVenta.codArticulo = nvoArticulo.codArticulo;
			detalleVenta.descripcion = nvoArticulo.descripcion;
			detalleVenta.cantidad = 1;
			detalleVenta.precioArticulo = detalleVenta.cantidad * nvoArticulo.precioFinal;

			Console.WriteLine("idCliente: " + venta.cliente.idCliente + " condPago: " + venta.condPago);
			Console.WriteLine("CUIT: " + venta.cuit + " Fecha de venta: " + venta.fecha.ToString() );
			//Console.WriteLine("Observacion: " + venta.observacion + " idUsuario:  " + venta.usuario.idUsuario + " idVendedor "  + venta.vendedor.idVendedor);
			Console.WriteLine("----------------------------Detalle-----------------------------------");
			Console.WriteLine("codArticulo | Descripcion | descuento | cantidad | total ");
			Console.WriteLine( detalleVenta.codArticulo +" | " +  detalleVenta.descripcion + "|" + 0 +  " | " + detalleVenta.precioArticulo );



		}
		static public void addArticulo()
        {
            E_Articulo articulo = new E_Articulo();
            BD_Articulo bdAticulo = new BD_Articulo();
            string xRet;
            //articulo.codArticulo = 100;
            articulo.descripcion = "tersuave";
            articulo.ubicacion = "afuera";
            articulo.fecCompra = Convert.ToDateTime("24/12/2013");
            articulo.stockMin = 0;
            articulo.stock = 10;
            articulo.precioLista = 500;
            //articulo.descuento = 20;
            articulo.iva = 21;
            articulo.observacion = "metros nose";

            xRet = bdAticulo.add_Articulo(articulo);

            if (xRet != "0")
            {
                Console.WriteLine("no se agrego la marca");
            }
            else
            {
                Console.WriteLine("se agrego la marca");
            }

        }
        static public void addMarca()
        {
            string xRet;
            E_Marca m = new E_Marca();
            BD_Marca bd = new BD_Marca();

            m.nombre = "nombre de la marca";
            xRet = bd.add_Marca(m);


            if (xRet != "0")
            {
                Console.WriteLine("no se agrego la marca");
            }
            else
            {
                Console.WriteLine("se agrego la marca");
            }

        }
        static public void addRurbo()
        {
            string xRet;
            E_Rubro r = new E_Rubro();
            BD_Rubro bd = new BD_Rubro();
            r.nombre = "nombre del rubro";
            xRet = bd.add_Rubro(r);

           
            if (xRet != "0")
            {
                Console.WriteLine("no se agrego la Rurbro");
            }
            else
            {
                Console.WriteLine("se agrego la Rubro");
            }

        }
        static public void AddCliente()
        {
            E_Cliente c = new E_Cliente();
            BD_Cliente bdC = new BD_Cliente();
            Console.WriteLine("Agregar Cliente");
           

            //c.nombre = "nicolas";
            //c.apellido = "bringa";
            c.fecNac = Convert.ToDateTime("23/02/1991");
            c.localidad.idLocalidad = 2;
            c.telefono = "1527371231";
            c.direccion = "Los talas";
            c.dni = 35471756;
            c.descripcion = "nuevocliente";
            c.boletinProtec = false;
            BD_Cliente BD = new BD_Cliente();
            BD.add_Cliente(c);
            
            

            Console.WriteLine("Cliente Agregado");

        }
        static public void getAllCliente()
        {
            E_Cliente c = new E_Cliente();
            BD_Cliente bdC = new BD_Cliente();
            c = bdC.getOne_Cliente(23);

            Console.WriteLine( c.boletinProtec);
        }


    }
    static class articulo
    {
       
    }
}
