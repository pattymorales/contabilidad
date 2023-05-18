namespace Contabilidad
{
    public partial class FCentros
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
            this.grpCentros = new System.Windows.Forms.GroupBox();
            this.btoBuscarCentros = new System.Windows.Forms.Button();
            this.lblDescripcionCentro = new System.Windows.Forms.Label();
            this.txtCentro = new System.Windows.Forms.TextBox();
            this.lblCentro = new System.Windows.Forms.Label();
            this.txtDescripcionCentro = new System.Windows.Forms.TextBox();
            this.lblIdCentros = new System.Windows.Forms.Label();
            this.txtIdCentro = new System.Windows.Forms.TextBox();
            this.btoIngresarCentros = new System.Windows.Forms.Button();
            this.btoModificarCentros = new System.Windows.Forms.Button();
            this.btoEliminarCentros = new System.Windows.Forms.Button();
            this.btoLimpiarCentros = new System.Windows.Forms.Button();
            this.btoSalirCentros = new System.Windows.Forms.Button();
            this.grpCentros.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCentros
            // 
            this.grpCentros.Controls.Add(this.btoBuscarCentros);
            this.grpCentros.Controls.Add(this.lblDescripcionCentro);
            this.grpCentros.Controls.Add(this.txtCentro);
            this.grpCentros.Controls.Add(this.lblCentro);
            this.grpCentros.Controls.Add(this.txtDescripcionCentro);
            this.grpCentros.Controls.Add(this.lblIdCentros);
            this.grpCentros.Controls.Add(this.txtIdCentro);
            this.grpCentros.Location = new System.Drawing.Point(33, 27);
            this.grpCentros.Name = "grpCentros";
            this.grpCentros.Size = new System.Drawing.Size(424, 234);
            this.grpCentros.TabIndex = 0;
            this.grpCentros.TabStop = false;
            // 
            // btoBuscarCentros
            // 
            this.btoBuscarCentros.Image = global::Contabilidad.Properties.Resources._646732;
            this.btoBuscarCentros.Location = new System.Drawing.Point(262, 25);
            this.btoBuscarCentros.Name = "btoBuscarCentros";
            this.btoBuscarCentros.Size = new System.Drawing.Size(39, 36);
            this.btoBuscarCentros.TabIndex = 3;
            this.btoBuscarCentros.UseVisualStyleBackColor = true;
            this.btoBuscarCentros.Click += new System.EventHandler(this.btoBuscarCentros_Click);
            // 
            // lblDescripcionCentro
            // 
            this.lblDescripcionCentro.AutoSize = true;
            this.lblDescripcionCentro.Location = new System.Drawing.Point(23, 83);
            this.lblDescripcionCentro.Name = "lblDescripcionCentro";
            this.lblDescripcionCentro.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcionCentro.TabIndex = 5;
            this.lblDescripcionCentro.Text = "Descripción";
            // 
            // txtCentro
            // 
            this.txtCentro.Location = new System.Drawing.Point(92, 52);
            this.txtCentro.Name = "txtCentro";
            this.txtCentro.Size = new System.Drawing.Size(154, 20);
            this.txtCentro.TabIndex = 1;
            // 
            // lblCentro
            // 
            this.lblCentro.AutoSize = true;
            this.lblCentro.Location = new System.Drawing.Point(23, 52);
            this.lblCentro.Name = "lblCentro";
            this.lblCentro.Size = new System.Drawing.Size(38, 13);
            this.lblCentro.TabIndex = 3;
            this.lblCentro.Text = "Centro";
            // 
            // txtDescripcionCentro
            // 
            this.txtDescripcionCentro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcionCentro.Location = new System.Drawing.Point(92, 80);
            this.txtDescripcionCentro.Name = "txtDescripcionCentro";
            this.txtDescripcionCentro.Size = new System.Drawing.Size(154, 20);
            this.txtDescripcionCentro.TabIndex = 2;
            // 
            // lblIdCentros
            // 
            this.lblIdCentros.AutoSize = true;
            this.lblIdCentros.Location = new System.Drawing.Point(23, 26);
            this.lblIdCentros.Name = "lblIdCentros";
            this.lblIdCentros.Size = new System.Drawing.Size(16, 13);
            this.lblIdCentros.TabIndex = 1;
            this.lblIdCentros.Text = "Id";
            // 
            // txtIdCentro
            // 
            this.txtIdCentro.Enabled = false;
            this.txtIdCentro.Location = new System.Drawing.Point(92, 26);
            this.txtIdCentro.Name = "txtIdCentro";
            this.txtIdCentro.Size = new System.Drawing.Size(154, 20);
            this.txtIdCentro.TabIndex = 0;
            // 
            // btoIngresarCentros
            // 
            this.btoIngresarCentros.Location = new System.Drawing.Point(617, 45);
            this.btoIngresarCentros.Name = "btoIngresarCentros";
            this.btoIngresarCentros.Size = new System.Drawing.Size(101, 34);
            this.btoIngresarCentros.TabIndex = 4;
            this.btoIngresarCentros.Text = "Ingresar";
            this.btoIngresarCentros.UseVisualStyleBackColor = true;
            this.btoIngresarCentros.Click += new System.EventHandler(this.btoIngresarCentros_Click);
            // 
            // btoModificarCentros
            // 
            this.btoModificarCentros.Enabled = false;
            this.btoModificarCentros.Location = new System.Drawing.Point(617, 85);
            this.btoModificarCentros.Name = "btoModificarCentros";
            this.btoModificarCentros.Size = new System.Drawing.Size(101, 34);
            this.btoModificarCentros.TabIndex = 5;
            this.btoModificarCentros.Text = "Modificar";
            this.btoModificarCentros.UseVisualStyleBackColor = true;
            this.btoModificarCentros.Click += new System.EventHandler(this.btoModificarCentros_Click);
            // 
            // btoEliminarCentros
            // 
            this.btoEliminarCentros.Enabled = false;
            this.btoEliminarCentros.Location = new System.Drawing.Point(617, 125);
            this.btoEliminarCentros.Name = "btoEliminarCentros";
            this.btoEliminarCentros.Size = new System.Drawing.Size(101, 34);
            this.btoEliminarCentros.TabIndex = 6;
            this.btoEliminarCentros.Text = "Eliminar";
            this.btoEliminarCentros.UseVisualStyleBackColor = true;
            this.btoEliminarCentros.Click += new System.EventHandler(this.btoEliminarCentros_Click);
            // 
            // btoLimpiarCentros
            // 
            this.btoLimpiarCentros.Location = new System.Drawing.Point(617, 165);
            this.btoLimpiarCentros.Name = "btoLimpiarCentros";
            this.btoLimpiarCentros.Size = new System.Drawing.Size(101, 34);
            this.btoLimpiarCentros.TabIndex = 7;
            this.btoLimpiarCentros.Text = "Limpiar";
            this.btoLimpiarCentros.UseVisualStyleBackColor = true;
            this.btoLimpiarCentros.Click += new System.EventHandler(this.btoLimpiarCentros_Click);
            // 
            // btoSalirCentros
            // 
            this.btoSalirCentros.Location = new System.Drawing.Point(617, 205);
            this.btoSalirCentros.Name = "btoSalirCentros";
            this.btoSalirCentros.Size = new System.Drawing.Size(101, 34);
            this.btoSalirCentros.TabIndex = 8;
            this.btoSalirCentros.Text = "Salir";
            this.btoSalirCentros.UseVisualStyleBackColor = true;
            this.btoSalirCentros.Click += new System.EventHandler(this.btoSalirCentros_Click);
            // 
            // FCentros
            // 
            this.ClientSize = new System.Drawing.Size(786, 359);
            this.Controls.Add(this.btoSalirCentros);
            this.Controls.Add(this.btoLimpiarCentros);
            this.Controls.Add(this.btoEliminarCentros);
            this.Controls.Add(this.btoModificarCentros);
            this.Controls.Add(this.btoIngresarCentros);
            this.Controls.Add(this.grpCentros);
            this.Name = "FCentros";
            this.Load += new System.EventHandler(this.FCentro_Load);
            this.grpCentros.ResumeLayout(false);
            this.grpCentros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.GroupBox grpCentros;
        private System.Windows.Forms.TextBox txtIdCentro;
        private System.Windows.Forms.Label lblIdCentros;
        private System.Windows.Forms.Label lblCentro;
        private System.Windows.Forms.TextBox txtDescripcionCentro;
        private System.Windows.Forms.TextBox txtCentro;
        private System.Windows.Forms.Label lblDescripcionCentro;
        private System.Windows.Forms.Button btoIngresarCentros;
        private System.Windows.Forms.Button btoModificarCentros;
        private System.Windows.Forms.Button btoEliminarCentros;
        private System.Windows.Forms.Button btoLimpiarCentros;
        private System.Windows.Forms.Button btoSalirCentros;
        private System.Windows.Forms.Button btoBuscarCentros;
    }
}