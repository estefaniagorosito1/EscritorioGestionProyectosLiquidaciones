namespace EscritorioGestionProyectosLiquidaciones.Proyectos
{
    partial class gestionarProyectosForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.proyectosFinalizadosDataGrid = new System.Windows.Forms.DataGridView();
            this.proyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crearBtn = new System.Windows.Forms.Button();
            this.volverBtn = new System.Windows.Forms.Button();
            this.proyectosDataView = new System.Windows.Forms.DataGridView();
            this.idproyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoProyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioProyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Tareas = new System.Windows.Forms.DataGridViewButtonColumn();
            this.informeHoras = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idproyectoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProyectoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioProyectoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinProyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadisticas = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosFinalizadosDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.proyectosFinalizadosDataGrid);
            this.panel1.Controls.Add(this.crearBtn);
            this.panel1.Controls.Add(this.volverBtn);
            this.panel1.Controls.Add(this.proyectosDataView);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(27, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 389);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Proyectos finalizados";
            // 
            // proyectosFinalizadosDataGrid
            // 
            this.proyectosFinalizadosDataGrid.AllowUserToAddRows = false;
            this.proyectosFinalizadosDataGrid.AllowUserToDeleteRows = false;
            this.proyectosFinalizadosDataGrid.AutoGenerateColumns = false;
            this.proyectosFinalizadosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proyectosFinalizadosDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproyectoDataGridViewTextBoxColumn1,
            this.nombreProyectoDataGridViewTextBoxColumn1,
            this.descripcionDataGridViewTextBoxColumn1,
            this.fechaInicioProyectoDataGridViewTextBoxColumn1,
            this.fechaFinProyectoDataGridViewTextBoxColumn,
            this.estadisticas});
            this.proyectosFinalizadosDataGrid.DataSource = this.proyectoBindingSource;
            this.proyectosFinalizadosDataGrid.Location = new System.Drawing.Point(21, 231);
            this.proyectosFinalizadosDataGrid.Name = "proyectosFinalizadosDataGrid";
            this.proyectosFinalizadosDataGrid.ReadOnly = true;
            this.proyectosFinalizadosDataGrid.Size = new System.Drawing.Size(699, 111);
            this.proyectosFinalizadosDataGrid.TabIndex = 5;
            this.proyectosFinalizadosDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.proyectosFinalizadosDataGrid_CellContentClick);
            // 
            // proyectoBindingSource
            // 
            this.proyectoBindingSource.DataSource = typeof(EscritorioGestionProyectosLiquidaciones.Models.Proyecto);
            // 
            // crearBtn
            // 
            this.crearBtn.Location = new System.Drawing.Point(102, 355);
            this.crearBtn.Name = "crearBtn";
            this.crearBtn.Size = new System.Drawing.Size(126, 23);
            this.crearBtn.TabIndex = 4;
            this.crearBtn.Text = "Crear nuevo proyecto";
            this.crearBtn.UseVisualStyleBackColor = true;
            this.crearBtn.Click += new System.EventHandler(this.crearBtn_Click);
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(21, 355);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(75, 23);
            this.volverBtn.TabIndex = 3;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // proyectosDataView
            // 
            this.proyectosDataView.AllowUserToAddRows = false;
            this.proyectosDataView.AllowUserToDeleteRows = false;
            this.proyectosDataView.AutoGenerateColumns = false;
            this.proyectosDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proyectosDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproyectoDataGridViewTextBoxColumn,
            this.nombreProyectoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.estadoProyectoDataGridViewTextBoxColumn,
            this.fechaInicioProyectoDataGridViewTextBoxColumn,
            this.Editar,
            this.Eliminar,
            this.Tareas,
            this.informeHoras});
            this.proyectosDataView.DataSource = this.proyectoBindingSource;
            this.proyectosDataView.Location = new System.Drawing.Point(21, 73);
            this.proyectosDataView.Name = "proyectosDataView";
            this.proyectosDataView.ReadOnly = true;
            this.proyectosDataView.Size = new System.Drawing.Size(699, 114);
            this.proyectosDataView.TabIndex = 2;
            this.proyectosDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.proyectosDataView_CellContentClick);
            // 
            // idproyectoDataGridViewTextBoxColumn
            // 
            this.idproyectoDataGridViewTextBoxColumn.DataPropertyName = "Idproyecto";
            this.idproyectoDataGridViewTextBoxColumn.FillWeight = 30F;
            this.idproyectoDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idproyectoDataGridViewTextBoxColumn.Name = "idproyectoDataGridViewTextBoxColumn";
            this.idproyectoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idproyectoDataGridViewTextBoxColumn.Width = 30;
            // 
            // nombreProyectoDataGridViewTextBoxColumn
            // 
            this.nombreProyectoDataGridViewTextBoxColumn.DataPropertyName = "NombreProyecto";
            this.nombreProyectoDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreProyectoDataGridViewTextBoxColumn.Name = "nombreProyectoDataGridViewTextBoxColumn";
            this.nombreProyectoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoProyectoDataGridViewTextBoxColumn
            // 
            this.estadoProyectoDataGridViewTextBoxColumn.DataPropertyName = "EstadoProyecto";
            this.estadoProyectoDataGridViewTextBoxColumn.FillWeight = 90F;
            this.estadoProyectoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoProyectoDataGridViewTextBoxColumn.Name = "estadoProyectoDataGridViewTextBoxColumn";
            this.estadoProyectoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoProyectoDataGridViewTextBoxColumn.Width = 90;
            // 
            // fechaInicioProyectoDataGridViewTextBoxColumn
            // 
            this.fechaInicioProyectoDataGridViewTextBoxColumn.DataPropertyName = "FechaInicioProyecto";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.fechaInicioProyectoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.fechaInicioProyectoDataGridViewTextBoxColumn.HeaderText = "Fecha Inicio";
            this.fechaInicioProyectoDataGridViewTextBoxColumn.Name = "fechaInicioProyectoDataGridViewTextBoxColumn";
            this.fechaInicioProyectoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.FillWeight = 57F;
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 57;
            // 
            // Eliminar
            // 
            this.Eliminar.FillWeight = 57F;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 57;
            // 
            // Tareas
            // 
            this.Tareas.FillWeight = 62F;
            this.Tareas.HeaderText = "";
            this.Tareas.Name = "Tareas";
            this.Tareas.ReadOnly = true;
            this.Tareas.Text = "Ver tareas";
            this.Tareas.UseColumnTextForButtonValue = true;
            this.Tareas.Width = 62;
            // 
            // informeHoras
            // 
            this.informeHoras.FillWeight = 60F;
            this.informeHoras.HeaderText = "";
            this.informeHoras.Name = "informeHoras";
            this.informeHoras.ReadOnly = true;
            this.informeHoras.Text = "Informe";
            this.informeHoras.ToolTipText = "Ver informe de horas del proyecto";
            this.informeHoras.UseColumnTextForButtonValue = true;
            this.informeHoras.Width = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "¿Vas a modificar o crear un nuevo proyecto?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de proyectos";
            // 
            // idproyectoDataGridViewTextBoxColumn1
            // 
            this.idproyectoDataGridViewTextBoxColumn1.DataPropertyName = "Idproyecto";
            this.idproyectoDataGridViewTextBoxColumn1.FillWeight = 30F;
            this.idproyectoDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idproyectoDataGridViewTextBoxColumn1.Name = "idproyectoDataGridViewTextBoxColumn1";
            this.idproyectoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idproyectoDataGridViewTextBoxColumn1.Width = 30;
            // 
            // nombreProyectoDataGridViewTextBoxColumn1
            // 
            this.nombreProyectoDataGridViewTextBoxColumn1.DataPropertyName = "NombreProyecto";
            this.nombreProyectoDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreProyectoDataGridViewTextBoxColumn1.Name = "nombreProyectoDataGridViewTextBoxColumn1";
            this.nombreProyectoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn1
            // 
            this.descripcionDataGridViewTextBoxColumn1.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn1.FillWeight = 224F;
            this.descripcionDataGridViewTextBoxColumn1.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn1.Name = "descripcionDataGridViewTextBoxColumn1";
            this.descripcionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn1.Width = 224;
            // 
            // fechaInicioProyectoDataGridViewTextBoxColumn1
            // 
            this.fechaInicioProyectoDataGridViewTextBoxColumn1.DataPropertyName = "FechaInicioProyecto";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.fechaInicioProyectoDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.fechaInicioProyectoDataGridViewTextBoxColumn1.HeaderText = "Fecha Inicio";
            this.fechaInicioProyectoDataGridViewTextBoxColumn1.Name = "fechaInicioProyectoDataGridViewTextBoxColumn1";
            this.fechaInicioProyectoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fechaFinProyectoDataGridViewTextBoxColumn
            // 
            this.fechaFinProyectoDataGridViewTextBoxColumn.DataPropertyName = "FechaFinProyecto";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.fechaFinProyectoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.fechaFinProyectoDataGridViewTextBoxColumn.HeaderText = "Fecha Fin";
            this.fechaFinProyectoDataGridViewTextBoxColumn.Name = "fechaFinProyectoDataGridViewTextBoxColumn";
            this.fechaFinProyectoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadisticas
            // 
            this.estadisticas.HeaderText = "";
            this.estadisticas.Name = "estadisticas";
            this.estadisticas.ReadOnly = true;
            this.estadisticas.Text = "Estadísticas";
            this.estadisticas.UseColumnTextForButtonValue = true;
            // 
            // gestionarProyectosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "gestionarProyectosForm";
            this.Text = "Gestionar proyectos";
            this.Load += new System.EventHandler(this.gestionarProyectosForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosFinalizadosDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectosDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView proyectosDataView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button crearBtn;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.BindingSource proyectoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoProyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioProyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn Tareas;
        private System.Windows.Forms.DataGridViewButtonColumn informeHoras;
        private System.Windows.Forms.DataGridView proyectosFinalizadosDataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproyectoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProyectoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioProyectoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinProyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn estadisticas;
    }
}