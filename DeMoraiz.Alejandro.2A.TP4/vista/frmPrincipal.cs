using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using static Entidades.Venta;

namespace vista
{
    public partial class frmPrincipal : Form
    {



        public SqlDataAdapter da;
        public DataTable dt;
        public DataTable aux;


        public SeleccionDeInstrumentos frmSeleccionar;
        public SeleccionDeAccesorios frmSeleccionarAccesorio;


        public Thread hiloPrincipal;

        DelegadoDeVenta miDelegadoDeVenta;


        public string ImporteDeVenta
        {



            get
            {

                float cantidad = 0;

                foreach (Producto producto in ProductosSeleccionados)
                {


                    cantidad += producto.Precio;

                }





                return cantidad.ToString();




            }
        }


        public List<Producto> ProductosSeleccionados
        {



            get
            {


                List<Producto> listaDeProductos = new List<Producto>();



                foreach (DataRow fila in aux.Rows)
                {
                    Producto producto = new Producto();

                    producto.ID = (int)(fila["id"]);
                    producto.Nombre = (string)(fila["nombre"]);
                    producto.Precio = (float)(fila["precio"]);
                    producto.Cantidad = 1;


                    listaDeProductos.Add(producto);



                }



               

                return listaDeProductos;



            }

        }


        public frmPrincipal()
        {

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            

           

            




            hiloPrincipal = new Thread(SeleccionarProducto);
            ConfigurarGrilla();
            configuracionDataTable();
            aux = new DataTable();
            this.aux = this.dt.Clone();





        }

        private void btnCargarInstrumento_Click(object sender, EventArgs e)
        {
           this.frmSeleccionar = new SeleccionDeInstrumentos();
            this.frmSeleccionar.Show();

        }

           private void btnCargarAccesorio_Click(object sender, EventArgs e)
        {
            this.frmSeleccionarAccesorio = new SeleccionDeAccesorios();
            this.frmSeleccionarAccesorio.Show();
        }

        public void configuracionDataTable()
        {
            this.dt = new DataTable("Producto");

            this.dt.Columns.Add("id", typeof(int));
            this.dt.Columns.Add("nombre", typeof(string));
            this.dt.Columns.Add("precio", typeof(float));



            ///  this.dt.PrimaryKey = new DataColumn[] { this.dt.Columns[0] };

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
            this.dgvPrincipal.MultiSelect = true;

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
            /// 

          


            hiloPrincipal = new Thread(SeleccionarProducto);
            if (!hiloPrincipal.IsAlive)
            {
                hiloPrincipal.Start();

            }
            else
            {
                hiloPrincipal.Abort();

            }


    
        }


        private void SeleccionarProducto()
        {


            if (this.dgvPrincipal.InvokeRequired)
            {

                this.dgvPrincipal.BeginInvoke((MethodInvoker)delegate ()
                {
           
                  if (Form.Equals(this.frmSeleccionar, null)){

                     this.aux.ImportRow(this.frmSeleccionarAccesorio.dt.Rows[0]);
                    }
                    else
                    {
                        this.aux.ImportRow(this.frmSeleccionar.dt.Rows[0]);
                        frmSeleccionar = null;
                    }

                    this.dgvPrincipal.DataSource = aux;
                    this.lblImporte.Text = ImporteDeVenta; //////////////////
                    this.aux = (DataTable)this.dgvPrincipal.DataSource;
                });

            }
            else
            {

                this.dgvPrincipal.DataSource = aux;
                this.aux = (DataTable)this.dgvPrincipal.DataSource;


            }
        }

    

        private void btnVender_Click(object sender, EventArgs e)
        {

            List<Producto> productos = ProductosSeleccionados;


            //this.miDelegadoDeVenta = new DelegadoDeVenta(modificarStock);



        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
