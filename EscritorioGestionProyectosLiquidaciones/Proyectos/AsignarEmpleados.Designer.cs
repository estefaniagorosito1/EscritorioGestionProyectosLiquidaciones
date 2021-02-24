namespace EscritorioGestionProyectosLiquidaciones.Proyectos
{
    partial class AsignarEmpleados
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
            this.label2 = new System.Windows.Forms.Label();
            this.empleadosProyectoDataView = new System.Windows.Forms.DataGridView();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guardarBtn = new System.Windows.Forms.Button();
            this.volverBtn = new System.Windows.Forms.Button();
            this.empleadosDataView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.idempleadoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpleadoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoEmpleadoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosProyectoDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.empleadosProyectoDataView);
            this.panel1.Controls.Add(this.guardarBtn);
            this.panel1.Controls.Add(this.volverBtn);
            this.panel1.Controls.Add(this.empleadosDataView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 397);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Empleados asignados";
            // 
            // empleadosProyectoDataView
            // 
            this.empleadosProyectoDataView.AllowUserToAddRows = false;
            this.empleadosProyectoDataView.AllowUserToDeleteRows = false;
            this.empleadosProyectoDataView.AutoGenerateColumns = false;
            this.empleadosProyectoDataView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.empleadosProyectoDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empleadosProyectoDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idempleadoDataGridViewTextBoxColumn1,
            this.nombreEmpleadoDataGridViewTextBoxColumn1,
            this.apellidoEmpleadoDataGridViewTextBoxColumn1,
            this.Eliminar});
            this.empleadosProyectoDataView.DataSource = this.empleadoBindingSource;
            this.empleadosProyectoDataView.Location = new System.Drawing.Point(21, 228);
            this.empleadosProyectoDataView.Name = "empleadosProyectoDataView";
            this.empleadosProyectoDataView.ReadOnly = true;
            this.empleadosProyectoDataView.Size = new System.Drawing.Size(420, 120);
            this.empleadosProyectoDataView.TabIndex = 5;
            this.empleadosProyectoDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empleadosProyectoDataView_CellContentClick);
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataSource = typeof(EscritorioGestionProyectosLiquidaciones.Models.Empleado);
            // 
            // guardarBtn
            // 
            this.guardarBtn.Location = new System.Drawing.Point(103, 357);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(75, 23);
            this.guardarBtn.TabIndex = 3;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(22, 357);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(75, 23);
            this.volverBtn.TabIndex = 2;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // empleadosDataView
            // 
            this.empleadosDataView.AllowUserToAddRows = false;
            this.empleadosDataView.AllowUserToDeleteRows = false;
            this.empleadosDataView.AutoGenerateColumns = false;
            this.empleadosDataView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.empleadosDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empleadosDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idempleadoDataGridViewTextBoxColumn,
            this.nombreEmpleadoDataGridViewTextBoxColumn,
            this.apellidoEmpleadoDataGridViewTextBoxColumn,
            this.Asignar});
            this.empleadosDataView.DataSource = this.empleadoBindingSource;
            this.empleadosDataView.Location = new System.Drawing.Point(21, 47);
            this.empleadosDataView.Name = "empleadosDataView";
            this.empleadosDataView.Size = new System.Drawing.Size(420, 140);
            this.empleadosDataView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asignar empleados al proyecto";
            // 
            // idempleadoDataGridViewTextBoxColumn1
            // 
            this.idempleadoDataGridViewTextBoxColumn1.DataPropertyName = "Idempleado";
            this.idempleadoDataGridViewTextBoxColumn1.FillWeight = 35F;
            this.idempleadoDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idempleadoDataGridViewTextBoxColumn1.Name = "idempleadoDataGridViewTextBoxColumn1";
            this.idempleadoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idempleadoDataGridViewTextBoxColumn1.Width = 35;
            // 
            // nombreEmpleadoDataGridViewTextBoxColumn1
            // 
            this.nombreEmpleadoDataGridViewTextBoxColumn1.DataPropertyName = "NombreEmpleado";
            this.nombreEmpleadoDataGridViewTextBoxColumn1.FillWeight = 130F;
            this.nombreEmpleadoDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreEmpleadoDataGridViewTextBoxColumn1.Name = "nombreEmpleadoDataGridViewTextBoxColumn1";
            this.nombreEmpleadoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nombreEmpleadoDataGridViewTextBoxColumn1.Width = 130;
            // 
            // apellidoEmpleadoDataGridViewTextBoxColumn1
            // 
            this.apellidoEmpleadoDataGridViewTextBoxColumn1.DataPropertyName = "ApellidoEmpleado";
            this.apellidoEmpleadoDataGridViewTextBoxColumn1.FillWeight = 130F;
            this.apellidoEmpleadoDataGridViewTextBoxColumn1.HeaderText = "Apellido";
            this.apellidoEmpleadoDataGridViewTextBoxColumn1.Name = "apellidoEmpleadoDataGridViewTextBoxColumn1";
            this.apellidoEmpleadoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.apellidoEmpleadoDataGridViewTextBoxColumn1.Width = 130;
            // 
            // Eliminar
            // 
            this.Eliminar.FillWeight = 80F;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 80;
            // 
            // idempleadoDataGridViewTextBoxColumn
            // 
            this.idempleadoDataGridViewTextBoxColumn.DataPropertyName = "Idempleado";
            this.idempleadoDataGridViewTextBoxColumn.FillWeight = 35F;
            this.idempleadoDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idempleadoDataGridViewTextBoxColumn.Name = "idempleadoDataGridViewTextBoxColumn";
            this.idempleadoDataGridViewTextBoxColumn.Width = 35;
            // 
            // nombreEmpleadoDataGridViewTextBoxColumn
            // 
            this.nombreEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "NombreEmpleado";
            this.nombreEmpleadoDataGridViewTextBoxColumn.FillWeight = 130F;
            this.nombreEmpleadoDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreEmpleadoDataGridViewTextBoxColumn.Name = "nombreEmpleadoDataGridViewTextBoxColumn";
            this.nombreEmpleadoDataGridViewTextBoxColumn.Width = 130;
            // 
            // apellidoEmpleadoDataGridViewTextBoxColumn
            // 
            this.apellidoEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoEmpleado";
            this.apellidoEmpleadoDataGridViewTextBoxColumn.FillWeight = 130F;
            this.apellidoEmpleadoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoEmpleadoDataGridViewTextBoxColumn.Name = "apellidoEmpleadoDataGridViewTextBoxColumn";
            this.apellidoEmpleadoDataGridViewTextBoxColumn.Width = 130;
            // 
            // Asignar
            // 
            this.Asignar.FillWeight = 80F;
            this.Asignar.HeaderText = "Asignar";
            this.Asignar.Name = "Asignar";
            this.Asignar.Width = 80;
            // 
            // AsignarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AsignarEmpleados";
            this.Text = "Asignar empleados";
            this.Load += new System.EventHandler(this.AsignarEmpleados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosProyectoDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView empleadosDataView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private System.Windows.Forms.DataGridView empleadosProyectoDataView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempleadoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleadoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoEmpleadoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Asignar;
    }
}