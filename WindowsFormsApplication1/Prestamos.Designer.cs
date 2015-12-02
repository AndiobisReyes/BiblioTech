namespace WindowsFormsApplication1
{
    partial class Prestamos
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
            System.Windows.Forms.Label cursoLabel;
            System.Windows.Forms.Label tandaLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label libro_PrestamoLabel;
            System.Windows.Forms.Label idLabel;
            this.bibliotecaDataSet = new WindowsFormsApplication1.BibliotecaDataSet();
            this.estudiantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudiantesTableAdapter = new WindowsFormsApplication1.BibliotecaDataSetTableAdapters.EstudiantesTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.cursoTextBox = new System.Windows.Forms.TextBox();
            this.tandaTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.libro_PrestamoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.autoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoresTableAdapter = new WindowsFormsApplication1.BibliotecaDataSetTableAdapters.AutoresTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.estudiantesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            cursoLabel = new System.Windows.Forms.Label();
            tandaLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            libro_PrestamoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            nombreLabel.Location = new System.Drawing.Point(11, 29);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(73, 20);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            apellidoLabel.Location = new System.Drawing.Point(12, 81);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(73, 20);
            apellidoLabel.TabIndex = 2;
            apellidoLabel.Text = "Apellido:";
            // 
            // cursoLabel
            // 
            cursoLabel.AutoSize = true;
            cursoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            cursoLabel.Location = new System.Drawing.Point(12, 135);
            cursoLabel.Name = "cursoLabel";
            cursoLabel.Size = new System.Drawing.Size(59, 20);
            cursoLabel.TabIndex = 4;
            cursoLabel.Text = "Curso:";
            // 
            // tandaLabel
            // 
            tandaLabel.AutoSize = true;
            tandaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            tandaLabel.Location = new System.Drawing.Point(379, 29);
            tandaLabel.Name = "tandaLabel";
            tandaLabel.Size = new System.Drawing.Size(60, 20);
            tandaLabel.TabIndex = 6;
            tandaLabel.Text = "Tanda:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            telefonoLabel.Location = new System.Drawing.Point(379, 78);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(78, 20);
            telefonoLabel.TabIndex = 8;
            telefonoLabel.Text = "Telefono:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            direccionLabel.Location = new System.Drawing.Point(379, 132);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(86, 20);
            direccionLabel.TabIndex = 10;
            direccionLabel.Text = "Direccion:";
            // 
            // libro_PrestamoLabel
            // 
            libro_PrestamoLabel.AutoSize = true;
            libro_PrestamoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            libro_PrestamoLabel.Location = new System.Drawing.Point(232, 186);
            libro_PrestamoLabel.Name = "libro_PrestamoLabel";
            libro_PrestamoLabel.Size = new System.Drawing.Size(129, 20);
            libro_PrestamoLabel.TabIndex = 12;
            libro_PrestamoLabel.Text = "Libro/Prestamo:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(226, 27);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 18;
            idLabel.Text = "Id:";
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudiantesBindingSource
            // 
            this.estudiantesBindingSource.DataMember = "Estudiantes";
            this.estudiantesBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // estudiantesTableAdapter
            // 
            this.estudiantesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutoresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EstudiantesTableAdapter = this.estudiantesTableAdapter;
            this.tableAdapterManager.LibrosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.BibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudiantesBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nombreTextBox.Location = new System.Drawing.Point(12, 52);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(202, 26);
            this.nombreTextBox.TabIndex = 2;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudiantesBindingSource, "Apellido", true));
            this.apellidoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.apellidoTextBox.Location = new System.Drawing.Point(12, 104);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(202, 26);
            this.apellidoTextBox.TabIndex = 3;
            // 
            // cursoTextBox
            // 
            this.cursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudiantesBindingSource, "Curso", true));
            this.cursoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cursoTextBox.Location = new System.Drawing.Point(10, 158);
            this.cursoTextBox.Name = "cursoTextBox";
            this.cursoTextBox.Size = new System.Drawing.Size(202, 26);
            this.cursoTextBox.TabIndex = 5;
            // 
            // tandaTextBox
            // 
            this.tandaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudiantesBindingSource, "Tanda", true));
            this.tandaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tandaTextBox.Location = new System.Drawing.Point(383, 52);
            this.tandaTextBox.Name = "tandaTextBox";
            this.tandaTextBox.Size = new System.Drawing.Size(202, 26);
            this.tandaTextBox.TabIndex = 7;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudiantesBindingSource, "Telefono", true));
            this.telefonoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.telefonoTextBox.Location = new System.Drawing.Point(383, 101);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(202, 26);
            this.telefonoTextBox.TabIndex = 9;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudiantesBindingSource, "Direccion", true));
            this.direccionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.direccionTextBox.Location = new System.Drawing.Point(383, 155);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(202, 26);
            this.direccionTextBox.TabIndex = 11;
            // 
            // libro_PrestamoTextBox
            // 
            this.libro_PrestamoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudiantesBindingSource, "Libro/Prestamo", true));
            this.libro_PrestamoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.libro_PrestamoTextBox.Location = new System.Drawing.Point(195, 209);
            this.libro_PrestamoTextBox.Name = "libro_PrestamoTextBox";
            this.libro_PrestamoTextBox.Size = new System.Drawing.Size(202, 26);
            this.libro_PrestamoTextBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(10, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button2.Location = new System.Drawing.Point(305, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 46);
            this.button2.TabIndex = 15;
            this.button2.Text = "Mod";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button3.Location = new System.Drawing.Point(195, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 46);
            this.button3.TabIndex = 16;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.formularios_1;
            this.pictureBox1.Location = new System.Drawing.Point(220, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudiantesBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(251, 24);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 19;
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
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button4.Location = new System.Drawing.Point(481, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 46);
            this.button4.TabIndex = 20;
            this.button4.Text = "Atras";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // estudiantesDataGridView
            // 
            this.estudiantesDataGridView.AutoGenerateColumns = false;
            this.estudiantesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estudiantesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.estudiantesDataGridView.DataSource = this.estudiantesBindingSource;
            this.estudiantesDataGridView.Location = new System.Drawing.Point(37, 314);
            this.estudiantesDataGridView.Name = "estudiantesDataGridView";
            this.estudiantesDataGridView.Size = new System.Drawing.Size(548, 220);
            this.estudiantesDataGridView.TabIndex = 21;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Curso";
            this.dataGridViewTextBoxColumn4.HeaderText = "Curso";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Tanda";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tanda";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn6.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn7.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Libro/Prestamo";
            this.dataGridViewTextBoxColumn8.HeaderText = "Libro/Prestamo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(605, 560);
            this.Controls.Add(this.estudiantesDataGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(libro_PrestamoLabel);
            this.Controls.Add(this.libro_PrestamoTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(tandaLabel);
            this.Controls.Add(this.tandaTextBox);
            this.Controls.Add(cursoLabel);
            this.Controls.Add(this.cursoTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Name = "Prestamos";
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource estudiantesBindingSource;
        private BibliotecaDataSetTableAdapters.EstudiantesTableAdapter estudiantesTableAdapter;
        private BibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox cursoTextBox;
        private System.Windows.Forms.TextBox tandaTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox libro_PrestamoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.BindingSource autoresBindingSource;
        private BibliotecaDataSetTableAdapters.AutoresTableAdapter autoresTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView estudiantesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}