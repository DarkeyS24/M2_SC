using M2_SC.Sessao2;
using Microsoft.EntityFrameworkCore;

namespace M2_SC
{
    public partial class Form1 : Form
    {
        private AppContextDB context;
        public Form1()
        {
            InitializeComponent();
            context = AppContextDB.GetAppContextDB();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastroForm cadastro = new CadastroForm();
            DisableFields(false);
            cadastro.SetPrevForm(this);
            cadastro.Show();
        }

        public void DisableFields(bool value)
        {
            pswdTxt.Enabled = value;
            userTxt.Enabled = value;
            entrarBtn.Enabled = value;
            cadastroLink.Enabled = value;
        }

        private void LoginAction()
        {
            if (string.IsNullOrEmpty(userTxt.Text))
            {
                MessageBox.Show("Por favor, insira o usuário.");
            }
            else if (string.IsNullOrEmpty(pswdTxt.Text))
            {
                MessageBox.Show("Por favor, insira a senha.");
            }
            else
            {
                    var user = context.Usuarios.FirstOrDefault(u => u.Login == userTxt.Text && u.SenhaHash == pswdTxt.Text);
                    if (user != null)
                    {
                        if (user.Perfil == "Cliente")
                        {
                            var cliente = context.Clientes.FirstOrDefault(c => c.PessoaId == user.PessoaId);
                            var list = context.Solicitacaos.Include(s => s.ProdutoSolicitacaos).Where(s => s.ClienteId == cliente.Id).ToList();
                            solicitacoesForm1.Visible = true;
                            solicitacoesForm1.SetValues(cliente, list);
                            solicitacoesForm1.SetDGV();
                            DisableFields(false);
                        }
                        else if (user.Perfil == "Fornecedor")
                        {
                            var fornecedor = context.Fornecedors.FirstOrDefault(c => c.PessoaId == user.PessoaId);
                            var list = context.Produtos.Include(f => f.ProdutoSolicitacaos).Include(p => p.Fornecedor).Where(s => s.FornecedorId == fornecedor.Id).ToList();
                            produtosForm1.Visible = true;
                            produtosForm1.SetValues(fornecedor, list);
                            produtosForm1.SetDGV();
                            produtosForm1.Visible = true;
                            DisableFields(false);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos. Tente novamente.");
                        userTxt.Clear();
                        pswdTxt.Clear();
                        userTxt.Focus();
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginAction();
        }

        private void pswdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                LoginAction();
            }
        }
    }
}
