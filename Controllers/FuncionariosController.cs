using Projeto_Teste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto_Teste.Controllers
{
    public class FuncionariosController : Controller
    {
        public ActionResult Index()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            Funcao funcao = new Funcao(1, "Programador");

            Funcionario f = new Funcionario() 
            { 
                Nome = "Everton",
                Funcao = funcao,
                Dependentes = new List<Dependente>()
                { new Dependente
                    {
                        Nome = "Suelen",
                        Parentesco = enumParentesco.conjuge
                    },
                  new Dependente
                  {
                      Nome = "Miguel",
                      Parentesco = enumParentesco.filho_filha
                  }
                }
            };

            Funcionario f2 = new Funcionario()
            {
                Nome = "Negão",
                Funcao = funcao
            };

            funcionarios.Add(f);
            funcionarios.Add(f2);

            return View(funcionarios);
        }

        [HttpGet]
        public ActionResult Edit()
        {
            Funcionario funcionario = new Funcionario() { Nome = "Everton" };
            return View(funcionario);
        }


        [HttpPost]
        public ActionResult Edit(Funcionario funcionario)
        {
            string nome = Request["Nome"];

            return RedirectToAction("Index");
        }


    }
}