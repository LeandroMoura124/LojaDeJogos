using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaDeJogos.Models
{
    public class Jogo : Controller
    {
        // GET: Jogo
        public ushort JogoCod { get; set; }
        public string JogoNome { get; set; }
        public int JogoVersao { get; set; }
        public string JogoDesenv { get; set; }
        public string JogoGen { get; set; }
        public int JogoFaixaEt { get; set; }
        public string JogoPlat { get; set; }
        public int JogoAnoLanc { get; set; }

    }
}