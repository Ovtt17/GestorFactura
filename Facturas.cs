using DevExpress.Data.Filtering;
using GestorFactura.bdventa;
using System;
using System.Collections;
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
    public partial class Facturas : Form
    {
        List<int> saleIdList;
        int currentSaleId = 1;
        // convierte la cadena en una constante para que no se pueda modificar
        const string totalToPayTitle = "TOTAL A PAGAR: ";
        public Facturas()
        {
            InitializeComponent();
        }
        private void Facturas_Load(object sender, EventArgs e)
        {
            GetSalesId();
            GetSaleDetails(currentSaleId);
        }

        private void GetSalesId()
        {
            saleIdList = new List<int>();
            foreach (Venta sale in xpVenta)
            {
                saleIdList.Add(sale.idventa);
            }
        }
        private void GetSaleDetails(int saleId)
        {
            currentSaleId = saleId;
            txtEnvoiceNumber.Text = saleId.ToString();
            Venta sale = (Venta) xpVenta.Lookup(saleId);
            txtClient.Text = sale.cliente_idcliente.nombre;
            txtEnvoiceDate.Text = sale.fecha.ToString();
            lbTotal.Text = totalToPayTitle + sale.monto_total.ToString();
            gridControl1.DataSource = sale.Detalles;
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            GetSaleDetails(saleIdList.First());
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            int currentIndex = saleIdList.IndexOf(currentSaleId);
            bool hasPrevious = currentIndex > 0;

            if (hasPrevious)
            {
                int previousIndex = currentIndex - 1;
                GetSaleDetails(saleIdList[previousIndex]);
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            int currentIndex = saleIdList.IndexOf(currentSaleId);
            int lastIndex = saleIdList.Count - 1; // Índice del último elemento
            bool hasNext = currentIndex < lastIndex;

            if (hasNext)
            {
                int nextIndex = currentIndex + 1;
                GetSaleDetails(saleIdList[nextIndex]);
            }
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            GetSaleDetails(saleIdList.Last());
        }

        private void BtnNuevaFactura_Click(object sender, EventArgs e)
        {
            Venta newSale = new Venta(unitOfWork1);
            txtEnvoiceNumber.Text = newSale.idventa.ToString();
            txtClient.Text = "";
            txtEnvoiceDate.Text = "";
            lbTotal.Text = totalToPayTitle;
            gridControl1.DataSource = null;

        }
    }
}
