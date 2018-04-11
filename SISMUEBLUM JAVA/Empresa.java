import java.util.*;

public class Empresa extends Cliente implements IConsultable
{
	private String ruc;
	private String razon;
	private String representante;
	
	public Empresa(){
		
	}
	public Empresa(String ruc, String razon, String representante,String telefono, String correo, String direccion) 
	{
		super(telefono, correo, direccion);
		this.ruc = ruc;
		this.razon = razon;
		this.representante = representante;
	}

	public String getRepresentante() { 
	return  representante; 
	}
	public void setRepresentante (String value){
		representante = value; 
		}
	public String getRuc() { 
		return ruc; 
	}
	public void setRuc (String value){
		ruc = value; 
	}
	public String getRazon() { 
		return razon;
	}
	public void setRazon(String value){
		 razon = value; 
	}
	
	public String consultarDatos()
	{
		return "";
	}
}


