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
        private EmpleadoService _empleadoService;

        public crearModificarTareaForm()
        {
            InitializeComponent();
            _idProyecto = 0;
            _idTarea = 0;
            _tareaService = new TareaService();
            _empleadoProyectoService = new EmpleadoProyectoService();
            _perfilEmpleadoService = new PerfilEmpleadoService();
            _empleadoService = new EmpleadoService();
        }

        public void SetProyecto(int idProyecto, string nombre)
        {
            _idProyecto = idProyecto;
            Text = Text + " - Proyecto: " + nombre;
        }

        private void crearModificarTareaForm_Load(object sender, EventArgs e)
        {
            if (_idProyecto != 0)
            {
                var tareas = _tareaService.FindTareasSinFinalizarProyecto(_idProyecto);
                tareas.RemoveAll(t => t.finalizada == "true");
                tareasDataGrid.DataSource = tareas;

                // Traigo solo a los empleados que están asociados pero no tienen tareas sin terminar del proyecto
                SetListEmpleados();
            }
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            Tarea tarea = new Tarea();

            if (Valid())
            {
                if (_idTarea == 0)
                {
                    tarea.DescripcionTarea = descripcionTxt.Text;
                    tarea.HorasEstimadasTarea = (int)cantHoras.Value;
                    tarea.Idproyecto = _idProyecto;
                    tarea.Idempleado = (int)empleadosList.SelectedValue;
                    tarea.Idperfil = (int)perfilesEmpleadoList.SelectedValue;
                    tarea.finalizada = "false";
                    tarea.HorasOverbudget = 0;
                }
                else
                {
                    tarea = _tareaService.FindTarea(_idTarea);
                    tarea.DescripcionTarea = descripcionTxt.Text;
                    tarea.HorasEstimadasTarea = (int)cantHoras.Value;
                    tarea.Idproyecto = _idProyecto;
                    tarea.Idempleado = (int)empleadosList.SelectedValue;
                    tarea.Idperfil = (int)perfilesEmpleadoList.SelectedValue;
                    tarea.finalizada = "false";
                }

                _tareaService.Guardar(tarea);

                MessageBox.Show("Tarea guardada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label1.Text = "Crear tarea";
                Clean();
                SetListEmpleados();
                tareasDataGrid.DataSource = _tareaService.FindTareasSinFinalizarProyecto(_idProyecto);
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void tareasFinalizadasBtn_Click(object sender, EventArgs e)
        {
            TareasFinalizadasForm tareasFinalizadasForm = new TareasFinalizadasForm();
            tareasFinalizadasForm.SetProyecto(_idProyecto);
            tareasFinalizadasForm.ShowDialog();
        }

        private void tareasDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)tareasDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (buttonCell.Value.ToString().Equals("Editar"))
                {
                    _idTarea = (int)tareasDataGrid.Rows[e.RowIndex].Cells[0].Value;
                    descripcionTxt.Text = tareasDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cantHoras.Value = (int)tareasDataGrid.Rows[e.RowIndex].Cells[2].Value;

                    // Deshabilito el campo de horas estimadas
                    cantHoras.Enabled = false;

                    var tarea = _tareaService.FindTarea(_idTarea);

                    var empleados = GetEmpleados(_idProyecto);
                    empleados.Add(_empleadoService.FindEmpleado(tarea.Idempleado));

                    if (empleados.Count > 2)
                    {
                        empleados.RemoveAt(0);
                    }

                    empleadosList.DataSource = empleados;
                    empleadosList.SelectedValue = tarea.Idempleado;
                    empleadosList.Enabled = true;

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
                            tareasDataGrid.DataSource = _tareaService.FindTareasSinFinalizarProyecto(_idProyecto);
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

        private List<Empleado> GetEmpleados(int idProyecto)
        {
            List<Empleado> empleados = new List<Empleado>();

            var data = _empleadoService.FindEmpleadosSinTareas(idProyecto);

            if (data.Count == 0)
            {
                var noEmpleado = new Empleado
                {
                    Idempleado = 0,
                    NombreEmpleado = "No hay empleados disponibles"
                };

                empleados.Add(noEmpleado);

            }
            else
            {
                var empleado = new Empleado
                {
                    Idempleado = 0,
                    NombreEmpleado = "Seleccione un empleado"
                };

                empleados.Add(empleado);
                empleados.AddRange(data);

            }

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
            int idEmpleado = (int)empleadosList.SelectedValue;
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

        private bool Valid()
        {
            bool valid = false;

            if (descripcionTxt.Text != string.Empty && cantHoras.Value != 0
                && (int)empleadosList.SelectedValue != 0 && (int)perfilesEmpleadoList.SelectedValue != 0)
            {
                valid = true;
            }

            return valid;
        }

        private void SetListEmpleados()
        {
            List<Empleado> empleados = GetEmpleados(_idProyecto);

            if (empleados.Count == 1)
            {
                empleadosList.Enabled = false;
            }

            empleadosList.DataSource = empleados;
        }


    }
}
