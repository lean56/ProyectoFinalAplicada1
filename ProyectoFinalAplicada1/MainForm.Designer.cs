namespace ProyectoFinalAplicada1
{
    partial class MainForm
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.dToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroUsuarioToolStripMenuItem,
            this.registroProductosToolStripMenuItem,
            this.entradaDeProductosToolStripMenuItem,
            this.registroDeClientesToolStripMenuItem,
            this.registroDeFacturasToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // registroUsuarioToolStripMenuItem
            // 
            this.registroUsuarioToolStripMenuItem.Name = "registroUsuarioToolStripMenuItem";
            this.registroUsuarioToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.registroUsuarioToolStripMenuItem.Text = "Registro Usuario";
            this.registroUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registroUsuarioToolStripMenuItem_Click);
            // 
            // registroProductosToolStripMenuItem
            // 
            this.registroProductosToolStripMenuItem.Name = "registroProductosToolStripMenuItem";
            this.registroProductosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.registroProductosToolStripMenuItem.Text = "Registro Productos";
            this.registroProductosToolStripMenuItem.Click += new System.EventHandler(this.registroProductosToolStripMenuItem_Click);
            // 
            // entradaDeProductosToolStripMenuItem
            // 
            this.entradaDeProductosToolStripMenuItem.Name = "entradaDeProductosToolStripMenuItem";
            this.entradaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.entradaDeProductosToolStripMenuItem.Text = "Entrada de Productos";
            this.entradaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.entradaDeProductosToolStripMenuItem_Click);
            // 
            // registroDeClientesToolStripMenuItem
            // 
            this.registroDeClientesToolStripMenuItem.Name = "registroDeClientesToolStripMenuItem";
            this.registroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.registroDeClientesToolStripMenuItem.Text = "Registro de Clientes";
            this.registroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.registroDeClientesToolStripMenuItem_Click);
            // 
            // registroDeFacturasToolStripMenuItem
            // 
            this.registroDeFacturasToolStripMenuItem.Name = "registroDeFacturasToolStripMenuItem";
            this.registroDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.registroDeFacturasToolStripMenuItem.Text = "Registro de Facturas";
            this.registroDeFacturasToolStripMenuItem.Click += new System.EventHandler(this.registroDeFacturasToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaUsuariosToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // consultaUsuariosToolStripMenuItem
            // 
            this.consultaUsuariosToolStripMenuItem.Name = "consultaUsuariosToolStripMenuItem";
            this.consultaUsuariosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.consultaUsuariosToolStripMenuItem.Text = "Consulta Usuarios";
            this.consultaUsuariosToolStripMenuItem.Click += new System.EventHandler(this.consultaUsuariosToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginsToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.loginToolStripMenuItem.Text = "login";
            // 
            // loginsToolStripMenuItem
            // 
            this.loginsToolStripMenuItem.Name = "loginsToolStripMenuItem";
            this.loginsToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.loginsToolStripMenuItem.Text = "logins";
            this.loginsToolStripMenuItem.Click += new System.EventHandler(this.loginsToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem});
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(26, 20);
            this.dToolStripMenuItem.Text = "d";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cToolStripMenuItem.Text = "Cerrar Sesion";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
    }
}

