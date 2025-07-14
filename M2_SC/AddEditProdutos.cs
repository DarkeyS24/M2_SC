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
    public partial class AddEditProdutos : Form
    {
        private int action;
        private ProdutosForm form;
        private Produto produto;
        private string type;
        private Fornecedor fornecedor;
        private AppContextDB newContext;

        public AddEditProdutos()
        {
            InitializeComponent();
            newContext = new AppContextDB();
            List<string> strings = new List<string> { "Medicamento", "Equipamento", "Higiene" };
            tipoCb.DataSource = strings;
        }

        public void SetAction(int action, Fornecedor fornecedor, ProdutosForm form)
        {
            this.action = action;
            this.form = form;
            this.fornecedor = fornecedor;

            if (action == 1)
            {
                this.Text = "Adicionar Produto";
            }
            else if (action == 2)
            {
                this.Text = "Editar Produto";
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            CloseTab();
        }

        public void SetEditFields(Produto produto)
        {
            this.produto = produto;
            tipoCb.SelectedItem = produto.Tipo;
            nomeTxt.Text = produto.Nome;
            descTxt.Text = produto.Descricao;
            validadePicker.Value = produto.Validade.ToDateTime(new TimeOnly(0, 0));
            valuePicker.Value = produto.Valor;
        }

        private void CloseTab()
        {
            var list = new List<Produto>();
            using (var context = new AppContextDB())
            {
                list = context.Produtos.Include(p => p.Fornecedor).Include(p => p.ProdutoSolicitacaos).Where(p => p.FornecedorId == fornecedor.Id).ToList();
            }
            form.SetValues(fornecedor, list);
            form.SetDGV();
            form.Enabled = true;
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(descTxt.Text))
                {
                    MessageBox.Show("Defina a descrição");
                    return;
                }
                else if (descTxt.Text.Length < 50 || descTxt.Text.Length > 200)
                {
                    MessageBox.Show("A descrição deve ter no mínimo 50 caracteres e no máximo 200");
                    return;
                }
                else if (validadePicker.Value <= DateTime.Now.AddDays(1))
                {
                    MessageBox.Show("A validade só deve ser uma data futura");
                    return;
                }
                else if (valuePicker.Value <= 0)
                {
                    MessageBox.Show("O valor do produto deve ser maior que zero");
                    return;
                }

                try { 
                    Produto produto;
                    if (action == 1)
                    {
                        produto = new Produto();
                        produto.Tipo = tipoCb.SelectedItem.ToString();
                        produto.Nome = nomeTxt.Text;
                        produto.Descricao = descTxt.Text;
                        produto.Validade = DateOnly.FromDateTime(validadePicker.Value);
                        produto.Valor = valuePicker.Value;
                        produto.DataHoraCadastro = DateTime.Now;
                        produto.Fornecedor = fornecedor;
                        produto.FornecedorId = fornecedor.Id;
                        newContext.Produtos.Add(produto);
                    }
                    else
                    {
                        produto = this.produto;
                        produto.Tipo = tipoCb.SelectedItem.ToString();
                        produto.Nome = nomeTxt.Text;
                        produto.Descricao = descTxt.Text;
                        produto.Validade = DateOnly.FromDateTime(validadePicker.Value);
                        produto.Valor = valuePicker.Value;
                        produto.DataHoraCadastro = DateTime.Now;
                        newContext.Produtos.Update(produto);
                    }


                    newContext.SaveChanges();
                    MessageBox.Show(action == 1 ? "Produto adicionado com sucesso!" : "Produto atualizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao {(action == 1 ? "adicionar" : "atualizar")} produto: {ex.Message}");
                }
            CloseTab();
        }
    }
}
