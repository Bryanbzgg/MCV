using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {

            Aluno a1 = new Aluno(1, "manojotajota", "éujotajota@gmail.co", 34564322);
            Aluno a2 = new Aluno(2, "manorato", "éuratojoga@gmail.co", 98765434);
            Aluno a3 = new Aluno(3, "cleitorasta", "gigantecleito@gmail.co", 56378293);
            Aluno a4 = new Aluno(4, "shereki", "oshereki@gmail.co", 92375489);
            Aluno a5 = new Aluno(5, "carlindolavas", "lavajato@gmail.co", 87564372);



            return View();
        }

        //criando novo controlador
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
