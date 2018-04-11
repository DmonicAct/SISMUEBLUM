using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Empresa : Cliente,IConsultable
{
	private string ruc;
	private string razon;
	private string representante;

	public Empresa(){
		
	}
	public Empresa(string ruc, string razon, string representante,string telefono, string correo, string direccion) : base(telefono, correo, direccion)
	{
		this.ruc = ruc;
		this.razon = razon;
		this.representante = representante;
	}
	public string getRepresentante() { 
	return  representante; 
	}
	public void setRepresentante (string value){
		representante = value; 
		}
	public string getRuc() { 
		return ruc; 
	}
	public void setRuc (string value){
		ruc = value; 
	}
	public string getRazon() { 
		return razon;
	}
	public void setRazon(string value){
		 razon = value; 
	}

	public string consultarDatos()
	{
		throw new NotImplementedException();
	}
}


