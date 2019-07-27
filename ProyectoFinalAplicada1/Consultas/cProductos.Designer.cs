namespace ProyectoFinalAplicada1.Consultas
{
    partial class cProductos
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechacheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cUsuariosdataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.CristerioTextBox = new System.Windows.Forms.TextBox();
            this.ConsultaUserbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CerrarButton = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cUsuariosdataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.DesdedateTimePicker);
            this.groupBox4.Controls.Add(this.HastadateTimePicker);
            this.groupBox4.Controls.Add(this.FechacheckBox);
            this.groupBox4.Location = new System.Drawing.Point(88, 68);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 73);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Desde:";
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(5, 47);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.DesdedateTimePicker.TabIndex = 12;
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(108, 47);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.HastadateTimePicker.TabIndex = 14;
            // 
            // FechacheckBox
            // 
            this.FechacheckBox.AutoSize = true;
            this.FechacheckBox.Location = new System.Drawing.Point(6, 11);
            this.FechacheckBox.Name = "FechacheckBox";
            this.FechacheckBox.Size = new System.Drawing.Size(102, 17);
            this.FechacheckBox.TabIndex = 15;
            this.FechacheckBox.Text = "Filtrar por Fecha";
            this.FechacheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cUsuariosdataGridView);
            this.groupBox2.Location = new System.Drawing.Point(88, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(625, 241);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // cUsuariosdataGridView
            // 
            this.cUsuariosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cUsuariosdataGridView.Location = new System.Drawing.Point(9, 19);
            this.cUsuariosdataGridView.Name = "cUsuariosdataGridView";
            this.cUsuariosdataGridView.Size = new System.Drawing.Size(596, 196);
            this.cUsuariosdataGridView.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FiltroComboBox);
            this.groupBox1.Controls.Add(this.CristerioTextBox);
            this.groupBox1.Controls.Add(this.ConsultaUserbutton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(307, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 73);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Todo",
            "Id",
            "Nombres",
            "Usuario"});
            this.FiltroComboBox.Location = new System.Drawing.Point(9, 40);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltroComboBox.TabIndex = 21;
            // 
            // CristerioTextBox
            // 
            this.CristerioTextBox.Location = new System.Drawing.Point(152, 40);
            this.CristerioTextBox.Name = "CristerioTextBox";
            this.CristerioTextBox.Size = new System.Drawing.Size(181, 20);
            this.CristerioTextBox.TabIndex = 19;
            // 
            // ConsultaUserbutton
            // 
            this.ConsultaUserbutton.Location = new System.Drawing.Point(350, 28);
            this.ConsultaUserbutton.Name = "ConsultaUserbutton";
            this.ConsultaUserbutton.Size = new System.Drawing.Size(36, 34);
            this.ConsultaUserbutton.TabIndex = 15;
            this.ConsultaUserbutton.UseVisualStyleBackColor = true;
            this.ConsultaUserbutton.Click += new System.EventHandler(this.ConsultaUserbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Criterio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Filtro";
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.Location = new System.Drawing.Point(638, 388);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(75, 23);
            this.Imprimirbutton.TabIndex = 28;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Visible = false;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
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
            this.CerrarButton.Location = new System.Drawing.Point(746, 9);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(17, 17);
            this.CerrarButton.TabIndex = 62;
            this.CerrarButton.Text = "X";
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // cProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 459);
            this.Controls.Add(this.CerrarButton);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cProductos";
            this.Text = "cProductos";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cUsuariosdataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.CheckBox FechacheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView cUsuariosdataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.TextBox CristerioTextBox;
        private System.Windows.Forms.Button ConsultaUserbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Label CerrarButton;
    }
}