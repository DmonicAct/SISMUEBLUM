using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Cliente
{
	private int codigoCliente;
	private string telefono;
	private string correo;
	private string direccion;
	private DateTime fechaDeRegistro;
	private List<Venta> ventas;
	private Vendedor vendedor;

	public Cliente() {
		
	}
	public Cliente(string telefono, string correo, string direccion,Vendedor v)
	{
		this.vendedor = v
		this.telefono = telefono;
		this.correo = correo;
		this.direccion = direccion;
		this.fechaDeRegistro = DateTime.Today;
		ventas = new List<Venta>();
	}
	public Vendedor getVendedor(){
		return this.vendedor;
	}
	public void setVendedor(Vendedor value){
		this.vendedor = value;
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

	}
	
}

