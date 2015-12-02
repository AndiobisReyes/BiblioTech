namespace WindowsFormsApplication1
{
    partial class Menu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.bibliotecaDataSet = new WindowsFormsApplication1.BibliotecaDataSet();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new WindowsFormsApplication1.BibliotecaDataSetTableAdapters.UsuarioTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSeccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button2.Location = new System.Drawing.Point(414, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "Prestar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button4.Location = new System.Drawing.Point(414, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 64);
            this.button4.TabIndex = 3;
            this.button4.Text = "Recibir Mens";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button5.Location = new System.Drawing.Point(218, 27);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 64);
            this.button5.TabIndex = 7;
            this.button5.Text = "Autores";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button6.Location = new System.Drawing.Point(12, 122);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(169, 64);
            this.button6.TabIndex = 8;
            this.button6.Text = "Enviar coments";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.bibliotecaDataSet;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(595, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSeccionToolStripMenuItem,
            this.modContraseñaToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.usuarioToolStripMenuItem.Text = "Perfil";
            // 
            // cerrarSeccionToolStripMenuItem
            // 
            this.cerrarSeccionToolStripMenuItem.Name = "cerrarSeccionToolStripMenuItem";
            this.cerrarSeccionToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.cerrarSeccionToolStripMenuItem.Text = "Cerrar Seccion";
            this.cerrarSeccionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSeccionToolStripMenuItem_Click);
            // 
            // modContraseñaToolStripMenuItem
            // 
            this.modContraseñaToolStripMenuItem.Name = "modContraseñaToolStripMenuItem";
            this.modContraseñaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.modContraseñaToolStripMenuItem.Text = "Mod Contraseña";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(595, 201);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private BibliotecaDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private BibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSeccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modContraseñaToolStripMenuItem;
    }
}