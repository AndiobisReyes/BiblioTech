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
    public partial class Autores : Form
    {
        public Autores()
        {
            InitializeComponent();
        }

        private void autoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.autoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void Autores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.bibliotecaDataSet.Autores);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.autoresTableAdapter.DeleteQuery(int.Parse(idTextBox.Text));
            this.autoresTableAdapter.Fill(this.bibliotecaDataSet.Autores);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.autoresTableAdapter.InsertQuery(nombreTextBox.Text, nacionalidadTextBox.Text, obramasfamosaTextBox.Text, generoliterarioTextBox.Text, fechanatTextBox.Text, fechamortTextBox.Text);
            this.autoresTableAdapter.Fill(this.bibliotecaDataSet.Autores);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.autoresTableAdapter.UpdateQuery(nombreTextBox.Text, nacionalidadTextBox.Text, obramasfamosaTextBox.Text, generoliterarioTextBox.Text, fechanatTextBox.Text, fechamortTextBox.Text, nombreTextBox.Text);
            this.autoresTableAdapter.Fill(this.bibliotecaDataSet.Autores);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.autoresTableAdapter.GetDataBy2(nombreTextBox.Text);
            this.autoresTableAdapter.Fill(this.bibliotecaDataSet.Autores);
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            Hide();
        }
    }
}


