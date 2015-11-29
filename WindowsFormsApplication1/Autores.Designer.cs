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
            this.bibliotecaDataSet = new WindowsFormsApplication1.BibliotecaDataSet();
            this.autoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoresTableAdapter = new WindowsFormsApplication1.BibliotecaDataSetTableAdapters.AutoresTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.nacionalidadTextBox = new System.Windows.Forms.TextBox();
            this.obramasfamosaTextBox = new System.Windows.Forms.TextBox();
            this.generoliterarioTextBox = new System.Windows.Forms.TextBox();
            this.fechanatTextBox = new System.Windows.Forms.TextBox();
            this.fechamortTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            nombreLabel.Location = new System.Drawing.Point(7, 23);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(73, 20);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre:";
            // 
            // nacionalidadLabel
            // 
            nacionalidadLabel.AutoSize = true;
            nacionalidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            nacionalidadLabel.Location = new System.Drawing.Point(12, 75);
            nacionalidadLabel.Name = "nacionalidadLabel";
            nacionalidadLabel.Size = new System.Drawing.Size(110, 20);
            nacionalidadLabel.TabIndex = 2;
            nacionalidadLabel.Text = "Nacionalidad:";
            // 
            // obramasfamosaLabel
            // 
            obramasfamosaLabel.AutoSize = true;
            obramasfamosaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            obramasfamosaLabel.Location = new System.Drawing.Point(12, 127);
            obramasfamosaLabel.Name = "obramasfamosaLabel";
            obramasfamosaLabel.Size = new System.Drawing.Size(138, 20);
            obramasfamosaLabel.TabIndex = 4;
            obramasfamosaLabel.Text = "Obramasfamosa:";
            // 
            // generoliterarioLabel
            // 
            generoliterarioLabel.AutoSize = true;
            generoliterarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            generoliterarioLabel.Location = new System.Drawing.Point(355, 23);
            generoliterarioLabel.Name = "generoliterarioLabel";
            generoliterarioLabel.Size = new System.Drawing.Size(125, 20);
            generoliterarioLabel.TabIndex = 6;
            generoliterarioLabel.Text = "Generoliterario:";
            // 
            // fechanatLabel
            // 
            fechanatLabel.AutoSize = true;
            fechanatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            fechanatLabel.Location = new System.Drawing.Point(355, 75);
            fechanatLabel.Name = "fechanatLabel";
            fechanatLabel.Size = new System.Drawing.Size(78, 20);
            fechanatLabel.TabIndex = 8;
            fechanatLabel.Text = "fechanat:";
            // 
            // fechamortLabel
            // 
            fechamortLabel.AutoSize = true;
            fechamortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            fechamortLabel.Location = new System.Drawing.Point(355, 130);
            fechamortLabel.Name = "fechamortLabel";
            fechamortLabel.Size = new System.Drawing.Size(89, 20);
            fechamortLabel.TabIndex = 10;
            fechamortLabel.Text = "fechamort:";
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autoresBindingSource
            // 
            this.autoresBindingSource.DataMember = "Autores";
            this.autoresBindingSource.DataSource = this.bibliotecaDataSet;
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
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoresBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nombreTextBox.Location = new System.Drawing.Point(11, 46);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(227, 26);
            this.nombreTextBox.TabIndex = 2;
            // 
            // nacionalidadTextBox
            // 
            this.nacionalidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoresBindingSource, "Nacionalidad", true));
            this.nacionalidadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nacionalidadTextBox.Location = new System.Drawing.Point(11, 98);
            this.nacionalidadTextBox.Name = "nacionalidadTextBox";
            this.nacionalidadTextBox.Size = new System.Drawing.Size(227, 26);
            this.nacionalidadTextBox.TabIndex = 3;
            // 
            // obramasfamosaTextBox
            // 
            this.obramasfamosaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoresBindingSource, "Obramasfamosa", true));
            this.obramasfamosaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.obramasfamosaTextBox.Location = new System.Drawing.Point(11, 150);
            this.obramasfamosaTextBox.Name = "obramasfamosaTextBox";
            this.obramasfamosaTextBox.Size = new System.Drawing.Size(227, 26);
            this.obramasfamosaTextBox.TabIndex = 5;
            // 
            // generoliterarioTextBox
            // 
            this.generoliterarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoresBindingSource, "Generoliterario", true));
            this.generoliterarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.generoliterarioTextBox.Location = new System.Drawing.Point(359, 46);
            this.generoliterarioTextBox.Name = "generoliterarioTextBox";
            this.generoliterarioTextBox.Size = new System.Drawing.Size(243, 26);
            this.generoliterarioTextBox.TabIndex = 7;
            // 
            // fechanatTextBox
            // 
            this.fechanatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoresBindingSource, "fechanat", true));
            this.fechanatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.fechanatTextBox.Location = new System.Drawing.Point(359, 98);
            this.fechanatTextBox.Name = "fechanatTextBox";
            this.fechanatTextBox.Size = new System.Drawing.Size(243, 26);
            this.fechanatTextBox.TabIndex = 9;
            // 
            // fechamortTextBox
            // 
            this.fechamortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoresBindingSource, "fechamort", true));
            this.fechamortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.fechamortTextBox.Location = new System.Drawing.Point(359, 150);
            this.fechamortTextBox.Name = "fechamortTextBox";
            this.fechamortTextBox.Size = new System.Drawing.Size(243, 26);
            this.fechamortTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(11, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 78);
            this.button1.TabIndex = 12;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button2.Location = new System.Drawing.Point(462, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 78);
            this.button2.TabIndex = 13;
            this.button2.Text = "Atras";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.writer_male_light_256;
            this.pictureBox1.Location = new System.Drawing.Point(175, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button3.Location = new System.Drawing.Point(156, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 78);
            this.button3.TabIndex = 15;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button4.Location = new System.Drawing.Point(318, 182);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 78);
            this.button4.TabIndex = 16;
            this.button4.Text = "Modificar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // autoresDataGridView
            // 
            this.autoresDataGridView.AutoGenerateColumns = false;
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
            this.autoresDataGridView.Location = new System.Drawing.Point(11, 304);
            this.autoresDataGridView.Name = "autoresDataGridView";
            this.autoresDataGridView.Size = new System.Drawing.Size(599, 220);
            this.autoresDataGridView.TabIndex = 17;
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
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(622, 536);
            this.Controls.Add(this.autoresDataGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(fechamortLabel);
            this.Controls.Add(this.fechamortTextBox);
            this.Controls.Add(fechanatLabel);
            this.Controls.Add(this.fechanatTextBox);
            this.Controls.Add(generoliterarioLabel);
            this.Controls.Add(this.generoliterarioTextBox);
            this.Controls.Add(obramasfamosaLabel);
            this.Controls.Add(this.obramasfamosaTextBox);
            this.Controls.Add(nacionalidadLabel);
            this.Controls.Add(this.nacionalidadTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Autores";
            this.Text = "Autores";
            this.Load += new System.EventHandler(this.Autores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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