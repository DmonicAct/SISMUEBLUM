import java.util.*;
public class Kit extends Producto{
	private List<ComponenteDeKit> componentes;
	
	public Kit(String nombre, String color, Proveedor marca, String familia, String codigo, double precio){
		super(nombre, color, marca, familia, codigo, precio);
		componentes = new ArrayList<ComponenteDeKit>();
	}
	
	public void anhadirComponente(Producto producto, double cantidad){
		ComponenteDeKit componente = new ComponenteDeKit(producto, cantidad);
		componentes.add(componente);
	}
}