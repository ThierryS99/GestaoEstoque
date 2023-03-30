using GestaoEstoque.Models;
using GestaoEstoque.Repos;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GestaoEstoque.Controllers
{
    public class CadastroController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public CadastroController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public IActionResult CadastroProdutoView()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult CadastroProdutoView(ProdutoModel produto)
        {
            _produtoRepositorio.Adicionar(produto);
            return RedirectToAction("CadastroProdutoView");
        }
        
    }
}