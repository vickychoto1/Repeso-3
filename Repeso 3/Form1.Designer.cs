namespace Repeso_3
{
    partial class Form1
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
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnPropiedad = new System.Windows.Forms.Button();
            this.btnPropietario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReporte
            // 
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(175, 58);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(95, 49);
            this.btnReporte.TabIndex = 5;
            this.btnReporte.Text = "Ir a Reportes";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnPropiedad
            // 
            this.btnPropiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPropiedad.Location = new System.Drawing.Point(303, 58);
            this.btnPropiedad.Margin = new System.Windows.Forms.Padding(2);
            this.btnPropiedad.Name = "btnPropiedad";
            this.btnPropiedad.Size = new System.Drawing.Size(95, 49);
            this.btnPropiedad.TabIndex = 4;
            this.btnPropiedad.Text = "Registrar Propiedad";
            this.btnPropiedad.UseVisualStyleBackColor = true;
            this.btnPropiedad.Click += new System.EventHandler(this.btnPropiedad_Click);
            // 
            // btnPropietario
            // 
            this.btnPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPropietario.Location = new System.Drawing.Point(60, 58);
            this.btnPropietario.Margin = new System.Windows.Forms.Padding(2);
            this.btnPropietario.Name = "btnPropietario";
            this.btnPropietario.Size = new System.Drawing.Size(95, 49);
            this.btnPropietario.TabIndex = 3;
            this.btnPropietario.Text = "Registrar Propietario";
            this.btnPropietario.UseVisualStyleBackColor = true;
            this.btnPropietario.Click += new System.EventHandler(this.btnPropietario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 163);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnPropiedad);
            this.Controls.Add(this.btnPropietario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnPropiedad;
        private System.Windows.Forms.Button btnPropietario;
    }
}

