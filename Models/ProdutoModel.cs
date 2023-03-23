﻿using System.ComponentModel.DataAnnotations;


namespace GestaoEstoque.Models
{
    public class ProdutoModel
    {
        [Key]
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public double? Quantidade { get; set; }
        public double? PrecoUnit { get; set; }
        public string? Locacao { get; set; }

        public ProdutoModel() { }


    }
}