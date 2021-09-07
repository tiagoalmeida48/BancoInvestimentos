using System;
using System.Collections.Generic;
using System.Text;

namespace banco
{
    interface IConta
    {
        public void SacarDinheiro(double valor) { }

        public void DepositarDinheiro(double valor) { }
    }
}
