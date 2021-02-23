namespace EscritorioGestionProyectosLiquidaciones.Tareas
{
    partial class TareasFinalizadasForm
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
            this.volverBtn = new System.Windows.Forms.Button();
            this.nombreProyecto = new System.Windows.Forms.Label();
            this.tareasFinalizadasDataGrid = new System.Windows.Forms.DataGridView();
            this.idtareaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionTareaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasEstimadasTareaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasOverbudgetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasTrabajadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tareasFinalizadasDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.volverBtn);
            this.panel1.Controls.Add(this.nombreProyecto);
            this.panel1.Controls.Add(this.tareasFinalizadasDataGrid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(27, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 389);
            this.panel1.TabIndex = 0;
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(22, 350);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(75, 23);
            this.volverBtn.TabIndex = 4;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // nombreProyecto
            // 
            this.nombreProyecto.AutoSize = true;
            this.nombreProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreProyecto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nombreProyecto.Location = new System.Drawing.Point(18, 50);
            this.nombreProyecto.Name = "nombreProyecto";
            this.nombreProyecto.Size = new System.Drawing.Size(64, 17);
            this.nombreProyecto.TabIndex = 2;
            this.nombreProyecto.Text = "Proyecto";
            // 
            // tareasFinalizadasDataGrid
            // 
            this.tareasFinalizadasDataGrid.AllowUserToAddRows = false;
            this.tareasFinalizadasDataGrid.AllowUserToDeleteRows = false;
            this.tareasFinalizadasDataGrid.AutoGenerateColumns = false;
            this.tareasFinalizadasDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.tareasFinalizadasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tareasFinalizadasDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtareaDataGridViewTextBoxColumn,
            this.descripcionTareaDataGridViewTextBoxColumn,
            this.horasEstimadasTareaDataGridViewTextBoxColumn,
            this.horasOverbudgetDataGridViewTextBoxColumn,
            this.horasTrabajadasDataGridViewTextBoxColumn});
            this.tareasFinalizadasDataGrid.DataSource = this.tareaBindingSource;
            this.tareasFinalizadasDataGrid.Location = new System.Drawing.Point(22, 82);
            this.tareasFinalizadasDataGrid.Name = "tareasFinalizadasDataGrid";
            this.tareasFinalizadasDataGrid.ReadOnly = true;
            this.tareasFinalizadasDataGrid.Size = new System.Drawing.Size(553, 258);
            this.tareasFinalizadasDataGrid.TabIndex = 1;
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
            this.descripcionTareaDataGridViewTextBoxColumn.FillWeight = 120F;
            this.descripcionTareaDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionTareaDataGridViewTextBoxColumn.Name = "descripcionTareaDataGridViewTextBoxColumn";
            this.descripcionTareaDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionTareaDataGridViewTextBoxColumn.Width = 120;
            // 
            // horasEstimadasTareaDataGridViewTextBoxColumn
            // 
            this.horasEstimadasTareaDataGridViewTextBoxColumn.DataPropertyName = "HorasEstimadasTarea";
            this.horasEstimadasTareaDataGridViewTextBoxColumn.FillWeight = 120F;
            this.horasEstimadasTareaDataGridViewTextBoxColumn.HeaderText = "Horas Estimadas";
            this.horasEstimadasTareaDataGridViewTextBoxColumn.Name = "horasEstimadasTareaDataGridViewTextBoxColumn";
            this.horasEstimadasTareaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horasEstimadasTareaDataGridViewTextBoxColumn.Width = 120;
            // 
            // horasOverbudgetDataGridViewTextBoxColumn
            // 
            this.horasOverbudgetDataGridViewTextBoxColumn.DataPropertyName = "HorasOverbudget";
            this.horasOverbudgetDataGridViewTextBoxColumn.FillWeight = 120F;
            this.horasOverbudgetDataGridViewTextBoxColumn.HeaderText = "Horas Overbudget";
            this.horasOverbudgetDataGridViewTextBoxColumn.Name = "horasOverbudgetDataGridViewTextBoxColumn";
            this.horasOverbudgetDataGridViewTextBoxColumn.ReadOnly = true;
            this.horasOverbudgetDataGridViewTextBoxColumn.Width = 120;
            // 
            // horasTrabajadasDataGridViewTextBoxColumn
            // 
            this.horasTrabajadasDataGridViewTextBoxColumn.DataPropertyName = "HorasTrabajadas";
            this.horasTrabajadasDataGridViewTextBoxColumn.FillWeight = 120F;
            this.horasTrabajadasDataGridViewTextBoxColumn.HeaderText = "Horas Trabajadas";
            this.horasTrabajadasDataGridViewTextBoxColumn.Name = "horasTrabajadasDataGridViewTextBoxColumn";
            this.horasTrabajadasDataGridViewTextBoxColumn.ReadOnly = true;
            this.horasTrabajadasDataGridViewTextBoxColumn.Width = 120;
            // 
            // tareaBindingSource
            // 
            this.tareaBindingSource.DataSource = typeof(EscritorioGestionProyectosLiquidaciones.Models.Tarea);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tareas finalizadas";
            // 
            // TareasFinalizadasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "TareasFinalizadasForm";
            this.Text = "Tareas finalizadas";
            this.Load += new System.EventHandler(this.TareasFinalizadasForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tareasFinalizadasDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tareasFinalizadasDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Label nombreProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtareaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionTareaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasEstimadasTareaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasOverbudgetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasTrabajadasDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tareaBindingSource;
    }
}