namespace ProyectoFinalAplicada1
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.restaurar = new System.Windows.Forms.PictureBox();
            this.min = new System.Windows.Forms.PictureBox();
            this.Max = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.HideButton = new System.Windows.Forms.PictureBox();
            this.CerrarSeccionbutton = new System.Windows.Forms.Button();
            this.ClienteAdd = new System.Windows.Forms.Button();
            this.Facturabutton = new System.Windows.Forms.Button();
            this.CategoriaAbutton = new System.Windows.Forms.Button();
            this.RegistroAsignatura = new System.Windows.Forms.Button();
            this.EntradadeProductos = new System.Windows.Forms.Button();
            this.RegistroEstudiante = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Userlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraTitulo.SuspendLayout();
            this.PanelContenedor.SuspendLayout();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HideButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BarraTitulo.Controls.Add(this.restaurar);
            this.BarraTitulo.Controls.Add(this.min);
            this.BarraTitulo.Controls.Add(this.Max);
            this.BarraTitulo.Controls.Add(this.Salir);
            this.BarraTitulo.Controls.Add(this.HideButton);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(176, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(774, 50);
            this.BarraTitulo.TabIndex = 4;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.SystemColors.Control;
            this.PanelContenedor.Controls.Add(this.label2);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelContenedor.Location = new System.Drawing.Point(176, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(774, 600);
            this.PanelContenedor.TabIndex = 5;
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.MenuVertical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.Userlabel);
            this.MenuVertical.Controls.Add(this.label1);
            this.MenuVertical.Controls.Add(this.CerrarSeccionbutton);
            this.MenuVertical.Controls.Add(this.ClienteAdd);
            this.MenuVertical.Controls.Add(this.Facturabutton);
            this.MenuVertical.Controls.Add(this.CategoriaAbutton);
            this.MenuVertical.Controls.Add(this.RegistroAsignatura);
            this.MenuVertical.Controls.Add(this.EntradadeProductos);
            this.MenuVertical.Controls.Add(this.RegistroEstudiante);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(176, 600);
            this.MenuVertical.TabIndex = 3;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // restaurar
            // 
            this.restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restaurar.Image = global::ProyectoFinalAplicada1.Properties.Resources.icon_restaurar;
            this.restaurar.Location = new System.Drawing.Point(702, 9);
            this.restaurar.Name = "restaurar";
            this.restaurar.Size = new System.Drawing.Size(30, 30);
            this.restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restaurar.TabIndex = 7;
            this.restaurar.TabStop = false;
            this.restaurar.Click += new System.EventHandler(this.restaurar_Click);
            // 
            // min
            // 
            this.min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.min.Image = global::ProyectoFinalAplicada1.Properties.Resources.icon_minimizar;
            this.min.Location = new System.Drawing.Point(666, 9);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(30, 30);
            this.min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.min.TabIndex = 6;
            this.min.TabStop = false;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // Max
            // 
            this.Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Max.Image = global::ProyectoFinalAplicada1.Properties.Resources.icon_maximizar;
            this.Max.Location = new System.Drawing.Point(702, 9);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(30, 30);
            this.Max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Max.TabIndex = 4;
            this.Max.TabStop = false;
            this.Max.Click += new System.EventHandler(this.Max_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.Image = global::ProyectoFinalAplicada1.Properties.Resources.icon_cerrar2;
            this.Salir.Location = new System.Drawing.Point(738, 9);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(30, 30);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Salir.TabIndex = 5;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // HideButton
            // 
            this.HideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.HideButton.Image = global::ProyectoFinalAplicada1.Properties.Resources.ic_menu_128_28650;
            this.HideButton.Location = new System.Drawing.Point(6, 9);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(35, 35);
            this.HideButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HideButton.TabIndex = 0;
            this.HideButton.TabStop = false;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // CerrarSeccionbutton
            // 
            this.CerrarSeccionbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.CerrarSeccionbutton.FlatAppearance.BorderSize = 0;
            this.CerrarSeccionbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.CerrarSeccionbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarSeccionbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CerrarSeccionbutton.Image = global::ProyectoFinalAplicada1.Properties.Resources.SignOut_icon_icons_com_74704;
            this.CerrarSeccionbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CerrarSeccionbutton.Location = new System.Drawing.Point(0, 541);
            this.CerrarSeccionbutton.Name = "CerrarSeccionbutton";
            this.CerrarSeccionbutton.Size = new System.Drawing.Size(173, 47);
            this.CerrarSeccionbutton.TabIndex = 11;
            this.CerrarSeccionbutton.Text = "Cerrar  sesión";
            this.CerrarSeccionbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CerrarSeccionbutton.UseVisualStyleBackColor = false;
            this.CerrarSeccionbutton.Click += new System.EventHandler(this.CerrarSeccionbutton_Click);
            // 
            // ClienteAdd
            // 
            this.ClienteAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClienteAdd.FlatAppearance.BorderSize = 0;
            this.ClienteAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClienteAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClienteAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClienteAdd.Image = global::ProyectoFinalAplicada1.Properties.Resources.business_application_addmale_useradd_insert_add_user_client_2312;
            this.ClienteAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClienteAdd.Location = new System.Drawing.Point(3, 304);
            this.ClienteAdd.Name = "ClienteAdd";
            this.ClienteAdd.Size = new System.Drawing.Size(173, 47);
            this.ClienteAdd.TabIndex = 10;
            this.ClienteAdd.Text = "Registro de Clientes";
            this.ClienteAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClienteAdd.UseVisualStyleBackColor = false;
            this.ClienteAdd.Click += new System.EventHandler(this.ClienteAdd_Click);
            // 
            // Facturabutton
            // 
            this.Facturabutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.Facturabutton.FlatAppearance.BorderSize = 0;
            this.Facturabutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Facturabutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Facturabutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Facturabutton.Image = global::ProyectoFinalAplicada1.Properties.Resources.ic_add_shopping_cart_128_28122;
            this.Facturabutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Facturabutton.Location = new System.Drawing.Point(3, 368);
            this.Facturabutton.Name = "Facturabutton";
            this.Facturabutton.Size = new System.Drawing.Size(173, 47);
            this.Facturabutton.TabIndex = 9;
            this.Facturabutton.Text = "Facturación";
            this.Facturabutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Facturabutton.UseVisualStyleBackColor = false;
            this.Facturabutton.Click += new System.EventHandler(this.Facturabutton_Click);
            // 
            // CategoriaAbutton
            // 
            this.CategoriaAbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.CategoriaAbutton.FlatAppearance.BorderSize = 0;
            this.CategoriaAbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.CategoriaAbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoriaAbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CategoriaAbutton.Image = global::ProyectoFinalAplicada1.Properties.Resources.explorer_folders_18871;
            this.CategoriaAbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CategoriaAbutton.Location = new System.Drawing.Point(3, 243);
            this.CategoriaAbutton.Name = "CategoriaAbutton";
            this.CategoriaAbutton.Size = new System.Drawing.Size(164, 47);
            this.CategoriaAbutton.TabIndex = 8;
            this.CategoriaAbutton.Text = "Categoría";
            this.CategoriaAbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CategoriaAbutton.UseVisualStyleBackColor = false;
            this.CategoriaAbutton.Click += new System.EventHandler(this.CategoriaAbutton_Click);
            // 
            // RegistroAsignatura
            // 
            this.RegistroAsignatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.RegistroAsignatura.FlatAppearance.BorderSize = 0;
            this.RegistroAsignatura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.RegistroAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistroAsignatura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegistroAsignatura.Image = global::ProyectoFinalAplicada1.Properties.Resources.businessregistration_signpen_negocio_inscripcio_2358;
            this.RegistroAsignatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegistroAsignatura.Location = new System.Drawing.Point(6, 61);
            this.RegistroAsignatura.Name = "RegistroAsignatura";
            this.RegistroAsignatura.Size = new System.Drawing.Size(164, 47);
            this.RegistroAsignatura.TabIndex = 7;
            this.RegistroAsignatura.Text = "Registro de Usuarios";
            this.RegistroAsignatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegistroAsignatura.UseVisualStyleBackColor = false;
            this.RegistroAsignatura.Click += new System.EventHandler(this.RegistroAsignatura_Click);
            // 
            // EntradadeProductos
            // 
            this.EntradadeProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.EntradadeProductos.FlatAppearance.BorderSize = 0;
            this.EntradadeProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.EntradadeProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntradadeProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EntradadeProductos.Image = global::ProyectoFinalAplicada1.Properties.Resources.businesssettings_thebox_theproduct_negocio_2327;
            this.EntradadeProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EntradadeProductos.Location = new System.Drawing.Point(3, 179);
            this.EntradadeProductos.Name = "EntradadeProductos";
            this.EntradadeProductos.Size = new System.Drawing.Size(173, 47);
            this.EntradadeProductos.TabIndex = 6;
            this.EntradadeProductos.Text = "Entrada de Productos";
            this.EntradadeProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EntradadeProductos.UseVisualStyleBackColor = false;
            this.EntradadeProductos.Click += new System.EventHandler(this.EntradadeProductos_Click);
            // 
            // RegistroEstudiante
            // 
            this.RegistroEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.RegistroEstudiante.FlatAppearance.BorderSize = 0;
            this.RegistroEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.RegistroEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistroEstudiante.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegistroEstudiante.Image = global::ProyectoFinalAplicada1.Properties.Resources.Cargo_1_35517;
            this.RegistroEstudiante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegistroEstudiante.Location = new System.Drawing.Point(3, 120);
            this.RegistroEstudiante.Name = "RegistroEstudiante";
            this.RegistroEstudiante.Size = new System.Drawing.Size(173, 48);
            this.RegistroEstudiante.TabIndex = 5;
            this.RegistroEstudiante.Text = "       Registro de Productos";
            this.RegistroEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegistroEstudiante.UseVisualStyleBackColor = false;
            this.RegistroEstudiante.Click += new System.EventHandler(this.RegistroEstudiante_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(67, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // Userlabel
            // 
            this.Userlabel.AutoSize = true;
            this.Userlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userlabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Userlabel.Location = new System.Drawing.Point(118, 479);
            this.Userlabel.Name = "Userlabel";
            this.Userlabel.Size = new System.Drawing.Size(41, 15);
            this.Userlabel.TabIndex = 13;
            this.Userlabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinalAplicada1.Properties.Resources.user_accounts_15362;
            this.pictureBox1.Location = new System.Drawing.Point(12, 469);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.BarraTitulo.ResumeLayout(false);
            this.PanelContenedor.ResumeLayout(false);
            this.PanelContenedor.PerformLayout();
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HideButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox restaurar;
        private System.Windows.Forms.PictureBox min;
        private System.Windows.Forms.PictureBox Max;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.PictureBox HideButton;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Button ClienteAdd;
        private System.Windows.Forms.Button Facturabutton;
        private System.Windows.Forms.Button CategoriaAbutton;
        private System.Windows.Forms.Button RegistroAsignatura;
        private System.Windows.Forms.Button EntradadeProductos;
        private System.Windows.Forms.Button RegistroEstudiante;
        public System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Button CerrarSeccionbutton;
        private System.Windows.Forms.Label Userlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}