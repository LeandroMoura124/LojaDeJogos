using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaDeJogos.Models;
using LojaDeJogos.Repositório;


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
        Ações ac = new Ações();

        [HttpPost]
        public ActionResult CadCliente(Cliente cliente)
        {
            ac.CadastrarClientes(cliente);
            return View(cliente);
        }

        public ActionResult ListarCliente()
        {
            var ExibirClie = new Ações();
            var TodosClie = ExibirClie.ListarCliente();
            return View(TodosClie);
        }
    }
}