using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Data.OleDb;


namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public static string recordar;
        public Login()
        {
            InitializeComponent();
        } 

        private void OnLoginButtonClick(object sender, EventArgs e)
        {
           

           

        }

        private void OnEraseButtonSelected(object sender, EventArgs e)
        {
            usuario_login.Clear();
        }

        private void OnCloseButton(object sender, EventArgs e)
        {
            Close();
        }

        private void OnAddUser(object sender, EventArgs e)
        {
            new Comprovacion().Show();
            Hide();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            SpeechSynthesizer habla = new SpeechSynthesizer();
           
            if (usuario_login.Text != "usuario")
            {
                usuario_login.ForeColor = System.Drawing.Color.Black;     
            }
            habla.Speak("Welcome to this new program, enjoy the stay");
            usuario_login.Text = recordar;
        }

        private void Borrar(object sender, EventArgs e)
        {
            contraseña_login.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
