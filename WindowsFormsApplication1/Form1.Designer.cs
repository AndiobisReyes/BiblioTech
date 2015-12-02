namespace WindowsFormsApplication1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usuario_login = new System.Windows.Forms.TextBox();
            this.contraseña_login = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Record = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.logo_BIVIR;
            this.pictureBox1.Location = new System.Drawing.Point(156, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // usuario_login
            // 
            this.usuario_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuario_login.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_login.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.usuario_login.Location = new System.Drawing.Point(209, 221);
            this.usuario_login.Name = "usuario_login";
            this.usuario_login.Size = new System.Drawing.Size(201, 19);
            this.usuario_login.TabIndex = 1;
            this.usuario_login.Text = "Usuario";
            this.usuario_login.Click += new System.EventHandler(this.OnEraseButtonSelected);
            // 
            // contraseña_login
            // 
            this.contraseña_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contraseña_login.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña_login.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.contraseña_login.Location = new System.Drawing.Point(209, 264);
            this.contraseña_login.Name = "contraseña_login";
            this.contraseña_login.PasswordChar = '*';
            this.contraseña_login.Size = new System.Drawing.Size(201, 19);
            this.contraseña_login.TabIndex = 2;
            this.contraseña_login.Text = "Contraseña";
            this.contraseña_login.Click += new System.EventHandler(this.Borrar);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(48, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnLoginButtonClick);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(7, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnAddUser);
            // 
            // Record
            // 
            this.Record.AutoSize = true;
            this.Record.BackColor = System.Drawing.Color.SteelBlue;
            this.Record.Location = new System.Drawing.Point(209, 297);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(109, 17);
            this.Record.TabIndex = 6;
            this.Record.Text = "Recordar Usuario";
            this.Record.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(191, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 160);
            this.panel1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 45);
            this.button3.TabIndex = 5;
            this.button3.Text = "Cerrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(476, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 386);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(-5, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 386);
            this.panel3.TabIndex = 9;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(625, 380);
            this.ControlBox = false;
            this.Controls.Add(this.Record);
            this.Controls.Add(this.contraseña_login);
            this.Controls.Add(this.usuario_login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox usuario_login;
        private System.Windows.Forms.TextBox contraseña_login;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox Record;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

