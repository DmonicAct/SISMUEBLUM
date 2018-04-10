public class exhibicion {

	private string direccion;
	private string distrito;
	private string ciudad;
	private string fechaIni;
	private string fechaFin;
	private Cliente cliente;
	///asignar cliente a exhibicion

	public exhibicion(){
		
	}

	public exhibicion(string direccion,string distrito,string ciudad,string fechaIni,string fechaFin/*Cliente cliente*/){
		this.direccion = direccion;
		this.distrito = distrito;
		this.ciudad = ciudad;
		this.fechaIni = fechaIni;
		this.fechaFin = fechaFin;
		//this.cliente = cliente;
	}	

	public void setDireccion(string dirEnt){
		this.direccion = dirEnt;
	}
		
	public string getDireccion(){
		return direccion;
	}
	

	public void setDistrito(string disEnt){
		this.distrito = disEnt;
	}

	public string getDistrito(){
		return distrito;
	}

	public void setCiudad(string ciuEnt){
		this.ciudad = ciuEnt;
	}		
	
	public string getCiudad(){
		return ciudad;
	}
		
	public string setFechaIni(string fechaIni){
		 this.fechaIni = fechaIni;
	}

	public String getFechaIni(){
		return fechaIni;
	}
	

	public void setFechaFin(string fechaFin){
		this.fechaFin = fechaFin;
	}
	
	public void getFechaFin(){
		return fechaFin
	}	
	
}