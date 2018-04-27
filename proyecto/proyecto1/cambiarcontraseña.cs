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
    public partial class cambiarcontraseña : Form
    {
        public cambiarcontraseña()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cambiarcontraseña_Load(object sender, EventArgs e)
        {
            try
            {
            MySqlConnection cmd = new MySqlConnection();
            cmd = conexion.ObtnerCOnexion();
           

                MySqlDataAdapter mostrar = new MySqlDataAdapter("select * from facturas;", cmd);
                DataTable datos = new DataTable();
                mostrar.Fill(datos);
                dataGridView1.DataSource = datos;

            }

            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
