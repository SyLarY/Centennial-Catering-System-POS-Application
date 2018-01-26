using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centennial_Catering_System
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }


        //MenuStrip Item Function
        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void mANAGEMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Management m1 = new Management();
            m1.Show();
        }

        private void customerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer c1 = new Customer();
            c1.Show();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report r1 = new Report();
            r1.Show();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            //SaleReportDataContext dataContext = new SaleReportDataContext();
            //dgvReport.DataSource = from tblOrderItem in dataContext.tblOrderItems
            //                       join tblOrder in dataContext.tblOrders on tblOrderItem.OrderID equals tblOrder.OrderID
            //                       join tblItem in dataContext.tblItems on tblOrderItem.ItemID equals tblItem.ItemID
            //                       select new
            //                       {

            //                           ProductName = tblItem.ProductName,
            //                           UnitPrice = tblItem.Price,
            //                           Quantity = tblOrderItem.Quantity,
            //                           Total = tblOrder.Amount
            //                       };
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = null;
            dgvReport.Update();
            dgvReport.Refresh();
            SaleReportDataContext dataContext = new SaleReportDataContext();
            dgvReport.DataSource = from tblOrderItem in dataContext.tblOrderItems
                                   join tblOrder in dataContext.tblOrders on tblOrderItem.OrderID equals tblOrder.OrderID
                                   join tblItem in dataContext.tblItems on tblOrderItem.ItemID equals tblItem.ItemID
                                   select new
                                   {

                                       ProductName = tblItem.ProductName,
                                       UnitPrice = tblItem.Price,
                                       Quantity = tblOrderItem.Quantity,
                                       Total = tblOrder.Amount
                                   };
        }
    }
}
