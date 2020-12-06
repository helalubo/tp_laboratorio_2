using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace FormCalculadora
{

    /// <summary>
    /// Clase FormCalculadora 
    /// </summary>
    public partial class FormCalculadora : Form
    {

        /// <summary>
        /// Constructor sin parametros de clase FormCaculadora
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        /// <summary>
        ///Boton que ejecuta la funcion que Limpia los resultados y numeros ingresados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        /// <summary>
        /// Limpia los resultados y numeros ingresados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Limpiar()
        {

            this.cmbOperador.Text = "";
            this.lblResultado.Text = "";
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
        }


        /// <summary>
        ///  Opera 2 numeros segun el tipo de operador pasado por parametro
        /// </summary>
        /// <param name="numero1">Numero a ser operado </param>
        /// <param name="numero2">Numero para operacion</param>
        /// <param name="operador">Signo operador</param>
        /// <returns>Resultado de la operacion</returns>

        private static double Operar(string numero1, string numero2,string operador)
        {
            double rta;

            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            rta = Calculadora.Operar(num1, num2, operador);


            return rta;

        }






        /// <summary>
        /// Boton que ejecuta la operacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void btnOperar_Click(object sender, EventArgs e)
        {
            double rta;

           rta=  FormCalculadora.Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);

            this.lblResultado.Text = rta.ToString();
           
            

        }



        /// <summary>
        /// Al cerrar el formulario verifica si se desea salir o no del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void formCalculadora_Closing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de SALIR?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }



        /// <summary>
        /// Boton que convierte el resultado decimal a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>




        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if(this.lblResultado.Text != null  && this.lblResultado.Text != "Valor invalido")
            {

                Numero numero = new Numero();

                this.lblResultado.Text=   numero.DecimalBinario(Convert.ToDouble(this.lblResultado.Text));

            }
        }


        /// <summary>
        /// Boton que convierte el binario a decimal
         /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (this.lblResultado.Text != null && this.lblResultado.Text != "Valor invalido")
            {

                Numero numero = new Numero();

                this.lblResultado.Text = numero.BinarioDecimal(this.lblResultado.Text);

            }
        }
        /// <summary>
        ///  Load del formulario que llamara al metodo limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
