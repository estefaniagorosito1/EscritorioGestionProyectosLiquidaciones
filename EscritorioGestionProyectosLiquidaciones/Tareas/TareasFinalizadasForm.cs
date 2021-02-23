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
    public partial class TareasFinalizadasForm : Form
    {
        private int _idProyecto;
        private TareaService _tareaService;
        private ProyectoService _proyectoService;

        public TareasFinalizadasForm()
        {
            InitializeComponent();
            _idProyecto = 0;
            _tareaService = new TareaService();
            _proyectoService = new ProyectoService();
        }

        public void SetProyecto(int idProyecto)
        {
            _idProyecto = idProyecto;
            var proyecto = _proyectoService.FindProyecto(_idProyecto);

            nombreProyecto.Text = nombreProyecto.Text + ": " + proyecto.NombreProyecto;
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TareasFinalizadasForm_Load(object sender, EventArgs e)
        {
            if (_idProyecto != 0)
            {
                var data = _tareaService.FindTareasFinalizadasProyecto(_idProyecto);
                tareasFinalizadasDataGrid.DataSource = data;
            }
        }
    }
}
