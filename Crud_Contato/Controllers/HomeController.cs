using Crud_Contato.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;

namespace Crud_Contato.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BancoDeDados _context;

        public HomeController(ILogger<HomeController> logger, BancoDeDados context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpPost("Login")]
        public IActionResult Login(string username, string password)
        {
            // Verificar se o usuário e a senha correspondem aos dados no banco de dados
            var user = _context.AdminUser.FirstOrDefault(u => u.Login == username && u.Senha == password);

            if (user != null)
                return RedirectToAction("Index", "Contatos");
            else
            {
                // Usuário não autenticado, retornar uma mensagem de erro
                ViewBag.ErrorMessage = "Usuário ou senha inválidos.";
                return RedirectToAction("AcessoNegado", "Home");
            }
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult AcessoNegado()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
