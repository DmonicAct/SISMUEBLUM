public class Producto{
	private String nombre;
	private String color;
	private Proveedor marca;
	private String familia;
	private String codigo;
	private double precio;
	
	public Producto(String nombre, String color, Proveedor marca, String familia, String codigo, double precio){
		this.nombre = nombre;
		this.color = color;
		this.familia = familia;
		this.codigo = codigo;
		this.marca = marca;
		this.precio = precio;
	}
	
	public String getNombre () {return this.nombre;}
	public void setNombre (String valor) {this.nombre = valor;}
	public String getColor() {return this.color;}
	public void setColor (String valor) {this.color = valor;}
	public String getFamilia () {return this.familia;}
	public void setFamilia (String valor) {this.familia = valor;}
	public String getCodigo () {return this.codigo;}
	public void setCodigo (String valor) {this.codigo = valor;}
	public Proveedor getMarca () {return this.marca;}
	public void setMarca (Proveedor valor) {this.marca = valor;}
	public double getPrecio () {return this.precio;}
	public void setPrecio (double valor) {this.precio = valor;}	
}