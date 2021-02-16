namespace EscritorioGestionProyectosLiquidaciones.Empleados
{
    partial class gestionarEmpleadosForm
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
            this.crearEmpleadoBtn = new System.Windows.Forms.Button();
            this.volverBtn = new System.Windows.Forms.Button();
            this.empleadosDataView = new System.Windows.Forms.DataGridView();
            this.idempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngresoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.crearEmpleadoBtn);
            this.panel1.Controls.Add(this.volverBtn);
            this.panel1.Controls.Add(this.empleadosDataView);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 389);
            this.panel1.TabIndex = 0;
            // 
            // crearEmpleadoBtn
            // 
            this.crearEmpleadoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearEmpleadoBtn.Location = new System.Drawing.Point(133, 339);
            this.crearEmpleadoBtn.Name = "crearEmpleadoBtn";
            this.crearEmpleadoBtn.Size = new System.Drawing.Size(121, 23);
            this.crearEmpleadoBtn.TabIndex = 4;
            this.crearEmpleadoBtn.Text = "Crear empleado";
            this.crearEmpleadoBtn.UseVisualStyleBackColor = true;
            this.crearEmpleadoBtn.Click += new System.EventHandler(this.crearEmpleadoBtn_Click);
            // 
            // volverBtn
            // 
            this.volverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverBtn.Location = new System.Drawing.Point(28, 339);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(99, 23);
            this.volverBtn.TabIndex = 3;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // empleadosDataView
            // 
            this.empleadosDataView.AllowUserToAddRows = false;
            this.empleadosDataView.AllowUserToDeleteRows = false;
            this.empleadosDataView.AutoGenerateColumns = false;
            this.empleadosDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empleadosDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idempleadoDataGridViewTextBoxColumn,
            this.dniEmpleadoDataGridViewTextBoxColumn,
            this.nombreEmpleadoDataGridViewTextBoxColumn,
            this.apellidoEmpleadoDataGridViewTextBoxColumn,
            this.FechaIngresoEmpleado,
            this.Editar,
            this.Eliminar});
            this.empleadosDataView.DataSource = this.empleadoBindingSource;
            this.empleadosDataView.Location = new System.Drawing.Point(28, 100);
            this.empleadosDataView.Name = "empleadosDataView";
            this.empleadosDataView.ReadOnly = true;
            this.empleadosDataView.Size = new System.Drawing.Size(683, 217);
            this.empleadosDataView.TabIndex = 2;
            this.empleadosDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empleadosDataView_CellContentClick);
            // 
            // idempleadoDataGridViewTextBoxColumn
            // 
            this.idempleadoDataGridViewTextBoxColumn.DataPropertyName = "Idempleado";
            this.idempleadoDataGridViewTextBoxColumn.FillWeight = 40F;
            this.idempleadoDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idempleadoDataGridViewTextBoxColumn.Name = "idempleadoDataGridViewTextBoxColumn";
            this.idempleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idempleadoDataGridViewTextBoxColumn.Width = 40;
            // 
            // dniEmpleadoDataGridViewTextBoxColumn
            // 
            this.dniEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "DniEmpleado";
            this.dniEmpleadoDataGridViewTextBoxColumn.HeaderText = "Dni";
            this.dniEmpleadoDataGridViewTextBoxColumn.Name = "dniEmpleadoDataGridViewTextBoxColumn";
            this.dniEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreEmpleadoDataGridViewTextBoxColumn
            // 
            this.nombreEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "NombreEmpleado";
            this.nombreEmpleadoDataGridViewTextBoxColumn.FillWeight = 120F;
            this.nombreEmpleadoDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreEmpleadoDataGridViewTextBoxColumn.Name = "nombreEmpleadoDataGridViewTextBoxColumn";
            this.nombreEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreEmpleadoDataGridViewTextBoxColumn.Width = 120;
            // 
            // apellidoEmpleadoDataGridViewTextBoxColumn
            // 
            this.apellidoEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoEmpleado";
            this.apellidoEmpleadoDataGridViewTextBoxColumn.FillWeight = 120F;
            this.apellidoEmpleadoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoEmpleadoDataGridViewTextBoxColumn.Name = "apellidoEmpleadoDataGridViewTextBoxColumn";
            this.apellidoEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoEmpleadoDataGridViewTextBoxColumn.Width = 120;
            // 
            // FechaIngresoEmpleado
            // 
            this.FechaIngresoEmpleado.DataPropertyName = "FechaIngresoEmpleado";
            this.FechaIngresoEmpleado.FillWeight = 120F;
            this.FechaIngresoEmpleado.HeaderText = "Fecha de ingreso";
            this.FechaIngresoEmpleado.Name = "FechaIngresoEmpleado";
            this.FechaIngresoEmpleado.ReadOnly = true;
            this.FechaIngresoEmpleado.Width = 120;
            // 
            // Editar
            // 
            this.Editar.FillWeight = 70F;
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 70;
            // 
            // Eliminar
            // 
            this.Eliminar.FillWeight = 70F;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 70;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataSource = typeof(EscritorioGestionProyectosLiquidaciones.Models.Empleado);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(25, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cree y modifique empleados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de empleados";
            // 
            // gestionarEmpleadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "gestionarEmpleadosForm";
            this.Text = "Gestionar Empleados";
            this.Load += new System.EventHandler(this.gestionarEmpleadosForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button crearEmpleadoBtn;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.DataGridView empleadosDataView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngresoEmpleado;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}