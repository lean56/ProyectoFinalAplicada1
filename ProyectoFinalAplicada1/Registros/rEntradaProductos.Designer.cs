namespace ProyectoFinalAplicada1.Registros
{
    partial class rEntradaProductos
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
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProductoComboBox = new System.Windows.Forms.ComboBox();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CerrarButton = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.Location = new System.Drawing.Point(362, 166);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.IdNumericUpDown.TabIndex = 1;
            // 
            // ProductoComboBox
            // 
            this.ProductoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductoComboBox.FormattingEnabled = true;
            this.ProductoComboBox.Location = new System.Drawing.Point(362, 206);
            this.ProductoComboBox.Name = "ProductoComboBox";
            this.ProductoComboBox.Size = new System.Drawing.Size(107, 21);
            this.ProductoComboBox.TabIndex = 2;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(362, 298);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(107, 20);
            this.FechadateTimePicker.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // CerrarButton
            // 
            this.CerrarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarButton.AutoSize = true;
            this.CerrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarButton.Location = new System.Drawing.Point(699, 62);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(17, 17);
            this.CerrarButton.TabIndex = 62;
            this.CerrarButton.Text = "X";
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(283, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 37);
            this.label5.TabIndex = 61;
            this.label5.Text = "Entrada de Productos ";
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CantidadtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadtextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadtextBox.ForeColor = System.Drawing.Color.Silver;
            this.CantidadtextBox.Location = new System.Drawing.Point(362, 247);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(107, 27);
            this.CantidadtextBox.TabIndex = 63;
            this.CantidadtextBox.Text = "Cantidad";
            this.CantidadtextBox.Enter += new System.EventHandler(this.CantidadtextBox_Enter);
            this.CantidadtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadtextBox_KeyPress);
            this.CantidadtextBox.Leave += new System.EventHandler(this.CantidadtextBox_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Nuevobutton);
            this.groupBox1.Controls.Add(this.Guardarbutton);
            this.groupBox1.Controls.Add(this.Eliminarbutton);
            this.groupBox1.Location = new System.Drawing.Point(262, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 80);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Botones";
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::ProyectoFinalAplicada1.Properties.Resources.file_new_22051;
            this.Nuevobutton.Location = new System.Drawing.Point(6, 19);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 50);
            this.Nuevobutton.TabIndex = 38;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::ProyectoFinalAplicada1.Properties.Resources.save_21411;
            this.Guardarbutton.Location = new System.Drawing.Point(108, 19);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 50);
            this.Guardarbutton.TabIndex = 39;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::ProyectoFinalAplicada1.Properties.Resources.action_exit_close_remove_13915;
            this.Eliminarbutton.Location = new System.Drawing.Point(198, 19);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 50);
            this.Eliminarbutton.TabIndex = 40;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click_1);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::ProyectoFinalAplicada1.Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            this.BuscarButton.Location = new System.Drawing.Point(430, 157);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(39, 35);
            this.BuscarButton.TabIndex = 64;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // rEntradaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.CantidadtextBox);
            this.Controls.Add(this.CerrarButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.ProductoComboBox);
            this.Controls.Add(this.IdNumericUpDown);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rEntradaProductos";
            this.Text = "Entrada de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.ComboBox ProductoComboBox;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Label CerrarButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button BuscarButton;
    }
}