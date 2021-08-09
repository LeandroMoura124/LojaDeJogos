using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaDeJogos.Models
{
    public class Cliente : Controller
    {
        // GET: Cliente
        public string ClienteNome { get; set; }
        public string ClienteCPF { get; set; }
        public DateTime FuncDtNasc { get; set; }
        public string ClienteEmail { get; set; }

        public string ClienteCel { get; set; }
        public string ClienteEnd { get; set; }
    }
}