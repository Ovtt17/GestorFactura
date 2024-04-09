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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            slbHour.Text = "";
            slbHour.Text = currentTime;
        }

        private void OrdenFactura_Click(object sender, EventArgs e)
        {
            Facturas facturas = new Facturas
            {
                MdiParent = this
            };
            facturas.Show();
        }
    }
}
