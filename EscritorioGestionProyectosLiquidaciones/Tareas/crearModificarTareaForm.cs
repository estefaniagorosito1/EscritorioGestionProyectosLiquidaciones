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

namespace EscritorioGestionProyectosLiquidaciones.Tareas
{
    public partial class crearModificarTareaForm : Form
    {
        private int _idProyecto;
        private int _idTarea;
        private TareaService _tareaService;
        private EmpleadoProyectoService _empleadoProyectoService;
        private PerfilEmpleadoService _perfilEmpleadoService;

        public crearModificarTareaForm()
        {
            InitializeComponent();
            _idProyecto = 0;
            _idTarea = 0;
            _tareaService = new TareaService();
            _empleadoProyectoService = new EmpleadoProyectoService();
            _perfilEmpleadoService = new PerfilEmpleadoService();
        }

        public void SetProyecto(int idProyecto, string nombre)
        {
            _idProyecto = idProyecto;
            Text = Text + " - " + nombre;
        }

        private void crearModificarTareaForm_Load(object sender, EventArgs e)
        {
            if (_idProyecto != 0)
            {
                tareasDataGrid.DataSource = _tareaService.FindTareasProyecto(_idProyecto);

                // Traigo solo a los empleados que están asociados pero no tienen tareas sin terminar del proyecto
                List<Empleado> empleados = GetEmpleados(_idProyecto);

                var empleadosOcupados = new List<Empleado>();

                foreach (var emp in empleados)
                {
                    var tareasEmpleado = _tareaService.FindTareasEmpleado(emp.Idempleado);
                    if (tareasEmpleado.Any(x => x.Idproyecto == _idProyecto && x.finalizada == "false")) {
                        empleadosOcupados.Add(emp);
                    }
                }

                empleados.RemoveAll(emp => empleadosOcupados.Contains(emp));
                empleadosList.DataSource = empleados;

                // Deshabilito los botones si la tarea está finalizada
                foreach (DataGridViewRow row in tareasDataGrid.Rows)
                {
                    var idTarea = (int) tareasDataGrid.Rows[row.Index].Cells[0].Value;
                    var tarea = _tareaService.FindTarea(idTarea);

                    if (tarea.finalizada == "true")
                    {
                        var editarBtn = (DataGridViewButtonCell) tareasDataGrid.Rows[row.Index].Cells[5];
                        editarBtn.DataGridView.Enabled = false;
                        var eliminarBtn = (DataGridViewButtonCell) tareasDataGrid.Rows[row.Index].Cells[6];
                        eliminarBtn.DataGridView.Enabled = false;
                    }
                } 
            }
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            Tarea tarea = new Tarea();

            if (_idTarea == 0)
            {
                tarea.DescripcionTarea = descripcionTxt.Text;
                tarea.HorasEstimadasTarea = (int)cantHoras.Value;
                tarea.Idproyecto = _idProyecto;
                tarea.Idempleado = (int) empleadosList.SelectedValue;
                tarea.Idperfil = (int) perfilesEmpleadoList.SelectedValue;
            }
            else
            {
                tarea = _tareaService.FindTarea(_idTarea);
                tarea.DescripcionTarea = descripcionTxt.Text;
                tarea.HorasEstimadasTarea = (int)cantHoras.Value;
                tarea.Idproyecto = _idProyecto;
                tarea.Idempleado = (int) empleadosList.SelectedValue;
                tarea.Idperfil = (int) perfilesEmpleadoList.SelectedValue;
            }

            _tareaService.Guardar(tarea);

            MessageBox.Show("Tarea guardada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label1.Text = "Crear tarea";
            Clean();
            tareasDataGrid.DataSource = _tareaService.FindTareasProyecto(_idProyecto);
        }

        private void tareasDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)tareasDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (buttonCell.Value.ToString().Equals("Editar"))
            {
                _idTarea = (int)tareasDataGrid.Rows[e.RowIndex].Cells[0].Value;
                descripcionTxt.Text = tareasDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                cantHoras.Value = (int) tareasDataGrid.Rows[e.RowIndex].Cells[2].Value;

                // Deshabilito el campo de horas estimadas
                cantHoras.Enabled = false;

                var tarea = _tareaService.FindTarea(_idTarea);
                empleadosList.DataSource = GetEmpleados(_idProyecto);
                empleadosList.SelectedValue = tarea.Idempleado;

                perfilesEmpleadoList.DataSource = GetPerfilesEmpleado(tarea.Idempleado);
                perfilesEmpleadoList.SelectedValue = tarea.Idperfil;

                label1.Text = "Modificar tarea";
            }
            else if (buttonCell.Value.ToString().Equals("Eliminar"))
            {
                DialogResult result = MessageBox.Show("¿Está seguro de eliminar esta tarea?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                switch (result)
                {
                    case DialogResult.OK:
                        _tareaService.Eliminar(_idTarea);
                        MessageBox.Show("Tarea eliminada", "Éxito", MessageBoxButtons.OK);
                        tareasDataGrid.DataSource = _tareaService.FindTareasProyecto(_idProyecto);
                        break;
                    case DialogResult.Cancel:
                        break;
                    default:
                        break;
                }
            }
        }

        private List<Empleado> GetEmpleados(int idProyecto)
        {
            List<Empleado> empleados = new List<Empleado>();

            var empleado = new Empleado
            {
                Idempleado = 0,
                NombreEmpleado = "Seleccione un empleado"
            };

            empleados.Add(empleado);
            empleados.AddRange(_empleadoProyectoService.FindEmpleadosProyecto(idProyecto));

            return empleados;
        }

        private List<Perfil> GetPerfilesEmpleado(int idEmpleado)
        {
            List<Perfil> perfiles = new List<Perfil>();

            var perfil = new Perfil
            {
                Idperfil = 0,
                NombrePerfil = "Seleccione un perfil"
            };

            perfiles.Add(perfil);
            perfiles.AddRange(_perfilEmpleadoService.FindPerfilesEmpleado(idEmpleado));

            return perfiles;
        }

        private void empleadosList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idEmpleado = (int) empleadosList.SelectedValue;
            perfilesEmpleadoList.DataSource = GetPerfilesEmpleado(idEmpleado);
        }

        private void Clean()
        {
            _idTarea = 0;
            descripcionTxt.Text = string.Empty;
            cantHoras.Value = 0;
            empleadosList.SelectedValue = 0;
            perfilesEmpleadoList.SelectedValue = 0;
        }
    }
}
