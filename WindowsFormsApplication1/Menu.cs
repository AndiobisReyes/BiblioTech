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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guardar fm = new Guardar();
            fm.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Autores fm = new Autores();
            fm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Prestamos().Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new EnviarMensajes().Show();
            Hide();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.bibliotecaDataSet.Usuario);

        }

        private void cerrarSeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new Login().Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cerrarSeccionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new Login().Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Info().Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new RecibirMensaje().Show();
            Hide();
        }
    }
}
