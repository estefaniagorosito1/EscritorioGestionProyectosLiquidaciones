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
    public partial class CargarHorasTarea : Form
    {
        private TareaService _tareaService;
        private HoraTrabajadaService _horaTrabajadaService;
        private int _idTarea;
        private int _idEmpleado;

        public CargarHorasTarea()
        {
            InitializeComponent();
            _tareaService = new TareaService();
            _horaTrabajadaService = new HoraTrabajadaService();
            _idTarea = 0;
            _idEmpleado = 0;
        }

        public void LoadHorasTarea(int horasEstimadas, int horasTrabajadas, int idTarea, int idEmpleado)
        {
            _idTarea = idTarea;
            _idEmpleado = idEmpleado;

            horasEstimadasTxt.Text = horasEstimadas.ToString();
            horasEstimadasTxt.Enabled = false;
            horasTrabajadasTxt.Text = horasTrabajadas.ToString();
            horasTrabajadasTxt.Enabled = false;
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            var horas = horasACargar.Value;
            var horasTrabajadas = int.Parse(horasTrabajadasTxt.Text.ToString());
            var horasEstimadas = int.Parse(horasEstimadasTxt.Text.ToString());

            Tarea tarea = _tareaService.FindTarea(_idTarea);

            if (tarea.HorasOverbudget == null)
            {
                tarea.HorasOverbudget = 0;
            }

            HoraTrabajada horaTrabajada = new HoraTrabajada
            {
                EstadoHoraTrabajada = "ADEUDADAS",
                FechaHoraTrabajada = DateTime.Today,
                Idempleado = _idEmpleado,
                Idtarea = _idTarea,
                Idperfil = tarea.Idperfil,
                CantidadHoraTrabajada = tarea.HorasTrabajadas + (int) horas,
                Idproyecto = tarea.Idproyecto
            };

            if (horas + horasTrabajadas > horasEstimadas)
            {
                var horasOverbudget = ((horas + horasTrabajadas) - horasEstimadas) - tarea.HorasOverbudget;

                DialogResult result = MessageBox.Show("Está cargando más horas de las estimadas. ¿Esto es correcto?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                switch (result)
                {
                    case DialogResult.Yes:
                        tarea.HorasOverbudget = tarea.HorasOverbudget + (int?)horasOverbudget;
                        CargarHoras(tarea, (int)horas);
                        _horaTrabajadaService.CrearHoraTrabajada(horaTrabajada);
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
            else
            {
                CargarHoras(tarea, (int)horas);
                _horaTrabajadaService.CrearHoraTrabajada(horaTrabajada);
            }
        }

        private void CargarHoras(Tarea tarea, int horas)
        {
            tarea.HorasTrabajadas = tarea.HorasTrabajadas + horas;
            _tareaService.Guardar(tarea);
            MessageBox.Show("Horas cargadas correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ((ListaTareasEmpleadoForm)this.Owner).LoadTareasEmpleado(_idEmpleado);
            Close();
        }
    }
}
