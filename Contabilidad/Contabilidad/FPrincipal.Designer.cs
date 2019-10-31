namespace Contabilidad
{
    partial class FPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionesContablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCuentas = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuInicio});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuInicio
            // 
            this.MnuInicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionesContablesToolStripMenuItem,
            this.MnuCuentas,
            this.salirToolStripMenuItem});
            this.MnuInicio.Name = "MnuInicio";
            this.MnuInicio.Size = new System.Drawing.Size(48, 20);
            this.MnuInicio.Text = "Inicio";
            // 
            // configuracionesContablesToolStripMenuItem
            // 
            this.configuracionesContablesToolStripMenuItem.Name = "configuracionesContablesToolStripMenuItem";
            this.configuracionesContablesToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.configuracionesContablesToolStripMenuItem.Text = "Configuraciones Contables";
            this.configuracionesContablesToolStripMenuItem.Click += new System.EventHandler(this.configuracionesContablesToolStripMenuItem_Click);
            // 
            // MnuCuentas
            // 
            this.MnuCuentas.Name = "MnuCuentas";
            this.MnuCuentas.Size = new System.Drawing.Size(217, 22);
            this.MnuCuentas.Text = "Cuentas";
            this.MnuCuentas.Click += new System.EventHandler(this.MnuCuentas_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FPrincipal";
            this.Text = "Contabilidad";
            this.Load += new System.EventHandler(this.FPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuInicio;
        private System.Windows.Forms.ToolStripMenuItem MnuCuentas;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionesContablesToolStripMenuItem;
    }
}