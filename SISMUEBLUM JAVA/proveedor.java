public class proveedor {
	private int idProveedor;
	private String nombre;
	private String direccion;
	private productos prod;
	private String pais;
	private String telefono
	
	public proveedor(){
		
	}
	
	public proveedor(int idEnt, String nomEnt, productos p, String paisEnt, String tlfEnt){
		this.idProveedor = idEnt;
		this.nombre = nomEnt;
		this.prod = p;
		this.pais = paisEnt;
		this.telefono = tlfEnt;
	}
	
	public int getIdProveedor(){
		return idProovedor;
	}
	
	public void setIdProveedor(int idEnt){
		this.idProovedor = idEnt;
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
}