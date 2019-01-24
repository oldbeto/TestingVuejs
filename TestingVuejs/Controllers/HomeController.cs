using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestingVuejs.Models;

namespace TestingVuejs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Pessoa pessoa = new Pessoa()
            {
                Nome = "Roberto",
                Idade = 14,
                Cursos = new string[]
                {"HTML",
                "CSS",
                "JQuery",
                "Bootstrap",
                "Vue",
                "Vuetify",
                "Angular",
                "MongoDB",
                "GraphSQL",
                "Node" },
            };

            return View(pessoa);
        }
    }
}