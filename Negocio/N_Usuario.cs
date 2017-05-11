using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Negocio
{
	public class N_Usuario
	{
		Datos.BD_Usuario bd = new Datos.BD_Usuario();

		public E_Usuario iniciarSesion(string usuario, string contrasenia)
		{
			return bd.iniciarSesion_Usuario(usuario, contrasenia);
		}
		public bool setContrasenia(string contraseniaNueva,Int64 idUsuario)
		{
			return bd.setContrasenia_Usuario(contraseniaNueva, idUsuario);
		}

		
	}
}
