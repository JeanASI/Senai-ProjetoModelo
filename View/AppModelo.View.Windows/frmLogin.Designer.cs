﻿namespace AppModelo.View.Windows
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblEsqueciMinhaSenha = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblSuporteContato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(57, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(54, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Senha";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(57, 149);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(57, 210);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(240, 20);
            this.txtSenha.TabIndex = 1;
            // 
            // lblEsqueciMinhaSenha
            // 
            this.lblEsqueciMinhaSenha.AutoSize = true;
            this.lblEsqueciMinhaSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEsqueciMinhaSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEsqueciMinhaSenha.Location = new System.Drawing.Point(189, 243);
            this.lblEsqueciMinhaSenha.Name = "lblEsqueciMinhaSenha";
            this.lblEsqueciMinhaSenha.Size = new System.Drawing.Size(108, 13);
            this.lblEsqueciMinhaSenha.TabIndex = 2;
            this.lblEsqueciMinhaSenha.Text = "Esqueci minha senha";
            this.lblEsqueciMinhaSenha.Click += new System.EventHandler(this.lblEsqueciMinhaSenha_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(57, 296);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(240, 35);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblSuporteContato
            // 
            this.lblSuporteContato.AutoSize = true;
            this.lblSuporteContato.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSuporteContato.Location = new System.Drawing.Point(138, 344);
            this.lblSuporteContato.Name = "lblSuporteContato";
            this.lblSuporteContato.Size = new System.Drawing.Size(93, 13);
            this.lblSuporteContato.TabIndex = 4;
            this.lblSuporteContato.Text = "Suporte e Contato";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(369, 364);
            this.Controls.Add(this.lblSuporteContato);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblEsqueciMinhaSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblEsqueciMinhaSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblSuporteContato;
    }
}