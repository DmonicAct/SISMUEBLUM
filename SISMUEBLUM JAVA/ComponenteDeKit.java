public class ComponenteDeKit{
	private Producto producto;
	private double cantidad;
	
	public ComponenteDeKit(Producto producto, double cantidad){
		this.producto = producto;
		this.cantidad = cantidad;
	}
	
	public Producto getProducto () {return this.producto;}
	public void setProducto (Producto valor) {this.producto = valor;}
	public double getCantidad () {return this.cantidad;}
	public void setCantidad (double valor) {this.cantidad = valor;}
}