using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using System.Transactions;
namespace Datos 
{
    public class BD_Articulo
    {
        SqlConnection cn =  new SqlConnection(Conexion.get_StringConexion());
        SqlCommand cmd;

        string xRet;
       

		//public String add_Articulo(E_Articulo articulo)
		//{
		//    String xRet = "0";
		//    try
		//    {
                
		//        cmd = new SqlCommand("addArticulo", cn);
		//        cmd.CommandType = CommandType.StoredProcedure;
		//        cmd.Parameters.AddWithValue("@codArticulo", articulo.codArticulo);
		//        cmd.Parameters.AddWithValue("@descripcion", articulo.descripcion);
		//        if (articulo.rubro.idRubro != 0)
		//        {
		//            cmd.Parameters.AddWithValue("@idRubro", articulo.rubro.idRubro);
		//        }
		//        else
		//        {
		//            cmd.Parameters.AddWithValue("@idRubro", DBNull.Value);
		//        }
		//        if (articulo.marca.idMarca != 0)
		//        {
		//            cmd.Parameters.AddWithValue("@idMarca", articulo.marca.idMarca);
		//        }
		//        else
		//        {
		//            cmd.Parameters.AddWithValue("@idMarca", DBNull.Value);
		//        }
		//        if (articulo.proveedor.idProveedor != 0)
		//        {
		//            cmd.Parameters.AddWithValue("@idProveedores", articulo.proveedor.idProveedor);
		//        }
		//        else
		//        {
		//            cmd.Parameters.AddWithValue("@idProveedores", DBNull.Value);
		//        }
		//        if (articulo.unidad.idUnidad != 0)
		//        {
		//            cmd.Parameters.AddWithValue("@idUnidad", articulo.unidad.idUnidad);
		//        }
		//        else
		//        {
		//            cmd.Parameters.AddWithValue("@idUnidad", DBNull.Value);
		//        }
		//        cmd.Parameters.AddWithValue("@ubicacion", articulo.ubicacion);
		//        if (articulo.fecCompra != null)
		//        {
		//            cmd.Parameters.AddWithValue("@fecCompra", articulo.fecCompra);
		//        }
		//        else
		//        {
		//            cmd.Parameters.AddWithValue("@fecCompra", DBNull.Value);
		//        }
		//        cmd.Parameters.AddWithValue("@ganancia", articulo.ganancia);
		//        cmd.Parameters.AddWithValue("@stockMin", articulo.stockMin);
		//        cmd.Parameters.AddWithValue("@stock", articulo.stock);
		//        cmd.Parameters.AddWithValue("@precioLista", articulo.precioLista);
		//        cmd.Parameters.AddWithValue("@precioFinal", articulo.precioFinal);
		//        cmd.Parameters.AddWithValue("@descuento", 0);
		//        cmd.Parameters.AddWithValue("@iva", articulo.iva);
		//        cmd.Parameters.AddWithValue("@observacion", articulo.observacion);
		//        //cmd.Parameters.AddWithValue("@msgErr","error");
		//        SqlParameter msgErr = new SqlParameter("@msgErr",DbType.String);
		//        msgErr.Direction = ParameterDirection.Output;
		//        cmd.Parameters.Add(msgErr);
		//       // cmd.Parameters.Add(new SqlParameter("@msgErr", ""));
		//        cn.Open();
		//        SqlDataReader oReader = cmd.ExecuteReader();
		//        while (oReader.Read())
		//        {
		//            string xR = oReader["error"].ToString();
		//        }
                
		//        //TuSqlCommand.Parameters.Add(new SqlParameter("@RETORNO"))
		//        //TuSqlCommand.Parameters[""@RETORNO""].ParameterDirection = ParameterDirection.Output
		//        //luego podras recuperar el valor retornado asi
		//        //valor = TuSqlCommand.Parameters[""@RETORNO""]

		//    }
		//    catch (Exception e)
		//    {
		//        xRet = e.Message;

		//    }
		//    finally
		//    {
		//        if (cn.State == ConnectionState.Open)
		//        {
		//            cn.Close();
		//        }

		//    }

