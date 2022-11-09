namespace InterfazGrafica
{
    partial class formPrograma1
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.inDatos = new System.Windows.Forms.TextBox();
            this.cartelIngreso = new System.Windows.Forms.Label();
            this.cartelSalida = new System.Windows.Forms.Label();
            this.outDatos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(149, 151);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(125, 42);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonOk_MouseClick);
            // 
            // inDatos
            // 
            this.inDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inDatos.Location = new System.Drawing.Point(149, 60);
            this.inDatos.Name = "inDatos";
            this.inDatos.Size = new System.Drawing.Size(262, 31);
            this.inDatos.TabIndex = 1;
            // 
            // cartelIngreso
            // 
            this.cartelIngreso.AutoSize = true;
            this.cartelIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartelIngreso.Location = new System.Drawing.Point(31, 66);
            this.cartelIngreso.Name = "cartelIngreso";
            this.cartelIngreso.Size = new System.Drawing.Size(89, 25);
            this.cartelIngreso.TabIndex = 2;
            this.cartelIngreso.Text = "Ingreso:";
            this.cartelIngreso.Click += new System.EventHandler(this.label1_Click);
            // 
            // cartelSalida
            // 
            this.cartelSalida.AutoSize = true;
            this.cartelSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartelSalida.Location = new System.Drawing.Point(31, 231);
            this.cartelSalida.Name = "cartelSalida";
            this.cartelSalida.Size = new System.Drawing.Size(78, 25);
            this.cartelSalida.TabIndex = 3;
            this.cartelSalida.Text = "Salida:";
            // 
            // outDatos
            // 
            this.outDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outDatos.Location = new System.Drawing.Point(36, 288);
            this.outDatos.Name = "outDatos";
            this.outDatos.Size = new System.Drawing.Size(375, 35);
            this.outDatos.TabIndex = 4;
            // 
            // formPrograma1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 377);
            this.Controls.Add(this.outDatos);
            this.Controls.Add(this.cartelSalida);
            this.Controls.Add(this.cartelIngreso);
            this.Controls.Add(this.inDatos);
            this.Controls.Add(this.buttonOk);
            this.Name = "formPrograma1";
            this.Text = "PROGRAMA 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox inDatos;
        private System.Windows.Forms.Label cartelIngreso;
        private System.Windows.Forms.Label cartelSalida;
        private System.Windows.Forms.Label outDatos;
    }
}

