using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class EnviarMensajes : Form
    {
        public EnviarMensajes()
        {
            InitializeComponent();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter archivo = new StreamWriter("." + "/Mensajes.txt", true);
            archivo.WriteLine("Mensaje de--" + registro_usuario.user + "--en la fecha--" + label2.Text +"--a las--"+ label3.Text + "--y su mensaje fue--"+ textBox1.Text);
            archivo.Close();
            textBox1.Clear();
            MessageBox.Show("Su mensaje ha sido guardado con exito");
        }

        private void EnviarMensajes_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortDateString();
            label3.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
