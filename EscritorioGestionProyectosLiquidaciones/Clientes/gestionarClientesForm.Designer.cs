namespace EscritorioGestionProyectosLiquidaciones.Clientes
{
    partial class gestionarClientesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crearClienteBtn = new System.Windows.Forms.Button();
            this.volverBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clientesDataView = new System.Windows.Forms.DataGridView();
            this.Idcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditarBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.crearClienteBtn);
            this.panel1.Controls.Add(this.volverBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.clientesDataView);
            this.panel1.Location = new System.Drawing.Point(26, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 389);
            this.panel1.TabIndex = 0;
            // 
            // crearClienteBtn
            // 
            this.crearClienteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearClienteBtn.Location = new System.Drawing.Point(102, 349);
            this.crearClienteBtn.Name = "crearClienteBtn";
            this.crearClienteBtn.Size = new System.Drawing.Size(122, 23);
            this.crearClienteBtn.TabIndex = 4;
            this.crearClienteBtn.Text = "Crear nuevo cliente";
            this.crearClienteBtn.UseVisualStyleBackColor = true;
            this.crearClienteBtn.Click += new System.EventHandler(this.crearClienteBtn_Click);
            // 
            // volverBtn
            // 
            this.volverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverBtn.Location = new System.Drawing.Point(21, 349);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(75, 23);
            this.volverBtn.TabIndex = 3;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cree y modifique clientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de clientes";
            // 
            // clientesDataView
            // 
            this.clientesDataView.AllowUserToAddRows = false;
            this.clientesDataView.AllowUserToDeleteRows = false;
            this.clientesDataView.AutoGenerateColumns = false;
            this.clientesDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idcliente,
            this.nombreClienteDataGridViewTextBoxColumn,
            this.apellidoClienteDataGridViewTextBoxColumn,
            this.emailClienteDataGridViewTextBoxColumn,
            this.direccionClienteDataGridViewTextBoxColumn,
            this.telefonoClienteDataGridViewTextBoxColumn,
            this.EditarBtn,
            this.Eliminar});
            this.clientesDataView.DataSource = this.clienteBindingSource;
            this.clientesDataView.Location = new System.Drawing.Point(21, 83);
            this.clientesDataView.Name = "clientesDataView";
            this.clientesDataView.ReadOnly = true;
            this.clientesDataView.Size = new System.Drawing.Size(699, 250);
            this.clientesDataView.TabIndex = 0;
            this.clientesDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientesDataView_CellContentClick);
            // 
            // Idcliente
            // 
            this.Idcliente.DataPropertyName = "Idcliente";
            this.Idcliente.HeaderText = "Id";
            this.Idcliente.Name = "Idcliente";
            this.Idcliente.ReadOnly = true;
            this.Idcliente.Width = 35;
            // 
            // nombreClienteDataGridViewTextBoxColumn
            // 
            this.nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "NombreCliente";
            this.nombreClienteDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
            this.nombreClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoClienteDataGridViewTextBoxColumn
            // 
            this.apellidoClienteDataGridViewTextBoxColumn.DataPropertyName = "ApellidoCliente";
            this.apellidoClienteDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoClienteDataGridViewTextBoxColumn.Name = "apellidoClienteDataGridViewTextBoxColumn";
            this.apellidoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailClienteDataGridViewTextBoxColumn
            // 
            this.emailClienteDataGridViewTextBoxColumn.DataPropertyName = "EmailCliente";
            this.emailClienteDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailClienteDataGridViewTextBoxColumn.Name = "emailClienteDataGridViewTextBoxColumn";
            this.emailClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionClienteDataGridViewTextBoxColumn
            // 
            this.direccionClienteDataGridViewTextBoxColumn.DataPropertyName = "DireccionCliente";
            this.direccionClienteDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionClienteDataGridViewTextBoxColumn.Name = "direccionClienteDataGridViewTextBoxColumn";
            this.direccionClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoClienteDataGridViewTextBoxColumn
            // 
            this.telefonoClienteDataGridViewTextBoxColumn.DataPropertyName = "TelefonoCliente";
            this.telefonoClienteDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoClienteDataGridViewTextBoxColumn.Name = "telefonoClienteDataGridViewTextBoxColumn";
            this.telefonoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EditarBtn
            // 
            this.EditarBtn.FillWeight = 60F;
            this.EditarBtn.HeaderText = "";
            this.EditarBtn.Name = "EditarBtn";
            this.EditarBtn.ReadOnly = true;
            this.EditarBtn.Text = "Editar";
            this.EditarBtn.UseColumnTextForButtonValue = true;
            this.EditarBtn.Width = 60;
            // 
            // Eliminar
            // 
            this.Eliminar.FillWeight = 60F;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 60;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(EscritorioGestionProyectosLiquidaciones.Models.Cliente);
            // 
            // gestionarClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "gestionarClientesForm";
            this.Text = "Gestionar clientes";
            this.Load += new System.EventHandler(this.gestionarClientesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button crearClienteBtn;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView clientesDataView;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditarBtn;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}