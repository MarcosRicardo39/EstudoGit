using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudoGit.Model;

namespace EstudoGit.Services
{
    public class ClientesServices
    {
        public List<Cliente> ListaClientes { get; set; }

        public ClientesServices(List<Cliente> lista)
        {
            ListaClientes = lista;
        }

        public void RetornarLista()
        {
            foreach (Cliente cliente in ListaClientes)
            {
                if (cliente.Idade > 17)
                {
                    Console.WriteLine($"{cliente.Nome}: Maior de idade.");
                }
                else
                {
                    Console.WriteLine($"{cliente.Nome}: Menor de idade.");
                }
            }
        }
    }
}



    

