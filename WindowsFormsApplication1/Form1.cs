using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
           

            var conexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\Biblioteca.accdb");

            conexion.Open();

            var consulta = "select Nickname, Password from Usuario where Password='" + contraseña_login.Text + "'and Nickname='" + usuario_login.Text + "';" ;
            
            var comando = new OleDbCommand(consulta, conexion);
            
            var Lectordatos = comando.ExecuteReader();
            
            var existenciaRegistros = Lectordatos.HasRows;
            
            if (existenciaRegistros) {
                MessageBox.Show("Bienvenido al programa--" + usuario_login.Text + "--usuario autorizado");
                if (Record.Checked == true)
                {
                    recordar = usuario_login.Text;
                }
                var fr = new Menu();
                fr.Show();
                Hide();
                

            }
            else
            {
                MessageBox.Show("Acceso denegado--" + usuario_login.Text + "--usuario no autorizado");
                usuario_login.Clear();
                contraseña_login.Clear();
                usuario_login.Focus();
                return;
            }
            //cerramos conexcion
            conexion.Close();

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
            usuario_login.Text = recordar;
            if (usuario_login.Text != "usuario")
            {
                usuario_login.ForeColor = System.Drawing.Color.Black;     
            }
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
