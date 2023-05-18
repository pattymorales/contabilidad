namespace Contabilidad
{
    public partial class FTerceros
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
        #endregion

        private System.Windows.Forms.GroupBox grpTerceros;
        private System.Windows.Forms.Label lblIdTerceros;
        private System.Windows.Forms.Label lblEstadoTercero;
        private System.Windows.Forms.TextBox txtEmailTercero;
        private System.Windows.Forms.Label lblEmailTercero;
        public System.Windows.Forms.TextBox txtApellidosTercero;
        private System.Windows.Forms.Label lblApellidosTercero;
        public System.Windows.Forms.TextBox txtNombresTercero;
        private System.Windows.Forms.Label lblNombresTercero;
        private System.Windows.Forms.Label lblTipoIdTercero;
        private System.Windows.Forms.TextBox txtIdTercero;
        private System.Windows.Forms.ComboBox cboTipoIdentificacionTercero;
        private System.Windows.Forms.Button btoBuscarTerceros;
        private System.Windows.Forms.ComboBox cboEstadoTercero;
        private System.Windows.Forms.Button btoIngresarTercero;
        private System.Windows.Forms.Button btoModificarTercero;
        private System.Windows.Forms.Button btoEliminarTercero;
        private System.Windows.Forms.Button btoLimpiarTercero;
        private System.Windows.Forms.Button btoSalirTercero;
        public System.Windows.Forms.TextBox txtNitTercero;
        private System.Windows.Forms.Label lblNitTercero;

        private void InitializeComponent()
        {
            this.grpTerceros = new System.Windows.Forms.GroupBox();
            this.txtNitTercero = new System.Windows.Forms.TextBox();
            this.lblNitTercero = new System.Windows.Forms.Label();
            this.btoBuscarTerceros = new System.Windows.Forms.Button();
            this.cboEstadoTercero = new System.Windows.Forms.ComboBox();
            this.cboTipoIdentificacionTercero = new System.Windows.Forms.ComboBox();
            this.lblEstadoTercero = new System.Windows.Forms.Label();
            this.txtEmailTercero = new System.Windows.Forms.TextBox();
            this.lblEmailTercero = new System.Windows.Forms.Label();
            this.txtApellidosTercero = new System.Windows.Forms.TextBox();
            this.lblApellidosTercero = new System.Windows.Forms.Label();
            this.txtNombresTercero = new System.Windows.Forms.TextBox();
            this.lblNombresTercero = new System.Windows.Forms.Label();
            this.lblTipoIdTercero = new System.Windows.Forms.Label();
            this.txtIdTercero = new System.Windows.Forms.TextBox();
            this.lblIdTerceros = new System.Windows.Forms.Label();
            this.btoIngresarTercero = new System.Windows.Forms.Button();
            this.btoModificarTercero = new System.Windows.Forms.Button();
            this.btoEliminarTercero = new System.Windows.Forms.Button();
            this.btoLimpiarTercero = new System.Windows.Forms.Button();
            this.btoSalirTercero = new System.Windows.Forms.Button();
            this.grpTerceros.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTerceros
            // 
            this.grpTerceros.Controls.Add(this.txtNitTercero);
            this.grpTerceros.Controls.Add(this.lblNitTercero);
            this.grpTerceros.Controls.Add(this.btoBuscarTerceros);
            this.grpTerceros.Controls.Add(this.cboEstadoTercero);
            this.grpTerceros.Controls.Add(this.cboTipoIdentificacionTercero);
            this.grpTerceros.Controls.Add(this.lblEstadoTercero);
            this.grpTerceros.Controls.Add(this.txtEmailTercero);
            this.grpTerceros.Controls.Add(this.lblEmailTercero);
            this.grpTerceros.Controls.Add(this.txtApellidosTercero);
            this.grpTerceros.Controls.Add(this.lblApellidosTercero);
            this.grpTerceros.Controls.Add(this.txtNombresTercero);
            this.grpTerceros.Controls.Add(this.lblNombresTercero);
            this.grpTerceros.Controls.Add(this.lblTipoIdTercero);
            this.grpTerceros.Controls.Add(this.txtIdTercero);
            this.grpTerceros.Controls.Add(this.lblIdTerceros);
            this.grpTerceros.Location = new System.Drawing.Point(16, 15);
            this.grpTerceros.Name = "grpTerceros";
            this.grpTerceros.Size = new System.Drawing.Size(444, 218);
            this.grpTerceros.TabIndex = 0;
            this.grpTerceros.TabStop = false;
            // 
            // txtNitTercero
            // 
            this.txtNitTercero.Location = new System.Drawing.Point(114, 67);
            this.txtNitTercero.Name = "txtNitTercero";
            this.txtNitTercero.Size = new System.Drawing.Size(161, 20);
            this.txtNitTercero.TabIndex = 3;
            // 
            // lblNitTercero
            // 
            this.lblNitTercero.AutoSize = true;
            this.lblNitTercero.Location = new System.Drawing.Point(14, 67);
            this.lblNitTercero.Name = "lblNitTercero";
            this.lblNitTercero.Size = new System.Drawing.Size(70, 13);
            this.lblNitTercero.TabIndex = 14;
            this.lblNitTercero.Text = "Identificacion";
            // 
            // btoBuscarTerceros
            // 
            this.btoBuscarTerceros.Image = global::Contabilidad.Properties.Resources._646732;
            this.btoBuscarTerceros.Location = new System.Drawing.Point(304, 14);
            this.btoBuscarTerceros.Name = "btoBuscarTerceros";
            this.btoBuscarTerceros.Size = new System.Drawing.Size(39, 36);
            this.btoBuscarTerceros.TabIndex = 8;
            this.btoBuscarTerceros.Click += new System.EventHandler(this.btoBuscarTerceros_Click);
            // 
            // cboEstadoTercero
            // 
            this.cboEstadoTercero.FormattingEnabled = true;
            this.cboEstadoTercero.Location = new System.Drawing.Point(114, 171);
            this.cboEstadoTercero.Name = "cboEstadoTercero";
            this.cboEstadoTercero.Size = new System.Drawing.Size(161, 21);
            this.cboEstadoTercero.TabIndex = 7;
            // 
            // cboTipoIdentificacionTercero
            // 
            this.cboTipoIdentificacionTercero.FormattingEnabled = true;
            this.cboTipoIdentificacionTercero.Location = new System.Drawing.Point(114, 40);
            this.cboTipoIdentificacionTercero.Name = "cboTipoIdentificacionTercero";
            this.cboTipoIdentificacionTercero.Size = new System.Drawing.Size(161, 21);
            this.cboTipoIdentificacionTercero.TabIndex = 2;
            this.cboTipoIdentificacionTercero.SelectedIndexChanged += new System.EventHandler(this.cboTipoIdentificacionTercero_SelectedIndexChanged);
            // 
            // lblEstadoTercero
            // 
            this.lblEstadoTercero.AutoSize = true;
            this.lblEstadoTercero.Location = new System.Drawing.Point(14, 171);
            this.lblEstadoTercero.Name = "lblEstadoTercero";
            this.lblEstadoTercero.Size = new System.Drawing.Size(40, 13);
            this.lblEstadoTercero.TabIndex = 10;
            this.lblEstadoTercero.Text = "Estado";
            // 
            // txtEmailTercero
            // 
            this.txtEmailTercero.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmailTercero.Location = new System.Drawing.Point(114, 145);
            this.txtEmailTercero.Name = "txtEmailTercero";
            this.txtEmailTercero.Size = new System.Drawing.Size(320, 20);
            this.txtEmailTercero.TabIndex = 6;
            // 
            // lblEmailTercero
            // 
            this.lblEmailTercero.AutoSize = true;
            this.lblEmailTercero.Location = new System.Drawing.Point(14, 145);
            this.lblEmailTercero.Name = "lblEmailTercero";
            this.lblEmailTercero.Size = new System.Drawing.Size(32, 13);
            this.lblEmailTercero.TabIndex = 8;
            this.lblEmailTercero.Text = "Email";
            // 
            // txtApellidosTercero
            // 
            this.txtApellidosTercero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidosTercero.Location = new System.Drawing.Point(114, 119);
            this.txtApellidosTercero.Name = "txtApellidosTercero";
            this.txtApellidosTercero.Size = new System.Drawing.Size(320, 20);
            this.txtApellidosTercero.TabIndex = 5;
            // 
            // lblApellidosTercero
            // 
            this.lblApellidosTercero.AutoSize = true;
            this.lblApellidosTercero.Location = new System.Drawing.Point(14, 119);
            this.lblApellidosTercero.Name = "lblApellidosTercero";
            this.lblApellidosTercero.Size = new System.Drawing.Size(49, 13);
            this.lblApellidosTercero.TabIndex = 6;
            this.lblApellidosTercero.Text = "Apellidos";
            // 
            // txtNombresTercero
            // 
            this.txtNombresTercero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombresTercero.Location = new System.Drawing.Point(114, 93);
            this.txtNombresTercero.Name = "txtNombresTercero";
            this.txtNombresTercero.Size = new System.Drawing.Size(320, 20);
            this.txtNombresTercero.TabIndex = 4;
            // 
            // lblNombresTercero
            // 
            this.lblNombresTercero.AutoSize = true;
            this.lblNombresTercero.Location = new System.Drawing.Point(14, 93);
            this.lblNombresTercero.Name = "lblNombresTercero";
            this.lblNombresTercero.Size = new System.Drawing.Size(49, 13);
            this.lblNombresTercero.TabIndex = 4;
            this.lblNombresTercero.Text = "Nombres";
            // 
            // lblTipoIdTercero
            // 
            this.lblTipoIdTercero.AutoSize = true;
            this.lblTipoIdTercero.Location = new System.Drawing.Point(14, 40);
            this.lblTipoIdTercero.Name = "lblTipoIdTercero";
            this.lblTipoIdTercero.Size = new System.Drawing.Size(94, 13);
            this.lblTipoIdTercero.TabIndex = 2;
            this.lblTipoIdTercero.Text = "Tipo Identificación";
            // 
            // txtIdTercero
            // 
            this.txtIdTercero.Enabled = false;
            this.txtIdTercero.Location = new System.Drawing.Point(114, 14);
            this.txtIdTercero.Name = "txtIdTercero";
            this.txtIdTercero.Size = new System.Drawing.Size(52, 20);
            this.txtIdTercero.TabIndex = 1;
            // 
            // lblIdTerceros
            // 
            this.lblIdTerceros.AutoSize = true;
            this.lblIdTerceros.Location = new System.Drawing.Point(14, 14);
            this.lblIdTerceros.Name = "lblIdTerceros";
            this.lblIdTerceros.Size = new System.Drawing.Size(16, 13);
            this.lblIdTerceros.TabIndex = 0;
            this.lblIdTerceros.Text = "Id";
            // 
            // btoIngresarTercero
            // 
            this.btoIngresarTercero.Location = new System.Drawing.Point(510, 29);
            this.btoIngresarTercero.Name = "btoIngresarTercero";
            this.btoIngresarTercero.Size = new System.Drawing.Size(83, 31);
            this.btoIngresarTercero.TabIndex = 9;
            this.btoIngresarTercero.Text = "Ingresar";
            this.btoIngresarTercero.UseVisualStyleBackColor = true;
            this.btoIngresarTercero.Click += new System.EventHandler(this.btoIngresarTercero_Click);
            // 
            // btoModificarTercero
            // 
            this.btoModificarTercero.Location = new System.Drawing.Point(510, 64);
            this.btoModificarTercero.Name = "btoModificarTercero";
            this.btoModificarTercero.Size = new System.Drawing.Size(83, 31);
            this.btoModificarTercero.TabIndex = 10;
            this.btoModificarTercero.Text = "Modificar";
            this.btoModificarTercero.UseVisualStyleBackColor = true;
            this.btoModificarTercero.Click += new System.EventHandler(this.btoModificarTercero_Click);
            // 
            // btoEliminarTercero
            // 
            this.btoEliminarTercero.Location = new System.Drawing.Point(510, 99);
            this.btoEliminarTercero.Name = "btoEliminarTercero";
            this.btoEliminarTercero.Size = new System.Drawing.Size(83, 31);
            this.btoEliminarTercero.TabIndex = 11;
            this.btoEliminarTercero.Text = "Eliminar";
            this.btoEliminarTercero.UseVisualStyleBackColor = true;
            this.btoEliminarTercero.Click += new System.EventHandler(this.btoEliminarTercero_Click);
            // 
            // btoLimpiarTercero
            // 
            this.btoLimpiarTercero.Location = new System.Drawing.Point(510, 134);
            this.btoLimpiarTercero.Name = "btoLimpiarTercero";
            this.btoLimpiarTercero.Size = new System.Drawing.Size(83, 31);
            this.btoLimpiarTercero.TabIndex = 12;
            this.btoLimpiarTercero.Text = "Limpiar";
            this.btoLimpiarTercero.UseVisualStyleBackColor = true;
            this.btoLimpiarTercero.Click += new System.EventHandler(this.btoLimpiarTercero_Click);
            // 
            // btoSalirTercero
            // 
            this.btoSalirTercero.Location = new System.Drawing.Point(510, 169);
            this.btoSalirTercero.Name = "btoSalirTercero";
            this.btoSalirTercero.Size = new System.Drawing.Size(83, 31);
            this.btoSalirTercero.TabIndex = 13;
            this.btoSalirTercero.Text = "Salir";
            this.btoSalirTercero.UseVisualStyleBackColor = true;
            this.btoSalirTercero.Click += new System.EventHandler(this.btoSalirTercero_Click);
            // 
            // FTerceros
            // 
            this.ClientSize = new System.Drawing.Size(659, 340);
            this.Controls.Add(this.btoSalirTercero);
            this.Controls.Add(this.btoLimpiarTercero);
            this.Controls.Add(this.btoEliminarTercero);
            this.Controls.Add(this.btoModificarTercero);
            this.Controls.Add(this.btoIngresarTercero);
            this.Controls.Add(this.grpTerceros);
            this.Name = "FTerceros";
            this.Load += new System.EventHandler(this.FTerceros_Load);
            this.grpTerceros.ResumeLayout(false);
            this.grpTerceros.PerformLayout();
            this.ResumeLayout(false);

        }

        
    }
}