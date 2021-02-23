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
    public partial class gestionarClientesForm : Form
    {
        private ClienteService _clienteService;

        public gestionarClientesForm()
        {
            InitializeComponent();
            _clienteService = new ClienteService();
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gestionarClientesForm_Load(object sender, EventArgs e)
        {
            LoadClientes();
        }

        public void LoadClientes()
        {
            var clientes = _clienteService.Find();
            clientesDataView.DataSource = clientes;
        }

        private void clientesDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)clientesDataView.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (buttonCell.Value.ToString().Equals("Editar"))
                {
                    crearModificarClientesForm crearModificarClientesForm = new crearModificarClientesForm();
                    crearModificarClientesForm.LoadCliente(new Cliente
                    {
                        Idcliente = int.Parse(clientesDataView.Rows[e.RowIndex].Cells[0].Value.ToString()),
                        NombreCliente = clientesDataView.Rows[e.RowIndex].Cells[1].Value.ToString(),
                        ApellidoCliente = clientesDataView.Rows[e.RowIndex].Cells[2].Value.ToString(),
                        EmailCliente = clientesDataView.Rows[e.RowIndex].Cells[3].Value.ToString(),
                        DireccionCliente = clientesDataView.Rows[e.RowIndex].Cells[4].Value.ToString(),
                        TelefonoCliente = clientesDataView.Rows[e.RowIndex].Cells[5].Value.ToString()
                    });

                    crearModificarClientesForm.Text = "Modificar cliente";
                    crearModificarClientesForm.Show(this);
                }
                else if (buttonCell.Value.ToString().Equals("Eliminar"))
                {
                    DialogResult result = MessageBox.Show("¿Está seguro de eliminar este cliente?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                    switch (result)
                    {
                        case DialogResult.OK:
                            _clienteService.Eliminar(int.Parse(clientesDataView.Rows[e.RowIndex].Cells[0].Value.ToString()));
                            MessageBox.Show("Cliente eliminado", "Éxito", MessageBoxButtons.OK);
                            LoadClientes();
                            break;
                        case DialogResult.Cancel:
                            break;
                        default:
                            break;
                    }
                }

            }
            catch (InvalidCastException ex)
            {
                // Cuando el usuario haga click en una celda que no es un botón
            }
        }

        private void crearClienteBtn_Click(object sender, EventArgs e)
        {
            crearModificarClientesForm crearModificarClientesForm = new crearModificarClientesForm();
            crearModificarClientesForm.Show(this);
        }
    }
}

