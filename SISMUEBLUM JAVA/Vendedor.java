import java.util.*;
public class Vendedor extends Usuario implements IConsultable
{
	private int meta;
	private String sexo;
	private double eficiencia;
	private ArrayList<Cliente> listacli;
	private String informacion;
	private String seguro;
	private String domicilio;
	private ArrayList<String> telefonos;
	private int horasMensuales;
	private int horasCumplidasMensuales;
	private ArrayList<Venta> ventas;
	
	public Vendedor(){
		
	}
	public Vendedor(String nombre, String apellidoPaterno, String apellidoMaterno, String dni, String username, String password, 
		 String sexo, String seguro,String domicilio,String informacion){
		super(nombre, apellidoPaterno, apellidoMaterno, dni, username, password, 1);
		this.sexo = sexo;
		this.seguro = seguro;
		this.informacion = informacion;
		this.domicilio = domicilio;
		listacli=new ArrayList<Cliente>();
		telefonos=new ArrayList<String>();
		ventas=new ArrayList<Venta>();
	}

	public int getMeta() { 
		return meta; 
	}
	public void setMeta (int value){
		meta = value; 
	}
	public String getSexo() { 
		return sexo; 
	}
	public void setSexo (String value){
		sexo = value; 
	}	
	public double getEficiencia() {
		return eficiencia; 
	}
	public void setEficiencia(double value) { 
		eficiencia = value; 
	}
	public String getInformacion() {
		return informacion; 
	}
		public void setInformacion(String value) { 
		informacion = value; 
	}
	public String getSeguro (){
		return seguro; 
	}
	public void setSeguro (String value){ 
		seguro = value; 
	}
	public String getDomicilio (){
		return domicilio; 
	}
	public void setDomicilio (String value){
		domicilio = value; 
	}
	public int getHorasMensuales (){
		return horasMensuales; 
	}
	public void setHorasMensuales(int value){
		horasMensuales = value; 
	}	
	public int getHorasCumplidasMensuales (){
		return horasCumplidasMensuales; 
	}
	public void setHorasCumplidasMensuales (int value){
		horasCumplidasMensuales = value; 
	}
	
	public String consultarDatos()
	{
		return "";
	}

	public void registrarCliente()
	{

	}
}
