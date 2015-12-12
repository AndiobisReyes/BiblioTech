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
    public partial class Comprovacion : Form
    {
        int suma = 0;
        public Comprovacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txtcode.Text == Database_Layer.Admin.codigoAdmin)
            {
               new registro_usuario().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("el codigo introducido es incorrecto");
                txtcode.Clear();
                txtcode.Focus();
                suma = suma + 1;
            }   
            
            if (suma > 2)
            {
                MessageBox.Show("Ha exedido el numero de intentos el programa se cerrara");
                Close();
            }
             
            }

        }
    }

