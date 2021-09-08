using System;
using System.Collections.Generic;
using System.Text;

namespace banco
{
    class ContaInvestimentos : Conta
    {
        public double SacarDinheiroInvestimento(double valor)
        {
            return saldoAtual -= valor;
        }

        public double DepositarDinheiroInvestimento(double valor)
        {
            return saldoAtual += RenderJuros(valor);
        }

        public double RenderJuros(double valor)
        {
            return saldoAtual += valor * 1.02;
        }
    }
}
