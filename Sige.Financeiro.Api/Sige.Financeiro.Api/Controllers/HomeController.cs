using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data.MySqlClient;
using Sige.Financeiro.Api.Models;

namespace Sige.Financeiro.Api.Controllers
{
    public class HomeController : Controller
    {
        private readonly MySqlConnection _dbConn = new MySqlConnection("Persist Security Info=False;server=remotemysql.com;Port=3306;database=knGOMEGQoI;uid=knGOMEGQoI;password=JUdJt8mvQf");

        public ActionResult Index()
        {
            ViewBag.Title = "Relatórios";


            var dataTable = new DataTable();
            MySqlCommand cmd = _dbConn.CreateCommand();
            cmd.CommandText = "SELECT * FROM apagar WHERE status = 58 OR status = 59";
            _dbConn.Open();
            cmd.ExecuteNonQuery();
            var da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);
            _dbConn.Close();

            var lst = new List<ContasAPagar>();
            var dt = dataTable.AsEnumerable();
            foreach (var row in dt)
            {
                var obj = new ContasAPagar();
                obj.id = row.Field<int>("id");
                obj.datavencimento = row.Field<DateTime?>("datavencimento");
                obj.datapagamento = row.Field<DateTime?>("datapagamento");
                obj.datalancamento = row.Field<DateTime?>("datalancamento");
                obj.historico = row.Field<string>("historico");
                obj.valor = row.Field<decimal?>("valor");
                obj.valorpago = row.Field<decimal?>("valorpago");
                obj.origem = row.Field<string>("origem");
                obj.status = row.Field<string>("status");
                obj.situacao = row.Field<string>("situacao");
                obj.juros = row.Field<decimal?>("juros");
                obj.desconto = row.Field<decimal?>("desconto");
                obj.multa = row.Field<decimal?>("multa");
                obj.tipo = row.Field<decimal?>("tipo");
                lst.Add(obj);
            }

            ViewBag.RESUMODEFOLHA = lst;

            dataTable = new DataTable();
            cmd = _dbConn.CreateCommand();
            cmd.CommandText = "SELECT (SELECT SUM(contasareceber.valorpago) from contasareceber WHERE contasareceber.origem = 'Financeiro' and contasareceber.situacao=' Pago') as 'ReceitaFinanceiro', (SELECT SUM(contasareceber.valorpago) from contasareceber WHERE contasareceber.origem = ' Marketing' and contasareceber.situacao=' Pago') as 'ReceitaMarketing', (SELECT SUM(contasareceber.valorpago) from contasareceber WHERE contasareceber.origem = ' Produção' and contasareceber.situacao=' Pago') as 'ReceitaProducao', (SELECT SUM(contasareceber.valorpago) from contasareceber WHERE contasareceber.origem = ' RH' and contasareceber.situacao=' Pago') as 'ReceitaRH'"
;
            _dbConn.Open();
            cmd.ExecuteNonQuery();
            da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);
            _dbConn.Close();

            dt = dataTable.AsEnumerable();

            ViewBag.ReceitaMarketing = dt.ElementAt(0).Field<decimal>("ReceitaMarketing"); 
            ViewBag.ReceitaFinanceiro = dt.ElementAt(0).Field<decimal>("ReceitaFinanceiro");
            ViewBag.ReceitaProducao = dt.ElementAt(0).Field<decimal>("ReceitaProducao");
            ViewBag.ReceitaRH =    dt.ElementAt(0).Field<decimal>("ReceitaRH");

            dataTable = new DataTable();
            cmd = _dbConn.CreateCommand();
            cmd.CommandText = "SELECT (SELECT SUM(apagar.valorpago) from apagar WHERE apagar.origem = 'Financeiro' and apagar.situacao=' Pago') as 'DespesasFinanceiro', (SELECT SUM(apagar.valorpago) from apagar WHERE apagar.origem = ' Marketing' and apagar.situacao=' Pago') as 'DespesasMarketing', (SELECT SUM(apagar.valorpago) from apagar WHERE apagar.origem = ' Produção' and apagar.situacao=' Pago') as 'DespesasProducao', (SELECT SUM(apagar.valorpago) from apagar WHERE apagar.origem = ' RH' and apagar.situacao=' Pago') as 'DespesasRH'";
            _dbConn.Open();
            cmd.ExecuteNonQuery();
            da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);
            _dbConn.Close();

            dt = dataTable.AsEnumerable();

            ViewBag.DespesasMarketing = dt.ElementAt(0).Field<decimal>("DespesasMarketing");
            ViewBag.DespesasFinanceiro = dt.ElementAt(0).Field<decimal>("DespesasFinanceiro");
            ViewBag.DespesasProducao = dt.ElementAt(0).Field<decimal>("DespesasProducao");
            ViewBag.DespesasRH = dt.ElementAt(0).Field<decimal>("DespesasRH");

           
             dataTable = new DataTable();
             cmd = _dbConn.CreateCommand();
            cmd.CommandText = "SELECT * FROM `apagar` WHERE apagar.datapagamento >= '2019-03-01' AND apagar.datapagamento < '2019-03-08'";
            _dbConn.Open();
            cmd.ExecuteNonQuery();
             da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);
            _dbConn.Close();

            lst = new List<ContasAPagar>();
             dt = dataTable.AsEnumerable();
            foreach (var row in dt)
            {
                var obj = new ContasAPagar();
                obj.id = row.Field<int>("id");
                obj.datavencimento = row.Field<DateTime?>("datavencimento");
                obj.datapagamento = row.Field<DateTime?>("datapagamento");
                obj.datalancamento = row.Field<DateTime?>("datalancamento");
                obj.historico = row.Field<string>("historico");
                obj.valor = row.Field<decimal?>("valor");
                obj.valorpago = row.Field<decimal?>("valorpago");
                obj.origem = row.Field<string>("origem");
                obj.status = row.Field<string>("status");
                obj.situacao = row.Field<string>("situacao");
                obj.juros = row.Field<decimal?>("juros");
                obj.desconto = row.Field<decimal?>("desconto");
                obj.multa = row.Field<decimal?>("multa");
                obj.tipo = row.Field<decimal?>("tipo");
                lst.Add(obj);
            }

            ViewBag.PagamentosDaSemana = lst;

            return View();
        }
    }
}
