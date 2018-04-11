import java.util.*;

public class SisMueblum {
	private static final int ruc = 20523959761;
	private static final String direccion = "Av. Republica de Panamá 6144";
	private Almacen almacen;
	private List<Vendedor> vendedores;
	private List<Gerente> gerentes;
	private List<Local> locales;
	private List<Cliente> clientes;
	private List<Proveedor> proveedores;
	
	public SisMueblum(Almacen almacen){
		this.almacen = almacen;
		vendedores = new ArrayList<Vendedor>();
		gerentes = new ArrayList<Vendedor>();
		locales = new ArrayList<Vendedor>();
		clientes = new ArrayList<Vendedor>();
		proveedores = new ArrayList<Vendedor>();
	}
	
	public Almacen getAlmacen () {return this.almacen;}
	public void setAlmacen (Almacen valor) {this.almacen = valor;}
	
	public void anhadirUsuario(Usuario valor){ 
		if (valor instanceof Vendedor) {vendedores.add(valor);}
		if (valor instanceof Gerente) {gerentes.add(valor);}
	}
	public void anhadirLocal(Local valor){ locales.add(valor); }
	public void anhadirCliente(Cliente valor){ clientes.add(valor); }
	public void anhadirProveedor(Proveedor valor){ proveedores.add(valor); }
	
}