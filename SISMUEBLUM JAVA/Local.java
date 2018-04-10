import java.util.*;
public class Local{
	private int local_id;
	private String local_direccion;
	private int local_telef;
	private ArrayList<Vendedor> local_vendedores;

	public Local(int local_id, string local_direccion, int local_telef){
		this.local_id = local_id;
		this.local_direccion = local_direccion;
        	this.local_telef = local_telef;
		local_vendedores = new List<Vendedor>();
		
	}
	
	public Local(){
		local_vendedores = new List<Vendedor>();
	}
	
	public Local(){
		local_vendedores = new ArrayList<Vendedor>();
	}

	public int getLocal_id(){
		return local_id;
	}
	
	public void setLocal_id(int local_id){
		this.local_id = local_id;
	}
	
	public String getLocal_direccion(){
		return local_direccion;
	}
	
	public void setLocal_direccion(String local_direccion){
		this.local_direccion = local_direccion;
	}

	public List<Vendedor> getLocal_vendedores(){
		return local_vendedores;
	}
	
	public void setLocal_vendedores(List<Vendedor> local_vendedores)
		this.local_vendedores = local_vendedores;
	}
	
	public int getLocal_telef(){
		return local_telef;
	}
	
	public void setLocal_telef(int local_telef){
		this.local_telef = local_telef;
	}


	public void agregarVendedor(Vendedor v){
		local_vendedores.Add(v);
	}

	public String consultarVendedores(){
	}

}
