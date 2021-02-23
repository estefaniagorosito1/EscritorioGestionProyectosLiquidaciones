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
                    asignar = (bool)row.Cells[3].Value;
                }

                if (asignar)
                {
                    var idEmpleado = int.Parse(row.Cells[0].Value.ToString());

                    EmpleadoProyecto empleadoProyecto = new EmpleadoProyecto
                    {
                        Idproyecto = _proyecto.Idproyecto,
                        Idempleado = idEmpleado
                    };

                    empleadosProyecto.Add(empleadoProyecto);
                }
            }

            if (empleadosProyecto.Count == 0)
            {
                MessageBox.Show("Debe asignar al menos un empleado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _empleadoProyectoService.Guardar(empleadosProyecto);

                MessageBox.Show("Empleados asignados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

        }

        private void AsignarEmpleados_Load(object sender, EventArgs e)
        {
            var empleadosProyecto = _empleadoProyectoService.FindEmpleadosProyecto(_proyecto.Idproyecto);
            empleadosProyectoDataView.DataSource = empleadosProyecto;

            List<Empleado> empleadosAQuitar = new List<Empleado>();
            var empleadosDisponibles = _empleadoService.EmpleadosDisponibles();

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
            try
            {
                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)empleadosProyectoDataView.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (buttonCell.Value.ToString().Equals("Eliminar"))
                {
                    DialogResult result = MessageBox.Show("¿Está seguro de quitar a este empleado?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                    switch (result)
                    {
                        case DialogResult.OK:
                            var ep = _empleadoProyectoService.FindEmpleadoProyecto(int.Parse(empleadosProyectoDataView.Rows[e.RowIndex].Cells[0].Value.ToString()), _proyecto.Idproyecto);
                            _empleadoProyectoService.Eliminar(ep);
                            MessageBox.Show("Empleado quitado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            empleadosProyectoDataView.DataSource = _empleadoProyectoService.FindEmpleadosProyecto(_proyecto.Idproyecto);
                            empleadosDataView.DataSource = _empleadoService.Find();
                            break;
                        case DialogResult.Cancel:
                            break;
                        default:
                            break;
                    }

                }

            }
            catch (Exception)
            {

            }

        }
    }
}
