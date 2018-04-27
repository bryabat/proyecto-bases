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
    public partial class proveedores : Form
    {
        MySqlConnection Conexion = new MySqlConnection("Data Source=localhost;Database=comercialbatz;User ID=root;Password='';");
        public proveedores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Conexion.Open();

            MySqlCommand Guardar1 = new MySqlCommand("CALL RAproveedores('" + txtnombre.Text + "','" + txtapellido.Text + "','" + txtTelefono.Text + "')", Conexion);
            // MySqlCommand Guardar1 = new MySqlCommand("INSERT INTO proveedor (nombre,apellido,telefono) VALUES('" + txtnombre.Text + "','" + txtapellido.Text + "','" + txtTelefono.Text + "')", Conexion);
            Guardar1.ExecuteNonQuery();
            Conexion.Close();
            MessageBox.Show("nuevo Proveedor agregado correctamente");
            this.Close();
        }

        private void proveedores_Load(object sender, EventArgs e)
        {

        }
    }
}
