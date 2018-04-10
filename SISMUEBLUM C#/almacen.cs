public class Almacen {

	private string direccion;
	private int telefono;
	private List<Productos> listaStockProd;
	private List<int>  listaStockProdInt;

	public Almacen(){
		listaStockProd = new ArrayList<Productos>();		
		listaStockProdInt = new ArrayList<int>();
	}

	public string Direccion{
		get{
			return _direccion;
		}
		set{
			_direccion = value;
		}
	}
	
	public int Telefono{
		get{
			return _telefono;
		}
		set{
			_telefono = value;
		}
	}
	
	

}