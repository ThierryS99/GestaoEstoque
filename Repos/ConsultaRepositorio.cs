using GestaoEstoque.Data;
using GestaoEstoque.Models;

namespace GestaoEstoque.Repos
{
    public class ConsultaRepositorio : IConsultaRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ConsultaRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;

        }

        public List<ProdutoModel> BuscarTodos()
        {
            return _bancoContext.Produto.ToList();
        }
    }
}
