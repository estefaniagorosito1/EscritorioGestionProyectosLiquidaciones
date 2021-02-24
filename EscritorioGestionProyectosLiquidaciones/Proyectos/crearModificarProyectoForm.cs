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
            clientes.DataSource = _clienteService.Find();

            proyecto = _proyectoService.FindProyecto(proyecto.Idproyecto);

            List<string> estados = new List<string>();
            estados.Add("Seleccione un estado");
            estados.Add(EstadoProyecto.En_Proceso.ToString().Replace("_", " "));
            estados.Add(EstadoProyecto.Finalizado.ToString());
            estados.Add(EstadoProyecto.Pausado.ToString());

            estadosProyecto.DataSource = estados;

            _proyecto = proyecto;
            nombreTxt.Text = proyecto.NombreProyecto;
            descripcionTxt.Text = proyecto.Descripcion;
            estadosProyecto.SelectedIndex = estadosProyecto.FindString(proyecto.EstadoProyecto);
            clientes.SelectedValue = proyecto.Idcliente;
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            Proyecto proyecto;

            if (Valid())
            {
                // Creo un proyecto
                if (_proyecto.Idproyecto == 0)
                {
                    proyecto = new Proyecto
                    {
                        NombreProyecto = nombreTxt.Text,
                        Descripcion = descripcionTxt.Text,
                        EstadoProyecto = estadosProyecto.SelectedValue.ToString(),
                        Idcliente = (int)clientes.SelectedValue,
                        FechaInicioProyecto = DateTime.Today
                    };
                }
                else
                {
                    // Modifico un proyecto
                    proyecto = _proyecto;
                    proyecto.NombreProyecto = nombreTxt.Text;
                    proyecto.Descripcion = descripcionTxt.Text;
                    proyecto.EstadoProyecto = estadosProyecto.SelectedValue.ToString();
                    proyecto.Idcliente = (int)clientes.SelectedValue;

                    if(proyecto.EstadoProyecto == EstadoProyecto.Finalizado.ToString())
                    {
                        proyecto.FechaFinProyecto = DateTime.Today; 
                    }

                }

                _proyectoService.Guardar(proyecto);
                MessageBox.Show("Proyecto guardado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if(this.Owner != null)
                {
                    ((gestionarProyectosForm)this.Owner).LoadProyectos();
                }

                Close();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void asignarBtn_Click(object sender, EventArgs e)
        {
            AsignarEmpleados asignarEmpleados = new AsignarEmpleados();
            asignarEmpleados.SetProyecto(_proyecto);
            asignarEmpleados.ShowDialog();
        }

        private void crearModificarProyectoForm_Load(object sender, EventArgs e)
        {
            if (_proyecto.Idproyecto == 0)
            {
                var data = new List<Cliente>();

                var cliente = new Cliente
                {
                    Idcliente = 0,
                    NombreCliente = "Seleccione un cliente"
                };

                List<string> estados = new List<string>();
                estados.Add("Seleccione un estado");
                estados.Add(EstadoProyecto.En_Proceso.ToString().Replace("_", " "));
                estados.Add(EstadoProyecto.Finalizado.ToString());
                estados.Add(EstadoProyecto.Pausado.ToString());

                estadosProyecto.DataSource = estados;

                data.Add(cliente);
                data.AddRange(_clienteService.Find());

                clientes.DataSource = data;

                asignarBtn.Enabled = false;
            }

        }

        private bool Valid()
        {
            bool valid = false;

            if (nombreTxt.Text != string.Empty && (string)estadosProyecto.SelectedValue != string.Empty
                && (int)clientes.SelectedValue != 0 && descripcionTxt.Text != string.Empty)
            {
                valid = true;
            }

            return valid;
        }
    }
}
