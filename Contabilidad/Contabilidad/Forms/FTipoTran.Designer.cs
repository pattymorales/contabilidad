namespace Contabilidad
{
    public partial class FTipoTransacciones
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
            this.grpTipoTran = new System.Windows.Forms.GroupBox();
            this.cboSwTipoTran = new System.Windows.Forms.ComboBox();
            this.btoBuscarTipoTran = new System.Windows.Forms.Button();
            this.txtDescripcionTipoTran = new System.Windows.Forms.TextBox();
            this.txtTipoTran = new System.Windows.Forms.TextBox();
            this.txtIdTipoTran = new System.Windows.Forms.TextBox();
            this.lblSwTipoTran = new System.Windows.Forms.Label();
            this.lblDescripcionTipoTran = new System.Windows.Forms.Label();
            this.lblTipoTran = new System.Windows.Forms.Label();
            this.lblIdTipoTran = new System.Windows.Forms.Label();
            this.btoIngresarTipoTran = new System.Windows.Forms.Button();
            this.btoModificarTipoTran = new System.Windows.Forms.Button();
            this.btoEliminarTipoTran = new System.Windows.Forms.Button();
            this.btoLimpiarTipoTran = new System.Windows.Forms.Button();
            this.btoSalirTipoTran = new System.Windows.Forms.Button();
            this.btoSiguiente = new System.Windows.Forms.Button();
            this.grpTipoTran.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTipoTran
            // 
            this.grpTipoTran.Controls.Add(this.cboSwTipoTran);
            this.grpTipoTran.Controls.Add(this.btoBuscarTipoTran);
            this.grpTipoTran.Controls.Add(this.txtDescripcionTipoTran);
            this.grpTipoTran.Controls.Add(this.txtTipoTran);
            this.grpTipoTran.Controls.Add(this.txtIdTipoTran);
            this.grpTipoTran.Controls.Add(this.lblSwTipoTran);
            this.grpTipoTran.Controls.Add(this.lblDescripcionTipoTran);
            this.grpTipoTran.Controls.Add(this.lblTipoTran);
            this.grpTipoTran.Controls.Add(this.lblIdTipoTran);
            this.grpTipoTran.Location = new System.Drawing.Point(13, 15);
            this.grpTipoTran.Name = "grpTipoTran";
            this.grpTipoTran.Size = new System.Drawing.Size(357, 231);
            this.grpTipoTran.TabIndex = 0;
            this.grpTipoTran.TabStop = false;
            // 
            // cboSwTipoTran
            // 
            this.cboSwTipoTran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSwTipoTran.FormattingEnabled = true;
            this.cboSwTipoTran.Location = new System.Drawing.Point(107, 103);
            this.cboSwTipoTran.Name = "cboSwTipoTran";
            this.cboSwTipoTran.Size = new System.Drawing.Size(197, 21);
            this.cboSwTipoTran.TabIndex = 7;
            // 
            // btoBuscarTipoTran
            // 
            this.btoBuscarTipoTran.Image = global::Contabilidad.Properties.Resources._646732;
            this.btoBuscarTipoTran.Location = new System.Drawing.Point(231, 24);
            this.btoBuscarTipoTran.Name = "btoBuscarTipoTran";
            this.btoBuscarTipoTran.Size = new System.Drawing.Size(39, 36);
            this.btoBuscarTipoTran.TabIndex = 8;
            this.btoBuscarTipoTran.UseVisualStyleBackColor = true;
            this.btoBuscarTipoTran.Click += new System.EventHandler(this.btoBuscarTipoTran_Click);
            // 
            // txtDescripcionTipoTran
            // 
            this.txtDescripcionTipoTran.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcionTipoTran.Location = new System.Drawing.Point(107, 77);
            this.txtDescripcionTipoTran.MaxLength = 255;
            this.txtDescripcionTipoTran.Name = "txtDescripcionTipoTran";
            this.txtDescripcionTipoTran.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionTipoTran.TabIndex = 5;
            // 
            // txtTipoTran
            // 
            this.txtTipoTran.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoTran.Location = new System.Drawing.Point(107, 51);
            this.txtTipoTran.MaxLength = 4;
            this.txtTipoTran.Name = "txtTipoTran";
            this.txtTipoTran.Size = new System.Drawing.Size(100, 20);
            this.txtTipoTran.TabIndex = 3;
            // 
            // txtIdTipoTran
            // 
            this.txtIdTipoTran.Enabled = false;
            this.txtIdTipoTran.Location = new System.Drawing.Point(107, 24);
            this.txtIdTipoTran.Name = "txtIdTipoTran";
            this.txtIdTipoTran.Size = new System.Drawing.Size(48, 20);
            this.txtIdTipoTran.TabIndex = 1;
            // 
            // lblSwTipoTran
            // 
            this.lblSwTipoTran.AutoSize = true;
            this.lblSwTipoTran.Location = new System.Drawing.Point(18, 103);
            this.lblSwTipoTran.Name = "lblSwTipoTran";
            this.lblSwTipoTran.Size = new System.Drawing.Size(22, 13);
            this.lblSwTipoTran.TabIndex = 6;
            this.lblSwTipoTran.Text = "Sw";
            // 
            // lblDescripcionTipoTran
            // 
            this.lblDescripcionTipoTran.AutoSize = true;
            this.lblDescripcionTipoTran.Location = new System.Drawing.Point(18, 77);
            this.lblDescripcionTipoTran.Name = "lblDescripcionTipoTran";
            this.lblDescripcionTipoTran.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcionTipoTran.TabIndex = 4;
            this.lblDescripcionTipoTran.Text = "Descripción";
            // 
            // lblTipoTran
            // 
            this.lblTipoTran.AutoSize = true;
            this.lblTipoTran.Location = new System.Drawing.Point(18, 51);
            this.lblTipoTran.Name = "lblTipoTran";
            this.lblTipoTran.Size = new System.Drawing.Size(28, 13);
            this.lblTipoTran.TabIndex = 2;
            this.lblTipoTran.Text = "Tipo";
            // 
            // lblIdTipoTran
            // 
            this.lblIdTipoTran.AutoSize = true;
            this.lblIdTipoTran.Location = new System.Drawing.Point(18, 24);
            this.lblIdTipoTran.Name = "lblIdTipoTran";
            this.lblIdTipoTran.Size = new System.Drawing.Size(16, 13);
            this.lblIdTipoTran.TabIndex = 0;
            this.lblIdTipoTran.Text = "Id";
            // 
            // btoIngresarTipoTran
            // 
            this.btoIngresarTipoTran.Location = new System.Drawing.Point(437, 39);
            this.btoIngresarTipoTran.Name = "btoIngresarTipoTran";
            this.btoIngresarTipoTran.Size = new System.Drawing.Size(101, 34);
            this.btoIngresarTipoTran.TabIndex = 9;
            this.btoIngresarTipoTran.Text = "Ingresar";
            this.btoIngresarTipoTran.UseVisualStyleBackColor = true;
            this.btoIngresarTipoTran.Click += new System.EventHandler(this.btoIngresarTipoTran_Click);
            // 
            // btoModificarTipoTran
            // 
            this.btoModificarTipoTran.Enabled = false;
            this.btoModificarTipoTran.Location = new System.Drawing.Point(437, 79);
            this.btoModificarTipoTran.Name = "btoModificarTipoTran";
            this.btoModificarTipoTran.Size = new System.Drawing.Size(101, 34);
            this.btoModificarTipoTran.TabIndex = 10;
            this.btoModificarTipoTran.Text = "Modificar";
            this.btoModificarTipoTran.UseVisualStyleBackColor = true;
            this.btoModificarTipoTran.Click += new System.EventHandler(this.btoModificarTipoTran_Click);
            // 
            // btoEliminarTipoTran
            // 
            this.btoEliminarTipoTran.Enabled = false;
            this.btoEliminarTipoTran.Location = new System.Drawing.Point(437, 119);
            this.btoEliminarTipoTran.Name = "btoEliminarTipoTran";
            this.btoEliminarTipoTran.Size = new System.Drawing.Size(101, 34);
            this.btoEliminarTipoTran.TabIndex = 11;
            this.btoEliminarTipoTran.Text = "Eliminar";
            this.btoEliminarTipoTran.UseVisualStyleBackColor = true;
            this.btoEliminarTipoTran.Click += new System.EventHandler(this.btoEliminarTipoTran_Click);
            // 
            // btoLimpiarTipoTran
            // 
            this.btoLimpiarTipoTran.Location = new System.Drawing.Point(437, 199);
            this.btoLimpiarTipoTran.Name = "btoLimpiarTipoTran";
            this.btoLimpiarTipoTran.Size = new System.Drawing.Size(101, 34);
            this.btoLimpiarTipoTran.TabIndex = 12;
            this.btoLimpiarTipoTran.Text = "Limpiar";
            this.btoLimpiarTipoTran.UseVisualStyleBackColor = true;
            this.btoLimpiarTipoTran.Click += new System.EventHandler(this.btoLimpiarTipoTran_Click);
            // 
            // btoSalirTipoTran
            // 
            this.btoSalirTipoTran.Location = new System.Drawing.Point(437, 239);
            this.btoSalirTipoTran.Name = "btoSalirTipoTran";
            this.btoSalirTipoTran.Size = new System.Drawing.Size(101, 34);
            this.btoSalirTipoTran.TabIndex = 13;
            this.btoSalirTipoTran.Text = "Salir";
            this.btoSalirTipoTran.UseVisualStyleBackColor = true;
            this.btoSalirTipoTran.Click += new System.EventHandler(this.btoSalirTipoTran_Click);
            // 
            // btoSiguiente
            // 
            this.btoSiguiente.Location = new System.Drawing.Point(437, 159);
            this.btoSiguiente.Name = "btoSiguiente";
            this.btoSiguiente.Size = new System.Drawing.Size(101, 34);
            this.btoSiguiente.TabIndex = 14;
            this.btoSiguiente.Text = "Número Siguiente";
            this.btoSiguiente.UseVisualStyleBackColor = true;
            this.btoSiguiente.Click += new System.EventHandler(this.btoSiguiente_Click);
            // 
            // FTipoTransacciones
            // 
            this.ClientSize = new System.Drawing.Size(561, 290);
            this.Controls.Add(this.btoSiguiente);
            this.Controls.Add(this.btoSalirTipoTran);
            this.Controls.Add(this.btoLimpiarTipoTran);
            this.Controls.Add(this.btoEliminarTipoTran);
            this.Controls.Add(this.btoModificarTipoTran);
            this.Controls.Add(this.btoIngresarTipoTran);
            this.Controls.Add(this.grpTipoTran);
            this.Name = "FTipoTransacciones";
            this.Load += new System.EventHandler(this.FTipoTransacciones_Load);
            this.grpTipoTran.ResumeLayout(false);
            this.grpTipoTran.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTipoTran;
        private System.Windows.Forms.Label lblIdTipoTran;
        private System.Windows.Forms.Label lblSwTipoTran;
        private System.Windows.Forms.Label lblDescripcionTipoTran;
        private System.Windows.Forms.Label lblTipoTran;
        private System.Windows.Forms.TextBox txtDescripcionTipoTran;
        private System.Windows.Forms.TextBox txtTipoTran;
        private System.Windows.Forms.TextBox txtIdTipoTran;
        private System.Windows.Forms.Button btoBuscarTipoTran;
        private System.Windows.Forms.Button btoIngresarTipoTran;
        private System.Windows.Forms.Button btoModificarTipoTran;
        private System.Windows.Forms.Button btoEliminarTipoTran;
        private System.Windows.Forms.Button btoLimpiarTipoTran;
        private System.Windows.Forms.Button btoSalirTipoTran;
        private System.Windows.Forms.ComboBox cboSwTipoTran;
        private System.Windows.Forms.Button btoSiguiente;
    }
}