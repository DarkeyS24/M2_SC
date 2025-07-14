using System;
using System.Collections.Generic;
using M2_SC.Models;
using Microsoft.EntityFrameworkCore;

namespace M2_SC.Sessao2;

public partial class AppContextDB : DbContext
{
    public AppContextDB(){}

    private static AppContextDB? contextDB;
    public static AppContextDB GetAppContextDB()
    {
        if (contextDB == null)
        {
            contextDB = new AppContextDB();
        }
        return contextDB;
    }

    public AppContextDB(DbContextOptions<AppContextDB> options) :base(options){}

    public virtual DbSet<Atendimento> Atendimentos { get; set; }

    public virtual DbSet<AtendimentoProduto> AtendimentoProdutos { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Endereco> Enderecos { get; set; }

    public virtual DbSet<Fornecedor> Fornecedors { get; set; }

    public virtual DbSet<Pessoa> Pessoas { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    public virtual DbSet<ProdutoSolicitacao> ProdutoSolicitacaos { get; set; }

    public virtual DbSet<Profissional> Profissionals { get; set; }

    public virtual DbSet<Servico> Servicos { get; set; }

    public virtual DbSet<Solicitacao> Solicitacaos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=Sessao2;User Id=sa;Password=sql;TrustServerCertificate=true;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Atendimento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Id");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.ToTable("Atendimento");

            entity.Property(e => e.DataAgendada).HasColumnType("datetime");
            entity.Property(e => e.Observacoes).HasColumnType("text");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Cliente).WithMany(p => p.Atendimentos)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.Profissional).WithMany(p => p.Atendimentos)
                .HasForeignKey(d => d.ProfissionalId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.Servico).WithMany(p => p.Atendimentos)
                .HasForeignKey(d => d.ServicoId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<AtendimentoProduto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Id");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.ToTable("AtendimentoProduto");

            entity.HasOne(d => d.Atendimento).WithMany(p => p.AtendimentoProdutos)
                .HasForeignKey(d => d.AtendimentoId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.Produto).WithMany(p => p.AtendimentoProdutos)
                .HasForeignKey(d => d.ProdutoId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Id");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.ToTable("Cliente");

            entity.HasIndex(e => e.PessoaId, "UQ__Cliente__2F5F55D317B9A43E").IsUnique();

            entity.HasIndex(e => e.Cpf, "UQ__Cliente__C1F897316628B85C").IsUnique();

            entity.Property(e => e.Cpf)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CPF");

            entity.HasOne(d => d.Pessoa).WithOne(p => p.Cliente)
                .HasForeignKey<Cliente>(d => d.PessoaId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.Responsavel).WithMany(p => p.InverseResponsavel)
                .HasForeignKey(d => d.ResponsavelId);
        });

        modelBuilder.Entity<Endereco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Id");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.ToTable("Endereco");

            entity.Property(e => e.Bairro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cep)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CEP");
            entity.Property(e => e.Cidade)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Complemento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Logradouro)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TipoEndereco)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Pessoa).WithMany(p => p.Enderecos)
                .HasForeignKey(d => d.PessoaId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Fornecedor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Id");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.ToTable("Fornecedor");

            entity.HasIndex(e => e.PessoaId, "UQ__Forneced__2F5F55D34C359701").IsUnique();

            entity.HasIndex(e => e.Cnpj, "UQ__Forneced__AA57D6B43462AF13").IsUnique();

            entity.Property(e => e.Cnpj)
                .HasMaxLength(14)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CNPJ");
            entity.Property(e => e.RazaoSocial)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Pessoa).WithOne(p => p.Fornecedor)
                .HasForeignKey<Fornecedor>(d => d.PessoaId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Pessoa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Id");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.ToTable("Pessoa");

            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefone)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Id");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.ToTable("Produto");

            entity.Property(e => e.DataHoraCadastro).HasColumnType("datetime");
            entity.Property(e => e.Descricao)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Valor).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Fornecedor).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.FornecedorId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<ProdutoSolicitacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Id");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.ToTable("ProdutoSolicitacao");

            entity.HasOne(d => d.Produto).WithMany(p => p.ProdutoSolicitacaos)
                .HasForeignKey(d => d.ProdutoId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.Solicitcao).WithMany(p => p.ProdutoSolicitacaos)
                .HasForeignKey(d => d.SolicitcaoId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Profissional>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Id");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.ToTable("Profissional");

            entity.HasIndex(e => e.PessoaId, "UQ__Profissi__2F5F55D35776C3CF").IsUnique();

            entity.HasIndex(e => e.Cpf, "UQ__Profissi__C1F89731A780EDFC").IsUnique();

            entity.Property(e => e.ConselhoRegistro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cpf)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CPF");
            entity.Property(e => e.TipoProfissional)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Pessoa).WithOne(p => p.Profissional)
                .HasForeignKey<Profissional>(d => d.PessoaId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Servico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Id");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.ToTable("Servico");

            entity.Property(e => e.Descricao).HasColumnType("text");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PrecoBase).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<Solicitacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Id");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.ToTable("Solicitacao");

            entity.Property(e => e.DataHoraCadastro).HasColumnType("datetime");
            entity.Property(e => e.Descricao)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Cliente).WithMany(p => p.Solicitacaos)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Id");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.ToTable("Usuario");

            entity.HasIndex(e => e.PessoaId, "UQ__Usuario__2F5F55D3162E67D3").IsUnique();

            entity.HasIndex(e => e.Login, "UQ__Usuario__5E55825B791416B8").IsUnique();

            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Perfil)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SenhaHash)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Pessoa).WithOne(p => p.Usuario)
                .HasForeignKey<Usuario>(d => d.PessoaId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
