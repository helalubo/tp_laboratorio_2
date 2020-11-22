﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace vista
{
    public partial class frmPrincipal : Form
    {

      

        public SqlDataAdapter da;
        public DataTable dt;
        public SeleccionDeInstrumentos frmSeleccionar;


        Thread seleccionandoProductos;



        public frmPrincipal()
        {

         
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
          
            ConfigurarGrilla();
           



        }

        private void btnCargarInstrumento_Click(object sender, EventArgs e)
        {
            this.frmSeleccionar = new SeleccionDeInstrumentos();
            this.frmSeleccionar.Show();

        }

     
        public void configuracionDataTable() 
            {
            this.dt = new DataTable("Producto");

            this.dt.Columns.Add("id", typeof(int));
            this.dt.Columns.Add("nombre", typeof(string));
            this.dt.Columns.Add("precio", typeof(float));
            this.dt.Columns.Add("cantidad", typeof(int));


            this.dt.PrimaryKey = new DataColumn[] { this.dt.Columns[0] };

            this.dt.Columns["id"].AutoIncrement = true;
            this.dt.Columns["id"].AutoIncrementSeed = 1;//obtener el último id insertado en la tabla
            this.dt.Columns["id"].AutoIncrementStep = 1;

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConfigurarGrilla()
        {
            // Coloco color de fondo para las filas
            this.dgvPrincipal.RowsDefaultCellStyle.BackColor = Color.Wheat;

            // Alterno colores
            this.dgvPrincipal.AlternatingRowsDefaultCellStyle.BackColor = Color.BurlyWood;

            // Pongo color de fondo a la grilla
            this.dgvPrincipal.BackgroundColor = Color.Beige;

            // Defino fuente para el encabezado y alineación del encabezado
            this.dgvPrincipal.ColumnHeadersDefaultCellStyle.Font = new Font(dgvPrincipal.Font, FontStyle.Bold);
            this.dgvPrincipal.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Defino el color de las lineas de separación
            this.dgvPrincipal.GridColor = Color.HotPink;

            // La grilla será de sólo lectura
            this.dgvPrincipal.ReadOnly = false;

            // No permito la multiselección
            this.dgvPrincipal.MultiSelect = false;

            // Selecciono toda la fila a la vez
            this.dgvPrincipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Hago que las columnas ocupen todo el ancho del 'DataGrid'
            this.dgvPrincipal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Indico el color de la fila seleccionada
            this.dgvPrincipal.RowsDefaultCellStyle.SelectionBackColor = Color.DarkOliveGreen;
            this.dgvPrincipal.RowsDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            // No permito modificar desde la grilla
            this.dgvPrincipal.EditMode = DataGridViewEditMode.EditProgrammatically;

            // Saco los encabezados de las filas
            this.dgvPrincipal.RowHeadersVisible = false;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            /// Aca inicializar hilo

            
            this.dgvPrincipal.DataSource = frmSeleccionar.dt;

        }

      



    }
}