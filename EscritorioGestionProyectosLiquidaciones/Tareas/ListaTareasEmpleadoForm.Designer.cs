namespace EscritorioGestionProyectosLiquidaciones.Tareas
{
    partial class ListaTareasEmpleadoForm
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
            this.tareasEmpleadoDataGrid = new System.Windows.Forms.DataGridView();
            this.tareaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareasFinalizadasDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.idtareaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionTareaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasEstimadasTareaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasOverbudgetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasTrabajadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregarHoras = new System.Windows.Forms.DataGridViewButtonColumn();
            this.finalizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idtareaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionTareaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasEstimadasTareaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasOverbudgetDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasTrabajadasDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tareasEmpleadoDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareasFinalizadasDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tareasFinalizadasDataGrid);
            this.panel1.Controls.Add(this.tareasEmpleadoDataGrid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 401);
            this.panel1.TabIndex = 0;
            // 
            // tareasEmpleadoDataGrid
            // 
            this.tareasEmpleadoDataGrid.AllowUserToAddRows = false;
            this.tareasEmpleadoDataGrid.AllowUserToDeleteRows = false;
            this.tareasEmpleadoDataGrid.AutoGenerateColumns = false;
            this.tareasEmpleadoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tareasEmpleadoDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtareaDataGridViewTextBoxColumn,
            this.descripcionTareaDataGridViewTextBoxColumn,
            this.horasEstimadasTareaDataGridViewTextBoxColumn,
            this.horasOverbudgetDataGridViewTextBoxColumn,
            this.horasTrabajadasDataGridViewTextBoxColumn,
            this.agregarHoras,
            this.finalizar});
            this.tareasEmpleadoDataGrid.DataSource = this.tareaBindingSource1;
            this.tareasEmpleadoDataGrid.Location = new System.Drawing.Point(22, 53);
            this.tareasEmpleadoDataGrid.Name = "tareasEmpleadoDataGrid";
            this.tareasEmpleadoDataGrid.ReadOnly = true;
            this.tareasEmpleadoDataGrid.Size = new System.Drawing.Size(715, 128);
            this.tareasEmpleadoDataGrid.TabIndex = 1;
            this.tareasEmpleadoDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tareasEmpleadoDataGrid_CellContentClick);
            // 
            // tareaBindingSource1
            // 
            this.tareaBindingSource1.DataSource = typeof(EscritorioGestionProyectosLiquidaciones.Models.Tarea);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tareas del empleado";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdproyectoNavigation";
            this.dataGridViewTextBoxColumn1.FillWeight = 90F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Proyecto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdproyectoNavigation";
            this.dataGridViewTextBoxColumn2.FillWeight = 90F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Proyecto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // tareasFinalizadasDataGrid
            // 
            this.tareasFinalizadasDataGrid.AutoGenerateColumns = false;
            this.tareasFinalizadasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tareasFinalizadasDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtareaDataGridViewTextBoxColumn1,
            this.descripcionTareaDataGridViewTextBoxColumn1,
            this.horasEstimadasTareaDataGridViewTextBoxColumn1,
            this.horasOverbudgetDataGridViewTextBoxColumn1,
            this.horasTrabajadasDataGridViewTextBoxColumn1});
            this.tareasFinalizadasDataGrid.DataSource = this.tareaBindingSource1;
            this.tareasFinalizadasDataGrid.Location = new System.Drawing.Point(22, 232);
            this.tareasFinalizadasDataGrid.Name = "tareasFinalizadasDataGrid";
            this.tareasFinalizadasDataGrid.Size = new System.Drawing.Size(715, 150);
            this.tareasFinalizadasDataGrid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tareas finalizadas";
            // 
            // idtareaDataGridViewTextBoxColumn
            // 
            this.idtareaDataGridViewTextBoxColumn.DataPropertyName = "Idtarea";
            this.idtareaDataGridViewTextBoxColumn.FillWeight = 30F;
            this.idtareaDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idtareaDataGridViewTextBoxColumn.Name = "idtareaDataGridViewTextBoxColumn";
            this.idtareaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtareaDataGridViewTextBoxColumn.Width = 30;
            // 
            // descripcionTareaDataGridViewTextBoxColumn
            // 
            this.descripcionTareaDataGridViewTextBoxColumn.DataPropertyName = "DescripcionTarea";
            this.descripcionTareaDataGridViewTextBoxColumn.FillWeight = 190F;
            this.descripcionTareaDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionTareaDataGridViewTextBoxColumn.Name = "descripcionTareaDataGridViewTextBoxColumn";
            this.descripcionTareaDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionTareaDataGridViewTextBoxColumn.Width = 190;
            // 
            // horasEstimadasTareaDataGridViewTextBoxColumn
            // 
            this.horasEstimadasTareaDataGridViewTextBoxColumn.DataPropertyName = "HorasEstimadasTarea";
            this.horasEstimadasTareaDataGridViewTextBoxColumn.FillWeight = 70F;
            this.horasEstimadasTareaDataGridViewTextBoxColumn.HeaderText = "Horas estimadas";
            this.horasEstimadasTareaDataGridViewTextBoxColumn.Name = "horasEstimadasTareaDataGridViewTextBoxColumn";
            this.horasEstimadasTareaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horasEstimadasTareaDataGridViewTextBoxColumn.Width = 70;
            // 
            // horasOverbudgetDataGridViewTextBoxColumn
            // 
            this.horasOverbudgetDataGridViewTextBoxColumn.DataPropertyName = "HorasOverbudget";
            this.horasOverbudgetDataGridViewTextBoxColumn.FillWeight = 70F;
            this.horasOverbudgetDataGridViewTextBoxColumn.HeaderText = "Horas overbudget";
            this.horasOverbudgetDataGridViewTextBoxColumn.Name = "horasOverbudgetDataGridViewTextBoxColumn";
            this.horasOverbudgetDataGridViewTextBoxColumn.ReadOnly = true;
            this.horasOverbudgetDataGridViewTextBoxColumn.Width = 70;
            // 
            // horasTrabajadasDataGridViewTextBoxColumn
            // 
            this.horasTrabajadasDataGridViewTextBoxColumn.DataPropertyName = "HorasTrabajadas";
            this.horasTrabajadasDataGridViewTextBoxColumn.FillWeight = 70F;
            this.horasTrabajadasDataGridViewTextBoxColumn.HeaderText = "Horas trabajadas";
            this.horasTrabajadasDataGridViewTextBoxColumn.Name = "horasTrabajadasDataGridViewTextBoxColumn";
            this.horasTrabajadasDataGridViewTextBoxColumn.ReadOnly = true;
            this.horasTrabajadasDataGridViewTextBoxColumn.Width = 70;
            // 
            // agregarHoras
            // 
            this.agregarHoras.FillWeight = 90F;
            this.agregarHoras.HeaderText = "";
            this.agregarHoras.Name = "agregarHoras";
            this.agregarHoras.ReadOnly = true;
            this.agregarHoras.Text = "Agregar horas";
            this.agregarHoras.UseColumnTextForButtonValue = true;
            this.agregarHoras.Width = 90;
            // 
            // finalizar
            // 
            this.finalizar.FillWeight = 90F;
            this.finalizar.HeaderText = "";
            this.finalizar.Name = "finalizar";
            this.finalizar.ReadOnly = true;
            this.finalizar.Text = "Finalizar";
            this.finalizar.UseColumnTextForButtonValue = true;
            this.finalizar.Width = 90;
            // 
            // idtareaDataGridViewTextBoxColumn1
            // 
            this.idtareaDataGridViewTextBoxColumn1.DataPropertyName = "Idtarea";
            this.idtareaDataGridViewTextBoxColumn1.FillWeight = 30F;
            this.idtareaDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idtareaDataGridViewTextBoxColumn1.Name = "idtareaDataGridViewTextBoxColumn1";
            this.idtareaDataGridViewTextBoxColumn1.Width = 30;
            // 
            // descripcionTareaDataGridViewTextBoxColumn1
            // 
            this.descripcionTareaDataGridViewTextBoxColumn1.DataPropertyName = "DescripcionTarea";
            this.descripcionTareaDataGridViewTextBoxColumn1.FillWeight = 200F;
            this.descripcionTareaDataGridViewTextBoxColumn1.HeaderText = "Descripcion";
            this.descripcionTareaDataGridViewTextBoxColumn1.Name = "descripcionTareaDataGridViewTextBoxColumn1";
            this.descripcionTareaDataGridViewTextBoxColumn1.Width = 200;
            // 
            // horasEstimadasTareaDataGridViewTextBoxColumn1
            // 
            this.horasEstimadasTareaDataGridViewTextBoxColumn1.DataPropertyName = "HorasEstimadasTarea";
            this.horasEstimadasTareaDataGridViewTextBoxColumn1.FillWeight = 120F;
            this.horasEstimadasTareaDataGridViewTextBoxColumn1.HeaderText = "Horas estimadas";
            this.horasEstimadasTareaDataGridViewTextBoxColumn1.Name = "horasEstimadasTareaDataGridViewTextBoxColumn1";
            this.horasEstimadasTareaDataGridViewTextBoxColumn1.Width = 120;
            // 
            // horasOverbudgetDataGridViewTextBoxColumn1
            // 
            this.horasOverbudgetDataGridViewTextBoxColumn1.DataPropertyName = "HorasOverbudget";
            this.horasOverbudgetDataGridViewTextBoxColumn1.FillWeight = 120F;
            this.horasOverbudgetDataGridViewTextBoxColumn1.HeaderText = "Horas overbudget";
            this.horasOverbudgetDataGridViewTextBoxColumn1.Name = "horasOverbudgetDataGridViewTextBoxColumn1";
            this.horasOverbudgetDataGridViewTextBoxColumn1.Width = 120;
            // 
            // horasTrabajadasDataGridViewTextBoxColumn1
            // 
            this.horasTrabajadasDataGridViewTextBoxColumn1.DataPropertyName = "HorasTrabajadas";
            this.horasTrabajadasDataGridViewTextBoxColumn1.FillWeight = 120F;
            this.horasTrabajadasDataGridViewTextBoxColumn1.HeaderText = "Horas trabajadas";
            this.horasTrabajadasDataGridViewTextBoxColumn1.Name = "horasTrabajadasDataGridViewTextBoxColumn1";
            this.horasTrabajadasDataGridViewTextBoxColumn1.Width = 120;
            // 
            // ListaTareasEmpleadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ListaTareasEmpleadoForm";
            this.Text = "Mis tareas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tareasEmpleadoDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareasFinalizadasDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tareasEmpleadoDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tareaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tareasFinalizadasDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtareaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionTareaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasEstimadasTareaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasOverbudgetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasTrabajadasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn agregarHoras;
        private System.Windows.Forms.DataGridViewButtonColumn finalizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtareaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionTareaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasEstimadasTareaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasOverbudgetDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasTrabajadasDataGridViewTextBoxColumn1;
    }
}