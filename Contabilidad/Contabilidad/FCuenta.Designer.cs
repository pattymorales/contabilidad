namespace Contabilidad
{
    public partial class FCuenta
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
            this.grpCuenta = new System.Windows.Forms.GroupBox();
            this.btoBuscar = new System.Windows.Forms.Button();
            this.chkAfectable = new System.Windows.Forms.CheckBox();
            this.lblAfectable = new System.Windows.Forms.Label();
            this.rbtCredito = new System.Windows.Forms.RadioButton();
            this.rbtDebito = new System.Windows.Forms.RadioButton();
            this.lblNaturaleza = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.btoSalir = new System.Windows.Forms.Button();
            this.btoIngresar = new System.Windows.Forms.Button();
            this.btoModificar = new System.Windows.Forms.Button();
            this.btoEliminar = new System.Windows.Forms.Button();
            this.btoLimpiar = new System.Windows.Forms.Button();
            this.btoPlanCuentas = new System.Windows.Forms.Button();
            this.grpCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCuenta
            // 
            this.grpCuenta.Controls.Add(this.btoBuscar);
            this.grpCuenta.Controls.Add(this.chkAfectable);
            this.grpCuenta.Controls.Add(this.lblAfectable);
            this.grpCuenta.Controls.Add(this.rbtCredito);
            this.grpCuenta.Controls.Add(this.rbtDebito);
            this.grpCuenta.Controls.Add(this.lblNaturaleza);
            this.grpCuenta.Controls.Add(this.txtDescripcion);
            this.grpCuenta.Controls.Add(this.lblDescripcion);
            this.grpCuenta.Controls.Add(this.txtCuenta);
            this.grpCuenta.Controls.Add(this.lblCuenta);
            this.grpCuenta.Controls.Add(this.txtId);
            this.grpCuenta.Controls.Add(this.lbId);
            this.grpCuenta.Location = new System.Drawing.Point(12, 25);
            this.grpCuenta.Name = "grpCuenta";
            this.grpCuenta.Size = new System.Drawing.Size(426, 181);
            this.grpCuenta.TabIndex = 7;
            this.grpCuenta.TabStop = false;
            this.grpCuenta.Enter += new System.EventHandler(this.grpCuenta_Enter);
            // 
            // btoBuscar
            // 
            this.btoBuscar.Image = global::Contabilidad.Properties.Resources._646732;
            this.btoBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btoBuscar.Location = new System.Drawing.Point(241, 20);
            this.btoBuscar.Name = "btoBuscar";
            this.btoBuscar.Size = new System.Drawing.Size(39, 36);
            this.btoBuscar.TabIndex = 18;
            this.btoBuscar.UseVisualStyleBackColor = true;
            this.btoBuscar.Click += new System.EventHandler(this.btoBuscar_Click);
            // 
            // chkAfectable
            // 
            this.chkAfectable.AutoSize = true;
            this.chkAfectable.Location = new System.Drawing.Point(79, 120);
            this.chkAfectable.Name = "chkAfectable";
            this.chkAfectable.Size = new System.Drawing.Size(15, 14);
            this.chkAfectable.TabIndex = 17;
            this.chkAfectable.UseVisualStyleBackColor = true;
            // 
            // lblAfectable
            // 
            this.lblAfectable.AutoSize = true;
            this.lblAfectable.Location = new System.Drawing.Point(6, 121);
            this.lblAfectable.Name = "lblAfectable";
            this.lblAfectable.Size = new System.Drawing.Size(52, 13);
            this.lblAfectable.TabIndex = 16;
            this.lblAfectable.Text = "Afectable";
            // 
            // rbtCredito
            // 
            this.rbtCredito.AutoSize = true;
            this.rbtCredito.Location = new System.Drawing.Point(141, 96);
            this.rbtCredito.Name = "rbtCredito";
            this.rbtCredito.Size = new System.Drawing.Size(58, 17);
            this.rbtCredito.TabIndex = 15;
            this.rbtCredito.TabStop = true;
            this.rbtCredito.Text = "Crédito";
            this.rbtCredito.UseVisualStyleBackColor = true;
            // 
            // rbtDebito
            // 
            this.rbtDebito.AutoSize = true;
            this.rbtDebito.Location = new System.Drawing.Point(79, 96);
            this.rbtDebito.Name = "rbtDebito";
            this.rbtDebito.Size = new System.Drawing.Size(56, 17);
            this.rbtDebito.TabIndex = 14;
            this.rbtDebito.TabStop = true;
            this.rbtDebito.Text = "Débito";
            this.rbtDebito.UseVisualStyleBackColor = true;
            // 
            // lblNaturaleza
            // 
            this.lblNaturaleza.AutoSize = true;
            this.lblNaturaleza.Location = new System.Drawing.Point(6, 96);
            this.lblNaturaleza.Name = "lblNaturaleza";
            this.lblNaturaleza.Size = new System.Drawing.Size(58, 13);
            this.lblNaturaleza.TabIndex = 13;
            this.lblNaturaleza.Text = "Naturaleza";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(79, 70);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(156, 20);
            this.txtDescripcion.TabIndex = 12;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(10, 73);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 11;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtCuenta
            // 
            this.txtCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuenta.Location = new System.Drawing.Point(79, 44);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(156, 20);
            this.txtCuenta.TabIndex = 10;
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(10, 47);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(41, 13);
            this.lblCuenta.TabIndex = 9;
            this.lblCuenta.Text = "Cuenta";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(79, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(56, 20);
            this.txtId.TabIndex = 8;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(10, 20);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(16, 13);
            this.lbId.TabIndex = 7;
            this.lbId.Text = "Id";
            // 
            // btoSalir
            // 
            this.btoSalir.Location = new System.Drawing.Point(592, 224);
            this.btoSalir.Name = "btoSalir";
            this.btoSalir.Size = new System.Drawing.Size(83, 30);
            this.btoSalir.TabIndex = 10;
            this.btoSalir.Text = "Salir";
            this.btoSalir.UseVisualStyleBackColor = true;
            this.btoSalir.Click += new System.EventHandler(this.btoSalir_Click);
            // 
            // btoIngresar
            // 
            this.btoIngresar.Location = new System.Drawing.Point(592, 27);
            this.btoIngresar.Name = "btoIngresar";
            this.btoIngresar.Size = new System.Drawing.Size(83, 31);
            this.btoIngresar.TabIndex = 11;
            this.btoIngresar.Text = "Ingresar";
            this.btoIngresar.UseVisualStyleBackColor = true;
            this.btoIngresar.Click += new System.EventHandler(this.btoIngresar_Click);
            // 
            // btoModificar
            // 
            this.btoModificar.Location = new System.Drawing.Point(592, 64);
            this.btoModificar.Name = "btoModificar";
            this.btoModificar.Size = new System.Drawing.Size(83, 35);
            this.btoModificar.TabIndex = 12;
            this.btoModificar.Text = "Modificar";
            this.btoModificar.UseVisualStyleBackColor = true;
            this.btoModificar.Click += new System.EventHandler(this.btoModificar_Click);
            // 
            // btoEliminar
            // 
            this.btoEliminar.Location = new System.Drawing.Point(592, 108);
            this.btoEliminar.Name = "btoEliminar";
            this.btoEliminar.Size = new System.Drawing.Size(83, 38);
            this.btoEliminar.TabIndex = 13;
            this.btoEliminar.Text = "Eliminar";
            this.btoEliminar.UseVisualStyleBackColor = true;
            this.btoEliminar.Click += new System.EventHandler(this.btoEliminar_Click);
            // 
            // btoLimpiar
            // 
            this.btoLimpiar.Location = new System.Drawing.Point(592, 152);
            this.btoLimpiar.Name = "btoLimpiar";
            this.btoLimpiar.Size = new System.Drawing.Size(83, 30);
            this.btoLimpiar.TabIndex = 14;
            this.btoLimpiar.Text = "Limpiar";
            this.btoLimpiar.UseVisualStyleBackColor = true;
            this.btoLimpiar.Click += new System.EventHandler(this.btoLimpiar_Click);
            // 
            // btoPlanCuentas
            // 
            this.btoPlanCuentas.Location = new System.Drawing.Point(592, 188);
            this.btoPlanCuentas.Name = "btoPlanCuentas";
            this.btoPlanCuentas.Size = new System.Drawing.Size(83, 30);
            this.btoPlanCuentas.TabIndex = 15;
            this.btoPlanCuentas.Text = "Plan Cuentas";
            this.btoPlanCuentas.UseVisualStyleBackColor = true;
            this.btoPlanCuentas.Click += new System.EventHandler(this.btoPlanCuentas_Click);
            // 
            // FCuenta
            // 
            this.ClientSize = new System.Drawing.Size(687, 319);
            this.Controls.Add(this.btoPlanCuentas);
            this.Controls.Add(this.btoLimpiar);
            this.Controls.Add(this.btoEliminar);
            this.Controls.Add(this.btoModificar);
            this.Controls.Add(this.btoIngresar);
            this.Controls.Add(this.btoSalir);
            this.Controls.Add(this.grpCuenta);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "FCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CuentaForm_Load);
            this.grpCuenta.ResumeLayout(false);
            this.grpCuenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.GroupBox grpCuenta;
        private System.Windows.Forms.CheckBox chkAfectable;
        private System.Windows.Forms.Label lblAfectable;
        private System.Windows.Forms.RadioButton rbtCredito;
        private System.Windows.Forms.RadioButton rbtDebito;
        private System.Windows.Forms.Label lblNaturaleza;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label lblCuenta;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btoBuscar;
        private System.Windows.Forms.Button btoSalir;
        private System.Windows.Forms.Button btoIngresar;
        private System.Windows.Forms.Button btoModificar;
        private System.Windows.Forms.Button btoEliminar;
        private System.Windows.Forms.Button btoLimpiar;
        private System.Windows.Forms.Button btoPlanCuentas;
    }
}