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
   
    public partial class agregarpersona : Form
    {
        MySqlConnection Conexion = new MySqlConnection("Data Source=localhost;Database=comercialbatz;User ID=root;Password='';");
        public agregarpersona()
        {
            InitializeComponent();
        }

        private void agregarpersona_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxNombre_Enter(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.Open();
                MySqlCommand us = new MySqlCommand("call RAagregarpersonal('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')", Conexion);
                us.ExecuteNonQuery();
                Conexion.Close();
                MessageBox.Show("Usuario guardado correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
