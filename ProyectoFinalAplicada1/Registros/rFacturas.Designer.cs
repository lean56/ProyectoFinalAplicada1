namespace ProyectoFinalAplicada1.Registros
{
    partial class rFacturas
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
            this.label1 = new System.Windows.Forms.Label();
            this.IdFacturanumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BuscarFacturabutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdClientenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.BuscarClientebutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.Addbutton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ImportetextBox = new System.Windows.Forms.TextBox();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BuscarProductbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.IdProductnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.EliminarDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IdFacturanumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdClientenumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdProductnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // IdFacturanumericUpDown
            // 
            this.IdFacturanumericUpDown.Location = new System.Drawing.Point(63, 21);
            this.IdFacturanumericUpDown.Name = "IdFacturanumericUpDown";
            this.IdFacturanumericUpDown.Size = new System.Drawing.Size(80, 20);
            this.IdFacturanumericUpDown.TabIndex = 1;
            // 
            // BuscarFacturabutton
            // 
            this.BuscarFacturabutton.Location = new System.Drawing.Point(167, 18);
            this.BuscarFacturabutton.Name = "BuscarFacturabutton";
            this.BuscarFacturabutton.Size = new System.Drawing.Size(59, 23);
            this.BuscarFacturabutton.TabIndex = 2;
            this.BuscarFacturabutton.Text = "Buscar";
            this.BuscarFacturabutton.UseVisualStyleBackColor = true;
            this.BuscarFacturabutton.Click += new System.EventHandler(this.BuscarFacturabutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // IdClientenumericUpDown
            // 
            this.IdClientenumericUpDown.Location = new System.Drawing.Point(63, 60);
            this.IdClientenumericUpDown.Name = "IdClientenumericUpDown";
            this.IdClientenumericUpDown.Size = new System.Drawing.Size(80, 20);
            this.IdClientenumericUpDown.TabIndex = 5;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(64, 99);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.ReadOnly = true;
            this.NombretextBox.Size = new System.Drawing.Size(162, 20);
            this.NombretextBox.TabIndex = 6;
            // 
            // BuscarClientebutton
            // 
            this.BuscarClientebutton.Location = new System.Drawing.Point(167, 57);
            this.BuscarClientebutton.Name = "BuscarClientebutton";
            this.BuscarClientebutton.Size = new System.Drawing.Size(59, 23);
            this.BuscarClientebutton.TabIndex = 7;
            this.BuscarClientebutton.Text = "Buscar";
            this.BuscarClientebutton.UseVisualStyleBackColor = true;
            this.BuscarClientebutton.Click += new System.EventHandler(this.BuscarClientebutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CantidadtextBox);
            this.groupBox1.Controls.Add(this.DetalledataGridView);
            this.groupBox1.Controls.Add(this.Addbutton);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ImportetextBox);
            this.groupBox1.Controls.Add(this.PreciotextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DescripciontextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BuscarProductbutton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.IdProductnumericUpDown);
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 240);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(215, 24);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(58, 20);
            this.CantidadtextBox.TabIndex = 21;
            this.CantidadtextBox.TextChanged += new System.EventHandler(this.CantidadtextBox_TextChanged);
            this.CantidadtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadtextBox_KeyPress);
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(7, 62);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.Size = new System.Drawing.Size(476, 167);
            this.DetalledataGridView.TabIndex = 18;
            // 
            // Addbutton
            // 
            this.Addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.Location = new System.Drawing.Point(454, 24);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(29, 23);
            this.Addbutton.TabIndex = 17;
            this.Addbutton.Text = "+";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Importe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Precio";
            // 
            // ImportetextBox
            // 
            this.ImportetextBox.Location = new System.Drawing.Point(346, 24);
            this.ImportetextBox.Name = "ImportetextBox";
            this.ImportetextBox.ReadOnly = true;
            this.ImportetextBox.Size = new System.Drawing.Size(100, 20);
            this.ImportetextBox.TabIndex = 14;
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(279, 24);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.ReadOnly = true;
            this.PreciotextBox.Size = new System.Drawing.Size(61, 20);
            this.PreciotextBox.TabIndex = 13;
            this.PreciotextBox.TextChanged += new System.EventHandler(this.PreciotextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cantidad";
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(107, 23);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.ReadOnly = true;
            this.DescripciontextBox.Size = new System.Drawing.Size(100, 20);
            this.DescripciontextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descripción";
            // 
            // BuscarProductbutton
            // 
            this.BuscarProductbutton.Location = new System.Drawing.Point(71, 21);
            this.BuscarProductbutton.Name = "BuscarProductbutton";
            this.BuscarProductbutton.Size = new System.Drawing.Size(29, 23);
            this.BuscarProductbutton.TabIndex = 8;
            this.BuscarProductbutton.Text = "Buscar";
            this.BuscarProductbutton.UseVisualStyleBackColor = true;
            this.BuscarProductbutton.Click += new System.EventHandler(this.BuscarProductbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Producto";
            // 
            // IdProductnumericUpDown
            // 
            this.IdProductnumericUpDown.Location = new System.Drawing.Point(7, 22);
            this.IdProductnumericUpDown.Name = "IdProductnumericUpDown";
            this.IdProductnumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.IdProductnumericUpDown.TabIndex = 0;
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(437, 371);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(75, 20);
            this.TotaltextBox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Total:";
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(176, 409);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(59, 23);
            this.Nuevobutton.TabIndex = 17;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(256, 409);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(59, 23);
            this.Guardarbutton.TabIndex = 18;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(338, 409);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(59, 23);
            this.Eliminarbutton.TabIndex = 19;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(417, 21);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.FechadateTimePicker.TabIndex = 20;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(256, 22);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.ReadOnly = true;
            this.UsuarioTextBox.Size = new System.Drawing.Size(146, 20);
            this.UsuarioTextBox.TabIndex = 97;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(253, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 96;
            this.label10.Text = "Usuario";
            // 
            // EliminarDetalle
            // 
            this.EliminarDetalle.Location = new System.Drawing.Point(16, 374);
            this.EliminarDetalle.Name = "EliminarDetalle";
            this.EliminarDetalle.Size = new System.Drawing.Size(90, 27);
            this.EliminarDetalle.TabIndex = 98;
            this.EliminarDetalle.Text = "Eliminar Detalle";
            this.EliminarDetalle.UseVisualStyleBackColor = true;
            this.EliminarDetalle.Click += new System.EventHandler(this.EliminarDetalle_Click);
            // 
            // rFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 468);
            this.Controls.Add(this.EliminarDetalle);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BuscarClientebutton);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.IdClientenumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscarFacturabutton);
            this.Controls.Add(this.IdFacturanumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "rFacturas";
            this.Text = "Facturación";
            ((System.ComponentModel.ISupportInitialize)(this.IdFacturanumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdClientenumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdProductnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IdFacturanumericUpDown;
        private System.Windows.Forms.Button BuscarFacturabutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown IdClientenumericUpDown;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Button BuscarClientebutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ImportetextBox;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BuscarProductbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown IdProductnumericUpDown;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button EliminarDetalle;
    }
}