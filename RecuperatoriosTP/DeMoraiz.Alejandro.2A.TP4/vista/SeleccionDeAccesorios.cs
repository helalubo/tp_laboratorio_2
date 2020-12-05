using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vista
{

    /// <summary>
    /// Clase de tipo Form para seleccion de Accesorios musicales
    /// </summary>
    public partial class SeleccionDeAccesorios : Form
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
        public SeleccionDeAccesorios()
        {
            InitializeComponent();



            this.StartPosition = FormStartPosition.CenterScreen;




        }

        #endregion














        #region DataAdapter


        /// <summary>
        /// Configuro DataAdapter para la busqueda de los Accesorios mediante un textbox 
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

                this.da.SelectCommand = new SqlCommand("SELECT * from Accesorios where nombre like '%"+ this.textBoxBuscar.Text  +"%';", accesoADatos.Conexion);


                rta = true;
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
        /// Configuracion de DataTable para compatibilidad con Accesorios
        /// </summary>
        private void ConfigurarDataTable()
        {
            this.dt = new DataTable("Accesorios");

            this.dt.Columns.Add("id", typeof(int));
            this.dt.Columns.Add("nombre", typeof(string));
            this.dt.Columns.Add("precio", typeof(float));
            this.dt.Columns.Add("cantidad", typeof(int));
            this.dt.Columns.Add("gama", typeof(int));
            this.dt.Columns.Add("tipo", typeof(int));

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
            this.dgvGrilla.RowsDefaultCellStyle.BackColor = Color.LightSteelBlue;

            // Alterno colores
            this.dgvGrilla.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue;

            // Pongo color de fondo a la grilla
            this.dgvGrilla.BackgroundColor = Color.LightSteelBlue;

            // Defino fuente para el encabezado y alineación del encabezado
            this.dgvGrilla.ColumnHeadersDefaultCellStyle.Font = new Font(dgvGrilla.Font, FontStyle.Bold);
            this.dgvGrilla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Defino el color de las lineas de separación
            this.dgvGrilla.GridColor = Color.MidnightBlue;

            // La grilla será de sólo lectura
            this.dgvGrilla.ReadOnly = false;

            // No permito la multiselección
            this.dgvGrilla.MultiSelect = true;

            // Selecciono toda la fila a la vez // FullRowSelect
            this.dgvGrilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Hago que las columnas ocupen todo el ancho del 'DataGrid'
            this.dgvGrilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Indico el color de la fila seleccionada
            this.dgvGrilla.RowsDefaultCellStyle.SelectionBackColor = Color.Black;
            this.dgvGrilla.RowsDefaultCellStyle.SelectionForeColor = Color.White;

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
        ///Selecciono un accesorio de DataGridView y traigo sus campos mediante el id, 
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


                this.da.SelectCommand = new SqlCommand("select id , nombre,precio ,cantidad  from Accesorios where id = " + id + ";", accesoADatos.Conexion);


                this.da.Fill(this.dt);



                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

       
    }
}
