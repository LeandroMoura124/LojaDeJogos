using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaDeJogos.Models
{
    public class Funcionario : Controller
    {
        // GET: Funcionario
        [Range(1, 4, ErrorMessage = "O código deve ter de 1 a 4 dígitos")]
        public ushort FuncCod { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string FuncNome { get; set; }

        public string FuncCPF { get; set; }

        public string FuncRg { get; set; }

        public DateTime FuncDtNasc
        {
            get
            {
                return this.funcDtNasc.HasValue
                    ? this.funcDtNasc.Value
                    : DateTime.Now;
            }
            set
            {
                this.funcDtNasc = value;
            }
        }
        private DateTime? funcDtNasc = null;

        public string FuncEnd { get; set; }

        public string FuncCel { get; set; }

        public string FuncEmail { get; set; }

        public string FuncCargo { get; set; }

    }
}