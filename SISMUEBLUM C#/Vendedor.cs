using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Vendedor : Usuario,IConsultable
{
	private int meta;
	private string sexo;
	private double eficiencia;
	private List<Cliente> listacli;
	private string informacion;
	private string seguro;
	private string domicilio;
	private List<string> telefonos;
	private int horasMensuales;
	private int horasCumplidasMensuales;
	private List<Venta> ventas;

	public Vendedor(string nombre, string apellidoPaterno, string apellidoMaterno, string dni, string username, string password, 
		 string sexo,string seguro,string domicilio,string informacion) :
		base(nombre, apellidoPaterno, apellidoMaterno, dni, username, password, 1){
		this.sexo = sexo;
		this.seguro = seguro;
		this.informacion = informacion;
		this.domicilio = domicilio;
		this.listacli=new List<Cliente>();
		this.telefonos=new List<string>();
		this.ventas=new List<Venta>();
	}

	public int getMeta() { 
		return meta; 
	}
	public void setMeta (int value){
		meta = value; 
	}
	public string getSexo() { 
		return sexo; 
	}
	public void setSexo (string value){
		sexo = value; 
	}	
	public double getEficiencia() {
		return eficiencia; 
	}
	public void setEficiencia(double value) { 
		eficiencia = value; 
	}
	public string getInformacion() {
		return informacion; 
	}
	public void setInformacion(string value) { 
		informacion = value; 
	}
	public string getSeguro (){
		return seguro; 
	}
	public void setSeguro (string value){ 
		seguro = value; 
	}
	public string getDomicilio (){
		return domicilio; 
	}
	public void setDomicilio (string value){
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
	public string consultarDatos()
	{
		throw new NotImplementedException();
	}

	public void registrarCliente()
	{

	}
}

