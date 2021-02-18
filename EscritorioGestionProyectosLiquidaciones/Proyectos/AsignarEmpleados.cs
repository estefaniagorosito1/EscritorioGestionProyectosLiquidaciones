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
    public partial class AsignarEmpleados : Form
    {
        private Proyecto _proyecto;
        private EmpleadoService _empleadoService;
        private EmpleadoProyectoService _empleadoProyectoService;

        public AsignarEmpleados()
        {
            InitializeComponent();
            _proyecto = new Proyecto();
            _empleadoService = new EmpleadoService();
            _empleadoProyectoService = new EmpleadoProyectoService();
        }

        public void SetProyecto(Proyecto proyecto)
        {
            _proyecto = proyecto;
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            List<EmpleadoProyecto> empleadosProyecto = new List<EmpleadoProyecto>();

            DataGridViewRowCollection rows = empleadosDataView.Rows;

            foreach (DataGridViewRow row in rows)
            {
                bool asignar = false;

                if (row.Cells[3].Value != null)
                {
                    asignar = (bool) row.Cells[3].Value;
                }

                if (asignar)
                {
                    var idEmpleado = int.Parse(row.Cells[0].Value.ToString());

                    EmpleadoProyecto empleadoProyecto = new EmpleadoProyecto();
                    empleadoProyecto.Idproyecto = _proyecto.Idproyecto;
                    empleadoProyecto.Idempleado = idEmpleado;

                    empleadosProyecto.Add(empleadoProyecto);
                }
            }

             _empleadoProyectoService.Guardar(empleadosProyecto);

            MessageBox.Show("Empleados asignados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void AsignarEmpleados_Load(object sender, EventArgs e)
        {
            var empleadosProyecto = _empleadoProyectoService.FindEmpleadosProyecto(_proyecto.Idproyecto);
            empleadosProyectoDataView.DataSource = empleadosProyecto;

            var empleadosDisponibles = _empleadoService.Find();
            List<Empleado> empleadosAQuitar = new List<Empleado>();

            foreach (var item in empleadosDisponibles)
            {
                if (empleadosProyecto.Any(emp => emp.Idempleado == item.Idempleado))
                {
                    empleadosAQuitar.Add(item);
                }
            }

            empleadosDisponibles.RemoveAll(x => empleadosAQuitar.Contains(x));

            empleadosDataView.DataSource = empleadosDisponibles;
        }

        private void empleadosProyectoDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
