namespace EscritorioGestionProyectosLiquidaciones.Clientes
{
    partial class crearModificarClientesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nombreClienteTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dropdownLocalidades = new System.Windows.Forms.ComboBox();
            this.mailTxt = new System.Windows.Forms.TextBox();
            this.apellidoClienteTxt = new System.Windows.Forms.TextBox();
            this.direccionTxt = new System.Windows.Forms.TextBox();
            this.telefonoTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dropdownProvincias = new System.Windows.Forms.ComboBox();
            this.volverBtn = new System.Windows.Forms.Button();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear cliente";
            // 
            // nombreClienteTxt
            // 
            this.nombreClienteTxt.Location = new System.Drawing.Point(32, 105);
            this.nombreClienteTxt.Name = "nombreClienteTxt";
            this.nombreClienteTxt.Size = new System.Drawing.Size(200, 20);
            this.nombreClienteTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(482, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dirección *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Teléfono *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(382, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email *";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dropdownLocalidades);
            this.panel1.Controls.Add(this.mailTxt);
            this.panel1.Controls.Add(this.apellidoClienteTxt);
            this.panel1.Controls.Add(this.direccionTxt);
            this.panel1.Controls.Add(this.telefonoTxt);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dropdownProvincias);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.volverBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.guardarBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nombreClienteTxt);
            this.panel1.Location = new System.Drawing.Point(27, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 389);
            this.panel1.TabIndex = 11;
            // 
            // dropdownLocalidades
            // 
            this.dropdownLocalidades.DisplayMember = "Descripcion";
            this.dropdownLocalidades.FormattingEnabled = true;
            this.dropdownLocalidades.Location = new System.Drawing.Point(385, 264);
            this.dropdownLocalidades.Name = "dropdownLocalidades";
            this.dropdownLocalidades.Size = new System.Drawing.Size(300, 21);
            this.dropdownLocalidades.TabIndex = 18;
            this.dropdownLocalidades.ValueMember = "Idlocalidad";
            // 
            // mailTxt
            // 
            this.mailTxt.Location = new System.Drawing.Point(385, 182);
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Size = new System.Drawing.Size(300, 20);
            this.mailTxt.TabIndex = 17;
            // 
            // apellidoClienteTxt
            // 
            this.apellidoClienteTxt.Location = new System.Drawing.Point(263, 105);
            this.apellidoClienteTxt.Name = "apellidoClienteTxt";
            this.apellidoClienteTxt.Size = new System.Drawing.Size(200, 20);
            this.apellidoClienteTxt.TabIndex = 16;
            // 
            // direccionTxt
            // 
            this.direccionTxt.Location = new System.Drawing.Point(485, 105);
            this.direccionTxt.Name = "direccionTxt";
            this.direccionTxt.Size = new System.Drawing.Size(200, 20);
            this.direccionTxt.TabIndex = 15;
            // 
            // telefonoTxt
            // 
            this.telefonoTxt.Location = new System.Drawing.Point(32, 182);
            this.telefonoTxt.Name = "telefonoTxt";
            this.telefonoTxt.Size = new System.Drawing.Size(300, 20);
            this.telefonoTxt.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(382, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Localidad *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Provincia *";
            // 
            // dropdownProvincias
            // 
            this.dropdownProvincias.DisplayMember = "Descripcion";
            this.dropdownProvincias.FormattingEnabled = true;
            this.dropdownProvincias.Location = new System.Drawing.Point(32, 264);
            this.dropdownProvincias.Name = "dropdownProvincias";
            this.dropdownProvincias.Size = new System.Drawing.Size(300, 21);
            this.dropdownProvincias.TabIndex = 2;
            this.dropdownProvincias.ValueMember = "Idprovincia";
            this.dropdownProvincias.SelectionChangeCommitted += new System.EventHandler(this.dropdownProvincias_SelectionChangeCommitted);
            // 
            // volverBtn
            // 
            this.volverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverBtn.Location = new System.Drawing.Point(32, 319);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(85, 25);
            this.volverBtn.TabIndex = 1;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // guardarBtn
            // 
            this.guardarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarBtn.Location = new System.Drawing.Point(123, 319);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(94, 25);
            this.guardarBtn.TabIndex = 0;
            this.guardarBtn.Text = "Guardar cliente";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // crearModificarClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "crearModificarClientesForm";
            this.Text = "Crear cliente";
            this.Load += new System.EventHandler(this.crearModificarClientesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreClienteTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox dropdownLocalidades;
        private System.Windows.Forms.TextBox mailTxt;
        private System.Windows.Forms.TextBox apellidoClienteTxt;
        private System.Windows.Forms.TextBox direccionTxt;
        private System.Windows.Forms.TextBox telefonoTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox dropdownProvincias;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Button guardarBtn;
    }
}