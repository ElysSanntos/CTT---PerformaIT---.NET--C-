namespace Leila.Dominio
{
    public class Servico
    {
        public int IdServico { get; set; }
        public string NomeServico { get; set; }
        public int TempoDeExecucaoDeUmServico { get; set; }
        public decimal ValorDoServico { get; set; }

        public void IncluirUmServico(int id, string nome, int minutosParaExecucao, decimal preco)
        {
            Agendamento a = new Agendamento();

            IdServico = id;
            NomeServico = nome;
            TempoDeExecucaoDeUmServico = minutosParaExecucao;
            ValorDoServico = preco;
        }

        public void AlterarUmServico(string nome, int minutosParaExecucao, decimal preco)
        {   
            NomeServico = nome;
            TempoDeExecucaoDeUmServico = minutosParaExecucao;
            ValorDoServico = preco;
        }

    }
}
