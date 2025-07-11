using System;
using System.Collections.Generic;

namespace M2_SC.Models;

public partial class Produto
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public int FornecedorId { get; set; }

    public string? Descricao { get; set; }

    public DateOnly Validade { get; set; }

    public DateTime DataHoraCadastro { get; set; }

    public decimal Valor { get; set; }

    public virtual ICollection<AtendimentoProduto> AtendimentoProdutos { get; set; } = new List<AtendimentoProduto>();

    public virtual Fornecedor Fornecedor { get; set; } = null!;

    public virtual ICollection<ProdutoSolicitacao> ProdutoSolicitacaos { get; set; } = new List<ProdutoSolicitacao>();
}
