using System;
using System.Collections.Generic;
using System.Text;

namespace banco
{
    interface IConta
    {
        double SacarDinheiro(double valor);

        double DepositarDinheiro(double valor);
    }
}
