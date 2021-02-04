using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Manicure.Funcionario;

namespace Manicure
{
    class MinhaBaseDeFuncionarios
    {
        public List<Funcionario> Funcionarios { get; set; }

        public MinhaBaseDeFuncionarios()
        {
            Funcionarios = new List<Funcionario>();
        }

        public void IncluirUmFuncionario(Funcionario func)
        {
            int matricula = 0; //Verifica se a lista de funcionarios tem alguem, se positivo, recebe o ultimo funcionario.matricula,senão incrementa
            if (Funcionarios.Any())
                matricula = Funcionarios.Last().CodFuncioanario+1;
            else
                matricula++;
            func.CodFuncioanario = matricula;
            Funcionarios.Add(func);
        }

        public void AlterarUmFuncionario(int matricula, string nomeNovo, string telefoneNovo, Endereco enderecoNovo, CargoFunc cargoNovo)
        {
            Funcionarios.Find(func => func.CodFuncioanario == matricula).AlterarFuncionario(nomeNovo, telefoneNovo, enderecoNovo, cargoNovo);
        }

        public void IncluirServicoDeUmFuncionario(int matricula, Servico servicos)
            //Vincular o funcionario ao serviço realizado no Salão
        {
            Funcionarios.Find(func => func.CodFuncioanario == matricula)
                .VincularServicoAoFuncionario(servicos); //procuro o func, verifico a matricula, e incluo o serviço
        }

        public void ExcluirUmFuncionario(int matricula)
        {
            Funcionarios.RemoveAll(func => func.CodFuncioanario.Equals(matricula));
        }

        public void ExcluirServicoDeUmFuncionario(int matricula, int idServ)
        {
            //Funcionario func = Funcionarios.Find(func => func.Matricula == matricula);
            //if (func != null)
            //{
            //    func.Servicos.RemoveAll(serv => serv.Id == idServ);
            //}

            Funcionarios.Find(func => func.CodFuncioanario == matricula)
                .Servicos.RemoveAll(serv => serv.IdServico == idServ);
            // Procura o funcionario, confirma a matricula e remove o serviço vinculado a matricula
        }
    }
}

