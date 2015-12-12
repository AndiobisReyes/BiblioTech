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
    public partial class Guardar : Form
    {
        public Guardar()
        {
            InitializeComponent();
        }

        private void librosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.librosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void Guardar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.Libros' table. You can move, or remove it, as needed.
            this.librosTableAdapter.Fill(this.bibliotecaDataSet.Libros);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.librosTableAdapter.DeleteQuery(int.Parse(idTextBox.Text));
            this.librosTableAdapter.Fill(this.bibliotecaDataSet.Libros);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tituloTextBox.Text != null && autorTextBox.Text != null && editorialTextBox.Text != null && nopagTextBox.Text != null && descripcionTextBox.Text != null && estadoTextBox.Text != null && fechaTextBox.Text != null && idiomaTextBox.Text != null && tipoTextBox.Text != null) {
                this.librosTableAdapter.InsertQuery(tituloTextBox.Text, autorTextBox.Text, editorialTextBox.Text,int.Parse(nopagTextBox.Text) , descripcionTextBox.Text, estadoTextBox.Text, fechaTextBox.Text, idiomaTextBox.Text, tipoTextBox.Text);
                this.librosTableAdapter.Fill(this.bibliotecaDataSet.Libros); }
            else
            {
                MessageBox.Show("Error Uno de los campos se ha dejado vacio porFavor llenar toda la informacion");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.librosTableAdapter.UpdateQuery(tituloTextBox.Text, autorTextBox.Text, editorialTextBox.Text, int.Parse(nopagTextBox.Text), descripcionTextBox.Text, estadoTextBox.Text, fechaTextBox.Text, idiomaTextBox.Text, tipoTextBox.Text, tituloTextBox.Text);
            this.librosTableAdapter.Fill(this.bibliotecaDataSet.Libros);
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            Hide();
        }
    }
}
