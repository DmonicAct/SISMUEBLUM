using System;
public class Kit: Producto{
	private List<ComponenteDeKit> _componentes;
	
	public Kit(String nombre, String color, Proveedor marca, String familia, String codigo, double stock, double precio): base(nombre, color, marca, familia, codigo, stock, precio){
		_componentes = new List<ComponenteDeKit>();
	}
	
	public void añadirComponente(Producto producto, double cantidad){
		ComponenteDeKit componente = new ComponenteDeKit(producto, cantidad);
		_componentes.Add(componente);
	}
	
	~Kit(){}
	
	public boolean hayStockSuficiente (double demanda) {return true;}
	public void descontarStock (double stockSaliente) {}
}