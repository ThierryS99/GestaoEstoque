using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GestaoEstoque.Models
{
    public class ProdutoModel
    {
        [Key]
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public string? Marca { get; set; }
        public string? Fornecedor { get; set; }
        public double? Quantidade { get; set; }
        public double? PrecoUnit { get; set; }
        public string? Locacao { get; set; }

        public ProdutoModel()
        {
        }


    }
}
