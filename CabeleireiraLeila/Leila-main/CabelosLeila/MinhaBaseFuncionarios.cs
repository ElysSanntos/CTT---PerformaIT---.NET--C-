using System.Collections.Generic;
using System.Linq;
using static Leila.Dominio.Funcionario;

namespace Leila.Dominio
{
    public class MinhaBaseFuncionarios
    {
        public List<Funcionario> Funcionarios { get; set; }

        public MinhaBaseFuncionarios()
        {
            Funcionarios = new List<Funcionario>();
        }

        public void IncluirUmFuncionario(Funcionario func)
        {
            int matricula = 0;
            if (Funcionarios.Any())
                matricula = Funcionarios.Last().MatriculaFuncionario + 1;
            else
                matricula++;
            func.MatriculaFuncionario = matricula;
            Funcionarios.Add(func);
        }

        public void AlterarUmFuncionario(int matricula, string nomeNovo, string telefoneNovo, Endereco enderecoNovo, CargoFunc cargoNovo)
        {
            Funcionarios.Find(func => func.MatriculaFuncionario == matricula)
                .AlterarFuncionario(nomeNovo, telefoneNovo, enderecoNovo, cargoNovo);
        }

        public void IncluirServicoDeUmFuncionario(int matricula, Servico servico)
        {
            Funcionarios.Find(func => func.MatriculaFuncionario == matricula)
                .IncluirServicoNoFuncionario(servico);
        }

        public void ExcluirUmFuncionario(int matricula)
        {
            Funcionarios.RemoveAll(func => func.MatriculaFuncionario.Equals(matricula));
        }

        public void ExcluirServicoDeUmFuncionario(int matricula, int idServ)
        {
            Funcionario func = Funcionarios.Find(func => func.MatriculaFuncionario == matricula);
            if (func != null)
            {
                func.Servicos.RemoveAll(serv => serv.IdServico == idServ);
            }

            //Funcionarios.Find(func => func.Matricula == matricula)
            //.Servicos.RemoveAll(serv => serv.Id == idServ);
        }
    }
}
