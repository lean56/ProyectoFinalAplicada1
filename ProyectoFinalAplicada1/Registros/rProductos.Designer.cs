namespace ProyectoFinalAplicada1.Registros
{
    partial class rProductos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.InventariotextBox = new System.Windows.Forms.TextBox();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GananciatextBox = new System.Windows.Forms.TextBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.CategoriacomboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CategoriaButton = new System.Windows.Forms.Label();
            this.CostotextBox = new System.Windows.Forms.TextBox();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "% Ganancia ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Inventario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha Creación";
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(81, 20);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(74, 20);
            this.IdnumericUpDown.TabIndex = 7;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(161, 17);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(62, 23);
            this.Buscarbutton.TabIndex = 8;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(81, 57);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(134, 20);
            this.DescripciontextBox.TabIndex = 9;
            // 
            // InventariotextBox
            // 
            this.InventariotextBox.Location = new System.Drawing.Point(182, 187);
            this.InventariotextBox.Name = "InventariotextBox";
            this.InventariotextBox.ReadOnly = true;
            this.InventariotextBox.Size = new System.Drawing.Size(55, 20);
            this.InventariotextBox.TabIndex = 12;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(95, 227);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.FechadateTimePicker.TabIndex = 13;
            // 
            // GananciatextBox
            // 
            this.GananciatextBox.Location = new System.Drawing.Point(182, 149);
            this.GananciatextBox.Name = "GananciatextBox";
            this.GananciatextBox.ReadOnly = true;
            this.GananciatextBox.Size = new System.Drawing.Size(55, 20);
            this.GananciatextBox.TabIndex = 14;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(8, 286);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 15;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(93, 286);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 16;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(190, 286);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 17;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // CategoriacomboBox
            // 
            this.CategoriacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriacomboBox.FormattingEnabled = true;
            this.CategoriacomboBox.Location = new System.Drawing.Point(81, 102);
            this.CategoriacomboBox.Name = "CategoriacomboBox";
            this.CategoriacomboBox.Size = new System.Drawing.Size(134, 21);
            this.CategoriacomboBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Categoria";
            // 
            // CategoriaButton
            // 
            this.CategoriaButton.AutoSize = true;
            this.CategoriaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaButton.Location = new System.Drawing.Point(221, 102);
            this.CategoriaButton.Name = "CategoriaButton";
            this.CategoriaButton.Size = new System.Drawing.Size(16, 17);
            this.CategoriaButton.TabIndex = 20;
            this.CategoriaButton.Text = "+";
            this.CategoriaButton.Click += new System.EventHandler(this.CategoriaButton_Click);
            // 
            // CostotextBox
            // 
            this.CostotextBox.Location = new System.Drawing.Point(52, 149);
            this.CostotextBox.Name = "CostotextBox";
            this.CostotextBox.Size = new System.Drawing.Size(56, 20);
            this.CostotextBox.TabIndex = 21;
            this.CostotextBox.TextChanged += new System.EventHandler(this.CostotextBox_TextChanged);
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(52, 184);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(56, 20);
            this.PreciotextBox.TabIndex = 22;
            this.PreciotextBox.TextChanged += new System.EventHandler(this.PreciotextBox_TextChanged);
            // 
            // rProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 326);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.CostotextBox);
            this.Controls.Add(this.CategoriaButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CategoriacomboBox);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.GananciatextBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.InventariotextBox);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rProductos";
            this.Text = "Registro de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.TextBox InventariotextBox;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.TextBox GananciatextBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Label CategoriaButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CategoriacomboBox;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.TextBox CostotextBox;
    }
}