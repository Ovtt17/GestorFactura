namespace GestorFactura
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.slbHour = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slbWelcome = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.OrdenAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAyuda = new System.Windows.Forms.ToolStripDropDownButton();
            this.OrdenVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVentana = new System.Windows.Forms.ToolStripDropDownButton();
            this.OrdenProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenFactura = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOperaciones = new System.Windows.Forms.ToolStripDropDownButton();
            this.OrdenSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchivo = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // slbHour
            // 
            this.slbHour.BackColor = System.Drawing.Color.Transparent;
            this.slbHour.Name = "slbHour";
            this.slbHour.Size = new System.Drawing.Size(34, 17);
            this.slbHour.Text = "Hour";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(351, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // slbWelcome
            // 
            this.slbWelcome.BackColor = System.Drawing.Color.Transparent;
            this.slbWelcome.Name = "slbWelcome";
            this.slbWelcome.Size = new System.Drawing.Size(70, 17);
            this.slbWelcome.Text = "Bienvenid@";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slbWelcome,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.slbHour});
            this.statusStrip1.Location = new System.Drawing.Point(0, 569);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(958, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(351, 17);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OrdenAcercaDe
            // 
            this.OrdenAcercaDe.Name = "OrdenAcercaDe";
            this.OrdenAcercaDe.Size = new System.Drawing.Size(135, 22);
            this.OrdenAcercaDe.Text = "Acerca de...";
            // 
            // menuAyuda
            // 
            this.menuAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrdenAcercaDe});
            this.menuAyuda.Image = ((System.Drawing.Image)(resources.GetObject("menuAyuda.Image")));
            this.menuAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuAyuda.Name = "menuAyuda";
            this.menuAyuda.Size = new System.Drawing.Size(54, 22);
            this.menuAyuda.Text = "Ayuda";
            // 
            // OrdenVertical
            // 
            this.OrdenVertical.Name = "OrdenVertical";
            this.OrdenVertical.Size = new System.Drawing.Size(129, 22);
            this.OrdenVertical.Text = "Vertical";
            // 
            // OrdenHorizontal
            // 
            this.OrdenHorizontal.Name = "OrdenHorizontal";
            this.OrdenHorizontal.Size = new System.Drawing.Size(129, 22);
            this.OrdenHorizontal.Text = "Horizontal";
            // 
            // OrdenCascada
            // 
            this.OrdenCascada.Name = "OrdenCascada";
            this.OrdenCascada.Size = new System.Drawing.Size(129, 22);
            this.OrdenCascada.Text = "Cascada";
            // 
            // menuVentana
            // 
            this.menuVentana.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuVentana.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrdenCascada,
            this.OrdenHorizontal,
            this.OrdenVertical});
            this.menuVentana.Image = ((System.Drawing.Image)(resources.GetObject("menuVentana.Image")));
            this.menuVentana.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuVentana.Name = "menuVentana";
            this.menuVentana.Size = new System.Drawing.Size(62, 22);
            this.menuVentana.Text = "Ventana";
            // 
            // OrdenProductos
            // 
            this.OrdenProductos.Name = "OrdenProductos";
            this.OrdenProductos.Size = new System.Drawing.Size(137, 22);
            this.OrdenProductos.Text = "Productos...";
            // 
            // OrdenFactura
            // 
            this.OrdenFactura.Name = "OrdenFactura";
            this.OrdenFactura.Size = new System.Drawing.Size(137, 22);
            this.OrdenFactura.Text = "Facturas...";
            this.OrdenFactura.Click += new System.EventHandler(this.OrdenFactura_Click);
            // 
            // menuOperaciones
            // 
            this.menuOperaciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuOperaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrdenFactura,
            this.OrdenProductos});
            this.menuOperaciones.Image = ((System.Drawing.Image)(resources.GetObject("menuOperaciones.Image")));
            this.menuOperaciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuOperaciones.Name = "menuOperaciones";
            this.menuOperaciones.Size = new System.Drawing.Size(86, 22);
            this.menuOperaciones.Text = "Operaciones";
            // 
            // OrdenSalir
            // 
            this.OrdenSalir.Name = "OrdenSalir";
            this.OrdenSalir.Size = new System.Drawing.Size(96, 22);
            this.OrdenSalir.Text = "Salir";
            // 
            // menuArchivo
            // 
            this.menuArchivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrdenSalir});
            this.menuArchivo.Image = ((System.Drawing.Image)(resources.GetObject("menuArchivo.Image")));
            this.menuArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(61, 22);
            this.menuArchivo.Text = "Archivo";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuOperaciones,
            this.menuVentana,
            this.menuAyuda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(958, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "asd";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 591);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel slbHour;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel slbWelcome;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem OrdenAcercaDe;
        private System.Windows.Forms.ToolStripDropDownButton menuAyuda;
        private System.Windows.Forms.ToolStripMenuItem OrdenVertical;
        private System.Windows.Forms.ToolStripMenuItem OrdenHorizontal;
        private System.Windows.Forms.ToolStripMenuItem OrdenCascada;
        private System.Windows.Forms.ToolStripDropDownButton menuVentana;
        private System.Windows.Forms.ToolStripMenuItem OrdenProductos;
        private System.Windows.Forms.ToolStripMenuItem OrdenFactura;
        private System.Windows.Forms.ToolStripDropDownButton menuOperaciones;
        private System.Windows.Forms.ToolStripMenuItem OrdenSalir;
        private System.Windows.Forms.ToolStripDropDownButton menuArchivo;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}