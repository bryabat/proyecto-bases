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
    public partial class anular : Form
    {
        public anular()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
                DialogResult result = MessageBox.Show("desea anular la factura ?", "AVISO", MessageBoxButtons.YesNo);
                  if (result == DialogResult.Yes)
                    {
                    BUSQUEDAFACTURA.idproduc = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                }
                }
            catch { }
            
        }
    }
}
