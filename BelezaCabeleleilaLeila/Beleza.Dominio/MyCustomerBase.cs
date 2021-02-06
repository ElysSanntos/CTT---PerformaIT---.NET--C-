using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;
using System.IO;


namespace BelezaCaleleleilaLeila.Dominio
{
    public class MyCustomerBase
    {
        public List<Client> Clientes { get; set; }

        public MyCustomerBase()
        {
            Clientes = new List<Client>();
        }

        public void IncluirCliente(Client cliente)
        {
            Clientes.Add(cliente);
        }

        public void IncluirClienteNaLista(Client cliente1, Client cliente2)
        {
            List<Client> lst = new List<Client> { cliente1, cliente2 };
            Clientes.AddRange(lst);
        }

        public void AlterarUmCliente(int id, string nomeNovo, string telefoneNovo)
        {
            Client cliente = Clientes.FirstOrDefault(cli => cli.IdCliente == id);
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

