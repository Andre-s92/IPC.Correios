using IPC.Correios.Web.Application;
using IPC.Correios.Web.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace IPC.Correios.Web.Controllers
{
    public class BuscadorController : Controller
    {

        // GET: Buscador
        public ActionResult BuscaCEP()
        {
            return View();
        }
        public ActionResult BuscaEndereco()
        {
            return View();
        }
        public async Task<ActionResult> ConsultarCep(string cep)
        {
            if (!string.IsNullOrEmpty(cep))
            {

                return View("BuscaCep", await BuscadorApplication.ConsultarCEP(cep));
            
            }
            return View("BuscaCep", null);
        }
    }
}