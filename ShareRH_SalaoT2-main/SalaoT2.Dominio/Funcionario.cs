﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace SalaoT2.Dominio
{
    public class Funcionario
    {
        public Funcionario()
        {
            Servicos = new List<Servico>();
        }

        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public CargoFunc Cargo { get; set; }
        public DateTime HorarioEntrada { get { return Convert.ToDateTime("10:00"); } }
        public DateTime HorarioSaida { get { return Convert.ToDateTime("19:00"); } }
        public enum CargoFunc
        {
            Cabelereira,
            Manicure,
            Esteticista
        }
        public List<Servico> Servicos { get; set; }

        public void Incluir(string nome, string telefone, Endereco endereco, CargoFunc cargo)
        {
            //Matricula = matricula;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Cargo = cargo;
        }

        public void Alterar(string nome, string telefone, Endereco endereco, CargoFunc cargo)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Cargo = cargo;
        }

        public void IncluirServico(Servico serv)
        {
            Servicos.Add(serv);
        }

        public void ExcluirServico(int id)
        {
            //Servicos.RemoveAll(s => s.Id == id);

            List<Servico> remover = Servicos.FindAll(f => f.Id == id);
            foreach (var remove in remover)
            {
                Servicos.Remove(remove);
            }
        }
    }


}
