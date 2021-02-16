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

namespace EscritorioGestionProyectosLiquidaciones.Empleados
{
    public partial class crearModificarEmpleadoFrom : Form
    {
        private EmpleadoService _empleadoService;
        private UsuarioService _usuarioService;
        private LocalidadService _localidadService;
        private ProvinciaService _provinciaService;
        private PerfilEmpleadoService _perfilEmpleadoService;

        private int idEmpleado;

        public crearModificarEmpleadoFrom()
        {
            InitializeComponent();

            _empleadoService = new EmpleadoService();
            _usuarioService = new UsuarioService();
            _localidadService = new LocalidadService();
            _provinciaService = new ProvinciaService();
            _perfilEmpleadoService = new PerfilEmpleadoService();

            idEmpleado = 0;
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadEmpleado(Empleado empleado)
        {
            label1.Text = "Modificar empleado";
            idEmpleado = empleado.Idempleado;

            var usuario = _usuarioService.FindUsuarioByIdEmpleado(idEmpleado);
            var empleadoDB = _empleadoService.FindEmpleado(idEmpleado);
            var provincia = _localidadService.FindProvinciaByLocalidad((long)empleadoDB.Localidad);
            var localidad = _localidadService.FindLocalidad((long)empleadoDB.Localidad);

            nombreEmpleadoTxt.Text = empleado.NombreEmpleado;
            apellidoEmpleadoTxt.Text = empleado.ApellidoEmpleado;
            direccionTxt.Text = empleado.Direccion;
            dniTxt.Text = empleado.DniEmpleado.ToString();
            telefonoTxt.Text = empleado.Telefono;
            usuarioTxt.Text = usuario.NombreUsuario;
            contraseñaTxt.Text = usuario.PasswordUsuario;
            provinciaSelected.SelectedIndex = provinciaSelected.FindStringExact(provincia.Descripcion);
            localidadSelected.SelectedItem = localidad;
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            Empleado empleado;
            Usuario usuario;

            // Estoy creando un empleado
            if (idEmpleado == 0)
            {
                empleado = new Empleado
                {
                    NombreEmpleado = nombreEmpleadoTxt.Text,
                    ApellidoEmpleado = apellidoEmpleadoTxt.Text,
                    DniEmpleado = long.Parse(dniTxt.Text),
                    Telefono = telefonoTxt.Text,
                    FechaIngresoEmpleado = new DateTime(),
                    Direccion = direccionTxt.Text,
                    Localidad = long.Parse(localidadSelected.SelectedValue.ToString())
                };

                usuario = new Usuario
                {
                    NombreUsuario = usuarioTxt.Text,
                    PasswordUsuario = contraseñaTxt.Text
                };

            }
            else
            {
                // Estoy modificando un empleado
                empleado = _empleadoService.FindEmpleado(idEmpleado);

                empleado.NombreEmpleado = nombreEmpleadoTxt.Text;
                empleado.ApellidoEmpleado = apellidoEmpleadoTxt.Text;
                empleado.DniEmpleado = long.Parse(dniTxt.Text);
                empleado.Telefono = telefonoTxt.Text;
                empleado.Direccion = direccionTxt.Text;
                empleado.Localidad = long.Parse(localidadSelected.SelectedValue.ToString());

                usuario = _usuarioService.FindUsuarioByIdEmpleado(idEmpleado);
                usuario.NombreUsuario = usuarioTxt.Text;
                usuario.PasswordUsuario = contraseñaTxt.Text;

            }

            //_usuarioService.Guardar(usuario);
            //_empleadoService.Guardar(empleado);
        }

        private void provinciaSelected_SelectionChangeCommitted(object sender, EventArgs e)
        {
            long idProvincia = long.Parse(provinciaSelected.SelectedValue.ToString());

            List<Localidad> data = new List<Localidad>();

            var localidad = new Localidad()
            {
                Idlocalidad = 0,
                Descripcion = "Seleccione una localidad"
            };

            data.Add(localidad);
            data.AddRange(_localidadService.FindLocalidadesProvincia(idProvincia));

            localidadSelected.DataSource = data;
        }

        private void provinciaSelected_Click(object sender, EventArgs e)
        {

        }

        private void asignarBtn_Click(object sender, EventArgs e)
        {
            AsignarPerfilesForm asignarPerfilesForm = new AsignarPerfilesForm();
            asignarPerfilesForm.LoadNombreEmpleado(nombreEmpleadoTxt.Text + " " + apellidoEmpleadoTxt.Text);

            var perfiles = _perfilEmpleadoService.FindPerfilesEmpleado(idEmpleado);
            asignarPerfilesForm.LoadPerfiles(perfiles);
            asignarPerfilesForm.SetIdEmpleado(idEmpleado);

            asignarPerfilesForm.ShowDialog();
        }

        private void crearModificarEmpleadoFrom_Load(object sender, EventArgs e)
        {
            var data = new List<Provincia>();

            var provincia = new Provincia
            {
                Idprovincia = 0,
                Descripcion = "Seleccione una provincia"
            };

            data.Add(provincia);
            data.AddRange(_provinciaService.FindProvincias());

            provinciaSelected.DataSource = data;
        }
    }
}
