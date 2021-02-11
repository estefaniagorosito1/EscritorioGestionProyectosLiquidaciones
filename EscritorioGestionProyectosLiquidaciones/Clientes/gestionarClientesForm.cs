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
        public gestionarClientesForm()
        {
            InitializeComponent();
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
