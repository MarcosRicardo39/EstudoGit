using EstudoGit.Model;
using EstudoGit.Services;
public class Program
{
    static void Main(string[] args)
    {

       

        List<Cliente> clientes = new List<Cliente>()
        {
            new Cliente("Marcos", 39),
            new Cliente("João", 15),
            new Cliente("Maria", 30)
        };

        foreach (Cliente cliente in clientes)
        {
            Console.WriteLine(cliente.Nome);
            Console.WriteLine(cliente.Idade);
        }

        ClientesServices service = new ClientesServices(clientes);

        service.RetornarLista();

        Console.WriteLine("Testando minha primeira Pull Request!");



    }


}