		//    return xRet;
		//}//addCliente // con procedimiento almacenado utilizo variable de retorno por si se produce un error
		public String add_Articulo(E_Articulo articulo)
		{
			String xRet = "0";
			try
			{
					using (TransactionScope scope = new TransactionScope()) // creo el objeto para relizar la trsasaccion
				{

					cmd = new SqlCommand("INSERT INTO Articulos(codArticulo,descripcion,idRubro,idMarca,idProveedor,idUnidad,ubicacion " +
										",fecCompra,stockMin,stock,precioLista,descuento,iva,observacion,ganancia,precioFinal) " +
										"VALUES(@codArticulo,@descripcion,@idRubro,@idMarca,@idProveedores,@idUnidad,@ubicacion,@fecCompra" +
										",@stockMin,@stock,@precioLista,@descuento,@iva,@observacion,@ganancia,@precioFinal)", cn);
					cmd.CommandType = CommandType.Text;
					cmd.Parameters.AddWithValue("@codArticulo", articulo.codArticulo);
					cmd.Parameters.AddWithValue("@descripcion", articulo.descripcion);
					if (articulo.rubro.idRubro != 0)
					{
						cmd.Parameters.AddWithValue("@idRubro", articulo.rubro.idRubro);
					}
					else
					{
						cmd.Parameters.AddWithValue("@idRubro", DBNull.Value);
					}
					if (articulo.marca.idMarca != 0)
					{
						cmd.Parameters.AddWithValue("@idMarca", articulo.marca.idMarca);
					}
					else
					{
						cmd.Parameters.AddWithValue("@idMarca", DBNull.Value);
					}
					if (articulo.proveedor.idProveedor != 0)
					{
						cmd.Parameters.AddWithValue("@idProveedores", articulo.proveedor.idProveedor);
					}
					else
					{
						cmd.Parameters.AddWithValue("@idProveedores", DBNull.Value);
					}
					if (articulo.unidad.idUnidad != 0)
					{
						cmd.Parameters.AddWithValue("@idUnidad", articulo.unidad.idUnidad);
					}
					else
					{
						cmd.Parameters.AddWithValue("@idUnidad", DBNull.Value);
					}
					cmd.Parameters.AddWithValue("@ubicacion", articulo.ubicacion);
					if (articulo.fecCompra != null)
					{
						cmd.Parameters.AddWithValue("@fecCompra", articulo.fecCompra);
					}
					else
					{
						cmd.Parameters.AddWithValue("@fecCompra", DBNull.Value);
					}
					cmd.Parameters.AddWithValue("@ganancia", articulo.ganancia);
					cmd.Parameters.AddWithValue("@stockMin", articulo.stockMin);
					cmd.Parameters.AddWithValue("@stock", articulo.stock);
					cmd.Parameters.AddWithValue("@precioLista", articulo.precioLista);
					cmd.Parameters.AddWithValue("@precioFinal", articulo.precioFinal);
					cmd.Parameters.AddWithValue("@descuento", 0);
					cmd.Parameters.AddWithValue("@iva", articulo.iva);
					cmd.Parameters.AddWithValue("@observacion", articulo.observacion);

				
					cn.Open();
					cmd.ExecuteScalar();
					// Guardar la condicion para calcular el costo total
						foreach (E_DetalleCondicionCosto detCosto in articulo.detCondCosto)
						{
							cmd = new SqlCommand("INSERT DetalleCondicion(codArticulo,condicion,orden,porcentaje,descripcion)VALUES(@codArticulo,@condicion,@orden,@porcentaje,@descripcion)",cn);
							cmd.Parameters.AddWithValue("@codArticulo",articulo.codArticulo);
							cmd.Parameters.AddWithValue("@condicion",detCosto.condicion);
							cmd.Parameters.AddWithValue("@orden",detCosto.orden);
							cmd.Parameters.AddWithValue("@porcentaje", detCosto.porcentaje);
							cmd.Parameters.AddWithValue("@descripcion", detCosto.descrpcion);

							cmd.ExecuteScalar();
						}//for
					
					// GUARDAR EL HISTORIAL DEL STOCK 
					cmd = new SqlCommand("INSERT INTO StockArticulo(codArticulo,fecha,stockActual) VALUES(@codArticulo,@fecCompra,@stock)",cn);
						cmd.Parameters.AddWithValue("@codArticulo",articulo.codArticulo);
						cmd.Parameters.AddWithValue("FecCompra",articulo.fecCompra);
						cmd.Parameters.AddWithValue("@stock",articulo.stock);
						

						cmd.ExecuteScalar();
				

					// confirmar la trasaccionic
					scope.Complete();

				
				}//Fin de trasaccion
			}
			catch (Exception e)
			{
				xRet = e.Message;

			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}

			}

