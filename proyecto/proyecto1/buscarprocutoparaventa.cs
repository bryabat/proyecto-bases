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
using Microsoft.VisualBasic;
namespace proyecto1
{
    public partial class buscarprocutoparaventa : Form
    {
        MySqlConnection Conexion = new MySqlConnection("Data Source=localhost;Database=comercialbatz;User ID=root;Password='';");
        public buscarprocutoparaventa()
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
        private void carrito_Click(object sender, EventArgs e)
        {
            try {

                DialogResult result = MessageBox.Show("Agregar al carrito ?", "AVISO", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string numeroavendertxt;
             
                    numeroavendertxt = Interaction.InputBox("Ingrese la cantidad a vender","CANTIDAD","0",1,100);
                    BUSQUEDAFACTURA.cantidadvender = Convert.ToInt32(numeroavendertxt);
                    BUSQUEDAFACTURA.idproduc = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    BUSQUEDAFACTURA.nombre = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    BUSQUEDAFACTURA.precio = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    double precioo;
                    precioo=double.Parse(BUSQUEDAFACTURA.precio);
                    BUSQUEDAFACTURA.subtotal = BUSQUEDAFACTURA.cantidadvender * precioo;


                }
              

                BUSQUEDAFACTURA.nombre = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                BUSQUEDAFACTURA.form1.labelnombre.Text = BUSQUEDAFACTURA.nombre;
            this.Close();




                }
            catch (Exception ex) { MessageBox.Show("Error en " + ex); }
        }

        private void buscarprocutoparaventa_Load(object sender, EventArgs e)
        {
            this.leer_datos("select productos.id_productos,productos.nombre,productos.modelo,productos.marca,productos.precio,productos.descripcion from productos", ref resultados, "productos");
            miflito = ((DataTable)resultados.Tables["productos"]).DefaultView;
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
                    salida_datos = "(nombre LIKE '%" + palabra + "%' OR grupo LIKE '%" + palabra + "%')";
                }
                else
                {
                    salida_datos += "AND (nombre LIKE '%" + palabra + "%' OR grupo LIKE '%" + palabra + "%')";
                }
            }
            miflito.RowFilter = salida_datos;
        }
    }
}
