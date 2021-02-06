using System;
using System.Collections.Generic;
using System.Text;

namespace BelezaCaleleleilaLeila.Dominio
{
    public class Address
    {
        public int IdAddress { get; set; }
        public string Street { get; set; }
        public string CodeZip { get; set; }
        public string Neigborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Number { get; set; }


        public void IncluirAddress(int id, string rua, string cep, string bairro, string cidade,
            string uf, string numero)
        {
            IdAddress = id;
            Street = rua;
            CodeZip = cep;
            Neigborhood = bairro;
            City = cidade;
            State = uf;
            Number = numero;

        }

        public void AlterarAddress(string rua, string cep, string bairro, string cidade,
            string uf, string numero)
        {
            Street = rua;
            CodeZip = cep;
            Neigborhood = bairro;
            City = cidade;
            State = uf;
            Number = numero;

        }
    }
}
