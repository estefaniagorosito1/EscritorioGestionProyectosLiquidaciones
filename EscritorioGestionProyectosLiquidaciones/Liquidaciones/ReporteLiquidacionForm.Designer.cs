namespace EscritorioGestionProyectosLiquidaciones.Liquidaciones
{
    partial class ReporteLiquidacionForm
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LiquidacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LiquidacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LiquidacionBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.EmpleadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EscritorioGestionProyectosLiquidaciones.Reportes.ReporteLiquidacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(572, 403);
            this.reportViewer1.TabIndex = 0;
            // 
            // LiquidacionBindingSource
            // 
            this.LiquidacionBindingSource.DataSource = typeof(EscritorioGestionProyectosLiquidaciones.Models.Liquidacion);
            // 
            // EmpleadoBindingSource
            // 
            this.EmpleadoBindingSource.DataSource = typeof(EscritorioGestionProyectosLiquidaciones.Models.Empleado);
            // 
            // ReporteLiquidacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 403);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteLiquidacionForm";
            this.Text = "Liquidación";
            this.Load += new System.EventHandler(this.ReporteLiquidacionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LiquidacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LiquidacionBindingSource;
        private System.Windows.Forms.BindingSource EmpleadoBindingSource;
    }
}