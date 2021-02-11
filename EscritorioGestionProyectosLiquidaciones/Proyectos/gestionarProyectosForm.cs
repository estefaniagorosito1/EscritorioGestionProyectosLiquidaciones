using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscritorioGestionProyectosLiquidaciones.Proyectos
{
    public partial class gestionarProyectosForm : Form
    {
        public gestionarProyectosForm()
        {
            InitializeComponent();
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crearBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            crearModificarProyectoForm crearModificarProyectoForm = new crearModificarProyectoForm();
            crearModificarProyectoForm.Show();
        }
    }
}
