using System;
using System.Collections.Generic;
using System.Text;

namespace BelezaCaleleleilaLeila.Dominio
{
    public class Employee
    {
        public Employee()
        {
            Servicos = new List<Service>();
        }

        public int MatriculaFuncionario { get; set; }
        public string NomeFuncionario { get; set; }
        public string TelefoneFuncionario { get; set; }
        public Address  EnderecoFuncionario { get; set; }
        public CargoFunc CargoFuncionario { get; set; }
        public DateTime HorarioEntradaFuncionario { get { return Convert.ToDateTime("10:00"); } }
        public DateTime HorarioSaidaFuncionario { get { return Convert.ToDateTime("19:00"); } }
        public enum CargoFunc
        {
            Cabelereira,
            Manicure,
            Esteticista
        }
        public List<Service> Services { get; set; }

        public void IncluirFuncionario(string nome, string telefone, Address endereco, CargoFunc cargo)
        {
            //Matricula = matricula;
            NomeFuncionario = nome;
            TelefoneFuncionario = telefone;
            EnderecoFuncionario = endereco;
            CargoFuncionario = cargo;
        }

        public void AlterarFuncionario(string nome, string telefone, Address endereco, CargoFunc cargo)
        {
            NomeFuncionario = nome;
            TelefoneFuncionario = telefone;
            EnderecoFuncionario = endereco;
            CargoFuncionario = cargo;
        }

        public void IncluirServicoNoFuncionario(Service serv)
        {
            Service.Add(serv);
        }

        public void ExcluirServicoFuncionario(int id)
        {
            //Servicos.RemoveAll(s => s.Id == id);

            List<Service> removerServicoDoFuncionario = Service.FindAll(f => f.IdServico == id);
            foreach (var remove in removerServicoDoFuncionario)
            {
                Service.Remove(remove);
            }
        }
    }

}

