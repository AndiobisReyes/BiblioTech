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
    public partial class Registrouser : Form
    {
        public static int count = 0;
        public static string user = "admin", pass = "admin";

        


        public Registrouser()
        {
            InitializeComponent();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login().Show();
            Hide();
        }

        private void Registrouser_Load(object sender, EventArgs e)
        {
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
                user = nicknameTextBox.Text;
                pass = passwordTextBox.Text;
                MessageBox.Show("Registro completo");
                new Login().Show();
                Hide();
        }
    }
}
