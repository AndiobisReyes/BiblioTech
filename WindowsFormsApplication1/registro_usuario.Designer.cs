namespace WindowsFormsApplication1
{
    partial class registro_usuario
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label nicknameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label correoElectronicoLabel;
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new WindowsFormsApplication1.BibliotecaDataSet();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.correoElectronicoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usuarioTableAdapter = new WindowsFormsApplication1.BibliotecaDataSetTableAdapters.UsuarioTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            nicknameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            correoElectronicoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(289, 19);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(73, 23);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.BackColor = System.Drawing.Color.SteelBlue;
            apellidoLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoLabel.Location = new System.Drawing.Point(3, 86);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(76, 23);
            apellidoLabel.TabIndex = 4;
            apellidoLabel.Text = "Apellido:";
            // 
            // nicknameLabel
            // 
            nicknameLabel.AutoSize = true;
            nicknameLabel.BackColor = System.Drawing.Color.SteelBlue;
            nicknameLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nicknameLabel.Location = new System.Drawing.Point(3, 138);
            nicknameLabel.Name = "nicknameLabel";
            nicknameLabel.Size = new System.Drawing.Size(85, 23);
            nicknameLabel.TabIndex = 5;
            nicknameLabel.Text = "Nickname:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = System.Drawing.Color.SteelBlue;
            passwordLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.Location = new System.Drawing.Point(4, 190);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(81, 23);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.BackColor = System.Drawing.Color.SteelBlue;
            telefonoLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.Location = new System.Drawing.Point(3, 138);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(79, 23);
            telefonoLabel.TabIndex = 9;
            telefonoLabel.Text = "Telefono:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.BackColor = System.Drawing.Color.SteelBlue;
            direccionLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(3, 190);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(85, 23);
            direccionLabel.TabIndex = 11;
            direccionLabel.Text = "Direccion:";
            // 
            // correoElectronicoLabel
            // 
            correoElectronicoLabel.AutoSize = true;
            correoElectronicoLabel.BackColor = System.Drawing.Color.SteelBlue;
            correoElectronicoLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            correoElectronicoLabel.Location = new System.Drawing.Point(3, 86);
            correoElectronicoLabel.Name = "correoElectronicoLabel";
            correoElectronicoLabel.Size = new System.Drawing.Size(153, 23);
            correoElectronicoLabel.TabIndex = 13;
            correoElectronicoLabel.Text = "Correo Electronico:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(263, 42);
            this.nombreTextBox.MaxLength = 36;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(130, 19);
            this.nombreTextBox.TabIndex = 1;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.apellidoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Apellido", true));
            this.apellidoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoTextBox.Location = new System.Drawing.Point(7, 109);
            this.apellidoTextBox.MaxLength = 36;
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(234, 19);
            this.apellidoTextBox.TabIndex = 2;
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nicknameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nickname", true));
            this.nicknameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicknameTextBox.Location = new System.Drawing.Point(6, 161);
            this.nicknameTextBox.MaxLength = 36;
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(234, 19);
            this.nicknameTextBox.TabIndex = 6;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Password", true));
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(6, 213);
            this.passwordTextBox.MaxLength = 36;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(234, 19);
            this.passwordTextBox.TabIndex = 7;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Telefono", true));
            this.telefonoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTextBox.Location = new System.Drawing.Point(7, 161);
            this.telefonoTextBox.MaxLength = 13;
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(234, 19);
            this.telefonoTextBox.TabIndex = 3;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Direccion", true));
            this.direccionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTextBox.Location = new System.Drawing.Point(7, 213);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(234, 19);
            this.direccionTextBox.TabIndex = 4;
            // 
            // correoElectronicoTextBox
            // 
            this.correoElectronicoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.correoElectronicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "CorreoElectronico", true));
            this.correoElectronicoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoElectronicoTextBox.Location = new System.Drawing.Point(6, 109);
            this.correoElectronicoTextBox.Name = "correoElectronicoTextBox";
            this.correoElectronicoTextBox.Size = new System.Drawing.Size(234, 19);
            this.correoElectronicoTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.button1.Location = new System.Drawing.Point(7, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.button2.Location = new System.Drawing.Point(102, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Atras";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.writer_male_light_256;
            this.pictureBox1.Location = new System.Drawing.Point(263, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutoresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EstudiantesTableAdapter = null;
            this.tableAdapterManager.LibrosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.BibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(direccionLabel);
            this.panel1.Controls.Add(this.apellidoTextBox);
            this.panel1.Controls.Add(this.direccionTextBox);
            this.panel1.Controls.Add(apellidoLabel);
            this.panel1.Controls.Add(telefonoLabel);
            this.panel1.Controls.Add(this.telefonoTextBox);
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 332);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(correoElectronicoLabel);
            this.panel2.Controls.Add(this.correoElectronicoTextBox);
            this.panel2.Controls.Add(nicknameLabel);
            this.panel2.Controls.Add(this.nicknameTextBox);
            this.panel2.Controls.Add(this.passwordTextBox);
            this.panel2.Controls.Add(passwordLabel);
            this.panel2.Location = new System.Drawing.Point(399, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 332);
            this.panel2.TabIndex = 19;
            // 
            // registro_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(658, 319);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "registro_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registro_usuario";
            this.Load += new System.EventHandler(this.registro_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private BibliotecaDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private BibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox nicknameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox correoElectronicoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}