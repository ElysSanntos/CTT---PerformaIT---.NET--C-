using System;
using System.Collections.Generic;
using System.Text;

namespace Manicure
{
    class Funcionario
    {
        public int CodFuncioanario { get; set; }
        public String NomeFuncionario { get; set; }
        public string Telefonefuncionario { get; set; }
        public Endereco enderecoFuncionario { get; set; }
        public Funcionario cargoFuncionario { get; set; }

    
        public DateTime HorarioEntrada
        {
            get { return Convert.ToDateTime("10:00"); }
        }
        public DateTime HorarioSaida
        {
            get { return Convert.ToDateTime("19:00"); }
        }


        public enum Especialidades
        {
            Cabelereira,
            Manicure,
            Esteticista
        }
        //Metodos

        public void Incluir(int matricula, string nome, string telefone, 
            Endereco endereco, Especialidades cargo)
        {
            CodFuncioanario = matricula;
            NomeFuncionario = nome;
            Telefonefuncionario = telefone;
            enderecoFuncionario = endereco;
            Especialidades = Especialidades.
        }
        public void Alterar(string telefone,
          Endereco endereco, Especialidades cargo)
        {
            Telefonefuncionario = telefone;
            enderecoFuncionario = endereco;
            Especialidades = Especialidades.
        }
    }
}
