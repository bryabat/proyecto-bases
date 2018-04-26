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
    public partial class ProductoAgotado : Form
    {
        MySqlConnection Conexion = new MySqlConnection("Data Source=localhost;Database=proyecto1;User ID=root;Password='';");
        public ProductoAgotado()
        {
            InitializeComponent();
        }

        private void ProductoAgotado_Load(object sender, EventArgs e)
        {
            Conexion.Open();
            MySqlDataAdapter mostrar = new MySqlDataAdapter("select * from productos where productos.existencia<2;", Conexion);
            DataTable datos = new DataTable();
            mostrar.Fill(datos);
            dataGridView1.DataSource = datos;

        }
    }
}
