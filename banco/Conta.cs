using System;
using System.Collections.Generic;
using System.Text;

namespace banco
{
    class Conta : IConta
    {
        public int numeroAgencia { get; set; }
        public int numeroConta { get; set; }
        public int numeroBanco { get; set; }
        public int idCliente { get; set; }
        public double saldoInicial { get; set; }
        public double saldoAtual { get; set; }

        public void SacarDinheiro(double valor) { }

        public void DepositarDinheiro(double valor) { }

    }
}
