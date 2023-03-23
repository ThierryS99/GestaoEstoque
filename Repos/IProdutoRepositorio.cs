using GestaoEstoque.Models;

namespace GestaoEstoque.Repos
{
    public interface IProdutoRepositorio
    {
        ProdutoModel Adicionar(ProdutoModel produto);
    }
}
