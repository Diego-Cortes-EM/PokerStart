﻿namespace PokerStart
{
    partial class ConfiguraçãoConta
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
            this.BotaoPessoal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotaoPessoal
            // 
            this.BotaoPessoal.Location = new System.Drawing.Point(33, 49);
            this.BotaoPessoal.Name = "BotaoPessoal";
            this.BotaoPessoal.Size = new System.Drawing.Size(199, 68);
            this.BotaoPessoal.TabIndex = 0;
            this.BotaoPessoal.Text = "Conta Pessoal";
            this.BotaoPessoal.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "Conta de Terceiros";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ConfiguraçãoConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 150);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BotaoPessoal);
            this.Name = "ConfiguraçãoConta";
            this.Text = "ConfiguraçãoConta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotaoPessoal;
        private System.Windows.Forms.Button button1;
    }
}