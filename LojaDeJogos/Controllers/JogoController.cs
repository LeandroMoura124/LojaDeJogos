using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaDeJogos.Models;

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
        [HttpPost]
        public ActionResult Jogo(Jogo jogo)
        {
            if (ModelState.IsValid) // Validamos o estado
            {
                return View("JogoResultado", jogo);
            }
            return View(jogo);
        }

    }
}