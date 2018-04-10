using System;
public class DetalleVenta{
	private Producto _producto;
	private double _cantidad;
	private double _porcentajeDescuento;
	
	public DetalleVenta(Producto producto, double cantidad){
		this._producto = producto;
		this._cantidad = cantidad;
	}
	
	public DetalleVenta(Producto producto, double cantidad, double porcentajeDescuento){
		this._producto = producto;
		this._cantidad = cantidad;
		this._porcentajeDescuento = porcentajeDescuento;
	}
	
	public Producto producto{get{return this._producto;} set{this._producto = value;}}
	public double cantidad{get{return this._cantidad;} set{this._cantidad = value;}}
	public double porcentajeDescuento{get{return this._porcentajeDescuento;} set{this._porcentajeDescuento = value;}}
	
	~DetalleVenta(){}
	
}