			return xRet;
		}//addCliente
		/// <summary>
		/// Permite modificar el articulo y tambien su codArticulo
		/// </summary>
		/// <param name="articulo"></param>
		/// <param name="oCodArticuloViejo"></param>
		/// <returns></returns>
        public String set_Articulo(E_Articulo articulo, string oCodArticuloViejo)
        {
            string xRet = "0";
            try
            {
				using (TransactionScope scope = new TransactionScope()) // creo el objeto para relizar la trsasaccion
				{

					cmd = new SqlCommand("UPDATE Articulos SET codArticulo= @codArticuloMod,  descripcion=@descripcion,idRubro=@idRubro,idMarca=@idMarca,idProveedor=@idProveedores," +
										"idUnidad=@idUnidad,ubicacion=@ubicacion,fecCompra=@fecCompra,stockMin=@stockMin,stock=@stock, " +
										"precioLista=@precioLista,descuento=@descuento,iva=@iva,observacion=@observacion,precioFinal=@precioFinal,ganancia = @ganancia " +
										"WHERE codArticulo = @codArticulo", cn);
					cmd.CommandType = CommandType.Text;
					cmd.Parameters.AddWithValue("@codArticuloMod", articulo.codArticulo);
					cmd.Parameters.AddWithValue("@codArticulo", oCodArticuloViejo);
					cmd.Parameters.AddWithValue("@descripcion", articulo.descripcion);
					if (articulo.rubro.idRubro != 0)
					{
						cmd.Parameters.AddWithValue("@idRubro", articulo.rubro.idRubro);
					}
					else
					{
						cmd.Parameters.AddWithValue("@idRubro", DBNull.Value);
					}
					if (articulo.marca.idMarca != 0)
					{
						cmd.Parameters.AddWithValue("@idMarca", articulo.marca.idMarca);
					}
					else
					{
						cmd.Parameters.AddWithValue("@idMarca", DBNull.Value);
					}
					if (articulo.proveedor.idProveedor != 0)
					{
						cmd.Parameters.AddWithValue("@idProveedores", articulo.proveedor.idProveedor);
					}
					else
					{
						cmd.Parameters.AddWithValue("@idProveedores", DBNull.Value);
					}
					if (articulo.unidad.idUnidad != 0)
					{
						cmd.Parameters.AddWithValue("@idUnidad", articulo.unidad.idUnidad);
					}
					else
					{
						cmd.Parameters.AddWithValue("@idUnidad", DBNull.Value);
					}
					cmd.Parameters.AddWithValue("@ubicacion", articulo.ubicacion);
					if (articulo.fecCompra != null)
					{
						cmd.Parameters.AddWithValue("@fecCompra", articulo.fecCompra);
					}
					else
					{
						cmd.Parameters.AddWithValue("@fecCompra", DBNull.Value);
					}
					cmd.Parameters.AddWithValue("@ganancia", articulo.ganancia);
					cmd.Parameters.AddWithValue("@stockMin", articulo.stockMin);
					cmd.Parameters.AddWithValue("@stock", articulo.stock);
					cmd.Parameters.AddWithValue("@precioLista", articulo.precioLista);
					cmd.Parameters.AddWithValue("@precioFinal", articulo.precioFinal);
					cmd.Parameters.AddWithValue("@descuento", 0);
					cmd.Parameters.AddWithValue("@iva", articulo.iva);
					cmd.Parameters.AddWithValue("@observacion", articulo.observacion);
					cn.Open();
					cmd.ExecuteScalar();
					// elimino el detalle de condicion para calcular el stock
					cmd = new SqlCommand("DELETE FROM DetalleCondicion WHERE codArticulo = @codArticulo",cn);
					cmd.Parameters.AddWithValue("@codArticulo", articulo.codArticulo);
					cmd.ExecuteScalar();
					//los creo de vuelta por si huvo una modificacion
					// Guardar la condicion para calcular el costo total
					foreach (E_DetalleCondicionCosto detCosto in articulo.detCondCosto)
					{
						cmd = new SqlCommand("INSERT DetalleCondicion(codArticulo,condicion,orden,porcentaje,descripcion)VALUES		(@codArticulo,@condicion,@orden,@porcentaje,@descripcion)", cn);
						cmd.Parameters.AddWithValue("@codArticulo", articulo.codArticulo);
						cmd.Parameters.AddWithValue("@condicion", detCosto.condicion);
						cmd.Parameters.AddWithValue("@orden", detCosto.orden);
						cmd.Parameters.AddWithValue("@porcentaje", detCosto.porcentaje);
						cmd.Parameters.AddWithValue("@descripcion", detCosto.descrpcion);

						cmd.ExecuteScalar();
					}//for
					scope.Complete();
				}//transaccion
            }//try
            catch (Exception e)
            {
				
                xRet = e.Message;

            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
             
            }

            return xRet;
        }//setArticuloo
		/// <summary>
		/// Permite modificar un articulo
		/// </summary>
		/// <param name="articulo"></param>
		/// <returns></returns>
		public String set_Articulo(E_Articulo articulo)
		{
			string xRet = "0";
			try
			{
				using (TransactionScope scope = new TransactionScope()) // creo el objeto para relizar la trsasaccion
				{

					cmd = new SqlCommand("UPDATE Articulos SET descripcion=@descripcion,idRubro=@idRubro,idMarca=@idMarca,idProveedor=@idProveedores," +
										"idUnidad=@idUnidad,ubicacion=@ubicacion,fecCompra=@fecCompra,stockMin=@stockMin,stock=@stock, " +
										"precioLista=@precioLista,descuento=@descuento,iva=@iva,observacion=@observacion,precioFinal=@precioFinal,ganancia=@ganancia " +
										"WHERE codArticulo = @codArticulo", cn);
					cmd.CommandType = CommandType.Text;
					cmd.Parameters.AddWithValue("@codArticulo", articulo.codArticulo);
					cmd.Parameters.AddWithValue("@descripcion", articulo.descripcion);
					if (articulo.rubro.idRubro != 0)
					{
						cmd.Parameters.AddWithValue("@idRubro", articulo.rubro.idRubro);
					}
					else
					{
						cmd.Parameters.AddWithValue("@idRubro", DBNull.Value);
					}
					if (articulo.marca.idMarca != 0)
					{
						cmd.Parameters.AddWithValue("@idMarca", articulo.marca.idMarca);
					}
					else
					{
						cmd.Parameters.AddWithValue("@idMarca", DBNull.Value);
					}
					if (articulo.proveedor.idProveedor != 0)
					{
						cmd.Parameters.AddWithValue("@idProveedores", articulo.proveedor.idProveedor);
					}
					else
					{
						cmd.Parameters.AddWithValue("@idProveedores", DBNull.Value);
					}
					if (articulo.unidad.idUnidad != 0)
					{
						cmd.Parameters.AddWithValue("@idUnidad", articulo.unidad.idUnidad);
					}
					else
					{
						cmd.Parameters.AddWithValue("@idUnidad", DBNull.Value);
					}
					cmd.Parameters.AddWithValue("@ubicacion", articulo.ubicacion);
					if (articulo.fecCompra != null)
					{
						cmd.Parameters.AddWithValue("@fecCompra", articulo.fecCompra);
					}
					else
					{
						cmd.Parameters.AddWithValue("@fecCompra", DBNull.Value);
					}
					cmd.Parameters.AddWithValue("@ganancia", articulo.ganancia);
					cmd.Parameters.AddWithValue("@stockMin", articulo.stockMin);
					cmd.Parameters.AddWithValue("@stock", articulo.stock);
					cmd.Parameters.AddWithValue("@precioLista", articulo.precioLista);
					cmd.Parameters.AddWithValue("@precioFinal", articulo.precioFinal);
					cmd.Parameters.AddWithValue("@descuento", 0);
					cmd.Parameters.AddWithValue("@iva", articulo.iva);
					cmd.Parameters.AddWithValue("@observacion", articulo.observacion);
					cn.Open();
					cmd.ExecuteScalar();
					// elimino el detalle de condicion para calcular el stock
					cmd = new SqlCommand("DELETE FROM DetalleCondicion WHERE codArticulo = @codArticulo", cn);
					cmd.Parameters.AddWithValue("@codArticulo", articulo.codArticulo);
					cmd.ExecuteScalar();
					//los creo de vuelta por si huvo una modificacion
					// Guardar la condicion para calcular el costo total
					foreach (E_DetalleCondicionCosto detCosto in articulo.detCondCosto)
					{
						cmd = new SqlCommand("INSERT DetalleCondicion(codArticulo,condicion,orden,porcentaje,descripcion)VALUES		(@codArticulo,@condicion,@orden,@porcentaje,@descripcion)", cn);
						cmd.Parameters.AddWithValue("@codArticulo", articulo.codArticulo);
						cmd.Parameters.AddWithValue("@condicion", detCosto.condicion);
						cmd.Parameters.AddWithValue("@orden", detCosto.orden);
						cmd.Parameters.AddWithValue("@porcentaje", detCosto.porcentaje);
						cmd.Parameters.AddWithValue("@descripcion", detCosto.descrpcion);

						cmd.ExecuteScalar();
					}//for
					scope.Complete();
				}//transaccion
			}//try
			catch (Exception e)
			{

				xRet = e.Message;

			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}

			}

