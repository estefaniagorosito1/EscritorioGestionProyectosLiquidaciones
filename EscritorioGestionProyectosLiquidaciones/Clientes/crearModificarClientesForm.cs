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

        public crearModificarClientesForm()
        {
            InitializeComponent();
            _clienteService = new ClienteService();
            _localidadService = new LocalidadService();
            _provinciaService = new ProvinciaService();
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.NombreCliente = nombreClienteTxt.Text;
            cliente.ApellidoCliente = apellidoClienteTxt.Text;
            cliente.EmailCliente = mailTxt.Text;
            cliente.TelefonoCliente = telefonoTxt.Text;
            cliente.DireccionCliente = direccionTxt.Text;
            cliente.LocalidadCliente = (dropdownLocalidades.SelectedValue as Localidad).Idlocalidad;

            _clienteService.Guardar(cliente);
        }

        public void LoadCliente(Cliente cliente)
        {
            label1.Text = "Modificar cliente";

            nombreClienteTxt.Text = cliente.NombreCliente;
            apellidoClienteTxt.Text = cliente.ApellidoCliente;
            mailTxt.Text = cliente.EmailCliente;
            direccionTxt.Text = cliente.DireccionCliente;
            telefonoTxt.Text = cliente.TelefonoCliente;
            // dropdownLocalidades.SelectedValue = cliente.LocalidadClienteNavigation;
            // dropdownProvincias.SelectedValue = cliente.LocalidadClienteNavigation.IdprovinciaNavigation;
        }
    }
}
