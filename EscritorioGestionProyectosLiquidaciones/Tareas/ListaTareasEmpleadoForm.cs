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
    public partial class ListaTareasEmpleadoForm : Form
    {
        private TareaService _tareaService;
        private ProyectoService _proyectoService;
        private int _idEmpleado;

        public ListaTareasEmpleadoForm()
        {
            InitializeComponent();
            _tareaService = new TareaService();
            _proyectoService = new ProyectoService();
            _idEmpleado = 0;
        }

        public void LoadTareasEmpleado(int idEmpleado)
        {
            _idEmpleado = idEmpleado;

            var data = _tareaService.FindTareasEmpleado(idEmpleado);
            data.RemoveAll(t => t.finalizada == "true");
            tareasEmpleadoDataGrid.DataSource = data;

            tareasFinalizadasDataGrid.DataSource = _tareaService.FindTareasFinalizadasEmpleado(idEmpleado);

        }

        private void tareasEmpleadoDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)tareasEmpleadoDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (buttonCell.Value.ToString().Equals("Agregar horas"))
                {
                    var idTarea = int.Parse(tareasEmpleadoDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var horasEstimadas = int.Parse(tareasEmpleadoDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                    var horasTrabajadas = int.Parse(tareasEmpleadoDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString());

                    var tareaSeleccionada = _tareaService.FindTarea(idTarea);
                    var nombreProyecto = _proyectoService.FindProyecto(tareaSeleccionada.Idproyecto).NombreProyecto;

                    CargarHorasTarea cargarHorasTareaForm = new CargarHorasTarea();
                    cargarHorasTareaForm.Text = nombreProyecto + " - Tarea n°" + idTarea;
                    cargarHorasTareaForm.LoadHorasTarea(horasEstimadas, horasTrabajadas, idTarea, _idEmpleado);
                    cargarHorasTareaForm.ShowDialog(this);

                }
                else if (buttonCell.Value.ToString().Equals("Finalizar"))
                {
                    var idTarea = int.Parse(tareasEmpleadoDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    Tarea tarea = _tareaService.FindTarea(idTarea);

                    if (tarea.HorasTrabajadas != 0)
                    {
                        DialogResult result = MessageBox.Show("¿Desea marcar esta tarea como finalizada?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        switch (result)
                        {
                            case DialogResult.Yes:
                                MessageBox.Show("Tarea n°" + idTarea + " finalizada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tarea.finalizada = "true";
                                _tareaService.Guardar(tarea);
                                LoadTareasEmpleado(_idEmpleado);
                                break;
                            case DialogResult.No:
                                break;
                            default:
                                break;
                        }

                    } else
                    {
                        MessageBox.Show("No hay horas cargadas en la tarea seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception)
            {

            }

        }
    }
}
