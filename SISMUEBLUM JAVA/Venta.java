import java.util.Date;
import java.util.*;
public class Venta{
	private int id;
	private Date fechaCompra;
	private Cliente comprador;
	private TipoDocDeVenta tipoDoc;
	private List<DetalleVenta> cantPorProducto;
	private double subTotal;
	private double total;
	private Vendedor vendedor;
	private Date fechaEntrega;
	private String direccionDeDespacho;
	private TipoGradoSatisfaccion satisfaccion;
	
	public Venta(int id, Date fecha, Cliente comprador, TipoDocDeVenta tipoDoc, double subTotal, double total, Vendedor vendedor, Date fechaEntrega) {
		this.id = id;
		this.fechaCompra = fechaCompra;
		this.comprador = comprador;
		this.tipoDoc = tipoDoc;
		this.subTotal = subTotal;
		this.total = total;
		this.vendedor = vendedor;
		this.fechaEntrega = fechaEntrega;
		cantPorProducto = new ArrayList<DetalleVenta>();
	}
	
	public Venta(int id, Date fecha, Cliente comprador, TipoDocDeVenta tipoDoc, double subTotal, double total, Vendedor vendedor, Date fechaEntrega, String direccionDeDespacho) {
		this.id = id;
		this.fechaCompra = fechaCompra;
		this.comprador = comprador;
		this.tipoDoc = tipoDoc;
		this.subTotal = subTotal;
		this.total = total;
		this.vendedor = vendedor;
		this.fechaEntrega = fechaEntrega;
		this.direccionDeDespacho = direccionDeDespacho;
		cantPorProducto = new ArrayList<DetalleVenta>();
	}
	
	public int getId () {return this.id;}
	public void setId(int valor) {this.id = valor;}
	public Date getFechaCompra () {return this.fechaCompra;}
	public void setFechaCompra (Date valor) {this.fechaCompra = valor;}
	public Cliente getCliente () {return this.comprador;}
	public void setCliente(Cliente valor) {this.comprador = valor;}
	public TipoDocDeVenta getTipoDoc () {return this.tipoDoc;}
	public void setTipoDoc(TipoDocDeVenta valor) {this.tipoDoc = valor;}
	public double getSubTotal () {return this.subTotal;}
	public void setSubTotal(double valor) {this.subTotal = valor;}
	public double getTotal () {return this.total;}
	public void setTotal(double valor) {this.total = valor;}
	public Vendedor getVendedor () {return this.vendedor;}
	public void setVendedor (Vendedor valor) {this.vendedor = valor;}
	public Date getFechaEntrega () {return this.fechaEntrega;}
	public void setFechaEntrega (Date valor) {this.fechaEntrega = valor;}
	public String getDireccionDeDespacho () {return this.direccionDeDespacho;}
	public void setDireccionDeDespacho (String valor) {this.direccionDeDespacho = valor;}
	public TipoGradoSatisfaccion getSatisfaccion () {return this.satisfaccion;}
	public void setSatisfaccion(TipoGradoSatisfaccion valor){this.satisfaccion = valor;}
	
	public void añadirProducto(Producto producto, double cantidad, double descuento){
		DetalleVenta item;
		if (descuento>0) item = new DetalleVenta(producto, cantidad, descuento);
		else item = new DetalleVenta(producto, cantidad);
		
		cantPorProducto.add(item);
	}
	
	public String consultarVenta(){return "";}
}