namespace WindowsFormsApplication1
{
    partial class Guardar
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
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label editorialLabel;
            System.Windows.Forms.Label nopagLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label idiomaLabel;
            System.Windows.Forms.Label tipoLabel;
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new WindowsFormsApplication1.BibliotecaDataSet();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.editorialTextBox = new System.Windows.Forms.TextBox();
            this.nopagTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.fechaTextBox = new System.Windows.Forms.TextBox();
            this.idiomaTextBox = new System.Windows.Forms.TextBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.librosTableAdapter = new WindowsFormsApplication1.BibliotecaDataSetTableAdapters.LibrosTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.BibliotecaDataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.librosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tituloLabel = new System.Windows.Forms.Label();
            autorLabel = new System.Windows.Forms.Label();
            editorialLabel = new System.Windows.Forms.Label();
            nopagLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            idiomaLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tituloLabel.Location = new System.Drawing.Point(12, 23);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(51, 20);
            tituloLabel.TabIndex = 1;
            tituloLabel.Text = "Titulo:";
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            autorLabel.Location = new System.Drawing.Point(13, 75);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(50, 20);
            autorLabel.TabIndex = 2;
            autorLabel.Text = "autor:";
            // 
            // editorialLabel
            // 
            editorialLabel.AutoSize = true;
            editorialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            editorialLabel.Location = new System.Drawing.Point(13, 127);
            editorialLabel.Name = "editorialLabel";
            editorialLabel.Size = new System.Drawing.Size(68, 20);
            editorialLabel.TabIndex = 4;
            editorialLabel.Text = "editorial:";
            // 
            // nopagLabel
            // 
            nopagLabel.AutoSize = true;
            nopagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nopagLabel.Location = new System.Drawing.Point(13, 179);
            nopagLabel.Name = "nopagLabel";
            nopagLabel.Size = new System.Drawing.Size(58, 20);
            nopagLabel.TabIndex = 6;
            nopagLabel.Text = "nopag:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(363, 23);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(93, 20);
            descripcionLabel.TabIndex = 8;
            descripcionLabel.Text = "descripcion:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estadoLabel.Location = new System.Drawing.Point(363, 75);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(62, 20);
            estadoLabel.TabIndex = 10;
            estadoLabel.Text = "estado:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.Location = new System.Drawing.Point(365, 127);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(53, 20);
            fechaLabel.TabIndex = 12;
            fechaLabel.Text = "fecha:";
            // 
            // idiomaLabel
            // 
            idiomaLabel.AutoSize = true;
            idiomaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idiomaLabel.Location = new System.Drawing.Point(365, 179);
            idiomaLabel.Name = "idiomaLabel";
            idiomaLabel.Size = new System.Drawing.Size(61, 20);
            idiomaLabel.TabIndex = 14;
            idiomaLabel.Text = "Idioma:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoLabel.Location = new System.Drawing.Point(244, 208);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(39, 20);
            tipoLabel.TabIndex = 16;
            tipoLabel.Text = "tipo:";
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Titulo", true));
            this.tituloTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloTextBox.Location = new System.Drawing.Point(16, 46);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(171, 26);
            this.tituloTextBox.TabIndex = 2;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "Libros";
            this.librosBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autorTextBox
            // 
            this.autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "autor", true));
            this.autorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorTextBox.Location = new System.Drawing.Point(16, 98);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(171, 26);
            this.autorTextBox.TabIndex = 3;
            // 
            // editorialTextBox
            // 
            this.editorialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "editorial", true));
            this.editorialTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editorialTextBox.Location = new System.Drawing.Point(16, 150);
            this.editorialTextBox.Name = "editorialTextBox";
            this.editorialTextBox.Size = new System.Drawing.Size(171, 26);
            this.editorialTextBox.TabIndex = 5;
            // 
            // nopagTextBox
            // 
            this.nopagTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "nopag", true));
            this.nopagTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nopagTextBox.Location = new System.Drawing.Point(16, 202);
            this.nopagTextBox.Name = "nopagTextBox";
            this.nopagTextBox.Size = new System.Drawing.Size(171, 26);
            this.nopagTextBox.TabIndex = 7;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "descripcion", true));
            this.descripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTextBox.Location = new System.Drawing.Point(367, 46);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(171, 26);
            this.descripcionTextBox.TabIndex = 9;
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "estado", true));
            this.estadoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoTextBox.Location = new System.Drawing.Point(367, 98);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(171, 26);
            this.estadoTextBox.TabIndex = 11;
            // 
            // fechaTextBox
            // 
            this.fechaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "fecha", true));
            this.fechaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaTextBox.Location = new System.Drawing.Point(367, 150);
            this.fechaTextBox.Name = "fechaTextBox";
            this.fechaTextBox.Size = new System.Drawing.Size(171, 26);
            this.fechaTextBox.TabIndex = 13;
            // 
            // idiomaTextBox
            // 
            this.idiomaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Idioma", true));
            this.idiomaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idiomaTextBox.Location = new System.Drawing.Point(367, 202);
            this.idiomaTextBox.Name = "idiomaTextBox";
            this.idiomaTextBox.Size = new System.Drawing.Size(171, 26);
            this.idiomaTextBox.TabIndex = 15;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "tipo", true));
            this.tipoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoTextBox.Location = new System.Drawing.Point(183, 234);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(186, 26);
            this.tipoTextBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 77);
            this.button1.TabIndex = 18;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(375, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 77);
            this.button2.TabIndex = 19;
            this.button2.Text = "Atras";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(183, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 48);
            this.button3.TabIndex = 20;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(289, 263);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 48);
            this.button4.TabIndex = 22;
            this.button4.Text = "Mod";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AutoresTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EstudiantesTableAdapter = null;
            this.tableAdapterManager.LibrosTableAdapter = this.librosTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.BibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.books;
            this.pictureBox1.Location = new System.Drawing.Point(193, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // librosDataGridView
            // 
            this.librosDataGridView.AutoGenerateColumns = false;
            this.librosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.librosDataGridView.DataSource = this.librosBindingSource;
            this.librosDataGridView.Location = new System.Drawing.Point(16, 343);
            this.librosDataGridView.Name = "librosDataGridView";
            this.librosDataGridView.Size = new System.Drawing.Size(530, 220);
            this.librosDataGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "autor";
            this.dataGridViewTextBoxColumn3.HeaderText = "autor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "editorial";
            this.dataGridViewTextBoxColumn4.HeaderText = "editorial";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nopag";
            this.dataGridViewTextBoxColumn5.HeaderText = "nopag";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn6.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn7.HeaderText = "estado";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn8.HeaderText = "fecha";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Idioma";
            this.dataGridViewTextBoxColumn9.HeaderText = "Idioma";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "tipo";
            this.dataGridViewTextBoxColumn10.HeaderText = "tipo";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // Guardar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(558, 607);
            this.Controls.Add(this.librosDataGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Controls.Add(idiomaLabel);
            this.Controls.Add(this.idiomaTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(nopagLabel);
            this.Controls.Add(this.nopagTextBox);
            this.Controls.Add(editorialLabel);
            this.Controls.Add(this.editorialTextBox);
            this.Controls.Add(autorLabel);
            this.Controls.Add(this.autorTextBox);
            this.Controls.Add(tituloLabel);
            this.Controls.Add(this.tituloTextBox);
            this.Name = "Guardar";
            this.Text = "Guardar";
            this.Load += new System.EventHandler(this.Guardar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private BibliotecaDataSetTableAdapters.LibrosTableAdapter librosTableAdapter;
        private BibliotecaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox editorialTextBox;
        private System.Windows.Forms.TextBox nopagTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.TextBox fechaTextBox;
        private System.Windows.Forms.TextBox idiomaTextBox;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView librosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}