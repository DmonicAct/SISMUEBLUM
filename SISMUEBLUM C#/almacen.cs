public class almacen {

	private string direccion;
	private int telefono;
	private List<productos> listaStockProd;

	public almacen(){
		listaStockProd = new ArrayList<productos>();
		
	}

	public void setDireccion(string direccion){
		this.direccion = direccion;
	}

	public string getDireccion(){
		return this.direccion;
	}

	public void setTelefono(string telefono){
		this.telefono = telefono;
	}

	public string getTelefono(){
		return this.telefono;
	}


}