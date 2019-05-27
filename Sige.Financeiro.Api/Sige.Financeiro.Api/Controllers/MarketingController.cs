using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Sige.Financeiro.Api.Models;

namespace Sige.Financeiro.Api.Controllers
{
    public class MarketingController : ApiController
    {
        /// <summary>
        /// GET Relatorio Operacional
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Marketing/GetRelatorioOperacional")]
        public IEnumerable<ContaViewModel> GetRelatorioOperacional()
        {
            return ContaViewModel.Get();
        }

        /// <summary>
        /// GET Relatorio Tático
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Marketing/GetRelatorioTatico")]
        public IEnumerable<ContaViewModel> GetRelatorioTatico()
        {
            return ContaViewModel.Get();
        }

        /// <summary>
        /// GET Relatorio Estratégico
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Marketing/GetRelatorioEstrategico")]
        public IEnumerable<ContaViewModel> GetRelatorioEstrategico()
        {
            return ContaViewModel.Get();
        }
    }
}
