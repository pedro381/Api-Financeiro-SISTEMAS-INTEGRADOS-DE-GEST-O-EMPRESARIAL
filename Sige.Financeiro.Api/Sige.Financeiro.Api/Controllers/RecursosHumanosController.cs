﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Sige.Financeiro.Api.Models;

namespace Sige.Financeiro.Api.Controllers
{
    public class RecursosHumanosController : ApiController
    {
        /// <summary>
        /// GET Relatorio Operacional
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("RecursosHumanos/GetRelatorioOperacional")]
        public IEnumerable<ContaViewModel> GetRelatorioOperacional()
        {
            return ContaViewModel.Get();
        }

        /// <summary>
        /// GET Relatorio Tático
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("RecursosHumanos/GetRelatorioTatico")]
        public IEnumerable<ContaViewModel> GetRelatorioTatico()
        {
            return ContaViewModel.Get();
        }

        /// <summary>
        /// GET Relatorio Estratégico
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("RecursosHumanos/GetRelatorioEstrategico")]
        public IEnumerable<ContaViewModel> GetRelatorioEstrategico()
        {
            return ContaViewModel.Get();
        }
    }
}