using System;
using System.Collections.Generic;

namespace M2_SC.Models;

public partial class Solicitacao
{
    public int Id { get; set; }

    public DateOnly Validade { get; set; }

    public string Tipo { get; set; } = null!;

    public DateTime DataHoraCadastro { get; set; }

    public int ClienteId { get; set; }

    public string Descricao { get; set; } = null!;

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual ICollection<ProdutoSolicitacao> ProdutoSolicitacaos { get; set; } = new List<ProdutoSolicitacao>();
}
