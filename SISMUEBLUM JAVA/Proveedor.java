import java.util.*;

public class Proveedor {
	private int idProveedor;
	private String nombre;
	private String direccion;
	private List<Producto> listProd;
	private String pais;
	private String telefono;
	
	public Proveedor(){
		listProd = new ArrayList<Producto>();
	}
	
	public Proveedor(int idEnt, String nomEnt, String dirEnt, String paisEnt, String tlfEnt){
		listProd = new ArrayList<Producto>();
		this.idProveedor = idEnt;
		this.nombre = nomEnt;
		this.direccion = dirEnt;
		this.pais = paisEnt;
		this.telefono = tlfEnt;
	}
	
	public int getIdProveedor(){
		return idProveedor;
	}
	
	public void setIdProveedor(int idEnt){
		this.idProveedor = idEnt;
	}
	
	public String getNombre(){
		return nombre;
	}
	
	public void setNombre(String nomEnt){
		this.nombre = nomEnt;
	}

	public String getDireccion(){
		return direccion;
	}
	
	public void setDireccion(String dirEnt){
		this.direccion = dirEnt;
	}
	
	public String getPais(){
		return pais;
	}
	
	public void setPais(String paisEnt){
		this.pais = paisEnt;
	}
	
	public String getTelefono(){
		return telefono;
	}
	
	public void setTelefono(String tlfEnt){
		this.telefono = tlfEnt;
	}	
	
	public void registrarProducto(Producto p){
	}	
	
	public void eliminarProducto(Producto p){
	}
}
