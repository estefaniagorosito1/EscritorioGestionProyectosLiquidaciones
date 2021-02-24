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
    public partial class gestionarEmpleadosForm : Form
    {
        private EmpleadoService _empleadoService;

        public gestionarEmpleadosForm()
        {
            InitializeComponent();
            _empleadoService = new EmpleadoService();
        }

        public void LoadEmpleados()
        {
            var empleados = _empleadoService.Find();
            empleadosDataView.DataSource = empleados;
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gestionarEmpleadosForm_Load(object sender, EventArgs e)
        {
            LoadEmpleados();
        }

        private void crearEmpleadoBtn_Click(object sender, EventArgs e)
        {
            crearModificarEmpleadoFrom crearModificarEmpleadoFrom = new crearModificarEmpleadoFrom();
            crearModificarEmpleadoFrom.Show(this);
        }

        private void empleadosDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)empleadosDataView.Rows[e.RowIndex].Cells[e.ColumnIndex];

                var IdEmpleado = int.Parse(empleadosDataView.Rows[e.RowIndex].Cells[0].Value.ToString());

                if (buttonCell.Value.ToString().Equals("Editar"))
                {
                    var empleado = _empleadoService.FindEmpleado(IdEmpleado);

                    crearModificarEmpleadoFrom crearModificarEmpleadoFrom = new crearModificarEmpleadoFrom();
                    crearModificarEmpleadoFrom.LoadEmpleado(new Empleado
                    {
                        Idempleado = IdEmpleado,
                        DniEmpleado = long.Parse(empleadosDataView.Rows[e.RowIndex].Cells[1].Value.ToString()),
                        NombreEmpleado = empleadosDataView.Rows[e.RowIndex].Cells[2].Value.ToString(),
                        ApellidoEmpleado = empleadosDataView.Rows[e.RowIndex].Cells[3].Value.ToString(),
                        Direccion = empleado.Direccion,
                        FechaIngresoEmpleado = empleado.FechaIngresoEmpleado,
                        Telefono = empleado.Telefono,
                    });

                    crearModificarEmpleadoFrom.Text = "Modificar empleado";
                    crearModificarEmpleadoFrom.Show(this);
                }
                else if (buttonCell.Value.ToString().Equals("Eliminar"))
                {
                    DialogResult result = MessageBox.Show("¿Está seguro de eliminar este empleado?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                    switch (result)
                    {
                        case DialogResult.OK:
                            _empleadoService.Eliminar(IdEmpleado);
                            MessageBox.Show("Empleado eliminado", "Éxito", MessageBoxButtons.OK);
                            LoadEmpleados();
                            break;
                        case DialogResult.Cancel:
                            break;
                        default:
                            break;
                    }
                }

            }
            catch (Exception)
            {
                // Cuando el usuario haga click en una celda que no es un botón
            }

        }
    }
}
