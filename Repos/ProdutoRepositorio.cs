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

        public ProdutoModel Adicionar(ProdutoModel produto)
        {
            _bancoContext.Produto.Add(produto);
            _bancoContext.SaveChanges();
            return produto;
        }

        public List<ProdutoModel> BuscarTudo()
        {
            return _bancoContext.Produto.ToList();
        }

        public ProdutoModel ListarPorId(int id)
        {
            return _bancoContext.Produto.FirstOrDefault(x => x.Id == id);
        }

        public ProdutoModel Editar(ProdutoModel produto)
        {
            ProdutoModel produtoDb = ListarPorId(produto.Id);

            if (produtoDb == null) throw new SystemException("Não foi encontrado produto com este ID.");
            else
            {
                produtoDb.Descricao = produto.Descricao;
                produtoDb.Quantidade = produto.Quantidade;
                produtoDb.PrecoUnit = produto.PrecoUnit;
                produtoDb.Locacao = produto.Locacao;
                produtoDb.Fornecedor = produto.Fornecedor;
                produtoDb.Marca = produto.Marca;
            }

            _bancoContext.Produto.Update(produtoDb);
            _bancoContext.SaveChanges();
            return produtoDb;
        }

        public bool Excluir(int id)
        {
            ProdutoModel produtoDb = ListarPorId(id);

            if (produtoDb == null) throw new SystemException("Não foi encontrado produto com este ID.");
            else
            {
                _bancoContext.Produto.Remove(produtoDb);
                _bancoContext.SaveChanges();
                return true;
            }
        }
    }
}
