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

namespace EscritorioGestionProyectosLiquidaciones.Proyectos
{
    public partial class crearModificarProyectoForm : Form
    {
        private ClienteService _clienteService;
        private ProyectoService _proyectoService;
        private Proyecto _proyecto;

        public crearModificarProyectoForm()
        {
            InitializeComponent();
            _clienteService = new ClienteService();
            _proyectoService = new ProyectoService();
            _proyecto = new Proyecto();
        }

        public void LoadProyecto(Proyecto proyecto)
        {
            label1.Text = "Modificar proyecto";

            _proyecto = proyecto;
            nombreTxt.Text = proyecto.NombreProyecto;
            descripcionTxt.Text = proyecto.Descripcion;
            estadosProyecto.SelectedItem = estadosProyecto.FindString(proyecto.EstadoProyecto);
            clientes.SelectedItem = clientes.Items.IndexOf(proyecto.Idcliente);
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            Proyecto proyecto;

            // Creo un proyecto
            if (_proyecto.Idproyecto == 0)
            {
                proyecto = new Proyecto
                {
                    NombreProyecto = nombreTxt.Text,
                    Descripcion = descripcionTxt.Text,
                    EstadoProyecto = estadosProyecto.SelectedText,
                    Idcliente = (int)clientes.SelectedValue,
                    FechaInicioProyecto = new DateTime()
                };
            }
            else
            {
                // Modifico un proyecto
                proyecto = _proyecto;
                proyecto.NombreProyecto = nombreTxt.Text;
                proyecto.Descripcion = descripcionTxt.Text;
                proyecto.EstadoProyecto = estadosProyecto.SelectedText;
                proyecto.Idcliente = (int)clientes.SelectedValue;
            }

            _proyectoService.Guardar(proyecto);

        }

        private void asignarBtn_Click(object sender, EventArgs e)
        {
            AsignarEmpleados asignarEmpleados = new AsignarEmpleados();
            asignarEmpleados.SetProyecto(_proyecto);
            asignarEmpleados.ShowDialog();
        }

        private void crearModificarProyectoForm_Load(object sender, EventArgs e)
        {
            var data = new List<Cliente>();

            var cliente = new Cliente
            {
                Idcliente = 0,
                NombreCliente = "Seleccione un cliente"
            };

            data.Add(cliente);
            data.AddRange(_clienteService.Find());

            clientes.DataSource = data;
        }
    }
}
