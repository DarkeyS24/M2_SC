﻿using System;
using System.Collections.Generic;

namespace M2_SC.Models;

public partial class Fornecedor
{
    public int Id { get; set; }

    public int PessoaId { get; set; }

    public string RazaoSocial { get; set; } = null!;

    public string Cnpj { get; set; } = null!;

    public virtual Pessoa Pessoa { get; set; } = null!;

    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
