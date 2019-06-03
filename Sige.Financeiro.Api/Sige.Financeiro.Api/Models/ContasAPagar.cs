using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sige.Financeiro.Api.Models
{
    public class ContasAPagar
    {
        public int id { get; set; }
        public DateTime? datavencimento { get; set; }
        public DateTime? datapagamento { get; set; }
        public DateTime? datalancamento { get; set; }
        public string historico { get; set; }
        public decimal? valor { get; set; }
        public decimal? valorpago { get; set; }
        public string origem { get; set; }
        public string status { get; set; }
        public string situacao { get; set; }
        public decimal? juros { get; set; }
        public decimal? desconto { get; set; }
        public decimal? multa { get; set; }
        public decimal? tipo { get; set; }
    }
}