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
            this.nombreProyecto = new System.Windows.Forms.Label();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.volverBtn = new System.Windows.Forms.Button();
            this.empleadosDataView = new System.Windows.Forms.DataGridView();
            this.idempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.nombreProyecto);
            this.panel1.Controls.Add(this.guardarBtn);
            this.panel1.Controls.Add(this.volverBtn);
            this.panel1.Controls.Add(this.empleadosDataView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 397);
            this.panel1.TabIndex = 0;
            // 
            // nombreProyecto
            // 
            this.nombreProyecto.AutoSize = true;
            this.nombreProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreProyecto.Location = new System.Drawing.Point(235, 30);
            this.nombreProyecto.Name = "nombreProyecto";
            this.nombreProyecto.Size = new System.Drawing.Size(0, 17);
            this.nombreProyecto.TabIndex = 4;
            // 
            // guardarBtn
            // 
            this.guardarBtn.Location = new System.Drawing.Point(102, 348);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(75, 23);
            this.guardarBtn.TabIndex = 3;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(21, 348);
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
            this.empleadosDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empleadosDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idempleadoDataGridViewTextBoxColumn,
            this.nombreEmpleadoDataGridViewTextBoxColumn,
            this.apellidoEmpleadoDataGridViewTextBoxColumn,
            this.Asignar});
            this.empleadosDataView.DataSource = this.empleadoBindingSource;
            this.empleadosDataView.Location = new System.Drawing.Point(53, 73);
            this.empleadosDataView.Name = "empleadosDataView";
            this.empleadosDataView.ReadOnly = true;
            this.empleadosDataView.Size = new System.Drawing.Size(407, 241);
            this.empleadosDataView.TabIndex = 1;
            // 
            // idempleadoDataGridViewTextBoxColumn
            // 
            this.idempleadoDataGridViewTextBoxColumn.DataPropertyName = "Idempleado";
            this.idempleadoDataGridViewTextBoxColumn.FillWeight = 35F;
            this.idempleadoDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idempleadoDataGridViewTextBoxColumn.Name = "idempleadoDataGridViewTextBoxColumn";
            this.idempleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idempleadoDataGridViewTextBoxColumn.Width = 35;
            // 
            // nombreEmpleadoDataGridViewTextBoxColumn
            // 
            this.nombreEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "NombreEmpleado";
            this.nombreEmpleadoDataGridViewTextBoxColumn.FillWeight = 130F;
            this.nombreEmpleadoDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreEmpleadoDataGridViewTextBoxColumn.Name = "nombreEmpleadoDataGridViewTextBoxColumn";
            this.nombreEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreEmpleadoDataGridViewTextBoxColumn.Width = 130;
            // 
            // apellidoEmpleadoDataGridViewTextBoxColumn
            // 
            this.apellidoEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoEmpleado";
            this.apellidoEmpleadoDataGridViewTextBoxColumn.FillWeight = 130F;
            this.apellidoEmpleadoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoEmpleadoDataGridViewTextBoxColumn.Name = "apellidoEmpleadoDataGridViewTextBoxColumn";
            this.apellidoEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoEmpleadoDataGridViewTextBoxColumn.Width = 130;
            // 
            // Asignar
            // 
            this.Asignar.FillWeight = 68F;
            this.Asignar.HeaderText = "Asignar";
            this.Asignar.Name = "Asignar";
            this.Asignar.ReadOnly = true;
            this.Asignar.Width = 68;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataSource = typeof(EscritorioGestionProyectosLiquidaciones.Models.Empleado);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asignar empleados al proyecto: ";
            // 
            // AsignarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AsignarEmpleados";
            this.Text = "Asignar empleados";
            this.Load += new System.EventHandler(this.AsignarEmpleados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView empleadosDataView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Label nombreProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Asignar;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
    }
}