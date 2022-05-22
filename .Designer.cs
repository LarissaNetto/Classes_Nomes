
namespace Classes_Nome
{
    partial class FrmPrefeito
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.frmLojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmLojaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.frmAlimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.txt_dt = new System.Windows.Forms.TextBox();
            this.lbl_dt = new System.Windows.Forms.Label();
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.lbl_rua = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txt_comp = new System.Windows.Forms.TextBox();
            this.lbl_comp = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmLojaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(508, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmLojaToolStripMenuItem
            // 
            this.frmLojaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmLojaToolStripMenuItem1,
            this.frmAlimentoToolStripMenuItem});
            this.frmLojaToolStripMenuItem.Name = "frmLojaToolStripMenuItem";
            this.frmLojaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.frmLojaToolStripMenuItem.Text = "FrmPrefeito";
            this.frmLojaToolStripMenuItem.Click += new System.EventHandler(this.frmLojaToolStripMenuItem_Click);
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
            this.frmAlimentoToolStripMenuItem.Text = "FrmAlimento";
            this.frmAlimentoToolStripMenuItem.Click += new System.EventHandler(this.frmAlimentoToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 28);
            this.panel1.TabIndex = 1;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(12, 46);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(63, 23);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "Nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(81, 46);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(109, 20);
            this.txt_nome.TabIndex = 3;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(81, 86);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(109, 20);
            this.txt_cpf.TabIndex = 5;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(12, 83);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(48, 23);
            this.lbl_cpf.TabIndex = 4;
            this.lbl_cpf.Text = "CPF:";
            this.lbl_cpf.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_dt
            // 
            this.txt_dt.Location = new System.Drawing.Point(131, 129);
            this.txt_dt.Name = "txt_dt";
            this.txt_dt.Size = new System.Drawing.Size(109, 20);
            this.txt_dt.TabIndex = 7;
            // 
            // lbl_dt
            // 
            this.lbl_dt.AutoSize = true;
            this.lbl_dt.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dt.Location = new System.Drawing.Point(12, 124);
            this.lbl_dt.Name = "lbl_dt";
            this.lbl_dt.Size = new System.Drawing.Size(113, 23);
            this.lbl_dt.TabIndex = 6;
            this.lbl_dt.Text = "Dt de Nasci.:";
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(81, 173);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(109, 20);
            this.txt_cep.TabIndex = 9;
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cep.Location = new System.Drawing.Point(12, 168);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(48, 23);
            this.lbl_cep.TabIndex = 8;
            this.lbl_cep.Text = "CEP:";
            // 
            // txt_rua
            // 
            this.txt_rua.Location = new System.Drawing.Point(98, 213);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(109, 20);
            this.txt_rua.TabIndex = 11;
            // 
            // lbl_rua
            // 
            this.lbl_rua.AutoSize = true;
            this.lbl_rua.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rua.Location = new System.Drawing.Point(12, 206);
            this.lbl_rua.Name = "lbl_rua";
            this.lbl_rua.Size = new System.Drawing.Size(80, 23);
            this.lbl_rua.TabIndex = 10;
            this.lbl_rua.Text = "Rua/ AV:";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(98, 256);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(109, 20);
            this.txt_numero.TabIndex = 13;
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero.Location = new System.Drawing.Point(10, 251);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(82, 23);
            this.lbl_numero.TabIndex = 12;
            this.lbl_numero.Text = "Número:";
            // 
            // txt_comp
            // 
            this.txt_comp.Location = new System.Drawing.Point(371, 44);
            this.txt_comp.Name = "txt_comp";
            this.txt_comp.Size = new System.Drawing.Size(109, 20);
            this.txt_comp.TabIndex = 15;
            // 
            // lbl_comp
            // 
            this.lbl_comp.AutoSize = true;
            this.lbl_comp.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comp.Location = new System.Drawing.Point(283, 41);
            this.lbl_comp.Name = "lbl_comp";
            this.lbl_comp.Size = new System.Drawing.Size(82, 23);
            this.lbl_comp.TabIndex = 14;
            this.lbl_comp.Text = "Comple.:";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(366, 91);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(109, 20);
            this.txt_bairro.TabIndex = 17;
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bairro.Location = new System.Drawing.Point(293, 86);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(67, 23);
            this.lbl_bairro.TabIndex = 16;
            this.lbl_bairro.Text = "Bairro:";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(371, 129);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(109, 20);
            this.txt_cidade.TabIndex = 19;
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.Location = new System.Drawing.Point(297, 129);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(71, 23);
            this.lbl_cidade.TabIndex = 18;
            this.lbl_cidade.Text = "Cidade:";
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(362, 175);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(109, 20);
            this.txt_estado.TabIndex = 21;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(293, 170);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(71, 23);
            this.lbl_estado.TabIndex = 20;
            this.lbl_estado.Text = "Estado:";
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(362, 218);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Size = new System.Drawing.Size(109, 20);
            this.txt_pais.TabIndex = 23;
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pais.Location = new System.Drawing.Point(305, 213);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(51, 23);
            this.lbl_pais.TabIndex = 22;
            this.lbl_pais.Text = "País:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmPrefeito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 313);
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
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.txt_rua);
            this.Controls.Add(this.lbl_rua);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.lbl_cep);
            this.Controls.Add(this.txt_dt);
            this.Controls.Add(this.lbl_dt);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrefeito";
            this.Text = "FrmPrefeito";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem frmLojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmLojaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem frmAlimentoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.TextBox txt_dt;
        private System.Windows.Forms.Label lbl_dt;
        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.Label lbl_rua;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.TextBox txt_comp;
        private System.Windows.Forms.Label lbl_comp;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

