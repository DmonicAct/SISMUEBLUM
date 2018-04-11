using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kit: Producto{
	private List<ComponenteDeKit> _componentes;
	
	public Kit(String nombre, String color, Proveedor marca, String familia, String codigo, double precio): base(nombre, color, marca, familia, codigo, precio){
		_componentes = new List<ComponenteDeKit>();
	}
	
	public void anhadirComponente(Producto producto, double cantidad){
		ComponenteDeKit componente = new ComponenteDeKit(producto, cantidad);
		_componentes.Add(componente);
	}
	
	~Kit(){}
}