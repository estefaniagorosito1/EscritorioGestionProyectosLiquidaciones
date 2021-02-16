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
        private TareaService _tareaService;

        public crearModificarTareaForm()
        {
            InitializeComponent();
            _idProyecto = 0;
            _tareaService = new TareaService();
        }

        public void SetProyecto(int idProyecto)
        {
            _idProyecto = idProyecto;
        }

        private void crearModificarTareaForm_Load(object sender, EventArgs e)
        {
            if (_idProyecto != 0)
            {
                tareasDataGrid.DataSource = _tareaService.FindTareasProyecto(_idProyecto);
            }
        }
    }
}
