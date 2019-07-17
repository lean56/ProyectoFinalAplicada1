namespace ProyectoFinalAplicada1
{
    partial class Login
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
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.Accederbutton = new System.Windows.Forms.Button();
            this.ClavetextBox = new System.Windows.Forms.TextBox();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.FlatAppearance.BorderSize = 0;
            this.Cancelarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelarbutton.Location = new System.Drawing.Point(115, 141);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(129, 37);
            this.Cancelarbutton.TabIndex = 18;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            // 
            // Accederbutton
            // 
            this.Accederbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Accederbutton.FlatAppearance.BorderSize = 0;
            this.Accederbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Accederbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Accederbutton.Location = new System.Drawing.Point(115, 98);
            this.Accederbutton.Name = "Accederbutton";
            this.Accederbutton.Size = new System.Drawing.Size(129, 37);
            this.Accederbutton.TabIndex = 17;
            this.Accederbutton.Text = "Acceder";
            this.Accederbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Accederbutton.UseVisualStyleBackColor = true;
            this.Accederbutton.Click += new System.EventHandler(this.Accederbutton_Click);
            // 
            // ClavetextBox
            // 
            this.ClavetextBox.Location = new System.Drawing.Point(115, 72);
            this.ClavetextBox.Name = "ClavetextBox";
            this.ClavetextBox.PasswordChar = '*';
            this.ClavetextBox.Size = new System.Drawing.Size(129, 20);
            this.ClavetextBox.TabIndex = 16;
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Location = new System.Drawing.Point(115, 36);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.Size = new System.Drawing.Size(129, 20);
            this.UsuariotextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Contraseña";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 208);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Accederbutton);
            this.Controls.Add(this.ClavetextBox);
            this.Controls.Add(this.UsuariotextBox);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Button Accederbutton;
        private System.Windows.Forms.TextBox ClavetextBox;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}