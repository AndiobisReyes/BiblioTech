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
    public partial class registro_usuario : Form
    {
        public static string user;
        public registro_usuario()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            usuarioBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(bibliotecaDataSet);

        }

        private void registro_usuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet.Usuario' table. You can move, or remove it, as needed.
            usuarioTableAdapter.Fill(this.bibliotecaDataSet.Usuario);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login fm = new Login();
            fm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text != null && apellidoTextBox.Text != null && nicknameTextBox.Text != null && passwordTextBox.Text != null && telefonoTextBox.Text != null && direccionTextBox.Text != null && correoElectronicoTextBox.Text != null)
            {
                this.usuarioTableAdapter.InsertQuery(nombreTextBox.Text, apellidoTextBox.Text, nicknameTextBox.Text, passwordTextBox.Text, telefonoTextBox.Text, direccionTextBox.Text, correoElectronicoTextBox.Text);
                this.usuarioTableAdapter.Fill(this.bibliotecaDataSet.Usuario);
                user = nicknameTextBox.Text;
                nombreTextBox.Clear();
                apellidoTextBox.Clear();
                nicknameTextBox.Clear();
                passwordTextBox.Clear();
                telefonoTextBox.Clear();
                direccionTextBox.Clear();
                correoElectronicoTextBox.Clear();
                
                MessageBox.Show("Registro realizado con exito");
                new Login().Show();
                Hide();
                
            }
            else
            {
                MessageBox.Show("Error Uno de los campos se ha dejado vacio porFavor llenar toda la informacion");
            
            }

        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login().Show();
            Hide();
        }
    }
}
