using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sige.Financeiro.Api.Models
{
    public class ContaViewModel
    {
        public int IdConta { get; set; }
        public string Historico { get; set; }
        public double Valor { get; set; }
        public double Encargos { get; set; }
        public string Area { get; set; }
        public DateTime DataVenc { get; set; }
        public DateTime DataLacamento { get; set; }
        public DateTime DataPag { get; set; }
        public string Tipo { get; set; }

    }
}