using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Usuario
{
	private int codigoUsuario;
	private string apellidoPaterno;
	private string apellidoMaterno;
	private string nombre;
	private string correo;
	private string dni;
	private DateTime  fechaDeRegistro;
	private bool activo;

	private string username;    
	private string password;
	private int prioridad; // 1 para vendedor y 0 para gerente

	public Usuario(string nombre, string apellidoPaterno,string apellidoMaterno, string dni, string username,string password,int prioridad)
	{
		this.nombre = nombre;
		this.fechaDeRegistro = DateTime.Today;
		this.apellidoPaterno = apellidoPaterno ;
		this.apellidoMaterno = apellidoMaterno;
		this.dni = dni;
		this.username = username;
		this.password = password;
		this.prioridad = prioridad;
		this.activo = true;
		
	}

	public string getDni() { 
		return dni; 
	}
	public void setDni (string value){
		dni = value; 
	}
	public int getCodigoUsuario(){ 
		return codigoUsuario; 
	}
	public void setCodigoUsuario (int value){
		codigoUsuario = value; 
	}
	public string getApellidoPaterno() { 
		return apellidoPaterno; 
	}
	public void setApellidoPaterno (string value){
		apellidoPaterno = value; 
	}
	public string getApellidoMaterno(){ 
		return apellidoMaterno; 
	}
	public void setApellidoMaterno (string value){
		apellidoMaterno = value; 
	}
	public string getNombre() { 
		return nombre; 
	}
	public void setNombre (string value){
		nombre = value; 
	}
	public string getCorreo(){ 
		return correo; 
	}
	public void setCorreo (string value){
		correo = value; 
	}
}


