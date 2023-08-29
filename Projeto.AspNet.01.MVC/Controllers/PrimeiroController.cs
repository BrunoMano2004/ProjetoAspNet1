using Microsoft.AspNetCore.Mvc;
using Projeto.AspNet._01.MVC.Models;

namespace Projeto.AspNet._01.MVC.Controllers
{
    public class PrimeiroController : Controller
    {
        /*
        public string Index()
        {
            return "Olá Mundo Asp.Net";
        }

        public IActionResult Ola()
        {
            ViewBag.Message = "Tô começando a sacar como a coisa funciona!";
            return View();
        }
        */

        public IActionResult Credenciais()
        {
            Perfil infos = new Perfil();
            infos.Nome = "Zé Pequeno";
            infos.Idade = 22;
            infos.Endereco = "Cidade de Deus";
            return View(infos);
        }
    }
}
