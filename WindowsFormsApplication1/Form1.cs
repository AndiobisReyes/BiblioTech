﻿using System;
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
                MessageBox.Show("Bienvenido al programa" + usuario_login.Text + "usuario autorizado");
                var fr = new Menu();
                fr.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("Acceso denegado" + usuario_login.Text + "usuario no autorizado");
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
            contraseña_login.Clear();
        }

        private void OnCloseButton(object sender, EventArgs e)
        {
            Close();
        }

        private void OnAddUser(object sender, EventArgs e)
        {
            registro_usuario fm = new registro_usuario();
            fm.Show();
            Hide();
        }
    }
}