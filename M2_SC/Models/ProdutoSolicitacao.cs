using System;
using System.Collections.Generic;

namespace M2_SC.Models;

public partial class ProdutoSolicitacao
{
    public int Id { get; set; }

    public int SolicitcaoId { get; set; }

    public int ProdutoId { get; set; }

    public virtual Produto Produto { get; set; } = null!;

    public virtual Solicitacao Solicitcao { get; set; } = null!;
}
