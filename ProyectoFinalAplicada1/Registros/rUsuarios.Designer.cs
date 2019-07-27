namespace ProyectoFinalAplicada1.Registros
{
    partial class rUsuarios
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
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NivelUsercomboBox = new System.Windows.Forms.ComboBox();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.ClavemaskedTextBox = new System.Windows.Forms.TextBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Clave2maskedTextBox = new System.Windows.Forms.TextBox();
            this.CerrarButton = new System.Windows.Forms.Label();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(295, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 36);
            this.label5.TabIndex = 25;
            this.label5.Text = "Registro de Usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Confirmar Contraseña";
            // 
            // NivelUsercomboBox
            // 
            this.NivelUsercomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NivelUsercomboBox.FormattingEnabled = true;
            this.NivelUsercomboBox.Items.AddRange(new object[] {
            "Usuario",
            "Administrador"});
            this.NivelUsercomboBox.Location = new System.Drawing.Point(353, 270);
            this.NivelUsercomboBox.Name = "NivelUsercomboBox";
            this.NivelUsercomboBox.Size = new System.Drawing.Size(171, 21);
            this.NivelUsercomboBox.TabIndex = 41;
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
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(353, 428);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(171, 20);
            this.FechadateTimePicker.TabIndex = 35;
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(353, 188);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(57, 20);
            this.IdnumericUpDown.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Fecha Ingreso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nivel Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombres";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "ID";
            // 
            // NombretextBox
            // 
            this.NombretextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NombretextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombretextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombretextBox.ForeColor = System.Drawing.Color.Silver;
            this.NombretextBox.Location = new System.Drawing.Point(353, 230);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(171, 26);
            this.NombretextBox.TabIndex = 44;
            this.NombretextBox.Text = "Nombres";
            this.NombretextBox.Enter += new System.EventHandler(this.NombretextBox_Enter);
            this.NombretextBox.Leave += new System.EventHandler(this.NombretextBox_Leave);
            // 
            // ClavemaskedTextBox
            // 
            this.ClavemaskedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ClavemaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClavemaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClavemaskedTextBox.ForeColor = System.Drawing.Color.Silver;
            this.ClavemaskedTextBox.Location = new System.Drawing.Point(353, 349);
            this.ClavemaskedTextBox.Name = "ClavemaskedTextBox";
            this.ClavemaskedTextBox.Size = new System.Drawing.Size(171, 26);
            this.ClavemaskedTextBox.TabIndex = 46;
            this.ClavemaskedTextBox.Text = "Contraseña";
            this.ClavemaskedTextBox.Enter += new System.EventHandler(this.ClavemaskedTextBox_Enter);
            this.ClavemaskedTextBox.Leave += new System.EventHandler(this.ClavemaskedTextBox_Leave);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // Clave2maskedTextBox
            // 
            this.Clave2maskedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.Clave2maskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Clave2maskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clave2maskedTextBox.ForeColor = System.Drawing.Color.Silver;
            this.Clave2maskedTextBox.Location = new System.Drawing.Point(353, 391);
            this.Clave2maskedTextBox.Name = "Clave2maskedTextBox";
            this.Clave2maskedTextBox.Size = new System.Drawing.Size(171, 26);
            this.Clave2maskedTextBox.TabIndex = 47;
            this.Clave2maskedTextBox.Text = "Confirmar";
            this.Clave2maskedTextBox.Enter += new System.EventHandler(this.Clave2maskedTextBox_Enter);
            this.Clave2maskedTextBox.Leave += new System.EventHandler(this.Clave2maskedTextBox_Leave);
            // 
            // CerrarButton
            // 
            this.CerrarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarButton.AutoSize = true;
            this.CerrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarButton.Location = new System.Drawing.Point(785, 9);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(17, 17);
            this.CerrarButton.TabIndex = 60;
            this.CerrarButton.Text = "X";
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::ProyectoFinalAplicada1.Properties.Resources.action_exit_close_remove_13915;
            this.Eliminarbutton.Location = new System.Drawing.Point(198, 19);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 50);
            this.Eliminarbutton.TabIndex = 40;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
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
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::ProyectoFinalAplicada1.Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            this.Buscarbutton.Location = new System.Drawing.Point(424, 177);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(39, 35);
            this.Buscarbutton.TabIndex = 37;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Nuevobutton);
            this.groupBox1.Controls.Add(this.Guardarbutton);
            this.groupBox1.Controls.Add(this.Eliminarbutton);
            this.groupBox1.Location = new System.Drawing.Point(245, 454);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 80);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Botones";
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.BackColor = System.Drawing.SystemColors.Window;
            this.UsuariotextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsuariotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuariotextBox.ForeColor = System.Drawing.Color.Silver;
            this.UsuariotextBox.Location = new System.Drawing.Point(353, 307);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.Size = new System.Drawing.Size(171, 26);
            this.UsuariotextBox.TabIndex = 45;
            this.UsuariotextBox.Text = "Usuario";
            this.UsuariotextBox.Enter += new System.EventHandler(this.UsuariotextBox_Enter);
            this.UsuariotextBox.Leave += new System.EventHandler(this.UsuariotextBox_Leave);
            // 
            // rUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CerrarButton);
            this.Controls.Add(this.Clave2maskedTextBox);
            this.Controls.Add(this.ClavemaskedTextBox);
            this.Controls.Add(this.UsuariotextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NivelUsercomboBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rUsuarios";
            this.Text = "rUsuarios1";
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox NivelUsercomboBox;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox ClavemaskedTextBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.TextBox Clave2maskedTextBox;
        private System.Windows.Forms.Label CerrarButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox UsuariotextBox;
    }
}