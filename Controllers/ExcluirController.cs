using GestaoEstoque.Models;
using GestaoEstoque.Repos;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GestaoEstoque.Controllers
{
    public class ExcluirController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ExcluirController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public IActionResult ExcluirProdutoView(int id)
        {
            ProdutoModel produto = _produtoRepositorio.ListarPorId(id);
            return View(produto);
        }

        public IActionResult ConfirmarExclusao(int id)
        {
            _produtoRepositorio.Excluir(id);
            
            return RedirectToAction("ConfirmacaoExclusaoView");
        }

        public IActionResult ConfirmacaoExclusaoView()
        {
            return View();
        }
    }
}