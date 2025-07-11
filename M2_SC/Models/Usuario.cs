using System;
using System.Collections.Generic;

namespace M2_SC.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public int PessoaId { get; set; }

    public string Login { get; set; } = null!;

    public string SenhaHash { get; set; } = null!;

    public string Perfil { get; set; } = null!;

    public virtual Pessoa Pessoa { get; set; } = null!;
}
