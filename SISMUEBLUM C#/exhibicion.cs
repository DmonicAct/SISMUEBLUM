public class Exhibicion {
	
	private DiaSemana diaIni;
	private DiaSemana diaFin;
	private string horaIni;
	private string horaFin;
	//private Cliente cliente;
	///asignar cliente a exhibicion

	public Exhibicion(){
		
	}

	public Exhibicion(DateTime diaIni,DateTime diaFin,string horaIni, string horaFin/*, Cliente cliente*/){		
		this.diaIni = diaIni;
		this.diaFin = diaFin;
		
		this.horaIni = horaIni;
		this.horaFin = horaFin;
		
	}	

	
	
	public date diaIni{
		get{
			return _diaIni;
		}
		set{
			_diaIni = value;
		}
	}
		
	public date diaFin{
		get{
			return _diaFin;
		}
		set{
			_diaFin = value;
		}
	}
	
	public date horaFin{
		get{
			return _horaFin;
		}
		set{
			_horaFin = value;
		}
	}
		
	public date horaIni{
		get{
			return _horaIni;
		}
		set{
			_horaIni = value;
		}
	}
	
	
	
}
