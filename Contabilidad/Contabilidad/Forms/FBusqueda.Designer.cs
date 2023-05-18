namespace Contabilidad
{
    partial class FBusqueda
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
            this.grdViewDatos = new System.Windows.Forms.DataGridView();
            this.btnEscoger = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdViewDatos
            // 
            this.grdViewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewDatos.Location = new System.Drawing.Point(17, 13);
            this.grdViewDatos.Name = "grdViewDatos";
            this.grdViewDatos.ReadOnly = true;
            this.grdViewDatos.Size = new System.Drawing.Size(489, 218);
            this.grdViewDatos.TabIndex = 0;
            this.grdViewDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdViewDatos_CellContentClick);
            this.grdViewDatos.DoubleClick += new System.EventHandler(this.btnEscoger_Click);
            // 
            // btnEscoger
            // 
            this.btnEscoger.Location = new System.Drawing.Point(521, 13);
            this.btnEscoger.Name = "btnEscoger";
            this.btnEscoger.Size = new System.Drawing.Size(97, 30);
            this.btnEscoger.TabIndex = 1;
            this.btnEscoger.Text = "Escoger";
            this.btnEscoger.UseVisualStyleBackColor = true;
            this.btnEscoger.Click += new System.EventHandler(this.btnEscoger_Click);
            // 
            // FBusqueda
            // 
            this.ClientSize = new System.Drawing.Size(630, 283);
            this.Controls.Add(this.btnEscoger);
            this.Controls.Add(this.grdViewDatos);
            this.Name = "FBusqueda";
            this.Load += new System.EventHandler(this.frmBusqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.DataGridView grdViewDatos;
        private System.Windows.Forms.Button btnEscoger;
    }
}