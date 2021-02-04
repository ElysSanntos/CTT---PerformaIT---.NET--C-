using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BelezaCaleleleilaLeila.Dominio
{
    class Client
    {
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string TelefoneCliente { get; set; }
        public string CPFCliente { get; set; }

        public void IncluirCliente(int id, string nome, string telefone, string cpf)
        {
            IdCliente = id;
            NomeCliente = nome + " Gameiro";
            TelefoneCliente = telefone;
            CPFCliente = cpf;
        }

        public void AlterarCliente(string nome, string telefone)
        {
            NomeCliente = string.IsNullOrEmpty(nome) ? NomeCliente : nome;
            //Nome = nome ?? Nome;
            //Nome = "";
            //Nome = null;

            TelefoneCliente = string.IsNullOrEmpty(telefone) ? TelefoneCliente : telefone;
        }
    }
}
