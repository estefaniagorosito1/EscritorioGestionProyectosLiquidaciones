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

namespace EscritorioGestionProyectosLiquidaciones
{
    public partial class AsignarPerfilesForm : Form
    {
        private PerfilService _perfilService;
        private PerfilEmpleadoService _perfilEmpleadoService;
        private int IdEmpleado;

        public AsignarPerfilesForm()
        {
            InitializeComponent();
            _perfilService = new PerfilService();
            _perfilEmpleadoService = new PerfilEmpleadoService();
        }

        public void SetIdEmpleado(int IdEmpleado)
        {
            this.IdEmpleado = IdEmpleado;
        }

        public void LoadNombreEmpleado(string nombre)
        {
            nombreEmpleadoTxt.Text = nombre;
        }

        public void LoadPerfiles(List<Perfil> perfiles)
        {
            foreach (var item in perfiles)
            {
                if (item.NombrePerfil.Equals("Analista"))
                {
                    analistaCheck.Checked = true;
                }

                if (item.NombrePerfil.Equals("Desarrollador"))
                {
                    desarrolladorCheck.Checked = true;
                }

                if (item.NombrePerfil.Equals("Tester"))
                {
                    testerCheck.Checked = true;
                }

                if (item.NombrePerfil.Equals("Implementador"))
                {
                    implementadorCheck.Checked = true;
                }

                if (item.NombrePerfil.Equals("Capacitador"))
                {
                    capacitadorCheck.Checked = true;
                }

                if (item.NombrePerfil.Equals("Supervisor"))
                {
                    supervisorCheck.Checked = true;
                }
            }
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            List<Perfil> perfiles = _perfilService.FindPerfiles();
            List<Perfil> perfilesAAsignar = new List<Perfil>();
            List<PerfilEmpleado> perfilesEmpleado = new List<PerfilEmpleado>();
            Perfil perfil = null;

            if (analistaCheck.Checked)
            {
                perfil = perfiles.Find(p => p.NombrePerfil == "Analista");
                perfilesAAsignar.Add(perfil);
            }

            if (desarrolladorCheck.Checked)
            {
                perfil = perfiles.Find(p => p.NombrePerfil == "Desarrollador");
                perfilesAAsignar.Add(perfil);
            }

            if (testerCheck.Checked)
            {
                perfil = perfiles.Find(p => p.NombrePerfil == "Tester");
                perfilesAAsignar.Add(perfil);
            }

            if (implementadorCheck.Checked)
            {
                perfil = perfiles.Find(p => p.NombrePerfil == "Implementador");
                perfilesAAsignar.Add(perfil);
            }

            if (capacitadorCheck.Checked)
            {
                perfil = perfiles.Find(p => p.NombrePerfil == "Capacitador");
                perfilesAAsignar.Add(perfil);
            }

            if (supervisorCheck.Checked)
            {
                perfil = perfiles.Find(p => p.NombrePerfil == "Supervisor");
                perfilesAAsignar.Add(perfil);
            }

            foreach (var item in perfilesAAsignar)
            {
                Console.WriteLine(item.ToString());

                PerfilEmpleado perfilEmpleado = new PerfilEmpleado();
                perfilEmpleado.Idperfil = item.Idperfil;
                perfilEmpleado.Idempleado = IdEmpleado;

                Console.WriteLine(perfilEmpleado.Idperfil.ToString());
                perfilesEmpleado.Add(perfilEmpleado);
            }


            // _perfilEmpleadoService.AsignarPerfilesEmpleado(perfilesEmpleado);

        }
    }
}
