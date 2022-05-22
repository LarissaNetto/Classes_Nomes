using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes_Nome
{
    public partial class FrmPrefeito : Form
    {
        public FrmPrefeito()
        {
            InitializeComponent();
        }

        private void frmLojaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLojaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLoja frm = new FrmLoja();
            this.Hide();
            frm.ShowDialog();
        }

        private void frmAlimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlimento frm = new FrmAlimento();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
