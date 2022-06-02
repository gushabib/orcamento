using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orcamento
{
    internal class comissao
    {
        public double ComissaoVendedor { get; set; }

        public comissao(double valor)
        {
            ComissaoVendedor = valor * 0.1;
        }
    }
}
