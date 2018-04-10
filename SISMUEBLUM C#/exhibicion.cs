using System;
public class Exhibicion : Local {
	
	private DiaSemana diaIni;
	private DiaSemana diaFin;
	private TimeSpan  horaIni;
	private TimeSpan  horaFin;
	private List<Producto> listProductos;
	private List<int> listCantidad;
	
	
	//private Cliente cliente;
	///asignar cliente a exhibicion

	public Exhibicion(){
		listProductos = new List<Producto>();
		listCantidad = new List<int>();
	}
	//TimeSpan timeSpan = new TimeSpan(2, 14, 18);
	public Exhibicion(DateTime diaIni,DateTime diaFin,int horaIni, int horaFin/*Cliente cliente*/){		
		this.diaIni = diaIni;
		this.diaFin = diaFin;		
		this.horaIni = new TimeSpan(horaIni);
		this.horaFin = new TimeSpan(horaFin);		
		listProductos = new List<Producto>();
		listCantidad = new List<int>();
	}	

	
	
	public DiaSemana diaIni{
		get{
			return _diaIni;
		}
		set{
			_diaIni = value;
		}
	}
		
	public DiaSemana diaFin{
		get{
			return _diaFin;
		}
		set{
			_diaFin = value;
		}
	}
	
	public TimeSpan horaFin{
		get{
			return _horaFin;
		}
		set{
			_horaFin = value;
		}
	}
		
	public TimeSpan horaIni{
		get{
			return _horaIni;
		}
		set{
			_horaIni = value;
		}
	}		
	
	public void agregarProducto(Producto p,int cant){
	
	}
	
	
	public producto devolverProducto(Producto p , int cant){
	
	}	
	
	public void devolverAlmacen(listProductos listP, listProd listaCant ){
	}
	
	
	public void mostrarProducto(){
	
	}
	
	
}	

