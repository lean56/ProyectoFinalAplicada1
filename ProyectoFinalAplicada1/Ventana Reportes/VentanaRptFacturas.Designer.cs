namespace ProyectoFinalAplicada1.Ventana_Reportes
{
    partial class VentanaRptFacturas
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
            this.FacturascrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // FacturascrystalReportViewer
            // 
            this.FacturascrystalReportViewer.ActiveViewIndex = -1;
            this.FacturascrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FacturascrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.FacturascrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FacturascrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.FacturascrystalReportViewer.Name = "FacturascrystalReportViewer";
            this.FacturascrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.FacturascrystalReportViewer.TabIndex = 0;
            this.FacturascrystalReportViewer.Load += new System.EventHandler(this.FacturascrystalReportViewer_Load);
            // 
            // VentanaRptFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FacturascrystalReportViewer);
            this.Name = "VentanaRptFacturas";
            this.Text = "VentanaRptFacturas";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer FacturascrystalReportViewer;
    }
}