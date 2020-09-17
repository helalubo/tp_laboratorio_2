namespace FormCalculadora
{
    partial class FormCalculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.btnConvertirABinario = new System.Windows.Forms.Button();
            this.btnConvertirADecimal = new System.Windows.Forms.Button();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero1.Location = new System.Drawing.Point(90, 149);
            this.txtNumero1.Multiline = true;
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(284, 66);
            this.txtNumero1.TabIndex = 0;
            this.txtNumero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumero1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnConvertirABinario
            // 
            this.btnConvertirABinario.Location = new System.Drawing.Point(62, 353);
            this.btnConvertirABinario.Name = "btnConvertirABinario";
            this.btnConvertirABinario.Size = new System.Drawing.Size(391, 69);
            this.btnConvertirABinario.TabIndex = 6;
            this.btnConvertirABinario.Text = "Convertir a Binario";
            this.btnConvertirABinario.UseVisualStyleBackColor = true;
            this.btnConvertirABinario.Click += new System.EventHandler(this.btnConvertirABinario_Click);
            // 
            // btnConvertirADecimal
            // 
            this.btnConvertirADecimal.Location = new System.Drawing.Point(459, 353);
            this.btnConvertirADecimal.Name = "btnConvertirADecimal";
            this.btnConvertirADecimal.Size = new System.Drawing.Size(404, 69);
            this.btnConvertirADecimal.TabIndex = 7;
            this.btnConvertirADecimal.Text = "Convertir a Decimal";
            this.btnConvertirADecimal.UseVisualStyleBackColor = true;
            this.btnConvertirADecimal.Click += new System.EventHandler(this.btnConvertirADecimal_Click);
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(36, 270);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(284, 61);
            this.btnOperar.TabIndex = 3;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(616, 270);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(268, 61);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cmbOperador
            // 
            this.cmbOperador.AllowDrop = true;
            this.cmbOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperador.Location = new System.Drawing.Point(401, 149);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(121, 66);
            this.cmbOperador.TabIndex = 1;
            this.cmbOperador.UseWaitCursor = true;
            this.cmbOperador.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(865, 70);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNumero2
            // 
            this.txtNumero2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero2.Location = new System.Drawing.Point(546, 149);
            this.txtNumero2.Multiline = true;
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(284, 66);
            this.txtNumero2.TabIndex = 2;
            this.txtNumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumero2.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblResultado
            // 
            this.lblResultado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(32, 49);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(865, 70);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(326, 270);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(284, 61);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 452);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOperador);
            this.Controls.Add(this.btnConvertirADecimal);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.btnConvertirABinario);
            this.Controls.Add(this.txtNumero1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.Text = "Calculadora de Alejandro De Moraiz del curso 2ºB";
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Button btnConvertirABinario;
        private System.Windows.Forms.Button btnConvertirADecimal;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

