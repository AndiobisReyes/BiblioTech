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
    public partial class RecibirMensaje : Form
    {
        public RecibirMensaje()
        {
            InitializeComponent();
        }

        private void RecibirMensaje_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortDateString();
            label3.Text = DateTime.Now.ToShortTimeString();
            StreamReader archivo = new StreamReader("." + "/Mensajes.txt", true);
            textBox1.Text = archivo.ReadToEnd();
            
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            Hide();
        }
    }
}
