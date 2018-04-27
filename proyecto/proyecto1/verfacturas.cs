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
    public partial class verfacturas : Form
    {
        public verfacturas()
        {
            InitializeComponent();
        }

        private void verfacturas_Load(object sender, EventArgs e)
        {
            MySqlConnection cmd = new MySqlConnection();
            cmd = conexion.ObtnerCOnexion();
            try {
                cmd.Open();
                MySqlDataAdapter mostrar = new MySqlDataAdapter("select * from facturas;", cmd);
                DataTable datos = new DataTable();
                mostrar.Fill(datos);
                dataGridView1.DataSource = datos;
                cmd.Close();

            }

            catch { }

        }
    }
}
