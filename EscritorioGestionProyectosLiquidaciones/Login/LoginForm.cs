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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ingresarBtn_Click(object sender, EventArgs e)
        {
            // Tengo que tomar los datos que están contenidos en los textbox 
            // y pegarle a base de datos para ver si existe el usuario 
            var usuario = userTxt.Text;
            var pass = passwordTxt.Text;

            if (usuario != string.Empty && pass != string.Empty)
            {
                // llamo a service con los datos
                var user = "asdasd";

                if (user != string.Empty)
                {
                    LoginForm.ActiveForm.Hide();

                    Home home = new Home();
                    home.Show();

                } else
                {
                    // Muestro popup de error
                    userTxt.Clear();
                    passwordTxt.Clear();
                }
            }

        }

    }
}
