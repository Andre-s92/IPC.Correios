using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IPC.Correios.Web.Models
{
    public class Endereco
    {
    public string cep { get; set; }
    public string street { get; set; }
    public string neighborhood { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    }
}