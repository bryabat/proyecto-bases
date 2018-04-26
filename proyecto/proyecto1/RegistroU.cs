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
    public partial class RegistroU : Form
    {
        string a;
        MySqlConnection Conexion = new MySqlConnection("Data Source=localhost;Database=comercialbatz;User ID=root;Password='';");
        public RegistroU()
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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                a = "1";
            }
            if (radioButton2.Checked)
            {
                a = "0";
            }
            string nuestra_cadena = txtpasword.Text;
            string ya = "";
            ya = encriptado.cifrar(nuestra_cadena);


            if (txtpasword.Text == textpasword2.Text)
            {
                Conexion.Open();
                MySqlCommand us = new MySqlCommand("INSERT INTO usuario(nombre_usuario,Autorizacion,password,empleados_id) VALUES('" + txtnombre.Text + "','" + a + "','" + ya + "','" + textBox2.Text + "')", Conexion);
                us.ExecuteNonQuery();
                Conexion.Close();
                MessageBox.Show("Usuario guardado correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo crear la cuenta");

            }
        }

        private void RegistroU_Load(object sender, EventArgs e)
        {
            this.leer_datos("SELECT * FROM empleados", ref resultados, "empleados");
            miflito = ((DataTable)resultados.Tables["empleados"]).DefaultView;
            this.dataGridView1.DataSource = miflito;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string salida_datos = "";
            string[] palabras_busqueda = textBox1.Text.Split(' ');

            foreach (string palabra in palabras_busqueda)
            {
                if (salida_datos.Length == 0)
                {
                    salida_datos = "(nombres LIKE '%" + palabra + "%' OR apellidos LIKE '%" + palabra + "%')";
                }
                else
                {
                    salida_datos += "AND (nombres LIKE '%" + palabra + "%' OR apellidos LIKE '%" + palabra + "%')";
                }
            }
            miflito.RowFilter = salida_datos;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
