namespace ProyectoFinalAplicada1.Registros
{
    partial class rClientes
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
            this.label8 = new System.Windows.Forms.Label();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CedulamaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TelefonomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CelularmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CerrarButton = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cédula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Celular";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha";
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(336, 128);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(70, 20);
            this.IdnumericUpDown.TabIndex = 8;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(336, 415);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(123, 20);
            this.FechadateTimePicker.TabIndex = 20;
            // 
            // CedulamaskedTextBox
            // 
            this.CedulamaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CedulamaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CedulamaskedTextBox.Location = new System.Drawing.Point(336, 301);
            this.CedulamaskedTextBox.Mask = "000-0000000-0";
            this.CedulamaskedTextBox.Name = "CedulamaskedTextBox";
            this.CedulamaskedTextBox.Size = new System.Drawing.Size(123, 26);
            this.CedulamaskedTextBox.TabIndex = 21;
            // 
            // TelefonomaskedTextBox
            // 
            this.TelefonomaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TelefonomaskedTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TelefonomaskedTextBox.Location = new System.Drawing.Point(336, 336);
            this.TelefonomaskedTextBox.Mask = "000-000-0000";
            this.TelefonomaskedTextBox.Name = "TelefonomaskedTextBox";
            this.TelefonomaskedTextBox.Size = new System.Drawing.Size(123, 27);
            this.TelefonomaskedTextBox.TabIndex = 22;
            // 
            // CelularmaskedTextBox
            // 
            this.CelularmaskedTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.CelularmaskedTextBox.Location = new System.Drawing.Point(336, 377);
            this.CelularmaskedTextBox.Mask = "000-000-0000";
            this.CelularmaskedTextBox.Name = "CelularmaskedTextBox";
            this.CelularmaskedTextBox.Size = new System.Drawing.Size(123, 27);
            this.CelularmaskedTextBox.TabIndex = 23;
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
            this.CerrarButton.Location = new System.Drawing.Point(704, 42);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(17, 17);
            this.CerrarButton.TabIndex = 62;
            this.CerrarButton.Text = "X";
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(288, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 37);
            this.label9.TabIndex = 61;
            this.label9.Text = "Registro de Cliente";
            // 
            // NombretextBox
            // 
            this.NombretextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NombretextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombretextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombretextBox.ForeColor = System.Drawing.Color.Silver;
            this.NombretextBox.Location = new System.Drawing.Point(336, 165);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(171, 27);
            this.NombretextBox.TabIndex = 63;
            this.NombretextBox.Text = "Nombres";
            this.NombretextBox.Enter += new System.EventHandler(this.NombretextBox_Enter);
            this.NombretextBox.Leave += new System.EventHandler(this.NombretextBox_Leave);
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DirecciontextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DirecciontextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirecciontextBox.ForeColor = System.Drawing.Color.Silver;
            this.DirecciontextBox.Location = new System.Drawing.Point(336, 206);
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(171, 27);
            this.DirecciontextBox.TabIndex = 64;
            this.DirecciontextBox.Text = "Dirección";
            this.DirecciontextBox.Enter += new System.EventHandler(this.DirecciontextBox_Enter);
            this.DirecciontextBox.Leave += new System.EventHandler(this.DirecciontextBox_Leave);
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.BackColor = System.Drawing.SystemColors.Window;
            this.EmailtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailtextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailtextBox.ForeColor = System.Drawing.Color.Silver;
            this.EmailtextBox.Location = new System.Drawing.Point(336, 255);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(171, 27);
            this.EmailtextBox.TabIndex = 65;
            this.EmailtextBox.Text = "Email";
            this.EmailtextBox.Enter += new System.EventHandler(this.EmailtextBox_Enter);
            this.EmailtextBox.Leave += new System.EventHandler(this.EmailtextBox_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Nuevobutton);
            this.groupBox1.Controls.Add(this.Guardarbutton);
            this.groupBox1.Controls.Add(this.Eliminarbutton);
            this.groupBox1.Location = new System.Drawing.Point(278, 462);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 80);
            this.groupBox1.TabIndex = 67;
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
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click_1);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::ProyectoFinalAplicada1.Properties.Resources.save_21411;
            this.Guardarbutton.Location = new System.Drawing.Point(108, 19);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 50);
            this.Guardarbutton.TabIndex = 39;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click_1);
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
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::ProyectoFinalAplicada1.Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            this.Buscarbutton.Location = new System.Drawing.Point(420, 119);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(39, 35);
            this.Buscarbutton.TabIndex = 66;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click_1);
            // 
            // rClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.DirecciontextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.CerrarButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CelularmaskedTextBox);
            this.Controls.Add(this.TelefonomaskedTextBox);
            this.Controls.Add(this.CedulamaskedTextBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rClientes";
            this.Text = "Registro de Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.MaskedTextBox CedulamaskedTextBox;
        private System.Windows.Forms.MaskedTextBox TelefonomaskedTextBox;
        private System.Windows.Forms.MaskedTextBox CelularmaskedTextBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Label CerrarButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Buscarbutton;
    }
}