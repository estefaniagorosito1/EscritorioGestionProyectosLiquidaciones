using EscritorioGestionProyectosLiquidaciones.Models;
using EscritorioGestionProyectosLiquidaciones.Services;
using EscritorioGestionProyectosLiquidaciones.Tareas;
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
        private ProyectoService _proyectoService;
        private ClienteService _clienteService;

        public gestionarProyectosForm()
        {
            InitializeComponent();
            _proyectoService = new ProyectoService();
            _clienteService = new ClienteService();
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

        private void proyectosDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonCell buttonCell = (DataGridViewButtonCell) proyectosDataView.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (buttonCell.Value.ToString().Equals("Editar"))
            {
                crearModificarProyectoForm crearModificarProyectoForm = new crearModificarProyectoForm();

                crearModificarProyectoForm.LoadProyecto(new Proyecto
                {
                    Idproyecto = int.Parse(proyectosDataView.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    NombreProyecto = proyectosDataView.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Descripcion = proyectosDataView.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    EstadoProyecto = proyectosDataView.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    FechaInicioProyecto = new DateTime(),
                    // FALTA CLIENTE
                });

                crearModificarProyectoForm.Text = "Modificar proyecto";
                crearModificarProyectoForm.Show();
            }
            else if (buttonCell.Value.ToString().Equals("Eliminar"))
            {
                DialogResult result = MessageBox.Show("¿Está seguro de eliminar este proyecto?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                switch (result)
                {
                    case DialogResult.OK:
                        _proyectoService.Eliminar(int.Parse(proyectosDataView.Rows[e.RowIndex].Cells[0].Value.ToString()));
                        proyectosDataView.DataSource = _proyectoService.Find();
                        break;
                    case DialogResult.Cancel:
                        break;
                    default:
                        break;
                }

            }
            else if (buttonCell.Value.ToString().Equals("Ver tareas"))
            {
                crearModificarTareaForm crearModificarTareaForm = new crearModificarTareaForm();
                crearModificarTareaForm.SetProyecto(int.Parse(proyectosDataView.Rows[e.RowIndex].Cells[0].Value.ToString()));
                crearModificarTareaForm.Show();
            }
        }

        private void gestionarProyectosForm_Load(object sender, EventArgs e)
        {
            proyectosDataView.DataSource = _proyectoService.Find();
        }
    }
}
