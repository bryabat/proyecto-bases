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
    public partial class coneccion : Form
    {
        public coneccion()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void coneccion_Load(object sender, EventArgs e)
        {

        }

        private void btnModificarConexion_Click(object sender, EventArgs e)
        {
            MySqlConnection cmd = new MySqlConnection();
            cmd = conexion.ObtnerCOnexion();
            try
            {
                cmd.Open();
                MySqlCommand Guardar1 = new MySqlCommand("call RAcambiarservidor('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", cmd);
                Guardar1.ExecuteNonQuery();
                cmd.Close();
            }

            catch { }
        }
    }
}
