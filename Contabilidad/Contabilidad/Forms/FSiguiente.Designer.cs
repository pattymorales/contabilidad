namespace Contabilidad
{
    partial class FSiguiente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTipoE = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtSiguiente = new System.Windows.Forms.TextBox();
            this.btoGrabar = new System.Windows.Forms.Button();
            this.lblSiguiente = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btoSalirSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTipoE
            // 
            this.lblTipoE.AutoSize = true;
            this.lblTipoE.Location = new System.Drawing.Point(15, 21);
            this.lblTipoE.Name = "lblTipoE";
            this.lblTipoE.Size = new System.Drawing.Size(28, 13);
            this.lblTipoE.TabIndex = 0;
            this.lblTipoE.Text = "Tipo";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(119, 21);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo";
            // 
            // txtSiguiente
            // 
            this.txtSiguiente.Location = new System.Drawing.Point(122, 53);
            this.txtSiguiente.Name = "txtSiguiente";
            this.txtSiguiente.Size = new System.Drawing.Size(108, 20);
            this.txtSiguiente.TabIndex = 2;
            // 
            // btoGrabar
            // 
            this.btoGrabar.Location = new System.Drawing.Point(310, 45);
            this.btoGrabar.Name = "btoGrabar";
            this.btoGrabar.Size = new System.Drawing.Size(101, 34);
            this.btoGrabar.TabIndex = 3;
            this.btoGrabar.Text = "Grabar";
            this.btoGrabar.UseVisualStyleBackColor = true;
            this.btoGrabar.Click += new System.EventHandler(this.btoGrabar_Click);
            // 
            // lblSiguiente
            // 
            this.lblSiguiente.AutoSize = true;
            this.lblSiguiente.Location = new System.Drawing.Point(12, 52);
            this.lblSiguiente.Name = "lblSiguiente";
            this.lblSiguiente.Size = new System.Drawing.Size(91, 13);
            this.lblSiguiente.TabIndex = 4;
            this.lblSiguiente.Text = "Número Siguiente";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(187, 21);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(43, 13);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descrip";
            // 
            // btoSalirSiguiente
            // 
            this.btoSalirSiguiente.Location = new System.Drawing.Point(310, 85);
            this.btoSalirSiguiente.Name = "btoSalirSiguiente";
            this.btoSalirSiguiente.Size = new System.Drawing.Size(101, 34);
            this.btoSalirSiguiente.TabIndex = 14;
            this.btoSalirSiguiente.Text = "Salir";
            this.btoSalirSiguiente.UseVisualStyleBackColor = true;
            this.btoSalirSiguiente.Click += new System.EventHandler(this.btoSalirSiguiente_Click);
            // 
            // FSiguiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 191);
            this.Controls.Add(this.btoSalirSiguiente);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblSiguiente);
            this.Controls.Add(this.btoGrabar);
            this.Controls.Add(this.txtSiguiente);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblTipoE);
            this.Name = "FSiguiente";
            this.Text = "Número Siguientes de Tipos de transacciones";
            this.Load += new System.EventHandler(this.FSiguiente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoE;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtSiguiente;
        private System.Windows.Forms.Button btoGrabar;
        private System.Windows.Forms.Label lblSiguiente;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btoSalirSiguiente;
    }
}