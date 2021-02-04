using System;
using System.Linq;
using System.Collections.Generic;

namespace Leila.Dominio
{
    public class Funcionario
    {
        public Funcionario()
        {
            Servicos = new List<Servico>();
        }

        public int MatriculaFuncionario { get; set; }
        public string NomeFuncionario { get; set; }
        public string TelefoneFuncionario { get; set; }
        public Endereco EnderecoFuncionario { get; set; }
        public CargoFunc CargoFuncionario { get; set; }
        public DateTime HorarioEntradaFuncionario { get { return Convert.ToDateTime("10:00"); } }
        public DateTime HorarioSaidaFuncionario { get { return Convert.ToDateTime("19:00"); } }
        public enum CargoFunc
        {
            Cabelereira,
            Manicure,
            Esteticista
        }
        public List<Servico> Servicos { get; set; }

        public void IncluirFuncionario(string nome, string telefone, Endereco endereco, CargoFunc cargo)
        {
            //Matricula = matricula;
            NomeFuncionario = nome;
            TelefoneFuncionario = telefone;
            EnderecoFuncionario = endereco;
            CargoFuncionario = cargo;
        }

        public void AlterarFuncionario(string nome, string telefone, Endereco endereco, CargoFunc cargo)
        {
            NomeFuncionario = nome;
            TelefoneFuncionario = telefone;
            EnderecoFuncionario = endereco;
            CargoFuncionario = cargo;
        }

        public void IncluirServicoNoFuncionario(Servico serv)
        {
            Servicos.Add(serv);
        }

        public void ExcluirServicoFuncionario(int id)
        {
            //Servicos.RemoveAll(s => s.Id == id);

            List<Servico> removerServicoDoFuncionario = Servicos.FindAll(f => f.IdServico == id);
            foreach (var remove in removerServicoDoFuncionario)
            {
                Servicos.Remove(remove);
            }
        }
    }


}
