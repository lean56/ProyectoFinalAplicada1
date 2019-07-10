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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ClavemaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.UsuarioradioButton = new System.Windows.Forms.RadioButton();
            this.AdminradioButton = new System.Windows.Forms.RadioButton();
            this.NivelgroupBox = new System.Windows.Forms.GroupBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            this.NivelgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nivel Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Ingreso";
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(106, 21);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(57, 20);
            this.IdnumericUpDown.TabIndex = 6;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(106, 62);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(153, 20);
            this.NombretextBox.TabIndex = 7;
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Location = new System.Drawing.Point(106, 136);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.Size = new System.Drawing.Size(134, 20);
            this.UsuariotextBox.TabIndex = 8;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(106, 211);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(110, 20);
            this.FechadateTimePicker.TabIndex = 9;
            // 
            // ClavemaskedTextBox
            // 
            this.ClavemaskedTextBox.Location = new System.Drawing.Point(106, 174);
            this.ClavemaskedTextBox.Name = "ClavemaskedTextBox";
            this.ClavemaskedTextBox.PasswordChar = '*';
            this.ClavemaskedTextBox.Size = new System.Drawing.Size(134, 20);
            this.ClavemaskedTextBox.TabIndex = 10;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(184, 18);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 11;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(28, 255);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 12;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(124, 255);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 13;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(215, 255);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 14;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // UsuarioradioButton
            // 
            this.UsuarioradioButton.AutoSize = true;
            this.UsuarioradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioradioButton.Location = new System.Drawing.Point(4, 9);
            this.UsuarioradioButton.Name = "UsuarioradioButton";
            this.UsuarioradioButton.Size = new System.Drawing.Size(61, 17);
            this.UsuarioradioButton.TabIndex = 15;
            this.UsuarioradioButton.TabStop = true;
            this.UsuarioradioButton.Text = "Usuario";
            this.UsuarioradioButton.UseVisualStyleBackColor = true;
            // 
            // AdminradioButton
            // 
            this.AdminradioButton.AutoSize = true;
            this.AdminradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminradioButton.Location = new System.Drawing.Point(66, 9);
            this.AdminradioButton.Name = "AdminradioButton";
            this.AdminradioButton.Size = new System.Drawing.Size(88, 17);
            this.AdminradioButton.TabIndex = 16;
            this.AdminradioButton.TabStop = true;
            this.AdminradioButton.Text = "Administrador";
            this.AdminradioButton.UseVisualStyleBackColor = true;
            // 
            // NivelgroupBox
            // 
            this.NivelgroupBox.Controls.Add(this.UsuarioradioButton);
            this.NivelgroupBox.Controls.Add(this.AdminradioButton);
            this.NivelgroupBox.Location = new System.Drawing.Point(106, 92);
            this.NivelgroupBox.Name = "NivelgroupBox";
            this.NivelgroupBox.Size = new System.Drawing.Size(153, 26);
            this.NivelgroupBox.TabIndex = 17;
            this.NivelgroupBox.TabStop = false;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 306);
            this.Controls.Add(this.NivelgroupBox);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.ClavemaskedTextBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.UsuariotextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rUsuarios";
            this.Text = "Registro de Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            this.NivelgroupBox.ResumeLayout(false);
            this.NivelgroupBox.PerformLayout();
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
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.MaskedTextBox ClavemaskedTextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.RadioButton UsuarioradioButton;
        private System.Windows.Forms.RadioButton AdminradioButton;
        private System.Windows.Forms.GroupBox NivelgroupBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}