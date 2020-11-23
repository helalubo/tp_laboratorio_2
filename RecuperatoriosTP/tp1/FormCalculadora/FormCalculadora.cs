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
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {

            this.cmbOperador.Text = "";
            this.lblResultado.Text = "";
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
        }


        private static double Operar(string numero1, string numero2,string operador)
        {
            double rta;

            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            rta = Calculadora.Operar(num1, num2, operador);


            return rta;

        }









        private void btnOperar_Click(object sender, EventArgs e)
        {
            double rta;

           rta=  FormCalculadora.Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);

            this.lblResultado.Text = rta.ToString();
           
            

        }





        private void formCalculadora_Closing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de SALIR?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }






        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if(this.lblResultado.Text != null  && this.lblResultado.Text != "Valor invalido")
            {

                Numero numero = new Numero();

                this.lblResultado.Text=   numero.DecimalBinario(Convert.ToDouble(this.lblResultado.Text));

            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (this.lblResultado.Text != null && this.lblResultado.Text != "Valor invalido")
            {

                Numero numero = new Numero();

                this.lblResultado.Text = numero.BinarioDecimal(this.lblResultado.Text);

            }
        }
    }
}
