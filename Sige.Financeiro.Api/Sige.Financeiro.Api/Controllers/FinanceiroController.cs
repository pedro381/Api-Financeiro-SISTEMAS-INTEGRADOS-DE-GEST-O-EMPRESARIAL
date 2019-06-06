using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Helpers;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Sige.Financeiro.Api.Models;
using WebGrease.Css.Extensions;

namespace Sige.Financeiro.Api.Controllers
{
    public class FinanceiroController : ApiController
    {
        private readonly MySqlConnection _dbConn = new MySqlConnection("Persist Security Info=False;server=remotemysql.com;Port=3306;database=knGOMEGQoI;uid=knGOMEGQoI;password=JUdJt8mvQf");

        /// <summary>
        /// GET Relatorio Operacional
        /// </summary>
        /// <returns></returns>
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Financeiro/GetContasAPagar")]
        public List<ContasAPagar> GetContasAPagar()
        {
            var dataTable = new DataTable();
            MySqlCommand cmd = _dbConn.CreateCommand();
            cmd.CommandText = "SELECT * from apagar";
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

            return lst;
        }


        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Financeiro/GetContasAReceber")]
        public List<ContasAReceber> GetContasAReceber()
        {
            var dataTable = new DataTable();
            MySqlCommand cmd = _dbConn.CreateCommand();
            cmd.CommandText = "SELECT * from contasareceber";
            _dbConn.Open();
            cmd.ExecuteNonQuery();
            var da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);
            _dbConn.Close();

            var lst = new List<ContasAReceber>();
            var dt = dataTable.AsEnumerable();
            foreach (var row in dt)
            {
                var obj = new ContasAReceber();
                obj.id = row.Field<int>("id");
                obj.datavencimento = row.Field<DateTime?>("datavencimento");
                obj.datarecebimento = row.Field<DateTime?>("datarecebimento");
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

            return lst;
        }
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Financeiro/GetFluxoDeCaixa")]
        public List<FluxoDeCaixa> GetFluxoDeCaixa()
        {
            var dataTable = new DataTable();
            MySqlCommand cmd = _dbConn.CreateCommand();
            cmd.CommandText = "SELECT * from flucodecaixa";
            _dbConn.Open();
            cmd.ExecuteNonQuery();
            var da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);
            _dbConn.Close();

            var lst = new List<FluxoDeCaixa>();
            var dt = dataTable.AsEnumerable();
            foreach (var row in dt)
            {
                var obj = new FluxoDeCaixa();
                obj.id = row.Field<int>("id");
                obj.origem = row.Field<string>("origem");
                obj.total = row.Field<decimal?>("total");
                obj.datainicial = row.Field<DateTime?>("datainicial");
                obj.datafinal = row.Field<DateTime?>("datafinal");
                obj.empresa_id = int.Parse(row[5].ToString());
                obj.historico = row.Field<string>("historico");
                obj.status = row.Field<string>("status");
                obj.situacao = row.Field<string>("situacao");
                lst.Add(obj);
            }

            return lst;
        }
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Financeiro/GetEmpresa")]
        public List<Empresa> GetEmpresa()
        {
            var dataTable = new DataTable();
            MySqlCommand cmd = _dbConn.CreateCommand();
            cmd.CommandText = "SELECT * from empresa";
            _dbConn.Open();
            cmd.ExecuteNonQuery();
            var da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);
            _dbConn.Close();

            var lst = new List<Empresa>();
            var dt = dataTable.AsEnumerable();
            foreach (var row in dt)
            {
                var obj = new Empresa();
                obj.id = int.Parse(row[0].ToString());
                obj.nome = row.Field<string>("nome");
                lst.Add(obj);
            }

            return lst;
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Financeiro/GetObterRespostaMelhoriaContinua")]
        public RespostaMelhoriaContinua GetObterRespostaMelhoriaContinua(string reclamacao)
        {
            var rmc = new RespostaMelhoriaContinua { Id = MelhoriaContinua.Reclamacao.ObterResposta(reclamacao) };

            switch (rmc.Id)
            {
                case 1:
                    rmc.Descricao = "Sim";
                    break;
                case 2:
                    rmc.Descricao = "Não";
                    break;
                default:
                    rmc.Descricao = "Pendente";
                    break;
            }

            return rmc;
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Financeiro/LucroPorProduto")]
        public List<LucroPorProduto> GetLucroPorProduto()
        {
            var dataTable = new DataTable();
            MySqlCommand cmd = _dbConn.CreateCommand();
            cmd.CommandText = "SELECT * from lucroPorProduto";
            _dbConn.Open();
            cmd.ExecuteNonQuery();
            var da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);
            _dbConn.Close();

            var lst = new List<LucroPorProduto>();
            var dt = dataTable.AsEnumerable();
            foreach (var row in dt)
            {
                var obj = new LucroPorProduto();
                obj.idProduto = int.Parse(row[0].ToString());
                obj.valorRealParaEmpresa = row.Field<string>("valorRealParaEmpresa");
                lst.Add(obj);
            }

            return lst;
        }
    }
}
