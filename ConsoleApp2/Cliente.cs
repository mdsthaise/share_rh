using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool ConstaSpc { get; set; }
        public string CpfCnpj { get; set; }
        public ContaCorrente ContaCorrente { get; set; }
        public ContaPoupanca ContaPoupanca { get; set; }

        public Cliente()
        {
            ContaCorrente = new ContaCorrente();
            ContaCorrente.Agencia = 1;
            ContaCorrente.Numero = 123456;

            ContaPoupanca = new ContaPoupanca();
            ContaPoupanca.Agencia = 1;
            ContaPoupanca.Numero = 78901;
        }
    }
}
