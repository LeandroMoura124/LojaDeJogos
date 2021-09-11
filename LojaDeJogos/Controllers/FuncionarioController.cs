using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaDeJogos.Models;
using LojaDeJogos.Repositório;

namespace LojaDeJogos.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Funcionario()
        {
            var funcionario = new Funcionario();
            return View(funcionario);
        }
        Ações ac = new Ações();

        [HttpPost]
        public ActionResult CadFuncionario(Funcionario funcionario)
        {
            ac.CadastrarFuncionario(funcionario);
            return View(funcionario);
        }

        public ActionResult ListarFuncionario()
        {
            var ExibirFunc = new Ações();
            var TodosFunc = ExibirFunc.ListarFuncionario();
            return View(TodosFunc);
        }
    }
}