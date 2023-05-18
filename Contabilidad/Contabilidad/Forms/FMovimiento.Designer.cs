namespace Contabilidad
{
    partial class FMovimiento
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMovimiento));
            this.grbDatosMov = new System.Windows.Forms.GroupBox();
            this.lblDescripcionTipoMov1 = new System.Windows.Forms.Label();
            this.btoBuscarTipoTranMov = new System.Windows.Forms.Button();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.lblNotasMov = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtSiguienteTipoMov = new System.Windows.Forms.TextBox();
            this.lblSiguienteTipoMov = new System.Windows.Forms.Label();
            this.lblDescripcionTipoMov = new System.Windows.Forms.Label();
            this.txtTipoMov = new System.Windows.Forms.TextBox();
            this.lblTipoMov = new System.Windows.Forms.Label();
            this.grdMovimientoMov = new System.Windows.Forms.DataGridView();
            this.btoActualizarMov = new System.Windows.Forms.Button();
            this.btoSalirMov = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.movimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btoLimpiar = new System.Windows.Forms.Button();
            this.grbCuentas = new System.Windows.Forms.GroupBox();
            this.lblDescripcionCuenta1 = new System.Windows.Forms.Label();
            this.btoBuscarCuentas = new System.Windows.Forms.Button();
            this.lblDescripcionCuenta = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.lblDescripcionCentro1 = new System.Windows.Forms.Label();
            this.btoBuscarCentros = new System.Windows.Forms.Button();
            this.lblDescripcionCentro = new System.Windows.Forms.Label();
            this.txtCentro = new System.Windows.Forms.TextBox();
            this.lblCentro = new System.Windows.Forms.Label();
            this.txtNitTercero = new System.Windows.Forms.TextBox();
            this.lblNitTercero = new System.Windows.Forms.Label();
            this.btoBuscarTerceros = new System.Windows.Forms.Button();
            this.lblNombresTercero = new System.Windows.Forms.Label();
            this.lblNombresTercero1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btoAgregar = new System.Windows.Forms.Button();
            this.grdMovimientosMovEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.grdMovimientoMovColCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdMovimientoMovColCuentaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdMovimientoMovColCentro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdMovimientoMovColCentroDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdMovimientoMovColNit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTercero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crédito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDatosMov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMovimientoMov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimientoBindingSource)).BeginInit();
            this.grbCuentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatosMov
            // 
            this.grbDatosMov.Controls.Add(this.lblDescripcionTipoMov1);
            this.grbDatosMov.Controls.Add(this.btoBuscarTipoTranMov);
            this.grbDatosMov.Controls.Add(this.txtNotas);
            this.grbDatosMov.Controls.Add(this.lblNotasMov);
            this.grbDatosMov.Controls.Add(this.dateTimePicker1);
            this.grbDatosMov.Controls.Add(this.lblFecha);
            this.grbDatosMov.Controls.Add(this.txtSiguienteTipoMov);
            this.grbDatosMov.Controls.Add(this.lblSiguienteTipoMov);
            this.grbDatosMov.Controls.Add(this.lblDescripcionTipoMov);
            this.grbDatosMov.Controls.Add(this.txtTipoMov);
            this.grbDatosMov.Controls.Add(this.lblTipoMov);
            this.grbDatosMov.Location = new System.Drawing.Point(23, 21);
            this.grbDatosMov.Name = "grbDatosMov";
            this.grbDatosMov.Size = new System.Drawing.Size(821, 161);
            this.grbDatosMov.TabIndex = 5;
            this.grbDatosMov.TabStop = false;
            this.grbDatosMov.Text = "Tipo";
            // 
            // lblDescripcionTipoMov1
            // 
            this.lblDescripcionTipoMov1.AutoSize = true;
            this.lblDescripcionTipoMov1.Location = new System.Drawing.Point(249, 38);
            this.lblDescripcionTipoMov1.Name = "lblDescripcionTipoMov1";
            this.lblDescripcionTipoMov1.Size = new System.Drawing.Size(35, 13);
            this.lblDescripcionTipoMov1.TabIndex = 15;
            this.lblDescripcionTipoMov1.Text = "label1";
            // 
            // btoBuscarTipoTranMov
            // 
            this.btoBuscarTipoTranMov.Image = global::Contabilidad.Properties.Resources._646732;
            this.btoBuscarTipoTranMov.Location = new System.Drawing.Point(130, 19);
            this.btoBuscarTipoTranMov.Name = "btoBuscarTipoTranMov";
            this.btoBuscarTipoTranMov.Size = new System.Drawing.Size(39, 36);
            this.btoBuscarTipoTranMov.TabIndex = 14;
            this.btoBuscarTipoTranMov.UseVisualStyleBackColor = true;
            this.btoBuscarTipoTranMov.Click += new System.EventHandler(this.btoBuscarTipoTranMov_Click);
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(18, 112);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(474, 20);
            this.txtNotas.TabIndex = 13;
            // 
            // lblNotasMov
            // 
            this.lblNotasMov.AutoSize = true;
            this.lblNotasMov.Location = new System.Drawing.Point(18, 96);
            this.lblNotasMov.Name = "lblNotasMov";
            this.lblNotasMov.Size = new System.Drawing.Size(35, 13);
            this.lblNotasMov.TabIndex = 12;
            this.lblNotasMov.Text = "Notas";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(18, 69);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha";
            // 
            // txtSiguienteTipoMov
            // 
            this.txtSiguienteTipoMov.Enabled = false;
            this.txtSiguienteTipoMov.Location = new System.Drawing.Point(447, 35);
            this.txtSiguienteTipoMov.Name = "txtSiguienteTipoMov";
            this.txtSiguienteTipoMov.Size = new System.Drawing.Size(34, 20);
            this.txtSiguienteTipoMov.TabIndex = 9;
            // 
            // lblSiguienteTipoMov
            // 
            this.lblSiguienteTipoMov.AutoSize = true;
            this.lblSiguienteTipoMov.Location = new System.Drawing.Point(390, 38);
            this.lblSiguienteTipoMov.Name = "lblSiguienteTipoMov";
            this.lblSiguienteTipoMov.Size = new System.Drawing.Size(51, 13);
            this.lblSiguienteTipoMov.TabIndex = 8;
            this.lblSiguienteTipoMov.Text = "Siguiente";
            // 
            // lblDescripcionTipoMov
            // 
            this.lblDescripcionTipoMov.AutoSize = true;
            this.lblDescripcionTipoMov.Location = new System.Drawing.Point(175, 38);
            this.lblDescripcionTipoMov.Name = "lblDescripcionTipoMov";
            this.lblDescripcionTipoMov.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcionTipoMov.TabIndex = 7;
            this.lblDescripcionTipoMov.Text = "Descripcion";
            // 
            // txtTipoMov
            // 
            this.txtTipoMov.Location = new System.Drawing.Point(69, 33);
            this.txtTipoMov.Name = "txtTipoMov";
            this.txtTipoMov.Size = new System.Drawing.Size(55, 20);
            this.txtTipoMov.TabIndex = 6;
            // 
            // lblTipoMov
            // 
            this.lblTipoMov.AutoSize = true;
            this.lblTipoMov.Location = new System.Drawing.Point(18, 33);
            this.lblTipoMov.Name = "lblTipoMov";
            this.lblTipoMov.Size = new System.Drawing.Size(28, 13);
            this.lblTipoMov.TabIndex = 5;
            this.lblTipoMov.Text = "Tipo";
            // 
            // grdMovimientoMov
            // 
            this.grdMovimientoMov.AllowUserToDeleteRows = false;
            this.grdMovimientoMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMovimientoMov.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdMovimientosMovEliminar,
            this.grdMovimientoMovColCuenta,
            this.grdMovimientoMovColCuentaDescripcion,
            this.grdMovimientoMovColCentro,
            this.grdMovimientoMovColCentroDescripcion,
            this.grdMovimientoMovColNit,
            this.NombreTercero,
            this.debito,
            this.Crédito});
            this.grdMovimientoMov.Location = new System.Drawing.Point(23, 354);
            this.grdMovimientoMov.Name = "grdMovimientoMov";
            this.grdMovimientoMov.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdMovimientoMov.Size = new System.Drawing.Size(821, 90);
            this.grdMovimientoMov.TabIndex = 6;
            this.grdMovimientoMov.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMovimientoMov_CellClick);
            this.grdMovimientoMov.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMovimientoMov_CellContentClick);
            this.grdMovimientoMov.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMovimientoMov_CellLeave);
            this.grdMovimientoMov.CurrentCellChanged += new System.EventHandler(this.grdMovimientoMov_CurrentCellChanged);
            this.grdMovimientoMov.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdMovimientoMov_KeyDown);
            this.grdMovimientoMov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grdMovimientoMov_KeyPress);
            // 
            // btoActualizarMov
            // 
            this.btoActualizarMov.Location = new System.Drawing.Point(862, 48);
            this.btoActualizarMov.Name = "btoActualizarMov";
            this.btoActualizarMov.Size = new System.Drawing.Size(101, 35);
            this.btoActualizarMov.TabIndex = 7;
            this.btoActualizarMov.Text = "Actualizar";
            this.btoActualizarMov.UseVisualStyleBackColor = true;
            this.btoActualizarMov.Click += new System.EventHandler(this.btoActualizarMov_Click);
            // 
            // btoSalirMov
            // 
            this.btoSalirMov.Location = new System.Drawing.Point(862, 133);
            this.btoSalirMov.Name = "btoSalirMov";
            this.btoSalirMov.Size = new System.Drawing.Size(101, 34);
            this.btoSalirMov.TabIndex = 14;
            this.btoSalirMov.Text = "Salir";
            this.btoSalirMov.UseVisualStyleBackColor = true;
            this.btoSalirMov.Click += new System.EventHandler(this.btoSalirMov_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Buscar";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.ToolTipText = "Buscar Cuenta";
            this.dataGridViewImageColumn1.Width = 45;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Buscar";
            this.dataGridViewImageColumn2.Image = global::Contabilidad.Properties.Resources._0141;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // movimientoBindingSource
            // 
            this.movimientoBindingSource.DataSource = typeof(Contabilidad.Movimiento);
            // 
            // btoLimpiar
            // 
            this.btoLimpiar.Location = new System.Drawing.Point(862, 89);
            this.btoLimpiar.Name = "btoLimpiar";
            this.btoLimpiar.Size = new System.Drawing.Size(101, 34);
            this.btoLimpiar.TabIndex = 15;
            this.btoLimpiar.Text = "Limpiar";
            this.btoLimpiar.UseVisualStyleBackColor = true;
            this.btoLimpiar.Click += new System.EventHandler(this.btoLimpiar_Click);
            // 
            // grbCuentas
            // 
            this.grbCuentas.Controls.Add(this.btoAgregar);
            this.grbCuentas.Controls.Add(this.txtValor);
            this.grbCuentas.Controls.Add(this.lblValor);
            this.grbCuentas.Controls.Add(this.lblNombresTercero1);
            this.grbCuentas.Controls.Add(this.txtNitTercero);
            this.grbCuentas.Controls.Add(this.lblNitTercero);
            this.grbCuentas.Controls.Add(this.btoBuscarTerceros);
            this.grbCuentas.Controls.Add(this.lblNombresTercero);
            this.grbCuentas.Controls.Add(this.lblDescripcionCentro1);
            this.grbCuentas.Controls.Add(this.btoBuscarCentros);
            this.grbCuentas.Controls.Add(this.lblDescripcionCentro);
            this.grbCuentas.Controls.Add(this.txtCentro);
            this.grbCuentas.Controls.Add(this.lblCentro);
            this.grbCuentas.Controls.Add(this.lblDescripcionCuenta1);
            this.grbCuentas.Controls.Add(this.btoBuscarCuentas);
            this.grbCuentas.Controls.Add(this.lblDescripcionCuenta);
            this.grbCuentas.Controls.Add(this.txtCuenta);
            this.grbCuentas.Controls.Add(this.lblCuenta);
            this.grbCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbCuentas.Location = new System.Drawing.Point(23, 188);
            this.grbCuentas.Name = "grbCuentas";
            this.grbCuentas.Size = new System.Drawing.Size(821, 160);
            this.grbCuentas.TabIndex = 16;
            this.grbCuentas.TabStop = false;
            this.grbCuentas.Text = "Movimiento";
            // 
            // lblDescripcionCuenta1
            // 
            this.lblDescripcionCuenta1.AutoSize = true;
            this.lblDescripcionCuenta1.Location = new System.Drawing.Point(330, 32);
            this.lblDescripcionCuenta1.Name = "lblDescripcionCuenta1";
            this.lblDescripcionCuenta1.Size = new System.Drawing.Size(35, 13);
            this.lblDescripcionCuenta1.TabIndex = 20;
            this.lblDescripcionCuenta1.Text = "label2";
            // 
            // btoBuscarCuentas
            // 
            this.btoBuscarCuentas.Image = global::Contabilidad.Properties.Resources._646732;
            this.btoBuscarCuentas.Location = new System.Drawing.Point(211, 18);
            this.btoBuscarCuentas.Name = "btoBuscarCuentas";
            this.btoBuscarCuentas.Size = new System.Drawing.Size(39, 36);
            this.btoBuscarCuentas.TabIndex = 19;
            this.btoBuscarCuentas.UseVisualStyleBackColor = true;
            this.btoBuscarCuentas.Click += new System.EventHandler(this.btnBuscarCuentas_Click);
            // 
            // lblDescripcionCuenta
            // 
            this.lblDescripcionCuenta.AutoSize = true;
            this.lblDescripcionCuenta.Location = new System.Drawing.Point(260, 32);
            this.lblDescripcionCuenta.Name = "lblDescripcionCuenta";
            this.lblDescripcionCuenta.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcionCuenta.TabIndex = 18;
            this.lblDescripcionCuenta.Text = "Descripcion";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(96, 30);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(102, 20);
            this.txtCuenta.TabIndex = 17;
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(16, 32);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(41, 13);
            this.lblCuenta.TabIndex = 16;
            this.lblCuenta.Text = "Cuenta";
            // 
            // lblDescripcionCentro1
            // 
            this.lblDescripcionCentro1.AutoSize = true;
            this.lblDescripcionCentro1.Location = new System.Drawing.Point(753, 30);
            this.lblDescripcionCentro1.Name = "lblDescripcionCentro1";
            this.lblDescripcionCentro1.Size = new System.Drawing.Size(35, 13);
            this.lblDescripcionCentro1.TabIndex = 25;
            this.lblDescripcionCentro1.Text = "label2";
            // 
            // btoBuscarCentros
            // 
            this.btoBuscarCentros.Image = global::Contabilidad.Properties.Resources._646732;
            this.btoBuscarCentros.Location = new System.Drawing.Point(634, 16);
            this.btoBuscarCentros.Name = "btoBuscarCentros";
            this.btoBuscarCentros.Size = new System.Drawing.Size(39, 36);
            this.btoBuscarCentros.TabIndex = 24;
            this.btoBuscarCentros.UseVisualStyleBackColor = true;
            this.btoBuscarCentros.Click += new System.EventHandler(this.btoBuscarCentros_Click);
            // 
            // lblDescripcionCentro
            // 
            this.lblDescripcionCentro.AutoSize = true;
            this.lblDescripcionCentro.Location = new System.Drawing.Point(683, 30);
            this.lblDescripcionCentro.Name = "lblDescripcionCentro";
            this.lblDescripcionCentro.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcionCentro.TabIndex = 23;
            this.lblDescripcionCentro.Text = "Descripcion";
            // 
            // txtCentro
            // 
            this.txtCentro.Location = new System.Drawing.Point(518, 28);
            this.txtCentro.Name = "txtCentro";
            this.txtCentro.Size = new System.Drawing.Size(55, 20);
            this.txtCentro.TabIndex = 22;
            // 
            // lblCentro
            // 
            this.lblCentro.AutoSize = true;
            this.lblCentro.Location = new System.Drawing.Point(439, 30);
            this.lblCentro.Name = "lblCentro";
            this.lblCentro.Size = new System.Drawing.Size(38, 13);
            this.lblCentro.TabIndex = 21;
            this.lblCentro.Text = "Centro";
            // 
            // txtNitTercero
            // 
            this.txtNitTercero.Location = new System.Drawing.Point(96, 76);
            this.txtNitTercero.Name = "txtNitTercero";
            this.txtNitTercero.Size = new System.Drawing.Size(102, 20);
            this.txtNitTercero.TabIndex = 26;
            // 
            // lblNitTercero
            // 
            this.lblNitTercero.AutoSize = true;
            this.lblNitTercero.Location = new System.Drawing.Point(16, 78);
            this.lblNitTercero.Name = "lblNitTercero";
            this.lblNitTercero.Size = new System.Drawing.Size(70, 13);
            this.lblNitTercero.TabIndex = 30;
            this.lblNitTercero.Text = "Identificacion";
            // 
            // btoBuscarTerceros
            // 
            this.btoBuscarTerceros.Image = global::Contabilidad.Properties.Resources._646732;
            this.btoBuscarTerceros.Location = new System.Drawing.Point(211, 64);
            this.btoBuscarTerceros.Name = "btoBuscarTerceros";
            this.btoBuscarTerceros.Size = new System.Drawing.Size(39, 36);
            this.btoBuscarTerceros.TabIndex = 29;
            this.btoBuscarTerceros.Click += new System.EventHandler(this.btoBuscarTerceros_Click);
            // 
            // lblNombresTercero
            // 
            this.lblNombresTercero.AutoSize = true;
            this.lblNombresTercero.Location = new System.Drawing.Point(260, 78);
            this.lblNombresTercero.Name = "lblNombresTercero";
            this.lblNombresTercero.Size = new System.Drawing.Size(49, 13);
            this.lblNombresTercero.TabIndex = 28;
            this.lblNombresTercero.Text = "Nombres";
            // 
            // lblNombresTercero1
            // 
            this.lblNombresTercero1.AutoSize = true;
            this.lblNombresTercero1.Location = new System.Drawing.Point(330, 78);
            this.lblNombresTercero1.Name = "lblNombresTercero1";
            this.lblNombresTercero1.Size = new System.Drawing.Size(49, 13);
            this.lblNombresTercero1.TabIndex = 31;
            this.lblNombresTercero1.Text = "Nombres";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(96, 122);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(102, 20);
            this.txtValor.TabIndex = 32;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(16, 124);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 33;
            this.lblValor.Text = "Valor";
            // 
            // btoAgregar
            // 
            this.btoAgregar.Location = new System.Drawing.Point(714, 102);
            this.btoAgregar.Name = "btoAgregar";
            this.btoAgregar.Size = new System.Drawing.Size(101, 35);
            this.btoAgregar.TabIndex = 34;
            this.btoAgregar.Text = "Agregar";
            this.btoAgregar.UseVisualStyleBackColor = true;
            // 
            // grdMovimientosMovEliminar
            // 
            this.grdMovimientosMovEliminar.HeaderText = "";
            this.grdMovimientosMovEliminar.Image = global::Contabilidad.Properties.Resources._0141;
            this.grdMovimientosMovEliminar.Name = "grdMovimientosMovEliminar";
            this.grdMovimientosMovEliminar.ReadOnly = true;
            // 
            // grdMovimientoMovColCuenta
            // 
            this.grdMovimientoMovColCuenta.HeaderText = "Cuenta";
            this.grdMovimientoMovColCuenta.Name = "grdMovimientoMovColCuenta";
            this.grdMovimientoMovColCuenta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // grdMovimientoMovColCuentaDescripcion
            // 
            this.grdMovimientoMovColCuentaDescripcion.HeaderText = "Descripción";
            this.grdMovimientoMovColCuentaDescripcion.Name = "grdMovimientoMovColCuentaDescripcion";
            this.grdMovimientoMovColCuentaDescripcion.ReadOnly = true;
            // 
            // grdMovimientoMovColCentro
            // 
            this.grdMovimientoMovColCentro.HeaderText = "Centro";
            this.grdMovimientoMovColCentro.Name = "grdMovimientoMovColCentro";
            // 
            // grdMovimientoMovColCentroDescripcion
            // 
            this.grdMovimientoMovColCentroDescripcion.DataPropertyName = "id";
            this.grdMovimientoMovColCentroDescripcion.HeaderText = "Descripción";
            this.grdMovimientoMovColCentroDescripcion.Name = "grdMovimientoMovColCentroDescripcion";
            this.grdMovimientoMovColCentroDescripcion.ReadOnly = true;
            // 
            // grdMovimientoMovColNit
            // 
            this.grdMovimientoMovColNit.HeaderText = "CI";
            this.grdMovimientoMovColNit.Name = "grdMovimientoMovColNit";
            // 
            // NombreTercero
            // 
            this.NombreTercero.DataPropertyName = "id";
            this.NombreTercero.HeaderText = "Nombre";
            this.NombreTercero.Name = "NombreTercero";
            this.NombreTercero.ReadOnly = true;
            // 
            // debito
            // 
            this.debito.HeaderText = "Débito";
            this.debito.Name = "debito";
            // 
            // Crédito
            // 
            this.Crédito.HeaderText = "Crédito";
            this.Crédito.Name = "Crédito";
            // 
            // FMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 456);
            this.Controls.Add(this.grbCuentas);
            this.Controls.Add(this.btoLimpiar);
            this.Controls.Add(this.btoSalirMov);
            this.Controls.Add(this.btoActualizarMov);
            this.Controls.Add(this.grdMovimientoMov);
            this.Controls.Add(this.grbDatosMov);
            this.Name = "FMovimiento";
            this.Text = "Movimiento";
            this.Load += new System.EventHandler(this.FMovimiento_Load);
            this.grbDatosMov.ResumeLayout(false);
            this.grbDatosMov.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMovimientoMov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimientoBindingSource)).EndInit();
            this.grbCuentas.ResumeLayout(false);
            this.grbCuentas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosMov;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtSiguienteTipoMov;
        private System.Windows.Forms.Label lblSiguienteTipoMov;
        private System.Windows.Forms.Label lblDescripcionTipoMov;
        private System.Windows.Forms.TextBox txtTipoMov;
        private System.Windows.Forms.Label lblTipoMov;
        private System.Windows.Forms.DataGridView grdMovimientoMov;
        private System.Windows.Forms.BindingSource movimientoBindingSource;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label lblNotasMov;
        private System.Windows.Forms.Button btoActualizarMov;
        private System.Windows.Forms.Button btoSalirMov;
        private System.Windows.Forms.Button btoBuscarTipoTranMov;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Label lblDescripcionTipoMov1;
        private System.Windows.Forms.Button btoLimpiar;
        private System.Windows.Forms.GroupBox grbCuentas;
        private System.Windows.Forms.Label lblDescripcionCuenta1;
        private System.Windows.Forms.Button btoBuscarCuentas;
        private System.Windows.Forms.Label lblDescripcionCuenta;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Label lblDescripcionCentro1;
        private System.Windows.Forms.Button btoBuscarCentros;
        private System.Windows.Forms.Label lblDescripcionCentro;
        private System.Windows.Forms.TextBox txtCentro;
        private System.Windows.Forms.Label lblCentro;
        private System.Windows.Forms.Label lblNombresTercero1;
        public System.Windows.Forms.TextBox txtNitTercero;
        private System.Windows.Forms.Label lblNitTercero;
        private System.Windows.Forms.Button btoBuscarTerceros;
        private System.Windows.Forms.Label lblNombresTercero;
        private System.Windows.Forms.Button btoAgregar;
        public System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.DataGridViewImageColumn grdMovimientosMovEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdMovimientoMovColCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdMovimientoMovColCuentaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdMovimientoMovColCentro;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdMovimientoMovColCentroDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdMovimientoMovColNit;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTercero;
        private System.Windows.Forms.DataGridViewTextBoxColumn debito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crédito;
    }
}