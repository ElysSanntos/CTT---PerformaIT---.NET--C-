using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Manicure
{
    public class Funcionario

    {
        //Contrutor de Serviço
        public Funcionario()
        {
            var Servicos = new List<Servico>();
        }
        public int CodFuncioanario { get; set; }
        public String NomeFuncionario { get; set; }
        public string Telefonefuncionario { get; set; }
        public CargoFunc Cargo { get; set; }

        public Endereco enderecoFuncionario { get; set; }
        public Funcionario cargoFuncionario { get; set; }
        


        public DateTime HoraEntrada
        {
            get { return Convert.ToDateTime("10:00"); }
        }
        public DateTime HoraSaida
        {
            get { return Convert.ToDateTime("19:00"); }
        }


        public enum CargoFunc
        {
            Cabelereira,
            Manicure,
            Esteticista
        }

        public List<Servico> Servicos { get; set; }

        //Metodos
        public void IncluirFuncionario( string nomeFunc, string telefoneFuncionario,
            Endereco enderecoFuncionario, CargoFunc cargoFuncionario)
        {
            //CodFuncioanario = matriculaFuncionario;
            NomeFuncionario = nomeFunc;
            Telefonefuncionario = telefoneFuncionario;
            var Endereco = enderecoFuncionario;
            Cargo = cargoFuncionario;
        }

        public void AlterarFuncionario(string telefone, //Altera as propriedades do funcionario
        string telefoneNovo, Endereco endereco, CargoFunc cargo)

        {
            Telefonefuncionario = telefone;
            enderecoFuncionario = endereco;
            Cargo = cargo;
        }


        public void VincularServicoAoFuncionario(Servico serv)
        {
            Servicos.Add(serv);
                
        }

       

        // Trata somente dos serviços - Faço a inclusão de um funcionario, 
        //e depois atribuo a ele os serviços que irá realizar no salão 


        public void ExcluirServico(int id)
        {
            //Servicos.RemoveAll(s => s.Id == id);

            List<Servico> remover = Servicos.FindAll(f => f.IdServico == id);
            foreach (var remove in remover)
            {
                Servicos.Remove(remove);
            }
        }
    }
}
