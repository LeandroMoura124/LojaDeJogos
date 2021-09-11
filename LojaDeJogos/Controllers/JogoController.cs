using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaDeJogos.Models;
using LojaDeJogos.Repositório;

namespace LojaDeJogos.Controllers
{
    public class JogoController : Controller
    {
        // GET: Jogo
        public ActionResult Jogo()
        {
            var jogo = new Jogo(); // aqui criamos o projeto
            return View(jogo); // Retornamos para a view dados
        }
        Ações ac = new Ações();

        [HttpPost]
        public ActionResult CadJogo(Jogo jogo)
        {
            ac.CadastrarJogos(jogo);
            return View(jogo);
        }

       
        public ActionResult ListarJogo()
        {
            var ExibirJogo = new Ações();
            var TodosJogo = ExibirJogo.ListarJogo();
            return View(TodosJogo);
        }

    }
}