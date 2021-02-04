using System.Collections.Generic;
using System.Linq;

namespace Leila.Dominio
{
    public class MinhaBaseClientes
    {
        public List<Cliente> Clientes { get; set; }

        public MinhaBaseClientes()
        {
            Clientes = new List<Cliente>();
        }

        public void IncluirCliente(Cliente cliente)
        {
            Clientes.Add(cliente);            
        }

        public void IncluirClienteNaLista(Cliente cliente1, Cliente cliente2)
        {
            List<Cliente> lst = new List<Cliente> { cliente1, cliente2};
            Clientes.AddRange(lst);
        }

        public void AlterarUmCliente(int id, string nomeNovo, string telefoneNovo)
        {
            Cliente cliente = Clientes.FirstOrDefault(cli => cli.IdCliente == id);
            if (cliente != null)
            {
                cliente.AlterarCliente(nomeNovo, telefoneNovo);
            }
        }

        public void ExcluirUmCliente(int id)
        {
            Clientes.RemoveAll(cli => cli.IdCliente == id);
        }
    }
}
