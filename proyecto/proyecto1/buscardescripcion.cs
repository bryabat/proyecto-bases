﻿using System;
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
    public partial class buscardescripcion : Form
    {
        MySqlConnection Conexion = new MySqlConnection("Data Source=localhost;Database=comercialbatz;User ID=root;Password='';");
        public buscardescripcion()
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

        private void buscardescripcion_Load(object sender, EventArgs e)
        {
            this.leer_datos("SELECT productos.descripcion,productos.nombre,productos.modelo,productos.marca,productos.existencia,productos.precio FROM productos", ref resultados, "productos");
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
                    salida_datos = "(descripcion LIKE '%" + palabra + "%')";
                }
                else
                {
                    salida_datos += "AND (descripcion LIKE '%" + palabra + "%')";
                }
            }
            miflito.RowFilter = salida_datos;
        }
    }
}
