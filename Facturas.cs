﻿using DevExpress.Data.Filtering;
using DevExpress.Utils.Extensions;
using DevExpress.XtraGrid.Views.Items.Layout;
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
        protected internal Venta sale;
        int currentSaleId;
        
        const string totalToPayTitle = "TOTAL A PAGAR: ";
        public Facturas()
        {
            InitializeComponent();
        }
        private void Facturas_Load(object sender, EventArgs e)
        {
            GetSalesId();
            GetSaleDetails(saleIdList.First());
        }

        private void GetSalesId()
        {
            saleIdList = new List<int>();
            xpVenta.Reload();
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

            searchClient.EditValue = sale.cliente_idcliente.idcliente;
            searchClient.Properties.ReadOnly = true;
            
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

        private void BtnNewEnvoice_Click(object sender, EventArgs e)
        {
            sale = new Venta(unitOfWork1)
            {
                fecha = DateTime.Today
            };
            CleanFields();
            txtEnvoiceNumber.Text = (saleIdList.Last() + 1).ToString();
            bool isScrollButtonEnabled = false;
            ChangeControlsState(isScrollButtonEnabled);
        }

        private void ChangeControlsState(bool state)
        {
            BtnFirst.Enabled = state;
            BtnBack.Enabled = state;
            BtnNext.Enabled = state;
            BtnLast.Enabled = state;
            BtnNewEnvoice.Enabled = state;

            BtnSave.Enabled = !state;
            BtnCancel.Enabled = !state;
            BtnAddProduct.Enabled = !state;
            BtnDeleteProduct.Enabled = !state;

            searchClient.Properties.ReadOnly = state;
        }

        private void CleanFields()
        {
            txtEnvoiceDate.Text = DateTime.Today.ToString();
            lbTotal.Text = totalToPayTitle;
            gridControl1.DataSource = sale.Detalles;
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(unitOfWork1);
            AddOwnedForm(addProduct);
            addProduct.ShowDialog();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            sale.Delete();  
            bool isScrollButtonEnabled = true;
            ChangeControlsState(isScrollButtonEnabled);
            GetSaleDetails(saleIdList.First());
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            Detalle saleDetail = (Detalle)gridDetalles.GetFocusedRow();
            sale.Detalles.Remove(saleDetail);
            gridControl1.RefreshDataSource();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            bool isSaleSaved = SaveSale();
            if (!isSaleSaved)
            {
                return;
            }

            bool isScrollButtonEnabled = true;
            ChangeControlsState(isScrollButtonEnabled);
            GetSalesId();
            GetSaleDetails(saleIdList.First());
        }

        private bool SaveSale()
        {
            try
            {
                if (sale.cliente_idcliente == null)
                {
                    MessageBox.Show("Seleccione un cliente");
                    return false;
                }
                else if (sale.Detalles.Count == 0)
                {
                    MessageBox.Show("Agregue al menos un producto");
                    return false;
                }
                
                int totalQuantity = 0;
                float totalAmount = 0f;

                foreach (var detail in sale.Detalles)
                {
                    totalQuantity += detail.cantidad;
                    totalAmount += detail.subtotal;
                }

                MessageBox.Show(sale.cliente_idcliente.idcliente.ToString());
                sale.cantidad = totalQuantity;
                sale.monto_total = totalAmount;
                unitOfWork1.CommitChanges();

                return true;
            } catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la factura: " + ex.Message);
                return false;
            }
        }

        private void searchClient_EditValueChanged(object sender, EventArgs e)
        {
            if (searchClient.ReadOnly == false)
            {
                Cliente cliente = (Cliente)searchLookUpEdit1View.GetFocusedRow();
                sale.cliente_idcliente = cliente;
                MessageBox.Show("El cliente es: " + sale.cliente_idcliente.idcliente);
            }
        }
    }
}