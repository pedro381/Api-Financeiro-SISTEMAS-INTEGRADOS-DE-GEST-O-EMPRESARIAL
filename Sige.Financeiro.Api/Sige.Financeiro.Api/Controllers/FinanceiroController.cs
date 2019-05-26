﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Sige.Financeiro.Api.Models;

namespace Sige.Financeiro.Api.Controllers
{
    public class FinanceiroController : ApiController
    {
        /// <summary>
        /// GET Relatorio Operacional
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Financeiro/GetRelatorioOperacional")]
        public IEnumerable<ContaVeiwModel> GetRelatorioOperacional()
        {
            return ContaVeiwModel.Get();
        }

        /// <summary>
        /// GET Relatorio Tático
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Financeiro/GetRelatorioTatico")]
        public IEnumerable<ContaVeiwModel> GetRelatorioTatico()
        {
            return ContaVeiwModel.Get();
        }

        /// <summary>
        /// GET Relatorio Estratégico
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Financeiro/GetRelatorioEstrategico")]
        public IEnumerable<ContaVeiwModel> GetRelatorioEstrategico()
        {
            return ContaVeiwModel.Get();
        }
    }
}
