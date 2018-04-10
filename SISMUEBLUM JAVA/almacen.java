public class almacen {
	private String direccion;
	private List<productos> listaSttockProd;
	//Lista FechasProducos (Pedidos);
	//Lista StockProductos ;
	private int telefono;
	
	public almacen(){
		listaSttockProd = new ArrayList<productos>();
	}
	
	public String getDireccion(){
		return direccion;
	}
	
	public void setDireccion(String dirEnt){
		this.direccion = dirEnt;
	}
	
	public String getTelefono(){
		return telefono;
	}
	
	public void setTelefono(String tlfEnt){
		this.telefono = tlfEnt;
	}	
}