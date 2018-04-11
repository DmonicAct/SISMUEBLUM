using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SisMueblum {
	private const int ruc = 20523959761;
	private const string direccion = "Av. Republica de Panamá 6144";
	private Almacen _almacen;
	private List<Vendedor> vendedores;
	private List<Gerente> gerentes;
	private List<Local> locales;
	private List<Cliente> clientes;
	private List<Proveedor> proveedores;
	
	public SisMueblum(Almacen almacen){
		this.almacen = almacen;
		vendedores = new List<Vendedor>();
		gerentes = new List<Vendedor>();
		locales = new List<Vendedor>();
		clientes = new List<Vendedor>();
		proveedores = new List<Vendedor>();
	}
	
	public Almacen almacen{get{return this._almacen;} set{this._almacen = value;}}
	
	public void anhadirUsuario(Usuario valor){ 
		if (valor is Vendedor) {vendedores.Add(valor);}
		if (valor is Gerente) {gerentes.Add(valor);}
	}
	public void anhadirLocal(Local valor){ locales.Add(valor); }
	public void anhadirCliente(Cliente valor){ clientes.Add(valor); }
	public void anhadirProveedor(Proveedor valor){ proveedores.Add(valor); }
}