public class Almacen extends Local{
	private List<Producto> listaStockProd;
	private List<int> listaStockCant;
	
	public Almacen(){
		listaStockProd = new ArrayList<Producto>();
		listaStockCant = new ArrayList<Catn>();
	}
	
	public void mostrarAlmacen(){
	}
	
	public void registrarProducto(Producto p, int cant){
	}
	
	public void sacarProductos(Producto p, int cant){
	}
	
	public void enviarAExhibicion(List<Producto> p, List<int> c){
	}
}
