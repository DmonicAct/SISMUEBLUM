public class DetalleVenta{
	private Producto producto;
	private double cantidad;
	private double porcentajeDescuento;
	
	public DetalleVenta(Producto producto, double cantidad){
		this.producto = producto;
		this.cantidad = cantidad;
	}
	
	public DetalleVenta(Producto producto, double cantidad, double porcentajeDescuento){
		this.producto = producto;
		this.cantidad = cantidad;
		this.porcentajeDescuento = porcentajeDescuento;
	}
	
	public Producto getProducto () {return this.producto;}
	public void setProducto (Producto valor) {this.producto = valor;}
	public double getCantidad () {return this.cantidad;}
	public void setCantidad (double valor) {this.cantidad = valor;}
	public double getPorcentajeDescuento () {return this.porcentajeDescuento;}
	public void setPorcentajeDescuento (double valor) {this.porcentajeDescuento = valor;}
}