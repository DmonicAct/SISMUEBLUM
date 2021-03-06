import java.util.*;
public abstract class Cliente
{
	private int codigoCliente;
	private String telefono;
	private String correo;
	private String direccion;
	private Date fechaDeRegistro;
	private ArrayList<Venta> ventas;
	private Vendedor vendedor;
	
	public Cliente() { 
		
	}
	public Cliente(String telefono, String correo, String direccion,Vendedor vendedor)
	{
		this.vendedor=vendedor;
		this.telefono = telefono;
		this.correo = correo;
		this.direccion = direccion;
		this.fechaDeRegistro = new Date();
		ventas = new ArrayList<Venta>();
	}
	public Vendedor getVendedor (){ 
		return vendedor; 
	}
	public void setVendedor(Vendedor value){
		 vendedor = value; 
	}
	public int getCodigoCliente (){ 
		return codigoCliente; 
	}
	public void setCodigoCliente(int value){
		 codigoCliente = value; 
	}
	public String getTelefono() { 
		return telefono; 
	}
	public void setTelefono(String value){
		telefono = value; 
	}
	public String getCorreo (){ 
		return correo;
	}
	public void setCorreo (String value){
		correo = value; 
	}
	public String getDireccion() { 
		return direccion; 
	}
	public void setDireccion(String value) {
		direccion = value; 
	}
	
	public void registrarVenta(Venta v)
	{
		int n;
	}
	
}

