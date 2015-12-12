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
    public partial class VerMensajes : Form
    {
        public VerMensajes()
        {
            InitializeComponent();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            Hide();
        }

        private void VerMensajes_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortDateString();
            StreamReader archivo = new StreamReader("." + "/mensajes.txt", true);
            textBox1.Text = archivo.ReadToEnd();
        }
    }
}
