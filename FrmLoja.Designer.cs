
namespace Classes_Nome
{
    partial class FrmLoja
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
            this.Pnl_loja = new System.Windows.Forms.Panel();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.txt_comp = new System.Windows.Forms.TextBox();
            this.lbl_comp = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.lbl_num = new System.Windows.Forms.Label();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.lbl_rua = new System.Windows.Forms.Label();
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.txt_cnpj = new System.Windows.Forms.TextBox();
            this.lbl_cnpj = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.Pnl_loja.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Fuchsia;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmLojaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(540, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmLojaToolStripMenuItem
            // 
            this.frmLojaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmLojaToolStripMenuItem1,
            this.frmAlimentoToolStripMenuItem});
            this.frmLojaToolStripMenuItem.Name = "frmLojaToolStripMenuItem";
            this.frmLojaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.frmLojaToolStripMenuItem.Text = "FrmLoja";
            // 
            // frmLojaToolStripMenuItem1
            // 
            this.frmLojaToolStripMenuItem1.Name = "frmLojaToolStripMenuItem1";
            this.frmLojaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.frmLojaToolStripMenuItem1.Text = "FrmPrefeito";
            this.frmLojaToolStripMenuItem1.Click += new System.EventHandler(this.frmLojaToolStripMenuItem1_Click);
            // 
            // frmAlimentoToolStripMenuItem
            // 
            this.frmAlimentoToolStripMenuItem.Name = "frmAlimentoToolStripMenuItem";
            this.frmAlimentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.frmAlimentoToolStripMenuItem.Text = "FrmAlimento";
            this.frmAlimentoToolStripMenuItem.Click += new System.EventHandler(this.frmAlimentoToolStripMenuItem_Click);
            // 
            // Pnl_loja
            // 
            this.Pnl_loja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Pnl_loja.Controls.Add(this.btn_salvar);
            this.Pnl_loja.Controls.Add(this.btn_limpar);
            this.Pnl_loja.Location = new System.Drawing.Point(0, 266);
            this.Pnl_loja.Name = "Pnl_loja";
            this.Pnl_loja.Size = new System.Drawing.Size(540, 31);
            this.Pnl_loja.TabIndex = 2;
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(406, 224);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Size = new System.Drawing.Size(109, 20);
            this.txt_pais.TabIndex = 45;
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pais.Location = new System.Drawing.Point(349, 219);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(51, 23);
            this.lbl_pais.TabIndex = 44;
            this.lbl_pais.Text = "País:";
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(414, 181);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(109, 20);
            this.txt_estado.TabIndex = 43;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(337, 176);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(71, 23);
            this.lbl_estado.TabIndex = 42;
            this.lbl_estado.Text = "Estado:";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(415, 135);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(109, 20);
            this.txt_cidade.TabIndex = 41;
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.Location = new System.Drawing.Point(341, 135);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(71, 23);
            this.lbl_cidade.TabIndex = 40;
            this.lbl_cidade.Text = "Cidade:";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(410, 97);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(109, 20);
            this.txt_bairro.TabIndex = 39;
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bairro.Location = new System.Drawing.Point(337, 92);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(67, 23);
            this.lbl_bairro.TabIndex = 38;
            this.lbl_bairro.Text = "Bairro:";
            // 
            // txt_comp
            // 
            this.txt_comp.Location = new System.Drawing.Point(415, 50);
            this.txt_comp.Name = "txt_comp";
            this.txt_comp.Size = new System.Drawing.Size(109, 20);
            this.txt_comp.TabIndex = 37;
            // 
            // lbl_comp
            // 
            this.lbl_comp.AutoSize = true;
            this.lbl_comp.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comp.Location = new System.Drawing.Point(326, 47);
            this.lbl_comp.Name = "lbl_comp";
            this.lbl_comp.Size = new System.Drawing.Size(82, 23);
            this.lbl_comp.TabIndex = 36;
            this.lbl_comp.Text = "Comple.:";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(122, 221);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(109, 20);
            this.txt_num.TabIndex = 35;
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num.Location = new System.Drawing.Point(34, 216);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(82, 23);
            this.lbl_num.TabIndex = 34;
            this.lbl_num.Text = "Número:";
            // 
            // txt_rua
            // 
            this.txt_rua.Location = new System.Drawing.Point(122, 178);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(109, 20);
            this.txt_rua.TabIndex = 33;
            // 
            // lbl_rua
            // 
            this.lbl_rua.AutoSize = true;
            this.lbl_rua.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rua.Location = new System.Drawing.Point(36, 171);
            this.lbl_rua.Name = "lbl_rua";
            this.lbl_rua.Size = new System.Drawing.Size(80, 23);
            this.lbl_rua.TabIndex = 32;
            this.lbl_rua.Text = "Rua/ AV:";
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(105, 138);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(109, 20);
            this.txt_cep.TabIndex = 31;
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cep.Location = new System.Drawing.Point(36, 133);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(48, 23);
            this.lbl_cep.TabIndex = 30;
            this.lbl_cep.Text = "CEP:";
            // 
            // txt_cnpj
            // 
            this.txt_cnpj.Location = new System.Drawing.Point(102, 95);
            this.txt_cnpj.Name = "txt_cnpj";
            this.txt_cnpj.Size = new System.Drawing.Size(109, 20);
            this.txt_cnpj.TabIndex = 27;
            // 
            // lbl_cnpj
            // 
            this.lbl_cnpj.AutoSize = true;
            this.lbl_cnpj.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cnpj.Location = new System.Drawing.Point(36, 92);
            this.lbl_cnpj.Name = "lbl_cnpj";
            this.lbl_cnpj.Size = new System.Drawing.Size(60, 23);
            this.lbl_cnpj.TabIndex = 26;
            this.lbl_cnpj.Text = "CNPJ:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(183, 47);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(109, 20);
            this.txt_nome.TabIndex = 25;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(36, 47);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(141, 23);
            this.lbl_nome.TabIndex = 24;
            this.lbl_nome.Text = "Nome Fantasia:";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(325, 3);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 0;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(425, 3);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 46;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            // 
            // FrmLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 295);
            this.Controls.Add(this.txt_pais);
            this.Controls.Add(this.lbl_pais);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.lbl_bairro);
            this.Controls.Add(this.txt_comp);
            this.Controls.Add(this.lbl_comp);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.txt_rua);
            this.Controls.Add(this.lbl_rua);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.lbl_cep);
            this.Controls.Add(this.txt_cnpj);
            this.Controls.Add(this.lbl_cnpj);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.Pnl_loja);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmLoja";
            this.Text = "FrmLoja";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Pnl_loja.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem frmLojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmLojaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem frmAlimentoToolStripMenuItem;
        private System.Windows.Forms.Panel Pnl_loja;
        private System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.TextBox txt_comp;
        private System.Windows.Forms.Label lbl_comp;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.Label lbl_rua;
        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.TextBox txt_cnpj;
        private System.Windows.Forms.Label lbl_cnpj;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_limpar;
    }
}