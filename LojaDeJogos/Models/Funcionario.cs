using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaDeJogos.Models
{
    public class Funcionario : Controller
    {
        // GET: Funcionario
        public ushort FuncCod { get; set; }

        public string FuncNome { get; set; }

        public string FuncCPF { get; set; }

        public string FuncRg { get; set; }

        public DateTime FuncDtNasc { get; set; }

        public string FuncEnd { get; set; }

        public string FuncCel { get; set; }

        public string FuncEmail { get; set; }

        public string FuncCargo { get; set; }

    }
}