using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
namespace Datos
{
	public class BD_Pedido
	{
		SqlConnection cn = new SqlConnection(Conexion.get_StringConexion());
		SqlCommand cmd;

		public string add_Pedido(E_Pedido pedido)
		{
			string xRet = "0";
			try
			{
				using (TransactionScope scope = new TransactionScope()) // creo el objeto para relizar la trsasaccion
				{
					cn.Open();//abro la conexion
					//crear cabecera del Pedido
					string PedidoSql = "INSERT INTO Pedidos(fecPedido,idProveedor,idVendedor,idCondPago,direccion,CUIT,observacion,idEstado) " +
							"VALUES(@fecPedido,@idProveedor,@idVendedor,@idCondPago,@direccion,@CUIT,@observacion,@idEstado) " +
							"SELECT SCOPE_IDENTITY()";

					cmd = new SqlCommand(PedidoSql, cn);

					cmd.Parameters.AddWithValue("@idProveedor", pedido.proveedor.idProveedor);
					cmd.Parameters.AddWithValue("@idVendedor", pedido.vendedor.idVendedor);
					cmd.Parameters.AddWithValue("@anular", pedido.anular);
					cmd.Parameters.AddWithValue("@idCondPago", pedido.condPago.idCondPago);
					cmd.Parameters.AddWithValue("@direccion", pedido.direccion);
					cmd.Parameters.AddWithValue("@CUIT", pedido.cuit);
					cmd.Parameters.AddWithValue("@observacion", pedido.observacion);
					cmd.Parameters.AddWithValue("@fecPedido", pedido.fecha);
					cmd.Parameters.AddWithValue("idEstado", pedido.estadoPedido.idEstado);
					Int64 codPedido = 0;


					codPedido = Convert.ToInt64(cmd.ExecuteScalar());
					//crear el detalle de la venta
					foreach (E_DetallePedido detalle in pedido.detalles)
					{
						string detalleSql = "INSERT INTO DetallePedido(codPedido,cantidad,codArticulo,descripcionArt,observacionArt) " +
										"VALUES (@codPedido,@cantidad,@codArticulo,@descripcionArt,@observacionArt)";
						cmd = new SqlCommand(detalleSql, cn);
						cmd.Parameters.AddWithValue("@codPedido", codPedido);
						cmd.Parameters.AddWithValue("@cantidad", detalle.cantidad);
						cmd.Parameters.AddWithValue("@codArticulo", detalle.codArticulo);
						cmd.Parameters.AddWithValue("@descripcionArt", detalle.descripcionArt);
						cmd.Parameters.AddWithValue("@observacionArt", detalle.observacionArt);

						cmd.ExecuteScalar();

					}

					// confirmar la trasaccion
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
		public List<E_Pedido> getAll_Pedido(DateTime fecDesde, DateTime fecHasta ,string filtro,string estado)
		{
			List<E_Pedido> Pedidos = new List<E_Pedido>();
			try
			{
				cn.Open();
				cmd = new SqlCommand("getAllPedido", cn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@filtro", filtro);
				cmd.Parameters.AddWithValue("@fecDesde", fecDesde);
				cmd.Parameters.AddWithValue("@fecHasta", fecHasta);
				cmd.Parameters.AddWithValue("@estado", estado);
				SqlDataReader oReader = cmd.ExecuteReader();

				while (oReader.Read())
				{
					E_Pedido pedido = new E_Pedido();
					pedido.codPedido = Convert.ToInt64(oReader["codPedido"]);
					pedido.proveedor.raSocial = oReader["RaSocial"].ToString();
					pedido.cantidadArt = Convert.ToInt32( oReader["cantidad"]);
					pedido.fecha = Convert.ToDateTime(oReader["fecPedido"]);
					pedido.estadoPedido.idEstado = Convert.ToInt32(oReader["idEstado"]);
					
					Pedidos.Add(pedido);
				}

			}
			catch (Exception e)
			{
				Pedidos = null;
			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}

			}


			return Pedidos;
		}
		public E_Pedido getOne_Pedido(Int64 codPedido)
		{
			E_Pedido pedido = new E_Pedido();
			try
			{
				cn.Open();
				//Obtener la cabecera de la venta
				cmd = new SqlCommand("getOnePedido", cn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@codPedido", codPedido);
				SqlDataReader oReaderPedido = cmd.ExecuteReader();

				while (oReaderPedido.Read())
				{

					pedido.codPedido = Convert.ToInt64(oReaderPedido["codPedido"]);
					pedido.fecha = Convert.ToDateTime(oReaderPedido["fecPedido"]);
					pedido.vendedor.idVendedor = Convert.ToInt64(oReaderPedido["idVendedor"]);
					pedido.estadoPedido.idEstado = Convert.ToInt32(oReaderPedido["idEstado"]);
					pedido.condPago.idCondPago = Convert.ToInt64(oReaderPedido["idCondPago"]);
					pedido.proveedor.idProveedor = Convert.ToInt64(oReaderPedido["idProveedor"]);
					pedido.direccion = oReaderPedido["direccion"].ToString();
					pedido.cuit = oReaderPedido["cuit"].ToString();
					pedido.observacion = oReaderPedido["observacion"].ToString();
					if (oReaderPedido["fecEntrega"] != DBNull.Value) pedido.fecEntrega = Convert.ToDateTime(oReaderPedido["fecEntrega"]);
				

				}
				oReaderPedido.Close();
				//Detalle de la pedido
				cmd = new SqlCommand("getOneDetallePedido", cn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@codPedido", pedido.codPedido);

				SqlDataReader oReaderDetalle = cmd.ExecuteReader();

				while (oReaderDetalle.Read())
				{
					E_DetallePedido detPedido = new E_DetallePedido();
					detPedido.idDetalle = Convert.ToInt64(oReaderDetalle["idDetalle"]);
					detPedido.codArticulo = oReaderDetalle["codArticulo"].ToString();
					detPedido.descripcionArt = oReaderDetalle["descripcionArt"].ToString();
					detPedido.observacionArt = oReaderDetalle["observacionArt"].ToString();
					detPedido.cantidad = Convert.ToInt16(oReaderDetalle["cantidad"]);

					pedido.detalles.Add(detPedido);
				}

			}
			catch (Exception e)
			{
				pedido = null;
			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}

			}


			return pedido;
		}
		public Boolean anular_Pedido(Int64 codPedido)
		{
			Boolean xConf = true;
			try
			{
				
				cn.Open();//abro la conexion
				//anular cabecera de la venta
				string anularSql = "UPDATE Pedidos SET idEstado = @idEstado WHERE codPedido = @codPedido";
				cmd = new SqlCommand(anularSql, cn);
				cmd.Parameters.AddWithValue("@idEstado", E_EstadoPedido.ANULADO);
				cmd.Parameters.AddWithValue("@codPedido", codPedido);

				cmd.ExecuteScalar();
				
			
			}
			catch (Exception e)
			{

				xConf = false;
			}
			finally
			{

			}
			return xConf;
		}
		public Boolean confirmar_Pedido(E_Pedido pedido)
		{
			Boolean xConf = true;
			try
			{
				using (TransactionScope scope = new TransactionScope()) // creo el objeto para relizar la trsasaccion
				{
					cn.Open();//abro la conexion
					//confirmar el pedido
					string confSql = "UPDATE Pedidos SET idEstado = @idEstado ,fecEntrega = @fecEntrega,observacion = @observacion  WHERE codPedido = @codPedido";
					cmd = new SqlCommand(confSql, cn);
					cmd.Parameters.AddWithValue("@idEstado", E_EstadoPedido.CONFIRMADO);
					cmd.Parameters.AddWithValue("@codPedido", pedido.codPedido);
					cmd.Parameters.AddWithValue("@fecEntrega", pedido.fecEntrega);
					cmd.Parameters.AddWithValue("@observacion", pedido.observacion);

					cmd.ExecuteScalar();
					// borro el el detalle del pedido porque se puedo a ver modificado
					string borrarDetalle = "DELETE FROM DetallePedido WHERE codPedido=@codPedido";
					cmd = new SqlCommand(borrarDetalle, cn);
					cmd.Parameters.AddWithValue("@codPedido", pedido.codPedido);
					cmd.ExecuteScalar();

					//genero el nuevo detalle
					foreach (E_DetallePedido detalle in pedido.detalles)
					{
						string detalleSql = "INSERT INTO DetallePedido(codPedido,cantidad,codArticulo,descripcionArt,observacionArt) " +
										"VALUES (@codPedido,@cantidad,@codArticulo,@descripcionArt,@observacionArt)";
						cmd = new SqlCommand(detalleSql, cn);
						cmd.Parameters.AddWithValue("@codPedido", pedido.codPedido);
						cmd.Parameters.AddWithValue("@cantidad", detalle.cantidad);
						cmd.Parameters.AddWithValue("@codArticulo", detalle.codArticulo);
						cmd.Parameters.AddWithValue("@descripcionArt", detalle.descripcionArt);
						cmd.Parameters.AddWithValue("@observacionArt", detalle.observacionArt);

						cmd.ExecuteScalar();

						//modificar el stock de los articulos
						string consSql = " INSERT INTO StockArticulo(codArticulo,fecha,stockActual,codPedido) " +
										"VALUES(@codArticulo,@fecha,@stock,@codPedido) ";
						cmd = new SqlCommand(consSql, cn);

						Int32 stockModif = detalle.stockActual + detalle.cantidad;
					

						cmd.Parameters.AddWithValue("@codArticulo", detalle.codArticulo);
						cmd.Parameters.AddWithValue("@fecha", pedido.fecEntrega);
						cmd.Parameters.AddWithValue("@stock", stockModif);
						cmd.Parameters.AddWithValue("@codPedido", pedido.codPedido);

						cmd.ExecuteScalar();

						//actualizar el campo del stock de la venta
						consSql = "UPDATE Articulos SET Articulos.stock = @stock where Articulos.codArticulo = @codArticulo";
						cmd = new SqlCommand(consSql, cn);
						cmd.Parameters.AddWithValue("@stock", stockModif);
						cmd.Parameters.AddWithValue("@codArticulo", detalle.codArticulo);
						cmd.ExecuteScalar();
					}

					cmd.ExecuteScalar();

					scope.Complete();
				}

			}
			catch (Exception e)
			{

				xConf = false;
			}
			finally
			{

			}
			return xConf;
		}
		public Int64 ulitCodCompra()
		{
			Int64 codCompra = 0;
			try
			{
				cn.Open();
				string sqlCons = "SELECT MAX(codPedido) FROM Pedidos";
				cmd = new SqlCommand(sqlCons, cn);

				codCompra = Convert.ToInt64(cmd.ExecuteScalar());
			}
			catch (Exception)
			{

				codCompra = 0;
			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}

			}

			return codCompra;


		}
	}
}
