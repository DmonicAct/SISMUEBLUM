using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Exhibicion : Local {
	
	private DiaSemana diaIni;
	private DiaSemana diaFin;
	private TimeSpan  horaIni;
	private TimeSpan  horaFin;
	private List<Producto> listProductos;
	private List<double> listCantidad;
	
	//private Cliente cliente;
	///asignar cliente a exhibicion

	public Exhibicion(){
		listProductos = new List<Producto>();
		listCantidad = new List<double>();
	}
	//TimeSpan timeSpan = new TimeSpan(2, 14, 18);
	public Exhibicion(DiaSemana diaIni,DiaSemana diaFin,int horaIni, int horaFin/*Cliente cliente*/){		
		this.diaIni = diaIni;
		this.diaFin = diaFin;		
		this.horaIni = new TimeSpan(horaIni);
		this.horaFin = new TimeSpan(horaFin);		
		listProductos = new List<Producto>();
		listCantidad = new List<double>();
	}	

	~Exhibicion(){
	}
	
	public DiaSemana _diaIni{
		get{
			return _diaIni;
		}
		set{
			_diaIni = value;
		}
	}
		
	public DiaSemana _diaFin{
		get{
			return _diaFin;
		}
		set{
			_diaFin = value;
		}
	}
	
	public TimeSpan _horaFin{
		get{
			return _horaFin;
		}
		set{
			_horaFin = value;
		}
	}
		
	public TimeSpan _horaIni{
		get{
			return _horaIni;
		}
		set{
			_horaIni = value;
		}
	}		
	
	public void agregarProducto(Producto p,double cant){
	
	}
	
	public void devolverProducto(Producto p , double cant){
	
	}	
	
	public void devolverAlmacen(List<Producto> listP, List<double> listaCant ){
	}
	
	
	public void mostrarProducto(){
	
	}
	
	
}	

