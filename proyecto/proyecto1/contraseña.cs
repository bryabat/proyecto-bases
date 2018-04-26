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
    public partial class contraseña : Form
    {
        MySqlConnection Conexion = new MySqlConnection("Data Source=localhost;Database=comercialbatz;User ID=root;Password='';");
        string ya,cadena;
        public contraseña()
        {
            InitializeComponent();
        }
        DataSet resultados = new DataSet();
        DataView miflito;
        public void leer_datos(string query, ref DataSet dstprincipal, string tabla)
        {
            Conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, Conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dstprincipal, tabla);
                da.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexion.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Conexion.Open();
            MySqlCommand codp = new MySqlCommand("select usuario.password from usuario where usuario.id_usuario = '" + textBox2.Text + "' limit 1;", Conexion);
            MySqlDataReader resultado3 = codp.ExecuteReader();
            while (resultado3.Read())
            {
                cadena = Convert.ToString(resultado3[0]);
                ya = encriptado.descifrar(cadena);

            }
            
            Conexion.Close();
            MessageBox.Show(ya);
            this.Close();
        }

        private void contraseña_Load(object sender, EventArgs e)
        {
            this.leer_datos("SELECT usuario.id_usuario,usuario.nombre_usuario FROM usuario", ref resultados, "usuario");
            miflito = ((DataTable)resultados.Tables["usuario"]).DefaultView;
            this.dataGridView1.DataSource = miflito;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string salida_datos = "";
            string[] palabras_busqueda = textBox1.Text.Split(' ');

            foreach (string palabra in palabras_busqueda)
            {
                if (salida_datos.Length == 0)
                {
                    salida_datos = "(nombre_usuario LIKE '%" + palabra + "%')";
                }
                else
                {
                    salida_datos += "AND (nombre_usuario LIKE '%" + palabra + "%')";
                }
            }
            miflito.RowFilter = salida_datos;
        }
    }
}
