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
        private RolService _rolService;

        private int idEmpleado;

        public crearModificarEmpleadoFrom()
        {
            InitializeComponent();

            _empleadoService = new EmpleadoService();
            _usuarioService = new UsuarioService();
            _localidadService = new LocalidadService();
            _provinciaService = new ProvinciaService();
            _perfilEmpleadoService = new PerfilEmpleadoService();
            _rolService = new RolService();

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

            provinciaSelected.DataSource = _provinciaService.FindProvincias();
            localidadSelected.DataSource = _localidadService.FindLocalidadesProvincia(provincia.Idprovincia);
            rolList.DataSource = _rolService.Find();

            nombreEmpleadoTxt.Text = empleado.NombreEmpleado;
            apellidoEmpleadoTxt.Text = empleado.ApellidoEmpleado;
            direccionTxt.Text = empleado.Direccion;
            dniTxt.Text = empleado.DniEmpleado.ToString();
            telefonoTxt.Text = empleado.Telefono;
            usuarioTxt.Text = usuario.NombreUsuario;
            contraseñaTxt.Text = usuario.PasswordUsuario;
            provinciaSelected.SelectedValue = provincia.Idprovincia;
            localidadSelected.SelectedValue = localidad.Idlocalidad;
            rolList.SelectedValue = usuario.Idrol;
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            Empleado empleado;
            Usuario usuario;

            if (ValidateForm())
            {
                // Estoy creando un empleado
                if (idEmpleado == 0)
                {
                    empleado = new Empleado
                    {
                        NombreEmpleado = nombreEmpleadoTxt.Text,
                        ApellidoEmpleado = apellidoEmpleadoTxt.Text,
                        DniEmpleado = long.Parse(dniTxt.Text),
                        Telefono = telefonoTxt.Text,
                        FechaIngresoEmpleado = DateTime.Today,
                        Direccion = direccionTxt.Text,
                        Localidad = long.Parse(localidadSelected.SelectedValue.ToString())
                    };

                    usuario = new Usuario
                    {
                        NombreUsuario = usuarioTxt.Text,
                        PasswordUsuario = contraseñaTxt.Text,
                        Idrol = (int) rolList.SelectedValue
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
                    usuario.Idrol = (int) rolList.SelectedValue;
                }

                try
                {
                    _empleadoService.Guardar(empleado);

                    if (usuario.Idempleado == 0)
                    {
                        // Busco el idEmpleado para poder crear el usuario
                        var empleadoDB = _empleadoService.FindEmpleadoDni((long)empleado.DniEmpleado);
                        usuario.Idempleado = empleadoDB.Idempleado;
                    }

                    _usuarioService.Guardar(usuario);

                    MessageBox.Show("Empleado guardado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Ha ocurrido un error", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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
            if (idEmpleado == 0)
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

                asignarBtn.Enabled = false;

                var roles = new List<Rol>();
                var rol = new Rol
                {
                    Idrol = 0,
                    DescripcionRol = "Seleccione un rol"
                };

                roles.Add(rol);
                roles.AddRange(_rolService.Find());

                rolList.DataSource = roles;

            }

        }

        private bool ValidateForm()
        {
            var valid = false;
            if (telefonoTxt.Text != string.Empty && direccionTxt.Text != string.Empty && nombreEmpleadoTxt.Text != string.Empty
                && dniTxt.Text != string.Empty && apellidoEmpleadoTxt.Text != string.Empty && usuarioTxt.Text != string.Empty
                && contraseñaTxt.Text != string.Empty)
            {
                valid = true;
            }

            if ((int) rolList.SelectedValue != 0)
            {
                valid = true;
            }

            if((long) localidadSelected.SelectedValue != 0)
            {
                valid = true;
            }

            return valid;
        }
    }
}
