import java.util.*;

public class Kit extends Producto{
	private List<ComponenteDeKit> componentes;
	
	public Kit(String nombre, String color, Proveedor marca, String familia, String codigo, double stock, double precio){
		super(nombre, color, marca, familia, codigo, stock, precio);
		componentes = new ArrayList<ComponenteDeKit>();
	}
	
	public void añadirComponente(Producto producto, double cantidad){
		ComponenteDeKit componente = new ComponenteDeKit(producto, cantidad);
		componentes.add(componente);
	}
	
	public boolean hayStockSuficiente (double demanda) {return true;}
	public void descontarStock (double stockSaliente) {}
}