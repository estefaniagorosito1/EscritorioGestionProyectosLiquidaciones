using EscritorioGestionProyectosLiquidaciones.Models;
using EscritorioGestionProyectosLiquidaciones.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscritorioGestionProyectosLiquidaciones
{
    public partial class LoginForm : Form
    {
        private UsuarioService _usuarioService;

        public LoginForm()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();
        }

        private void ingresarBtn_Click(object sender, EventArgs e)
        {
            var usuario = userTxt.Text;
            var pass = passwordTxt.Text;

            if (usuario != string.Empty && pass != string.Empty)
            {

                var user = _usuarioService.FindUsuario(usuario, pass);

                if (user != null)
                {
                    LoginForm.ActiveForm.Hide();

                    Home home = new Home();
                    home.Show();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Usuario y/o contraseña incorrectos", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    switch (result)
                    {
                        case DialogResult.OK:
                            break;
                        case DialogResult.Cancel:
                            break;
                        default:
                            break;
                    }

                    userTxt.Clear();
                    passwordTxt.Clear();
                }


            }

        }

    }
}
