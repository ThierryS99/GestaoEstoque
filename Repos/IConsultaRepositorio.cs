using GestaoEstoque.Models;

namespace GestaoEstoque.Repos
{
    public interface IConsultaRepositorio
    {
        List<ProdutoModel> BuscarTodos();
    }
}
