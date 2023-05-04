using IPC.Correios.Web.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using System.Web;

namespace IPC.Correios.Web.Application
{
   
    public class BuscadorApplication
    {
        public static async Task<Endereco> ConsultarCEP(string cep)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"https://brasilapi.com.br/api/cep/v1/{cep}");
                if (response.IsSuccessStatusCode)
                {
                    var enderecoJson = await response.Content.ReadAsStringAsync();
                    var endereco = JsonConvert.DeserializeObject<Endereco>(enderecoJson);
                    return endereco;
                }
            }
            return null;
        }
}
}