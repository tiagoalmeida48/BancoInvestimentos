using System;
using System.Collections.Generic;
using System.Text;

namespace banco
{
    interface IConta
    {
        public double SacarDinheiro(double valor);

        public double DepositarDinheiro(double valor);
    }
}
