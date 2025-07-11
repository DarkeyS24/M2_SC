namespace M2_SC
{
    partial class AddEditSolicitacoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditSolicitacoes));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            nomeTxt = new TextBox();
            tipoCb = new ComboBox();
            searchBtn = new PictureBox();
            dgvPesquisados = new DataGridView();
            NomeColumnPP = new DataGridViewTextBoxColumn();
            FornecedorColumnPP = new DataGridViewTextBoxColumn();
            addBtn = new Button();
            validadePicker = new DateTimePicker();
            descTxt = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            dgvSolicitados = new DataGridView();
            NomeColumnS = new DataGridViewTextBoxColumn();
            FornecedorColumnS = new DataGridViewTextBoxColumn();
            ImageColumn = new DataGridViewImageColumn();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lbl = new Label();
            saveBtn = new Button();
            cancelBtn = new Button();
            valueLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)searchBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPesquisados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(70, 32);
            label1.TabIndex = 0;
            label1.Text = "Tipo";
            // 
            // nomeTxt
            // 
            nomeTxt.BorderStyle = BorderStyle.FixedSingle;
            nomeTxt.Location = new Point(173, 86);
            nomeTxt.Name = "nomeTxt";
            nomeTxt.Size = new Size(268, 40);
            nomeTxt.TabIndex = 1;
            // 
            // tipoCb
            // 
            tipoCb.FormattingEnabled = true;
            tipoCb.Location = new Point(173, 17);
            tipoCb.Name = "tipoCb";
            tipoCb.Size = new Size(268, 40);
            tipoCb.TabIndex = 2;
            // 
            // searchBtn
            // 
            searchBtn.Image = (Image)resources.GetObject("searchBtn.Image");
            searchBtn.Location = new Point(447, 86);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(51, 40);
            searchBtn.SizeMode = PictureBoxSizeMode.Zoom;
            searchBtn.TabIndex = 3;
            searchBtn.TabStop = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // dgvPesquisados
            // 
            dgvPesquisados.BackgroundColor = Color.White;
            dgvPesquisados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPesquisados.Columns.AddRange(new DataGridViewColumn[] { NomeColumnPP, FornecedorColumnPP });
            dgvPesquisados.Location = new Point(22, 214);
            dgvPesquisados.Name = "dgvPesquisados";
            dgvPesquisados.RowHeadersVisible = false;
            dgvPesquisados.RowHeadersWidth = 51;
            dgvPesquisados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPesquisados.Size = new Size(610, 186);
            dgvPesquisados.TabIndex = 4;
            // 
            // NomeColumnPP
            // 
            dataGridViewCellStyle1.Font = new Font("Uber Move Medium", 13.8F, FontStyle.Bold);
            NomeColumnPP.DefaultCellStyle = dataGridViewCellStyle1;
            NomeColumnPP.HeaderText = "Nome";
            NomeColumnPP.MinimumWidth = 6;
            NomeColumnPP.Name = "NomeColumnPP";
            NomeColumnPP.Width = 303;
            // 
            // FornecedorColumnPP
            // 
            dataGridViewCellStyle2.Font = new Font("Uber Move Medium", 13.8F, FontStyle.Bold);
            FornecedorColumnPP.DefaultCellStyle = dataGridViewCellStyle2;
            FornecedorColumnPP.HeaderText = "Fornecedor";
            FornecedorColumnPP.MinimumWidth = 6;
            FornecedorColumnPP.Name = "FornecedorColumnPP";
            FornecedorColumnPP.Width = 304;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(355, 406);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(277, 40);
            addBtn.TabIndex = 5;
            addBtn.Text = "Adicionar produto";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // validadePicker
            // 
            validadePicker.Format = DateTimePickerFormat.Short;
            validadePicker.Location = new Point(173, 729);
            validadePicker.Name = "validadePicker";
            validadePicker.Size = new Size(268, 40);
            validadePicker.TabIndex = 6;
            // 
            // descTxt
            // 
            descTxt.BackColor = Color.White;
            descTxt.BorderStyle = BorderStyle.FixedSingle;
            descTxt.Location = new Point(173, 809);
            descTxt.Name = "descTxt";
            descTxt.Size = new Size(459, 117);
            descTxt.TabIndex = 7;
            descTxt.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 89);
            label2.Name = "label2";
            label2.Size = new Size(91, 32);
            label2.TabIndex = 8;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 171);
            label3.Name = "label3";
            label3.Size = new Size(268, 32);
            label3.TabIndex = 9;
            label3.Text = "Resultados da busca";
            // 
            // dgvSolicitados
            // 
            dgvSolicitados.BackgroundColor = Color.White;
            dgvSolicitados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitados.Columns.AddRange(new DataGridViewColumn[] { NomeColumnS, FornecedorColumnS, ImageColumn });
            dgvSolicitados.Location = new Point(22, 515);
            dgvSolicitados.Name = "dgvSolicitados";
            dgvSolicitados.RowHeadersVisible = false;
            dgvSolicitados.RowHeadersWidth = 51;
            dgvSolicitados.Size = new Size(610, 186);
            dgvSolicitados.TabIndex = 10;
            dgvSolicitados.CellContentClick += dgvSolicitados_CellContentClick;
            // 
            // NomeColumnS
            // 
            dataGridViewCellStyle3.Font = new Font("Uber Move Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NomeColumnS.DefaultCellStyle = dataGridViewCellStyle3;
            NomeColumnS.HeaderText = "Nome";
            NomeColumnS.MinimumWidth = 6;
            NomeColumnS.Name = "NomeColumnS";
            NomeColumnS.Width = 250;
            // 
            // FornecedorColumnS
            // 
            dataGridViewCellStyle4.Font = new Font("Uber Move Medium", 13.8F, FontStyle.Bold);
            FornecedorColumnS.DefaultCellStyle = dataGridViewCellStyle4;
            FornecedorColumnS.HeaderText = "Fornecedor";
            FornecedorColumnS.MinimumWidth = 6;
            FornecedorColumnS.Name = "FornecedorColumnS";
            FornecedorColumnS.Width = 250;
            // 
            // ImageColumn
            // 
            ImageColumn.HeaderText = "";
            ImageColumn.MinimumWidth = 6;
            ImageColumn.Name = "ImageColumn";
            ImageColumn.Width = 107;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 472);
            label4.Name = "label4";
            label4.Size = new Size(268, 32);
            label4.TabIndex = 11;
            label4.Text = "Produtos solicitados";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 735);
            label5.Name = "label5";
            label5.Size = new Size(123, 32);
            label5.TabIndex = 12;
            label5.Text = "Validade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 812);
            label6.Name = "label6";
            label6.Size = new Size(141, 32);
            label6.TabIndex = 13;
            label6.Text = "Descrição";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(23, 956);
            lbl.Name = "lbl";
            lbl.Size = new Size(122, 32);
            lbl.TabIndex = 14;
            lbl.Text = "Valor: R$";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(490, 1009);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(142, 40);
            saveBtn.TabIndex = 15;
            saveBtn.Text = "Salvar";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(286, 1009);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(185, 40);
            cancelBtn.TabIndex = 16;
            cancelBtn.Text = "Cancelar";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // valueLbl
            // 
            valueLbl.AutoSize = true;
            valueLbl.Location = new Point(139, 956);
            valueLbl.Name = "valueLbl";
            valueLbl.Size = new Size(114, 32);
            valueLbl.TabIndex = 17;
            valueLbl.Text = "2589,00";
            // 
            // AddEditSolicitacoes
            // 
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(653, 552);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(lbl);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dgvSolicitados);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(descTxt);
            Controls.Add(validadePicker);
            Controls.Add(addBtn);
            Controls.Add(dgvPesquisados);
            Controls.Add(searchBtn);
            Controls.Add(tipoCb);
            Controls.Add(nomeTxt);
            Controls.Add(label1);
            Controls.Add(valueLbl);
            Font = new Font("Uber Move", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "AddEditSolicitacoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEditSolicitacoes";
            ((System.ComponentModel.ISupportInitialize)searchBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPesquisados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nomeTxt;
        private ComboBox tipoCb;
        private PictureBox searchBtn;
        private DataGridView dgvPesquisados;
        private Button addBtn;
        private DateTimePicker validadePicker;
        private RichTextBox descTxt;
        private Label label2;
        private Label label3;
        private DataGridView dgvSolicitados;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lbl;
        private Button saveBtn;
        private Button cancelBtn;
        private DataGridViewTextBoxColumn NomeColumnS;
        private DataGridViewTextBoxColumn FornecedorColumnS;
        private DataGridViewImageColumn ImageColumn;
        private DataGridViewTextBoxColumn NomeColumnPP;
        private DataGridViewTextBoxColumn FornecedorColumnPP;
        private Label valueLbl;
    }
}