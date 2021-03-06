﻿using CapaDatos;
using Excepciones;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace vista
{


    /// <summary>
    /// Clase de tipo Form para seleccion de Instrumentos musicales
    /// </summary>

    public partial class SeleccionDeInstrumentos : Form
    {

        #region Campos

        public SqlDataAdapter da;
        public DataTable dt;









        #endregion






        #region Constructor 


        /// <summary>
        /// Constructor por defecto que inicializa al componente y lo setea 
        /// para que aparezca en el medio de la pantalla
        /// </summary>
        public SeleccionDeInstrumentos()
        {
            InitializeComponent();



            this.StartPosition = FormStartPosition.CenterScreen;




        }

        #endregion














        #region DataAdapter


        /// <summary>
        /// Configuro DataAdapter para la busqueda de los Instrumentos mediante un textbox 
        /// con conexion a base de datos
        /// </summary>
        /// <returns></returns>

        private bool ConfigurarDataAdapter()
        {
            bool rta = false;

            try
            {
                AccesoDatos accesoADatos = new AccesoDatos();




                this.da = new SqlDataAdapter();
                this.dt = new DataTable();

                this.da.SelectCommand = new SqlCommand("select * from Instrumento where nombre like '%" + this.textBoxBuscar.Text + "%'", accesoADatos.Conexion);


                rta = true;
                accesoADatos.Conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            return rta;
        }



        #endregion


        #region Datatable



        /// <summary>
        /// Configuracion de DataTable para compatibilidad con Instrumentos
        /// </summary>

        private void ConfigurarDataTable()
        {
            this.dt = new DataTable("Instrumento");

            this.dt.Columns.Add("id", typeof(int));
            this.dt.Columns.Add("nombre", typeof(string));
            this.dt.Columns.Add("precio", typeof(float));
            this.dt.Columns.Add("cantidad", typeof(int));
            this.dt.Columns.Add("origen", typeof(string));
            this.dt.Columns.Add("modelo", typeof(int));

            this.dt.PrimaryKey = new DataColumn[] { this.dt.Columns[0] };

            this.dt.Columns["id"].AutoIncrement = true;
            this.dt.Columns["id"].AutoIncrementSeed = 1;//obtener el último id insertado en la tabla
            this.dt.Columns["id"].AutoIncrementStep = 1;



        }

        #endregion

        #region DataGridView


        /// <summary>
        /// Configuracion de formato de DataGridView
        /// </summary>
        private void ConfigurarGrilla()
        {
            // Coloco color de fondo para las filas
            this.dgvGrilla.RowsDefaultCellStyle.BackColor = Color.MediumPurple;

            // Alterno colores
            this.dgvGrilla.AlternatingRowsDefaultCellStyle.BackColor = Color.MediumPurple;

            // Pongo color de fondo a la grilla
            this.dgvGrilla.BackgroundColor = Color.SteelBlue;

            // Defino fuente para el encabezado y alineación del encabezado
            this.dgvGrilla.ColumnHeadersDefaultCellStyle.Font = new Font(dgvGrilla.Font, FontStyle.Bold);
            this.dgvGrilla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Defino el color de las lineas de separación
            this.dgvGrilla.GridColor = Color.Black;

            // La grilla será de sólo lectura
            this.dgvGrilla.ReadOnly = false;

            // No permito la multiselección
            this.dgvGrilla.MultiSelect = false;

            // Selecciono toda la fila a la vez // FullRowSelect
            this.dgvGrilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Hago que las columnas ocupen todo el ancho del 'DataGrid'
            this.dgvGrilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Indico el color de la fila seleccionada
            this.dgvGrilla.RowsDefaultCellStyle.SelectionBackColor = Color.Black;
            this.dgvGrilla.RowsDefaultCellStyle.SelectionForeColor = Color.Green;

            // No permito modificar desde la grilla
            this.dgvGrilla.EditMode = DataGridViewEditMode.EditProgrammatically;

            // Saco los encabezados de las filas
            this.dgvGrilla.RowHeadersVisible = false;

        }




        #endregion


        /// <summary>
        /// LLama a los metodos que configurar DataAbapter, el dataTable y el DataGridView
        /// lleno el datatable con el dataAbapter y llena la grilla con el dataTable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.ConfigurarDataAdapter();
            this.ConfigurarDataTable();

            try
            {



                this.ConfigurarGrilla();


                this.da.Fill(this.dt);




                this.dgvGrilla.DataSource = this.dt;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




        }


        /// <summary>
        ///Selecciono un Producto de DataGridView y traigo sus campos mediante el id, 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void btnSeleccionProductos_Click(object sender, EventArgs e)
        {
           
            



            try
            {

                int i = this.dgvGrilla.SelectedRows[0].Index;


                DataRow fila = this.dt.Rows[i];

                string id = (fila["id"].ToString());


                AccesoDatos accesoADatos = new AccesoDatos();




                this.da = new SqlDataAdapter();
                this.dt = new DataTable();


                this.da.SelectCommand = new SqlCommand("select id , nombre,precio ,cantidad  from Instrumento where id = " + id + ";", accesoADatos.Conexion);



                this.da.Fill(this.dt);



                this.Close();

            }

            catch (Exception ex1)
            {
                ///creo SeleccionInvalidaException 
                MessageBox.Show(ex1.Message);

            }


        }


    }
}
