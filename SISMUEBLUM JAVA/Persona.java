import java.util.*;
public class Persona extends  Cliente implements IConsultable
{
	private String nombre;
	private String apPat;
	private String apMat;
	private String dni;
	
	public Persona(){
		
	}
	public Persona(String nombre, String apPat,String apMat, String dni, String telefono, String correo, String direccion)             
	{
		super(telefono, correo, direccion);
		this.nombre = nombre;
		this.apMat = apMat;
		this.apPat = apPat;
		this.dni = dni;
	}


	public String getNombre (){
		return nombre; 
	}
	public void setNombre(String value){
		nombre = value; 
	}
	public String getApPat() { 
		return  apPat; 
	}
	public void setApPat (String value){
		apPat = value; 
	}
	public String getApMat() { 
		return apMat;
	}
	public void setApMat (String value){
		apMat = value; 
	}
	public String getDni() { 
		return dni;
	}
	public void setDni (String value){ 
		dni = value; 
	}

	public String consultarDatos()
	{
		return "";
	}

}

