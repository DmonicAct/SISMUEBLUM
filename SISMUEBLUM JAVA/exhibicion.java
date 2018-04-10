public class exhibicion {
	private String direccion;
	private String distrito;
	private String ciudad;
	private String fechaIni;
	private String fechaFin;
	private Cliente cli;
	
	//asignar cliente a exhibicion
	
	public exhibicion(){
		
	}
	
	public exhibicion(String dirEnt, String disEnt, String ciuEnt, String fIni, String fFin, Cliente c){
		this.direccion = dirEnt;
		this.distrito = disEnt;
		this.ciudad = ciuEnt;
		this.fechaIni = fIni;
		this.fechaFin = fFin;
		this.cli = c;
	}
	
	public String getDireccion(){
		return direccion;
	}
	
	public void setDireccion(String dirEnt){
		this.direccion = dirEnt;
	}
	
	public String getDistrito(){
		return distrito;
	}
	
	public void setDistrito(String disEnt){
		this.distrito = disEnt;
	}
	
	public String getCiudad(){
		return ciudad;
	}
	
	public void setCiudad(String ciuEnt){
		this.ciudad = ciuEnt;
	}
	
	public String getFechaIni(){
		return fechaIni;
	}
	
	public void setFechaIni(String fIni){
		this.fechaIni = fFin;
	}
	
	public String getFechaFin(){
		return fechaFin;
	}
	
	public void setFechaFin(String fFin){
		this.fechaFin = fFin;
	}
}
