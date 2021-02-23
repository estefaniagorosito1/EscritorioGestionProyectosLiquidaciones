using EscritorioGestionProyectosLiquidaciones.Models;
using EscritorioGestionProyectosLiquidaciones.Services;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscritorioGestionProyectosLiquidaciones.Liquidaciones
{
    public partial class ReporteLiquidacionForm : Form
    {
        private Liquidacion _liquidacion;
        private Empleado _empleado;

        private LiquidacionService _liquidacionService;
        private EmpleadoService _empleadoService;

        public ReporteLiquidacionForm()
        {
            InitializeComponent();

            _liquidacion = new Liquidacion();
            _empleado = new Empleado();

            _liquidacionService = new LiquidacionService();
            _empleadoService = new EmpleadoService();
        }

        public void GetDatosLiquidacion(int idEmpleado, int codLiquidacion)
        {
            _empleado = _empleadoService.FindEmpleado(idEmpleado);
            _liquidacion = _liquidacionService.GetLiquidacion(codLiquidacion);
        }

        private void ReporteLiquidacionForm_Load(object sender, EventArgs e)
        {
            // Armo los parametros
            ReportParameter[] reportParameters = new ReportParameter[5];
            reportParameters[0] = new ReportParameter("nombreApellidoEmpleado", _empleado.NombreEmpleado + " " + _empleado.ApellidoEmpleado);
            reportParameters[1] = new ReportParameter("dniEmpleado", _empleado.DniEmpleado.ToString());
            reportParameters[2] = new ReportParameter("telefonoEmpleado", _empleado.Telefono);
            reportParameters[3] = new ReportParameter("direccionEmpleado", _empleado.Direccion);
            reportParameters[4] = new ReportParameter("fechaIngresoEmpleado", _empleado.FechaIngresoEmpleado.ToShortDateString());
            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            // Armo los data source
            List<Liquidacion> liquidaciones = new List<Liquidacion>();
            liquidaciones.Add(_liquidacion);
            ReportDataSource dataSource1 = new ReportDataSource("DataSet1", liquidaciones);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource1);

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EscritorioGestionProyectosLiquidaciones.Reportes.ReporteLiquidacion.rdlc";
            this.reportViewer1.RefreshReport();

        }
    }
}
