using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Proveedor {
	private int idProveedor;
	private string nombre;
	private string direccion; //metodo
	private List<Producto> listProd;
	private string pais;
	private string telefono;


	public Proveedor(){
		listProd = new List<Producto>();
	}
	
	public Proveedor(int idEnt, string nomEnt, string direccion, string paisEnt, string tlfEnt){
		listProd = new List<Producto>();
		this.idProveedor = idEnt;
		this.direccion = direccion;
		this.nombre = nomEnt;
		this.pais = paisEnt;
		this.telefono = tlfEnt;
	}
	
	~Proveedor(){
	}
	
	public int IdProveedor{
		get{
			return idProveedor;
		}
		set{
			idProveedor = value;
		}
	}
	
	
	public string Nombre{
		get{
			return nombre;
		}
		set{
			nombre = value;
		}
	}

	public string Direccion{
		get{
			return direccion;
		}
		set{
			direccion = value;
		}
	}	
	
	public string Pais{
		get{
			return pais;
		}
		set{
			pais = value;
		}
	}
		
	public string Telefono{
		get{
			return telefono;
		}
		set{
			telefono = value;
		}
	}
	
	public void registrarProducto(){
		
	}
	
	public void eliminarProducto(){		
		
	}
}
