using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_Articulo
    {
        private string _codArticulo;
        private string _descripcion;
        private E_Rubro _rubro;
        private E_Marca _marca;
        private E_Proveedor _proveedor;
        private E_Unidad _unidad;
        private string _ubicacion;
        private DateTime? _fecCompra;
        private Int32 _stockMin;
        private Int32 _stock;
        private decimal _precioLista;
        private decimal _iva;
        private string _observacion;
        private decimal _ganancia;
        private decimal _precioFinal;
		private List<E_DetalleCondicionCosto> _detCondCosto;

        public E_Articulo()
        {
             _marca = new E_Marca();
            _proveedor = new E_Proveedor();
            _rubro = new E_Rubro();
            _unidad =  new E_Unidad();
            _fecCompra = null;
            _stockMin = 0;
            _stock = 0;
            _precioLista = 0;
            _ganancia = 0;
            _precioFinal = 0;
            _iva = 0;
			_detCondCosto = new List<E_DetalleCondicionCosto>();
         }//contructor

        //Metodos de accesos setter y getter
        public string codArticulo { get { return _codArticulo; } set { _codArticulo = value; } }
        public string descripcion { get { return _descripcion; } set { _descripcion = value; } }
        public string ubicacion { get { return _ubicacion; } set { _ubicacion = value; } }
        public Int32 stockMin { get { return _stockMin; } set { _stockMin = value; } }
        public Int32 stock { get { return _stock; } set { _stock = value; } }
        public decimal precioLista { get { return _precioLista; } set { _precioLista = value; } }
        public decimal iva { get { return _iva; } set { _iva = value; } }
        public string observacion { get { return _observacion; } set { _observacion = value; } } 
        public DateTime? fecCompra { get { return _fecCompra; } set { _fecCompra = value; } }
        public E_Rubro rubro { get { return _rubro; } set { _rubro = value; } }
        public E_Proveedor proveedor { get { return _proveedor; } set { _proveedor = value; } }
        public E_Marca marca { get { return _marca; } set { _marca = value; } }
        public E_Unidad unidad { get { return _unidad; } set { _unidad = value; } }
        public string nombreMarca { get { return marca.nombre; } }
        public decimal ganancia { get { return _ganancia; } set { _ganancia = value; } }
        public decimal precioFinal { get { return _precioFinal; } set { _precioFinal = value; } }
		public List<E_DetalleCondicionCosto> detCondCosto { get { return _detCondCosto; } set { _detCondCosto = value; } } 
        //metodos
     

    }
}
