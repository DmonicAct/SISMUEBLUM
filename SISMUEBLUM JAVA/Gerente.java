import java.util.*;
class Gerente extends Usuario implements IConsultable
{
	
	public Gerente(){
		
	}
	public Gerente(String nombre, String apellidoPaterno, String apellidoMaterno, String dni, String username, String password)
		
	{
		super(nombre, apellidoPaterno, apellidoMaterno, dni, username, password, 0);
	}

	public void consultarVendedoresSede(String sede)
	{

	}
   
	public void asignarVendedorSede(String dniVend,String sede)
	{

	}
	
	public void moverReasignarCliente(String dniVend, String dniCli)
	{

	}

	public void emitirReporteVendedor(String dniVend)
	{

	}

	public void registrarVendedor(String nombre, String apellidoPaterno, String apellidoMaterno, 
		String dni, String username, String password,
		String sexo, String seguro, String domicilio, String informacion)
	{
		Vendedor v;
		v = new Vendedor(nombre, apellidoPaterno, apellidoMaterno, dni, username, password,
			sexo,  seguro, domicilio, informacion);
	}

	public void eliminarVendedor(String dniVend)
	{

	}
	public void revisarCliente(String dni)
	{

	}

	public String consultarDatos()
	{
		return "";
	}
}

