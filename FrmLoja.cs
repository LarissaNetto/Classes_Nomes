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
    public partial class FrmLoja : Form
    {
        public FrmLoja()
        {
            InitializeComponent();
        }

        private void frmLojaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPrefeito frm = new FrmPrefeito();
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
