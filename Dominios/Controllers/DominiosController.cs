using Dominios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dominios.Controllers
{
    public class DominiosController : ApiController
    {
        private static List<Dominio> dominios = new List<Dominio>();
 
        [HttpGet]
        public string ObterDominio()
        {
            string arraydominio = "[ {\"id\": \"1\", \"nome\":\"Criado\"},{ \"id\": \"21\",\" nome\": \"Alterado\"},{\"id\": \"41\", \"nome\":\"Transporte\"}]";

            return arraydominio.ToString();
        }

        [HttpPost]
        public void Post(int id, string nome)
        {
            dominios.Add(new Dominio(id, nome));
        }
    }
}
