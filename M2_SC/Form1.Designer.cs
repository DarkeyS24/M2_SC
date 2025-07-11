namespace M2_SC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            userTxt = new TextBox();
            pswdTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            entrarBtn = new Button();
            cadastroLink = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            produtosForm1 = new ProdutosForm();
            solicitacoesForm1 = new SolicitacoesForm();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gold;
            pictureBox1.Location = new Point(-2, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(529, 609);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // userTxt
            // 
            userTxt.BorderStyle = BorderStyle.FixedSingle;
            userTxt.Location = new Point(730, 262);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(249, 40);
            userTxt.TabIndex = 1;
            // 
            // pswdTxt
            // 
            pswdTxt.BorderStyle = BorderStyle.FixedSingle;
            pswdTxt.Location = new Point(730, 346);
            pswdTxt.Name = "pswdTxt";
            pswdTxt.Size = new Size(249, 40);
            pswdTxt.TabIndex = 2;
            pswdTxt.UseSystemPasswordChar = true;
            pswdTxt.KeyPress += pswdTxt_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(584, 264);
            label1.Name = "label1";
            label1.Size = new Size(108, 32);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(601, 348);
            label2.Name = "label2";
            label2.Size = new Size(91, 32);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // entrarBtn
            // 
            entrarBtn.Location = new Point(803, 433);
            entrarBtn.Name = "entrarBtn";
            entrarBtn.Size = new Size(176, 40);
            entrarBtn.TabIndex = 5;
            entrarBtn.Text = "Entrar";
            entrarBtn.UseVisualStyleBackColor = true;
            entrarBtn.Click += button1_Click;
            // 
            // cadastroLink
            // 
            cadastroLink.AutoSize = true;
            cadastroLink.Location = new Point(708, 521);
            cadastroLink.Name = "cadastroLink";
            cadastroLink.Size = new Size(168, 32);
            cadastroLink.TabIndex = 6;
            cadastroLink.TabStop = true;
            cadastroLink.Text = "Cadastre-se";
            cadastroLink.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gold;
            label3.Font = new Font("Uber Move", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(601, 47);
            label3.Name = "label3";
            label3.Size = new Size(190, 72);
            label3.TabIndex = 7;
            label3.Text = "Ponte";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Uber Move", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(721, 119);
            label4.Name = "label4";
            label4.Size = new Size(267, 72);
            label4.TabIndex = 8;
            label4.Text = "Dourada";
            // 
            // produtosForm1
            // 
            produtosForm1.AutoScroll = true;
            produtosForm1.Font = new Font("Uber Move", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            produtosForm1.Location = new Point(-2, -2);
            produtosForm1.Margin = new Padding(6, 5, 6, 5);
            produtosForm1.Name = "produtosForm1";
            produtosForm1.Size = new Size(1040, 607);
            produtosForm1.TabIndex = 9;
            produtosForm1.Visible = false;
            // 
            // solicitacoesForm1
            // 
            solicitacoesForm1.AutoScroll = true;
            solicitacoesForm1.BackColor = Color.White;
            solicitacoesForm1.Font = new Font("Uber Move", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            solicitacoesForm1.Location = new Point(-2, -2);
            solicitacoesForm1.Margin = new Padding(6, 5, 6, 5);
            solicitacoesForm1.Name = "solicitacoesForm1";
            solicitacoesForm1.Size = new Size(1040, 607);
            solicitacoesForm1.TabIndex = 10;
            solicitacoesForm1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1032, 603);
            Controls.Add(solicitacoesForm1);
            Controls.Add(produtosForm1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cadastroLink);
            Controls.Add(entrarBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pswdTxt);
            Controls.Add(userTxt);
            Controls.Add(pictureBox1);
            Font = new Font("Uber Move", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ponte Dourada";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox userTxt;
        private TextBox pswdTxt;
        private Label label1;
        private Label label2;
        private Button entrarBtn;
        private LinkLabel cadastroLink;
        private Label label3;
        private Label label4;
        private ProdutosForm produtosForm1;
        private SolicitacoesForm solicitacoesForm1;
    }
}
