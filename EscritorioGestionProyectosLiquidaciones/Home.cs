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
using EscritorioGestionProyectosLiquidaciones.Models;
using EscritorioGestionProyectosLiquidaciones.Services;
using EscritorioGestionProyectosLiquidaciones.Tareas;

namespace EscritorioGestionProyectosLiquidaciones
{
    public partial class Home : Form
    {
        private Usuario _usuarioSession;
        private EmpleadoService _empleadoService;
        private RolService _rolService;
        private UsuarioService _usuarioService;

        public Home()
        {
            InitializeComponent();
            _usuarioSession = new Usuario();
            _empleadoService = new EmpleadoService();
            _rolService = new RolService();
            _usuarioService = new UsuarioService();
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

        private void misTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaTareasEmpleadoForm listaTareasEmpleadoForm = new ListaTareasEmpleadoForm();
            listaTareasEmpleadoForm.LoadTareasEmpleado(_usuarioSession.Idempleado);
            listaTareasEmpleadoForm.Show();
        }

        public void StoreUsuarioSession(string nombreUsuario, string password)
        {
            _usuarioSession = _usuarioService.FindUsuario(nombreUsuario, password);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            var rolUsuario = _rolService.FindRol(_usuarioSession.Idrol);

            if (rolUsuario.DescripcionRol == "Empleado")
            {
                toolStripDropDownButton1.DropDownItems.Remove(empleadosToolStripMenuItem);
                toolStripDropDownButton1.DropDownItems.Remove(clientesToolStripMenuItem);
                toolStripDropDownButton1.DropDownItems.Remove(proyectosToolStripMenuItem);

                toolStrip1.Items.Remove(liquidacionBtn);
            }

            if (rolUsuario.DescripcionRol == "Project Manager")
            {
                toolStripDropDownButton1.DropDownItems.Remove(empleadosToolStripMenuItem);
                toolStripDropDownButton1.DropDownItems.Remove(clientesToolStripMenuItem);
                toolStripDropDownButton1.DropDownItems.Remove(misTareasToolStripMenuItem);

                toolStrip1.Items.Remove(liquidacionBtn);
            }

            if (rolUsuario.DescripcionRol == "Administrativo")
            {
                toolStripDropDownButton1.DropDownItems.Remove(empleadosToolStripMenuItem);
                toolStripDropDownButton1.DropDownItems.Remove(clientesToolStripMenuItem);
                toolStripDropDownButton1.DropDownItems.Remove(proyectosToolStripMenuItem);
                toolStripDropDownButton1.DropDownItems.Remove(misTareasToolStripMenuItem);
            }
        }
    }
}
