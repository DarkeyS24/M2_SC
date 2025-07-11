namespace M2_SC
{
    partial class SolicitacoesForm
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitacoesForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            produtoTxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tipoCb = new ComboBox();
            validadePicker = new DateTimePicker();
            cadastroPicker = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            searchPic = new PictureBox();
            dgvSolicitacoes = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            DescColumn = new DataGridViewTextBoxColumn();
            TipoColumn = new DataGridViewTextBoxColumn();
            ValorColumn = new DataGridViewTextBoxColumn();
            ValidadeColumn = new DataGridViewTextBoxColumn();
            CadastroColumn = new DataGridViewTextBoxColumn();
            novoBtn = new Button();
            editBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitacoes).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gold;
            pictureBox1.Location = new Point(13, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 144);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Uber Move", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(407, 47);
            label1.Name = "label1";
            label1.Size = new Size(361, 72);
            label1.TabIndex = 1;
            label1.Text = "Solicitações";
            // 
            // produtoTxt
            // 
            produtoTxt.BorderStyle = BorderStyle.FixedSingle;
            produtoTxt.Location = new Point(13, 206);
            produtoTxt.Name = "produtoTxt";
            produtoTxt.Size = new Size(204, 40);
            produtoTxt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 171);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 3;
            label2.Text = "Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 171);
            label3.Name = "label3";
            label3.Size = new Size(70, 32);
            label3.TabIndex = 5;
            label3.Text = "Tipo";
            // 
            // tipoCb
            // 
            tipoCb.FormattingEnabled = true;
            tipoCb.Location = new Point(242, 206);
            tipoCb.Name = "tipoCb";
            tipoCb.Size = new Size(204, 40);
            tipoCb.TabIndex = 6;
            // 
            // validadePicker
            // 
            validadePicker.Format = DateTimePickerFormat.Short;
            validadePicker.Location = new Point(474, 206);
            validadePicker.Name = "validadePicker";
            validadePicker.Size = new Size(204, 40);
            validadePicker.TabIndex = 7;
            // 
            // cadastroPicker
            // 
            cadastroPicker.Format = DateTimePickerFormat.Short;
            cadastroPicker.Location = new Point(706, 206);
            cadastroPicker.Name = "cadastroPicker";
            cadastroPicker.Size = new Size(204, 40);
            cadastroPicker.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(474, 171);
            label4.Name = "label4";
            label4.Size = new Size(123, 32);
            label4.TabIndex = 9;
            label4.Text = "Validade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(706, 171);
            label5.Name = "label5";
            label5.Size = new Size(230, 32);
            label5.TabIndex = 10;
            label5.Text = "Data de Cadastro";
            // 
            // searchPic
            // 
            searchPic.BackColor = Color.White;
            searchPic.Image = (Image)resources.GetObject("searchPic.Image");
            searchPic.Location = new Point(941, 206);
            searchPic.Name = "searchPic";
            searchPic.Size = new Size(62, 40);
            searchPic.SizeMode = PictureBoxSizeMode.Zoom;
            searchPic.TabIndex = 11;
            searchPic.TabStop = false;
            searchPic.Click += pictureBox2_Click;
            // 
            // dgvSolicitacoes
            // 
            dgvSolicitacoes.BackgroundColor = Color.White;
            dgvSolicitacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitacoes.Columns.AddRange(new DataGridViewColumn[] { IdColumn, DescColumn, TipoColumn, ValorColumn, ValidadeColumn, CadastroColumn });
            dgvSolicitacoes.Location = new Point(13, 256);
            dgvSolicitacoes.Name = "dgvSolicitacoes";
            dgvSolicitacoes.RowHeadersVisible = false;
            dgvSolicitacoes.RowHeadersWidth = 51;
            dgvSolicitacoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSolicitacoes.Size = new Size(1004, 296);
            dgvSolicitacoes.TabIndex = 12;
            // 
            // IdColumn
            // 
            dataGridViewCellStyle1.Font = new Font("Uber Move Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IdColumn.DefaultCellStyle = dataGridViewCellStyle1;
            IdColumn.HeaderText = "ID";
            IdColumn.MinimumWidth = 6;
            IdColumn.Name = "IdColumn";
            IdColumn.Width = 50;
            // 
            // DescColumn
            // 
            dataGridViewCellStyle2.Font = new Font("Uber Move Medium", 13.8F, FontStyle.Bold);
            DescColumn.DefaultCellStyle = dataGridViewCellStyle2;
            DescColumn.HeaderText = "Descrição Resumida";
            DescColumn.MinimumWidth = 6;
            DescColumn.Name = "DescColumn";
            DescColumn.Width = 200;
            // 
            // TipoColumn
            // 
            dataGridViewCellStyle3.Font = new Font("Uber Move Medium", 13.8F, FontStyle.Bold);
            TipoColumn.DefaultCellStyle = dataGridViewCellStyle3;
            TipoColumn.HeaderText = "Tipo";
            TipoColumn.MinimumWidth = 6;
            TipoColumn.Name = "TipoColumn";
            TipoColumn.Width = 200;
            // 
            // ValorColumn
            // 
            dataGridViewCellStyle4.Font = new Font("Uber Move Medium", 13.8F, FontStyle.Bold);
            ValorColumn.DefaultCellStyle = dataGridViewCellStyle4;
            ValorColumn.HeaderText = "Valor";
            ValorColumn.MinimumWidth = 6;
            ValorColumn.Name = "ValorColumn";
            ValorColumn.Width = 150;
            // 
            // ValidadeColumn
            // 
            dataGridViewCellStyle5.Font = new Font("Uber Move Medium", 13.8F, FontStyle.Bold);
            ValidadeColumn.DefaultCellStyle = dataGridViewCellStyle5;
            ValidadeColumn.HeaderText = "Data de Validade";
            ValidadeColumn.MinimumWidth = 6;
            ValidadeColumn.Name = "ValidadeColumn";
            ValidadeColumn.Width = 200;
            // 
            // CadastroColumn
            // 
            dataGridViewCellStyle6.Font = new Font("Uber Move Medium", 13.8F, FontStyle.Bold);
            CadastroColumn.DefaultCellStyle = dataGridViewCellStyle6;
            CadastroColumn.HeaderText = "Data de Cadastro";
            CadastroColumn.MinimumWidth = 6;
            CadastroColumn.Name = "CadastroColumn";
            CadastroColumn.Width = 200;
            // 
            // novoBtn
            // 
            novoBtn.Location = new Point(885, 560);
            novoBtn.Name = "novoBtn";
            novoBtn.Size = new Size(132, 40);
            novoBtn.TabIndex = 13;
            novoBtn.Text = "Novo";
            novoBtn.UseVisualStyleBackColor = true;
            novoBtn.Click += novoBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(722, 560);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(146, 40);
            editBtn.TabIndex = 14;
            editBtn.Text = "Editar";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // SolicitacoesForm
            // 
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(editBtn);
            Controls.Add(novoBtn);
            Controls.Add(dgvSolicitacoes);
            Controls.Add(searchPic);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cadastroPicker);
            Controls.Add(validadePicker);
            Controls.Add(tipoCb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(produtoTxt);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Uber Move", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "SolicitacoesForm";
            Size = new Size(1030, 610);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitacoes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox produtoTxt;
        private Label label2;
        private Label label3;
        private ComboBox tipoCb;
        private DateTimePicker validadePicker;
        private DateTimePicker cadastroPicker;
        private Label label4;
        private Label label5;
        private PictureBox searchPic;
        private DataGridView dgvSolicitacoes;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn DescColumn;
        private DataGridViewTextBoxColumn TipoColumn;
        private DataGridViewTextBoxColumn ValorColumn;
        private DataGridViewTextBoxColumn ValidadeColumn;
        private DataGridViewTextBoxColumn CadastroColumn;
        private Button novoBtn;
        private Button editBtn;
    }
}
