using System;
public class Local{
	private int _id;
	private string _direccion;
	private int _telef;
	private List<Vendedor> _vendedores;

	public Local(int _id, string _direccion, int _telef){
		this._id = _id;
		this._direccion = _direccion;
        	this._telef = _telef;
		_vendedores = new List<Vendedor>();
		
	}
	
	public Local(){
		_vendedores = new List<Vendedor>();
	}
	
	~Local(){
	}

	public int local_id{
		set{
			this._id = value;
		}
		get{
			return _id;
		}
	}

	public string local_direccion{
		set{
			this._direccion = value;
		}
		get{
			return _direccion;
		}
	}
	
	public int local_telef{
		set{
			this._telef = value;
		}
		get{
			return _telef;
		}
	}

	public List<Vendedor> local_vendedores{
		set{
			this._vendedores = value;
		}
		get{
			return _vendedores;
		}
	}

	public void agregarVendedor(Vendedor v){
		_vendedores.Add(v);
	}

	public string consultarVendedores(){
    		string cadena = "";
		return cadena;
	}

}
