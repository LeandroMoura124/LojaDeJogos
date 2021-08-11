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

        [Required(ErrorMessage = "O nome do cliente é obrigatório!")]
        public string ClienteNome { get; set; }

        [StringLength(12, MinimumLength = 9, ErrorMessage = "CPF incompleto ou inválido." )]
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

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido.")]
        public string ClienteEmail { get; set; }

        public string ClienteCel { get; set; }

        [StringLength(100, MinimumLength = 10, ErrorMessage = "Informe seu endereço completo.")]
        public string ClienteEnd { get; set; }
    }
}
