using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaDeJogos.Models;

namespace LojaDeJogos.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Cliente()
        {
            var cliente = new Cliente(); // aqui criamos o projeto
            return View(cliente); // Retornamos para a view dados
        }
        [HttpPost]
        public ActionResult Cliente(Cliente cliente)
        {
            if (ModelState.IsValid) // Validamos o estado
            {
                return View("ClienteResultado", cliente);
            }
            return View(cliente);
        }
    }
}