using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orcamento
{
    internal class calculo
    {
        public string Nome { get; set; }
        public double QtdLivros { get; set; }
        public double QtdPaginasPorLivro { get; set; }
        public double ValorPorPagina { get; set; }
        public double ValorPorLivro { get; set; }
        public double ValorTotalLivros { get; set; }

        public void CalculaLivro(double QtdPaginasPorLivro, double ValorPorPagina)
        { 
            ValorPorLivro = ValorPorPagina * QtdPaginasPorLivro;
        }

        public void CalculaValorTotalLivros(double QtdLivros)
        {
            ValorTotalLivros = ValorPorLivro * QtdLivros;
        }

    }
}
