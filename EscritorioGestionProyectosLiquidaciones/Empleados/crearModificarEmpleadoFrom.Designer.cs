namespace EscritorioGestionProyectosLiquidaciones.Empleados
{
    partial class crearModificarEmpleadoFrom
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
            this.asignarBtn = new System.Windows.Forms.Button();
            this.contraseñaTxt = new System.Windows.Forms.MaskedTextBox();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.volverBtn = new System.Windows.Forms.Button();
            this.localidadSelected = new System.Windows.Forms.ComboBox();
            this.provinciaSelected = new System.Windows.Forms.ComboBox();
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.direccionTxt = new System.Windows.Forms.TextBox();
            this.telefonoTxt = new System.Windows.Forms.TextBox();
            this.apellidoEmpleadoTxt = new System.Windows.Forms.TextBox();
            this.nombreEmpleadoTxt = new System.Windows.Forms.TextBox();
            this.dniTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.asignarBtn);
            this.panel1.Controls.Add(this.contraseñaTxt);
            this.panel1.Controls.Add(this.guardarBtn);
            this.panel1.Controls.Add(this.volverBtn);
            this.panel1.Controls.Add(this.localidadSelected);
            this.panel1.Controls.Add(this.provinciaSelected);
            this.panel1.Controls.Add(this.usuarioTxt);
            this.panel1.Controls.Add(this.direccionTxt);
            this.panel1.Controls.Add(this.telefonoTxt);
            this.panel1.Controls.Add(this.apellidoEmpleadoTxt);
            this.panel1.Controls.Add(this.nombreEmpleadoTxt);
            this.panel1.Controls.Add(this.dniTxt);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 389);
            this.panel1.TabIndex = 0;
            // 
            // asignarBtn
            // 
            this.asignarBtn.Location = new System.Drawing.Point(239, 329);
            this.asignarBtn.Name = "asignarBtn";
            this.asignarBtn.Size = new System.Drawing.Size(94, 23);
            this.asignarBtn.TabIndex = 30;
            this.asignarBtn.Text = "Asignar perfiles";
            this.asignarBtn.UseVisualStyleBackColor = true;
            this.asignarBtn.Click += new System.EventHandler(this.asignarBtn_Click);
            // 
            // contraseñaTxt
            // 
            this.contraseñaTxt.Location = new System.Drawing.Point(261, 275);
            this.contraseñaTxt.Name = "contraseñaTxt";
            this.contraseñaTxt.PasswordChar = '*';
            this.contraseñaTxt.Size = new System.Drawing.Size(200, 20);
            this.contraseñaTxt.TabIndex = 29;
            // 
            // guardarBtn
            // 
            this.guardarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarBtn.Location = new System.Drawing.Point(126, 329);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(107, 23);
            this.guardarBtn.TabIndex = 22;
            this.guardarBtn.Text = "Guardar empleado";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // volverBtn
            // 
            this.volverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverBtn.Location = new System.Drawing.Point(32, 329);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(88, 23);
            this.volverBtn.TabIndex = 21;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // localidadSelected
            // 
            this.localidadSelected.DisplayMember = "Descripcion";
            this.localidadSelected.FormattingEnabled = true;
            this.localidadSelected.Location = new System.Drawing.Point(374, 204);
            this.localidadSelected.Name = "localidadSelected";
            this.localidadSelected.Size = new System.Drawing.Size(315, 21);
            this.localidadSelected.TabIndex = 19;
            this.localidadSelected.ValueMember = "Idlocalidad";
            // 
            // provinciaSelected
            // 
            this.provinciaSelected.DisplayMember = "Descripcion";
            this.provinciaSelected.FormattingEnabled = true;
            this.provinciaSelected.Location = new System.Drawing.Point(33, 204);
            this.provinciaSelected.Name = "provinciaSelected";
            this.provinciaSelected.Size = new System.Drawing.Size(315, 21);
            this.provinciaSelected.TabIndex = 18;
            this.provinciaSelected.ValueMember = "Idprovincia";
            this.provinciaSelected.SelectionChangeCommitted += new System.EventHandler(this.provinciaSelected_SelectionChangeCommitted);
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.Location = new System.Drawing.Point(33, 275);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(200, 20);
            this.usuarioTxt.TabIndex = 16;
            // 
            // direccionTxt
            // 
            this.direccionTxt.Location = new System.Drawing.Point(261, 142);
            this.direccionTxt.Name = "direccionTxt";
            this.direccionTxt.Size = new System.Drawing.Size(200, 20);
            this.direccionTxt.TabIndex = 15;
            // 
            // telefonoTxt
            // 
            this.telefonoTxt.Location = new System.Drawing.Point(33, 142);
            this.telefonoTxt.Name = "telefonoTxt";
            this.telefonoTxt.Size = new System.Drawing.Size(200, 20);
            this.telefonoTxt.TabIndex = 14;
            // 
            // apellidoEmpleadoTxt
            // 
            this.apellidoEmpleadoTxt.Location = new System.Drawing.Point(489, 78);
            this.apellidoEmpleadoTxt.Name = "apellidoEmpleadoTxt";
            this.apellidoEmpleadoTxt.Size = new System.Drawing.Size(200, 20);
            this.apellidoEmpleadoTxt.TabIndex = 13;
            // 
            // nombreEmpleadoTxt
            // 
            this.nombreEmpleadoTxt.Location = new System.Drawing.Point(261, 78);
            this.nombreEmpleadoTxt.Name = "nombreEmpleadoTxt";
            this.nombreEmpleadoTxt.Size = new System.Drawing.Size(200, 20);
            this.nombreEmpleadoTxt.TabIndex = 12;
            // 
            // dniTxt
            // 
            this.dniTxt.Location = new System.Drawing.Point(33, 78);
            this.dniTxt.Name = "dniTxt";
            this.dniTxt.Size = new System.Drawing.Size(200, 20);
            this.dniTxt.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(258, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Contraseña *";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Usuario *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(371, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Localidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Provincia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(255, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "DNI *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(486, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear empleado";
            // 
            // crearModificarEmpleadoFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "crearModificarEmpleadoFrom";
            this.Text = "Crear Empleado";
            this.Load += new System.EventHandler(this.crearModificarEmpleadoFrom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.ComboBox localidadSelected;
        private System.Windows.Forms.ComboBox provinciaSelected;
        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.TextBox direccionTxt;
        private System.Windows.Forms.TextBox telefonoTxt;
        private System.Windows.Forms.TextBox apellidoEmpleadoTxt;
        private System.Windows.Forms.TextBox nombreEmpleadoTxt;
        private System.Windows.Forms.TextBox dniTxt;
        private System.Windows.Forms.MaskedTextBox contraseñaTxt;
        private System.Windows.Forms.Button asignarBtn;
    }
}