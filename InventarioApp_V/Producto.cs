using System;
using InventarioApp_V;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioApp_V

{ 
	internal class Producto { 
		

	public string 
		Codigo { get; set; }
	public string
		Nombre { get; set; }
	public double
		Precio { get; set; }
	public int
		Cantidad { get; set; }


//Constructor
		public Producto
			(string codigo, string nombre, double precio, int cantidad)
		{
			Codigo = codigo;
            Nombre = nombre;
			Precio = precio;
            Cantidad = cantidad;
		}

	}
}