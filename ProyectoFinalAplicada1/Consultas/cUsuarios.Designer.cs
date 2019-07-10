namespace ProyectoFinalAplicada1.Consultas
{
    partial class cUsuarios
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cUsuariosdataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CristerioTextBox = new System.Windows.Forms.TextBox();
            this.ConsultaUserbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cUsuariosdataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cUsuariosdataGridView);
            this.groupBox2.Location = new System.Drawing.Point(104, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 198);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // cUsuariosdataGridView
            // 
            this.cUsuariosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cUsuariosdataGridView.Location = new System.Drawing.Point(14, 19);
            this.cUsuariosdataGridView.Name = "cUsuariosdataGridView";
            this.cUsuariosdataGridView.Size = new System.Drawing.Size(535, 173);
            this.cUsuariosdataGridView.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HastadateTimePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DesdedateTimePicker);
            this.groupBox1.Controls.Add(this.FiltroComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CristerioTextBox);
            this.groupBox1.Controls.Add(this.ConsultaUserbutton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(104, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 116);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastadateTimePicker.Location = new System.Drawing.Point(226, 75);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.HastadateTimePicker.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Hasta";
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(56, 78);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(98, 20);
            this.DesdedateTimePicker.TabIndex = 18;
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
            this.FiltroComboBox.Location = new System.Drawing.Point(14, 41);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltroComboBox.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Desde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Consulta";
            // 
            // CristerioTextBox
            // 
            this.CristerioTextBox.Location = new System.Drawing.Point(188, 42);
            this.CristerioTextBox.Name = "CristerioTextBox";
            this.CristerioTextBox.Size = new System.Drawing.Size(181, 20);
            this.CristerioTextBox.TabIndex = 19;
            // 
            // ConsultaUserbutton
            // 
            this.ConsultaUserbutton.Location = new System.Drawing.Point(467, 25);
            this.ConsultaUserbutton.Name = "ConsultaUserbutton";
            this.ConsultaUserbutton.Size = new System.Drawing.Size(61, 53);
            this.ConsultaUserbutton.TabIndex = 15;
            this.ConsultaUserbutton.UseVisualStyleBackColor = true;
            this.ConsultaUserbutton.Click += new System.EventHandler(this.ConsultaUserbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Criterio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Filtro";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // cUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 375);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "cUsuarios";
            this.Text = "Consulta Usuarios";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cUsuariosdataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView cUsuariosdataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CristerioTextBox;
        private System.Windows.Forms.Button ConsultaUserbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}