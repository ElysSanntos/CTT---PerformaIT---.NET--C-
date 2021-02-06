using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BelezaCaleleleilaLeila.Dominio
{
    class MyEmployeeBase
    {
        public List<Employee> Funcionarios { get; set; }

        public MyEmployeeBase()
        {
            Funcionarios = new List<Employee>();
        }

        public void IncluirUmFuncionario(Employee func)
        {
            int matricula = 0;
            if (Funcionarios.Any())
                matricula = Funcionarios.Last().MatriculaFuncionario + 1;
            else
                matricula++;
            func.MatriculaFuncionario = matricula;
            Funcionarios.Add(func);
        }

        public void AlterarUmFuncionario(int matricula, string nomeNovo, string telefoneNovo, Address enderecoNovo, Employee.CargoFunc cargoNovo)
        {
            Funcionarios.Find(func => func.MatriculaFuncionario == matricula)
                .AlterarFuncionario(nomeNovo, telefoneNovo, enderecoNovo, cargoNovo);
        }

        public void IncluirServicoDeUmFuncionario(int matricula, Service servico)
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
            Employee func = Funcionarios.Find(func => func.MatriculaFuncionario == matricula);
            if (func != null)
            {
                func.Services.RemoveAll(serv => serv.IdServico == idServ);
            }

            //Funcionarios.Find(func => func.Matricula == matricula)
            //.Servicos.RemoveAll(serv => serv.Id == idServ);
        }
    }
}

