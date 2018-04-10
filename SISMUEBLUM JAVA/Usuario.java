import java.util.*;


public abstract class Usuario
{
	private int codigoUsuario;
	private String apellidoPaterno;
	private String apellidoMaterno;
	private String nombre;
	private String correo;
	private String dni;
	private Date fechaDeRegistro;
	private boolean activo;

	private String username;    
	private String password;
	private int prioridad; // 1 para vendedor y 0 para gerente

	public Usuario(String nombre, String apellidoPaterno,String apellidoMaterno, String dni, String username,String password,int prioridad)
	{
		this.nombre = nombre;
		this.fechaDeRegistro = new Date();
		this.apellidoPaterno = apellidoPaterno ;
		this.apellidoMaterno = apellidoMaterno;
		this.dni = dni;
		this.username = username;
		this.password = password;
		this.prioridad = prioridad;
		this.activo = true;
	}

	public String getDni() { 
		return dni; 
	}
	public void setDni (String value){
		dni = value; 
	}
	public int getCodigoUsuario(){ 
		return codigoUsuario; 
	}
	public void setCodigoUsuario (int value){
		codigoUsuario = value; 
	}
	public String getApellidoPaterno() { 
		return apellidoPaterno; 
	}
	public void setApellidoPaterno (String value){
		apellidoPaterno = value; 
	}
	public String getApellidoMaterno(){ 
		return apellidoMaterno; 
	}
	public void setApellidoMaterno (String value){
		apellidoMaterno = value; 
	}
	public String getNombre() { 
		return nombre; 
	}
	public void setNombre (String value){
		nombre = value; 
	}
	public String getCorreo(){ 
		return correo; 
	}
	public void setCorreo (String value){
		correo = value; 
	}
}

