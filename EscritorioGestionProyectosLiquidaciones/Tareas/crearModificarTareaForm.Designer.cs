﻿namespace EscritorioGestionProyectosLiquidaciones.Tareas
{
    partial class crearModificarTareaForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tareasDataGrid = new System.Windows.Forms.DataGridView();
            this.idtareaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionTareaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasEstimadasTareaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasOverbudgetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasTrabajadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tareaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.volverBtn = new System.Windows.Forms.Button();
            this.horasTxt = new System.Windows.Forms.MaskedTextBox();
            this.descripcionTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tareasDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tareasDataGrid);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(30, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 222);
            this.panel2.TabIndex = 3;
            // 
            // tareasDataGrid
            // 
            this.tareasDataGrid.AllowUserToAddRows = false;
            this.tareasDataGrid.AllowUserToDeleteRows = false;
            this.tareasDataGrid.AutoGenerateColumns = false;
            this.tareasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tareasDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtareaDataGridViewTextBoxColumn,
            this.descripcionTareaDataGridViewTextBoxColumn,
            this.horasEstimadasTareaDataGridViewTextBoxColumn,
            this.horasOverbudgetDataGridViewTextBoxColumn,
            this.horasTrabajadasDataGridViewTextBoxColumn,
            this.Editar,
            this.Eliminar});
            this.tareasDataGrid.DataSource = this.tareaBindingSource;
            this.tareasDataGrid.Location = new System.Drawing.Point(24, 68);
            this.tareasDataGrid.Name = "tareasDataGrid";
            this.tareasDataGrid.Size = new System.Drawing.Size(695, 140);
            this.tareasDataGrid.TabIndex = 3;
            // 
            // idtareaDataGridViewTextBoxColumn
            // 
            this.idtareaDataGridViewTextBoxColumn.DataPropertyName = "Idtarea";
            this.idtareaDataGridViewTextBoxColumn.FillWeight = 35F;
            this.idtareaDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idtareaDataGridViewTextBoxColumn.Name = "idtareaDataGridViewTextBoxColumn";
            this.idtareaDataGridViewTextBoxColumn.Width = 35;
            // 
            // descripcionTareaDataGridViewTextBoxColumn
            // 
            this.descripcionTareaDataGridViewTextBoxColumn.DataPropertyName = "DescripcionTarea";
            this.descripcionTareaDataGridViewTextBoxColumn.FillWeight = 108F;
            this.descripcionTareaDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionTareaDataGridViewTextBoxColumn.Name = "descripcionTareaDataGridViewTextBoxColumn";
            this.descripcionTareaDataGridViewTextBoxColumn.Width = 108;
            // 
            // horasEstimadasTareaDataGridViewTextBoxColumn
            // 
            this.horasEstimadasTareaDataGridViewTextBoxColumn.DataPropertyName = "HorasEstimadasTarea";
            this.horasEstimadasTareaDataGridViewTextBoxColumn.FillWeight = 110F;
            this.horasEstimadasTareaDataGridViewTextBoxColumn.HeaderText = "Horas estimadas";
            this.horasEstimadasTareaDataGridViewTextBoxColumn.Name = "horasEstimadasTareaDataGridViewTextBoxColumn";
            this.horasEstimadasTareaDataGridViewTextBoxColumn.Width = 110;
            // 
            // horasOverbudgetDataGridViewTextBoxColumn
            // 
            this.horasOverbudgetDataGridViewTextBoxColumn.DataPropertyName = "HorasOverbudget";
            this.horasOverbudgetDataGridViewTextBoxColumn.FillWeight = 115F;
            this.horasOverbudgetDataGridViewTextBoxColumn.HeaderText = "Horas overbudget";
            this.horasOverbudgetDataGridViewTextBoxColumn.Name = "horasOverbudgetDataGridViewTextBoxColumn";
            this.horasOverbudgetDataGridViewTextBoxColumn.Width = 115;
            // 
            // horasTrabajadasDataGridViewTextBoxColumn
            // 
            this.horasTrabajadasDataGridViewTextBoxColumn.DataPropertyName = "HorasTrabajadas";
            this.horasTrabajadasDataGridViewTextBoxColumn.FillWeight = 112F;
            this.horasTrabajadasDataGridViewTextBoxColumn.HeaderText = "Horas trabajadas";
            this.horasTrabajadasDataGridViewTextBoxColumn.Name = "horasTrabajadasDataGridViewTextBoxColumn";
            this.horasTrabajadasDataGridViewTextBoxColumn.Width = 112;
            // 
            // Editar
            // 
            this.Editar.FillWeight = 70F;
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 70;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // tareaBindingSource
            // 
            this.tareaBindingSource.DataSource = typeof(EscritorioGestionProyectosLiquidaciones.Models.Tarea);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(21, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Modifique tareas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tareas existentes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.guardarBtn);
            this.panel1.Controls.Add(this.volverBtn);
            this.panel1.Controls.Add(this.horasTxt);
            this.panel1.Controls.Add(this.descripcionTxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 164);
            this.panel1.TabIndex = 2;
            // 
            // guardarBtn
            // 
            this.guardarBtn.Location = new System.Drawing.Point(105, 121);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(75, 23);
            this.guardarBtn.TabIndex = 8;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = true;
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(24, 121);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(75, 23);
            this.volverBtn.TabIndex = 7;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            // 
            // horasTxt
            // 
            this.horasTxt.Location = new System.Drawing.Point(500, 85);
            this.horasTxt.Mask = "99999";
            this.horasTxt.Name = "horasTxt";
            this.horasTxt.Size = new System.Drawing.Size(219, 20);
            this.horasTxt.TabIndex = 6;
            this.horasTxt.ValidatingType = typeof(int);
            // 
            // descripcionTxt
            // 
            this.descripcionTxt.Location = new System.Drawing.Point(24, 85);
            this.descripcionTxt.Name = "descripcionTxt";
            this.descripcionTxt.Size = new System.Drawing.Size(448, 20);
            this.descripcionTxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Horas estimadas *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(21, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cree o modifique tareas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Tarea";
            // 
            // crearModificarTareaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "crearModificarTareaForm";
            this.Text = "Tareas";
            this.Load += new System.EventHandler(this.crearModificarTareaForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tareasDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tareasDataGrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.MaskedTextBox horasTxt;
        private System.Windows.Forms.TextBox descripcionTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtareaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionTareaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasEstimadasTareaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasOverbudgetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasTrabajadasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.BindingSource tareaBindingSource;
    }
}