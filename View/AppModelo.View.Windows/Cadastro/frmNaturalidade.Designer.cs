namespace AppModelo.View.Windows.Cadastro
{
    partial class frmNaturalidade
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
            this.components = new System.ComponentModel.Container();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvarNaturalidade = new System.Windows.Forms.Button();
            this.chkBox = new System.Windows.Forms.CheckBox();
            this.gvNaturalidade = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNaturalidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtId.CausesValidation = false;
            this.txtId.Location = new System.Drawing.Point(16, 37);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDescricao.Location = new System.Drawing.Point(16, 92);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(287, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição";
            // 
            // panel1
            // 
<<<<<<< HEAD
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
=======
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
>>>>>>> a3cb59095f2653f2c3140b5adfcf03e2c102b6e0
            this.panel1.Controls.Add(this.btnAtualizar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnSalvarNaturalidade);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chkBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 127);
            this.panel1.TabIndex = 4;
            // 
            // btnSalvarNaturalidade
            // 
            this.btnSalvarNaturalidade.BackColor = System.Drawing.Color.GreenYellow;
            this.btnSalvarNaturalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.btnSalvarNaturalidade.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSalvarNaturalidade.Location = new System.Drawing.Point(254, 89);
=======
            this.btnSalvarNaturalidade.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarNaturalidade.Location = new System.Drawing.Point(339, 91);
>>>>>>> a3cb59095f2653f2c3140b5adfcf03e2c102b6e0
            this.btnSalvarNaturalidade.Name = "btnSalvarNaturalidade";
            this.btnSalvarNaturalidade.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarNaturalidade.TabIndex = 7;
            this.btnSalvarNaturalidade.Text = "Salvar";
            this.btnSalvarNaturalidade.UseVisualStyleBackColor = false;
            this.btnSalvarNaturalidade.Click += new System.EventHandler(this.btnSalvarNaturalidade_Click);
            // 
            // chkBox
            // 
            this.chkBox.AutoSize = true;
            this.chkBox.Checked = true;
            this.chkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.chkBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkBox.Location = new System.Drawing.Point(150, 37);
            this.chkBox.Name = "chkBox";
            this.chkBox.Size = new System.Drawing.Size(64, 22);
            this.chkBox.TabIndex = 5;
            this.chkBox.Text = "Ativo";
            this.chkBox.UseVisualStyleBackColor = true;
            // 
            // gvNaturalidade
            // 
            this.gvNaturalidade.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvNaturalidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNaturalidade.Location = new System.Drawing.Point(12, 135);
            this.gvNaturalidade.Name = "gvNaturalidade";
            this.gvNaturalidade.Size = new System.Drawing.Size(407, 247);
            this.gvNaturalidade.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnExcluir
            // 
<<<<<<< HEAD
            this.btnExcluir.BackColor = System.Drawing.Color.LightCoral;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(254, 60);
=======
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Location = new System.Drawing.Point(339, 54);
>>>>>>> a3cb59095f2653f2c3140b5adfcf03e2c102b6e0
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
<<<<<<< HEAD
            this.btnExcluir.UseVisualStyleBackColor = false;
=======
            this.btnExcluir.UseVisualStyleBackColor = true;
>>>>>>> a3cb59095f2653f2c3140b5adfcf03e2c102b6e0
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
<<<<<<< HEAD
            this.btnAtualizar.BackColor = System.Drawing.Color.Turquoise;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(254, 31);
=======
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.Black;
            this.btnAtualizar.Location = new System.Drawing.Point(339, 18);
>>>>>>> a3cb59095f2653f2c3140b5adfcf03e2c102b6e0
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "Atualizar";
<<<<<<< HEAD
            this.btnAtualizar.UseVisualStyleBackColor = false;
=======
            this.btnAtualizar.UseVisualStyleBackColor = true;
>>>>>>> a3cb59095f2653f2c3140b5adfcf03e2c102b6e0
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // frmNaturalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(432, 397);
            this.Controls.Add(this.gvNaturalidade);
            this.Controls.Add(this.panel1);
            this.Name = "frmNaturalidade";
            this.Text = "frmNaturalidade";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNaturalidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkBox;
        private System.Windows.Forms.DataGridView gvNaturalidade;
        private System.Windows.Forms.Button btnSalvarNaturalidade;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
    }
}