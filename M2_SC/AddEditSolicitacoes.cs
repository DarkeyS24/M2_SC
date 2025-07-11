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
    public partial class AddEditSolicitacoes : Form
    {
        private int action;
        private SolicitacoesForm form;
        private Solicitacao solicitacao;
        private string type;
        private Cliente cliente;
        public AddEditSolicitacoes()
        {
            InitializeComponent();
            List<string> tipos = new List<string> { "Medicamento", "Equipamento", "Higiene" };
            tipoCb.DataSource = tipos;
        }

        public void SetFieldsForEdit(Solicitacao solicitacao, List<Produto> produtos, string tipo, string desc, DateOnly validade)
        {
            this.solicitacao = solicitacao;
            dgvSolicitados.Rows.Clear();
            foreach (var produto in produtos)
            {
                Image image = Image.FromFile(@"C:\Users\angel_mata\source\repos\M2_SC\M2_SC\Images\PNG\16px\173-bin.png");
                dgvSolicitados.Rows.Add(produto.Nome, produto.Fornecedor.RazaoSocial, image);
            }
            this.type = tipo;
            tipoCb.SelectedItem = type;
            descTxt.Text = desc;
            validadePicker.Value = new DateTime(validade, new TimeOnly(0,0,0));
            CalculateValue();
        }

        public void SetAction(int action, Cliente cliente, SolicitacoesForm form)
        {
            this.action = action;
            this.form = form;
            this.cliente = cliente;

            if (action == 1)
            {
                this.Text = "Adicionar Solicitação";
            }
            else if (action == 2)
            {
                this.Text = "Editar Solicitação";
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            List<Solicitacao> list = [];
            using (var context = new AppContextDB()) { list = context.Solicitacaos.Include(s => s.ProdutoSolicitacaos).Where(s => s.ClienteId == cliente.Id).ToList(); }
            form.SetValues(cliente, list);
            form.SetDGV();
            this.form.Enabled = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (CheckSolicitation())
            {
                using (var context = new AppContextDB())
                {
                    if (action == 1)
                    {
                        if (string.IsNullOrEmpty(descTxt.Text))
                        {
                            MessageBox.Show("Defina a descrição");
                            return;
                        }
                        else if (descTxt.Text.Length < 50 && descTxt.Text.Length > 200)
                        {
                            MessageBox.Show("A descrição deve ter no minimo 50 caracteres e no maximo 200");
                            return;
                        }
                        else if (validadePicker.Value < DateTime.Now.AddDays(15) && validadePicker.Value.Day % 5 != 0)
                        {
                            MessageBox.Show("A validade só deve ser uma data futura com no minimo 15 dias e o numero do sia deve ser multiplo de 5 Ex.(5, 10, 15)");
                            return;
                        } else
                        {
                            var solicitacao = new Solicitacao
                            {
                                Descricao = descTxt.Text,
                                Tipo = type,
                                ClienteId = cliente.Id,
                                DataHoraCadastro = DateTime.Now,
                                Validade = DateOnly.FromDateTime(validadePicker.Value)
                            };
                            context.Solicitacaos.Add(solicitacao);
                            context.SaveChanges();
                            foreach (DataGridViewRow row in dgvSolicitados.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    var produtoNome = row.Cells[0].Value.ToString();
                                    var fornecedorRazaoSocial = row.Cells[1].Value.ToString();
                                    var produto = context.Produtos.Include(p => p.Fornecedor).FirstOrDefault(p => p.Nome == produtoNome && p.Fornecedor.RazaoSocial == fornecedorRazaoSocial);

                                    if (produto != null)
                                    {
                                        var produtoSolicitacao = new ProdutoSolicitacao
                                        {
                                            ProdutoId = produto.Id,
                                            SolicitcaoId = solicitacao.Id
                                        };
                                        context.ProdutoSolicitacaos.Add(produtoSolicitacao);
                                    }
                                }
                            }
                            context.SaveChanges();
                            MessageBox.Show("Solicitação adicionada com sucesso!");
                        }
                    }
                    else if (action == 2)
                    {
                        if (string.IsNullOrEmpty(descTxt.Text))
                        {
                            MessageBox.Show("Defina a descrição");
                            return;
                        }
                        else if (descTxt.Text.Length < 50 && descTxt.Text.Length > 200)
                        {
                            MessageBox.Show("A descrição deve ter no minimo 50 caracteres e no maximo 200");
                            return;
                        }
                        else if (validadePicker.Value < DateTime.Now.AddDays(15) && validadePicker.Value.Day % 5 != 0)
                        {
                            MessageBox.Show("A validade só deve ser uma data futura com no minimo 15 dias e o numero do sia deve ser multiplo de 5 Ex.(5, 10, 15)");
                            return;
                        }
                        else
                        {
                            solicitacao.Descricao = descTxt.Text;
                            solicitacao.Tipo = type;
                            solicitacao.ClienteId = cliente.Id;
                            solicitacao.DataHoraCadastro = DateTime.Now;
                            solicitacao.Validade = DateOnly.FromDateTime(validadePicker.Value);

                            context.Solicitacaos.Update(solicitacao);
                            context.SaveChanges();
                            context.ProdutoSolicitacaos.RemoveRange(context.ProdutoSolicitacaos.Include(ps => ps.Produto).Include(ps => ps.Solicitcao).Where(ps => ps.SolicitcaoId == solicitacao.Id).ToList());
                            foreach (DataGridViewRow row in dgvSolicitados.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    var produtoNome = row.Cells[0].Value.ToString();
                                    var fornecedorRazaoSocial = row.Cells[1].Value.ToString();
                                    var produto = context.Produtos.Include(p => p.Fornecedor).FirstOrDefault(p => p.Nome == produtoNome && p.Fornecedor.RazaoSocial == fornecedorRazaoSocial);

                                    if (produto != null)
                                    {
                                        var produtoSolicitacao = new ProdutoSolicitacao
                                        {
                                            ProdutoId = produto.Id,
                                            SolicitcaoId = solicitacao.Id
                                        };
                                        context.ProdutoSolicitacaos.Add(produtoSolicitacao);
                                    }
                                }
                            }
                            context.SaveChanges();
                            MessageBox.Show("Solicitação atualizada com sucesso!");
                        }
                    }
                }
                form.Enabled = true;
                var list = new List<Solicitacao>();
                using (var context = new AppContextDB()) { list = context.Solicitacaos.Include(s => s.ProdutoSolicitacaos).Where(s => s.ClienteId == cliente.Id).ToList(); }
                form.SetValues(cliente, list);
                form.SetDGV();
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, adicione pelo menos um produto à solicitação.");
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var list = new List<Produto>();
            using (var context = new AppContextDB())
            {
                if (string.IsNullOrEmpty(nomeTxt.Text))
                {
                    list = context.Produtos.Include(p => p.Fornecedor).Include(p => p.ProdutoSolicitacaos).Where(p => p.Tipo == tipoCb.SelectedItem.ToString()).ToList();
                    dgvPesquisados.Rows.Clear();
                    if(list.Count > 0)
                    {
                        foreach (var item in list)
                        {
                            dgvPesquisados.Rows.Add(item.Nome, item.Fornecedor.RazaoSocial);
                        }
                    }
                }
                else
                {
                    list = context.Produtos.Include(p => p.Fornecedor).Include(p => p.ProdutoSolicitacaos)
                        .Where(p => p.Nome.Contains(nomeTxt.Text) && p.Tipo == tipoCb.SelectedItem.ToString()).ToList();
                    dgvPesquisados.Rows.Clear();
                    if (list.Count > 0)
                    {
                        foreach (var item in list)
                        {
                            dgvPesquisados.Rows.Add(item.Nome, item.Fornecedor.RazaoSocial);
                        }
                    }
                }
            }
        }

        private bool CheckSolicitation()
        {
            using (var context = new AppContextDB())
            {
                var rows = dgvSolicitados.Rows;
                List<bool> list = [];
                foreach (DataGridViewRow row in rows)
                {
                    if (row.IsNewRow)
                    {
                        list.Add(false);
                    }else if (row.Cells[0].Value == null)
                    {
                        list.Add(false);
                    }
                    else
                    {
                        list.Add(true);
                    }
                }
                return list.Any(l => l == true);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using (var context = new AppContextDB())
            {
                if (dgvPesquisados.SelectedRows.Count > 0)
                {
                    var row = dgvPesquisados.SelectedRows[0];
                    var produto = context.Produtos.Include(p => p.Fornecedor).FirstOrDefault(p => p.Nome == row.Cells[0].Value.ToString() && p.Fornecedor.RazaoSocial == row.Cells[1].Value.ToString());
                    Image image = Image.FromFile(@"C:\Users\angel_mata\source\repos\M2_SC\M2_SC\Images\PNG\16px\173-bin.png");
                    if (!CheckSolicitation())
                    {
                        dgvSolicitados.Rows.Add(produto.Nome, produto.Fornecedor.RazaoSocial, image);
                        if (string.IsNullOrEmpty(type))
                        {
                            type = produto.Tipo;
                        }
                    }
                    else
                    {
                        if (produto.Tipo != type)
                        {
                            MessageBox.Show("Você não pode adicionar produtos de tipos diferentes em uma mesma solicitação.");  
                        }
                        else
                        {
                            dgvSolicitados.Rows.Add(produto.Nome, produto.Fornecedor.RazaoSocial, image);
                        }
                    }
                    CalculateValue();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um produto da lista.");
                }
            }
        }

        private void dgvSolicitados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (e.RowIndex >= 0)
                {
                    dgvSolicitados.Rows.RemoveAt(e.RowIndex);
                    CalculateValue();
                }
            }
        }

        private void CalculateValue()
        {
            var rows = dgvSolicitados.Rows;
            var value = 0;
            using (var context = new AppContextDB())
            {
                foreach (DataGridViewRow item in rows)
                {
                    if (!item.IsNewRow)
                    {
                        var produto = context.Produtos.FirstOrDefault(p => p.Nome == item.Cells[0].Value.ToString() && p.Fornecedor.RazaoSocial == item.Cells[1].Value.ToString());
                        if (produto != null)
                        {
                            value += (int)produto.Valor;
                        }
                    }
                }
            }
            valueLbl.Text = $"{value}";
        }
    }
}
