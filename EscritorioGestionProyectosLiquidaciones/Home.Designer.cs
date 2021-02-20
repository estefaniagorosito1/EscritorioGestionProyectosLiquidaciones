namespace EscritorioGestionProyectosLiquidaciones
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.homeBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.proyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearProyectoBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarProyectoBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearEmpleadoBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarEmpleadoBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearClienteBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarClientesBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.misTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liquidacionBtn = new System.Windows.Forms.ToolStripButton();
            this.salirBtn = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(218, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 350);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 125);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "¡Bienvenido!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuestro sistema te permite:\r\n  • Gestionar proyectos y sus tareas\r\n  • Gestionar " +
    "clientes y asignarlos a proyectos\r\n  • Gestionar empleados y sus perfiles\r\n  • G" +
    "estionar liquidacion de empleados";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeBtn,
            this.toolStripDropDownButton1,
            this.liquidacionBtn,
            this.salirBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            // 
            // homeBtn
            // 
            this.homeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(44, 22);
            this.homeBtn.Text = "Home";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proyectosToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.misTareasToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(70, 22);
            this.toolStripDropDownButton1.Text = "Gestionar";
            // 
            // proyectosToolStripMenuItem
            // 
            this.proyectosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearProyectoBtn,
            this.gestionarProyectoBtn});
            this.proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
            this.proyectosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.proyectosToolStripMenuItem.Text = "Proyectos";
            // 
            // crearProyectoBtn
            // 
            this.crearProyectoBtn.Name = "crearProyectoBtn";
            this.crearProyectoBtn.Size = new System.Drawing.Size(174, 22);
            this.crearProyectoBtn.Text = "Crear proyecto";
            this.crearProyectoBtn.Click += new System.EventHandler(this.crearProyectoBtn_Click);
            // 
            // gestionarProyectoBtn
            // 
            this.gestionarProyectoBtn.Name = "gestionarProyectoBtn";
            this.gestionarProyectoBtn.Size = new System.Drawing.Size(174, 22);
            this.gestionarProyectoBtn.Text = "Gestionar proyecto";
            this.gestionarProyectoBtn.Click += new System.EventHandler(this.gestionarProyectoBtn_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearEmpleadoBtn,
            this.gestionarEmpleadoBtn});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // crearEmpleadoBtn
            // 
            this.crearEmpleadoBtn.Name = "crearEmpleadoBtn";
            this.crearEmpleadoBtn.Size = new System.Drawing.Size(185, 22);
            this.crearEmpleadoBtn.Text = "Crear empleado";
            this.crearEmpleadoBtn.Click += new System.EventHandler(this.crearEmpleadoBtn_Click);
            // 
            // gestionarEmpleadoBtn
            // 
            this.gestionarEmpleadoBtn.Name = "gestionarEmpleadoBtn";
            this.gestionarEmpleadoBtn.Size = new System.Drawing.Size(185, 22);
            this.gestionarEmpleadoBtn.Text = "Gestionar empleados";
            this.gestionarEmpleadoBtn.Click += new System.EventHandler(this.gestionarEmpleadoBtn_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearClienteBtn,
            this.gestionarClientesBtn});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // crearClienteBtn
            // 
            this.crearClienteBtn.Name = "crearClienteBtn";
            this.crearClienteBtn.Size = new System.Drawing.Size(167, 22);
            this.crearClienteBtn.Text = "Crear cliente";
            this.crearClienteBtn.Click += new System.EventHandler(this.crearClienteBtn_Click);
            // 
            // gestionarClientesBtn
            // 
            this.gestionarClientesBtn.Name = "gestionarClientesBtn";
            this.gestionarClientesBtn.Size = new System.Drawing.Size(167, 22);
            this.gestionarClientesBtn.Text = "Gestionar clientes";
            this.gestionarClientesBtn.Click += new System.EventHandler(this.gestionarClientesBtn_Click);
            // 
            // misTareasToolStripMenuItem
            // 
            this.misTareasToolStripMenuItem.Name = "misTareasToolStripMenuItem";
            this.misTareasToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.misTareasToolStripMenuItem.Text = "Mis tareas";
            this.misTareasToolStripMenuItem.Click += new System.EventHandler(this.misTareasToolStripMenuItem_Click);
            // 
            // liquidacionBtn
            // 
            this.liquidacionBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.liquidacionBtn.Image = ((System.Drawing.Image)(resources.GetObject("liquidacionBtn.Image")));
            this.liquidacionBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.liquidacionBtn.Name = "liquidacionBtn";
            this.liquidacionBtn.Size = new System.Drawing.Size(73, 22);
            this.liquidacionBtn.Text = "Liquidación";
            // 
            // salirBtn
            // 
            this.salirBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.salirBtn.Image = ((System.Drawing.Image)(resources.GetObject("salirBtn.Image")));
            this.salirBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salirBtn.Name = "salirBtn";
            this.salirBtn.Size = new System.Drawing.Size(33, 22);
            this.salirBtn.Text = "Salir";
            this.salirBtn.Click += new System.EventHandler(this.salirBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton homeBtn;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem proyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearProyectoBtn;
        private System.Windows.Forms.ToolStripMenuItem gestionarProyectoBtn;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearEmpleadoBtn;
        private System.Windows.Forms.ToolStripMenuItem gestionarEmpleadoBtn;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearClienteBtn;
        private System.Windows.Forms.ToolStripMenuItem gestionarClientesBtn;
        private System.Windows.Forms.ToolStripButton salirBtn;
        private System.Windows.Forms.ToolStripButton liquidacionBtn;
        private System.Windows.Forms.ToolStripMenuItem misTareasToolStripMenuItem;
    }
}