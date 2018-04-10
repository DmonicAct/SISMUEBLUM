public class Proovedor {
	private int idProveedor;
	private string nombre;
	private string direccion; //metodo
	private List<Producto> listProd;
	private string pais;
	private string telefono;


	public Proovedor(){
		listProd = new List<Producto>;
	}
	
	public Proovedor(int idEnt, string nomEnt, string direccion, string paisEnt, string tlfEnt){
		listProd = new List<Producto>;
		this.idProveedor = idEnt;
		this.direccion = direccion;
		this.nombre = nomEnt;
		this.pais = paisEnt
		this.telefono = tlfEnt;
	}
	
	public int IdProveedor{
		get{
			return _idProveedor;
		}
		set{
			_idProveedor = value;
		}
	}
	
	
	public string Nombre{
		get{
			return _nombre;
		}
		set{
			_nombre = value;
		}
	}

	public string Direccion{
		get{
			return _direccion;
		}
		set{
			_direccion = value;
		}
	}	
	
	public string Pais{
		get{
			return _pais;
		}
		set{
			_pais = value;
		}
	}
		
	public string Telefono{
		get{
			return _telefono;
		}
		set{
			_telefono = value;
		}
	}
	
	public void registrarProducto(){
		
	}
	
	public void eliminarProducto(){		
		
	}
}
