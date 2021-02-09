namespace EscritorioGestionProyectosLiquidaciones.Clientes
{
    partial class gestionarClientesForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.volverBtn = new System.Windows.Forms.Button();
            this.crearClienteBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.crearClienteBtn);
            this.panel1.Controls.Add(this.volverBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(51, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 354);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cree y modifique clientes";
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(22, 310);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(75, 23);
            this.volverBtn.TabIndex = 3;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            // 
            // crearClienteBtn
            // 
            this.crearClienteBtn.Location = new System.Drawing.Point(103, 310);
            this.crearClienteBtn.Name = "crearClienteBtn";
            this.crearClienteBtn.Size = new System.Drawing.Size(122, 23);
            this.crearClienteBtn.TabIndex = 4;
            this.crearClienteBtn.Text = "Crear nuevo cliente";
            this.crearClienteBtn.UseVisualStyleBackColor = true;
            // 
            // gestionarClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "gestionarClientesForm";
            this.Text = "Gestionar clientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button crearClienteBtn;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}