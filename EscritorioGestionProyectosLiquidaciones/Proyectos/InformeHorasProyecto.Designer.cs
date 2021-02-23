namespace EscritorioGestionProyectosLiquidaciones.Proyectos
{
    partial class InformeHorasProyecto
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TareaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PerfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.TareaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerfilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TareaBindingSource
            // 
            this.TareaBindingSource.DataMember = "HoraTrabajada";
            this.TareaBindingSource.DataSource = typeof(EscritorioGestionProyectosLiquidaciones.Models.Tarea);
            // 
            // PerfilBindingSource
            // 
            this.PerfilBindingSource.DataSource = typeof(EscritorioGestionProyectosLiquidaciones.Models.Perfil);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "horasPerfil";
            reportDataSource1.Value = this.TareaBindingSource;
            reportDataSource2.Name = "perfiles";
            reportDataSource2.Value = this.PerfilBindingSource;
            reportDataSource3.Name = "tareas";
            reportDataSource3.Value = this.TareaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EscritorioGestionProyectosLiquidaciones.Reportes.ReporteHoras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(565, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // InformeHorasProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InformeHorasProyecto";
            this.Text = "Informe";
            this.Load += new System.EventHandler(this.InformeHorasProyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TareaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerfilBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource TareaBindingSource;
        private System.Windows.Forms.BindingSource PerfilBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}