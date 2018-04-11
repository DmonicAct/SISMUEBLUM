import java.time.*;
import java.util.*;

public class Exhibicion extends Local {
	private DiaSemana diaIni;
	private DiaSemana diaFin;
	private LocalTime horaIni;
	private LocalTime horaFin;
	private List<Producto> listProductos;
	private List<Double> listCantidad; 
	//private Cliente cli;
	
	public Exhibicion(){
		listProductos = new ArrayList<Producto>();
		listCantidad = new ArrayList<Double>();
	}
	
	public Exhibicion(DiaSemana dIni, DiaSemana dFin, int hIni, int mIni, int hFin, int mFin/*, Cliente c*/){
		listProductos = new ArrayList<Producto>();
		listCantidad = new ArrayList<Double>();
		this.diaIni = dIni;
		this.diaFin = dFin;
		this.horaIni = LocalTime.of(hIni,mIni);
		this.horaFin = LocalTime.of(hFin,mFin);
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
	
	public void setHoraIni(int hIni, int mIni){
		this.horaIni = LocalTime.of(hIni,mIni);
	}
	
	public LocalTime getHoraFin(){
		return horaFin;
	}
	
	public void setHoraFin(int hFin, int mFin){
		this.horaFin = LocalTime.of(hFin,mFin);
	}
	
	public void agregarProducto(Producto p, double cant){
	}
	
	public void devolverProducto(Producto p, double cant){
	}
	
	public void devolverAlmacen(List<Producto> listP, List<Double> listC){
	}	
	
	public void mostrarProductos(){
	}
}
