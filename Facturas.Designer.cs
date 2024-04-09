namespace GestorFactura
{
    partial class Facturas
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
            this.lbTotal = new System.Windows.Forms.Label();
            this.BtnEliminarProducto = new System.Windows.Forms.Button();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnNuevaFactura = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.txtEnvoiceNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpDetalleVenta = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridDetalles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsubtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnLast = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnFirst = new System.Windows.Forms.Button();
            this.xpVenta = new DevExpress.Xpo.XPCollection(this.components);
            this.txtEnvoiceDate = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalles)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(66, 594);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(95, 13);
            this.lbTotal.TabIndex = 20;
            this.lbTotal.Text = "TOTAL A PAGAR:";
            // 
            // BtnEliminarProducto
            // 
            this.BtnEliminarProducto.Location = new System.Drawing.Point(30, 69);
            this.BtnEliminarProducto.Name = "BtnEliminarProducto";
            this.BtnEliminarProducto.Size = new System.Drawing.Size(163, 31);
            this.BtnEliminarProducto.TabIndex = 4;
            this.BtnEliminarProducto.Text = "ELIMINAR PRODUCTO";
            this.BtnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.Location = new System.Drawing.Point(30, 19);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(163, 31);
            this.BtnAgregarProducto.TabIndex = 3;
            this.BtnAgregarProducto.Text = "AGREGAR PRODUCTO";
            this.BtnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(30, 103);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(163, 31);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(30, 60);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(163, 31);
            this.BtnGuardar.TabIndex = 1;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnNuevaFactura
            // 
            this.BtnNuevaFactura.Location = new System.Drawing.Point(30, 19);
            this.BtnNuevaFactura.Name = "BtnNuevaFactura";
            this.BtnNuevaFactura.Size = new System.Drawing.Size(163, 31);
            this.BtnNuevaFactura.TabIndex = 0;
            this.BtnNuevaFactura.Text = "NUEVA FACTURA";
            this.BtnNuevaFactura.UseVisualStyleBackColor = true;
            this.BtnNuevaFactura.Click += new System.EventHandler(this.BtnNuevaFactura_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnCancelar);
            this.groupBox1.Controls.Add(this.BtnGuardar);
            this.groupBox1.Controls.Add(this.BtnNuevaFactura);
            this.groupBox1.Location = new System.Drawing.Point(669, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 140);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnEliminarProducto);
            this.groupBox2.Controls.Add(this.BtnAgregarProducto);
            this.groupBox2.Location = new System.Drawing.Point(669, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 119);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "PRODUCTOS:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(516, 96);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(49, 15);
            this.lbDate.TabIndex = 16;
            this.lbDate.Text = "FECHA:";
            // 
            // txtClient
            // 
            this.txtClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClient.Location = new System.Drawing.Point(184, 135);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(201, 21);
            this.txtClient.TabIndex = 15;
            // 
            // txtEnvoiceNumber
            // 
            this.txtEnvoiceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnvoiceNumber.Location = new System.Drawing.Point(184, 100);
            this.txtEnvoiceNumber.Name = "txtEnvoiceNumber";
            this.txtEnvoiceNumber.ReadOnly = true;
            this.txtEnvoiceNumber.Size = new System.Drawing.Size(100, 21);
            this.txtEnvoiceNumber.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "CLIENTE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "FACTURA N:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "FACTURAS";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpDetalleVenta;
            this.gridControl1.Location = new System.Drawing.Point(88, 205);
            this.gridControl1.MainView = this.gridDetalles;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(560, 273);
            this.gridControl1.TabIndex = 21;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDetalles});
            // 
            // xpDetalleVenta
            // 
            this.xpDetalleVenta.ObjectType = typeof(GestorFactura.bdventa.Detalle);
            this.xpDetalleVenta.Session = this.unitOfWork1;
            // 
            // gridDetalles
            // 
            this.gridDetalles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn1,
            this.gridColumn3,
            this.colcantidad,
            this.colsubtotal});
            this.gridDetalles.GridControl = this.gridControl1;
            this.gridDetalles.Name = "gridDetalles";
            this.gridDetalles.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.BackColor = System.Drawing.Color.Black;
            this.gridColumn2.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Codigo Producto";
            this.gridColumn2.FieldName = "producto_idproducto!Key";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.BackColor = System.Drawing.Color.Black;
            this.gridColumn1.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Nombre de Producto";
            this.gridColumn1.FieldName = "producto_idproducto.nombreprod";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.BackColor = System.Drawing.Color.Black;
            this.gridColumn3.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Precio";
            this.gridColumn3.FieldName = "producto_idproducto.precio";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // colcantidad
            // 
            this.colcantidad.AppearanceCell.Options.UseTextOptions = true;
            this.colcantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcantidad.AppearanceHeader.BackColor = System.Drawing.Color.Black;
            this.colcantidad.AppearanceHeader.Options.UseBackColor = true;
            this.colcantidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colcantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 3;
            // 
            // colsubtotal
            // 
            this.colsubtotal.AppearanceCell.Options.UseTextOptions = true;
            this.colsubtotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsubtotal.AppearanceHeader.BackColor = System.Drawing.Color.Black;
            this.colsubtotal.AppearanceHeader.Options.UseBackColor = true;
            this.colsubtotal.AppearanceHeader.Options.UseTextOptions = true;
            this.colsubtotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsubtotal.Caption = "Subtotal";
            this.colsubtotal.FieldName = "subtotal";
            this.colsubtotal.Name = "colsubtotal";
            this.colsubtotal.Visible = true;
            this.colsubtotal.VisibleIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnLast);
            this.groupBox3.Controls.Add(this.BtnNext);
            this.groupBox3.Controls.Add(this.BtnBack);
            this.groupBox3.Controls.Add(this.BtnFirst);
            this.groupBox3.Location = new System.Drawing.Point(173, 493);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(408, 78);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // BtnLast
            // 
            this.BtnLast.Location = new System.Drawing.Point(312, 33);
            this.BtnLast.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(56, 24);
            this.BtnLast.TabIndex = 3;
            this.BtnLast.Text = ">|";
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(221, 33);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(56, 24);
            this.BtnNext.TabIndex = 2;
            this.BtnNext.Text = ">>";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(127, 33);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(56, 24);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "<<";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnFirst
            // 
            this.BtnFirst.Location = new System.Drawing.Point(41, 33);
            this.BtnFirst.Margin = new System.Windows.Forms.Padding(2);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(56, 24);
            this.BtnFirst.TabIndex = 0;
            this.BtnFirst.Text = "|<";
            this.BtnFirst.UseVisualStyleBackColor = true;
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // xpVenta
            // 
            this.xpVenta.ObjectType = typeof(GestorFactura.bdventa.Venta);
            this.xpVenta.Session = this.unitOfWork1;
            // 
            // txtEnvoiceDate
            // 
            this.txtEnvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnvoiceDate.Location = new System.Drawing.Point(571, 96);
            this.txtEnvoiceDate.Name = "txtEnvoiceDate";
            this.txtEnvoiceDate.ReadOnly = true;
            this.txtEnvoiceDate.Size = new System.Drawing.Size(201, 21);
            this.txtEnvoiceDate.TabIndex = 23;
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 628);
            this.Controls.Add(this.txtEnvoiceDate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.txtEnvoiceNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Facturas";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.Facturas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalles)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xpVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button BtnEliminarProducto;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnNuevaFactura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.TextBox txtEnvoiceNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDetalles;
        private DevExpress.Xpo.UnitOfWork unitOfWork1;
        private DevExpress.Xpo.XPCollection xpDetalleVenta;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colsubtotal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnFirst;
        private DevExpress.Xpo.XPCollection xpVenta;
        private System.Windows.Forms.TextBox txtEnvoiceDate;
    }
}