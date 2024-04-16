using DevExpress.Xpo;
using GestorFactura.bdventa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorFactura
{
    public partial class AddProduct : Form
    {
        private UnitOfWork unitOfWork;
        public AddProduct(UnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            xpProduct.Session = unitOfWork;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Facturas facturas = Owner as Facturas;
            Producto product = (Producto)searchLookUpEdit1View.GetFocusedRow();
            if (product == null)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            } else if (txtAmount.Text == "" || txtAmount.Text == "0")
            {
                MessageBox.Show("Ingrese una cantidad valida");
                return;
            }
            Detalle saleDetails = new Detalle(unitOfWork)
            {
                cantidad = Convert.ToInt32(txtAmount.Text),
                producto_idproducto = product,
                subtotal = Convert.ToSingle(txtAmount.Text) * product.precio
            };
            saleDetails.Save();
            facturas.sale.Detalles.Add(saleDetails);
            facturas.gridControl1.DataSource = facturas.sale.Detalles;
            Close();
        }
    }
}
