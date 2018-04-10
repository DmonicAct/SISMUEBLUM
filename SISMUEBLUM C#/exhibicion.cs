public class Exhibicion {

	private string direccion;
	private string distrito;
	private string ciudad;
	private string fechaIni;
	private string fechaFin;
	private Cliente cliente;
	///asignar cliente a exhibicion

	public Exhibicion(){
		
	}

	public Exhibicion(string direccion,string distrito,string ciudad,string fechaIni,string fechaFin, Cliente cliente){
		this.direccion = direccion;
		this.distrito = distrito;
		this.ciudad = ciudad;
		this.fechaIni = fechaIni;
		this.fechaFin = fechaFin;
		this.cliente = cliente;
	}	

	
	public string Direccion{
		get{
			return _direccion;
		}
		set{
			_direccion = value;
		}
	}
	
	
	public string Distrito{
		get{
			return _distrito;
		}
		set{
			_distrito = value;
		}
	}
	
	public string Ciudad{
		get{
			return _ciudad;
		}
		set{
			_ciudad = value;
		}
	}
		
	
	public date FechaFin{
		get{
			return _fechaFin;
		}
		set{
			_fechaFin = value;
		}
	}
	
	
	public date FechaIni{
		get{
			return _fechaIni;
		}
		set{
			_fechaIni = value;
		}
	}
	
}