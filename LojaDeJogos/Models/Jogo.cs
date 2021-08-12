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
        [Range(1, 10, ErrorMessage = "O código deve ter de 1 a 10 dígitos")]
        public ushort JogoCod { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string JogoNome { get; set; }

        [Required(ErrorMessage = "A versão do jogo é necessária.")]
        public int JogoVersao { get; set; }

        [Required(ErrorMessage = "Insira o desenvolvedor do jogo!")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Informe o desenvolvedor com no minímo 3 caracteres a 200.")]
        public string JogoDesenv { get; set; }

        [Required(ErrorMessage = "O gênero do jogo é necessário.")]
        public string JogoGen { get; set; }

        [Range(12, 100, ErrorMessage = "Idade permitida entre 12 a 100 anos!")]
        [Required(ErrorMessage = "Introduza a faixa etária recomendada.")]
        public int JogoFaixaEt { get; set; }
        

        [Required(ErrorMessage = "Informe a plataforma do jogo.")]
        public string JogoPlat { get; set; }

        [Range(1958, 2021, ErrorMessage = "O ano de lançamento do jogo parte de 1958 a 2021.")]
        [Required(ErrorMessage = "Insira o ano de lançamento do jogo.")]
        public int JogoAnoLanc { get; set; }

        public string JogoSinopse { get; set; }

    }
}