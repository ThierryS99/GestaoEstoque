using GestaoEstoque.Models;
using GestaoEstoque.Repos;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GestaoEstoque.Controllers
{
    public class EditarController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public EditarController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public IActionResult EditarProdutoView(int id)
        {
            ProdutoModel produto = _produtoRepositorio.ListarPorId(id);
            return View(produto);
        }

        [HttpPost]
        public IActionResult EditarProdutoView(ProdutoModel produto)
        {
            _produtoRepositorio.Editar(produto);
            return RedirectToAction("EditarProdutoView");
        }

        public IActionResult EditarQuantidadeView(int id)
        {
            ProdutoModel produto = _produtoRepositorio.ListarPorId(id);
            return View(produto);
        }

        [HttpPost]
        public IActionResult EditarQuantidadeView(ProdutoModel produto)
        {
            _produtoRepositorio.Editar(produto);
            return RedirectToAction("EditarQuantidadeView");
        }

    }
}