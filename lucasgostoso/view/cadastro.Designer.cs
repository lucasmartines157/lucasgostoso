namespace lucasgostoso.view
{
    partial class cadastro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbx_nome = new TextBox();
            tbx_cpf = new TextBox();
            cbx_idade = new ComboBox();
            btn_botao = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 152);
            label1.Name = "label1";
            label1.Size = new Size(49, 17);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(114, 195);
            label2.Name = "label2";
            label2.Size = new Size(35, 17);
            label2.TabIndex = 1;
            label2.Text = "CPF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(114, 237);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 2;
            label3.Text = "Idade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(264, 48);
            label4.Name = "label4";
            label4.Size = new Size(239, 25);
            label4.TabIndex = 3;
            label4.Text = "Cadastro Loja Palmeiras";
            // 
            // tbx_nome
            // 
            tbx_nome.Location = new Point(169, 152);
            tbx_nome.Name = "tbx_nome";
            tbx_nome.Size = new Size(161, 23);
            tbx_nome.TabIndex = 4;
            // 
            // tbx_cpf
            // 
            tbx_cpf.Location = new Point(169, 195);
            tbx_cpf.Name = "tbx_cpf";
            tbx_cpf.Size = new Size(161, 23);
            tbx_cpf.TabIndex = 5;
            // 
            // cbx_idade
            // 
            cbx_idade.FormattingEnabled = true;
            cbx_idade.Items.AddRange(new object[] { "18 a 29 Anos", "30 a 40 Anos", "41 a 60 Anos", "+60 Anos" });
            cbx_idade.Location = new Point(169, 237);
            cbx_idade.Name = "cbx_idade";
            cbx_idade.Size = new Size(121, 23);
            cbx_idade.TabIndex = 6;
            // 
            // btn_botao
            // 
            btn_botao.Location = new Point(219, 347);
            btn_botao.Name = "btn_botao";
            btn_botao.Size = new Size(383, 23);
            btn_botao.TabIndex = 7;
            btn_botao.Text = "Cadastrar";
            btn_botao.UseVisualStyleBackColor = true;
            btn_botao.Click += button1_Click;
            // 
            // cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Palmeiras_logo_DD815B6EE2_seeklogo_com;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_botao);
            Controls.Add(cbx_idade);
            Controls.Add(tbx_cpf);
            Controls.Add(tbx_nome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "cadastro";
            Text = "cadastro";
            Load += cadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbx_nome;
        private TextBox tbx_cpf;
        private ComboBox cbx_idade;
        private Button btn_botao;
    }
}