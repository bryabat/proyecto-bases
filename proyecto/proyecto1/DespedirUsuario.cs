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
    public partial class DespedirUsuario : Form
    {
        MySqlConnection Conexion = new MySqlConnection("Data Source=localhost;Database=comercialbatz;User ID=root;Password='';");
        public DespedirUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.Open();
            int a = 3;
            MySqlCommand Actualizar = new MySqlCommand("UPDATE usuario SET Autorizacion='" + a + "', comentario ='" + textBox1.Text + "' WHERE nombre_usuario= '" + txtEliminarU.Text + "'", Conexion);
            Actualizar.ExecuteNonQuery();
            Conexion.Close();
            MessageBox.Show("Usuario despedido");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            button1.Visible = true;
        }

        private void buttonVerUsuarios_Click(object sender, EventArgs e)
        {
            Conexion.Open();
            MySqlDataAdapter mostrar = new MySqlDataAdapter("select usuario.nombre_usuario,usuario.Autorizacion,usuario.comentario,usuario.empleados_id from usuario;", Conexion);
            DataTable datos = new DataTable();
            mostrar.Fill(datos);
            dataGridView1.DataSource = datos;
            Conexion.Close();
        }

        private void DespedirUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
