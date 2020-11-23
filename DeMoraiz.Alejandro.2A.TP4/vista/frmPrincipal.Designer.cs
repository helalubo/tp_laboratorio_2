
namespace vista
{
    partial class frmPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargarInstrumento = new System.Windows.Forms.Button();
            this.btnCargarAccesorio = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 132);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venta de Articulos Musicales";
            // 
            // btnCargarInstrumento
            // 
            this.btnCargarInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarInstrumento.Location = new System.Drawing.Point(32, 156);
            this.btnCargarInstrumento.Name = "btnCargarInstrumento";
            this.btnCargarInstrumento.Size = new System.Drawing.Size(415, 41);
            this.btnCargarInstrumento.TabIndex = 2;
            this.btnCargarInstrumento.Text = "Cargar Instrumento";
            this.btnCargarInstrumento.UseVisualStyleBackColor = true;
            this.btnCargarInstrumento.Click += new System.EventHandler(this.btnCargarInstrumento_Click);
            // 
            // btnCargarAccesorio
            // 
            this.btnCargarAccesorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarAccesorio.Location = new System.Drawing.Point(494, 156);
            this.btnCargarAccesorio.Name = "btnCargarAccesorio";
            this.btnCargarAccesorio.Size = new System.Drawing.Size(428, 41);
            this.btnCargarAccesorio.TabIndex = 3;
            this.btnCargarAccesorio.Text = "Cargar Accesorio";
            this.btnCargarAccesorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargarAccesorio.UseVisualStyleBackColor = true;
            this.btnCargarAccesorio.Click += new System.EventHandler(this.btnCargarAccesorio_Click);
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(107)))), ((int)(((byte)(33)))));
            this.btnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVender.Location = new System.Drawing.Point(947, 441);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(217, 54);
            this.btnVender.TabIndex = 4;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Location = new System.Drawing.Point(32, 222);
            this.dgvPrincipal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.RowHeadersWidth = 62;
            this.dgvPrincipal.Size = new System.Drawing.Size(890, 273);
            this.dgvPrincipal.TabIndex = 11;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(947, 156);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(217, 273);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 517);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvPrincipal);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnCargarAccesorio);
            this.Controls.Add(this.btnCargarInstrumento);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargarInstrumento;
        private System.Windows.Forms.Button btnCargarAccesorio;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.Button btnActualizar;
    }
}

