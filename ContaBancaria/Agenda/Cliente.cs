using System;
using System.Collections.Generic;
using System.Text;

namespace Manicure
{
    //Criando as propriedades de Cliente
    public class Cliente
    {
        public int CodCliente { get; set; }
        public string NomeCliente { get; set; }
        public string TelefoneCliente { get; set; }
        public string AgendaHorario { get; set; }


        // Tudo o que se relacionar com o obj cliente deve ficar nesta classe
        //Classes, propriedades e métodos iniciam com letra maiuscula 
        //variaveis e parametros com letra minuscula


        //Metodo
        public void Incluir(int cod, string name, string phone, string schedule)
        {
            CodCliente = cod;
            NomeCliente = name;
            TelefoneCliente = phone;
            AgendaHorario = schedule;

        }

        public void Alterar(string nome, string telefone)
        {
            //Este conteúdo que vem de fora, está nulo ou vazio? 
            //Se true, permanece com o mesmo conteúdo, se false: recebe o conteúdo de fora
            NomeCliente = string.IsNullOrEmpty(nome) ? NomeCliente : nome;
            TelefoneCliente = string.IsNullOrEmpty(telefone) ? TelefoneCliente : telefone;
        }   
    }


}
