using EscritorioGestionProyectosLiquidaciones.Proyectos;
using EscritorioGestionProyectosLiquidaciones.Empleados;
using EscritorioGestionProyectosLiquidaciones.Clientes;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        #region PROYECTO
        private void crearProyectoBtn_Click(object sender, EventArgs e)
        {
            crearModificarProyectoForm crearModificarProyectoForm = new crearModificarProyectoForm();
            crearModificarProyectoForm.Show();
        }

        private void gestionarProyectoBtn_Click(object sender, EventArgs e)
        {
            gestionarProyectosForm gestionarProyecto = new gestionarProyectosForm();
            gestionarProyecto.Show();
        }


        #endregion

        #region EMPLEADO
        private void crearEmpleadoBtn_Click(object sender, EventArgs e)
        {
            crearModificarEmpleadoFrom crearModificarEmpleado = new crearModificarEmpleadoFrom();
            crearModificarEmpleado.Show();
        }

        private void gestionarEmpleadoBtn_Click(object sender, EventArgs e)
        {
            gestionarEmpleadosForm gestionarEmpleados = new gestionarEmpleadosForm();
            gestionarEmpleados.Show();
        }
        #endregion

        #region CLIENTE
        private void crearClienteBtn_Click(object sender, EventArgs e)
        {
            crearModificarClientesForm crearModificarClientes = new crearModificarClientesForm();
            crearModificarClientes.Show();
        }

        private void gestionarClientesBtn_Click(object sender, EventArgs e)
        {
            gestionarClientesForm gestionarClientes = new gestionarClientesForm();
            gestionarClientes.Show();
        }
        #endregion

        private void salirBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("¿Está seguro que desea salir?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            switch (dialog)
            {
                case DialogResult.OK:
                    Application.Exit();
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
