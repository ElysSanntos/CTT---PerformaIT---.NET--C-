using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Conta
    {
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public decimal Saldo { get; set; }
        public string Status { get; set; }


        public string Sacar(int valorParaSaque)
        {
            if (valorParaSaque > 500)
                return "Valor acima do liberado para saque";
            else
            {
                if (valorParaSaque > Saldo)
                    return "Não tem Saldo disponível";
                else
                {
                    Saldo = Saldo - valorParaSaque;
                    return "Foi sacado R$ " + valorParaSaque + ". Seu saldo agora é de R$ " + Saldo;
                }
            }
        }

        public string Depositar(int valorParaDeposito)
        {
            if (valorParaDeposito <= 0)
                return "Valor para depósito não pode ser menor ou igual a 0.";

            Saldo = Saldo + valorParaDeposito;
            return "Foi depositado R$ " + valorParaDeposito + ". Seu saldo agora é de R$ " + Saldo;
        }
    }
}
