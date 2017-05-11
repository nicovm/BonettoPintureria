using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
namespace Negocio
{
	public class N_Notas
	{
		public Boolean guardarNota(DateTime fecha, string descripcion)
		{
			BD_Notas bdNotas = new BD_Notas();
			return  bdNotas.guardar_notas(descripcion);
			
		}
		public string getNotas()
		{
			BD_Notas bdNotas = new BD_Notas();

			return bdNotas.get_Nota();
		}
	}
}
