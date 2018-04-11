using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Persona : Cliente, IConsultable
{
	private string nombre;
	private string apPat;
	private string apMat;
	private string dni;

	public Persona(){
		
	}
	public Persona(string nombre, string apPat,string apMat, string dni, string telefono, string correo, string direccion) : 
		base(telefono, correo, direccion)
	{
		this.nombre = nombre;
		this.apMat = apMat;
		this.apPat = apPat;
		this.dni = dni;
	}


	public string getNombre (){
		return nombre; 
	}
	public void setNombre(string value){
		nombre = value; 
	}
	public string getApPat() { 
		return  apPat; 
	}
	public void setApPat (string value){
		apPat = value; 
	}
	public string getApMat() { 
		return apMat;
	}
	public void setApMat (string value){
		apMat = value; 
	}
	public string getDni() { 
		return dni;
	}
	public void setDni (string value){ 
		dni = value; 
	}

	public string consultarDatos()
	{
		throw new NotImplementedException();
	}

}

