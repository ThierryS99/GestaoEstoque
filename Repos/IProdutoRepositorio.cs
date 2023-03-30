using GestaoEstoque.Models;

namespace GestaoEstoque.Repos
{
    public interface IProdutoRepositorio
    {
        ProdutoModel ListarPorId(int id);
        List<ProdutoModel> BuscarTudo();
        ProdutoModel Adicionar(ProdutoModel produto);
        ProdutoModel Editar(ProdutoModel produto);
        bool Excluir(int id);
    }
}
