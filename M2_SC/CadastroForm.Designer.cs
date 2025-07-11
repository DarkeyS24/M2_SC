namespace M2_SC
{
    partial class CadastroForm
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
            panel1 = new Panel();
            cancelBtn = new Button();
            saveBtn = new Button();
            nascPicker = new DateTimePicker();
            cpfLbl = new Label();
            rePswdTxt = new TextBox();
            label6 = new Label();
            pswdTxt = new TextBox();
            label7 = new Label();
            userTxt = new TextBox();
            label9 = new Label();
            telTxt = new TextBox();
            label4 = new Label();
            documentoTxt = new TextBox();
            cnpjLbl = new Label();
            socialTxt = new TextBox();
            socialLbl = new Label();
            nomeTxt = new TextBox();
            label2 = new Label();
            perfilCb = new ComboBox();
            label1 = new Label();
            nascLbl = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cancelBtn);
            panel1.Controls.Add(saveBtn);
            panel1.Controls.Add(nascPicker);
            panel1.Controls.Add(cpfLbl);
            panel1.Controls.Add(rePswdTxt);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pswdTxt);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(userTxt);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(telTxt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(documentoTxt);
            panel1.Controls.Add(cnpjLbl);
            panel1.Controls.Add(socialTxt);
            panel1.Controls.Add(socialLbl);
            panel1.Controls.Add(nomeTxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(perfilCb);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(nascLbl);
            panel1.Location = new Point(26, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(552, 686);
            panel1.TabIndex = 0;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(192, 623);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(155, 40);
            cancelBtn.TabIndex = 22;
            cancelBtn.Text = "Cancelar";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(368, 623);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(155, 40);
            saveBtn.TabIndex = 21;
            saveBtn.Text = "Salvar";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // nascPicker
            // 
            nascPicker.Format = DateTimePickerFormat.Short;
            nascPicker.Location = new Point(276, 180);
            nascPicker.Name = "nascPicker";
            nascPicker.Size = new Size(247, 40);
            nascPicker.TabIndex = 20;
            // 
            // cpfLbl
            // 
            cpfLbl.AutoSize = true;
            cpfLbl.Location = new Point(192, 255);
            cpfLbl.Name = "cpfLbl";
            cpfLbl.Size = new Size(64, 32);
            cpfLbl.TabIndex = 19;
            cpfLbl.Text = "CPF";
            // 
            // rePswdTxt
            // 
            rePswdTxt.Location = new Point(276, 539);
            rePswdTxt.Name = "rePswdTxt";
            rePswdTxt.Size = new Size(247, 40);
            rePswdTxt.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 542);
            label6.Name = "label6";
            label6.Size = new Size(216, 32);
            label6.TabIndex = 16;
            label6.Text = "Confirme a seha";
            // 
            // pswdTxt
            // 
            pswdTxt.Location = new Point(276, 468);
            pswdTxt.Name = "pswdTxt";
            pswdTxt.Size = new Size(247, 40);
            pswdTxt.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(165, 471);
            label7.Name = "label7";
            label7.Size = new Size(91, 32);
            label7.TabIndex = 14;
            label7.Text = "Senha";
            // 
            // userTxt
            // 
            userTxt.Location = new Point(276, 396);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(247, 40);
            userTxt.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(148, 399);
            label9.Name = "label9";
            label9.Size = new Size(108, 32);
            label9.TabIndex = 10;
            label9.Text = "Usuario";
            // 
            // telTxt
            // 
            telTxt.Location = new Point(276, 323);
            telTxt.Name = "telTxt";
            telTxt.Size = new Size(247, 40);
            telTxt.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 326);
            label4.Name = "label4";
            label4.Size = new Size(122, 32);
            label4.TabIndex = 8;
            label4.Text = "Telefone";
            // 
            // documentoTxt
            // 
            documentoTxt.Location = new Point(276, 252);
            documentoTxt.Name = "documentoTxt";
            documentoTxt.Size = new Size(247, 40);
            documentoTxt.TabIndex = 7;
            // 
            // cnpjLbl
            // 
            cnpjLbl.AutoSize = true;
            cnpjLbl.Location = new Point(176, 255);
            cnpjLbl.Name = "cnpjLbl";
            cnpjLbl.Size = new Size(80, 32);
            cnpjLbl.TabIndex = 6;
            cnpjLbl.Text = "CNPJ";
            cnpjLbl.Visible = false;
            // 
            // socialTxt
            // 
            socialTxt.Location = new Point(276, 180);
            socialTxt.Name = "socialTxt";
            socialTxt.Size = new Size(247, 40);
            socialTxt.TabIndex = 5;
            socialTxt.Visible = false;
            // 
            // socialLbl
            // 
            socialLbl.AutoSize = true;
            socialLbl.Location = new Point(86, 183);
            socialLbl.Name = "socialLbl";
            socialLbl.Size = new Size(170, 32);
            socialLbl.TabIndex = 4;
            socialLbl.Text = "Razão Social";
            socialLbl.Visible = false;
            // 
            // nomeTxt
            // 
            nomeTxt.Location = new Point(276, 106);
            nomeTxt.Name = "nomeTxt";
            nomeTxt.Size = new Size(247, 40);
            nomeTxt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 114);
            label2.Name = "label2";
            label2.Size = new Size(91, 32);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // perfilCb
            // 
            perfilCb.FormattingEnabled = true;
            perfilCb.Location = new Point(276, 32);
            perfilCb.Name = "perfilCb";
            perfilCb.Size = new Size(247, 40);
            perfilCb.TabIndex = 1;
            perfilCb.SelectedIndexChanged += perfilCb_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 35);
            label1.Name = "label1";
            label1.Size = new Size(77, 32);
            label1.TabIndex = 0;
            label1.Text = "Perfil";
            // 
            // nascLbl
            // 
            nascLbl.AutoSize = true;
            nascLbl.BackColor = Color.Gold;
            nascLbl.Location = new Point(28, 183);
            nascLbl.Name = "nascLbl";
            nascLbl.Size = new Size(228, 32);
            nascLbl.TabIndex = 18;
            nascLbl.Text = "Data Nascimento";
            // 
            // CadastroForm
            // 
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(605, 738);
            ControlBox = false;
            Controls.Add(panel1);
            Font = new Font("Uber Move", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "CadastroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ponte Dourada";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox rePswdTxt;
        private Label label6;
        private TextBox pswdTxt;
        private Label label7;
        private TextBox userTxt;
        private Label label9;
        private TextBox telTxt;
        private Label label4;
        private TextBox documentoTxt;
        private Label cnpjLbl;
        private TextBox socialTxt;
        private Label socialLbl;
        private TextBox nomeTxt;
        private Label label2;
        private ComboBox perfilCb;
        private Label label1;
        private Label cpfLbl;
        private Label nascLbl;
        private Button cancelBtn;
        private Button saveBtn;
        private DateTimePicker nascPicker;
    }
}