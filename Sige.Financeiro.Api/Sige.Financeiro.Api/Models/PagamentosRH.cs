using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sige.Financeiro.Api.Models
{
    public class PagamentosRH
    {
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAbertura { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public decimal Custo { get; set; }

    }
    public class RHContainer
    {
        public List<PagamentosRH> PagamentosRHs { get; set; }
    }
}