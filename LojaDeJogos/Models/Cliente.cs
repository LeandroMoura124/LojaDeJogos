using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaDeJogos.Models
{
    public class Cliente : Controller
    {
        // GET: Cliente

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string ClienteNome { get; set; }
        public string ClienteCPF { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyy}", ApplyFormatInEditMode = true)]
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


        public string ClienteEmail { get; set; }

        public string ClienteCel { get; set; }
        public string ClienteEnd { get; set; }
    }
}
