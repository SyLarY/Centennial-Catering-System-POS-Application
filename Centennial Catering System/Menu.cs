using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Centennial_Catering_System
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        //Connection String for home PC
        public static string cnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\FW 2017- 2018\COMP 212\Midterm\Centennial Catering System\Centennial Catering System\App_Data\CateringDB.mdf;Integrated Security=True";
        //Connection String for minion USB
        //public string cnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\New folder\COMP 212\Midterm\Centennial Catering System\Centennial Catering System\App_Data\CateringDB.mdf;Integrated Security=True";
        SqlConnection cn = new SqlConnection(cnStr);
        SqlCommand cmd;
        SqlDataReader reader;
        List<Items> items = new List<Items>();
        List<CartItem> billList = new List<CartItem>();
        double subtotal = 0;

        private void Menu_Load(object sender, EventArgs e)
        {
            //Load Item to relative tabControl
            LoadItems(1, tlpFood);
            LoadItems(2, tlpBeverage);
            LoadItems(3, tlpDessert);
            LoadItems(4, tlpSide);

            //Get number of orders in tblOrder
            cn.Open();
            cmd = new SqlCommand("Select Count(*) from tblOrders;", cn);
            int orderNumber = cmd.ExecuteScalar() == null? 1 : (int)cmd.ExecuteScalar() + 1;
            cn.Close();
            lbBillNO.Text = orderNumber.ToString();
        }
        
        private void LoadItems(int catID, TableLayoutPanel tpl)
        {
            List<Items> foods = new List<Items>();
            int row = 0;
            int col = 0;
            int index = 0;
            string cmdStr = string.Format("select * from tblItems where CategoryID = {0};", catID.ToString());
            SqlCommand cmd = new SqlCommand(cmdStr, cn);
            cn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Items item = new Items(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), Convert.ToDouble(reader[4]));
                foods.Add(item);
                items.Add(item);
            }
            cn.Close();

            
            foreach (Items i in foods)
            {

                Button btn = new Button();
                btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
                btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                btn.Font = new System.Drawing.Font("Agency FB", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.Image = System.Drawing.Image.FromFile(@"E:\FW 2017- 2018\COMP 212\Midterm\Centennial Catering System\Centennial Catering System\" + i.ProductImg.ToString());
                btn.Margin = new System.Windows.Forms.Padding(4);
                btn.Name = "btn" + i.ItemID;
                btn.Size = new System.Drawing.Size(156, 156);
                btn.TabIndex = index++;
                btn.Text = i.ProductName.Length >12? i.ProductName.Substring(0,13):i.ProductName;
                btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                btn.UseVisualStyleBackColor = true;
                btn.Click += new System.EventHandler(addToCart);
                if (col == 5)
                {
                    col = 0;
                    row++;
                }
                tpl.Controls.Add(btn,col++,row); 
            }
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


        private void addToCart(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string itemID = btn.Name.Substring(3);
            Items item = items.Find(i => i.ItemID == itemID);
            CartItem cartItem = new CartItem(); 

            if(dgvBill.Rows.Count == 0 )
            {
                cartItem.Item = item;
                cartItem.Quantity = 1;
                billList.Add(cartItem);
                dgvBill.Rows.Add(btn.Image, item.ProductName, 1, item.Price);
                subtotal += item.Price;
            }
            else
            {
                int index = billList.FindIndex(row => row.Item.ProductName == item.ProductName);
                if (index != -1)
                {
                    int qty = Convert.ToInt32(dgvBill.Rows[index].Cells[2].Value);
                    dgvBill.Rows[index].Cells[2].Value = qty + 1;
                    billList[index].Quantity = qty + 1;
                    subtotal += item.Price;
                }
                else
                {
                    cartItem.Item = item;
                    cartItem.Quantity = 1;
                    billList.Add(cartItem);
                    dgvBill.Rows.Add(btn.Image, item.ProductName, 1, item.Price);
                    subtotal += item.Price;
                }
            }
            showPrice();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
           foreach(DataGridViewRow r in dgvBill.SelectedRows)
            {
                int qty = Convert.ToInt32(r.Cells[2].Value);
                double price = Convert.ToDouble(r.Cells[3].Value);
                dgvBill.Rows.RemoveAt(r.Index);
                subtotal -= qty * price;
                var cart = billList.SingleOrDefault(x => x.Item.ProductName == r.Cells[1].Value.ToString());
                if(cart != null)
                {
                    billList.Remove(cart);
                }
                showPrice();
            }
        }

        private void showPrice()
        {
            lbSubtotal.Text = subtotal.ToString("$0.00");
            lbTax.Text = (subtotal * 0.13).ToString("$0.00");
            lbTotal.Text = (subtotal * 1.13).ToString("$0.00");
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow r in dgvBill.SelectedRows)
            {
                if(r.Cells[2].Value.ToString() == "1")
                {

                    btnRemove_Click(sender, e);
                }
                else
                {
                    int index = billList.FindIndex(row => row.Item.ProductName == r.Cells[1].Value.ToString());
                    int qty = Convert.ToInt32(r.Cells[2].Value);
                    r.Cells[2].Value = qty - 1;
                    billList[index].Quantity = qty - 1;
                    subtotal -= Convert.ToDouble(r.Cells[3].Value);
                    showPrice();
                }
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if(billList.Count == 0)
            {
                MessageBox.Show("No Item In the Cart!");
            }
            else
            {
                //Save Order info to tblOrders
                cn.Open();
                DateTime time = DateTime.Now;
                cmd = new SqlCommand("Insert Into tblOrders Values(@orderId,@cusId, @orderDate, @amount);", cn);
                cmd.Parameters.AddWithValue("@orderId", lbBillNO.Text);
                cmd.Parameters.AddWithValue("@cusId", tbxCusID.Text == "" ? DBNull.Value.ToString() : tbxCusID.Text);
                cmd.Parameters.AddWithValue("@orderDate", time.ToString("yyyy-MM-dd H:mm:ss"));
                cmd.Parameters.AddWithValue("@amount", (subtotal*1.13));
                cmd.ExecuteNonQuery();
                cn.Close();

                //Save order item to tblOrderItems
                cn.Open();
                foreach(CartItem orderitem in billList)
                {
                    
                    cmd = new SqlCommand("Insert Into tblOrderItems Values(@oid,@oiid,@itemid,@quantity,@total);",cn);
                    cmd.Parameters.AddWithValue("@oid", lbBillNO.Text);
                    cmd.Parameters.AddWithValue("oiid", billList.IndexOf(orderitem));
                    cmd.Parameters.AddWithValue("@itemid", orderitem.Item.ItemID);
                    cmd.Parameters.AddWithValue("@quantity", orderitem.Quantity);
                    cmd.Parameters.AddWithValue("@total", (orderitem.Item.Price * orderitem.Quantity));
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
                MessageBox.Show("Order Complete!");
            }
        }

        private void btnCusIDSearch_Click(object sender, EventArgs e)
        {
            if(tbxCusID.Text == "")
            {
                lbCusIDResult.Text = "Please enter a value!";
            }
            else
            {
                cn.Open();
                cmd = new SqlCommand("select * from tblCustomers where CustomerID=" + tbxCusID.Text, cn);
                if(cmd.ExecuteScalar() == null)
                {
                    lbCusIDResult.ForeColor = Color.Crimson;
                    lbCusIDResult.Text = "Customer Record Not Found!";
                }
                else
                {
                    lbCusIDResult.ForeColor = Color.ForestGreen;
                    lbCusIDResult.Text = "Customer Record Found!";
                }
                cn.Close();
            }
        }
    }
}
