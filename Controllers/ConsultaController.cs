using GestaoEstoque.Models;
using GestaoEstoque.Repos;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GestaoEstoque.Controllers
{
    public class ConsultaController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ConsultaController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public IActionResult ConsultaEstoqueView()
        {
            List<ProdutoModel> produto = _produtoRepositorio.BuscarTudo();
            return View(produto);
        }

        public IActionResult ConsultaAvancadaView()
        {
            List<ProdutoModel> produto = _produtoRepositorio.BuscarFiltroDescricao();
            return View(produto);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}