			return xRet;
		}//setArticulo

        public List<E_Articulo> getAll_Articulo(string filtro)
        {
            List<E_Articulo> articulos = new List<E_Articulo>();
            String xRet = "0";
            try
            {
                cn.Open();
                cmd = new SqlCommand("getAllArticulo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@filtro", filtro);
                SqlDataReader oReader = cmd.ExecuteReader();

                while (oReader.Read())
                {
                    E_Articulo articulo = new E_Articulo();
                    articulo.codArticulo = oReader["codArticulo"].ToString();
                    articulo.descripcion = oReader["descripcion"].ToString();
                    articulo.stock = Convert.ToInt32(oReader["stock"]);
                    articulo.marca.nombre = oReader["nombreMarca"].ToString();
                    articulo.precioFinal = Convert.ToDecimal(oReader["precioFinal"]);
                    articulo.observacion = oReader["observacion"].ToString();
					articulo.stockMin = Convert.ToInt16(oReader["stockMin"]);
                    articulos.Add(articulo);
                }

            }
            catch (Exception e)
            {
                xRet = e.Message;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }


            return articulos;
        }
        public List<E_Articulo> getAll_ArticuloXcod(string filtro)
        {
            List<E_Articulo> articulos = new List<E_Articulo>();
            String xRet = "0";
            try
            {
                cn.Open();
                cmd = new SqlCommand("getAllArticuloXcod", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codArticulo", filtro);
                SqlDataReader oReader = cmd.ExecuteReader();

                while (oReader.Read())
                {
                    E_Articulo articulo = new E_Articulo();
                    articulo.codArticulo = oReader["codArticulo"].ToString();
                    articulo.descripcion = oReader["descripcion"].ToString();
                    articulo.stock = Convert.ToInt32(oReader["stock"]);
                    articulo.marca.nombre = oReader["nombreMarca"].ToString();
                    articulo.precioFinal = Convert.ToDecimal(oReader["precioFinal"]);
                    articulo.observacion = oReader["observacion"].ToString();

                    articulos.Add(articulo);
                }

            }
            catch (Exception e)
            {
                xRet = e.Message;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }


            return articulos;
        }
        public E_Articulo getOne_Articulo(string codArticulo)
        {
			E_Articulo articulo = null;
          
            try
            {
                cn.Open();
                cmd = new SqlCommand("getOneArticulo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codArticulo", codArticulo);
                SqlDataReader oReader = cmd.ExecuteReader();


                while (oReader.Read())
                {
					articulo = new E_Articulo();
                    articulo.codArticulo = oReader["codArticulo"].ToString();
                    articulo.descripcion = oReader["descripcion"].ToString();
                    articulo.stock = Convert.ToInt32(oReader["stock"]);
                 
                    if (oReader["idMarca"] != DBNull.Value) articulo.marca.idMarca = Convert.ToInt64(oReader["idMarca"]);
                    if (oReader["idRubro"] != DBNull.Value) articulo.rubro.idRubro = Convert.ToInt64(oReader["idRubro"]);
                    if (oReader["idProveedor"] != DBNull.Value) articulo.proveedor.idProveedor = Convert.ToInt64(oReader["idProveedor"]);
                    if (oReader["idUnidad"] != DBNull.Value) articulo.unidad.idUnidad = Convert.ToInt64(oReader["idUnidad"]);
                    articulo.ubicacion = oReader["ubicacion"].ToString();
                    if (oReader["FecCompra"] != DBNull.Value) articulo.fecCompra = Convert.ToDateTime(oReader["FecCompra"]);
                    articulo.stock = Convert.ToInt32(oReader["stock"]);
                    articulo.stockMin = Convert.ToInt32(oReader["stockMin"]);
                    articulo.precioLista = Convert.ToDecimal(oReader["precioLista"]);
                    articulo.precioFinal = Convert.ToDecimal(oReader["precioFinal"]);
                    articulo.iva = Convert.ToDecimal(oReader["iva"]);
                    articulo.observacion = oReader["observacion"].ToString();
                    articulo.ganancia = Convert.ToDecimal(oReader["ganancia"]);

                }
				oReader.Close();
				//Busco el detalle de condicion para generar calcular el costo y el precio final
				SqlCommand cmdDetCOnd = new SqlCommand("SELECT * FROM DetalleCondicion WHERE codArticulo = @codArticulo",cn);
				cmdDetCOnd.Parameters.AddWithValue("@codArticulo", codArticulo);

				SqlDataReader oReaderDetCond = cmdDetCOnd.ExecuteReader();

				while (oReaderDetCond.Read())
				{
					E_DetalleCondicionCosto detCondCosto = new E_DetalleCondicionCosto();
					detCondCosto.condicion = oReaderDetCond["condicion"].ToString();
					detCondCosto.orden = Convert.ToInt16(oReaderDetCond["orden"]);
					detCondCosto.porcentaje = Convert.ToDecimal(oReaderDetCond["porcentaje"]);
					detCondCosto.descrpcion = oReaderDetCond["descripcion"].ToString();

					articulo.detCondCosto.Add(detCondCosto); // agrego a lista de condiciones del articulo para calcular el costo
				}


            }
            catch (Exception e)
            {
                articulo = null;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }


            return articulo;
        }
        public Int16 count_Articulo(string codArticulo)
        {
            Int16 count = 0;
            try
            {
                cmd = new SqlCommand("countArticulo", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@codArticulo", codArticulo);
                cn.Open();
                SqlDataReader oReader = cmd.ExecuteReader();
                while (oReader.Read())
                {
                    count =  Convert.ToInt16(oReader["cantidad"]);
                }

            }
            catch (Exception)
            {

                count = 2;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }

            return count;
        }
        public string delete_Articulo(string codArticulo)
        {
			try
			{
				using (TransactionScope scope = new TransactionScope()) // creo el objeto para relizar la trsasaccion
				{
					cn.Open();
					cmd = new SqlCommand("DELETE FROM Articulos WHERE codArticulo = @codArticulo", cn);
					cmd.CommandType = CommandType.Text;
					cmd.Parameters.AddWithValue("@codArticulo", codArticulo);
					cmd.ExecuteNonQuery();

					cmd = new SqlCommand("DELETE FROM DetalleCondicion WHERE codArticulo = @codArticulo", cn);
					cmd.Parameters.AddWithValue("@codArticulo", codArticulo);
					cmd.ExecuteNonQuery();

					cmd = new SqlCommand("DELETE FROM StockArticulo WHERE codArticulo = @codArticulo", cn);
					cmd.Parameters.AddWithValue("@codArticulo", codArticulo);
					cmd.ExecuteScalar();
					scope.Complete();

				}
			}
			catch (Exception e)
			{
				xRet = e.Message;

			}
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return xRet;
        }
		public List<E_Stock> getAll_StockArticulo(string codArticulo)
		{

			List<E_Stock> listStock = new List<E_Stock>();
            try
            {
				
                cn.Open();
                cmd = new SqlCommand("getAllStockXArticulo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codArticulo", codArticulo);
                SqlDataReader oReader = cmd.ExecuteReader();

				if(oReader == null) listStock = null;
                while (oReader.Read())
                {
                    E_Stock stock = new E_Stock();

					stock.idStockArticulo = Convert.ToInt64(oReader["idStockArticulo"]);
					stock.stockActual = Convert.ToInt32(oReader["stockActual"]);
					stock.codArticulo = oReader["codArticulo"].ToString();
					if(oReader["codCompra"]!= DBNull.Value)   stock.codCompra =Convert.ToInt64( oReader["codCompra"]);
					if(oReader["codVenta"] != DBNull.Value)  stock.codVenta = Convert.ToInt64(oReader["codVenta"]);
					stock.fecha = Convert.ToDateTime(oReader["fecha"]);


					listStock.Add(stock);
                }

            }
            catch (Exception e)
            {
                xRet = e.Message;
				listStock = null;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }


            return listStock;
        }



		}
		


    }

