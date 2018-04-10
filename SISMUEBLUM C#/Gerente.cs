using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    class Gerente : Usuario
    {

        public Gerente(string nombre, string apellidoPaterno, string apellidoMaterno, string dni, string username, string password, 
            bool prioridad) : base(nombre, apellidoPaterno, apellidoMaterno, dni, username, password, prioridad)
        {
        }

        public void consultarVendedoresSede(string sede)
        {

        }
       
        public void asignarVendedorSede(Vendedor v,string sede)
        {

        }
    }
}
