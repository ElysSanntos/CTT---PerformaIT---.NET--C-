using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Manicure
{

    class MinhaBaseDeClientes
    {
        public List<Cliente> Clientes { get; set; }
        public MinhaBaseDeClientes()
        {
            Clientes = new List<Cliente>();
        }
        public void IncluirCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
        }
        public void IncluirLista(Cliente cliente1, Cliente cliente2)
        {
            List<Cliente> lst = new List<Cliente> { cliente1, cliente2 };
            Clientes.AddRange(lst);
        }
        public void AlterarUmCliente(int novoid, string novoNome, string novoTelefone, string v)
        {
            Cliente alterClient = Clientes.FirstOrDefault(cli => cli.CodCliente == novoid);
            if (alterClient != null)
            {
                alterClient.Alterar(novoNome, novoTelefone);
            }
            //foreach (var cli in Clientes)
            //{
            //    if (cli.CodCliente == novoid)
            //    {
            //        cli.Alterar(novoNome, novoTelefone);
            //        break;
            //    }
            //}

        }
        public void ExcluirUmCliente(int id)
        {
            Clientes.RemoveAll(cli => cli.CodCliente == id);

            //for (int i = 0; i < Clientes.Count; i++)//Enquanto for menor que a quantidade de itens da lista
            //{
            //    if (Clientes[i].CodCliente == id)
            //    {
            //        Clientes.RemoveAt(i);
            //        break;
            //    }
            //}
        }
    }

        
       
}







