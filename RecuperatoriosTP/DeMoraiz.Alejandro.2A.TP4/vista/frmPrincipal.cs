using Entidades;
using Excepciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

using static Entidades.Venta;

namespace vista
{

    /// <summary>
    /// Clase de formulario principal que hereda de Form
    /// </summary>
    public partial class frmPrincipal : Form
    {



        public SqlDataAdapter da;
        public DataTable dt;
        public DataTable aux;


        public SeleccionDeInstrumentos frmSeleccionar;
        public SeleccionDeAccesorios frmSeleccionarAccesorio;


        public Thread hiloPrincipal;

        DelegadoDeVenta miDelegadoDeVenta;


        public float ImporteDeVenta
        {



            get
            {

                float cantidad = 0;

                foreach (Producto producto in ProductosSeleccionados)
                {


                    cantidad += producto.Precio;

                }

               


                return cantidad;




            }
        }



        /// <summary>
        /// Atributo de lectura de lista de productos seleccionado con respecto a la seleccion
        /// en el datagridview principal, esta es retornada en forma de Lista .
        /// </summary>

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
                    producto.Cantidad = (int)(fila["cantidad"]);


                    listaDeProductos.Add(producto);



                }





                return listaDeProductos;



            }

        }

        /// <summary>
        /// Constructor vacio de clase frmPrincipal,
        /// en la cual se inicializa el hilo principal pasandole 
        /// la direccion de memoria de la funcion Seleccionar producto,
        /// inicializo el datagridView principal y le doy el formato de 
        /// un dataTable de producto
        /// </summary>
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


        /// <summary>
        /// Abre el formulario para cargar un instrumento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarInstrumento_Click(object sender, EventArgs e)
        {
            this.frmSeleccionar = new SeleccionDeInstrumentos();
            this.frmSeleccionar.Show();

        }

        /// <summary>
        /// Abre el formulario para cargar un Accesorio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarAccesorio_Click(object sender, EventArgs e)
        {
            this.frmSeleccionarAccesorio = new SeleccionDeAccesorios();
            this.frmSeleccionarAccesorio.Show();
        }



        /// <summary>
        /// Configuro el DataTable para que muestre los articulos en formato producto
        /// </summary>
        public void configuracionDataTable()
        {
            this.dt = new DataTable("Producto");

            this.dt.Columns.Add("id", typeof(int));
            this.dt.Columns.Add("nombre", typeof(string));
            this.dt.Columns.Add("precio", typeof(float));
            this.dt.Columns.Add("cantidad", typeof(int));


            this.dt.Columns["id"].AutoIncrement = true;
            this.dt.Columns["id"].AutoIncrementSeed = 1;
            this.dt.Columns["id"].AutoIncrementStep = 1;



        }


        /// <summary>
        /// Configura dandole formato a la grilla
        /// </summary>

        private void ConfigurarGrilla()
        {
            // Coloco color de fondo para las filas
            this.dgvPrincipal.RowsDefaultCellStyle.BackColor = Color.MediumPurple;

            // Alterno colores
            this.dgvPrincipal.AlternatingRowsDefaultCellStyle.BackColor = Color.MediumPurple;

            // Pongo color de fondo a la grilla
            this.dgvPrincipal.BackgroundColor = Color.Lavender;

            // Defino fuente para el encabezado y alineación del encabezado
            this.dgvPrincipal.ColumnHeadersDefaultCellStyle.Font = new Font(dgvPrincipal.Font, FontStyle.Bold);
            this.dgvPrincipal.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Defino el color de las lineas de separación
            this.dgvPrincipal.GridColor = Color.LimeGreen;

            // La grilla será de sólo lectura
            this.dgvPrincipal.ReadOnly = false;

            // No permito la multiselección
            this.dgvPrincipal.MultiSelect = true;

            // Selecciono toda la fila a la vez
            this.dgvPrincipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Hago que las columnas ocupen todo el ancho del 'DataGrid'
            this.dgvPrincipal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Indico el color de la fila seleccionada
            this.dgvPrincipal.RowsDefaultCellStyle.SelectionBackColor = Color.Black;
            this.dgvPrincipal.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            // No permito modificar desde la grilla
            this.dgvPrincipal.EditMode = DataGridViewEditMode.EditProgrammatically;

            // Saco los encabezados de las filas
            this.dgvPrincipal.RowHeadersVisible = false;




        }

        /// <summary>
        /// Actualiza El formulario principal dando inicio al hilo correspondiente de este.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            

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

        /// <summary>
        /// Observa los DataTable de los formularios de Accesorios y de instrumentos
        /// que estan en otros hilos y carga el dataGridView de l form principal
        /// con los articulos seleccionados en estos formularios  
        /// </summary>
        private void SeleccionarProducto()
        {


            if (this.dgvPrincipal.InvokeRequired)
            {

                this.dgvPrincipal.BeginInvoke((MethodInvoker)delegate ()
                {

                    if (Form.Equals(this.frmSeleccionar, null))
                    {
                        if (this.frmSeleccionarAccesorio != null)
                        {

                            this.aux.ImportRow(this.frmSeleccionarAccesorio.dt.Rows[0]);

                        }
                        else
                        {


                            MessageBox.Show("No se a cargado ningun producto todavia");
                        }




                    }
                    else
                    {
                        this.aux.ImportRow(this.frmSeleccionar.dt.Rows[0]);
                        frmSeleccionar = null;
                    }

                    this.dgvPrincipal.DataSource = aux;
                    this.lblImporte.Text = ImporteDeVenta.ToString();

                    this.aux = (DataTable)this.dgvPrincipal.DataSource;
                });

            }
            else
            {

                this.dgvPrincipal.DataSource = aux;
                this.lblImporte.Text = ImporteDeVenta.ToString();
                this.aux = (DataTable)this.dgvPrincipal.DataSource;


            }
        }


        /// <summary>
        /// Gestiona lo necesario para la venta de lo productos seleccionado
        /// esto utilizando un delegado el cual maneja las funciones para
        /// Verificar stock(en caso de que el stock sea menor
        /// a los articulos requeridos lanza una excepcion),modificar el stock
        /// (el cual lanza el evento que genera el ticket) y
        /// genera un archivo .xml con las ventas realizadas.
        /// Dichas funciones se ejecutan invocando al delegado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void btnVender_Click(object sender, EventArgs e)
        {


          


            if (float.Parse(this.textPago.Text) >= ImporteDeVenta)
            {

               
                 

                List<Producto> productos = ProductosSeleccionados;

                //inicializo al delegado
                miDelegadoDeVenta = new DelegadoDeVenta(Venta.VerificarStock);
                miDelegadoDeVenta += Venta.modificarStock;
                miDelegadoDeVenta += Venta.GuardarVentasEnXml;




                try
                {


                    miDelegadoDeVenta.Invoke(productos);
                    

                }

                catch (SobrepasaStockException e1)
                {
                    MessageBox.Show(e1.Message);
                }
                catch (EstableciendoConexionException e2)
                {
                    MessageBox.Show(e2.Message);
                }

                finally
                {
                    string cadena = string.Format("La venta se realizo con exito \n \t \t El vuelto es de un total de {0} $", (float)(Convert.ToDouble(this.textPago.Text)) - ImporteDeVenta);
                    MessageBox.Show(cadena);
                    this.aux.Clear();
                    this.textPago.Clear();
                    this.lblImporte.Text = "";
                   

                }





            }
            else
            {




                string fallo = "El importe a abonar es mayor al monto de pago cargado.";


                MessageBox.Show(fallo);
               
            }


        }

       
    }
}
