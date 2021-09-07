using System;
using System.Collections.Generic;
using System.Text;

namespace banco
{
    class ClientePJ : Cliente
    {
        public string CNPJ{ get; set; }
        public string lucro { get; set; }
        public int tipoEmpresa { get; set; }

    }
}
