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

        public static List<ContaViewModel> Get()
        {
            return new List<ContaViewModel>
            {
                new ContaViewModel{ Tipo = "Cred.", Area = "Comercial", Historico = "Salario Regular", DataVenc =  DateTime.Parse("01/04/2019"),DataLacamento =  DateTime.Parse("01/04/2019"),DataPag =  DateTime.Parse("01/04/2019"), Valor = 9812.44, Encargos = 6868.71}
                ,new ContaViewModel{ Tipo = "Cred.", Area = "Estoque", Historico = "Salario Regular", DataVenc =  DateTime.Parse("01/04/2014"),DataLacamento =  DateTime.Parse("01/04/2019"),DataPag =  DateTime.Parse("01/04/2019"), Valor = 4521.33, Encargos =  3164.93    }
                ,new ContaViewModel{ Tipo = "Cred.", Area = "Vendas", Historico = "Ferias", DataVenc =  DateTime.Parse(" 02/04/2019"),DataLacamento =  DateTime.Parse("01/04/2019"),DataPag =  DateTime.Parse("01/04/2019"), Valor = 7653.11, Encargos =  5357.18             }
                ,new ContaViewModel{ Tipo = "Cred.", Area = "Contábil", Historico = "Ferias", DataVenc =  DateTime.Parse(" 03/04/2019"),DataLacamento =  DateTime.Parse("01/04/2019"),DataPag =  DateTime.Parse("01/04/2019"), Valor = 5169.63, Encargos =  3618.74           }
                ,new ContaViewModel{ Tipo = "Cred.", Area = "Contábil", Historico = "Salario Regular", DataVenc =  DateTime.Parse("01/04/2019"),DataLacamento =  DateTime.Parse("01/04/2019"),DataPag =  DateTime.Parse("01/04/2019"), Valor = 4089.97, Encargos =  2862.98   }
                ,new ContaViewModel{ Tipo = "Cred.", Area = "Tecnólogia", Historico = "Salario Regular", DataVenc =  DateTime.Parse("01/04/2014"),DataLacamento =  DateTime.Parse("01/04/2019"),DataPag =  DateTime.Parse("01/04/2019"), Valor = 3010.30, Encargos =  2107.21 }
                ,new ContaViewModel{ Tipo = "Cred.", Area = "Comercial", Historico = "Salario Regular", DataVenc =  DateTime.Parse("02/04/2019"),DataLacamento =  DateTime.Parse("01/04/2019"),DataPag =  DateTime.Parse("01/04/2019"), Valor = 1930.63, Encargos =  1351.44  }
                ,new ContaViewModel{ Tipo = "Cred.", Area = "Estoque", Historico = "Salario Regular", DataVenc =  DateTime.Parse("03/04/2019"),DataLacamento =  DateTime.Parse("01/04/2019"),DataPag =  DateTime.Parse("01/04/2019"), Valor = 850.97, Encargos =    595.68    }
                ,new ContaViewModel{ Tipo = "Cred.", Area = "Vendas", Historico = "Salario Regular", DataVenc =  DateTime.Parse("01/04/2019"),DataLacamento =  DateTime.Parse("01/04/2019"),DataPag =  DateTime.Parse("01/04/2019"), Valor = 2850.97, Encargos =  1995.68     }
                ,new ContaViewModel{ Tipo = "Cred.", Area = "Contábil", Historico = "Salario Regular", DataVenc =  DateTime.Parse("01/04/2014"),DataLacamento =  DateTime.Parse("01/04/2019"),DataPag =  DateTime.Parse("01/04/2019"), Valor = 4850.97, Encargos =  3395.68   }
                ,new ContaViewModel{ Tipo = "Cred.", Area = "Contábil", Historico = "Salario Regular", DataVenc =  DateTime.Parse("02/04/2019"),DataLacamento =  DateTime.Parse("01/04/2019"),DataPag =  DateTime.Parse("01/04/2019"), Valor = 6850.97, Encargos =  4795.68   }
                ,new ContaViewModel{ Tipo = "Cred.", Area = "Tecnólogia", Historico = "Salario Regular", DataVenc =  DateTime.Parse("03/04/2019"),DataLacamento =  DateTime.Parse("01/04/2019"),DataPag =  DateTime.Parse("01/04/2019"), Valor = 8850.97, Encargos =  6195.68 }
                ,new ContaViewModel{ Tipo = "Cred.", Area = "Comercial", Historico = "Ferias", DataVenc =  DateTime.Parse(" 01/04/2014"),DataLacamento =  DateTime.Parse("01/04/2019"),DataPag =  DateTime.Parse("01/04/2019"), Valor = 10850.97, Encargos = 7595.68          }
                ,new ContaViewModel{ Tipo = "Cred.", Area = "Estoque", Historico = "Ferias", DataVenc =  DateTime.Parse(" 02/04/2019"),DataLacamento =  DateTime.Parse("01/04/2019"),DataPag =  DateTime.Parse("01/04/2019"), Valor = 12850.97, Encargos = 8995.68            }
                ,new ContaViewModel{ Tipo = "Cred.", Area = "Vendas", Historico = "Antecipação 13", DataVenc =  DateTime.Parse(" 03/04/2019"),DataLacamento =  DateTime.Parse("01/04/2019"),DataPag =  DateTime.Parse("01/04/2019"), Valor = 14850.97, Encargos = 10395.68    }
                ,new ContaViewModel{ Tipo = "Cred.", Area = "Contábil", Historico = "Antecipação 13", DataVenc =  DateTime.Parse(" 01/04/2014"),DataLacamento =  DateTime.Parse("01/04/2019"),DataPag =  DateTime.Parse("01/04/2019"), Valor = 16850.97, Encargos = 11795.68 }

            };
        }
    }
}