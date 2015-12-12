namespace WindowsFormsApplication1
{
    partial class Autores
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
            System.Windows.Forms.Label nacionalidadLabel;
            System.Windows.Forms.Label obramasfamosaLabel;
            System.Windows.Forms.Label generoliterarioLabel;
            System.Windows.Forms.Label fechanatLabel;
            System.Windows.Forms.Label fechamortLabel;
            System.Windows.Forms.Label idLabel;
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.autoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new WindowsFormsApplication1.BibliotecaDataSet();
            this.nacionalidadTextBox = new System.Windows.Forms.TextBox();
            this.obramasfamosaTextBox = new System.Windows.Forms.TextBox();
            this.generoliterarioTextBox = new System.Windows.Forms.TextBox();
            this.fechanatTextBox = new System.Windows.Forms.TextBox();
            this.fechamortTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.autoresTableAdapter = new WindowsFormsApplication1.BibliotecaDataSetTableAdapters.AutoresTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.autoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombreLabel = new System.Windows.Forms.Label();
            nacionalidadLabel = new System.Windows.Forms.Label();
            obramasfamosaLabel = new System.Windows.Forms.Label();
            generoliterarioLabel = new System.Windows.Forms.Label();
            fechanatLabel = new System.Windows.Forms.Label();
            fechamortLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            nombreLabel.Location = new System.Drawing.Point(16, 62);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(73, 20);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre:";
            // 
            // nacionalidadLabel
            // 
            nacionalidadLabel.AutoSize = true;
            nacionalidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            nacionalidadLabel.Location = new System.Drawing.Point(21, 114);
            nacionalidadLabel.Name = "nacionalidadLabel";
            nacionalidadLabel.Size = new System.Drawing.Size(110, 20);
            nacionalidadLabel.TabIndex = 2;
            nacionalidadLabel.Text = "Nacionalidad:";
            // 
            // obramasfamosaLabel
            // 
            obramasfamosaLabel.AutoSize = true;
            obramasfamosaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            obramasfamosaLabel.Location = new System.Drawing.Point(21, 166);
            obramasfamosaLabel.Name = "obramasfamosaLabel";
            obramasfamosaLabel.Size = new System.Drawing.Size(138, 20);
            obramasfamosaLabel.TabIndex = 4;
            obramasfamosaLabel.Text = "Obramasfamosa:";
            // 
            // generoliterarioLabel
            // 
            generoliterarioLabel.AutoSize = true;
            generoliterarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            generoliterarioLabel.Location = new System.Drawing.Point(16, 62);
            generoliterarioLabel.Name = "generoliterarioLabel";
            generoliterarioLabel.Size = new System.Drawing.Size(65, 20);
            generoliterarioLabel.TabIndex = 6;
            generoliterarioLabel.Text = "Materia";
            // 
            // fechanatLabel
            // 
            fechanatLabel.AutoSize = true;
            fechanatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            fechanatLabel.Location = new System.Drawing.Point(16, 114);
            fechanatLabel.Name = "fechanatLabel";
            fechanatLabel.Size = new System.Drawing.Size(78, 20);
            fechanatLabel.TabIndex = 8;
            fechanatLabel.Text = "fechanat:";
            // 
            // fechamortLabel
            // 
            fechamortLabel.AutoSize = true;
            fechamortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            fechamortLabel.Location = new System.Drawing.Point(16, 169);
            fechamortLabel.Name = "fechamortLabel";
            fechamortLabel.Size = new System.Drawing.Size(89, 20);
            fechamortLabel.TabIndex = 10;
            fechamortLabel.Text = "fechamort:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            idLabel.Location = new System.Drawing.Point(40, 192);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 20);
            idLabel.TabIndex = 14;
            idLabel.Text = "Id:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoresBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nombreTextBox.Location = new System.Drawing.Point(20, 85);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(168, 26);
            this.nombreTextBox.TabIndex = 2;
            // 
            // autoresBindingSource
            // 
            this.autoresBindingSource.DataMember = "Autores";
            this.autoresBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nacionalidadTextBox
            // 
            this.nacionalidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoresBindingSource, "Nacionalidad", true));
            this.nacionalidadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nacionalidadTextBox.Location = new System.Drawing.Point(20, 137);
            this.nacionalidadTextBox.Name = "nacionalidadTextBox";
            this.nacionalidadTextBox.Size = new System.Drawing.Size(168, 26);
            this.nacionalidadTextBox.TabIndex = 3;
            // 
            // obramasfamosaTextBox
            // 
            this.obramasfamosaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoresBindingSource, "Obramasfamosa", true));
            this.obramasfamosaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.obramasfamosaTextBox.Location = new System.Drawing.Point(20, 189);
            this.obramasfamosaTextBox.Name = "obramasfamosaTextBox";
            this.obramasfamosaTextBox.Size = new System.Drawing.Size(168, 26);
            this.obramasfamosaTextBox.TabIndex = 5;
            // 
            // generoliterarioTextBox
            // 
            this.generoliterarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoresBindingSource, "Generoliterario", true));
            this.generoliterarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.generoliterarioTextBox.Location = new System.Drawing.Point(20, 85);
            this.generoliterarioTextBox.Name = "generoliterarioTextBox";
            this.generoliterarioTextBox.Size = new System.Drawing.Size(168, 26);
            this.generoliterarioTextBox.TabIndex = 7;
            // 
            // fechanatTextBox
            // 
            this.fechanatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoresBindingSource, "fechanat", true));
            this.fechanatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.fechanatTextBox.Location = new System.Drawing.Point(20, 137);
            this.fechanatTextBox.Name = "fechanatTextBox";
            this.fechanatTextBox.Size = new System.Drawing.Size(168, 26);
            this.fechanatTextBox.TabIndex = 9;
            // 
            // fechamortTextBox
            // 
            this.fechamortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoresBindingSource, "fechamort", true));
            this.fechamortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.fechamortTextBox.Location = new System.Drawing.Point(20, 189);
            this.fechamortTextBox.Name = "fechamortTextBox";
            this.fechamortTextBox.Size = new System.Drawing.Size(168, 26);
            this.fechamortTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.floppy_128;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(18, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.wrong_01_512;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button2.Location = new System.Drawing.Point(569, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Search;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button3.Location = new System.Drawing.Point(249, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 75);
            this.button3.TabIndex = 15;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._012_restart_512;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button4.Location = new System.Drawing.Point(342, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 75);
            this.button4.TabIndex = 16;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.writer_male_light_256;
            this.pictureBox1.Location = new System.Drawing.Point(44, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // autoresTableAdapter
            // 
            this.autoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutoresTableAdapter = this.autoresTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EstudiantesTableAdapter = null;
            this.tableAdapterManager.LibrosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.BibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 56);
            this.panel1.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atrasToolStripMenuItem
            // 
            this.atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            this.atrasToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.atrasToolStripMenuItem.Text = "Atras";
            this.atrasToolStripMenuItem.Click += new System.EventHandler(this.atrasToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(obramasfamosaLabel);
            this.panel2.Controls.Add(this.nombreTextBox);
            this.panel2.Controls.Add(nombreLabel);
            this.panel2.Controls.Add(this.nacionalidadTextBox);
            this.panel2.Controls.Add(nacionalidadLabel);
            this.panel2.Controls.Add(this.obramasfamosaTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 282);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(idLabel);
            this.panel3.Controls.Add(this.idTextBox);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(228, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 282);
            this.panel3.TabIndex = 19;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoresBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.idTextBox.Location = new System.Drawing.Point(35, 218);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(168, 26);
            this.idTextBox.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(generoliterarioLabel);
            this.panel4.Controls.Add(this.generoliterarioTextBox);
            this.panel4.Controls.Add(this.fechanatTextBox);
            this.panel4.Controls.Add(fechanatLabel);
            this.panel4.Controls.Add(this.fechamortTextBox);
            this.panel4.Controls.Add(fechamortLabel);
            this.panel4.Location = new System.Drawing.Point(470, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 282);
            this.panel4.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Location = new System.Drawing.Point(14, 350);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(666, 100);
            this.panel5.TabIndex = 21;
            // 
            // autoresDataGridView
            // 
            this.autoresDataGridView.AutoGenerateColumns = false;
            this.autoresDataGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.autoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.autoresDataGridView.DataSource = this.autoresBindingSource;
            this.autoresDataGridView.Location = new System.Drawing.Point(14, 456);
            this.autoresDataGridView.Name = "autoresDataGridView";
            this.autoresDataGridView.Size = new System.Drawing.Size(666, 220);
            this.autoresDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nacionalidad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nacionalidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Obramasfamosa";
            this.dataGridViewTextBoxColumn4.HeaderText = "Obramasfamosa";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Generoliterario";
            this.dataGridViewTextBoxColumn5.HeaderText = "Generoliterario";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fechanat";
            this.dataGridViewTextBoxColumn6.HeaderText = "fechanat";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fechamort";
            this.dataGridViewTextBoxColumn7.HeaderText = "fechamort";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Autores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(693, 679);
            this.Controls.Add(this.autoresDataGridView);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Autores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autores";
            this.Load += new System.EventHandler(this.Autores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.autoresDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource autoresBindingSource;
        private BibliotecaDataSetTableAdapters.AutoresTableAdapter autoresTableAdapter;
        private BibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox nacionalidadTextBox;
        private System.Windows.Forms.TextBox obramasfamosaTextBox;
        private System.Windows.Forms.TextBox generoliterarioTextBox;
        private System.Windows.Forms.TextBox fechanatTextBox;
        private System.Windows.Forms.TextBox fechamortTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atrasToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView autoresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}