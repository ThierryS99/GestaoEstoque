using GestaoEstoque.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GestaoEstoque.Controllers
{
    public class EditarController : Controller
    {
        private readonly ILogger<EditarController> _logger;

        public EditarController(ILogger<EditarController> logger)
        {
            _logger = logger;
        }

        public IActionResult EditarProdutoView()
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