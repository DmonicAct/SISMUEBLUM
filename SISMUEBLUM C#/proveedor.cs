public class Proveedor {
	private int idProveedor;
	private string nombre;
	private string direccion; //metodo
	private productos prod;
	private string pais;
	private string telefono;


	public Proveedor(){
		
	}
	
	public Proveedor(int idEnt, string nomEnt, productos p, string paisEnt, string tlfEnt){
		this.idProveedor = idEnt;
		this.nombre = nomEnt;
		this.prod = p;
		this.pais = paisEnt
		this.telefono = tlfEnt;
	}
	
	public void setProveedor(idEnt){
		idProveedor = idEnt;
	}

	public int getProveedor(){
		return this.idProveedor;
	}
	
	public void setNombre(string nomEnt){
		this.nombre = nomEnt;
	}

	public String getNombre(){
		return this.nombre;
	}

	public void setDireccion(string direccion){
		this.direccion = direccion;
	}

	public string getDireccion(){
		return this.direccion;
	}
	
	public void setPais(string paisEnt){
		this.pais = paisEnt;
	}

	public string getPais(){
		return this.pais;
	}

	public void setTelefono(string telefono){
		this.telefono = telefono;
	}

	public string getTelefono(){
		return this.telefono;
	}
	
	
	
}