using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M2_SC.Models;
using M2_SC.Sessao2;
using Microsoft.EntityFrameworkCore;

namespace M2_SC
{
    public partial class SolicitacoesForm : UserControl
    {
        private Cliente cliente;
        private AppContextDB context;
        private List<Solicitacao> solicitacaoList;
        public SolicitacoesForm()
        {
            InitializeComponent();
            context = AppContextDB.GetAppContextDB();
            List<string> strings = new List<string> { "Medicamento", "Equipamento", "Higiene" };
            tipoCb.DataSource = strings;
        }

        public void SetValues(Cliente cliente, List<Solicitacao> list)
        {
            this.cliente = cliente;
                foreach (var item in list)
                {
                    item.ProdutoSolicitacaos = context.ProdutoSolicitacaos
                        .Include(ps => ps.Produto)
                        .Include(ps => ps.Solicitcao)
                        .Where(ps => ps.SolicitcaoId == item.Id)
                        .ToList();
                }
            solicitacaoList = list;
        }

        public void SetDGV()
        {
            dgvSolicitacoes.Rows.Clear();
            foreach (var solicitacao in solicitacaoList)
            {
                dgvSolicitacoes.Rows.Add(solicitacao.Id, solicitacao.Descricao, solicitacao.Tipo, solicitacao.ProdutoSolicitacaos.Sum(ps => ps.Produto.Valor), solicitacao.Validade, solicitacao.DataHoraCadastro);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bool pNome = string.IsNullOrEmpty(produtoTxt.Text);
            bool pTipo = string.IsNullOrEmpty(tipoCb.SelectedItem.ToString());
            List<Solicitacao> list = [];
                dgvSolicitacoes.Rows.Clear();
                if (pNome && pTipo)
                {
                    list = solicitacaoList.Where(s => s.Validade == DateOnly.FromDateTime(validadePicker.Value) && s.DataHoraCadastro == cadastroPicker.Value).ToList();
                    if (list.Count > 0)
                    {
                        foreach (var solicitacao in list)
                        {
                            dgvSolicitacoes.Rows.Add(solicitacao.Id, solicitacao.Descricao, solicitacao.Tipo, solicitacao.ProdutoSolicitacaos.Sum(ps => ps.Produto.Valor), solicitacao.Validade, solicitacao.DataHoraCadastro);
                        }
                    }
                }
                else if (!pNome && pTipo)
                {
                    list = solicitacaoList.Where(s => s.Descricao.Contains(produtoTxt.Text) && s.Validade == DateOnly.FromDateTime(validadePicker.Value) && s.DataHoraCadastro == cadastroPicker.Value).ToList();
                    if (list.Count > 0)
                    {
                        foreach (var solicitacao in list)
                        {
                            dgvSolicitacoes.Rows.Add(solicitacao.Id, solicitacao.Descricao, solicitacao.Tipo, solicitacao.ProdutoSolicitacaos.Sum(ps => ps.Produto.Valor), solicitacao.Validade, solicitacao.DataHoraCadastro);
                        }
                    }
                }
                else if (pNome && !pTipo)
                {
                    list = solicitacaoList.Where(s => s.Tipo == tipoCb.SelectedItem.ToString() && s.Validade == DateOnly.FromDateTime(validadePicker.Value) && s.DataHoraCadastro.Date == cadastroPicker.Value.Date).ToList();
                    if (list.Count > 0)
                    {
                        foreach (var solicitacao in list)
                        {
                            dgvSolicitacoes.Rows.Add(solicitacao.Id, solicitacao.Descricao, solicitacao.Tipo, solicitacao.ProdutoSolicitacaos.Sum(ps => ps.Produto.Valor), solicitacao.Validade, solicitacao.DataHoraCadastro);
                        }
                    }
                }
                else
                {
                    list = solicitacaoList.Where(s => s.Descricao.Contains(produtoTxt.Text) && s.Tipo == tipoCb.SelectedItem.ToString() && s.Validade == DateOnly.FromDateTime(validadePicker.Value) && s.DataHoraCadastro == cadastroPicker.Value).ToList();
                    if (list.Count > 0)
                    {
                        foreach (var solicitacao in list)
                        {
                            dgvSolicitacoes.Rows.Add(solicitacao.Id, solicitacao.Descricao, solicitacao.Tipo, solicitacao.ProdutoSolicitacaos.Sum(ps => ps.Produto.Valor), solicitacao.Validade, solicitacao.DataHoraCadastro);
                        }
                    }
                }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if(dgvSolicitacoes.SelectedRows.Count > 0)
            {
                AddEditSolicitacoes addEdit = new AddEditSolicitacoes();
                addEdit.SetAction(2, cliente, this);
                var row = dgvSolicitacoes.SelectedRows[0];
                List<Produto> produtos = [];
                Solicitacao solicitacao = new Solicitacao();
                    solicitacao = context.Solicitacaos.Include(s => s.Cliente).Include(s => s.ProdutoSolicitacaos).FirstOrDefault(s => s.Id == int.Parse(row.Cells[0].Value.ToString()));
                    foreach (var produto in solicitacao.ProdutoSolicitacaos)
                    {
                        var p = context.Produtos.Include(p => p.Fornecedor).Include(p => p.ProdutoSolicitacaos).FirstOrDefault(prod => prod.Id == produto.ProdutoId);
                        if (produto != null){
                            produtos.Add(p);
                        }
                    }
                addEdit.SetFieldsForEdit(solicitacao, produtos, solicitacao.ProdutoSolicitacaos.ElementAt(0).Produto.Tipo, solicitacao.Descricao, solicitacao.Validade);
                this.Enabled = false;
                addEdit.Show();
            }
        }

        private void novoBtn_Click(object sender, EventArgs e)
        {
            AddEditSolicitacoes addEdit = new AddEditSolicitacoes();
            addEdit.SetAction(1, cliente, this);
            this.Enabled = false;
            addEdit.Show();
        }
    }
}
