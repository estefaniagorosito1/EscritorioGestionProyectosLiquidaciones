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

namespace EscritorioGestionProyectosLiquidaciones.Proyectos
{
    public partial class InformeHorasProyecto : Form
    {
        private int _idProyecto;
        private int _horasAdeudadas;
        private int _horasOverbudget;

        private Proyecto proyecto;
        private List<HorasReportBody> body;

        private HoraTrabajadaService _horaTrabajadaService;
        private ProyectoService _proyectoService;
        private PerfilService _perfilService;

        public InformeHorasProyecto()
        {
            InitializeComponent();
            _idProyecto = 0;
            _horasAdeudadas = 0;
            _horasOverbudget = 0;

            proyecto = new Proyecto();
            body = new List<HorasReportBody>();

            _horaTrabajadaService = new HoraTrabajadaService();
            _proyectoService = new ProyectoService();
            _perfilService = new PerfilService();
        }

        public void SetProyecto(int idProyecto)
        {
            _idProyecto = idProyecto;
            proyecto = _proyectoService.FindProyecto(_idProyecto);
            CreateReportData();
        }

        private void CreateReportData()
        {
            _horasAdeudadas = _horaTrabajadaService.GetCantHorasAdeudadasProyecto(_idProyecto);
            _horasOverbudget = _horaTrabajadaService.GetCantHorasOverbudgetProyecto(_idProyecto);

            var perfiles = _perfilService.FindPerfiles();

            body = new List<HorasReportBody>();

            foreach (var perf in perfiles)
            {
                HorasReportBody reportBody = new HorasReportBody();
                var horasTrabajadas = _horaTrabajadaService.GetCantHorasTrabajadasProyectoPerfil(_idProyecto, perf.Idperfil);

                reportBody.CantidadHoraTrabajada = horasTrabajadas;
                reportBody.Perfil = perf.NombrePerfil;

                body.Add(reportBody);
            }

        }

        private void InformeHorasProyecto_Load(object sender, EventArgs e)
        {
            ReportParameter[] reportParameters = new ReportParameter[4];
            reportParameters[0] = new ReportParameter("nombreProyecto", proyecto.NombreProyecto);
            reportParameters[1] = new ReportParameter("horasOverbudget", _horasOverbudget.ToString());
            reportParameters[2] = new ReportParameter("horasAdeudadas", _horasAdeudadas.ToString());
            reportParameters[3] = new ReportParameter("fechaReporte", DateTime.Today.ToShortDateString());
            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            ReportDataSource dataSource1 = new ReportDataSource("DataSet1", body);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource1);

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EscritorioGestionProyectosLiquidaciones.Reportes.ReporteHoras.rdlc";
            this.reportViewer1.RefreshReport();
        }
    }
}
