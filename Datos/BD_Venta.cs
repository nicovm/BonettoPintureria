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
	public	class BD_Venta
	{
		SqlConnection cn = new SqlConnection(Conexion.get_StringConexion());
		SqlCommand cmd;

		public Int64 add_Venta( E_Venta venta )
		{
			 string xRet = "0";
			 Int64 codVenta = 0;
			try
			{
				using (TransactionScope scope = new TransactionScope()) // creo el objeto para relizar la trsasaccion
				{
					cn.Open();//abro la conexion
					//crear cabecera de la venta
					string VentaSql = "INSERT INTO Ventas(fecVenta,idCliente,idVendedor,anular,idCondPago,direccion,CUIT,observacion,precioTotal,descuento,recargo) " +
							"VALUES(@fecVenta,@idCliente,@idVendedor,@anular,@idCondPago,@direccion,@CUIT,@observacion,@precioTotal,@descuento,@recargo) " +
							"SELECT SCOPE_IDENTITY()";
					
					cmd = new SqlCommand(VentaSql,cn);
					
					cmd.Parameters.AddWithValue("@idCliente", venta.cliente.idCliente);
					cmd.Parameters.AddWithValue("@idVendedor", venta.vendedor.idVendedor);
					cmd.Parameters.AddWithValue("@anular", venta.anular);
					cmd.Parameters.AddWithValue("@idCondPago", venta.condPago.idCondPago);
					cmd.Parameters.AddWithValue("@direccion", venta.direccion);
					cmd.Parameters.AddWithValue("@CUIT", venta.cuit);
					cmd.Parameters.AddWithValue("@observacion", venta.observacion);
					cmd.Parameters.AddWithValue("@fecVenta", venta.fecha);
					cmd.Parameters.AddWithValue("@precioTotal", venta.precioTotal);
					//cmd.Parameters.AddWithValue("@abonado", venta.abonado);
					cmd.Parameters.AddWithValue("descuento", venta.descuento);
					cmd.Parameters.AddWithValue("@recargo", venta.recargo);
					
					codVenta = Convert.ToInt64(cmd.ExecuteScalar());
					// insertar el abonando de la venta
					cmd = new SqlCommand("INSERT AbonarVenta (codVenta,fecAbonado,abonado) VALUES(@codVenta,@fecAbonado,@abonado)", cn);
					cmd.Parameters.AddWithValue("@codVenta", codVenta);
					cmd.Parameters.AddWithValue("@fecAbonado", DateTime.Now.Date);
					cmd.Parameters.AddWithValue("@abonado", venta.abonado);
					cmd.ExecuteScalar();
					
					
					//crear el detalle de la venta
					foreach (E_DetalleVenta detalle in venta.detalles)
					{
						string detalleSql = "INSERT INTO DetalleVenta(codVenta,cantidad,precio,codArticulo,precioTotal,Descripcion) " +
										"VALUES (@codVenta,@cantidad,@total,@codArticulo,@precioTotal,@Descripcion)";
						cmd = new SqlCommand(detalleSql, cn);
						cmd.Parameters.AddWithValue("@codVenta", codVenta);
						cmd.Parameters.AddWithValue("@cantidad", detalle.cantidad);
						cmd.Parameters.AddWithValue("@total", detalle.precioArticulo);
						cmd.Parameters.AddWithValue("@precioTotal", detalle.precioTotal);
						cmd.Parameters.AddWithValue("@codArticulo", detalle.codArticulo);
						cmd.Parameters.AddWithValue("@Descripcion", detalle.descripcion);

						cmd.ExecuteScalar();

						if (detalle.codArticulo != "#") // # significa que fue una producto ingresado para esta venta en particulo , el articulo no existe en el sistema
						{

							//modificar el stock de venta
							string consSql = " INSERT INTO StockArticulo(codArticulo,fecha,stockActual,codVenta) " +
											"VALUES(@codArticulo,@fecha,@stock,@codVenta) ";
							cmd = new SqlCommand(consSql, cn);

							Int32 stockActual = 0;
							if (detalle.stockActual > 0) // si el stock es mayor que cero le des
							{
								stockActual = detalle.stockActual - detalle.cantidad;
								if (stockActual < 0) stockActual = 0;
							}

							cmd.Parameters.AddWithValue("@codArticulo", detalle.codArticulo);
							cmd.Parameters.AddWithValue("@fecha", venta.fecha);
							cmd.Parameters.AddWithValue("@stock", stockActual);
							cmd.Parameters.AddWithValue("@codVenta", codVenta);

							cmd.ExecuteScalar();

							//actualizar el campo del stock de la venta
							consSql = "UPDATE Articulos SET Articulos.stock = @stock where Articulos.codArticulo = @codArticulo";
							cmd = new SqlCommand(consSql, cn);
							cmd.Parameters.AddWithValue("@stock", stockActual);
							cmd.Parameters.AddWithValue("@codArticulo", detalle.codArticulo);
							cmd.ExecuteScalar();
						}

					}

					// confirmar la trasaccionic
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
			return codVenta;
		}
        public string Update_Venta(E_Venta venta)
        {
             string xRet = "0";
            try
            {
               
                cn.Open();

                using (TransactionScope scope = new TransactionScope()) // creo el objeto para relizar la trsasaccion
                {
                    string UpdateSql = "Update Ventas set fecVenta=@fecVenta,idCliente=@idCliente,idVendedor=@idVendedor,anular=@anular,idCondPago=@idCondPago" +
                                        ",direccion=@direccion,CUIT=@CUIT,observacion=@observacion,precioTotal=@precioTotal,descuento=@descuento,recargo=@recargo " + 
                                        "Where  codVenta = @codVenta ";


                    cmd = new SqlCommand(UpdateSql, cn);

                    cmd.Parameters.AddWithValue("@codVenta",venta.codVenta);
                    cmd.Parameters.AddWithValue("@idCliente", venta.cliente.idCliente);
                    cmd.Parameters.AddWithValue("@idVendedor", venta.vendedor.idVendedor);
                    cmd.Parameters.AddWithValue("@anular", venta.anular);
                    cmd.Parameters.AddWithValue("@idCondPago", venta.condPago.idCondPago);
                    cmd.Parameters.AddWithValue("@direccion", venta.direccion);
                    cmd.Parameters.AddWithValue("@CUIT", venta.cuit);
                    cmd.Parameters.AddWithValue("@observacion", venta.observacion);
                    cmd.Parameters.AddWithValue("@fecVenta", venta.fecha);
                    cmd.Parameters.AddWithValue("@precioTotal", venta.precioTotal);
                    //cmd.Parameters.AddWithValue("@abonado", venta.abonado);
                    cmd.Parameters.AddWithValue("descuento", venta.descuento);
                    cmd.Parameters.AddWithValue("@recargo", venta.recargo);

                    cmd.ExecuteScalar();
                    //// insertar el abonando de la venta
                    //cmd = new SqlCommand("INSERT AbonarVenta (codVenta,fecAbonado,abonado) VALUES(@codVenta,@fecAbonado,@abonado)", cn);
                    //cmd.Parameters.AddWithValue("@codVenta", codVenta);
                    //cmd.Parameters.AddWithValue("@fecAbonado", DateTime.Now.Date);
                    //cmd.Parameters.AddWithValue("@abonado", venta.abonado);
                    //cmd.ExecuteScalar();

                    //ELiminar todos los detalles de esta venta
                    cmd = new SqlCommand("Delete from  DetalleVenta Where codVenta = @codVenta", cn);
                    cmd.Parameters.AddWithValue("@codVenta", venta.codVenta);

                    cmd.ExecuteScalar();


                    //Volver cargar los detalles modificado
                    //crear el detalle de la venta
                    foreach (E_DetalleVenta detalle in venta.detalles)
                    {
                        string detalleSql = "INSERT INTO DetalleVenta(codVenta,cantidad,precio,codArticulo,precioTotal,Descripcion) " +
                                        "VALUES (@codVenta,@cantidad,@total,@codArticulo,@precioTotal,@Descripcion)";
                        cmd = new SqlCommand(detalleSql, cn);
                        cmd.Parameters.AddWithValue("@codVenta", venta.codVenta);
                        cmd.Parameters.AddWithValue("@cantidad", detalle.cantidad);
                        cmd.Parameters.AddWithValue("@total", detalle.precioArticulo);
                        cmd.Parameters.AddWithValue("@precioTotal", detalle.precioTotal);
                        cmd.Parameters.AddWithValue("@codArticulo", detalle.codArticulo);
                        cmd.Parameters.AddWithValue("@Descripcion", detalle.descripcion);

                        cmd.ExecuteScalar();

                        if (detalle.codArticulo != "#") // # significa que fue una producto ingresado para esta venta en particulo , el articulo no existe en el sistema
                        {

                            //modificar el stock de venta
                            string consSql = " INSERT INTO StockArticulo(codArticulo,fecha,stockActual,codVenta) " +
                                            "VALUES(@codArticulo,@fecha,@stock,@codVenta) ";
                            cmd = new SqlCommand(consSql, cn);

                            Int32 stockActual = 0;
                            if (detalle.stockActual > 0) // si el stock es mayor que cero le des
                            {
                                stockActual = detalle.stockActual - detalle.cantidad;
                                if (stockActual < 0) stockActual = 0;
                            }

                            cmd.Parameters.AddWithValue("@codArticulo", detalle.codArticulo);
                            cmd.Parameters.AddWithValue("@fecha", venta.fecha);
                            cmd.Parameters.AddWithValue("@stock", stockActual);
                            cmd.Parameters.AddWithValue("@codVenta", venta.codVenta);

                            cmd.ExecuteScalar();

                            //actualizar el campo del stock de la venta
                            consSql = "UPDATE Articulos SET Articulos.stock = @stock where Articulos.codArticulo = @codArticulo";
                            cmd = new SqlCommand(consSql, cn);
                            cmd.Parameters.AddWithValue("@stock", stockActual);
                            cmd.Parameters.AddWithValue("@codArticulo", detalle.codArticulo);
                            cmd.ExecuteScalar();
                        }

                    }

                    // confirmar la trasaccionic
                    scope.Complete();
					

                         
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            return xRet;
        }
		public Int64 ulitCodVenta()
		{
			Int64 codVenta = 0;
			try
			{
				cn.Open();
				string sqlCons = "SELECT MAX(codVenta) FROM Ventas";
				cmd = new SqlCommand(sqlCons,cn);

				 codVenta = Convert.ToInt64(cmd.ExecuteScalar());
			}
			catch (Exception)
			{

				codVenta = 0;
			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}

			}

			return codVenta;
			

		}
		public List<E_Venta> getAll_Venta(DateTime fecDesde, DateTime fecHasta,string descripcionClie, string filtro)
		{
			
			List<E_Venta> ventas = new List<E_Venta>();
			try
			{
				cn.Open();
				cmd = new SqlCommand("getAllVentas", cn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@fecDesde", fecDesde);
				cmd.Parameters.AddWithValue("@fecHasta", fecHasta);
				cmd.Parameters.AddWithValue("@descripcion", descripcionClie);
				cmd.Parameters.AddWithValue("@filtro", filtro);
				SqlDataReader oReader = cmd.ExecuteReader();

				while (oReader.Read())
				{
					E_Venta venta = new E_Venta();

					venta.codVenta = Convert.ToInt64(oReader["codVenta"]);
					venta.condPago.descripcion = oReader["pago"].ToString();
					venta.cliente.descripcion = oReader["cliente"].ToString();
					venta.cliente.dni = Convert.ToInt32(oReader["dni"]);
					venta.fecha = Convert.ToDateTime(oReader["fecVenta"]);
					venta.precioTotal = Convert.ToDecimal(oReader["precioTotal"]);
					venta.abonado = Convert.ToDecimal(oReader["abonado"]);
					venta.anular = Convert.ToBoolean(oReader["anular"]);
                    //venta.creditoUtilizado = oReader["CreditoUtilizado"] != DBNull.Value ? Convert.ToDecimal( oReader["CreditoUtilizado"]): 0; 
					

					ventas.Add(venta);
				}

			}
			catch (Exception e)
			{
				ventas = null;
			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}

			}


			return ventas;
		}

        public List<E_Venta> getAll_Venta(DateTime fecDesde, DateTime fecHasta, Int64 idCliente )
        {

            List<E_Venta> ventas = new List<E_Venta>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("getAllVentasPendientes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecDesde", fecDesde);
                cmd.Parameters.AddWithValue("@fecHasta", fecHasta);
                cmd.Parameters.AddWithValue("@idCliente", idCliente);
                SqlDataReader oReader = cmd.ExecuteReader();

                while (oReader.Read())
                {
                    E_Venta venta = new E_Venta();

                    venta.codVenta = Convert.ToInt64(oReader["codVenta"]);
                    venta.condPago.descripcion = oReader["pago"].ToString();
                    venta.cliente.descripcion = oReader["cliente"].ToString();
                    venta.cliente.dni = Convert.ToInt32(oReader["dni"]);
                    venta.fecha = Convert.ToDateTime(oReader["fecVenta"]);
                    venta.precioTotal = Convert.ToDecimal(oReader["precioTotal"]);
                    venta.abonado = Convert.ToDecimal(oReader["abonado"]);
                    venta.anular = Convert.ToBoolean(oReader["anular"]);
                    //venta.creditoUtilizado = oReader["CreditoUtilizado"] != DBNull.Value ? Convert.ToDecimal( oReader["CreditoUtilizado"]): 0; 


                    ventas.Add(venta);
                }

            }
            catch (Exception e)
            {
                ventas = null;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }


            return ventas;
        }
		public E_Venta getOne_Venta(Int64 codVenta)
		{
			E_Venta venta = new E_Venta() ;
            try
            {
                cn.Open();
				//Obtener la cabecera de la venta
                cmd = new SqlCommand("getOneVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codVenta", codVenta);
                SqlDataReader oReaderVenta = cmd.ExecuteReader();

                while (oReaderVenta.Read())
                {

                    venta.codVenta = Convert.ToInt64(oReaderVenta["codVenta"]);
                    venta.fecha = Convert.ToDateTime(oReaderVenta["fecVenta"]);
					venta.vendedor.idVendedor = Convert.ToInt64(oReaderVenta["idVendedor"]);
					venta.anular = Convert.ToBoolean(oReaderVenta["anular"]);
					venta.condPago.idCondPago = Convert.ToInt64(oReaderVenta["idCondPago"]);
					venta.cliente.idCliente = Convert.ToInt64(oReaderVenta["idCliente"]);
					venta.direccion = oReaderVenta["direccion"].ToString();
					venta.cuit = oReaderVenta["cuit"].ToString();
					venta.observacion = oReaderVenta["observacion"].ToString();
					venta.precioTotal = Convert.ToDecimal(oReaderVenta["precioTotal"]);
					venta.abonado = Convert.ToDecimal(oReaderVenta["abonado"]);
					venta.descuento = Convert.ToDecimal(oReaderVenta["descuento"]);
					venta.recargo = Convert.ToDecimal(oReaderVenta["recargo"]);

					
                }
				oReaderVenta.Close();
				//Detalle de la venta
				cmd = new SqlCommand("getOneDetalleVenta", cn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@codVenta", codVenta);
				
				SqlDataReader oReaderDetalle = cmd.ExecuteReader();

				while (oReaderDetalle.Read())
				{
					E_DetalleVenta detVenta = new E_DetalleVenta();
					detVenta.idDetalle = Convert.ToInt64(oReaderDetalle["idDetalle"]);
					detVenta.codArticulo = oReaderDetalle["codArticulo"].ToString();
					detVenta.cantidad = Convert.ToInt16(oReaderDetalle["cantidad"]);
					detVenta.precioArticulo = Convert.ToDecimal(oReaderDetalle["precio"]);
					detVenta.precioTotal = Convert.ToDecimal(oReaderDetalle["precioTotal"]);
					detVenta.descripcion = oReaderDetalle["descripcion"].ToString();

					if (oReaderDetalle["stock"] != DBNull.Value)
					{
						detVenta.stockActual = Convert.ToInt16(oReaderDetalle["stock"]);
					}
					else
					{
						detVenta.stockActual = 0;
					}
					venta.detalles.Add(detVenta);
				}
                oReaderDetalle.Close();

                //CreditoUtilizado

                cmd = new SqlCommand("getOneCreditoUtilizado", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@codVentaUtilizado", codVenta);


                SqlDataReader oReaderCredito = cmd.ExecuteReader();


                while (oReaderCredito.Read())
                {
                    venta.creditoUtilizado = oReaderCredito["CreditoUtilizado"] != DBNull.Value ? (decimal)oReaderCredito["CreditoUtilizado"]: 0; 
                }



            }
            catch (Exception e)
            {
                PintError.MsjError = e.Message;
                venta = null;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }


            return venta;
        }
		public Boolean anular_Venta(E_Venta venta)
		{
			 Boolean xResp = true;
			try
			{
				using (TransactionScope scope = new TransactionScope()) // creo el objeto para relizar la trsasaccion
				{
					cn.Open();//abro la conexion
					//anular cabecera de la venta
					string anularSql = "UPDATE Ventas SET anular = @anular WHERE codVenta = @codVenta" ;
					cmd = new SqlCommand(anularSql,cn);
					cmd.Parameters.AddWithValue("@anular", true);
					cmd.Parameters.AddWithValue("@codVenta", venta.codVenta);

					cmd.ExecuteScalar();
					//crear el detalle de la venta
					foreach (E_DetalleVenta detalle in venta.detalles)
					{
						//Suma el stock de la vanta anulada
						Int32 stockActual = detalle.stockActual + detalle.cantidad;
						
						//actualizar el campo del stock de la venta
						string consSql = "UPDATE Articulos SET Articulos.stock = @stock where Articulos.codArticulo = @codArticulo" ;
						cmd = new SqlCommand(consSql, cn);
						cmd.Parameters.AddWithValue("@stock", stockActual);
						cmd.Parameters.AddWithValue("@codArticulo", detalle.codArticulo);
						cmd.ExecuteScalar();

						//Elimino el stockArcticulo
						string deleteSql = "DELETE FROM StockArticulo WHERE codVenta = @codVenta";
						cmd = new SqlCommand(deleteSql, cn);
						cmd.Parameters.AddWithValue("@codVenta", venta.codVenta);
						cmd.ExecuteScalar();

					}

					// confirmar la trasaccionic
					scope.Complete();

				}
			}
			catch (Exception e)
			{

				xResp = false;
			}
			finally
			{

			}
			return xResp;
		}
		public Boolean aplicarRecargo_Venta(Int64 codVenta,decimal recargo,decimal nvoPrecioTotal)
		{
			Boolean xConf = true;
			try
			{
				cn.Open();
				cmd = new SqlCommand("UPDATE Ventas SET recargo = @recargo, precioTotal=@precioTotal WHERE codVenta = @codVenta", cn);
				cmd.Parameters.AddWithValue("@recargo", recargo);
				cmd.Parameters.AddWithValue("@precioTotal", nvoPrecioTotal);
				cmd.Parameters.AddWithValue("@codVenta", codVenta);
				cmd.ExecuteScalar();

			}
			catch (Exception)
			{

				xConf = false;
			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
			}
			return xConf;
		}
		public Boolean aplicarRecargo_Venta(List<E_DetalleVenta> listDet,decimal precioTotaL,Int64 codVenta)
		{
			Boolean xConf = true;
			try 
			{
				using (TransactionScope scope = new TransactionScope()) // creo el objeto para relizar la trsasaccion
				{
					cn.Open();
					foreach (E_DetalleVenta detVent  in listDet)
					{
						
						cmd = new SqlCommand("UPDATE DetalleVenta SET precio = @precio, precioTotal=@precioTotal WHERE idDetalle=@idDetalle ", cn);
						cmd.Parameters.AddWithValue("@precio", detVent.precioArticulo);
						cmd.Parameters.AddWithValue("@idDetalle", detVent.idDetalle);
						cmd.Parameters.AddWithValue("@precioTotal", detVent.precioTotal);


						cmd.ExecuteScalar();
					}
					cmd = new SqlCommand("UPDATE Ventas SET precioTotal = @precioTotal WHERE codVenta = @codVenta ",cn);
					cmd.Parameters.AddWithValue("@codVenta", codVenta);
					cmd.Parameters.AddWithValue("@precioTotal", precioTotaL);
					cmd.ExecuteScalar();

					scope.Complete();
				}
				
			}
			catch (Exception)
			{

				xConf = false;
			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
			}
			return xConf;
		}

        /// <summary>
        /// Permite abonar una venta con saldo
        /// </summary>
        /// <param name="venta"></param>
        /// <param name="abonadoActual"></param>
        /// <returns></returns>
		public Boolean abonar_Venta(E_Venta venta, decimal abonadoActual)
		{
			Boolean xConf = true;
			try
			{
				using (TransactionScope scope = new TransactionScope()) // creo el objeto para relizar la trsasaccion
				{
					cn.Open();
				
					cmd = new SqlCommand("INSERT AbonarVenta (codVenta,fecAbonado,abonado) VALUES(@codVenta,@fecAbonado,@abonado)", cn);
					cmd.Parameters.AddWithValue("@codVenta", venta.codVenta);
					cmd.Parameters.AddWithValue("@fecAbonado", DateTime.Now.Date);
					cmd.Parameters.AddWithValue("@abonado", abonadoActual);
				
					cmd.ExecuteScalar();
					scope.Complete();
                    
				}

			}
			catch (Exception)
			{
                

				xConf = false;
			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
			}
			return xConf;
		}

        /// <summary>
        /// Permite abonar el total de un conjunto de ventas
        /// </summary>
        /// <param name="listVenta">Lista de ventas a abonar</param>
        /// <returns></returns>
        public Boolean abonar_Venta(List<E_Venta> listVenta)
        {
            Boolean xConf = true;
            using (TransactionScope scope = new TransactionScope()) // creo el objeto para relizar la trsasaccion
            {
                try
                {
                    cn.Open();
                    foreach (E_Venta venta in listVenta)
                    {
                        cmd = new SqlCommand("INSERT AbonarVenta (codVenta,fecAbonado,abonado) VALUES(@codVenta,@fecAbonado,@abonado)", cn);
                        cmd.Parameters.AddWithValue("@codVenta", venta.codVenta);
                        cmd.Parameters.AddWithValue("@fecAbonado", DateTime.Now.Date);
                        cmd.Parameters.AddWithValue("@abonado", venta.saldo); //Abona el total del saldo que debe

                        cmd.ExecuteScalar();

                    }
                    scope.Complete();
                    xConf = true;
                }
                catch 
                {

                    return xConf = false;
                }
            }
            return xConf;
        }

        /// <summary>
        /// Metodo que permite modificar el descuento de una venta, ya realizada
        /// </summary>
        /// <param name="descuentoMod"></param>
        /// <returns></returns>
        public Boolean setDescuento(decimal descuentoMod , decimal precioTotal,Int64 codVenta )
        {
            Boolean xConf = true;
            try
            {
                cn.Open();
                string sqlCons = "UPDATE Ventas SET descuento = @descuento , precioTotal = @precioTotal WHERE codVenta = @codVenta";

                cmd = new SqlCommand(sqlCons, cn);
                cmd.Parameters.AddWithValue("@descuento", descuentoMod);
                cmd.Parameters.AddWithValue("@precioTotal", precioTotal);
                cmd.Parameters.AddWithValue("@codventa", codVenta);


                cmd.ExecuteNonQuery();
                xConf = true;
            }
            catch (Exception)
            {

                xConf = false;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
               
            }
            return xConf;
        }
	}
		
}