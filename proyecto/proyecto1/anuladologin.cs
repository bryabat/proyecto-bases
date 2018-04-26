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
    public partial class anuladologin : Form
    {
        public anuladologin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand ccmd = new MySqlCommand();
            ccmd.Connection = conexion.ObtnerCOnexion();

            string nuestra_cadena = txtpasword.Text;
            string ya = "";
            ya = encriptado.cifrar(nuestra_cadena);


            try
            {
                ccmd.CommandText = "SELECT count(*) from usuario where nombre_usuario ='" + txtnombre.Text + "'and password = '" + ya + "'and Autorizacion ='1';";
                int valor = int.Parse(ccmd.ExecuteScalar().ToString());
                if (valor == 1)
                {
                    anular f = new anular();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }

                ccmd.CommandText = "select count(*) from usuario where nombre_usuario ='" + txtnombre.Text + "'and password = '" + ya + "'and Autorizacion ='0';";
                valor = int.Parse(ccmd.ExecuteScalar().ToString());
                if (valor == 1)
                {
                    MessageBox.Show("¡ no tiene autorizacion!");
                }

                ccmd.CommandText = "select count(*) from usuario where nombre_usuario ='" + txtnombre.Text + "'and password = '" + ya + "'and Autorizacion ='3';";
                valor = int.Parse(ccmd.ExecuteScalar().ToString());
                if (valor == 1)
                {
                    MessageBox.Show("¡Ya no tiene autorizacion!");
                }

                ccmd.CommandText = "select count(*) from usuario where nombre_usuario ='" + txtnombre.Text + "'and password = '" + ya + "';";
                valor = int.Parse(ccmd.ExecuteScalar().ToString());
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

        private void textBoxnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void anuladologin_Load(object sender, EventArgs e)
        {

        }
    }
}
