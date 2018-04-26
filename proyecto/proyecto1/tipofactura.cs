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
    public partial class tipofactura : Form
    {
        MySqlConnection Conexion = new MySqlConnection("Data Source=localhost;Database=comercialbatz;User ID=root;Password='';");
        public tipofactura()
        {
            InitializeComponent();
        }

        private void tipofactura_Load(object sender, EventArgs e)
        {
            try { 
            Conexion.Open();
            MySqlDataAdapter mostrar = new MySqlDataAdapter("select * from tipo;", Conexion);
            DataTable datos = new DataTable();
            mostrar.Fill(datos);
            dataGridView1.DataSource = datos;
            Conexion.Close();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            Conexion.Open();
            MySqlCommand us = new MySqlCommand("INSERT INTO tipo(nombre) VALUES('" + textBox1.Text + "')", Conexion);
            us.ExecuteNonQuery();
            Conexion.Close();
            MessageBox.Show("Tipo guardado correctamente");
            this.Close();
            }
            catch { }
        }
    }
}
