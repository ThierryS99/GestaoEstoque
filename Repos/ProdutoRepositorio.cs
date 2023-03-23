using GestaoEstoque.Data;
using GestaoEstoque.Models;

namespace GestaoEstoque.Repos
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ProdutoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;

        }

        public List<ProdutoModel> BuscarTodos()
        {
            return _bancoContext.Produto.ToList();
        }

        public ProdutoModel Adicionar(ProdutoModel produto)
        {
            _bancoContext.Produto.Add(produto);
            _bancoContext.SaveChanges();
            return produto;
        }
    }
}
