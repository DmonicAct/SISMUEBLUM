using System;
public class ComponenteDeKit{
	private Producto _producto;
	private double _cantidad;
	
	public ComponenteDeKit(Producto producto, double cantidad){
		this._producto = producto;
		this._cantidad = cantidad;
	}
	
	public Producto producto{get{return this._producto;} set{this._producto = value;}}
	public double cantidad{get{return this._cantidad;} set{this._cantidad = value;}}
	
	~ComponenteDeKit(){}
	
}