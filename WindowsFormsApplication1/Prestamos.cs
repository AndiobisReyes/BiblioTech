using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();
        }

        private void estudiantesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estudiantesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.Estudiantes' table. You can move, or remove it, as needed.
            this.estudiantesTableAdapter.Fill(this.bibliotecaDataSet.Estudiantes);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.estudiantesTableAdapter.InsertQuery(nombreTextBox.Text, apellidoTextBox.Text, cursoTextBox.Text, tandaTextBox.Text, telefonoTextBox.Text, direccionTextBox.Text, libro_PrestamoTextBox.Text);
            this.estudiantesTableAdapter.Fill(this.bibliotecaDataSet.Estudiantes);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.estudiantesTableAdapter.UpdateQuery(nombreTextBox.Text, apellidoTextBox.Text, cursoTextBox.Text, tandaTextBox.Text, telefonoTextBox.Text, direccionTextBox.Text, libro_PrestamoTextBox.Text, int.Parse(idTextBox.Text));
            this.estudiantesTableAdapter.Fill(this.bibliotecaDataSet.Estudiantes);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.estudiantesTableAdapter.DeleteQuery(int.Parse(idTextBox.Text));
            this.estudiantesTableAdapter.Fill(this.bibliotecaDataSet.Estudiantes);
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            Hide();
        }
    }
}
