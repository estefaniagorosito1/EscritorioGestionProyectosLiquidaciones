using EscritorioGestionProyectosLiquidaciones.Models;
using EscritorioGestionProyectosLiquidaciones.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscritorioGestionProyectosLiquidaciones.Liquidaciones
{
    public partial class GenerarLiquidacionForm : Form
    {
        private int _idEmpleado;
        private int _mesLiquidado;

        private EmpleadoService _empleadoService;
        private LiquidacionService _liquidacionService;

        public GenerarLiquidacionForm()
        {
            InitializeComponent();
            _empleadoService = new EmpleadoService();
            _liquidacionService = new LiquidacionService();

            _idEmpleado = 0;
            _mesLiquidado = 0;
        }

        private void GenerarLiquidacionForm_Load(object sender, EventArgs e)
        {
            List<Empleado> empleados = new List<Empleado>();
            var empleado = new Empleado
            {
                Idempleado = 0,
                NombreEmpleado = "Seleccione un empleado"
            };

            empleados.Add(empleado);
            empleados.AddRange(_empleadoService.Find());

            // Lista de arriba. Traigo a los empleados
            empleadosList.DataSource = empleados;

        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void generarLiqBtn_Click(object sender, EventArgs e)
        {
            if (_idEmpleado == 0 || _mesLiquidado == 0)
            {
                MessageBox.Show("Debe seleccionar una fecha y un empleado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Liquidacion liquidacion = new Liquidacion
                {
                    Idempleado = _idEmpleado,
                    MesLiquidado = _mesLiquidado,
                };

                try
                {
                    _liquidacionService.CrearLiquidacion(liquidacion);
                    MessageBox.Show("Liquidación generada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        }

        private void empleadosList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _idEmpleado = (int)empleadosList.SelectedValue;
        }

        private void fechaLiquidacion_ValueChanged(object sender, EventArgs e)
        {
            _mesLiquidado = fechaLiquidacion.Value.Month;
        }

        private void empleadosConLiqList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idempleado = (int)empleadosConLiqList.SelectedValue;
            _idEmpleado = idempleado;

            var empleado = _empleadoService.FindEmpleado(idempleado);
            buscarLiqLabel.Text = "Liquidaciones del empleado " + empleado.NombreEmpleado + " " + empleado.ApellidoEmpleado;

            liquidacionesDataGrid.DataSource = _liquidacionService.GetLiquidacionesEmpleado(idempleado);

            foreach (DataGridViewRow row in liquidacionesDataGrid.Rows)
            {
                var codLiq = (int)liquidacionesDataGrid.Rows[row.Index].Cells[0].Value;
                var liquidacion = _liquidacionService.GetLiquidacion(codLiq);

                liquidacionesDataGrid.Rows[row.Index].Cells[2].Value = DateTimeFormatInfo.CurrentInfo.GetMonthName(liquidacion.MesLiquidado.Value).ToUpper();
            }
        }

        private void empleadosConLiqList_Click(object sender, EventArgs e)
        {
            List<Empleado> empleados = new List<Empleado>();
            var empleado = new Empleado
            {
                Idempleado = 0,
                NombreEmpleado = "Seleccione un empleado"
            };

            empleados.Add(empleado);
            empleados.AddRange(_empleadoService.Find());

            empleadosConLiqList.DataSource = empleados;
        }

        private void liquidacionesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)liquidacionesDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (buttonCell.Value.ToString() == "Imprimir liquidación")
            {
                ReporteLiquidacionForm reporteLiquidacionForm = new ReporteLiquidacionForm();
                reporteLiquidacionForm.GetDatosLiquidacion(_idEmpleado, (int)liquidacionesDataGrid.Rows[e.RowIndex].Cells[0].Value);
                reporteLiquidacionForm.Show();

                // MessageBox.Show("Funcionalidad sin implementar");
            }
        }
    }
}
