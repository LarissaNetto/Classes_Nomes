
namespace Classes_Nome
{
    partial class FrmAlimento
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.frmLojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmLojaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.frmAlimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pnl_alimento = new System.Windows.Forms.Panel();
            this.txt_valoraumento = new System.Windows.Forms.TextBox();
            this.lbl_valoraumento = new System.Windows.Forms.Label();
            this.txt_valorcompra = new System.Windows.Forms.TextBox();
            this.lbl_valorcompra = new System.Windows.Forms.Label();
            this.txt_calorias = new System.Windows.Forms.TextBox();
            this.lbl_calorias = new System.Windows.Forms.Label();
            this.txt_ing = new System.Windows.Forms.TextBox();
            this.lbl_ing = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.Pnl_alimento.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmLojaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(403, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmLojaToolStripMenuItem
            // 
            this.frmLojaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmLojaToolStripMenuItem1,
            this.frmAlimentoToolStripMenuItem});
            this.frmLojaToolStripMenuItem.Name = "frmLojaToolStripMenuItem";
            this.frmLojaToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.frmLojaToolStripMenuItem.Text = "FrmAlimento";
            // 
            // frmLojaToolStripMenuItem1
            // 
            this.frmLojaToolStripMenuItem1.Name = "frmLojaToolStripMenuItem1";
            this.frmLojaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.frmLojaToolStripMenuItem1.Text = "FrmLoja";
            this.frmLojaToolStripMenuItem1.Click += new System.EventHandler(this.frmLojaToolStripMenuItem1_Click);
            // 
            // frmAlimentoToolStripMenuItem
            // 
            this.frmAlimentoToolStripMenuItem.Name = "frmAlimentoToolStripMenuItem";
            this.frmAlimentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.frmAlimentoToolStripMenuItem.Text = "FrmPrefeito";
            this.frmAlimentoToolStripMenuItem.Click += new System.EventHandler(this.frmAlimentoToolStripMenuItem_Click);
            // 
            // Pnl_alimento
            // 
            this.Pnl_alimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Pnl_alimento.Controls.Add(this.btn_salvar);
            this.Pnl_alimento.Controls.Add(this.btn_limpar);
            this.Pnl_alimento.Location = new System.Drawing.Point(0, 270);
            this.Pnl_alimento.Name = "Pnl_alimento";
            this.Pnl_alimento.Size = new System.Drawing.Size(403, 30);
            this.Pnl_alimento.TabIndex = 2;
            // 
            // txt_valoraumento
            // 
            this.txt_valoraumento.Location = new System.Drawing.Point(272, 225);
            this.txt_valoraumento.Name = "txt_valoraumento";
            this.txt_valoraumento.Size = new System.Drawing.Size(109, 20);
            this.txt_valoraumento.TabIndex = 33;
            // 
            // lbl_valoraumento
            // 
            this.lbl_valoraumento.AutoSize = true;
            this.lbl_valoraumento.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valoraumento.Location = new System.Drawing.Point(10, 220);
            this.lbl_valoraumento.Name = "lbl_valoraumento";
            this.lbl_valoraumento.Size = new System.Drawing.Size(237, 23);
            this.lbl_valoraumento.TabIndex = 32;
            this.lbl_valoraumento.Text = "Valor com 10% de aumento:";
            // 
            // txt_valorcompra
            // 
            this.txt_valorcompra.Location = new System.Drawing.Point(172, 185);
            this.txt_valorcompra.Name = "txt_valorcompra";
            this.txt_valorcompra.Size = new System.Drawing.Size(109, 20);
            this.txt_valorcompra.TabIndex = 31;
            // 
            // lbl_valorcompra
            // 
            this.lbl_valorcompra.AutoSize = true;
            this.lbl_valorcompra.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorcompra.Location = new System.Drawing.Point(11, 182);
            this.lbl_valorcompra.Name = "lbl_valorcompra";
            this.lbl_valorcompra.Size = new System.Drawing.Size(155, 23);
            this.lbl_valorcompra.TabIndex = 30;
            this.lbl_valorcompra.Text = "Valor da Compra:";
            // 
            // txt_calorias
            // 
            this.txt_calorias.Location = new System.Drawing.Point(103, 141);
            this.txt_calorias.Name = "txt_calorias";
            this.txt_calorias.Size = new System.Drawing.Size(109, 20);
            this.txt_calorias.TabIndex = 29;
            // 
            // lbl_calorias
            // 
            this.lbl_calorias.AutoSize = true;
            this.lbl_calorias.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calorias.Location = new System.Drawing.Point(12, 141);
            this.lbl_calorias.Name = "lbl_calorias";
            this.lbl_calorias.Size = new System.Drawing.Size(85, 23);
            this.lbl_calorias.TabIndex = 28;
            this.lbl_calorias.Text = "Calorias:";
            // 
            // txt_ing
            // 
            this.txt_ing.Location = new System.Drawing.Point(138, 101);
            this.txt_ing.Name = "txt_ing";
            this.txt_ing.Size = new System.Drawing.Size(109, 20);
            this.txt_ing.TabIndex = 27;
            // 
            // lbl_ing
            // 
            this.lbl_ing.AutoSize = true;
            this.lbl_ing.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ing.Location = new System.Drawing.Point(12, 98);
            this.lbl_ing.Name = "lbl_ing";
            this.lbl_ing.Size = new System.Drawing.Size(120, 23);
            this.lbl_ing.TabIndex = 26;
            this.lbl_ing.Text = "Ingredientes:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(81, 58);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(109, 20);
            this.txt_nome.TabIndex = 25;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(12, 51);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(63, 23);
            this.lbl_nome.TabIndex = 24;
            this.lbl_nome.Text = "Nome:";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(228, 3);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 0;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(316, 3);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 34;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            // 
            // FrmAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 298);
            this.Controls.Add(this.txt_valoraumento);
            this.Controls.Add(this.lbl_valoraumento);
            this.Controls.Add(this.txt_valorcompra);
            this.Controls.Add(this.lbl_valorcompra);
            this.Controls.Add(this.txt_calorias);
            this.Controls.Add(this.lbl_calorias);
            this.Controls.Add(this.txt_ing);
            this.Controls.Add(this.lbl_ing);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.Pnl_alimento);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmAlimento";
            this.Text = "FrmAlimento";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Pnl_alimento.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem frmLojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmLojaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem frmAlimentoToolStripMenuItem;
        private System.Windows.Forms.Panel Pnl_alimento;
        private System.Windows.Forms.TextBox txt_valoraumento;
        private System.Windows.Forms.Label lbl_valoraumento;
        private System.Windows.Forms.TextBox txt_valorcompra;
        private System.Windows.Forms.Label lbl_valorcompra;
        private System.Windows.Forms.TextBox txt_calorias;
        private System.Windows.Forms.Label lbl_calorias;
        private System.Windows.Forms.TextBox txt_ing;
        private System.Windows.Forms.Label lbl_ing;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_limpar;
    }
}