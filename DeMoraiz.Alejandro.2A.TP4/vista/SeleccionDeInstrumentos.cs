using CapaDatos;
using Entidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace vista
{
    public partial class SeleccionDeInstrumentos : Form
    {

        #region Campos

        public SqlDataAdapter da;
        public DataTable dt;


    






        #endregion






        #region Constructor 

        public SeleccionDeInstrumentos()
        {
            InitializeComponent();



            this.StartPosition = FormStartPosition.CenterScreen;




        }

        #endregion














        #region DataAdapter

        private bool ConfigurarDataAdapter()
        {
            bool rta = false;

            try
            {
                AccesoDatos accesoADatos = new AccesoDatos();




                this.da = new SqlDataAdapter();
                this.dt = new DataTable();

                this.da.SelectCommand = new SqlCommand("select id, nombre,precio,cantidad from Instrumento where nombre like '%" + this.textBoxBuscar.Text + "%'", accesoADatos.Conexion);


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

        private void ConfigurarGrilla()
        {
            // Coloco color de fondo para las filas
            this.dgvGrilla.RowsDefaultCellStyle.BackColor = Color.Wheat;

            // Alterno colores
            this.dgvGrilla.AlternatingRowsDefaultCellStyle.BackColor = Color.BurlyWood;

            // Pongo color de fondo a la grilla
            this.dgvGrilla.BackgroundColor = Color.Beige;

            // Defino fuente para el encabezado y alineación del encabezado
            this.dgvGrilla.ColumnHeadersDefaultCellStyle.Font = new Font(dgvGrilla.Font, FontStyle.Bold);
            this.dgvGrilla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Defino el color de las lineas de separación
            this.dgvGrilla.GridColor = Color.HotPink;

            // La grilla será de sólo lectura
            this.dgvGrilla.ReadOnly = false;

            // No permito la multiselección
            this.dgvGrilla.MultiSelect = true;

            // Selecciono toda la fila a la vez // FullRowSelect
            this.dgvGrilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Hago que las columnas ocupen todo el ancho del 'DataGrid'
            this.dgvGrilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Indico el color de la fila seleccionada
            this.dgvGrilla.RowsDefaultCellStyle.SelectionBackColor = Color.DarkOliveGreen;
            this.dgvGrilla.RowsDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            // No permito modificar desde la grilla
            this.dgvGrilla.EditMode = DataGridViewEditMode.EditProgrammatically;

            // Saco los encabezados de las filas
            this.dgvGrilla.RowHeadersVisible = false;

        }




        #endregion

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

        private void btnSeleccionProductos_Click(object sender, EventArgs e)
        {


            int i = this.dgvGrilla.SelectedRows[0].Index;


            DataRow fila = this.dt.Rows[i];
            
            string id = (fila["id"].ToString());


            try
            {


                AccesoDatos accesoADatos = new AccesoDatos();




                this.da = new SqlDataAdapter();
                this.dt = new DataTable();

                this.da.SelectCommand = new SqlCommand("select id,nombre,precio,cantidad from Instrumento where id = " + id +";", accesoADatos.Conexion);





                this.da.Fill(this.dt);




                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }











        }

        private void dgvGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
