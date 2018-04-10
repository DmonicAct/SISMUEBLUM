import java.time.LocalTime;

public class Exhibicion extends Local {
	private DiaSemana diaIni;
	private DiaSemana diaFin;
	private LocalTime horaIni;
	private LocalTime horaFin;
	private List<Producto> listProductos;
	private List<int> listCantidad; 
	//private Cliente cli;
	
	public Exhibicion(){
		listProductos = new ArrayList<Producto>();
		listCantidad = new ArrayList<int>();
	}
	
	public Exhibicion(DiaSemana dIni, DiaSemana dFin, int hIni, int hFin/*, Cliente c*/){
		listProductos = new ArrayList<Producto>();
		listCantidad = new ArrayList<int>();
		this.diaIni = dIni;
		this.diaFin = dFin;
		this.horaIni = LocalTime.of(hIni);
		this.horaFin = LocalTime.of(hFin);
	}
	
	public DiaSemana getDiaIni(){
		return diaIni;
	}
	
	public void setDiaIni(DiaSemana dIni){
		this.diaIni = dIni;
	}
	
	public DiaSemana getDiaFin(){
		return diaFin;
	}
	
	public void setDiaFin(DiaSemana dFin){
		this.diaFin = dFin;
	}	
	
	public LocalTime getHoraIni(){
		return horaIni;
	}
	
	public void setHoraIni(int hIni){
		this.horaIni = LocalTime.of(hIni);
	}
	
	public LocalTime getHoraFin(){
		return horaFin;
	}
	
	public void setHoraFin(int hFin){
		this.horaFin = LocalTime.of(hFin);
	}
	
	public void agregarProducto(Producto p, int cant){
	}
	
	public void devolverProducto(Producto p, int cant){
	}
	
	public void devolverAlmacen(List<Producto> listP, List<int> listC){
	}	
	
	public void mostrarProductos(){
	}
}
