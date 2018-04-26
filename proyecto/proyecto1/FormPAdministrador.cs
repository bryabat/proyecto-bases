using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace proyecto1
{
    public partial class FormPAdministrador : Form
    {
        MySqlConnection Conexion = new MySqlConnection("Data Source=localhost;Database=comercialbatz;User ID=root;Password='';");
        public FormPAdministrador()
        {
            InitializeComponent();
        }

        private void cREARUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroU form = new RegistroU();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void rEGISTRODEPRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroProductos form = new RegistroProductos();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void eLIMINARUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DespedirUsuario form = new DespedirUsuario();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void bUSCARPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rEALIZARVENTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int deafault = 0;
            Conexion.Open();
            MySqlCommand Guardar1 = new MySqlCommand("INSERT INTO factura (total_Venta) VALUES('" + deafault + "')", Conexion);
            Guardar1.ExecuteNonQuery();
            Conexion.Close();

            
  this.Close();
            this.Hide();
            BUSQUEDAFACTURA.form1.ShowDialog();
            this.Show();
          
        }

        private void rEGISTRARPROVEEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
           proveedores form = new proveedores();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void rEPORTEDEPRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductoAgotado form = new ProductoAgotado ();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void rEGISTRARCLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregarclientesinfacturA form = new agregarclientesinfacturA();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void FormPAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregarpersona form = new agregarpersona();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void pRODUCTOSAGOTADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductoAgotado form = new ProductoAgotado();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void rECUPERARCONTRASEÑAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contraseña form = new contraseña();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void rEGISTRODEVENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        private void rEPORTEDECLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vERCLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tOTALQDIAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rEGISTRODEVENTASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tipofactura form = new tipofactura();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void realizarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            realizar_pago form = new realizar_pago();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saldo form = new saldo();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
