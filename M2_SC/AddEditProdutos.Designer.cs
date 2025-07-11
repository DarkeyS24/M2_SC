namespace M2_SC
{
    partial class AddEditProdutos
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
            saveBtn = new Button();
            label1 = new Label();
            tipoCb = new ComboBox();
            descTxt = new RichTextBox();
            validadePicker = new DateTimePicker();
            nomeTxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            valuePicker = new NumericUpDown();
            cancelBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)valuePicker).BeginInit();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(515, 373);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(144, 40);
            saveBtn.TabIndex = 0;
            saveBtn.Text = "Salvar";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 29);
            label1.Name = "label1";
            label1.Size = new Size(70, 32);
            label1.TabIndex = 1;
            label1.Text = "Tipo";
            // 
            // tipoCb
            // 
            tipoCb.FormattingEnabled = true;
            tipoCb.Location = new Point(182, 26);
            tipoCb.Name = "tipoCb";
            tipoCb.Size = new Size(281, 40);
            tipoCb.TabIndex = 2;
            // 
            // descTxt
            // 
            descTxt.BorderStyle = BorderStyle.FixedSingle;
            descTxt.Location = new Point(182, 227);
            descTxt.Name = "descTxt";
            descTxt.Size = new Size(458, 132);
            descTxt.TabIndex = 4;
            descTxt.Text = "";
            // 
            // validadePicker
            // 
            validadePicker.Format = DateTimePickerFormat.Short;
            validadePicker.Location = new Point(182, 161);
            validadePicker.Name = "validadePicker";
            validadePicker.Size = new Size(199, 40);
            validadePicker.TabIndex = 3;
            // 
            // nomeTxt
            // 
            nomeTxt.BorderStyle = BorderStyle.FixedSingle;
            nomeTxt.Location = new Point(182, 93);
            nomeTxt.Name = "nomeTxt";
            nomeTxt.Size = new Size(458, 40);
            nomeTxt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 167);
            label3.Name = "label3";
            label3.Size = new Size(123, 32);
            label3.TabIndex = 6;
            label3.Text = "Validade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 95);
            label2.Name = "label2";
            label2.Size = new Size(91, 32);
            label2.TabIndex = 7;
            label2.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 229);
            label4.Name = "label4";
            label4.Size = new Size(141, 32);
            label4.TabIndex = 8;
            label4.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 167);
            label5.Name = "label5";
            label5.Size = new Size(79, 32);
            label5.TabIndex = 10;
            label5.Text = "Valor";
            // 
            // valuePicker
            // 
            valuePicker.Location = new Point(510, 161);
            valuePicker.Name = "valuePicker";
            valuePicker.Size = new Size(130, 40);
            valuePicker.TabIndex = 11;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(328, 373);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(170, 40);
            cancelBtn.TabIndex = 12;
            cancelBtn.Text = "Cancelar";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // AddEditProdutos
            // 
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(671, 425);
            ControlBox = false;
            Controls.Add(cancelBtn);
            Controls.Add(valuePicker);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(nomeTxt);
            Controls.Add(validadePicker);
            Controls.Add(descTxt);
            Controls.Add(tipoCb);
            Controls.Add(label1);
            Controls.Add(saveBtn);
            Font = new Font("Uber Move", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "AddEditProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEditProdutos";
            ((System.ComponentModel.ISupportInitialize)valuePicker).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveBtn;
        private Label label1;
        private ComboBox tipoCb;
        private RichTextBox descTxt;
        private DateTimePicker validadePicker;
        private TextBox nomeTxt;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private NumericUpDown valuePicker;
        private Button cancelBtn;
    }
}