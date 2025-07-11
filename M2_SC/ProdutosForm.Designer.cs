namespace M2_SC
{
    partial class ProdutosForm
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            editBtn = new Button();
            novoBtn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvProdutos = new DataGridView();
            NomeColumn = new DataGridViewTextBoxColumn();
            TipoColumn = new DataGridViewTextBoxColumn();
            ValidadeColumn = new DataGridViewTextBoxColumn();
            CadastroColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // editBtn
            // 
            editBtn.Location = new Point(722, 556);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(146, 40);
            editBtn.TabIndex = 19;
            editBtn.Text = "Editar";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // novoBtn
            // 
            novoBtn.Location = new Point(885, 556);
            novoBtn.Name = "novoBtn";
            novoBtn.Size = new Size(132, 40);
            novoBtn.TabIndex = 18;
            novoBtn.Text = "Novo";
            novoBtn.UseVisualStyleBackColor = true;
            novoBtn.Click += novoBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Uber Move", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(414, 52);
            label1.Name = "label1";
            label1.Size = new Size(282, 72);
            label1.TabIndex = 16;
            label1.Text = "Produtos";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gold;
            pictureBox1.Location = new Point(13, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 144);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.BackgroundColor = Color.White;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { NomeColumn, TipoColumn, ValidadeColumn, CadastroColumn });
            dgvProdutos.Location = new Point(13, 180);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.RowHeadersWidth = 51;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(1004, 363);
            dgvProdutos.TabIndex = 21;
            // 
            // NomeColumn
            // 
            dataGridViewCellStyle13.Font = new Font("Uber Move Medium", 13.8F, FontStyle.Bold);
            NomeColumn.DefaultCellStyle = dataGridViewCellStyle13;
            NomeColumn.HeaderText = "Nome";
            NomeColumn.MinimumWidth = 6;
            NomeColumn.Name = "NomeColumn";
            NomeColumn.Width = 200;
            // 
            // TipoColumn
            // 
            dataGridViewCellStyle14.Font = new Font("Uber Move Medium", 13.8F, FontStyle.Bold);
            TipoColumn.DefaultCellStyle = dataGridViewCellStyle14;
            TipoColumn.HeaderText = "Tipo";
            TipoColumn.MinimumWidth = 6;
            TipoColumn.Name = "TipoColumn";
            TipoColumn.Width = 200;
            // 
            // ValidadeColumn
            // 
            dataGridViewCellStyle15.Font = new Font("Uber Move Medium", 13.8F, FontStyle.Bold);
            ValidadeColumn.DefaultCellStyle = dataGridViewCellStyle15;
            ValidadeColumn.HeaderText = "Data de Validade";
            ValidadeColumn.MinimumWidth = 6;
            ValidadeColumn.Name = "ValidadeColumn";
            ValidadeColumn.Width = 300;
            // 
            // CadastroColumn
            // 
            dataGridViewCellStyle16.Font = new Font("Uber Move Medium", 13.8F, FontStyle.Bold);
            CadastroColumn.DefaultCellStyle = dataGridViewCellStyle16;
            CadastroColumn.HeaderText = "Data de Cadastro";
            CadastroColumn.MinimumWidth = 6;
            CadastroColumn.Name = "CadastroColumn";
            CadastroColumn.Width = 300;
            // 
            // ProdutosForm
            // 
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(dgvProdutos);
            Controls.Add(pictureBox1);
            Controls.Add(editBtn);
            Controls.Add(novoBtn);
            Controls.Add(label1);
            Font = new Font("Uber Move", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "ProdutosForm";
            Size = new Size(1030, 610);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button editBtn;
        private Button novoBtn;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn NomeColumn;
        private DataGridViewTextBoxColumn TipoColumn;
        private DataGridViewTextBoxColumn ValidadeColumn;
        private DataGridViewTextBoxColumn CadastroColumn;
    }
}
