using System;
public class Producto{
	private string _nombre;
	private string _color;
	private Proveedor _marca;
	private string _familia;
	private string _codigo;
	private double _precio;
	
	public Producto(string nombre, string color, Proveedor marca, string familia, string codigo, double precio){
		this._nombre = nombre;
		this._color = color;
		this._familia = familia;
		this._codigo = codigo;
		this._marca = marca;
		this._precio = precio;
	}
	
	~Producto(){}
	
	public string nombre{get{return this._nombre;} set{this._nombre = value;}}
	public string color{get{return this._color;} set{this._color = value;}}
	public Proveedor marca{get{return this._marca;} set{this._marca = value;}}
	public string familia{get{return this._familia;} set{this._familia = value;}}
	public string codigo{get{return this._codigo;} set{this._codigo = value;}}
	public double precio{get{return this._precio;} set{this._precio = value;}}
}