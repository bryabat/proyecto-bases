using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1
{
    public partial class FormUsuarioC : Form
    {
        public FormUsuarioC()
        {
            InitializeComponent();
        }

        private void rEGISTRODEVENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroU form = new RegistroU();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void rEGISTRODEVENTASToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void FormUsuarioC_Load(object sender, EventArgs e)
        {

        }

        private void nOMBREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarproducto form = new buscarproducto();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void gRUPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscargrupo form = new buscargrupo();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void mARCAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarmarca form = new buscarmarca();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void dESCRIPCIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscardescripcion form = new buscardescripcion();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void mODELOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarmodelo form = new buscarmodelo();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
