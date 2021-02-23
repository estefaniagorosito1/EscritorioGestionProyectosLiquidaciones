namespace EscritorioGestionProyectosLiquidaciones.Liquidaciones
{
    partial class GenerarLiquidacionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.generarLiqBtn = new System.Windows.Forms.Button();
            this.volverBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaLiquidacion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.empleadosList = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.empleadosConLiqList = new System.Windows.Forms.ComboBox();
            this.liquidacionesDataGrid = new System.Windows.Forms.DataGridView();
            this.codLiquidacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaLiquidacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesLiquidadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeLiquidacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imprimir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.liquidacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscarLiqLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.generarLiqBtn);
            this.panel1.Controls.Add(this.volverBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.fechaLiquidacion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.empleadosList);
            this.panel1.Location = new System.Drawing.Point(30, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 150);
            this.panel1.TabIndex = 0;
            // 
            // generarLiqBtn
            // 
            this.generarLiqBtn.Location = new System.Drawing.Point(103, 107);
            this.generarLiqBtn.Name = "generarLiqBtn";
            this.generarLiqBtn.Size = new System.Drawing.Size(113, 23);
            this.generarLiqBtn.TabIndex = 6;
            this.generarLiqBtn.Text = "Generar liquidación";
            this.generarLiqBtn.UseVisualStyleBackColor = true;
            this.generarLiqBtn.Click += new System.EventHandler(this.generarLiqBtn_Click);
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(22, 107);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(75, 23);
            this.volverBtn.TabIndex = 5;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Empleado *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(369, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de liquidación *";
            // 
            // fechaLiquidacion
            // 
            this.fechaLiquidacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaLiquidacion.Location = new System.Drawing.Point(522, 68);
            this.fechaLiquidacion.Name = "fechaLiquidacion";
            this.fechaLiquidacion.Size = new System.Drawing.Size(122, 20);
            this.fechaLiquidacion.TabIndex = 2;
            this.fechaLiquidacion.ValueChanged += new System.EventHandler(this.fechaLiquidacion_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generar nueva liquidación";
            // 
            // empleadosList
            // 
            this.empleadosList.DisplayMember = "NombreEmpleado";
            this.empleadosList.FormattingEnabled = true;
            this.empleadosList.Location = new System.Drawing.Point(108, 67);
            this.empleadosList.Name = "empleadosList";
            this.empleadosList.Size = new System.Drawing.Size(206, 21);
            this.empleadosList.TabIndex = 1;
            this.empleadosList.ValueMember = "Idempleado";
            this.empleadosList.SelectionChangeCommitted += new System.EventHandler(this.empleadosList_SelectionChangeCommitted);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.empleadosConLiqList);
            this.panel2.Controls.Add(this.liquidacionesDataGrid);
            this.panel2.Controls.Add(this.buscarLiqLabel);
            this.panel2.Location = new System.Drawing.Point(30, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 230);
            this.panel2.TabIndex = 1;
            // 
            // empleadosConLiqList
            // 
            this.empleadosConLiqList.DisplayMember = "NombreEmpleado";
            this.empleadosConLiqList.FormattingEnabled = true;
            this.empleadosConLiqList.Location = new System.Drawing.Point(22, 57);
            this.empleadosConLiqList.Name = "empleadosConLiqList";
            this.empleadosConLiqList.Size = new System.Drawing.Size(228, 21);
            this.empleadosConLiqList.TabIndex = 3;
            this.empleadosConLiqList.ValueMember = "Idempleado";
            this.empleadosConLiqList.SelectionChangeCommitted += new System.EventHandler(this.empleadosConLiqList_SelectionChangeCommitted);
            this.empleadosConLiqList.Click += new System.EventHandler(this.empleadosConLiqList_Click);
            // 
            // liquidacionesDataGrid
            // 
            this.liquidacionesDataGrid.AllowUserToAddRows = false;
            this.liquidacionesDataGrid.AllowUserToDeleteRows = false;
            this.liquidacionesDataGrid.AutoGenerateColumns = false;
            this.liquidacionesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liquidacionesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codLiquidacionDataGridViewTextBoxColumn,
            this.fechaLiquidacionDataGridViewTextBoxColumn,
            this.mesLiquidadoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.importeLiquidacionDataGridViewTextBoxColumn,
            this.imprimir});
            this.liquidacionesDataGrid.DataSource = this.liquidacionBindingSource;
            this.liquidacionesDataGrid.Location = new System.Drawing.Point(22, 92);
            this.liquidacionesDataGrid.Name = "liquidacionesDataGrid";
            this.liquidacionesDataGrid.ReadOnly = true;
            this.liquidacionesDataGrid.Size = new System.Drawing.Size(700, 112);
            this.liquidacionesDataGrid.TabIndex = 2;
            this.liquidacionesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.liquidacionesDataGrid_CellContentClick);
            // 
            // codLiquidacionDataGridViewTextBoxColumn
            // 
            this.codLiquidacionDataGridViewTextBoxColumn.DataPropertyName = "CodLiquidacion";
            this.codLiquidacionDataGridViewTextBoxColumn.FillWeight = 120F;
            this.codLiquidacionDataGridViewTextBoxColumn.HeaderText = "Cod. Liquidacion";
            this.codLiquidacionDataGridViewTextBoxColumn.Name = "codLiquidacionDataGridViewTextBoxColumn";
            this.codLiquidacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.codLiquidacionDataGridViewTextBoxColumn.Width = 120;
            // 
            // fechaLiquidacionDataGridViewTextBoxColumn
            // 
            this.fechaLiquidacionDataGridViewTextBoxColumn.DataPropertyName = "FechaLiquidacion";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.fechaLiquidacionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.fechaLiquidacionDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaLiquidacionDataGridViewTextBoxColumn.Name = "fechaLiquidacionDataGridViewTextBoxColumn";
            this.fechaLiquidacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mesLiquidadoDataGridViewTextBoxColumn
            // 
            this.mesLiquidadoDataGridViewTextBoxColumn.HeaderText = "Mes liquidado";
            this.mesLiquidadoDataGridViewTextBoxColumn.Name = "mesLiquidadoDataGridViewTextBoxColumn";
            this.mesLiquidadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // importeLiquidacionDataGridViewTextBoxColumn
            // 
            this.importeLiquidacionDataGridViewTextBoxColumn.DataPropertyName = "ImporteLiquidacion";
            dataGridViewCellStyle2.NullValue = null;
            this.importeLiquidacionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.importeLiquidacionDataGridViewTextBoxColumn.HeaderText = "Importe";
            this.importeLiquidacionDataGridViewTextBoxColumn.Name = "importeLiquidacionDataGridViewTextBoxColumn";
            this.importeLiquidacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imprimir
            // 
            this.imprimir.FillWeight = 137F;
            this.imprimir.HeaderText = "";
            this.imprimir.Name = "imprimir";
            this.imprimir.ReadOnly = true;
            this.imprimir.Text = "Imprimir liquidación";
            this.imprimir.UseColumnTextForButtonValue = true;
            this.imprimir.Width = 137;
            // 
            // liquidacionBindingSource
            // 
            this.liquidacionBindingSource.DataSource = typeof(EscritorioGestionProyectosLiquidaciones.Models.Liquidacion);
            // 
            // buscarLiqLabel
            // 
            this.buscarLiqLabel.AutoSize = true;
            this.buscarLiqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarLiqLabel.Location = new System.Drawing.Point(22, 17);
            this.buscarLiqLabel.Name = "buscarLiqLabel";
            this.buscarLiqLabel.Size = new System.Drawing.Size(184, 24);
            this.buscarLiqLabel.TabIndex = 0;
            this.buscarLiqLabel.Text = "Buscar liquidaciones";
            // 
            // GenerarLiquidacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GenerarLiquidacionForm";
            this.Text = "Liquidaciones";
            this.Load += new System.EventHandler(this.GenerarLiquidacionForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generarLiqBtn;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fechaLiquidacion;
        private System.Windows.Forms.ComboBox empleadosList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox empleadosConLiqList;
        private System.Windows.Forms.DataGridView liquidacionesDataGrid;
        private System.Windows.Forms.BindingSource liquidacionBindingSource;
        private System.Windows.Forms.Label buscarLiqLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLiquidacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaLiquidacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesLiquidadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeLiquidacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn imprimir;
    }
}