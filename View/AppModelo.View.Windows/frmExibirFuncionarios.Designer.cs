namespace AppModelo.View.Windows
{
    partial class frmExibirFuncionarios
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
            this.gvExibirFuncionarios = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdExibirFuncionarios = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MiExcluirFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MiAtualizarFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirFuncionarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvExibirFuncionarios
            // 
            this.gvExibirFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExibirFuncionarios.Location = new System.Drawing.Point(12, 71);
            this.gvExibirFuncionarios.Name = "gvExibirFuncionarios";
            this.gvExibirFuncionarios.Size = new System.Drawing.Size(1229, 383);
            this.gvExibirFuncionarios.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIdExibirFuncionarios);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1253, 63);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // txtIdExibirFuncionarios
            // 
            this.txtIdExibirFuncionarios.Location = new System.Drawing.Point(3, 28);
            this.txtIdExibirFuncionarios.Name = "txtIdExibirFuncionarios";
            this.txtIdExibirFuncionarios.Size = new System.Drawing.Size(63, 20);
            this.txtIdExibirFuncionarios.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiExcluirFuncionarios,
            this.MiAtualizarFuncionarios});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1253, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MiExcluirFuncionarios
            // 
            this.MiExcluirFuncionarios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiExcluirFuncionarios.Name = "MiExcluirFuncionarios";
            this.MiExcluirFuncionarios.Size = new System.Drawing.Size(61, 21);
            this.MiExcluirFuncionarios.Text = "Excluir";
            this.MiExcluirFuncionarios.Click += new System.EventHandler(this.MiExcluirFuncionarios_Click);
            // 
            // MiAtualizarFuncionarios
            // 
            this.MiAtualizarFuncionarios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiAtualizarFuncionarios.Name = "MiAtualizarFuncionarios";
            this.MiAtualizarFuncionarios.Size = new System.Drawing.Size(75, 21);
            this.MiAtualizarFuncionarios.Text = "Atualizar";
            this.MiAtualizarFuncionarios.Click += new System.EventHandler(this.MiAtualizarFuncionarios_Click);
            // 
            // frmExibirFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gvExibirFuncionarios);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmExibirFuncionarios";
            this.Text = "frmExibirFuncionarios";
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirFuncionarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvExibirFuncionarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdExibirFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem MiExcluirFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem MiAtualizarFuncionarios;
    }
}