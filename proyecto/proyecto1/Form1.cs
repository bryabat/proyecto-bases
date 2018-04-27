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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            BUSQUEDAFACTURA.usuarioventa = txtnombre.Text;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion.ObtnerCOnexion();

            string nuestra_cadena = txtpasword.Text;
            string ya = "";
            ya = encriptado.cifrar(nuestra_cadena);


            try
            {
                cmd.CommandText = "SELECT count(*) from usuario where nombre_usuario ='" + txtnombre.Text + "'and password = '" + ya + "'and Autorizacion ='1';";
                int valor = int.Parse(cmd.ExecuteScalar().ToString());
                if (valor == 1)
                {
                    FormPAdministrador f = new FormPAdministrador();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }

                cmd.CommandText = "select count(*) from usuario where nombre_usuario ='" + txtnombre.Text + "'and password = '" + ya + "'and Autorizacion ='0';";
                valor = int.Parse(cmd.ExecuteScalar().ToString());
                if (valor == 1)
                {
                    FormUsuarioC f = new FormUsuarioC();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }

                cmd.CommandText = "select count(*) from usuario where nombre_usuario ='" + txtnombre.Text + "'and password = '" + ya + "'and Autorizacion ='3';";
                valor = int.Parse(cmd.ExecuteScalar().ToString());
                if (valor == 1)
                {
                    MessageBox.Show("¡Ya no tiene autorizacion!");
                }

                cmd.CommandText = "select count(*) from usuario where nombre_usuario ='" + txtnombre.Text + "'and password = '" + ya + "';";
                valor = int.Parse(cmd.ExecuteScalar().ToString());
                if (valor == 0)
                {
                    MessageBox.Show("¡Acceso Denegado!");
                }
            }
            catch (Exception ex) { MessageBox.Show("Error en " + ex); }
            // conexion.ObtnerCOnexion.Close();
            txtnombre.Text = "";
            txtpasword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroU form = new RegistroU();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
