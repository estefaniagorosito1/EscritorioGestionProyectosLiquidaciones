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

namespace EscritorioGestionProyectosLiquidaciones.Clientes
{
    public partial class crearModificarClientesForm : Form
    {
        private ClienteService _clienteService;
        private LocalidadService _localidadService;
        private ProvinciaService _provinciaService;

        private int _idCliente;

        public crearModificarClientesForm()
        {
            InitializeComponent();
            _clienteService = new ClienteService();
            _localidadService = new LocalidadService();
            _provinciaService = new ProvinciaService();

            _idCliente = 0;
        }

        public void LoadCliente(Cliente cliente)
        {
            label1.Text = "Modificar cliente";
            _idCliente = cliente.Idcliente;

            var clienteDB = _clienteService.FindCliente(_idCliente);

            var provincia = _localidadService.FindProvinciaByLocalidad((long)clienteDB.LocalidadCliente);
            var localidad = _localidadService.FindLocalidad((long)clienteDB.LocalidadCliente);

            dropdownProvincias.DataSource = _provinciaService.FindProvincias();
            dropdownLocalidades.DataSource = _localidadService.FindLocalidadesProvincia(provincia.Idprovincia);

            nombreClienteTxt.Text = cliente.NombreCliente;
            apellidoClienteTxt.Text = cliente.ApellidoCliente;
            mailTxt.Text = cliente.EmailCliente;
            direccionTxt.Text = cliente.DireccionCliente;
            telefonoTxt.Text = cliente.TelefonoCliente;
            dropdownProvincias.SelectedValue = provincia.Idprovincia;
            dropdownLocalidades.SelectedValue = localidad.Idlocalidad;
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            if (Valid())
            {
                if (_idCliente == 0)
                {
                    cliente.NombreCliente = nombreClienteTxt.Text;
                    cliente.ApellidoCliente = apellidoClienteTxt.Text;
                    cliente.EmailCliente = mailTxt.Text;
                    cliente.TelefonoCliente = telefonoTxt.Text;
                    cliente.DireccionCliente = direccionTxt.Text;
                    cliente.LocalidadCliente = (long)dropdownLocalidades.SelectedValue;
                }
                else
                {
                    cliente = _clienteService.FindCliente(_idCliente);
                    cliente.NombreCliente = nombreClienteTxt.Text;
                    cliente.ApellidoCliente = apellidoClienteTxt.Text;
                    cliente.EmailCliente = mailTxt.Text;
                    cliente.TelefonoCliente = telefonoTxt.Text;
                    cliente.DireccionCliente = direccionTxt.Text;
                    cliente.LocalidadCliente = (long)dropdownLocalidades.SelectedValue;
                }

                _clienteService.Guardar(cliente);
                MessageBox.Show("Cliente guardado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (this.Owner != null)
                {
                    ((gestionarClientesForm)this.Owner).LoadClientes();
                }

                Close();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void crearModificarClientesForm_Load(object sender, EventArgs e)
        {
            if (_idCliente == 0)
            {
                var data = new List<Provincia>();

                var provincia = new Provincia
                {
                    Idprovincia = 0,
                    Descripcion = "Seleccione una provincia"
                };

                data.Add(provincia);
                data.AddRange(_provinciaService.FindProvincias());

                dropdownProvincias.DataSource = data;
            }
        }

        private void dropdownProvincias_SelectionChangeCommitted(object sender, EventArgs e)
        {
            long idProvincia = long.Parse(dropdownProvincias.SelectedValue.ToString());

            List<Localidad> data = new List<Localidad>();

            var localidad = new Localidad()
            {
                Idlocalidad = 0,
                Descripcion = "Seleccione una localidad"
            };

            data.Add(localidad);
            data.AddRange(_localidadService.FindLocalidadesProvincia(idProvincia));

            dropdownLocalidades.DataSource = data;
        }

        private bool Valid()
        {
            bool valid = false;

            if (nombreClienteTxt.Text != string.Empty && apellidoClienteTxt.Text != string.Empty
                && mailTxt.Text != string.Empty && direccionTxt.Text != string.Empty && telefonoTxt.Text != string.Empty
                && (long)dropdownProvincias.SelectedValue != 0 && (long)dropdownLocalidades.SelectedValue != 0)
            {
                valid = true;
            }

            return valid;
        }
    }
}
