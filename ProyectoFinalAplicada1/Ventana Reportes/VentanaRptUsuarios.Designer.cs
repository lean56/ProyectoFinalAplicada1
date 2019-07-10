namespace ProyectoFinalAplicada1.Ventana_Reportes
{
    partial class VentanaRptUsuarios
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
            this.UsuarioscrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // UsuarioscrystalReportViewer
            // 
            this.UsuarioscrystalReportViewer.ActiveViewIndex = -1;
            this.UsuarioscrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsuarioscrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.UsuarioscrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsuarioscrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.UsuarioscrystalReportViewer.Name = "UsuarioscrystalReportViewer";
            this.UsuarioscrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.UsuarioscrystalReportViewer.TabIndex = 0;
            this.UsuarioscrystalReportViewer.Load += new System.EventHandler(this.UsuarioscrystalReportViewer_Load);
            // 
            // VentanaRptUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UsuarioscrystalReportViewer);
            this.Name = "VentanaRptUsuarios";
            this.Text = "VentanaRptUsuarios";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer UsuarioscrystalReportViewer;
    }
}