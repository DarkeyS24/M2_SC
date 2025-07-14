using M2_SC.Models;
using M2_SC.Sessao2;

namespace M2_SC
{
    public partial class CadastroForm : Form
    {
        private Form1 form;
        private AppContextDB context;

        public CadastroForm()
        {
            InitializeComponent();
            List<string> strings = new List<string>
            {
                "Cliente",
                "Fornecedor"
            };
            perfilCb.DataSource = strings;
        }

        public void SetPrevForm(Form1 form)
        {
            this.form = form;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.form.DisableFields(true);
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!IsFieldEmpty())
            {
                    long CNPJ, CPF, tel;
                    if (perfilCb.SelectedItem.ToString() == "Fornecedor")
                    {
                        try
                        {
                            CNPJ = long.Parse(documentoTxt.Text);
                            try
                            {
                                tel = long.Parse(telTxt.Text);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Telefone Invalido, só são permitidos numeros");
                                return;
                            }
                            var fornecedor = context.Fornecedors.FirstOrDefault(f => f.Cnpj == documentoTxt.Text);
                            if (fornecedor != null)
                            {
                                MessageBox.Show("CNPJ já cadastrado, por favor verifique o CNPJ e tente novamente.");
                                return;
                            }
                            else
                            {
                                Pessoa pessoa = new Pessoa
                                {
                                    Nome = nomeTxt.Text,
                                    Telefone = telTxt.Text,
                                };

                                context.Pessoas.Add(pessoa);
                                context.SaveChanges();

                                context.Usuarios.Add(new Usuario
                                {
                                    Login = userTxt.Text,
                                    SenhaHash = pswdTxt.Text,
                                    Perfil = perfilCb.SelectedItem.ToString(),
                                    PessoaId = pessoa.Id,
                                    Pessoa = pessoa
                                });
                                context.Fornecedors.Add(new Fornecedor
                                {
                                    RazaoSocial = socialTxt.Text,
                                    Cnpj = documentoTxt.Text,
                                    PessoaId = pessoa.Id,
                                    Pessoa = pessoa
                                });
                                context.SaveChanges();
                                MessageBox.Show("Cadastro realizado com sucesso!");
                            }
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("CNPJ Invalido, só são permitidos numeros");
                        }
                    }
                    else
                    {
                        try
                        {
                            CPF = long.Parse(documentoTxt.Text);
                            try
                            {
                                tel = long.Parse(telTxt.Text);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Telefone Invalido, só são permitidos numeros");
                                return;
                            }
                            var cliente = context.Clientes.FirstOrDefault(f => f.Cpf == documentoTxt.Text);
                            if (cliente != null)
                            {
                                MessageBox.Show("CPF já cadastrado, por favor verifique o CPF e tente novamente.");
                                return;
                            }
                            else
                            {
                                Pessoa pessoa = new Pessoa
                                {
                                    Nome = nomeTxt.Text,
                                    Telefone = telTxt.Text,
                                };

                                context.Pessoas.Add(pessoa);
                                context.SaveChanges();

                                context.Usuarios.Add(new Usuario
                                {
                                    Login = userTxt.Text,
                                    SenhaHash = pswdTxt.Text,
                                    Perfil = perfilCb.SelectedItem.ToString(),
                                    PessoaId = pessoa.Id,
                                    Pessoa = pessoa
                                });
                                context.Clientes.Add(new Cliente
                                {
                                    DataNascimento = DateOnly.FromDateTime(nascPicker.Value),
                                    Cpf = documentoTxt.Text,
                                    PessoaId = pessoa.Id,
                                    Pessoa = pessoa
                                });
                                context.SaveChanges();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("CPF Invalido, só são permitidos numeros");
                        }
                    }
            }
        }

        private void ClearFields()
        {
            nomeTxt.Clear();
            socialTxt.Clear();
            documentoTxt.Clear();
            telTxt.Clear();
            userTxt.Clear();
            pswdTxt.Clear();
            rePswdTxt.Clear();
            nascPicker.Value = DateTime.Now;
        }

        private bool IsFieldEmpty()
        {
            if (perfilCb.SelectedItem.ToString() == "Fornecedor")
            {
                if (string.IsNullOrEmpty(nomeTxt.Text))
                {
                    MessageBox.Show("Por favor, insira o nome.");
                    return true;
                }
                else if (string.IsNullOrEmpty(socialTxt.Text))
                {
                    MessageBox.Show("Por favor, insira a razâo social.");
                    return true;
                }
                else if (string.IsNullOrEmpty(documentoTxt.Text))
                {
                    MessageBox.Show("Por favor, insira o seu CNPJ");
                    return true;
                }
                else if (documentoTxt.Text.Length != 14)
                {
                    MessageBox.Show("CNPJ Invalido, tem mais ou menos de 14 caracteres");
                    return true;
                }
                else if (string.IsNullOrEmpty(telTxt.Text))
                {
                    MessageBox.Show("Por favor, insira o telefone.");
                    return true;
                }
                else if (string.IsNullOrEmpty(userTxt.Text))
                {
                    MessageBox.Show("Por favor, insira o usuario.");
                    return true;
                }
                else if (string.IsNullOrEmpty(pswdTxt.Text))
                {
                    MessageBox.Show("Por favor, insira a senha.");
                    return true;
                }
                else if (string.IsNullOrEmpty(rePswdTxt.Text))
                {
                    MessageBox.Show("Por favor, insira a senha novamente.");
                    return true;
                }
                else if (pswdTxt.Text != rePswdTxt.Text)
                {
                    MessageBox.Show("As senhas nâo conferem. Por favor, tente novamente.");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(nomeTxt.Text))
                {
                    MessageBox.Show("Por favor, insira o nome.");
                    return true;
                }
                else if (nascPicker.Value.AddYears(18) > DateTime.Now)
                {
                    MessageBox.Show("Usuario menor de 18 anos, não é possivel fazer o cadastro");
                    return true;
                }
                else if (string.IsNullOrEmpty(documentoTxt.Text))
                {
                    MessageBox.Show("Por favor, insira o seu CPF");
                    return true;
                }
                else if (documentoTxt.Text.Length != 11)
                {
                    MessageBox.Show("CPF Invalido, tem mais ou menos de 11 caracteres");
                    return true;
                }
                else if (string.IsNullOrEmpty(telTxt.Text))
                {
                    MessageBox.Show("Por favor, insira o telefone.");
                    return true;
                }
                else if (string.IsNullOrEmpty(userTxt.Text))
                {
                    MessageBox.Show("Por favor, insira o usuario.");
                    return true;
                }
                else if (string.IsNullOrEmpty(pswdTxt.Text))
                {
                    MessageBox.Show("Por favor, insira a senha.");
                    return true;
                }
                else if (string.IsNullOrEmpty(rePswdTxt.Text))
                {
                    MessageBox.Show("Por favor, insira a senha novamente.");
                    return true;
                }
                else if (pswdTxt.Text != rePswdTxt.Text)
                {
                    MessageBox.Show("As senhas nâo conferem. Por favor, tente novamente.");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void perfilCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (perfilCb.SelectedIndex == 0)
            {
                ClearFields();
                cpfLbl.Visible = true;
                cnpjLbl.Visible = false;

                nascLbl.Visible = true;
                nascPicker.Visible = true;
                socialTxt.Visible = false;
                socialLbl.Visible = false;
            }
            else
            {
                ClearFields();
                cpfLbl.Visible = false;
                cnpjLbl.Visible = true;

                nascLbl.Visible = false;
                nascPicker.Visible = false;
                socialTxt.Visible = true;
                socialLbl.Visible = true;
            }
        }
    }
}
