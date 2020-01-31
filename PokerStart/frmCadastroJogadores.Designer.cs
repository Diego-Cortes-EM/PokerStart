namespace PokerStart
{
    partial class frmCadastroJogadores
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
            this.labelNome = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.labelDTNascimento = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.BotaoCriarContaBancaria = new System.Windows.Forms.Button();
            this.botaoGravaJogador = new System.Windows.Forms.Button();
            this.labelConta = new System.Windows.Forms.Label();
            this.textConta = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(-1, 39);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(129, 17);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome do Jogador :";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(126, 36);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(426, 22);
            this.textNome.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 22);
            this.textBox1.TabIndex = 3;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(86, 68);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(42, 17);
            this.labelCPF.TabIndex = 2;
            this.labelCPF.Text = "CPF :";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(101, 8);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(27, 17);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "Id :";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(126, 8);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(137, 22);
            this.textID.TabIndex = 3;
            // 
            // labelDTNascimento
            // 
            this.labelDTNascimento.AutoSize = true;
            this.labelDTNascimento.Location = new System.Drawing.Point(269, 68);
            this.labelDTNascimento.Name = "labelDTNascimento";
            this.labelDTNascimento.Size = new System.Drawing.Size(140, 17);
            this.labelDTNascimento.TabIndex = 4;
            this.labelDTNascimento.Text = "Data de Nascimento:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(426, 22);
            this.textBox2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "RG :";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(415, 65);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(137, 22);
            this.maskedTextBox1.TabIndex = 8;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // BotaoCriarContaBancaria
            // 
            this.BotaoCriarContaBancaria.Location = new System.Drawing.Point(48, 370);
            this.BotaoCriarContaBancaria.Name = "BotaoCriarContaBancaria";
            this.BotaoCriarContaBancaria.Size = new System.Drawing.Size(167, 35);
            this.BotaoCriarContaBancaria.TabIndex = 9;
            this.BotaoCriarContaBancaria.Text = "Criar Conta Bancaria";
            this.BotaoCriarContaBancaria.UseVisualStyleBackColor = true;
            this.BotaoCriarContaBancaria.Click += new System.EventHandler(this.BotaoCriarContaBancaria_Click);
            // 
            // botaoGravaJogador
            // 
            this.botaoGravaJogador.Location = new System.Drawing.Point(329, 370);
            this.botaoGravaJogador.Name = "botaoGravaJogador";
            this.botaoGravaJogador.Size = new System.Drawing.Size(167, 35);
            this.botaoGravaJogador.TabIndex = 10;
            this.botaoGravaJogador.Text = "Gravar";
            this.botaoGravaJogador.UseVisualStyleBackColor = true;
            // 
            // labelConta
            // 
            this.labelConta.AutoSize = true;
            this.labelConta.Location = new System.Drawing.Point(72, 142);
            this.labelConta.Name = "labelConta";
            this.labelConta.Size = new System.Drawing.Size(53, 17);
            this.labelConta.TabIndex = 11;
            this.labelConta.Text = "Conta :";
            // 
            // textConta
            // 
            this.textConta.Location = new System.Drawing.Point(126, 142);
            this.textConta.Name = "textConta";
            this.textConta.Size = new System.Drawing.Size(426, 205);
            this.textConta.TabIndex = 12;
            this.textConta.Text = "";
            // 
            // frmCadastroJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 417);
            this.Controls.Add(this.textConta);
            this.Controls.Add(this.labelConta);
            this.Controls.Add(this.botaoGravaJogador);
            this.Controls.Add(this.BotaoCriarContaBancaria);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDTNascimento);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.labelNome);
            this.Name = "frmCadastroJogadores";
            this.Text = "Cadastro De Jogadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label labelDTNascimento;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button BotaoCriarContaBancaria;
        private System.Windows.Forms.Button botaoGravaJogador;
        private System.Windows.Forms.Label labelConta;
        private System.Windows.Forms.RichTextBox textConta;
    }
}