using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sige.Financeiro.Api.Models
{
    public class PagamentosMK
    {
        public string ID { get; set; }
        public string NOME_PROMOCAO { get; set; }
        public decimal CUSTO_CAMPANHA { get; set; }
        public decimal VALOR_PREVISTO { get; set; }
        public decimal VALOR_GASTO { get; set; }
    }
    public class MKContainer
    {
        public List<PagamentosMK> PagamentosMKs { get; set; }
    }
}