using System;
public class Venta{
	private int _id;
	private DateTime _fechaCompra;
	private Cliente _comprador;
	private TipoDocDeVenta _tipoDoc;
	private List<DetalleVenta> _cantPorProducto;
	private double _subTotal;
	private double _total;
	private Vendedor _vendedor;
	private DateTime _fechaEntrega;
	private string _direccionDeDespacho;
	private TipoGradoSatisfaccion _satisfaccion;
	
	public Venta(int id, DateTime fecha, Cliente comprador, TipoDocDeVenta tipoDoc, double subTotal, double total, Vendedor vendedor, DateTime fechaEntrega) {
		this._id = id;
		this._fechaCompra = fechaCompra;
		this._comprador = comprador;
		this._tipoDoc = tipoDoc;
		this._subTotal = subTotal;
		this._total = total;
		this._vendedor = vendedor;
		this._fechaEntrega = fechaEntrega;
		_cantPorProducto = new List<DetalleVenta>();
	}
	
	public Venta(int id, DateTime fecha, Cliente comprador, TipoDocDeVenta tipoDoc, double subTotal, double total, Vendedor vendedor, DateTime fechaEntrega, string direccionDeDespacho) {
		this._id = id;
		this._fechaCompra = fechaCompra;
		this._comprador = comprador;
		this._tipoDoc = tipoDoc;
		this._subTotal = subTotal;
		this._total = total;
		this._vendedor = vendedor;
		this._fechaEntrega = fechaEntrega;
		this._direccionDeDespacho = direccionDeDespacho;
		_cantPorProducto = new List<DetalleVenta>();
	}
	
	~Venta(){}
	
	public int id{get{return this._id;} set{this._id = value;}}
	public DateTime fechaCompra{get{return this._fechaCompra;} set{this._fechaCompra = value;}}
	public Cliente comprador{get{return this._comprador;} set{this._comprador = value;}}
	public TipoDocDeVenta tipoDoc{get{return this._tipoDoc;} set{this._tipoDoc = value;}}
	public double subTotal{get{return this._subTotal;} set{this._subTotal = value;}}
	public double total{get{return this._total;} set{this._total = value;}}
	public Vendedor vendedor{get{return this._vendedor;} set{this._vendedor = value;}}
	public DateTime fechaEntrega{get{return this._fechaEntrega;} set{this._fechaEntrega = value;}}
	public string direccionDeDespacho{get{return this._direccionDeDespacho;} set{this._direccionDeDespacho = value;}}
	public TipoGradoSatisfaccion satisfaccion{get{return this._satisfaccion;} set{this._satisfaccion = value;}}
	
	public void añadirProducto(Producto producto, double cantidad, double descuento){
		DetalleVenta item;
		if (descuento>0) item = new DetalleVenta(producto, cantidad, descuento);
		else item = new DetalleVenta(producto, cantidad);
		
		_cantPorProducto.Add(item);
	}
	
	public string consultarVenta(){return "";}
}