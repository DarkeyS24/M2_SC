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
    public partial class ProdutosForm : UserControl
    {
        private Fornecedor fornecedor;
        private List<Produto> produtosList;
        private AppContextDB context;

        public ProdutosForm()
        {
            InitializeComponent();
            context = AppContextDB.GetAppContextDB();
        }

        public void SetValues(Fornecedor fornecedor, List<Produto> list)
        {
            this.fornecedor = fornecedor;
                foreach (var item in list)
                {
                    item.ProdutoSolicitacaos = context.ProdutoSolicitacaos
                        .Include(ps => ps.Produto)
                        .Include(ps => ps.Solicitcao)
                        .Where(ps => ps.ProdutoId == item.Id)
                        .ToList();
                }
            produtosList = list;
        }

        public void SetDGV()
        {
            dgvProdutos.Rows.Clear();
            foreach (var produto in produtosList)
            {
                dgvProdutos.Rows.Add(produto.Nome, produto.Tipo, produto.Validade, produto.DataHoraCadastro);
            }
        }

        private void novoBtn_Click(object sender, EventArgs e)
        {
            AddEditProdutos addEdit = new AddEditProdutos();
            addEdit.SetAction(1, fornecedor, this);
            addEdit.Show();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            AddEditProdutos addEdit = new AddEditProdutos();
            addEdit.SetAction(2, fornecedor, this);
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                var row = dgvProdutos.SelectedRows[0];
                    Produto? produto = context.Produtos.AsNoTracking().FirstOrDefault(p =>
                    p.Nome == row.Cells[0].Value.ToString() &&
                    p.Tipo == row.Cells[1].Value.ToString() &&
                    p.Fornecedor.RazaoSocial == fornecedor.RazaoSocial);
                    if (produto != null)
                    {
                        addEdit.SetEditFields(produto);
                    }
                    addEdit.Show();
            }
        }
    }
}
